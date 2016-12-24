Public Class PaymentRetrieveForm

    Friend selectionSearch As String = "BillNo"
    Friend id As String = ""


    Private Sub BindData()
        Dim search As String = txtSearch.Text

        Dim db As New DBDataContext
        Dim rs = From bl In db.Bills Where bl.billNo.Contains(search) And bl.status = "Unpaid" And bl.totalAmount <> CDec("0")
                Select bl.billNo, bl.Customer.name, bl.Customer.customerIC, bl.totalAmount, bl.billDate, bl.status
        If selectionSearch = "BillNo" Then
            rs = From bl In db.Bills Where bl.billNo.Contains(search) And bl.status = "Unpaid" And bl.totalAmount <> CDec("0")
            Select bl.billNo, bl.Customer.name, bl.Customer.customerIC, bl.totalAmount, bl.billDate, bl.status
        ElseIf selectionSearch.Equals("CustomerName") Then
            rs = From bl In db.Bills Where bl.Customer.name.Contains(search) And bl.status = "Unpaid" And bl.totalAmount <> CDec("0")
                 Select bl.billNo, bl.Customer.name, bl.Customer.customerIC, bl.totalAmount, bl.billDate, bl.status
        ElseIf selectionSearch.Equals("CustomerIC") Then
            rs = From bl In db.Bills Where bl.Customer.customerIC.Contains(search) And bl.status = "Unpaid" And bl.totalAmount <> CDec("0")
                 Select bl.billNo, bl.Customer.name, bl.Customer.customerIC, bl.totalAmount, bl.billDate, bl.status

        Else
            rs = From bl In db.Bills Where bl.billNo.Contains(search) And bl.status = "Unpaid" And bl.totalAmount <> CDec("0")
                 Select bl.billNo, bl.Customer.name, bl.Customer.customerIC, bl.totalAmount, bl.billDate, bl.status
        End If
        dgvBill.AutoResizeColumns()
        dgvBill.DataSource = rs
        With dgvBill
            .Columns(0).HeaderText = "Bill No"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Customer Name"
            .Columns(1).Width = 180
            .Columns(2).HeaderText = "I/C No"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Total Amount"
            .Columns(3).Width = 150
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(4).HeaderText = "Bill Date"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "Status"
            .Columns(5).Width = 150

        End With
        dgvBill.ClearSelection()
        dgvBill.CurrentCell = Nothing
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PaymentRetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub byBillNo_Click(sender As Object, e As EventArgs) Handles byBillNo.Click
        byBillNo.ForeColor = Color.MediumBlue
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "BillNo"
        BindData()
    End Sub

    Private Sub byCustomerName_Click(sender As Object, e As EventArgs) Handles byCustomerName.Click
        byBillNo.ForeColor = Color.Black
        byCustomerName.ForeColor = Color.MediumBlue
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "CustomerName"
        BindData()
    End Sub

    Private Sub byCustomerIC_Click(sender As Object, e As EventArgs) Handles byCustomerIC.Click
        byBillNo.ForeColor = Color.Black
        byCustomerName.ForeColor = Color.MediumBlue
        byCustomerIC.ForeColor = Color.Black
        selectionSearch = "CustomerIC"
        BindData()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBill.RowHeaderMouseClick
        Dim i As Integer = e.RowIndex

        id = CStr(dgvBill.Rows(i).Cells(0).Value)
    End Sub




    Private Sub btnViewPayment_Click(sender As Object, e As EventArgs) Handles btnViewPayment.Click
        PaymentHistoryRetrieveForm.Show()
    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
        Try
            PaymentInsertForm.SelectedId = id
            PaymentInsertForm.ShowDialog()
            BindData()
            id = ""
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class