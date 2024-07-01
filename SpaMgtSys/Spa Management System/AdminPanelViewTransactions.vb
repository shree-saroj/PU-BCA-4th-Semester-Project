Imports System.Data.SqlClient

Public Class AdminPanelViewTransactions
    Private Sub AdminPanelViewTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet4.Usp_View_Transactions' table. You can move, or remove it, as needed.
        Me.Usp_View_TransactionsTableAdapter.Fill(Me.SpaMgtSysDataSet4.Usp_View_Transactions)
    End Sub
    Private Sub UsersPanelManageCustomers_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim UserId As Integer
        Dim CusId As Integer
        If UserIdTb.Text = "" And CusIdTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            If UserIdTb.Text = "" Then
                UserId = 0
                CusId = CusIdTb.Text
            ElseIf CusIdTb.Text = "" Then
                UserId = UserIdTb.Text
                CusId = 0
            Else
                UserId = UserIdTb.Text
                CusId = CusIdTb.Text
            End If
            Dim Query As String = "Usp_Sort_Transactions"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UserId", UserId),
                New SqlParameter("@CusId", CusId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim DS As DataSet = Search(Query, Param, CmdType)
            TransactionsDGV.DataSource = DS.Tables(0)
        End If
    End Sub

    Private Sub ByDateSearch_Click(sender As Object, e As EventArgs) Handles ByDateSearch.Click
        Dim Query As String = "Usp_Sort_TransactionsByDate"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FromDate", FromDTP.Value.ToString),
                New SqlParameter("@ToDate", ToDTP.Value.ToString)
            }
        Dim CmdType As CommandType = CommandType.StoredProcedure
        Dim DS As DataSet = Search(Query, Param, CmdType)
        TransactionsDGV.DataSource = DS.Tables(0)
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        TransactionsDGV.DataSource = SpaMgtSysDataSet4.Usp_View_Transactions
        UserIdTb.Text = ""
        CusIdTb.Text = ""
    End Sub
End Class