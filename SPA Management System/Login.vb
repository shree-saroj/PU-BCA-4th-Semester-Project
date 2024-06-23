Imports System.Data.SqlClient

Public Class Login
    Private Sub ExitPb_MouseEnter(sender As Object, e As EventArgs) Handles ExitPb.MouseEnter
        ExitPb.BackColor = Color.Red
    End Sub
    Private Sub ExitPb_MouseLeave(sender As Object, e As EventArgs) Handles ExitPb.MouseLeave
        ExitPb.BackColor = Color.YellowGreen
    End Sub
    Private Sub ExitPb_Click(sender As Object, e As EventArgs) Handles ExitPb.Click
        Application.Exit()
    End Sub
    Private Sub HideShowChkB_CheckedChanged(sender As Object, e As EventArgs) Handles HideShowChkB.CheckedChanged
        If HideShowChkB.Checked = True Then
            PasswordTb.UseSystemPasswordChar = False
        Else
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
            Dim ManageServices As New ManageServices
            ManageServices.Show()
            Me.Hide()
        ElseIf LoginResult = 0 Then
            Dim Book As New Book
            Book.Show()
            Me.Hide()
        ElseIf UnameTb.Text = "SuperUser" And PasswordTb.Text = "SuperPassword" Then
            UserId = 0
            Dim ManageUsers As New ManageUsers
            ManageUsers.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName and Passwrod")
            UnameTb.Text = ""
            PasswordTb.Text = ""
            HideShowChkB.Checked = False
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTb.UseSystemPasswordChar = True
    End Sub
End Class