<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleNPCAction
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Desc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBX_Miss = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_FHelp = New System.Windows.Forms.Button()
        Me.TBX_Damage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ACB_Single = New MediCalc.AssocComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RBN_AllFriends = New System.Windows.Forms.RadioButton()
        Me.RBN_AllEnemies = New System.Windows.Forms.RadioButton()
        Me.RBN_RandomFriend = New System.Windows.Forms.RadioButton()
        Me.RBN_RandomEnemy = New System.Windows.Forms.RadioButton()
        Me.RBN_Single = New System.Windows.Forms.RadioButton()
        Me.BTN_Done = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.RBN_None = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a short description of the attack (past tense):"
        '
        'TBX_Desc
        '
        Me.TBX_Desc.Location = New System.Drawing.Point(9, 32)
        Me.TBX_Desc.Name = "TBX_Desc"
        Me.TBX_Desc.Size = New System.Drawing.Size(301, 20)
        Me.TBX_Desc.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBX_Miss)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BTN_FHelp)
        Me.GroupBox1.Controls.Add(Me.TBX_Damage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBX_Desc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 190)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attack"
        '
        'TBX_Miss
        '
        Me.TBX_Miss.Location = New System.Drawing.Point(113, 162)
        Me.TBX_Miss.Name = "TBX_Miss"
        Me.TBX_Miss.Size = New System.Drawing.Size(40, 20)
        Me.TBX_Miss.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Miss chance (0-100)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Special characters for attack description:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%d => The amount of damage done" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%t =" & _
            "> The target's name"
        '
        'BTN_FHelp
        '
        Me.BTN_FHelp.Location = New System.Drawing.Point(235, 133)
        Me.BTN_FHelp.Name = "BTN_FHelp"
        Me.BTN_FHelp.Size = New System.Drawing.Size(75, 23)
        Me.BTN_FHelp.TabIndex = 4
        Me.BTN_FHelp.TabStop = False
        Me.BTN_FHelp.Text = "Formula help"
        Me.BTN_FHelp.UseVisualStyleBackColor = True
        '
        'TBX_Damage
        '
        Me.TBX_Damage.BackColor = System.Drawing.Color.Azure
        Me.TBX_Damage.Location = New System.Drawing.Point(9, 136)
        Me.TBX_Damage.Name = "TBX_Damage"
        Me.TBX_Damage.Size = New System.Drawing.Size(144, 20)
        Me.TBX_Damage.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Damage range"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ACB_Single)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.RBN_AllFriends)
        Me.GroupBox2.Controls.Add(Me.RBN_AllEnemies)
        Me.GroupBox2.Controls.Add(Me.RBN_RandomFriend)
        Me.GroupBox2.Controls.Add(Me.RBN_None)
        Me.GroupBox2.Controls.Add(Me.RBN_RandomEnemy)
        Me.GroupBox2.Controls.Add(Me.RBN_Single)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target"
        '
        'ACB_Single
        '
        Me.ACB_Single.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACB_Single.FormattingEnabled = True
        Me.ACB_Single.Location = New System.Drawing.Point(27, 29)
        Me.ACB_Single.Name = "ACB_Single"
        Me.ACB_Single.Size = New System.Drawing.Size(129, 21)
        Me.ACB_Single.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Random"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "All"
        '
        'RBN_AllFriends
        '
        Me.RBN_AllFriends.AutoSize = True
        Me.RBN_AllFriends.Location = New System.Drawing.Point(99, 58)
        Me.RBN_AllFriends.Name = "RBN_AllFriends"
        Me.RBN_AllFriends.Size = New System.Drawing.Size(56, 17)
        Me.RBN_AllFriends.TabIndex = 9
        Me.RBN_AllFriends.TabStop = True
        Me.RBN_AllFriends.Text = "friends"
        Me.RBN_AllFriends.UseVisualStyleBackColor = True
        '
        'RBN_AllEnemies
        '
        Me.RBN_AllEnemies.AutoSize = True
        Me.RBN_AllEnemies.Location = New System.Drawing.Point(29, 58)
        Me.RBN_AllEnemies.Name = "RBN_AllEnemies"
        Me.RBN_AllEnemies.Size = New System.Drawing.Size(64, 17)
        Me.RBN_AllEnemies.TabIndex = 8
        Me.RBN_AllEnemies.TabStop = True
        Me.RBN_AllEnemies.Text = "enemies"
        Me.RBN_AllEnemies.UseVisualStyleBackColor = True
        '
        'RBN_RandomFriend
        '
        Me.RBN_RandomFriend.AutoSize = True
        Me.RBN_RandomFriend.Location = New System.Drawing.Point(110, 87)
        Me.RBN_RandomFriend.Name = "RBN_RandomFriend"
        Me.RBN_RandomFriend.Size = New System.Drawing.Size(51, 17)
        Me.RBN_RandomFriend.TabIndex = 6
        Me.RBN_RandomFriend.TabStop = True
        Me.RBN_RandomFriend.Text = "friend"
        Me.RBN_RandomFriend.UseVisualStyleBackColor = True
        '
        'RBN_RandomEnemy
        '
        Me.RBN_RandomEnemy.AutoSize = True
        Me.RBN_RandomEnemy.Location = New System.Drawing.Point(51, 87)
        Me.RBN_RandomEnemy.Name = "RBN_RandomEnemy"
        Me.RBN_RandomEnemy.Size = New System.Drawing.Size(59, 17)
        Me.RBN_RandomEnemy.TabIndex = 5
        Me.RBN_RandomEnemy.TabStop = True
        Me.RBN_RandomEnemy.Text = " enemy"
        Me.RBN_RandomEnemy.UseVisualStyleBackColor = True
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
        'BTN_Done
        '
        Me.BTN_Done.Location = New System.Drawing.Point(427, 208)
        Me.BTN_Done.Name = "BTN_Done"
        Me.BTN_Done.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Done.TabIndex = 4
        Me.BTN_Done.Text = "Done"
        Me.BTN_Done.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(12, 208)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Clear.TabIndex = 5
        Me.BTN_Clear.Text = "Clear action"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'RBN_None
        '
        Me.RBN_None.AutoSize = True
        Me.RBN_None.Location = New System.Drawing.Point(7, 135)
        Me.RBN_None.Name = "RBN_None"
        Me.RBN_None.Size = New System.Drawing.Size(51, 17)
        Me.RBN_None.TabIndex = 7
        Me.RBN_None.TabStop = True
        Me.RBN_None.Text = "None"
        Me.RBN_None.UseVisualStyleBackColor = True
        '
        'BattleNPCAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 243)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.BTN_Done)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BattleNPCAction"
        Me.Text = "NPC Action"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBX_Desc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_Damage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_FHelp As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Done As System.Windows.Forms.Button
    Friend WithEvents RBN_RandomEnemy As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_Single As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_Clear As System.Windows.Forms.Button
    Friend WithEvents RBN_RandomFriend As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RBN_AllFriends As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_AllEnemies As System.Windows.Forms.RadioButton
    Friend WithEvents ACB_Single As MediCalc.AssocComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBX_Miss As System.Windows.Forms.TextBox
    Friend WithEvents RBN_None As System.Windows.Forms.RadioButton
End Class
