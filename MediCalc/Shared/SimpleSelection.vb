Public Class SimpleSelection

    Delegate Sub SelectionCallBack(ByVal choiceName As String, ByVal choiceValue As AssocComboBox.SelectionInfo)

    Private choiceName As String
    Private callback As SelectionCallBack

    Public Shared Sub open(ByVal name As String, ByVal items() As String, ByVal values() As Object, ByRef cb As SelectionCallBack)
        Dim ss = New SimpleSelection(name, items, values, cb)
        ss.Show()
    End Sub

    Public Sub New(ByVal name As String, ByVal items() As String, ByVal values() As Object, ByRef cb As SelectionCallBack)
        InitializeComponent()

        choiceName = name
        callback = cb
        ACB_List.AddAssocRange(items, values)
        If (items.Length > 0) Then
            ACB_List.SelectedIndex = 0
        End If
    End Sub

    Private Sub BTN_Choose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Choose.Click
        callback(choiceName, ACB_List.GetSelectionInfo())
        Me.Close()
    End Sub
End Class