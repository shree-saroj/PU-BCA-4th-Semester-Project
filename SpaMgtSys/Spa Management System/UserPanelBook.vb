Imports System.Data.SqlClient

Public Class UserPanelBook
    Dim Price As Double = 0
    Dim Total As Double = 0
    Dim Discount As Double = 0
    Dim DiscountedPrice As Double = 0
    Dim i As Integer = 0
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
    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillservices()
        DateDP.MinDate = Date.Today()
        DateDP.Value = Date.Today()
        Gettime()
    End Sub

    Private Sub Gettime()
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


    Private Sub Getprice()
        Dim Query As String = "Usp_Get_ServicePrice"
        Using Con As New SqlConnection(_constr)
            Using Cmd As New SqlCommand(Query, Con)
                Cmd.Parameters.AddWithValue("@Sid", ServicesCB.SelectedValue)
                Cmd.CommandType = CommandType.StoredProcedure
                Con.Open()
                Price = Cmd.ExecuteScalar()
                PriceViewLbl.Text = "Rs. " + Convert.ToString(Price)
            End Using
        End Using
    End Sub
    Private Sub ServicesCB_Enter(sender As Object, e As EventArgs) Handles ServicesCB.Enter
        Getprice()
    End Sub
    Private Sub DateDP_Enter(sender As Object, e As EventArgs) Handles DateDP.Enter
        Getprice()
    End Sub
    Private Sub AddToBill_Click(sender As Object, e As EventArgs) Handles AddToBill.Click
        If ServicesCB.SelectedValue.ToString = "" Or TimeCB.SelectedValue.ToString = "" Or CIdTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Rnum As Integer = BookDGV.Rows.Add()
            i += 1
            BookDGV.Rows.Item(Rnum).Cells("ServicesIdCol").Value = ServicesCB.SelectedValue
            BookDGV.Rows.Item(Rnum).Cells("ServicesNameCol").Value = ServicesCB.Text
            BookDGV.Rows.Item(Rnum).Cells("DateCol").Value = DateDP.Value
            BookDGV.Rows.Item(Rnum).Cells("TimeIdCol").Value = TimeCB.SelectedValue
            BookDGV.Rows.Item(Rnum).Cells("TimeCol").Value = TimeCB.Text
            BookDGV.Rows.Item(Rnum).Cells("PriceCol").Value = Price
            Total += Price
            TotalPriceViewLbl.Text = "Rs. " + Convert.ToString(Total)
        End If
    End Sub

    Private Sub BillBtn_Click(sender As Object, e As EventArgs) Handles BillBtn.Click
        If DiscountTb.Text = "" Then
        Else
            Discount = DiscountTb.Text
            DiscountedPrice = Total - Discount
            BillViewLbl.Text = "Rs. " + DiscountedPrice.ToString()
        End If
    End Sub
    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        If BillViewLbl.Text = "" Or CIdTb.Text = "" Or CusNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim result = AddIntoBooking()
            If result = 0 Then
                MsgBox("Booked Successfully")
                AddIntoTransaction()
                Reset()
            End If
        End If
    End Sub
    Private Function AddIntoBooking() As Integer
        Dim Query As String = "Usp_I_Book"
        Using Con As New SqlConnection(_constr)
            Con.Open()
            For Each row As DataGridViewRow In BookDGV.Rows
                If row.IsNewRow Then
                    Continue For
                End If
                Using Cmd As New SqlCommand(Query, Con)
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Parameters.AddWithValue("@UId", UserId)
                    Cmd.Parameters.AddWithValue("@CId", CIdTb.Text)
                    Cmd.Parameters.AddWithValue("@SId", row.Cells("ServicesIdCol").Value)
                    Cmd.Parameters.AddWithValue("@SPrice", row.Cells("PriceCol").Value)
                    Cmd.Parameters.AddWithValue("@Date", row.Cells("DateCol").Value)
                    Cmd.Parameters.AddWithValue("@Time", row.Cells("TimeIdCol").Value)
                    Try
                        Cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Database Exception " & ex.Message)
                        Return 1
                    End Try
                End Using
            Next
            Return 0
        End Using
    End Function
    Private Sub AddIntoTransaction()
        Dim Query As String = "Usp_I_Transaction"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", UserId),
                New SqlParameter("@CId", CIdTb.Text),
                New SqlParameter("@Amount", DiscountedPrice)
            }
        Dim CmdType As CommandType = CommandType.StoredProcedure
        Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
        If AddEmpResult = -1 Then
            MsgBox("DataBase Exception Occured! Try Again")
            Reset()
        Else
            Reset()
        End If
    End Sub

    Private Sub TimeCB_Enter(sender As Object, e As EventArgs) Handles TimeCB.Enter
        Gettime()
    End Sub
    Private Sub Reset()
        CIdTb.Text = ""
        CusNameTb.Text = ""
        ServicesCB.Text = ""
        PriceViewLbl.Text = ""
        CustomerInfoDGV.DataSource = ""
        BookDGV.DataSource = ""
        DateDP.Value = Date.Today
        TimeCB.Text = ""
        Total = 0
        TotalPriceViewLbl.Text = ""
        DiscountTb.Text = ""
        BillViewLbl.Text = ""
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub UserPanelBook_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
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
    Private Sub ServicesCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ServicesCB.SelectionChangeCommitted
        Getprice()
    End Sub
End Class