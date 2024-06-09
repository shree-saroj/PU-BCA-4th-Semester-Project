<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageServices))
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsBtn = New System.Windows.Forms.Button()
        Me.AddUpdatePnl = New System.Windows.Forms.Panel()
        Me.EmployeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet2 = New SPA_Management_System.SpaMgtSysDataSet2()
        Me.SRemoveBtn = New System.Windows.Forms.Button()
        Me.SUpdateBtn = New System.Windows.Forms.Button()
        Me.SAddBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.SPriceTb = New System.Windows.Forms.TextBox()
        Me.SPriceLbl = New System.Windows.Forms.Label()
        Me.SNameTb = New System.Windows.Forms.TextBox()
        Me.SNameLbl = New System.Windows.Forms.Label()
        Me.ManageServiesLbl = New System.Windows.Forms.Label()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.Usp_View_ServicesTableAdapter = New SPA_Management_System.SpaMgtSysDataSet2TableAdapters.Usp_View_ServicesTableAdapter()
        Me.AddUpdatePnl.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoutLbl
        '
        Me.LogoutLbl.AutoSize = True
        Me.LogoutLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLbl.Location = New System.Drawing.Point(46, 527)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(71, 25)
        Me.LogoutLbl.TabIndex = 29
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
        Me.ManageUsersBtn.TabIndex = 27
        Me.ManageUsersBtn.Text = "Manage Users"
        Me.ManageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageUsersBtn.UseVisualStyleBackColor = False
        '
        'ViewCustomerInfoBtn
        '
        Me.ViewCustomerInfoBtn.BackColor = System.Drawing.Color.LightGray
        Me.ViewCustomerInfoBtn.FlatAppearance.BorderSize = 0
        Me.ViewCustomerInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCustomerInfoBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCustomerInfoBtn.Location = New System.Drawing.Point(12, 177)
        Me.ViewCustomerInfoBtn.Name = "ViewCustomerInfoBtn"
        Me.ViewCustomerInfoBtn.Size = New System.Drawing.Size(154, 63)
        Me.ViewCustomerInfoBtn.TabIndex = 26
        Me.ViewCustomerInfoBtn.Text = "View " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer Info"
        Me.ViewCustomerInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewCustomerInfoBtn.UseVisualStyleBackColor = False
        '
        'ViewTransactionsBtn
        '
        Me.ViewTransactionsBtn.BackColor = System.Drawing.Color.LightGray
        Me.ViewTransactionsBtn.FlatAppearance.BorderSize = 0
        Me.ViewTransactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionsBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTransactionsBtn.Location = New System.Drawing.Point(12, 101)
        Me.ViewTransactionsBtn.Name = "ViewTransactionsBtn"
        Me.ViewTransactionsBtn.Size = New System.Drawing.Size(154, 63)
        Me.ViewTransactionsBtn.TabIndex = 25
        Me.ViewTransactionsBtn.Text = "View Transactions"
        Me.ViewTransactionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewTransactionsBtn.UseVisualStyleBackColor = False
        '
        'AddUpdatePnl
        '
        Me.AddUpdatePnl.BackColor = System.Drawing.Color.White
        Me.AddUpdatePnl.Controls.Add(Me.EmployeeDGV)
        Me.AddUpdatePnl.Controls.Add(Me.SRemoveBtn)
        Me.AddUpdatePnl.Controls.Add(Me.SUpdateBtn)
        Me.AddUpdatePnl.Controls.Add(Me.SAddBtn)
        Me.AddUpdatePnl.Controls.Add(Me.ResetBtn)
        Me.AddUpdatePnl.Controls.Add(Me.SPriceTb)
        Me.AddUpdatePnl.Controls.Add(Me.SPriceLbl)
        Me.AddUpdatePnl.Controls.Add(Me.SNameTb)
        Me.AddUpdatePnl.Controls.Add(Me.SNameLbl)
        Me.AddUpdatePnl.Controls.Add(Me.ManageServiesLbl)
        Me.AddUpdatePnl.Location = New System.Drawing.Point(172, 37)
        Me.AddUpdatePnl.Name = "AddUpdatePnl"
        Me.AddUpdatePnl.Size = New System.Drawing.Size(840, 527)
        Me.AddUpdatePnl.TabIndex = 24
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
        Me.EmployeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.EmployeeDGV.DataSource = Me.UspViewServicesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(22, 171)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowTemplate.Height = 30
        Me.EmployeeDGV.RowTemplate.ReadOnly = True
        Me.EmployeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.Size = New System.Drawing.Size(795, 344)
        Me.EmployeeDGV.TabIndex = 58
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspViewServicesBindingSource
        '
        Me.UspViewServicesBindingSource.DataMember = "Usp_View_Services"
        Me.UspViewServicesBindingSource.DataSource = Me.SpaMgtSysDataSet2
        '
        'SpaMgtSysDataSet2
        '
        Me.SpaMgtSysDataSet2.DataSetName = "SpaMgtSysDataSet2"
        Me.SpaMgtSysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SRemoveBtn
        '
        Me.SRemoveBtn.BackColor = System.Drawing.Color.Yellow
        Me.SRemoveBtn.FlatAppearance.BorderSize = 0
        Me.SRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SRemoveBtn.Location = New System.Drawing.Point(417, 119)
        Me.SRemoveBtn.Name = "SRemoveBtn"
        Me.SRemoveBtn.Size = New System.Drawing.Size(184, 34)
        Me.SRemoveBtn.TabIndex = 57
        Me.SRemoveBtn.Text = "Remove Service"
        Me.SRemoveBtn.UseVisualStyleBackColor = False
        '
        'SUpdateBtn
        '
        Me.SUpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.SUpdateBtn.FlatAppearance.BorderSize = 0
        Me.SUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUpdateBtn.Location = New System.Drawing.Point(417, 79)
        Me.SUpdateBtn.Name = "SUpdateBtn"
        Me.SUpdateBtn.Size = New System.Drawing.Size(184, 34)
        Me.SUpdateBtn.TabIndex = 56
        Me.SUpdateBtn.Text = "Edit Info"
        Me.SUpdateBtn.UseVisualStyleBackColor = False
        '
        'SAddBtn
        '
        Me.SAddBtn.BackColor = System.Drawing.Color.Yellow
        Me.SAddBtn.FlatAppearance.BorderSize = 0
        Me.SAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAddBtn.Location = New System.Drawing.Point(417, 39)
        Me.SAddBtn.Name = "SAddBtn"
        Me.SAddBtn.Size = New System.Drawing.Size(184, 34)
        Me.SAddBtn.TabIndex = 55
        Me.SAddBtn.Text = "Add Service"
        Me.SAddBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(154, 119)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(181, 33)
        Me.ResetBtn.TabIndex = 54
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'SPriceTb
        '
        Me.SPriceTb.Location = New System.Drawing.Point(154, 80)
        Me.SPriceTb.Name = "SPriceTb"
        Me.SPriceTb.Size = New System.Drawing.Size(245, 33)
        Me.SPriceTb.TabIndex = 51
        '
        'SPriceLbl
        '
        Me.SPriceLbl.AutoSize = True
        Me.SPriceLbl.Location = New System.Drawing.Point(90, 83)
        Me.SPriceLbl.Name = "SPriceLbl"
        Me.SPriceLbl.Size = New System.Drawing.Size(58, 25)
        Me.SPriceLbl.TabIndex = 46
        Me.SPriceLbl.Text = "Price:"
        '
        'SNameTb
        '
        Me.SNameTb.Location = New System.Drawing.Point(154, 39)
        Me.SNameTb.Name = "SNameTb"
        Me.SNameTb.Size = New System.Drawing.Size(245, 33)
        Me.SNameTb.TabIndex = 45
        '
        'SNameLbl
        '
        Me.SNameLbl.AutoSize = True
        Me.SNameLbl.Location = New System.Drawing.Point(17, 42)
        Me.SNameLbl.Name = "SNameLbl"
        Me.SNameLbl.Size = New System.Drawing.Size(131, 25)
        Me.SNameLbl.TabIndex = 44
        Me.SNameLbl.Text = "Service Name:"
        '
        'ManageServiesLbl
        '
        Me.ManageServiesLbl.AutoSize = True
        Me.ManageServiesLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageServiesLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ManageServiesLbl.Location = New System.Drawing.Point(370, 4)
        Me.ManageServiesLbl.Name = "ManageServiesLbl"
        Me.ManageServiesLbl.Size = New System.Drawing.Size(156, 25)
        Me.ManageServiesLbl.TabIndex = 32
        Me.ManageServiesLbl.Text = "Manage Services"
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
        Me.ViewStatisticsBtn.TabIndex = 30
        Me.ViewStatisticsBtn.Text = "View Statistics"
        Me.ViewStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewStatisticsBtn.UseVisualStyleBackColor = False
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
        Me.ManageEmployeesBtn.TabIndex = 31
        Me.ManageEmployeesBtn.Text = "Manage Employees"
        Me.ManageEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageEmployeesBtn.UseVisualStyleBackColor = False
        '
        'SmsPb
        '
        Me.SmsPb.Image = CType(resources.GetObject("SmsPb.Image"), System.Drawing.Image)
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 28
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 15
        Me.ExitPb.TabStop = False
        '
        'Usp_View_ServicesTableAdapter
        '
        Me.Usp_View_ServicesTableAdapter.ClearBeforeFill = True
        '
        'ManageServices
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
        Me.Controls.Add(Me.ViewCustomerInfoBtn)
        Me.Controls.Add(Me.ViewTransactionsBtn)
        Me.Controls.Add(Me.AddUpdatePnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ManageServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUpdate"
        Me.AddUpdatePnl.ResumeLayout(False)
        Me.AddUpdatePnl.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents ViewCustomerInfoBtn As Button
    Friend WithEvents ViewTransactionsBtn As Button
    Friend WithEvents AddUpdatePnl As Panel
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents ManageEmployeesBtn As Button
    Friend WithEvents ManageServiesLbl As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents SPriceTb As TextBox
    Friend WithEvents SPriceLbl As Label
    Friend WithEvents SNameTb As TextBox
    Friend WithEvents SNameLbl As Label
    Friend WithEvents SRemoveBtn As Button
    Friend WithEvents SUpdateBtn As Button
    Friend WithEvents SAddBtn As Button
    Friend WithEvents SpaMgtSysDataSet2 As SpaMgtSysDataSet2
    Friend WithEvents EmployeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UspViewServicesBindingSource As BindingSource
    Friend WithEvents Usp_View_ServicesTableAdapter As SpaMgtSysDataSet2TableAdapters.Usp_View_ServicesTableAdapter
End Class
