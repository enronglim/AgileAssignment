Public Class PaymentHistoryRetrieveForm
    Friend selectionSearch As String = "PaymentNo"
    Friend id As String = ""
    Friend paymentID As String = ""
    Private Sub BindData()
        Dim search As String = txtSearch.Text

        Dim db As New DBDataContext
        Dim rs = From py In db.Payments Where py.paymentID.Contains(search) And py.Bill.status = "Paid"
                Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        If selectionSearch = "PaymentNo" Then
            rs = From py In db.Payments Where py.paymentID.Contains(search) And py.Bill.status = "Paid"
                Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        ElseIf selectionSearch.Equals("BillNo") Then
            rs = From py In db.Payments Where py.Bill.billNo.Contains(search) And py.Bill.status = "Paid"
                Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        ElseIf selectionSearch.Equals("CustomerName") Then
            rs = From py In db.Payments Where py.Bill.Customer.name.Contains(search) And py.Bill.status = "Paid"
               Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        ElseIf selectionSearch.Equals("CustomerIC") Then
            rs = From py In db.Payments Where py.Bill.Customer.customerIC.Contains(search) And py.Bill.status = "Paid"
               Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        Else
            rs = From py In db.Payments Where py.paymentID.Contains(search) And py.Bill.status = "Paid"
                Select py.paymentDate, py.paymentID, py.Bill.billNo, py.Bill.Customer.name, py.Bill.Customer.customerIC, py.paymentMethod, py.Bill.totalAmount, py.discount, py.paymentAmount, py.paymentChange
        End If
        dgvPayment.AutoResizeColumns()
        dgvPayment.DataSource = rs
        With dgvPayment
            .Columns(0).HeaderText = "Payment Date"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Payment No"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Bill No"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "Customer Name"
            .Columns(3).Width = 180
            .Columns(4).HeaderText = "I/C No"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Method"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "Bill Amount"
            .Columns(6).Width = 100
            .Columns(6).DefaultCellStyle.Format = "c2"
            .Columns(7).HeaderText = "Discount"
            .Columns(7).Width = 80
            .Columns(7).DefaultCellStyle.Format = "c2"
            .Columns(8).HeaderText = "Payment Receive"
            .Columns(8).Width = 120
            .Columns(8).DefaultCellStyle.Format = "c2"
            .Columns(9).HeaderText = "Payment Change"
            .Columns(9).DefaultCellStyle.Format = "c2"
            .Columns(9).Width = 120
        End With
        dgvPayment.ClearSelection()
        dgvPayment.CurrentCell = Nothing
    End Sub
    Private Sub byPaymentID_Click(sender As Object, e As EventArgs) Handles byPaymentNo.Click
        byPaymentNo.ForeColor = Color.MediumBlue
        byBillNo.ForeColor = Color.Black
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "PaymentNo"
        BindData()
    End Sub

    Private Sub byBillNo_Click(sender As Object, e As EventArgs) Handles byBillNo.Click
        byPaymentNo.ForeColor = Color.Black
        byBillNo.ForeColor = Color.MediumBlue
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "BillNo"
        BindData()
    End Sub

    Private Sub byCustomerName_Click(sender As Object, e As EventArgs) Handles byCustomerName.Click
        byPaymentNo.ForeColor = Color.Black
        byBillNo.ForeColor = Color.Black
        byCustomerName.ForeColor = Color.MediumBlue
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "CustomerName"
        BindData()
    End Sub

    Private Sub byCustomerIC_Click(sender As Object, e As EventArgs) Handles byCustomerIC.Click
        byPaymentNo.ForeColor = Color.Black
        byBillNo.ForeColor = Color.Black
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.MediumBlue
        selectionSearch = "CustomerIC"
        BindData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
    End Sub

    Private Sub PaymentHistoryRetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPayment.RowHeaderMouseClick
        Dim i As Integer = e.RowIndex
        id = CStr(dgvPayment.Rows(i).Cells(2).Value)
        paymentID = CStr(dgvPayment.Rows(i).Cells(1).Value)
    End Sub


    Private Sub btnViewPaymentDetail_Click(sender As Object, e As EventArgs) Handles btnViewPaymentDetail.Click
        Try
            PaymentDetailForm.SelectedId = id
            PaymentDetailForm.ShowDialog()
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvPayment_CellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPayment.RowHeaderMouseDoubleClick
        Try
            Dim i As Integer = e.RowIndex
            id = CStr(dgvPayment.Rows(i).Cells(2).Value)
            paymentID = CStr(dgvPayment.Rows(i).Cells(1).Value)

            PaymentDetailForm.SelectedId = id
            PaymentDetailForm.ShowDialog()
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class