<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaff
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
        Dim L_Staff_IDLabel As System.Windows.Forms.Label
        Dim L_Staff_NameLabel As System.Windows.Forms.Label
        Dim L_Staff_AddressLabel As System.Windows.Forms.Label
        Dim L_Staff_HpLabel As System.Windows.Forms.Label
        Dim L_Staff_ScheduleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStaff))
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.Library_StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Library_StaffTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.Library_StaffTableAdapter()
        Me.TableAdapterManager = New Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.Library_StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Library_StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.L_Staff_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.L_Staff_HpTextBox = New System.Windows.Forms.TextBox()
        Me.L_Staff_ScheduleTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        L_Staff_IDLabel = New System.Windows.Forms.Label()
        L_Staff_NameLabel = New System.Windows.Forms.Label()
        L_Staff_AddressLabel = New System.Windows.Forms.Label()
        L_Staff_HpLabel = New System.Windows.Forms.Label()
        L_Staff_ScheduleLabel = New System.Windows.Forms.Label()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Library_StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Library_StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Library_StaffBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_Staff_IDLabel
        '
        L_Staff_IDLabel.AutoSize = True
        L_Staff_IDLabel.Location = New System.Drawing.Point(108, 56)
        L_Staff_IDLabel.Name = "L_Staff_IDLabel"
        L_Staff_IDLabel.Size = New System.Drawing.Size(55, 13)
        L_Staff_IDLabel.TabIndex = 1
        L_Staff_IDLabel.Text = "L Staff ID:"
        '
        'L_Staff_NameLabel
        '
        L_Staff_NameLabel.AutoSize = True
        L_Staff_NameLabel.Location = New System.Drawing.Point(91, 82)
        L_Staff_NameLabel.Name = "L_Staff_NameLabel"
        L_Staff_NameLabel.Size = New System.Drawing.Size(72, 13)
        L_Staff_NameLabel.TabIndex = 3
        L_Staff_NameLabel.Text = "L Staff Name:"
        '
        'L_Staff_AddressLabel
        '
        L_Staff_AddressLabel.AutoSize = True
        L_Staff_AddressLabel.Location = New System.Drawing.Point(81, 108)
        L_Staff_AddressLabel.Name = "L_Staff_AddressLabel"
        L_Staff_AddressLabel.Size = New System.Drawing.Size(82, 13)
        L_Staff_AddressLabel.TabIndex = 5
        L_Staff_AddressLabel.Text = "L Staff Address:"
        '
        'L_Staff_HpLabel
        '
        L_Staff_HpLabel.AutoSize = True
        L_Staff_HpLabel.Location = New System.Drawing.Point(105, 134)
        L_Staff_HpLabel.Name = "L_Staff_HpLabel"
        L_Staff_HpLabel.Size = New System.Drawing.Size(58, 13)
        L_Staff_HpLabel.TabIndex = 7
        L_Staff_HpLabel.Text = "L Staff Hp:"
        '
        'L_Staff_ScheduleLabel
        '
        L_Staff_ScheduleLabel.AutoSize = True
        L_Staff_ScheduleLabel.Location = New System.Drawing.Point(74, 160)
        L_Staff_ScheduleLabel.Name = "L_Staff_ScheduleLabel"
        L_Staff_ScheduleLabel.Size = New System.Drawing.Size(89, 13)
        L_Staff_ScheduleLabel.TabIndex = 9
        L_Staff_ScheduleLabel.Text = "L Staff Schedule:"
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Library_StaffBindingSource
        '
        Me.Library_StaffBindingSource.DataMember = "Library_Staff"
        Me.Library_StaffBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'Library_StaffTableAdapter
        '
        Me.Library_StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_RentalTableAdapter = Nothing
        Me.TableAdapterManager.Book_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.Library_StaffTableAdapter = Me.Library_StaffTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Library_StaffBindingNavigator
        '
        Me.Library_StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Library_StaffBindingNavigator.BindingSource = Me.Library_StaffBindingSource
        Me.Library_StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Library_StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Library_StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Library_StaffBindingNavigatorSaveItem})
        Me.Library_StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Library_StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Library_StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Library_StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Library_StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Library_StaffBindingNavigator.Name = "Library_StaffBindingNavigator"
        Me.Library_StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Library_StaffBindingNavigator.Size = New System.Drawing.Size(394, 25)
        Me.Library_StaffBindingNavigator.TabIndex = 0
        Me.Library_StaffBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Library_StaffBindingNavigatorSaveItem
        '
        Me.Library_StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Library_StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("Library_StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Library_StaffBindingNavigatorSaveItem.Name = "Library_StaffBindingNavigatorSaveItem"
        Me.Library_StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Library_StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Library_StaffBindingSource, "L_Staff ID", True))
        Me.txtId.Location = New System.Drawing.Point(169, 53)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(181, 20)
        Me.txtId.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Library_StaffBindingSource, "L_Staff Name", True))
        Me.txtName.Location = New System.Drawing.Point(169, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 20)
        Me.txtName.TabIndex = 4
        '
        'L_Staff_AddressTextBox
        '
        Me.L_Staff_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Library_StaffBindingSource, "L_Staff Address", True))
        Me.L_Staff_AddressTextBox.Location = New System.Drawing.Point(169, 105)
        Me.L_Staff_AddressTextBox.Name = "L_Staff_AddressTextBox"
        Me.L_Staff_AddressTextBox.Size = New System.Drawing.Size(181, 20)
        Me.L_Staff_AddressTextBox.TabIndex = 6
        '
        'L_Staff_HpTextBox
        '
        Me.L_Staff_HpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Library_StaffBindingSource, "L_Staff Hp", True))
        Me.L_Staff_HpTextBox.Location = New System.Drawing.Point(169, 131)
        Me.L_Staff_HpTextBox.Name = "L_Staff_HpTextBox"
        Me.L_Staff_HpTextBox.Size = New System.Drawing.Size(181, 20)
        Me.L_Staff_HpTextBox.TabIndex = 8
        '
        'L_Staff_ScheduleTextBox
        '
        Me.L_Staff_ScheduleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Library_StaffBindingSource, "L_Staff Schedule", True))
        Me.L_Staff_ScheduleTextBox.Location = New System.Drawing.Point(169, 157)
        Me.L_Staff_ScheduleTextBox.Name = "L_Staff_ScheduleTextBox"
        Me.L_Staff_ScheduleTextBox.Size = New System.Drawing.Size(181, 20)
        Me.L_Staff_ScheduleTextBox.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(108, 204)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(214, 195)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(121, 37)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search for Staff Id"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FrmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 262)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(L_Staff_ScheduleLabel)
        Me.Controls.Add(Me.L_Staff_ScheduleTextBox)
        Me.Controls.Add(L_Staff_HpLabel)
        Me.Controls.Add(Me.L_Staff_HpTextBox)
        Me.Controls.Add(L_Staff_AddressLabel)
        Me.Controls.Add(Me.L_Staff_AddressTextBox)
        Me.Controls.Add(L_Staff_NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(L_Staff_IDLabel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Library_StaffBindingNavigator)
        Me.Name = "FrmStaff"
        Me.Text = "Library Staff Profile"
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Library_StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Library_StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Library_StaffBindingNavigator.ResumeLayout(False)
        Me.Library_StaffBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents Library_StaffBindingSource As BindingSource
    Friend WithEvents Library_StaffTableAdapter As Library_Management_SystemDataSet1TableAdapters.Library_StaffTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Library_StaffBindingNavigator As BindingNavigator
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
    Friend WithEvents Library_StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents L_Staff_AddressTextBox As TextBox
    Friend WithEvents L_Staff_HpTextBox As TextBox
    Friend WithEvents L_Staff_ScheduleTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
