Imports System.Data.SqlClient

Public Class ManageUsers
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
    Private Sub ViewTransactionsBtn_Click(sender As Object, e As EventArgs) Handles ViewTransactionsBtn.Click
        Dim ViewTransaction As ViewTransactions = New ViewTransactions
        ViewTransaction.Show()
        Me.Hide()
    End Sub
    Private Sub ViewCustomerInfoBtn_Click(sender As Object, e As EventArgs) Handles ViewCustomerInfoBtn.Click
        Dim ViewCustInfo As ViewCustomerInfo = New ViewCustomerInfo
        ViewCustInfo.Show()
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

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet.Usp_View_Users' table. You can move, or remove it, as needed.
        Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet.Usp_View_Users)
        UPasswdTb.UseSystemPasswordChar = True
        UConfirmPasswdTb.UseSystemPasswordChar = True
        Reset()
    End Sub

    Private Sub UPasswdChkB_CheckedChanged(sender As Object, e As EventArgs) Handles UPasswdChkB.CheckedChanged
        If UPasswdChkB.Checked = True Then
            UPasswdTb.UseSystemPasswordChar = False
        Else
            UPasswdTb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub UConPasswdChkB_CheckedChanged(sender As Object, e As EventArgs) Handles UConPasswdChkB.CheckedChanged
        If UConPasswdChkB.Checked = True Then
            UConfirmPasswdTb.UseSystemPasswordChar = False
        Else
            UConfirmPasswdTb.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Reset()
        UFNameTb.Text = ""
        ULNameTb.Text = ""
        UsrNameTb.Text = ""
        UAddressTb.Text = ""
        UContactTb.Text = ""
        UPasswdTb.Text = ""
        UConfirmPasswdTb.Text = ""
        UType.Checked = False
        UPasswdChkB.Checked = False
        UConPasswdChkB.Checked = False
        GlobalVariables.Key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub UAddBtn_Click(sender As Object, e As EventArgs) Handles UAddBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Or UsrNameTb.Text = "" Or UPasswdTb.Text = "" Or UConfirmPasswdTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf GlobalVariables.Key > 0 Then
            Reset()
            MsgBox("Key Exception Occured! Try Again")
        Else
            Dim Query As String = "Usp_Add_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FName", UFNameTb.Text.ToString()),
                New SqlParameter("@LName", ULNameTb.Text.ToString()),
                New SqlParameter("@Address", UAddressTb.Text.ToString()),
                New SqlParameter("@Contact", UContactTb.Text.ToString()),
                New SqlParameter("@UName", UsrNameTb.Text.ToString()),
                New SqlParameter("@UPassword", UPasswdTb.Text.ToString()),
                New SqlParameter("@UAdId", GlobalVariables.UserId),
                New SqlParameter("@UIsAd", UType.Checked)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet.Usp_View_Users)
                MsgBox("User Added Sucessfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UUpdateBtn_Click(sender As Object, e As EventArgs) Handles UUpdateBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Or UsrNameTb.Text = "" Or UPasswdTb.Text = "" Or UConfirmPasswdTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", GlobalVariables.Key),
                New SqlParameter("@FName", UFNameTb.Text.ToString()),
                New SqlParameter("@LName", ULNameTb.Text.ToString()),
                New SqlParameter("@Address", UAddressTb.Text.ToString()),
                New SqlParameter("@Contact", UContactTb.Text.ToString()),
                New SqlParameter("@UName", UsrNameTb.Text.ToString()),
                New SqlParameter("@UPassword", UPasswdTb.Text.ToString()),
                New SqlParameter("@UAdId", GlobalVariables.UserId),
                New SqlParameter("@UIsAd", UType.Checked)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet.Usp_View_Users)
                MsgBox("User Info Updated Sucessfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UsersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDGV.CellClick
        Dim row As New DataGridViewRow
        Try
            row = UsersDGV.Rows(e.RowIndex)
            UFNameTb.Text = row.Cells(1).Value.ToString()
            ULNameTb.Text = row.Cells(2).Value.ToString()
            UAddressTb.Text = row.Cells(3).Value.ToString()
            UContactTb.Text = row.Cells(4).Value.ToString()
            UsrNameTb.Text = row.Cells(5).Value.ToString()
            UType.Checked = Convert.ToBoolean(row.Cells(6).Value)
            If UFNameTb.Text = "" Then
                GlobalVariables.Key = 0
            Else
                GlobalVariables.Key = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub
    Private Sub ERemoveBtn_Click(sender As Object, e As EventArgs) Handles URemoveBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Remove_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", GlobalVariables.Key),
                New SqlParameter("@UAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet.Usp_View_Users)
                MsgBox("Employee Removed Sucessfully")
            End If
        End If
    End Sub

End Class