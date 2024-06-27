<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersPanelManageCustomers
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.CAddBtn = New System.Windows.Forms.Button()
        Me.CFNameLbl = New System.Windows.Forms.Label()
        Me.CUpdateBtn = New System.Windows.Forms.Button()
        Me.CFNameTb = New System.Windows.Forms.TextBox()
        Me.CAddressLbl = New System.Windows.Forms.Label()
        Me.CLNameTb = New System.Windows.Forms.TextBox()
        Me.CLNameLbl = New System.Windows.Forms.Label()
        Me.CAddressTb = New System.Windows.Forms.TextBox()
        Me.CContactTb = New System.Windows.Forms.TextBox()
        Me.CContactLbl = New System.Windows.Forms.Label()
        Me.CustomersDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspViewCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaMgtSysDataSet = New Spa_Management_System.SpaMgtSysDataSet()
        Me.Usp_View_CustomersTableAdapter = New Spa_Management_System.SpaMgtSysDataSetTableAdapters.Usp_View_CustomersTableAdapter()
        CType(Me.CustomersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.LightGray
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Location = New System.Drawing.Point(42, 184)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(82, 39)
        Me.SearchBtn.TabIndex = 76
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightGray
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Location = New System.Drawing.Point(42, 230)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(82, 39)
        Me.ResetBtn.TabIndex = 75
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'CAddBtn
        '
        Me.CAddBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CAddBtn.FlatAppearance.BorderSize = 0
        Me.CAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CAddBtn.Location = New System.Drawing.Point(130, 183)
        Me.CAddBtn.Name = "CAddBtn"
        Me.CAddBtn.Size = New System.Drawing.Size(184, 39)
        Me.CAddBtn.TabIndex = 74
        Me.CAddBtn.Text = "Add Customer"
        Me.CAddBtn.UseVisualStyleBackColor = False
        '
        'CFNameLbl
        '
        Me.CFNameLbl.AutoSize = True
        Me.CFNameLbl.Location = New System.Drawing.Point(21, 37)
        Me.CFNameLbl.Name = "CFNameLbl"
        Me.CFNameLbl.Size = New System.Drawing.Size(106, 25)
        Me.CFNameLbl.TabIndex = 65
        Me.CFNameLbl.Text = "First Name:"
        '
        'CUpdateBtn
        '
        Me.CUpdateBtn.BackColor = System.Drawing.Color.LightSalmon
        Me.CUpdateBtn.FlatAppearance.BorderSize = 0
        Me.CUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CUpdateBtn.Location = New System.Drawing.Point(130, 231)
        Me.CUpdateBtn.Name = "CUpdateBtn"
        Me.CUpdateBtn.Size = New System.Drawing.Size(184, 39)
        Me.CUpdateBtn.TabIndex = 73
        Me.CUpdateBtn.Text = "Edit Info"
        Me.CUpdateBtn.UseVisualStyleBackColor = False
        '
        'CFNameTb
        '
        Me.CFNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CFNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFNameTb.Location = New System.Drawing.Point(133, 33)
        Me.CFNameTb.Name = "CFNameTb"
        Me.CFNameTb.Size = New System.Drawing.Size(181, 29)
        Me.CFNameTb.TabIndex = 66
        '
        'CAddressLbl
        '
        Me.CAddressLbl.AutoSize = True
        Me.CAddressLbl.Location = New System.Drawing.Point(44, 109)
        Me.CAddressLbl.Name = "CAddressLbl"
        Me.CAddressLbl.Size = New System.Drawing.Size(83, 25)
        Me.CAddressLbl.TabIndex = 67
        Me.CAddressLbl.Text = "Address:"
        '
        'CLNameTb
        '
        Me.CLNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CLNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLNameTb.Location = New System.Drawing.Point(133, 72)
        Me.CLNameTb.Name = "CLNameTb"
        Me.CLNameTb.Size = New System.Drawing.Size(181, 29)
        Me.CLNameTb.TabIndex = 72
        '
        'CLNameLbl
        '
        Me.CLNameLbl.AutoSize = True
        Me.CLNameLbl.Location = New System.Drawing.Point(23, 76)
        Me.CLNameLbl.Name = "CLNameLbl"
        Me.CLNameLbl.Size = New System.Drawing.Size(104, 25)
        Me.CLNameLbl.TabIndex = 71
        Me.CLNameLbl.Text = "Last Name:"
        '
        'CAddressTb
        '
        Me.CAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CAddressTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAddressTb.Location = New System.Drawing.Point(133, 107)
        Me.CAddressTb.Name = "CAddressTb"
        Me.CAddressTb.Size = New System.Drawing.Size(181, 29)
        Me.CAddressTb.TabIndex = 70
        '
        'CContactTb
        '
        Me.CContactTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CContactTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CContactTb.Location = New System.Drawing.Point(133, 145)
        Me.CContactTb.Name = "CContactTb"
        Me.CContactTb.Size = New System.Drawing.Size(181, 29)
        Me.CContactTb.TabIndex = 68
        '
        'CContactLbl
        '
        Me.CContactLbl.AutoSize = True
        Me.CContactLbl.Location = New System.Drawing.Point(46, 147)
        Me.CContactLbl.Name = "CContactLbl"
        Me.CContactLbl.Size = New System.Drawing.Size(81, 25)
        Me.CContactLbl.TabIndex = 69
        Me.CContactLbl.Text = "Contact:"
        '
        'CustomersDGV
        '
        Me.CustomersDGV.AllowUserToAddRows = False
        Me.CustomersDGV.AllowUserToDeleteRows = False
        Me.CustomersDGV.AllowUserToResizeColumns = False
        Me.CustomersDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CustomersDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomersDGV.AutoGenerateColumns = False
        Me.CustomersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomersDGV.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomersDGV.ColumnHeadersHeight = 30
        Me.CustomersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CustomersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn})
        Me.CustomersDGV.DataSource = Me.UspViewCustomersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomersDGV.Location = New System.Drawing.Point(333, 33)
        Me.CustomersDGV.Name = "CustomersDGV"
        Me.CustomersDGV.ReadOnly = True
        Me.CustomersDGV.RowHeadersVisible = False
        Me.CustomersDGV.RowTemplate.Height = 30
        Me.CustomersDGV.RowTemplate.ReadOnly = True
        Me.CustomersDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomersDGV.Size = New System.Drawing.Size(663, 492)
        Me.CustomersDGV.TabIndex = 77
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspViewCustomersBindingSource
        '
        Me.UspViewCustomersBindingSource.DataMember = "Usp_View_Customers"
        Me.UspViewCustomersBindingSource.DataSource = Me.SpaMgtSysDataSet
        '
        'SpaMgtSysDataSet
        '
        Me.SpaMgtSysDataSet.DataSetName = "SpaMgtSysDataSet"
        Me.SpaMgtSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_CustomersTableAdapter
        '
        Me.Usp_View_CustomersTableAdapter.ClearBeforeFill = True
        '
        'UsersPanelManageCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.CustomersDGV)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.CAddBtn)
        Me.Controls.Add(Me.CFNameLbl)
        Me.Controls.Add(Me.CUpdateBtn)
        Me.Controls.Add(Me.CFNameTb)
        Me.Controls.Add(Me.CAddressLbl)
        Me.Controls.Add(Me.CLNameTb)
        Me.Controls.Add(Me.CLNameLbl)
        Me.Controls.Add(Me.CAddressTb)
        Me.Controls.Add(Me.CContactTb)
        Me.Controls.Add(Me.CContactLbl)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UsersPanelManageCustomers"
        Me.Text = "Manage Customers"
        CType(Me.CustomersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents CAddBtn As Button
    Friend WithEvents CFNameLbl As Label
    Friend WithEvents CUpdateBtn As Button
    Friend WithEvents CFNameTb As TextBox
    Friend WithEvents CAddressLbl As Label
    Friend WithEvents CLNameTb As TextBox
    Friend WithEvents CLNameLbl As Label
    Friend WithEvents CAddressTb As TextBox
    Friend WithEvents CContactTb As TextBox
    Friend WithEvents CContactLbl As Label
    Friend WithEvents CustomersDGV As DataGridView
    Friend WithEvents SpaMgtSysDataSet As SpaMgtSysDataSet
    Friend WithEvents UspViewCustomersBindingSource As BindingSource
    Friend WithEvents Usp_View_CustomersTableAdapter As SpaMgtSysDataSetTableAdapters.Usp_View_CustomersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
