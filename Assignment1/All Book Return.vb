Public Class frmAllBookReturn
    Public Property Library_Management_SystemDataSet1 As Object

    Private Sub frmAllBookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Book_Return' table. You can move, or remove it, as needed.
        Me.Book_ReturnTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Book_Return)

    End Sub
End Class