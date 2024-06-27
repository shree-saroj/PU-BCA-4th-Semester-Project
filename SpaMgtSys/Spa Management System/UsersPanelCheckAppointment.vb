Imports System.Data.SqlClient

Public Class UsersPanelCheckAppointment
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
        DateDP.MinDate = Today.Date()
        DateDP.Value = Today.Date()
    End Sub
    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        If ServicesCB.Text = "" Then
        Else
            Try
                Dim Query As String = "Usp_Display_Time"
                Dim param As New List(Of SqlParameter) From {
                    New SqlParameter("@Date", DateDP.Value.ToString()),
                    New SqlParameter("@SId", ServicesCB.SelectedValue)
                }
                Dim DS As DataSet = Search(Query, param, CommandType.StoredProcedure)
                TimeDGV.DataSource = DS.Tables(0)
            Catch ex As Exception
                MsgBox("DataBase Exception")
            End Try

        End If
    End Sub

    Private Sub UsersPanelCheckAppointment_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub

End Class