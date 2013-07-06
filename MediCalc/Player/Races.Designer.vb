<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Races
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
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.GBX_Races = New System.Windows.Forms.GroupBox()
        Me.CHX_Science = New System.Windows.Forms.CheckBox()
        Me.CHX_Fletching = New System.Windows.Forms.CheckBox()
        Me.CHX_Carpentry = New System.Windows.Forms.CheckBox()
        Me.CHX_Writing = New System.Windows.Forms.CheckBox()
        Me.CHX_Enchanting = New System.Windows.Forms.CheckBox()
        Me.CHX_Tailoring = New System.Windows.Forms.CheckBox()
        Me.CHX_Leather = New System.Windows.Forms.CheckBox()
        Me.CHX_Alchemy = New System.Windows.Forms.CheckBox()
        Me.CHX_Jewel = New System.Windows.Forms.CheckBox()
        Me.CHX_Blacksmithing = New System.Windows.Forms.CheckBox()
        Me.CHX_Fishing = New System.Windows.Forms.CheckBox()
        Me.CHX_Cooking = New System.Windows.Forms.CheckBox()
        Me.CHX_Skinning = New System.Windows.Forms.CheckBox()
        Me.CHX_Herbalism = New System.Windows.Forms.CheckBox()
        Me.CHX_Mining = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.LBL_BonusSkills = New System.Windows.Forms.Label()
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.SLV_Specialties = New MediCalc.SkillsListView()
        Me.GBX_Races.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(252, 36)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(53, 20)
        Me.TBX_ID.TabIndex = 10
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Location = New System.Drawing.Point(225, 39)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(21, 13)
        Me.LBL_ID.TabIndex = 9
        Me.LBL_ID.Text = "ID:"
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(12, 36)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 8
        '
        'GBX_Races
        '
        Me.GBX_Races.Controls.Add(Me.SLV_Specialties)
        Me.GBX_Races.Controls.Add(Me.CHX_Science)
        Me.GBX_Races.Controls.Add(Me.CHX_Fletching)
        Me.GBX_Races.Controls.Add(Me.CHX_Carpentry)
        Me.GBX_Races.Controls.Add(Me.CHX_Writing)
        Me.GBX_Races.Controls.Add(Me.CHX_Enchanting)
        Me.GBX_Races.Controls.Add(Me.CHX_Tailoring)
        Me.GBX_Races.Controls.Add(Me.CHX_Leather)
        Me.GBX_Races.Controls.Add(Me.CHX_Alchemy)
        Me.GBX_Races.Controls.Add(Me.CHX_Jewel)
        Me.GBX_Races.Controls.Add(Me.CHX_Blacksmithing)
        Me.GBX_Races.Controls.Add(Me.CHX_Fishing)
        Me.GBX_Races.Controls.Add(Me.CHX_Cooking)
        Me.GBX_Races.Controls.Add(Me.CHX_Skinning)
        Me.GBX_Races.Controls.Add(Me.CHX_Herbalism)
        Me.GBX_Races.Controls.Add(Me.CHX_Mining)
        Me.GBX_Races.Controls.Add(Me.Label1)
        Me.GBX_Races.Controls.Add(Me.TBX_Name)
        Me.GBX_Races.Controls.Add(Me.LBL_Name)
        Me.GBX_Races.Controls.Add(Me.LBL_BonusSkills)
        Me.GBX_Races.Location = New System.Drawing.Point(12, 65)
        Me.GBX_Races.Name = "GBX_Races"
        Me.GBX_Races.Size = New System.Drawing.Size(293, 330)
        Me.GBX_Races.TabIndex = 11
        Me.GBX_Races.TabStop = False
        Me.GBX_Races.Text = "Race info"
        '
        'CHX_Science
        '
        Me.CHX_Science.AutoSize = True
        Me.CHX_Science.Location = New System.Drawing.Point(219, 250)
        Me.CHX_Science.Name = "CHX_Science"
        Me.CHX_Science.Size = New System.Drawing.Size(65, 17)
        Me.CHX_Science.TabIndex = 42
        Me.CHX_Science.Text = "Science"
        Me.CHX_Science.UseVisualStyleBackColor = True
        '
        'CHX_Fletching
        '
        Me.CHX_Fletching.AutoSize = True
        Me.CHX_Fletching.Location = New System.Drawing.Point(219, 230)
        Me.CHX_Fletching.Name = "CHX_Fletching"
        Me.CHX_Fletching.Size = New System.Drawing.Size(69, 17)
        Me.CHX_Fletching.TabIndex = 41
        Me.CHX_Fletching.Text = "Fletching"
        Me.CHX_Fletching.UseVisualStyleBackColor = True
        '
        'CHX_Carpentry
        '
        Me.CHX_Carpentry.AutoSize = True
        Me.CHX_Carpentry.Location = New System.Drawing.Point(219, 210)
        Me.CHX_Carpentry.Name = "CHX_Carpentry"
        Me.CHX_Carpentry.Size = New System.Drawing.Size(71, 17)
        Me.CHX_Carpentry.TabIndex = 40
        Me.CHX_Carpentry.Text = "Carpentry"
        Me.CHX_Carpentry.UseVisualStyleBackColor = True
        '
        'CHX_Writing
        '
        Me.CHX_Writing.AutoSize = True
        Me.CHX_Writing.Location = New System.Drawing.Point(112, 305)
        Me.CHX_Writing.Name = "CHX_Writing"
        Me.CHX_Writing.Size = New System.Drawing.Size(59, 17)
        Me.CHX_Writing.TabIndex = 39
        Me.CHX_Writing.Text = "Writing"
        Me.CHX_Writing.UseVisualStyleBackColor = True
        '
        'CHX_Enchanting
        '
        Me.CHX_Enchanting.AutoSize = True
        Me.CHX_Enchanting.Location = New System.Drawing.Point(112, 286)
        Me.CHX_Enchanting.Name = "CHX_Enchanting"
        Me.CHX_Enchanting.Size = New System.Drawing.Size(80, 17)
        Me.CHX_Enchanting.TabIndex = 38
        Me.CHX_Enchanting.Text = "Enchanting"
        Me.CHX_Enchanting.UseVisualStyleBackColor = True
        '
        'CHX_Tailoring
        '
        Me.CHX_Tailoring.AutoSize = True
        Me.CHX_Tailoring.Location = New System.Drawing.Point(112, 267)
        Me.CHX_Tailoring.Name = "CHX_Tailoring"
        Me.CHX_Tailoring.Size = New System.Drawing.Size(66, 17)
        Me.CHX_Tailoring.TabIndex = 37
        Me.CHX_Tailoring.Text = "Tailoring"
        Me.CHX_Tailoring.UseVisualStyleBackColor = True
        '
        'CHX_Leather
        '
        Me.CHX_Leather.AutoSize = True
        Me.CHX_Leather.Location = New System.Drawing.Point(112, 248)
        Me.CHX_Leather.Name = "CHX_Leather"
        Me.CHX_Leather.Size = New System.Drawing.Size(99, 17)
        Me.CHX_Leather.TabIndex = 36
        Me.CHX_Leather.Text = "Leatherworking"
        Me.CHX_Leather.UseVisualStyleBackColor = True
        '
        'CHX_Alchemy
        '
        Me.CHX_Alchemy.AutoSize = True
        Me.CHX_Alchemy.Location = New System.Drawing.Point(112, 229)
        Me.CHX_Alchemy.Name = "CHX_Alchemy"
        Me.CHX_Alchemy.Size = New System.Drawing.Size(66, 17)
        Me.CHX_Alchemy.TabIndex = 35
        Me.CHX_Alchemy.Text = "Alchemy"
        Me.CHX_Alchemy.UseVisualStyleBackColor = True
        '
        'CHX_Jewel
        '
        Me.CHX_Jewel.AutoSize = True
        Me.CHX_Jewel.Location = New System.Drawing.Point(112, 210)
        Me.CHX_Jewel.Name = "CHX_Jewel"
        Me.CHX_Jewel.Size = New System.Drawing.Size(88, 17)
        Me.CHX_Jewel.TabIndex = 34
        Me.CHX_Jewel.Text = "Jewelcrafting"
        Me.CHX_Jewel.UseVisualStyleBackColor = True
        '
        'CHX_Blacksmithing
        '
        Me.CHX_Blacksmithing.AutoSize = True
        Me.CHX_Blacksmithing.Location = New System.Drawing.Point(7, 306)
        Me.CHX_Blacksmithing.Name = "CHX_Blacksmithing"
        Me.CHX_Blacksmithing.Size = New System.Drawing.Size(91, 17)
        Me.CHX_Blacksmithing.TabIndex = 33
        Me.CHX_Blacksmithing.Text = "Blacksmithing"
        Me.CHX_Blacksmithing.UseVisualStyleBackColor = True
        '
        'CHX_Fishing
        '
        Me.CHX_Fishing.AutoSize = True
        Me.CHX_Fishing.Location = New System.Drawing.Point(7, 287)
        Me.CHX_Fishing.Name = "CHX_Fishing"
        Me.CHX_Fishing.Size = New System.Drawing.Size(59, 17)
        Me.CHX_Fishing.TabIndex = 32
        Me.CHX_Fishing.Text = "Fishing"
        Me.CHX_Fishing.UseVisualStyleBackColor = True
        '
        'CHX_Cooking
        '
        Me.CHX_Cooking.AutoSize = True
        Me.CHX_Cooking.Location = New System.Drawing.Point(7, 230)
        Me.CHX_Cooking.Name = "CHX_Cooking"
        Me.CHX_Cooking.Size = New System.Drawing.Size(65, 17)
        Me.CHX_Cooking.TabIndex = 31
        Me.CHX_Cooking.Text = "Cooking"
        Me.CHX_Cooking.UseVisualStyleBackColor = True
        '
        'CHX_Skinning
        '
        Me.CHX_Skinning.AutoSize = True
        Me.CHX_Skinning.Location = New System.Drawing.Point(7, 268)
        Me.CHX_Skinning.Name = "CHX_Skinning"
        Me.CHX_Skinning.Size = New System.Drawing.Size(67, 17)
        Me.CHX_Skinning.TabIndex = 30
        Me.CHX_Skinning.Text = "Skinning"
        Me.CHX_Skinning.UseVisualStyleBackColor = True
        '
        'CHX_Herbalism
        '
        Me.CHX_Herbalism.AutoSize = True
        Me.CHX_Herbalism.Location = New System.Drawing.Point(7, 249)
        Me.CHX_Herbalism.Name = "CHX_Herbalism"
        Me.CHX_Herbalism.Size = New System.Drawing.Size(72, 17)
        Me.CHX_Herbalism.TabIndex = 29
        Me.CHX_Herbalism.Text = "Herbalism"
        Me.CHX_Herbalism.UseVisualStyleBackColor = True
        '
        'CHX_Mining
        '
        Me.CHX_Mining.AutoSize = True
        Me.CHX_Mining.Location = New System.Drawing.Point(7, 211)
        Me.CHX_Mining.Name = "CHX_Mining"
        Me.CHX_Mining.Size = New System.Drawing.Size(57, 17)
        Me.CHX_Mining.TabIndex = 28
        Me.CHX_Mining.Text = "Mining"
        Me.CHX_Mining.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "XP Bonus to professions"
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
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(74, 6)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 14
        Me.BTN_New.Text = "Add new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(155, 6)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 13
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(236, 6)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 12
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(236, 401)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 15
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'SLV_Specialties
        '
        Me.SLV_Specialties.Editable = True
        Me.SLV_Specialties.Location = New System.Drawing.Point(7, 60)
        Me.SLV_Specialties.Name = "SLV_Specialties"
        Me.SLV_Specialties.Size = New System.Drawing.Size(281, 131)
        Me.SLV_Specialties.TabIndex = 43
        '
        'Races
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 430)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.BTN_New)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.GBX_Races)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.CBX_Names)
        Me.Name = "Races"
        Me.Text = "Races"
        Me.GBX_Races.ResumeLayout(False)
        Me.GBX_Races.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents GBX_Races As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Name As System.Windows.Forms.Label
    Friend WithEvents LBL_BonusSkills As System.Windows.Forms.Label
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHX_Fishing As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Cooking As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Skinning As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Herbalism As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Mining As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Writing As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Enchanting As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Tailoring As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Leather As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Alchemy As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Jewel As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Blacksmithing As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Science As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Fletching As System.Windows.Forms.CheckBox
    Friend WithEvents CHX_Carpentry As System.Windows.Forms.CheckBox
    Friend WithEvents SLV_Specialties As MediCalc.SkillsListView
End Class
