Public Class AddWorkshop

    Dim newID As Integer

    Public Function generateNewID() As String
        Dim dbCheck As New DBDataContext

        Dim rsCheck = From workshopDB In dbCheck.Workshops
                      Select workshopDB.workshopID

        For Each item In rsCheck
            newID = Integer.Parse(item.Substring(2, 5))
        Next

        Return (newID + 1).ToString("WS00000")
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

    Private Function checkEmptyReg() As Boolean
        Dim checkState As Boolean
        Try
            If registrationTxt.Text = "" Or registrationTxt.TextLength < 5 Or
               registrationTxt.Text.Substring(registrationTxt.TextLength - 2, 1).Contains("-") = False Or
               IsNumeric(registrationTxt.Text.Substring(registrationTxt.TextLength - 1, 1)) = True Then

                checkState = False
                verifyReg.Text = "Format:153-V and at least 5 characters"
            Else
                verifyReg.Text = ""
                checkState = True
            End If
        Catch ex As Exception
            checkState = False
            verifyReg.Text = "Format:153-V and at least 5 characters"
        End Try
        Return checkState
    End Function

    Function ValidateEmail() As Boolean
        Dim checkState As Boolean
        Try
            Dim checkMail As New System.Net.Mail.MailAddress(emailTxt.Text)
            verifyEmail.Text = ""
            checkState = True
        Catch ex As Exception
            verifyEmail.Text = "Format:example@hotmail.com"
            checkState = False
        End Try
        Return checkState
    End Function

    'Regular Expression
    'Function ValidateEmail(ByVal email As String) As Boolean
    '    Dim emailRegex As New System.Text.RegularExpressions.Regex(
    '        "^(?<user>[^@]+)@(?<host>.+)$")
    '    Dim emailMatch As System.Text.RegularExpressions.Match =
    '       emailRegex.Match(email)
    '    Return emailMatch.Success
    'End Function

    Private Function checkEmptyAdd() As Boolean
        Dim checkState As Boolean
        If addressBox.Text = "" Or addressBox.Text.Trim().Length < 4 Then
            checkState = False
            verifyAdd.Text = "*At least 4 characters"
        ElseIf addressBox.TextLength >= 4 Then
            verifyAdd.Text = ""
            checkState = True
        End If
        Return checkState
    End Function

    Private Sub AddWorkshop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idLabel.Text = generateNewID()
        stateCombo.SelectedIndex = 0
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to clear all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            registrationTxt.Clear()
            contactTxt1.Clear()
            contactTxt2.Clear()
            emailTxt.Clear()
            addressBox.Clear()

            'Verification Label
            verifyAdd.Text = ""
            verifyReg.Text = ""
            verifyContact.Text = ""
            verifyEmail.Text = ""
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim newEntry As New Workshop()

        If checkEmptyAdd() = True And checkEmptyContact() = True And
            checkEmptyReg() = True And ValidateEmail() = True Then

            Try
                newEntry.workshopID = idLabel.Text
                newEntry.workshopRegistrationNo = registrationTxt.Text
                newEntry.workshopEmail = emailTxt.Text
                newEntry.workshopState = stateCombo.SelectedItem.ToString()
                newEntry.workshopAddress = addressBox.Text
                newEntry.workshopContact = contactTxt1.Text + "-" + contactTxt2.Text
                newEntry.workshopOD = arrivalDate.Value.Date
                newEntry.workshopStatus = "Operational"

                Dim dbSubmit As New DBDataContext
                dbSubmit.Workshops.InsertOnSubmit(newEntry)
                dbSubmit.SubmitChanges()

                idLabel.Text = generateNewID()

                registrationTxt.Clear()
                contactTxt1.Clear()
                contactTxt2.Clear()
                emailTxt.Clear()
                addressBox.Clear()

                'Verification Label
                verifyAdd.Text = ""
                verifyReg.Text = ""
                verifyContact.Text = ""
                verifyEmail.Text = ""

                MessageBox.Show("The new record has been created", "Record Stored", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try

        End If
    End Sub

    Private Sub registrationTxt_TextChanged(sender As Object, e As EventArgs) Handles registrationTxt.TextChanged
        checkEmptyReg()
    End Sub

    Private Sub contactTxt1_TextChanged(sender As Object, e As EventArgs) Handles contactTxt1.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub contactTxt2_TextChanged(sender As Object, e As EventArgs) Handles contactTxt2.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub emailTxt_TextChanged(sender As Object, e As EventArgs) Handles emailTxt.TextChanged
        ValidateEmail()
    End Sub

    Private Sub addressBox_TextChanged(sender As Object, e As EventArgs) Handles addressBox.TextChanged
        checkEmptyAdd()
    End Sub
End Class