Imports System.Data.SqlClient
Imports System.Web.UI.WebControls.WebParts

Public Class Availablility
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

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles ShiftBtn.Click
        Dim UpdateInfo As ShiftAppointment = New ShiftAppointment
        UpdateInfo.Show()
        Me.Hide()
    End Sub
    Private Sub LogoutLbl_Click(sender As Object, e As EventArgs) Handles LogoutLbl.Click
        Dim Login As Login = New Login
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub CustomersBtn_Click(sender As Object, e As EventArgs) Handles CustomersBtn.Click
        Dim ManageCus As New UserManageCustomers
        ManageCus.Show()
        Me.Hide()
    End Sub
    Private Sub Fillservices()
        Dim Query As String = "Usp_Display_Services"
        Dim Table As New DataTable()
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                Cmd.CommandType = CommandType.StoredProcedure
                Try
                    Con.Open()
                    Dim Adapter As New SqlDataAdapter(Cmd)
                    Adapter.Fill(Table)
                Catch ex As Exception
                    MsgBox("DataBase Exception Occured")
                End Try
            End Using
        End Using
        ServicesCB.DataSource = Table
        ServicesCB.DisplayMember = "S_Name"
        ServicesCB.ValueMember = "S_Id"
    End Sub

    Private Sub Availablility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillservices()
    End Sub
    Private Sub DateDP_Enter(sender As Object, e As EventArgs) Handles DateDP.Enter
        DateDP.MinDate = Today.Date()
        DateDP.Value = Today.Date()
        Filltime()
    End Sub
    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Filltime()
    End Sub
    Private Sub Filltime()
        Dim Query As String = "Usp_Display_Time"
        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@Date", DateDP.Value.ToString()),
            New SqlParameter("@SId", ServicesCB.SelectedValue)
        }
        Dim Table As New DataTable()
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                If param IsNot Nothing Then
                    Cmd.Parameters.AddRange(param.ToArray())
                End If
                Cmd.CommandType = CommandType.StoredProcedure
                Try
                    Con.Open()
                    Dim Adapter As New SqlDataAdapter(Cmd)
                    Adapter.Fill(Table)
                Catch ex As Exception
                    MsgBox("DataBase Exception Occured " & ex.Message)
                End Try
            End Using
        End Using
        If Table.Rows.Count > 0 Then
            TimeCB.DataSource = Table
            TimeCB.DisplayMember = "Ti_StartTime"
            TimeCB.ValueMember = "Ti_Id"
        Else
            TimeCB.DataSource = Nothing
            TimeCB.Items.Clear()
            MsgBox("No available times for the selected date.")
        End If
    End Sub
End Class