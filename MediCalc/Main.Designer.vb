<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BTN_Players = New System.Windows.Forms.Button()
        Me.BTN_Battle = New System.Windows.Forms.Button()
        Me.BTN_Items = New System.Windows.Forms.Button()
        Me.BTN_Spells = New System.Windows.Forms.Button()
        Me.BTN_Races = New System.Windows.Forms.Button()
        Me.BTN_Classes = New System.Windows.Forms.Button()
        Me.GBX_1 = New System.Windows.Forms.GroupBox()
        Me.GBX_2 = New System.Windows.Forms.GroupBox()
        Me.GBX_3 = New System.Windows.Forms.GroupBox()
        Me.GBX_4 = New System.Windows.Forms.GroupBox()
        Me.BTN_About = New System.Windows.Forms.Button()
        Me.GBX_1.SuspendLayout()
        Me.GBX_2.SuspendLayout()
        Me.GBX_3.SuspendLayout()
        Me.GBX_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Players
        '
        Me.BTN_Players.Location = New System.Drawing.Point(92, 19)
        Me.BTN_Players.Name = "BTN_Players"
        Me.BTN_Players.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Players.TabIndex = 0
        Me.BTN_Players.Text = "Players"
        Me.BTN_Players.UseVisualStyleBackColor = True
        '
        'BTN_Battle
        '
        Me.BTN_Battle.Location = New System.Drawing.Point(92, 19)
        Me.BTN_Battle.Name = "BTN_Battle"
        Me.BTN_Battle.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Battle.TabIndex = 1
        Me.BTN_Battle.Text = "Battles"
        Me.BTN_Battle.UseVisualStyleBackColor = True
        '
        'BTN_Items
        '
        Me.BTN_Items.Location = New System.Drawing.Point(18, 19)
        Me.BTN_Items.Name = "BTN_Items"
        Me.BTN_Items.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Items.TabIndex = 2
        Me.BTN_Items.Text = "Items"
        Me.BTN_Items.UseVisualStyleBackColor = True
        '
        'BTN_Spells
        '
        Me.BTN_Spells.Location = New System.Drawing.Point(165, 19)
        Me.BTN_Spells.Name = "BTN_Spells"
        Me.BTN_Spells.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Spells.TabIndex = 4
        Me.BTN_Spells.Text = "Spells"
        Me.BTN_Spells.UseVisualStyleBackColor = True
        '
        'BTN_Races
        '
        Me.BTN_Races.Location = New System.Drawing.Point(18, 19)
        Me.BTN_Races.Name = "BTN_Races"
        Me.BTN_Races.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Races.TabIndex = 5
        Me.BTN_Races.Text = "Races"
        Me.BTN_Races.UseVisualStyleBackColor = True
        '
        'BTN_Classes
        '
        Me.BTN_Classes.Location = New System.Drawing.Point(165, 19)
        Me.BTN_Classes.Name = "BTN_Classes"
        Me.BTN_Classes.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Classes.TabIndex = 6
        Me.BTN_Classes.Text = "Classes"
        Me.BTN_Classes.UseVisualStyleBackColor = True
        '
        'GBX_1
        '
        Me.GBX_1.Controls.Add(Me.BTN_Races)
        Me.GBX_1.Controls.Add(Me.BTN_Classes)
        Me.GBX_1.Location = New System.Drawing.Point(13, 13)
        Me.GBX_1.Name = "GBX_1"
        Me.GBX_1.Size = New System.Drawing.Size(261, 55)
        Me.GBX_1.TabIndex = 7
        Me.GBX_1.TabStop = False
        Me.GBX_1.Text = "Step 1"
        '
        'GBX_2
        '
        Me.GBX_2.Controls.Add(Me.BTN_Players)
        Me.GBX_2.Location = New System.Drawing.Point(13, 74)
        Me.GBX_2.Name = "GBX_2"
        Me.GBX_2.Size = New System.Drawing.Size(261, 55)
        Me.GBX_2.TabIndex = 8
        Me.GBX_2.TabStop = False
        Me.GBX_2.Text = "Step 2"
        '
        'GBX_3
        '
        Me.GBX_3.Controls.Add(Me.BTN_Items)
        Me.GBX_3.Controls.Add(Me.BTN_Spells)
        Me.GBX_3.Location = New System.Drawing.Point(13, 135)
        Me.GBX_3.Name = "GBX_3"
        Me.GBX_3.Size = New System.Drawing.Size(261, 55)
        Me.GBX_3.TabIndex = 9
        Me.GBX_3.TabStop = False
        Me.GBX_3.Text = "Step 3"
        '
        'GBX_4
        '
        Me.GBX_4.Controls.Add(Me.BTN_Battle)
        Me.GBX_4.Location = New System.Drawing.Point(13, 196)
        Me.GBX_4.Name = "GBX_4"
        Me.GBX_4.Size = New System.Drawing.Size(261, 55)
        Me.GBX_4.TabIndex = 10
        Me.GBX_4.TabStop = False
        Me.GBX_4.Text = "Step 4"
        '
        'BTN_About
        '
        Me.BTN_About.Location = New System.Drawing.Point(199, 257)
        Me.BTN_About.Name = "BTN_About"
        Me.BTN_About.Size = New System.Drawing.Size(75, 23)
        Me.BTN_About.TabIndex = 11
        Me.BTN_About.Text = "About"
        Me.BTN_About.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 287)
        Me.Controls.Add(Me.BTN_About)
        Me.Controls.Add(Me.GBX_4)
        Me.Controls.Add(Me.GBX_3)
        Me.Controls.Add(Me.GBX_2)
        Me.Controls.Add(Me.GBX_1)
        Me.Name = "Main"
        Me.Text = "MediCalc"
        Me.GBX_1.ResumeLayout(False)
        Me.GBX_2.ResumeLayout(False)
        Me.GBX_3.ResumeLayout(False)
        Me.GBX_4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_Players As System.Windows.Forms.Button
    Friend WithEvents BTN_Battle As System.Windows.Forms.Button
    Friend WithEvents BTN_Items As System.Windows.Forms.Button
    Friend WithEvents BTN_Spells As System.Windows.Forms.Button
    Friend WithEvents BTN_Races As System.Windows.Forms.Button
    Friend WithEvents BTN_Classes As System.Windows.Forms.Button
    Friend WithEvents GBX_1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBX_2 As System.Windows.Forms.GroupBox
    Friend WithEvents GBX_3 As System.Windows.Forms.GroupBox
    Friend WithEvents GBX_4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_About As System.Windows.Forms.Button

End Class
