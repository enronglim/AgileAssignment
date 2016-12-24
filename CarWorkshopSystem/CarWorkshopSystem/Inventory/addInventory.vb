Public Class addInventory
    Dim newID As Integer
    Dim picStore As String

    Dim shortenPath As String
    Dim fullPath As String

    Dim result As Boolean

    Public Function generateNewID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From inventryDB In dbCheck.ItemStorages
                      Select inventryDB.inventoryID

        For Each item In rsCheck
            newID = Integer.Parse(item.Substring(2, 7))
        Next

        Return (newID + 1).ToString("IS0000000")
    End Function

    Private Function checkEmptyName() As Boolean
        Dim checkState As Boolean
        If nameTxt.Text = "" Or nameTxt.Text.Trim().Length < 4 Then
            checkState = False
            verifyName.Text = "*At least 4 characters"
        ElseIf nameTxt.TextLength >= 4 Then
            verifyName.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Function checkEmptyBatch() As Boolean
        Dim checkState As Boolean
        Try
            If batchTxt.Text = "" Or batchTxt.Text.Trim().Length < 5 Or batchTxt.Text.Substring(0, 1).Contains("#") = False Then
                checkState = False
                verifyBatch.Text = "Format:#6123 and at least 4 characters"
            ElseIf batchTxt.TextLength >= 4 Then
                verifyBatch.Text = ""
                checkState = True
            End If
        Catch ex As Exception
            verifyBatch.Text = "Format:#6123 and at least 4 characters"
        End Try
        Return checkState
    End Function

    Private Function checkEmptyBrand() As Boolean
        Dim checkState As Boolean
        If brandTxt.Text = "" Or brandTxt.Text.Trim().Length < 4 Then
            checkState = False
            verifyBrand.Text = "*At least 4 characters"
        ElseIf brandTxt.TextLength >= 4 Then
            verifyBrand.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Function checkEmptyDes() As Boolean
        Dim checkState As Boolean
        If descriptionBox.Text = "" Or descriptionBox.Text.Trim().Length < 4 Then
            checkState = False
            verifyDes.Text = "*At least 4 characters"
        ElseIf descriptionBox.TextLength >= 4 Then
            verifyDes.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Function checkEmptySpec() As Boolean
        Dim checkState As Boolean
        If specificationBox.Text = "" Or specificationBox.Text.Trim().Length < 4 Then
            checkState = False
            verifySpec.Text = "*At least 4 characters"
        ElseIf specificationBox.TextLength >= 4 Then
            verifySpec.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Sub addInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarWorkshopDBDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.CarWorkshopDBDataSet.Supplier)
        categoryCombo.SelectedIndex = 0
        localRadio.Select()

        arrivalDate.MaxDate = Today
        idLabel.Text = generateNewID()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to clear all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            nameTxt.Clear()
            quantityNum.Value = 1
            batchTxt.Clear()
            categoryCombo.SelectedIndex = 0
            arrivalDate.Value = Today
            priceNum.Value = 1
            brandTxt.Clear()
            descriptionBox.Clear()
            specificationBox.Clear()
            localRadio.Select()

            'Verification Labels
            verifyBatch.Text = ""
            verifyBrand.Text = ""
            verifyName.Text = ""
            verifyDes.Text = ""
            verifySpec.Text = ""
        End If

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim newEntry As New ItemStorage

        If checkEmptyName() = True And checkEmptyBatch() = True And
            checkEmptyBrand() = True And checkEmptyDes() = True And
            checkEmptySpec() = True Then
            Try

                newEntry.inventoryID = idLabel.Text
                newEntry.stockName = nameTxt.Text
                newEntry.stockQuantity = CInt(quantityNum.Value)
                newEntry.stockBatchNo = batchTxt.Text
                newEntry.stockCategory = categoryCombo.SelectedItem.ToString
                newEntry.stockArrivalDate = arrivalDate.Value.Date
                newEntry.stockCondition = "Good"
                newEntry.stockBrand = brandTxt.Text
                newEntry.stockDescription = descriptionBox.Text
                newEntry.stockSpecification = specificationBox.Text
                newEntry.stockStatus = "Available"

                If preRadio.Checked = True Then
                    newEntry.stockType = preRadio.Text
                Else
                    newEntry.stockType = localRadio.Text
                End If

                newEntry.stockSupplier = supplierCombo.SelectedValue.ToString
                newEntry.stockPrice = priceNum.Value

                If picStore = "" Then
                    shortenPath = "None"
                    fullPath = "None"
                End If
                newEntry.stockImage = shortenPath
                newEntry.stockPath = fullPath
                imageBox.ImageLocation = ""

                Dim dbSubmit As New DBDataContext
                dbSubmit.ItemStorages.InsertOnSubmit(newEntry)
                dbSubmit.SubmitChanges()

                idLabel.Text = generateNewID()

                nameTxt.Clear()
                quantityNum.Value = 1
                batchTxt.Clear()
                categoryCombo.SelectedIndex = 0
                arrivalDate.Value = Today
                priceNum.Value = 1
                brandTxt.Clear()
                descriptionBox.Clear()
                specificationBox.Clear()
                localRadio.Select()

                'Verification Labels
                verifyBatch.Text = ""
                verifyBrand.Text = ""
                verifyName.Text = ""
                verifyDes.Text = ""
                verifySpec.Text = ""

                MessageBox.Show("The new record has been created", "Record Stored", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click

        Try
            Dim dlg As New OpenFileDialog
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            dlg.Title = "Select Product Image"
            If dlg.ShowDialog = DialogResult.OK Then
                picStore = dlg.FileName.ToString()
                imageBox.ImageLocation = picStore
                shortenPath = "../Images/Products/" + System.IO.Path.GetFileName(picStore)
                fullPath = picStore
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub nameTxt_TextChanged(sender As Object, e As EventArgs) Handles nameTxt.TextChanged
        checkEmptyName()
    End Sub

    Private Sub batchTxt_TextChanged(sender As Object, e As EventArgs) Handles batchTxt.TextChanged
        checkEmptyBatch()
    End Sub

    Private Sub brandTxt_TextChanged(sender As Object, e As EventArgs) Handles brandTxt.TextChanged
        checkEmptyBrand()
    End Sub

    Private Sub descriptionBox_TextChanged(sender As Object, e As EventArgs) Handles descriptionBox.TextChanged
        checkEmptyDes()
    End Sub

    Private Sub specificationBox_TextChanged(sender As Object, e As EventArgs) Handles specificationBox.TextChanged
        checkEmptySpec()
    End Sub
End Class