<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTransactions))
        Me.ManageEmployeesBtn = New System.Windows.Forms.Button()
        Me.ViewStatisticsBtn = New System.Windows.Forms.Button()
        Me.LogoutLbl = New System.Windows.Forms.Label()
        Me.ManageUsersBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerInfoBtn = New System.Windows.Forms.Button()
        Me.ManageServicesBtn = New System.Windows.Forms.Button()
        Me.ViewTransactionsPnl = New System.Windows.Forms.Panel()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ManageEmployeesBtn.TabIndex = 39
        Me.ManageEmployeesBtn.Text = "Manage Employees"
        Me.ManageEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageEmployeesBtn.UseVisualStyleBackColor = False
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
        Me.ViewStatisticsBtn.TabIndex = 38
        Me.ViewStatisticsBtn.Text = "View Statistics"
        Me.ViewStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewStatisticsBtn.UseVisualStyleBackColor = False
        '
        'LogoutLbl
        '
        Me.LogoutLbl.AutoSize = True
        Me.LogoutLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLbl.Location = New System.Drawing.Point(46, 527)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(71, 25)
        Me.LogoutLbl.TabIndex = 37
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
        Me.ManageUsersBtn.TabIndex = 35
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
        Me.ViewCustomerInfoBtn.TabIndex = 34
        Me.ViewCustomerInfoBtn.Text = "View " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer Info"
        Me.ViewCustomerInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewCustomerInfoBtn.UseVisualStyleBackColor = False
        '
        'ManageServicesBtn
        '
        Me.ManageServicesBtn.BackColor = System.Drawing.Color.LightGray
        Me.ManageServicesBtn.FlatAppearance.BorderSize = 0
        Me.ManageServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageServicesBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageServicesBtn.Location = New System.Drawing.Point(12, 101)
        Me.ManageServicesBtn.Name = "ManageServicesBtn"
        Me.ManageServicesBtn.Size = New System.Drawing.Size(154, 63)
        Me.ManageServicesBtn.TabIndex = 33
        Me.ManageServicesBtn.Text = "Manage Services"
        Me.ManageServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageServicesBtn.UseVisualStyleBackColor = False
        '
        'ViewTransactionsPnl
        '
        Me.ViewTransactionsPnl.BackColor = System.Drawing.Color.White
        Me.ViewTransactionsPnl.Location = New System.Drawing.Point(172, 37)
        Me.ViewTransactionsPnl.Name = "ViewTransactionsPnl"
        Me.ViewTransactionsPnl.Size = New System.Drawing.Size(840, 527)
        Me.ViewTransactionsPnl.TabIndex = 32
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(12, 12)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(154, 83)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 36
        Me.SmsPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 16
        Me.ExitPb.TabStop = False
        '
        'ViewTransactions
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
        Me.Controls.Add(Me.ManageServicesBtn)
        Me.Controls.Add(Me.ViewTransactionsPnl)
        Me.Controls.Add(Me.ExitPb)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ViewTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewTransactions"
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents ManageEmployeesBtn As Button
    Friend WithEvents ViewStatisticsBtn As Button
    Friend WithEvents LogoutLbl As Label
    Friend WithEvents SmsPb As PictureBox
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents ViewCustomerInfoBtn As Button
    Friend WithEvents ManageServicesBtn As Button
    Friend WithEvents ViewTransactionsPnl As Panel
End Class
