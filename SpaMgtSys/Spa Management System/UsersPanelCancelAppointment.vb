Imports System.Data.SqlClient

Public Class UsersPanelCancelAppointment
    Private Sub UsersPanelCancelAppointment_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If BookIdTb.Text = "" Or CusNameTb.Text = "" Or CIdTb.Text = "" Or RefundTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Cancel_Appointment"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@BId", BookIdTb.Text),
                New SqlParameter("@UId", UserId),
                New SqlParameter("@Amount", Convert.ToDouble(RefundTb.Text.ToString))
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim Cancel = InsertUpdateDelete(Query, Param, CmdType)
            If Cancel = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                MsgBox("Appointment Cancelled Sucessfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub BookDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookDGV.CellClick
        Dim Row As DataGridViewRow
        Try
            Row = BookDGV.Rows(e.RowIndex)
            BookIdTb.Text = Convert.ToInt32(Row.Cells(0).Value.ToString)
            RefundTb.Text = Convert.ToDouble(Row.Cells(3).Value.ToString)
        Catch ex As Exception
            MsgBox("Select a Row")
        End Try
    End Sub
    Private Sub Reset()
        BookIdTb.Text = ""
        CusNameTb.Text = ""
        CIdTb.Text = ""
        RefundTb.Text = ""
        CustomerInfoDGV.DataSource = ""
        BookDGV.DataSource = ""
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub UsersPanelCancelAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateDP.Value = Date.Today()
        DateDP.MinDate = Date.Today()
    End Sub

End Class