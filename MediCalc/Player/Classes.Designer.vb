<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.GBX_Classes = New System.Windows.Forms.GroupBox()
        Me.RBN_Energy = New System.Windows.Forms.RadioButton()
        Me.RBN_Mana = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.LBL_BonusSkills = New System.Windows.Forms.Label()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.SLV_Specialties = New MediCalc.SkillsListView()
        Me.GBX_Classes.SuspendLayout()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(67, 12)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 20
        Me.BTN_New.Text = "Add new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(148, 12)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 19
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(229, 12)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 18
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(245, 42)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(53, 20)
        Me.TBX_ID.TabIndex = 17
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(218, 45)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(21, 13)
        Me.LBL_ID.TabIndex = 16
        Me.LBL_ID.Text = "ID:"
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(5, 42)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 15
        '
        'GBX_Classes
        '
        Me.GBX_Classes.Controls.Add(Me.SLV_Specialties)
        Me.GBX_Classes.Controls.Add(Me.RBN_Energy)
        Me.GBX_Classes.Controls.Add(Me.RBN_Mana)
        Me.GBX_Classes.Controls.Add(Me.Label2)
        Me.GBX_Classes.Controls.Add(Me.NUD_End)
        Me.GBX_Classes.Controls.Add(Me.Label4)
        Me.GBX_Classes.Controls.Add(Me.NUD_Wil)
        Me.GBX_Classes.Controls.Add(Me.LBL_Willpower)
        Me.GBX_Classes.Controls.Add(Me.NUD_Int)
        Me.GBX_Classes.Controls.Add(Me.LBL_Int)
        Me.GBX_Classes.Controls.Add(Me.NUD_Agi)
        Me.GBX_Classes.Controls.Add(Me.LBL_Agility)
        Me.GBX_Classes.Controls.Add(Me.NUD_Str)
        Me.GBX_Classes.Controls.Add(Me.LBL_Strength)
        Me.GBX_Classes.Controls.Add(Me.Label1)
        Me.GBX_Classes.Controls.Add(Me.TBX_Name)
        Me.GBX_Classes.Controls.Add(Me.LBL_Name)
        Me.GBX_Classes.Controls.Add(Me.LBL_BonusSkills)
        Me.GBX_Classes.Location = New System.Drawing.Point(10, 66)
        Me.GBX_Classes.Name = "GBX_Classes"
        Me.GBX_Classes.Size = New System.Drawing.Size(293, 336)
        Me.GBX_Classes.TabIndex = 21
        Me.GBX_Classes.TabStop = False
        Me.GBX_Classes.Text = "Class info"
        '
        'RBN_Energy
        '
        Me.RBN_Energy.AutoSize = True
        Me.RBN_Energy.Location = New System.Drawing.Point(164, 235)
        Me.RBN_Energy.Name = "RBN_Energy"
        Me.RBN_Energy.Size = New System.Drawing.Size(58, 17)
        Me.RBN_Energy.TabIndex = 40
        Me.RBN_Energy.TabStop = True
        Me.RBN_Energy.Text = "Energy"
        Me.RBN_Energy.UseVisualStyleBackColor = True
        '
        'RBN_Mana
        '
        Me.RBN_Mana.AutoSize = True
        Me.RBN_Mana.Location = New System.Drawing.Point(164, 213)
        Me.RBN_Mana.Name = "RBN_Mana"
        Me.RBN_Mana.Size = New System.Drawing.Size(52, 17)
        Me.RBN_Mana.TabIndex = 39
        Me.RBN_Mana.TabStop = True
        Me.RBN_Mana.Text = "Mana"
        Me.RBN_Mana.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Power type"
        '
        'NUD_End
        '
        Me.NUD_End.Location = New System.Drawing.Point(77, 310)
        Me.NUD_End.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_End.Name = "NUD_End"
        Me.NUD_End.Size = New System.Drawing.Size(50, 20)
        Me.NUD_End.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Endurance"
        '
        'NUD_Wil
        '
        Me.NUD_Wil.Location = New System.Drawing.Point(77, 287)
        Me.NUD_Wil.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Wil.Name = "NUD_Wil"
        Me.NUD_Wil.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Wil.TabIndex = 35
        '
        'LBL_Willpower
        '
        Me.LBL_Willpower.AutoSize = True
        Me.LBL_Willpower.Location = New System.Drawing.Point(14, 288)
        Me.LBL_Willpower.Name = "LBL_Willpower"
        Me.LBL_Willpower.Size = New System.Drawing.Size(53, 13)
        Me.LBL_Willpower.TabIndex = 34
        Me.LBL_Willpower.Text = "Willpower"
        '
        'NUD_Int
        '
        Me.NUD_Int.Location = New System.Drawing.Point(77, 261)
        Me.NUD_Int.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Int.Name = "NUD_Int"
        Me.NUD_Int.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Int.TabIndex = 33
        '
        'LBL_Int
        '
        Me.LBL_Int.AutoSize = True
        Me.LBL_Int.Location = New System.Drawing.Point(14, 263)
        Me.LBL_Int.Name = "LBL_Int"
        Me.LBL_Int.Size = New System.Drawing.Size(61, 13)
        Me.LBL_Int.TabIndex = 32
        Me.LBL_Int.Text = "Intelligence"
        '
        'NUD_Agi
        '
        Me.NUD_Agi.Location = New System.Drawing.Point(77, 235)
        Me.NUD_Agi.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Agi.Name = "NUD_Agi"
        Me.NUD_Agi.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Agi.TabIndex = 31
        '
        'LBL_Agility
        '
        Me.LBL_Agility.AutoSize = True
        Me.LBL_Agility.Location = New System.Drawing.Point(14, 237)
        Me.LBL_Agility.Name = "LBL_Agility"
        Me.LBL_Agility.Size = New System.Drawing.Size(34, 13)
        Me.LBL_Agility.TabIndex = 30
        Me.LBL_Agility.Text = "Agility"
        '
        'NUD_Str
        '
        Me.NUD_Str.Location = New System.Drawing.Point(77, 210)
        Me.NUD_Str.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NUD_Str.Name = "NUD_Str"
        Me.NUD_Str.Size = New System.Drawing.Size(50, 20)
        Me.NUD_Str.TabIndex = 29
        '
        'LBL_Strength
        '
        Me.LBL_Strength.AutoSize = True
        Me.LBL_Strength.Location = New System.Drawing.Point(14, 212)
        Me.LBL_Strength.Name = "LBL_Strength"
        Me.LBL_Strength.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Strength.TabIndex = 28
        Me.LBL_Strength.Text = "Strength"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Bonus to Stats"
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(47, 19)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(100, 20)
        Me.TBX_Name.TabIndex = 26
        '
        'LBL_Name
        '
        Me.LBL_Name.AutoSize = True
        Me.LBL_Name.Location = New System.Drawing.Point(6, 22)
        Me.LBL_Name.Name = "LBL_Name"
        Me.LBL_Name.Size = New System.Drawing.Size(35, 13)
        Me.LBL_Name.TabIndex = 25
        Me.LBL_Name.Text = "Name"
        '
        'LBL_BonusSkills
        '
        Me.LBL_BonusSkills.AutoSize = True
        Me.LBL_BonusSkills.Location = New System.Drawing.Point(6, 43)
        Me.LBL_BonusSkills.Name = "LBL_BonusSkills"
        Me.LBL_BonusSkills.Size = New System.Drawing.Size(74, 13)
        Me.LBL_BonusSkills.TabIndex = 24
        Me.LBL_BonusSkills.Text = "Bonus to skills"
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(228, 408)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 22
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'SLV_Specialties
        '
        Me.SLV_Specialties.Editable = True
        Me.SLV_Specialties.Location = New System.Drawing.Point(6, 61)
        Me.SLV_Specialties.Name = "SLV_Specialties"
        Me.SLV_Specialties.Size = New System.Drawing.Size(281, 124)
        Me.SLV_Specialties.TabIndex = 41
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 439)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.GBX_Classes)
        Me.Controls.Add(Me.BTN_New)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.CBX_Names)
        Me.Name = "Classes"
        Me.Text = "Classes"
        Me.GBX_Classes.ResumeLayout(False)
        Me.GBX_Classes.PerformLayout()
        CType(Me.NUD_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Wil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Int, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Agi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Str, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents GBX_Classes As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Name As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusSkills As System.Windows.Forms.Label
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
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RBN_Energy As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Mana As System.Windows.Forms.RadioButton
    Friend WithEvents SLV_Specialties As MediCalc.SkillsListView
End Class
