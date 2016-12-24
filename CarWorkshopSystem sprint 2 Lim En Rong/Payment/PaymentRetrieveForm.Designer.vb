<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentRetrieveForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBill = New System.Windows.Forms.DataGridView()
        Me.byBillNo = New System.Windows.Forms.Button()
        Me.byCustomerIC = New System.Windows.Forms.Button()
        Me.byCustomerName = New System.Windows.Forms.Button()
        Me.btnViewPayment = New System.Windows.Forms.Button()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(817, 537)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMakePayment
        '
        Me.btnMakePayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePayment.Location = New System.Drawing.Point(484, 537)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(139, 29)
        Me.btnMakePayment.TabIndex = 6
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSearch.Location = New System.Drawing.Point(80, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(299, 26)
        Me.txtSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search:"
        '
        'dgvBill
        '
        Me.dgvBill.AllowUserToAddRows = False
        Me.dgvBill.AllowUserToDeleteRows = False
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Location = New System.Drawing.Point(1, 56)
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.ReadOnly = True
        Me.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBill.Size = New System.Drawing.Size(902, 468)
        Me.dgvBill.TabIndex = 17
        '
        'byBillNo
        '
        Me.byBillNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byBillNo.ForeColor = System.Drawing.Color.MediumBlue
        Me.byBillNo.Location = New System.Drawing.Point(1, 1)
        Me.byBillNo.Name = "byBillNo"
        Me.byBillNo.Size = New System.Drawing.Size(125, 23)
        Me.byBillNo.TabIndex = 1
        Me.byBillNo.Text = "By Bill No"
        Me.byBillNo.UseVisualStyleBackColor = True
        '
        'byCustomerIC
        '
        Me.byCustomerIC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerIC.Location = New System.Drawing.Point(254, 1)
        Me.byCustomerIC.Name = "byCustomerIC"
        Me.byCustomerIC.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerIC.TabIndex = 20
        Me.byCustomerIC.Text = "By Customer I/C No"
        Me.byCustomerIC.UseVisualStyleBackColor = True
        '
        'byCustomerName
        '
        Me.byCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.byCustomerName.Location = New System.Drawing.Point(126, 1)
        Me.byCustomerName.Name = "byCustomerName"
        Me.byCustomerName.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerName.TabIndex = 19
        Me.byCustomerName.Text = "By Customer Name"
        Me.byCustomerName.UseVisualStyleBackColor = True
        '
        'btnViewPayment
        '
        Me.btnViewPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPayment.Location = New System.Drawing.Point(629, 537)
        Me.btnViewPayment.Name = "btnViewPayment"
        Me.btnViewPayment.Size = New System.Drawing.Size(185, 29)
        Me.btnViewPayment.TabIndex = 21
        Me.btnViewPayment.Text = "View Payment "
        Me.btnViewPayment.UseVisualStyleBackColor = True
        '
        'PaymentRetrieveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.btnViewPayment)
        Me.Controls.Add(Me.byCustomerIC)
        Me.Controls.Add(Me.byCustomerName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMakePayment)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBill)
        Me.Controls.Add(Me.byBillNo)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "PaymentRetrieveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Browse the Bill Retrieve Form"
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMakePayment As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvBill As System.Windows.Forms.DataGridView
    Friend WithEvents byBillNo As System.Windows.Forms.Button
    Friend WithEvents byCustomerIC As System.Windows.Forms.Button
    Friend WithEvents byCustomerName As System.Windows.Forms.Button
    Friend WithEvents btnViewPayment As System.Windows.Forms.Button
End Class
