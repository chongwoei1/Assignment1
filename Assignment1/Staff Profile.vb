Imports Assignment1

Public Class FrmStaff
    Public Property Library_Management_SystemDataSet1 As Library_Management_SystemDataSet1

    Private Sub Library_StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Library_StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Library_StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Library_Management_SystemDataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet1.Library_Staff' table. You can move, or remove it, as needed.
        Me.Library_StaffTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Library_Staff)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Library_StaffBindingSource.Position = Library_StaffBindingSource.Find("L_Staff ID", txtSearch.Text)
        If txtId.Text <> txtSearch.Text Then
            MessageBox.Show("Record not found.")
        End If
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class
