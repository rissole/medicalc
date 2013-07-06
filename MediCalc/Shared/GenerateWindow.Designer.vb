<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateWindow
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
        Me.TBX_Output = New System.Windows.Forms.TextBox()
        Me.BTN_Copy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBX_Output
        '
        Me.TBX_Output.BackColor = System.Drawing.Color.White
        Me.TBX_Output.Location = New System.Drawing.Point(13, 13)
        Me.TBX_Output.Multiline = True
        Me.TBX_Output.Name = "TBX_Output"
        Me.TBX_Output.ReadOnly = True
        Me.TBX_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_Output.Size = New System.Drawing.Size(391, 226)
        Me.TBX_Output.TabIndex = 0
        '
        'BTN_Copy
        '
        Me.BTN_Copy.Location = New System.Drawing.Point(155, 245)
        Me.BTN_Copy.Name = "BTN_Copy"
        Me.BTN_Copy.Size = New System.Drawing.Size(107, 23)
        Me.BTN_Copy.TabIndex = 1
        Me.BTN_Copy.Text = "Copy all"
        Me.BTN_Copy.UseVisualStyleBackColor = True
        '
        'GenerateWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 275)
        Me.Controls.Add(Me.BTN_Copy)
        Me.Controls.Add(Me.TBX_Output)
        Me.Name = "GenerateWindow"
        Me.Text = "Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBX_Output As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Copy As System.Windows.Forms.Button
End Class
