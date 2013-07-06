<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleInput
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
        Me.LBL_Field = New System.Windows.Forms.Label()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.MTB_Value = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'LBL_Field
        '
        Me.LBL_Field.AutoSize = True
        Me.LBL_Field.Location = New System.Drawing.Point(8, 27)
        Me.LBL_Field.Name = "LBL_Field"
        Me.LBL_Field.Size = New System.Drawing.Size(37, 13)
        Me.LBL_Field.TabIndex = 2
        Me.LBL_Field.Text = "Value:"
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(162, 37)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancel.TabIndex = 4
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'BTN_OK
        '
        Me.BTN_OK.Location = New System.Drawing.Point(162, 8)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OK.TabIndex = 3
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'MTB_Value
        '
        Me.MTB_Value.Location = New System.Drawing.Point(51, 24)
        Me.MTB_Value.Name = "MTB_Value"
        Me.MTB_Value.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MTB_Value.Size = New System.Drawing.Size(105, 20)
        Me.MTB_Value.TabIndex = 5
        '
        'SimpleInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 68)
        Me.Controls.Add(Me.MTB_Value)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.LBL_Field)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SimpleInput"
        Me.Text = "Input new value"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_Field As System.Windows.Forms.Label
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents BTN_OK As System.Windows.Forms.Button
    Friend WithEvents MTB_Value As System.Windows.Forms.MaskedTextBox
End Class
