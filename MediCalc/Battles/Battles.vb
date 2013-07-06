Public Class Battles

    Public Shared openNames As List(Of String) = New List(Of String)
    Public Shared maxBID As UInteger

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        Me.Close()
    End Sub

    Private Sub FormOnClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Main.currentBattlesInst = Nothing
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        Dim name As String = TBX_Name.Text
        If (name = "") Then
            MsgBox("Invalid battle name", MsgBoxStyle.Information)
            Return
        Else
            For Each savedName As String In CBX_Saved.Items
                If (name = savedName) Then
                    MsgBox("Invalid battle name, already taken", MsgBoxStyle.Information)
                    Return
                End If
            Next

            For Each savedName As String In openNames
                If (name = savedName) Then
                    MsgBox("Battle already open", MsgBoxStyle.Information)
                    Return
                End If
            Next
        End If

        'valid name now
        Dim b As Battle = New Battle(name, maxBID)
        maxBID += 1
        b.Show()
        CBX_Saved.Items.Add(name)
    End Sub

    Private Sub BTN_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Load.Click
        If (CBX_Saved.SelectedIndex = -1) Then Return
        For Each savedName As String In openNames
            If (Name = savedName) Then
                MsgBox("Battle already open", MsgBoxStyle.Information)
                Return
            End If
        Next

        Dim b As Battle = New Battle(CBX_Saved.SelectedItem, -1)
        b.Show()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Generate new max battle id
        Dim bID = New SQLite.SQLiteCommand("SELECT MAX(id) FROM battles", Common.sqLiteCon).ExecuteScalar()
        If (IsDBNull(bID)) Then maxBID = 0 Else maxBID = bID + 1
    End Sub

    Private Sub Battles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBX_Saved.Items.Clear()
        Dim btlNames = New SQLite.SQLiteCommand("SELECT name FROM battles", Common.sqLiteCon).ExecuteReader()
        While (btlNames.Read())
            CBX_Saved.Items.Add(btlNames.GetString(0))
        End While
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        If (CBX_Saved.SelectedIndex = -1) Then Return
        If (MsgBox("Are you sure you want to delete the battle '" & CBX_Saved.SelectedItem & "'?", MsgBoxStyle.YesNo, "Confirm delete") = MsgBoxResult.Yes) Then
            Dim idQ = New SQLite.SQLiteCommand("SELECT id FROM battles WHERE name=@name", Common.sqLiteCon)
            idQ.Parameters.AddWithValue("@name", CBX_Saved.SelectedItem)
            Dim id As UInteger = idQ.ExecuteScalar()
            Dim q = New SQLite.SQLiteCommand(Common.sqLiteCon)
            q.CommandText = "BEGIN TRANSACTION; DELETE FROM battle_actions WHERE member_id IN (SELECT id FROM battle_members WHERE battle_id=" & id & "); "
            q.CommandText &= "DELETE FROM battle_effects WHERE member_id IN (SELECT id FROM battle_members WHERE battle_id=" & id & "); "
            q.CommandText &= "DELETE FROM battles WHERE id=" & id & "; DELETE FROM battle_members WHERE battle_id=" & id & "; "
            'q.CommandText &= "DELETE FROM battle_events WHERE battle_id=" & id & ";"
            q.CommandText &= "COMMIT; "
            q.ExecuteNonQuery()
            Battles_Load(Nothing, Nothing)
        End If
    End Sub
End Class