Public Class frmBookRental
    Private Sub Book_RentalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Book_RentalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Book_RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Library_Management_SystemDataSet1)

    End Sub

    Private Sub frmBookRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book_Rental' table. You can move, or remove it, as needed.
        Me.Book_RentalTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book_Rental)

    End Sub

    Private Function Library_Management_SystemDataSet1() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        Book_RentalBindingSource.Position = Book_RentalBindingSource.Find("Book Rental ID", txtSearch.Text)
        If txtId.Text <> txtSearch.Text Then
            MessageBox.Show("Record not found.")
        End If
    End Sub
End Class