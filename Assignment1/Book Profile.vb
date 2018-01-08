Imports Assignment1

Public Class frmBook
    Public Property Library_Management_SystemDataSet1 As Library_Management_SystemDataSet1

    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Library_Management_SystemDataSet1)

    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BookBindingSource.Position = BookBindingSource.Find("Book ID", txtSearch.Text)
        If txtId.Text <> txtSearch.Text Then
            MessageBox.Show("Record not found.")
        End If
    End Sub
End Class