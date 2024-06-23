Imports System.Management.Instrumentation

Public Class ViewTransactions
    Sub ExitPb_MouseEnter(sender As Object, e As EventArgs) Handles ExitPb.MouseEnter
        ExitPb.BackColor = Color.Red
    End Sub
    Private Sub ExitPb_MouseLeave(sender As Object, e As EventArgs) Handles ExitPb.MouseLeave
        ExitPb.BackColor = Color.YellowGreen
    End Sub
    Private Sub ExitPb_Click(sender As Object, e As EventArgs) Handles ExitPb.Click
        Application.Exit()
    End Sub

    Private Sub ManageServicesBtn_Click(sender As Object, e As EventArgs) Handles ManageServicesBtn.Click
        Dim ManageServices As ManageServices = New ManageServices
        ManageServices.Show()
        Me.Hide()
    End Sub

    Private Sub ViewCustomerInfoBtn_Click(sender As Object, e As EventArgs) Handles ViewCustomerInfoBtn.Click
        Dim ViewCustInfo As ViewCustomerInfo = New ViewCustomerInfo
        ViewCustInfo.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUsersBtn_Click(sender As Object, e As EventArgs) Handles ManageUsersBtn.Click
        Dim ManageUsers As ManageUsers = New ManageUsers
        ManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub ManageEmployeesBtn_Click(sender As Object, e As EventArgs) Handles ManageEmployeesBtn.Click
        Dim ManageEmployees As ManageEmployees = New ManageEmployees
        ManageEmployees.Show()
        Me.Hide()
    End Sub

    Private Sub ViewStatisticsBtn_Click(sender As Object, e As EventArgs) Handles ViewStatisticsBtn.Click
        Dim ViewStatistics As ViewStatistics = New ViewStatistics
        ViewStatistics.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutLbl_Click(sender As Object, e As EventArgs) Handles LogoutLbl.Click
        Dim Login As Login = New Login
        Login.Show()
        Me.Hide()
    End Sub
End Class