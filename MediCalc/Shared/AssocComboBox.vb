Public Class AssocComboBox
    Inherits ComboBox

    Public Structure SelectionInfo
        Public text As String
        Public value As Object
        Public Sub New(ByVal text As String, ByRef value As Object)
            Me.text = text
            Me.value = value
        End Sub
    End Structure

    Private assocSet As List(Of Object)

    Public Sub New()
        assocSet = New List(Of Object)
    End Sub

    Public Sub AddAssoc(ByVal text As String, ByRef assocValue As Object)
        Items.Add(text)
        assocSet.Add(assocValue)
    End Sub

    Public Sub AddAssocRange(ByVal text() As String, ByRef assocValue() As Object)
        Items.AddRange(text)
        assocSet.AddRange(assocValue)
    End Sub

    Public Sub RemoveAssocAt(ByVal idx As UInteger)
        Items.RemoveAt(idx)
        assocSet.RemoveAt(idx)
    End Sub

    Public Function GetAssocValue() As Object
        If (SelectedIndex <> -1) Then
            Return assocSet(SelectedIndex)
        End If
        Return Nothing
    End Function

    Public Function GetSelectionInfo() As SelectionInfo
        Return (New SelectionInfo(SelectedItem, GetAssocValue()))
    End Function

    Public Sub SetSelectedAssocValue(ByRef assocValue As Object)
        For i As Integer = 0 To assocSet.Count - 1
            Dim o As Object = assocSet(i)
            If (o Is Nothing) Then
                If (assocValue Is Nothing) Then
                    SelectedIndex = i
                    Return
                End If
            ElseIf (o = assocValue) Then
                SelectedIndex = i
                Return
            End If
        Next
    End Sub

End Class
