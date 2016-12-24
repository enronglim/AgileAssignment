Public Class updateInventory

    Dim tempID As String
    Dim tempName As String
    Dim tempQuantity As Integer
    Dim tempBatchNo As String
    Dim tempCategory As String
    Dim tempAD As Date
    Dim tempCondition As String
    Dim tempBrand As String
    Dim tempDescription As String
    Dim tempSpecification As String
    Dim tempStatus As String
    Dim tempSupplier As String
    Dim tempPrice As Double
    Dim tempImage As String
    Dim tempPath As String

    Dim categoryI As Integer
    Dim conditionI As Integer
    Dim supplierI As Integer

    Dim picStore As String
    Dim shortenPath As String
    Dim fullPath As String

    Private Sub loadImage()
        If tempPath = "None" Then
            imageBox.ImageLocation = ""
        Else
            imageBox.ImageLocation = tempPath
            shortenPath = tempImage
            fullPath = tempPath
        End If
    End Sub

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

    Private Sub resetInfo()
        'Dim imgByte() As Byte = System.Text.Encoding.ASCII.GetBytes("0xFFD8FFE000104A46494600010100000100010000FFDB00840009060712121215121311161515171515151817161717151618171515161615151715181E2820181A251D151521312225292B2E2E2E171F3338332C37282D2E2B010A0A0A0E0D0E1B10101B2D251F252D2D2D2D2D2D2E2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D322D")
        'System.Text.Encoding.ASCII.GetBytes(tempImage)

        idLabel.Text = tempID
        nameTxt.Text = tempName
        quantityNum.Value = tempQuantity
        batchTxt.Text = tempBatchNo

        categoryI = categoryCombo.FindString(tempCategory)
        categoryCombo.SelectedIndex = categoryI

        dateText.Text = tempAD.ToString("dd/MM/yyyy")

        conditionI = conditionCombo.FindString(tempCondition)
        conditionCombo.SelectedIndex = conditionI

        brandTxt.Text = tempBrand
        descriptionBox.Text = tempDescription
        specificationBox.Text = tempSpecification

        If tempStatus = "Available" Then
            availableRadio.Select()
        Else
            disabledRadio.Select()
        End If

        Dim db As New DBDataContext
        Dim rs = From s In db.Suppliers
                 Select s.supplierName

        supplierCombo.DataSource = rs.ToArray()
        supplierCombo.Enabled = True

        supplierI = supplierCombo.FindString(tempSupplier)
        supplierCombo.SelectedIndex = supplierI

        priceNum.Value = CDec(tempPrice)
        imageBox.ImageLocation = tempPath

        'Verification Labels
        verifyBrand.Text = ""
        verifyDes.Text = ""
        verifySpec.Text = ""

    End Sub

    Private Sub updateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempID = Inventory.tempID
        tempName = Inventory.tempName
        tempQuantity = Inventory.tempQuantity
        tempBatchNo = Inventory.tempBatchNo
        tempCategory = Inventory.tempCategory
        tempAD = Inventory.tempAD
        tempCondition = Inventory.tempCondition
        tempBrand = Inventory.tempBrand
        tempDescription = Inventory.tempDescription
        tempSpecification = Inventory.tempSpecification
        tempStatus = Inventory.tempStatus
        tempSupplier = Inventory.tempSupplier
        tempPrice = Inventory.tempPrice
        tempImage = Inventory.tempImage
        tempPath = Inventory.tempPath

        loadImage()
        resetInfo()
    End Sub


    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If checkEmptyBrand() = True And checkEmptyDes() = True And checkEmptySpec() = True Then
            Try
                Dim dbUpdate As New DBDataContext
                Dim upDate As ItemStorage = dbUpdate.ItemStorages.FirstOrDefault(Function(o) o.inventoryID = tempID)

                upDate.stockQuantity = CInt(quantityNum.Value)
                upDate.stockCategory = categoryCombo.SelectedItem.ToString
                upDate.stockBrand = brandTxt.Text
                upDate.stockSupplier = supplierCombo.SelectedItem.ToString
                upDate.stockPrice = priceNum.Value
                upDate.stockDescription = descriptionBox.Text
                upDate.stockSpecification = specificationBox.Text
                upDate.stockCondition = conditionCombo.SelectedItem.ToString

                If availableRadio.Checked = True Then
                    upDate.stockStatus = "Available"
                Else
                    upDate.stockStatus = "Disabled"
                End If

                If picStore = "" And shortenPath = "" Then
                    shortenPath = "None"
                    fullPath = "None"
                End If
                upDate.stockImage = shortenPath
                upDate.stockPath = fullPath

                'quantity category brand supplier price descrip specific condition status

                dbUpdate.SubmitChanges()

                categoryI = categoryCombo.SelectedIndex
                conditionI = conditionCombo.SelectedIndex
                supplierI = supplierCombo.SelectedIndex

                'Verification Labels
                verifyBrand.Text = ""
                verifyDes.Text = ""
                verifySpec.Text = ""

                MessageBox.Show("The record has been updated", "Record Updated", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to reset all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            resetInfo()
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
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

    Private Sub descriptionBox_TextChanged(sender As Object, e As EventArgs) Handles descriptionBox.TextChanged
        checkEmptyDes()
    End Sub

    Private Sub specificationBox_TextChanged(sender As Object, e As EventArgs) Handles specificationBox.TextChanged
        checkEmptySpec()
    End Sub

    Private Sub brandTxt_TextChanged(sender As Object, e As EventArgs) Handles brandTxt.TextChanged
        checkEmptyBrand()
    End Sub
End Class