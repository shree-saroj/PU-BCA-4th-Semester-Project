<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update))
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.AvailabilityBtn = New System.Windows.Forms.Button()
        Me.UpdatePnl = New System.Windows.Forms.Panel()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
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
        Me.CancelBtn.Location = New System.Drawing.Point(12, 255)
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
        Me.BookBtn.Location = New System.Drawing.Point(12, 177)
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
        Me.AvailabilityBtn.Location = New System.Drawing.Point(12, 101)
        Me.AvailabilityBtn.Name = "AvailabilityBtn"
        Me.AvailabilityBtn.Size = New System.Drawing.Size(154, 63)
        Me.AvailabilityBtn.TabIndex = 19
        Me.AvailabilityBtn.Text = "Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appointment"
        Me.AvailabilityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AvailabilityBtn.UseVisualStyleBackColor = False
        '
        'UpdatePnl
        '
        Me.UpdatePnl.BackColor = System.Drawing.Color.White
        Me.UpdatePnl.Location = New System.Drawing.Point(172, 37)
        Me.UpdatePnl.Name = "UpdatePnl"
        Me.UpdatePnl.Size = New System.Drawing.Size(840, 527)
        Me.UpdatePnl.TabIndex = 18
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
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.SmsPb)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.BookBtn)
        Me.Controls.Add(Me.AvailabilityBtn)
        Me.Controls.Add(Me.UpdatePnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
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
    Friend WithEvents UpdatePnl As Panel
    Friend WithEvents LogoutLbl As Label
End Class
