Public Class CheckButtonSet
    Inherits Control

    Private checkBoxes As List(Of CheckBox)

    Public Sub New()
        checkBoxes = New List(Of CheckBox)
    End Sub

    ''' <summary>
    ''' Adds a new CheckBox to the set.
    ''' </summary>
    ''' <param name="chk">The CheckBox to add</param>
    ''' <remarks></remarks>
    Public Sub Add(ByVal chk As CheckBox)
        checkBoxes.Add(chk)
    End Sub

    ''' <summary>
    ''' Retrieves the currently selected CheckBoxes as a string in the form "(0/1),(0/1)...".
    ''' </summary>
    ''' <returns>The Object value associated with the selected CheckBox.</returns>
    ''' <remarks></remarks>
    Public Function GetSelectedValues() As Object
        Dim ret As String = ""
        For Each chk As CheckBox In checkBoxes
            ret += IIf(chk.Checked, "1,", "0,")
        Next
        Common.RemoveLastChars(ret, 1)
        Return ret
    End Function

    ''' <summary>
    ''' Selects the CheckBoxes in the set as specified by the string.
    ''' </summary>
    ''' <param name="switchSet">A String in the format "(0/1),(0/1)..." indicating which boxes to check.</param>
    ''' <remarks></remarks>
    Public Sub SetSelectedValues(ByVal switchSet As String)
        Dim idx As Integer = 0
        If (switchSet Is Nothing) Then
            For idx = 0 To checkBoxes.Count - 1
                checkBoxes(idx).Checked = False
            Next
            Return
        End If
        Dim bArray As String() = switchSet.Split(",")
        If (bArray.Length <> checkBoxes.Count) Then
            MsgBox("Count mismatch during SetSelectedValues on CheckButtonSet (got " & bArray.Length & ", expected " & checkBoxes.Count & ")")
            Return
        End If
        For Each bOn As String In bArray
            If (bOn = "1") Then
                checkBoxes(idx).Checked = True
            Else
                checkBoxes(idx).Checked = False
            End If
            idx += 1
        Next
    End Sub

    Public Function GetCheckBoxCount() As UInteger
        Return checkBoxes.Count
    End Function

End Class
