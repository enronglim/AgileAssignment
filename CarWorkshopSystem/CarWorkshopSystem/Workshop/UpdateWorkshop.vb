Public Class UpdateWorkshop

    Dim tempID As String
    Dim tempReg As String
    Dim tempEmail As String
    Dim tempState As String
    Dim tempAdd As String
    Dim tempContact As String
    Dim tempOD As Date
    Dim tempStatus As String

    Dim index As Integer

    Public Sub loadInfo()
        tempID = WorkshopLocation.tempID
        tempReg = WorkshopLocation.tempReg
        tempEmail = WorkshopLocation.tempEmail
        tempState = WorkshopLocation.tempState
        tempAdd = WorkshopLocation.tempAdd
        tempContact = WorkshopLocation.tempContact
        tempOD = WorkshopLocation.tempOD
        tempStatus = WorkshopLocation.tempStatus

        resetInfo()
    End Sub

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

    Private Sub resetInfo()
        idLabel.Text = tempID
        registrationTxt.Text = tempReg.ToString
        emailTxt.Text = tempEmail
        stateTxt.Text = tempState
        addressBox.Text = tempAdd
        contactTxt1.Text = tempContact.Substring(0, 3)
        contactTxt2.Text = tempContact.Substring(4, 7)
        odTxt.Text = tempOD.ToString("dd/MM/yyyy")

        index = statusCombo.FindString(tempStatus)
        statusCombo.SelectedIndex = index

        'Verification Label
        verifyContact.Text = ""
        verifyEmail.Text = ""
    End Sub

    Private Sub UpdateWorkshop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInfo()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Dim checkMsg As Integer
        checkMsg = MessageBox.Show("Are you sure you wish to reset all input?", "Warning", MessageBoxButtons.YesNo)
        If checkMsg = 6 Then
            registrationTxt.Text = tempReg.ToString
            contactTxt1.Text = tempContact.Substring(0, 3)
            contactTxt2.Text = tempContact.Substring(4, 7)
            emailTxt.Text = tempEmail
            addressBox.Text = tempAdd
            statusCombo.SelectedIndex = index

            'Verification Label
            verifyContact.Text = ""
            verifyEmail.Text = ""
        End If
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If checkEmptyContact() = True And ValidateEmail() = True Then
            Try
                Dim dbUpdate As New DBDataContext
                Dim upDate As Workshop = dbUpdate.Workshops.FirstOrDefault(Function(o) o.workshopID = tempID)

                upDate.workshopID = idLabel.Text
                upDate.workshopRegistrationNo = registrationTxt.Text
                upDate.workshopEmail = emailTxt.Text
                upDate.workshopAddress = addressBox.Text
                upDate.workshopContact = contactTxt1.Text + "-" + contactTxt2.Text
                upDate.workshopStatus = statusCombo.SelectedItem.ToString

                dbUpdate.SubmitChanges()

                tempEmail = emailTxt.Text
                tempContact = contactTxt1.Text + "-" + contactTxt2.Text
                index = statusCombo.SelectedIndex

                'Verification Label
                verifyContact.Text = ""
                verifyEmail.Text = ""

                MessageBox.Show("The record has been updated", "Record Updated", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub emailTxt_TextChanged(sender As Object, e As EventArgs) Handles emailTxt.TextChanged
        ValidateEmail()
    End Sub

    Private Sub contactTxt1_TextChanged(sender As Object, e As EventArgs) Handles contactTxt1.TextChanged
        checkEmptyContact()
    End Sub

    Private Sub contactTxt2_TextChanged(sender As Object, e As EventArgs) Handles contactTxt2.TextChanged
        checkEmptyContact()
    End Sub
End Class