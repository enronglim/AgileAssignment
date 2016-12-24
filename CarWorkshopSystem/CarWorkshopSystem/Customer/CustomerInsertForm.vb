
Public Class CustomerInsertForm


    Private Sub ResetForm()
        txtCustomerName.Text = ""
        mskCustomerIc.Text = ""
        rbCustomerMale.Checked = False
        rbCustomerFemale.Checked = False
        cboCustomerRace.Text = ""
        txtCustomerContact.Text = ""
        txtcustomerEmailAddress.Text = ""
        txtCustomerPassportNo.Text = ""
        txtCustomerAddress.Text = ""
        lblCustomerNameEmpty.Visible = False
        lblContactEmpty.Visible = False
        lblEmailFormatError.Visible = False
        lblAddressEmpty.Visible = False
        lblGenderEmpty.Visible = False
        lblRaceEmpty.Visible = False
        lblCustomerICEmpty.Visible = False
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        
        ResetForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ResetForm()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim err As Integer = 0

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

            If Not mskCustomerIc.MaskFull Then
                lblCustomerICEmpty.Visible = True
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
            Dim emailFormatCorrect As Integer = 0

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
            Dim status = txtStatus.Text



            Dim c As New Customer()
            c.name = customerName.ToString
            c.customerIC = customerIC.ToString
            c.gender = selectedValue.ToString
            c.race = race.ToString
            c.contactNo = contact.ToString
            c.email = email.ToString
            c.passportNo = passport.ToString
            c.address = address.ToString
            c.status = status.ToString
            c.serviceCount = 0
            If err > 0 Then

            Else

                If emailFormatCorrect = 0 Then
                    Dim db As New DBDataContext()
                    db.Customers.InsertOnSubmit(c)
                    db.SubmitChanges()
                    MessageBox.Show("Record inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ResetForm()
                    Me.Close()
                End If

            End If


        Catch ex As Exception
            'MessageBox.Show("error insert database", "format error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)

        End Try
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
   
    Private Sub CustomerInsertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmailFormatError.Visible = False
    End Sub

    Private Sub txtcustomerEmailAddress_TextChanged(sender As Object, e As EventArgs) Handles txtcustomerEmailAddress.TextChanged
        lblEmailFormatError.Visible = False
    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        lblCustomerNameEmpty.Visible = False
    End Sub

    Private Sub mskCustomerIc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCustomerIc.MaskInputRejected
        lblCustomerICEmpty.Visible = False
    End Sub

    Private Sub rbCustomerMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbCustomerMale.CheckedChanged
        lblGenderEmpty.Visible = False
    End Sub

    Private Sub rbCustomerFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbCustomerFemale.CheckedChanged
        lblGenderEmpty.Visible = False
    End Sub

    Private Sub cboCustomerRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerRace.SelectedIndexChanged
        lblRaceEmpty.Visible = False
    End Sub

    Private Sub txtCustomerAddress_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerAddress.TextChanged
        lblAddressEmpty.Visible = False
    End Sub
End Class