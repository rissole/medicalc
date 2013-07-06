Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class BattleNPCAction

    Public Shared ReadOnly TTYPE_SINGLE As UInteger = 1
    Public Shared ReadOnly TTYPE_RANDOM_ENEMY As UInteger = 2
    Public Shared ReadOnly TTYPE_RANDOM_FRIEND As UInteger = 3
    Public Shared ReadOnly TTYPE_ALL_ENEMIES As UInteger = 4
    Public Shared ReadOnly TTYPE_ALL_FRIENDS As UInteger = 5
    Public Shared ReadOnly TTYPE_NONE As UInteger = 6

    Private id As Integer = -1
    Private bNew As Boolean = True
    Private member As BattleMember
    Private RBS_Type As RadioButtonSet
    Private Shared maxID As Integer = -1
    Public Shared openWindows As New List(Of BattleMember)

    Public Shared Sub open(ByVal member As BattleMember, Optional ByVal id As Integer = -1)
        If (openWindows.Contains(member)) Then
            Return
        End If
        openWindows.Add(member)
        Dim w As New BattleNPCAction(member, id)
        w.Show()
    End Sub

    Private Sub New(ByVal member As BattleMember, Optional ByVal id As Integer = -1)
        InitializeComponent()
        If (maxID = -1) Then
            'initialise maxID
            Dim mID = New SQLite.SQLiteCommand("SELECT MAX(id) FROM battle_actions", Common.sqLiteCon).ExecuteScalar()
            If (IsDBNull(mID)) Then maxID = 0 Else maxID = mID + 1
        End If

        If (id = -1) Then
            Me.id = maxID
            maxID += 1
            bNew = True
        Else
            Me.id = id
            bNew = False
        End If
        Me.member = member
        RBS_Type = New RadioButtonSet()
        RBS_Type.Add(RBN_Single, TTYPE_SINGLE)
        RBS_Type.Add(RBN_RandomEnemy, TTYPE_RANDOM_ENEMY)
        RBS_Type.Add(RBN_RandomFriend, TTYPE_RANDOM_FRIEND)
        RBS_Type.Add(RBN_AllEnemies, TTYPE_ALL_ENEMIES)
        RBS_Type.Add(RBN_AllFriends, TTYPE_ALL_FRIENDS)
        RBS_Type.Add(RBN_None, TTYPE_NONE)
    End Sub

    Private Sub BattleNPCAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate ACB_Single
        For i As Integer = 0 To 1
            For j As Integer = 0 To member.GetBattle().GetTeamMembersCount(i) - 1
                ACB_Single.AddAssoc(member.GetBattle().GetTeamMember(i, j).MembName, member.GetBattle().GetTeamMember(i, j).GetID())
            Next
            If (i <> 1) Then ACB_Single.AddAssoc("----------", Nothing)
        Next
        If (Not bNew) Then
            Dim q = New SQLiteCommand("SELECT * FROM battle_actions WHERE id=" & id, Common.sqLiteCon).ExecuteReader()
            q.Read() 'shouldnt be null.
            TBX_Desc.Text = q.Item("description")
            TBX_Damage.Text = q.Item("damage")
            RBS_Type.SetSelectedValue(q.Item("targettype"))
            ACB_Single.SetSelectedAssocValue(q.Item("targetextra"))
            TBX_Miss.Text = q.Item("misschance")
        End If
    End Sub

    Private Function Save() As Boolean
        'validating dmg formula
        Dim rangeReg = New Regex("(?:^\d+ *\| *\d+$)|(?:^\d+$)")
        If (Not rangeReg.IsMatch(TBX_Damage.Text)) Then
            MsgBox("Invalid damage entered. See formula help for more information", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        'end validate
        Dim miss As Decimal = -1
        If (Decimal.TryParse(TBX_Miss.Text, miss)) Then
            If (Not (miss >= 0 And miss <= 100)) Then
                miss = -1
            End If
        End If
        If (miss = -1) Then
            MsgBox("Invalid miss chance", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        If ((RBS_Type.GetSelectedValue() = 1 And ACB_Single.GetAssocValue() Is Nothing) Or RBS_Type.GetSelectedValue() Is Nothing) Then
            MsgBox("Invalid target", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        Dim s As New SQLiteCommand(Common.sqLiteCon)
        If (Not bNew) Then
            s.CommandText = "UPDATE battle_actions SET description=@desc, damage=@dmg, targettype=@type, targetextra=@extra, misschance=@miss WHERE id=" & id
        Else
            s.CommandText = "INSERT INTO battle_actions (id, member_id, description, damage, targettype, targetextra, misschance) VALUES (@id, @mid, @desc, @dmg, @type, @extra, @miss)"
            s.Parameters.AddWithValue("@id", id)
            s.Parameters.AddWithValue("@mid", member.GetID())
        End If
        s.Parameters.AddWithValue("@desc", TBX_Desc.Text)
        s.Parameters.AddWithValue("@dmg", TBX_Damage.Text)
        s.Parameters.AddWithValue("@type", RBS_Type.GetSelectedValue())
        s.Parameters.AddWithValue("@extra", IIf(RBN_Single.Checked, ACB_Single.GetAssocValue(), -1))
        s.Parameters.AddWithValue("@miss", miss)
        s.ExecuteNonQuery()
        Return True
    End Function

    Private Sub BTN_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Done.Click
        If (Not Save()) Then Return
        member.FlagAction(id, GenerateActionText(TBX_Damage.Text, RBS_Type.GetSelectedValue(), ACB_Single.GetAssocValue()))
        Me.Close()
    End Sub

    Private Sub BTN_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Clear.Click
        member.FlagAction(-1)
        Me.Close()
    End Sub

    Private Sub BTN_FHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FHelp.Click
        MsgBox("A | B => The value will be between A and B.", MsgBoxStyle.OkOnly, "Formula Help")
    End Sub

    Public Shared Function GenerateActionText(ByVal damage As String, ByVal ttype As UInteger, ByVal tExtra As Integer) As String
        Dim typetxt As String = ""
        If (ttype = TTYPE_SINGLE) Then
            typetxt = New SQLiteCommand("SELECT name FROM battle_members WHERE id=" & tExtra, Common.sqLiteCon).ExecuteScalar()
        ElseIf (ttype = TTYPE_RANDOM_ENEMY) Then
            typetxt = "Random Enemy"
        ElseIf (ttype = TTYPE_RANDOM_FRIEND) Then
            typetxt = "Random Friend"
        ElseIf (ttype = TTYPE_ALL_ENEMIES) Then
            typetxt = "All Enemies"
        ElseIf (ttype = TTYPE_ALL_FRIENDS) Then
            typetxt = "All Friends"
        ElseIf (ttype = TTYPE_NONE) Then
            typetxt = "None"
        End If
        Return ("Deal " & damage & " damage to " & typetxt)
    End Function

    Private Sub MeClosing() Handles Me.FormClosed
        openWindows.Remove(member)
    End Sub

End Class