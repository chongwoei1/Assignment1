<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLecturer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLecturer))
        Dim Lecturer_IDLabel As System.Windows.Forms.Label
        Dim Lecturer_NameLabel As System.Windows.Forms.Label
        Dim Lecturer_RoomLabel As System.Windows.Forms.Label
        Dim Lecturer_HpLabel As System.Windows.Forms.Label
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.LecturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturerTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.LecturerTableAdapter()
        Me.TableAdapterManager = New Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.LecturerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LecturerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Lecturer_RoomTextBox = New System.Windows.Forms.TextBox()
        Me.Lecturer_HpTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Lecturer_IDLabel = New System.Windows.Forms.Label()
        Lecturer_NameLabel = New System.Windows.Forms.Label()
        Lecturer_RoomLabel = New System.Windows.Forms.Label()
        Lecturer_HpLabel = New System.Windows.Forms.Label()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LecturerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_RentalTableAdapter = Nothing
        Me.TableAdapterManager.Book_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Me.LecturerTableAdapter
        Me.TableAdapterManager.Library_StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LecturerBindingNavigator
        '
        Me.LecturerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LecturerBindingNavigator.BindingSource = Me.LecturerBindingSource
        Me.LecturerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LecturerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LecturerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LecturerBindingNavigatorSaveItem})
        Me.LecturerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LecturerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LecturerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LecturerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LecturerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LecturerBindingNavigator.Name = "LecturerBindingNavigator"
        Me.LecturerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LecturerBindingNavigator.Size = New System.Drawing.Size(315, 25)
        Me.LecturerBindingNavigator.TabIndex = 0
        Me.LecturerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'LecturerBindingNavigatorSaveItem
        '
        Me.LecturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LecturerBindingNavigatorSaveItem.Image = CType(resources.GetObject("LecturerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LecturerBindingNavigatorSaveItem.Name = "LecturerBindingNavigatorSaveItem"
        Me.LecturerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LecturerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Lecturer_IDLabel
        '
        Lecturer_IDLabel.AutoSize = True
        Lecturer_IDLabel.Location = New System.Drawing.Point(78, 59)
        Lecturer_IDLabel.Name = "Lecturer_IDLabel"
        Lecturer_IDLabel.Size = New System.Drawing.Size(63, 13)
        Lecturer_IDLabel.TabIndex = 1
        Lecturer_IDLabel.Text = "Lecturer ID:"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerBindingSource, "Lecturer ID", True))
        Me.txtId.Location = New System.Drawing.Point(147, 56)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'Lecturer_NameLabel
        '
        Lecturer_NameLabel.AutoSize = True
        Lecturer_NameLabel.Location = New System.Drawing.Point(61, 85)
        Lecturer_NameLabel.Name = "Lecturer_NameLabel"
        Lecturer_NameLabel.Size = New System.Drawing.Size(80, 13)
        Lecturer_NameLabel.TabIndex = 3
        Lecturer_NameLabel.Text = "Lecturer Name:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerBindingSource, "Lecturer Name", True))
        Me.txtName.Location = New System.Drawing.Point(147, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'Lecturer_RoomLabel
        '
        Lecturer_RoomLabel.AutoSize = True
        Lecturer_RoomLabel.Location = New System.Drawing.Point(61, 111)
        Lecturer_RoomLabel.Name = "Lecturer_RoomLabel"
        Lecturer_RoomLabel.Size = New System.Drawing.Size(80, 13)
        Lecturer_RoomLabel.TabIndex = 5
        Lecturer_RoomLabel.Text = "Lecturer Room:"
        '
        'Lecturer_RoomTextBox
        '
        Me.Lecturer_RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerBindingSource, "Lecturer Room", True))
        Me.Lecturer_RoomTextBox.Location = New System.Drawing.Point(147, 108)
        Me.Lecturer_RoomTextBox.Name = "Lecturer_RoomTextBox"
        Me.Lecturer_RoomTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lecturer_RoomTextBox.TabIndex = 6
        '
        'Lecturer_HpLabel
        '
        Lecturer_HpLabel.AutoSize = True
        Lecturer_HpLabel.Location = New System.Drawing.Point(75, 137)
        Lecturer_HpLabel.Name = "Lecturer_HpLabel"
        Lecturer_HpLabel.Size = New System.Drawing.Size(66, 13)
        Lecturer_HpLabel.TabIndex = 7
        Lecturer_HpLabel.Text = "Lecturer Hp:"
        '
        'Lecturer_HpTextBox
        '
        Me.Lecturer_HpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerBindingSource, "Lecturer Hp", True))
        Me.Lecturer_HpTextBox.Location = New System.Drawing.Point(147, 134)
        Me.Lecturer_HpTextBox.Name = "Lecturer_HpTextBox"
        Me.Lecturer_HpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lecturer_HpTextBox.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(41, 175)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(147, 167)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 34)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search for Lecturer Id"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FrmLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 262)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Lecturer_HpLabel)
        Me.Controls.Add(Me.Lecturer_HpTextBox)
        Me.Controls.Add(Lecturer_RoomLabel)
        Me.Controls.Add(Me.Lecturer_RoomTextBox)
        Me.Controls.Add(Lecturer_NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Lecturer_IDLabel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.LecturerBindingNavigator)
        Me.Name = "FrmLecturer"
        Me.Text = "Lecturer Profile"
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LecturerBindingNavigator.ResumeLayout(False)
        Me.LecturerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents LecturerBindingSource As BindingSource
    Friend WithEvents LecturerTableAdapter As Library_Management_SystemDataSet1TableAdapters.LecturerTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LecturerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LecturerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Lecturer_RoomTextBox As TextBox
    Friend WithEvents Lecturer_HpTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
