Imports System.Data.SqlClient
Imports System.Runtime.Remoting

Public Class UsersPanelShiftAppointment
    Private Sub UsersPanelShiftAppointment_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If CIdTb.Text = "" And CusNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Dim Query As String = "Usp_Get_Customer"
                Dim Param As New List(Of SqlParameter) From {
                    New SqlParameter("@CId", CIdTb.Text),
                    New SqlParameter("@FName", CusNameTb.Text)
                }
                Dim CmdType As CommandType = CommandType.StoredProcedure
                Dim DS As DataSet = Search(Query, Param, CmdType)
                CustomerInfoDGV.DataSource = DS.Tables(0)
            Catch ex As Exception
                MsgBox("Enter Proper Value")
            End Try
        End If
    End Sub

    Private Sub UsersPanelShiftAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateDP.Value = Date.Today()
        DateDP.MinDate = Date.Today()
        NewDateDP.Value = Date.Today()
        NewDateDP.MinDate = Date.Today()
    End Sub
    Private Sub Reset()
        BookIdTb.Text = ""
        CusNameTb.Text = ""
        CIdTb.Text = ""
        CustomerInfoDGV.DataSource = ""
        BookDGV.DataSource = ""
        TimeCB.Text = ""
    End Sub
    Private Sub ShowBookingsBtn_Click(sender As Object, e As EventArgs) Handles ShowBookingsBtn.Click
        If CIdTb.Text = "" And CusNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Dim Query As String = "Usp_Get_Bookings"
                Dim Param As New List(Of SqlParameter) From {
                    New SqlParameter("@CId", CIdTb.Text),
                    New SqlParameter("@Date", DateDP.Value)
                }
                Dim CmdType As CommandType = CommandType.StoredProcedure
                Dim DS As DataSet = Search(Query, Param, CmdType)
                BookDGV.DataSource = DS.Tables(0)
            Catch ex As Exception
                MsgBox("Enter Proper Value")
            End Try
        End If
    End Sub
    Private Sub BookDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookDGV.CellClick
        Dim Row As DataGridViewRow
        Try
            Row = BookDGV.Rows(e.RowIndex)
            BookIdTb.Text = Convert.ToInt32(Row.Cells(0).Value.ToString)
            ServiceIdTb.Text = Convert.ToInt32(Row.Cells(1).Value.ToString)
        Catch ex As Exception
            MsgBox("Select a Row")
        End Try
    End Sub
    Private Sub CustomerInfoDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerInfoDGV.CellClick
        Dim Row As New DataGridViewRow
        Try
            Row = CustomerInfoDGV.Rows(e.RowIndex)
            CIdTb.Text = Convert.ToInt32(Row.Cells(0).Value.ToString)
            CusNameTb.Text = Row.Cells(1).Value.ToString()
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Dim Query As String = "Usp_Display_Time"
        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@Date", DateDP.Value.ToString()),
            New SqlParameter("@SId", Convert.ToInt32(ServiceIdTb.Text.ToString()))
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

    Private Sub ShiftBtn_Click(sender As Object, e As EventArgs) Handles ShiftBtn.Click
        Dim Query As String = "Usp_Update_Bookings"
        Dim Param As New List(Of SqlParameter) From {
        New SqlParameter("@Bid", BookIdTb.Text.ToString),
        New SqlParameter("@Uid", UserId),
        New SqlParameter("@Date", NewDateDP.Value),
        New SqlParameter("@Time", TimeCB.SelectedValue)
        }
        Dim Result = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
        If Result = -1 Then
            MsgBox("DataBase Exception Occured! Try Again")
            Reset()
        Else
            MsgBox("Booking Shifting Successfully")
            Reset()
        End If
    End Sub

End Class