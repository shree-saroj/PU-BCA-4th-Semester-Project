<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTransactions))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ManageServicesBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsPnl = New System.Windows.Forms.Panel()
        Me.ViewTransactionsLbl = New System.Windows.Forms.Label()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.EmployeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SpaMgtSysDataSet4 = New SPA_Management_System.SpaMgtSysDataSet4()
        Me.UspViewTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usp_View_TransactionsTableAdapter = New SPA_Management_System.SpaMgtSysDataSet4TableAdapters.Usp_View_TransactionsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewTransactionsPnl.SuspendLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ManageEmployeesBtn.TabIndex = 39
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
        Me.ViewStatisticsBtn.TabIndex = 38
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
        Me.LogoutLbl.TabIndex = 37
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
        Me.ManageUsersBtn.TabIndex = 35
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
        Me.ViewCustomerInfoBtn.TabIndex = 34
        Me.ViewCustomerInfoBtn.Text = "View " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer Info"
        Me.ViewCustomerInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewCustomerInfoBtn.UseVisualStyleBackColor = False
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
        Me.ManageServicesBtn.TabIndex = 33
        Me.ManageServicesBtn.Text = "Manage Services"
        Me.ManageServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageServicesBtn.UseVisualStyleBackColor = False
        '
        'ViewTransactionsPnl
        '
        Me.ViewTransactionsPnl.BackColor = System.Drawing.Color.White
        Me.ViewTransactionsPnl.Controls.Add(Me.EmployeeDGV)
        Me.ViewTransactionsPnl.Controls.Add(Me.ViewTransactionsLbl)
        Me.ViewTransactionsPnl.Location = New System.Drawing.Point(172, 37)
        Me.ViewTransactionsPnl.Name = "ViewTransactionsPnl"
        Me.ViewTransactionsPnl.Size = New System.Drawing.Size(840, 527)
        Me.ViewTransactionsPnl.TabIndex = 32
        '
        'ViewTransactionsLbl
        '
        Me.ViewTransactionsLbl.AutoSize = True
        Me.ViewTransactionsLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTransactionsLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ViewTransactionsLbl.Location = New System.Drawing.Point(372, 4)
        Me.ViewTransactionsLbl.Name = "ViewTransactionsLbl"
        Me.ViewTransactionsLbl.Size = New System.Drawing.Size(117, 25)
        Me.ViewTransactionsLbl.TabIndex = 58
        Me.ViewTransactionsLbl.Text = "Transactions"
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 36
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 16
        Me.ExitPb.TabStop = False
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
        Me.EmployeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.BookingByDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.EmployeeDGV.DataSource = Me.UspViewTransactionsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(23, 32)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowTemplate.Height = 30
        Me.EmployeeDGV.RowTemplate.ReadOnly = True
        Me.EmployeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.Size = New System.Drawing.Size(795, 483)
        Me.EmployeeDGV.TabIndex = 59
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
        'SpaMgtSysDataSet4
        '
        Me.SpaMgtSysDataSet4.DataSetName = "SpaMgtSysDataSet4"
        Me.SpaMgtSysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UspViewTransactionsBindingSource
        '
        Me.UspViewTransactionsBindingSource.DataMember = "Usp_View_Transactions"
        Me.UspViewTransactionsBindingSource.DataSource = Me.SpaMgtSysDataSet4
        '
        'Usp_View_TransactionsTableAdapter
        '
        Me.Usp_View_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingByDataGridViewTextBoxColumn
        '
        Me.BookingByDataGridViewTextBoxColumn.DataPropertyName = "Booking By"
        Me.BookingByDataGridViewTextBoxColumn.HeaderText = "Booking By"
        Me.BookingByDataGridViewTextBoxColumn.Name = "BookingByDataGridViewTextBoxColumn"
        Me.BookingByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewTransactions
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
        Me.Controls.Add(Me.ManageServicesBtn)
        Me.Controls.Add(Me.ViewTransactionsPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ViewTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewTransactions"
        Me.ViewTransactionsPnl.ResumeLayout(False)
        Me.ViewTransactionsPnl.PerformLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents ManageEmployeesBtn As Button
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents ViewCustomerInfoBtn As Button
    Friend WithEvents ManageServicesBtn As Button
    Friend WithEvents ViewTransactionsPnl As Panel
    Friend WithEvents ViewTransactionsLbl As Label
    Friend WithEvents EmployeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SpaMgtSysDataSet4 As SpaMgtSysDataSet4
    Friend WithEvents UspViewTransactionsBindingSource As BindingSource
    Friend WithEvents Usp_View_TransactionsTableAdapter As SpaMgtSysDataSet4TableAdapters.Usp_View_TransactionsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
