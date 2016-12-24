Public Class updateSupplier

    Dim tempID As String
    Dim tempName As String
    Dim tempContact As String
    Dim tempAddress As String

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

    Private Function checkEmptyContact() As Boolean
        Dim checkState As Boolean
        If contactTxt1.Text = "" Or contactTxt2.Text = "" Or contactTxt1.TextLength < 3 Or
            contactTxt2.TextLength < 7 Or IsNumeric(contactTxt1.Text) = False Or
            IsNumeric(contactTxt2.Text) = False Then

            checkState = False
            verifyContact.Text = "Format:604-8992314"
        Else
            verifyContact.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Function checkEmptyAdd() As Boolean
        Dim checkState As Boolean
        If addressBox.Text = "" Or addressBox.Text.Trim().Length < 4 Then
            checkState = False
            verifyAddress.Text = "*At least 4 characters"
        ElseIf addressBox.TextLength >= 4 Then
            verifyAddress.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub resetInfo()
        idLabel.Text = tempID
        nameTxt.Text = tempName
        contactTxt1.Text = tempContact.Substring(0, 3)
        Try
            contactTxt2.Text = tempContact.Substring(4, 8)
        Catch ex As Exception
            contactTxt2.Text = tempContact.Substring(4, 7)
        End Try
        addressBox.Text = tempAddress

    End Sub

    Private Sub updateSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempID = Inventory.tempSupID
        tempName = Inventory.tempSupName
        tempContact = Inventory.tempSupContact
        tempAddress = Inventory.tempSupAddress

        resetInfo()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If checkEmptyAdd() = True And checkEmptyContact() = True And checkEmptyName() = True Then
            Try
                Dim dbUpdate As New DBDataContext
                Dim upDate As Supplier = dbUpdate.Suppliers.FirstOrDefault(Function(o) o.supplierID = tempID)

                upDate.supplierName = nameTxt.Text
                upDate.supplierContact = contactTxt1.Text + "-" + contactTxt2.Text
                upDate.supplierAddress = addressBox.Text

                dbUpdate.SubmitChanges()

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

    Private Sub addressBox_TextChanged_1(sender As Object, e As EventArgs) Handles addressBox.TextChanged
        checkEmptyAdd()
    End Sub

    Private Sub contactTxt1_TextChanged_1(sender As Object, e As EventArgs) Handles contactTxt1.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub contactTxt2_TextChanged_1(sender As Object, e As EventArgs) Handles contactTxt2.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub nameTxt_TextChanged_1(sender As Object, e As EventArgs) Handles nameTxt.TextChanged
        checkEmptyName()
    End Sub
End Class