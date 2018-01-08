Imports Assignment1

Public Class frmBookReturn
    Public Property Library_Management_SystemDataSet1 As Library_Management_SystemDataSet1

    Private Sub Book_ReturnBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Book_ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Book_ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Library_Management_SystemDataSet1)

    End Sub

    Private Sub frmBookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book_Return' table. You can move, or remove it, as needed.
        Me.Book_ReturnTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book_Return)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Book_ReturnBindingSource.Position = Book_ReturnBindingSource.Find("Book Rental ID", txtSearch.Text)
        If txtId.Text <> txtSearch.Text Then
            MessageBox.Show("Record not found.")
        End If
    End Sub
End Class