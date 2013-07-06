Public Class BattleLog

    Private battle As Battle

    Private memberActions As Dictionary(Of UInteger, String)
    Public Shared ReadOnly doubleLine As String = vbNewLine & vbNewLine

    ''' <summary>
    ''' Opens the battle log.
    ''' </summary>
    ''' <param name="battle">The battle that this logs.</param>
    ''' <remarks></remarks>
    Public Shared Function open(ByRef battle As Battle) As BattleLog
        Dim m As New BattleLog(battle)
        m.Location = New Point(battle.Location.X + battle.Width + 5, battle.Location.Y)
        m.Show()
        Return m
    End Function

    Private Sub New(ByRef battle As Battle)
        InitializeComponent()

        Me.battle = battle
        memberActions = New Dictionary(Of UInteger, String)
    End Sub

    Private Sub Write(ByVal text As String)
        RTB_Log.AppendText(text)
    End Sub

    Private Sub Log(ByVal text As String)
        Write(text & vbNewLine)
    End Sub

    Public Sub AddAction(ByVal membID As UInteger, ByVal actionText As String)
        If (memberActions.ContainsKey(membID)) Then
            memberActions(membID) &= actionText & vbNewLine
        Else
            memberActions.Add(membID, actionText & vbNewLine)
        End If
    End Sub

    Public Function Format() As String
        Dim formatted As String = ""
        For Each action As KeyValuePair(Of UInteger, String) In memberActions
            formatted &= action.Value & vbNewLine
        Next
        Return formatted
    End Function

    Public Sub WriteToLog()
        Write(Format())
    End Sub

    Public Sub Clear()
        memberActions.Clear()
        Log("--------------------------------------")
    End Sub

    Public Shared Function GetMemberStatus(ByVal m As BattleMember) As String
        Dim status As String = ""
        status &= m.MembName & ":" & vbNewLine
        status &= "Level: " & m.MembLevel & vbNewLine
        status &= "HP: " & m.MembHpCur & "/" & m.MembHpMax & IIf(m.IsDead(), " (DEAD)", "") & vbNewLine
        If (m.IsPlayer()) Then
            Dim Pm As BattlePlayer = DirectCast(m, BattlePlayer)
            status &= Pm.GetPowerType() & ": " & Pm.MembPowerCur & "/" & Pm.MembPowerMax
        End If
        Return status
    End Function

    'Public Sub LoadCustomEvents()
    '    Dim eventQ = New SQLite.SQLiteCommand("SELECT * FROM battle_events WHERE battle_id=" & battle.GetID(), Common.sqLiteCon).ExecuteReader()
    '    While (eventQ.Read())
    '        If (eventQ.Item("isBefore") = 0) Then
    '            preActionText &= eventQ.Item("event").ToString() & vbNewLine
    '        Else
    '            postActionText &= eventQ.Item("event").ToString() & vbNewLine
    '        End If
    '    End While
    '    eventQ.Close()
    'End Sub

    Public Shared Function GetTeamStatus(ByVal team As List(Of BattleMember), ByVal isEnemy As Boolean) As String
        Dim formatted As String = ""
        If (isEnemy) Then
            formatted &= "[color=red]-Enemies-[/color]" & doubleLine
        End If
        For Each m As BattleMember In team
            formatted &= GetMemberStatus(m) & doubleLine
        Next
        Return formatted
    End Function

End Class