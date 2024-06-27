<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersPanelCheckAppointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.DateDP = New System.Windows.Forms.DateTimePicker()
        Me.ServicesCB = New System.Windows.Forms.ComboBox()
        Me.ServiceLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.TimeDGV = New System.Windows.Forms.DataGridView()
        CType(Me.TimeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBtn
        '
        Me.CheckBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CheckBtn.FlatAppearance.BorderSize = 0
        Me.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBtn.Location = New System.Drawing.Point(206, 106)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(200, 39)
        Me.CheckBtn.TabIndex = 68
        Me.CheckBtn.Text = "Check"
        Me.CheckBtn.UseVisualStyleBackColor = False
        '
        'DateDP
        '
        Me.DateDP.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDP.Location = New System.Drawing.Point(206, 71)
        Me.DateDP.Name = "DateDP"
        Me.DateDP.Size = New System.Drawing.Size(200, 29)
        Me.DateDP.TabIndex = 67
        Me.DateDP.Value = New Date(2024, 12, 25, 23, 59, 59, 0)
        '
        'ServicesCB
        '
        Me.ServicesCB.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesCB.FormattingEnabled = True
        Me.ServicesCB.Location = New System.Drawing.Point(207, 32)
        Me.ServicesCB.Name = "ServicesCB"
        Me.ServicesCB.Size = New System.Drawing.Size(199, 29)
        Me.ServicesCB.TabIndex = 66
        '
        'ServiceLbl
        '
        Me.ServiceLbl.AutoSize = True
        Me.ServiceLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceLbl.Location = New System.Drawing.Point(124, 36)
        Me.ServiceLbl.Name = "ServiceLbl"
        Me.ServiceLbl.Size = New System.Drawing.Size(76, 25)
        Me.ServiceLbl.TabIndex = 64
        Me.ServiceLbl.Text = "Service:"
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(145, 75)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(55, 25)
        Me.DateLbl.TabIndex = 65
        Me.DateLbl.Text = "Date:"
        '
        'TimeDGV
        '
        Me.TimeDGV.AllowUserToAddRows = False
        Me.TimeDGV.AllowUserToDeleteRows = False
        Me.TimeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TimeDGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TimeDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TimeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeDGV.Location = New System.Drawing.Point(140, 151)
        Me.TimeDGV.Name = "TimeDGV"
        Me.TimeDGV.ReadOnly = True
        Me.TimeDGV.RowHeadersVisible = False
        Me.TimeDGV.RowTemplate.ReadOnly = True
        Me.TimeDGV.Size = New System.Drawing.Size(310, 355)
        Me.TimeDGV.TabIndex = 69
        '
        'UsersPanelCheckAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 537)
        Me.Controls.Add(Me.TimeDGV)
        Me.Controls.Add(Me.CheckBtn)
        Me.Controls.Add(Me.DateDP)
        Me.Controls.Add(Me.ServicesCB)
        Me.Controls.Add(Me.ServiceLbl)
        Me.Controls.Add(Me.DateLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UsersPanelCheckAppointment"
        Me.Text = "Check Appointment"
        CType(Me.TimeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBtn As Button
    Friend WithEvents DateDP As DateTimePicker
    Friend WithEvents ServicesCB As ComboBox
    Friend WithEvents ServiceLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents TimeDGV As DataGridView
End Class
