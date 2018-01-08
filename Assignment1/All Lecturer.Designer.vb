<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllLecturer
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
        Me.LecturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturerTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.LecturerTableAdapter()
        Me.LecturerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerRoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerHpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LecturerIDDataGridViewTextBoxColumn, Me.LecturerNameDataGridViewTextBoxColumn, Me.LecturerRoomDataGridViewTextBoxColumn, Me.LecturerHpDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LecturerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(448, 238)
        Me.DataGridView1.TabIndex = 0
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturerBindingSource
        '
        Me.LecturerBindingSource.DataMember = "Lecturer"
        Me.LecturerBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'LecturerTableAdapter
        '
        Me.LecturerTableAdapter.ClearBeforeFill = True
        '
        'LecturerIDDataGridViewTextBoxColumn
        '
        Me.LecturerIDDataGridViewTextBoxColumn.DataPropertyName = "Lecturer ID"
        Me.LecturerIDDataGridViewTextBoxColumn.HeaderText = "Lecturer ID"
        Me.LecturerIDDataGridViewTextBoxColumn.Name = "LecturerIDDataGridViewTextBoxColumn"
        Me.LecturerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LecturerNameDataGridViewTextBoxColumn
        '
        Me.LecturerNameDataGridViewTextBoxColumn.DataPropertyName = "Lecturer Name"
        Me.LecturerNameDataGridViewTextBoxColumn.HeaderText = "Lecturer Name"
        Me.LecturerNameDataGridViewTextBoxColumn.Name = "LecturerNameDataGridViewTextBoxColumn"
        Me.LecturerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LecturerRoomDataGridViewTextBoxColumn
        '
        Me.LecturerRoomDataGridViewTextBoxColumn.DataPropertyName = "Lecturer Room"
        Me.LecturerRoomDataGridViewTextBoxColumn.HeaderText = "Lecturer Room"
        Me.LecturerRoomDataGridViewTextBoxColumn.Name = "LecturerRoomDataGridViewTextBoxColumn"
        Me.LecturerRoomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LecturerHpDataGridViewTextBoxColumn
        '
        Me.LecturerHpDataGridViewTextBoxColumn.DataPropertyName = "Lecturer Hp"
        Me.LecturerHpDataGridViewTextBoxColumn.HeaderText = "Lecturer Hp"
        Me.LecturerHpDataGridViewTextBoxColumn.Name = "LecturerHpDataGridViewTextBoxColumn"
        Me.LecturerHpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmAllLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmAllLecturer"
        Me.Text = "All Lecturer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents LecturerBindingSource As BindingSource
    Friend WithEvents LecturerTableAdapter As Library_Management_SystemDataSet1TableAdapters.LecturerTableAdapter
    Friend WithEvents LecturerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerRoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerHpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
