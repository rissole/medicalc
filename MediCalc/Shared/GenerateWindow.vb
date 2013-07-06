Public Class GenerateWindow

    Private Sub BTN_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Copy.Click
        Clipboard.SetDataObject(TBX_Output.Text, True)
    End Sub

    Public Shared Function open(ByVal text As String) As GenerateWindow
        Dim w As New GenerateWindow()
        w.TBX_Output.Text = text
        w.Show()
        Return w
    End Function

End Class