Public Class Races
    Inherits DBInputForm

    Private forcedRace As String = ""
    Private CBS_Profs As CheckButtonSet = New CheckButtonSet()

    Public Sub New(Optional ByVal preSelectedRace As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        CBS_Profs.Add(CHX_Science)
        CBS_Profs.Add(CHX_Fletching)
        CBS_Profs.Add(CHX_Carpentry)
        CBS_Profs.Add(CHX_Writing)
        CBS_Profs.Add(CHX_Enchanting)
        CBS_Profs.Add(CHX_Tailoring)
        CBS_Profs.Add(CHX_Leather)
        CBS_Profs.Add(CHX_Alchemy)
        CBS_Profs.Add(CHX_Jewel)
        CBS_Profs.Add(CHX_Blacksmithing)
        CBS_Profs.Add(CHX_Fishing)
        CBS_Profs.Add(CHX_Cooking)
        CBS_Profs.Add(CHX_Skinning)
        CBS_Profs.Add(CHX_Herbalism)
        CBS_Profs.Add(CHX_Mining)

        SetTableName("races")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("name", TBX_Name)
        AssocField("skills_bonus", SLV_Specialties)
        AssocField("prof_bonus", CBS_Profs)

        forcedRace = preSelectedRace
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        forceClose = True
        SaveContent(True)
        Me.Close()
    End Sub

    Private Sub FormOnClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNo, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        Main.currentRacesInst = Nothing
    End Sub

    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.DBInputForm_Load()
        If (forcedRace <> "") Then
            CBX_Names.SelectedItem = forcedRace
        End If
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadRaces()
        End If
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        AddNew()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadRaces()
        End If
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        DeleteEntry()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.ReloadRaces()
        End If
    End Sub

End Class