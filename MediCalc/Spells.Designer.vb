<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spells
    Inherits MediCalc.DBInputForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CHX_Multicast = New System.Windows.Forms.CheckBox()
        Me.TBX_SpellString = New System.Windows.Forms.TextBox()
        Me.TBX_Damage = New System.Windows.Forms.TextBox()
        Me.RBN_Energy = New System.Windows.Forms.RadioButton()
        Me.RBN_Mana = New System.Windows.Forms.RadioButton()
        Me.NUD_Power = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CHX_Healing = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBX_Skill = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GBX_Use_settings = New System.Windows.Forms.GroupBox()
        Me.NUD_Turns = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Use_Duration = New System.Windows.Forms.Label()
        Me.GBX_Use_Bonuses = New System.Windows.Forms.GroupBox()
        Me.SLV_Specialties2 = New MediCalc.SkillsListView()
        Me.TBX_Custom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBX_Defense2 = New System.Windows.Forms.TextBox()
        Me.TBX_MinRanged2 = New System.Windows.Forms.TextBox()
        Me.TBX_MinMelee2 = New System.Windows.Forms.TextBox()
        Me.TBX_Magic2 = New System.Windows.Forms.TextBox()
        Me.TBX_Ranged2 = New System.Windows.Forms.TextBox()
        Me.TBX_Energy2 = New System.Windows.Forms.TextBox()
        Me.TBX_Melee2 = New System.Windows.Forms.TextBox()
        Me.TBX_Mana2 = New System.Windows.Forms.TextBox()
        Me.TBX_Hp2 = New System.Windows.Forms.TextBox()
        Me.TBX_RegEnergy = New System.Windows.Forms.TextBox()
        Me.TBX_RegMana = New System.Windows.Forms.TextBox()
        Me.TBX_End2 = New System.Windows.Forms.TextBox()
        Me.TBX_Wil2 = New System.Windows.Forms.TextBox()
        Me.TBX_Int2 = New System.Windows.Forms.TextBox()
        Me.TBX_Agi2 = New System.Windows.Forms.TextBox()
        Me.TBX_Str2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TBC_Effects = New System.Windows.Forms.TabControl()
        Me.MouseOverTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_Formula = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GBX_Use_settings.SuspendLayout()
        CType(Me.NUD_Turns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBX_Use_Bonuses.SuspendLayout()
        Me.TBC_Effects.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(53, 84)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(136, 20)
        Me.TBX_Name.TabIndex = 61
        '
        'LBL_Name
        '
        Me.LBL_Name.AutoSize = True
        Me.LBL_Name.Location = New System.Drawing.Point(12, 87)
        Me.LBL_Name.Name = "LBL_Name"
        Me.LBL_Name.Size = New System.Drawing.Size(35, 13)
        Me.LBL_Name.TabIndex = 60
        Me.LBL_Name.Text = "Name"
        '
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(442, 12)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 59
        Me.BTN_New.Text = "Add new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(523, 12)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 58
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(604, 12)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 57
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(240, 48)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(53, 20)
        Me.TBX_ID.TabIndex = 56
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(213, 51)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(21, 13)
        Me.LBL_ID.TabIndex = 55
        Me.LBL_ID.Text = "ID:"
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(15, 47)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 54
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(608, 401)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 64
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHX_Multicast)
        Me.GroupBox1.Controls.Add(Me.TBX_SpellString)
        Me.GroupBox1.Controls.Add(Me.TBX_Damage)
        Me.GroupBox1.Controls.Add(Me.RBN_Energy)
        Me.GroupBox1.Controls.Add(Me.RBN_Mana)
        Me.GroupBox1.Controls.Add(Me.NUD_Power)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.CHX_Healing)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CBX_Skill)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 285)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basics"
        '
        'CHX_Multicast
        '
        Me.CHX_Multicast.AutoSize = True
        Me.CHX_Multicast.Location = New System.Drawing.Point(14, 154)
        Me.CHX_Multicast.Name = "CHX_Multicast"
        Me.CHX_Multicast.Size = New System.Drawing.Size(68, 17)
        Me.CHX_Multicast.TabIndex = 120
        Me.CHX_Multicast.Text = "Multicast"
        Me.MouseOverTip.SetToolTip(Me.CHX_Multicast, "If checked, casting this spell on multiple enemies will only use power once.")
        Me.CHX_Multicast.UseVisualStyleBackColor = True
        '
        'TBX_SpellString
        '
        Me.TBX_SpellString.Location = New System.Drawing.Point(8, 196)
        Me.TBX_SpellString.Multiline = True
        Me.TBX_SpellString.Name = "TBX_SpellString"
        Me.TBX_SpellString.ReadOnly = True
        Me.TBX_SpellString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_SpellString.Size = New System.Drawing.Size(259, 70)
        Me.TBX_SpellString.TabIndex = 119
        '
        'TBX_Damage
        '
        Me.TBX_Damage.BackColor = System.Drawing.Color.Azure
        Me.TBX_Damage.Location = New System.Drawing.Point(123, 49)
        Me.TBX_Damage.Name = "TBX_Damage"
        Me.TBX_Damage.Size = New System.Drawing.Size(121, 20)
        Me.TBX_Damage.TabIndex = 118
        '
        'RBN_Energy
        '
        Me.RBN_Energy.AutoSize = True
        Me.RBN_Energy.Location = New System.Drawing.Point(197, 124)
        Me.RBN_Energy.Name = "RBN_Energy"
        Me.RBN_Energy.Size = New System.Drawing.Size(58, 17)
        Me.RBN_Energy.TabIndex = 10
        Me.RBN_Energy.TabStop = True
        Me.RBN_Energy.Text = "Energy"
        Me.RBN_Energy.UseVisualStyleBackColor = True
        '
        'RBN_Mana
        '
        Me.RBN_Mana.AutoSize = True
        Me.RBN_Mana.Location = New System.Drawing.Point(197, 101)
        Me.RBN_Mana.Name = "RBN_Mana"
        Me.RBN_Mana.Size = New System.Drawing.Size(52, 17)
        Me.RBN_Mana.TabIndex = 9
        Me.RBN_Mana.TabStop = True
        Me.RBN_Mana.Text = "Mana"
        Me.RBN_Mana.UseVisualStyleBackColor = True
        '
        'NUD_Power
        '
        Me.NUD_Power.Location = New System.Drawing.Point(125, 111)
        Me.NUD_Power.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NUD_Power.Name = "NUD_Power"
        Me.NUD_Power.Size = New System.Drawing.Size(49, 20)
        Me.NUD_Power.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Base power cost"
        '
        'CHX_Healing
        '
        Me.CHX_Healing.AutoSize = True
        Me.CHX_Healing.Location = New System.Drawing.Point(14, 83)
        Me.CHX_Healing.Name = "CHX_Healing"
        Me.CHX_Healing.Size = New System.Drawing.Size(62, 17)
        Me.CHX_Healing.TabIndex = 6
        Me.CHX_Healing.Text = "Healing"
        Me.CHX_Healing.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Base damage formula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Skill"
        '
        'CBX_Skill
        '
        Me.CBX_Skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Skill.FormattingEnabled = True
        Me.CBX_Skill.Items.AddRange(New Object() {"Non-elemental", "Arcane", "Fire", "Water", "Wind/Air", "Stone/Earth", "Nature", "Light", "Shadow"})
        Me.CBX_Skill.Location = New System.Drawing.Point(123, 17)
        Me.CBX_Skill.Name = "CBX_Skill"
        Me.CBX_Skill.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Skill.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GBX_Use_settings)
        Me.TabPage1.Controls.Add(Me.GBX_Use_Bonuses)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Effects"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GBX_Use_settings
        '
        Me.GBX_Use_settings.Controls.Add(Me.NUD_Turns)
        Me.GBX_Use_settings.Controls.Add(Me.LBL_Use_Duration)
        Me.GBX_Use_settings.Location = New System.Drawing.Point(6, 3)
        Me.GBX_Use_settings.Name = "GBX_Use_settings"
        Me.GBX_Use_settings.Size = New System.Drawing.Size(349, 45)
        Me.GBX_Use_settings.TabIndex = 5
        Me.GBX_Use_settings.TabStop = False
        Me.GBX_Use_settings.Text = "Settings"
        '
        'NUD_Turns
        '
        Me.NUD_Turns.Location = New System.Drawing.Point(176, 17)
        Me.NUD_Turns.Name = "NUD_Turns"
        Me.NUD_Turns.Size = New System.Drawing.Size(59, 20)
        Me.NUD_Turns.TabIndex = 1
        '
        'LBL_Use_Duration
        '
        Me.LBL_Use_Duration.AutoSize = True
        Me.LBL_Use_Duration.Location = New System.Drawing.Point(9, 20)
        Me.LBL_Use_Duration.Name = "LBL_Use_Duration"
        Me.LBL_Use_Duration.Size = New System.Drawing.Size(161, 13)
        Me.LBL_Use_Duration.TabIndex = 0
        Me.LBL_Use_Duration.Text = "Turn duration (0 for rest of battle)"
        '
        'GBX_Use_Bonuses
        '
        Me.GBX_Use_Bonuses.Controls.Add(Me.SLV_Specialties2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Custom)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Defense2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_MinRanged2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_MinMelee2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Magic2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Ranged2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Energy2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Melee2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Mana2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Hp2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_RegEnergy)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_RegMana)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_End2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Wil2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Int2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Agi2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.TBX_Str2)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label20)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label21)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label17)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label16)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label5)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label6)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label7)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label8)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label9)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label10)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label11)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label12)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label13)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label14)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label15)
        Me.GBX_Use_Bonuses.Controls.Add(Me.Label19)
        Me.GBX_Use_Bonuses.Location = New System.Drawing.Point(6, 54)
        Me.GBX_Use_Bonuses.Name = "GBX_Use_Bonuses"
        Me.GBX_Use_Bonuses.Size = New System.Drawing.Size(349, 511)
        Me.GBX_Use_Bonuses.TabIndex = 4
        Me.GBX_Use_Bonuses.TabStop = False
        Me.GBX_Use_Bonuses.Text = "Bonuses"
        '
        'SLV_Specialties2
        '
        Me.SLV_Specialties2.Editable = True
        Me.SLV_Specialties2.Location = New System.Drawing.Point(33, 98)
        Me.SLV_Specialties2.Name = "SLV_Specialties2"
        Me.SLV_Specialties2.Size = New System.Drawing.Size(283, 163)
        Me.SLV_Specialties2.TabIndex = 131
        '
        'TBX_Custom
        '
        Me.TBX_Custom.Location = New System.Drawing.Point(10, 437)
        Me.TBX_Custom.Multiline = True
        Me.TBX_Custom.Name = "TBX_Custom"
        Me.TBX_Custom.Size = New System.Drawing.Size(331, 65)
        Me.TBX_Custom.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Custom effect / Description"
        '
        'TBX_Defense2
        '
        Me.TBX_Defense2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Defense2.Location = New System.Drawing.Point(77, 386)
        Me.TBX_Defense2.Name = "TBX_Defense2"
        Me.TBX_Defense2.Size = New System.Drawing.Size(79, 20)
        Me.TBX_Defense2.TabIndex = 128
        '
        'TBX_MinRanged2
        '
        Me.TBX_MinRanged2.BackColor = System.Drawing.Color.Azure
        Me.TBX_MinRanged2.Location = New System.Drawing.Point(252, 363)
        Me.TBX_MinRanged2.Name = "TBX_MinRanged2"
        Me.TBX_MinRanged2.Size = New System.Drawing.Size(91, 20)
        Me.TBX_MinRanged2.TabIndex = 127
        '
        'TBX_MinMelee2
        '
        Me.TBX_MinMelee2.BackColor = System.Drawing.Color.Azure
        Me.TBX_MinMelee2.Location = New System.Drawing.Point(252, 341)
        Me.TBX_MinMelee2.Name = "TBX_MinMelee2"
        Me.TBX_MinMelee2.Size = New System.Drawing.Size(91, 20)
        Me.TBX_MinMelee2.TabIndex = 126
        '
        'TBX_Magic2
        '
        Me.TBX_Magic2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Magic2.Location = New System.Drawing.Point(252, 319)
        Me.TBX_Magic2.Name = "TBX_Magic2"
        Me.TBX_Magic2.Size = New System.Drawing.Size(91, 20)
        Me.TBX_Magic2.TabIndex = 125
        '
        'TBX_Ranged2
        '
        Me.TBX_Ranged2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Ranged2.Location = New System.Drawing.Point(252, 297)
        Me.TBX_Ranged2.Name = "TBX_Ranged2"
        Me.TBX_Ranged2.Size = New System.Drawing.Size(91, 20)
        Me.TBX_Ranged2.TabIndex = 124
        '
        'TBX_Energy2
        '
        Me.TBX_Energy2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Energy2.Location = New System.Drawing.Point(77, 364)
        Me.TBX_Energy2.Name = "TBX_Energy2"
        Me.TBX_Energy2.Size = New System.Drawing.Size(79, 20)
        Me.TBX_Energy2.TabIndex = 123
        '
        'TBX_Melee2
        '
        Me.TBX_Melee2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Melee2.Location = New System.Drawing.Point(252, 274)
        Me.TBX_Melee2.Name = "TBX_Melee2"
        Me.TBX_Melee2.Size = New System.Drawing.Size(91, 20)
        Me.TBX_Melee2.TabIndex = 122
        '
        'TBX_Mana2
        '
        Me.TBX_Mana2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Mana2.Location = New System.Drawing.Point(77, 343)
        Me.TBX_Mana2.Name = "TBX_Mana2"
        Me.TBX_Mana2.Size = New System.Drawing.Size(79, 20)
        Me.TBX_Mana2.TabIndex = 121
        '
        'TBX_Hp2
        '
        Me.TBX_Hp2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Hp2.Location = New System.Drawing.Point(77, 321)
        Me.TBX_Hp2.Name = "TBX_Hp2"
        Me.TBX_Hp2.Size = New System.Drawing.Size(79, 20)
        Me.TBX_Hp2.TabIndex = 120
        '
        'TBX_RegEnergy
        '
        Me.TBX_RegEnergy.BackColor = System.Drawing.Color.Azure
        Me.TBX_RegEnergy.Location = New System.Drawing.Point(77, 299)
        Me.TBX_RegEnergy.Name = "TBX_RegEnergy"
        Me.TBX_RegEnergy.Size = New System.Drawing.Size(79, 20)
        Me.TBX_RegEnergy.TabIndex = 119
        '
        'TBX_RegMana
        '
        Me.TBX_RegMana.BackColor = System.Drawing.Color.Azure
        Me.TBX_RegMana.Location = New System.Drawing.Point(77, 277)
        Me.TBX_RegMana.Name = "TBX_RegMana"
        Me.TBX_RegMana.Size = New System.Drawing.Size(79, 20)
        Me.TBX_RegMana.TabIndex = 118
        '
        'TBX_End2
        '
        Me.TBX_End2.BackColor = System.Drawing.Color.Azure
        Me.TBX_End2.Location = New System.Drawing.Point(240, 46)
        Me.TBX_End2.Name = "TBX_End2"
        Me.TBX_End2.Size = New System.Drawing.Size(103, 20)
        Me.TBX_End2.TabIndex = 116
        '
        'TBX_Wil2
        '
        Me.TBX_Wil2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Wil2.Location = New System.Drawing.Point(240, 20)
        Me.TBX_Wil2.Name = "TBX_Wil2"
        Me.TBX_Wil2.Size = New System.Drawing.Size(103, 20)
        Me.TBX_Wil2.TabIndex = 115
        '
        'TBX_Int2
        '
        Me.TBX_Int2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Int2.Location = New System.Drawing.Point(68, 70)
        Me.TBX_Int2.Name = "TBX_Int2"
        Me.TBX_Int2.Size = New System.Drawing.Size(103, 20)
        Me.TBX_Int2.TabIndex = 114
        '
        'TBX_Agi2
        '
        Me.TBX_Agi2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Agi2.Location = New System.Drawing.Point(68, 45)
        Me.TBX_Agi2.Name = "TBX_Agi2"
        Me.TBX_Agi2.Size = New System.Drawing.Size(103, 20)
        Me.TBX_Agi2.TabIndex = 113
        '
        'TBX_Str2
        '
        Me.TBX_Str2.BackColor = System.Drawing.Color.Azure
        Me.TBX_Str2.Location = New System.Drawing.Point(68, 21)
        Me.TBX_Str2.Name = "TBX_Str2"
        Me.TBX_Str2.Size = New System.Drawing.Size(103, 20)
        Me.TBX_Str2.TabIndex = 112
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(161, 367)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 13)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Bonus min ranged"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(161, 344)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 13)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "Bonus min melee"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 301)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Energy"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 279)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Mana"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Endurance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Strength"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Willpower"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Defense"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Agility"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(161, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Bonus magic"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Intelligence"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Bonus ranged"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Max Energy"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Max Health"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Max Mana"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(161, 281)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Bonus melee"
        '
        'TBC_Effects
        '
        Me.TBC_Effects.Controls.Add(Me.TabPage1)
        Me.TBC_Effects.Location = New System.Drawing.Point(299, 48)
        Me.TBC_Effects.Name = "TBC_Effects"
        Me.TBC_Effects.SelectedIndex = 0
        Me.TBC_Effects.Size = New System.Drawing.Size(384, 347)
        Me.TBC_Effects.TabIndex = 66
        '
        'BTN_Formula
        '
        Me.BTN_Formula.Location = New System.Drawing.Point(13, 12)
        Me.BTN_Formula.Name = "BTN_Formula"
        Me.BTN_Formula.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Formula.TabIndex = 67
        Me.BTN_Formula.Text = "Formula help"
        Me.BTN_Formula.UseVisualStyleBackColor = True
        '
        'Spells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 431)
        Me.Controls.Add(Me.BTN_Formula)
        Me.Controls.Add(Me.TBC_Effects)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.TBX_Name)
        Me.Controls.Add(Me.LBL_Name)
        Me.Controls.Add(Me.BTN_New)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.CBX_Names)
        Me.Name = "Spells"
        Me.Text = "Spells"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_Power, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GBX_Use_settings.ResumeLayout(False)
        Me.GBX_Use_settings.PerformLayout()
        CType(Me.NUD_Turns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBX_Use_Bonuses.ResumeLayout(False)
        Me.GBX_Use_Bonuses.PerformLayout()
        Me.TBC_Effects.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Name As System.Windows.Forms.Label
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBX_Skill As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CHX_Healing As System.Windows.Forms.CheckBox
    Friend WithEvents RBN_Energy As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Mana As System.Windows.Forms.RadioButton
    Friend WithEvents NUD_Power As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TBC_Effects As System.Windows.Forms.TabControl
    Friend WithEvents GBX_Use_settings As System.Windows.Forms.GroupBox
    Friend WithEvents NUD_Turns As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Use_Duration As System.Windows.Forms.Label
    Friend WithEvents GBX_Use_Bonuses As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_Defense2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_MinRanged2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_MinMelee2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Magic2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Ranged2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Energy2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Melee2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Mana2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Hp2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_RegEnergy As System.Windows.Forms.TextBox
    Friend WithEvents TBX_RegMana As System.Windows.Forms.TextBox
    Friend WithEvents TBX_End2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Wil2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Int2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Agi2 As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Str2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TBX_Damage As System.Windows.Forms.TextBox
    Friend WithEvents TBX_SpellString As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Custom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CHX_Multicast As System.Windows.Forms.CheckBox
    Friend WithEvents MouseOverTip As System.Windows.Forms.ToolTip
    Friend WithEvents SLV_Specialties2 As MediCalc.SkillsListView
    Friend WithEvents BTN_Formula As System.Windows.Forms.Button
End Class
