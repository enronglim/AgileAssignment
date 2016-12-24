<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffInsertForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gender = New System.Windows.Forms.GroupBox()
        Me.rbStaffMale = New System.Windows.Forms.RadioButton()
        Me.rbStaffFemale = New System.Windows.Forms.RadioButton()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtStaffAddress = New System.Windows.Forms.TextBox()
        Me.txtstaffEmailAddress = New System.Windows.Forms.TextBox()
        Me.cboStaffRace = New System.Windows.Forms.ComboBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.mskStaffIc = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstaffStatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.emplomentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnStaffPic = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStaffNameEmpty = New System.Windows.Forms.Label()
        Me.lblStaffICEmpty = New System.Windows.Forms.Label()
        Me.lblGenderEmpty = New System.Windows.Forms.Label()
        Me.lblStaffContact = New System.Windows.Forms.Label()
        Me.txtStaffContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblPositionEmpty = New System.Windows.Forms.Label()
        Me.lblStaffEmailFormatError = New System.Windows.Forms.Label()
        Me.lblStaffRaceEmpty = New System.Windows.Forms.Label()
        Me.lblPasswordEmpty = New System.Windows.Forms.Label()
        Me.lblStaffAddressEmpty = New System.Windows.Forms.Label()
        Me.gender.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gender
        '
        Me.gender.Controls.Add(Me.rbStaffMale)
        Me.gender.Controls.Add(Me.rbStaffFemale)
        Me.gender.Location = New System.Drawing.Point(140, 118)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(176, 41)
        Me.gender.TabIndex = 54
        Me.gender.TabStop = False
        '
        'rbStaffMale
        '
        Me.rbStaffMale.AutoSize = True
        Me.rbStaffMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStaffMale.ForeColor = System.Drawing.Color.Black
        Me.rbStaffMale.Location = New System.Drawing.Point(19, 11)
        Me.rbStaffMale.Name = "rbStaffMale"
        Me.rbStaffMale.Size = New System.Drawing.Size(61, 24)
        Me.rbStaffMale.TabIndex = 4
        Me.rbStaffMale.Tag = ""
        Me.rbStaffMale.Text = "Male"
        Me.rbStaffMale.UseVisualStyleBackColor = True
        '
        'rbStaffFemale
        '
        Me.rbStaffFemale.AutoSize = True
        Me.rbStaffFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStaffFemale.ForeColor = System.Drawing.Color.Black
        Me.rbStaffFemale.Location = New System.Drawing.Point(81, 11)
        Me.rbStaffFemale.Name = "rbStaffFemale"
        Me.rbStaffFemale.Size = New System.Drawing.Size(80, 24)
        Me.rbStaffFemale.TabIndex = 5
        Me.rbStaffFemale.Tag = ""
        Me.rbStaffFemale.Text = "Female"
        Me.rbStaffFemale.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(362, 482)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(86, 29)
        Me.BtnReset.TabIndex = 53
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(593, 482)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 52
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(470, 482)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 29)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtStaffAddress
        '
        Me.txtStaffAddress.Location = New System.Drawing.Point(140, 364)
        Me.txtStaffAddress.MaxLength = 50
        Me.txtStaffAddress.Multiline = True
        Me.txtStaffAddress.Name = "txtStaffAddress"
        Me.txtStaffAddress.Size = New System.Drawing.Size(540, 72)
        Me.txtStaffAddress.TabIndex = 50
        '
        'txtstaffEmailAddress
        '
        Me.txtstaffEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffEmailAddress.Location = New System.Drawing.Point(535, 212)
        Me.txtstaffEmailAddress.MaxLength = 35
        Me.txtstaffEmailAddress.Name = "txtstaffEmailAddress"
        Me.txtstaffEmailAddress.Size = New System.Drawing.Size(145, 22)
        Me.txtstaffEmailAddress.TabIndex = 47
        '
        'cboStaffRace
        '
        Me.cboStaffRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffRace.FormattingEnabled = True
        Me.cboStaffRace.Items.AddRange(New Object() {"Chinese", "Malays", "Indian", "Others"})
        Me.cboStaffRace.Location = New System.Drawing.Point(535, 131)
        Me.cboStaffRace.Name = "cboStaffRace"
        Me.cboStaffRace.Size = New System.Drawing.Size(129, 28)
        Me.cboStaffRace.TabIndex = 6
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(140, 6)
        Me.txtStaffName.MaxLength = 30
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(208, 22)
        Me.txtStaffName.TabIndex = 1
        '
        'mskStaffIc
        '
        Me.mskStaffIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStaffIc.Location = New System.Drawing.Point(140, 66)
        Me.mskStaffIc.Mask = "000000-00-0000"
        Me.mskStaffIc.Name = "mskStaffIc"
        Me.mskStaffIc.Size = New System.Drawing.Size(100, 22)
        Me.mskStaffIc.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(388, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Race"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(388, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "E-Mail Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Contact No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Address "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Position        "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Gender                       "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Staff I/C No     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Staff Name     "
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Manager", "Admin Staff", "Mechanic"})
        Me.cboPosition.Location = New System.Drawing.Point(140, 282)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(129, 28)
        Me.cboPosition.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Status"
        '
        'txtstaffStatus
        '
        Me.txtstaffStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffStatus.ForeColor = System.Drawing.Color.Black
        Me.txtstaffStatus.Location = New System.Drawing.Point(535, 290)
        Me.txtstaffStatus.Name = "txtstaffStatus"
        Me.txtstaffStatus.ReadOnly = True
        Me.txtstaffStatus.Size = New System.Drawing.Size(100, 22)
        Me.txtstaffStatus.TabIndex = 57
        Me.txtstaffStatus.Text = "Available"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(535, 6)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(129, 22)
        Me.txtPassword.TabIndex = 2
        '
        'emplomentDateTimePicker
        '
        Me.emplomentDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.emplomentDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emplomentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.emplomentDateTimePicker.Location = New System.Drawing.Point(535, 78)
        Me.emplomentDateTimePicker.Name = "emplomentDateTimePicker"
        Me.emplomentDateTimePicker.Size = New System.Drawing.Size(129, 26)
        Me.emplomentDateTimePicker.TabIndex = 59
        Me.emplomentDateTimePicker.Value = New Date(2016, 9, 26, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(388, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 19)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Emploment Date"
        '
        'btnStaffPic
        '
        Me.btnStaffPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffPic.ForeColor = System.Drawing.Color.Blue
        Me.btnStaffPic.Location = New System.Drawing.Point(751, 175)
        Me.btnStaffPic.Name = "btnStaffPic"
        Me.btnStaffPic.Size = New System.Drawing.Size(141, 32)
        Me.btnStaffPic.TabIndex = 61
        Me.btnStaffPic.Text = "Select Photo to Upload"
        Me.btnStaffPic.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(751, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'lblStaffNameEmpty
        '
        Me.lblStaffNameEmpty.AutoSize = True
        Me.lblStaffNameEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffNameEmpty.Location = New System.Drawing.Point(145, 31)
        Me.lblStaffNameEmpty.Name = "lblStaffNameEmpty"
        Me.lblStaffNameEmpty.Size = New System.Drawing.Size(95, 13)
        Me.lblStaffNameEmpty.TabIndex = 63
        Me.lblStaffNameEmpty.Text = "* Enter Staff Name"
        Me.lblStaffNameEmpty.Visible = False
        '
        'lblStaffICEmpty
        '
        Me.lblStaffICEmpty.AutoSize = True
        Me.lblStaffICEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffICEmpty.Location = New System.Drawing.Point(246, 72)
        Me.lblStaffICEmpty.Name = "lblStaffICEmpty"
        Me.lblStaffICEmpty.Size = New System.Drawing.Size(99, 13)
        Me.lblStaffICEmpty.TabIndex = 64
        Me.lblStaffICEmpty.Text = "* Enter Staff I/C No"
        Me.lblStaffICEmpty.Visible = False
        '
        'lblGenderEmpty
        '
        Me.lblGenderEmpty.AutoSize = True
        Me.lblGenderEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGenderEmpty.Location = New System.Drawing.Point(322, 136)
        Me.lblGenderEmpty.Name = "lblGenderEmpty"
        Me.lblGenderEmpty.Size = New System.Drawing.Size(49, 13)
        Me.lblGenderEmpty.TabIndex = 65
        Me.lblGenderEmpty.Text = "* Gender"
        Me.lblGenderEmpty.Visible = False
        '
        'lblStaffContact
        '
        Me.lblStaffContact.AutoSize = True
        Me.lblStaffContact.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffContact.Location = New System.Drawing.Point(246, 218)
        Me.lblStaffContact.Name = "lblStaffContact"
        Me.lblStaffContact.Size = New System.Drawing.Size(96, 13)
        Me.lblStaffContact.TabIndex = 66
        Me.lblStaffContact.Text = "* Enter Contact No"
        Me.lblStaffContact.Visible = False
        '
        'txtStaffContact
        '
        Me.txtStaffContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffContact.Location = New System.Drawing.Point(140, 212)
        Me.txtStaffContact.Mask = "000-00000000"
        Me.txtStaffContact.Name = "txtStaffContact"
        Me.txtStaffContact.Size = New System.Drawing.Size(100, 22)
        Me.txtStaffContact.TabIndex = 67
        '
        'lblPositionEmpty
        '
        Me.lblPositionEmpty.AutoSize = True
        Me.lblPositionEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPositionEmpty.Location = New System.Drawing.Point(275, 292)
        Me.lblPositionEmpty.Name = "lblPositionEmpty"
        Me.lblPositionEmpty.Size = New System.Drawing.Size(79, 13)
        Me.lblPositionEmpty.TabIndex = 68
        Me.lblPositionEmpty.Text = "* Enter Position"
        Me.lblPositionEmpty.Visible = False
        '
        'lblStaffEmailFormatError
        '
        Me.lblStaffEmailFormatError.AutoSize = True
        Me.lblStaffEmailFormatError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffEmailFormatError.Location = New System.Drawing.Point(686, 221)
        Me.lblStaffEmailFormatError.Name = "lblStaffEmailFormatError"
        Me.lblStaffEmailFormatError.Size = New System.Drawing.Size(92, 13)
        Me.lblStaffEmailFormatError.TabIndex = 69
        Me.lblStaffEmailFormatError.Text = "Email Format Error"
        Me.lblStaffEmailFormatError.Visible = False
        '
        'lblStaffRaceEmpty
        '
        Me.lblStaffRaceEmpty.AutoSize = True
        Me.lblStaffRaceEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffRaceEmpty.Location = New System.Drawing.Point(670, 139)
        Me.lblStaffRaceEmpty.Name = "lblStaffRaceEmpty"
        Me.lblStaffRaceEmpty.Size = New System.Drawing.Size(40, 13)
        Me.lblStaffRaceEmpty.TabIndex = 70
        Me.lblStaffRaceEmpty.Text = "* Race"
        Me.lblStaffRaceEmpty.Visible = False
        '
        'lblPasswordEmpty
        '
        Me.lblPasswordEmpty.AutoSize = True
        Me.lblPasswordEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPasswordEmpty.Location = New System.Drawing.Point(670, 11)
        Me.lblPasswordEmpty.Name = "lblPasswordEmpty"
        Me.lblPasswordEmpty.Size = New System.Drawing.Size(60, 13)
        Me.lblPasswordEmpty.TabIndex = 71
        Me.lblPasswordEmpty.Text = "* Password"
        Me.lblPasswordEmpty.Visible = False
        '
        'lblStaffAddressEmpty
        '
        Me.lblStaffAddressEmpty.AutoSize = True
        Me.lblStaffAddressEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStaffAddressEmpty.Location = New System.Drawing.Point(686, 401)
        Me.lblStaffAddressEmpty.Name = "lblStaffAddressEmpty"
        Me.lblStaffAddressEmpty.Size = New System.Drawing.Size(105, 13)
        Me.lblStaffAddressEmpty.TabIndex = 72
        Me.lblStaffAddressEmpty.Text = "* Enter Staff Address"
        Me.lblStaffAddressEmpty.Visible = False
        '
        'StaffInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.lblStaffAddressEmpty)
        Me.Controls.Add(Me.lblPasswordEmpty)
        Me.Controls.Add(Me.lblStaffRaceEmpty)
        Me.Controls.Add(Me.lblStaffEmailFormatError)
        Me.Controls.Add(Me.lblPositionEmpty)
        Me.Controls.Add(Me.txtStaffContact)
        Me.Controls.Add(Me.lblStaffContact)
        Me.Controls.Add(Me.lblGenderEmpty)
        Me.Controls.Add(Me.lblStaffICEmpty)
        Me.Controls.Add(Me.lblStaffNameEmpty)
        Me.Controls.Add(Me.btnStaffPic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.emplomentDateTimePicker)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtstaffStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStaffAddress)
        Me.Controls.Add(Me.txtstaffEmailAddress)
        Me.Controls.Add(Me.cboStaffRace)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.mskStaffIc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "StaffInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Staff Insert Form"
        Me.gender.ResumeLayout(False)
        Me.gender.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gender As System.Windows.Forms.GroupBox
    Friend WithEvents rbStaffMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbStaffFemale As System.Windows.Forms.RadioButton
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtStaffAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtstaffEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboStaffRace As System.Windows.Forms.ComboBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents mskStaffIc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstaffStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents emplomentDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnStaffPic As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStaffNameEmpty As System.Windows.Forms.Label
    Friend WithEvents lblStaffICEmpty As System.Windows.Forms.Label
    Friend WithEvents lblGenderEmpty As System.Windows.Forms.Label
    Friend WithEvents lblStaffContact As System.Windows.Forms.Label
    Friend WithEvents txtStaffContact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPositionEmpty As System.Windows.Forms.Label
    Friend WithEvents lblStaffEmailFormatError As System.Windows.Forms.Label
    Friend WithEvents lblStaffRaceEmpty As System.Windows.Forms.Label
    Friend WithEvents lblPasswordEmpty As System.Windows.Forms.Label
    Friend WithEvents lblStaffAddressEmpty As System.Windows.Forms.Label
End Class
