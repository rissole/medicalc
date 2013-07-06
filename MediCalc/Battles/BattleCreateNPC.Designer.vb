<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleCreateNPC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBX_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBX_Level = New System.Windows.Forms.TextBox()
        Me.BTN_Done = New System.Windows.Forms.Button()
        Me.BTN_Load = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBX_HPCur = New System.Windows.Forms.TextBox()
        Me.MouseOverTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.TBX_HP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_DeleteFromBattle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'TBX_Name
        '
        Me.TBX_Name.Location = New System.Drawing.Point(54, 38)
        Me.TBX_Name.Name = "TBX_Name"
        Me.TBX_Name.Size = New System.Drawing.Size(134, 20)
        Me.TBX_Name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Level"
        '
        'TBX_Level
        '
        Me.TBX_Level.Location = New System.Drawing.Point(242, 38)
        Me.TBX_Level.Name = "TBX_Level"
        Me.TBX_Level.Size = New System.Drawing.Size(36, 20)
        Me.TBX_Level.TabIndex = 2
        '
        'BTN_Done
        '
        Me.BTN_Done.Location = New System.Drawing.Point(228, 96)
        Me.BTN_Done.Name = "BTN_Done"
        Me.BTN_Done.Size = New System.Drawing.Size(50, 23)
        Me.BTN_Done.TabIndex = 8
        Me.BTN_Done.Text = "Done"
        Me.BTN_Done.UseVisualStyleBackColor = True
        '
        'BTN_Load
        '
        Me.BTN_Load.Location = New System.Drawing.Point(68, 96)
        Me.BTN_Load.Name = "BTN_Load"
        Me.BTN_Load.Size = New System.Drawing.Size(50, 23)
        Me.BTN_Load.TabIndex = 6
        Me.BTN_Load.Text = "Load..."
        Me.MouseOverTip.SetToolTip(Me.BTN_Load, "Load a previously saved NPC")
        Me.BTN_Load.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(12, 96)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(50, 23)
        Me.BTN_Save.TabIndex = 5
        Me.BTN_Save.Text = "Save"
        Me.MouseOverTip.SetToolTip(Me.BTN_Save, "Save this NPC for later use")
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "HP"
        '
        'TBX_HPCur
        '
        Me.TBX_HPCur.Location = New System.Drawing.Point(54, 67)
        Me.TBX_HPCur.Name = "TBX_HPCur"
        Me.TBX_HPCur.Size = New System.Drawing.Size(36, 20)
        Me.TBX_HPCur.TabIndex = 3
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(124, 96)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(64, 23)
        Me.BTN_Delete.TabIndex = 7
        Me.BTN_Delete.Text = "Delete..."
        Me.MouseOverTip.SetToolTip(Me.BTN_Delete, "Load a previously saved NPC")
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'TBX_HP
        '
        Me.TBX_HP.Location = New System.Drawing.Point(108, 67)
        Me.TBX_HP.Name = "TBX_HP"
        Me.TBX_HP.Size = New System.Drawing.Size(36, 20)
        Me.TBX_HP.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "/"
        '
        'BTN_DeleteFromBattle
        '
        Me.BTN_DeleteFromBattle.Location = New System.Drawing.Point(167, 8)
        Me.BTN_DeleteFromBattle.Name = "BTN_DeleteFromBattle"
        Me.BTN_DeleteFromBattle.Size = New System.Drawing.Size(111, 23)
        Me.BTN_DeleteFromBattle.TabIndex = 12
        Me.BTN_DeleteFromBattle.Text = "Remove from battle"
        Me.BTN_DeleteFromBattle.UseVisualStyleBackColor = True
        '
        'BattleCreateNPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 131)
        Me.Controls.Add(Me.BTN_DeleteFromBattle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBX_HP)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.TBX_HPCur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.BTN_Load)
        Me.Controls.Add(Me.BTN_Done)
        Me.Controls.Add(Me.TBX_Level)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBX_Name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BattleCreateNPC"
        Me.Text = "Create new NPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBX_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBX_Level As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Done As System.Windows.Forms.Button
    Friend WithEvents BTN_Load As System.Windows.Forms.Button
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBX_HPCur As System.Windows.Forms.TextBox
    Friend WithEvents MouseOverTip As System.Windows.Forms.ToolTip
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents TBX_HP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_DeleteFromBattle As System.Windows.Forms.Button
End Class
