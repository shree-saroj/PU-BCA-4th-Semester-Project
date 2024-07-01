<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanelManageServices
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SRemoveBtn = New System.Windows.Forms.Button()
        Me.SUpdateBtn = New System.Windows.Forms.Button()
        Me.SAddBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.SPriceTb = New System.Windows.Forms.TextBox()
        Me.SPriceLbl = New System.Windows.Forms.Label()
        Me.SNameTb = New System.Windows.Forms.TextBox()
        Me.SNameLbl = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet1 = New Spa_Management_System.SpaMgtSysDataSet1()
        Me.Usp_View_ServicesTableAdapter = New Spa_Management_System.SpaMgtSysDataSet1TableAdapters.Usp_View_ServicesTableAdapter()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SRemoveBtn
        '
        Me.SRemoveBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.SRemoveBtn.FlatAppearance.BorderSize = 0
        Me.SRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SRemoveBtn.Location = New System.Drawing.Point(501, 101)
        Me.SRemoveBtn.Name = "SRemoveBtn"
        Me.SRemoveBtn.Size = New System.Drawing.Size(184, 34)
        Me.SRemoveBtn.TabIndex = 65
        Me.SRemoveBtn.Text = "Remove Service"
        Me.SRemoveBtn.UseVisualStyleBackColor = False
        '
        'SUpdateBtn
        '
        Me.SUpdateBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.SUpdateBtn.FlatAppearance.BorderSize = 0
        Me.SUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUpdateBtn.Location = New System.Drawing.Point(287, 101)
        Me.SUpdateBtn.Name = "SUpdateBtn"
        Me.SUpdateBtn.Size = New System.Drawing.Size(184, 34)
        Me.SUpdateBtn.TabIndex = 64
        Me.SUpdateBtn.Text = "Edit Info"
        Me.SUpdateBtn.UseVisualStyleBackColor = False
        '
        'SAddBtn
        '
        Me.SAddBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.SAddBtn.FlatAppearance.BorderSize = 0
        Me.SAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAddBtn.Location = New System.Drawing.Point(72, 101)
        Me.SAddBtn.Name = "SAddBtn"
        Me.SAddBtn.Size = New System.Drawing.Size(184, 34)
        Me.SAddBtn.TabIndex = 63
        Me.SAddBtn.Text = "Add Service"
        Me.SAddBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightGray
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(481, 37)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(127, 33)
        Me.ResetBtn.TabIndex = 62
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'SPriceTb
        '
        Me.SPriceTb.Location = New System.Drawing.Point(204, 52)
        Me.SPriceTb.Name = "SPriceTb"
        Me.SPriceTb.Size = New System.Drawing.Size(245, 33)
        Me.SPriceTb.TabIndex = 61
        '
        'SPriceLbl
        '
        Me.SPriceLbl.AutoSize = True
        Me.SPriceLbl.Location = New System.Drawing.Point(140, 55)
        Me.SPriceLbl.Name = "SPriceLbl"
        Me.SPriceLbl.Size = New System.Drawing.Size(58, 25)
        Me.SPriceLbl.TabIndex = 60
        Me.SPriceLbl.Text = "Price:"
        '
        'SNameTb
        '
        Me.SNameTb.Location = New System.Drawing.Point(204, 11)
        Me.SNameTb.Name = "SNameTb"
        Me.SNameTb.Size = New System.Drawing.Size(245, 33)
        Me.SNameTb.TabIndex = 59
        '
        'SNameLbl
        '
        Me.SNameLbl.AutoSize = True
        Me.SNameLbl.Location = New System.Drawing.Point(67, 14)
        Me.SNameLbl.Name = "SNameLbl"
        Me.SNameLbl.Size = New System.Drawing.Size(131, 25)
        Me.SNameLbl.TabIndex = 58
        Me.SNameLbl.Text = "Service Name:"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.AllowUserToResizeColumns = False
        Me.EmployeeDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.AutoGenerateColumns = False
        Me.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDGV.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeDGV.ColumnHeadersHeight = 30
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.EmployeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ServiceNameDataGridViewTextBoxColumn1, Me.CostDataGridViewTextBoxColumn1})
        Me.EmployeeDGV.DataSource = Me.UspViewServicesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(72, 155)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowTemplate.Height = 30
        Me.EmployeeDGV.RowTemplate.ReadOnly = True
        Me.EmployeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDGV.Size = New System.Drawing.Size(613, 370)
        Me.EmployeeDGV.TabIndex = 66
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ServiceNameDataGridViewTextBoxColumn1
        '
        Me.ServiceNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceNameDataGridViewTextBoxColumn1.DataPropertyName = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn1.FillWeight = 73.85786!
        Me.ServiceNameDataGridViewTextBoxColumn1.HeaderText = "Service Name"
        Me.ServiceNameDataGridViewTextBoxColumn1.Name = "ServiceNameDataGridViewTextBoxColumn1"
        Me.ServiceNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn1
        '
        Me.CostDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CostDataGridViewTextBoxColumn1.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.CostDataGridViewTextBoxColumn1.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn1.Name = "CostDataGridViewTextBoxColumn1"
        Me.CostDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UspViewServicesBindingSource
        '
        Me.UspViewServicesBindingSource.DataMember = "Usp_View_Services"
        Me.UspViewServicesBindingSource.DataSource = Me.SpaMgtSysDataSet1
        '
        'SpaMgtSysDataSet1
        '
        Me.SpaMgtSysDataSet1.DataSetName = "SpaMgtSysDataSet1"
        Me.SpaMgtSysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_ServicesTableAdapter
        '
        Me.Usp_View_ServicesTableAdapter.ClearBeforeFill = True
        '
        'AdminPanelManageServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 537)
        Me.Controls.Add(Me.EmployeeDGV)
        Me.Controls.Add(Me.SRemoveBtn)
        Me.Controls.Add(Me.SUpdateBtn)
        Me.Controls.Add(Me.SAddBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.SPriceTb)
        Me.Controls.Add(Me.SPriceLbl)
        Me.Controls.Add(Me.SNameTb)
        Me.Controls.Add(Me.SNameLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "AdminPanelManageServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Services"
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SRemoveBtn As Button
    Friend WithEvents SUpdateBtn As Button
    Friend WithEvents SAddBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents SPriceTb As TextBox
    Friend WithEvents SPriceLbl As Label
    Friend WithEvents SNameTb As TextBox
    Friend WithEvents SNameLbl As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents SpaMgtSysDataSet1 As SpaMgtSysDataSet1
    Friend WithEvents UspViewServicesBindingSource As BindingSource
    Friend WithEvents Usp_View_ServicesTableAdapter As SpaMgtSysDataSet1TableAdapters.Usp_View_ServicesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
