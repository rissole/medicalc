<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattlePlayerEditEffects
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
        Me.LBX_Effects = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Remove = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBX_Effects
        '
        Me.LBX_Effects.FormattingEnabled = True
        Me.LBX_Effects.Location = New System.Drawing.Point(16, 33)
        Me.LBX_Effects.Name = "LBX_Effects"
        Me.LBX_Effects.Size = New System.Drawing.Size(176, 238)
        Me.LBX_Effects.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Here you can manually remove effects. This is irreversible."
        '
        'BTN_Remove
        '
        Me.BTN_Remove.Location = New System.Drawing.Point(198, 33)
        Me.BTN_Remove.Name = "BTN_Remove"
        Me.BTN_Remove.Size = New System.Drawing.Size(83, 23)
        Me.BTN_Remove.TabIndex = 2
        Me.BTN_Remove.Text = "Remove"
        Me.BTN_Remove.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(198, 248)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(83, 23)
        Me.BTN_Close.TabIndex = 3
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'BattlePlayerEditEffects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 280)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.BTN_Remove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBX_Effects)
        Me.Name = "BattlePlayerEditEffects"
        Me.Text = "Edit player effects"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBX_Effects As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_Remove As System.Windows.Forms.Button
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
End Class
