<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanelManageEmployees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ERemoveBtn = New System.Windows.Forms.Button()
        Me.EUpdateBtn = New System.Windows.Forms.Button()
        Me.EAddBtn = New System.Windows.Forms.Button()
        Me.ELNameTb = New System.Windows.Forms.TextBox()
        Me.ELNameLbl = New System.Windows.Forms.Label()
        Me.EAddressTb = New System.Windows.Forms.TextBox()
        Me.EContactLbl = New System.Windows.Forms.Label()
        Me.EContactTb = New System.Windows.Forms.TextBox()
        Me.EPostLbl = New System.Windows.Forms.Label()
        Me.EPostTb = New System.Windows.Forms.TextBox()
        Me.EAddressLbl = New System.Windows.Forms.Label()
        Me.EFNameTb = New System.Windows.Forms.TextBox()
        Me.EFNameLbl = New System.Windows.Forms.Label()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet2 = New Spa_Management_System.SpaMgtSysDataSet2()
        Me.Usp_View_EmployeesTableAdapter = New Spa_Management_System.SpaMgtSysDataSet2TableAdapters.Usp_View_EmployeesTableAdapter()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightGray
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(46, 223)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(70, 39)
        Me.ResetBtn.TabIndex = 57
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ERemoveBtn
        '
        Me.ERemoveBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.ERemoveBtn.FlatAppearance.BorderSize = 0
        Me.ERemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ERemoveBtn.Location = New System.Drawing.Point(126, 317)
        Me.ERemoveBtn.Name = "ERemoveBtn"
        Me.ERemoveBtn.Size = New System.Drawing.Size(181, 39)
        Me.ERemoveBtn.TabIndex = 56
        Me.ERemoveBtn.Text = "Remove Employee"
        Me.ERemoveBtn.UseVisualStyleBackColor = False
        '
        'EUpdateBtn
        '
        Me.EUpdateBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.EUpdateBtn.FlatAppearance.BorderSize = 0
        Me.EUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EUpdateBtn.Location = New System.Drawing.Point(126, 270)
        Me.EUpdateBtn.Name = "EUpdateBtn"
        Me.EUpdateBtn.Size = New System.Drawing.Size(181, 39)
        Me.EUpdateBtn.TabIndex = 55
        Me.EUpdateBtn.Text = "Edit Info"
        Me.EUpdateBtn.UseVisualStyleBackColor = False
        '
        'EAddBtn
        '
        Me.EAddBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.EAddBtn.FlatAppearance.BorderSize = 0
        Me.EAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EAddBtn.Location = New System.Drawing.Point(126, 223)
        Me.EAddBtn.Name = "EAddBtn"
        Me.EAddBtn.Size = New System.Drawing.Size(181, 39)
        Me.EAddBtn.TabIndex = 54
        Me.EAddBtn.Text = "Add Employee"
        Me.EAddBtn.UseVisualStyleBackColor = False
        '
        'ELNameTb
        '
        Me.ELNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ELNameTb.Location = New System.Drawing.Point(126, 61)
        Me.ELNameTb.Name = "ELNameTb"
        Me.ELNameTb.Size = New System.Drawing.Size(181, 33)
        Me.ELNameTb.TabIndex = 53
        '
        'ELNameLbl
        '
        Me.ELNameLbl.AutoSize = True
        Me.ELNameLbl.Location = New System.Drawing.Point(18, 69)
        Me.ELNameLbl.Name = "ELNameLbl"
        Me.ELNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.ELNameLbl.TabIndex = 52
        Me.ELNameLbl.Text = "Last Name:"
        '
        'EAddressTb
        '
        Me.EAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EAddressTb.Location = New System.Drawing.Point(126, 102)
        Me.EAddressTb.Name = "EAddressTb"
        Me.EAddressTb.Size = New System.Drawing.Size(181, 33)
        Me.EAddressTb.TabIndex = 51
        '
        'EContactLbl
        '
        Me.EContactLbl.AutoSize = True
        Me.EContactLbl.Location = New System.Drawing.Point(41, 145)
        Me.EContactLbl.Name = "EContactLbl"
        Me.EContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.EContactLbl.TabIndex = 50
        Me.EContactLbl.Text = "Contact:"
        '
        'EContactTb
        '
        Me.EContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EContactTb.Location = New System.Drawing.Point(126, 143)
        Me.EContactTb.Name = "EContactTb"
        Me.EContactTb.Size = New System.Drawing.Size(181, 33)
        Me.EContactTb.TabIndex = 49
        '
        'EPostLbl
        '
        Me.EPostLbl.AutoSize = True
        Me.EPostLbl.Location = New System.Drawing.Point(70, 186)
        Me.EPostLbl.Name = "EPostLbl"
        Me.EPostLbl.Size = New System.Drawing.Size(52, 25)
        Me.EPostLbl.TabIndex = 48
        Me.EPostLbl.Text = "Post:"
        '
        'EPostTb
        '
        Me.EPostTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EPostTb.Location = New System.Drawing.Point(126, 184)
        Me.EPostTb.Name = "EPostTb"
        Me.EPostTb.Size = New System.Drawing.Size(181, 33)
        Me.EPostTb.TabIndex = 47
        '
        'EAddressLbl
        '
        Me.EAddressLbl.AutoSize = True
        Me.EAddressLbl.Location = New System.Drawing.Point(37, 104)
        Me.EAddressLbl.Name = "EAddressLbl"
        Me.EAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.EAddressLbl.TabIndex = 46
        Me.EAddressLbl.Text = "Address:"
        '
        'EFNameTb
        '
        Me.EFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFNameTb.Location = New System.Drawing.Point(126, 20)
        Me.EFNameTb.Name = "EFNameTb"
        Me.EFNameTb.Size = New System.Drawing.Size(181, 33)
        Me.EFNameTb.TabIndex = 45
        '
        'EFNameLbl
        '
        Me.EFNameLbl.AutoSize = True
        Me.EFNameLbl.Location = New System.Drawing.Point(16, 22)
        Me.EFNameLbl.Name = "EFNameLbl"
        Me.EFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.EFNameLbl.TabIndex = 44
        Me.EFNameLbl.Text = "First Name:"
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.AllowUserToResizeColumns = False
        Me.EmployeeDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.AutoGenerateColumns = False
        Me.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDGV.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeDGV.ColumnHeadersHeight = 30
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.EmployeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.PostDataGridViewTextBoxColumn})
        Me.EmployeeDGV.DataSource = Me.UspViewEmployeesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(327, 20)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowTemplate.Height = 30
        Me.EmployeeDGV.RowTemplate.ReadOnly = True
        Me.EmployeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDGV.Size = New System.Drawing.Size(766, 505)
        Me.EmployeeDGV.TabIndex = 67
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PostDataGridViewTextBoxColumn
        '
        Me.PostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PostDataGridViewTextBoxColumn.DataPropertyName = "Post"
        Me.PostDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.PostDataGridViewTextBoxColumn.HeaderText = "Post"
        Me.PostDataGridViewTextBoxColumn.Name = "PostDataGridViewTextBoxColumn"
        Me.PostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspViewEmployeesBindingSource
        '
        Me.UspViewEmployeesBindingSource.DataMember = "Usp_View_Employees"
        Me.UspViewEmployeesBindingSource.DataSource = Me.SpaMgtSysDataSet2
        '
        'SpaMgtSysDataSet2
        '
        Me.SpaMgtSysDataSet2.DataSetName = "SpaMgtSysDataSet2"
        Me.SpaMgtSysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_EmployeesTableAdapter
        '
        Me.Usp_View_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'AdminPanelManageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 537)
        Me.Controls.Add(Me.EmployeeDGV)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.ERemoveBtn)
        Me.Controls.Add(Me.EUpdateBtn)
        Me.Controls.Add(Me.EAddBtn)
        Me.Controls.Add(Me.ELNameTb)
        Me.Controls.Add(Me.ELNameLbl)
        Me.Controls.Add(Me.EAddressTb)
        Me.Controls.Add(Me.EContactLbl)
        Me.Controls.Add(Me.EContactTb)
        Me.Controls.Add(Me.EPostLbl)
        Me.Controls.Add(Me.EPostTb)
        Me.Controls.Add(Me.EAddressLbl)
        Me.Controls.Add(Me.EFNameTb)
        Me.Controls.Add(Me.EFNameLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AdminPanelManageEmployees"
        Me.Text = "Manage Employees"
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResetBtn As Button
    Friend WithEvents ERemoveBtn As Button
    Friend WithEvents EUpdateBtn As Button
    Friend WithEvents EAddBtn As Button
    Friend WithEvents ELNameTb As TextBox
    Friend WithEvents ELNameLbl As Label
    Friend WithEvents EAddressTb As TextBox
    Friend WithEvents EContactLbl As Label
    Friend WithEvents EContactTb As TextBox
    Friend WithEvents EPostLbl As Label
    Friend WithEvents EPostTb As TextBox
    Friend WithEvents EAddressLbl As Label
    Friend WithEvents EFNameTb As TextBox
    Friend WithEvents EFNameLbl As Label
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents SpaMgtSysDataSet2 As SpaMgtSysDataSet2
    Friend WithEvents UspViewEmployeesBindingSource As BindingSource
    Friend WithEvents Usp_View_EmployeesTableAdapter As SpaMgtSysDataSet2TableAdapters.Usp_View_EmployeesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
