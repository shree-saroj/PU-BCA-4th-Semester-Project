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
        Me.SmsLbl = New System.Windows.Forms.Label()
        Me.UserPb = New System.Windows.Forms.PictureBox()
        Me.SigninLbl = New System.Windows.Forms.Label()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.UnameLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LoginPnl.SuspendLayout()
        CType(Me.UserPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginPnl
        '
        Me.LoginPnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPnl.BackColor = System.Drawing.Color.Snow
        Me.LoginPnl.Controls.Add(Me.LoginBtn)
        Me.LoginPnl.Controls.Add(Me.PasswordLbl)
        Me.LoginPnl.Controls.Add(Me.PasswordTb)
        Me.LoginPnl.Controls.Add(Me.UnameLbl)
        Me.LoginPnl.Controls.Add(Me.UnameTb)
        Me.LoginPnl.Controls.Add(Me.SigninLbl)
        Me.LoginPnl.Controls.Add(Me.UserPb)
        Me.LoginPnl.Controls.Add(Me.SmsLbl)
        Me.LoginPnl.Location = New System.Drawing.Point(120, 76)
        Me.LoginPnl.Name = "LoginPnl"
        Me.LoginPnl.Size = New System.Drawing.Size(748, 377)
        Me.LoginPnl.TabIndex = 0
        '
        'SmsLbl
        '
        Me.SmsLbl.AutoSize = True
        Me.SmsLbl.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmsLbl.Location = New System.Drawing.Point(21, 35)
        Me.SmsLbl.Name = "SmsLbl"
        Me.SmsLbl.Size = New System.Drawing.Size(284, 30)
        Me.SmsLbl.TabIndex = 0
        Me.SmsLbl.Text = "SPA MANAGEMENT SYSTEM"
        '
        'UserPb
        '
        Me.UserPb.Image = CType(resources.GetObject("UserPb.Image"), System.Drawing.Image)
        Me.UserPb.Location = New System.Drawing.Point(52, 68)
        Me.UserPb.Name = "UserPb"
        Me.UserPb.Size = New System.Drawing.Size(215, 271)
        Me.UserPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPb.TabIndex = 1
        Me.UserPb.TabStop = False
        '
        'SigninLbl
        '
        Me.SigninLbl.AutoSize = True
        Me.SigninLbl.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SigninLbl.Location = New System.Drawing.Point(471, 92)
        Me.SigninLbl.Name = "SigninLbl"
        Me.SigninLbl.Size = New System.Drawing.Size(88, 30)
        Me.SigninLbl.TabIndex = 2
        Me.SigninLbl.Text = "SIGN IN"
        '
        'UnameTb
        '
        Me.UnameTb.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameTb.Location = New System.Drawing.Point(405, 142)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(276, 32)
        Me.UnameTb.TabIndex = 3
        '
        'UnameLbl
        '
        Me.UnameLbl.AutoSize = True
        Me.UnameLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameLbl.Location = New System.Drawing.Point(295, 151)
        Me.UnameLbl.Name = "UnameLbl"
        Me.UnameLbl.Size = New System.Drawing.Size(104, 23)
        Me.UnameLbl.TabIndex = 4
        Me.UnameLbl.Text = "UserName:"
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.Location = New System.Drawing.Point(295, 201)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(96, 23)
        Me.PasswordLbl.TabIndex = 6
        Me.PasswordLbl.Text = "Password:"
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(405, 192)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(276, 32)
        Me.PasswordTb.TabIndex = 5
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Yellow
        Me.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(443, 246)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(135, 40)
        Me.LoginBtn.TabIndex = 7
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(962, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LoginPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.LoginPnl.ResumeLayout(False)
        Me.LoginPnl.PerformLayout()
        CType(Me.UserPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginPnl As Panel
    Friend WithEvents SmsLbl As Label
    Friend WithEvents UserPb As PictureBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UnameLbl As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents SigninLbl As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
