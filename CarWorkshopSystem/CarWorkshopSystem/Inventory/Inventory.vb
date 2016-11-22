Imports System.Net.Mail
Public Class Inventory
    Friend tempID As String
    Friend tempName As String
    Friend tempQuantity As Integer
    Friend tempBatchNo As String
    Friend tempCategory As String
    Friend tempAD As Date
    Friend tempCondition As String
    Friend tempBrand As String
    Friend tempDescription As String
    Friend tempSpecification As String
    Friend tempStatus As String
    Friend tempType As String
    Friend tempSupplier As String
    Friend tempPrice As Double
    Friend tempImage As String
    Friend tempPath As String

    Friend tempSupID As String
    Friend tempSupName As String
    Friend tempSupContact As String
    Friend tempSupAddress As String

    Dim checkButton As Integer
    Dim newID As Integer

    Dim ramID As String
    Dim ramSupID As String
    'enrong data
    Friend Shared selection As Integer = 0

    Public Function generateNewID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From usedDB In dbCheck.UsedItems
                      Select usedDB.dStockID

        For Each item In rsCheck
            newID = Integer.Parse(item.Substring(2, 7))
        Next

        Return (newID + 1).ToString("DS0000000")
    End Function

    Public Function generateBinID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From binDB In dbCheck.Bins
                      Select binDB.binID

        For Each item In rsCheck
            newID = Integer.Parse(item.Substring(2, 5))
        Next

        Return (newID + 1).ToString("BN00000")
    End Function

    Private Sub changeEmptyQuantity()
        Dim dbUpdate As New DBDataContext
        Dim countChanges As Integer

        For Each row As DataGridViewRow In stockView.Rows
            If row.Cells(10).Value.ToString = "Available" And CInt(row.Cells(2).Value.ToString) = 0 And row.Cells(11).Value.ToString = "Local" Then
                Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = row.Cells(0).Value.ToString)
                upDate.stockStatus = "Disabled"
                dbUpdate.SubmitChanges()
                'countChanges += 1
            ElseIf row.Cells(10).Value.ToString = "Disabled" And CInt(row.Cells(2).Value.ToString) > 0 And row.Cells(11).Value.ToString = "Local" Then
                Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = row.Cells(0).Value.ToString)
                upDate.stockStatus = "Available"
                dbUpdate.SubmitChanges()
            End If
        Next
        If countChanges > 0 Then
            'MessageBox.Show("The number of stock that had their status changed is, " + countChanges.ToString, "Notice")
        End If
    End Sub

    Private Sub refreshViewer()
        Try
            Dim dbCheck As New DBDataContext
            Dim rsCheck = From inventoryDB In dbCheck.ItemStorages
                          Where ((inventoryDB.stockQuantity <> 0 And inventoryDB.stockType = "Local") Or inventoryDB.stockStatus = "Available") Or inventoryDB.stockType = "Pre-Order"
                          Select inventoryDB

            stockView.DataSource = rsCheck

            stockView.Columns(0).HeaderText = "Inventory ID"
            stockView.Columns(1).HeaderText = "Name"
            stockView.Columns(2).HeaderText = "Quantity"
            stockView.Columns(3).HeaderText = "Batch No"
            stockView.Columns(4).HeaderText = "Category"
            stockView.Columns(5).HeaderText = "Arrival Date"
            stockView.Columns(6).HeaderText = "Condition"
            stockView.Columns(7).HeaderText = "Brand"
            stockView.Columns(8).HeaderText = "Description"
            stockView.Columns(9).HeaderText = "Specification"
            stockView.Columns(10).HeaderText = "Status"
            stockView.Columns(11).HeaderText = "Type"
            stockView.Columns(12).HeaderText = "Supplier"
            stockView.Columns(13).HeaderText = "Price"
            stockView.Columns(13).DefaultCellStyle.Format = "c"
            stockView.Columns(14).Visible = False
            stockView.Columns(15).Visible = False

            stockView.ClearSelection()
            stockView.CurrentCell = Nothing

            stockView.AutoResizeColumns()
            stockView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
            stockView.AutoResizeRows()
            stockView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As Exception
            'MessageBox.Show("Error detected while connecting to the database. Contact your local system Administrator", "Error")
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub refreshSupplierView()
        Try
            Dim dbCheck As New DBDataContext
            Dim rsCheck = From supplierDB In dbCheck.Suppliers
                          Select supplierDB

            supplierView.DataSource = rsCheck

            supplierView.Columns(0).HeaderText = "Supplier ID"
            supplierView.Columns(1).HeaderText = "Name"
            supplierView.Columns(2).HeaderText = "Contact"
            supplierView.Columns(3).HeaderText = "Address"

            supplierView.ClearSelection()
            supplierView.CurrentCell = Nothing

            supplierView.AutoResizeColumns()
            supplierView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
            supplierView.AutoResizeRows()
            supplierView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As Exception
            MessageBox.Show("Error detected while connecting to the database. Contact your local system Administrator", "Error")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub searchboxFilter()
        Dim searchText As String = searchBox.Text

        Dim dbInventory As New DBDataContext
        If checkButton = 1 Then
            Dim rsInventory = From all In dbInventory.ItemStorages
                             Where all.stockName.Contains(searchText)

            stockView.DataSource = rsInventory

        ElseIf checkButton = 2 Then
            Dim rsInventory = From all In dbInventory.ItemStorages
                             Where all.stockArrivalDate <= (CDate(searchText))

            Try
                stockView.DataSource = rsInventory
            Catch ex As Exception

            End Try


        ElseIf checkButton = 3 Then
            Dim rsInventory = From all In dbInventory.ItemStorages
                             Where all.stockQuantity <= (CInt(searchText))

            Try
                stockView.DataSource = rsInventory
            Catch ex As Exception

            End Try

        ElseIf checkButton = 4 Then
            Dim rsInventory = From all In dbInventory.ItemStorages
                             Where all.stockCategory.Contains(searchText)

            stockView.DataSource = rsInventory
        End If
    End Sub

    Public Sub countLowQuantity()
        Dim dbCheck As New DBDataContext
        Dim rsCheck = From inventoryDB In dbCheck.ItemStorages
                      Select inventoryDB Where inventoryDB.stockQuantity < 20 And inventoryDB.stockStatus <> "Disabled" And inventoryDB.stockType = "Local"

        For index As Integer = 0 To rsCheck.Count
            If index >= 1 Then
                alertLabel.ForeColor = Color.Red
                alertLabel.Text = index.ToString + " stocks are low"
                'alertLabel.Visible = True
            Else
                alertLabel.ForeColor = Color.Black
                alertLabel.Text = "0 stocks are low"
            End If
        Next

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshViewer()
        'changeEmptyQuantity()
        refreshViewer()
        refreshSupplierView()
        byName.ForeColor = System.Drawing.Color.MediumBlue
        bySupplierName.ForeColor = System.Drawing.Color.MediumBlue
        checkButton = 1
        searchboxFilter()
        countLowQuantity()
    End Sub

    Private Sub Inventory_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tempID = ""
        tempSupID = ""
        refreshViewer()
        refreshSupplierView()
        countLowQuantity()
        'changeEmptyQuantity()
        refreshViewer()
        countLowQuantity()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addInventory.ShowDialog()
    End Sub

    Private Sub byDate_Click_1(sender As Object, e As EventArgs) Handles byDate.Click
        byName.ForeColor = Color.Black
        byDate.ForeColor = System.Drawing.Color.MediumBlue
        byCategory.ForeColor = Color.Black
        byQuantity.ForeColor = Color.Black

        checkButton = 2

        searchboxFilter()
    End Sub

    Private Sub byQuantity_Click_1(sender As Object, e As EventArgs) Handles byQuantity.Click
        byName.ForeColor = Color.Black
        byDate.ForeColor = Color.Black
        byCategory.ForeColor = Color.Black
        byQuantity.ForeColor = System.Drawing.Color.MediumBlue

        checkButton = 3

        searchboxFilter()
    End Sub

    Private Sub byCategory_Click(sender As Object, e As EventArgs) Handles byCategory.Click
        byName.ForeColor = Color.Black
        byDate.ForeColor = Color.Black
        byCategory.ForeColor = System.Drawing.Color.MediumBlue
        byQuantity.ForeColor = Color.Black

        checkButton = 4

        searchboxFilter()
    End Sub

    Private Sub byName_Click_1(sender As Object, e As EventArgs) Handles byName.Click
        byName.ForeColor = System.Drawing.Color.MediumBlue
        byDate.ForeColor = Color.Black
        byCategory.ForeColor = Color.Black
        byQuantity.ForeColor = Color.Black

        checkButton = 1

        searchboxFilter()
    End Sub

    Private Sub transferBtn_Click(sender As Object, e As EventArgs) Handles transferBtn.Click
        'select the record from the datagrid, then request whether the user wishes to transfer the data to the defect section or bin section or to cancel altogether
        If tempID <> "" And tempCondition = "Good" Then
            MessageBox.Show("The selected item, " + tempName + " is not in poor condition.")
        ElseIf tempID <> "" And tempCondition = "Poor" Then
            If tempType = "Pre-Order" And tempQuantity = 0 Then
                MessageBox.Show("The selected pre-order product has 0 quantity to transfer.")
            Else
                ramID = tempID
                TransferMessage.ShowDialog()
                If TransferMessage.selectionI = 1 Then
                    If TransferDisposable.disposalQuantity <> 0 Then 'Checks if user confirmed transfer to disposable stock
                        Dim newEntry As New UsedItem
                        Try
                            newEntry.dStockID = generateNewID()
                            newEntry.dStockName = tempName
                            newEntry.dStockQuantity = TransferDisposable.disposalQuantity
                            newEntry.dStockBatchNo = tempBatchNo
                            newEntry.dStockCategory = tempCategory
                            newEntry.dStockArrivalDate = tempAD
                            newEntry.dStockCondition = tempCondition
                            newEntry.dStockBrand = tempBrand
                            newEntry.dStockDescription = TransferDisposable.disposalDescription
                            newEntry.dStockSpecification = tempSpecification
                            newEntry.dStatus = tempStatus
                            newEntry.dSupplier = tempSupplier
                            newEntry.dPrice = TransferDisposable.disposalPrice
                            newEntry.dType = TransferDisposable.disposalType

                            If TransferDisposable.disposalQuantity = tempQuantity Then 'Delete record

                                Dim dbUpdate As New DBDataContext

                                Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = ramID)

                                dbUpdate.ItemStorages.DeleteOnSubmit(upDate)
                                dbUpdate.SubmitChanges()

                                dbUpdate.SubmitChanges()
                            Else 'Does not delete Record
                                Dim dbUpdate As New DBDataContext
                                Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = ramID)

                                upDate.stockQuantity = tempQuantity - TransferDisposable.disposalQuantity

                                dbUpdate.SubmitChanges()
                            End If

                            Dim dbTransfer As New DBDataContext
                            dbTransfer.UsedItems.InsertOnSubmit(newEntry)
                            dbTransfer.SubmitChanges()

                            refreshViewer()
                            countLowQuantity()
                        Catch ex As Exception
                            Dim dbUpdate As New DBDataContext

                            Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = ramID)

                            If upDate.stockType = "Pre-Order" Then
                                upDate.stockQuantity = 0
                                'upDate.stockStatus = "Disabled"
                                'MessageBox.Show("The current stock, " + tempName + " is a pre-ordered item and cannot be deleted from the database." + vbNewLine +
                                '              "Quantity has instead been set to 0 and status is changed to Disabled'.", "Alert!")
                                dbUpdate.SubmitChanges()
                            ElseIf upDate.stockType = "Local" Then
                                upDate.stockQuantity = 0
                                upDate.stockStatus = "Disabled"
                                dbUpdate.SubmitChanges()
                                MessageBox.Show("The stock, " + upDate.inventoryID + " has reached 0 quantity and is therefore disabled.")
                            End If
                        End Try
                    End If

                ElseIf TransferMessage.selectionI = 2 Then
                    If DisposalReason.reasonDisposal <> "" And DisposalReason.disposalQuantity <> 0 Or tempQuantity = 0 Then
                        Dim newEntry As New Bin
                        Try
                            newEntry.binID = generateBinID()
                            newEntry.dStockID = ramID
                            newEntry.dStockName = tempName
                            newEntry.dStockQuantity = tempQuantity
                            newEntry.dStockBinDate = Today
                            newEntry.dStockStatus = "Present"
                            newEntry.binDisposalReason = DisposalReason.reasonDisposal

                            DisposalReason.reasonDisposal = ""

                            Dim dbBin As New DBDataContext
                            dbBin.Bins.InsertOnSubmit(newEntry)
                            dbBin.SubmitChanges()

                            'Delete the record from Item Storage

                            Dim dbUpdate As New DBDataContext

                            Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = ramID)

                            dbUpdate.ItemStorages.DeleteOnSubmit(upDate)

                            dbUpdate.SubmitChanges()

                            refreshViewer()
                            countLowQuantity()
                        Catch ex As Exception
                            Dim dbUpdate As New DBDataContext

                            Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = ramID)

                            If upDate.stockType = "Pre-Order" Then
                                upDate.stockQuantity = 0
                                'upDate.stockStatus = "Disabled"
                                'MessageBox.Show("The current stock, " + tempName + " is a pre-ordered item and cannot be deleted from the database." + vbNewLine +
                                '"Quantity has instead been set to 0 and status is changed to Disabled'.", "Alert!")
                                dbUpdate.SubmitChanges()
                            ElseIf upDate.stockType = "Local" Then
                                upDate.stockQuantity = 0
                                upDate.stockStatus = "Disabled"
                                dbUpdate.SubmitChanges()
                                MessageBox.Show("The stock, " + upDate.inventoryID + " has reached 0 quantity and is therefore disabled.")
                            End If
                        End Try
                    Else
                        MessageBox.Show(tempName + " was not send to the Bin.", "Note")
                    End If
                Else
                    MessageBox.Show("Record was not transferred", "Cancelled")
                End If
            End If     
        Else
            MessageBox.Show("Please select a record", "Alert")
        End If
        countLowQuantity()
    End Sub

    Private Sub stockView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockView.CellClick
        tempID = stockView.CurrentRow.Cells(0).Value.ToString
        tempName = stockView.CurrentRow.Cells(1).Value.ToString  'As Integer
        tempQuantity = CInt(stockView.CurrentRow.Cells(2).Value) 'As String
        tempBatchNo = stockView.CurrentRow.Cells(3).Value.ToString 'As String
        tempCategory = stockView.CurrentRow.Cells(4).Value.ToString 'String
        tempAD = CDate(stockView.CurrentRow.Cells(5).Value) 'As String
        tempCondition = stockView.CurrentRow.Cells(6).Value.ToString 'As Date
        tempBrand = stockView.CurrentRow.Cells(7).Value.ToString
        tempDescription = stockView.CurrentRow.Cells(8).Value.ToString 'As String
        tempSpecification = stockView.CurrentRow.Cells(9).Value.ToString 'String
        tempStatus = stockView.CurrentRow.Cells(10).Value.ToString 'As String
        tempType = stockView.CurrentRow.Cells(11).Value.ToString
        tempSupplier = stockView.CurrentRow.Cells(12).Value.ToString 'As Date
        tempPrice = CDbl(stockView.CurrentRow.Cells(13).Value) 'As String
        Try
            tempImage = stockView.CurrentRow.Cells(14).Value.ToString
            tempPath = stockView.CurrentRow.Cells(15).Value.ToString
        Catch ex As Exception

        End Try


    End Sub
    Private Sub stockView_CellContentClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles stockView.RowHeaderMouseDoubleClick
        Dim i As Integer = e.RowIndex

        Dim id = CStr(stockView.Rows(i).Cells(0).Value)
        Dim db As New DBDataContext()

        Dim iv As ItemStorage = db.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = id)
        Dim price As Decimal = CDec(iv.stockPrice)
        If selection = 1 Then
            'JobSheetBillingRecordInsertForm.txtInventoryID.Text = iv.inventoryID.ToString
            'JobSheetBillingRecordInsertForm.inventorySelectedID = iv.inventoryID.ToString
            'JobSheetBillingRecordInsertForm.txtBrand.Text = iv.stockBrand.ToString
            'JobSheetBillingRecordInsertForm.txtName.Text = iv.stockName.ToString
            'JobSheetBillingRecordInsertForm.txtUnitPrice.Text = price.ToString("c2")
            'JobSheetBillingRecordInsertForm.txtQty.ReadOnly = False
            'JobSheetBillingRecordInsertForm.txtWarrantyInfo.ReadOnly = False
            Me.Close()
        End If
        selection = 0
    End Sub
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If tempID <> "" Then
            updateInventory.ShowDialog()
        Else
            MessageBox.Show("Please select a record from the Table", "Note")
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchboxFilter()
    End Sub

    Private Sub addSupBtn_Click(sender As Object, e As EventArgs) Handles addSupBtn.Click
        addSupplier.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles supCloseBtn.Click
        Me.Close()
    End Sub

    Private Sub supplierView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierView.CellClick
        tempSupID = supplierView.CurrentRow.Cells(0).Value.ToString
        tempSupName = supplierView.CurrentRow.Cells(1).Value.ToString
        tempSupContact = supplierView.CurrentRow.Cells(2).Value.ToString
        tempSupAddress = supplierView.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub updateSupBtn_Click(sender As Object, e As EventArgs) Handles updateSupBtn.Click
        If tempSupID <> "" Then
            updateSupplier.ShowDialog()
        Else
            MessageBox.Show("Please select a record from the Table", "Note")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchSupBox.TextChanged
        Dim searchText As String = searchSupBox.Text

        Dim dbSupplier As New DBDataContext
        Dim rsSupplier = From all In dbSupplier.Suppliers
                             Where all.supplierName.Contains(searchText)

        supplierView.DataSource = rsSupplier
    End Sub

    Private Sub removeSupBtn_Click(sender As Object, e As EventArgs) Handles removeSupBtn.Click
        Dim checkMsg As Integer

        ramSupID = tempSupID
        If tempSupID <> "" Then

            checkMsg = MessageBox.Show("Are you sure you wish to delete the record, " + tempSupName + "?", "Warning", MessageBoxButtons.YesNo)

            If checkMsg = 6 Then
                Dim dbDeleteSup As New DBDataContext

                Dim removeSup As Supplier = dbDeleteSup.Suppliers.FirstOrDefault(Function(o) o.supplierID = ramSupID)

                dbDeleteSup.Suppliers.DeleteOnSubmit(removeSup)
                dbDeleteSup.SubmitChanges()

                refreshSupplierView()
                tempSupID = ""
            Else

            End If
        Else
            MessageBox.Show("Please select a record from the Table", "Note")
        End If
    End Sub
End Class
