Public Class frmIndex
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Hide()
        frmLMS.Show()
    End Sub
End Class