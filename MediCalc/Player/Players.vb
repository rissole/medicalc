Imports System.Data.SQLite

Public Class Players
    Inherits DBInputForm

    Private RBS_Gender As RadioButtonSet = New RadioButtonSet()
    Private CFC_Color As ColorFieldControl
    Private forcedPlayer As String = ""
    Public invWindow As Inventory = Nothing
    Public tsWindow As TradeSkills = Nothing
    Public psWindow As PlayerSpells = Nothing

    Public Sub New(Optional ByVal preSelectedPlayer As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        RBS_Gender.Add(RBN_Male, 0)
        RBS_Gender.Add(RBN_Female, 1)
        CFC_Color = New ColorFieldControl(TBX_Color)


        SetTableName("players")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("name", TBX_Name)
        AssocField("age", NUD_Age)
        AssocField("gender", RBS_Gender)
        AssocField("physical_desc", TBX_Physdesc)
        AssocField("history", TBX_History)
        AssocField("more", TBX_More)
        AssocField("color", CFC_Color)
        AssocField("skills", SLV_Specialties)
        AssocField("level", NUD_Level)
        AssocField("experience", NUD_Exp)
        AssocField("stat_str", NUD_Str)
        AssocField("stat_agi", NUD_Agi)
        AssocField("stat_int", NUD_Int)
        AssocField("stat_wil", NUD_Wil)
        AssocField("stat_end", NUD_End)
        AssocField("race", CBX_Race)
        AssocField("class", CBX_Class)

        forcedPlayer = preSelectedPlayer
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        SaveContent(True)
        forceClose = True
        Me.Close()
    End Sub

    Private Sub Players_OnClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNoCancel, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
                Main.currentPlayersInst = Nothing
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        Main.currentPlayersInst = Nothing
    End Sub

    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadRaces()
        ReloadClasses()
        MyBase.DBInputForm_Load()
        If (forcedPlayer <> "") Then
            CBX_Names.SelectedItem = forcedPlayer
        End If
        RecalculateRatings()
    End Sub

    Private Sub BTN_SetColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SetColor.Click
        CDG_Color.Color = CFC_Color.GetColor()
        If (CDG_Color.ShowDialog() = DialogResult.OK) Then
            CFC_Color.SetColor(ColorTranslator.ToHtml(CDG_Color.Color))
        End If
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        AddNew()
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        DeleteEntry()
    End Sub

    Public Sub RecalculateRatings(Optional ByVal noRaceClassReload As Boolean = False)
        'reset all
        Dim tempArray() As NumericUpDown = {NUD_Str, NUD_Agi, NUD_Int, NUD_Wil, NUD_End}
        Dim tempArray2() As NumericUpDown = {NUD_Melee, NUD_Ranged, NUD_Energy, NUD_Mana, NUD_Magic, NUD_Hp, NUD_Defense}
        For Each nud As NumericUpDown In tempArray2
            nud.Value = 0
        Next
        'end reset
        If (Not noRaceClassReload) Then
            'race-based ratings - auto apply level 1 stats
            If (NUD_Level.Value = 1 And NUD_Exp.Value = 0) Then
                Dim skillsQuery = New SQLiteCommand("SELECT skills_bonus FROM races WHERE name=@parameter", Common.sqLiteCon)
                skillsQuery.Parameters.AddWithValue("@parameter", CBX_Race.SelectedItem)
                Dim skillsRead = skillsQuery.ExecuteReader()
                skillsRead.Read()
                If (Not skillsRead.IsDBNull(0)) Then
                    SetControlValue(SLV_Specialties, skillsRead.GetString(0))
                End If
                skillsRead.Close()
            End If
            'end race-based ratings
            'class-based ratings - auto apply level 1 stats
            If (NUD_Level.Value = 1 And NUD_Exp.Value = 0) Then
                For Each nud As NumericUpDown In tempArray
                    nud.Value = 0
                Next
                Dim skillsQuery = New SQLiteCommand("SELECT skills_bonus FROM classes WHERE name=@parameter", Common.sqLiteCon)
                skillsQuery.Parameters.AddWithValue("@parameter", CBX_Class.SelectedItem)
                Dim skillsRead = skillsQuery.ExecuteReader()
                skillsRead.Read()
                If (Not skillsRead.IsDBNull(0)) Then
                    SetControlValue(SLV_Specialties, Common.AddCommaSepIntString(skillsRead.GetString(0), GetControlValue(SLV_Specialties)))
                End If
                skillsRead.Close()
                Dim statsQuery = New SQLiteCommand("SELECT stat_bonus_str, stat_bonus_agi, stat_bonus_int, stat_bonus_wil, stat_bonus_end FROM classes WHERE name=@parameter", Common.sqLiteCon)
                statsQuery.Parameters.AddWithValue("@parameter", CBX_Class.SelectedItem)
                Dim statsRead = statsQuery.ExecuteReader()
                If (statsRead.Read()) Then
                    For i As Integer = 0 To 4
                        If (Not statsRead.IsDBNull(i)) Then
                            tempArray(i).Value = statsRead.GetInt32(i)
                        End If
                    Next
                End If
                statsRead.Close()
            End If
            'end class-based ratings
        End If
        'stat-based ratings
        'str
        NUD_Melee.Value = NUD_Str.Value
        NUD_Ranged.Value = Math.Floor(NUD_Str.Value / 2)
        NUD_Slots.Value = Math.Floor(NUD_Str.Value / 5)
        'agi
        NUD_Ranged.Value += Math.Floor(NUD_Agi.Value / 2)
        NUD_Energy.Value = NUD_Agi.Value * 5
        'int
        NUD_Mana.Value = NUD_Int.Value * 5
        'wil
        NUD_Magic.Value = NUD_Wil.Value
        'end
        NUD_Hp.Value = NUD_End.Value * 5
        NUD_Defense.Value = Math.Floor(NUD_End.Value / 5)
        'end stat-based ratings
    End Sub

    Private Function ProcessEquipmentStat(ByVal val1 As Integer, ByVal val2 As Integer) As String
        Dim ret As String = val1.ToString()
        If (val1 <> val2) Then
            ret &= " (" & val2 & ")"
        End If
        Return ret & vbNewLine
    End Function

    Private Function ProcessEquipped(ByVal q As SQLiteCommand, ByVal slot As String) As String
        Dim ret As String = slot & ": "
        q.Parameters.AddWithValue("@slot", slot)
        Dim itemID As Object = q.ExecuteScalar()
        q.Parameters.Clear()
        If (itemID IsNot Nothing) Then
            ret &= Items.GenerateItemString(itemID)
        End If
        ret &= vbNewLine
        Return ret
    End Function

    Private Sub BTN_Generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Generate.Click
        If (TBX_ID.Text = "") Then Return
        Dim text As String = ""
        text &= "Name: " & TBX_Name.Text & vbNewLine
        text &= "Age: " & NUD_Age.Value & vbNewLine
        text &= "Gender: " & RBS_Gender.GetSelectedRadioButton().Text & vbNewLine
        text &= "Race: " & CBX_Race.SelectedItem & vbNewLine
        text &= "Class: " & CBX_Class.SelectedItem & vbNewLine
        text &= "Tradeskills/Professions: "
        Dim profQuery = New SQLiteCommand("SELECT * FROM player_tradeskills WHERE player_id=" & TBX_ID.Text, Common.sqLiteCon)
        Dim profQ = profQuery.ExecuteReader()
        If (profQ.Read()) Then
            For i As Integer = 1 To profQ.FieldCount - 1
                If (profQ.GetString(i) <> "") Then
                    text &= profQ.GetName(i) & ", "
                End If
            Next
            Common.RemoveLastChars(text, 2)
        End If
        profQ.Close()
        text &= vbNewLine
        text &= "Physical Description: " & TBX_Physdesc.Text & vbNewLine
        text &= "Short History: " & TBX_History.Text & vbNewLine
        text &= "Anything else you'd like to say? " & TBX_More.Text & BattleLog.doubleLine

        text &= "Stats:" & vbNewLine & "[spoiler]" & vbNewLine
        text &= "Level: " & NUD_Level.Value & vbNewLine
        text &= "Experience:  " & NUD_Exp.Value & vbNewLine
        Dim fromEquips As BattlePlayer = New BattlePlayer(Integer.Parse(TBX_ID.Text), 0, Nothing, True)
        text &= "Health: " & ProcessEquipmentStat(NUD_Hp.Value, fromEquips.MembHpMax)
        Dim powTypeQ = New SQLiteCommand("SELECT powertype FROM classes WHERE name=@name", Common.sqLiteCon)
        powTypeQ.Parameters.AddWithValue("@name", CBX_Class.SelectedItem)
        Dim powType As String = powTypeQ.ExecuteScalar()
        If (powType <> Nothing) Then
            text &= powType & ": " & IIf(powType = "Mana", ProcessEquipmentStat(NUD_Mana.Value, fromEquips.MembPowerMax), ProcessEquipmentStat(NUD_Energy.Value, fromEquips.MembPowerMax))
        End If
        text &= "[color=#FF1111]Strength:[/color] " & ProcessEquipmentStat(NUD_Str.Value, fromEquips.GetStat(BattlePlayer.STAT_STR))
        text &= "[color=#FF9F11]Agility:[/color] " & ProcessEquipmentStat(NUD_Agi.Value, fromEquips.GetStat(BattlePlayer.STAT_AGI))
        text &= "[color=#0033FF]Intelligence:[/color] " & ProcessEquipmentStat(NUD_Int.Value, fromEquips.GetStat(BattlePlayer.STAT_INT))
        text &= "[color=#7000BB]Willpower:[/color] " & ProcessEquipmentStat(NUD_Wil.Value, fromEquips.GetStat(BattlePlayer.STAT_WIL))
        text &= "[color=#660000]Endurance:[/color] " & ProcessEquipmentStat(NUD_End.Value, fromEquips.GetStat(BattlePlayer.STAT_END))
        text &= "Defense: " & ProcessEquipmentStat(NUD_Defense.Value, fromEquips.PDefense)
        text &= "Melee Damage: " & ProcessEquipmentStat(NUD_Melee.Value, fromEquips.PBonusMelee)
        text &= "Ranged Damage: " & ProcessEquipmentStat(NUD_Ranged.Value, fromEquips.PBonusRanged)
        text &= "Magic Bonus Damage:  " & ProcessEquipmentStat(NUD_Magic.Value, fromEquips.PBonusMagic)
        text &= "[/spoiler]" & BattleLog.doubleLine

        text &= "Specialties:" & vbNewLine & "[spoiler]" & vbNewLine
        text &= vbNewLine & "[color=#FF9F11]Weapons:[/color]" & vbNewLine
        For i = 0 To SkillsListView.GetSkillsCount() - 1
            text &= SkillsListView.GetSkillName(i) & ": " & SLV_Specialties.GetValue(i) & vbNewLine
            If (i = SkillsListView.GetWeaponSkillsCount() - 1) Then
                text &= vbNewLine & "[color=#B4B4B4]Armor:[/color]" & vbNewLine
            ElseIf (i = SkillsListView.GetWeaponSkillsCount() + SkillsListView.GetArmorSkillsCount() - 1) Then
                text &= vbNewLine & "[color=#0099FF]Magic:[/color]" & vbNewLine
            End If
        Next
        text &= "[/spoiler]" & BattleLog.doubleLine

        profQ = profQuery.ExecuteReader()
        text &= "Tradeskills: " & vbNewLine & "[spoiler]" & vbNewLine
        If (profQ.Read()) Then
            For i As Integer = 1 To profQ.FieldCount - 1
                If (profQ.GetString(i) <> "") Then
                    Dim lvlAndExp() As String = profQ.GetString(i).Split(",")
                    text &= profQ.GetName(i) & ": " & lvlAndExp(0) & vbNewLine
                    text &= "Experience: " & ": " & lvlAndExp(1) & BattleLog.doubleLine
                End If
            Next
            Common.RemoveLastChars(text, 2)
        End If
        profQ.Close()
        text &= "[/spoiler]" & BattleLog.doubleLine

        text &= "Inventory:" & vbNewLine & "[spoiler]" & vbNewLine
        Dim invQuery = New SQLiteCommand("SELECT * FROM player_items WHERE player_id=" & TBX_ID.Text & " ORDER BY bag_slot ASC", Common.sqLiteCon)
        Dim invQ = invQuery.ExecuteReader()
        For i As Integer = 1 To 20 + NUD_Slots.Value
            text &= i & "-"
            If (invQ.Read()) Then
                text &= IIf(invQ.Item("stack_count") > 1, invQ.Item("stack_count") & "x ", "") & Items.GenerateItemString(invQ.Item("item_id"))
            End If
            text &= vbNewLine
        Next
        invQ.Close()
        text &= "[/spoiler]" & BattleLog.doubleLine

        Dim equipList As List(Of String) = New List(Of String)
        With (equipList)
            .Add("Head")
            .Add("Neck")
            .Add("Back")
            .Add("Chest")
            .Add("Shoulders")
            .Add("Wrists")
            .Add("Hands")
            .Add("Finger1")
            .Add("Finger2")
            .Add("Finger3")
            .Add("Finger4")
            .Add("Waist")
            .Add("Legs")
            .Add("Feet")
            .Add("RightArm")
            .Add("LeftArm")
            .Add("Ranged")
            .Add("Ammo")
        End With
        Dim eqQ = New SQLiteCommand("SELECT item_id FROM player_items WHERE player_id=" & TBX_ID.Text & " AND equip_slot=@slot", Common.sqLiteCon)

        text &= "~Equipped:" & vbNewLine & "[spoiler]" & vbNewLine
        For Each s As String In equipList
            text &= ProcessEquipped(eqQ, s)
        Next
        text &= "[/spoiler]" & BattleLog.doubleLine

        Dim sp = New SQLiteCommand("SELECT spells FROM player_spells WHERE player_id=" & TBX_ID.Text, Common.sqLiteCon).ExecuteScalar()
        text &= "Spells:" & vbNewLine & "[spoiler]" & vbNewLine
        If (sp IsNot Nothing) Then
            Dim spellz() As String = sp.ToString().Split(",")
            For Each s As String In spellz
                text &= Spells.GenerateSpellString(Integer.Parse(s)) & BattleLog.doubleLine
            Next
        End If
        text &= "[/spoiler]"

        GenerateWindow.open(text)
    End Sub

    Private Sub NUD_Stats_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUD_Str.ValueChanged, NUD_Agi.ValueChanged, NUD_Int.ValueChanged, NUD_Wil.ValueChanged, NUD_End.ValueChanged
        RecalculateRatings(True)
    End Sub

    Public Sub ReloadRaces()
        Dim sel = CBX_Race.SelectedItem
        CBX_Race.Items.Clear()
        Dim raceNameQuery = New SQLiteCommand("SELECT name FROM races", Common.sqLiteCon).ExecuteReader()
        While (raceNameQuery.Read())
            CBX_Race.Items.Add(raceNameQuery.Item(0))
        End While
        raceNameQuery.Close()
        CBX_Race.SelectedItem = sel
        RecalculateRatings()
    End Sub

    Public Sub ReloadClasses()
        Dim sel = CBX_Class.SelectedItem
        CBX_Class.Items.Clear()
        Dim classNameQuery = New SQLiteCommand("SELECT name FROM classes", Common.sqLiteCon).ExecuteReader()
        While (classNameQuery.Read())
            CBX_Class.Items.Add(classNameQuery.Item(0))
        End While
        classNameQuery.Close()
        CBX_Class.SelectedItem = sel
        RecalculateRatings()
    End Sub

    Private Sub CBX_Names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBX_Names.SelectedIndexChanged
        RecalculateRatings()
    End Sub

    Private Sub BTN_EditRace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_EditRace.Click
        If (Main.currentRacesInst Is Nothing) Then
            Main.currentRacesInst = New Races(CBX_Race.SelectedItem)
            Main.currentRacesInst.Show()
        End If
    End Sub

    Private Sub CBX_Race_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBX_Race.SelectedIndexChanged
        RecalculateRatings()
    End Sub

    Private Sub CBX_Class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBX_Class.SelectedIndexChanged
        RecalculateRatings()
    End Sub

    Private Sub BTN_EditClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_EditClass.Click
        If (Main.currentClassesInst Is Nothing) Then
            Main.currentClassesInst = New Classes(CBX_Class.SelectedItem)
            Main.currentClassesInst.Show()
        End If
    End Sub

    Private Sub BTN_Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Items.Click
        If (invWindow Is Nothing And TBX_ID.Text <> "") Then
            invWindow = New Inventory(Integer.Parse(TBX_ID.Text))
            invWindow.Show()
        End If
    End Sub

    Private Sub BTN_Trade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Trade.Click
        If (tsWindow Is Nothing And TBX_ID.Text <> "") Then
            tsWindow = New TradeSkills(Integer.Parse(TBX_ID.Text))
            tsWindow.Show()
        End If
    End Sub

    Private Sub BTN_Spells_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Spells.Click
        If (psWindow Is Nothing And TBX_ID.Text <> "") Then
            psWindow = New PlayerSpells(Integer.Parse(TBX_ID.Text))
            psWindow.Show()
        End If
    End Sub
End Class