Public Class UsersPanel


    Private Sub UsersPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim LoginPanel As New LoginForm
            LoginPanel.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BookToolStripMenuItemBook_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItemBook.Click
        UserPanelBook.MdiParent = Me
        UserPanelBook.Show()
    End Sub

    Private Sub ManageCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCustomersToolStripMenuItem.Click
        UsersPanelManageCustomers.MdiParent = Me
        UsersPanelManageCustomers.Show()
    End Sub

    Private Sub CheckAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAppointmentToolStripMenuItem.Click
        UsersPanelCheckAppointment.MdiParent = Me
        UsersPanelCheckAppointment.Show()
    End Sub

    Private Sub CancelAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelAppointmentToolStripMenuItem.Click
        UsersPanelCancelAppointment.MdiParent = Me
        UsersPanelCancelAppointment.Show()
    End Sub
    Private Sub ShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftToolStripMenuItem.Click
        UsersPanelShiftAppointment.MdiParent = Me
        UsersPanelShiftAppointment.Show()
    End Sub
End Class