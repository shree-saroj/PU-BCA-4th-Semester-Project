<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanelManageUsers
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
        Me.UFNameLbl = New System.Windows.Forms.Label()
        Me.UFNameTb = New System.Windows.Forms.TextBox()
        Me.UAddressLbl = New System.Windows.Forms.Label()
        Me.UContactTb = New System.Windows.Forms.TextBox()
        Me.EContactLbl = New System.Windows.Forms.Label()
        Me.ULNameTb = New System.Windows.Forms.TextBox()
        Me.ELNameLbl = New System.Windows.Forms.Label()
        Me.UAddressTb = New System.Windows.Forms.TextBox()
        Me.UConfirmPasswdTb = New System.Windows.Forms.TextBox()
        Me.UPasswdTb = New System.Windows.Forms.TextBox()
        Me.UPasswdLbl = New System.Windows.Forms.Label()
        Me.UConfirmPasswdLbl = New System.Windows.Forms.Label()
        Me.UsrNameLbl = New System.Windows.Forms.Label()
        Me.UsrNameTb = New System.Windows.Forms.TextBox()
        Me.UType = New System.Windows.Forms.CheckBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.URemoveBtn = New System.Windows.Forms.Button()
        Me.UUpdateBtn = New System.Windows.Forms.Button()
        Me.UAddBtn = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UsersDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspViewUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet3 = New Spa_Management_System.SpaMgtSysDataSet3()
        Me.Usp_View_UsersTableAdapter = New Spa_Management_System.SpaMgtSysDataSet3TableAdapters.Usp_View_UsersTableAdapter()
        Me.CfrmPasHideShowChkB = New System.Windows.Forms.CheckBox()
        Me.PasHideShowChkB = New System.Windows.Forms.CheckBox()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UFNameLbl
        '
        Me.UFNameLbl.AutoSize = True
        Me.UFNameLbl.Location = New System.Drawing.Point(11, 14)
        Me.UFNameLbl.Name = "UFNameLbl"
        Me.UFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.UFNameLbl.TabIndex = 66
        Me.UFNameLbl.Text = "First Name:"
        '
        'UFNameTb
        '
        Me.UFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UFNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFNameTb.Location = New System.Drawing.Point(126, 14)
        Me.UFNameTb.Name = "UFNameTb"
        Me.UFNameTb.Size = New System.Drawing.Size(169, 29)
        Me.UFNameTb.TabIndex = 67
        '
        'UAddressLbl
        '
        Me.UAddressLbl.AutoSize = True
        Me.UAddressLbl.Location = New System.Drawing.Point(34, 124)
        Me.UAddressLbl.Name = "UAddressLbl"
        Me.UAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.UAddressLbl.TabIndex = 68
        Me.UAddressLbl.Text = "Address:"
        '
        'UContactTb
        '
        Me.UContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UContactTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UContactTb.Location = New System.Drawing.Point(126, 88)
        Me.UContactTb.Name = "UContactTb"
        Me.UContactTb.Size = New System.Drawing.Size(169, 29)
        Me.UContactTb.TabIndex = 69
        '
        'EContactLbl
        '
        Me.EContactLbl.AutoSize = True
        Me.EContactLbl.Location = New System.Drawing.Point(36, 89)
        Me.EContactLbl.Name = "EContactLbl"
        Me.EContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.EContactLbl.TabIndex = 70
        Me.EContactLbl.Text = "Contact:"
        '
        'ULNameTb
        '
        Me.ULNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ULNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULNameTb.Location = New System.Drawing.Point(126, 52)
        Me.ULNameTb.Name = "ULNameTb"
        Me.ULNameTb.Size = New System.Drawing.Size(169, 29)
        Me.ULNameTb.TabIndex = 73
        '
        'ELNameLbl
        '
        Me.ELNameLbl.AutoSize = True
        Me.ELNameLbl.Location = New System.Drawing.Point(13, 53)
        Me.ELNameLbl.Name = "ELNameLbl"
        Me.ELNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.ELNameLbl.TabIndex = 72
        Me.ELNameLbl.Text = "Last Name:"
        '
        'UAddressTb
        '
        Me.UAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UAddressTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAddressTb.Location = New System.Drawing.Point(126, 124)
        Me.UAddressTb.Name = "UAddressTb"
        Me.UAddressTb.Size = New System.Drawing.Size(169, 29)
        Me.UAddressTb.TabIndex = 71
        '
        'UConfirmPasswdTb
        '
        Me.UConfirmPasswdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UConfirmPasswdTb.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UConfirmPasswdTb.Location = New System.Drawing.Point(126, 233)
        Me.UConfirmPasswdTb.MaxLength = 49
        Me.UConfirmPasswdTb.Name = "UConfirmPasswdTb"
        Me.UConfirmPasswdTb.Size = New System.Drawing.Size(169, 25)
        Me.UConfirmPasswdTb.TabIndex = 72
        '
        'UPasswdTb
        '
        Me.UPasswdTb.BackColor = System.Drawing.Color.White
        Me.UPasswdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UPasswdTb.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPasswdTb.Location = New System.Drawing.Point(126, 200)
        Me.UPasswdTb.MaxLength = 49
        Me.UPasswdTb.Name = "UPasswdTb"
        Me.UPasswdTb.Size = New System.Drawing.Size(169, 25)
        Me.UPasswdTb.TabIndex = 75
        '
        'UPasswdLbl
        '
        Me.UPasswdLbl.AutoSize = True
        Me.UPasswdLbl.Location = New System.Drawing.Point(24, 202)
        Me.UPasswdLbl.Name = "UPasswdLbl"
        Me.UPasswdLbl.Size = New System.Drawing.Size(96, 25)
        Me.UPasswdLbl.TabIndex = 74
        Me.UPasswdLbl.Text = "Password:"
        '
        'UConfirmPasswdLbl
        '
        Me.UConfirmPasswdLbl.AutoSize = True
        Me.UConfirmPasswdLbl.Location = New System.Drawing.Point(37, 234)
        Me.UConfirmPasswdLbl.Name = "UConfirmPasswdLbl"
        Me.UConfirmPasswdLbl.Size = New System.Drawing.Size(83, 25)
        Me.UConfirmPasswdLbl.TabIndex = 73
        Me.UConfirmPasswdLbl.Text = "Confirm:"
        '
        'UsrNameLbl
        '
        Me.UsrNameLbl.AutoSize = True
        Me.UsrNameLbl.Location = New System.Drawing.Point(11, 166)
        Me.UsrNameLbl.Name = "UsrNameLbl"
        Me.UsrNameLbl.Size = New System.Drawing.Size(109, 25)
        Me.UsrNameLbl.TabIndex = 79
        Me.UsrNameLbl.Text = "User Name:"
        '
        'UsrNameTb
        '
        Me.UsrNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsrNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrNameTb.Location = New System.Drawing.Point(126, 163)
        Me.UsrNameTb.Name = "UsrNameTb"
        Me.UsrNameTb.Size = New System.Drawing.Size(169, 29)
        Me.UsrNameTb.TabIndex = 80
        '
        'UType
        '
        Me.UType.BackColor = System.Drawing.Color.Red
        Me.UType.FlatAppearance.BorderSize = 0
        Me.UType.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.UType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UType.ForeColor = System.Drawing.Color.Black
        Me.UType.Location = New System.Drawing.Point(126, 264)
        Me.UType.Name = "UType"
        Me.UType.Padding = New System.Windows.Forms.Padding(15, 1, 0, 0)
        Me.UType.Size = New System.Drawing.Size(169, 36)
        Me.UType.TabIndex = 71
        Me.UType.Text = "Is Admin"
        Me.UType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UType.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightGray
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(102, 445)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(71, 39)
        Me.ResetBtn.TabIndex = 84
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'URemoveBtn
        '
        Me.URemoveBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.URemoveBtn.FlatAppearance.BorderSize = 0
        Me.URemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.URemoveBtn.Location = New System.Drawing.Point(67, 400)
        Me.URemoveBtn.Name = "URemoveBtn"
        Me.URemoveBtn.Size = New System.Drawing.Size(144, 39)
        Me.URemoveBtn.TabIndex = 83
        Me.URemoveBtn.Text = "Remove User"
        Me.URemoveBtn.UseVisualStyleBackColor = False
        '
        'UUpdateBtn
        '
        Me.UUpdateBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.UUpdateBtn.FlatAppearance.BorderSize = 0
        Me.UUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UUpdateBtn.Location = New System.Drawing.Point(67, 353)
        Me.UUpdateBtn.Name = "UUpdateBtn"
        Me.UUpdateBtn.Size = New System.Drawing.Size(144, 39)
        Me.UUpdateBtn.TabIndex = 82
        Me.UUpdateBtn.Text = "Edit Info"
        Me.UUpdateBtn.UseVisualStyleBackColor = False
        '
        'UAddBtn
        '
        Me.UAddBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.UAddBtn.FlatAppearance.BorderSize = 0
        Me.UAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UAddBtn.Location = New System.Drawing.Point(67, 306)
        Me.UAddBtn.Name = "UAddBtn"
        Me.UAddBtn.Size = New System.Drawing.Size(144, 39)
        Me.UAddBtn.TabIndex = 81
        Me.UAddBtn.Text = "Add User"
        Me.UAddBtn.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn2
        '
        Me.FirstNameDataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn2.Name = "FirstNameDataGridViewTextBoxColumn2"
        Me.FirstNameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn2
        '
        Me.LastNameDataGridViewTextBoxColumn2.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn2.Name = "LastNameDataGridViewTextBoxColumn2"
        Me.LastNameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn2
        '
        Me.AddressDataGridViewTextBoxColumn2.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn2.Name = "AddressDataGridViewTextBoxColumn2"
        Me.AddressDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn2
        '
        Me.ContactDataGridViewTextBoxColumn2.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn2.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn2.Name = "ContactDataGridViewTextBoxColumn2"
        Me.ContactDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn2
        '
        Me.UserNameDataGridViewTextBoxColumn2.DataPropertyName = "User Name"
        Me.UserNameDataGridViewTextBoxColumn2.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn2.Name = "UserNameDataGridViewTextBoxColumn2"
        Me.UserNameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'AdminDataGridViewCheckBoxColumn2
        '
        Me.AdminDataGridViewCheckBoxColumn2.DataPropertyName = "Admin"
        Me.AdminDataGridViewCheckBoxColumn2.HeaderText = "Admin"
        Me.AdminDataGridViewCheckBoxColumn2.Name = "AdminDataGridViewCheckBoxColumn2"
        Me.AdminDataGridViewCheckBoxColumn2.ReadOnly = True
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
        Me.UsersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersDGV.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UsersDGV.ColumnHeadersHeight = 30
        Me.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.UsersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.AdminDataGridViewCheckBoxColumn})
        Me.UsersDGV.DataSource = Me.UspViewUsersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.Location = New System.Drawing.Point(335, 33)
        Me.UsersDGV.Name = "UsersDGV"
        Me.UsersDGV.ReadOnly = True
        Me.UsersDGV.RowHeadersVisible = False
        Me.UsersDGV.RowTemplate.Height = 30
        Me.UsersDGV.RowTemplate.ReadOnly = True
        Me.UsersDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDGV.Size = New System.Drawing.Size(753, 570)
        Me.UsersDGV.TabIndex = 87
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
        Me.FirstNameDataGridViewTextBoxColumn.FillWeight = 81.52849!
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.FillWeight = 81.52849!
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.FillWeight = 81.52849!
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.FillWeight = 81.52849!
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.FillWeight = 81.52849!
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminDataGridViewCheckBoxColumn
        '
        Me.AdminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AdminDataGridViewCheckBoxColumn.DataPropertyName = "Admin"
        Me.AdminDataGridViewCheckBoxColumn.FillWeight = 50.0!
        Me.AdminDataGridViewCheckBoxColumn.HeaderText = "Admin"
        Me.AdminDataGridViewCheckBoxColumn.Name = "AdminDataGridViewCheckBoxColumn"
        Me.AdminDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'UspViewUsersBindingSource
        '
        Me.UspViewUsersBindingSource.DataMember = "Usp_View_Users"
        Me.UspViewUsersBindingSource.DataSource = Me.SpaMgtSysDataSet3
        '
        'SpaMgtSysDataSet3
        '
        Me.SpaMgtSysDataSet3.DataSetName = "SpaMgtSysDataSet3"
        Me.SpaMgtSysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_UsersTableAdapter
        '
        Me.Usp_View_UsersTableAdapter.ClearBeforeFill = True
        '
        'CfrmPasHideShowChkB
        '
        Me.CfrmPasHideShowChkB.Appearance = System.Windows.Forms.Appearance.Button
        Me.CfrmPasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
        Me.CfrmPasHideShowChkB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CfrmPasHideShowChkB.Location = New System.Drawing.Point(301, 233)
        Me.CfrmPasHideShowChkB.Name = "CfrmPasHideShowChkB"
        Me.CfrmPasHideShowChkB.Size = New System.Drawing.Size(28, 25)
        Me.CfrmPasHideShowChkB.TabIndex = 86
        Me.CfrmPasHideShowChkB.UseVisualStyleBackColor = True
        '
        'PasHideShowChkB
        '
        Me.PasHideShowChkB.Appearance = System.Windows.Forms.Appearance.Button
        Me.PasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
        Me.PasHideShowChkB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PasHideShowChkB.Location = New System.Drawing.Point(301, 200)
        Me.PasHideShowChkB.Name = "PasHideShowChkB"
        Me.PasHideShowChkB.Size = New System.Drawing.Size(28, 25)
        Me.PasHideShowChkB.TabIndex = 85
        Me.PasHideShowChkB.UseVisualStyleBackColor = True
        '
        'AdminPanelManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 624)
        Me.Controls.Add(Me.UsersDGV)
        Me.Controls.Add(Me.CfrmPasHideShowChkB)
        Me.Controls.Add(Me.PasHideShowChkB)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.URemoveBtn)
        Me.Controls.Add(Me.UUpdateBtn)
        Me.Controls.Add(Me.UAddBtn)
        Me.Controls.Add(Me.UType)
        Me.Controls.Add(Me.UsrNameTb)
        Me.Controls.Add(Me.UFNameLbl)
        Me.Controls.Add(Me.UsrNameLbl)
        Me.Controls.Add(Me.UFNameTb)
        Me.Controls.Add(Me.UConfirmPasswdLbl)
        Me.Controls.Add(Me.UAddressLbl)
        Me.Controls.Add(Me.UContactTb)
        Me.Controls.Add(Me.UPasswdLbl)
        Me.Controls.Add(Me.EContactLbl)
        Me.Controls.Add(Me.ULNameTb)
        Me.Controls.Add(Me.UPasswdTb)
        Me.Controls.Add(Me.UConfirmPasswdTb)
        Me.Controls.Add(Me.ELNameLbl)
        Me.Controls.Add(Me.UAddressTb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AdminPanelManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Users"
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UFNameLbl As Label
    Friend WithEvents UFNameTb As TextBox
    Friend WithEvents UAddressLbl As Label
    Friend WithEvents UContactTb As TextBox
    Friend WithEvents EContactLbl As Label
    Friend WithEvents ULNameTb As TextBox
    Friend WithEvents ELNameLbl As Label
    Friend WithEvents UAddressTb As TextBox
    Friend WithEvents UConfirmPasswdTb As TextBox
    Friend WithEvents UPasswdTb As TextBox
    Friend WithEvents UPasswdLbl As Label
    Friend WithEvents UConfirmPasswdLbl As Label
    Friend WithEvents UsrNameLbl As Label
    Friend WithEvents UsrNameTb As TextBox
    Friend WithEvents UType As CheckBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents URemoveBtn As Button
    Friend WithEvents UUpdateBtn As Button
    Friend WithEvents UAddBtn As Button
    Friend WithEvents PasHideShowChkB As CheckBox
    Friend WithEvents CfrmPasHideShowChkB As CheckBox
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents UsersDGV As DataGridView
    Friend WithEvents SpaMgtSysDataSet3 As SpaMgtSysDataSet3
    Friend WithEvents UspViewUsersBindingSource As BindingSource
    Friend WithEvents Usp_View_UsersTableAdapter As SpaMgtSysDataSet3TableAdapters.Usp_View_UsersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
