Public Class CustomerUpdateForm
    Public Shared SelectedId As String
    Private Sub CustomerUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ResetForm()
            Dim db As New DBDataContext()
            Dim cd As Customer = db.Customers.FirstOrDefault(Function(o) o.customerIC = SelectedId)


            txtCustomerName.Text = cd.name.ToString
            mskCustomerIc.Text = cd.customerIC.ToString

            If cd.gender.Equals("Male") Then
                rbCustomerMale.Checked = True
            ElseIf cd.gender.Equals("Female") Then
                rbCustomerFemale.Checked = True

            End If

            cboCustomerRace.Text = cd.race.ToString
            txtCustomerContact.Text = cd.contactNo.ToString
            txtcustomerEmailAddress.Text = cd.email.ToString
            If cd.passportNo Is Nothing Then

            Else
                txtCustomerPassportNo.Text = cd.passportNo.ToString
            End If

            cboCustomerStatus.Text = cd.status.ToString()
            txtCustomerAddress.Text = cd.address.ToString
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub ResetForm()
        txtCustomerName.Text = ""
        mskCustomerIc.Enabled = False
        rbCustomerMale.Checked = False
        rbCustomerFemale.Checked = False
        cboCustomerRace.SelectedValue = 0
        txtCustomerContact.Text = ""
        txtcustomerEmailAddress.Text = ""
        txtCustomerPassportNo.Text = ""
        txtCustomerAddress.Text = ""
        cboCustomerStatus.Text = ""
        lblCustomerNameEmpty.Visible = False
        lblContactEmpty.Visible = False
        lblEmailFormatError.Visible = False
        lblAddressEmpty.Visible = False
        lblGenderEmpty.Visible = False
        lblRaceEmpty.Visible = False

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            Dim err As Integer = 0
            Dim emailFormatCorrect As Integer = 0
            If txtCustomerName.Text = "" Then
                lblCustomerNameEmpty.Visible = True
                err += 1
            End If

            If txtCustomerContact.TextLength < 10 Then
                lblContactEmpty.Visible = True
                err += 1
            End If
            If txtCustomerAddress.Text = "" Then
                lblAddressEmpty.Visible = True
                err += 1
            End If


            If cboCustomerRace.Text = "" Then
                lblRaceEmpty.Visible = True
                err += 1
            End If
            If rbCustomerMale.Checked = False And rbCustomerFemale.Checked = False Then
                lblGenderEmpty.Visible = True
                err += 1
            End If
            If txtcustomerEmailAddress.Text = "" Then
                lblEmailFormatError.Visible = True
                err += 1
            End If

            Dim selectedValue As String = ""
            Dim customerName As String = txtCustomerName.Text
            Dim customerIC As String = mskCustomerIc.Text

            If rbCustomerMale.Checked Then
                selectedValue = "Male"
            ElseIf rbCustomerFemale.Checked Then
                selectedValue = "Female"

            End If


            Dim race As String = cboCustomerRace.SelectedItem.ToString

            Dim contact = txtCustomerContact.Text
            Dim email = txtcustomerEmailAddress.Text
            If IsValidEmailFormat(email) = False Then
                lblEmailFormatError.Visible = True
                emailFormatCorrect = 1
            Else
                lblEmailFormatError.Visible = False
                emailFormatCorrect = 0
            End If
            Dim passport = txtCustomerPassportNo.Text
            Dim address = txtCustomerAddress.Text

            Dim status = cboCustomerStatus.SelectedItem.ToString
            Dim db As New DBDataContext()
            Dim c As Customer = db.Customers.FirstOrDefault(Function(o) o.customerIC = SelectedId)

            c.name = customerName.ToString
            c.customerIC = customerIC.ToString
            c.gender = selectedValue.ToString
            c.race = race.ToString
            c.contactNo = contact.ToString
            c.email = email.ToString
            c.passportNo = passport.ToString
            c.address = address.ToString
            c.status = status.ToString

            If err > 0 Then

            Else

                If emailFormatCorrect = 0 Then
                    db.SubmitChanges()
                    MessageBox.Show("Customer name " & c.name & " and Customer IC " & c.customerIC & " has been updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            End If

        Catch ex As Exception
            'MessageBox.Show("error insert database", "format error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ResetForm()
        Me.Close()
    End Sub
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
End Class