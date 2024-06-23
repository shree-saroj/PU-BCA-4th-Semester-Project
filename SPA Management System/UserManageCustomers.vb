Imports System.Data.SqlClient
Imports SPA_Management_System.SpaMgtSysDataSet1TableAdapters

Public Class UserManageCustomers
    Private Sub ExitPb_MouseEnter(sender As Object, e As EventArgs) Handles ExitPb.MouseEnter
        ExitPb.BackColor = Color.Red
    End Sub
    Private Sub ExitPb_MouseLeave(sender As Object, e As EventArgs) Handles ExitPb.MouseLeave
        ExitPb.BackColor = Color.YellowGreen
    End Sub

    Private Sub ExitPb_Click(sender As Object, e As EventArgs) Handles ExitPb.Click
        Application.Exit()
    End Sub

    Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
        Dim BookAppointment As Book = New Book
        BookAppointment.Show()
        Me.Hide()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dim CancelAppointment As Cancel = New Cancel
        CancelAppointment.Show()
        Me.Hide()
    End Sub

    Private Sub AvailabilityBtn_Click(sender As Object, e As EventArgs) Handles AvailabilityBtn.Click
        Dim Check As Availablility = New Availablility
        Check.Show()
        Me.Hide()
    End Sub
    Private Sub LogoutLbl_Click(sender As Object, e As EventArgs) Handles LogoutLbl.Click
        Dim Login As Login = New Login
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub ShifitAppointmentBtn_Click(sender As Object, e As EventArgs) Handles ShifitAppointmentBtn.Click
        Dim ShiftAppointment As New ShiftAppointment
        ShiftAppointment.Show()
        Me.Hide()
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
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)
                MsgBox("User Info Updated Sucessfully")
            End If
        End If
    End Sub
    Private Sub ViewCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet3.Usp_View_Customers' table. You can move, or remove it, as needed.
        Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)
    End Sub

    Private Sub CAddBtn_Click(sender As Object, e As EventArgs) Handles CAddBtn.Click
        If CFNameTb.Text = "" Or CLNameTb.Text = "" Or CAddressTb.Text = "" Or CContactTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf GlobalVariables.Key > 0 Then
            Reset()
            MsgBox("Key Exception Occured! Try Again")
        Else
            Dim Query As String = "Usp_Add_Customer"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FName", CFNameTb.Text.ToString()),
                New SqlParameter("@LName", CLNameTb.Text.ToString()),
                New SqlParameter("@Address", CAddressTb.Text.ToString()),
                New SqlParameter("@Contact", CContactTb.Text.ToString()),
                New SqlParameter("@UAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_CustomersTableAdapter1.Fill(Me.SpaMgtSysDataSet3.Usp_View_Customers)
                MsgBox("User Added Sucessfully")
                Reset()
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
    Private Sub Reset()
        CFNameTb.Text = ""
        CLNameTb.Text = ""
        CAddressTb.Text = ""
        CContactTb.Text = ""
        GlobalVariables.Key = 0
        CustomersDGV.DataSource = SpaMgtSysDataSet3.Usp_View_Customers
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If CFNameTb.Text = "" And CLNameTb.Text = "" And CAddressTb.Text = "" And CContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Search_Customer"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FName", CFNameTb.Text.ToString()),
                New SqlParameter("@LName", CLNameTb.Text.ToString()),
                New SqlParameter("@Address", CAddressTb.Text.ToString()),
                New SqlParameter("@Contact", CContactTb.Text.ToString())
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim DS As DataSet = Search(Query, Param, CmdType)
            CustomersDGV.DataSource = DS.Tables(0)
        End If
    End Sub
End Class