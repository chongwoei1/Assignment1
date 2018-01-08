<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookReturn))
        Dim Book_Rental_IDLabel As System.Windows.Forms.Label
        Dim Book_Return_DateLabel As System.Windows.Forms.Label
        Dim Book_PenaltyLabel As System.Windows.Forms.Label
        Dim Charge_of_PenaltyLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Lecturer_IDLabel As System.Windows.Forms.Label
        Dim L_Staff_IDLabel As System.Windows.Forms.Label
        Dim Book_IDLabel As System.Windows.Forms.Label
        Me.Library_Management_SystemDataSet = New Assignment1.Library_Management_SystemDataSet()
        Me.Book_ReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_ReturnTableAdapter = New Assignment1.Library_Management_SystemDataSet1TableAdapters.Book_ReturnTableAdapter()
        Me.TableAdapterManager = New Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.Book_ReturnBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Book_ReturnBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Book_Return_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Book_PenaltyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Charge_of_PenaltyTextBox = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Lecturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.L_Staff_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Book_IDTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Book_Rental_IDLabel = New System.Windows.Forms.Label()
        Book_Return_DateLabel = New System.Windows.Forms.Label()
        Book_PenaltyLabel = New System.Windows.Forms.Label()
        Charge_of_PenaltyLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Lecturer_IDLabel = New System.Windows.Forms.Label()
        L_Staff_IDLabel = New System.Windows.Forms.Label()
        Book_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_ReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Book_ReturnBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Library_Management_SystemDataSet
        '
        Me.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet"
        Me.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Book_ReturnBindingSource
        '
        Me.Book_ReturnBindingSource.DataMember = "Book_Return"
        Me.Book_ReturnBindingSource.DataSource = Me.Library_Management_SystemDataSet
        '
        'Book_ReturnTableAdapter
        '
        Me.Book_ReturnTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_RentalTableAdapter = Nothing
        Me.TableAdapterManager.Book_ReturnTableAdapter = Me.Book_ReturnTableAdapter
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.Library_StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment1.Library_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Book_ReturnBindingNavigator
        '
        Me.Book_ReturnBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Book_ReturnBindingNavigator.BindingSource = Me.Book_ReturnBindingSource
        Me.Book_ReturnBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Book_ReturnBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Book_ReturnBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Book_ReturnBindingNavigatorSaveItem})
        Me.Book_ReturnBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Book_ReturnBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Book_ReturnBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Book_ReturnBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Book_ReturnBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Book_ReturnBindingNavigator.Name = "Book_ReturnBindingNavigator"
        Me.Book_ReturnBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Book_ReturnBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.Book_ReturnBindingNavigator.TabIndex = 0
        Me.Book_ReturnBindingNavigator.Text = "BindingNavigator1"
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
        'Book_ReturnBindingNavigatorSaveItem
        '
        Me.Book_ReturnBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Book_ReturnBindingNavigatorSaveItem.Image = CType(resources.GetObject("Book_ReturnBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Book_ReturnBindingNavigatorSaveItem.Name = "Book_ReturnBindingNavigatorSaveItem"
        Me.Book_ReturnBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Book_ReturnBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Book_Rental_IDLabel
        '
        Book_Rental_IDLabel.AutoSize = True
        Book_Rental_IDLabel.Location = New System.Drawing.Point(78, 53)
        Book_Rental_IDLabel.Name = "Book_Rental_IDLabel"
        Book_Rental_IDLabel.Size = New System.Drawing.Size(83, 13)
        Book_Rental_IDLabel.TabIndex = 1
        Book_Rental_IDLabel.Text = "Book Rental ID:"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "Book Rental ID", True))
        Me.txtId.Location = New System.Drawing.Point(167, 50)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'Book_Return_DateLabel
        '
        Book_Return_DateLabel.AutoSize = True
        Book_Return_DateLabel.Location = New System.Drawing.Point(65, 80)
        Book_Return_DateLabel.Name = "Book_Return_DateLabel"
        Book_Return_DateLabel.Size = New System.Drawing.Size(96, 13)
        Book_Return_DateLabel.TabIndex = 3
        Book_Return_DateLabel.Text = "Book Return Date:"
        '
        'Book_Return_DateDateTimePicker
        '
        Me.Book_Return_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Book_ReturnBindingSource, "Book Return Date", True))
        Me.Book_Return_DateDateTimePicker.Location = New System.Drawing.Point(167, 76)
        Me.Book_Return_DateDateTimePicker.Name = "Book_Return_DateDateTimePicker"
        Me.Book_Return_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Book_Return_DateDateTimePicker.TabIndex = 4
        '
        'Book_PenaltyLabel
        '
        Book_PenaltyLabel.AutoSize = True
        Book_PenaltyLabel.Location = New System.Drawing.Point(88, 107)
        Book_PenaltyLabel.Name = "Book_PenaltyLabel"
        Book_PenaltyLabel.Size = New System.Drawing.Size(73, 13)
        Book_PenaltyLabel.TabIndex = 5
        Book_PenaltyLabel.Text = "Book Penalty:"
        '
        'Book_PenaltyCheckBox
        '
        Me.Book_PenaltyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Book_ReturnBindingSource, "Book Penalty", True))
        Me.Book_PenaltyCheckBox.Location = New System.Drawing.Point(167, 102)
        Me.Book_PenaltyCheckBox.Name = "Book_PenaltyCheckBox"
        Me.Book_PenaltyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Book_PenaltyCheckBox.TabIndex = 6
        Me.Book_PenaltyCheckBox.Text = "CheckBox1"
        Me.Book_PenaltyCheckBox.UseVisualStyleBackColor = True
        '
        'Charge_of_PenaltyLabel
        '
        Charge_of_PenaltyLabel.AutoSize = True
        Charge_of_PenaltyLabel.Location = New System.Drawing.Point(254, 107)
        Charge_of_PenaltyLabel.Name = "Charge_of_PenaltyLabel"
        Charge_of_PenaltyLabel.Size = New System.Drawing.Size(94, 13)
        Charge_of_PenaltyLabel.TabIndex = 7
        Charge_of_PenaltyLabel.Text = "Charge of Penalty:"
        '
        'Charge_of_PenaltyTextBox
        '
        Me.Charge_of_PenaltyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "Charge of Penalty", True))
        Me.Charge_of_PenaltyTextBox.Location = New System.Drawing.Point(354, 104)
        Me.Charge_of_PenaltyTextBox.Name = "Charge_of_PenaltyTextBox"
        Me.Charge_of_PenaltyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Charge_of_PenaltyTextBox.TabIndex = 8
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(54, 135)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(61, 13)
        Student_IDLabel.TabIndex = 9
        Student_IDLabel.Text = "Student ID:"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(121, 132)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Student_IDTextBox.TabIndex = 10
        '
        'Lecturer_IDLabel
        '
        Lecturer_IDLabel.AutoSize = True
        Lecturer_IDLabel.Location = New System.Drawing.Point(227, 135)
        Lecturer_IDLabel.Name = "Lecturer_IDLabel"
        Lecturer_IDLabel.Size = New System.Drawing.Size(63, 13)
        Lecturer_IDLabel.TabIndex = 11
        Lecturer_IDLabel.Text = "Lecturer ID:"
        '
        'Lecturer_IDTextBox
        '
        Me.Lecturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "Lecturer ID", True))
        Me.Lecturer_IDTextBox.Location = New System.Drawing.Point(296, 132)
        Me.Lecturer_IDTextBox.Name = "Lecturer_IDTextBox"
        Me.Lecturer_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lecturer_IDTextBox.TabIndex = 12
        '
        'L_Staff_IDLabel
        '
        L_Staff_IDLabel.AutoSize = True
        L_Staff_IDLabel.Location = New System.Drawing.Point(409, 135)
        L_Staff_IDLabel.Name = "L_Staff_IDLabel"
        L_Staff_IDLabel.Size = New System.Drawing.Size(55, 13)
        L_Staff_IDLabel.TabIndex = 13
        L_Staff_IDLabel.Text = "L Staff ID:"
        '
        'L_Staff_IDTextBox
        '
        Me.L_Staff_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "L_Staff ID", True))
        Me.L_Staff_IDTextBox.Location = New System.Drawing.Point(470, 132)
        Me.L_Staff_IDTextBox.Name = "L_Staff_IDTextBox"
        Me.L_Staff_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.L_Staff_IDTextBox.TabIndex = 14
        '
        'Book_IDLabel
        '
        Book_IDLabel.AutoSize = True
        Book_IDLabel.Location = New System.Drawing.Point(273, 53)
        Book_IDLabel.Name = "Book_IDLabel"
        Book_IDLabel.Size = New System.Drawing.Size(49, 13)
        Book_IDLabel.TabIndex = 15
        Book_IDLabel.Text = "Book ID:"
        '
        'Book_IDTextBox
        '
        Me.Book_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_ReturnBindingSource, "Book ID", True))
        Me.Book_IDTextBox.Location = New System.Drawing.Point(328, 50)
        Me.Book_IDTextBox.Name = "Book_IDTextBox"
        Me.Book_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_IDTextBox.TabIndex = 16
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(91, 191)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(173, 20)
        Me.txtSearch.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(270, 181)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(173, 39)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search for Book Rental Id"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmBookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 262)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Book_IDLabel)
        Me.Controls.Add(Me.Book_IDTextBox)
        Me.Controls.Add(L_Staff_IDLabel)
        Me.Controls.Add(Me.L_Staff_IDTextBox)
        Me.Controls.Add(Lecturer_IDLabel)
        Me.Controls.Add(Me.Lecturer_IDTextBox)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Charge_of_PenaltyLabel)
        Me.Controls.Add(Me.Charge_of_PenaltyTextBox)
        Me.Controls.Add(Book_PenaltyLabel)
        Me.Controls.Add(Me.Book_PenaltyCheckBox)
        Me.Controls.Add(Book_Return_DateLabel)
        Me.Controls.Add(Me.Book_Return_DateDateTimePicker)
        Me.Controls.Add(Book_Rental_IDLabel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Book_ReturnBindingNavigator)
        Me.Name = "frmBookReturn"
        Me.Text = "Book Return Profile"
        CType(Me.Library_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_ReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Book_ReturnBindingNavigator.ResumeLayout(False)
        Me.Book_ReturnBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Library_Management_SystemDataSet As Library_Management_SystemDataSet
    Friend WithEvents Book_ReturnBindingSource As BindingSource
    Friend WithEvents Book_ReturnTableAdapter As Library_Management_SystemDataSet1TableAdapters.Book_ReturnTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Book_ReturnBindingNavigator As BindingNavigator
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
    Friend WithEvents Book_ReturnBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId As TextBox
    Friend WithEvents Book_Return_DateDateTimePicker As DateTimePicker
    Friend WithEvents Book_PenaltyCheckBox As CheckBox
    Friend WithEvents Charge_of_PenaltyTextBox As TextBox
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents Lecturer_IDTextBox As TextBox
    Friend WithEvents L_Staff_IDTextBox As TextBox
    Friend WithEvents Book_IDTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
