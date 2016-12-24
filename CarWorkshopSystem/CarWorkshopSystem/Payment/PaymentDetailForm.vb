Imports System.Text

Public Class PaymentDetailForm
    Friend Shared selection As Integer = 0
    Friend inventoryId As String = ""
    Public Shared SelectedId As String
    Dim grossSales As Decimal
    Dim gstAmount As Decimal
    Private Sub BindData()

        Dim db As New DBDataContext
        Dim rs = From br In db.BillingRecords Where br.billNo = SelectedId
                Select br.inventoryID, br.ItemStorage.stockBrand, br.ItemStorage.stockName, br.ItemStorage.stockPrice, br.quantity, br.billingAmount, br.warrantyPeriod

        Dim py As Payment = db.Payments.FirstOrDefault(Function(o) o.Bill.billNo = SelectedId And o.paymentID = PaymentHistoryRetrieveForm.paymentID)
        grossSales = CDec(py.Bill.totalAmount * 0.94)
        gstAmount = CDec(py.Bill.totalAmount * 0.06)
        Dim totalAmountUpdate As Decimal
        totalAmountUpdate = CDec(py.Bill.totalAmount - py.discount)
        dgvBillingRecordPaymentDetail.AutoResizeColumns()
        dgvBillingRecordPaymentDetail.DataSource = rs
        With dgvBillingRecordPaymentDetail
            .Columns(0).HeaderText = "Inventory ID"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Brand"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 220
            .Columns(3).HeaderText = "Unit Price Inc(GST)"
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(3).Width = 140
            .Columns(4).HeaderText = "Quantity"
            .Columns(4).Width = 80
            .Columns(5).HeaderText = "Amount"
            .Columns(5).Width = 80
            .Columns(5).DefaultCellStyle.Format = "c2"
            .Columns(6).HeaderText = "Warranty Period"
            .Columns(6).Width = 150
        End With
        txtPaymentID.Text = py.paymentID.ToString
        txtPaymentDate.Text = py.paymentDate.ToString("dd/MM/yyy")
        txtCustomerName.Text = py.Bill.Customer.name.ToString
        mskCustomerIc.Text = py.Bill.Customer.customerIC.ToString
        txtPaymentTime.Text = CStr(py.paymentTime.ToString)
        txtGrossSales.Text = grossSales.ToString("c2")
        txtGstTaxAmount.Text = gstAmount.ToString("c2")
        txtDiscount.Text = Format(py.discount, "c2")
        txtNetSellAfterDiscount.Text = Format(totalAmountUpdate, "c2")
        txtMethod.Text = py.paymentMethod.ToString
        txtPaymentAmount.Text = py.paymentAmount.ToString("c2")
        mskChange.Text = py.paymentChange.ToString("c2")
        txtNetSell.Text = Format(py.Bill.totalAmount, "c2")
        If py.serialNo <> "" Then
            txtServiceCouponNo.Visible = True
            txtServiceCouponNo.Text = py.serialNo
            lblUsage.Text = py.ServiceCoupon.usage
        Else
            txtServiceCouponNo.Visible = False
            lblUsage.Text = ""
        End If


        dgvBillingRecordPaymentDetail.ClearSelection()
        dgvBillingRecordPaymentDetail.CurrentCell = Nothing
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If selection = 1 Then
            Me.Close()
            PaymentHistoryRetrieveForm.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub PaymentDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub


    Private Sub BtnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles BtnGenerateReceipt.Click
        dlgPreviewReceipt.Document = docReceipt
        dlgPreviewReceipt.ShowDialog(Me)
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


            Dim py As Payment = db.Payments.FirstOrDefault(Function(o) o.paymentID = PaymentHistoryRetrieveForm.paymentID)

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
                creditNo = py.creditNo
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
                .DrawString(header, fontHeader, Brushes.Purple, 145, 0)
                .DrawString(subHeader, fontSubHeader, Brushes.Black, 140, 60)
                .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
            End With
            BindData()
        Catch ex As Exception

            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvBillingRecordPaymentDetail_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBillingRecordPaymentDetail.RowHeaderMouseDoubleClick
        Dim i As Integer = e.RowIndex

        inventoryId = CStr(dgvBillingRecordPaymentDetail.Rows(i).Cells(0).Value)
        Dim db As New DBDataContext()
        Dim br As BillingRecord = db.BillingRecords.FirstOrDefault(Function(o) o.billNo = SelectedId And o.inventoryID = inventoryId)
        Dim py As Payment = db.Payments.FirstOrDefault(Function(o) o.billNo = SelectedId)
    
        selection = 0
    End Sub

    Private Sub dlgPreviewReceipt_Load(sender As Object, e As EventArgs) Handles dlgPreviewReceipt.Load

    End Sub
End Class