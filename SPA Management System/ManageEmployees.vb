Imports System.Data.SqlClient

Public Class ManageEmployees
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
    Private Sub ManageUsersBtn_Click(sender As Object, e As EventArgs) Handles ManageUsersBtn.Click
        Dim ManageUsers As ManageUsers = New ManageUsers
        ManageUsers.Show()
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

    Private Sub EAddBtn_Click(sender As Object, e As EventArgs) Handles EAddBtn.Click
        If EFNameTb.Text = "" Or ELNameTb.Text = "" Or EAddressTb.Text = "" Or EContactTb.Text = "" Or EPostTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf GlobalVariables.Key > 0 Then
            Reset()
            MsgBox("Exception Occured Try Again")
        Else
            Dim Query As String = "Usp_Add_Employee"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@EFName", EFNameTb.Text.ToString()),
                New SqlParameter("@ELName", ELNameTb.Text.ToString()),
                New SqlParameter("@EAddress", EAddressTb.Text.ToString()),
                New SqlParameter("@EContact", EContactTb.Text.ToString()),
                New SqlParameter("@EPost", EPostTb.Text.ToString()),
                New SqlParameter("@EAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If EFNameTb.Text = "" Or ELNameTb.Text = "" Or EAddressTb.Text = "" Or EContactTb.Text = "" Or EPostTb.Text = "" Then
                MsgBox("Missing Information")
            ElseIf AddEmpResult = -1 Then
                MsgBox("Exception Occured Try Again")
                Reset()
            Else
                Me.Usp_View_EmployeesTableAdapter1.Fill(Me.SpaMgtSysDataSet1.Usp_View_Employees)
                MsgBox("Employee Added Sucessfully")
            End If
        End If
    End Sub
    Private Sub ManageEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet1.Usp_View_Employees' table. You can move, or remove it, as needed.
        Me.Usp_View_EmployeesTableAdapter1.Fill(Me.SpaMgtSysDataSet1.Usp_View_Employees)
        Reset()
    End Sub
    Private Sub Reset()
        EFNameTb.Text = ""
        ELNameTb.Text = ""
        EAddressTb.Text = ""
        EContactTb.Text = ""
        EPostTb.Text = ""
        GlobalVariables.Key = 0
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Private Sub EmployeeDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDGV.CellClick
        Dim row As New DataGridViewRow
        Try
            row = EmployeeDGV.Rows(e.RowIndex)
            EFNameTb.Text = row.Cells(1).Value.ToString()
            ELNameTb.Text = row.Cells(2).Value.ToString()
            EAddressTb.Text = row.Cells(3).Value.ToString()
            EContactTb.Text = row.Cells(4).Value.ToString()
            EPostTb.Text = row.Cells(5).Value.ToString()
            If EFNameTb.Text = "" Then
                GlobalVariables.Key = 0
            Else
                GlobalVariables.Key = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub
    Private Sub EUpdateBtn_Click(sender As Object, e As EventArgs) Handles EUpdateBtn.Click
        If EFNameTb.Text = "" Or ELNameTb.Text = "" Or EAddressTb.Text = "" Or EContactTb.Text = "" Or EPostTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_Employee"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@EId", GlobalVariables.Key),
                New SqlParameter("@EFName", EFNameTb.Text.ToString()),
                New SqlParameter("@ELName", ELNameTb.Text.ToString()),
                New SqlParameter("@EAddress", EAddressTb.Text.ToString()),
                New SqlParameter("@EContact", EContactTb.Text.ToString()),
                New SqlParameter("@EPost", EPostTb.Text.ToString()),
                New SqlParameter("@EAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim UpdateEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)

            If UpdateEmpResult = -1 Then
                MsgBox("Exception Occured Try Again")
                Reset()
            Else
                Me.Usp_View_EmployeesTableAdapter1.Fill(Me.SpaMgtSysDataSet1.Usp_View_Employees)
                MsgBox("Employee Info Updated Sucessfully")
            End If
        End If
    End Sub

    Private Sub ERemoveBtn_Click(sender As Object, e As EventArgs) Handles ERemoveBtn.Click
        If EFNameTb.Text = "" Or ELNameTb.Text = "" Or EAddressTb.Text = "" Or EContactTb.Text = "" Or EPostTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Remove_Employee"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@EId", GlobalVariables.Key),
                New SqlParameter("@EAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("Exception Occured Try Again")
                Reset()
            Else
                Me.Usp_View_EmployeesTableAdapter1.Fill(Me.SpaMgtSysDataSet1.Usp_View_Employees)
                MsgBox("Employee Removed Sucessfully")
            End If
        End If
    End Sub
End Class