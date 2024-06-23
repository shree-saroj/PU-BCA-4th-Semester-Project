Imports System.Data.SqlClient

Public Class ManageServices
    Private Sub ExitPb_MouseEnter(sender As Object, e As EventArgs) Handles ExitPb.MouseEnter
        ExitPb.BackColor = Color.Red
    End Sub
    Private Sub ExitPb_MouseLeave(sender As Object, e As EventArgs) Handles ExitPb.MouseLeave
        ExitPb.BackColor = Color.YellowGreen
    End Sub
    Private Sub ExitPb_Click(sender As Object, e As EventArgs) Handles ExitPb.Click
        Application.Exit()
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

    Private Sub ManageServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet2.Usp_View_Services' table. You can move, or remove it, as needed.
        Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet2.Usp_View_Services)

    End Sub
    Sub Reset()
        SNameTb.Text = ""
        SPriceTb.Text = ""
        GlobalVariables.Key = 0
    End Sub

    Private Sub SAddBtn_Click(sender As Object, e As EventArgs) Handles SAddBtn.Click
        If SNameTb.Text = "" Or SPriceTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf GlobalVariables.Key > 0 Then
            Reset()
            MsgBox("Key Exception Occured! Try Again")
        Else
            Dim Query As String = "Usp_Add_Service"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@SName", SNameTb.Text.ToString()),
                New SqlParameter("@SPrice", Convert.ToDecimal(SPriceTb.Text)),
                New SqlParameter("@AdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exeption Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet2.Usp_View_Services)
                MsgBox("Service Added Sucessfully")
            End If
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Private Sub SUpdateBtn_Click(sender As Object, e As EventArgs) Handles SUpdateBtn.Click
        If SNameTb.Text = "" Or SPriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_Service"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@SId", GlobalVariables.Key),
                New SqlParameter("@SName", SNameTb.Text.ToString()),
                New SqlParameter("@SPrice", Convert.ToDecimal(SPriceTb.Text)),
                New SqlParameter("@AdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exeption Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet2.Usp_View_Services)
                MsgBox("Service Updated Sucessfully")
            End If
        End If
    End Sub

    Private Sub EmployeeDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDGV.CellClick
        Dim row As New DataGridViewRow
        Try
            row = EmployeeDGV.Rows(e.RowIndex)
            SNameTb.Text = row.Cells(1).Value.ToString()
            SPriceTb.Text = Convert.ToDecimal(row.Cells(2).Value)
            If SNameTb.Text = "" Then
                GlobalVariables.Key = 0
            Else
                GlobalVariables.Key = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub

    Private Sub SRemoveBtn_Click(sender As Object, e As EventArgs) Handles SRemoveBtn.Click
        If SNameTb.Text = "" Or SPriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Remove_Service"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@SId", GlobalVariables.Key),
                New SqlParameter("@AdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exeption Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet2.Usp_View_Services)
                MsgBox("Service Removed Sucessfully")
            End If
        End If
    End Sub
End Class