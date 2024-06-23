<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel))
        Me.ShifitAppointmentBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.AvailabilityBtn = New System.Windows.Forms.Button()
        Me.CancelPnl = New System.Windows.Forms.Panel()
        Me.CancelAppointmentLbl = New System.Windows.Forms.Label()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.CustomersBtn = New System.Windows.Forms.Button()
        Me.CancelPnl.SuspendLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShifitAppointmentBtn
        '
        Me.ShifitAppointmentBtn.BackColor = System.Drawing.Color.LightGray
        Me.ShifitAppointmentBtn.FlatAppearance.BorderSize = 0
        Me.ShifitAppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShifitAppointmentBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShifitAppointmentBtn.Location = New System.Drawing.Point(12, 317)
        Me.ShifitAppointmentBtn.Name = "ShifitAppointmentBtn"
        Me.ShifitAppointmentBtn.Size = New System.Drawing.Size(154, 63)
        Me.ShifitAppointmentBtn.TabIndex = 16
        Me.ShifitAppointmentBtn.Text = "Shift Appointment"
        Me.ShifitAppointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShifitAppointmentBtn.UseVisualStyleBackColor = False
        '
        'BookBtn
        '
        Me.BookBtn.BackColor = System.Drawing.Color.LightGray
        Me.BookBtn.FlatAppearance.BorderSize = 0
        Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBtn.Location = New System.Drawing.Point(12, 248)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(154, 63)
        Me.BookBtn.TabIndex = 15
        Me.BookBtn.Text = "Book" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.BookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookBtn.UseVisualStyleBackColor = False
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
        Me.AvailabilityBtn.TabIndex = 14
        Me.AvailabilityBtn.Text = "Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.AvailabilityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AvailabilityBtn.UseVisualStyleBackColor = False
        '
        'CancelPnl
        '
        Me.CancelPnl.BackColor = System.Drawing.Color.White
        Me.CancelPnl.Controls.Add(Me.CancelAppointmentLbl)
        Me.CancelPnl.Location = New System.Drawing.Point(172, 37)
        Me.CancelPnl.Name = "CancelPnl"
        Me.CancelPnl.Size = New System.Drawing.Size(840, 527)
        Me.CancelPnl.TabIndex = 12
        '
        'CancelAppointmentLbl
        '
        Me.CancelAppointmentLbl.AutoSize = True
        Me.CancelAppointmentLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelAppointmentLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CancelAppointmentLbl.Location = New System.Drawing.Point(346, 4)
        Me.CancelAppointmentLbl.Name = "CancelAppointmentLbl"
        Me.CancelAppointmentLbl.Size = New System.Drawing.Size(188, 25)
        Me.CancelAppointmentLbl.TabIndex = 26
        Me.CancelAppointmentLbl.Text = "Cancel Appointment"
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
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 17
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 13
        Me.ExitPb.TabStop = False
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
        Me.CustomersBtn.TabIndex = 26
        Me.CustomersBtn.Text = "Manage Customers"
        Me.CustomersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomersBtn.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.CustomersBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ShifitAppointmentBtn)
        Me.Controls.Add(Me.BookBtn)
        Me.Controls.Add(Me.AvailabilityBtn)
        Me.Controls.Add(Me.ExitPb)
        Me.Controls.Add(Me.CancelPnl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Cancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cancel"
        Me.CancelPnl.ResumeLayout(False)
        Me.CancelPnl.PerformLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ShifitAppointmentBtn As Button
    Friend WithEvents BookBtn As Button
    Friend WithEvents AvailabilityBtn As Button
    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents CancelPnl As Panel
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents CancelAppointmentLbl As Label
    Friend WithEvents CustomersBtn As Button
End Class
