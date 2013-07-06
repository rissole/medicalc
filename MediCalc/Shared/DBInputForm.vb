Imports System.Data.SQLite

''' <summary>
''' A customisable parent class that provides an easy interface to a table from the SQLite database.
''' </summary>
''' <remarks></remarks>
Public Class DBInputForm
    Inherits System.Windows.Forms.Form

    Private tableName As String = ""
    Private fieldControls As Dictionary(Of String, Control) = New Dictionary(Of String, Control)
    Protected forceClose As Boolean = False

    ''' <summary>
    ''' Sets the name of the table this form uses. Can only be done once.
    ''' </summary>
    ''' <param name="name">The name of the SQLite table the form represents.</param>
    ''' <remarks></remarks>
    Protected Sub SetTableName(ByVal name As String)
        'once only.
        If (tableName = "") Then
            tableName = name
        End If
    End Sub

    ''' <summary>
    ''' Associates the specified field name with a control from the form.
    ''' </summary>
    ''' <param name="fieldName">The SQLite field name</param>
    ''' <param name="control">The control that represents this field</param>
    ''' <remarks></remarks>
    Protected Sub AssocField(ByVal fieldName As String, ByRef control As Control)
        fieldControls.Add(fieldName, control)
    End Sub

    ''' <summary>
    ''' Gets an associated control.
    ''' </summary>
    ''' <param name="fieldName">The SQLite field name</param>
    ''' <returns>The field control as specified.</returns>
    ''' <remarks></remarks>
    Protected Function GetAssocControl(ByVal fieldName As String) As Object
        Return fieldControls.Item(fieldName)
    End Function

    ''' <summary>
    ''' Gets an associated control's field.
    ''' </summary>
    ''' <param name="control">The control to look for</param>
    ''' <returns>The field name, or an empty string on error.</returns>
    ''' <remarks></remarks>
    Protected Function GetAssocField(ByVal control As Control) As String
        For Each pair As KeyValuePair(Of String, Control) In fieldControls
            If (pair.Value.Equals(control)) Then
                Return pair.Key
            End If
        Next
        Return ""
    End Function

    ''' <summary>
    ''' Retrieves the arbitrary control's value.
    ''' </summary>
    ''' <param name="fieldCtrl">The control to retrieve the value from</param>
    ''' <returns>The value of the control</returns>
    ''' <remarks></remarks>
    Public Shared Function GetControlValue(ByVal fieldCtrl As Control) As Object
        If (fieldCtrl Is Nothing) Then
            Return Nothing
        ElseIf (Not TryCast(fieldCtrl, TextBox) Is Nothing) Then
            'TBX:
            Return DirectCast(fieldCtrl, TextBox).Text
        ElseIf (Not TryCast(fieldCtrl, NumericUpDown) Is Nothing) Then
            'NUD:
            Return DirectCast(fieldCtrl, NumericUpDown).Value
        ElseIf (Not TryCast(fieldCtrl, RadioButtonSet) Is Nothing) Then
            'RBS:
            Return DirectCast(fieldCtrl, RadioButtonSet).GetSelectedValue()
        ElseIf (Not TryCast(fieldCtrl, ColorFieldControl) Is Nothing) Then
            'CFC:
            Return DirectCast(fieldCtrl, ColorFieldControl).GetColorString()
        ElseIf (Not TryCast(fieldCtrl, ListView) Is Nothing) Then
            'LVW:
            Dim retString As String = ""
            Dim lvw As ListView = DirectCast(fieldCtrl, ListView)
            For i As Integer = 0 To lvw.Items.Count - 1
                retString &= lvw.Items(i).SubItems(1).Text & ","
            Next
            Common.RemoveLastChars(retString, 1)
            Return retString
        ElseIf (Not TryCast(fieldCtrl, SkillsListView) Is Nothing) Then
            'SLV:
            Return DirectCast(fieldCtrl, SkillsListView).GetValues()
        ElseIf (Not TryCast(fieldCtrl, CheckButtonSet) Is Nothing) Then
            'CBS:
            Return DirectCast(fieldCtrl, CheckButtonSet).GetSelectedValues()
        ElseIf (Not TryCast(fieldCtrl, ComboBox) Is Nothing) Then
            'CBX:
            Return IIf(DirectCast(fieldCtrl, ComboBox).SelectedItem Is Nothing, "", DirectCast(fieldCtrl, ComboBox).SelectedItem)
        ElseIf (Not TryCast(fieldCtrl, FlaggedCheckButtonSet) Is Nothing) Then
            'FCS:
            Return DirectCast(fieldCtrl, FlaggedCheckButtonSet).GetSelectedValues()
        ElseIf (Not TryCast(fieldCtrl, MaskedTextBox) Is Nothing) Then
            'MTB:
            Return DirectCast(fieldCtrl, MaskedTextBox).Text
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Sets the arbitary control's value.
    ''' </summary>
    ''' <param name="fieldCtrl">The control whose value to set</param>
    ''' <param name="value">The value to set</param>
    ''' <remarks></remarks>
    Public Shared Sub SetControlValue(ByRef fieldCtrl As Control, ByVal value As Object)
        If (IsDBNull(value)) Then
            Clear(fieldCtrl)
            Return
        ElseIf (fieldCtrl Is Nothing) Then
            Return
        ElseIf (Not TryCast(fieldCtrl, TextBox) Is Nothing) Then
            'TBX:
            DirectCast(fieldCtrl, TextBox).Text = value.ToString()
        ElseIf (Not TryCast(fieldCtrl, NumericUpDown) Is Nothing) Then
            'NUD:
            DirectCast(fieldCtrl, NumericUpDown).Value = CType(value, Integer)
        ElseIf (Not TryCast(fieldCtrl, RadioButtonSet) Is Nothing) Then
            'RBS:
            DirectCast(fieldCtrl, RadioButtonSet).SetSelectedValue(value)
        ElseIf (Not TryCast(fieldCtrl, ColorFieldControl) Is Nothing) Then
            'CFC:
            DirectCast(fieldCtrl, ColorFieldControl).SetColor(value.ToString())
        ElseIf (Not TryCast(fieldCtrl, ListView) Is Nothing) Then
            'LVW:
            Dim lvw As ListView = DirectCast(fieldCtrl, ListView)
            Dim valArray As String() = value.ToString().Split(",")
            If (valArray.Length <> lvw.Items.Count) Then
                MsgBox("Count mismatch during SetControlValue on ListView (got " & valArray.Length & ", expected " & lvw.Items.Count & ")")
                Return
            End If
            For i As Integer = 0 To lvw.Items.Count - 1
                lvw.Items(i).SubItems(1).Text = valArray(i)
            Next
        ElseIf (Not TryCast(fieldCtrl, SkillsListView) Is Nothing) Then
            'SLV:
            DirectCast(fieldCtrl, SkillsListView).SetValues(value.ToString())
        ElseIf (Not TryCast(fieldCtrl, CheckButtonSet) Is Nothing) Then
            'CBS:
            DirectCast(fieldCtrl, CheckButtonSet).SetSelectedValues(value)
        ElseIf (Not TryCast(fieldCtrl, ComboBox) Is Nothing) Then
            'CBX:
            DirectCast(fieldCtrl, ComboBox).SelectedItem = value
            If (value = "") Then
                DirectCast(fieldCtrl, ComboBox).SelectedIndex = -1
            End If
        ElseIf (Not TryCast(fieldCtrl, FlaggedCheckButtonSet) Is Nothing) Then
            'FCS:
            DirectCast(fieldCtrl, FlaggedCheckButtonSet).SetSelectedValues(value)
        ElseIf (Not TryCast(fieldCtrl, MaskedTextBox) Is Nothing) Then
            'MTB:
            DirectCast(fieldCtrl, MaskedTextBox).Text = value.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Returns the default value of the specified control.
    ''' </summary>
    ''' <param name="fieldCtrl">The control</param>
    ''' <remarks></remarks>
    Public Shared Function GetDefaultValue(ByVal fieldCtrl As Control)
        If (fieldCtrl Is Nothing) Then
            Return Nothing
        ElseIf (Not TryCast(fieldCtrl, TextBox) Is Nothing) Then
            'TBX:
            Return ""
        ElseIf (Not TryCast(fieldCtrl, NumericUpDown) Is Nothing) Then
            'NUD:
            Return Math.Max(DirectCast(fieldCtrl, NumericUpDown).Minimum, 0D)
        ElseIf (Not TryCast(fieldCtrl, RadioButtonSet) Is Nothing) Then
            'RBS:
            Return Nothing
        ElseIf (Not TryCast(fieldCtrl, ColorFieldControl) Is Nothing) Then
            'CFC:
            Return "#FFFFFF"
        ElseIf (Not TryCast(fieldCtrl, ListView) Is Nothing Or Not TryCast(fieldCtrl, SkillsListView) Is Nothing) Then
            'LVW, SLV:
            Dim retString As String = ""
            Dim count As Integer
            If (Not TryCast(fieldCtrl, ListView) Is Nothing) Then
                count = DirectCast(fieldCtrl, ListView).Items.Count
            Else
                count = SkillsListView.GetSkillsCount()
            End If
            For i As Integer = 1 To count
                retString &= "0,"
            Next
            Common.RemoveLastChars(retString, 1)
            Return retString
        ElseIf (Not TryCast(fieldCtrl, CheckButtonSet) Is Nothing) Then
            'CBS:
            Dim retString As String = ""
            For i As UInteger = 1 To DirectCast(fieldCtrl, CheckButtonSet).GetCheckBoxCount()
                retString &= "0,"
            Next
            Common.RemoveLastChars(retString, 1)
            Return retString
        ElseIf (Not TryCast(fieldCtrl, ComboBox) Is Nothing) Then
            'CBX:
            Return ""
        ElseIf (Not TryCast(fieldCtrl, FlaggedCheckButtonSet) Is Nothing) Then
            'FCS:
            Return 0
        ElseIf (Not TryCast(fieldCtrl, MaskedTextBox) Is Nothing) Then
            'MTB:
            Return DirectCast(fieldCtrl, MaskedTextBox).Mask
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Clears the control.
    ''' </summary>
    ''' <param name="fieldCtrl">The control to clear</param>
    ''' <remarks></remarks>
    Public Overloads Shared Sub Clear(ByRef fieldCtrl As Control)
        SetControlValue(fieldCtrl, GetDefaultValue(fieldCtrl))
    End Sub

    Protected Sub DBInputForm_Load()
        'populate drop down
        If (Not fieldControls.ContainsKey("!NameList")) Then
            MsgBox("No NameList control found in form '" & tableName & "'", MsgBoxStyle.Exclamation)
            Me.Close()
        ElseIf (TryCast(fieldControls.Item("!NameList"), ComboBox) Is Nothing) Then
            MsgBox("No NameList ComboBox found in form '" & tableName & "'", MsgBoxStyle.Exclamation)
            Me.Close()
        Else
            Dim CBNAMES As ComboBox = CType(fieldControls.Item("!NameList"), ComboBox)
            AddHandler CBNAMES.SelectedIndexChanged, AddressOf DBInputForm_HandleNameListChange
            Dim nameListQ = New SQLiteCommand("SELECT name FROM '" & tableName & "'", Common.sqLiteCon).ExecuteReader()
            While (nameListQ.Read())
                CBNAMES.Items.Add(nameListQ.Item(0))
            End While
            If (CBNAMES.Items.Count > 0) Then
                CBNAMES.SelectedIndex = 0
            End If
            nameListQ.Close()
        End If
        'end populate drop down
    End Sub

    Protected Overridable Sub DBInputForm_HandleNameListChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'populate form
        Dim curName = CType(fieldControls.Item("!NameList"), ComboBox).SelectedItem
        Dim fieldQ = New SQLiteCommand("SELECT * FROM '" & tableName & "' WHERE name = @name", Common.sqLiteCon)
        fieldQ.Parameters.AddWithValue("@name", curName)
        Dim fieldQuery = fieldQ.ExecuteReader()
        fieldQuery.Read()
        For col As Integer = 0 To fieldQuery.FieldCount - 1
            If (Not fieldControls.ContainsKey(fieldQuery.GetName(col))) Then
                MsgBox("Field '" & fieldQuery.GetName(col) & "' not handled in '" & tableName & "' form", MsgBoxStyle.Exclamation)
                Continue For
            End If
            Dim fieldCtrl As Control = fieldControls.Item(fieldQuery.GetName(col))
            SetControlValue(fieldCtrl, fieldQuery.GetValue(col))
        Next
        fieldQuery.Close()
        'end populate form
    End Sub

    Public Sub SaveContent(Optional ByVal silentSuccess As Boolean = False)
        'save current form content to DB.
        'check to ensure the current name is not duplicate
        If (CType(fieldControls.Item("!NameList"), ComboBox).SelectedIndex = -1) Then Return
        If (fieldControls.ContainsKey("name")) Then
            Dim name As String = DirectCast(fieldControls.Item("name"), TextBox).Text
            If (Common.CountOccurancesOf(CType(fieldControls.Item("!NameList"), ComboBox).Items, name) > 1) Then
                MsgBox("Duplicate name entered", MsgBoxStyle.Critical)
                Return
            End If
        End If
        Dim saveQuery = Common.sqLiteCon.CreateCommand()
        saveQuery.CommandText += "UPDATE '" + tableName + "' SET "
        Dim pair As KeyValuePair(Of String, Control)
        For Each pair In fieldControls
            If (pair.Key.StartsWith("!") = False And pair.Key <> "id" And Not pair.Value Is Nothing) Then
                saveQuery.CommandText += pair.Key + "=@param_" & pair.Key & ", "
            End If
        Next
        Common.RemoveLastChars(saveQuery.CommandText, 2)
        saveQuery.CommandText += " WHERE id=" & fieldControls.Item("id").Text
        For Each pair In fieldControls
            If (pair.Key.StartsWith("!") = False And pair.Key <> "id" And Not pair.Value Is Nothing) Then
                saveQuery.Parameters.Add(New SQLiteParameter("@param_" & pair.Key, GetControlValue(pair.Value)))
            End If
        Next
        If (saveQuery.ExecuteNonQuery() > 0) Then
            If (Not silentSuccess) Then MsgBox("Save successful", MsgBoxStyle.Information)
            Dim idx = CType(fieldControls.Item("!NameList"), ComboBox).SelectedIndex
            CType(fieldControls.Item("!NameList"), ComboBox).Items(idx) = GetControlValue(fieldControls("name"))
        Else
            MsgBox("Unknown error occured", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Overloads Sub Clear()
        Dim pair As KeyValuePair(Of String, Control)
        For Each pair In fieldControls
            If (pair.Key.StartsWith("!") = False) Then
                Clear(pair.Value)
            End If
        Next
    End Sub

    Public Sub AddNew()
        Dim newIDQuery = New SQLiteCommand("SELECT MAX(id) FROM '" & tableName & "'", Common.sqLiteCon).ExecuteReader()
        Dim newID As Integer = 0
        newIDQuery.Read()
        If (Not newIDQuery.IsDBNull(0)) Then
            newID = newIDQuery.GetInt32(0) + 1
        End If
        newIDQuery.Close()
        Dim uniqueNameQuery = New SQLiteCommand("SELECT COUNT(name) FROM '" & tableName & "' WHERE name LIKE '%Unnamed Object%'", Common.sqLiteCon).ExecuteReader()
        Dim UnnamedCount As Integer = 0
        uniqueNameQuery.Read()
        If (Not uniqueNameQuery.IsDBNull(0)) Then
            UnnamedCount = uniqueNameQuery.GetInt32(0) + 1
        End If
        uniqueNameQuery.Close()
        Dim newName = "Unnamed Object " & UnnamedCount
        Dim insertQuery = Common.sqLiteCon.CreateCommand()
        insertQuery.CommandText = "INSERT INTO '" & tableName & "' (id, name) VALUES ('" & newID & "', '" & newName & "', "
        Dim colNameInsertion As Integer = ("INSERT INTO '" & tableName & "' (id, name").Length
        Dim pair As KeyValuePair(Of String, Control)
        For Each pair In fieldControls
            If (pair.Key.StartsWith("!") = False And pair.Key <> "id" And pair.Key <> "name") Then
                insertQuery.CommandText = insertQuery.CommandText.Insert(colNameInsertion, ", " & pair.Key)
                colNameInsertion += (", " & pair.Key).Length
                insertQuery.CommandText &= "'" & GetDefaultValue(pair.Value) & "', "
            End If
        Next
        Common.RemoveLastChars(insertQuery.CommandText, 2)
        insertQuery.CommandText += ")"
        insertQuery.ExecuteNonQuery()
        CType(fieldControls.Item("!NameList"), ComboBox).Items.Add(newName)
        CType(fieldControls.Item("!NameList"), ComboBox).SelectedItem = newName
    End Sub

    Public Sub DeleteEntry()
        If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirm deletion") = MsgBoxResult.Yes) Then
            If (Not fieldControls.ContainsKey("id") Or Not fieldControls.ContainsKey("!NameList")) Then
                Return
            End If
            Dim deleteQuery = New SQLiteCommand("DELETE FROM '" & tableName & "' WHERE id=" & fieldControls.Item("id").Text, Common.sqLiteCon)
            deleteQuery.ExecuteNonQuery()
            CType(fieldControls.Item("!NameList"), ComboBox).Items.RemoveAt(CType(fieldControls.Item("!NameList"), ComboBox).SelectedIndex)
            Clear()
        End If
    End Sub
End Class
