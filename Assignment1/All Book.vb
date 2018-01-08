Public Class frmAllBook
    Public Property Library_Management_SystemDataSet1 As Object

    Private Sub frmAllBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book)

    End Sub
End Class