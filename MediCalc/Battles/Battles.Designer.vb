<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battles
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
        Me.CBX_Saved = New System.Windows.Forms.ComboBox()
        Me.BTN_Load = New System.Windows.Forms.Button()
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBX_Saved
        '
        Me.CBX_Saved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Saved.FormattingEnabled = True
        Me.CBX_Saved.Location = New System.Drawing.Point(65, 22)
        Me.CBX_Saved.Name = "CBX_Saved"
        Me.CBX_Saved.Size = New System.Drawing.Size(153, 21)
        Me.CBX_Saved.TabIndex = 0
        '
        'BTN_Load
        '
        Me.BTN_Load.Location = New System.Drawing.Point(14, 53)
        Me.BTN_Load.Name = "BTN_Load"
        Me.BTN_Load.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Load.TabIndex = 1
        Me.BTN_Load.Text = "Load battle"
        Me.BTN_Load.UseVisualStyleBackColor = True
        '
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(191, 19)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 2
        Me.BTN_New.Text = "Create new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(65, 21)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(109, 20)
        Me.TBX_Name.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBX_Name)
        Me.GroupBox1.Controls.Add(Me.BTN_New)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create a new battle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_Delete)
        Me.GroupBox2.Controls.Add(Me.CBX_Saved)
        Me.GroupBox2.Controls.Add(Me.BTN_Load)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 86)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage saved battles"
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(191, 53)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 2
        Me.BTN_Delete.Text = "Delete battle"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(221, 180)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 22
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "TIP: Battles automatically save as you edit them."
        '
        'Battles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 211)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Battles"
        Me.Text = "Battles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBX_Saved As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_Load As System.Windows.Forms.Button
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
