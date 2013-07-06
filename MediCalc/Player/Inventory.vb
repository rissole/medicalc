Imports System.Data.SQLite

Public Class Inventory

    Public player_id As UInteger
    Private MaxSlots As UInteger = 20
    Private currentItemID As Integer = -1
    Private MaxInstID As UInteger = 0
    Private internalInventory As Dictionary(Of UInteger, List(Of UInteger)) = New Dictionary(Of UInteger, List(Of UInteger)) ' [bag_slot] = {instance_id, item_id, stack_count}
    Private internalEquip As Dictionary(Of String, UInteger) = New Dictionary(Of String, UInteger) ' ["equip slot"] = instance_id
    Private forceClose As Boolean = False

    Public Sub New(ByVal plID As UInteger)
        ' This call is required by the designer.
        InitializeComponent()

        'set player_id, MaxSlots, MaxInstID
        player_id = plID
        Dim strengthRead = New SQLiteCommand("SELECT stat_str FROM players WHERE id=" & player_id, Common.sqLiteCon).ExecuteReader()
        If (strengthRead.Read()) Then
            MaxSlots += Math.Floor(strengthRead.GetInt32(0) / 5)
        End If
        strengthRead.Close()
        Dim maxQ = New SQLiteCommand("SELECT MAX(instance_id) FROM player_items", Common.sqLiteCon).ExecuteReader()
        maxQ.Read()
        If (Not maxQ.IsDBNull(0)) Then
            MaxInstID = maxQ.GetInt32(0)
        End If
        maxQ.Close()

        'populate internalInventory
        For i As UInteger = 1 To MaxSlots
            internalInventory.Add(i, New List(Of UInteger)(3))
        Next
        Dim iinvComm = New SQLiteCommand("SELECT instance_id, bag_slot, item_id, stack_count FROM player_items WHERE player_id=" & player_id & " ORDER BY bag_slot ASC", Common.sqLiteCon).ExecuteReader()
        While (iinvComm.Read())
            If (iinvComm.GetInt32(1) > MaxSlots) Then
                MsgBox("Item Instance # " & iinvComm.GetInt32(0) & " removed since its bag slot no longer exists", MsgBoxStyle.Critical, "Alert")
            End If
            internalInventory(iinvComm.GetInt32(1)).Add(iinvComm.GetInt32(0))
            internalInventory(iinvComm.GetInt32(1)).Add(iinvComm.GetInt32(2))
            internalInventory(iinvComm.GetInt32(1)).Add(iinvComm.GetInt32(3))
        End While
        iinvComm.Close()

        'populate internalEquip
        Dim ieqComm = New SQLiteCommand("SELECT equip_slot, instance_id FROM player_items WHERE player_id=" & player_id, Common.sqLiteCon).ExecuteReader()
        While (ieqComm.Read())
            If (ieqComm.GetString(0) <> "" And ieqComm.GetString(0) <> "None") Then
                internalEquip.Add(ieqComm.GetString(0), ieqComm.GetInt32(1))
            End If
        End While
        ieqComm.Close()
    End Sub

    ''' <summary>
    ''' Updates item CBX, and updates controls based on internal dictionaries.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshStuff()
        'populate drop down
        Dim sel = CBX_Items.SelectedItem
        CBX_Items.Items.Clear()
        Dim nameListQ = New SQLiteCommand("SELECT name FROM 'items'", Common.sqLiteCon).ExecuteReader()
        While (nameListQ.Read())
            CBX_Items.Items.Add(nameListQ.GetString(0))
        End While
        If (CBX_Items.Items.Count = 0) Then
            nameListQ.Close()
            MsgBox("You must have at least 1 item saved before you can load the Inventory.", MsgBoxStyle.Critical, "Error")
            forceClose = True
            Me.Close()
            Return
        End If
        CBX_Items.SelectedItem = sel
        If (CBX_Items.SelectedIndex = -1) Then
            CBX_Items.SelectedIndex = 0
        End If
        nameListQ.Close()
        UpdateDisplay()
    End Sub

    Private Sub FormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'we'll disable all other forms so this one doesnt get interfered with.
        Main.DisableAll("rci")
        RefreshStuff()
    End Sub

    Private Sub FormClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        If (Not forceClose) Then
            Dim res = MsgBox("Would you like to save before closing?", MsgBoxStyle.YesNoCancel, "Save confirmation")
            If (res = MsgBoxResult.Yes) Then
                SaveContent(True)
            ElseIf (res = MsgBoxResult.Cancel) Then
                e.Cancel = True
                Return
            End If
        End If
        Main.EnableAll()
        If (Not Main.currentPlayersInst Is Nothing) Then
            Main.currentPlayersInst.invWindow = Nothing
        End If
    End Sub

    Private Sub UpdateDisplay()
        'update controls based on internal dictionaries
        LBX_Inventory.Items.Clear()
        For i As Integer = 1 To MaxSlots
            LBX_Inventory.Items.Add("--EMPTY--")
        Next

        'update LBX_Inventory based on internalInventory
        Dim pair As KeyValuePair(Of UInteger, List(Of UInteger))
        For Each pair In internalInventory
            If (pair.Value.Count = 0) Then Continue For
            Dim nameQ = New SQLiteCommand("SELECT name FROM items WHERE id=" & pair.Value(1), Common.sqLiteCon).ExecuteReader()
            Dim name = "UNKNOWN ITEM [" & pair.Value(1) & "]"
            If (nameQ.Read() And Not nameQ.IsDBNull(0)) Then
                name = nameQ.GetString(0)
            End If
            nameQ.Close()
            LBX_Inventory.Items.RemoveAt(pair.Key - 1)
            LBX_Inventory.Items.Insert(pair.Key - 1, IIf(pair.Value(2) > 1, pair.Value(2) & "x ", "") & name)
        Next

        'update equip text boxes based on internalEquip
        For Each ctrl As Control In GBX_EquippedItems.Controls
            Dim tbxCtrl As TextBox = TryCast(ctrl, TextBox)
            If (Not tbxCtrl Is Nothing) Then
                tbxCtrl.Text = ""
            End If
        Next
        Dim pair2 As KeyValuePair(Of String, UInteger)
        Dim errornousEquips = New List(Of String)
        For Each pair2 In internalEquip
            Dim itemID As Integer = -1
            For Each pair In internalInventory
                If (pair.Value.Count = 0) Then Continue For
                If (pair.Value(0) = pair2.Value) Then
                    itemID = pair.Value(1)
                End If
            Next
            Dim name As String = ""
            Dim nameQ = New SQLiteCommand("SELECT name FROM items WHERE id=" & itemID, Common.sqLiteCon).ExecuteReader()
            If (nameQ.Read() And Not nameQ.IsDBNull(0)) Then
                name = nameQ.GetString(0)
            Else
                errornousEquips.Add(pair2.Key)
                Continue For
            End If
            nameQ.Close()
            Dim slot As String = pair2.Key
            Common.GetControlByName(GBX_EquippedItems, "TBX_" & slot).Text = name
        Next
        'remove bad item slots
        For Each Str As String In errornousEquips
            internalEquip.Remove(Str)
        Next
        errornousEquips.Clear()

        'update max slots
        LBL_TotalSlots.Text = "(" & MaxSlots & " total slots)"
    End Sub

    Private Sub CBX_Items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBX_Items.SelectedIndexChanged
        'handle updating currentItemID and TBX_ItemString
        Dim name As String = DirectCast(sender, ComboBox).SelectedItem
        Dim idQ = New SQLiteCommand("SELECT id FROM items WHERE name=@name", Common.sqLiteCon)
        idQ.Parameters.AddWithValue("@name", name)
        Dim idQR = idQ.ExecuteReader()
        If (idQR.Read() And idQR.IsDBNull(0)) Then
            MsgBox("Item no longer exists", MsgBoxStyle.Critical, "Error")
            RefreshStuff()
            Return
        Else
            currentItemID = idQR.GetInt32(0)
            TBX_ItemString.Text = Items.GenerateItemString(currentItemID)
        End If
        idQR.Close()
    End Sub

    Public Shared Function IsStackable(ByVal id As Object) As Integer
        Dim stackQ = New SQLiteCommand("SELECT stackable FROM items WHERE id=@val", Common.sqLiteCon)
        stackQ.Parameters.AddWithValue("@val", id)
        Dim stackR = stackQ.ExecuteReader()
        If (stackR.Read() And Not stackR.IsDBNull(0)) Then
            Dim ret As Integer = stackR.GetInt32(0)
            stackR.Close()
            Return ret
        Else
            stackR.Close()
            MsgBox("Item not found during stackable check", MsgBoxStyle.Critical, "Error")
            Return -1
        End If
    End Function

    ''' <summary>
    ''' Used to find the appropriate bag slot for the specified item, accounting for bag size and stackability.
    ''' </summary>
    ''' <param name="ItemID">The ItemID that will be added (used for searching for stackable slots)</param>
    ''' <returns>The appropriate bagslot, -1 if full or -2 on error.</returns>
    ''' <remarks></remarks>
    Private Function FindTargetSlot(ByVal ItemID As UInteger) As Integer
        'determine if stackable
        Dim stackable As Integer = IsStackable(ItemID)
        If (stackable = -1) Then
            Return -2
        End If

        If (stackable > 0) Then 'prioritise stacking rather than using another slot.
            For i As Integer = 1 To MaxSlots
                If (internalInventory(i).Count > 0) Then
                    If (internalInventory(i)(1) = ItemID) Then
                        Return i
                    End If
                End If
            Next
            For i As Integer = 1 To MaxSlots
                If (internalInventory(i).Count = 0) Then
                    Return i
                End If
            Next
        Else
            For i As Integer = 1 To MaxSlots
                If (internalInventory(i).Count = 0) Then
                    Return i
                End If
            Next
        End If
        Return -1
    End Function

    Private Sub BTN_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Add.Click
        If (CBX_Items.SelectedIndex = -1) Then Return
        'add to inventory - account for stackable, max slots
        'generate new item info
        For c As Integer = 1 To Integer.Parse(MTB_AddAmt.Text)
            Dim slot As Integer = FindTargetSlot(currentItemID)
            If (slot = -2) Then Return
            If (slot = -1) Then
                MsgBox("Inventory full", MsgBoxStyle.Exclamation, "Error")
                UpdateDisplay()
                Return
            End If
            'now slot is an actual slot.
            If (internalInventory(slot).Count > 0) Then 'an item is here -> stackable then
                internalInventory(slot)(2) += 1 '+1 stack count.
            Else 'an empty slot
                'generate new item.
                MaxInstID += 1
                internalInventory(slot).Add(MaxInstID)
                internalInventory(slot).Add(currentItemID)
                internalInventory(slot).Add(1) 'stack count 1
            End If
        Next

        MTB_AddAmt.Text = 1
        UpdateDisplay()
    End Sub

    Private Sub BTN_AddEquip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AddEquip.Click
        If (CBX_Items.SelectedIndex = -1) Then Return
        'same as add to inventory, but equip in the appropriate slot
        'add to inventory - account for stackable, max slots
        'generate new item info
        MTB_AddAmt.Text = 1

        Dim slot As Integer = FindTargetSlot(currentItemID)
        If (slot = -2) Then Return
        If (slot = -1) Then
            MsgBox("Inventory full", MsgBoxStyle.Exclamation, "Error")
            UpdateDisplay()
            Return
        End If
        'now slot is an actual slot.
        If (internalInventory(slot).Count > 0) Then 'an item is here -> stackable then
            internalInventory(slot)(2) += 1 '+1 stack count.
        Else 'an empty slot
            'generate new item.
            MaxInstID += 1
            internalInventory(slot).Add(MaxInstID)
            internalInventory(slot).Add(currentItemID)
            internalInventory(slot).Add(1) 'stack count 1
        End If
        UpdateDisplay()

        'equip selected inventory item - check for already equipped
        Dim selIId As UInteger = internalInventory(slot)(0)
        Dim itemID As UInteger = internalInventory(slot)(1)
        Dim nameQ = New SQLiteCommand("SELECT name, equip_slot FROM items WHERE id=" & itemID, Common.sqLiteCon).ExecuteReader()
        If (Not nameQ.Read()) Then
            nameQ.Close()
            MsgBox("Item no longer exists", MsgBoxStyle.Critical, "Error")
            RefreshStuff()
            Return
        Else
            Dim itemName As String = nameQ.GetString(0)
            Dim s_slot As String = nameQ.GetString(1)
            If (s_slot <> "" And s_slot <> "None") Then
                If (s_slot = "Finger") Then ' we need special treatment for finger... can go in 1,2,3,4
                    If (MsgBox("Would you like to equip this in Finger 1?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger1").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger1")) Then
                            internalEquip.Remove("Finger1")
                        End If
                        internalEquip.Add("Finger1", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 2?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger2").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger2")) Then
                            internalEquip.Remove("Finger2")
                        End If
                        internalEquip.Add("Finger2", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 3?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger3").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger3")) Then
                            internalEquip.Remove("Finger3")
                        End If
                        internalEquip.Add("Finger3", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 4?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger4").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger4")) Then
                            internalEquip.Remove("Finger4")
                        End If
                        internalEquip.Add("Finger4", selIId)
                    End If
                ElseIf (s_slot = "Any Arm") Then
                    If (MsgBox("Would you like to equip this in Right Arm?", MsgBoxStyle.YesNo, "Arm slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_RightArm").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("RightArm")) Then
                            internalEquip.Remove("RightArm")
                        End If
                        internalEquip.Add("RightArm", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Left Arm?", MsgBoxStyle.YesNo, "Arm slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_LeftArm").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("LeftArm")) Then
                            internalEquip.Remove("LeftArm")
                        End If
                        internalEquip.Add("LeftArm", selIId)
                    End If
                Else
                    Dim tbxName As String = s_slot.Replace(" ", "")
                    Common.GetControlByName(GBX_EquippedItems, "TBX_" & tbxName).Text = itemName
                    If (internalEquip.ContainsKey(tbxName)) Then
                        internalEquip.Remove(tbxName)
                    End If
                    internalEquip.Add(tbxName, selIId)
                End If
            Else
                nameQ.Close()
                MsgBox("Item not equipable", MsgBoxStyle.Exclamation, "Error")
                Return
            End If
        End If
        nameQ.Close()
        UpdateDisplay()
    End Sub

    Private Sub SaveContent(Optional ByVal silent As Boolean = False)
        'custom save based on internalInventroy, internalEquip
        'now, put everything in as a new transaction - including a delete
        Dim insertTransaction = New SQLiteCommand(Common.sqLiteCon)
        insertTransaction.CommandText = "BEGIN TRANSACTION;" & vbNewLine
        insertTransaction.CommandText &= "DELETE FROM player_items WHERE player_id=" & player_id & ";" & vbNewLine
        For Each pair As KeyValuePair(Of UInteger, List(Of UInteger)) In internalInventory
            If (pair.Value.Count = 0) Then Continue For 'no item -> skip
            insertTransaction.CommandText &= "INSERT INTO player_items VALUES (@instidK, @plidK, @itmidK, @bslotK, @stackK, @eslotK);".Replace("K", pair.Key) & vbNewLine
            insertTransaction.Parameters.AddWithValue("@instid" & pair.Key, pair.Value(0))
            insertTransaction.Parameters.AddWithValue("@plid" & pair.Key, player_id)
            insertTransaction.Parameters.AddWithValue("@itmid" & pair.Key, pair.Value(1))
            insertTransaction.Parameters.AddWithValue("@bslot" & pair.Key, pair.Key)
            insertTransaction.Parameters.AddWithValue("@stack" & pair.Key, pair.Value(2))
            Dim eslot As String = ""
            For Each pair2 As KeyValuePair(Of String, UInteger) In internalEquip
                If (pair2.Value = pair.Value(0)) Then
                    eslot = pair2.Key
                End If
            Next
            insertTransaction.Parameters.AddWithValue("@eslot" & pair.Key, eslot)
        Next
        insertTransaction.CommandText &= "COMMIT;"
        If (insertTransaction.ExecuteNonQuery() > 0 And Not silent) Then
            MsgBox("Save successful", MsgBoxStyle.Information)
        ElseIf (Not silent) Then
            MsgBox("Unknown error occured", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub SaveBtnPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        SaveContent()
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        SaveContent(True)
        forceClose = True
        Me.Close()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectToolStripMenuItem.Click
        'change currently selected item based on selected inventory item
        If (LBX_Inventory.SelectedItem = "--EMPTY--") Then Return
        CBX_Items.SelectedItem = LBX_Inventory.SelectedItem
    End Sub

    Private Sub EquipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipToolStripMenuItem.Click
        'equip selected inventory item - check for already equipped
        If (LBX_Inventory.SelectedItem = "--EMPTY--") Then Return
        Dim selBagSlot As UInteger = LBX_Inventory.SelectedIndex + 1
        Dim selIId As UInteger = internalInventory(selBagSlot)(0)
        If (internalEquip.ContainsValue(selIId)) Then
            MsgBox("Item already equipped", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim itemID As UInteger = internalInventory(selBagSlot)(1)
        Dim nameQ = New SQLiteCommand("SELECT name, equip_slot FROM items WHERE id=" & itemID, Common.sqLiteCon).ExecuteReader()
        If (Not nameQ.Read()) Then
            nameQ.Close()
            MsgBox("Item no longer exists", MsgBoxStyle.Critical, "Error")
            RefreshStuff()
            Return
        Else
            Dim itemName As String = nameQ.GetString(0)
            Dim slot As String = nameQ.GetString(1)
            If (slot <> "" And slot <> "None") Then
                If (slot = "Finger") Then ' we need special treatment for finger... can go in 1,2,3,4
                    If (MsgBox("Would you like to equip this in Finger 1?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger1").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger1")) Then
                            internalEquip.Remove("Finger1")
                        End If
                        internalEquip.Add("Finger1", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 2?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger2").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger2")) Then
                            internalEquip.Remove("Finger2")
                        End If
                        internalEquip.Add("Finger2", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 3?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger3").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger3")) Then
                            internalEquip.Remove("Finger3")
                        End If
                        internalEquip.Add("Finger3", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Finger 4?", MsgBoxStyle.YesNo, "Finger slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_Finger4").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("Finger4")) Then
                            internalEquip.Remove("Finger4")
                        End If
                        internalEquip.Add("Finger4", selIId)
                    End If
                ElseIf (slot = "Any Arm") Then
                    If (MsgBox("Would you like to equip this in Right Arm?", MsgBoxStyle.YesNo, "Arm slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_RightArm").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("RightArm")) Then
                            internalEquip.Remove("RightArm")
                        End If
                        internalEquip.Add("RightArm", selIId)
                    ElseIf (MsgBox("Would you like to equip this in Left Arm?", MsgBoxStyle.YesNo, "Arm slot choice") = MsgBoxResult.Yes) Then
                        Common.GetControlByName(GBX_EquippedItems, "TBX_LeftArm").Text = LBX_Inventory.SelectedItem
                        If (internalEquip.ContainsKey("LeftArm")) Then
                            internalEquip.Remove("LeftArm")
                        End If
                        internalEquip.Add("LeftArm", selIId)
                    End If
                Else
                    Dim tbxName As String = slot.Replace(" ", "")
                    Common.GetControlByName(GBX_EquippedItems, "TBX_" & tbxName).Text = itemName
                    If (internalEquip.ContainsKey(tbxName)) Then
                        internalEquip.Remove(tbxName)
                    End If
                    internalEquip.Add(tbxName, selIId)
                End If
            Else
                nameQ.Close()
                MsgBox("Item not equipable", MsgBoxStyle.Exclamation, "Error")
                Return
            End If
        End If
        nameQ.Close()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        'remove selected inventory item, unequip if equipped
        If (LBX_Inventory.SelectedItem = "--EMPTY--") Then Return
        Dim selBagSlot As UInteger = LBX_Inventory.SelectedIndex + 1
        Dim selIId As UInteger = internalInventory(selBagSlot)(0)

        'unequip if equipped
        If (internalEquip.ContainsValue(selIId)) Then
            For Each pair As KeyValuePair(Of String, UInteger) In internalEquip
                If (pair.Value = selIId) Then
                    internalEquip.Remove(pair.Key)
                    Exit For
                End If
            Next
        End If

        'remove from inv
        internalInventory(selBagSlot).Clear()

        UpdateDisplay()
    End Sub

    Private Sub CMS_InventoryOptions_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS_InventoryOptions.Opening
        Dim p As Point = Cursor.Position
        p = LBX_Inventory.PointToClient(p)
        Dim idx As Integer = LBX_Inventory.IndexFromPoint(p)
        If (idx = -1) Then
            e.Cancel = True
        End If
        LBX_Inventory.SelectedIndex = idx
    End Sub

    Private Sub BTN_Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Items.Click
        If (Main.currentItemsInst Is Nothing) Then
            Main.currentItemsInst = New Items()
            Main.currentItemsInst.Show()
        End If
    End Sub

    Private Sub UnequipSlot(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        TBX_Ammo.DoubleClick, TBX_Back.DoubleClick, TBX_Chest.DoubleClick, TBX_Feet.DoubleClick, TBX_Finger1.DoubleClick, _
        TBX_Finger2.DoubleClick, TBX_Finger3.DoubleClick, TBX_Finger4.DoubleClick, TBX_Hands.DoubleClick, TBX_Head.DoubleClick, _
        TBX_LeftArm.DoubleClick, TBX_Legs.DoubleClick, TBX_Neck.DoubleClick, TBX_Ranged.DoubleClick, TBX_RightArm.DoubleClick, _
        TBX_Shoulders.DoubleClick, TBX_Waist.DoubleClick, TBX_Wrists.DoubleClick

        Dim key As String = DirectCast(sender, Control).Name.Replace("TBX_", "")
        DirectCast(sender, TextBox).Text = ""
        internalEquip.Remove(key)
    End Sub
End Class