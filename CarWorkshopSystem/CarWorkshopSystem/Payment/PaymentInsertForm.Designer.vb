<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentInsertForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentInsertForm))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvBillingRecord = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNetSellAfterDiscount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGstTaxAmount = New System.Windows.Forms.TextBox()
        Me.txtGrossSales = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.mskCustomerIc = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.GroupBox()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbCreditCard = New System.Windows.Forms.RadioButton()
        Me.lblRM = New System.Windows.Forms.Label()
        Me.mskCC = New System.Windows.Forms.MaskedTextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.mskChange = New System.Windows.Forms.TextBox()
        Me.txtDiscountReminder = New System.Windows.Forms.Label()
        Me.txtPaymentReminder = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.dlgPreviewReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.docReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNetSell = New System.Windows.Forms.TextBox()
        Me.btnBrowseServiceCoupon = New System.Windows.Forms.Button()
        Me.txtServiceCouponNo = New System.Windows.Forms.TextBox()
        Me.lblUsage = New System.Windows.Forms.Label()
        Me.txtCreditCardReminder = New System.Windows.Forms.Label()
        CType(Me.dgvBillingRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gender.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 19)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Billing Recrod"
        '
        'dgvBillingRecord
        '
        Me.dgvBillingRecord.AllowUserToAddRows = False
        Me.dgvBillingRecord.AllowUserToDeleteRows = False
        Me.dgvBillingRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillingRecord.Location = New System.Drawing.Point(0, 151)
        Me.dgvBillingRecord.Name = "dgvBillingRecord"
        Me.dgvBillingRecord.ReadOnly = True
        Me.dgvBillingRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillingRecord.Size = New System.Drawing.Size(906, 155)
        Me.dgvBillingRecord.TabIndex = 152
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 496)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 19)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "After Discount "
        '
        'txtNetSellAfterDiscount
        '
        Me.txtNetSellAfterDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSellAfterDiscount.Location = New System.Drawing.Point(172, 493)
        Me.txtNetSellAfterDiscount.Name = "txtNetSellAfterDiscount"
        Me.txtNetSellAfterDiscount.ReadOnly = True
        Me.txtNetSellAfterDiscount.Size = New System.Drawing.Size(117, 22)
        Me.txtNetSellAfterDiscount.TabIndex = 167
        Me.txtNetSellAfterDiscount.Text = "0.00"
        Me.txtNetSellAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 19)
        Me.Label12.TabIndex = 166
        Me.Label12.Text = "GST Tax Amount(+)"
        '
        'txtGstTaxAmount
        '
        Me.txtGstTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGstTaxAmount.Location = New System.Drawing.Point(172, 370)
        Me.txtGstTaxAmount.Name = "txtGstTaxAmount"
        Me.txtGstTaxAmount.ReadOnly = True
        Me.txtGstTaxAmount.Size = New System.Drawing.Size(117, 22)
        Me.txtGstTaxAmount.TabIndex = 165
        Me.txtGstTaxAmount.Text = "0.00"
        Me.txtGstTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrossSales
        '
        Me.txtGrossSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossSales.Location = New System.Drawing.Point(172, 333)
        Me.txtGrossSales.Name = "txtGrossSales"
        Me.txtGrossSales.ReadOnly = True
        Me.txtGrossSales.Size = New System.Drawing.Size(117, 22)
        Me.txtGrossSales.TabIndex = 164
        Me.txtGrossSales.Text = "0.00"
        Me.txtGrossSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Gross Sales"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(806, 526)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 170
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(710, 526)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 29)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Discount(-)"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(172, 448)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(117, 22)
        Me.txtDiscount.TabIndex = 1
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(144, 6)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(117, 22)
        Me.txtBillNo.TabIndex = 174
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Bill No"
        '
        'txtBillDate
        '
        Me.txtBillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillDate.Location = New System.Drawing.Point(478, 8)
        Me.txtBillDate.Name = "txtBillDate"
        Me.txtBillDate.ReadOnly = True
        Me.txtBillDate.Size = New System.Drawing.Size(117, 22)
        Me.txtBillDate.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Bill Date"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(144, 45)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 22)
        Me.txtCustomerName.TabIndex = 178
        '
        'mskCustomerIc
        '
        Me.mskCustomerIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustomerIc.Location = New System.Drawing.Point(144, 84)
        Me.mskCustomerIc.Mask = "000000-00-0000"
        Me.mskCustomerIc.Name = "mskCustomerIc"
        Me.mskCustomerIc.ReadOnly = True
        Me.mskCustomerIc.Size = New System.Drawing.Size(100, 22)
        Me.mskCustomerIc.TabIndex = 180
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Customer I/C No     "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 19)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Customer Name     "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(535, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "Payment Method"
        '
        'gender
        '
        Me.gender.Controls.Add(Me.rbCash)
        Me.gender.Controls.Add(Me.rbCreditCard)
        Me.gender.Location = New System.Drawing.Point(539, 342)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(326, 41)
        Me.gender.TabIndex = 182
        Me.gender.TabStop = False
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCash.ForeColor = System.Drawing.Color.Black
        Me.rbCash.Location = New System.Drawing.Point(6, 11)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(64, 24)
        Me.rbCash.TabIndex = 20
        Me.rbCash.TabStop = True
        Me.rbCash.Tag = ""
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbCreditCard
        '
        Me.rbCreditCard.AutoSize = True
        Me.rbCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCreditCard.ForeColor = System.Drawing.Color.Black
        Me.rbCreditCard.Location = New System.Drawing.Point(96, 11)
        Me.rbCreditCard.Name = "rbCreditCard"
        Me.rbCreditCard.Size = New System.Drawing.Size(107, 24)
        Me.rbCreditCard.TabIndex = 22
        Me.rbCreditCard.Tag = ""
        Me.rbCreditCard.Text = "Credit Card"
        Me.rbCreditCard.UseVisualStyleBackColor = True
        '
        'lblRM
        '
        Me.lblRM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRM.Location = New System.Drawing.Point(535, 389)
        Me.lblRM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRM.Name = "lblRM"
        Me.lblRM.Size = New System.Drawing.Size(171, 28)
        Me.lblRM.TabIndex = 185
        Me.lblRM.Text = "Payment Receive RM"
        Me.lblRM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mskCC
        '
        Me.mskCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.mskCC.Location = New System.Drawing.Point(710, 388)
        Me.mskCC.Margin = New System.Windows.Forms.Padding(2)
        Me.mskCC.Mask = "0000-0000-0000-0000"
        Me.mskCC.Name = "mskCC"
        Me.mskCC.Size = New System.Drawing.Size(155, 22)
        Me.mskCC.TabIndex = 183
        Me.mskCC.Visible = False
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChange.Location = New System.Drawing.Point(606, 431)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(100, 28)
        Me.lblChange.TabIndex = 186
        Me.lblChange.Text = "Change RM"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mskChange
        '
        Me.mskChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskChange.Location = New System.Drawing.Point(710, 435)
        Me.mskChange.Name = "mskChange"
        Me.mskChange.ReadOnly = True
        Me.mskChange.Size = New System.Drawing.Size(155, 22)
        Me.mskChange.TabIndex = 187
        Me.mskChange.Text = "0.00"
        Me.mskChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountReminder
        '
        Me.txtDiscountReminder.AutoSize = True
        Me.txtDiscountReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountReminder.ForeColor = System.Drawing.Color.Maroon
        Me.txtDiscountReminder.Location = New System.Drawing.Point(169, 473)
        Me.txtDiscountReminder.Name = "txtDiscountReminder"
        Me.txtDiscountReminder.Size = New System.Drawing.Size(0, 16)
        Me.txtDiscountReminder.TabIndex = 188
        '
        'txtPaymentReminder
        '
        Me.txtPaymentReminder.AutoSize = True
        Me.txtPaymentReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentReminder.ForeColor = System.Drawing.Color.Maroon
        Me.txtPaymentReminder.Location = New System.Drawing.Point(542, 418)
        Me.txtPaymentReminder.Name = "txtPaymentReminder"
        Me.txtPaymentReminder.Size = New System.Drawing.Size(0, 16)
        Me.txtPaymentReminder.TabIndex = 189
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(710, 389)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(154, 22)
        Me.txtCash.TabIndex = 190
        Me.txtCash.Text = "0.00"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'docReceipt
        '
        Me.docReceipt.OriginAtMargins = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 19)
        Me.Label7.TabIndex = 192
        Me.Label7.Text = "Net Selling Price"
        '
        'txtNetSell
        '
        Me.txtNetSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSell.Location = New System.Drawing.Point(172, 412)
        Me.txtNetSell.Name = "txtNetSell"
        Me.txtNetSell.ReadOnly = True
        Me.txtNetSell.Size = New System.Drawing.Size(117, 22)
        Me.txtNetSell.TabIndex = 191
        Me.txtNetSell.Text = "0.00"
        Me.txtNetSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBrowseServiceCoupon
        '
        Me.btnBrowseServiceCoupon.Location = New System.Drawing.Point(426, 447)
        Me.btnBrowseServiceCoupon.Name = "btnBrowseServiceCoupon"
        Me.btnBrowseServiceCoupon.Size = New System.Drawing.Size(66, 23)
        Me.btnBrowseServiceCoupon.TabIndex = 193
        Me.btnBrowseServiceCoupon.Text = "Browse"
        Me.btnBrowseServiceCoupon.UseVisualStyleBackColor = True
        '
        'txtServiceCouponNo
        '
        Me.txtServiceCouponNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtServiceCouponNo.Location = New System.Drawing.Point(306, 448)
        Me.txtServiceCouponNo.Name = "txtServiceCouponNo"
        Me.txtServiceCouponNo.ReadOnly = True
        Me.txtServiceCouponNo.Size = New System.Drawing.Size(119, 22)
        Me.txtServiceCouponNo.TabIndex = 194
        Me.txtServiceCouponNo.Text = "Service Coupon"
        '
        'lblUsage
        '
        Me.lblUsage.AutoSize = True
        Me.lblUsage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsage.Location = New System.Drawing.Point(313, 496)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(0, 20)
        Me.lblUsage.TabIndex = 195
        '
        'txtCreditCardReminder
        '
        Me.txtCreditCardReminder.AutoSize = True
        Me.txtCreditCardReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCardReminder.ForeColor = System.Drawing.Color.Maroon
        Me.txtCreditCardReminder.Location = New System.Drawing.Point(714, 415)
        Me.txtCreditCardReminder.Name = "txtCreditCardReminder"
        Me.txtCreditCardReminder.Size = New System.Drawing.Size(0, 16)
        Me.txtCreditCardReminder.TabIndex = 196
        '
        'PaymentInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.txtCreditCardReminder)
        Me.Controls.Add(Me.lblUsage)
        Me.Controls.Add(Me.btnBrowseServiceCoupon)
        Me.Controls.Add(Me.txtServiceCouponNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNetSell)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtPaymentReminder)
        Me.Controls.Add(Me.txtDiscountReminder)
        Me.Controls.Add(Me.mskChange)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblRM)
        Me.Controls.Add(Me.mskCC)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.mskCustomerIc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBillDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNetSellAfterDiscount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtGstTaxAmount)
        Me.Controls.Add(Me.txtGrossSales)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvBillingRecord)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "PaymentInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Make Payment Form"
        CType(Me.dgvBillingRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gender.ResumeLayout(False)
        Me.gender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvBillingRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNetSellAfterDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGstTaxAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossSales As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBillDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents mskCustomerIc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.GroupBox
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents lblRM As System.Windows.Forms.Label
    Friend WithEvents mskCC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents mskChange As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountReminder As System.Windows.Forms.Label
    Friend WithEvents txtPaymentReminder As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents dlgPreviewReceipt As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents docReceipt As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNetSell As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseServiceCoupon As System.Windows.Forms.Button
    Friend WithEvents txtServiceCouponNo As System.Windows.Forms.TextBox
    Friend WithEvents lblUsage As System.Windows.Forms.Label
    Friend WithEvents txtCreditCardReminder As System.Windows.Forms.Label
End Class
