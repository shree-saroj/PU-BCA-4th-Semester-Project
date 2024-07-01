Imports System.Data.SqlClient
Imports System.Drawing.Imaging

Public Class AdminPanelViewStatistics
    Private Sub UsersPanelManageCustomers_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub
    Private Sub AdminPanelViewStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet5.Usp_Get_DistinctAmountByService' table. You can move, or remove it, as needed.
        Me.Usp_Get_DistinctAmountByServiceTableAdapter.Fill(Me.SpaMgtSysDataSet5.Usp_Get_DistinctAmountByService)
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet6.Usp_Get_DistinctAmountByArea' table. You can move, or remove it, as needed.
        Me.Usp_Get_DistinctAmountByAreaTableAdapter.Fill(Me.SpaMgtSysDataSet6.Usp_Get_DistinctAmountByArea)
        FillIncomeRefund()
    End Sub
    Private Sub FillIncomeRefund()
        Dim Query As String = "Usp_Get_IncomeRefund"
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                Cmd.CommandType = CommandType.StoredProcedure
                Con.Open()
                Using reader As SqlDataReader = Cmd.ExecuteReader()
                    reader.Read()
                    IncomeTb.Text = Convert.ToDouble(reader("Income"))
                    RefundedTb.Text = Convert.ToDouble(reader("Refunded"))
                    NetIncomeTb.Text = IncomeTb.Text - RefundedTb.Text
                End Using
            End Using
        End Using
    End Sub
End Class