Public Class FlaggedCheckButtonSet
    Inherits Control

    Private checkBoxes As Dictionary(Of CheckBox, UInteger)

    Public Sub New()
        checkBoxes = New Dictionary(Of CheckBox, UInteger)
    End Sub

    ''' <summary>
    ''' Adds a new CheckBox to the set.
    ''' </summary>
    ''' <param name="chk">The CheckBox to add</param>
    ''' <remarks></remarks>
    Public Sub Add(ByVal chk As CheckBox)
        checkBoxes.Add(chk, Math.Pow(2, checkBoxes.Count))
    End Sub

    ''' <summary>
    ''' Retrieves the currently selected CheckBoxes as a bit flag.
    ''' </summary>
    ''' <returns>The Object value associated with the selected CheckBox.</returns>
    ''' <remarks></remarks>
    Public Function GetSelectedValues() As UInteger
        Dim ret As Integer = 0
        For Each chk As KeyValuePair(Of CheckBox, UInteger) In checkBoxes
            ret += IIf(chk.Key.Checked, chk.Value, 0)
        Next
        Return ret
    End Function

    ''' <summary>
    ''' Selects the CheckBoxes in the set as specified by the bit flag.
    ''' </summary>
    ''' <param name="bitFlag">A bit flag specifying which boxes to check.</param>
    ''' <remarks></remarks>
    Public Sub SetSelectedValues(ByVal bitFlag As UInteger)
        For Each chk As KeyValuePair(Of CheckBox, UInteger) In checkBoxes
            If ((bitFlag And chk.Value) > 0) Then
                chk.Key.Checked = True
            Else
                chk.Key.Checked = False
            End If
        Next
    End Sub

    Public Function GetCheckBoxCount() As UInteger
        Return checkBoxes.Count
    End Function

End Class
