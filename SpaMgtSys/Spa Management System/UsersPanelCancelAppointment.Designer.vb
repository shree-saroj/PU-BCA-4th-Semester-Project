<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersPanelCancelAppointment
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
        Me.CusNameTb = New System.Windows.Forms.TextBox()
        Me.CusNameLbl = New System.Windows.Forms.Label()
        Me.CustomerInfoDGV = New System.Windows.Forms.DataGridView()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CIdTb = New System.Windows.Forms.TextBox()
        Me.CIdLbl = New System.Windows.Forms.Label()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.ShowBookingsBtn = New System.Windows.Forms.Button()
        Me.BookDGV = New System.Windows.Forms.DataGridView()
        Me.Usp_View_CustomersTableAdapter1 = New Spa_Management_System.SpaMgtSysDataSetTableAdapters.Usp_View_CustomersTableAdapter()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.RefundLbl = New System.Windows.Forms.Label()
        Me.RefundTb = New System.Windows.Forms.TextBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.BookIdLbl = New System.Windows.Forms.Label()
        Me.BookIdTb = New System.Windows.Forms.TextBox()
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CusNameTb
        '
        Me.CusNameTb.Location = New System.Drawing.Point(278, 12)
        Me.CusNameTb.Name = "CusNameTb"
        Me.CusNameTb.Size = New System.Drawing.Size(155, 33)
        Me.CusNameTb.TabIndex = 115
        '
        'CusNameLbl
        '
        Me.CusNameLbl.AutoSize = True
        Me.CusNameLbl.Location = New System.Drawing.Point(206, 15)
        Me.CusNameLbl.Name = "CusNameLbl"
        Me.CusNameLbl.Size = New System.Drawing.Size(66, 25)
        Me.CusNameLbl.TabIndex = 114
        Me.CusNameLbl.Text = "Name:"
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
        Me.CustomerInfoDGV.Location = New System.Drawing.Point(11, 51)
        Me.CustomerInfoDGV.Name = "CustomerInfoDGV"
        Me.CustomerInfoDGV.ReadOnly = True
        Me.CustomerInfoDGV.RowHeadersVisible = False
        Me.CustomerInfoDGV.RowTemplate.Height = 30
        Me.CustomerInfoDGV.RowTemplate.ReadOnly = True
        Me.CustomerInfoDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerInfoDGV.Size = New System.Drawing.Size(526, 110)
        Me.CustomerInfoDGV.TabIndex = 113
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(439, 12)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(88, 33)
        Me.SearchBtn.TabIndex = 112
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'CIdTb
        '
        Me.CIdTb.Location = New System.Drawing.Point(133, 12)
        Me.CIdTb.Name = "CIdTb"
        Me.CIdTb.Size = New System.Drawing.Size(67, 33)
        Me.CIdTb.TabIndex = 111
        '
        'CIdLbl
        '
        Me.CIdLbl.AutoSize = True
        Me.CIdLbl.Location = New System.Drawing.Point(7, 15)
        Me.CIdLbl.Name = "CIdLbl"
        Me.CIdLbl.Size = New System.Drawing.Size(120, 25)
        Me.CIdLbl.TabIndex = 110
        Me.CIdLbl.Text = "Customer ID:"
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDP.Location = New System.Drawing.Point(72, 174)
        Me.DateDP.MinDate = New Date(2024, 6, 25, 0, 0, 0, 0)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 117
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(11, 177)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 116
        Me.DateLbl.Text = "Date:"
        '
        'ShowBookingsBtn
        '
        Me.ShowBookingsBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ShowBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowBookingsBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBookingsBtn.Location = New System.Drawing.Point(278, 170)
        Me.ShowBookingsBtn.Name = "ShowBookingsBtn"
        Me.ShowBookingsBtn.Size = New System.Drawing.Size(202, 35)
        Me.ShowBookingsBtn.TabIndex = 118
        Me.ShowBookingsBtn.Text = "Show Bookings"
        Me.ShowBookingsBtn.UseVisualStyleBackColor = False
        '
        'BookDGV
        '
        Me.BookDGV.AllowUserToAddRows = False
        Me.BookDGV.AllowUserToDeleteRows = False
        Me.BookDGV.AllowUserToResizeColumns = False
        Me.BookDGV.AllowUserToResizeRows = False
        Me.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookDGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BookDGV.ColumnHeadersHeight = 30
        Me.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BookDGV.Location = New System.Drawing.Point(11, 211)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.ReadOnly = True
        Me.BookDGV.RowHeadersVisible = False
        Me.BookDGV.RowTemplate.Height = 30
        Me.BookDGV.RowTemplate.ReadOnly = True
        Me.BookDGV.Size = New System.Drawing.Size(528, 314)
        Me.BookDGV.TabIndex = 119
        '
        'Usp_View_CustomersTableAdapter1
        '
        Me.Usp_View_CustomersTableAdapter1.ClearBeforeFill = True
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(550, 298)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(154, 41)
        Me.CancelBtn.TabIndex = 122
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'RefundLbl
        '
        Me.RefundLbl.AutoSize = True
        Me.RefundLbl.Location = New System.Drawing.Point(550, 258)
        Me.RefundLbl.Name = "RefundLbl"
        Me.RefundLbl.Size = New System.Drawing.Size(76, 25)
        Me.RefundLbl.TabIndex = 123
        Me.RefundLbl.Text = "Refund:"
        '
        'RefundTb
        '
        Me.RefundTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundTb.Location = New System.Drawing.Point(632, 254)
        Me.RefundTb.Name = "RefundTb"
        Me.RefundTb.Size = New System.Drawing.Size(72, 29)
        Me.RefundTb.TabIndex = 124
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(586, 345)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(88, 33)
        Me.ResetBtn.TabIndex = 125
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'BookIdLbl
        '
        Me.BookIdLbl.AutoSize = True
        Me.BookIdLbl.Location = New System.Drawing.Point(545, 215)
        Me.BookIdLbl.Name = "BookIdLbl"
        Me.BookIdLbl.Size = New System.Drawing.Size(81, 25)
        Me.BookIdLbl.TabIndex = 121
        Me.BookIdLbl.Text = "Book ID:"
        '
        'BookIdTb
        '
        Me.BookIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookIdTb.Location = New System.Drawing.Point(632, 211)
        Me.BookIdTb.Name = "BookIdTb"
        Me.BookIdTb.ReadOnly = True
        Me.BookIdTb.Size = New System.Drawing.Size(72, 29)
        Me.BookIdTb.TabIndex = 120
        '
        'UsersPanelCancelAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 537)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.RefundTb)
        Me.Controls.Add(Me.RefundLbl)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.BookIdLbl)
        Me.Controls.Add(Me.BookIdTb)
        Me.Controls.Add(Me.BookDGV)
        Me.Controls.Add(Me.ShowBookingsBtn)
        Me.Controls.Add(Me.DateDP)
        Me.Controls.Add(Me.DateLbl)
        Me.Controls.Add(Me.CusNameTb)
        Me.Controls.Add(Me.CusNameLbl)
        Me.Controls.Add(Me.CustomerInfoDGV)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.CIdTb)
        Me.Controls.Add(Me.CIdLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UsersPanelCancelAppointment"
        Me.Text = "Cancel Appointment"
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CusNameTb As TextBox
    Friend WithEvents CusNameLbl As Label
    Friend WithEvents CustomerInfoDGV As DataGridView
    Friend WithEvents SearchBtn As Button
    Friend WithEvents CIdTb As TextBox
    Friend WithEvents CIdLbl As Label
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents DateLbl As Label
    Friend WithEvents ShowBookingsBtn As Button
    Friend WithEvents BookDGV As DataGridView
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Usp_View_CustomersTableAdapter1 As SpaMgtSysDataSetTableAdapters.Usp_View_CustomersTableAdapter
    Friend WithEvents CancelBtn As Button
    Friend WithEvents RefundLbl As Label
    Friend WithEvents RefundTb As TextBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents BookIdLbl As Label
    Friend WithEvents BookIdTb As TextBox
End Class
