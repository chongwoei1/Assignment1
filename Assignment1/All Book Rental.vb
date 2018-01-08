Public Class frmAllBookRental
    Public Property Library_Management_SystemDataSet1 As Object

    Private Sub fmrAllBookRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book_Rental' table. You can move, or remove it, as needed.
        Me.Book_RentalTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book_Rental)

    End Sub
End Class