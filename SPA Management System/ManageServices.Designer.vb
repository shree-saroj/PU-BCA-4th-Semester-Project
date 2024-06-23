<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageServices
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageServices))
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsBtn = New System.Windows.Forms.Button()
        Me.AddUpdatePnl = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SRemoveBtn = New System.Windows.Forms.Button()
        Me.SUpdateBtn = New System.Windows.Forms.Button()
        Me.SAddBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.STimeLbl = New System.Windows.Forms.Label()
        Me.SPriceTb = New System.Windows.Forms.TextBox()
        Me.SPrice = New System.Windows.Forms.Label()
        Me.SNameTb = New System.Windows.Forms.TextBox()
        Me.SNameLbl = New System.Windows.Forms.Label()
        Me.ManageServiesLbl = New System.Windows.Forms.Label()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.AddUpdatePnl.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.AddUpdatePnl.Controls.Add(Me.DateTimePicker1)
        Me.AddUpdatePnl.Controls.Add(Me.Guna2DataGridView1)
        Me.AddUpdatePnl.Controls.Add(Me.SRemoveBtn)
        Me.AddUpdatePnl.Controls.Add(Me.SUpdateBtn)
        Me.AddUpdatePnl.Controls.Add(Me.SAddBtn)
        Me.AddUpdatePnl.Controls.Add(Me.ResetBtn)
        Me.AddUpdatePnl.Controls.Add(Me.STimeLbl)
        Me.AddUpdatePnl.Controls.Add(Me.SPriceTb)
        Me.AddUpdatePnl.Controls.Add(Me.SPrice)
        Me.AddUpdatePnl.Controls.Add(Me.SNameTb)
        Me.AddUpdatePnl.Controls.Add(Me.SNameLbl)
        Me.AddUpdatePnl.Controls.Add(Me.ManageServiesLbl)
        Me.AddUpdatePnl.Location = New System.Drawing.Point(172, 37)
        Me.AddUpdatePnl.Name = "AddUpdatePnl"
        Me.AddUpdatePnl.Size = New System.Drawing.Size(840, 527)
        Me.AddUpdatePnl.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(154, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 33)
        Me.DateTimePicker1.TabIndex = 59
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(95, 209)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(669, 306)
        Me.Guna2DataGridView1.TabIndex = 58
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SRemoveBtn
        '
        Me.SRemoveBtn.BackColor = System.Drawing.Color.Yellow
        Me.SRemoveBtn.FlatAppearance.BorderSize = 0
        Me.SRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SRemoveBtn.Location = New System.Drawing.Point(375, 149)
        Me.SRemoveBtn.Name = "SRemoveBtn"
        Me.SRemoveBtn.Size = New System.Drawing.Size(184, 39)
        Me.SRemoveBtn.TabIndex = 57
        Me.SRemoveBtn.Text = "Remove Service"
        Me.SRemoveBtn.UseVisualStyleBackColor = False
        '
        'SUpdateBtn
        '
        Me.SUpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.SUpdateBtn.FlatAppearance.BorderSize = 0
        Me.SUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUpdateBtn.Location = New System.Drawing.Point(375, 95)
        Me.SUpdateBtn.Name = "SUpdateBtn"
        Me.SUpdateBtn.Size = New System.Drawing.Size(184, 39)
        Me.SUpdateBtn.TabIndex = 56
        Me.SUpdateBtn.Text = "Edit Info"
        Me.SUpdateBtn.UseVisualStyleBackColor = False
        '
        'SAddBtn
        '
        Me.SAddBtn.BackColor = System.Drawing.Color.Yellow
        Me.SAddBtn.FlatAppearance.BorderSize = 0
        Me.SAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAddBtn.Location = New System.Drawing.Point(375, 39)
        Me.SAddBtn.Name = "SAddBtn"
        Me.SAddBtn.Size = New System.Drawing.Size(184, 39)
        Me.SAddBtn.TabIndex = 55
        Me.SAddBtn.Text = "Add Service"
        Me.SAddBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(154, 155)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(181, 33)
        Me.ResetBtn.TabIndex = 54
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'STimeLbl
        '
        Me.STimeLbl.AutoSize = True
        Me.STimeLbl.Location = New System.Drawing.Point(17, 81)
        Me.STimeLbl.Name = "STimeLbl"
        Me.STimeLbl.Size = New System.Drawing.Size(122, 25)
        Me.STimeLbl.TabIndex = 52
        Me.STimeLbl.Text = "Service Time:"
        '
        'SPriceTb
        '
        Me.SPriceTb.Location = New System.Drawing.Point(154, 117)
        Me.SPriceTb.Name = "SPriceTb"
        Me.SPriceTb.Size = New System.Drawing.Size(181, 33)
        Me.SPriceTb.TabIndex = 51
        '
        'SPrice
        '
        Me.SPrice.AutoSize = True
        Me.SPrice.Location = New System.Drawing.Point(90, 120)
        Me.SPrice.Name = "SPrice"
        Me.SPrice.Size = New System.Drawing.Size(58, 25)
        Me.SPrice.TabIndex = 46
        Me.SPrice.Text = "Price:"
        '
        'SNameTb
        '
        Me.SNameTb.Location = New System.Drawing.Point(154, 39)
        Me.SNameTb.Name = "SNameTb"
        Me.SNameTb.Size = New System.Drawing.Size(181, 33)
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
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents STimeLbl As Label
    Friend WithEvents SPriceTb As TextBox
    Friend WithEvents SPrice As Label
    Friend WithEvents SNameTb As TextBox
    Friend WithEvents SNameLbl As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SRemoveBtn As Button
    Friend WithEvents SUpdateBtn As Button
    Friend WithEvents SAddBtn As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
