Imports System.IO

Public Class StaffUpdateForm
    Public Shared SelectedId As String
    Friend Shared selection As Integer = 0
    Friend used As Integer = 0
    Friend staffPicture As Image
    Dim staPicName As String = ""
    Dim clickPic As Integer = 0
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
        cboStaffStatus.Text = ""
        lblGenderEmpty.Visible = False
        lblPasswordEmpty.Visible = False
        lblPositionEmpty.Visible = False
        lblStaffAddressEmpty.Visible = False
        lblStaffContact.Visible = False
        lblStaffEmailFormatError.Visible = False
        lblStaffNameEmpty.Visible = False
        lblStaffRaceEmpty.Visible = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ResetForm()
        Me.Close()
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
        Dim status As String = ""
        If used = 0 Then
            status = cboStaffStatus.SelectedItem.ToString
        End If



        Dim db As New DBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffIC = SelectedId)

        s.name = staffName.ToString
        s.staffIC = staffIC.ToString
        s.position = position.ToString
        s.gender = selectedValue.ToString
        s.contactNo = contact.ToString
        s.password = password.ToString

        s.address = address.ToString
        s.race = race.ToString
        s.email = email.ToString

        If used = 0 Then
            s.status = status.ToString
        End If
        If clickPic = 1 Then
            s.staffPic = File.ReadAllBytes(staPicName)
        End If
        staPicName = ""
        clickPic = 0
        s.emplomentDate = Convert.ToDateTime(emplomentDateTimePicker.Value.Date.ToString("yyyy/MM/dd")).Date




            If err > 0 Then

            Else
                If emailFormatCorrect = 0 Then
                    db.SubmitChanges()
                    MessageBox.Show("Staff name " & s.name & " and Staff IC " & s.staffIC & " has been updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub StaffUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ResetForm()
            If selection = 1 Then
                lblStatus.Visible = False
                cboStaffStatus.Visible = False
                lblPosition.Visible = False
                cboPosition.Visible = False
                used = 1
            Else
                lblStatus.Visible = True
                cboStaffStatus.Visible = True
                lblPosition.Visible = True
                cboPosition.Visible = True
            End If
            selection = 0
            Dim db As New DBDataContext()

            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffIC = SelectedId)

            Dim imgByte As Byte()
            If Not s.staffPic = Nothing Then
                imgByte = CType(s.staffPic.ToArray, Byte())
                Dim stream As New MemoryStream(imgByte)
                staffPicture = Image.FromStream(stream)
            Else
                staffPicture = Nothing
            End If


            txtStaffName.Text = s.name.ToString
            mskStaffIc.Text = s.staffIC.ToString
            cboPosition.Text = s.position.ToString
            If s.gender.Equals("Male") Then
                rbStaffMale.Checked = True
            ElseIf s.gender.Equals("Female") Then
                rbStaffFemale.Checked = True

            End If
            txtStaffContact.Text = s.contactNo.ToString
            txtPassword.Text = s.password.ToString
            cboStaffStatus.Text = s.status.ToString
            txtStaffAddress.Text = s.address.ToString
            txtstaffEmailAddress.Text = s.email.ToString
            cboStaffRace.Text = s.race.ToString
            emplomentDateTimePicker.Value = s.emplomentDate
            PictureBox1.Image = staffPicture
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnStaffPic_Click(sender As Object, e As EventArgs) Handles btnStaffPic.Click
      
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            staPicName = OpenFileDialog1.FileName
            clickPic = 1
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

    Private Sub txtStaffContact_TextChanged(sender As Object, e As EventArgs)
        lblStaffContact.Visible = False
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