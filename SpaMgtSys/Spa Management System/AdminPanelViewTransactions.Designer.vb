<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanelViewTransactions
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
        Me.TransactionsDGV = New System.Windows.Forms.DataGridView()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SortByUserIdLbl = New System.Windows.Forms.Label()
        Me.UserIdTb = New System.Windows.Forms.TextBox()
        Me.CusIdTb = New System.Windows.Forms.TextBox()
        Me.SortByCustomerIdLbl = New System.Windows.Forms.Label()
        Me.SpaMgtSysDataSet4 = New Spa_Management_System.SpaMgtSysDataSet4()
        Me.Usp_View_TransactionsTableAdapter = New Spa_Management_System.SpaMgtSysDataSet4TableAdapters.Usp_View_TransactionsTableAdapter()
        Me.UspViewTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TransactionsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaMgtSysDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspViewTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionsDGV
        '
        Me.TransactionsDGV.AllowUserToAddRows = False
        Me.TransactionsDGV.AllowUserToDeleteRows = False
        Me.TransactionsDGV.AutoGenerateColumns = False
        Me.TransactionsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransactionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIdDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.CusIDDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.TransactionsDGV.DataSource = Me.UspViewTransactionsBindingSource
        Me.TransactionsDGV.Location = New System.Drawing.Point(12, 83)
        Me.TransactionsDGV.Name = "TransactionsDGV"
        Me.TransactionsDGV.ReadOnly = True
        Me.TransactionsDGV.RowHeadersVisible = False
        Me.TransactionsDGV.RowTemplate.Height = 30
        Me.TransactionsDGV.Size = New System.Drawing.Size(984, 442)
        Me.TransactionsDGV.TabIndex = 0
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.LightGray
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Location = New System.Drawing.Point(248, 24)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(96, 39)
        Me.SearchBtn.TabIndex = 80
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'SortByUserIdLbl
        '
        Me.SortByUserIdLbl.AutoSize = True
        Me.SortByUserIdLbl.Location = New System.Drawing.Point(12, 14)
        Me.SortByUserIdLbl.Name = "SortByUserIdLbl"
        Me.SortByUserIdLbl.Size = New System.Drawing.Size(141, 25)
        Me.SortByUserIdLbl.TabIndex = 81
        Me.SortByUserIdLbl.Text = "Sort By User ID:"
        '
        'UserIdTb
        '
        Me.UserIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIdTb.Location = New System.Drawing.Point(159, 12)
        Me.UserIdTb.Name = "UserIdTb"
        Me.UserIdTb.Size = New System.Drawing.Size(79, 29)
        Me.UserIdTb.TabIndex = 82
        '
        'CusIdTb
        '
        Me.CusIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusIdTb.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusIdTb.Location = New System.Drawing.Point(159, 48)
        Me.CusIdTb.Name = "CusIdTb"
        Me.CusIdTb.Size = New System.Drawing.Size(79, 29)
        Me.CusIdTb.TabIndex = 84
        '
        'SortByCustomerIdLbl
        '
        Me.SortByCustomerIdLbl.AutoSize = True
        Me.SortByCustomerIdLbl.Location = New System.Drawing.Point(12, 50)
        Me.SortByCustomerIdLbl.Name = "SortByCustomerIdLbl"
        Me.SortByCustomerIdLbl.Size = New System.Drawing.Size(134, 25)
        Me.SortByCustomerIdLbl.TabIndex = 83
        Me.SortByCustomerIdLbl.Text = "Sort By Cus ID:"
        '
        'SpaMgtSysDataSet4
        '
        Me.SpaMgtSysDataSet4.DataSetName = "SpaMgtSysDataSet4"
        Me.SpaMgtSysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_View_TransactionsTableAdapter
        '
        Me.Usp_View_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'UspViewTransactionsBindingSource
        '
        Me.UspViewTransactionsBindingSource.DataMember = "Usp_View_Transactions"
        Me.UspViewTransactionsBindingSource.DataSource = Me.SpaMgtSysDataSet4
        '
        'TIdDataGridViewTextBoxColumn
        '
        Me.TIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TIdDataGridViewTextBoxColumn.DataPropertyName = "TId"
        Me.TIdDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.TIdDataGridViewTextBoxColumn.HeaderText = "TId"
        Me.TIdDataGridViewTextBoxColumn.Name = "TIdDataGridViewTextBoxColumn"
        Me.TIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CusIDDataGridViewTextBoxColumn
        '
        Me.CusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CusIDDataGridViewTextBoxColumn.DataPropertyName = "Cus ID"
        Me.CusIDDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.CusIDDataGridViewTextBoxColumn.HeaderText = "Cus ID"
        Me.CusIDDataGridViewTextBoxColumn.Name = "CusIDDataGridViewTextBoxColumn"
        Me.CusIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminPanelViewTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.CusIdTb)
        Me.Controls.Add(Me.SortByCustomerIdLbl)
        Me.Controls.Add(Me.UserIdTb)
        Me.Controls.Add(Me.SortByUserIdLbl)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.TransactionsDGV)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "AdminPanelViewTransactions"
        Me.Text = "AdminPanelViewTransactions"
        CType(Me.TransactionsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaMgtSysDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspViewTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransactionsDGV As DataGridView
    Friend WithEvents SpaMgtSysDataSet4 As SpaMgtSysDataSet4
    Friend WithEvents Usp_View_TransactionsTableAdapter As SpaMgtSysDataSet4TableAdapters.Usp_View_TransactionsTableAdapter
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SortByUserIdLbl As Label
    Friend WithEvents UserIdTb As TextBox
    Friend WithEvents CusIdTb As TextBox
    Friend WithEvents SortByCustomerIdLbl As Label
    Friend WithEvents TIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UspViewTransactionsBindingSource As BindingSource
End Class
