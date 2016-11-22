Public Class CounterSalesManagement

    Dim tempID As String
    Dim tempName As String
    Dim tempPrice As Decimal
    Dim tempBrand As String
    Dim tempCondition As String
    Dim tempQuantity As Integer

    Dim customerName As String
    Dim customerCheckIC As String

    Dim checkSearchName As String
    Dim checkCondition As String
    Dim checkQuantity As Integer

    Dim billID As Integer
    Dim checkID As String

    Dim billRID As String
    Dim billRstockID As String

    Dim tabChange As Integer
    Dim checkButton As Integer = 1
    Dim checkStatus As Integer

    Dim statusRam As String
    Dim customerType As String

    Private Sub CounterSalesManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guestRadio.Checked = True
        billViewRefresh()
        checkCustomerType()
        byName.ForeColor = Color.MediumBlue
    End Sub

    Private Sub checkCustomerType()
        If guestRadio.Checked = True Then
            ic1Txt.Enabled = False
            ic2Txt.Enabled = False
            ic3Txt.Enabled = False

            addCusBtn.Enabled = True
            cusSearchBtn.Enabled = False
            checkAvailabilityPanel.Enabled = True
            customerCheckIC = "111111-11-1111"
            conditionCombo.SelectedIndex = 0

            searchboxFilter()
            If checkID <> "" Then
                deleteBillNRecord()
                custnameTxt.Clear()
                ic1Txt.Clear()
                ic2Txt.Clear()
                ic3Txt.Clear()
                checkAvailabilityPanel.Enabled = False
                productDetailsPanel.Enabled = False
                stockView.Rows.Clear()
                billingRecordView.Rows.Clear()
            End If


        ElseIf userRadio.Checked = True Then
            ic1Txt.Enabled = True
            ic2Txt.Enabled = True
            ic3Txt.Enabled = True

            If checkID <> "" Then
                deleteBillNRecord()
                
            End If
            custnameTxt.Clear()
            ic1Txt.Clear()
            ic2Txt.Clear()
            ic3Txt.Clear()
            warrantyBox.Clear()
            checkAvailabilityPanel.Enabled = False
            productDetailsPanel.Enabled = False
            stockView.Rows.Clear()
            billingRecordView.Rows.Clear()

            addCusBtn.Enabled = False
            cusSearchBtn.Enabled = True
            checkAvailabilityPanel.Enabled = False
            stockView.Rows.Clear()
        End If
    End Sub

    Private Sub billViewRefresh()
        Dim dbRecord As New DBDataContext
        Dim rsCheck = From dbBill In dbRecord.Bills, dbCust In dbRecord.Customers
                      Where dbBill.customerIC = dbCust.customerIC
                      Select dbBill.billNo, dbBill.billDate, dbBill.totalAmount, dbCust.name, dbBill.customerIC, dbBill.status

        billView.DataSource = rsCheck

        billView.Columns(0).HeaderText = "Bill No"
        billView.Columns(1).HeaderText = "Date Of Bill"
        billView.Columns(2).HeaderText = "Sum of Charges"
        billView.Columns(3).HeaderText = "Name"
        billView.Columns(4).HeaderText = "Customer IC"
        billView.Columns(5).HeaderText = "Status of Bill"

        billView.ClearSelection()
        billView.CurrentCell = Nothing


        billView.AutoResizeColumns()
        billView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
        billView.AutoResizeRows()
        billView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub deleteBillNRecord()
        Dim dbUpdate As New DBDataContext
        Dim dbDelete As New DBDataContext

        For Each row As DataGridViewRow In billingRecordView.Rows
            Try
                Dim upDate As BillingRecord = dbUpdate.BillingRecords.FirstOrDefault(Function(o) o.billNo = checkID)
                dbUpdate.BillingRecords.DeleteOnSubmit(Update)
                dbUpdate.SubmitChanges()

            Catch ex As Exception
                MessageBox.Show("There is currently no product in the queue to remove.", "Note")
            End Try

        Next

        Dim deleteBill As Bill = dbDelete.Bills.FirstOrDefault(Function(o) o.billNo = checkID)
        dbDelete.Bills.DeleteOnSubmit(deleteBill)
        dbDelete.SubmitChanges()

        refreshBillRecord()
        checkID = ""
    End Sub

    Public Sub refreshBillRecord()
        Dim dbRecord As New DBDataContext
        Dim rsRecord = From all In dbRecord.BillingRecords
                       Where all.billNo = checkID
                       Select all.billNo, all.inventoryID, all.quantity, all.billingAmount, all.warrantyPeriod

        billingRecordView.DataSource = rsRecord

        billingRecordView.Columns(0).HeaderText = "Bill No"
        billingRecordView.Columns(1).HeaderText = "Inventory ID"
        billingRecordView.Columns(2).HeaderText = "Quantity"
        billingRecordView.Columns(3).HeaderText = "Total Cost"
        billingRecordView.Columns(4).HeaderText = "Warranty Period"

        billingRecordView.ClearSelection()
        billingRecordView.CurrentCell = Nothing

        billingRecordView.AutoResizeColumns()
        billingRecordView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
        billingRecordView.AutoResizeRows()
        billingRecordView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Public Function generateBillID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From billDB In dbCheck.Bills
                      Select billDB.billNo

        For Each item In rsCheck
            billID = Integer.Parse(item.Substring(2, 5))
        Next

        Return (billID + 1).ToString("BL00000")
    End Function

    Private Sub arrangeProductColumn()
        stockView.Columns(0).HeaderText = "Inventory ID"
        stockView.Columns(1).HeaderText = "Name"
        stockView.Columns(2).HeaderText = "Quantity"
        stockView.Columns(3).HeaderText = "Price"
        stockView.Columns(4).HeaderText = "Condition"
        stockView.Columns(5).HeaderText = "Brand"
        stockView.Columns(3).DefaultCellStyle.Format = "c"

        stockView.AutoResizeColumns()
        stockView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
        stockView.AutoResizeRows()
        stockView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub clearStockViewSelection()
        stockView.ClearSelection()
        stockView.CurrentCell = Nothing
    End Sub

    Private Sub clearBillingRecordView()
        billingRecordView.ClearSelection()
        billingRecordView.CurrentCell = Nothing
    End Sub

    Private Sub searchboxFilter()
        Dim searchText As String = productNameTxt.Text

        Dim dbInventory As New DBDataContext

        Try
            If conditionCombo.SelectedItem.ToString = "ID" Then
                Dim rsInventory = From inven In dbInventory.ItemStorages
                                      Where inven.inventoryID.Contains(searchText) And inven.stockStatus = "Available" And inven.stockType = "Local" And inven.stockCategory <> "Labour"
                                      Select inven.inventoryID, inven.stockName, inven.stockQuantity, inven.stockPrice, inven.stockCondition, inven.stockBrand
                stockView.DataSource = rsInventory

                arrangeProductColumn()

                Dim rsCount = From inven In dbInventory.ItemStorages
                                      Where inven.inventoryID.Contains(searchText) And inven.stockQuantity < 20 And inven.stockStatus = "Available" And inven.stockType = "Local" And inven.stockCategory <> "Labour"
                                      Select inven.stockQuantity

                If rsCount.Count() > 0 Then
                    alertLabel.Visible = True
                    alertLabel.Text = "Alert!" + rsCount.Count.ToString + " products are low in quantity."
                Else
                    alertLabel.Visible = False
                End If
            Else
                Dim rsDisposed = From dispo In dbInventory.ItemStorages
                                 Where dispo.stockName.Contains(searchText) And dispo.stockStatus = "Available" And dispo.stockType = "Local" And dispo.stockCategory <> "Labour"
                                 Select dispo.inventoryID, dispo.stockName, dispo.stockQuantity, dispo.stockPrice, dispo.stockCondition, dispo.stockBrand
                stockView.DataSource = rsDisposed

                Dim rsCount = From dispo In dbInventory.ItemStorages
                                 Where dispo.stockName.Contains(searchText) And dispo.stockQuantity < 20 And dispo.stockStatus = "Available" And dispo.stockType = "Local" And dispo.stockCategory <> "Labour"
                                 Select dispo.stockQuantity

                If rsCount.Count > 0 Then
                    alertLabel.Visible = True
                    alertLabel.Text = "Alert! " + rsCount.Count.ToString + " products are low in quantity."
                Else
                    alertLabel.Visible = False
                End If
                arrangeProductColumn()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub checkCustomerIC()
        Dim dbCheck As New DBDataContext

        If ic1Txt.TextLength = 6 And ic2Txt.TextLength = 2 And ic3Txt.TextLength = 4 Then
            customerCheckIC = ic1Txt.Text + "-" + ic2Txt.Text + "-" + ic3Txt.Text
            Try
                Dim rsCheck = From customerDB In dbCheck.Customers
                         Where customerDB.customerIC = customerCheckIC
                         Select customerDB.name
                'MessageBox.Show(customerCheckIC)
                custnameTxt.Text = rsCheck.First.ToString
                searchboxFilter()

                checkAvailabilityPanel.Enabled = True
            Catch ex As Exception
                MessageBox.Show("The customer is not registered in the database", "Alert")
                checkAvailabilityPanel.Enabled = False
            End Try
            conditionCombo.SelectedIndex = 0
        Else
            MessageBox.Show("Please enter the proper IC format, 'xxxxxx-xx-xxxx of the customer'", "Note")
        End If
    End Sub

    Public Sub resetInfo()
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to clear all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            If checkID <> "" Then
                deleteBillNRecord()
            End If
            custnameTxt.Clear()
            ic1Txt.Clear()
            ic2Txt.Clear()
            ic3Txt.Clear()
            checkAvailabilityPanel.Enabled = False
            productDetailsPanel.Enabled = False
            stockView.Rows.Clear()
            billingRecordView.Rows.Clear()
        End If
    End Sub

    Private Sub productDetailsClear()
        'tempName = ""
        'tempBrand = ""
        'tempCondition = ""
        'tempPrice = 0
        'tempQuantity = 0

        detailsbrandTxt.Clear()
        detailsconditionTxt.Clear()
        detailsidTxt.Clear()
        detailsnameTxt.Clear()
        detailspriceTxt.Clear()
        quantityProductNum.Value = 1
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If checkID <> "" Then
            Dim i As Integer
            i = MessageBox.Show("Are you sure you wish to close while undergoing the sales order?", "Warning!", MessageBoxButtons.YesNo)
            If i = 6 Then
                deleteBillNRecord()
                custnameTxt.Clear()
                ic1Txt.Clear()
                ic2Txt.Clear()
                ic3Txt.Clear()
                checkAvailabilityPanel.Enabled = False
                productDetailsPanel.Enabled = False
                stockView.Rows.Clear()
                billingRecordView.Rows.Clear()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cusSearchBtn_Click(sender As Object, e As EventArgs) Handles cusSearchBtn.Click
        checkCustomerIC()
    End Sub

    Private Sub cusClearBtn_Click(sender As Object, e As EventArgs) Handles cusClearBtn.Click
        resetInfo()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim newBillEntry As New Bill
        Dim newRecordEntry As New BillingRecord

        If checkID = "" Then
            Try
                checkID = generateBillID()
                newBillEntry.billNo = checkID
                newBillEntry.billDate = CDate(Today.ToString("dd/MM/yyyy"))
                newBillEntry.totalAmount = 0
                newBillEntry.customerIC = customerCheckIC
                newBillEntry.status = "unpaid"

                Dim dbSubmit As New DBDataContext
                dbSubmit.Bills.InsertOnSubmit(newBillEntry)
                dbSubmit.SubmitChanges()

                MessageBox.Show("The new record has been created", "Record Stored", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
        End If

        If checkID <> "" And tempID <> "" And tempQuantity >= CInt(quantityProductNum.Value) Then
            Dim checkDuplicate As Integer = 0
            For Each row As DataGridViewRow In billingRecordView.Rows
                If (row.Cells(1).Value.ToString = tempID) Then
                    MessageBox.Show("Selected Item is already included in the billing list.", "Info")
                    checkDuplicate = 1
                End If
            Next

            If checkDuplicate = 0 Then
                newRecordEntry.billNo = checkID
                newRecordEntry.inventoryID = tempID
                newRecordEntry.quantity = CInt(quantityProductNum.Value)
                newRecordEntry.billingAmount = tempPrice * CInt(quantityProductNum.Value)
                If warrantyBox.Text.Trim <> "" Then
                    newRecordEntry.warrantyPeriod = warrantyBox.Text
                Else
                    newRecordEntry.warrantyPeriod = "None"
                End If

                Dim dbSubmitRecord As New DBDataContext
                dbSubmitRecord.BillingRecords.InsertOnSubmit(newRecordEntry)
                dbSubmitRecord.SubmitChanges()

                refreshBillRecord()
                productDetailsClear()
            End If
        Else
            MessageBox.Show("Select another product and ensure that quantity does not exceed existing amount.", "Note")
        End If

    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click

        Dim dbUpdate As New DBDataContext

        Try
            Dim countDrows As Integer = billingRecordView.RowCount - 1
            Dim upDate As BillingRecord = dbUpdate.BillingRecords.FirstOrDefault(Function(o) o.billNo = billingRecordView.Rows(countDrows).Cells(0).Value.ToString And o.inventoryID = billingRecordView.Rows(countDrows).Cells(1).Value.ToString)

            dbUpdate.BillingRecords.DeleteOnSubmit(upDate)
            dbUpdate.SubmitChanges()

            refreshBillRecord()

            If billingRecordView.Rows.Count = 0 Then
                tempID = ""
            End If
        Catch ex As Exception
            MessageBox.Show("There is currently no product in the queue to remove.", "Note")
        End Try

    End Sub

    Private Sub finaliseBtn_Click(sender As Object, e As EventArgs) Handles finaliseBtn.Click
        If checkID = "" Then
            MessageBox.Show("Please add at least 1 product before proceeding", "Info")
        Else
            If tempID = "" Then
                MessageBox.Show("Please add at least 1 product before proceeding", "Info")
            Else
                Dim sumPrice As Decimal
                For Each row As DataGridViewRow In billingRecordView.Rows
                    sumPrice += CDec(row.Cells(3).Value)

                    Dim dbUpdateStock As New DBDataContext
                    Dim upStock As ItemStorage = dbUpdateStock.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = row.Cells(1).Value.ToString)

                    upStock.stockQuantity -= CInt(row.Cells(2).Value)
                    dbUpdateStock.SubmitChanges()
                Next
                Dim dbUpdate As New DBDataContext
                Dim upDate As Bill = dbUpdate.Bills.FirstOrDefault(Function(o) o.billNo = checkID)

                upDate.totalAmount = sumPrice
                dbUpdate.SubmitChanges()

                Dim dbRecord As New DBDataContext
                Dim rsCheck = From dbBill In dbRecord.Bills, dbCust In dbRecord.Customers
                              Where dbBill.billNo = checkID And dbCust.customerIC = customerCheckIC
                              Select dbBill.billNo, dbBill.billDate, dbBill.totalAmount, dbCust.name, dbBill.customerIC, dbBill.status

                billView.DataSource = rsCheck

                TabControl1.SelectedTab = TabPage2

                custnameTxt.Clear()
                ic1Txt.Clear()
                ic2Txt.Clear()
                ic3Txt.Clear()
                checkAvailabilityPanel.Enabled = False
                productDetailsPanel.Enabled = False
                stockView.Rows.Clear()
                billingRecordView.Rows.Clear()

                productDetailsClear()
                checkID = ""

                userRadio.Select()
                guestRadio.Select()
            End If
        End If
    End Sub

    Private Sub productNameTxt_TextChanged(sender As Object, e As EventArgs) Handles productNameTxt.TextChanged
        searchboxFilter()
    End Sub

    Private Sub conditionCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles conditionCombo.SelectedIndexChanged
        searchboxFilter()
    End Sub

    Private Sub quantitySearchNum_ValueChanged(sender As Object, e As EventArgs)
        searchboxFilter()
    End Sub

    Private Sub stockView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles stockView.CellClick
        tempID = stockView.CurrentRow.Cells(0).Value.ToString
        tempName = stockView.CurrentRow.Cells(1).Value.ToString  'As Integer
        tempQuantity = CInt(stockView.CurrentRow.Cells(2).Value) 'As String
        tempPrice = CDec(stockView.CurrentRow.Cells(3).Value) 'As String
        tempCondition = stockView.CurrentRow.Cells(4).Value.ToString 'String
        tempBrand = stockView.CurrentRow.Cells(5).Value.ToString  'As String

        detailsidTxt.Text = tempID
        detailsnameTxt.Text = tempName
        detailspriceTxt.Text = tempPrice.ToString("c")
        detailsconditionTxt.Text = tempCondition
        detailsbrandTxt.Text = tempBrand

        productDetailsPanel.Enabled = True
        stockView.CurrentRow.Selected = True
        warrantyBox.ReadOnly = False
        warrantyBox.Clear()

        quantityProductNum.Value = 1
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addCusBtn_Click(sender As Object, e As EventArgs) Handles addCusBtn.Click
        CustomerInsertForm.ShowDialog()
    End Sub

    Private Sub searchBillBoxFilter()
        Dim searchText As String = searchBox.Text

        Dim dbBill As New DBDataContext
        If checkButton = 1 Then
            If checkStatus = 1 Then
                statusRam = "paid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where also.name.Contains(searchText) And all.customerIC = also.customerIC And all.status = statusRam
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                billView.DataSource = rsBill
            ElseIf checkStatus = 2 Then
                statusRam = "unpaid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where also.name.Contains(searchText) And all.customerIC = also.customerIC And all.status = statusRam
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                billView.DataSource = rsBill
            Else
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where also.name.Contains(searchText) And all.customerIC = also.customerIC
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                billView.DataSource = rsBill
            End If

        ElseIf checkButton = 2 Then
            If checkStatus = 1 Then
                statusRam = "paid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.billNo.Contains(searchText) And all.customerIC = also.customerIC And all.status = statusRam
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            ElseIf checkStatus = 2 Then
                statusRam = "unpaid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.billNo.Contains(searchText) And all.customerIC = also.customerIC And all.status = statusRam
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            Else
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.billNo.Contains(searchText) And all.customerIC = also.customerIC
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            End If


        ElseIf checkButton = 3 Then
            If checkStatus = 1 Then
                statusRam = "paid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                        Where all.billDate <= (CDate(searchText)) And all.customerIC = also.customerIC And all.status = statusRam
                        Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            ElseIf checkStatus = 2 Then
                statusRam = "unpaid"
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.billDate <= (CDate(searchText)) And all.customerIC = also.customerIC And all.status = statusRam
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status
                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            Else
                Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.billDate <= (CDate(searchText)) And all.customerIC = also.customerIC
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status

                Try
                    billView.DataSource = rsBill
                Catch ex As Exception

                End Try
            End If

        ElseIf checkButton = 4 Then
            Dim rsBill = From all In dbBill.Bills, also In dbBill.Customers
                         Where all.status.Contains(searchText) And all.customerIC = also.customerIC
                         Select all.billNo, all.billDate, all.totalAmount, also.name, all.customerIC, all.status

            billView.DataSource = rsBill
        End If
    End Sub

    Private Sub byName_Click(sender As Object, e As EventArgs) Handles byName.Click
        byName.ForeColor = System.Drawing.Color.MediumBlue
        byBillNo.ForeColor = Color.Black
        byDate.ForeColor = Color.Black

        checkButton = 1

        searchBillBoxFilter()
    End Sub

    Private Sub byBillNo_Click(sender As Object, e As EventArgs) Handles byBillNo.Click
        byName.ForeColor = Color.Black
        byBillNo.ForeColor = System.Drawing.Color.MediumBlue
        byDate.ForeColor = Color.Black

        checkButton = 2

        searchBillBoxFilter()
    End Sub

    Private Sub byDate_Click(sender As Object, e As EventArgs) Handles byDate.Click
        byName.ForeColor = Color.Black
        byBillNo.ForeColor = Color.Black
        byDate.ForeColor = System.Drawing.Color.MediumBlue

        checkButton = 3

        searchBillBoxFilter()
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchBillBoxFilter()
    End Sub

    Private Sub paidBtn_Click(sender As Object, e As EventArgs) Handles paidBtn.Click
        If paidBtn.ForeColor = Color.Black Then
            paidBtn.ForeColor = Color.MediumPurple
            unpaidBtn.ForeColor = Color.Black
            checkStatus = 1
            searchBillBoxFilter()
        Else
            paidBtn.ForeColor = Color.Black
            checkStatus = 0
            searchBillBoxFilter()
        End If

    End Sub

    Private Sub unpaidBtn_Click(sender As Object, e As EventArgs) Handles unpaidBtn.Click
        If unpaidBtn.ForeColor = Color.Black Then
            unpaidBtn.ForeColor = Color.MediumPurple
            paidBtn.ForeColor = Color.Black
            checkStatus = 2
            searchBillBoxFilter()
        Else
            unpaidBtn.ForeColor = Color.Black
            checkStatus = 0
            searchBillBoxFilter()
        End If
    End Sub

    Private Sub btnCloseBill_Click(sender As Object, e As EventArgs) Handles btnCloseBill.Click
        If checkID <> "" Then
            Dim i As Integer
            i = MessageBox.Show("Are you sure you wish to close while undergoing the sales order?", "Warning!", MessageBoxButtons.YesNo)
            If i = 6 Then
                deleteBillNRecord()
                custnameTxt.Clear()
                ic1Txt.Clear()
                ic2Txt.Clear()
                ic3Txt.Clear()
                checkAvailabilityPanel.Enabled = False
                productDetailsPanel.Enabled = False
                stockView.Rows.Clear()
                billingRecordView.Rows.Clear()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub userRadio_CheckedChanged(sender As Object, e As EventArgs) Handles userRadio.CheckedChanged
        checkCustomerType()
    End Sub

    Private Sub guestRadio_CheckedChanged(sender As Object, e As EventArgs) Handles guestRadio.CheckedChanged
        checkCustomerType()
    End Sub

    Private Sub billView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles billView.CellContentDoubleClick
        Dim checkBillNo As String

        If billView.CurrentRow.Cells(5).Value.ToString = "unpaid" Then
            checkBillNo = billView.CurrentRow.Cells(0).Value.ToString()

            'PaymentInsertForm.SelectedId = checkBillNo
            'PaymentInsertForm.ShowDialog()

            Dim dbBill As New DBDataContext
            'Dim rsCheck = dbBill.Bills.FirstOrDefault(Function(o) o.billNo = billView.CurrentRow.Cells(0).Value.ToString())
            Dim rsCheck = From check In dbBill.Bills
                          Where check.billNo = checkBillNo
                          Select check.billNo, check.billDate, check.totalAmount, check.Customer.name, check.customerIC, check.status

            If rsCheck.FirstOrDefault.status = "Paid" Or rsCheck.FirstOrDefault.status = "paid" Then
                billView.DataSource = rsCheck
            End If
        End If
    End Sub
End Class