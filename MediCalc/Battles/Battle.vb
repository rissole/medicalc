Imports System.Data.SQLite

Public Class Battle

    Public Shared ReadOnly MAX_MEMBERS As UInteger = 15
    Private battleName As String
    Private team(2) As List(Of BattleMember)
    Private teamGBX(2) As GroupBox
    Private bID As UInteger
    Public Log As BattleLog
    'Public eventsWindow As BattleCustomEvent = Nothing

    ''' <summary>
    ''' Saves battle to DB.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        Dim q = New SQLiteCommand(Common.sqLiteCon)
        q.CommandText = "BEGIN TRANSACTION;" & vbNewLine & "DELETE FROM battles WHERE id=" & bID & ";" & vbNewLine
        q.CommandText &= "INSERT INTO battles (id, name, teamA, teamB) VALUES (@id, @name, @a, @b);" & vbNewLine & "COMMIT;"
        q.Parameters.AddWithValue("@id", bID)
        q.Parameters.AddWithValue("@name", battleName)
        Dim teamStringA(MAX_MEMBERS - 1) As String
        For i As Integer = 0 To MAX_MEMBERS - 1
            If (i < team(0).Count) Then
                teamStringA(i) = team(0)(i).GetID().ToString()
            Else
                teamStringA(i) = "-1"
            End If
        Next
        Dim teamStringB(MAX_MEMBERS - 1) As String
        For i As Integer = 0 To MAX_MEMBERS - 1
            If (i < team(1).Count) Then
                teamStringB(i) = team(1)(i).GetID().ToString()
            Else
                teamStringB(i) = "-1"
            End If
        Next
        q.Parameters.AddWithValue("@a", String.Join(",", teamStringA))
        q.Parameters.AddWithValue("@b", String.Join(",", teamStringB))
        q.ExecuteNonQuery()
        'Now save each battle member
        For i As Integer = 0 To 1
            For Each memb As BattleMember In team(i)
                memb.Save()
            Next
        Next
    End Sub

    Public Sub New(ByVal name As String, ByVal ID As Integer)
        InitializeComponent()
        Me.Text = "Battle: " + name

        battleName = name
        team(0) = New List(Of BattleMember)(MAX_MEMBERS)
        team(1) = New List(Of BattleMember)(MAX_MEMBERS)
        teamGBX(0) = GBX_TeamA
        teamGBX(1) = GBX_TeamB
        Battles.openNames.Add(name)
        If (ID <> -1) Then
            bID = ID
            Save()
        Else
            Dim infoc = New SQLiteCommand("SELECT * FROM battles WHERE name=@name", Common.sqLiteCon)
            infoc.Parameters.AddWithValue("@name", name)
            Dim infoQ = infoc.ExecuteReader()
            infoQ.Read() 'this is never gonna be null.
            bID = infoQ.GetInt32(0)
            For i As Integer = 0 To 1
                Dim ids() As String = infoQ.GetString(i + 2).Split(",")
                For Each sid As String In ids
                    Dim _id As Integer = Integer.Parse(sid)
                    If (_id = -1) Then Continue For
                    Dim m As BattleMember
                    Dim isPlayer As Boolean = IIf(New SQLiteCommand("SELECT player_id FROM battle_members WHERE id=" & _id, Common.sqLiteCon).ExecuteScalar() <> -1, True, False)
                    If (isPlayer) Then
                        m = New BattlePlayer(_id, Me)
                    Else
                        m = New BattleMember(_id, Me)
                    End If
                    m.Location = New Point(7, 45 + 37 * team(i).Count)
                    teamGBX(i).Controls.Add(m)
                    team(i).Add(m)
                Next
            Next
        End If

        Log = BattleLog.open(Me)
    End Sub

    Public Sub ClosingBattle(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Dim okToClose As Boolean = True
        For Each member As BattleMember In BattleCreateNPC.openEdits
            If (member.GetBattleID() = GetID()) Then okToClose = False
        Next
        For Each member As BattleMember In BattleNPCAction.openWindows
            If (member.GetBattleID() = GetID()) Then okToClose = False
        Next
        For Each member As BattleMember In BattlePlayerEdit.openEdits
            If (member.GetBattleID() = GetID()) Then okToClose = False
        Next
        For Each member As BattleMember In BattlePlayerAction.openWindows
            If (member.GetBattleID() = GetID()) Then okToClose = False
        Next
        If (Not okToClose) Then
            MsgBox("There is still a member being edited. Make sure all windows opened from this battle are closed.", MsgBoxStyle.Information, "Error")
            e.Cancel = True
            Return
        End If
        Battles.openNames.Remove(battleName)
        Log.Close()
        'If (Not eventsWindow Is Nothing) Then eventsWindow.Close()
        Save()
    End Sub

    Private Sub BTN_AddPlayer_Click(ByVal sender As Control, ByVal e As System.EventArgs) Handles BTN_A_AddPlayer.Click, BTN_B_AddPlayer.Click
        Dim tID As Byte = IIf(sender.Name.Contains("BTN_A"), 0, 1)
        If (team(tID).Count = MAX_MEMBERS) Then
            MsgBox("This team is full", MsgBoxStyle.Information, "Error")
            Return
        End If
        Dim listOfNames(1) As String
        Dim listOfValues(1) As Object
        Dim nameQ = New SQLiteCommand("SELECT name, id FROM players", Common.sqLiteCon)
        Dim nameQuery = nameQ.ExecuteReader()
        Dim count As Integer = 0
        While (nameQuery.Read())
            If (Not nameQuery.IsDBNull(0)) Then
                listOfNames(count) = nameQuery.GetString(0)
                listOfValues(count) = nameQuery.GetInt32(1)
                count += 1
                ReDim Preserve listOfNames(count)
            End If
        End While
        ReDim Preserve listOfNames(count - 1)
        nameQuery.Close()
        SimpleSelection.open("PlayerChoice" & tID, listOfNames, listOfValues, AddressOf HandleSelection)
    End Sub

    Private Sub BTN_AddNPC_Click(ByVal sender As Control, ByVal e As System.EventArgs) Handles BTN_A_AddNPC.Click, BTN_B_AddNPC.Click
        Dim tID As Byte = IIf(sender.Name.Contains("BTN_A"), 0, 1)
        If (team(tID).Count = MAX_MEMBERS) Then
            MsgBox("This team is full", MsgBoxStyle.Information, "Error")
            Return
        End If
        BattleCreateNPC.open(tID, Me)
    End Sub

    Private Sub HandleSelection(ByVal choiceName As String, ByVal choiceInfo As AssocComboBox.SelectionInfo)
        If (choiceInfo.value Is Nothing) Then
            Return
        End If
        If (choiceName.Contains("PlayerChoice")) Then
            Dim id As UInteger = choiceInfo.value
            If (ContainsPlayer(id)) Then
                MsgBox("That player is already in the battle.", MsgBoxStyle.Exclamation, "Error")
                Return
            Else
                AddMember(Byte.Parse(choiceName.Substring(12)), id)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Adds a player with ID plID to the specified team
    ''' </summary>
    ''' <param name="tID">Strictly 0 or 1 only, the team to add to</param>
    ''' <param name="plID">The ID of the player</param>
    ''' <remarks></remarks>
    Public Overloads Sub AddMember(ByVal tID As Byte, ByVal plID As Integer)
        Dim m As BattlePlayer = New BattlePlayer(plID, tID, Me)
        m.Location = New Point(7, 45 + 37 * team(tID).Count)
        teamGBX(tID).Controls.Add(m)
        team(tID).Add(m)
        Save()
    End Sub

    ''' <summary>
    ''' Adds an NPC with the specified parameters to the specified team
    ''' </summary>
    ''' <param name="tID">Strictly 0 or 1 only, the team to add to.</param>
    ''' <param name="name">NPC name</param>
    ''' <param name="level">NPC level</param>
    ''' <param name="HP">NPC HP (positive integer)</param>
    ''' <remarks></remarks>
    Public Overloads Sub AddMember(ByVal tID As Byte, ByVal name As String, ByVal level As String, ByVal HP As UInteger)
        Dim m As BattleMember = New BattleMember(name, level, HP, tID, Me)
        m.Location = New Point(7, 45 + 37 * team(tID).Count)
        teamGBX(tID).Controls.Add(m)
        team(tID).Add(m)
        Save()
    End Sub

    Public Function ContainsPlayer(ByVal id As UInteger) As Boolean
        For i As Integer = 0 To 1
            For Each m As BattleMember In team(i)
                If (Not m.IsPlayer()) Then Continue For
                If (DirectCast(m, BattlePlayer).GetPlayerID() = id) Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Public Function GetID() As UInteger
        Return bID
    End Function

    Public Sub DeleteMember(ByVal id As UInteger)
        For i As Integer = 0 To 1
            For Each m As BattleMember In team(i)
                If (m.GetID() = id) Then
                    ' gotta clear all actions that are targeting this, now removed, member
                    Dim actQ = New SQLiteCommand("SELECT * FROM battle_actions WHERE targettype=1 AND targetextra=" & id, Common.sqLiteCon).ExecuteReader()
                    While (actQ.Read())
                        Dim actorID As Integer = actQ.Item("member_id")
                        GetMemberByID(actorID).FlagAction(-1)
                        MsgBox("The action for member ID #" & actorID & " was cleared because they targetted the removed Member.", MsgBoxStyle.Exclamation, "Warning")
                    End While
                    actQ.Close()
                    Dim r = New SQLiteCommand("BEGIN TRANSACTION; DELETE FROM battle_members WHERE id=" & id & "; ", Common.sqLiteCon)
                    r.CommandText &= "DELETE FROM battle_actions WHERE member_id=" & id & ";"
                    r.CommandText &= "DELETE FROM battle_actions WHERE targettype=1 AND targetextra=" & id & "; "
                    r.CommandText &= "DELETE FROM battle_effects WHERE member_id=" & id & "; COMMIT;"
                    r.ExecuteNonQuery()
                    teamGBX(i).Controls.Remove(m)
                    m.Dispose()
                    team(i).Remove(m)
                    RefreshPositions()
                    Return
                End If
            Next
        Next
    End Sub

    Public Sub RefreshPositions()
        For i As Integer = 0 To 1
            For j = 0 To team(i).Count - 1
                team(i)(j).Location = New Point(7, 45 + 37 * j)
            Next
        Next
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        Me.Close()
    End Sub

    Public Function GetTeamMember(ByVal tid As Byte, ByVal idx As UInteger) As BattleMember
        Return team(tid)(idx)
    End Function

    Public Function GetTeamMembersCount(ByVal tid As Byte) As UInteger
        Return team(tid).Count
    End Function

    ''' <summary>
    ''' Returns a BattleMember in this battle with the specified ID.
    ''' </summary>
    ''' <param name="id">Member ID of Member to find</param>
    ''' <returns>The BattleMember if found, otherwise Nothing</returns>
    ''' <remarks></remarks>
    Public Function GetMemberByID(ByVal id As UInteger) As BattleMember
        For i As Integer = 0 To 1
            For Each member As BattleMember In team(i)
                If (member.GetID() = id) Then
                    Return member
                End If
            Next
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Gets a random member from the specified team.
    ''' </summary>
    ''' <param name="tid">The team</param>
    ''' <returns>A BattleMember if the team is not empty, Nothing otherwise.</returns>
    ''' <remarks></remarks>
    Public Function GetRandomMember(ByVal tid As Byte) As BattleMember
        If (team(tid).Count = 0) Then
            Return Nothing
        End If
        Dim rand As New Random()
        Dim idx As UInteger = rand.Next(0, team(tid).Count - 1)
        Return team(tid)(idx)
    End Function

    Private Sub AdjustPosition(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Move
        Log.Location = New Point(Location.X + Width + 5, Location.Y)
    End Sub

    'Private Sub BTN_AddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    eventsWindow = BattleCustomEvent.open(Me)
    'End Sub

    Private Sub BTN_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Log.Click
        Log.Visible = (Not Log.Visible)
    End Sub

    Private Sub BTN_TurnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TurnEnd.Click
        If (MsgBox("Are you absolutely sure you want to go to the next turn? This can't be undone.", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmation") = MsgBoxResult.No) Then
            Return
        End If
        TurnEnd()
    End Sub

    Public Sub TurnEnd()
        'prioritise each action: players first sorted by agi (highest agi = first), then npcs in whatever order.
        'interpret each action: stats modified, deaths...

        'list of all battle members on either team
        Dim mems As New List(Of BattleMember)

        'initially, get just players, then sort by P_Stat(1) (agi)
        For i As Integer = 0 To 1
            For Each b As BattleMember In team(i)
                If (b.IsPlayer()) Then
                    mems.Add(DirectCast(b, BattlePlayer))
                End If
            Next
        Next

        'sort!! these are definitely battleplayers so calm down.
        mems.Sort(New Comparison(Of BattleMember)(AddressOf AgiSortCompare))

        'now add NPCs like nothing ever happened
        For i As Integer = 0 To 1
            For Each b As BattleMember In team(i)
                If (Not b.IsPlayer()) Then
                    mems.Add(b)
                End If
            Next
        Next

        ' now mems is a sorted list of members (in order of turn!)

        For Each m As BattleMember In mems
            m.DecrementEffects()
        Next
        For Each m As BattleMember In mems
            EvalAction(m)
            m.FlagAction(-1)
        Next

        Log.WriteToLog()
        GenerateWindow.open(Log.Format() & vbNewLine & BattleLog.GetTeamStatus(team(0), False) & BattleLog.GetTeamStatus(team(1), True))
        Log.Clear()

        Save()
    End Sub

    ''' <summary>
    ''' Agility sorter.
    ''' </summary>
    ''' <param name="xm">MUST BE PLAYER</param>
    ''' <param name="ym">MUST BE PLAYER</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function AgiSortCompare(ByVal xm As BattleMember, ByVal ym As BattleMember) As Integer
        Dim x As BattlePlayer = DirectCast(xm, BattlePlayer)
        Dim y As BattlePlayer = DirectCast(ym, BattlePlayer)
        Dim xv As Integer = x.GetStat(BattlePlayer.STAT_AGI)
        Dim yv As Integer = y.GetStat(BattlePlayer.STAT_AGI)
        If (xv < yv) Then
            Return 1
        ElseIf (xv = yv) Then
            Return 0
        Else
            Return -1
        End If
    End Function



    ''' <summary>
    ''' Evaluates this player's action for the current turn of this battle.
    ''' </summary>
    ''' <param name="mem"></param>
    ''' <remarks></remarks>
    Public Sub EvalAction(ByRef mem As BattleMember)
        If (mem.IsDead() And mem.GetActionID() <> -1) Then
            Log.AddAction(mem.GetID(), mem.MembName & " was dead and could not perform their action.")
            Return
        ElseIf (Not mem.IsDead() And mem.GetActionID() = -1) Then
            Log.AddAction(mem.GetID(), mem.MembName & " did nothing.")
            Return
        ElseIf (mem.GetActionID() = -1) Then
            Return
        End If

        Dim rand As New Random()
        Dim infoQ = New SQLiteCommand("SELECT * FROM battle_actions WHERE id=" & mem.GetActionID(), Common.sqLiteCon).ExecuteReader()
        infoQ.Read()

        Dim ttype As Integer = infoQ.GetInt32(4)
        Dim textra As Integer = infoQ.GetInt32(5)

        'let's handle NPC stuff, relatively easy
        If (Not mem.IsPlayer()) Then
            Dim descriptionRaw As String = infoQ.GetString(2)
            Dim damageRaw As String = infoQ.GetString(3)
            Dim missChance As Decimal = infoQ.GetDecimal(8)

            If (rand.NextDouble() < missChance / 100) Then
                Log.AddAction(mem.GetID(), mem.MembName & "'s attack missed!")
                Return
            End If


            Select Case ttype
                Case BattleNPCAction.TTYPE_SINGLE
                    mem.DoNPCAction(GetMemberByID(textra), damageRaw, descriptionRaw)
                Case BattleNPCAction.TTYPE_RANDOM_ENEMY
                    mem.DoNPCAction(GetRandomMember(Common.OtherTeam(mem.GetTeamID())), damageRaw, descriptionRaw)
                Case BattleNPCAction.TTYPE_RANDOM_FRIEND
                    mem.DoNPCAction(GetRandomMember(mem.GetTeamID()), damageRaw, descriptionRaw)
                Case BattleNPCAction.TTYPE_ALL_ENEMIES
                    mem.DoNPCAction(team(Common.OtherTeam(mem.GetTeamID())), damageRaw, descriptionRaw)
                Case BattleNPCAction.TTYPE_ALL_FRIENDS
                    mem.DoNPCAction(team(mem.GetTeamID()), damageRaw, descriptionRaw)
                Case BattleNPCAction.TTYPE_NONE
                    mem.DoNPCAction(CType(Nothing, BattleMember), damageRaw, descriptionRaw)
            End Select

        Else
            'player
            Dim PMem As BattlePlayer = DirectCast(mem, BattlePlayer)
            Dim atype As Integer = infoQ.GetInt32(6)
            Dim aextra As Integer = infoQ.GetInt32(7)

            Select Case ttype
                Case BattlePlayerAction.TTYPE_SINGLE
                    PMem.DoPlayerAction(GetMemberByID(textra), atype, aextra)
                Case BattlePlayerAction.TTYPE_ALL_ENEMIES
                    PMem.DoPlayerAction(team(Common.OtherTeam(mem.GetTeamID())), atype, aextra)
                Case BattlePlayerAction.TTYPE_ALL_FRIENDS
                    PMem.DoPlayerAction(team(mem.GetTeamID()), atype, aextra)
            End Select

        End If

    End Sub

End Class