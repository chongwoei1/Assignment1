<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookRental))
        Dim Book_Rental_IDLabel As System.Windows.Forms.Label
        Dim Book_StartRentalDateLabel As System.Windows.Forms.Label
        Dim Book_EndRentalDateLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Lecturer_IDLabel As System.Windows.Forms.Label
        Dim L_Staff_IDLabel As System.Windows.Forms.Label
        Dim Book_IDLabel As System.Windows.Forms.Label
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.Book_RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_RentalTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.Book_RentalTableAdapter()
        Me.TableAdapterManager = New Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.Book_RentalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Book_RentalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Book_StartRentalDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Book_EndRentalDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Lecturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.L_Staff_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Book_IDTextBox = New System.Windows.Forms.TextBox()
        Me.btnSeach = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Book_Rental_IDLabel = New System.Windows.Forms.Label()
        Book_StartRentalDateLabel = New System.Windows.Forms.Label()
        Book_EndRentalDateLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Lecturer_IDLabel = New System.Windows.Forms.Label()
        L_Staff_IDLabel = New System.Windows.Forms.Label()
        Book_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_RentalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Book_RentalBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Book_RentalBindingSource
        '
        Me.Book_RentalBindingSource.DataMember = "Book_Rental"
        Me.Book_RentalBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'Book_RentalTableAdapter
        '
        Me.Book_RentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_RentalTableAdapter = Me.Book_RentalTableAdapter
        Me.TableAdapterManager.Book_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.Library_StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Book_RentalBindingNavigator
        '
        Me.Book_RentalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Book_RentalBindingNavigator.BindingSource = Me.Book_RentalBindingSource
        Me.Book_RentalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Book_RentalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Book_RentalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Book_RentalBindingNavigatorSaveItem})
        Me.Book_RentalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Book_RentalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Book_RentalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Book_RentalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Book_RentalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Book_RentalBindingNavigator.Name = "Book_RentalBindingNavigator"
        Me.Book_RentalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Book_RentalBindingNavigator.Size = New System.Drawing.Size(632, 25)
        Me.Book_RentalBindingNavigator.TabIndex = 0
        Me.Book_RentalBindingNavigator.Text = "BindingNavigator1"
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
        'Book_RentalBindingNavigatorSaveItem
        '
        Me.Book_RentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Book_RentalBindingNavigatorSaveItem.Image = CType(resources.GetObject("Book_RentalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Book_RentalBindingNavigatorSaveItem.Name = "Book_RentalBindingNavigatorSaveItem"
        Me.Book_RentalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Book_RentalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Book_Rental_IDLabel
        '
        Book_Rental_IDLabel.AutoSize = True
        Book_Rental_IDLabel.Location = New System.Drawing.Point(83, 45)
        Book_Rental_IDLabel.Name = "Book_Rental_IDLabel"
        Book_Rental_IDLabel.Size = New System.Drawing.Size(83, 13)
        Book_Rental_IDLabel.TabIndex = 1
        Book_Rental_IDLabel.Text = "Book Rental ID:"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_RentalBindingSource, "Book Rental ID", True))
        Me.txtId.Location = New System.Drawing.Point(172, 42)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'Book_StartRentalDateLabel
        '
        Book_StartRentalDateLabel.AutoSize = True
        Book_StartRentalDateLabel.Location = New System.Drawing.Point(46, 72)
        Book_StartRentalDateLabel.Name = "Book_StartRentalDateLabel"
        Book_StartRentalDateLabel.Size = New System.Drawing.Size(120, 13)
        Book_StartRentalDateLabel.TabIndex = 3
        Book_StartRentalDateLabel.Text = "Book Start Rental Date:"
        '
        'Book_StartRentalDateDateTimePicker
        '
        Me.Book_StartRentalDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Book_RentalBindingSource, "Book StartRentalDate", True))
        Me.Book_StartRentalDateDateTimePicker.Location = New System.Drawing.Point(172, 68)
        Me.Book_StartRentalDateDateTimePicker.Name = "Book_StartRentalDateDateTimePicker"
        Me.Book_StartRentalDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Book_StartRentalDateDateTimePicker.TabIndex = 4
        '
        'Book_EndRentalDateLabel
        '
        Book_EndRentalDateLabel.AutoSize = True
        Book_EndRentalDateLabel.Location = New System.Drawing.Point(49, 98)
        Book_EndRentalDateLabel.Name = "Book_EndRentalDateLabel"
        Book_EndRentalDateLabel.Size = New System.Drawing.Size(117, 13)
        Book_EndRentalDateLabel.TabIndex = 5
        Book_EndRentalDateLabel.Text = "Book End Rental Date:"
        '
        'Book_EndRentalDateDateTimePicker
        '
        Me.Book_EndRentalDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Book_RentalBindingSource, "Book EndRentalDate", True))
        Me.Book_EndRentalDateDateTimePicker.Location = New System.Drawing.Point(172, 94)
        Me.Book_EndRentalDateDateTimePicker.Name = "Book_EndRentalDateDateTimePicker"
        Me.Book_EndRentalDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Book_EndRentalDateDateTimePicker.TabIndex = 6
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(52, 123)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(61, 13)
        Student_IDLabel.TabIndex = 7
        Student_IDLabel.Text = "Student ID:"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_RentalBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(119, 120)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Student_IDTextBox.TabIndex = 8
        '
        'Lecturer_IDLabel
        '
        Lecturer_IDLabel.AutoSize = True
        Lecturer_IDLabel.Location = New System.Drawing.Point(226, 123)
        Lecturer_IDLabel.Name = "Lecturer_IDLabel"
        Lecturer_IDLabel.Size = New System.Drawing.Size(63, 13)
        Lecturer_IDLabel.TabIndex = 9
        Lecturer_IDLabel.Text = "Lecturer ID:"
        '
        'Lecturer_IDTextBox
        '
        Me.Lecturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_RentalBindingSource, "Lecturer ID", True))
        Me.Lecturer_IDTextBox.Location = New System.Drawing.Point(295, 120)
        Me.Lecturer_IDTextBox.Name = "Lecturer_IDTextBox"
        Me.Lecturer_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lecturer_IDTextBox.TabIndex = 10
        '
        'L_Staff_IDLabel
        '
        L_Staff_IDLabel.AutoSize = True
        L_Staff_IDLabel.Location = New System.Drawing.Point(403, 123)
        L_Staff_IDLabel.Name = "L_Staff_IDLabel"
        L_Staff_IDLabel.Size = New System.Drawing.Size(55, 13)
        L_Staff_IDLabel.TabIndex = 11
        L_Staff_IDLabel.Text = "L Staff ID:"
        '
        'L_Staff_IDTextBox
        '
        Me.L_Staff_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_RentalBindingSource, "L_Staff ID", True))
        Me.L_Staff_IDTextBox.Location = New System.Drawing.Point(464, 120)
        Me.L_Staff_IDTextBox.Name = "L_Staff_IDTextBox"
        Me.L_Staff_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.L_Staff_IDTextBox.TabIndex = 12
        '
        'Book_IDLabel
        '
        Book_IDLabel.AutoSize = True
        Book_IDLabel.Location = New System.Drawing.Point(280, 45)
        Book_IDLabel.Name = "Book_IDLabel"
        Book_IDLabel.Size = New System.Drawing.Size(49, 13)
        Book_IDLabel.TabIndex = 13
        Book_IDLabel.Text = "Book ID:"
        '
        'Book_IDTextBox
        '
        Me.Book_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_RentalBindingSource, "Book ID", True))
        Me.Book_IDTextBox.Location = New System.Drawing.Point(335, 42)
        Me.Book_IDTextBox.Name = "Book_IDTextBox"
        Me.Book_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_IDTextBox.TabIndex = 14
        '
        'btnSeach
        '
        Me.btnSeach.Location = New System.Drawing.Point(283, 176)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(181, 36)
        Me.btnSeach.TabIndex = 15
        Me.btnSeach.Text = "Search for Book Rental Id"
        Me.btnSeach.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(119, 185)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(153, 20)
        Me.txtSearch.TabIndex = 16
        '
        'frmBookRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 262)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSeach)
        Me.Controls.Add(Book_IDLabel)
        Me.Controls.Add(Me.Book_IDTextBox)
        Me.Controls.Add(L_Staff_IDLabel)
        Me.Controls.Add(Me.L_Staff_IDTextBox)
        Me.Controls.Add(Lecturer_IDLabel)
        Me.Controls.Add(Me.Lecturer_IDTextBox)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Book_EndRentalDateLabel)
        Me.Controls.Add(Me.Book_EndRentalDateDateTimePicker)
        Me.Controls.Add(Book_StartRentalDateLabel)
        Me.Controls.Add(Me.Book_StartRentalDateDateTimePicker)
        Me.Controls.Add(Book_Rental_IDLabel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Book_RentalBindingNavigator)
        Me.Name = "frmBookRental"
        Me.Text = "Book Rental Profile"
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_RentalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Book_RentalBindingNavigator.ResumeLayout(False)
        Me.Book_RentalBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents Book_RentalBindingSource As BindingSource
    Friend WithEvents Book_RentalTableAdapter As Library_Management_SystemDataSet1TableAdapters.Book_RentalTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Book_RentalBindingNavigator As BindingNavigator
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
    Friend WithEvents Book_RentalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId As TextBox
    Friend WithEvents Book_StartRentalDateDateTimePicker As DateTimePicker
    Friend WithEvents Book_EndRentalDateDateTimePicker As DateTimePicker
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents Lecturer_IDTextBox As TextBox
    Friend WithEvents L_Staff_IDTextBox As TextBox
    Friend WithEvents Book_IDTextBox As TextBox
    Friend WithEvents btnSeach As Button
    Friend WithEvents txtSearch As TextBox
End Class
