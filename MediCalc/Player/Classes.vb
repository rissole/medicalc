Public Class Classes
    Inherits DBInputForm

    Private forced As String = ""
    Private RBS_PowerType As RadioButtonSet = New RadioButtonSet()

    Public Sub New(Optional ByVal preSelected = "")
        ' This call is required by the designer.
        InitializeComponent()
        RBS_PowerType.Add(RBN_Mana, "Mana")
        RBS_PowerType.Add(RBN_Energy, "Energy")

        SetTableName("classes")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("name", TBX_Name)
        AssocField("skills_bonus", SLV_Specialties)
        AssocField("stat_bonus_str", NUD_Str)
        AssocField("stat_bonus_agi", NUD_Agi)
        AssocField("stat_bonus_int", NUD_Int)
        AssocField("stat_bonus_wil", NUD_Wil)
        AssocField("stat_bonus_end", NUD_End)
        AssocField("powertype", RBS_PowerType)

        forced = preSelected
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        SaveContent(True)
        forceClose = True
        Me.Close()
    End Sub

    Private Sub FormOnClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNoCancel, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        Main.currentClassesInst = Nothing
    End Sub

    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.DBInputForm_Load()
        If (forced <> "") Then
            CBX_Names.SelectedItem = forced
        End If
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadClasses()
        End If
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        AddNew()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadClasses()
        End If
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        DeleteEntry()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadClasses()
        End If
    End Sub
End Class