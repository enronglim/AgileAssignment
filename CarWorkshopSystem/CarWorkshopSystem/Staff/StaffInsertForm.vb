Imports System.IO

Public Class StaffInsertForm

    Dim staPicName As String = ""

    Private Sub ResetForm()
        txtStaffName.Text = ""
        txtPassword.Text = ""
        mskStaffIc.Text = ""
        rbStaffMale.Checked = False
        rbStaffFemale.Checked = False
        cboStaffRace.Text = ""
        txtStaffContact.Text = ""
        txtstaffEmailAddress.Text = ""
        cboPosition.Text = ""
        txtStaffAddress.Text = ""
        txtstaffStatus.Text = "Available"
        lblGenderEmpty.Visible = False
        lblPasswordEmpty.Visible = False
        lblPositionEmpty.Visible = False
        lblStaffAddressEmpty.Visible = False
        lblStaffContact.Visible = False
        lblStaffEmailFormatError.Visible = False
        lblStaffICEmpty.Visible = False
        lblStaffNameEmpty.Visible = False
        lblStaffRaceEmpty.Visible = False


    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ResetForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim err As Integer = 0
            If rbStaffMale.Checked = False And rbStaffFemale.Checked = False Then
                lblGenderEmpty.Visible = True
                err += 1
            End If
            If txtPassword.Text = "" Then
                lblPasswordEmpty.Visible = True
                err += 1
            End If
            If cboPosition.Text = "" Then
                lblPositionEmpty.Visible = True
                err += 1
            End If
            If txtStaffAddress.Text = "" Then
                lblStaffAddressEmpty.Visible = True
                err += 1
            End If
            If txtStaffContact.Text = "" Then
                lblStaffContact.Visible = True
                err += 1
            End If
            If txtstaffEmailAddress.Text = "" Then
                lblStaffEmailFormatError.Visible = True
                err += 1
            End If
            If Not mskStaffIc.MaskFull Then
                lblStaffICEmpty.Visible = True
                err += 1
            End If
            If txtStaffName.Text = "" Then
                lblStaffNameEmpty.Visible = True
                err += 1
            End If
            If cboStaffRace.Text = "" Then
                lblStaffRaceEmpty.Visible = True
                err += 1
            End If



            Dim selectedValue As String = ""
            Dim emailFormatCorrect As Integer = 0
            Dim staffName As String = txtStaffName.Text
            Dim staffIC As String = mskStaffIc.Text
            Dim position = cboPosition.SelectedItem.ToString
            If rbStaffMale.Checked Then
                selectedValue = "Male"
            ElseIf rbStaffFemale.Checked Then
                selectedValue = "Female"

            End If
            Dim contact = txtStaffContact.Text
            Dim password As String = txtPassword.Text
            Dim status = txtstaffStatus.Text
            Dim race As String = cboStaffRace.SelectedItem.ToString
            Dim email = txtstaffEmailAddress.Text
            If IsValidEmailFormat(email) = False Then
                lblStaffEmailFormatError.Visible = True
                emailFormatCorrect = 1
            Else
                lblStaffEmailFormatError.Visible = False
                emailFormatCorrect = 0
            End If
            Dim address = txtStaffAddress.Text




            Dim s As New Staff()
            s.name = staffName.ToString
            s.staffIC = staffIC.ToString
            s.position = position.ToString
            s.gender = selectedValue.ToString
            s.contactNo = contact.ToString
            s.password = password.ToString
            s.status = status.ToString
            s.address = address.ToString
            s.race = race.ToString
            s.email = email.ToString
            If staPicName Is "" Then
                s.staffPic = Nothing
            Else
                s.staffPic = File.ReadAllBytes(staPicName)
            End If
            s.emplomentDate = Convert.ToDateTime(emplomentDateTimePicker.Value.Date.ToString("yyyy/MM/dd")).Date
            If err > 0 Then

            Else

                If emailFormatCorrect = 0 Then
                    Dim db As New DBDataContext()
                    db.Staffs.InsertOnSubmit(s)
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub StaffInsertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emplomentDateTimePicker.Value = Date.Now
    End Sub

    Private Sub btnStaffPic_Click(sender As Object, e As EventArgs) Handles btnStaffPic.Click

        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            staPicName = OpenFileDialog1.FileName
        End If
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub txtStaffName_TextChanged(sender As Object, e As EventArgs) Handles txtStaffName.TextChanged
        lblStaffNameEmpty.Visible = False
    End Sub

    Private Sub mskStaffIc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskStaffIc.MaskInputRejected
        lblStaffICEmpty.Visible = False
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblPasswordEmpty.Visible = False
    End Sub

    Private Sub rbStaffMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbStaffMale.CheckedChanged
        lblGenderEmpty.Visible = False
    End Sub

    Private Sub rbStaffFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbStaffFemale.CheckedChanged
        lblGenderEmpty.Visible = False
    End Sub

    Private Sub cboStaffRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStaffRace.SelectedIndexChanged
        lblStaffRaceEmpty.Visible = False
    End Sub

    Private Sub txtstaffEmailAddress_TextChanged(sender As Object, e As EventArgs) Handles txtstaffEmailAddress.TextChanged
        lblStaffEmailFormatError.Visible = False
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        lblPositionEmpty.Visible = False
    End Sub

    Private Sub txtStaffAddress_TextChanged(sender As Object, e As EventArgs) Handles txtStaffAddress.TextChanged
        lblStaffAddressEmpty.Visible = False
    End Sub
End Class