<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleLog
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
        Me.RTB_Log = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RTB_Log
        '
        Me.RTB_Log.BackColor = System.Drawing.SystemColors.Window
        Me.RTB_Log.Location = New System.Drawing.Point(13, 13)
        Me.RTB_Log.Name = "RTB_Log"
        Me.RTB_Log.ReadOnly = True
        Me.RTB_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RTB_Log.Size = New System.Drawing.Size(544, 194)
        Me.RTB_Log.TabIndex = 0
        Me.RTB_Log.Text = ""
        '
        'BattleLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 219)
        Me.Controls.Add(Me.RTB_Log)
        Me.Name = "BattleLog"
        Me.Text = "Turn log"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTB_Log As System.Windows.Forms.RichTextBox
End Class
