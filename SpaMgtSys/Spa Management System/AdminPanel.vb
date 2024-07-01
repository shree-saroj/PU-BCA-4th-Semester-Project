Public Class AdminPanel
    Private Sub AdminPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim LoginPanel As New LoginForm
            LoginPanel.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click
        AdminPanelManageServices.MdiParent = Me
        AdminPanelManageServices.Show()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        AdminPanelManageEmployees.MdiParent = Me
        AdminPanelManageEmployees.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        AdminPanelManageUsers.MdiParent = Me
        AdminPanelManageUsers.Show()
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        AdminPanelCustomerInfo.MdiParent = Me
        AdminPanelCustomerInfo.Show()
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem.Click
        AdminPanelViewTransactions.MdiParent = Me
        AdminPanelViewTransactions.Show()
    End Sub

    Private Sub StatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem.Click
        AdminPanelViewStatistics.MdiParent = Me
        AdminPanelViewStatistics.Show()
    End Sub
End Class