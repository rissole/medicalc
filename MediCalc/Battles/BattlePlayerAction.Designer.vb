<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattlePlayerAction
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ACB_Item = New MediCalc.AssocComboBox()
        Me.ACB_Spell = New MediCalc.AssocComboBox()
        Me.RBN_Item = New System.Windows.Forms.RadioButton()
        Me.RBN_Spell = New System.Windows.Forms.RadioButton()
        Me.RBN_Block = New System.Windows.Forms.RadioButton()
        Me.RBN_Ranged = New System.Windows.Forms.RadioButton()
        Me.RBN_Melee = New System.Windows.Forms.RadioButton()
        Me.BTN_Done = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ACB_Single = New MediCalc.AssocComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBN_AllFriends = New System.Windows.Forms.RadioButton()
        Me.RBN_AllEnemies = New System.Windows.Forms.RadioButton()
        Me.RBN_Single = New System.Windows.Forms.RadioButton()
        Me.BTN_Generate = New System.Windows.Forms.Button()
        Me.MouseOverTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ACB_Item)
        Me.GroupBox1.Controls.Add(Me.ACB_Spell)
        Me.GroupBox1.Controls.Add(Me.RBN_Item)
        Me.GroupBox1.Controls.Add(Me.RBN_Spell)
        Me.GroupBox1.Controls.Add(Me.RBN_Block)
        Me.GroupBox1.Controls.Add(Me.RBN_Ranged)
        Me.GroupBox1.Controls.Add(Me.RBN_Melee)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'ACB_Item
        '
        Me.ACB_Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACB_Item.FormattingEnabled = True
        Me.ACB_Item.Location = New System.Drawing.Point(103, 90)
        Me.ACB_Item.Name = "ACB_Item"
        Me.ACB_Item.Size = New System.Drawing.Size(96, 21)
        Me.ACB_Item.TabIndex = 8
        '
        'ACB_Spell
        '
        Me.ACB_Spell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACB_Spell.FormattingEnabled = True
        Me.ACB_Spell.Location = New System.Drawing.Point(103, 64)
        Me.ACB_Spell.Name = "ACB_Spell"
        Me.ACB_Spell.Size = New System.Drawing.Size(96, 21)
        Me.ACB_Spell.TabIndex = 7
        '
        'RBN_Item
        '
        Me.RBN_Item.AutoSize = True
        Me.RBN_Item.Location = New System.Drawing.Point(7, 91)
        Me.RBN_Item.Name = "RBN_Item"
        Me.RBN_Item.Size = New System.Drawing.Size(66, 17)
        Me.RBN_Item.TabIndex = 4
        Me.RBN_Item.TabStop = True
        Me.RBN_Item.Text = "Use item"
        Me.RBN_Item.UseVisualStyleBackColor = True
        '
        'RBN_Spell
        '
        Me.RBN_Spell.AutoSize = True
        Me.RBN_Spell.Location = New System.Drawing.Point(7, 67)
        Me.RBN_Spell.Name = "RBN_Spell"
        Me.RBN_Spell.Size = New System.Drawing.Size(70, 17)
        Me.RBN_Spell.TabIndex = 3
        Me.RBN_Spell.TabStop = True
        Me.RBN_Spell.Text = "Cast spell"
        Me.RBN_Spell.UseVisualStyleBackColor = True
        '
        'RBN_Block
        '
        Me.RBN_Block.AutoSize = True
        Me.RBN_Block.Location = New System.Drawing.Point(7, 44)
        Me.RBN_Block.Name = "RBN_Block"
        Me.RBN_Block.Size = New System.Drawing.Size(52, 17)
        Me.RBN_Block.TabIndex = 2
        Me.RBN_Block.TabStop = True
        Me.RBN_Block.Text = "Block"
        Me.MouseOverTip.SetToolTip(Me.RBN_Block, "You can ignore target for this one.")
        Me.RBN_Block.UseVisualStyleBackColor = True
        '
        'RBN_Ranged
        '
        Me.RBN_Ranged.AutoSize = True
        Me.RBN_Ranged.Location = New System.Drawing.Point(103, 20)
        Me.RBN_Ranged.Name = "RBN_Ranged"
        Me.RBN_Ranged.Size = New System.Drawing.Size(96, 17)
        Me.RBN_Ranged.TabIndex = 1
        Me.RBN_Ranged.TabStop = True
        Me.RBN_Ranged.Text = "Ranged attack"
        Me.RBN_Ranged.UseVisualStyleBackColor = True
        '
        'RBN_Melee
        '
        Me.RBN_Melee.AutoSize = True
        Me.RBN_Melee.Location = New System.Drawing.Point(7, 20)
        Me.RBN_Melee.Name = "RBN_Melee"
        Me.RBN_Melee.Size = New System.Drawing.Size(87, 17)
        Me.RBN_Melee.TabIndex = 0
        Me.RBN_Melee.TabStop = True
        Me.RBN_Melee.Text = "Melee attack"
        Me.RBN_Melee.UseVisualStyleBackColor = True
        '
        'BTN_Done
        '
        Me.BTN_Done.Location = New System.Drawing.Point(315, 160)
        Me.BTN_Done.Name = "BTN_Done"
        Me.BTN_Done.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Done.TabIndex = 1
        Me.BTN_Done.Text = "Done"
        Me.BTN_Done.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(10, 160)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Clear.TabIndex = 6
        Me.BTN_Clear.Text = "Clear action"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ACB_Single)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RBN_AllFriends)
        Me.GroupBox2.Controls.Add(Me.RBN_AllEnemies)
        Me.GroupBox2.Controls.Add(Me.RBN_Single)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 119)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target"
        '
        'ACB_Single
        '
        Me.ACB_Single.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACB_Single.FormattingEnabled = True
        Me.ACB_Single.Location = New System.Drawing.Point(28, 30)
        Me.ACB_Single.Name = "ACB_Single"
        Me.ACB_Single.Size = New System.Drawing.Size(129, 21)
        Me.ACB_Single.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "All"
        Me.MouseOverTip.SetToolTip(Me.Label1, "Only really viable for Spell and Item effects" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Power cost will be charged as if o" & _
                "nly 1 target was chosen.")
        '
        'RBN_AllFriends
        '
        Me.RBN_AllFriends.AutoSize = True
        Me.RBN_AllFriends.Location = New System.Drawing.Point(96, 61)
        Me.RBN_AllFriends.Name = "RBN_AllFriends"
        Me.RBN_AllFriends.Size = New System.Drawing.Size(56, 17)
        Me.RBN_AllFriends.TabIndex = 6
        Me.RBN_AllFriends.TabStop = True
        Me.RBN_AllFriends.Text = "friends"
        Me.RBN_AllFriends.UseVisualStyleBackColor = True
        '
        'RBN_AllEnemies
        '
        Me.RBN_AllEnemies.AutoSize = True
        Me.RBN_AllEnemies.Location = New System.Drawing.Point(26, 61)
        Me.RBN_AllEnemies.Name = "RBN_AllEnemies"
        Me.RBN_AllEnemies.Size = New System.Drawing.Size(64, 17)
        Me.RBN_AllEnemies.TabIndex = 5
        Me.RBN_AllEnemies.TabStop = True
        Me.RBN_AllEnemies.Text = "enemies"
        Me.RBN_AllEnemies.UseVisualStyleBackColor = True
        '
        'RBN_Single
        '
        Me.RBN_Single.AutoSize = True
        Me.RBN_Single.Location = New System.Drawing.Point(7, 33)
        Me.RBN_Single.Name = "RBN_Single"
        Me.RBN_Single.Size = New System.Drawing.Size(14, 13)
        Me.RBN_Single.TabIndex = 3
        Me.RBN_Single.TabStop = True
        Me.RBN_Single.UseVisualStyleBackColor = True
        '
        'BTN_Generate
        '
        Me.BTN_Generate.Location = New System.Drawing.Point(93, 160)
        Me.BTN_Generate.Name = "BTN_Generate"
        Me.BTN_Generate.Size = New System.Drawing.Size(128, 23)
        Me.BTN_Generate.TabIndex = 8
        Me.BTN_Generate.Text = "Generate options post"
        Me.BTN_Generate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To leave combat, use 'Remove from battle' on the Direct player edit screen."
        '
        'BattlePlayerAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 191)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_Generate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.BTN_Done)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BattlePlayerAction"
        Me.Text = "Player action"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBN_Block As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Ranged As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Melee As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Item As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Spell As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_Done As System.Windows.Forms.Button
    Friend WithEvents BTN_Clear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBN_AllFriends As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_AllEnemies As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Single As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_Generate As System.Windows.Forms.Button
    Friend WithEvents ACB_Spell As MediCalc.AssocComboBox
    Friend WithEvents ACB_Item As MediCalc.AssocComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MouseOverTip As System.Windows.Forms.ToolTip
    Friend WithEvents ACB_Single As MediCalc.AssocComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
