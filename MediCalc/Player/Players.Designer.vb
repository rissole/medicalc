<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Players
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
        Me.CDG_Color = New System.Windows.Forms.ColorDialog()
        Me.BTN_Generate = New System.Windows.Forms.Button()
        Me.BTN_Spells = New System.Windows.Forms.Button()
        Me.BTN_Trade = New System.Windows.Forms.Button()
        Me.BTN_Items = New System.Windows.Forms.Button()
        Me.GBX_Stats = New System.Windows.Forms.GroupBox()
        Me.SLV_Specialties = New MediCalc.SkillsListView()
        Me.NUD_Slots = New System.Windows.Forms.NumericUpDown()
        Me.LBL_BonusSlots = New System.Windows.Forms.Label()
        Me.NUD_Defense = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Magic = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Ranged = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Melee = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Energy = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Mana = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Hp = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Def = New System.Windows.Forms.Label()
        Me.LBL_BonusS = New System.Windows.Forms.Label()
        Me.LBL_BonusR = New System.Windows.Forms.Label()
        Me.LBL_BonusM = New System.Windows.Forms.Label()
        Me.LBL_Energy = New System.Windows.Forms.Label()
        Me.LBL_Mana = New System.Windows.Forms.Label()
        Me.LBL_Hp = New System.Windows.Forms.Label()
        Me.NUD_Exp = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Exp = New System.Windows.Forms.Label()
        Me.NUD_Level = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Level = New System.Windows.Forms.Label()
        Me.NUD_End = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_Wil = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Willpower = New System.Windows.Forms.Label()
        Me.NUD_Int = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Int = New System.Windows.Forms.Label()
        Me.NUD_Agi = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Agility = New System.Windows.Forms.Label()
        Me.NUD_Str = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Strength = New System.Windows.Forms.Label()
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.GBX_Demographics = New System.Windows.Forms.GroupBox()
        Me.BTN_EditClass = New System.Windows.Forms.Button()
        Me.CBX_Class = New System.Windows.Forms.ComboBox()
        Me.BTN_EditRace = New System.Windows.Forms.Button()
        Me.CBX_Race = New System.Windows.Forms.ComboBox()
        Me.LBL_Class = New System.Windows.Forms.Label()
        Me.LBL_Race = New System.Windows.Forms.Label()
        Me.BTN_SetColor = New System.Windows.Forms.Button()
        Me.TBX_Color = New System.Windows.Forms.TextBox()
        Me.LBL_NameColor = New System.Windows.Forms.Label()
        Me.LBL_More = New System.Windows.Forms.Label()
        Me.TBX_More = New System.Windows.Forms.TextBox()
        Me.TBX_History = New System.Windows.Forms.TextBox()
        Me.LBL_History = New System.Windows.Forms.Label()
        Me.TBX_Physdesc = New System.Windows.Forms.TextBox()
        Me.LBL_Physdesc = New System.Windows.Forms.Label()
        Me.RBN_Female = New System.Windows.Forms.RadioButton()
        Me.RBN_Male = New System.Windows.Forms.RadioButton()
        Me.LBL_Gender = New System.Windows.Forms.Label()
        Me.NUD_Age = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Age = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.GBX_Stats.SuspendLayout()
        CType(Me.NUD_Slots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Defense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Magic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Ranged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Melee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Energy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Mana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Hp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Exp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBX_Demographics.SuspendLayout()
        CType(Me.NUD_Age, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Generate
        '
        Me.BTN_Generate.Location = New System.Drawing.Point(453, 479)
        Me.BTN_Generate.Name = "BTN_Generate"
        Me.BTN_Generate.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Generate.TabIndex = 12
        Me.BTN_Generate.Text = "Generate post"
        Me.BTN_Generate.UseVisualStyleBackColor = True
        '
        'BTN_Spells
        '
        Me.BTN_Spells.Location = New System.Drawing.Point(173, 479)
        Me.BTN_Spells.Name = "BTN_Spells"
        Me.BTN_Spells.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Spells.TabIndex = 11
        Me.BTN_Spells.Text = "Spells"
        Me.BTN_Spells.UseVisualStyleBackColor = True
        '
        'BTN_Trade
        '
        Me.BTN_Trade.Location = New System.Drawing.Point(92, 479)
        Me.BTN_Trade.Name = "BTN_Trade"
        Me.BTN_Trade.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Trade.TabIndex = 10
        Me.BTN_Trade.Text = "Trade skills"
        Me.BTN_Trade.UseVisualStyleBackColor = True
        '
        'BTN_Items
        '
        Me.BTN_Items.Location = New System.Drawing.Point(11, 479)
        Me.BTN_Items.Name = "BTN_Items"
        Me.BTN_Items.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Items.TabIndex = 9
        Me.BTN_Items.Text = "Inventory"
        Me.BTN_Items.UseVisualStyleBackColor = True
        '
        'GBX_Stats
        '
        Me.GBX_Stats.Controls.Add(Me.SLV_Specialties)
        Me.GBX_Stats.Controls.Add(Me.NUD_Slots)
        Me.GBX_Stats.Controls.Add(Me.LBL_BonusSlots)
        Me.GBX_Stats.Controls.Add(Me.NUD_Defense)
        Me.GBX_Stats.Controls.Add(Me.NUD_Magic)
        Me.GBX_Stats.Controls.Add(Me.NUD_Ranged)
        Me.GBX_Stats.Controls.Add(Me.NUD_Melee)
        Me.GBX_Stats.Controls.Add(Me.NUD_Energy)
        Me.GBX_Stats.Controls.Add(Me.NUD_Mana)
        Me.GBX_Stats.Controls.Add(Me.NUD_Hp)
        Me.GBX_Stats.Controls.Add(Me.LBL_Def)
        Me.GBX_Stats.Controls.Add(Me.LBL_BonusS)
        Me.GBX_Stats.Controls.Add(Me.LBL_BonusR)
        Me.GBX_Stats.Controls.Add(Me.LBL_BonusM)
        Me.GBX_Stats.Controls.Add(Me.LBL_Energy)
        Me.GBX_Stats.Controls.Add(Me.LBL_Mana)
        Me.GBX_Stats.Controls.Add(Me.LBL_Hp)
        Me.GBX_Stats.Controls.Add(Me.NUD_Exp)
        Me.GBX_Stats.Controls.Add(Me.LBL_Exp)
        Me.GBX_Stats.Controls.Add(Me.NUD_Level)
        Me.GBX_Stats.Controls.Add(Me.LBL_Level)
        Me.GBX_Stats.Controls.Add(Me.NUD_End)
        Me.GBX_Stats.Controls.Add(Me.Label4)
        Me.GBX_Stats.Controls.Add(Me.NUD_Wil)
        Me.GBX_Stats.Controls.Add(Me.LBL_Willpower)
        Me.GBX_Stats.Controls.Add(Me.NUD_Int)
        Me.GBX_Stats.Controls.Add(Me.LBL_Int)
        Me.GBX_Stats.Controls.Add(Me.NUD_Agi)
        Me.GBX_Stats.Controls.Add(Me.LBL_Agility)
        Me.GBX_Stats.Controls.Add(Me.NUD_Str)
        Me.GBX_Stats.Controls.Add(Me.LBL_Strength)
        Me.GBX_Stats.Location = New System.Drawing.Point(310, 41)
        Me.GBX_Stats.Name = "GBX_Stats"
        Me.GBX_Stats.Size = New System.Drawing.Size(312, 432)
        Me.GBX_Stats.TabIndex = 8
        Me.GBX_Stats.TabStop = False
        Me.GBX_Stats.Text = "Stats"
        '
        'SLV_Specialties
        '
        Me.SLV_Specialties.Editable = True
        Me.SLV_Specialties.Location = New System.Drawing.Point(14, 224)
        Me.SLV_Specialties.Name = "SLV_Specialties"
        Me.SLV_Specialties.Size = New System.Drawing.Size(283, 197)
        Me.SLV_Specialties.TabIndex = 32
        '
        'NUD_Slots
        '
        Me.NUD_Slots.Enabled = False
        Me.NUD_Slots.Location = New System.Drawing.Point(247, 198)
        Me.NUD_Slots.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Slots.Name = "NUD_Slots"
        Me.NUD_Slots.ReadOnly = True
        Me.NUD_Slots.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Slots.TabIndex = 31
        '
        'LBL_BonusSlots
        '
        Me.LBL_BonusSlots.AutoSize = True
        Me.LBL_BonusSlots.Location = New System.Drawing.Point(160, 201)
        Me.LBL_BonusSlots.Name = "LBL_BonusSlots"
        Me.LBL_BonusSlots.Size = New System.Drawing.Size(85, 13)
        Me.LBL_BonusSlots.TabIndex = 30
        Me.LBL_BonusSlots.Text = "Bonus Bag Slots"
        '
        'NUD_Defense
        '
        Me.NUD_Defense.Enabled = False
        Me.NUD_Defense.Location = New System.Drawing.Point(100, 198)
        Me.NUD_Defense.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Defense.Name = "NUD_Defense"
        Me.NUD_Defense.ReadOnly = True
        Me.NUD_Defense.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Defense.TabIndex = 29
        '
        'NUD_Magic
        '
        Me.NUD_Magic.Enabled = False
        Me.NUD_Magic.Location = New System.Drawing.Point(100, 176)
        Me.NUD_Magic.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Magic.Name = "NUD_Magic"
        Me.NUD_Magic.ReadOnly = True
        Me.NUD_Magic.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Magic.TabIndex = 28
        '
        'NUD_Ranged
        '
        Me.NUD_Ranged.Enabled = False
        Me.NUD_Ranged.Location = New System.Drawing.Point(100, 153)
        Me.NUD_Ranged.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Ranged.Name = "NUD_Ranged"
        Me.NUD_Ranged.ReadOnly = True
        Me.NUD_Ranged.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Ranged.TabIndex = 27
        '
        'NUD_Melee
        '
        Me.NUD_Melee.Enabled = False
        Me.NUD_Melee.Location = New System.Drawing.Point(100, 130)
        Me.NUD_Melee.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Melee.Name = "NUD_Melee"
        Me.NUD_Melee.ReadOnly = True
        Me.NUD_Melee.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Melee.TabIndex = 26
        '
        'NUD_Energy
        '
        Me.NUD_Energy.Enabled = False
        Me.NUD_Energy.Location = New System.Drawing.Point(100, 108)
        Me.NUD_Energy.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Energy.Name = "NUD_Energy"
        Me.NUD_Energy.ReadOnly = True
        Me.NUD_Energy.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Energy.TabIndex = 25
        '
        'NUD_Mana
        '
        Me.NUD_Mana.Enabled = False
        Me.NUD_Mana.Location = New System.Drawing.Point(100, 85)
        Me.NUD_Mana.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Mana.Name = "NUD_Mana"
        Me.NUD_Mana.ReadOnly = True
        Me.NUD_Mana.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Mana.TabIndex = 24
        '
        'NUD_Hp
        '
        Me.NUD_Hp.Enabled = False
        Me.NUD_Hp.Location = New System.Drawing.Point(100, 63)
        Me.NUD_Hp.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Hp.Name = "NUD_Hp"
        Me.NUD_Hp.ReadOnly = True
        Me.NUD_Hp.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Hp.TabIndex = 23
        '
        'LBL_Def
        '
        Me.LBL_Def.AutoSize = True
        Me.LBL_Def.Location = New System.Drawing.Point(7, 203)
        Me.LBL_Def.Name = "LBL_Def"
        Me.LBL_Def.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Def.TabIndex = 22
        Me.LBL_Def.Text = "Defense"
        '
        'LBL_BonusS
        '
        Me.LBL_BonusS.AutoSize = True
        Me.LBL_BonusS.Location = New System.Drawing.Point(7, 180)
        Me.LBL_BonusS.Name = "LBL_BonusS"
        Me.LBL_BonusS.Size = New System.Drawing.Size(68, 13)
        Me.LBL_BonusS.TabIndex = 21
        Me.LBL_BonusS.Text = "Bonus magic"
        '
        'LBL_BonusR
        '
        Me.LBL_BonusR.AutoSize = True
        Me.LBL_BonusR.Location = New System.Drawing.Point(7, 157)
        Me.LBL_BonusR.Name = "LBL_BonusR"
        Me.LBL_BonusR.Size = New System.Drawing.Size(73, 13)
        Me.LBL_BonusR.TabIndex = 20
        Me.LBL_BonusR.Text = "Bonus ranged"
        '
        'LBL_BonusM
        '
        Me.LBL_BonusM.AutoSize = True
        Me.LBL_BonusM.Location = New System.Drawing.Point(7, 134)
        Me.LBL_BonusM.Name = "LBL_BonusM"
        Me.LBL_BonusM.Size = New System.Drawing.Size(68, 13)
        Me.LBL_BonusM.TabIndex = 19
        Me.LBL_BonusM.Text = "Bonus melee"
        '
        'LBL_Energy
        '
        Me.LBL_Energy.AutoSize = True
        Me.LBL_Energy.Location = New System.Drawing.Point(7, 111)
        Me.LBL_Energy.Name = "LBL_Energy"
        Me.LBL_Energy.Size = New System.Drawing.Size(63, 13)
        Me.LBL_Energy.TabIndex = 17
        Me.LBL_Energy.Text = "Max Energy"
        '
        'LBL_Mana
        '
        Me.LBL_Mana.AutoSize = True
        Me.LBL_Mana.Location = New System.Drawing.Point(7, 88)
        Me.LBL_Mana.Name = "LBL_Mana"
        Me.LBL_Mana.Size = New System.Drawing.Size(57, 13)
        Me.LBL_Mana.TabIndex = 16
        Me.LBL_Mana.Text = "Max Mana"
        '
        'LBL_Hp
        '
        Me.LBL_Hp.AutoSize = True
        Me.LBL_Hp.Location = New System.Drawing.Point(7, 65)
        Me.LBL_Hp.Name = "LBL_Hp"
        Me.LBL_Hp.Size = New System.Drawing.Size(61, 13)
        Me.LBL_Hp.TabIndex = 15
        Me.LBL_Hp.Text = "Max Health"
        '
        'NUD_Exp
        '
        Me.NUD_Exp.Location = New System.Drawing.Point(100, 39)
        Me.NUD_Exp.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NUD_Exp.Name = "NUD_Exp"
        Me.NUD_Exp.Size = New System.Drawing.Size(78, 20)
        Me.NUD_Exp.TabIndex = 14
        '
        'LBL_Exp
        '
        Me.LBL_Exp.AutoSize = True
        Me.LBL_Exp.Location = New System.Drawing.Point(7, 42)
        Me.LBL_Exp.Name = "LBL_Exp"
        Me.LBL_Exp.Size = New System.Drawing.Size(60, 13)
        Me.LBL_Exp.TabIndex = 13
        Me.LBL_Exp.Text = "Experience"
        '
        'NUD_Level
        '
        Me.NUD_Level.Location = New System.Drawing.Point(100, 15)
        Me.NUD_Level.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Level.Name = "NUD_Level"
        Me.NUD_Level.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Level.TabIndex = 12
        Me.NUD_Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LBL_Level
        '
        Me.LBL_Level.AutoSize = True
        Me.LBL_Level.Location = New System.Drawing.Point(7, 19)
        Me.LBL_Level.Name = "LBL_Level"
        Me.LBL_Level.Size = New System.Drawing.Size(33, 13)
        Me.LBL_Level.TabIndex = 11
        Me.LBL_Level.Text = "Level"
        '
        'NUD_End
        '
        Me.NUD_End.Location = New System.Drawing.Point(247, 114)
        Me.NUD_End.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_End.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_End.Name = "NUD_End"
        Me.NUD_End.Size = New System.Drawing.Size(50, 20)
        Me.NUD_End.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Endurance"
        '
        'NUD_Wil
        '
        Me.NUD_Wil.Location = New System.Drawing.Point(247, 89)
        Me.NUD_Wil.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Wil.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Wil.Name = "NUD_Wil"
        Me.NUD_Wil.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Wil.TabIndex = 7
        '
        'LBL_Willpower
        '
        Me.LBL_Willpower.AutoSize = True
        Me.LBL_Willpower.Location = New System.Drawing.Point(184, 92)
        Me.LBL_Willpower.Name = "LBL_Willpower"
        Me.LBL_Willpower.Size = New System.Drawing.Size(53, 13)
        Me.LBL_Willpower.TabIndex = 6
        Me.LBL_Willpower.Text = "Willpower"
        '
        'NUD_Int
        '
        Me.NUD_Int.Location = New System.Drawing.Point(247, 65)
        Me.NUD_Int.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Int.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Int.Name = "NUD_Int"
        Me.NUD_Int.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Int.TabIndex = 5
        '
        'LBL_Int
        '
        Me.LBL_Int.AutoSize = True
        Me.LBL_Int.Location = New System.Drawing.Point(184, 67)
        Me.LBL_Int.Name = "LBL_Int"
        Me.LBL_Int.Size = New System.Drawing.Size(61, 13)
        Me.LBL_Int.TabIndex = 4
        Me.LBL_Int.Text = "Intelligence"
        '
        'NUD_Agi
        '
        Me.NUD_Agi.Location = New System.Drawing.Point(247, 39)
        Me.NUD_Agi.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Agi.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Agi.Name = "NUD_Agi"
        Me.NUD_Agi.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Agi.TabIndex = 3
        '
        'LBL_Agility
        '
        Me.LBL_Agility.AutoSize = True
        Me.LBL_Agility.Location = New System.Drawing.Point(184, 41)
        Me.LBL_Agility.Name = "LBL_Agility"
        Me.LBL_Agility.Size = New System.Drawing.Size(34, 13)
        Me.LBL_Agility.TabIndex = 2
        Me.LBL_Agility.Text = "Agility"
        '
        'NUD_Str
        '
        Me.NUD_Str.Location = New System.Drawing.Point(247, 14)
        Me.NUD_Str.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Str.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Str.Name = "NUD_Str"
        Me.NUD_Str.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Str.TabIndex = 1
        '
        'LBL_Strength
        '
        Me.LBL_Strength.AutoSize = True
        Me.LBL_Strength.Location = New System.Drawing.Point(184, 16)
        Me.LBL_Strength.Name = "LBL_Strength"
        Me.LBL_Strength.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Strength.TabIndex = 0
        Me.LBL_Strength.Text = "Strength"
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(251, 13)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(53, 20)
        Me.TBX_ID.TabIndex = 7
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(224, 15)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(21, 13)
        Me.LBL_ID.TabIndex = 6
        Me.LBL_ID.Text = "ID:"
        '
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(385, 11)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 5
        Me.BTN_New.Text = "Add new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(466, 11)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 4
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(547, 11)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 3
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(546, 479)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 2
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'GBX_Demographics
        '
        Me.GBX_Demographics.Controls.Add(Me.BTN_EditClass)
        Me.GBX_Demographics.Controls.Add(Me.CBX_Class)
        Me.GBX_Demographics.Controls.Add(Me.BTN_EditRace)
        Me.GBX_Demographics.Controls.Add(Me.CBX_Race)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Class)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Race)
        Me.GBX_Demographics.Controls.Add(Me.BTN_SetColor)
        Me.GBX_Demographics.Controls.Add(Me.TBX_Color)
        Me.GBX_Demographics.Controls.Add(Me.LBL_NameColor)
        Me.GBX_Demographics.Controls.Add(Me.LBL_More)
        Me.GBX_Demographics.Controls.Add(Me.TBX_More)
        Me.GBX_Demographics.Controls.Add(Me.TBX_History)
        Me.GBX_Demographics.Controls.Add(Me.LBL_History)
        Me.GBX_Demographics.Controls.Add(Me.TBX_Physdesc)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Physdesc)
        Me.GBX_Demographics.Controls.Add(Me.RBN_Female)
        Me.GBX_Demographics.Controls.Add(Me.RBN_Male)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Gender)
        Me.GBX_Demographics.Controls.Add(Me.NUD_Age)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Age)
        Me.GBX_Demographics.Controls.Add(Me.TBX_Name)
        Me.GBX_Demographics.Controls.Add(Me.LBL_Name)
        Me.GBX_Demographics.Location = New System.Drawing.Point(13, 41)
        Me.GBX_Demographics.Name = "GBX_Demographics"
        Me.GBX_Demographics.Size = New System.Drawing.Size(291, 432)
        Me.GBX_Demographics.TabIndex = 1
        Me.GBX_Demographics.TabStop = False
        Me.GBX_Demographics.Text = "Demographics"
        '
        'BTN_EditClass
        '
        Me.BTN_EditClass.Location = New System.Drawing.Point(203, 404)
        Me.BTN_EditClass.Name = "BTN_EditClass"
        Me.BTN_EditClass.Size = New System.Drawing.Size(40, 20)
        Me.BTN_EditClass.TabIndex = 21
        Me.BTN_EditClass.Text = "Edit"
        Me.BTN_EditClass.UseVisualStyleBackColor = True
        '
        'CBX_Class
        '
        Me.CBX_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Class.FormattingEnabled = True
        Me.CBX_Class.Location = New System.Drawing.Point(79, 403)
        Me.CBX_Class.Name = "CBX_Class"
        Me.CBX_Class.Size = New System.Drawing.Size(100, 21)
        Me.CBX_Class.TabIndex = 20
        '
        'BTN_EditRace
        '
        Me.BTN_EditRace.Location = New System.Drawing.Point(203, 376)
        Me.BTN_EditRace.Name = "BTN_EditRace"
        Me.BTN_EditRace.Size = New System.Drawing.Size(40, 20)
        Me.BTN_EditRace.TabIndex = 19
        Me.BTN_EditRace.Text = "Edit"
        Me.BTN_EditRace.UseVisualStyleBackColor = True
        '
        'CBX_Race
        '
        Me.CBX_Race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Race.FormattingEnabled = True
        Me.CBX_Race.Location = New System.Drawing.Point(79, 376)
        Me.CBX_Race.Name = "CBX_Race"
        Me.CBX_Race.Size = New System.Drawing.Size(100, 21)
        Me.CBX_Race.TabIndex = 18
        '
        'LBL_Class
        '
        Me.LBL_Class.AutoSize = True
        Me.LBL_Class.Location = New System.Drawing.Point(10, 408)
        Me.LBL_Class.Name = "LBL_Class"
        Me.LBL_Class.Size = New System.Drawing.Size(32, 13)
        Me.LBL_Class.TabIndex = 17
        Me.LBL_Class.Text = "Class"
        '
        'LBL_Race
        '
        Me.LBL_Race.AutoSize = True
        Me.LBL_Race.Location = New System.Drawing.Point(10, 378)
        Me.LBL_Race.Name = "LBL_Race"
        Me.LBL_Race.Size = New System.Drawing.Size(33, 13)
        Me.LBL_Race.TabIndex = 16
        Me.LBL_Race.Text = "Race"
        '
        'BTN_SetColor
        '
        Me.BTN_SetColor.Location = New System.Drawing.Point(207, 349)
        Me.BTN_SetColor.Name = "BTN_SetColor"
        Me.BTN_SetColor.Size = New System.Drawing.Size(33, 21)
        Me.BTN_SetColor.TabIndex = 15
        Me.BTN_SetColor.Text = "Set"
        Me.BTN_SetColor.UseVisualStyleBackColor = True
        '
        'TBX_Color
        '
        Me.TBX_Color.Location = New System.Drawing.Point(79, 350)
        Me.TBX_Color.Name = "TBX_Color"
        Me.TBX_Color.ReadOnly = True
        Me.TBX_Color.Size = New System.Drawing.Size(100, 20)
        Me.TBX_Color.TabIndex = 14
        '
        'LBL_NameColor
        '
        Me.LBL_NameColor.AutoSize = True
        Me.LBL_NameColor.Location = New System.Drawing.Point(10, 353)
        Me.LBL_NameColor.Name = "LBL_NameColor"
        Me.LBL_NameColor.Size = New System.Drawing.Size(61, 13)
        Me.LBL_NameColor.TabIndex = 13
        Me.LBL_NameColor.Text = "Name color"
        '
        'LBL_More
        '
        Me.LBL_More.AutoSize = True
        Me.LBL_More.Location = New System.Drawing.Point(6, 271)
        Me.LBL_More.Name = "LBL_More"
        Me.LBL_More.Size = New System.Drawing.Size(70, 13)
        Me.LBL_More.TabIndex = 12
        Me.LBL_More.Text = "Anything else"
        '
        'TBX_More
        '
        Me.TBX_More.Location = New System.Drawing.Point(10, 290)
        Me.TBX_More.Multiline = True
        Me.TBX_More.Name = "TBX_More"
        Me.TBX_More.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_More.Size = New System.Drawing.Size(269, 51)
        Me.TBX_More.TabIndex = 11
        '
        'TBX_History
        '
        Me.TBX_History.Location = New System.Drawing.Point(9, 201)
        Me.TBX_History.Multiline = True
        Me.TBX_History.Name = "TBX_History"
        Me.TBX_History.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_History.Size = New System.Drawing.Size(269, 67)
        Me.TBX_History.TabIndex = 10
        '
        'LBL_History
        '
        Me.LBL_History.AutoSize = True
        Me.LBL_History.Location = New System.Drawing.Point(6, 185)
        Me.LBL_History.Name = "LBL_History"
        Me.LBL_History.Size = New System.Drawing.Size(39, 13)
        Me.LBL_History.TabIndex = 9
        Me.LBL_History.Text = "History"
        '
        'TBX_Physdesc
        '
        Me.TBX_Physdesc.Location = New System.Drawing.Point(10, 121)
        Me.TBX_Physdesc.Multiline = True
        Me.TBX_Physdesc.Name = "TBX_Physdesc"
        Me.TBX_Physdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_Physdesc.Size = New System.Drawing.Size(269, 61)
        Me.TBX_Physdesc.TabIndex = 8
        '
        'LBL_Physdesc
        '
        Me.LBL_Physdesc.AutoSize = True
        Me.LBL_Physdesc.Location = New System.Drawing.Point(7, 105)
        Me.LBL_Physdesc.Name = "LBL_Physdesc"
        Me.LBL_Physdesc.Size = New System.Drawing.Size(100, 13)
        Me.LBL_Physdesc.TabIndex = 7
        Me.LBL_Physdesc.Text = "Physical description"
        '
        'RBN_Female
        '
        Me.RBN_Female.AutoSize = True
        Me.RBN_Female.Location = New System.Drawing.Point(220, 80)
        Me.RBN_Female.Name = "RBN_Female"
        Me.RBN_Female.Size = New System.Drawing.Size(59, 17)
        Me.RBN_Female.TabIndex = 6
        Me.RBN_Female.TabStop = True
        Me.RBN_Female.Text = "Female"
        Me.RBN_Female.UseVisualStyleBackColor = True
        '
        'RBN_Male
        '
        Me.RBN_Male.AutoSize = True
        Me.RBN_Male.Location = New System.Drawing.Point(166, 80)
        Me.RBN_Male.Name = "RBN_Male"
        Me.RBN_Male.Size = New System.Drawing.Size(48, 17)
        Me.RBN_Male.TabIndex = 5
        Me.RBN_Male.TabStop = True
        Me.RBN_Male.Text = "Male"
        Me.RBN_Male.UseVisualStyleBackColor = True
        '
        'LBL_Gender
        '
        Me.LBL_Gender.AutoSize = True
        Me.LBL_Gender.Location = New System.Drawing.Point(7, 80)
        Me.LBL_Gender.Name = "LBL_Gender"
        Me.LBL_Gender.Size = New System.Drawing.Size(42, 13)
        Me.LBL_Gender.TabIndex = 4
        Me.LBL_Gender.Text = "Gender"
        '
        'NUD_Age
        '
        Me.NUD_Age.Location = New System.Drawing.Point(210, 47)
        Me.NUD_Age.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Age.Name = "NUD_Age"
        Me.NUD_Age.Size = New System.Drawing.Size(69, 20)
        Me.NUD_Age.TabIndex = 3
        '
        'LBL_Age
        '
        Me.LBL_Age.AutoSize = True
        Me.LBL_Age.Location = New System.Drawing.Point(7, 49)
        Me.LBL_Age.Name = "LBL_Age"
        Me.LBL_Age.Size = New System.Drawing.Size(26, 13)
        Me.LBL_Age.TabIndex = 2
        Me.LBL_Age.Text = "Age"
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(179, 21)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(100, 20)
        Me.TBX_Name.TabIndex = 1
        '
        'LBL_Name
        '
        Me.LBL_Name.AutoSize = True
        Me.LBL_Name.Location = New System.Drawing.Point(7, 20)
        Me.LBL_Name.Name = "LBL_Name"
        Me.LBL_Name.Size = New System.Drawing.Size(35, 13)
        Me.LBL_Name.TabIndex = 0
        Me.LBL_Name.Text = "Name"
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(12, 10)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 0
        '
        'Players
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.BTN_Generate)
        Me.Controls.Add(Me.BTN_Spells)
        Me.Controls.Add(Me.BTN_Trade)
        Me.Controls.Add(Me.BTN_Items)
        Me.Controls.Add(Me.GBX_Stats)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.BTN_New)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.GBX_Demographics)
        Me.Controls.Add(Me.CBX_Names)
        Me.Name = "Players"
        Me.Text = "Players"
        Me.GBX_Stats.ResumeLayout(False)
        Me.GBX_Stats.PerformLayout()
        CType(Me.NUD_Slots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Defense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Magic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Ranged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Melee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Energy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Mana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Hp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Exp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBX_Demographics.ResumeLayout(False)
        Me.GBX_Demographics.PerformLayout()
        CType(Me.NUD_Age, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents GBX_Demographics As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Name As System.Windows.Forms.Label
    Friend WithEvents NUD_Age As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Age As System.Windows.Forms.Label
    Friend WithEvents RBN_Female As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Male As System.Windows.Forms.RadioButton
    Friend WithEvents LBL_Gender As System.Windows.Forms.Label
    Friend WithEvents TBX_Physdesc As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Physdesc As System.Windows.Forms.Label
    Friend WithEvents TBX_History As System.Windows.Forms.TextBox
    Friend WithEvents LBL_History As System.Windows.Forms.Label
    Friend WithEvents LBL_More As System.Windows.Forms.Label
    Friend WithEvents TBX_More As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents GBX_Stats As System.Windows.Forms.GroupBox
    Friend WithEvents NUD_Level As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Exp As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_BonusS As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusR As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusM As System.Windows.Forms.Label
    Friend WithEvents LBL_Def As System.Windows.Forms.Label
    Friend WithEvents LBL_Energy As System.Windows.Forms.Label
    Friend WithEvents LBL_Mana As System.Windows.Forms.Label
    Friend WithEvents LBL_Hp As System.Windows.Forms.Label
    Friend WithEvents LBL_Exp As System.Windows.Forms.Label
    Friend WithEvents LBL_Level As System.Windows.Forms.Label
    Friend WithEvents NUD_End As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NUD_Wil As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Willpower As System.Windows.Forms.Label
    Friend WithEvents NUD_Int As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Int As System.Windows.Forms.Label
    Friend WithEvents NUD_Agi As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Agility As System.Windows.Forms.Label
    Friend WithEvents NUD_Str As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Strength As System.Windows.Forms.Label
    Friend WithEvents NUD_Defense As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Magic As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Ranged As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Melee As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Energy As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Mana As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Hp As System.Windows.Forms.NumericUpDown
    Friend WithEvents BTN_Items As System.Windows.Forms.Button
    Friend WithEvents BTN_Trade As System.Windows.Forms.Button
    Friend WithEvents BTN_Spells As System.Windows.Forms.Button
    Friend WithEvents LBL_NameColor As System.Windows.Forms.Label
    Friend WithEvents CDG_Color As System.Windows.Forms.ColorDialog
    Friend WithEvents BTN_SetColor As System.Windows.Forms.Button
    Friend WithEvents TBX_Color As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Generate As System.Windows.Forms.Button
    Friend WithEvents BTN_EditClass As System.Windows.Forms.Button
    Friend WithEvents CBX_Class As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_EditRace As System.Windows.Forms.Button
    Friend WithEvents CBX_Race As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_Class As System.Windows.Forms.Label
    Friend WithEvents LBL_Race As System.Windows.Forms.Label
    Friend WithEvents NUD_Slots As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_BonusSlots As System.Windows.Forms.Label
    Friend WithEvents SLV_Specialties As MediCalc.SkillsListView
End Class
