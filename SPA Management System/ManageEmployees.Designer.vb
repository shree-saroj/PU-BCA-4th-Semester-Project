<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageEmployees
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageEmployees))
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsBtn = New System.Windows.Forms.Button()
        Me.ManageServicesBtn = New System.Windows.Forms.Button()
        Me.ManageEmployeesPnl = New System.Windows.Forms.Panel()
        Me.EmployeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EmpIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewEmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet1 = New SPA_Management_System.SpaMgtSysDataSet1()
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
        Me.ManageEmployeesLbl = New System.Windows.Forms.Label()
        Me.UspViewEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.Usp_View_EmployeesTableAdapter1 = New SPA_Management_System.SpaMgtSysDataSet1TableAdapters.Usp_View_EmployeesTableAdapter()
        Me.ManageEmployeesPnl.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManageUsersBtn
        '
        Me.ManageUsersBtn.BackColor = System.Drawing.Color.LightGray
        Me.ManageUsersBtn.FlatAppearance.BorderSize = 0
        Me.ManageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageUsersBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersBtn.Location = New System.Drawing.Point(12, 333)
        Me.ManageUsersBtn.Name = "ManageUsersBtn"
        Me.ManageUsersBtn.Size = New System.Drawing.Size(154, 63)
        Me.ManageUsersBtn.TabIndex = 63
        Me.ManageUsersBtn.Text = "Manage Users"
        Me.ManageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageUsersBtn.UseVisualStyleBackColor = False
        '
        'ViewStatisticsBtn
        '
        Me.ViewStatisticsBtn.BackColor = System.Drawing.Color.LightGray
        Me.ViewStatisticsBtn.FlatAppearance.BorderSize = 0
        Me.ViewStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewStatisticsBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStatisticsBtn.Location = New System.Drawing.Point(12, 411)
        Me.ViewStatisticsBtn.Name = "ViewStatisticsBtn"
        Me.ViewStatisticsBtn.Size = New System.Drawing.Size(154, 63)
        Me.ViewStatisticsBtn.TabIndex = 62
        Me.ViewStatisticsBtn.Text = "View Statistics"
        Me.ViewStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewStatisticsBtn.UseVisualStyleBackColor = False
        '
        'LogoutLbl
        '
        Me.LogoutLbl.AutoSize = True
        Me.LogoutLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLbl.Location = New System.Drawing.Point(46, 527)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(71, 25)
        Me.LogoutLbl.TabIndex = 61
        Me.LogoutLbl.Text = "Logout"
        '
        'ViewCustomerInfoBtn
        '
        Me.ViewCustomerInfoBtn.BackColor = System.Drawing.Color.LightGray
        Me.ViewCustomerInfoBtn.FlatAppearance.BorderSize = 0
        Me.ViewCustomerInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCustomerInfoBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCustomerInfoBtn.Location = New System.Drawing.Point(12, 255)
        Me.ViewCustomerInfoBtn.Name = "ViewCustomerInfoBtn"
        Me.ViewCustomerInfoBtn.Size = New System.Drawing.Size(154, 63)
        Me.ViewCustomerInfoBtn.TabIndex = 59
        Me.ViewCustomerInfoBtn.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer Info"
        Me.ViewCustomerInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewCustomerInfoBtn.UseVisualStyleBackColor = False
        '
        'ViewTransactionsBtn
        '
        Me.ViewTransactionsBtn.BackColor = System.Drawing.Color.LightGray
        Me.ViewTransactionsBtn.FlatAppearance.BorderSize = 0
        Me.ViewTransactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionsBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTransactionsBtn.Location = New System.Drawing.Point(12, 177)
        Me.ViewTransactionsBtn.Name = "ViewTransactionsBtn"
        Me.ViewTransactionsBtn.Size = New System.Drawing.Size(154, 63)
        Me.ViewTransactionsBtn.TabIndex = 58
        Me.ViewTransactionsBtn.Text = "View Transactions"
        Me.ViewTransactionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewTransactionsBtn.UseVisualStyleBackColor = False
        '
        'ManageServicesBtn
        '
        Me.ManageServicesBtn.BackColor = System.Drawing.Color.LightGray
        Me.ManageServicesBtn.FlatAppearance.BorderSize = 0
        Me.ManageServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageServicesBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageServicesBtn.Location = New System.Drawing.Point(12, 101)
        Me.ManageServicesBtn.Name = "ManageServicesBtn"
        Me.ManageServicesBtn.Size = New System.Drawing.Size(154, 63)
        Me.ManageServicesBtn.TabIndex = 57
        Me.ManageServicesBtn.Text = "Manage Services"
        Me.ManageServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageServicesBtn.UseVisualStyleBackColor = False
        '
        'ManageEmployeesPnl
        '
        Me.ManageEmployeesPnl.BackColor = System.Drawing.Color.White
        Me.ManageEmployeesPnl.Controls.Add(Me.EmployeeDGV)
        Me.ManageEmployeesPnl.Controls.Add(Me.ResetBtn)
        Me.ManageEmployeesPnl.Controls.Add(Me.ERemoveBtn)
        Me.ManageEmployeesPnl.Controls.Add(Me.EUpdateBtn)
        Me.ManageEmployeesPnl.Controls.Add(Me.EAddBtn)
        Me.ManageEmployeesPnl.Controls.Add(Me.ELNameTb)
        Me.ManageEmployeesPnl.Controls.Add(Me.ELNameLbl)
        Me.ManageEmployeesPnl.Controls.Add(Me.EAddressTb)
        Me.ManageEmployeesPnl.Controls.Add(Me.EContactLbl)
        Me.ManageEmployeesPnl.Controls.Add(Me.EContactTb)
        Me.ManageEmployeesPnl.Controls.Add(Me.EPostLbl)
        Me.ManageEmployeesPnl.Controls.Add(Me.EPostTb)
        Me.ManageEmployeesPnl.Controls.Add(Me.EAddressLbl)
        Me.ManageEmployeesPnl.Controls.Add(Me.EFNameTb)
        Me.ManageEmployeesPnl.Controls.Add(Me.EFNameLbl)
        Me.ManageEmployeesPnl.Controls.Add(Me.ManageEmployeesLbl)
        Me.ManageEmployeesPnl.Location = New System.Drawing.Point(172, 37)
        Me.ManageEmployeesPnl.Name = "ManageEmployeesPnl"
        Me.ManageEmployeesPnl.Size = New System.Drawing.Size(840, 527)
        Me.ManageEmployeesPnl.TabIndex = 56
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeDGV.ColumnHeadersHeight = 30
        Me.EmployeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.PostDataGridViewTextBoxColumn})
        Me.EmployeeDGV.DataSource = Me.UspViewEmployeesBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(15, 198)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowTemplate.Height = 30
        Me.EmployeeDGV.RowTemplate.ReadOnly = True
        Me.EmployeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.Size = New System.Drawing.Size(809, 317)
        Me.EmployeeDGV.TabIndex = 44
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.EmployeeDGV.ThemeStyle.ReadOnly = True
        Me.EmployeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmployeeDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.RowsStyle.Height = 30
        Me.EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'EmpIdDataGridViewTextBoxColumn
        '
        Me.EmpIdDataGridViewTextBoxColumn.DataPropertyName = "Emp Id"
        Me.EmpIdDataGridViewTextBoxColumn.FillWeight = 60.9137!
        Me.EmpIdDataGridViewTextBoxColumn.HeaderText = "Emp Id"
        Me.EmpIdDataGridViewTextBoxColumn.Name = "EmpIdDataGridViewTextBoxColumn"
        Me.EmpIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.FillWeight = 107.8173!
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.FillWeight = 107.8173!
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PostDataGridViewTextBoxColumn
        '
        Me.PostDataGridViewTextBoxColumn.DataPropertyName = "Post"
        Me.PostDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.PostDataGridViewTextBoxColumn.HeaderText = "Post"
        Me.PostDataGridViewTextBoxColumn.Name = "PostDataGridViewTextBoxColumn"
        Me.PostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspViewEmployeesBindingSource1
        '
        Me.UspViewEmployeesBindingSource1.DataMember = "Usp_View_Employees"
        Me.UspViewEmployeesBindingSource1.DataSource = Me.SpaMgtSysDataSet1
        '
        'SpaMgtSysDataSet1
        '
        Me.SpaMgtSysDataSet1.DataSetName = "SpaMgtSysDataSet1"
        Me.SpaMgtSysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(659, 100)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(165, 39)
        Me.ResetBtn.TabIndex = 43
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ERemoveBtn
        '
        Me.ERemoveBtn.BackColor = System.Drawing.Color.Yellow
        Me.ERemoveBtn.FlatAppearance.BorderSize = 0
        Me.ERemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ERemoveBtn.Location = New System.Drawing.Point(606, 147)
        Me.ERemoveBtn.Name = "ERemoveBtn"
        Me.ERemoveBtn.Size = New System.Drawing.Size(184, 39)
        Me.ERemoveBtn.TabIndex = 41
        Me.ERemoveBtn.Text = "Remove Employee"
        Me.ERemoveBtn.UseVisualStyleBackColor = False
        '
        'EUpdateBtn
        '
        Me.EUpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.EUpdateBtn.FlatAppearance.BorderSize = 0
        Me.EUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EUpdateBtn.Location = New System.Drawing.Point(362, 147)
        Me.EUpdateBtn.Name = "EUpdateBtn"
        Me.EUpdateBtn.Size = New System.Drawing.Size(184, 39)
        Me.EUpdateBtn.TabIndex = 40
        Me.EUpdateBtn.Text = "Edit Info"
        Me.EUpdateBtn.UseVisualStyleBackColor = False
        '
        'EAddBtn
        '
        Me.EAddBtn.BackColor = System.Drawing.Color.Yellow
        Me.EAddBtn.FlatAppearance.BorderSize = 0
        Me.EAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EAddBtn.Location = New System.Drawing.Point(132, 147)
        Me.EAddBtn.Name = "EAddBtn"
        Me.EAddBtn.Size = New System.Drawing.Size(184, 39)
        Me.EAddBtn.TabIndex = 39
        Me.EAddBtn.Text = "Add Employee"
        Me.EAddBtn.UseVisualStyleBackColor = False
        '
        'ELNameTb
        '
        Me.ELNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ELNameTb.Location = New System.Drawing.Point(132, 97)
        Me.ELNameTb.Name = "ELNameTb"
        Me.ELNameTb.Size = New System.Drawing.Size(181, 33)
        Me.ELNameTb.TabIndex = 37
        '
        'ELNameLbl
        '
        Me.ELNameLbl.AutoSize = True
        Me.ELNameLbl.Location = New System.Drawing.Point(22, 100)
        Me.ELNameLbl.Name = "ELNameLbl"
        Me.ELNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.ELNameLbl.TabIndex = 36
        Me.ELNameLbl.Text = "Last Name:"
        '
        'EAddressTb
        '
        Me.EAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EAddressTb.Location = New System.Drawing.Point(410, 58)
        Me.EAddressTb.Name = "EAddressTb"
        Me.EAddressTb.Size = New System.Drawing.Size(181, 33)
        Me.EAddressTb.TabIndex = 35
        '
        'EContactLbl
        '
        Me.EContactLbl.AutoSize = True
        Me.EContactLbl.Location = New System.Drawing.Point(323, 100)
        Me.EContactLbl.Name = "EContactLbl"
        Me.EContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.EContactLbl.TabIndex = 34
        Me.EContactLbl.Text = "Contact:"
        '
        'EContactTb
        '
        Me.EContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EContactTb.Location = New System.Drawing.Point(410, 97)
        Me.EContactTb.Name = "EContactTb"
        Me.EContactTb.Size = New System.Drawing.Size(181, 33)
        Me.EContactTb.TabIndex = 33
        '
        'EPostLbl
        '
        Me.EPostLbl.AutoSize = True
        Me.EPostLbl.Location = New System.Drawing.Point(601, 61)
        Me.EPostLbl.Name = "EPostLbl"
        Me.EPostLbl.Size = New System.Drawing.Size(52, 25)
        Me.EPostLbl.TabIndex = 32
        Me.EPostLbl.Text = "Post:"
        '
        'EPostTb
        '
        Me.EPostTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EPostTb.Location = New System.Drawing.Point(659, 58)
        Me.EPostTb.Name = "EPostTb"
        Me.EPostTb.Size = New System.Drawing.Size(165, 33)
        Me.EPostTb.TabIndex = 31
        '
        'EAddressLbl
        '
        Me.EAddressLbl.AutoSize = True
        Me.EAddressLbl.Location = New System.Drawing.Point(321, 61)
        Me.EAddressLbl.Name = "EAddressLbl"
        Me.EAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.EAddressLbl.TabIndex = 30
        Me.EAddressLbl.Text = "Address:"
        '
        'EFNameTb
        '
        Me.EFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFNameTb.Location = New System.Drawing.Point(132, 58)
        Me.EFNameTb.Name = "EFNameTb"
        Me.EFNameTb.Size = New System.Drawing.Size(181, 33)
        Me.EFNameTb.TabIndex = 29
        '
        'EFNameLbl
        '
        Me.EFNameLbl.AutoSize = True
        Me.EFNameLbl.Location = New System.Drawing.Point(20, 61)
        Me.EFNameLbl.Name = "EFNameLbl"
        Me.EFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.EFNameLbl.TabIndex = 28
        Me.EFNameLbl.Text = "First Name:"
        '
        'ManageEmployeesLbl
        '
        Me.ManageEmployeesLbl.AutoSize = True
        Me.ManageEmployeesLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageEmployeesLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ManageEmployeesLbl.Location = New System.Drawing.Point(345, 4)
        Me.ManageEmployeesLbl.Name = "ManageEmployeesLbl"
        Me.ManageEmployeesLbl.Size = New System.Drawing.Size(179, 25)
        Me.ManageEmployeesLbl.TabIndex = 27
        Me.ManageEmployeesLbl.Text = "Manage Employees"
        '
        'UspViewEmployeesBindingSource
        '
        Me.UspViewEmployeesBindingSource.DataMember = "Usp_View_Employees"
        '
        'SmsPb
        '
        Me.SmsPb.Image = CType(resources.GetObject("SmsPb.Image"), System.Drawing.Image)
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 60
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 19
        Me.ExitPb.TabStop = False
        '
        'Usp_View_EmployeesTableAdapter1
        '
        Me.Usp_View_EmployeesTableAdapter1.ClearBeforeFill = True
        '
        'ManageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.ManageUsersBtn)
        Me.Controls.Add(Me.ViewStatisticsBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ViewCustomerInfoBtn)
        Me.Controls.Add(Me.ViewTransactionsBtn)
        Me.Controls.Add(Me.ManageServicesBtn)
        Me.Controls.Add(Me.ManageEmployeesPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ManageEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageEmployees"
        Me.ManageEmployeesPnl.ResumeLayout(False)
        Me.ManageEmployeesPnl.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ViewCustomerInfoBtn As Button
    Friend WithEvents ViewTransactionsBtn As Button
    Friend WithEvents ManageServicesBtn As Button
    Friend WithEvents ManageEmployeesPnl As Panel
    Friend WithEvents ManageEmployeesLbl As Label
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
    Friend WithEvents EAddBtn As Button
    Friend WithEvents EUpdateBtn As Button
    Friend WithEvents ERemoveBtn As Button
    Friend WithEvents UspViewEmployeesBindingSource As BindingSource
    Friend WithEvents ResetBtn As Button
    Friend WithEvents SpaMgtSysDataSet1 As SpaMgtSysDataSet1
    Friend WithEvents UspViewEmployeesBindingSource1 As BindingSource
    Friend WithEvents Usp_View_EmployeesTableAdapter1 As SpaMgtSysDataSet1TableAdapters.Usp_View_EmployeesTableAdapter
    Friend WithEvents EmployeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EmpIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
