Public Class addSupplier
    Dim newID As Integer
    Public Function generateNewID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From supplierDB In dbCheck.Suppliers
                      Select supplierDB.supplierID

        For Each item In rsCheck
            newID = Integer.Parse(item.Substring(2, 4))
        Next

        Return (newID + 1).ToString("SP0000")
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

    Private Sub addSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idLabel.Text = generateNewID()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to reset all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            nameTxt.Clear()
            contactTxt1.Clear()
            contactTxt2.Clear()
            addressBox.Clear()

            'Verification Label
            verifyAddress.Text = ""
            verifyContact.Text = ""
            verifyName.Text = ""
        End If
    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim newEntry As New Supplier

        If checkEmptyAdd() = True And checkEmptyContact() = True And checkEmptyName() = True Then
            Try
                newEntry.supplierID = idLabel.Text
                newEntry.supplierName = nameTxt.Text
                newEntry.supplierContact = contactTxt1.Text + "-" + contactTxt2.Text
                newEntry.supplierAddress = addressBox.Text

                Dim dbSubmit As New DBDataContext
                dbSubmit.Suppliers.InsertOnSubmit(newEntry)
                dbSubmit.SubmitChanges()

                idLabel.Text = generateNewID()
                nameTxt.Clear()
                contactTxt1.Clear()
                contactTxt2.Clear()
                addressBox.Clear()

                'Verification Label
                verifyAddress.Text = ""
                verifyContact.Text = ""
                verifyName.Text = ""

                MessageBox.Show("The new record has been created", "Record Stored", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
    End Sub


    Private Sub nameTxt_TextChanged(sender As Object, e As EventArgs) Handles nameTxt.TextChanged
        checkEmptyName()
    End Sub

    Private Sub contactTxt2_TextChanged(sender As Object, e As EventArgs) Handles contactTxt2.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub contactTxt1_TextChanged(sender As Object, e As EventArgs) Handles contactTxt1.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub addressBox_TextChanged(sender As Object, e As EventArgs) Handles addressBox.TextChanged
        checkEmptyAdd()
    End Sub
End Class