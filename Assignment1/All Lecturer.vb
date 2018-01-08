Public Class frmAllLecturer
    Public Property Library_Management_SystemDataSet1 As Object

    Private Sub frmAllLecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Lecturer' table. You can move, or remove it, as needed.
        Me.LecturerTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Lecturer)

    End Sub
End Class