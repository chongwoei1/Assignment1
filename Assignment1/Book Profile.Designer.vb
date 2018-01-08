<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBook))
        Dim Book_IDLabel As System.Windows.Forms.Label
        Dim Book_NameLabel As System.Windows.Forms.Label
        Dim Book_TypeLabel As System.Windows.Forms.Label
        Dim Book_LocationLabel As System.Windows.Forms.Label
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.BookTableAdapter()
        Me.TableAdapterManager = New Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.BookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Book_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Book_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Book_IDLabel = New System.Windows.Forms.Label()
        Book_NameLabel = New System.Windows.Forms.Label()
        Book_TypeLabel = New System.Windows.Forms.Label()
        Book_LocationLabel = New System.Windows.Forms.Label()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_RentalTableAdapter = Nothing
        Me.TableAdapterManager.Book_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.Library_StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookBindingNavigator
        '
        Me.BookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookBindingNavigator.BindingSource = Me.BookBindingSource
        Me.BookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookBindingNavigatorSaveItem})
        Me.BookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookBindingNavigator.Name = "BookBindingNavigator"
        Me.BookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.BookBindingNavigator.TabIndex = 0
        Me.BookBindingNavigator.Text = "BindingNavigator1"
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
        'BookBindingNavigatorSaveItem
        '
        Me.BookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookBindingNavigatorSaveItem.Name = "BookBindingNavigatorSaveItem"
        Me.BookBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Book_IDLabel
        '
        Book_IDLabel.AutoSize = True
        Book_IDLabel.Location = New System.Drawing.Point(88, 57)
        Book_IDLabel.Name = "Book_IDLabel"
        Book_IDLabel.Size = New System.Drawing.Size(49, 13)
        Book_IDLabel.TabIndex = 1
        Book_IDLabel.Text = "Book ID:"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book ID", True))
        Me.txtId.Location = New System.Drawing.Point(143, 54)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(136, 20)
        Me.txtId.TabIndex = 2
        '
        'Book_NameLabel
        '
        Book_NameLabel.AutoSize = True
        Book_NameLabel.Location = New System.Drawing.Point(71, 83)
        Book_NameLabel.Name = "Book_NameLabel"
        Book_NameLabel.Size = New System.Drawing.Size(66, 13)
        Book_NameLabel.TabIndex = 3
        Book_NameLabel.Text = "Book Name:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Name", True))
        Me.txtName.Location = New System.Drawing.Point(143, 80)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(136, 20)
        Me.txtName.TabIndex = 4
        '
        'Book_TypeLabel
        '
        Book_TypeLabel.AutoSize = True
        Book_TypeLabel.Location = New System.Drawing.Point(75, 109)
        Book_TypeLabel.Name = "Book_TypeLabel"
        Book_TypeLabel.Size = New System.Drawing.Size(62, 13)
        Book_TypeLabel.TabIndex = 5
        Book_TypeLabel.Text = "Book Type:"
        '
        'Book_TypeTextBox
        '
        Me.Book_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Type", True))
        Me.Book_TypeTextBox.Location = New System.Drawing.Point(143, 106)
        Me.Book_TypeTextBox.Name = "Book_TypeTextBox"
        Me.Book_TypeTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Book_TypeTextBox.TabIndex = 6
        '
        'Book_LocationLabel
        '
        Book_LocationLabel.AutoSize = True
        Book_LocationLabel.Location = New System.Drawing.Point(58, 135)
        Book_LocationLabel.Name = "Book_LocationLabel"
        Book_LocationLabel.Size = New System.Drawing.Size(79, 13)
        Book_LocationLabel.TabIndex = 7
        Book_LocationLabel.Text = "Book Location:"
        '
        'Book_LocationTextBox
        '
        Me.Book_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Location", True))
        Me.Book_LocationTextBox.Location = New System.Drawing.Point(143, 132)
        Me.Book_LocationTextBox.Name = "Book_LocationTextBox"
        Me.Book_LocationTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Book_LocationTextBox.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(61, 182)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(167, 170)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 42)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search for Book Id"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 262)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Book_LocationLabel)
        Me.Controls.Add(Me.Book_LocationTextBox)
        Me.Controls.Add(Book_TypeLabel)
        Me.Controls.Add(Me.Book_TypeTextBox)
        Me.Controls.Add(Book_NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Book_IDLabel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.BookBindingNavigator)
        Me.Name = "frmBook"
        Me.Text = "Book Profile"
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookBindingNavigator.ResumeLayout(False)
        Me.BookBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As Library_Management_SystemDataSet1TableAdapters.BookTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BookBindingNavigator As BindingNavigator
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
    Friend WithEvents BookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Book_TypeTextBox As TextBox
    Friend WithEvents Book_LocationTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
