<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllBookReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.BookReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_ReturnTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.Book_ReturnTableAdapter()
        Me.BookRentalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookPenaltyDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChargeOfPenaltyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LStaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookRentalIDDataGridViewTextBoxColumn, Me.BookReturnDateDataGridViewTextBoxColumn, Me.BookPenaltyDataGridViewCheckBoxColumn, Me.ChargeOfPenaltyDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.LecturerIDDataGridViewTextBoxColumn, Me.LStaffIDDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookReturnBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(857, 316)
        Me.DataGridView1.TabIndex = 0
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookReturnBindingSource
        '
        Me.BookReturnBindingSource.DataMember = "Book_Return"
        Me.BookReturnBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'Book_ReturnTableAdapter
        '
        Me.Book_ReturnTableAdapter.ClearBeforeFill = True
        '
        'BookRentalIDDataGridViewTextBoxColumn
        '
        Me.BookRentalIDDataGridViewTextBoxColumn.DataPropertyName = "Book Rental ID"
        Me.BookRentalIDDataGridViewTextBoxColumn.HeaderText = "Book Rental ID"
        Me.BookRentalIDDataGridViewTextBoxColumn.Name = "BookRentalIDDataGridViewTextBoxColumn"
        Me.BookRentalIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookReturnDateDataGridViewTextBoxColumn
        '
        Me.BookReturnDateDataGridViewTextBoxColumn.DataPropertyName = "Book Return Date"
        Me.BookReturnDateDataGridViewTextBoxColumn.HeaderText = "Book Return Date"
        Me.BookReturnDateDataGridViewTextBoxColumn.Name = "BookReturnDateDataGridViewTextBoxColumn"
        Me.BookReturnDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookPenaltyDataGridViewCheckBoxColumn
        '
        Me.BookPenaltyDataGridViewCheckBoxColumn.DataPropertyName = "Book Penalty"
        Me.BookPenaltyDataGridViewCheckBoxColumn.HeaderText = "Book Penalty"
        Me.BookPenaltyDataGridViewCheckBoxColumn.Name = "BookPenaltyDataGridViewCheckBoxColumn"
        Me.BookPenaltyDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ChargeOfPenaltyDataGridViewTextBoxColumn
        '
        Me.ChargeOfPenaltyDataGridViewTextBoxColumn.DataPropertyName = "Charge of Penalty"
        Me.ChargeOfPenaltyDataGridViewTextBoxColumn.HeaderText = "Charge of Penalty"
        Me.ChargeOfPenaltyDataGridViewTextBoxColumn.Name = "ChargeOfPenaltyDataGridViewTextBoxColumn"
        Me.ChargeOfPenaltyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LecturerIDDataGridViewTextBoxColumn
        '
        Me.LecturerIDDataGridViewTextBoxColumn.DataPropertyName = "Lecturer ID"
        Me.LecturerIDDataGridViewTextBoxColumn.HeaderText = "Lecturer ID"
        Me.LecturerIDDataGridViewTextBoxColumn.Name = "LecturerIDDataGridViewTextBoxColumn"
        Me.LecturerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LStaffIDDataGridViewTextBoxColumn
        '
        Me.LStaffIDDataGridViewTextBoxColumn.DataPropertyName = "L_Staff ID"
        Me.LStaffIDDataGridViewTextBoxColumn.HeaderText = "L_Staff ID"
        Me.LStaffIDDataGridViewTextBoxColumn.Name = "LStaffIDDataGridViewTextBoxColumn"
        Me.LStaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmAllBookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 340)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmAllBookReturn"
        Me.Text = "All Book Return"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents BookReturnBindingSource As BindingSource
    Friend WithEvents Book_ReturnTableAdapter As Library_Management_SystemDataSet1TableAdapters.Book_ReturnTableAdapter
    Friend WithEvents BookRentalIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookPenaltyDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ChargeOfPenaltyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LStaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
