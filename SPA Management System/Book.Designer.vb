<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        Me.BookPnl = New System.Windows.Forms.Panel()
        Me.BillBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.BillViewLbl = New System.Windows.Forms.Label()
        Me.DiscountTb = New System.Windows.Forms.TextBox()
        Me.DiscountLbl = New System.Windows.Forms.Label()
        Me.TotalPriceViewLbl = New System.Windows.Forms.Label()
        Me.TotalPriceLbl = New System.Windows.Forms.Label()
        Me.CheckoutBtn = New System.Windows.Forms.Button()
        Me.PriceViewLbl = New System.Windows.Forms.Label()
        Me.TimeCB = New System.Windows.Forms.ComboBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.AddToBill = New System.Windows.Forms.Button()
        Me.BookDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ServicesCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TImeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.ServicesCB = New System.Windows.Forms.ComboBox()
        Me.ServiceLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.CustomerInfoDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CustomerIdLbl = New System.Windows.Forms.Label()
        Me.CIdTb = New System.Windows.Forms.TextBox()
        Me.BookAppointmentLbl = New System.Windows.Forms.Label()
        Me.ShiftAppointmentBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AvailabilityBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.CustomersBtn = New System.Windows.Forms.Button()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.BookPnl.SuspendLayout()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookPnl
        '
        Me.BookPnl.BackColor = System.Drawing.Color.White
        Me.BookPnl.Controls.Add(Me.BillBtn)
        Me.BookPnl.Controls.Add(Me.ResetBtn)
        Me.BookPnl.Controls.Add(Me.PriceLbl)
        Me.BookPnl.Controls.Add(Me.BillViewLbl)
        Me.BookPnl.Controls.Add(Me.DiscountTb)
        Me.BookPnl.Controls.Add(Me.DiscountLbl)
        Me.BookPnl.Controls.Add(Me.TotalPriceViewLbl)
        Me.BookPnl.Controls.Add(Me.TotalPriceLbl)
        Me.BookPnl.Controls.Add(Me.CheckoutBtn)
        Me.BookPnl.Controls.Add(Me.PriceViewLbl)
        Me.BookPnl.Controls.Add(Me.TimeCB)
        Me.BookPnl.Controls.Add(Me.TimeLbl)
        Me.BookPnl.Controls.Add(Me.AddToBill)
        Me.BookPnl.Controls.Add(Me.BookDGV)
        Me.BookPnl.Controls.Add(Me.DateDP)
        Me.BookPnl.Controls.Add(Me.ServicesCB)
        Me.BookPnl.Controls.Add(Me.ServiceLbl)
        Me.BookPnl.Controls.Add(Me.DateLbl)
        Me.BookPnl.Controls.Add(Me.CustomerInfoDGV)
        Me.BookPnl.Controls.Add(Me.SearchBtn)
        Me.BookPnl.Controls.Add(Me.CustomerIdLbl)
        Me.BookPnl.Controls.Add(Me.CIdTb)
        Me.BookPnl.Controls.Add(Me.BookAppointmentLbl)
        Me.BookPnl.Location = New System.Drawing.Point(172, 37)
        Me.BookPnl.Name = "BookPnl"
        Me.BookPnl.Size = New System.Drawing.Size(840, 527)
        Me.BookPnl.TabIndex = 1
        '
        'BillBtn
        '
        Me.BillBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BillBtn.FlatAppearance.BorderSize = 0
        Me.BillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillBtn.Location = New System.Drawing.Point(672, 281)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(62, 31)
        Me.BillBtn.TabIndex = 87
        Me.BillBtn.Text = "Bill"
        Me.BillBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(672, 318)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(82, 31)
        Me.ResetBtn.TabIndex = 86
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.Location = New System.Drawing.Point(598, 33)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(58, 25)
        Me.PriceLbl.TabIndex = 85
        Me.PriceLbl.Text = "Price:"
        '
        'BillViewLbl
        '
        Me.BillViewLbl.AutoSize = True
        Me.BillViewLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillViewLbl.Location = New System.Drawing.Point(750, 284)
        Me.BillViewLbl.Name = "BillViewLbl"
        Me.BillViewLbl.Size = New System.Drawing.Size(0, 25)
        Me.BillViewLbl.TabIndex = 84
        '
        'DiscountTb
        '
        Me.DiscountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiscountTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTb.Location = New System.Drawing.Point(763, 249)
        Me.DiscountTb.Name = "DiscountTb"
        Me.DiscountTb.Size = New System.Drawing.Size(55, 29)
        Me.DiscountTb.TabIndex = 82
        Me.DiscountTb.Text = "0"
        '
        'DiscountLbl
        '
        Me.DiscountLbl.AutoSize = True
        Me.DiscountLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLbl.Location = New System.Drawing.Point(672, 253)
        Me.DiscountLbl.Name = "DiscountLbl"
        Me.DiscountLbl.Size = New System.Drawing.Size(95, 25)
        Me.DiscountLbl.TabIndex = 81
        Me.DiscountLbl.Text = "Discount: "
        '
        'TotalPriceViewLbl
        '
        Me.TotalPriceViewLbl.AutoSize = True
        Me.TotalPriceViewLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceViewLbl.Location = New System.Drawing.Point(734, 221)
        Me.TotalPriceViewLbl.Name = "TotalPriceViewLbl"
        Me.TotalPriceViewLbl.Size = New System.Drawing.Size(0, 25)
        Me.TotalPriceViewLbl.TabIndex = 80
        '
        'TotalPriceLbl
        '
        Me.TotalPriceLbl.AutoSize = True
        Me.TotalPriceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLbl.Location = New System.Drawing.Point(672, 221)
        Me.TotalPriceLbl.Name = "TotalPriceLbl"
        Me.TotalPriceLbl.Size = New System.Drawing.Size(61, 25)
        Me.TotalPriceLbl.TabIndex = 79
        Me.TotalPriceLbl.Text = "Total: "
        '
        'CheckoutBtn
        '
        Me.CheckoutBtn.BackColor = System.Drawing.Color.Yellow
        Me.CheckoutBtn.FlatAppearance.BorderSize = 0
        Me.CheckoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckoutBtn.Location = New System.Drawing.Point(672, 355)
        Me.CheckoutBtn.Name = "CheckoutBtn"
        Me.CheckoutBtn.Size = New System.Drawing.Size(126, 33)
        Me.CheckoutBtn.TabIndex = 78
        Me.CheckoutBtn.Text = "Book"
        Me.CheckoutBtn.UseVisualStyleBackColor = False
        '
        'PriceViewLbl
        '
        Me.PriceViewLbl.AutoSize = True
        Me.PriceViewLbl.Location = New System.Drawing.Point(661, 34)
        Me.PriceViewLbl.Name = "PriceViewLbl"
        Me.PriceViewLbl.Size = New System.Drawing.Size(0, 25)
        Me.PriceViewLbl.TabIndex = 76
        '
        'TimeCB
        '
        Me.TimeCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeCB.FormattingEnabled = True
        Me.TimeCB.Location = New System.Drawing.Point(356, 168)
        Me.TimeCB.Name = "TimeCB"
        Me.TimeCB.Size = New System.Drawing.Size(201, 29)
        Me.TimeCB.TabIndex = 74
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.Location = New System.Drawing.Point(293, 171)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(57, 25)
        Me.TimeLbl.TabIndex = 73
        Me.TimeLbl.Text = "Time:"
        '
        'AddToBill
        '
        Me.AddToBill.BackColor = System.Drawing.Color.Yellow
        Me.AddToBill.FlatAppearance.BorderSize = 0
        Me.AddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddToBill.Location = New System.Drawing.Point(576, 164)
        Me.AddToBill.Name = "AddToBill"
        Me.AddToBill.Size = New System.Drawing.Size(126, 33)
        Me.AddToBill.TabIndex = 72
        Me.AddToBill.Text = "Add To Bill"
        Me.AddToBill.UseVisualStyleBackColor = False
        '
        'BookDGV
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.BookDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.BookDGV.ColumnHeadersHeight = 27
        Me.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BookDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicesCol, Me.DateCol, Me.TImeCol, Me.PriceCol})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookDGV.DefaultCellStyle = DataGridViewCellStyle15
        Me.BookDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.Location = New System.Drawing.Point(13, 211)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.RowHeadersVisible = False
        Me.BookDGV.Size = New System.Drawing.Size(653, 295)
        Me.BookDGV.TabIndex = 71
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BookDGV.ThemeStyle.HeaderStyle.Height = 27
        Me.BookDGV.ThemeStyle.ReadOnly = False
        Me.BookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BookDGV.ThemeStyle.RowsStyle.Height = 22
        Me.BookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ServicesCol
        '
        Me.ServicesCol.FillWeight = 125.0!
        Me.ServicesCol.HeaderText = "Services"
        Me.ServicesCol.Name = "ServicesCol"
        '
        'DateCol
        '
        Me.DateCol.HeaderText = "Date"
        Me.DateCol.Name = "DateCol"
        Me.DateCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'TImeCol
        '
        Me.TImeCol.HeaderText = "Time"
        Me.TImeCol.Name = "TImeCol"
        '
        'PriceCol
        '
        Me.PriceCol.HeaderText = "Price"
        Me.PriceCol.Name = "PriceCol"
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDP.Location = New System.Drawing.Point(86, 168)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 70
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'ServicesCB
        '
        Me.ServicesCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesCB.FormattingEnabled = True
        Me.ServicesCB.Location = New System.Drawing.Point(371, 31)
        Me.ServicesCB.Name = "ServicesCB"
        Me.ServicesCB.Size = New System.Drawing.Size(199, 29)
        Me.ServicesCB.TabIndex = 69
        '
        'ServiceLbl
        '
        Me.ServiceLbl.AutoSize = True
        Me.ServiceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceLbl.Location = New System.Drawing.Point(293, 32)
        Me.ServiceLbl.Name = "ServiceLbl"
        Me.ServiceLbl.Size = New System.Drawing.Size(76, 25)
        Me.ServiceLbl.TabIndex = 67
        Me.ServiceLbl.Text = "Service:"
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(25, 171)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 68
        Me.DateLbl.Text = "Date:"
        '
        'CustomerInfoDGV
        '
        Me.CustomerInfoDGV.AllowUserToAddRows = False
        Me.CustomerInfoDGV.AllowUserToDeleteRows = False
        Me.CustomerInfoDGV.AllowUserToResizeColumns = False
        Me.CustomerInfoDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerInfoDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.CustomerInfoDGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.DefaultCellStyle = DataGridViewCellStyle18
        Me.CustomerInfoDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerInfoDGV.Location = New System.Drawing.Point(14, 68)
        Me.CustomerInfoDGV.Name = "CustomerInfoDGV"
        Me.CustomerInfoDGV.ReadOnly = True
        Me.CustomerInfoDGV.RowHeadersVisible = False
        Me.CustomerInfoDGV.RowTemplate.Height = 30
        Me.CustomerInfoDGV.RowTemplate.ReadOnly = True
        Me.CustomerInfoDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.Size = New System.Drawing.Size(814, 84)
        Me.CustomerInfoDGV.TabIndex = 66
        Me.CustomerInfoDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CustomerInfoDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CustomerInfoDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CustomerInfoDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CustomerInfoDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CustomerInfoDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.CustomerInfoDGV.ThemeStyle.ReadOnly = True
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.Height = 30
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerInfoDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Location = New System.Drawing.Point(204, 28)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(82, 31)
        Me.SearchBtn.TabIndex = 65
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'CustomerIdLbl
        '
        Me.CustomerIdLbl.AutoSize = True
        Me.CustomerIdLbl.Location = New System.Drawing.Point(6, 31)
        Me.CustomerIdLbl.Name = "CustomerIdLbl"
        Me.CustomerIdLbl.Size = New System.Drawing.Size(120, 25)
        Me.CustomerIdLbl.TabIndex = 50
        Me.CustomerIdLbl.Text = "Customer ID:"
        '
        'CIdTb
        '
        Me.CIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIdTb.Location = New System.Drawing.Point(132, 29)
        Me.CIdTb.Name = "CIdTb"
        Me.CIdTb.Size = New System.Drawing.Size(66, 29)
        Me.CIdTb.TabIndex = 51
        '
        'BookAppointmentLbl
        '
        Me.BookAppointmentLbl.AutoSize = True
        Me.BookAppointmentLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookAppointmentLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BookAppointmentLbl.Location = New System.Drawing.Point(341, 3)
        Me.BookAppointmentLbl.Name = "BookAppointmentLbl"
        Me.BookAppointmentLbl.Size = New System.Drawing.Size(174, 25)
        Me.BookAppointmentLbl.TabIndex = 25
        Me.BookAppointmentLbl.Text = "Book Appointment"
        '
        'ShiftAppointmentBtn
        '
        Me.ShiftAppointmentBtn.BackColor = System.Drawing.Color.LightGray
        Me.ShiftAppointmentBtn.FlatAppearance.BorderSize = 0
        Me.ShiftAppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShiftAppointmentBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftAppointmentBtn.Location = New System.Drawing.Point(12, 317)
        Me.ShiftAppointmentBtn.Name = "ShiftAppointmentBtn"
        Me.ShiftAppointmentBtn.Size = New System.Drawing.Size(154, 63)
        Me.ShiftAppointmentBtn.TabIndex = 10
        Me.ShiftAppointmentBtn.Text = "Shift Appointment"
        Me.ShiftAppointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShiftAppointmentBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.LightGray
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(12, 248)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(154, 63)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'AvailabilityBtn
        '
        Me.AvailabilityBtn.BackColor = System.Drawing.Color.LightGray
        Me.AvailabilityBtn.FlatAppearance.BorderSize = 0
        Me.AvailabilityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvailabilityBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailabilityBtn.Location = New System.Drawing.Point(12, 110)
        Me.AvailabilityBtn.Name = "AvailabilityBtn"
        Me.AvailabilityBtn.Size = New System.Drawing.Size(154, 63)
        Me.AvailabilityBtn.TabIndex = 8
        Me.AvailabilityBtn.Text = "Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.AvailabilityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AvailabilityBtn.UseVisualStyleBackColor = False
        '
        'LogoutLbl
        '
        Me.LogoutLbl.AutoSize = True
        Me.LogoutLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLbl.Location = New System.Drawing.Point(46, 527)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(71, 25)
        Me.LogoutLbl.TabIndex = 24
        Me.LogoutLbl.Text = "Logout"
        '
        'CustomersBtn
        '
        Me.CustomersBtn.BackColor = System.Drawing.Color.LightGray
        Me.CustomersBtn.FlatAppearance.BorderSize = 0
        Me.CustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomersBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersBtn.Location = New System.Drawing.Point(12, 179)
        Me.CustomersBtn.Name = "CustomersBtn"
        Me.CustomersBtn.Size = New System.Drawing.Size(154, 63)
        Me.CustomersBtn.TabIndex = 27
        Me.CustomersBtn.Text = "Manage Customers"
        Me.CustomersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomersBtn.UseVisualStyleBackColor = False
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 11
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 3
        Me.ExitPb.TabStop = False
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.CustomersBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ShiftAppointmentBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AvailabilityBtn)
        Me.Controls.Add(Me.ExitPb)
        Me.Controls.Add(Me.BookPnl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book"
        Me.BookPnl.ResumeLayout(False)
        Me.BookPnl.PerformLayout()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookPnl As Panel
    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ShiftAppointmentBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents AvailabilityBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents BookAppointmentLbl As Label
    Friend WithEvents CustomersBtn As Button
    Friend WithEvents CustomerIdLbl As Label
    Friend WithEvents CIdTb As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents CustomerInfoDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents ServicesCB As ComboBox
    Friend WithEvents ServiceLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents BookDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddToBill As Button
    Friend WithEvents TimeCB As ComboBox
    Friend WithEvents TimeLbl As Label
    Friend WithEvents PriceViewLbl As Label
    Friend WithEvents BillViewLbl As Label
    Friend WithEvents DiscountTb As TextBox
    Friend WithEvents DiscountLbl As Label
    Friend WithEvents TotalPriceViewLbl As Label
    Friend WithEvents TotalPriceLbl As Label
    Friend WithEvents CheckoutBtn As Button
    Friend WithEvents PriceLbl As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ServicesCol As DataGridViewTextBoxColumn
    Friend WithEvents DateCol As DataGridViewTextBoxColumn
    Friend WithEvents TImeCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents BillBtn As Button
End Class
