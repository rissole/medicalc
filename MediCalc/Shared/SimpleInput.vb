Public Class SimpleInput

    Private textControl As Object

    Public Shared Sub open(ByRef var As Object, ByVal mask As String)
        Dim _me As SimpleInput = New SimpleInput(var, mask)
        _me.Show()
    End Sub

    Public Sub New(ByRef ctrl As Object, ByVal mask As String)
        InitializeComponent()

        textControl = ctrl
        MTB_Value.Mask = mask
        MTB_Value.Text = IIf(TryCast(textControl.Text, String) Is Nothing, "", textControl.Text)
    End Sub

    Private Sub BTN_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BTN_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_OK.Click
        textControl.Text = MTB_Value.Text
        Me.Close()
    End Sub
End Class