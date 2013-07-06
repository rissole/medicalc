Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class BattleMember

    'properties
    Private curHp, maxHp As Integer
    'lvl can be ?? for example, so string
    Private mname, lvl As String
    Protected bDead As Boolean
    Protected teamID As Byte
    Protected membID As UInteger
    Protected battle As Battle
    'membID manager
    Protected Shared maxMembID As Integer = -1
    Protected actID As Integer = -1
    Public Effects As New List(Of BattleEffect)

    Property MembName() As String
        Get
            Return mname
        End Get
        Set(ByVal value As String)
            mname = value
            Label1.Text = mname.ToUpper()
        End Set
    End Property
    Property MembLevel() As String
        Get
            Return lvl
        End Get
        Set(ByVal value As String)
            lvl = value
            Label2.Text = lvl
        End Set
    End Property
    Property MembHpCur() As Integer
        Get
            Return curHp
        End Get
        Set(ByVal value As Integer)
            If (bDead) Then Return
            curHp = value
            If (Not bDead And curHp <= 0) Then Die()
            If (curHp < 0) Then curHp = 0
            If (curHp > maxHp) Then curHp = maxHp
            Label3.Text = "HP " & curHp.ToString() & "/" & maxHp.ToString()
        End Set
    End Property
    Property MembHpMax() As Integer
        Get
            Return maxHp
        End Get
        Set(ByVal value As Integer)
            If (value >= 0) Then
                maxHp = value
                Label3.Text = "HP " & curHp.ToString() & "/" & maxHp.ToString()
            Else
                Throw New Exception("Cannot set max HP negative")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Creating a new NPC member
    ''' </summary>
    ''' <param name="MembName"></param>
    ''' <param name="MembLevel"></param>
    ''' <param name="MembHP"></param>
    ''' <param name="tID"></param>
    ''' <param name="srcBtl"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal MembName As String, ByVal MembLevel As String, ByVal MembHP As Integer, ByVal tID As Byte, ByRef srcBtl As Battle)
        InitializeComponent()
        If (maxMembID = -1) Then
            'initialise maxMembID
            Dim mID = New SQLite.SQLiteCommand("SELECT MAX(id) FROM battle_members", Common.sqLiteCon).ExecuteScalar()
            If (IsDBNull(mID)) Then maxMembID = 0 Else maxMembID = mID + 1
        End If

        Me.MembName = MembName
        Me.MembLevel = MembLevel
        MembHpMax = MembHP
        MembHpCur = MembHP
        teamID = tID
        battle = srcBtl
        membID = maxMembID
        maxMembID += 1
    End Sub

    ''' <summary>
    ''' Loading a member from the database
    ''' </summary>
    ''' <param name="membID"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal membID As UInteger, ByVal srcBtl As Battle)
        InitializeComponent()
        Me.battle = srcBtl
        LoadNPCInfoByMembID(membID)
    End Sub

    Protected Sub LoadEffects()
        Dim effQ = New SQLiteCommand("SELECT * FROM battle_effects WHERE member_id=" & membID, Common.sqLiteCon).ExecuteReader()
        While (effQ.Read())
            Dim effect As BattleEffect = New BattleEffect(effQ.Item("name"), effQ.Item("turns_left"), Nothing, Me, effQ.Item("id"))
            Effects.Add(effect)
        End While
    End Sub

    ''' <summary>
    ''' Loads the BattleMember's fields with information from the DB.
    ''' </summary>
    ''' <param name="membID">ID of member.</param>
    ''' <remarks></remarks>
    Private Sub LoadNPCInfoByMembID(ByVal membID As UInteger)
        Dim info = New SQLiteCommand("SELECT team_id, name, MembLevel, MembHpCur, MembHpMax, MembPowerCur, MembPowerMax, player_id FROM battle_members WHERE id=" & membID, Common.sqLiteCon)
        Dim infoQ = info.ExecuteReader()
        If (Not infoQ.Read()) Then
            MsgBox("Tried to create non existant member #" & membID, MsgBoxStyle.Critical, "Error")
            Dispose()
            Return
        End If
        Me.membID = membID
        teamID = infoQ.GetByte(0)
        MembName = infoQ.GetString(1)
        MembLevel = infoQ.GetString(2)
        MembHpMax = infoQ.GetInt32(4)
        MembHpCur = infoQ.GetInt32(3)
        infoQ.Close()
        info.CommandText = "SELECT * FROM battle_actions WHERE member_id=" & membID
        Dim res = info.ExecuteReader()
        If (res.Read()) Then
            actID = res.Item("id")
            FlagAction(actID, BattleNPCAction.GenerateActionText(res.Item("damage"), res.Item("targettype"), res.Item("targetextra")))
        End If
        res.Close()
        LoadEffects()
    End Sub

    ''' <summary>
    ''' NEVER USE THIS CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overridable Sub BTN_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Edit.Click
        BattleCreateNPC.edit(Me)
    End Sub

    Protected Overridable Sub BTN_Action_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Action.Click
        BattleNPCAction.open(Me, actID)
    End Sub

    ''' <summary>
    ''' Saves the BattleMember to the database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub Save()
        Dim q = New SQLiteCommand(Common.sqLiteCon)
        q.CommandText = "BEGIN TRANSACTION;" & vbNewLine & "DELETE FROM battle_members WHERE id=" & membID & ";" & vbNewLine
        q.CommandText &= "INSERT INTO battle_members (id, battle_id, team_id, player_id, name, MembLevel, MembHpCur, MembHpMax, MembPowerCur, MembPowerMax) "
        q.CommandText &= "VALUES (@id, @bid, @tid, -1, @mname, @mlvl, @mhpc, @mhpm, @mpowc, @mpowm);" & vbNewLine & "COMMIT;"
        q.Parameters.AddWithValue("@id", GetID())
        q.Parameters.AddWithValue("@bid", GetBattleID())
        q.Parameters.AddWithValue("@tid", GetTeamID())
        q.Parameters.AddWithValue("@mname", MembName)
        q.Parameters.AddWithValue("@mlvl", MembLevel)
        q.Parameters.AddWithValue("@mhpc", MembHpCur)
        q.Parameters.AddWithValue("@mhpm", MembHpMax)
        q.Parameters.AddWithValue("@mpowc", 0)
        q.Parameters.AddWithValue("@mpowm", 0)
        q.ExecuteNonQuery()
        SaveEffects()
    End Sub

    Protected Sub SaveEffects()
        Dim q = New SQLiteCommand("DELETE FROM battle_effects WHERE member_id=" & membID, Common.sqLiteCon).ExecuteNonQuery()
        For Each e As BattleEffect In Effects
            e.Save()
        Next
    End Sub

    Public Sub FlagAction(ByVal actID As Integer, Optional ByVal actText As String = "")
        If (actID > -1) Then
            Me.MouseOverTip.SetToolTip(Me.BTN_Action, actText)
            BTN_Action.ForeColor = Color.Crimson
        Else
            Me.MouseOverTip.SetToolTip(Me.BTN_Action, "Actions")
            BTN_Action.ForeColor = Color.DodgerBlue
            Dim p = New SQLiteCommand("DELETE FROM battle_actions WHERE id=" & Me.actID, Common.sqLiteCon).ExecuteNonQuery()
        End If
        Me.actID = actID
    End Sub

    Public Function GetTeamID() As Byte
        Return teamID
    End Function

    Public Function GetBattle() As Battle
        Return battle
    End Function

    ''' <summary>
    ''' Returns the member ID.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetID() As UInteger
        Return membID
    End Function

    Public Function GetBattleID() As UInteger
        Return battle.GetID()
    End Function

    Public Overridable Function IsPlayer() As Boolean
        Return False
    End Function

    Public Function GetActionID() As Integer
        Return actID
    End Function

    Public Overloads Sub DoNPCAction(ByRef target As BattleMember, ByVal damageFormula As String, ByVal descFormat As String)
        If (IsPlayer()) Then
            Throw New Exception("Calling DoNPCAction from BattlePlayer")
        End If
        Dim damage As UInteger = 0
        If (Not Integer.TryParse(damageFormula, damage)) Then
            'then it's a range formula...
            Dim rand As New Random()
            Dim rangeReg As New Regex("^(\d+) *\| *(\d+)$")
            Dim match As Match = rangeReg.Match(damageFormula)
            If (Not match.Success) Then Throw New Exception("Invalid formula.")
            Dim minDamage, maxDamage As Integer
            minDamage = Math.Min(Integer.Parse(match.Groups(1).Value), Integer.Parse(match.Groups(2).Value))
            maxDamage = Math.Max(Integer.Parse(match.Groups(1).Value), Integer.Parse(match.Groups(2).Value))
            damage = rand.Next(minDamage, maxDamage)
        End If

        Dim description As String = descFormat

        If (target IsNot Nothing) Then
            Common.HardReplace(description, "%t", target.MembName)
        Else
            Common.HardReplace(description, "%t", "Nothing")
        End If
        Common.HardReplace(description, "%d", damage.ToString())

        battle.Log.AddAction(membID, description)

        If (target Is Nothing) Then
            Return
        End If
        If (target.IsDead()) Then
            battle.Log.AddAction(membID, "The target was already dead, and could not be attacked!")
            Return
        End If

        damage = target.ApplyReductions(damage)
        target.MembHpCur -= damage
        If (target.IsDead()) Then
            battle.Log.AddAction(membID, target.MembName & " died.")
        End If
    End Sub

    Public Overloads Sub DoNPCAction(ByRef targets As IEnumerable(Of BattleMember), ByVal damageFormula As String, ByVal descFormat As String)
        For Each m As BattleMember In targets
            DoNPCAction(m, damageFormula, descFormat)
        Next
    End Sub

    Public Overridable Function ApplyReductions(ByVal baseDamage As Integer) As Integer
        Return baseDamage
    End Function

    Public Function IsDead() As Boolean
        Return bDead
    End Function

    ''' <summary>
    ''' Marks the Member as dead. Does nothing if already dead.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Die()
        If (bDead = True) Then
            Return
        End If

        bDead = True
        MembHpCur = 0

        For Each ctrl As Control In Panel1.Controls
            If (Not ctrl.Equals(BTN_Edit)) Then
                ctrl.Enabled = False
            End If
        Next
    End Sub

    ''' <summary>
    ''' Revives the BattleMember, does nothing if Member already alive
    ''' </summary>
    ''' <param name="hp">HP to revive with, must be > 0</param>
    ''' <remarks></remarks>
    Public Sub Revive(ByVal hp As Integer)
        If (bDead = False) Then
            Return
        End If

        bDead = False
        MembHpCur = hp

        For Each ctrl As Control In Panel1.Controls
            ctrl.Enabled = True
        Next
    End Sub

    Public Sub DecrementEffects()
        Dim toremove As New List(Of BattleEffect)
        For Each e As BattleEffect In Effects
            If (e.DecrementTurn()) Then
                toremove.Add(e)
            End If
        Next
        For Each e As BattleEffect In toremove
            e.Remove()
            battle.Log.AddAction(membID, MembName & " lost the effect of " & e.GetName())
        Next
    End Sub

End Class
