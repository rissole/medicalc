Imports System.Data.SQLite

Public Class PlayerSpells

    Public playerID As UInteger
    Private internalSpells As New List(Of UInteger)
    Private currentSpellID As Integer = -1
    Private forceClose As Boolean = False

    Public Sub New(ByVal plID As UInteger)
        ' This call is required by the designer.
        InitializeComponent()

        playerID = plID

        'populate internalSpells
        Dim splstr As String = New SQLiteCommand("SELECT spells FROM player_spells WHERE player_id=" & playerID, Common.sqLiteCon).ExecuteScalar()
        If (Not splstr Is Nothing And splstr <> "") Then
            Dim arr() = splstr.Split(",")
            For Each id In arr
                internalSpells.Add(UInteger.Parse(id))
            Next
        End If
    End Sub

    ''' <summary>
    ''' Updates item CBX, and updates controls based on internal dictionaries.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshStuff()
        'populate drop down
        Dim sel = CBX_Spells.SelectedItem
        CBX_Spells.Items.Clear()
        Dim nameListQ = New SQLiteCommand("SELECT name FROM 'spells'", Common.sqLiteCon).ExecuteReader()
        While (nameListQ.Read())
            CBX_Spells.Items.Add(nameListQ.GetString(0))
        End While
        nameListQ.Close()
        CBX_Spells.SelectedItem = sel
        If (CBX_Spells.Items.Count = 0) Then
            nameListQ.Close()
            MsgBox("You must have at least 1 spell saved before you can load the Player Spellbook.", MsgBoxStyle.Critical, "Error")
            forceClose = True
            Me.Close()
            Return
        End If
        If (CBX_Spells.SelectedIndex = -1) Then
            CBX_Spells.SelectedIndex = 0
        End If

        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()
        'update visuals based on internal dictionaries.
        LBX_Spells.Items.Clear()
        For Each id As UInteger In internalSpells
            Dim nameQ = New SQLiteCommand("SELECT name FROM spells WHERE id=" & id, Common.sqLiteCon).ExecuteReader()
            Dim name = "UNKNOWN SPELL [" & id & "]"
            If (nameQ.Read() And Not nameQ.IsDBNull(0)) Then
                name = nameQ.GetString(0)
            End If
            nameQ.Close()
            LBX_Spells.Items.Add(name)
        Next
    End Sub

    Private Sub CBX_Spells_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBX_Spells.SelectedIndexChanged
        'handle updating currentSpellID and TBX_SpellString
        Dim name As String = DirectCast(sender, ComboBox).SelectedItem
        Dim idQ = New SQLiteCommand("SELECT id FROM spells WHERE name=@name", Common.sqLiteCon)
        idQ.Parameters.AddWithValue("@name", name)
        Dim idQR = idQ.ExecuteReader()
        If (idQR.Read() And idQR.IsDBNull(0)) Then
            idQR.Close()
            MsgBox("Spell no longer exists", MsgBoxStyle.Critical, "Error")
            RefreshStuff()
            Return
        Else
            currentSpellID = idQR.GetInt32(0)
            idQR.Close()
            TBX_SpellString.Text = Spells.GenerateSpellString(currentSpellID)
        End If
    End Sub

    Private Sub FormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'we'll disable all other forms so this one doesnt get interfered with.
        Main.DisableAll("rcs")
        RefreshStuff()
    End Sub

    Private Sub FormClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNoCancel, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        Main.EnableAll()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.psWindow = Nothing
        End If
    End Sub

    Private Sub SaveBtnPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
    End Sub

    Private Sub SaveContent(Optional ByVal silent As Boolean = False)
        'custom save based on internalSpells
        Dim saveQ = New SQLiteCommand(Common.sqLiteCon)
        saveQ.CommandText = "BEGIN TRANSACTION;" & vbNewLine
        saveQ.CommandText &= "DELETE FROM player_spells WHERE player_id=" & playerID & ";" & vbNewLine
        saveQ.CommandText &= "INSERT INTO player_spells (player_id, spells) VALUES (" & playerID & ", @splstr);" & vbNewLine
        Dim splstr As String = Common.ListToCommaSep(internalSpells)
        saveQ.Parameters.AddWithValue("@splstr", splstr)
        saveQ.CommandText &= "COMMIT;"
        If (saveQ.ExecuteNonQuery() > 0 And Not silent) Then
            MsgBox("Save successful", MsgBoxStyle.Information)
        ElseIf (Not silent) Then
            MsgBox("Unknown error occured", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        SaveContent(True)
        forceClose = True
        Me.Close()
    End Sub

    Private Sub BTN_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Add.Click
        internalSpells.Add(currentSpellID)
        UpdateDisplay()
    End Sub

    Private Sub LBX_Spells_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBX_Spells.MouseDoubleClick
        Dim p As Point = Cursor.Position
        p = LBX_Spells.PointToClient(p)
        Dim idx As Integer = LBX_Spells.IndexFromPoint(p)
        If (idx <> -1) Then
            internalSpells.RemoveAt(idx)
            UpdateDisplay()
        End If
    End Sub

    Private Sub BTN_Spells_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Spells.Click
        If (Main.currentSpellsInst Is Nothing) Then
            Main.currentSpellsInst = New Spells()
            Main.currentSpellsInst.Show()
        End If
    End Sub
End Class