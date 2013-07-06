<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattlePlayerEdit
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
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBX_HP = New System.Windows.Forms.TextBox()
        Me.TBX_HPCur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBX_Level = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBX_Pow = New System.Windows.Forms.TextBox()
        Me.TBX_PowCur = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SLV_BaseSkills = New MediCalc.SkillsListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SLV_DmgExtraSkills = New MediCalc.SkillsListView()
        Me.NUD_MinRanged = New System.Windows.Forms.NumericUpDown()
        Me.NUD_MinMelee = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NUD_Defense = New System.Windows.Forms.NumericUpDown()
        Me.NUD_End = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Magic = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_Strength = New System.Windows.Forms.Label()
        Me.NUD_Ranged = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Wil = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Str = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Melee = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Willpower = New System.Windows.Forms.Label()
        Me.LBL_Def = New System.Windows.Forms.Label()
        Me.LBL_Agility = New System.Windows.Forms.Label()
        Me.LBL_BonusS = New System.Windows.Forms.Label()
        Me.NUD_Int = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Agi = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Int = New System.Windows.Forms.Label()
        Me.LBL_BonusR = New System.Windows.Forms.Label()
        Me.LBL_BonusM = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BTN_Reset = New System.Windows.Forms.Button()
        Me.BTN_Effects = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUD_MinRanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_MinMelee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Defense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Magic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Ranged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Melee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(472, 385)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancel.TabIndex = 21
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'BTN_OK
        '
        Me.BTN_OK.Location = New System.Drawing.Point(553, 385)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OK.TabIndex = 20
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(510, 12)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(118, 23)
        Me.BTN_Delete.TabIndex = 24
        Me.BTN_Delete.Text = "Remove from battle"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(101, 11)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 22
        Me.CBX_Names.Visible = False
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(36, 12)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(26, 20)
        Me.TBX_ID.TabIndex = 26
        Me.TBX_ID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "/"
        '
        'TBX_HP
        '
        Me.TBX_HP.Location = New System.Drawing.Point(110, 69)
        Me.TBX_HP.Name = "TBX_HP"
        Me.TBX_HP.Size = New System.Drawing.Size(36, 20)
        Me.TBX_HP.TabIndex = 34
        '
        'TBX_HPCur
        '
        Me.TBX_HPCur.Location = New System.Drawing.Point(56, 69)
        Me.TBX_HPCur.Name = "TBX_HPCur"
        Me.TBX_HPCur.Size = New System.Drawing.Size(36, 20)
        Me.TBX_HPCur.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "HP"
        '
        'TBX_Level
        '
        Me.TBX_Level.Location = New System.Drawing.Point(56, 44)
        Me.TBX_Level.Name = "TBX_Level"
        Me.TBX_Level.Size = New System.Drawing.Size(36, 20)
        Me.TBX_Level.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Level"
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(56, 19)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(134, 20)
        Me.TBX_Name.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "/"
        '
        'TBX_Pow
        '
        Me.TBX_Pow.Location = New System.Drawing.Point(110, 95)
        Me.TBX_Pow.Name = "TBX_Pow"
        Me.TBX_Pow.Size = New System.Drawing.Size(36, 20)
        Me.TBX_Pow.TabIndex = 38
        '
        'TBX_PowCur
        '
        Me.TBX_PowCur.Location = New System.Drawing.Point(56, 95)
        Me.TBX_PowCur.Name = "TBX_PowCur"
        Me.TBX_PowCur.Size = New System.Drawing.Size(36, 20)
        Me.TBX_PowCur.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Pow"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBX_Name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBX_Pow)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBX_PowCur)
        Me.GroupBox1.Controls.Add(Me.TBX_Level)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBX_HPCur)
        Me.GroupBox1.Controls.Add(Me.TBX_HP)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 125)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basics"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SLV_BaseSkills)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 158)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Base skills"
        '
        'SLV_BaseSkills
        '
        Me.SLV_BaseSkills.Editable = True
        Me.SLV_BaseSkills.Location = New System.Drawing.Point(8, 18)
        Me.SLV_BaseSkills.Name = "SLV_BaseSkills"
        Me.SLV_BaseSkills.Size = New System.Drawing.Size(283, 133)
        Me.SLV_BaseSkills.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SLV_DmgExtraSkills)
        Me.GroupBox3.Location = New System.Drawing.Point(331, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 173)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bonus damage with skills"
        '
        'SLV_DmgExtraSkills
        '
        Me.SLV_DmgExtraSkills.Editable = True
        Me.SLV_DmgExtraSkills.Location = New System.Drawing.Point(8, 17)
        Me.SLV_DmgExtraSkills.Name = "SLV_DmgExtraSkills"
        Me.SLV_DmgExtraSkills.Size = New System.Drawing.Size(283, 147)
        Me.SLV_DmgExtraSkills.TabIndex = 0
        '
        'NUD_MinRanged
        '
        Me.NUD_MinRanged.Location = New System.Drawing.Point(252, 44)
        Me.NUD_MinRanged.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_MinRanged.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_MinRanged.Name = "NUD_MinRanged"
        Me.NUD_MinRanged.Size = New System.Drawing.Size(50, 20)
        Me.NUD_MinRanged.TabIndex = 125
        '
        'NUD_MinMelee
        '
        Me.NUD_MinMelee.Location = New System.Drawing.Point(252, 21)
        Me.NUD_MinMelee.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_MinMelee.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_MinMelee.Name = "NUD_MinMelee"
        Me.NUD_MinMelee.Size = New System.Drawing.Size(50, 20)
        Me.NUD_MinMelee.TabIndex = 124
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(159, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 13)
        Me.Label18.TabIndex = 123
        Me.Label18.Text = "Bonus min ranged"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(159, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "Bonus min melee"
        '
        'NUD_Defense
        '
        Me.NUD_Defense.Location = New System.Drawing.Point(252, 67)
        Me.NUD_Defense.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Defense.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Defense.Name = "NUD_Defense"
        Me.NUD_Defense.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Defense.TabIndex = 121
        '
        'NUD_End
        '
        Me.NUD_End.Location = New System.Drawing.Point(253, 44)
        Me.NUD_End.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_End.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_End.Name = "NUD_End"
        Me.NUD_End.Size = New System.Drawing.Size(50, 20)
        Me.NUD_End.TabIndex = 113
        '
        'NUD_Magic
        '
        Me.NUD_Magic.Location = New System.Drawing.Point(100, 67)
        Me.NUD_Magic.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Magic.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Magic.Name = "NUD_Magic"
        Me.NUD_Magic.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Magic.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Endurance"
        '
        'LBL_Strength
        '
        Me.LBL_Strength.AutoSize = True
        Me.LBL_Strength.Location = New System.Drawing.Point(12, 21)
        Me.LBL_Strength.Name = "LBL_Strength"
        Me.LBL_Strength.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Strength.TabIndex = 104
        Me.LBL_Strength.Text = "Strength"
        '
        'NUD_Ranged
        '
        Me.NUD_Ranged.Location = New System.Drawing.Point(100, 44)
        Me.NUD_Ranged.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Ranged.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Ranged.Name = "NUD_Ranged"
        Me.NUD_Ranged.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Ranged.TabIndex = 119
        '
        'NUD_Wil
        '
        Me.NUD_Wil.Location = New System.Drawing.Point(253, 19)
        Me.NUD_Wil.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Wil.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Wil.Name = "NUD_Wil"
        Me.NUD_Wil.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Wil.TabIndex = 111
        '
        'NUD_Str
        '
        Me.NUD_Str.Location = New System.Drawing.Point(101, 19)
        Me.NUD_Str.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Str.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Str.Name = "NUD_Str"
        Me.NUD_Str.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Str.TabIndex = 105
        '
        'NUD_Melee
        '
        Me.NUD_Melee.Location = New System.Drawing.Point(100, 21)
        Me.NUD_Melee.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Melee.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Melee.Name = "NUD_Melee"
        Me.NUD_Melee.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Melee.TabIndex = 118
        '
        'LBL_Willpower
        '
        Me.LBL_Willpower.AutoSize = True
        Me.LBL_Willpower.Location = New System.Drawing.Point(182, 22)
        Me.LBL_Willpower.Name = "LBL_Willpower"
        Me.LBL_Willpower.Size = New System.Drawing.Size(53, 13)
        Me.LBL_Willpower.TabIndex = 110
        Me.LBL_Willpower.Text = "Willpower"
        '
        'LBL_Def
        '
        Me.LBL_Def.AutoSize = True
        Me.LBL_Def.Location = New System.Drawing.Point(159, 71)
        Me.LBL_Def.Name = "LBL_Def"
        Me.LBL_Def.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Def.TabIndex = 117
        Me.LBL_Def.Text = "Defense"
        '
        'LBL_Agility
        '
        Me.LBL_Agility.AutoSize = True
        Me.LBL_Agility.Location = New System.Drawing.Point(12, 44)
        Me.LBL_Agility.Name = "LBL_Agility"
        Me.LBL_Agility.Size = New System.Drawing.Size(34, 13)
        Me.LBL_Agility.TabIndex = 106
        Me.LBL_Agility.Text = "Agility"
        '
        'LBL_BonusS
        '
        Me.LBL_BonusS.AutoSize = True
        Me.LBL_BonusS.Location = New System.Drawing.Point(11, 71)
        Me.LBL_BonusS.Name = "LBL_BonusS"
        Me.LBL_BonusS.Size = New System.Drawing.Size(68, 13)
        Me.LBL_BonusS.TabIndex = 116
        Me.LBL_BonusS.Text = "Bonus magic"
        '
        'NUD_Int
        '
        Me.NUD_Int.Location = New System.Drawing.Point(101, 66)
        Me.NUD_Int.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Int.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Int.Name = "NUD_Int"
        Me.NUD_Int.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Int.TabIndex = 109
        '
        'NUD_Agi
        '
        Me.NUD_Agi.Location = New System.Drawing.Point(101, 42)
        Me.NUD_Agi.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Agi.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Agi.Name = "NUD_Agi"
        Me.NUD_Agi.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Agi.TabIndex = 107
        '
        'LBL_Int
        '
        Me.LBL_Int.AutoSize = True
        Me.LBL_Int.Location = New System.Drawing.Point(12, 68)
        Me.LBL_Int.Name = "LBL_Int"
        Me.LBL_Int.Size = New System.Drawing.Size(61, 13)
        Me.LBL_Int.TabIndex = 108
        Me.LBL_Int.Text = "Intelligence"
        '
        'LBL_BonusR
        '
        Me.LBL_BonusR.AutoSize = True
        Me.LBL_BonusR.Location = New System.Drawing.Point(11, 47)
        Me.LBL_BonusR.Name = "LBL_BonusR"
        Me.LBL_BonusR.Size = New System.Drawing.Size(73, 13)
        Me.LBL_BonusR.TabIndex = 115
        Me.LBL_BonusR.Text = "Bonus ranged"
        '
        'LBL_BonusM
        '
        Me.LBL_BonusM.AutoSize = True
        Me.LBL_BonusM.Location = New System.Drawing.Point(11, 23)
        Me.LBL_BonusM.Name = "LBL_BonusM"
        Me.LBL_BonusM.Size = New System.Drawing.Size(68, 13)
        Me.LBL_BonusM.TabIndex = 114
        Me.LBL_BonusM.Text = "Bonus melee"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NUD_Str)
        Me.GroupBox4.Controls.Add(Me.LBL_Int)
        Me.GroupBox4.Controls.Add(Me.NUD_Agi)
        Me.GroupBox4.Controls.Add(Me.NUD_Int)
        Me.GroupBox4.Controls.Add(Me.LBL_Agility)
        Me.GroupBox4.Controls.Add(Me.LBL_Willpower)
        Me.GroupBox4.Controls.Add(Me.NUD_End)
        Me.GroupBox4.Controls.Add(Me.NUD_Wil)
        Me.GroupBox4.Controls.Add(Me.LBL_Strength)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(313, 100)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stats"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LBL_BonusM)
        Me.GroupBox5.Controls.Add(Me.NUD_Melee)
        Me.GroupBox5.Controls.Add(Me.NUD_Defense)
        Me.GroupBox5.Controls.Add(Me.NUD_MinRanged)
        Me.GroupBox5.Controls.Add(Me.LBL_Def)
        Me.GroupBox5.Controls.Add(Me.NUD_Magic)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.LBL_BonusR)
        Me.GroupBox5.Controls.Add(Me.LBL_BonusS)
        Me.GroupBox5.Controls.Add(Me.NUD_MinMelee)
        Me.GroupBox5.Controls.Add(Me.NUD_Ranged)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(312, 100)
        Me.GroupBox5.TabIndex = 127
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ratings"
        '
        'BTN_Reset
        '
        Me.BTN_Reset.Location = New System.Drawing.Point(429, 12)
        Me.BTN_Reset.Name = "BTN_Reset"
        Me.BTN_Reset.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Reset.TabIndex = 128
        Me.BTN_Reset.Text = "Reset"
        Me.BTN_Reset.UseVisualStyleBackColor = True
        '
        'BTN_Effects
        '
        Me.BTN_Effects.Location = New System.Drawing.Point(12, 385)
        Me.BTN_Effects.Name = "BTN_Effects"
        Me.BTN_Effects.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Effects.TabIndex = 129
        Me.BTN_Effects.Text = "Effects"
        Me.BTN_Effects.UseVisualStyleBackColor = True
        '
        'BattlePlayerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 419)
        Me.Controls.Add(Me.BTN_Effects)
        Me.Controls.Add(Me.BTN_Reset)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.CBX_Names)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_OK)
        Me.Name = "BattlePlayerEdit"
        Me.Text = "Direct player edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NUD_MinRanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_MinMelee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Defense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Magic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Ranged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Melee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents BTN_OK As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBX_HP As System.Windows.Forms.TextBox
    Friend WithEvents TBX_HPCur As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBX_Level As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBX_Pow As System.Windows.Forms.TextBox
    Friend WithEvents TBX_PowCur As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NUD_MinRanged As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_MinMelee As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents NUD_Defense As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_End As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Magic As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBL_Strength As System.Windows.Forms.Label
    Friend WithEvents NUD_Ranged As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Wil As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Str As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Melee As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Willpower As System.Windows.Forms.Label
    Friend WithEvents LBL_Def As System.Windows.Forms.Label
    Friend WithEvents LBL_Agility As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusS As System.Windows.Forms.Label
    Friend WithEvents NUD_Int As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD_Agi As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBL_Int As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusR As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusM As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Reset As System.Windows.Forms.Button
    Friend WithEvents SLV_BaseSkills As MediCalc.SkillsListView
    Friend WithEvents SLV_DmgExtraSkills As MediCalc.SkillsListView
    Friend WithEvents BTN_Effects As System.Windows.Forms.Button
End Class
