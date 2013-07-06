<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.GBX_Item = New System.Windows.Forms.GroupBox()
        Me.MTB_AddAmt = New System.Windows.Forms.MaskedTextBox()
        Me.BTN_Add = New System.Windows.Forms.Button()
        Me.BTN_AddEquip = New System.Windows.Forms.Button()
        Me.TBX_ItemString = New System.Windows.Forms.TextBox()
        Me.CBX_Items = New System.Windows.Forms.ComboBox()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBX_EquippedItems = New System.Windows.Forms.GroupBox()
        Me.TBX_Ammo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBX_Ranged = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TBX_LeftArm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBX_RightArm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBX_Chest = New System.Windows.Forms.TextBox()
        Me.TBX_Head = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBX_Feet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBX_Neck = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBX_Back = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBX_Legs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBX_Shoulders = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBX_Wrists = New System.Windows.Forms.TextBox()
        Me.TBX_Waist = New System.Windows.Forms.TextBox()
        Me.TBX_Finger3 = New System.Windows.Forms.TextBox()
        Me.TBX_Hands = New System.Windows.Forms.TextBox()
        Me.TBX_Finger2 = New System.Windows.Forms.TextBox()
        Me.TBX_Finger1 = New System.Windows.Forms.TextBox()
        Me.TBX_Finger4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LBX_Inventory = New System.Windows.Forms.ListBox()
        Me.CMS_InventoryOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBL_TotalSlots = New System.Windows.Forms.Label()
        Me.BTN_Items = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GBX_Item.SuspendLayout()
        Me.GBX_EquippedItems.SuspendLayout()
        Me.CMS_InventoryOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBX_Item
        '
        Me.GBX_Item.Controls.Add(Me.MTB_AddAmt)
        Me.GBX_Item.Controls.Add(Me.BTN_Add)
        Me.GBX_Item.Controls.Add(Me.BTN_AddEquip)
        Me.GBX_Item.Controls.Add(Me.TBX_ItemString)
        Me.GBX_Item.Controls.Add(Me.CBX_Items)
        Me.GBX_Item.Location = New System.Drawing.Point(12, 41)
        Me.GBX_Item.Name = "GBX_Item"
        Me.GBX_Item.Size = New System.Drawing.Size(215, 132)
        Me.GBX_Item.TabIndex = 0
        Me.GBX_Item.TabStop = False
        Me.GBX_Item.Text = "Item"
        '
        'MTB_AddAmt
        '
        Me.MTB_AddAmt.Location = New System.Drawing.Point(8, 104)
        Me.MTB_AddAmt.Mask = "0999"
        Me.MTB_AddAmt.Name = "MTB_AddAmt"
        Me.MTB_AddAmt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MTB_AddAmt.Size = New System.Drawing.Size(33, 20)
        Me.MTB_AddAmt.TabIndex = 4
        Me.MTB_AddAmt.Text = "1"
        '
        'BTN_Add
        '
        Me.BTN_Add.Location = New System.Drawing.Point(46, 102)
        Me.BTN_Add.Name = "BTN_Add"
        Me.BTN_Add.Size = New System.Drawing.Size(37, 23)
        Me.BTN_Add.TabIndex = 3
        Me.BTN_Add.Text = "Add"
        Me.BTN_Add.UseVisualStyleBackColor = True
        '
        'BTN_AddEquip
        '
        Me.BTN_AddEquip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddEquip.Location = New System.Drawing.Point(116, 102)
        Me.BTN_AddEquip.Name = "BTN_AddEquip"
        Me.BTN_AddEquip.Size = New System.Drawing.Size(93, 23)
        Me.BTN_AddEquip.TabIndex = 2
        Me.BTN_AddEquip.Text = "Add + Equip"
        Me.BTN_AddEquip.UseVisualStyleBackColor = True
        '
        'TBX_ItemString
        '
        Me.TBX_ItemString.Location = New System.Drawing.Point(7, 48)
        Me.TBX_ItemString.Multiline = True
        Me.TBX_ItemString.Name = "TBX_ItemString"
        Me.TBX_ItemString.ReadOnly = True
        Me.TBX_ItemString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBX_ItemString.Size = New System.Drawing.Size(202, 51)
        Me.TBX_ItemString.TabIndex = 1
        '
        'CBX_Items
        '
        Me.CBX_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Items.FormattingEnabled = True
        Me.CBX_Items.Location = New System.Drawing.Point(46, 19)
        Me.CBX_Items.Name = "CBX_Items"
        Me.CBX_Items.Size = New System.Drawing.Size(121, 21)
        Me.CBX_Items.Sorted = True
        Me.CBX_Items.TabIndex = 0
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(440, 12)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 19
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Close
        '
        Me.BTN_Close.Location = New System.Drawing.Point(440, 467)
        Me.BTN_Close.Name = "BTN_Close"
        Me.BTN_Close.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Close.TabIndex = 22
        Me.BTN_Close.Text = "Close"
        Me.BTN_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Head"
        '
        'GBX_EquippedItems
        '
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Ammo)
        Me.GBX_EquippedItems.Controls.Add(Me.Label12)
        Me.GBX_EquippedItems.Controls.Add(Me.Label13)
        Me.GBX_EquippedItems.Controls.Add(Me.Label14)
        Me.GBX_EquippedItems.Controls.Add(Me.Label15)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Ranged)
        Me.GBX_EquippedItems.Controls.Add(Me.Label16)
        Me.GBX_EquippedItems.Controls.Add(Me.Label17)
        Me.GBX_EquippedItems.Controls.Add(Me.Label18)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_LeftArm)
        Me.GBX_EquippedItems.Controls.Add(Me.Label10)
        Me.GBX_EquippedItems.Controls.Add(Me.Label11)
        Me.GBX_EquippedItems.Controls.Add(Me.Label9)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_RightArm)
        Me.GBX_EquippedItems.Controls.Add(Me.Label8)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Chest)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Head)
        Me.GBX_EquippedItems.Controls.Add(Me.Label7)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Feet)
        Me.GBX_EquippedItems.Controls.Add(Me.Label6)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Neck)
        Me.GBX_EquippedItems.Controls.Add(Me.Label5)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Back)
        Me.GBX_EquippedItems.Controls.Add(Me.Label4)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Legs)
        Me.GBX_EquippedItems.Controls.Add(Me.Label3)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Shoulders)
        Me.GBX_EquippedItems.Controls.Add(Me.Label2)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Wrists)
        Me.GBX_EquippedItems.Controls.Add(Me.Label1)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Waist)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Finger3)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Hands)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Finger2)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Finger1)
        Me.GBX_EquippedItems.Controls.Add(Me.TBX_Finger4)
        Me.GBX_EquippedItems.Location = New System.Drawing.Point(233, 41)
        Me.GBX_EquippedItems.Name = "GBX_EquippedItems"
        Me.GBX_EquippedItems.Size = New System.Drawing.Size(282, 256)
        Me.GBX_EquippedItems.TabIndex = 25
        Me.GBX_EquippedItems.TabStop = False
        Me.GBX_EquippedItems.Text = "Equipped items"
        '
        'TBX_Ammo
        '
        Me.TBX_Ammo.Location = New System.Drawing.Point(197, 176)
        Me.TBX_Ammo.Name = "TBX_Ammo"
        Me.TBX_Ammo.ReadOnly = True
        Me.TBX_Ammo.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Ammo.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(146, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Ammo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Ranged"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(146, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Left Arm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Right Arm"
        '
        'TBX_Ranged
        '
        Me.TBX_Ranged.Location = New System.Drawing.Point(66, 176)
        Me.TBX_Ranged.Name = "TBX_Ranged"
        Me.TBX_Ranged.ReadOnly = True
        Me.TBX_Ranged.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Ranged.TabIndex = 57
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(146, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Feet"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Legs"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(146, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Waist"
        '
        'TBX_LeftArm
        '
        Me.TBX_LeftArm.Location = New System.Drawing.Point(197, 151)
        Me.TBX_LeftArm.Name = "TBX_LeftArm"
        Me.TBX_LeftArm.ReadOnly = True
        Me.TBX_LeftArm.Size = New System.Drawing.Size(73, 20)
        Me.TBX_LeftArm.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(146, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Finger 4"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Finger 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Finger 2"
        '
        'TBX_RightArm
        '
        Me.TBX_RightArm.Location = New System.Drawing.Point(66, 151)
        Me.TBX_RightArm.Name = "TBX_RightArm"
        Me.TBX_RightArm.ReadOnly = True
        Me.TBX_RightArm.Size = New System.Drawing.Size(74, 20)
        Me.TBX_RightArm.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Finger 1"
        '
        'TBX_Chest
        '
        Me.TBX_Chest.Location = New System.Drawing.Point(66, 77)
        Me.TBX_Chest.Name = "TBX_Chest"
        Me.TBX_Chest.ReadOnly = True
        Me.TBX_Chest.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Chest.TabIndex = 31
        '
        'TBX_Head
        '
        Me.TBX_Head.Location = New System.Drawing.Point(66, 26)
        Me.TBX_Head.Name = "TBX_Head"
        Me.TBX_Head.ReadOnly = True
        Me.TBX_Head.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Head.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Hands"
        '
        'TBX_Feet
        '
        Me.TBX_Feet.Location = New System.Drawing.Point(197, 101)
        Me.TBX_Feet.Name = "TBX_Feet"
        Me.TBX_Feet.ReadOnly = True
        Me.TBX_Feet.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Feet.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Wrists"
        '
        'TBX_Neck
        '
        Me.TBX_Neck.Location = New System.Drawing.Point(197, 26)
        Me.TBX_Neck.Name = "TBX_Neck"
        Me.TBX_Neck.ReadOnly = True
        Me.TBX_Neck.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Neck.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Shoulders"
        '
        'TBX_Back
        '
        Me.TBX_Back.Location = New System.Drawing.Point(197, 51)
        Me.TBX_Back.Name = "TBX_Back"
        Me.TBX_Back.ReadOnly = True
        Me.TBX_Back.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Back.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Chest"
        '
        'TBX_Legs
        '
        Me.TBX_Legs.Location = New System.Drawing.Point(66, 102)
        Me.TBX_Legs.Name = "TBX_Legs"
        Me.TBX_Legs.ReadOnly = True
        Me.TBX_Legs.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Legs.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Back"
        '
        'TBX_Shoulders
        '
        Me.TBX_Shoulders.Location = New System.Drawing.Point(66, 51)
        Me.TBX_Shoulders.Name = "TBX_Shoulders"
        Me.TBX_Shoulders.ReadOnly = True
        Me.TBX_Shoulders.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Shoulders.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Neck"
        '
        'TBX_Wrists
        '
        Me.TBX_Wrists.Location = New System.Drawing.Point(66, 126)
        Me.TBX_Wrists.Name = "TBX_Wrists"
        Me.TBX_Wrists.ReadOnly = True
        Me.TBX_Wrists.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Wrists.TabIndex = 35
        '
        'TBX_Waist
        '
        Me.TBX_Waist.Location = New System.Drawing.Point(197, 75)
        Me.TBX_Waist.Name = "TBX_Waist"
        Me.TBX_Waist.ReadOnly = True
        Me.TBX_Waist.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Waist.TabIndex = 47
        '
        'TBX_Finger3
        '
        Me.TBX_Finger3.Location = New System.Drawing.Point(66, 227)
        Me.TBX_Finger3.Name = "TBX_Finger3"
        Me.TBX_Finger3.ReadOnly = True
        Me.TBX_Finger3.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Finger3.TabIndex = 43
        '
        'TBX_Hands
        '
        Me.TBX_Hands.Location = New System.Drawing.Point(197, 126)
        Me.TBX_Hands.Name = "TBX_Hands"
        Me.TBX_Hands.ReadOnly = True
        Me.TBX_Hands.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Hands.TabIndex = 37
        '
        'TBX_Finger2
        '
        Me.TBX_Finger2.Location = New System.Drawing.Point(197, 199)
        Me.TBX_Finger2.Name = "TBX_Finger2"
        Me.TBX_Finger2.ReadOnly = True
        Me.TBX_Finger2.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Finger2.TabIndex = 41
        '
        'TBX_Finger1
        '
        Me.TBX_Finger1.Location = New System.Drawing.Point(66, 201)
        Me.TBX_Finger1.Name = "TBX_Finger1"
        Me.TBX_Finger1.ReadOnly = True
        Me.TBX_Finger1.Size = New System.Drawing.Size(74, 20)
        Me.TBX_Finger1.TabIndex = 39
        '
        'TBX_Finger4
        '
        Me.TBX_Finger4.Location = New System.Drawing.Point(197, 226)
        Me.TBX_Finger4.Name = "TBX_Finger4"
        Me.TBX_Finger4.ReadOnly = True
        Me.TBX_Finger4.Size = New System.Drawing.Size(73, 20)
        Me.TBX_Finger4.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 284)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Inventory items"
        '
        'LBX_Inventory
        '
        Me.LBX_Inventory.ColumnWidth = 165
        Me.LBX_Inventory.ContextMenuStrip = Me.CMS_InventoryOptions
        Me.LBX_Inventory.FormattingEnabled = True
        Me.LBX_Inventory.Location = New System.Drawing.Point(15, 301)
        Me.LBX_Inventory.MultiColumn = True
        Me.LBX_Inventory.Name = "LBX_Inventory"
        Me.LBX_Inventory.Size = New System.Drawing.Size(500, 160)
        Me.LBX_Inventory.TabIndex = 28
        '
        'CMS_InventoryOptions
        '
        Me.CMS_InventoryOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.EquipToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.CMS_InventoryOptions.Name = "CMS_InventoryOptions"
        Me.CMS_InventoryOptions.Size = New System.Drawing.Size(118, 70)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'EquipToolStripMenuItem
        '
        Me.EquipToolStripMenuItem.Name = "EquipToolStripMenuItem"
        Me.EquipToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EquipToolStripMenuItem.Text = "Equip"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'LBL_TotalSlots
        '
        Me.LBL_TotalSlots.AutoSize = True
        Me.LBL_TotalSlots.Location = New System.Drawing.Point(89, 284)
        Me.LBL_TotalSlots.Name = "LBL_TotalSlots"
        Me.LBL_TotalSlots.Size = New System.Drawing.Size(72, 13)
        Me.LBL_TotalSlots.TabIndex = 29
        Me.LBL_TotalSlots.Text = "($$ total slots)"
        '
        'BTN_Items
        '
        Me.BTN_Items.Location = New System.Drawing.Point(15, 11)
        Me.BTN_Items.Name = "BTN_Items"
        Me.BTN_Items.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Items.TabIndex = 30
        Me.BTN_Items.Text = "Edit Items"
        Me.BTN_Items.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(224, 39)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "To unequip an item, double-click on the slot's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text box to the right. You can r" & _
            "ight-click on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inventory items below for more options as well."
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 496)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BTN_Items)
        Me.Controls.Add(Me.LBX_Inventory)
        Me.Controls.Add(Me.LBL_TotalSlots)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GBX_EquippedItems)
        Me.Controls.Add(Me.BTN_Close)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.GBX_Item)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.GBX_Item.ResumeLayout(False)
        Me.GBX_Item.PerformLayout()
        Me.GBX_EquippedItems.ResumeLayout(False)
        Me.GBX_EquippedItems.PerformLayout()
        Me.CMS_InventoryOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBX_Item As System.Windows.Forms.GroupBox
    Friend WithEvents CBX_Items As System.Windows.Forms.ComboBox
    Friend WithEvents TBX_ItemString As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents BTN_Close As System.Windows.Forms.Button
    Friend WithEvents BTN_AddEquip As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBX_EquippedItems As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_Finger2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBX_Finger1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBX_Hands As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBX_Wrists As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBX_Shoulders As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBX_Chest As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBX_Back As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBX_Neck As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBX_Head As System.Windows.Forms.TextBox
    Friend WithEvents TBX_Finger4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TBX_Finger3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TBX_Ammo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBX_Ranged As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TBX_LeftArm As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TBX_RightArm As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TBX_Feet As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TBX_Legs As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TBX_Waist As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BTN_Add As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LBX_Inventory As System.Windows.Forms.ListBox
    Friend WithEvents CMS_InventoryOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EquipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBL_TotalSlots As System.Windows.Forms.Label
    Friend WithEvents MTB_AddAmt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BTN_Items As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
