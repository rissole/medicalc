Public Class ColorFieldControl
    Inherits System.Windows.Forms.Control

    Private mInnerText As TextBox

    Public Sub New(ByRef TBX As TextBox)
        mInnerText = TBX
    End Sub

    Public Overloads Sub SetColor(ByVal htmlColor As String)
        SetColor(ColorTranslator.FromHtml(htmlColor))
    End Sub

    Public Overloads Sub SetColor(ByVal col As Color)
        mInnerText.BackColor = col
        'mInnerText.Text = "#" & col.R.ToString("X2") & col.G.ToString("X2") & col.B.ToString("X2")
        'mInnerText.ForeColor = Color.FromArgb(&HFF - mInnerText.BackColor.R, &HFF - mInnerText.BackColor.G, &HFF - mInnerText.BackColor.B)
    End Sub

    Public Function GetColor() As Color
        Return mInnerText.BackColor
    End Function

    Public Function GetColorString() As String
        Dim col As Color = mInnerText.BackColor
        Return "#" & col.R.ToString("X2") & col.G.ToString("X2") & col.B.ToString("X2")
    End Function

End Class
