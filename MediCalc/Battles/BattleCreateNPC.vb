Imports System.Data.SQLite

Public Class BattleCreateNPC

    Private tID As Byte
    Private sourceBattle As Battle
    Private existingMember As BattleMember = Nothing
    Public Shared openEdits As New List(Of BattleMember)

    Public Overloads Shared Sub open(ByVal tID As Byte, ByRef sourceBattle As Battle)
        Dim b As BattleCreateNPC = New BattleCreateNPC(tID, sourceBattle)
        b.Show()
    End Sub

    ''' <summary>
    ''' Opens specified member for editing. Does nothing if member is already being edited.
    ''' </summary>
    ''' <param name="existingMember">The member to edit.</param>
    ''' <remarks></remarks>
    Public Shared Sub edit(ByRef existingMember As BattleMember)
        If (openEdits.Contains(existingMember)) Then
            Return
        End If
        openEdits.Add(existingMember)
        Dim b As BattleCreateNPC = New BattleCreateNPC(existingMember)
        b.Show()
    End Sub

    Private Sub New(ByVal team As Byte, ByRef sourceBattle As Battle)
        InitializeComponent()
        Me.tID = team
        Me.sourceBattle = sourceBattle
        TBX_HPCur.Enabled = False
        BTN_DeleteFromBattle.Enabled = False
    End Sub

    Private Sub New(ByRef existingMember As BattleMember)
        InitializeComponent()
        Me.existingMember = existingMember
        'Me.tID = existingMember.GetTeamID()
        'Me.sourceBattle = sourceBattle
        TBX_Name.Text = existingMember.MembName
        TBX_Level.Text = existingMember.MembLevel
        TBX_HP.Text = existingMember.MembHpMax
        TBX_HPCur.Text = existingMember.MembHpCur
    End Sub

    Private Sub BTN_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Done.Click
        'validate fields
        If (Not Common.ValidateHPLikeField(TBX_HPCur.Text, TBX_HP.Text)) Then
            MsgBox("Invalid HP values (must be positive integer; current <= maximum)", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If (TBX_HPCur.Enabled = False) Then
            'add NPC battle member (if not editing)
            sourceBattle.AddMember(tID, TBX_Name.Text, TBX_Level.Text, Integer.Parse(TBX_HP.Text))
        Else
            'modify the original member
            existingMember.MembName = TBX_Name.Text
            existingMember.MembLevel = TBX_Level.Text
            existingMember.MembHpMax = Integer.Parse(TBX_HP.Text)
            If (existingMember.IsDead() And Integer.Parse(TBX_HPCur.Text) > 0) Then
                existingMember.Revive(Integer.Parse(TBX_HPCur.Text))
            Else
                existingMember.MembHpCur = Integer.Parse(TBX_HPCur.Text)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        If (Not Common.ValidateHPLikeField("0", TBX_HP.Text)) Then
            MsgBox("Invalid HP value (must be positive integer)", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim saveQ = New SQLiteCommand("INSERT INTO npc_prefab (name, level, health) VALUES (@name, @level, @health);" & vbNewLine, Common.sqLiteCon)
        saveQ.Parameters.AddWithValue("@name", TBX_Name.Text)
        saveQ.Parameters.AddWithValue("@level", TBX_Level.Text)
        saveQ.Parameters.AddWithValue("@health", Integer.Parse(TBX_HP.Text))
        saveQ.ExecuteNonQuery()
        MsgBox("Save successful", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub BTN_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Load.Click
        Dim listOfNames(1) As String
        Dim listOfValues(1) As Object
        Dim nameQ = New SQLiteCommand("SELECT name, id FROM npc_prefab", Common.sqLiteCon)
        Dim nameQuery = nameQ.ExecuteReader()
        Dim count As Integer = 0
        While (nameQuery.Read())
            If (Not nameQuery.IsDBNull(0)) Then
                listOfNames(count) = nameQuery.GetString(0)
                listOfValues(count) = nameQuery.GetInt32(1)
                count += 1
                ReDim Preserve listOfNames(count)
                ReDim Preserve listOfValues(count)
            End If
        End While
        ReDim Preserve listOfNames(count - 1)
        ReDim Preserve listOfValues(count - 1)
        nameQuery.Close()
        SimpleSelection.open("LoadChoice", listOfNames, listOfValues, AddressOf HandleSelection)
    End Sub

    Private Sub HandleSelection(ByVal choiceName As String, ByVal choiceInfo As AssocComboBox.SelectionInfo)
        If (choiceInfo.value = Nothing) Then
            Return
        End If
        If (choiceName = "LoadChoice") Then
            Dim id As Integer = choiceInfo.value
            Dim infoQ = New SQLiteCommand("SELECT name, level, health FROM npc_prefab WHERE id=" & id, Common.sqLiteCon)
            Dim infoQuery = infoQ.ExecuteReader()
            infoQuery.Read()
            TBX_Name.Text = infoQuery.Item("name")
            TBX_Level.Text = infoQuery.Item("level")
            TBX_HP.Text = infoQuery.Item("health")
            infoQuery.Close()
        ElseIf (choiceName = "DeleteChoice") Then
            Dim id As Integer = choiceInfo.value
            Dim infoQ = New SQLiteCommand("DELETE FROM npc_prefab WHERE id=" & id, Common.sqLiteCon)
            infoQ.ExecuteNonQuery()
            MsgBox("Successfully deleted '" & choiceInfo.text & "'", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        Dim listOfNames(1) As String
        Dim listOfValues(1) As String
        Dim nameQ = New SQLiteCommand("SELECT name, id FROM npc_prefab", Common.sqLiteCon)
        Dim nameQuery = nameQ.ExecuteReader()
        Dim count As Integer = 0
        While (nameQuery.Read())
            If (Not nameQuery.IsDBNull(0)) Then
                listOfNames(count) = nameQuery.GetString(0)
                listOfValues(count) = nameQuery.GetInt32(1)
                count += 1
                ReDim Preserve listOfNames(count)
                ReDim Preserve listOfValues(count)
            End If
        End While
        ReDim Preserve listOfNames(count - 1)
        ReDim Preserve listOfValues(count - 1)
        nameQuery.Close()
        SimpleSelection.open("DeleteChoice", listOfNames, listOfValues, AddressOf HandleSelection)
    End Sub

    Private Sub TBX_HP_TextChanged(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles TBX_HP.TextChanged
        If (TBX_HPCur.Enabled = False) Then
            TBX_HPCur.Text = sender.Text
        End If
    End Sub

    Private Sub MeClosed() Handles Me.FormClosed
        openEdits.Remove(existingMember)
    End Sub

    Private Sub BTN_DeleteFromBattle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DeleteFromBattle.Click
        If (MsgBox("Are you sure you want to delete this member from the battle?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirm action") = MsgBoxResult.Yes) Then
            existingMember.GetBattle().DeleteMember(existingMember.GetID())
            Me.Close()
        End If
    End Sub
End Class