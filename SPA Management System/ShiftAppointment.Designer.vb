<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShiftAppointment))
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.AvailabilityBtn = New System.Windows.Forms.Button()
        Me.ShiftAppointmentPnl = New System.Windows.Forms.Panel()
        Me.ShiftAppointmentLbl = New System.Windows.Forms.Label()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.CustomersBtn = New System.Windows.Forms.Button()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.ShiftAppointmentPnl.SuspendLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.LightGray
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(12, 319)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(154, 63)
        Me.CancelBtn.TabIndex = 21
        Me.CancelBtn.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'BookBtn
        '
        Me.BookBtn.BackColor = System.Drawing.Color.LightGray
        Me.BookBtn.FlatAppearance.BorderSize = 0
        Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBtn.Location = New System.Drawing.Point(12, 250)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(154, 63)
        Me.BookBtn.TabIndex = 20
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
        Me.AvailabilityBtn.Location = New System.Drawing.Point(12, 112)
        Me.AvailabilityBtn.Name = "AvailabilityBtn"
        Me.AvailabilityBtn.Size = New System.Drawing.Size(154, 63)
        Me.AvailabilityBtn.TabIndex = 19
        Me.AvailabilityBtn.Text = "Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.AvailabilityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AvailabilityBtn.UseVisualStyleBackColor = False
        '
        'ShiftAppointmentPnl
        '
        Me.ShiftAppointmentPnl.BackColor = System.Drawing.Color.White
        Me.ShiftAppointmentPnl.Controls.Add(Me.ShiftAppointmentLbl)
        Me.ShiftAppointmentPnl.Location = New System.Drawing.Point(172, 37)
        Me.ShiftAppointmentPnl.Name = "ShiftAppointmentPnl"
        Me.ShiftAppointmentPnl.Size = New System.Drawing.Size(840, 527)
        Me.ShiftAppointmentPnl.TabIndex = 18
        '
        'ShiftAppointmentLbl
        '
        Me.ShiftAppointmentLbl.AutoSize = True
        Me.ShiftAppointmentLbl.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftAppointmentLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ShiftAppointmentLbl.Location = New System.Drawing.Point(330, 1)
        Me.ShiftAppointmentLbl.Name = "ShiftAppointmentLbl"
        Me.ShiftAppointmentLbl.Size = New System.Drawing.Size(171, 25)
        Me.ShiftAppointmentLbl.TabIndex = 27
        Me.ShiftAppointmentLbl.Text = "Shift Appointment"
        '
        'LogoutLbl
        '
        Me.LogoutLbl.AutoSize = True
        Me.LogoutLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLbl.Location = New System.Drawing.Point(46, 527)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(71, 25)
        Me.LogoutLbl.TabIndex = 23
        Me.LogoutLbl.Text = "Logout"
        '
        'CustomersBtn
        '
        Me.CustomersBtn.BackColor = System.Drawing.Color.LightGray
        Me.CustomersBtn.FlatAppearance.BorderSize = 0
        Me.CustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomersBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersBtn.Location = New System.Drawing.Point(12, 181)
        Me.CustomersBtn.Name = "CustomersBtn"
        Me.CustomersBtn.Size = New System.Drawing.Size(154, 63)
        Me.CustomersBtn.TabIndex = 26
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
        Me.SmsPb.TabIndex = 22
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 14
        Me.ExitPb.TabStop = False
        '
        'ShiftAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.CustomersBtn)
        Me.Controls.Add(Me.AvailabilityBtn)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.BookBtn)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.ShiftAppointmentPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ShiftAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.ShiftAppointmentPnl.ResumeLayout(False)
        Me.ShiftAppointmentPnl.PerformLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents BookBtn As Button
    Friend WithEvents AvailabilityBtn As Button
    Friend WithEvents ShiftAppointmentPnl As Panel
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents ShiftAppointmentLbl As Label
    Friend WithEvents CustomersBtn As Button
End Class
