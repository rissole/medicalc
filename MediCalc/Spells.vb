Public Class Spells
    Inherits DBInputForm

    Private RBS_PowerType As RadioButtonSet = New RadioButtonSet()
    Private FCS_Healing As FlaggedCheckButtonSet = New FlaggedCheckButtonSet()
    Private FCS_Multicast As FlaggedCheckButtonSet = New FlaggedCheckButtonSet()
    Private FormulaBoxes As List(Of TextBox) = New List(Of TextBox)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        RBS_PowerType.Add(RBN_Mana, 1)
        RBS_PowerType.Add(RBN_Energy, 2)
        FCS_Healing.Add(CHX_Healing)
        FCS_Multicast.Add(CHX_Multicast)
        With (FormulaBoxes)
            .Add(TBX_Damage)
            .Add(TBX_Defense2)
            .Add(TBX_MinRanged2)
            .Add(TBX_MinMelee2)
            .Add(TBX_Magic2)
            .Add(TBX_Ranged2)
            .Add(TBX_Energy2)
            .Add(TBX_Melee2)
            .Add(TBX_Mana2)
            .Add(TBX_Hp2)
            .Add(TBX_RegEnergy)
            .Add(TBX_RegMana)
            .Add(TBX_End2)
            .Add(TBX_Wil2)
            .Add(TBX_Int2)
            .Add(TBX_Agi2)
            .Add(TBX_Str2)
        End With

        SetTableName("spells")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("name", TBX_Name)
        AssocField("skill", CBX_Skill)
        AssocField("damage_formula", TBX_Damage)
        AssocField("is_healing", FCS_Healing)
        AssocField("power_cost", NUD_Power)
        AssocField("power_type", RBS_PowerType)
        AssocField("multicast", FCS_Multicast)
        AssocField("custom_string", TBX_Custom)
        AssocField("eff_duration", NUD_Turns)
        AssocField("eff_stat_str", TBX_Str2)
        AssocField("eff_stat_agi", TBX_Agi2)
        AssocField("eff_stat_int", TBX_Int2)
        AssocField("eff_stat_wil", TBX_Wil2)
        AssocField("eff_stat_end", TBX_End2)
        AssocField("eff_skills", SLV_Specialties2)
        AssocField("eff_mana", TBX_RegMana)
        AssocField("eff_energy", TBX_RegEnergy)
        AssocField("eff_maxhp", TBX_Hp2)
        AssocField("eff_maxmana", TBX_Mana2)
        AssocField("eff_maxenergy", TBX_Energy2)
        AssocField("eff_melee", TBX_Melee2)
        AssocField("eff_minmelee", TBX_MinMelee2)
        AssocField("eff_ranged", TBX_Ranged2)
        AssocField("eff_minranged", TBX_MinRanged2)
        AssocField("eff_magic", TBX_Magic2)
        AssocField("eff_defense", TBX_Defense2)

    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        forceClose = True
        SaveContent(True)
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
        Main.currentSpellsInst = Nothing
    End Sub

    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.DBInputForm_Load()
        RefreshSpellString()
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        Dim invalidBox As TextBox = Common.ValidateFormula(FormulaBoxes)
        If (invalidBox IsNot Nothing) Then
            MsgBox("Invalid formula entered for " & GetAssocField(invalidBox))
            Return
        End If
        SaveContent()
        RefreshSpellString()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.psWindow Is Nothing) Then
                Main.currentPlayersInst.psWindow.RefreshStuff()
            End If
        End If
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        AddNew()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.psWindow Is Nothing) Then
                Main.currentPlayersInst.psWindow.RefreshStuff()
            End If
        End If
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        DeleteEntry()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.psWindow Is Nothing) Then
                Main.currentPlayersInst.psWindow.RefreshStuff()
            End If
        End If
    End Sub

    Private Sub TBX_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBX_ID.TextChanged
        RefreshSpellString()
    End Sub

    Public Shared Function GenerateSpellString(ByVal id As UInteger) As String
        Dim ret As String = ""
        Dim itemQuery = Common.sqLiteCon.CreateCommand()
        itemQuery.CommandText = "SELECT * FROM spells WHERE id=" & id
        Dim itemRead = itemQuery.ExecuteReader()
        If (Not itemRead.Read()) Then
            itemRead.Close()
            Return ret
        End If
        ret &= itemRead.Item("name") & ": "
        ret &= IIf(itemRead.Item("skill").Length > 0, "[" & itemRead.Item("skill") & " spell] ", " ")
        ret &= IIf(itemRead.Item("is_healing") > 0, "Healing: ", "Damage: ")
        ret &= IIf(itemRead.Item("damage_formula").Length > 0, itemRead.Item("damage_formula"), "NULL") & ", "
        ret &= "Costs " & itemRead.Item("power_cost") & " "
        If (itemRead.Item("power_type") = 1) Then
            ret &= "Mana"
        ElseIf (itemRead.Item("power_type") = 2) Then
            ret &= "Energy"
        End If
        ret &= " "

        'effects
        Dim statsStr As String = ""
        For i As Integer = 10 To 25
            If (itemRead.GetName(i) = "eff_skills") Then Continue For
            If (itemRead.GetString(i) = "0" Or itemRead.GetString(i) = "") Then Continue For
            statsStr &= Items.GetStatNameFromString(itemRead.GetName(i)) & ": " & IIf(itemRead.GetString(i).StartsWith("-"), "", "+") & itemRead.GetString(i) & ", "
        Next
        Dim skillStr As String = Items.GetSkillString(itemRead.Item("eff_skills"))
        If (statsStr.Length > 0 Or skillStr.Length > 0 Or itemRead.Item("custom_string").Length > 0) Then
            ret &= "[EFFECTS] "
        End If
        If (statsStr.Length > 0 Or skillStr.Length > 0) Then
            If (statsStr.Length > 0 And skillStr.Length = 0) Then
                Common.RemoveLastChars(statsStr, 2)
            End If
            ret &= "(" & statsStr & skillStr & ") "
        End If
        ret = ret.Replace("|", "to")
        If (itemRead.Item("custom_string") <> "") Then
            ret &= "(" & itemRead.Item("custom_string") & ") "
        End If
        If (itemRead.Item("eff_duration") > 0) Then
            ret &= "[Lasts " & itemRead.Item("eff_duration") & " turn(s)] "
        End If
        itemRead.Close()
        Return ret
    End Function

    Private Sub RefreshSpellString()
        If (IsNumeric(TBX_ID.Text)) Then
            TBX_SpellString.Text = GenerateSpellString(Integer.Parse(TBX_ID.Text))
        Else
            TBX_SpellString.Text = ""
        End If
    End Sub

    Private Sub BTN_Formula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Formula.Click
        Dim msg As String = <a><![CDATA[
Any text box with a light blue background can be a formula.

| (pipe character) -> Signifies range, eg. 5 | 10 would evaluate to a random number between 5 and 10.

STR, AGI, INT, WIL, END -> Player stats.

LVL -> Level.

(MAX_)ENERGY, (MAX_)HP, (MAX_)MANA, (MIN_)MELEE, (MIN_)RANGED, MAGIC, DEF -> Player ratings.

SKILL:skillname; -> Player skill, eg SKILL:Unarmed Combat; would evaluate to the player's damage+ with unarmed combat skill.

t prefix -> The target's value. Eg: tLVL would become the target's level, tINT would become the target's intellect.
                            ]]></a>.Value
        MsgBox(msg)
    End Sub
End Class