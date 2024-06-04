<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsers))
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsBtn = New System.Windows.Forms.Button()
        Me.ManageServicesBtn = New System.Windows.Forms.Button()
        Me.ManageUsersPnl = New System.Windows.Forms.Panel()
        Me.UsrNameTb = New System.Windows.Forms.TextBox()
        Me.UsrNameLbl = New System.Windows.Forms.Label()
        Me.UsersDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspViewUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet = New SPA_Management_System.SpaMgtSysDataSet()
        Me.UConPasswdChkB = New System.Windows.Forms.CheckBox()
        Me.UPasswdChkB = New System.Windows.Forms.CheckBox()
        Me.UPasswdTb = New System.Windows.Forms.TextBox()
        Me.UPasswdLbl = New System.Windows.Forms.Label()
        Me.UConfirmPasswdTb = New System.Windows.Forms.TextBox()
        Me.UConfirmPasswdLbl = New System.Windows.Forms.Label()
        Me.UType = New System.Windows.Forms.CheckBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ManageUsersLbl = New System.Windows.Forms.Label()
        Me.URemoveBtn = New System.Windows.Forms.Button()
        Me.UFNameLbl = New System.Windows.Forms.Label()
        Me.UUpdateBtn = New System.Windows.Forms.Button()
        Me.UFNameTb = New System.Windows.Forms.TextBox()
        Me.UAddBtn = New System.Windows.Forms.Button()
        Me.UAddressLbl = New System.Windows.Forms.Label()
        Me.ULNameTb = New System.Windows.Forms.TextBox()
        Me.ELNameLbl = New System.Windows.Forms.Label()
        Me.UAddressTb = New System.Windows.Forms.TextBox()
        Me.UContactTb = New System.Windows.Forms.TextBox()
        Me.EContactLbl = New System.Windows.Forms.Label()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.Usp_View_UsersTableAdapter = New SPA_Management_System.SpaMgtSysDataSetTableAdapters.Usp_View_UsersTableAdapter()
        Me.ManageUsersPnl.SuspendLayout()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManageEmployeesBtn
        '
        Me.ManageEmployeesBtn.BackColor = System.Drawing.Color.LightGray
        Me.ManageEmployeesBtn.FlatAppearance.BorderSize = 0
        Me.ManageEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageEmployeesBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageEmployeesBtn.Location = New System.Drawing.Point(12, 333)
        Me.ManageEmployeesBtn.Name = "ManageEmployeesBtn"
        Me.ManageEmployeesBtn.Size = New System.Drawing.Size(154, 63)
        Me.ManageEmployeesBtn.TabIndex = 55
        Me.ManageEmployeesBtn.Text = "Manage Employees"
        Me.ManageEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageEmployeesBtn.UseVisualStyleBackColor = False
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
        Me.ViewStatisticsBtn.TabIndex = 54
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
        Me.LogoutLbl.TabIndex = 53
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
        Me.ViewCustomerInfoBtn.TabIndex = 51
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
        Me.ViewTransactionsBtn.TabIndex = 50
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
        Me.ManageServicesBtn.TabIndex = 49
        Me.ManageServicesBtn.Text = "Manage Services"
        Me.ManageServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageServicesBtn.UseVisualStyleBackColor = False
        '
        'ManageUsersPnl
        '
        Me.ManageUsersPnl.BackColor = System.Drawing.Color.White
        Me.ManageUsersPnl.Controls.Add(Me.UsrNameTb)
        Me.ManageUsersPnl.Controls.Add(Me.UsrNameLbl)
        Me.ManageUsersPnl.Controls.Add(Me.UsersDGV)
        Me.ManageUsersPnl.Controls.Add(Me.UConPasswdChkB)
        Me.ManageUsersPnl.Controls.Add(Me.UPasswdChkB)
        Me.ManageUsersPnl.Controls.Add(Me.UPasswdTb)
        Me.ManageUsersPnl.Controls.Add(Me.UPasswdLbl)
        Me.ManageUsersPnl.Controls.Add(Me.UConfirmPasswdTb)
        Me.ManageUsersPnl.Controls.Add(Me.UConfirmPasswdLbl)
        Me.ManageUsersPnl.Controls.Add(Me.UType)
        Me.ManageUsersPnl.Controls.Add(Me.ResetBtn)
        Me.ManageUsersPnl.Controls.Add(Me.ManageUsersLbl)
        Me.ManageUsersPnl.Controls.Add(Me.URemoveBtn)
        Me.ManageUsersPnl.Controls.Add(Me.UFNameLbl)
        Me.ManageUsersPnl.Controls.Add(Me.UUpdateBtn)
        Me.ManageUsersPnl.Controls.Add(Me.UFNameTb)
        Me.ManageUsersPnl.Controls.Add(Me.UAddBtn)
        Me.ManageUsersPnl.Controls.Add(Me.UAddressLbl)
        Me.ManageUsersPnl.Controls.Add(Me.ULNameTb)
        Me.ManageUsersPnl.Controls.Add(Me.ELNameLbl)
        Me.ManageUsersPnl.Controls.Add(Me.UAddressTb)
        Me.ManageUsersPnl.Controls.Add(Me.UContactTb)
        Me.ManageUsersPnl.Controls.Add(Me.EContactLbl)
        Me.ManageUsersPnl.Location = New System.Drawing.Point(172, 37)
        Me.ManageUsersPnl.Name = "ManageUsersPnl"
        Me.ManageUsersPnl.Size = New System.Drawing.Size(840, 527)
        Me.ManageUsersPnl.TabIndex = 48
        '
        'UsrNameTb
        '
        Me.UsrNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsrNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrNameTb.Location = New System.Drawing.Point(110, 108)
        Me.UsrNameTb.Name = "UsrNameTb"
        Me.UsrNameTb.Size = New System.Drawing.Size(169, 29)
        Me.UsrNameTb.TabIndex = 80
        '
        'UsrNameLbl
        '
        Me.UsrNameLbl.AutoSize = True
        Me.UsrNameLbl.Location = New System.Drawing.Point(5, 111)
        Me.UsrNameLbl.Name = "UsrNameLbl"
        Me.UsrNameLbl.Size = New System.Drawing.Size(109, 25)
        Me.UsrNameLbl.TabIndex = 79
        Me.UsrNameLbl.Text = "User Name:"
        '
        'UsersDGV
        '
        Me.UsersDGV.AllowUserToAddRows = False
        Me.UsersDGV.AllowUserToDeleteRows = False
        Me.UsersDGV.AllowUserToResizeColumns = False
        Me.UsersDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.UsersDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UsersDGV.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UsersDGV.ColumnHeadersHeight = 52
        Me.UsersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.AdminDataGridViewCheckBoxColumn})
        Me.UsersDGV.DataSource = Me.UspViewUsersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.Location = New System.Drawing.Point(285, 33)
        Me.UsersDGV.Name = "UsersDGV"
        Me.UsersDGV.ReadOnly = True
        Me.UsersDGV.RowHeadersVisible = False
        Me.UsersDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersDGV.RowTemplate.Height = 30
        Me.UsersDGV.RowTemplate.ReadOnly = True
        Me.UsersDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.Size = New System.Drawing.Size(552, 491)
        Me.UsersDGV.TabIndex = 78
        Me.UsersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.UsersDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UsersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.UsersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UsersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UsersDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.UsersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UsersDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.UsersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.UsersDGV.ThemeStyle.HeaderStyle.Height = 52
        Me.UsersDGV.ThemeStyle.ReadOnly = True
        Me.UsersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.UsersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UsersDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UsersDGV.ThemeStyle.RowsStyle.Height = 30
        Me.UsersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminDataGridViewCheckBoxColumn
        '
        Me.AdminDataGridViewCheckBoxColumn.DataPropertyName = "Admin"
        Me.AdminDataGridViewCheckBoxColumn.FillWeight = 65.0!
        Me.AdminDataGridViewCheckBoxColumn.HeaderText = "Admin"
        Me.AdminDataGridViewCheckBoxColumn.Name = "AdminDataGridViewCheckBoxColumn"
        Me.AdminDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'UspViewUsersBindingSource
        '
        Me.UspViewUsersBindingSource.DataMember = "Usp_View_Users"
        Me.UspViewUsersBindingSource.DataSource = Me.SpaMgtSysDataSet
        '
        'SpaMgtSysDataSet
        '
        Me.SpaMgtSysDataSet.DataSetName = "SpaMgtSysDataSet"
        Me.SpaMgtSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UConPasswdChkB
        '
        Me.UConPasswdChkB.AutoSize = True
        Me.UConPasswdChkB.Location = New System.Drawing.Point(265, 269)
        Me.UConPasswdChkB.Name = "UConPasswdChkB"
        Me.UConPasswdChkB.Size = New System.Drawing.Size(15, 14)
        Me.UConPasswdChkB.TabIndex = 77
        Me.UConPasswdChkB.UseVisualStyleBackColor = True
        '
        'UPasswdChkB
        '
        Me.UPasswdChkB.AutoSize = True
        Me.UPasswdChkB.Location = New System.Drawing.Point(265, 234)
        Me.UPasswdChkB.Name = "UPasswdChkB"
        Me.UPasswdChkB.Size = New System.Drawing.Size(15, 14)
        Me.UPasswdChkB.TabIndex = 76
        Me.UPasswdChkB.UseVisualStyleBackColor = True
        '
        'UPasswdTb
        '
        Me.UPasswdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UPasswdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPasswdTb.Location = New System.Drawing.Point(110, 226)
        Me.UPasswdTb.MaxLength = 49
        Me.UPasswdTb.Name = "UPasswdTb"
        Me.UPasswdTb.Size = New System.Drawing.Size(151, 29)
        Me.UPasswdTb.TabIndex = 75
        '
        'UPasswdLbl
        '
        Me.UPasswdLbl.AutoSize = True
        Me.UPasswdLbl.Location = New System.Drawing.Point(13, 230)
        Me.UPasswdLbl.Name = "UPasswdLbl"
        Me.UPasswdLbl.Size = New System.Drawing.Size(96, 25)
        Me.UPasswdLbl.TabIndex = 74
        Me.UPasswdLbl.Text = "Password:"
        '
        'UConfirmPasswdTb
        '
        Me.UConfirmPasswdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UConfirmPasswdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UConfirmPasswdTb.Location = New System.Drawing.Point(110, 261)
        Me.UConfirmPasswdTb.MaxLength = 49
        Me.UConfirmPasswdTb.Name = "UConfirmPasswdTb"
        Me.UConfirmPasswdTb.Size = New System.Drawing.Size(151, 29)
        Me.UConfirmPasswdTb.TabIndex = 72
        '
        'UConfirmPasswdLbl
        '
        Me.UConfirmPasswdLbl.AutoSize = True
        Me.UConfirmPasswdLbl.Location = New System.Drawing.Point(30, 264)
        Me.UConfirmPasswdLbl.Name = "UConfirmPasswdLbl"
        Me.UConfirmPasswdLbl.Size = New System.Drawing.Size(83, 25)
        Me.UConfirmPasswdLbl.TabIndex = 73
        Me.UConfirmPasswdLbl.Text = "Confirm:"
        '
        'UType
        '
        Me.UType.AutoSize = True
        Me.UType.Location = New System.Drawing.Point(139, 296)
        Me.UType.Name = "UType"
        Me.UType.Size = New System.Drawing.Size(104, 29)
        Me.UType.TabIndex = 71
        Me.UType.Text = "Is Admin"
        Me.UType.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(35, 296)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(71, 39)
        Me.ResetBtn.TabIndex = 69
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ManageUsersLbl
        '
        Me.ManageUsersLbl.AutoSize = True
        Me.ManageUsersLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ManageUsersLbl.Location = New System.Drawing.Point(361, 4)
        Me.ManageUsersLbl.Name = "ManageUsersLbl"
        Me.ManageUsersLbl.Size = New System.Drawing.Size(133, 25)
        Me.ManageUsersLbl.TabIndex = 56
        Me.ManageUsersLbl.Text = "Manage Users"
        '
        'URemoveBtn
        '
        Me.URemoveBtn.BackColor = System.Drawing.Color.Yellow
        Me.URemoveBtn.FlatAppearance.BorderSize = 0
        Me.URemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.URemoveBtn.Location = New System.Drawing.Point(35, 431)
        Me.URemoveBtn.Name = "URemoveBtn"
        Me.URemoveBtn.Size = New System.Drawing.Size(184, 39)
        Me.URemoveBtn.TabIndex = 68
        Me.URemoveBtn.Text = "Remove User"
        Me.URemoveBtn.UseVisualStyleBackColor = False
        '
        'UFNameLbl
        '
        Me.UFNameLbl.AutoSize = True
        Me.UFNameLbl.Location = New System.Drawing.Point(3, 33)
        Me.UFNameLbl.Name = "UFNameLbl"
        Me.UFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.UFNameLbl.TabIndex = 56
        Me.UFNameLbl.Text = "First Name:"
        '
        'UUpdateBtn
        '
        Me.UUpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.UUpdateBtn.FlatAppearance.BorderSize = 0
        Me.UUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UUpdateBtn.Location = New System.Drawing.Point(35, 386)
        Me.UUpdateBtn.Name = "UUpdateBtn"
        Me.UUpdateBtn.Size = New System.Drawing.Size(184, 39)
        Me.UUpdateBtn.TabIndex = 67
        Me.UUpdateBtn.Text = "Edit Info"
        Me.UUpdateBtn.UseVisualStyleBackColor = False
        '
        'UFNameTb
        '
        Me.UFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UFNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFNameTb.Location = New System.Drawing.Point(110, 31)
        Me.UFNameTb.Name = "UFNameTb"
        Me.UFNameTb.Size = New System.Drawing.Size(169, 29)
        Me.UFNameTb.TabIndex = 57
        '
        'UAddBtn
        '
        Me.UAddBtn.BackColor = System.Drawing.Color.Yellow
        Me.UAddBtn.FlatAppearance.BorderSize = 0
        Me.UAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UAddBtn.Location = New System.Drawing.Point(35, 341)
        Me.UAddBtn.Name = "UAddBtn"
        Me.UAddBtn.Size = New System.Drawing.Size(184, 39)
        Me.UAddBtn.TabIndex = 66
        Me.UAddBtn.Text = "Add User"
        Me.UAddBtn.UseVisualStyleBackColor = False
        '
        'UAddressLbl
        '
        Me.UAddressLbl.AutoSize = True
        Me.UAddressLbl.Location = New System.Drawing.Point(26, 150)
        Me.UAddressLbl.Name = "UAddressLbl"
        Me.UAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.UAddressLbl.TabIndex = 58
        Me.UAddressLbl.Text = "Address:"
        '
        'ULNameTb
        '
        Me.ULNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ULNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULNameTb.Location = New System.Drawing.Point(110, 69)
        Me.ULNameTb.Name = "ULNameTb"
        Me.ULNameTb.Size = New System.Drawing.Size(169, 29)
        Me.ULNameTb.TabIndex = 65
        '
        'ELNameLbl
        '
        Me.ELNameLbl.AutoSize = True
        Me.ELNameLbl.Location = New System.Drawing.Point(5, 72)
        Me.ELNameLbl.Name = "ELNameLbl"
        Me.ELNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.ELNameLbl.TabIndex = 64
        Me.ELNameLbl.Text = "Last Name:"
        '
        'UAddressTb
        '
        Me.UAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UAddressTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAddressTb.Location = New System.Drawing.Point(110, 147)
        Me.UAddressTb.Name = "UAddressTb"
        Me.UAddressTb.Size = New System.Drawing.Size(169, 29)
        Me.UAddressTb.TabIndex = 63
        '
        'UContactTb
        '
        Me.UContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UContactTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UContactTb.Location = New System.Drawing.Point(110, 186)
        Me.UContactTb.Name = "UContactTb"
        Me.UContactTb.Size = New System.Drawing.Size(169, 29)
        Me.UContactTb.TabIndex = 61
        '
        'EContactLbl
        '
        Me.EContactLbl.AutoSize = True
        Me.EContactLbl.Location = New System.Drawing.Point(28, 189)
        Me.EContactLbl.Name = "EContactLbl"
        Me.EContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.EContactLbl.TabIndex = 62
        Me.EContactLbl.Text = "Contact:"
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 52
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 18
        Me.ExitPb.TabStop = False
        '
        'Usp_View_UsersTableAdapter
        '
        Me.Usp_View_UsersTableAdapter.ClearBeforeFill = True
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.ManageEmployeesBtn)
        Me.Controls.Add(Me.ViewStatisticsBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ViewCustomerInfoBtn)
        Me.Controls.Add(Me.ViewTransactionsBtn)
        Me.Controls.Add(Me.ManageServicesBtn)
        Me.Controls.Add(Me.ManageUsersPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageUsers"
        Me.ManageUsersPnl.ResumeLayout(False)
        Me.ManageUsersPnl.PerformLayout()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents ManageEmployeesBtn As Button
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ViewCustomerInfoBtn As Button
    Friend WithEvents ViewTransactionsBtn As Button
    Friend WithEvents ManageServicesBtn As Button
    Friend WithEvents ManageUsersPnl As Panel
    Friend WithEvents ManageUsersLbl As Label
    Friend WithEvents UType As CheckBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents URemoveBtn As Button
    Friend WithEvents UFNameLbl As Label
    Friend WithEvents UUpdateBtn As Button
    Friend WithEvents UFNameTb As TextBox
    Friend WithEvents UAddBtn As Button
    Friend WithEvents UAddressLbl As Label
    Friend WithEvents ULNameTb As TextBox
    Friend WithEvents ELNameLbl As Label
    Friend WithEvents UAddressTb As TextBox
    Friend WithEvents UContactTb As TextBox
    Friend WithEvents EContactLbl As Label
    Friend WithEvents UPasswdTb As TextBox
    Friend WithEvents UPasswdLbl As Label
    Friend WithEvents UConfirmPasswdTb As TextBox
    Friend WithEvents UConfirmPasswdLbl As Label
    Friend WithEvents SpaMgtSysDataSet As SpaMgtSysDataSet
    Friend WithEvents UspViewUsersBindingSource As BindingSource
    Friend WithEvents Usp_View_UsersTableAdapter As SpaMgtSysDataSetTableAdapters.Usp_View_UsersTableAdapter
    Friend WithEvents UConPasswdChkB As CheckBox
    Friend WithEvents UPasswdChkB As CheckBox
    Friend WithEvents UsersDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents UsrNameTb As TextBox
    Friend WithEvents UsrNameLbl As Label
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
