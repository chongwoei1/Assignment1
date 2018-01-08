Imports Assignment1

Public Class FrmLecturer
    Public Property Library_Management_SystemDataSet1 As Library_Management_SystemDataSet1

    Private Sub LecturerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LecturerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LecturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Library_Management_SystemDataSet1)

    End Sub

    Private Sub FrmLecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_Management_SystemDataSet.Lecturer' table. You can move, or remove it, as needed.
        Me.LecturerTableAdapter.Fill(Me.Library_Management_SystemDataSet1.Lecturer)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LecturerBindingSource.Position = LecturerBindingSource.Find("Lecturer ID", txtSearch.Text)
        If txtId.Text <> txtSearch.Text Then
            MessageBox.Show("Record not found.")
        End If
    End Sub
End Class