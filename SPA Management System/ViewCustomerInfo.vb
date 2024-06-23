﻿Imports System.Data.SqlClient

Public Class ViewCustomerInfo
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

    Private Sub ViewCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet3.Usp_View_Customers' table. You can move, or remove it, as needed.
        Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)

    End Sub
    Private Sub Reset()
        CFNameTb.Text = ""
        CLNameTb.Text = ""
        CAddressTb.Text = ""
        CContactTb.Text = ""
        GlobalVariables.Key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub CUpdateBtn_Click(sender As Object, e As EventArgs) Handles CUpdateBtn.Click
        If CFNameTb.Text = "" Or CLNameTb.Text = "" Or CAddressTb.Text = "" Or CContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_Customer"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@CId", GlobalVariables.Key),
                New SqlParameter("@FName", CFNameTb.Text.ToString()),
                New SqlParameter("@LName", CLNameTb.Text.ToString()),
                New SqlParameter("@Address", CAddressTb.Text.ToString()),
                New SqlParameter("@Contact", CContactTb.Text.ToString()),
                New SqlParameter("@AdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("Exception Occured Try Again")
                Reset()
            Else
                Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)
                MsgBox("User Info Updated Sucessfully")
            End If
        End If
    End Sub

    Private Sub CustomersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDGV.CellClick
        Dim row As New DataGridViewRow
        Try
            row = CustomersDGV.Rows(e.RowIndex)
            CFNameTb.Text = row.Cells(1).Value.ToString()
            CLNameTb.Text = row.Cells(2).Value.ToString()
            CAddressTb.Text = row.Cells(3).Value.ToString()
            CContactTb.Text = row.Cells(4).Value.ToString()
            If CFNameTb.Text = "" Then
                GlobalVariables.Key = 0
            Else
                GlobalVariables.Key = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub
    Private Sub CRemoveBtn_Click(sender As Object, e As EventArgs) Handles CRemoveBtn.Click
        If CFNameTb.Text = "" Or CLNameTb.Text = "" Or CAddressTb.Text = "" Or CContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Remove_Customer"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", GlobalVariables.Key),
                New SqlParameter("@UAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("Exception Occured Try Again")
                Reset()
            Else
                Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)
                MsgBox("Employee Removed Sucessfully")
            End If
        End If
    End Sub
End Class