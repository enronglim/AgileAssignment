<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRetrieveForm
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
        Me.byCustomerName = New System.Windows.Forms.Button()
        Me.byCustomerIC = New System.Windows.Forms.Button()
        Me.byCustomerPassport = New System.Windows.Forms.Button()
        Me.btnContactNo = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'byCustomerName
        '
        Me.byCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerName.ForeColor = System.Drawing.Color.MediumBlue
        Me.byCustomerName.Location = New System.Drawing.Point(0, 0)
        Me.byCustomerName.Name = "byCustomerName"
        Me.byCustomerName.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerName.TabIndex = 1
        Me.byCustomerName.Text = "By Customer Name"
        Me.byCustomerName.UseVisualStyleBackColor = True
        '
        'byCustomerIC
        '
        Me.byCustomerIC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerIC.Location = New System.Drawing.Point(125, 0)
        Me.byCustomerIC.Name = "byCustomerIC"
        Me.byCustomerIC.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerIC.TabIndex = 2
        Me.byCustomerIC.Text = "By Customer I/C No"
        Me.byCustomerIC.UseVisualStyleBackColor = True
        '
        'byCustomerPassport
        '
        Me.byCustomerPassport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerPassport.Location = New System.Drawing.Point(250, 0)
        Me.byCustomerPassport.Name = "byCustomerPassport"
        Me.byCustomerPassport.Size = New System.Drawing.Size(162, 23)
        Me.byCustomerPassport.TabIndex = 4
        Me.byCustomerPassport.Text = "By Customer passport No"
        Me.byCustomerPassport.UseVisualStyleBackColor = True
        '
        'btnContactNo
        '
        Me.btnContactNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactNo.Location = New System.Drawing.Point(412, 0)
        Me.btnContactNo.Name = "btnContactNo"
        Me.btnContactNo.Size = New System.Drawing.Size(162, 23)
        Me.btnContactNo.TabIndex = 5
        Me.btnContactNo.Text = "By Customer Contact No"
        Me.btnContactNo.UseVisualStyleBackColor = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 62)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(902, 468)
        Me.dgvCustomer.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSearch.Location = New System.Drawing.Point(79, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(495, 26)
        Me.txtSearch.TabIndex = 8
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(552, 536)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 29)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(633, 536)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(86, 29)
        Me.btnChange.TabIndex = 10
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(724, 536)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 29)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(816, 536)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CustomerRetrieveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.btnContactNo)
        Me.Controls.Add(Me.byCustomerPassport)
        Me.Controls.Add(Me.byCustomerIC)
        Me.Controls.Add(Me.byCustomerName)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "CustomerRetrieveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Browse the Customer File"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents byCustomerName As System.Windows.Forms.Button
    Friend WithEvents byCustomerIC As System.Windows.Forms.Button
    Friend WithEvents byCustomerPassport As System.Windows.Forms.Button
    Friend WithEvents btnContactNo As System.Windows.Forms.Button
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
