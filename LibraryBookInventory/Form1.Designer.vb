<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxAvailable = New System.Windows.Forms.CheckBox()
        Me.cbxNA = New System.Windows.Forms.CheckBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.cmbAvailability = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreate.Location = New System.Drawing.Point(28, 400)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(101, 38)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(71, 46)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(419, 20)
        Me.tbTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.24!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LIBRARY BOOK INVENTORY"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.Location = New System.Drawing.Point(28, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 243)
        Me.DataGridView1.TabIndex = 3
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(361, 77)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(127, 20)
        Me.tbID.TabIndex = 4
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(84, 75)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(227, 20)
        Me.tbAuthor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Author :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ID :"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnView.Location = New System.Drawing.Point(226, 400)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(101, 38)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Location = New System.Drawing.Point(436, 400)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 38)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(666, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 38)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Novel", "Sci-Fi", "Fantrasy", "Mystery", "History", "Fiction", "Adventure", "Literary"})
        Me.cmbCategory.Location = New System.Drawing.Point(577, 45)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(172, 21)
        Me.cmbCategory.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(507, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Category :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(507, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Availability :"
        '
        'cbxAvailable
        '
        Me.cbxAvailable.AutoSize = True
        Me.cbxAvailable.Location = New System.Drawing.Point(588, 83)
        Me.cbxAvailable.Name = "cbxAvailable"
        Me.cbxAvailable.Size = New System.Drawing.Size(69, 17)
        Me.cbxAvailable.TabIndex = 16
        Me.cbxAvailable.Text = "Available"
        Me.cbxAvailable.UseVisualStyleBackColor = True
        '
        'cbxNA
        '
        Me.cbxNA.AutoSize = True
        Me.cbxNA.Location = New System.Drawing.Point(684, 83)
        Me.cbxNA.Name = "cbxNA"
        Me.cbxNA.Size = New System.Drawing.Size(46, 17)
        Me.cbxNA.TabIndex = 18
        Me.cbxNA.Text = "N/A"
        Me.cbxNA.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(84, 108)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(227, 20)
        Me.tbSearch.TabIndex = 19
        '
        'cmbSort
        '
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.cmbSort.Location = New System.Drawing.Point(360, 106)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(128, 21)
        Me.cmbSort.TabIndex = 20
        '
        'cmbAvailability
        '
        Me.cmbAvailability.FormattingEnabled = True
        Me.cmbAvailability.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.cmbAvailability.Location = New System.Drawing.Point(510, 106)
        Me.cmbAvailability.Name = "cmbAvailability"
        Me.cmbAvailability.Size = New System.Drawing.Size(239, 21)
        Me.cmbAvailability.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Search :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Sort:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbAvailability)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.cbxNA)
        Me.Controls.Add(Me.cbxAvailable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "Welcome!"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxAvailable As CheckBox
    Friend WithEvents cbxNA As CheckBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents cmbAvailability As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
