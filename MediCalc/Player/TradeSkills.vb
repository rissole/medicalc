Imports System.Data.SQLite

Public Class TradeSkills

    Private player_id As Integer
    Private forceClose As Boolean = False

    Public Sub New(ByVal plID As Integer)
        'required by designer
        InitializeComponent()

        player_id = plID
    End Sub

    Private Sub CloseMe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNoCancel, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.tsWindow = Nothing
        End If
    End Sub

    Private Sub SaveContent(Optional ByVal silent As Boolean = False)
        'custom save "level,exp" (or empty if not checked)
        Dim trans = New SQLiteCommand(Common.sqLiteCon)
        trans.CommandText = "BEGIN TRANSACTION;" & vbNewLine
        trans.CommandText &= "DELETE FROM player_tradeskills WHERE player_id=" & player_id & ";" & vbNewLine
        trans.CommandText &= "INSERT INTO player_tradeskills (player_id, Mining, Cooking, Herbalism, Skinning, Fishing, Blacksmithing, Jewelcrafting, Alchemy, Leatherworking, Tailoring, Enchanting, Writing, Carpentry, Fletching, Science) "
        trans.CommandText &= "VALUES (" & player_id & ", @Mining, @Cooking, @Herbalism, @Skinning, @Fishing, @Blacksmithing, @Jewelcrafting, @Alchemy, @Leatherworking, @Tailoring, @Enchanting, @Writing, @Carpentry, @Fletching, @Science);" & vbNewLine
        For row As Integer = 1 To TableLayoutPanel1.RowCount - 1
            Dim pName As String = "@" & TableLayoutPanel1.GetControlFromPosition(0, row).Name.Replace("CHX_", "")
            Dim level As String = DirectCast(TableLayoutPanel1.GetControlFromPosition(1, row), NumericUpDown).Value.ToString()
            Dim exp As String = DirectCast(TableLayoutPanel1.GetControlFromPosition(2, row), NumericUpDown).Value.ToString()
            If (DirectCast(TableLayoutPanel1.GetControlFromPosition(0, row), CheckBox).Checked) Then
                trans.Parameters.AddWithValue(pName, level & "," & exp)
            Else
                trans.Parameters.AddWithValue(pName, "")
            End If
        Next
        trans.CommandText &= "COMMIT;"
        If (trans.ExecuteNonQuery() > 0 And Not silent) Then
            MsgBox("Save successful", MsgBoxStyle.Information)
        ElseIf (Not silent) Then
            MsgBox("Unknown error occured", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
    End Sub

    Private Sub CHX_CheckedChanged(ByVal sender As Control, ByVal e As System.EventArgs) Handles _
        CHX_Alchemy.CheckedChanged, CHX_Blacksmithing.CheckedChanged, CHX_Carpentry.CheckedChanged, CHX_Cooking.CheckedChanged, _
        CHX_Enchanting.CheckedChanged, CHX_Fishing.CheckedChanged, CHX_Fletching.CheckedChanged, CHX_Herbalism.CheckedChanged, _
        CHX_Jewelcrafting.CheckedChanged, CHX_Leatherworking.CheckedChanged, CHX_Mining.CheckedChanged, CHX_Science.CheckedChanged, _
        CHX_Skinning.CheckedChanged, CHX_Tailoring.CheckedChanged, CHX_Writing.CheckedChanged

        Dim row As Integer = TableLayoutPanel1.GetPositionFromControl(sender).Row
        TableLayoutPanel1.GetControlFromPosition(1, row).Enabled = DirectCast(sender, CheckBox).Checked
        TableLayoutPanel1.GetControlFromPosition(2, row).Enabled = DirectCast(sender, CheckBox).Checked
    End Sub

    Private Sub TradeSkills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'enable/disable controls and set NUD values based on player_tradeskills
        Dim query = New SQLiteCommand("SELECT * FROM player_tradeskills WHERE player_id=" & player_id, Common.sqLiteCon).ExecuteReader()
        If (query.Read()) Then
            For i = 1 To query.FieldCount - 1
                Dim lvlExpStr As String = query.GetString(i)
                Dim CHX As CheckBox = DirectCast(Common.GetControlByName(TableLayoutPanel1, "CHX_" & query.GetName(i)), CheckBox)
                CHX.Checked = True
                If (lvlExpStr = "") Then
                    CHX.Checked = False
                Else
                    Dim lvlExpArr() As String = lvlExpStr.Split(",")
                    Dim lvlCtrl As NumericUpDown = DirectCast(Common.GetControlByName(TableLayoutPanel1, "NUD_L" & query.GetName(i)), NumericUpDown)
                    Dim expCtrl As NumericUpDown = DirectCast(Common.GetControlByName(TableLayoutPanel1, "NUD_E" & query.GetName(i)), NumericUpDown)
                    lvlCtrl.Value = Integer.Parse(lvlExpArr(0))
                    expCtrl.Value = Integer.Parse(lvlExpArr(1))
                End If
            Next
        End If
        query.Close()
    End Sub

    Private Sub BTN_Close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        SaveContent(True)
        forceClose = True
        Me.Close()
    End Sub
End Class