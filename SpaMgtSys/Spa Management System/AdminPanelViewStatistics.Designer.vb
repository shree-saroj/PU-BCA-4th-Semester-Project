<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanelViewStatistics
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UsersDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RefundLbl = New System.Windows.Forms.Label()
        Me.IncomeLbl = New System.Windows.Forms.Label()
        Me.RefundedTb = New System.Windows.Forms.TextBox()
        Me.IncomeTb = New System.Windows.Forms.TextBox()
        Me.NetIncomeLbl = New System.Windows.Forms.Label()
        Me.NetIncomeTb = New System.Windows.Forms.TextBox()
        Me.SerivceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEarningsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetDistinctAmountByServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet5 = New Spa_Management_System.SpaMgtSysDataSet5()
        Me.Usp_Get_DistinctAmountByServiceTableAdapter = New Spa_Management_System.SpaMgtSysDataSet5TableAdapters.Usp_Get_DistinctAmountByServiceTableAdapter()
        Me.UspGetDistinctAmountByAreaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet6 = New Spa_Management_System.SpaMgtSysDataSet6()
        Me.Usp_Get_DistinctAmountByAreaTableAdapter = New Spa_Management_System.SpaMgtSysDataSet6TableAdapters.Usp_Get_DistinctAmountByAreaTableAdapter()
        Me.UspGetDistinctAmountByAreaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCustomers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetDistinctAmountByServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetDistinctAmountByAreaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetDistinctAmountByAreaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UsersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerivceDataGridViewTextBoxColumn, Me.TotalEarningsDataGridViewTextBoxColumn})
        Me.UsersDGV.DataSource = Me.UspGetDistinctAmountByServiceBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.UsersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsersDGV.Location = New System.Drawing.Point(12, 12)
        Me.UsersDGV.Name = "UsersDGV"
        Me.UsersDGV.ReadOnly = True
        Me.UsersDGV.RowHeadersVisible = False
        Me.UsersDGV.RowTemplate.Height = 30
        Me.UsersDGV.RowTemplate.ReadOnly = True
        Me.UsersDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDGV.Size = New System.Drawing.Size(565, 207)
        Me.UsersDGV.TabIndex = 88
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Area, Me.TotalCustomers})
        Me.DataGridView1.DataSource = Me.UspGetDistinctAmountByAreaBindingSource1
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(583, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(413, 207)
        Me.DataGridView1.TabIndex = 89
        '
        'RefundLbl
        '
        Me.RefundLbl.AutoSize = True
        Me.RefundLbl.Location = New System.Drawing.Point(40, 281)
        Me.RefundLbl.Name = "RefundLbl"
        Me.RefundLbl.Size = New System.Drawing.Size(97, 25)
        Me.RefundLbl.TabIndex = 80
        Me.RefundLbl.Text = "Refunded:"
        '
        'IncomeLbl
        '
        Me.IncomeLbl.AutoSize = True
        Me.IncomeLbl.Location = New System.Drawing.Point(59, 236)
        Me.IncomeLbl.Name = "IncomeLbl"
        Me.IncomeLbl.Size = New System.Drawing.Size(78, 25)
        Me.IncomeLbl.TabIndex = 81
        Me.IncomeLbl.Text = "Income:"
        '
        'RefundedTb
        '
        Me.RefundedTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RefundedTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundedTb.Location = New System.Drawing.Point(143, 282)
        Me.RefundedTb.Name = "RefundedTb"
        Me.RefundedTb.ReadOnly = True
        Me.RefundedTb.Size = New System.Drawing.Size(124, 29)
        Me.RefundedTb.TabIndex = 82
        '
        'IncomeTb
        '
        Me.IncomeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IncomeTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeTb.Location = New System.Drawing.Point(143, 237)
        Me.IncomeTb.Name = "IncomeTb"
        Me.IncomeTb.ReadOnly = True
        Me.IncomeTb.Size = New System.Drawing.Size(124, 29)
        Me.IncomeTb.TabIndex = 83
        '
        'NetIncomeLbl
        '
        Me.NetIncomeLbl.AutoSize = True
        Me.NetIncomeLbl.Location = New System.Drawing.Point(24, 329)
        Me.NetIncomeLbl.Name = "NetIncomeLbl"
        Me.NetIncomeLbl.Size = New System.Drawing.Size(113, 25)
        Me.NetIncomeLbl.TabIndex = 84
        Me.NetIncomeLbl.Text = "Net Income:"
        '
        'NetIncomeTb
        '
        Me.NetIncomeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetIncomeTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetIncomeTb.Location = New System.Drawing.Point(143, 329)
        Me.NetIncomeTb.Name = "NetIncomeTb"
        Me.NetIncomeTb.ReadOnly = True
        Me.NetIncomeTb.Size = New System.Drawing.Size(124, 29)
        Me.NetIncomeTb.TabIndex = 85
        '
        'SerivceDataGridViewTextBoxColumn
        '
        Me.SerivceDataGridViewTextBoxColumn.DataPropertyName = "Serivce"
        Me.SerivceDataGridViewTextBoxColumn.HeaderText = "Serivce"
        Me.SerivceDataGridViewTextBoxColumn.Name = "SerivceDataGridViewTextBoxColumn"
        Me.SerivceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalEarningsDataGridViewTextBoxColumn
        '
        Me.TotalEarningsDataGridViewTextBoxColumn.DataPropertyName = "Total Earnings"
        Me.TotalEarningsDataGridViewTextBoxColumn.HeaderText = "Total Earnings"
        Me.TotalEarningsDataGridViewTextBoxColumn.Name = "TotalEarningsDataGridViewTextBoxColumn"
        Me.TotalEarningsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspGetDistinctAmountByServiceBindingSource
        '
        Me.UspGetDistinctAmountByServiceBindingSource.DataMember = "Usp_Get_DistinctAmountByService"
        Me.UspGetDistinctAmountByServiceBindingSource.DataSource = Me.SpaMgtSysDataSet5
        '
        'SpaMgtSysDataSet5
        '
        Me.SpaMgtSysDataSet5.DataSetName = "SpaMgtSysDataSet5"
        Me.SpaMgtSysDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_Get_DistinctAmountByServiceTableAdapter
        '
        Me.Usp_Get_DistinctAmountByServiceTableAdapter.ClearBeforeFill = True
        '
        'UspGetDistinctAmountByAreaBindingSource1
        '
        Me.UspGetDistinctAmountByAreaBindingSource1.DataMember = "Usp_Get_DistinctAmountByArea"
        Me.UspGetDistinctAmountByAreaBindingSource1.DataSource = Me.SpaMgtSysDataSet6
        '
        'SpaMgtSysDataSet6
        '
        Me.SpaMgtSysDataSet6.DataSetName = "SpaMgtSysDataSet6"
        Me.SpaMgtSysDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_Get_DistinctAmountByAreaTableAdapter
        '
        Me.Usp_Get_DistinctAmountByAreaTableAdapter.ClearBeforeFill = True
        '
        'UspGetDistinctAmountByAreaBindingSource
        '
        Me.UspGetDistinctAmountByAreaBindingSource.DataMember = "Usp_Get_DistinctAmountByArea"
        Me.UspGetDistinctAmountByAreaBindingSource.DataSource = Me.SpaMgtSysDataSet6
        '
        'Area
        '
        Me.Area.DataPropertyName = "Area"
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        '
        'TotalCustomers
        '
        Me.TotalCustomers.DataPropertyName = "Total Customers"
        Me.TotalCustomers.HeaderText = "Total Customers"
        Me.TotalCustomers.Name = "TotalCustomers"
        Me.TotalCustomers.ReadOnly = True
        '
        'AdminPanelViewStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.NetIncomeTb)
        Me.Controls.Add(Me.NetIncomeLbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IncomeTb)
        Me.Controls.Add(Me.UsersDGV)
        Me.Controls.Add(Me.RefundedTb)
        Me.Controls.Add(Me.IncomeLbl)
        Me.Controls.Add(Me.RefundLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AdminPanelViewStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Statistics"
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetDistinctAmountByServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetDistinctAmountByAreaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetDistinctAmountByAreaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsersDGV As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SpaMgtSysDataSet6 As SpaMgtSysDataSet6
    Friend WithEvents Usp_Get_DistinctAmountByAreaTableAdapter As SpaMgtSysDataSet6TableAdapters.Usp_Get_DistinctAmountByAreaTableAdapter
    Friend WithEvents UspGetDistinctAmountByAreaBindingSource1 As BindingSource
    Friend WithEvents SpaMgtSysDataSet5 As SpaMgtSysDataSet5
    Friend WithEvents UspGetDistinctAmountByServiceBindingSource As BindingSource
    Friend WithEvents Usp_Get_DistinctAmountByServiceTableAdapter As SpaMgtSysDataSet5TableAdapters.Usp_Get_DistinctAmountByServiceTableAdapter
    Friend WithEvents SerivceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEarningsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UspGetDistinctAmountByAreaBindingSource As BindingSource
    Friend WithEvents RefundLbl As Label
    Friend WithEvents IncomeLbl As Label
    Friend WithEvents RefundedTb As TextBox
    Friend WithEvents IncomeTb As TextBox
    Friend WithEvents NetIncomeLbl As Label
    Friend WithEvents NetIncomeTb As TextBox
    Friend WithEvents Area As DataGridViewTextBoxColumn
    Friend WithEvents TotalCustomers As DataGridViewTextBoxColumn
End Class
