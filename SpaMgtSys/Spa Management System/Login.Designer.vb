<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.SignInLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.UNameLbl = New System.Windows.Forms.Label()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.HideShowChkB = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'SignInLbl
        '
        Me.SignInLbl.AutoSize = True
        Me.SignInLbl.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLbl.Location = New System.Drawing.Point(442, 139)
        Me.SignInLbl.Name = "SignInLbl"
        Me.SignInLbl.Size = New System.Drawing.Size(101, 32)
        Me.SignInLbl.TabIndex = 0
        Me.SignInLbl.Text = "SIGN IN"
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.Location = New System.Drawing.Point(283, 236)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(96, 25)
        Me.PasswordLbl.TabIndex = 1
        Me.PasswordLbl.Text = "Password:"
        '
        'UNameLbl
        '
        Me.UNameLbl.AutoSize = True
        Me.UNameLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNameLbl.Location = New System.Drawing.Point(270, 194)
        Me.UNameLbl.Name = "UNameLbl"
        Me.UNameLbl.Size = New System.Drawing.Size(109, 25)
        Me.UNameLbl.TabIndex = 2
        Me.UNameLbl.Text = "User Name:"
        '
        'UnameTb
        '
        Me.UnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameTb.Location = New System.Drawing.Point(385, 192)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(246, 29)
        Me.UnameTb.TabIndex = 3
        '
        'PasswordTb
        '
        Me.PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(385, 232)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(246, 29)
        Me.PasswordTb.TabIndex = 4
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.LightGray
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(385, 275)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(246, 45)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'HideShowChkB
        '
        Me.HideShowChkB.Appearance = System.Windows.Forms.Appearance.Button
        Me.HideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
        Me.HideShowChkB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HideShowChkB.Location = New System.Drawing.Point(633, 232)
        Me.HideShowChkB.Name = "HideShowChkB"
        Me.HideShowChkB.Size = New System.Drawing.Size(28, 28)
        Me.HideShowChkB.TabIndex = 7
        Me.HideShowChkB.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.HideShowChkB)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UnameTb)
        Me.Controls.Add(Me.UNameLbl)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.SignInLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignInLbl As Label
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents UNameLbl As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents HideShowChkB As CheckBox
End Class
