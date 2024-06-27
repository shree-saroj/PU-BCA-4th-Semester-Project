<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPanelBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CIdLbl = New System.Windows.Forms.Label()
        Me.CIdTb = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CustomerInfoDGV = New System.Windows.Forms.DataGridView()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.ServicesCB = New System.Windows.Forms.ComboBox()
        Me.ServiceLbl = New System.Windows.Forms.Label()
        Me.TimeCB = New System.Windows.Forms.ComboBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.AddToBill = New System.Windows.Forms.Button()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.BookDGV = New System.Windows.Forms.DataGridView()
        Me.ServicesIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicesNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.DiscountTb = New System.Windows.Forms.TextBox()
        Me.DiscountLbl = New System.Windows.Forms.Label()
        Me.TotalPriceLbl = New System.Windows.Forms.Label()
        Me.CheckoutBtn = New System.Windows.Forms.Button()
        Me.BillViewLbl = New System.Windows.Forms.TextBox()
        Me.TotalPriceViewLbl = New System.Windows.Forms.TextBox()
        Me.PriceViewLbl = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CusNameLbl = New System.Windows.Forms.Label()
        Me.CusNameTb = New System.Windows.Forms.TextBox()
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CIdLbl
        '
        Me.CIdLbl.AutoSize = True
        Me.CIdLbl.Location = New System.Drawing.Point(13, 13)
        Me.CIdLbl.Name = "CIdLbl"
        Me.CIdLbl.Size = New System.Drawing.Size(120, 25)
        Me.CIdLbl.TabIndex = 0
        Me.CIdLbl.Text = "Customer ID:"
        '
        'CIdTb
        '
        Me.CIdTb.Location = New System.Drawing.Point(139, 10)
        Me.CIdTb.Name = "CIdTb"
        Me.CIdTb.Size = New System.Drawing.Size(67, 33)
        Me.CIdTb.TabIndex = 1
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(472, 13)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(99, 33)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'CustomerInfoDGV
        '
        Me.CustomerInfoDGV.AllowUserToAddRows = False
        Me.CustomerInfoDGV.AllowUserToDeleteRows = False
        Me.CustomerInfoDGV.AllowUserToResizeColumns = False
        Me.CustomerInfoDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerInfoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerInfoDGV.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerInfoDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerInfoDGV.ColumnHeadersHeight = 30
        Me.CustomerInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerInfoDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerInfoDGV.Location = New System.Drawing.Point(18, 57)
        Me.CustomerInfoDGV.Name = "CustomerInfoDGV"
        Me.CustomerInfoDGV.ReadOnly = True
        Me.CustomerInfoDGV.RowHeadersVisible = False
        Me.CustomerInfoDGV.RowTemplate.Height = 30
        Me.CustomerInfoDGV.RowTemplate.ReadOnly = True
        Me.CustomerInfoDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerInfoDGV.Size = New System.Drawing.Size(553, 110)
        Me.CustomerInfoDGV.TabIndex = 3
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.Location = New System.Drawing.Point(335, 175)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(58, 25)
        Me.PriceLbl.TabIndex = 89
        Me.PriceLbl.Text = "Price:"
        '
        'ServicesCB
        '
        Me.ServicesCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesCB.FormattingEnabled = True
        Me.ServicesCB.Location = New System.Drawing.Point(94, 173)
        Me.ServicesCB.Name = "ServicesCB"
        Me.ServicesCB.Size = New System.Drawing.Size(199, 29)
        Me.ServicesCB.TabIndex = 87
        '
        'ServiceLbl
        '
        Me.ServiceLbl.AutoSize = True
        Me.ServiceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceLbl.Location = New System.Drawing.Point(16, 174)
        Me.ServiceLbl.Name = "ServiceLbl"
        Me.ServiceLbl.Size = New System.Drawing.Size(76, 25)
        Me.ServiceLbl.TabIndex = 86
        Me.ServiceLbl.Text = "Service:"
        '
        'TimeCB
        '
        Me.TimeCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeCB.FormattingEnabled = True
        Me.TimeCB.Location = New System.Drawing.Point(399, 216)
        Me.TimeCB.Name = "TimeCB"
        Me.TimeCB.Size = New System.Drawing.Size(174, 29)
        Me.TimeCB.TabIndex = 94
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.Location = New System.Drawing.Point(336, 219)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(57, 25)
        Me.TimeLbl.TabIndex = 93
        Me.TimeLbl.Text = "Time:"
        '
        'AddToBill
        '
        Me.AddToBill.BackColor = System.Drawing.Color.LightSalmon
        Me.AddToBill.FlatAppearance.BorderSize = 0
        Me.AddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddToBill.Location = New System.Drawing.Point(584, 175)
        Me.AddToBill.Name = "AddToBill"
        Me.AddToBill.Size = New System.Drawing.Size(126, 33)
        Me.AddToBill.TabIndex = 92
        Me.AddToBill.Text = "Add To Bill"
        Me.AddToBill.UseVisualStyleBackColor = False
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDP.Location = New System.Drawing.Point(93, 217)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 91
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(32, 220)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 90
        Me.DateLbl.Text = "Date:"
        '
        'BookDGV
        '
        Me.BookDGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicesIdCol, Me.ServicesNameCol, Me.DateCol, Me.TimeIdCol, Me.TimeCol, Me.PriceCol})
        Me.BookDGV.Location = New System.Drawing.Point(19, 262)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.RowHeadersVisible = False
        Me.BookDGV.Size = New System.Drawing.Size(554, 263)
        Me.BookDGV.TabIndex = 95
        '
        'ServicesIdCol
        '
        Me.ServicesIdCol.HeaderText = "Services Id"
        Me.ServicesIdCol.Name = "ServicesIdCol"
        Me.ServicesIdCol.Width = 5
        '
        'ServicesNameCol
        '
        Me.ServicesNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServicesNameCol.HeaderText = "Service Name"
        Me.ServicesNameCol.Name = "ServicesNameCol"
        '
        'DateCol
        '
        Me.DateCol.HeaderText = "Date"
        Me.DateCol.Name = "DateCol"
        Me.DateCol.Width = 150
        '
        'TimeIdCol
        '
        Me.TimeIdCol.HeaderText = "Time Id"
        Me.TimeIdCol.Name = "TimeIdCol"
        Me.TimeIdCol.Width = 5
        '
        'TimeCol
        '
        Me.TimeCol.HeaderText = "Time"
        Me.TimeCol.Name = "TimeCol"
        '
        'PriceCol
        '
        Me.PriceCol.HeaderText = "Price"
        Me.PriceCol.Name = "PriceCol"
        Me.PriceCol.Width = 120
        '
        'BillBtn
        '
        Me.BillBtn.BackColor = System.Drawing.Color.LightGray
        Me.BillBtn.FlatAppearance.BorderSize = 0
        Me.BillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BillBtn.Location = New System.Drawing.Point(46, 105)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(62, 31)
        Me.BillBtn.TabIndex = 103
        Me.BillBtn.Text = "Bill"
        Me.BillBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightGray
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ResetBtn.Location = New System.Drawing.Point(602, 214)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(82, 35)
        Me.ResetBtn.TabIndex = 102
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'DiscountTb
        '
        Me.DiscountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiscountTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTb.Location = New System.Drawing.Point(124, 74)
        Me.DiscountTb.Name = "DiscountTb"
        Me.DiscountTb.Size = New System.Drawing.Size(87, 29)
        Me.DiscountTb.TabIndex = 100
        Me.DiscountTb.Text = "0"
        '
        'DiscountLbl
        '
        Me.DiscountLbl.AutoSize = True
        Me.DiscountLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLbl.Location = New System.Drawing.Point(23, 74)
        Me.DiscountLbl.Name = "DiscountLbl"
        Me.DiscountLbl.Size = New System.Drawing.Size(95, 25)
        Me.DiscountLbl.TabIndex = 99
        Me.DiscountLbl.Text = "Discount: "
        '
        'TotalPriceLbl
        '
        Me.TotalPriceLbl.AutoSize = True
        Me.TotalPriceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLbl.Location = New System.Drawing.Point(23, 41)
        Me.TotalPriceLbl.Name = "TotalPriceLbl"
        Me.TotalPriceLbl.Size = New System.Drawing.Size(61, 25)
        Me.TotalPriceLbl.TabIndex = 97
        Me.TotalPriceLbl.Text = "Total: "
        '
        'CheckoutBtn
        '
        Me.CheckoutBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CheckoutBtn.FlatAppearance.BorderSize = 0
        Me.CheckoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckoutBtn.Location = New System.Drawing.Point(74, 151)
        Me.CheckoutBtn.Name = "CheckoutBtn"
        Me.CheckoutBtn.Size = New System.Drawing.Size(126, 33)
        Me.CheckoutBtn.TabIndex = 96
        Me.CheckoutBtn.Text = "Book"
        Me.CheckoutBtn.UseVisualStyleBackColor = False
        '
        'BillViewLbl
        '
        Me.BillViewLbl.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillViewLbl.Location = New System.Drawing.Point(124, 107)
        Me.BillViewLbl.Name = "BillViewLbl"
        Me.BillViewLbl.ReadOnly = True
        Me.BillViewLbl.Size = New System.Drawing.Size(87, 29)
        Me.BillViewLbl.TabIndex = 104
        '
        'TotalPriceViewLbl
        '
        Me.TotalPriceViewLbl.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceViewLbl.Location = New System.Drawing.Point(124, 41)
        Me.TotalPriceViewLbl.Name = "TotalPriceViewLbl"
        Me.TotalPriceViewLbl.ReadOnly = True
        Me.TotalPriceViewLbl.Size = New System.Drawing.Size(87, 29)
        Me.TotalPriceViewLbl.TabIndex = 105
        '
        'PriceViewLbl
        '
        Me.PriceViewLbl.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceViewLbl.Location = New System.Drawing.Point(399, 174)
        Me.PriceViewLbl.Name = "PriceViewLbl"
        Me.PriceViewLbl.ReadOnly = True
        Me.PriceViewLbl.Size = New System.Drawing.Size(172, 29)
        Me.PriceViewLbl.TabIndex = 106
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BillViewLbl)
        Me.Panel1.Controls.Add(Me.CheckoutBtn)
        Me.Panel1.Controls.Add(Me.TotalPriceViewLbl)
        Me.Panel1.Controls.Add(Me.TotalPriceLbl)
        Me.Panel1.Controls.Add(Me.DiscountLbl)
        Me.Panel1.Controls.Add(Me.BillBtn)
        Me.Panel1.Controls.Add(Me.DiscountTb)
        Me.Panel1.Location = New System.Drawing.Point(592, 285)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 226)
        Me.Panel1.TabIndex = 107
        '
        'CusNameLbl
        '
        Me.CusNameLbl.AutoSize = True
        Me.CusNameLbl.Location = New System.Drawing.Point(212, 16)
        Me.CusNameLbl.Name = "CusNameLbl"
        Me.CusNameLbl.Size = New System.Drawing.Size(66, 25)
        Me.CusNameLbl.TabIndex = 108
        Me.CusNameLbl.Text = "Name:"
        '
        'CusNameTb
        '
        Me.CusNameTb.Location = New System.Drawing.Point(284, 13)
        Me.CusNameTb.Name = "CusNameTb"
        Me.CusNameTb.Size = New System.Drawing.Size(182, 33)
        Me.CusNameTb.TabIndex = 109
        '
        'UserPanelBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 537)
        Me.Controls.Add(Me.CusNameTb)
        Me.Controls.Add(Me.CusNameLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PriceViewLbl)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.BookDGV)
        Me.Controls.Add(Me.TimeCB)
        Me.Controls.Add(Me.TimeLbl)
        Me.Controls.Add(Me.AddToBill)
        Me.Controls.Add(Me.DateDP)
        Me.Controls.Add(Me.DateLbl)
        Me.Controls.Add(Me.PriceLbl)
        Me.Controls.Add(Me.ServicesCB)
        Me.Controls.Add(Me.ServiceLbl)
        Me.Controls.Add(Me.CustomerInfoDGV)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.CIdTb)
        Me.Controls.Add(Me.CIdLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "UserPanelBook"
        Me.Text = "Book Appointment"
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CIdLbl As Label
    Friend WithEvents CIdTb As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents CustomerInfoDGV As DataGridView
    Friend WithEvents PriceLbl As Label
    Friend WithEvents ServicesCB As ComboBox
    Friend WithEvents ServiceLbl As Label
    Friend WithEvents TimeCB As ComboBox
    Friend WithEvents TimeLbl As Label
    Friend WithEvents AddToBill As Button
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents DateLbl As Label
    Friend WithEvents BookDGV As DataGridView
    Friend WithEvents BillBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents DiscountTb As TextBox
    Friend WithEvents DiscountLbl As Label
    Friend WithEvents TotalPriceLbl As Label
    Friend WithEvents CheckoutBtn As Button
    Friend WithEvents BillViewLbl As TextBox
    Friend WithEvents TotalPriceViewLbl As TextBox
    Friend WithEvents PriceViewLbl As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CusNameLbl As Label
    Friend WithEvents CusNameTb As TextBox
    Friend WithEvents ServicesIdCol As DataGridViewTextBoxColumn
    Friend WithEvents ServicesNameCol As DataGridViewTextBoxColumn
    Friend WithEvents DateCol As DataGridViewTextBoxColumn
    Friend WithEvents TimeIdCol As DataGridViewTextBoxColumn
    Friend WithEvents TimeCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
End Class
