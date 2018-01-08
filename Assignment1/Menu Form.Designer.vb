<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLMS
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
        Me.btnLSP = New System.Windows.Forms.Button()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.btnBP = New System.Windows.Forms.Button()
        Me.btnBRP = New System.Windows.Forms.Button()
        Me.btnLP = New System.Windows.Forms.Button()
        Me.btnBReP = New System.Windows.Forms.Button()
        Me.btnLSF = New System.Windows.Forms.Button()
        Me.btnSF = New System.Windows.Forms.Button()
        Me.btnLF = New System.Windows.Forms.Button()
        Me.btnBF = New System.Windows.Forms.Button()
        Me.btnBRF = New System.Windows.Forms.Button()
        Me.btnBReF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLSP
        '
        Me.btnLSP.Location = New System.Drawing.Point(44, 29)
        Me.btnLSP.Name = "btnLSP"
        Me.btnLSP.Size = New System.Drawing.Size(123, 32)
        Me.btnLSP.TabIndex = 0
        Me.btnLSP.Text = "Libary Staff Profile"
        Me.btnLSP.UseVisualStyleBackColor = True
        '
        'btnSP
        '
        Me.btnSP.Location = New System.Drawing.Point(44, 67)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(123, 32)
        Me.btnSP.TabIndex = 1
        Me.btnSP.Text = "Student Profile"
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'btnBP
        '
        Me.btnBP.Location = New System.Drawing.Point(44, 143)
        Me.btnBP.Name = "btnBP"
        Me.btnBP.Size = New System.Drawing.Size(123, 32)
        Me.btnBP.TabIndex = 2
        Me.btnBP.Text = "Book Profile"
        Me.btnBP.UseVisualStyleBackColor = True
        '
        'btnBRP
        '
        Me.btnBRP.Location = New System.Drawing.Point(44, 181)
        Me.btnBRP.Name = "btnBRP"
        Me.btnBRP.Size = New System.Drawing.Size(123, 32)
        Me.btnBRP.TabIndex = 3
        Me.btnBRP.Text = "Book Rental Profile"
        Me.btnBRP.UseVisualStyleBackColor = True
        '
        'btnLP
        '
        Me.btnLP.Location = New System.Drawing.Point(44, 105)
        Me.btnLP.Name = "btnLP"
        Me.btnLP.Size = New System.Drawing.Size(123, 32)
        Me.btnLP.TabIndex = 4
        Me.btnLP.Text = "Lecturer Profile"
        Me.btnLP.UseVisualStyleBackColor = True
        '
        'btnBReP
        '
        Me.btnBReP.Location = New System.Drawing.Point(44, 219)
        Me.btnBReP.Name = "btnBReP"
        Me.btnBReP.Size = New System.Drawing.Size(123, 32)
        Me.btnBReP.TabIndex = 5
        Me.btnBReP.Text = "Book Return Profile"
        Me.btnBReP.UseVisualStyleBackColor = True
        '
        'btnLSF
        '
        Me.btnLSF.Location = New System.Drawing.Point(173, 29)
        Me.btnLSF.Name = "btnLSF"
        Me.btnLSF.Size = New System.Drawing.Size(123, 32)
        Me.btnLSF.TabIndex = 6
        Me.btnLSF.Text = "Library Staff Form"
        Me.btnLSF.UseVisualStyleBackColor = True
        '
        'btnSF
        '
        Me.btnSF.Location = New System.Drawing.Point(173, 67)
        Me.btnSF.Name = "btnSF"
        Me.btnSF.Size = New System.Drawing.Size(123, 32)
        Me.btnSF.TabIndex = 7
        Me.btnSF.Text = "Student Form"
        Me.btnSF.UseVisualStyleBackColor = True
        '
        'btnLF
        '
        Me.btnLF.Location = New System.Drawing.Point(173, 105)
        Me.btnLF.Name = "btnLF"
        Me.btnLF.Size = New System.Drawing.Size(123, 32)
        Me.btnLF.TabIndex = 8
        Me.btnLF.Text = "Lecturer Form"
        Me.btnLF.UseVisualStyleBackColor = True
        '
        'btnBF
        '
        Me.btnBF.Location = New System.Drawing.Point(173, 143)
        Me.btnBF.Name = "btnBF"
        Me.btnBF.Size = New System.Drawing.Size(123, 32)
        Me.btnBF.TabIndex = 9
        Me.btnBF.Text = "Book Form"
        Me.btnBF.UseVisualStyleBackColor = True
        '
        'btnBRF
        '
        Me.btnBRF.Location = New System.Drawing.Point(173, 181)
        Me.btnBRF.Name = "btnBRF"
        Me.btnBRF.Size = New System.Drawing.Size(123, 32)
        Me.btnBRF.TabIndex = 10
        Me.btnBRF.Text = "Book Rental Form"
        Me.btnBRF.UseVisualStyleBackColor = True
        '
        'btnBReF
        '
        Me.btnBReF.Location = New System.Drawing.Point(173, 219)
        Me.btnBReF.Name = "btnBReF"
        Me.btnBReF.Size = New System.Drawing.Size(123, 32)
        Me.btnBReF.TabIndex = 11
        Me.btnBReF.Text = "Book Return Form"
        Me.btnBReF.UseVisualStyleBackColor = True
        '
        'frmLMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 296)
        Me.Controls.Add(Me.btnBReF)
        Me.Controls.Add(Me.btnBRF)
        Me.Controls.Add(Me.btnBF)
        Me.Controls.Add(Me.btnLF)
        Me.Controls.Add(Me.btnSF)
        Me.Controls.Add(Me.btnLSF)
        Me.Controls.Add(Me.btnBReP)
        Me.Controls.Add(Me.btnLP)
        Me.Controls.Add(Me.btnBRP)
        Me.Controls.Add(Me.btnBP)
        Me.Controls.Add(Me.btnSP)
        Me.Controls.Add(Me.btnLSP)
        Me.Name = "frmLMS"
        Me.Text = "Library Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLSP As Button
    Friend WithEvents btnSP As Button
    Friend WithEvents btnBP As Button
    Friend WithEvents btnBRP As Button
    Friend WithEvents btnLP As Button
    Friend WithEvents btnBReP As Button
    Friend WithEvents btnLSF As Button
    Friend WithEvents btnSF As Button
    Friend WithEvents btnLF As Button
    Friend WithEvents btnBF As Button
    Friend WithEvents btnBRF As Button
    Friend WithEvents btnBReF As Button
End Class
