<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersPanelShiftAppointment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CusNameTb = New System.Windows.Forms.TextBox()
        Me.CusNameLbl = New System.Windows.Forms.Label()
        Me.CustomerInfoDGV = New System.Windows.Forms.DataGridView()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CIdTb = New System.Windows.Forms.TextBox()
        Me.CIdLbl = New System.Windows.Forms.Label()
        Me.BookDGV = New System.Windows.Forms.DataGridView()
        Me.ShowBookingsBtn = New System.Windows.Forms.Button()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.BookIdTb = New System.Windows.Forms.TextBox()
        Me.BookIdLbl = New System.Windows.Forms.Label()
        Me.NewDateDP = New System.Windows.Forms.DateTimePicker()
        Me.NewDateLbl = New System.Windows.Forms.Label()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.TimeCB = New System.Windows.Forms.ComboBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ShiftBtn = New System.Windows.Forms.Button()
        Me.ServiceIdLbl = New System.Windows.Forms.Label()
        Me.ServiceIdTb = New System.Windows.Forms.TextBox()
        CType(Me.CustomerInfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CusNameTb
        '
        Me.CusNameTb.Location = New System.Drawing.Point(278, 5)
        Me.CusNameTb.Name = "CusNameTb"
        Me.CusNameTb.Size = New System.Drawing.Size(155, 33)
        Me.CusNameTb.TabIndex = 121
        '
        'CusNameLbl
        '
        Me.CusNameLbl.AutoSize = True
        Me.CusNameLbl.Location = New System.Drawing.Point(206, 8)
        Me.CusNameLbl.Name = "CusNameLbl"
        Me.CusNameLbl.Size = New System.Drawing.Size(66, 25)
        Me.CusNameLbl.TabIndex = 120
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
        Me.CustomerInfoDGV.Location = New System.Drawing.Point(12, 44)
        Me.CustomerInfoDGV.Name = "CustomerInfoDGV"
        Me.CustomerInfoDGV.ReadOnly = True
        Me.CustomerInfoDGV.RowHeadersVisible = False
        Me.CustomerInfoDGV.RowTemplate.Height = 30
        Me.CustomerInfoDGV.RowTemplate.ReadOnly = True
        Me.CustomerInfoDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerInfoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerInfoDGV.Size = New System.Drawing.Size(526, 110)
        Me.CustomerInfoDGV.TabIndex = 119
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(439, 5)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(88, 33)
        Me.SearchBtn.TabIndex = 118
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'CIdTb
        '
        Me.CIdTb.Location = New System.Drawing.Point(133, 5)
        Me.CIdTb.Name = "CIdTb"
        Me.CIdTb.Size = New System.Drawing.Size(67, 33)
        Me.CIdTb.TabIndex = 117
        '
        'CIdLbl
        '
        Me.CIdLbl.AutoSize = True
        Me.CIdLbl.Location = New System.Drawing.Point(7, 8)
        Me.CIdLbl.Name = "CIdLbl"
        Me.CIdLbl.Size = New System.Drawing.Size(120, 25)
        Me.CIdLbl.TabIndex = 116
        Me.CIdLbl.Text = "Customer ID:"
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
        Me.BookDGV.Location = New System.Drawing.Point(12, 211)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.ReadOnly = True
        Me.BookDGV.RowHeadersVisible = False
        Me.BookDGV.RowTemplate.Height = 30
        Me.BookDGV.RowTemplate.ReadOnly = True
        Me.BookDGV.Size = New System.Drawing.Size(528, 314)
        Me.BookDGV.TabIndex = 125
        '
        'ShowBookingsBtn
        '
        Me.ShowBookingsBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ShowBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowBookingsBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBookingsBtn.Location = New System.Drawing.Point(279, 170)
        Me.ShowBookingsBtn.Name = "ShowBookingsBtn"
        Me.ShowBookingsBtn.Size = New System.Drawing.Size(202, 35)
        Me.ShowBookingsBtn.TabIndex = 124
        Me.ShowBookingsBtn.Text = "Show Bookings"
        Me.ShowBookingsBtn.UseVisualStyleBackColor = False
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDP.Location = New System.Drawing.Point(73, 174)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 123
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(12, 177)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 122
        Me.DateLbl.Text = "Date:"
        '
        'BookIdTb
        '
        Me.BookIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookIdTb.Location = New System.Drawing.Point(717, 35)
        Me.BookIdTb.Name = "BookIdTb"
        Me.BookIdTb.ReadOnly = True
        Me.BookIdTb.Size = New System.Drawing.Size(129, 29)
        Me.BookIdTb.TabIndex = 120
        '
        'BookIdLbl
        '
        Me.BookIdLbl.AutoSize = True
        Me.BookIdLbl.Location = New System.Drawing.Point(630, 39)
        Me.BookIdLbl.Name = "BookIdLbl"
        Me.BookIdLbl.Size = New System.Drawing.Size(81, 25)
        Me.BookIdLbl.TabIndex = 121
        Me.BookIdLbl.Text = "Book ID:"
        '
        'NewDateDP
        '
        Me.NewDateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDateDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NewDateDP.Location = New System.Drawing.Point(717, 116)
        Me.NewDateDP.Name = "NewDateDP"
        Me.NewDateDP.Size = New System.Drawing.Size(129, 29)
        Me.NewDateDP.TabIndex = 127
        Me.NewDateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'NewDateLbl
        '
        Me.NewDateLbl.AutoSize = True
        Me.NewDateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDateLbl.Location = New System.Drawing.Point(656, 119)
        Me.NewDateLbl.Name = "NewDateLbl"
        Me.NewDateLbl.Size = New System.Drawing.Size(55, 25)
        Me.NewDateLbl.TabIndex = 126
        Me.NewDateLbl.Text = "Date:"
        '
        'CheckBtn
        '
        Me.CheckBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBtn.Location = New System.Drawing.Point(736, 151)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(88, 33)
        Me.CheckBtn.TabIndex = 128
        Me.CheckBtn.Text = "Check"
        Me.CheckBtn.UseVisualStyleBackColor = False
        '
        'TimeCB
        '
        Me.TimeCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeCB.FormatString = "t"
        Me.TimeCB.FormattingEnabled = True
        Me.TimeCB.Location = New System.Drawing.Point(717, 190)
        Me.TimeCB.Name = "TimeCB"
        Me.TimeCB.Size = New System.Drawing.Size(129, 29)
        Me.TimeCB.TabIndex = 130
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.Location = New System.Drawing.Point(654, 194)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(57, 25)
        Me.TimeLbl.TabIndex = 129
        Me.TimeLbl.Text = "Time:"
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(736, 281)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(88, 33)
        Me.ResetBtn.TabIndex = 126
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'ShiftBtn
        '
        Me.ShiftBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.ShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShiftBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftBtn.Location = New System.Drawing.Point(703, 234)
        Me.ShiftBtn.Name = "ShiftBtn"
        Me.ShiftBtn.Size = New System.Drawing.Size(154, 41)
        Me.ShiftBtn.TabIndex = 126
        Me.ShiftBtn.Text = "Shift"
        Me.ShiftBtn.UseVisualStyleBackColor = False
        '
        'ServiceIdLbl
        '
        Me.ServiceIdLbl.AutoSize = True
        Me.ServiceIdLbl.Location = New System.Drawing.Point(614, 74)
        Me.ServiceIdLbl.Name = "ServiceIdLbl"
        Me.ServiceIdLbl.Size = New System.Drawing.Size(97, 25)
        Me.ServiceIdLbl.TabIndex = 132
        Me.ServiceIdLbl.Text = "Service Id:"
        '
        'ServiceIdTb
        '
        Me.ServiceIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceIdTb.Location = New System.Drawing.Point(717, 70)
        Me.ServiceIdTb.Name = "ServiceIdTb"
        Me.ServiceIdTb.ReadOnly = True
        Me.ServiceIdTb.Size = New System.Drawing.Size(129, 29)
        Me.ServiceIdTb.TabIndex = 131
        '
        'UsersPanelShiftAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.ServiceIdLbl)
        Me.Controls.Add(Me.ServiceIdTb)
        Me.Controls.Add(Me.ShiftBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.TimeCB)
        Me.Controls.Add(Me.TimeLbl)
        Me.Controls.Add(Me.CheckBtn)
        Me.Controls.Add(Me.NewDateDP)
        Me.Controls.Add(Me.NewDateLbl)
        Me.Controls.Add(Me.BookDGV)
        Me.Controls.Add(Me.ShowBookingsBtn)
        Me.Controls.Add(Me.DateDP)
        Me.Controls.Add(Me.DateLbl)
        Me.Controls.Add(Me.BookIdLbl)
        Me.Controls.Add(Me.CusNameTb)
        Me.Controls.Add(Me.BookIdTb)
        Me.Controls.Add(Me.CusNameLbl)
        Me.Controls.Add(Me.CustomerInfoDGV)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.CIdTb)
        Me.Controls.Add(Me.CIdLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UsersPanelShiftAppointment"
        Me.Text = "Shift Appointment"
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
    Friend WithEvents BookDGV As DataGridView
    Friend WithEvents ShowBookingsBtn As Button
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents DateLbl As Label
    Friend WithEvents BookIdTb As TextBox
    Friend WithEvents BookIdLbl As Label
    Friend WithEvents NewDateDP As DateTimePicker
    Friend WithEvents NewDateLbl As Label
    Friend WithEvents CheckBtn As Button
    Friend WithEvents TimeCB As ComboBox
    Friend WithEvents TimeLbl As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ShiftBtn As Button
    Friend WithEvents ServiceIdLbl As Label
    Friend WithEvents ServiceIdTb As TextBox
End Class
