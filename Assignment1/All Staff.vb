Public Class FrmAllStaff
    Private Sub FrmAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Library_Staff' table. You can move, or remove it, as needed.
        Me.Library_StaffTableAdapter.Fill(Me.Library_Management_SystemDataSet.Library_Staff)

    End Sub
End Class