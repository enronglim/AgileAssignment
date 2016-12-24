Imports System.Text

Public Class PaymentInsertForm

    Public Shared SelectedId As String
    Dim grossSales As Decimal
    Dim gstAmount As Decimal
    Dim totalAmount As Decimal
    Dim discount As Decimal
    Dim paymentID As String
    Public lastId As Integer = 0
    Public newId As Integer
    Public Shared newPaymentID As String
    Public paymentResult As String = "no"
    Public paymentResult1 As String = "no"
    Public Function GetNewPaymentId() As String
        Dim serviceData As New DBDataContext

        Dim py = From payment In serviceData.Payments
                    Select payment.paymentID
        For Each item In py
            lastId = Integer.Parse(item.Substring(2, 5))
        Next

        Return (lastId + 1).ToString("PY00000")
    End Function

    Private Sub ResetForm()
        txtCash.Text = ""
        mskCC.Text = ""
        txtDiscount.Text = "0.00"
        mskChange.Text = "0.00"
        txtPaymentReminder.Text = ""
        txtDiscountReminder.Text = ""
        txtCreditCardReminder.Text = ""
        txtServiceCouponNo.Text = "Service Coupon"
        lblUsage.Text = ""
        rbCash.Checked = False
        rbCreditCard.Checked = False
    End Sub

    Private Sub BindData()
        Dim db As New DBDataContext
        Dim rs = From br In db.BillingRecords Where br.billNo = SelectedId
                Select br.inventoryID, br.ItemStorage.stockBrand, br.ItemStorage.stockName, br.ItemStorage.stockPrice, br.quantity, br.billingAmount, br.warrantyPeriod

        Dim bl As Bill = db.Bills.FirstOrDefault(Function(o) o.billNo = SelectedId)
        grossSales = CDec(bl.totalAmount * 0.94)
        gstAmount = CDec(bl.totalAmount * 0.06)
        totalAmount = CDec(bl.totalAmount)
        dgvBillingRecord.AutoResizeColumns()
        dgvBillingRecord.DataSource = rs
        With dgvBillingRecord
            .Columns(0).HeaderText = "Inventory ID"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Brand"
            .Columns(1).Width = 100S
            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Unit Price Inc(GST)"
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Quantity"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Amount"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "Warranty Period"
            .Columns(6).Width = 200
        End With
        dgvBillingRecord.ClearSelection()
        dgvBillingRecord.CurrentCell = Nothing
        txtGrossSales.Text = grossSales.ToString("c2")
        txtGstTaxAmount.Text = gstAmount.ToString("c2")
        txtNetSellAfterDiscount.Text = totalAmount.ToString("c2")
        txtNetSell.Text = totalAmount.ToString("c2")
    End Sub
    Private Sub PaymentInsertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ResetForm()
            newPaymentID = GetNewPaymentId()
            lblChange.Visible = True
            lblRM.Visible = True
            txtCash.Visible = True
            mskCC.Visible = False
            mskChange.Visible = True
            lblRM.Text = "Payment Receive RM"
            BindData()

            Dim db As New DBDataContext()
            Dim bl As Bill = db.Bills.FirstOrDefault(Function(o) o.billNo = SelectedId)
            txtBillNo.Text = bl.billNo.ToString()
            txtBillDate.Text = bl.billDate.Value.ToString("dd/MM/yyyy")
            txtCustomerName.Text = bl.Customer.name()
            mskCustomerIc.Text = bl.customerIC()
            BindData()

        Catch ex As Exception
            MessageBox.Show("Please Generate Invoice before make payment", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub


    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        lblRM.Text = "Payment Receive RM"
        lblChange.Visible = True
        lblRM.Visible = True
        txtCash.Visible = True
        mskCC.Visible = False
        mskChange.Visible = True
        txtCreditCardReminder.Text = ""
    End Sub

    Private Sub rbCreditCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditCard.CheckedChanged
        txtPaymentReminder.Text = ("")
        lblChange.Visible = False
        lblRM.Text = "Creadit No"
        txtCash.Visible = False
        mskCC.Visible = True
        mskChange.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtServiceCouponNo.Text = "Service Coupon"
        lblUsage.Text = ""
        Me.Close()
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        Try
            If CDbl(txtNetSellAfterDiscount.Text) < CDbl(txtDiscount.Text) Then
                txtDiscountReminder.Text = ("Discount can not more than NetSell RM " & totalAmount)
                txtNetSellAfterDiscount.Text = totalAmount.ToString("c2")
                paymentResult1 = "no"
            Else
                Dim totalAmountUpdate As Decimal
                discount = CDec(txtDiscount.Text)
                totalAmountUpdate = totalAmount - discount
                txtNetSellAfterDiscount.Text = totalAmountUpdate.ToString("c2")
                txtDiscountReminder.Text = ("")
                'Dim change As Decimal
                'Dim paymentReceive As Decimal
                'paymentReceive = CDec(txtCash.Text)
                'change = paymentReceive - CDec(txtNetSellAfterDiscount.Text)

                'mskChange.Text = CStr(change)

                paymentResult1 = "ok"
            End If
        Catch ex As Exception
            txtDiscountReminder.Text = ("0.00")
            txtDiscountReminder.Text = "Please enter Decimal number"
            txtDiscount.Text = ""
            txtNetSellAfterDiscount.Text = totalAmount.ToString("c2")
            paymentResult1 = "no"
        End Try
    End Sub



    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            If CDbl(txtNetSellAfterDiscount.Text) > CDbl(txtCash.Text) Then
                txtPaymentReminder.Text = ("Payment Cash can not less than NetSell RM " & CDbl(txtNetSellAfterDiscount.Text))
            Else
                Dim change As Decimal
                Dim paymentReceive As Decimal
                paymentReceive = CDec(txtCash.Text)
                change = paymentReceive - CDec(txtNetSellAfterDiscount.Text)

                mskChange.Text = change.ToString("c2")
                txtPaymentReminder.Text = ("")
            End If
        Catch ex As Exception
            txtPaymentReminder.Text = "Please enter Decimal number"
            txtCash.Text = "0.00"
            mskChange.Text = ""
            paymentResult = "no"
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim billNo As String = txtBillNo.Text
            Dim discount As Decimal = CDec(txtDiscount.Text)
            Dim paymentAmount As Decimal = CDec(txtCash.Text)
            Dim paymentChange As Decimal = CDec(mskChange.Text)
            Dim paymentMethod As String = ""
            Dim creditNo As String = ""
            Dim serialNo As String = txtServiceCouponNo.Text
            Dim serviceCount As Integer
            If CDbl(txtNetSellAfterDiscount.Text) < CDbl(txtDiscount.Text) Then
                paymentResult = "no"
                txtDiscountReminder.Text = ("Discount can not more than NetSell RM " & totalAmount)
            Else
                paymentResult = "ok"
                txtDiscountReminder.Text = ""
            End If

            If CDbl(txtNetSellAfterDiscount.Text) > CDbl(txtCash.Text) Then
                paymentResult = "no"
                txtPaymentReminder.Text = ("Payment Cash can not less than NetSell RM " & CDbl(txtNetSellAfterDiscount.Text))
                txtCreditCardReminder.Text = ""
            Else
                paymentResult = "ok"
                txtPaymentReminder.Text = ""
                txtCreditCardReminder.Text = ""
            End If

            If rbCash.Checked Then
                paymentMethod = "Cash"
            ElseIf rbCreditCard.Checked Then
                Dim creditCard As String = If(mskCC.MaskCompleted, mskCC.Text, "")
                If creditCard = "" Then
                    paymentResult = "no"
                    txtCreditCardReminder.Text = "Enter Credit Card Number"
                    txtPaymentReminder.Text = ""
                Else
                    paymentMethod = "Credit Card"
                    paymentResult = "ok"
                    paymentAmount = CDec(txtNetSellAfterDiscount.Text)
                    creditNo = mskCC.Text
                    txtCreditCardReminder.Text = ""
                    txtPaymentReminder.Text = ""
                End If
            End If
            Dim db As New DBDataContext()
            Dim py As New Payment()
            py.paymentID = newPaymentID
            py.discount = discount
            py.paymentAmount = paymentAmount
            py.paymentDate = Convert.ToDateTime((Date.Today.ToString("dd/MM/yyyy")))
            py.paymentTime = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).TimeOfDay
            py.paymentMethod = paymentMethod.ToString
            py.billNo = SelectedId
            py.paymentChange = paymentChange
            If paymentMethod = "Credit Card" Then
                py.creditNo = creditNo
            End If
            If serialNo <> "Service Coupon" Then
                py.serialNo = serialNo
            End If


            Dim bl As Bill = db.Bills.FirstOrDefault(Function(o) o.billNo = SelectedId)
            Dim sc As ServiceCoupon = db.ServiceCoupons.FirstOrDefault(Function(o) o.serialNo = serialNo)

            If paymentResult = "ok" And paymentResult1 = "ok" Then
                bl.status = "Paid"
                db.Payments.InsertOnSubmit(py)
                If serialNo <> "Service Coupon" Then
                    sc.status = "Used"
                End If
                db.SubmitChanges()

                Dim pyServiceCoupon As Payment = db.Payments.FirstOrDefault(Function(o) o.paymentID = newPaymentID)
                pyServiceCoupon.Bill.Customer.serviceCount = pyServiceCoupon.Bill.Customer.serviceCount + 1
                serviceCount = CInt(pyServiceCoupon.Bill.Customer.serviceCount)
                db.SubmitChanges()
                If serviceCount Mod 5 = 0 Then
                    MessageBox.Show("Customer: " & pyServiceCoupon.Bill.Customer.name & " can get a free service coupon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Update Online Order

                'Update Online Order
                MessageBox.Show("Payment Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dlgPreviewReceipt.Document = docReceipt
                dlgPreviewReceipt.ShowDialog(Me)
                ResetForm()
                Me.Close()
                'Else
                '    MessageBox.Show("Payment Failed please make sure data insert correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Payment Failed please make sure data insert correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub docReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docReceipt.PrintPage
        Try
            Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
            Dim fontSubHeader As New Font("Calibri", 14)
            Dim fontBody As New Font("Consolas", 12)

            ' (2) Prepare header and sub-header
            Dim header As String = "     Payment Receipt"
            Dim subHeader As String = String.Format(
                "           Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                "           Prepared by TH CAR WORKSHOP", DateTime.Now
            )

            ' (3) Prepare bodyW
            Dim body As New StringBuilder()


            Dim cnt As Integer = 0

            Dim db As New DBDataContext


            Dim py As Payment = db.Payments.FirstOrDefault(Function(o) o.paymentID = newPaymentID)

            'py.Bill.Customer.serviceCount = py.Bill.Customer.serviceCount + 1
            Dim creditNo As String
            db.SubmitChanges()
            body.AppendLine()
            body.AppendLine()
            body.AppendFormat("Payment No    : {0,0}", py.paymentID)
            body.AppendFormat("                  Bill No      : {0,0}", py.billNo)
            body.AppendLine()
            body.AppendFormat("Payment Time  : {0,0}", py.paymentTime)
            body.AppendFormat("                 Payment Date : {0,0}", py.paymentDate.ToString("dd/MM/yyy"))
            body.AppendLine()
            body.AppendFormat("Payment Method: {0,0}", py.paymentMethod)
            body.AppendLine()
            If py.paymentMethod = "Credit Card" Then
                creditNo = py.creditNo
                Dim lastFour As String = creditNo.Substring(creditNo.Length - 4)
                Dim asterisks As String = "XXXX-XXXX-XXXX-" + lastFour
                body.AppendFormat("Credit Card No: {0,0}", asterisks)
            End If
            body.AppendLine()
            If py.serialNo <> "" Then
                body.AppendFormat("Service Coupon: {0,0}", py.serialNo)
                body.AppendLine()
                body.AppendFormat("Coupon Usage  : {0,0}", py.ServiceCoupon.usage)
                body.AppendLine()
            End If
            body.AppendLine()
            body.AppendFormat("Customer Information:")
            body.AppendLine()
            body.AppendFormat("Name          : {0,0}", py.Bill.Customer.name)
            body.AppendLine()
            body.AppendFormat("IC No         : {0,0}", py.Bill.Customer.customerIC)
            body.AppendLine()
            body.AppendFormat("Contact No    : {0,0}", py.Bill.Customer.contactNo)
            
            body.AppendLine()
            body.AppendLine()
            body.AppendLine("No   Item ID               Name            Qty    Price    Total")
            body.AppendLine("--  ---------  --------------------------  ---   -------  --------")
            Dim rs = From BillingRecord In db.BillingRecords
                    Where BillingRecord.billNo = SelectedId
                     Select BillingRecord.inventoryID, BillingRecord.ItemStorage.stockName, BillingRecord.quantity, BillingRecord.ItemStorage.stockPrice, BillingRecord.billingAmount
            For Each item In rs
                Dim unitPrice As Decimal
                unitPrice = CDec(item.stockPrice)
                cnt += 1


                body.AppendFormat("{0,-2}  {1,-6}  {2,-26}  {3,3}  {4,8}  {5,8} " & vbNewLine, cnt, item.inventoryID, item.stockName, item.quantity.ToString, unitPrice.ToString("0.00"), item.billingAmount)

            Next

            Dim grossSales As Decimal
            Dim gstAmount As Decimal
            Dim totalAmount As Decimal
            Dim discount As Decimal
            Dim paymentChange As Decimal
            Dim paymentAmount As Decimal
            Dim totalAmountUpdate As Decimal

            grossSales = CDec(py.Bill.totalAmount * 0.94)
            gstAmount = CDec(py.Bill.totalAmount * 0.06)
            totalAmount = CDec(py.Bill.totalAmount)
            discount = CDec(py.discount)
            paymentAmount = CDec(py.paymentAmount)
            paymentChange = CDec(py.paymentChange)
            totalAmountUpdate = totalAmount - discount

            body.AppendLine("___________________________________________________________________")
            body.AppendLine()
            body.AppendFormat("                                     Gross Sales       :{0,10}", grossSales.ToString("c2"))
            body.AppendLine()
            body.AppendFormat("                                     GST Tax Amount(+) :{0,10}", gstAmount.ToString("c2"))
            body.AppendLine()
            body.AppendFormat("                                     Net Selling Price :{0,10}", totalAmount.ToString("c2"))
            body.AppendLine()
            body.AppendFormat("                                     Discount(-)       :{0,10}", discount.ToString("c2"))
            body.AppendLine()
            body.AppendFormat("                                     After Discount    :{0,10}", totalAmountUpdate.ToString("c2"))
            body.AppendLine()
            body.AppendLine("___________________________________________________________________")
            body.AppendLine()
            body.AppendFormat("                                     Payment Amount    :{0,10}", paymentAmount.ToString("c2"))
            body.AppendLine()
            body.AppendFormat("                                     Payment Change    :{0,10}", paymentChange.ToString("c2"))
            body.AppendLine()
            body.AppendLine()
            body.AppendLine("                                       Tank You. Please come again")
            body.AppendLine()
            body.AppendLine("                          Keep the receipt for application returns")
            ' (4) Print 
            With e.Graphics
                .DrawImage(My.Resources.logo, 0, 0, 160, 130) ' Print the image with smaller size 80 x 100
                .DrawString(header, fontHeader, Brushes.Purple, 130, 0)
                .DrawString(subHeader, fontSubHeader, Brushes.Black, 140, 60)
                .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
            End With
            BindData()
        Catch ex As Exception

            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
End Class