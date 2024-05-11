<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginPnl = New System.Windows.Forms.Panel()
        Me.SmsPb = New System.Windows.Forms.PictureBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.UnameLbl = New System.Windows.Forms.Label()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.SigninLbl = New System.Windows.Forms.Label()
        Me.UserPb = New System.Windows.Forms.PictureBox()
        Me.ExitPb = New System.Windows.Forms.PictureBox()
        Me.LoginPnl.SuspendLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginPnl
        '
        Me.LoginPnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPnl.BackColor = System.Drawing.Color.Snow
        Me.LoginPnl.Controls.Add(Me.SmsPb)
        Me.LoginPnl.Controls.Add(Me.LoginBtn)
        Me.LoginPnl.Controls.Add(Me.PasswordLbl)
        Me.LoginPnl.Controls.Add(Me.PasswordTb)
        Me.LoginPnl.Controls.Add(Me.UnameLbl)
        Me.LoginPnl.Controls.Add(Me.UnameTb)
        Me.LoginPnl.Controls.Add(Me.SigninLbl)
        Me.LoginPnl.Controls.Add(Me.UserPb)
        Me.LoginPnl.Location = New System.Drawing.Point(97, 49)
        Me.LoginPnl.Name = "LoginPnl"
        Me.LoginPnl.Size = New System.Drawing.Size(824, 476)
        Me.LoginPnl.TabIndex = 0
        '
        'SmsPb
        '
        Me.SmsPb.Image = Global.SPA_Management_System.My.Resources.Resources.spa_management_system_high_resolution_logo_transparent
        Me.SmsPb.Location = New System.Drawing.Point(106, 32)
        Me.SmsPb.Name = "SmsPb"
        Me.SmsPb.Size = New System.Drawing.Size(180, 80)
        Me.SmsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmsPb.TabIndex = 8
        Me.SmsPb.TabStop = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Yellow
        Me.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(516, 304)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(135, 40)
        Me.LoginBtn.TabIndex = 7
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.Location = New System.Drawing.Point(368, 259)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(96, 23)
        Me.PasswordLbl.TabIndex = 6
        Me.PasswordLbl.Text = "Password:"
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(478, 250)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(276, 32)
        Me.PasswordTb.TabIndex = 5
        '
        'UnameLbl
        '
        Me.UnameLbl.AutoSize = True
        Me.UnameLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameLbl.Location = New System.Drawing.Point(368, 209)
        Me.UnameLbl.Name = "UnameLbl"
        Me.UnameLbl.Size = New System.Drawing.Size(104, 23)
        Me.UnameLbl.TabIndex = 4
        Me.UnameLbl.Text = "UserName:"
        '
        'UnameTb
        '
        Me.UnameTb.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameTb.Location = New System.Drawing.Point(478, 200)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(276, 32)
        Me.UnameTb.TabIndex = 3
        '
        'SigninLbl
        '
        Me.SigninLbl.AutoSize = True
        Me.SigninLbl.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SigninLbl.Location = New System.Drawing.Point(544, 150)
        Me.SigninLbl.Name = "SigninLbl"
        Me.SigninLbl.Size = New System.Drawing.Size(88, 30)
        Me.SigninLbl.TabIndex = 2
        Me.SigninLbl.Text = "SIGN IN"
        '
        'UserPb
        '
        Me.UserPb.Image = Global.SPA_Management_System.My.Resources.Resources._3749784
        Me.UserPb.Location = New System.Drawing.Point(88, 105)
        Me.UserPb.Name = "UserPb"
        Me.UserPb.Size = New System.Drawing.Size(215, 271)
        Me.UserPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPb.TabIndex = 1
        Me.UserPb.TabStop = False
        '
        'ExitPb
        '
        Me.ExitPb.BackColor = System.Drawing.Color.YellowGreen
        Me.ExitPb.Image = CType(resources.GetObject("ExitPb.Image"), System.Drawing.Image)
        Me.ExitPb.Location = New System.Drawing.Point(991, -1)
        Me.ExitPb.Name = "ExitPb"
        Me.ExitPb.Size = New System.Drawing.Size(34, 31)
        Me.ExitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPb.TabIndex = 1
        Me.ExitPb.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.ExitPb)
        Me.Controls.Add(Me.LoginPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.LoginPnl.ResumeLayout(False)
        Me.LoginPnl.PerformLayout()
        CType(Me.SmsPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginPnl As Panel
    Friend WithEvents UserPb As PictureBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UnameLbl As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents SigninLbl As Label
    Friend WithEvents ExitPb As PictureBox
    Friend WithEvents SmsPb As PictureBox
End Class
