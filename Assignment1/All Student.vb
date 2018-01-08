Public Class FrmAllStudent
    Public Property Library_Management_SystemDataSet1 As Object

    Private Sub All_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Student)

    End Sub
End Class