Imports System.Data.SQLite

Public Class BattlePlayerAction

    Public Shared ReadOnly TTYPE_SINGLE As UInteger = 1
    Public Shared ReadOnly TTYPE_ALL_ENEMIES As UInteger = 2
    Public Shared ReadOnly TTYPE_ALL_FRIENDS As UInteger = 3

    Public Shared ReadOnly ATYPE_MELEE As UInteger = 1
    Public Shared ReadOnly ATYPE_RANGED As UInteger = 2
    Public Shared ReadOnly ATYPE_BLOCK As UInteger = 3
    Public Shared ReadOnly ATYPE_SPELL As UInteger = 4 'ext: id
    Public Shared ReadOnly ATYPE_ITEM As UInteger = 5 'ext: id

    Private id As Integer = -1
    Private bNew As Boolean = True
    Private player As BattlePlayer
    Private RBS_TType As RadioButtonSet
    Private RBS_AType As RadioButtonSet
    Private Shared maxID As Integer = -1
    Public Shared openWindows As New List(Of BattlePlayer)

    Public Shared Sub open(ByVal player As BattlePlayer, Optional ByVal id As Integer = -1)
        If (openWindows.Contains(player)) Then
            Return
        End If
        openWindows.Add(player)
        Dim w As New BattlePlayerAction(player, id)
        w.Show()
    End Sub

    Private Sub New(ByVal player As BattlePlayer, Optional ByVal id As Integer = -1)
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
        Me.player = player
        RBS_AType = New RadioButtonSet()
        RBS_AType.Add(RBN_Melee, ATYPE_MELEE)
        RBS_AType.Add(RBN_Ranged, ATYPE_RANGED)
        RBS_AType.Add(RBN_Block, ATYPE_BLOCK)
        RBS_AType.Add(RBN_Spell, ATYPE_SPELL)
        RBS_AType.Add(RBN_Item, ATYPE_ITEM)

        RBS_TType = New RadioButtonSet()
        RBS_TType.Add(RBN_Single, TTYPE_SINGLE)
        RBS_TType.Add(RBN_AllEnemies, TTYPE_ALL_ENEMIES)
        RBS_TType.Add(RBN_AllFriends, TTYPE_ALL_FRIENDS)

        RBN_Ranged.Visible = player.CanRanged()
    End Sub

    Private Sub BattlePlayerAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate CBX_Single
        For i As Integer = 0 To 1
            For j As Integer = 0 To player.GetBattle().GetTeamMembersCount(i) - 1
                ACB_Single.AddAssoc(player.GetBattle().GetTeamMember(i, j).MembName, player.GetBattle().GetTeamMember(i, j).GetID())
            Next
            If (i <> 1) Then ACB_Single.AddAssoc("----------", Nothing)
        Next
        'populate cbx_spell and cbx_item
        For i As Integer = 0 To player.GetSpellsCount() - 1
            Dim id As UInteger = player.GetSpell(i)
            Dim name = New SQLiteCommand("SELECT name FROM spells WHERE id=" & id, Common.sqLiteCon).ExecuteScalar()
            ACB_Spell.AddAssoc(name, id)
        Next
        For i As Integer = 0 To player.GetUsableItemsCount() - 1
            Dim id As UInteger = player.GetUsableItem(i)
            Dim name = New SQLiteCommand("SELECT name FROM items WHERE id=" & id, Common.sqLiteCon).ExecuteScalar()
            ACB_Item.AddAssoc(name, id)
        Next
        If (Not bNew) Then
            Dim q = New SQLiteCommand("SELECT * FROM battle_actions WHERE id=" & id, Common.sqLiteCon).ExecuteReader()
            q.Read() 'shouldnt be null.
            RBS_AType.SetSelectedValue(q.Item("p_attacktype"))
            If (RBS_AType.GetSelectedValue() = ATYPE_SPELL) Then ACB_Spell.SetSelectedAssocValue(q.Item("p_attackextra"))
            If (RBS_AType.GetSelectedValue() = ATYPE_ITEM) Then ACB_Item.SetSelectedAssocValue(q.Item("p_attackextra"))
            RBS_TType.SetSelectedValue(q.Item("targettype"))
            ACB_Single.SetSelectedAssocValue(q.Item("targetextra"))
        End If
    End Sub

    Private Function Save() As Boolean
        If ((RBS_AType.GetSelectedValue() = ATYPE_SPELL And ACB_Spell.SelectedIndex = -1) Or (RBS_AType.GetSelectedValue() = ATYPE_ITEM And _
                                                                                    ACB_Item.SelectedIndex = -1)) Then
            MsgBox("Invalid spell/item selection", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        If ((RBS_TType.GetSelectedValue() = TTYPE_SINGLE And (ACB_Single.GetAssocValue() Is Nothing)) Or RBS_TType.GetSelectedValue() Is Nothing) Then
            MsgBox("Invalid target", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        Dim s As New SQLiteCommand(Common.sqLiteCon)
        If (Not bNew) Then
            s.CommandText = "UPDATE battle_actions SET p_attacktype=@atype, p_attackextra=@aext, targettype=@ttype, targetextra=@text WHERE id=" & id
        Else
            s.CommandText = "INSERT INTO battle_actions (id, member_id, p_attacktype, p_attackextra, targettype, targetextra) VALUES (@id, @mid, @atype, @aext, @ttype, @text)"
            s.Parameters.AddWithValue("@id", id)
            s.Parameters.AddWithValue("@mid", player.GetID())
        End If
        s.Parameters.AddWithValue("@atype", RBS_AType.GetSelectedValue())
        Dim aext As Integer = -1
        If (RBS_AType.GetSelectedValue() = ATYPE_SPELL) Then aext = ACB_Spell.GetAssocValue()
        If (RBS_AType.GetSelectedValue() = ATYPE_ITEM) Then aext = ACB_Item.GetAssocValue()
        s.Parameters.AddWithValue("@aext", aext)
        s.Parameters.AddWithValue("@ttype", RBS_TType.GetSelectedValue())
        s.Parameters.AddWithValue("@text", IIf(RBN_Single.Checked, ACB_Single.GetAssocValue(), -1))
        s.ExecuteNonQuery()
        Return True
    End Function

    Private Sub BTN_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Done.Click
        If (Not Save()) Then Return
        Dim aext As Integer = IIf(RBS_AType.GetSelectedValue() = 4, ACB_Spell.GetAssocValue(), ACB_Item.GetAssocValue())
        player.FlagAction(id, GenerateActionText(RBS_AType.GetSelectedValue(), aext, RBS_TType.GetSelectedValue(), ACB_Single.GetAssocValue()))
        Me.Close()
    End Sub

    Private Sub BTN_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Clear.Click
        player.FlagAction(-1)
        Me.Close()
    End Sub

    Private Sub MeClosing() Handles Me.FormClosed
        openWindows.Remove(player)
    End Sub

    Private Sub BTN_Generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Generate.Click
        Dim text As String = BattleLog.GetMemberStatus(player) & vbNewLine
        Dim count As UInteger = 0 ' 0 based number of options

        Dim min As Integer = player.PBonusMinMelee
        If (min = 0) Then min = 1
        Dim max As Integer = player.PBonusMelee
        If (min > max) Then max = min

        text &= Chr(65 + count) & ") Melee Attack (" & min & " - " & max & " Damage)" & vbNewLine
        count += 1
        If (player.CanRanged()) Then
            min = player.PBonusMinRanged
            If (min = 0) Then min = 1
            max = player.PBonusRanged
            If (min > max) Then max = min
            text &= Chr(65 + count) & ") Ranged Attack (" & min & " - " & max & " Damage)" & vbNewLine
            count += 1
        End If
        text &= Chr(65 + count) & ") Block" & vbNewLine
        count += 1
        text &= Chr(65 + count) & ") Cast:" & vbNewLine
        For i As Integer = 0 To player.GetSpellsCount() - 1
            text &= "  " & Chr(65 + count) & i + 1 & ") " & Spells.GenerateSpellString(player.GetSpell(i)) & vbNewLine
        Next
        count += 1
        text &= Chr(65 + count) & ") Use item:" & vbNewLine
        For i As Integer = 0 To player.GetUsableItemsCount() - 1
            text &= "  " & Chr(65 + count) & i + 1 & ") " & Items.GenerateItemString(player.GetUsableItem(i)) & vbNewLine
        Next
        count += 1
        text &= Chr(65 + count) & ") Leave combat"

        GenerateWindow.open(text)
    End Sub

    Public Shared Function GenerateActionText(ByVal atype As Integer, ByVal aext As Integer, ByVal ttype As Integer, ByVal textra As Integer) As String
        Dim atxt As String = ""
        If (atype = ATYPE_MELEE) Then
            atxt = "Melee attack at "
        ElseIf (atype = ATYPE_RANGED) Then
            atxt = "Ranged attack at "
        ElseIf (atype = ATYPE_BLOCK) Then
            Return "Block attacks"
        ElseIf (atype = ATYPE_SPELL) Then
            atxt = "Cast spell"
        ElseIf (atype = ATYPE_ITEM) Then
            atxt = "Use item"
        End If
        If (atype = ATYPE_SPELL Or atype = ATYPE_ITEM) Then
            Dim ext As String = New SQLiteCommand("SELECT name FROM " & IIf(atype = ATYPE_SPELL, "spells", "items") & " WHERE id=" & aext, Common.sqLiteCon).ExecuteScalar()
            atxt &= " '" & ext & "' on "
        End If
        Dim typetxt As String = ""
        If (ttype = TTYPE_SINGLE) Then
            typetxt = New SQLiteCommand("SELECT name FROM battle_members WHERE id=" & textra, Common.sqLiteCon).ExecuteScalar()
        ElseIf (ttype = TTYPE_ALL_ENEMIES) Then
            typetxt = "All Enemies"
        ElseIf (ttype = TTYPE_ALL_FRIENDS) Then
            typetxt = "All Friends"
        End If
        Return (atxt & typetxt)
    End Function
End Class