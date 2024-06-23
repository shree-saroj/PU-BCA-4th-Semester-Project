Public Class ShiftAppointment
    Sub ExitPb_MouseEnter(sender As Object, e As EventArgs) Handles ExitPb.MouseEnter
        ExitPb.BackColor = Color.Red
    End Sub
    Private Sub ExitPb_MouseLeave(sender As Object, e As EventArgs) Handles ExitPb.MouseLeave
        ExitPb.BackColor = Color.YellowGreen
    End Sub
    Private Sub ExitPb_Click(sender As Object, e As EventArgs) Handles ExitPb.Click
        Application.Exit()
    End Sub

    Private Sub AvailabilityBtn_Click(sender As Object, e As EventArgs) Handles AvailabilityBtn.Click
        Dim CheckAppointment As Availablility = New Availablility
        CheckAppointment.Show()
        Me.Hide()
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
End Class