<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleSelection
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
        Me.BTN_Choose = New System.Windows.Forms.Button()
        Me.ACB_List = New MediCalc.AssocComboBox()
        Me.SuspendLayout()
        '
        'BTN_Choose
        '
        Me.BTN_Choose.Location = New System.Drawing.Point(197, 10)
        Me.BTN_Choose.Name = "BTN_Choose"
        Me.BTN_Choose.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Choose.TabIndex = 0
        Me.BTN_Choose.Text = "Choose"
        Me.BTN_Choose.UseVisualStyleBackColor = True
        '
        'ACB_List
        '
        Me.ACB_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACB_List.FormattingEnabled = True
        Me.ACB_List.Location = New System.Drawing.Point(13, 11)
        Me.ACB_List.Name = "ACB_List"
        Me.ACB_List.Size = New System.Drawing.Size(178, 21)
        Me.ACB_List.TabIndex = 1
        '
        'SimpleSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 44)
        Me.Controls.Add(Me.ACB_List)
        Me.Controls.Add(Me.BTN_Choose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SimpleSelection"
        Me.Text = "Select value"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_Choose As System.Windows.Forms.Button
    Friend WithEvents ACB_List As MediCalc.AssocComboBox
End Class
