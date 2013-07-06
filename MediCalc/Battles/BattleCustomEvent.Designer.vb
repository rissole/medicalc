<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleCustomEvent
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
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.BTN_New = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.TBX_ID = New System.Windows.Forms.TextBox()
        Me.CBX_Names = New System.Windows.Forms.ComboBox()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.RBN_Before = New System.Windows.Forms.RadioButton()
        Me.RBN_After = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Text = New System.Windows.Forms.TextBox()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.TBX_BID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_OK
        '
        Me.BTN_OK.Location = New System.Drawing.Point(142, 219)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OK.TabIndex = 29
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'BTN_New
        '
        Me.BTN_New.Location = New System.Drawing.Point(12, 12)
        Me.BTN_New.Name = "BTN_New"
        Me.BTN_New.Size = New System.Drawing.Size(75, 23)
        Me.BTN_New.TabIndex = 28
        Me.BTN_New.Text = "Add new"
        Me.BTN_New.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(93, 12)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 27
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'TBX_ID
        '
        Me.TBX_ID.Location = New System.Drawing.Point(191, 41)
        Me.TBX_ID.Name = "TBX_ID"
        Me.TBX_ID.ReadOnly = True
        Me.TBX_ID.Size = New System.Drawing.Size(10, 20)
        Me.TBX_ID.TabIndex = 25
        Me.TBX_ID.Visible = False
        '
        'CBX_Names
        '
        Me.CBX_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Names.FormattingEnabled = True
        Me.CBX_Names.Location = New System.Drawing.Point(12, 41)
        Me.CBX_Names.Name = "CBX_Names"
        Me.CBX_Names.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Names.Sorted = True
        Me.CBX_Names.TabIndex = 23
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(159, 41)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(10, 20)
        Me.TBX_Name.TabIndex = 30
        Me.TBX_Name.Visible = False
        '
        'RBN_Before
        '
        Me.RBN_Before.AutoSize = True
        Me.RBN_Before.Location = New System.Drawing.Point(6, 39)
        Me.RBN_Before.Name = "RBN_Before"
        Me.RBN_Before.Size = New System.Drawing.Size(93, 17)
        Me.RBN_Before.TabIndex = 31
        Me.RBN_Before.TabStop = True
        Me.RBN_Before.Text = "Before actions"
        Me.RBN_Before.UseVisualStyleBackColor = True
        '
        'RBN_After
        '
        Me.RBN_After.AutoSize = True
        Me.RBN_After.Location = New System.Drawing.Point(105, 39)
        Me.RBN_After.Name = "RBN_After"
        Me.RBN_After.Size = New System.Drawing.Size(84, 17)
        Me.RBN_After.TabIndex = 32
        Me.RBN_After.TabStop = True
        Me.RBN_After.Text = "After actions"
        Me.RBN_After.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBX_Text)
        Me.GroupBox1.Controls.Add(Me.RBN_Before)
        Me.GroupBox1.Controls.Add(Me.RBN_After)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 145)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text should appear:"
        '
        'TBX_Text
        '
        Me.TBX_Text.Location = New System.Drawing.Point(6, 62)
        Me.TBX_Text.Multiline = True
        Me.TBX_Text.Name = "TBX_Text"
        Me.TBX_Text.Size = New System.Drawing.Size(192, 77)
        Me.TBX_Text.TabIndex = 33
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(58, 219)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancel.TabIndex = 34
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'TBX_BID
        '
        Me.TBX_BID.Location = New System.Drawing.Point(139, 42)
        Me.TBX_BID.Name = "TBX_BID"
        Me.TBX_BID.ReadOnly = True
        Me.TBX_BID.Size = New System.Drawing.Size(10, 20)
        Me.TBX_BID.TabIndex = 35
        Me.TBX_BID.Visible = False
        '
        'BattleCustomEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 250)
        Me.Controls.Add(Me.TBX_BID)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBX_Name)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.BTN_New)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.TBX_ID)
        Me.Controls.Add(Me.CBX_Names)
        Me.Name = "BattleCustomEvent"
        Me.Text = "Custom event"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_OK As System.Windows.Forms.Button
    Friend WithEvents BTN_New As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents TBX_ID As System.Windows.Forms.TextBox
    Friend WithEvents CBX_Names As System.Windows.Forms.ComboBox
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents RBN_Before As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_After As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents TBX_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBX_BID As System.Windows.Forms.TextBox
End Class
