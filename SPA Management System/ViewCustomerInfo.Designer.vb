<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewCustomerInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCustomerInfo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsBtn = New System.Windows.Forms.Button()
        Me.ManageServicesBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoPnl = New System.Windows.Forms.Panel()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoLbl = New System.Windows.Forms.Label()
        Me.CRemoveBtn = New System.Windows.Forms.Button()
        Me.CFNameLbl = New System.Windows.Forms.Label()
        Me.CUpdateBtn = New System.Windows.Forms.Button()
        Me.CFNameTb = New System.Windows.Forms.TextBox()
        Me.CAddressLbl = New System.Windows.Forms.Label()
        Me.CLNameTb = New System.Windows.Forms.TextBox()
        Me.CLNameLbl = New System.Windows.Forms.Label()
        Me.CAddressTb = New System.Windows.Forms.TextBox()
        Me.CContactTb = New System.Windows.Forms.TextBox()
        Me.CContactLbl = New System.Windows.Forms.Label()
        Me.UspViewCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.SpaMgtSysDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewCustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet3 = New SPA_Management_System.SpaMgtSysDataSet3()
        Me.Usp_View_CustomersTableAdapter1 = New SPA_Management_System.SpaMgtSysDataSet3TableAdapters.Usp_View_CustomersTableAdapter()
        Me.ViewCustomerInfoPnl.SuspendLayout()
        CType(Me.UspViewCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewCustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ManageEmployeesBtn.TabIndex = 47
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
        Me.ViewStatisticsBtn.TabIndex = 46
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
        Me.LogoutLbl.TabIndex = 45
        Me.LogoutLbl.Text = "Logout"
        '
        'ManageUsersBtn
        '
        Me.ManageUsersBtn.BackColor = System.Drawing.Color.LightGray
        Me.ManageUsersBtn.FlatAppearance.BorderSize = 0
        Me.ManageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageUsersBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersBtn.Location = New System.Drawing.Point(12, 255)
        Me.ManageUsersBtn.Name = "ManageUsersBtn"
        Me.ManageUsersBtn.Size = New System.Drawing.Size(154, 63)
        Me.ManageUsersBtn.TabIndex = 43
        Me.ManageUsersBtn.Text = "Manage Users"
        Me.ManageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageUsersBtn.UseVisualStyleBackColor = False
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
        Me.ViewTransactionsBtn.TabIndex = 42
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
        Me.ManageServicesBtn.TabIndex = 41
        Me.ManageServicesBtn.Text = "Manage Services"
        Me.ManageServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageServicesBtn.UseVisualStyleBackColor = False
        '
        'ViewCustomerInfoPnl
        '
        Me.ViewCustomerInfoPnl.BackColor = System.Drawing.Color.White
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CustomersDGV)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.ResetBtn)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.ViewCustomerInfoLbl)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CRemoveBtn)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CFNameLbl)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CUpdateBtn)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CFNameTb)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CAddressLbl)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CLNameTb)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CLNameLbl)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CAddressTb)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CContactTb)
        Me.ViewCustomerInfoPnl.Controls.Add(Me.CContactLbl)
        Me.ViewCustomerInfoPnl.Location = New System.Drawing.Point(172, 37)
        Me.ViewCustomerInfoPnl.Name = "ViewCustomerInfoPnl"
        Me.ViewCustomerInfoPnl.Size = New System.Drawing.Size(840, 527)
        Me.ViewCustomerInfoPnl.TabIndex = 40
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(644, 64)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(165, 39)
        Me.ResetBtn.TabIndex = 61
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ViewCustomerInfoLbl
        '
        Me.ViewCustomerInfoLbl.AutoSize = True
        Me.ViewCustomerInfoLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCustomerInfoLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ViewCustomerInfoLbl.Location = New System.Drawing.Point(366, 4)
        Me.ViewCustomerInfoLbl.Name = "ViewCustomerInfoLbl"
        Me.ViewCustomerInfoLbl.Size = New System.Drawing.Size(135, 25)
        Me.ViewCustomerInfoLbl.TabIndex = 57
        Me.ViewCustomerInfoLbl.Text = "Customer Info"
        '
        'CRemoveBtn
        '
        Me.CRemoveBtn.BackColor = System.Drawing.Color.Yellow
        Me.CRemoveBtn.FlatAppearance.BorderSize = 0
        Me.CRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CRemoveBtn.Location = New System.Drawing.Point(399, 118)
        Me.CRemoveBtn.Name = "CRemoveBtn"
        Me.CRemoveBtn.Size = New System.Drawing.Size(184, 39)
        Me.CRemoveBtn.TabIndex = 60
        Me.CRemoveBtn.Text = "Remove Customer"
        Me.CRemoveBtn.UseVisualStyleBackColor = False
        '
        'CFNameLbl
        '
        Me.CFNameLbl.AutoSize = True
        Me.CFNameLbl.Location = New System.Drawing.Point(22, 48)
        Me.CFNameLbl.Name = "CFNameLbl"
        Me.CFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.CFNameLbl.TabIndex = 48
        Me.CFNameLbl.Text = "First Name:"
        '
        'CUpdateBtn
        '
        Me.CUpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.CUpdateBtn.FlatAppearance.BorderSize = 0
        Me.CUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CUpdateBtn.Location = New System.Drawing.Point(195, 118)
        Me.CUpdateBtn.Name = "CUpdateBtn"
        Me.CUpdateBtn.Size = New System.Drawing.Size(184, 39)
        Me.CUpdateBtn.TabIndex = 59
        Me.CUpdateBtn.Text = "Edit Info"
        Me.CUpdateBtn.UseVisualStyleBackColor = False
        '
        'CFNameTb
        '
        Me.CFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CFNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFNameTb.Location = New System.Drawing.Point(134, 44)
        Me.CFNameTb.Name = "CFNameTb"
        Me.CFNameTb.Size = New System.Drawing.Size(181, 29)
        Me.CFNameTb.TabIndex = 49
        '
        'CAddressLbl
        '
        Me.CAddressLbl.AutoSize = True
        Me.CAddressLbl.Location = New System.Drawing.Point(342, 47)
        Me.CAddressLbl.Name = "CAddressLbl"
        Me.CAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.CAddressLbl.TabIndex = 50
        Me.CAddressLbl.Text = "Address:"
        '
        'CLNameTb
        '
        Me.CLNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CLNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLNameTb.Location = New System.Drawing.Point(134, 83)
        Me.CLNameTb.Name = "CLNameTb"
        Me.CLNameTb.Size = New System.Drawing.Size(181, 29)
        Me.CLNameTb.TabIndex = 57
        '
        'CLNameLbl
        '
        Me.CLNameLbl.AutoSize = True
        Me.CLNameLbl.Location = New System.Drawing.Point(24, 87)
        Me.CLNameLbl.Name = "CLNameLbl"
        Me.CLNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.CLNameLbl.TabIndex = 56
        Me.CLNameLbl.Text = "Last Name:"
        '
        'CAddressTb
        '
        Me.CAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CAddressTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAddressTb.Location = New System.Drawing.Point(431, 45)
        Me.CAddressTb.Name = "CAddressTb"
        Me.CAddressTb.Size = New System.Drawing.Size(181, 29)
        Me.CAddressTb.TabIndex = 55
        '
        'CContactTb
        '
        Me.CContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CContactTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CContactTb.Location = New System.Drawing.Point(431, 83)
        Me.CContactTb.Name = "CContactTb"
        Me.CContactTb.Size = New System.Drawing.Size(181, 29)
        Me.CContactTb.TabIndex = 53
        '
        'CContactLbl
        '
        Me.CContactLbl.AutoSize = True
        Me.CContactLbl.Location = New System.Drawing.Point(344, 85)
        Me.CContactLbl.Name = "CContactLbl"
        Me.CContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.CContactLbl.TabIndex = 54
        Me.CContactLbl.Text = "Contact:"
        '
        'UspViewCustomersBindingSource
        '
        Me.UspViewCustomersBindingSource.DataMember = "Usp_View_Customers"
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 44
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 17
        Me.ExitPb.TabStop = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CustomersDGV
        '
        Me.CustomersDGV.AllowUserToAddRows = False
        Me.CustomersDGV.AllowUserToDeleteRows = False
        Me.CustomersDGV.AllowUserToResizeColumns = False
        Me.CustomersDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CustomersDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomersDGV.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomersDGV.ColumnHeadersHeight = 30
        Me.CustomersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AdddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn})
        Me.CustomersDGV.DataSource = Me.UspViewCustomersBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomersDGV.Location = New System.Drawing.Point(14, 163)
        Me.CustomersDGV.Name = "CustomersDGV"
        Me.CustomersDGV.ReadOnly = True
        Me.CustomersDGV.RowHeadersVisible = False
        Me.CustomersDGV.RowTemplate.Height = 30
        Me.CustomersDGV.RowTemplate.ReadOnly = True
        Me.CustomersDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersDGV.Size = New System.Drawing.Size(814, 274)
        Me.CustomersDGV.TabIndex = 63
        Me.CustomersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomersDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CustomersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CustomersDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomersDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CustomersDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.CustomersDGV.ThemeStyle.ReadOnly = True
        Me.CustomersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomersDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CustomersDGV.ThemeStyle.RowsStyle.Height = 30
        Me.CustomersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
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
        'AdddressDataGridViewTextBoxColumn
        '
        Me.AdddressDataGridViewTextBoxColumn.DataPropertyName = "Adddress"
        Me.AdddressDataGridViewTextBoxColumn.HeaderText = "Adddress"
        Me.AdddressDataGridViewTextBoxColumn.Name = "AdddressDataGridViewTextBoxColumn"
        Me.AdddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspViewCustomersBindingSource1
        '
        Me.UspViewCustomersBindingSource1.DataMember = "Usp_View_Customers"
        Me.UspViewCustomersBindingSource1.DataSource = Me.SpaMgtSysDataSet3
        '
        'SpaMgtSysDataSet3
        '
        Me.SpaMgtSysDataSet3.DataSetName = "SpaMgtSysDataSet3"
        Me.SpaMgtSysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_CustomersTableAdapter1
        '
        Me.Usp_View_CustomersTableAdapter1.ClearBeforeFill = True
        '
        'ViewCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.ManageEmployeesBtn)
        Me.Controls.Add(Me.ViewStatisticsBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ManageUsersBtn)
        Me.Controls.Add(Me.ViewTransactionsBtn)
        Me.Controls.Add(Me.ManageServicesBtn)
        Me.Controls.Add(Me.ViewCustomerInfoPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "ViewCustomerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewCustomerInfo"
        Me.ViewCustomerInfoPnl.ResumeLayout(False)
        Me.ViewCustomerInfoPnl.PerformLayout()
        CType(Me.UspViewCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewCustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents ManageEmployeesBtn As Button
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents ViewTransactionsBtn As Button
    Friend WithEvents ManageServicesBtn As Button
    Friend WithEvents ViewCustomerInfoPnl As Panel
    Friend WithEvents ViewCustomerInfoLbl As Label
    Friend WithEvents UspViewCustomersBindingSource As BindingSource
    Friend WithEvents ResetBtn As Button
    Friend WithEvents CRemoveBtn As Button
    Friend WithEvents CFNameLbl As Label
    Friend WithEvents CUpdateBtn As Button
    Friend WithEvents CFNameTb As TextBox
    Friend WithEvents CAddressLbl As Label
    Friend WithEvents CLNameTb As TextBox
    Friend WithEvents CLNameLbl As Label
    Friend WithEvents CAddressTb As TextBox
    Friend WithEvents CContactTb As TextBox
    Friend WithEvents CContactLbl As Label
    Friend WithEvents SpaMgtSysDataSet2BindingSource As BindingSource
    Friend WithEvents SpaMgtSysDataSet3 As SpaMgtSysDataSet3
    Friend WithEvents UspViewCustomersBindingSource1 As BindingSource
    Friend WithEvents Usp_View_CustomersTableAdapter1 As SpaMgtSysDataSet3TableAdapters.Usp_View_CustomersTableAdapter
    Friend WithEvents CustomersDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
