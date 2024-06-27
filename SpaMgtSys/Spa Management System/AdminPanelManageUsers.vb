Imports System.Data.SqlClient

Public Class AdminPanelManageUsers

    Private Sub AdminPanelManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaMgtSysDataSet3.Usp_View_Users' table. You can move, or remove it, as needed.
        Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet3.Usp_View_Users)
        UPasswdTb.UseSystemPasswordChar = True
        UConfirmPasswdTb.UseSystemPasswordChar = True
    End Sub
    Private Sub UsersPanelManageCustomers_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Dispose()
    End Sub

    Private Sub PasHideShowChkB_CheckedChanged(sender As Object, e As EventArgs) Handles PasHideShowChkB.CheckedChanged
        If PasHideShowChkB.Checked = True Then
            PasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.opened_eye
            UPasswdTb.UseSystemPasswordChar = False
        Else
            PasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
            UPasswdTb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CfrmPasHideShowChkB_CheckedChanged(sender As Object, e As EventArgs) Handles CfrmPasHideShowChkB.CheckedChanged
        If CfrmPasHideShowChkB.Checked = True Then
            CfrmPasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.opened_eye
            UConfirmPasswdTb.UseSystemPasswordChar = False
        Else
            CfrmPasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
            UConfirmPasswdTb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Reset()
        UFNameTb.Text = ""
        ULNameTb.Text = ""
        UsrNameTb.Text = ""
        UAddressTb.Text = ""
        UContactTb.Text = ""
        UPasswdTb.Text = ""
        UConfirmPasswdTb.Text = ""
        UType.Checked = False
        CfrmPasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
        PasHideShowChkB.BackgroundImage = Global.Spa_Management_System.My.Resources.Resources.cloased_eye
        GlobalVariables.Key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub UAddBtn_Click(sender As Object, e As EventArgs) Handles UAddBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Or UsrNameTb.Text = "" Or UPasswdTb.Text = "" Or UConfirmPasswdTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf GlobalVariables.Key > 0 Then
            Reset()
            MsgBox("Key Exception Occured! Try Again")
        Else
            Dim Query As String = "Usp_Add_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FName", UFNameTb.Text.ToString()),
                New SqlParameter("@LName", ULNameTb.Text.ToString()),
                New SqlParameter("@Address", UAddressTb.Text.ToString()),
                New SqlParameter("@Contact", UContactTb.Text.ToString()),
                New SqlParameter("@UName", UsrNameTb.Text.ToString()),
                New SqlParameter("@UPassword", UPasswdTb.Text.ToString()),
                New SqlParameter("@UAdId", GlobalVariables.UserId),
                New SqlParameter("@UIsAd", UType.Checked)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet3.Usp_View_Users)
                MsgBox("User Added Sucessfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UUpdateBtn_Click(sender As Object, e As EventArgs) Handles UUpdateBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Or UsrNameTb.Text = "" Or UPasswdTb.Text = "" Or UConfirmPasswdTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", GlobalVariables.Key),
                New SqlParameter("@FName", UFNameTb.Text.ToString()),
                New SqlParameter("@LName", ULNameTb.Text.ToString()),
                New SqlParameter("@Address", UAddressTb.Text.ToString()),
                New SqlParameter("@Contact", UContactTb.Text.ToString()),
                New SqlParameter("@UName", UsrNameTb.Text.ToString()),
                New SqlParameter("@UPassword", UPasswdTb.Text.ToString()),
                New SqlParameter("@UAdId", GlobalVariables.UserId),
                New SqlParameter("@UIsAd", UType.Checked)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet3.Usp_View_Users)
                MsgBox("User Info Updated Sucessfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UsersDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDGV.CellClick
        Dim row As New DataGridViewRow
        Try
            row = UsersDGV.Rows(e.RowIndex)
            UFNameTb.Text = row.Cells(1).Value.ToString()
            ULNameTb.Text = row.Cells(2).Value.ToString()
            UAddressTb.Text = row.Cells(3).Value.ToString()
            UContactTb.Text = row.Cells(4).Value.ToString()
            UsrNameTb.Text = row.Cells(5).Value.ToString()
            UType.Checked = Convert.ToBoolean(row.Cells(6).Value)
            If UFNameTb.Text = "" Then
                GlobalVariables.Key = 0
            Else
                GlobalVariables.Key = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            MsgBox("Select Row")
        End Try
    End Sub
    Private Sub ERemoveBtn_Click(sender As Object, e As EventArgs) Handles URemoveBtn.Click
        If UPasswdTb.Text <> UConfirmPasswdTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UFNameTb.Text = "" Or ULNameTb.Text = "" Or UAddressTb.Text = "" Or UContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Remove_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UId", GlobalVariables.Key),
                New SqlParameter("@UAdId", GlobalVariables.UserId)
            }
            Dim CmdType As CommandType = CommandType.StoredProcedure
            Dim AddEmpResult = GlobalVariables.InsertUpdateDelete(Query, Param, CmdType)
            If AddEmpResult = -1 Then
                MsgBox("DataBase Exception Occured! Try Again")
                Reset()
            Else
                Me.Usp_View_UsersTableAdapter.Fill(Me.SpaMgtSysDataSet3.Usp_View_Users)
                MsgBox("Employee Removed Sucessfully")
            End If
        End If
    End Sub
End Class