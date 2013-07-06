<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerSpells
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
        Me.BTN_Spells = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.GBX_Spell = New System.Windows.Forms.GroupBox()
        Me.BTN_Add = New System.Windows.Forms.Button()
        Me.TBX_SpellString = New System.Windows.Forms.TextBox()
        Me.CBX_Spells = New System.Windows.Forms.ComboBox()
        Me.LBX_Spells = New System.Windows.Forms.ListBox()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GBX_Spell.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Spells
        '
        Me.BTN_Spells.Location = New System.Drawing.Point(12, 12)
        Me.BTN_Spells.Name = "BTN_Spells"
        Me.BTN_Spells.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Spells.TabIndex = 35
        Me.BTN_Spells.Text = "Edit Spells"
        Me.BTN_Spells.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(357, 12)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 34
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'GBX_Spell
        '
        Me.GBX_Spell.Controls.Add(Me.BTN_Add)
        Me.GBX_Spell.Controls.Add(Me.TBX_SpellString)
        Me.GBX_Spell.Controls.Add(Me.CBX_Spells)
        Me.GBX_Spell.Location = New System.Drawing.Point(12, 41)
        Me.GBX_Spell.Name = "GBX_Spell"
        Me.GBX_Spell.Size = New System.Drawing.Size(215, 146)
        Me.GBX_Spell.TabIndex = 36
        Me.GBX_Spell.TabStop = False
        Me.GBX_Spell.Text = "Spell"
        '
        'BTN_Add
        '
        Me.BTN_Add.Location = New System.Drawing.Point(70, 117)
        Me.BTN_Add.Name = "BTN_Add"
        Me.BTN_Add.Size = New System.Drawing.Size(72, 23)
        Me.BTN_Add.TabIndex = 3
        Me.BTN_Add.Text = "Add"
        Me.BTN_Add.UseVisualStyleBackColor = True
        '
        'TBX_SpellString
        '
        Me.TBX_SpellString.Location = New System.Drawing.Point(7, 48)
        Me.TBX_SpellString.Multiline = True
        Me.TBX_SpellString.Name = "TBX_SpellString"
        Me.TBX_SpellString.ReadOnly = True
        Me.TBX_SpellString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_SpellString.Size = New System.Drawing.Size(202, 63)
        Me.TBX_SpellString.TabIndex = 1
        '
        'CBX_Spells
        '
        Me.CBX_Spells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Spells.FormattingEnabled = True
        Me.CBX_Spells.Location = New System.Drawing.Point(46, 19)
        Me.CBX_Spells.Name = "CBX_Spells"
        Me.CBX_Spells.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Spells.Sorted = True
        Me.CBX_Spells.TabIndex = 0
        '
        'LBX_Spells
        '
        Me.LBX_Spells.FormattingEnabled = True
        Me.LBX_Spells.Location = New System.Drawing.Point(234, 48)
        Me.LBX_Spells.Name = "LBX_Spells"
        Me.LBX_Spells.Size = New System.Drawing.Size(198, 264)
        Me.LBX_Spells.TabIndex = 37
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(357, 319)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 23
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(39, 190)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Double click a spell to remove it."
        '
        'PlayerSpells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 349)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.LBX_Spells)
        Me.Controls.Add(Me.GBX_Spell)
        Me.Controls.Add(Me.BTN_Spells)
        Me.Controls.Add(Me.BTN_Save)
        Me.Name = "PlayerSpells"
        Me.Text = "Player Spells"
        Me.GBX_Spell.ResumeLayout(False)
        Me.GBX_Spell.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Spells As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents GBX_Spell As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Add As System.Windows.Forms.Button
    Friend WithEvents TBX_SpellString As System.Windows.Forms.TextBox
    Friend WithEvents CBX_Spells As System.Windows.Forms.ComboBox
    Friend WithEvents LBX_Spells As System.Windows.Forms.ListBox
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
