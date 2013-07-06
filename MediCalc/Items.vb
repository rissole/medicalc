Public Class Items
    Inherits DBInputForm

    Private RBS_Stackable As RadioButtonSet = New RadioButtonSet()
    Private FCS_Type As FlaggedCheckButtonSet = New FlaggedCheckButtonSet()
    Private FormulaBoxes As List(Of TextBox) = New List(Of TextBox)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        FCS_Type.Add(CHX_Equipable)
        FCS_Type.Add(CHX_Usable)
        RBS_Stackable.Add(RBN_StackNo, 0)
        RBS_Stackable.Add(RBN_StackYes, 1)
        With (FormulaBoxes)
            .Add(TBX_Defense2)
            .Add(TBX_MinRanged2)
            .Add(TBX_MinMelee2)
            .Add(TBX_Magic2)
            .Add(TBX_Ranged2)
            .Add(TBX_Energy2)
            .Add(TBX_Melee2)
            .Add(TBX_Mana2)
            .Add(TBX_Hp2)
            .Add(TBX_RegHp)
            .Add(TBX_RegEnergy)
            .Add(TBX_RegMana)
            .Add(TBX_End2)
            .Add(TBX_Wil2)
            .Add(TBX_Int2)
            .Add(TBX_Agi2)
            .Add(TBX_Str2)
        End With

        SetTableName("items")
        AssocField("!NameList", CBX_Names)
        AssocField("id", TBX_ID)
        AssocField("name", TBX_Name)
        AssocField("desc", TBX_Description)
        AssocField("type", FCS_Type)
        AssocField("stackable", RBS_Stackable)
        AssocField("equip_slot", CBX_Equip_Slot)
        AssocField("equip_stat_str", NUD_Str)
        AssocField("equip_stat_agi", NUD_Agi)
        AssocField("equip_stat_int", NUD_Int)
        AssocField("equip_stat_wil", NUD_Wil)
        AssocField("equip_stat_end", NUD_End)
        AssocField("equip_skills", SLV_Specialties)
        AssocField("equip_maxhp", NUD_Hp)
        AssocField("equip_maxmana", NUD_Mana)
        AssocField("equip_maxenergy", NUD_Energy)
        AssocField("equip_melee", NUD_Melee)
        AssocField("equip_minmelee", NUD_MinMelee)
        AssocField("equip_ranged", NUD_Ranged)
        AssocField("equip_minranged", NUD_MinRanged)
        AssocField("equip_magic", NUD_Magic)
        AssocField("equip_defense", NUD_Defense)
        AssocField("use_duration", NUD_Turns)
        AssocField("use_stat_str", TBX_Str2)
        AssocField("use_stat_agi", TBX_Agi2)
        AssocField("use_stat_int", TBX_Int2)
        AssocField("use_stat_wil", TBX_Wil2)
        AssocField("use_stat_end", TBX_End2)
        AssocField("use_skills", SLV_Specialties2)
        AssocField("use_hp", TBX_RegHp)
        AssocField("use_mana", TBX_RegMana)
        AssocField("use_energy", TBX_RegEnergy)
        AssocField("use_maxhp", TBX_Hp2)
        AssocField("use_maxmana", TBX_Mana2)
        AssocField("use_maxenergy", TBX_Energy2)
        AssocField("use_melee", TBX_Melee2)
        AssocField("use_minmelee", TBX_MinMelee2)
        AssocField("use_ranged", TBX_Ranged2)
        AssocField("use_minranged", TBX_MinRanged2)
        AssocField("use_magic", TBX_Magic2)
        AssocField("use_defense", TBX_Defense2)
        AssocField("use_custom", TBX_Use_Custom)
        AssocField("weapon_type", CBX_WeaponType)
        AssocField("equipment_type", CBX_EquipType)

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
        Main.currentItemsInst = Nothing
    End Sub

    Private Sub MeLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.DBInputForm_Load()
        RefreshItemString()
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        Dim invalidBox As TextBox = Common.ValidateFormula(FormulaBoxes)
        If (invalidBox IsNot Nothing) Then
            MsgBox("Invalid formula entered for " & GetAssocField(invalidBox))
            Return
        End If
        SaveContent()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.invWindow Is Nothing) Then
                Main.currentPlayersInst.invWindow.RefreshStuff()
            End If
        End If
        RefreshItemString()
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        AddNew()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.invWindow Is Nothing) Then
                Main.currentPlayersInst.invWindow.RefreshStuff()
            End If
        End If
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        DeleteEntry()
        If (Not Main.currentPlayersInst Is Nothing) Then
            If (Not Main.currentPlayersInst.invWindow Is Nothing) Then
                Main.currentPlayersInst.invWindow.RefreshStuff()
            End If
        End If
    End Sub

    Public Shared Function GetStatNameFromString(ByVal someString As String)
        someString = someString.ToLower()
        If (someString.Contains("maxhp")) Then
            Return "Max Health"
        ElseIf (someString.Contains("maxmana")) Then
            Return "Max Mana"
        ElseIf (someString.Contains("maxenergy")) Then
            Return "Max Energy"
        ElseIf (someString.Contains("minmelee")) Then
            Return "Min Melee Damage"
        ElseIf (someString.Contains("minranged")) Then
            Return "Min Ranged Damage"
        ElseIf (someString.Contains("hp")) Then
            Return "Health"
        ElseIf (someString.Contains("mana")) Then
            Return "Mana"
        ElseIf (someString.Contains("energy")) Then
            Return "Energy"
        ElseIf (someString.Contains("melee")) Then
            Return "Melee Damage"
        ElseIf (someString.Contains("ranged")) Then
            Return "Ranged Damage"
        ElseIf (someString.Contains("magic")) Then
            Return "Magic Damage"
        ElseIf (someString.Contains("def")) Then
            Return "Defense"
        ElseIf (someString.Contains("str")) Then
            Return "Strength"
        ElseIf (someString.Contains("agi")) Then
            Return "Agility"
        ElseIf (someString.Contains("int")) Then
            Return "Intellect"
        ElseIf (someString.Contains("wil")) Then
            Return "Willpower"
        ElseIf (someString.Contains("end")) Then
            Return "Endurance"
        End If
        Return "Unknown"
    End Function

    Public Shared Function GetSkillString(ByVal commaSepSet As String) As String
        Dim valArray As String() = commaSepSet.ToString().Split(",")
        Dim ret As String = ""
        If (valArray.Length <> SkillsListView.GetSkillsCount()) Then
            MsgBox("Count mismatch on ListView (got " & valArray.Length & ", expected " & SkillsListView.GetSkillsCount() & ")")
            Return ""
        End If
        For i As Integer = 0 To SkillsListView.GetSkillsCount() - 1
            If (valArray(i) = "0") Then Continue For
            ret &= SkillsListView.GetSkillName(i) & " Dmg: " & IIf(Integer.Parse(valArray(i)) >= 0, "+", "") & valArray(i) & ", "
        Next
        If (ret.Length > 0) Then
            Common.RemoveLastChars(ret, 2)
        End If
        Return ret
    End Function

    Public Shared Function GetSkillSingular(ByVal skill As String) As String
        If (skill = "Unarmed Combat") Then
            Return "Unarmed"
        ElseIf (skill = "Daggers and Knives") Then
            Return "Dagger"
        ElseIf (skill = "Swords and Claymores") Then
            Return "Sword"
        ElseIf (skill = "Axes") Then
            Return "Axe"
        ElseIf (skill = "Hammers") Then
            Return "Hammer"
        ElseIf (skill = "Staves") Then
            Return "Staff"
        ElseIf (skill = "Wands") Then
            Return "Wand"
        ElseIf (skill = "Polearms and Spears") Then
            Return "Polearm"
        ElseIf (skill = "Bows") Then
            Return "Bow"
        ElseIf (skill = "Crossbows") Then
            Return "Crossbow"
        ElseIf (skill = "Thrown") Then
            Return "Thrown"
        Else
            Return skill
        End If
    End Function

    Public Shared Function GenerateItemString(ByVal id As UInteger) As String
        Dim ret As String = ""
        Dim itemQuery = Common.sqLiteCon.CreateCommand()
        itemQuery.CommandText = "SELECT * FROM items WHERE id=" & id
        Dim itemRead = itemQuery.ExecuteReader()
        If (Not itemRead.Read()) Then
            Return ret
        End If
        ret &= itemRead.Item("name") & " "
        'EQUIP:
        If ((CType(itemRead.Item("type"), UInteger) And 1) > 0 And itemRead.Item("equip_slot") <> "None") Then
            ret &= "[" & itemRead.Item("equip_slot") & "] "
            If (itemRead.Item("weapon_type") <> "" And itemRead.Item("weapon_type") <> "None") Then
                ret &= "[" & GetSkillSingular(itemRead.Item("weapon_type")) & "] "
            End If
            If (itemRead.Item("equipment_type") <> "" And itemRead.Item("equipment_type") <> "None") Then
                ret &= "[" & GetSkillSingular(itemRead.Item("equipment_type")) & "] "
            End If
            Dim statsStr As String = ""
            For i As Integer = 6 To 20
                If (itemRead.GetName(i) = "equip_skills") Then Continue For
                If (itemRead.GetInt32(i) = 0) Then Continue For
                statsStr &= Items.GetStatNameFromString(itemRead.GetName(i)) & ": " & IIf(itemRead.GetInt32(i) >= 0, "+", "") & itemRead.GetInt32(i) & ", "
            Next
            Dim skillStr As String = GetSkillString(itemRead.Item("equip_skills"))
            If (statsStr.Length > 0 Or skillStr.Length > 0) Then
                If (statsStr.Length > 0 And skillStr.Length = 0) Then
                    Common.RemoveLastChars(statsStr, 2)
                End If
                ret &= "(" & statsStr & skillStr & ") "
            End If
        End If
        'USE:
        If ((CType(itemRead.Item("type"), UInteger) And 2) > 0) Then
            Dim statsStr As String = ""
            For i As Integer = 22 To 37
                If (itemRead.GetName(i) = "use_skills") Then Continue For
                If (itemRead.GetString(i) = "0" Or itemRead.GetString(i) = "") Then Continue For
                statsStr &= Items.GetStatNameFromString(itemRead.GetName(i)) & ": " & IIf(itemRead.GetString(i).StartsWith("-"), "", "+") & itemRead.GetString(i) & ", "
            Next
            Dim skillStr As String = GetSkillString(itemRead.Item("use_skills"))
            If (statsStr.Length > 0 Or skillStr.Length > 0 Or itemRead.Item("use_custom").Length > 0) Then
                ret &= "[ON USE] "
            End If
            If (statsStr.Length > 0 Or skillStr.Length > 0) Then
                If (statsStr.Length > 0 And skillStr.Length = 0) Then
                    Common.RemoveLastChars(statsStr, 2)
                End If
                ret &= "(" & statsStr & skillStr & ") "
            End If
            ret = ret.Replace("|", "to")
            If (itemRead.Item("use_custom") <> "") Then
                ret &= "(" & itemRead.Item("use_custom") & ") "
            End If
            If (ret.Contains("ON USE:") And itemRead.Item("use_duration") <> 0) Then
                ret &= "[Lasts " & itemRead.Item("use_duration") & " turn(s)] "
            End If
        End If
        If (itemRead.Item("desc") <> "") Then
            ret &= "(""" & itemRead.Item("desc") & """)"
        End If
        itemRead.Close()
        Return ret
    End Function

    Private Sub RefreshItemString()
        If (IsNumeric(TBX_ID.Text)) Then
            TBX_ItemString.Text = GenerateItemString(Integer.Parse(TBX_ID.Text))
        Else
            TBX_ItemString.Text = ""
        End If
    End Sub

    Private Sub TBX_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBX_ID.TextChanged
        RefreshItemString()
    End Sub

    Private Sub BTN_FormulaHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FormulaHelp.Click
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