Imports System.Data.SqlClient

Public Class AdminPanelManageServices
    Private Sub AdminPanelManageServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet1.Usp_View_Services' table. You can move, or remove it, as needed.
        Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet1.Usp_View_Services)

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
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet1.Usp_View_Services)
                Reset()
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
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet1.Usp_View_Services)
                Reset()
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
                Me.Usp_View_ServicesTableAdapter.Fill(Me.SpaMgtSysDataSet1.Usp_View_Services)
                Reset()
                MsgBox("Service Removed Sucessfully")
            End If
        End If
    End Sub

    Private Sub UsersPanelManageCustomers_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub

End Class