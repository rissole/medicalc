<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battle
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
        Me.components = New System.ComponentModel.Container()
        Me.GBX_TeamB = New System.Windows.Forms.GroupBox()
        Me.BTN_B_AddNPC = New System.Windows.Forms.Button()
        Me.BTN_B_AddPlayer = New System.Windows.Forms.Button()
        Me.MouseOverTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_Log = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.BTN_TurnEnd = New System.Windows.Forms.Button()
        Me.GBX_TeamA = New System.Windows.Forms.GroupBox()
        Me.BTN_A_AddNPC = New System.Windows.Forms.Button()
        Me.BTN_A_AddPlayer = New System.Windows.Forms.Button()
        Me.GBX_TeamB.SuspendLayout()
        Me.GBX_TeamA.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBX_TeamB
        '
        Me.GBX_TeamB.Controls.Add(Me.BTN_B_AddNPC)
        Me.GBX_TeamB.Controls.Add(Me.BTN_B_AddPlayer)
        Me.GBX_TeamB.Location = New System.Drawing.Point(265, 12)
        Me.GBX_TeamB.Name = "GBX_TeamB"
        Me.GBX_TeamB.Size = New System.Drawing.Size(220, 610)
        Me.GBX_TeamB.TabIndex = 2
        Me.GBX_TeamB.TabStop = False
        Me.GBX_TeamB.Text = "Team B"
        '
        'BTN_B_AddNPC
        '
        Me.BTN_B_AddNPC.Location = New System.Drawing.Point(117, 19)
        Me.BTN_B_AddNPC.Name = "BTN_B_AddNPC"
        Me.BTN_B_AddNPC.Size = New System.Drawing.Size(75, 23)
        Me.BTN_B_AddNPC.TabIndex = 1
        Me.BTN_B_AddNPC.Text = "Add NPC"
        Me.BTN_B_AddNPC.UseVisualStyleBackColor = True
        '
        'BTN_B_AddPlayer
        '
        Me.BTN_B_AddPlayer.Location = New System.Drawing.Point(27, 19)
        Me.BTN_B_AddPlayer.Name = "BTN_B_AddPlayer"
        Me.BTN_B_AddPlayer.Size = New System.Drawing.Size(75, 23)
        Me.BTN_B_AddPlayer.TabIndex = 0
        Me.BTN_B_AddPlayer.Text = "Add Player"
        Me.BTN_B_AddPlayer.UseVisualStyleBackColor = True
        '
        'BTN_Log
        '
        Me.BTN_Log.Location = New System.Drawing.Point(12, 628)
        Me.BTN_Log.Name = "BTN_Log"
        Me.BTN_Log.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Log.TabIndex = 4
        Me.BTN_Log.Text = "Toggle Log"
        Me.BTN_Log.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(265, 628)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(89, 23)
        Me.BTN_Close.TabIndex = 5
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'BTN_TurnEnd
        '
        Me.BTN_TurnEnd.Location = New System.Drawing.Point(360, 628)
        Me.BTN_TurnEnd.Name = "BTN_TurnEnd"
        Me.BTN_TurnEnd.Size = New System.Drawing.Size(125, 46)
        Me.BTN_TurnEnd.TabIndex = 6
        Me.BTN_TurnEnd.Text = "Next turn and Generate Post"
        Me.BTN_TurnEnd.UseVisualStyleBackColor = True
        '
        'GBX_TeamA
        '
        Me.GBX_TeamA.Controls.Add(Me.BTN_A_AddNPC)
        Me.GBX_TeamA.Controls.Add(Me.BTN_A_AddPlayer)
        Me.GBX_TeamA.Location = New System.Drawing.Point(12, 12)
        Me.GBX_TeamA.Name = "GBX_TeamA"
        Me.GBX_TeamA.Size = New System.Drawing.Size(220, 610)
        Me.GBX_TeamA.TabIndex = 3
        Me.GBX_TeamA.TabStop = False
        Me.GBX_TeamA.Text = "Team A"
        '
        'BTN_A_AddNPC
        '
        Me.BTN_A_AddNPC.Location = New System.Drawing.Point(117, 19)
        Me.BTN_A_AddNPC.Name = "BTN_A_AddNPC"
        Me.BTN_A_AddNPC.Size = New System.Drawing.Size(75, 23)
        Me.BTN_A_AddNPC.TabIndex = 1
        Me.BTN_A_AddNPC.Text = "Add NPC"
        Me.BTN_A_AddNPC.UseVisualStyleBackColor = True
        '
        'BTN_A_AddPlayer
        '
        Me.BTN_A_AddPlayer.Location = New System.Drawing.Point(27, 19)
        Me.BTN_A_AddPlayer.Name = "BTN_A_AddPlayer"
        Me.BTN_A_AddPlayer.Size = New System.Drawing.Size(75, 23)
        Me.BTN_A_AddPlayer.TabIndex = 0
        Me.BTN_A_AddPlayer.Text = "Add Player"
        Me.BTN_A_AddPlayer.UseVisualStyleBackColor = True
        '
        'Battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 681)
        Me.Controls.Add(Me.GBX_TeamA)
        Me.Controls.Add(Me.BTN_TurnEnd)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.BTN_Log)
        Me.Controls.Add(Me.GBX_TeamB)
        Me.Name = "Battle"
        Me.Text = "Battle"
        Me.GBX_TeamB.ResumeLayout(False)
        Me.GBX_TeamA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBX_TeamB As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_B_AddNPC As System.Windows.Forms.Button
    Friend WithEvents BTN_B_AddPlayer As System.Windows.Forms.Button
    Friend WithEvents MouseOverTip As System.Windows.Forms.ToolTip
    Friend WithEvents BTN_Log As System.Windows.Forms.Button
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents BTN_TurnEnd As System.Windows.Forms.Button
    Friend WithEvents GBX_TeamA As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_A_AddNPC As System.Windows.Forms.Button
    Friend WithEvents BTN_A_AddPlayer As System.Windows.Forms.Button
End Class
