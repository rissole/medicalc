Imports System.Data.SQLite

Public Class Main
    Public Shared currentPlayersInst As Players = Nothing
    Public Shared currentRacesInst As Races = Nothing
    Public Shared currentClassesInst As Classes = Nothing
    Public Shared currentItemsInst As Items = Nothing
    Public Shared currentSpellsInst As Spells = Nothing
    Public Shared currentBattlesInst As Battles = Nothing

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.sqLiteCon.Open()
    End Sub

    Private Sub Main_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Common.sqLiteCon.Close()
    End Sub

    Public Shared Sub DisableAll(Optional ByVal butNot As String = "")
        If (Not butNot.Contains("m")) Then Main.Enabled = False
        If (Not currentPlayersInst Is Nothing And Not butNot.Contains("p")) Then currentPlayersInst.Enabled = False
        If (Not currentRacesInst Is Nothing And Not butNot.Contains("r")) Then currentRacesInst.Enabled = False
        If (Not currentClassesInst Is Nothing And Not butNot.Contains("c")) Then currentClassesInst.Enabled = False
        If (Not currentItemsInst Is Nothing And Not butNot.Contains("i")) Then currentItemsInst.Enabled = False
        If (Not currentSpellsInst Is Nothing And Not butNot.Contains("s")) Then currentSpellsInst.Enabled = False
    End Sub

    Public Shared Sub EnableAll(Optional ByVal butNot As String = "")
        If (Not butNot.Contains("m")) Then Main.Enabled = True
        If (Not currentPlayersInst Is Nothing And Not butNot.Contains("p")) Then currentPlayersInst.Enabled = True
        If (Not currentRacesInst Is Nothing And Not butNot.Contains("r")) Then currentRacesInst.Enabled = True
        If (Not currentClassesInst Is Nothing And Not butNot.Contains("c")) Then currentClassesInst.Enabled = True
        If (Not currentItemsInst Is Nothing And Not butNot.Contains("i")) Then currentItemsInst.Enabled = True
        If (Not currentSpellsInst Is Nothing And Not butNot.Contains("s")) Then currentSpellsInst.Enabled = True
    End Sub

    Private Sub B_Players_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Players.Click
        If (currentPlayersInst Is Nothing) Then
            currentPlayersInst = New Players()
            currentPlayersInst.Show()
        End If
    End Sub

    Private Sub BTN_Races_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Races.Click
        If (currentRacesInst Is Nothing) Then
            currentRacesInst = New Races()
            currentRacesInst.Show()
        End If
    End Sub

    Private Sub BTN_Classes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Classes.Click
        If (currentClassesInst Is Nothing) Then
            currentClassesInst = New Classes()
            currentClassesInst.Show()
        End If
    End Sub

    Private Sub BTN_Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Items.Click
        If (currentItemsInst Is Nothing) Then
            currentItemsInst = New Items()
            currentItemsInst.Show()
        End If
    End Sub

    Private Sub BTN_Spells_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Spells.Click
        If (currentSpellsInst Is Nothing) Then
            currentSpellsInst = New Spells()
            currentSpellsInst.Show()
        End If
    End Sub

    Private Sub BTN_Battle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Battle.Click
        If (currentBattlesInst Is Nothing) Then
            currentBattlesInst = New Battles()
            currentBattlesInst.Show()
        End If
    End Sub

    Private Sub BTN_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_About.Click
        MsgBox("MediCalc by hypersniper" & Chr(10) & "Made for Aninimouse and the Medieval Forum RPG of WoW-V.com" & Chr(10) & "WoW-V is in no way related to this project", MsgBoxStyle.Information)
    End Sub
End Class
