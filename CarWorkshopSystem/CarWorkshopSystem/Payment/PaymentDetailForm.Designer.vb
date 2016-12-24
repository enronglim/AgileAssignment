<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDetailForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentDetailForm))
        Me.docReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dlgPreviewReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.mskCustomerIc = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPaymentDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNetSellAfterDiscount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGstTaxAmount = New System.Windows.Forms.TextBox()
        Me.txtGrossSales = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvBillingRecordPaymentDetail = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaymentTime = New System.Windows.Forms.TextBox()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.BtnGenerateReceipt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNetSell = New System.Windows.Forms.TextBox()
        Me.mskChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtServiceCouponNo = New System.Windows.Forms.TextBox()
        Me.lblUsage = New System.Windows.Forms.Label()
        CType(Me.dgvBillingRecordPaymentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'docReceipt
        '
        Me.docReceipt.OriginAtMargins = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 211
        Me.Label6.Text = "Payment Method"
        '
        'dlgPreviewReceipt
        '
        Me.dlgPreviewReceipt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReceipt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReceipt.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewReceipt.Enabled = True
        Me.dlgPreviewReceipt.Icon = CType(resources.GetObject("dlgPreviewReceipt.Icon"), System.Drawing.Icon)
        Me.dlgPreviewReceipt.Name = "dlgPreview"
        Me.dlgPreviewReceipt.UseAntiAlias = True
        Me.dlgPreviewReceipt.Visible = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(143, 48)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 22)
        Me.txtCustomerName.TabIndex = 5
        '
        'mskCustomerIc
        '
        Me.mskCustomerIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustomerIc.Location = New System.Drawing.Point(143, 87)
        Me.mskCustomerIc.Mask = "000000-00-0000"
        Me.mskCustomerIc.Name = "mskCustomerIc"
        Me.mskCustomerIc.ReadOnly = True
        Me.mskCustomerIc.Size = New System.Drawing.Size(100, 22)
        Me.mskCustomerIc.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "Customer I/C No     "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 19)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Customer Name     "
        '
        'txtPaymentDate
        '
        Me.txtPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPaymentDate.Location = New System.Drawing.Point(520, 12)
        Me.txtPaymentDate.Name = "txtPaymentDate"
        Me.txtPaymentDate.ReadOnly = True
        Me.txtPaymentDate.Size = New System.Drawing.Size(117, 22)
        Me.txtPaymentDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "Payment Date"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPaymentID.Location = New System.Drawing.Point(143, 9)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.ReadOnly = True
        Me.txtPaymentID.Size = New System.Drawing.Size(117, 22)
        Me.txtPaymentID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "Payment No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Discount(-)"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(805, 529)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 493)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 19)
        Me.Label14.TabIndex = 200
        Me.Label14.Text = "After Discount "
        '
        'txtNetSellAfterDiscount
        '
        Me.txtNetSellAfterDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSellAfterDiscount.Location = New System.Drawing.Point(171, 490)
        Me.txtNetSellAfterDiscount.Name = "txtNetSellAfterDiscount"
        Me.txtNetSellAfterDiscount.ReadOnly = True
        Me.txtNetSellAfterDiscount.Size = New System.Drawing.Size(117, 22)
        Me.txtNetSellAfterDiscount.TabIndex = 13
        Me.txtNetSellAfterDiscount.Text = "0.00"
        Me.txtNetSellAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 19)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "GST Tax Amount(+)"
        '
        'txtGstTaxAmount
        '
        Me.txtGstTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGstTaxAmount.Location = New System.Drawing.Point(171, 373)
        Me.txtGstTaxAmount.Name = "txtGstTaxAmount"
        Me.txtGstTaxAmount.ReadOnly = True
        Me.txtGstTaxAmount.Size = New System.Drawing.Size(117, 22)
        Me.txtGstTaxAmount.TabIndex = 11
        Me.txtGstTaxAmount.Text = "0.00"
        Me.txtGstTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrossSales
        '
        Me.txtGrossSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossSales.Location = New System.Drawing.Point(171, 336)
        Me.txtGrossSales.Name = "txtGrossSales"
        Me.txtGrossSales.ReadOnly = True
        Me.txtGrossSales.Size = New System.Drawing.Size(117, 22)
        Me.txtGrossSales.TabIndex = 10
        Me.txtGrossSales.Text = "0.00"
        Me.txtGrossSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Gross Sales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 19)
        Me.Label10.TabIndex = 194
        Me.Label10.Text = "Billing Recrod"
        '
        'dgvBillingRecordPaymentDetail
        '
        Me.dgvBillingRecordPaymentDetail.AllowUserToAddRows = False
        Me.dgvBillingRecordPaymentDetail.AllowUserToDeleteRows = False
        Me.dgvBillingRecordPaymentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillingRecordPaymentDetail.Location = New System.Drawing.Point(-1, 154)
        Me.dgvBillingRecordPaymentDetail.Name = "dgvBillingRecordPaymentDetail"
        Me.dgvBillingRecordPaymentDetail.ReadOnly = True
        Me.dgvBillingRecordPaymentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillingRecordPaymentDetail.Size = New System.Drawing.Size(906, 155)
        Me.dgvBillingRecordPaymentDetail.TabIndex = 500
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(399, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "Payment Time"
        '
        'txtPaymentTime
        '
        Me.txtPaymentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPaymentTime.Location = New System.Drawing.Point(520, 49)
        Me.txtPaymentTime.Name = "txtPaymentTime"
        Me.txtPaymentTime.ReadOnly = True
        Me.txtPaymentTime.Size = New System.Drawing.Size(117, 22)
        Me.txtPaymentTime.TabIndex = 8
        '
        'txtMethod
        '
        Me.txtMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMethod.Location = New System.Drawing.Point(678, 322)
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.ReadOnly = True
        Me.txtMethod.Size = New System.Drawing.Size(139, 22)
        Me.txtMethod.TabIndex = 14
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentAmount.Location = New System.Drawing.Point(678, 371)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.ReadOnly = True
        Me.txtPaymentAmount.Size = New System.Drawing.Size(139, 22)
        Me.txtPaymentAmount.TabIndex = 15
        Me.txtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(501, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 19)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Payment Receive RM"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(171, 445)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(117, 22)
        Me.txtDiscount.TabIndex = 12
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGenerateReceipt
        '
        Me.BtnGenerateReceipt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateReceipt.Location = New System.Drawing.Point(590, 529)
        Me.BtnGenerateReceipt.Name = "BtnGenerateReceipt"
        Me.BtnGenerateReceipt.Size = New System.Drawing.Size(196, 29)
        Me.BtnGenerateReceipt.TabIndex = 2
        Me.BtnGenerateReceipt.Text = "Generate Receipt"
        Me.BtnGenerateReceipt.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 19)
        Me.Label9.TabIndex = 502
        Me.Label9.Text = "Net Selling Price"
        '
        'txtNetSell
        '
        Me.txtNetSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSell.Location = New System.Drawing.Point(172, 412)
        Me.txtNetSell.Name = "txtNetSell"
        Me.txtNetSell.ReadOnly = True
        Me.txtNetSell.Size = New System.Drawing.Size(117, 22)
        Me.txtNetSell.TabIndex = 501
        Me.txtNetSell.Text = "0.00"
        Me.txtNetSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskChange
        '
        Me.mskChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskChange.Location = New System.Drawing.Point(678, 416)
        Me.mskChange.Name = "mskChange"
        Me.mskChange.ReadOnly = True
        Me.mskChange.Size = New System.Drawing.Size(139, 22)
        Me.mskChange.TabIndex = 504
        Me.mskChange.Text = "0.00"
        Me.mskChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChange.Location = New System.Drawing.Point(501, 410)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(100, 28)
        Me.lblChange.TabIndex = 503
        Me.lblChange.Text = "Change RM"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServiceCouponNo
        '
        Me.txtServiceCouponNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtServiceCouponNo.Location = New System.Drawing.Point(306, 448)
        Me.txtServiceCouponNo.Name = "txtServiceCouponNo"
        Me.txtServiceCouponNo.ReadOnly = True
        Me.txtServiceCouponNo.Size = New System.Drawing.Size(119, 22)
        Me.txtServiceCouponNo.TabIndex = 505
        Me.txtServiceCouponNo.Text = "Service Coupon"
        Me.txtServiceCouponNo.Visible = False
        '
        'lblUsage
        '
        Me.lblUsage.AutoSize = True
        Me.lblUsage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsage.Location = New System.Drawing.Point(313, 496)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(0, 20)
        Me.lblUsage.TabIndex = 506
        '
        'PaymentDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.lblUsage)
        Me.Controls.Add(Me.txtServiceCouponNo)
        Me.Controls.Add(Me.mskChange)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNetSell)
        Me.Controls.Add(Me.BtnGenerateReceipt)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPaymentAmount)
        Me.Controls.Add(Me.txtMethod)
        Me.Controls.Add(Me.txtPaymentTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.mskCustomerIc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPaymentDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNetSellAfterDiscount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtGstTaxAmount)
        Me.Controls.Add(Me.txtGrossSales)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvBillingRecordPaymentDetail)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "PaymentDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Payment Detail Form"
        CType(Me.dgvBillingRecordPaymentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents docReceipt As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dlgPreviewReceipt As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents mskCustomerIc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNetSellAfterDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGstTaxAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossSales As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvBillingRecordPaymentDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentTime As System.Windows.Forms.TextBox
    Friend WithEvents txtMethod As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerateReceipt As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNetSell As System.Windows.Forms.TextBox
    Friend WithEvents mskChange As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtServiceCouponNo As System.Windows.Forms.TextBox
    Friend WithEvents lblUsage As System.Windows.Forms.Label
End Class
