Public Class BattlePlayerEditEffects

    Private playerEdit As BattlePlayerEdit

    Public Shared Function open(ByRef p As BattlePlayerEdit) As BattlePlayerEditEffects
        Dim n = New BattlePlayerEditEffects(p)
        n.Show()
        Return n
    End Function

    Private Sub New(ByRef p As BattlePlayerEdit)
        ' This call is required by the designer.
        InitializeComponent()

        playerEdit = p

        For Each e As BattleEffect In playerEdit.GetPlayer().Effects
            LBX_Effects.Items.Add(e.GetName())
        Next

    End Sub

    Private Sub BTN_Remove_Click(ByVal sender As System.Object, ByVal _e As System.EventArgs) Handles BTN_Remove.Click
        If (LBX_Effects.SelectedIndex <> -1) Then
            Dim e As BattleEffect = playerEdit.GetPlayer().Effects(LBX_Effects.SelectedIndex)
            e.Remove()
            playerEdit.GetPlayer().Save()
            playerEdit.ReloadData()
            LBX_Effects.Items.Clear()

            For Each e2 As BattleEffect In playerEdit.GetPlayer().Effects
                LBX_Effects.Items.Add(e2.GetName())
            Next
        End If
    End Sub

    Private Sub BTN_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Close.Click
        Me.Close()
    End Sub

    Private Sub BattlePlayerEditEffects_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        playerEdit.effectEdit = Nothing
    End Sub
End Class