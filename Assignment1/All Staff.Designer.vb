<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllStaff
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
        Me.LibraryStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Library_StaffTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.Library_StaffTableAdapter()
        Me.LStaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LStaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LStaffAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LStaffHpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LStaffScheduleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LStaffIDDataGridViewTextBoxColumn, Me.LStaffNameDataGridViewTextBoxColumn, Me.LStaffAddressDataGridViewTextBoxColumn, Me.LStaffHpDataGridViewTextBoxColumn, Me.LStaffScheduleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibraryStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(688, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryStaffBindingSource
        '
        Me.LibraryStaffBindingSource.DataMember = "Library_Staff"
        Me.LibraryStaffBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'Library_StaffTableAdapter
        '
        Me.Library_StaffTableAdapter.ClearBeforeFill = True
        '
        'LStaffIDDataGridViewTextBoxColumn
        '
        Me.LStaffIDDataGridViewTextBoxColumn.DataPropertyName = "L_Staff ID"
        Me.LStaffIDDataGridViewTextBoxColumn.HeaderText = "L_Staff ID"
        Me.LStaffIDDataGridViewTextBoxColumn.Name = "LStaffIDDataGridViewTextBoxColumn"
        Me.LStaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LStaffNameDataGridViewTextBoxColumn
        '
        Me.LStaffNameDataGridViewTextBoxColumn.DataPropertyName = "L_Staff Name"
        Me.LStaffNameDataGridViewTextBoxColumn.HeaderText = "L_Staff Name"
        Me.LStaffNameDataGridViewTextBoxColumn.Name = "LStaffNameDataGridViewTextBoxColumn"
        Me.LStaffNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LStaffAddressDataGridViewTextBoxColumn
        '
        Me.LStaffAddressDataGridViewTextBoxColumn.DataPropertyName = "L_Staff Address"
        Me.LStaffAddressDataGridViewTextBoxColumn.HeaderText = "L_Staff Address"
        Me.LStaffAddressDataGridViewTextBoxColumn.Name = "LStaffAddressDataGridViewTextBoxColumn"
        Me.LStaffAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.LStaffAddressDataGridViewTextBoxColumn.Width = 220
        '
        'LStaffHpDataGridViewTextBoxColumn
        '
        Me.LStaffHpDataGridViewTextBoxColumn.DataPropertyName = "L_Staff Hp"
        Me.LStaffHpDataGridViewTextBoxColumn.HeaderText = "L_Staff Hp"
        Me.LStaffHpDataGridViewTextBoxColumn.Name = "LStaffHpDataGridViewTextBoxColumn"
        Me.LStaffHpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LStaffScheduleDataGridViewTextBoxColumn
        '
        Me.LStaffScheduleDataGridViewTextBoxColumn.DataPropertyName = "L_Staff Schedule"
        Me.LStaffScheduleDataGridViewTextBoxColumn.HeaderText = "L_Staff Schedule"
        Me.LStaffScheduleDataGridViewTextBoxColumn.Name = "LStaffScheduleDataGridViewTextBoxColumn"
        Me.LStaffScheduleDataGridViewTextBoxColumn.ReadOnly = True
        Me.LStaffScheduleDataGridViewTextBoxColumn.Width = 120
        '
        'FrmAllStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 235)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmAllStaff"
        Me.Text = "All Library Staff"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents LibraryStaffBindingSource As BindingSource
    Friend WithEvents Library_StaffTableAdapter As Library_Management_SystemDataSet1TableAdapters.Library_StaffTableAdapter
    Friend WithEvents LStaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LStaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LStaffAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LStaffHpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LStaffScheduleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
