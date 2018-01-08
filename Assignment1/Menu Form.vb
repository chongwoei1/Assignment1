Public Class frmLMS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLSP.Click
        FrmStaff.Show()
    End Sub

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        FrmStudent.Show()
    End Sub

    Private Sub btnLP_Click(sender As Object, e As EventArgs) Handles btnLP.Click
        FrmLecturer.Show()
    End Sub

    Private Sub btnBP_Click(sender As Object, e As EventArgs) Handles btnBP.Click
        FrmBook.Show()
    End Sub

    Private Sub btnBRP_Click(sender As Object, e As EventArgs) Handles btnBRP.Click
        frmBookRental.Show()
    End Sub

    Private Sub btnBReP_Click(sender As Object, e As EventArgs) Handles btnBReP.Click
        frmBookReturn.Show()
    End Sub

    Private Sub btnLSF_Click(sender As Object, e As EventArgs) Handles btnLSF.Click
        FrmAllStaff.Show()
    End Sub

    Private Sub btnSF_Click(sender As Object, e As EventArgs) Handles btnSF.Click
        FrmAllStudent.Show()
    End Sub

    Private Sub btnLF_Click(sender As Object, e As EventArgs) Handles btnLF.Click
        frmAllLecturer.Show()
    End Sub

    Private Sub btnBF_Click(sender As Object, e As EventArgs) Handles btnBF.Click
        frmAllBook.Show()
    End Sub

    Private Sub btnBRF_Click(sender As Object, e As EventArgs) Handles btnBRF.Click
        frmAllBookRental.Show()
    End Sub

    Private Sub btnBReF_Click(sender As Object, e As EventArgs) Handles btnBReF.Click
        frmAllBookReturn.Show()
    End Sub
End Class