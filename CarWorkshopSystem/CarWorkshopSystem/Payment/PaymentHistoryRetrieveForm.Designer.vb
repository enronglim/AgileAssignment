<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentHistoryRetrieveForm
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
        Me.btnViewPaymentDetail = New System.Windows.Forms.Button()
        Me.byCustomerIC = New System.Windows.Forms.Button()
        Me.byCustomerName = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.byBillNo = New System.Windows.Forms.Button()
        Me.byPaymentNo = New System.Windows.Forms.Button()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnViewPaymentDetail
        '
        Me.btnViewPaymentDetail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPaymentDetail.Location = New System.Drawing.Point(629, 537)
        Me.btnViewPaymentDetail.Name = "btnViewPaymentDetail"
        Me.btnViewPaymentDetail.Size = New System.Drawing.Size(185, 29)
        Me.btnViewPaymentDetail.TabIndex = 30
        Me.btnViewPaymentDetail.Text = "View Payment Detail "
        Me.btnViewPaymentDetail.UseVisualStyleBackColor = True
        '
        'byCustomerIC
        '
        Me.byCustomerIC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerIC.Location = New System.Drawing.Point(379, 1)
        Me.byCustomerIC.Name = "byCustomerIC"
        Me.byCustomerIC.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerIC.TabIndex = 29
        Me.byCustomerIC.Text = "By Customer I/C No"
        Me.byCustomerIC.UseVisualStyleBackColor = True
        '
        'byCustomerName
        '
        Me.byCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.byCustomerName.Location = New System.Drawing.Point(251, 1)
        Me.byCustomerName.Name = "byCustomerName"
        Me.byCustomerName.Size = New System.Drawing.Size(125, 23)
        Me.byCustomerName.TabIndex = 28
        Me.byCustomerName.Text = "By Customer Name"
        Me.byCustomerName.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(817, 537)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSearch.Location = New System.Drawing.Point(80, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(424, 26)
        Me.txtSearch.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search:"
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToDeleteRows = False
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Location = New System.Drawing.Point(1, 56)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayment.Size = New System.Drawing.Size(902, 468)
        Me.dgvPayment.TabIndex = 26
        '
        'byBillNo
        '
        Me.byBillNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byBillNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.byBillNo.Location = New System.Drawing.Point(126, 1)
        Me.byBillNo.Name = "byBillNo"
        Me.byBillNo.Size = New System.Drawing.Size(125, 23)
        Me.byBillNo.TabIndex = 22
        Me.byBillNo.Text = "By Bill No"
        Me.byBillNo.UseVisualStyleBackColor = True
        '
        'byPaymentNo
        '
        Me.byPaymentNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byPaymentNo.ForeColor = System.Drawing.Color.MediumBlue
        Me.byPaymentNo.Location = New System.Drawing.Point(1, 1)
        Me.byPaymentNo.Name = "byPaymentNo"
        Me.byPaymentNo.Size = New System.Drawing.Size(125, 23)
        Me.byPaymentNo.TabIndex = 31
        Me.byPaymentNo.Text = "By Payment No"
        Me.byPaymentNo.UseVisualStyleBackColor = True
        '
        'PaymentHistoryRetrieveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.byPaymentNo)
        Me.Controls.Add(Me.btnViewPaymentDetail)
        Me.Controls.Add(Me.byCustomerIC)
        Me.Controls.Add(Me.byCustomerName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPayment)
        Me.Controls.Add(Me.byBillNo)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "PaymentHistoryRetrieveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Browse the Payment Retrieve Form"
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnViewPaymentDetail As System.Windows.Forms.Button
    Friend WithEvents byCustomerIC As System.Windows.Forms.Button
    Friend WithEvents byCustomerName As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents byBillNo As System.Windows.Forms.Button
    Friend WithEvents byPaymentNo As System.Windows.Forms.Button
End Class
