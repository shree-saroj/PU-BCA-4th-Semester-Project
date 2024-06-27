<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItemBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem, Me.BookToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckAppointmentToolStripMenuItem, Me.CancelAppointmentToolStripMenuItem, Me.ShiftToolStripMenuItem})
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AppointmentToolStripMenuItem.Text = "Appointments"
        '
        'CheckAppointmentToolStripMenuItem
        '
        Me.CheckAppointmentToolStripMenuItem.Name = "CheckAppointmentToolStripMenuItem"
        Me.CheckAppointmentToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CheckAppointmentToolStripMenuItem.Text = "Check"
        '
        'CancelAppointmentToolStripMenuItem
        '
        Me.CancelAppointmentToolStripMenuItem.Name = "CancelAppointmentToolStripMenuItem"
        Me.CancelAppointmentToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CancelAppointmentToolStripMenuItem.Text = "Cancel"
        '
        'ShiftToolStripMenuItem
        '
        Me.ShiftToolStripMenuItem.Name = "ShiftToolStripMenuItem"
        Me.ShiftToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ShiftToolStripMenuItem.Text = "Shift"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageCustomersToolStripMenuItem, Me.BookToolStripMenuItemBook})
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'ManageCustomersToolStripMenuItem
        '
        Me.ManageCustomersToolStripMenuItem.Name = "ManageCustomersToolStripMenuItem"
        Me.ManageCustomersToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ManageCustomersToolStripMenuItem.Text = "Manage Customers"
        '
        'BookToolStripMenuItemBook
        '
        Me.BookToolStripMenuItemBook.Name = "BookToolStripMenuItemBook"
        Me.BookToolStripMenuItemBook.Size = New System.Drawing.Size(177, 22)
        Me.BookToolStripMenuItemBook.Text = "Book"
        '
        'UsersPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UsersPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsersPanel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShiftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItemBook As ToolStripMenuItem
End Class
