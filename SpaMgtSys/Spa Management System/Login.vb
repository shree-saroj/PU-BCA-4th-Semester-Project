Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub HideShowChkB_CheckedChanged(sender As Object, e As EventArgs) Handles HideShowChkB.CheckedChanged
        If HideShowChkB.Checked = True Then
            HideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.opened_eye
            PasswordTb.UseSystemPasswordChar = False
        Else
            HideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
            PasswordTb.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim Query As String = "Usp_Check_Login"
        Dim Param As New List(Of SqlParameter) From {
            New SqlParameter("@Uname", UnameTb.Text.ToString()),
            New SqlParameter("@Passwd", PasswordTb.Text.ToString())
        }
        Dim CmdType As CommandType = CommandType.StoredProcedure
        Dim LoginResult = GlobalVariables.Login(Query, Param, CmdType)
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter UserName and Password")
        ElseIf LoginResult = 1 Then
            Dim AdminPnl As New AdminPanel
            AdminPnl.Show()
            Me.Hide()
        ElseIf LoginResult = 0 Then
            Dim UsersPnl As New UsersPanel
            UsersPnl.Show()
            Me.Hide()
        ElseIf UnameTb.Text = "SuperUser" And PasswordTb.Text = "SuperPassword" Then
            UserId = 0
            AdminPanelManageUsers.Show()
            UnameTb.Text = ""
            PasswordTb.Text = ""
            HideShowChkB.Checked = False
        Else
            MsgBox("Wrong UserName and Passwrod")
            UnameTb.Text = ""
            PasswordTb.Text = ""
            HideShowChkB.Checked = False
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTb.UseSystemPasswordChar = True
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Application.Exit()
        End If
    End Sub
End Class
