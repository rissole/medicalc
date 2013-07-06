''' <summary>
''' An associative set of RadioButtons and values.
''' </summary>
''' <remarks></remarks>
Public Class RadioButtonSet
    Inherits Control

    Private radioButtons As Dictionary(Of RadioButton, Object)

    Public Sub New()
        radioButtons = New Dictionary(Of RadioButton, Object)
    End Sub

    ''' <summary>
    ''' Adds a new RadioButton to the set, with an associated value.
    ''' </summary>
    ''' <param name="radiobtn">The RadioButton to add</param>
    ''' <param name="value">The value to associate it with</param>
    ''' <remarks></remarks>
    Public Sub Add(ByVal radiobtn As RadioButton, ByVal value As Object)
        radioButtons.Add(radiobtn, value)
    End Sub

    ''' <summary>
    ''' Retrieves the currently selected RadioButton's value.
    ''' </summary>
    ''' <returns>The Object value associated with the selected RadioButton.</returns>
    ''' <remarks></remarks>
    Public Function GetSelectedValue() As Object
        Dim pair As KeyValuePair(Of RadioButton, Object)
        For Each pair In radioButtons
            If (pair.Key.Checked) Then Return pair.Value
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Retrieves the currently selected RadioButton.
    ''' </summary>
    ''' <returns>The selected RadioButton.</returns>
    ''' <remarks></remarks>
    Public Function GetSelectedRadioButton() As RadioButton
        Dim pair As KeyValuePair(Of RadioButton, Object)
        For Each pair In radioButtons
            If (pair.Key.Checked) Then Return pair.Key
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Selects the RadioButton in the set which has the specified value.
    ''' </summary>
    ''' <param name="newValue">The value of the RadioButton to select.</param>
    ''' <remarks></remarks>
    Public Sub SetSelectedValue(ByVal newValue As Object)
        Dim pair As KeyValuePair(Of RadioButton, Object)
        If (newValue Is Nothing) Then
            For Each pair In radioButtons
                pair.Key.Checked = False
            Next
            Return
        End If
        For Each pair In radioButtons
            If (pair.Value = newValue) Then
                pair.Key.Checked = True
                Return
            End If
        Next
    End Sub

End Class
