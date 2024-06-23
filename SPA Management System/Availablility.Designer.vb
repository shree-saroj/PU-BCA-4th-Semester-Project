<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Availablility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Availablility))
        Me.AvailabilityPnl = New System.Windows.Forms.Panel()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.ServicesCB = New System.Windows.Forms.ComboBox()
        Me.ServiceLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.CheckAppointmentLbl = New System.Windows.Forms.Label()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ShiftBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.CustomersBtn = New System.Windows.Forms.Button()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.TimeCB = New System.Windows.Forms.ComboBox()
        Me.AvailabilityPnl.SuspendLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvailabilityPnl
        '
        Me.AvailabilityPnl.BackColor = System.Drawing.Color.White
        Me.AvailabilityPnl.Controls.Add(Me.TimeCB)
        Me.AvailabilityPnl.Controls.Add(Me.TimeLbl)
        Me.AvailabilityPnl.Controls.Add(Me.CheckBtn)
        Me.AvailabilityPnl.Controls.Add(Me.DateDP)
        Me.AvailabilityPnl.Controls.Add(Me.ServicesCB)
        Me.AvailabilityPnl.Controls.Add(Me.ServiceLbl)
        Me.AvailabilityPnl.Controls.Add(Me.DateLbl)
        Me.AvailabilityPnl.Controls.Add(Me.CheckAppointmentLbl)
        Me.AvailabilityPnl.Location = New System.Drawing.Point(172, 37)
        Me.AvailabilityPnl.Name = "AvailabilityPnl"
        Me.AvailabilityPnl.Size = New System.Drawing.Size(840, 527)
        Me.AvailabilityPnl.TabIndex = 0
        '
        'CheckBtn
        '
        Me.CheckBtn.BackColor = System.Drawing.Color.Yellow
        Me.CheckBtn.FlatAppearance.BorderSize = 0
        Me.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBtn.Location = New System.Drawing.Point(94, 119)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(200, 39)
        Me.CheckBtn.TabIndex = 61
        Me.CheckBtn.Text = "Check"
        Me.CheckBtn.UseVisualStyleBackColor = False
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDP.Location = New System.Drawing.Point(94, 84)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 60
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'ServicesCB
        '
        Me.ServicesCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesCB.FormattingEnabled = True
        Me.ServicesCB.Location = New System.Drawing.Point(95, 45)
        Me.ServicesCB.Name = "ServicesCB"
        Me.ServicesCB.Size = New System.Drawing.Size(199, 29)
        Me.ServicesCB.TabIndex = 59
        '
        'ServiceLbl
        '
        Me.ServiceLbl.AutoSize = True
        Me.ServiceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceLbl.Location = New System.Drawing.Point(12, 49)
        Me.ServiceLbl.Name = "ServiceLbl"
        Me.ServiceLbl.Size = New System.Drawing.Size(76, 25)
        Me.ServiceLbl.TabIndex = 57
        Me.ServiceLbl.Text = "Service:"
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(33, 88)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 58
        Me.DateLbl.Text = "Date:"
        '
        'CheckAppointmentLbl
        '
        Me.CheckAppointmentLbl.AutoSize = True
        Me.CheckAppointmentLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAppointmentLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CheckAppointmentLbl.Location = New System.Drawing.Point(341, 4)
        Me.CheckAppointmentLbl.Name = "CheckAppointmentLbl"
        Me.CheckAppointmentLbl.Size = New System.Drawing.Size(183, 25)
        Me.CheckAppointmentLbl.TabIndex = 0
        Me.CheckAppointmentLbl.Text = "Check Appointment"
        '
        'BookBtn
        '
        Me.BookBtn.BackColor = System.Drawing.Color.LightGray
        Me.BookBtn.FlatAppearance.BorderSize = 0
        Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBtn.Location = New System.Drawing.Point(12, 180)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(154, 63)
        Me.BookBtn.TabIndex = 4
        Me.BookBtn.Text = "Book" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.BookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.LightGray
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(12, 249)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(154, 63)
        Me.CancelBtn.TabIndex = 5
        Me.CancelBtn.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'ShiftBtn
        '
        Me.ShiftBtn.BackColor = System.Drawing.Color.LightGray
        Me.ShiftBtn.FlatAppearance.BorderSize = 0
        Me.ShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShiftBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftBtn.Location = New System.Drawing.Point(12, 318)
        Me.ShiftBtn.Name = "ShiftBtn"
        Me.ShiftBtn.Size = New System.Drawing.Size(154, 63)
        Me.ShiftBtn.TabIndex = 6
        Me.ShiftBtn.Text = "Shift Appointment"
        Me.ShiftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShiftBtn.UseVisualStyleBackColor = False
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
        Me.CustomersBtn.Location = New System.Drawing.Point(12, 111)
        Me.CustomersBtn.Name = "CustomersBtn"
        Me.CustomersBtn.Size = New System.Drawing.Size(154, 63)
        Me.CustomersBtn.TabIndex = 25
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
        Me.SmsPb.TabIndex = 7
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 2
        Me.ExitPb.TabStop = False
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.Location = New System.Drawing.Point(33, 181)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(57, 25)
        Me.TimeLbl.TabIndex = 62
        Me.TimeLbl.Text = "Time:"
        '
        'TimeCB
        '
        Me.TimeCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeCB.FormattingEnabled = True
        Me.TimeCB.Location = New System.Drawing.Point(96, 177)
        Me.TimeCB.Name = "TimeCB"
        Me.TimeCB.Size = New System.Drawing.Size(199, 29)
        Me.TimeCB.TabIndex = 63
        '
        'Availablility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.CustomersBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ShiftBtn)
        Me.Controls.Add(Me.BookBtn)
        Me.Controls.Add(Me.ExitPb)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AvailabilityPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Availablility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Availablility"
        Me.AvailabilityPnl.ResumeLayout(False)
        Me.AvailabilityPnl.PerformLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AvailabilityPnl As Panel
    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents BookBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ShiftBtn As Button
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents CheckAppointmentLbl As Label
    Friend WithEvents ServiceLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents ServicesCB As ComboBox
    Friend WithEvents CustomersBtn As Button
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents CheckBtn As Button
    Friend WithEvents TimeCB As ComboBox
    Friend WithEvents TimeLbl As Label
End Class
