<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInsertForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerPassportNo = New System.Windows.Forms.TextBox()
        Me.txtcustomerEmailAddress = New System.Windows.Forms.TextBox()
        Me.cboCustomerRace = New System.Windows.Forms.ComboBox()
        Me.rbCustomerFemale = New System.Windows.Forms.RadioButton()
        Me.rbCustomerMale = New System.Windows.Forms.RadioButton()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.mskCustomerIc = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.gender = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustomerContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmailFormatError = New System.Windows.Forms.Label()
        Me.lblCustomerNameEmpty = New System.Windows.Forms.Label()
        Me.lblCustomerICEmpty = New System.Windows.Forms.Label()
        Me.lblGenderEmpty = New System.Windows.Forms.Label()
        Me.lblContactEmpty = New System.Windows.Forms.Label()
        Me.lblAddressEmpty = New System.Windows.Forms.Label()
        Me.lblRaceEmpty = New System.Windows.Forms.Label()
        Me.gender.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(613, 375)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(490, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 29)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(159, 257)
        Me.txtCustomerAddress.MaxLength = 50
        Me.txtCustomerAddress.Multiline = True
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(540, 72)
        Me.txtCustomerAddress.TabIndex = 31
        '
        'txtCustomerPassportNo
        '
        Me.txtCustomerPassportNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPassportNo.Location = New System.Drawing.Point(159, 204)
        Me.txtCustomerPassportNo.MaxLength = 20
        Me.txtCustomerPassportNo.Name = "txtCustomerPassportNo"
        Me.txtCustomerPassportNo.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPassportNo.TabIndex = 30
        '
        'txtcustomerEmailAddress
        '
        Me.txtcustomerEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomerEmailAddress.Location = New System.Drawing.Point(525, 154)
        Me.txtcustomerEmailAddress.MaxLength = 35
        Me.txtcustomerEmailAddress.Name = "txtcustomerEmailAddress"
        Me.txtcustomerEmailAddress.Size = New System.Drawing.Size(174, 22)
        Me.txtcustomerEmailAddress.TabIndex = 28
        '
        'cboCustomerRace
        '
        Me.cboCustomerRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerRace.FormattingEnabled = True
        Me.cboCustomerRace.Items.AddRange(New Object() {"Chinese", "Malays", "Indian", "Others"})
        Me.cboCustomerRace.Location = New System.Drawing.Point(525, 94)
        Me.cboCustomerRace.Name = "cboCustomerRace"
        Me.cboCustomerRace.Size = New System.Drawing.Size(129, 28)
        Me.cboCustomerRace.TabIndex = 24
        '
        'rbCustomerFemale
        '
        Me.rbCustomerFemale.AutoSize = True
        Me.rbCustomerFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomerFemale.ForeColor = System.Drawing.Color.Black
        Me.rbCustomerFemale.Location = New System.Drawing.Point(81, 11)
        Me.rbCustomerFemale.Name = "rbCustomerFemale"
        Me.rbCustomerFemale.Size = New System.Drawing.Size(80, 24)
        Me.rbCustomerFemale.TabIndex = 22
        Me.rbCustomerFemale.Tag = ""
        Me.rbCustomerFemale.Text = "Female"
        Me.rbCustomerFemale.UseVisualStyleBackColor = True
        '
        'rbCustomerMale
        '
        Me.rbCustomerMale.AutoSize = True
        Me.rbCustomerMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomerMale.ForeColor = System.Drawing.Color.Black
        Me.rbCustomerMale.Location = New System.Drawing.Point(19, 11)
        Me.rbCustomerMale.Name = "rbCustomerMale"
        Me.rbCustomerMale.Size = New System.Drawing.Size(61, 24)
        Me.rbCustomerMale.TabIndex = 20
        Me.rbCustomerMale.Tag = ""
        Me.rbCustomerMale.Text = "Male"
        Me.rbCustomerMale.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(159, 6)
        Me.txtCustomerName.MaxLength = 30
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 22)
        Me.txtCustomerName.TabIndex = 17
        '
        'mskCustomerIc
        '
        Me.mskCustomerIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustomerIc.Location = New System.Drawing.Point(159, 46)
        Me.mskCustomerIc.Mask = "000000-00-0000"
        Me.mskCustomerIc.Name = "mskCustomerIc"
        Me.mskCustomerIc.Size = New System.Drawing.Size(100, 22)
        Me.mskCustomerIc.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(397, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Race"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(397, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "E-Mail Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Contact No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Address "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Passport No             "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Gender                       "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Customer I/C No     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Customer Name     "
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(382, 375)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(86, 29)
        Me.BtnReset.TabIndex = 34
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'gender
        '
        Me.gender.Controls.Add(Me.rbCustomerMale)
        Me.gender.Controls.Add(Me.rbCustomerFemale)
        Me.gender.Location = New System.Drawing.Point(159, 81)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(176, 41)
        Me.gender.TabIndex = 35
        Me.gender.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(544, 206)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(100, 22)
        Me.txtStatus.TabIndex = 59
        Me.txtStatus.Text = "Available"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(397, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Status"
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerContact.Location = New System.Drawing.Point(159, 141)
        Me.txtCustomerContact.Mask = "000-00000000"
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerContact.TabIndex = 60
        '
        'lblEmailFormatError
        '
        Me.lblEmailFormatError.AutoSize = True
        Me.lblEmailFormatError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEmailFormatError.Location = New System.Drawing.Point(705, 163)
        Me.lblEmailFormatError.Name = "lblEmailFormatError"
        Me.lblEmailFormatError.Size = New System.Drawing.Size(92, 13)
        Me.lblEmailFormatError.TabIndex = 61
        Me.lblEmailFormatError.Text = "Email Format Error"
        Me.lblEmailFormatError.Visible = False
        '
        'lblCustomerNameEmpty
        '
        Me.lblCustomerNameEmpty.AutoSize = True
        Me.lblCustomerNameEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCustomerNameEmpty.Location = New System.Drawing.Point(373, 13)
        Me.lblCustomerNameEmpty.Name = "lblCustomerNameEmpty"
        Me.lblCustomerNameEmpty.Size = New System.Drawing.Size(117, 13)
        Me.lblCustomerNameEmpty.TabIndex = 62
        Me.lblCustomerNameEmpty.Text = "* Enter Customer Name"
        Me.lblCustomerNameEmpty.Visible = False
        '
        'lblCustomerICEmpty
        '
        Me.lblCustomerICEmpty.AutoSize = True
        Me.lblCustomerICEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCustomerICEmpty.Location = New System.Drawing.Point(265, 50)
        Me.lblCustomerICEmpty.Name = "lblCustomerICEmpty"
        Me.lblCustomerICEmpty.Size = New System.Drawing.Size(121, 13)
        Me.lblCustomerICEmpty.TabIndex = 63
        Me.lblCustomerICEmpty.Text = "* Enter Customer I/C No"
        Me.lblCustomerICEmpty.Visible = False
        '
        'lblGenderEmpty
        '
        Me.lblGenderEmpty.AutoSize = True
        Me.lblGenderEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGenderEmpty.Location = New System.Drawing.Point(342, 99)
        Me.lblGenderEmpty.Name = "lblGenderEmpty"
        Me.lblGenderEmpty.Size = New System.Drawing.Size(49, 13)
        Me.lblGenderEmpty.TabIndex = 64
        Me.lblGenderEmpty.Text = "* Gender"
        Me.lblGenderEmpty.Visible = False
        '
        'lblContactEmpty
        '
        Me.lblContactEmpty.AutoSize = True
        Me.lblContactEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContactEmpty.Location = New System.Drawing.Point(265, 146)
        Me.lblContactEmpty.Name = "lblContactEmpty"
        Me.lblContactEmpty.Size = New System.Drawing.Size(96, 13)
        Me.lblContactEmpty.TabIndex = 65
        Me.lblContactEmpty.Text = "* Enter Contact No"
        Me.lblContactEmpty.Visible = False
        '
        'lblAddressEmpty
        '
        Me.lblAddressEmpty.AutoSize = True
        Me.lblAddressEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAddressEmpty.Location = New System.Drawing.Point(705, 284)
        Me.lblAddressEmpty.Name = "lblAddressEmpty"
        Me.lblAddressEmpty.Size = New System.Drawing.Size(127, 13)
        Me.lblAddressEmpty.TabIndex = 66
        Me.lblAddressEmpty.Text = "* Enter Customer Address"
        Me.lblAddressEmpty.Visible = False
        '
        'lblRaceEmpty
        '
        Me.lblRaceEmpty.AutoSize = True
        Me.lblRaceEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRaceEmpty.Location = New System.Drawing.Point(660, 103)
        Me.lblRaceEmpty.Name = "lblRaceEmpty"
        Me.lblRaceEmpty.Size = New System.Drawing.Size(40, 13)
        Me.lblRaceEmpty.TabIndex = 67
        Me.lblRaceEmpty.Text = "* Race"
        Me.lblRaceEmpty.Visible = False
        '
        'CustomerInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.lblRaceEmpty)
        Me.Controls.Add(Me.lblAddressEmpty)
        Me.Controls.Add(Me.lblContactEmpty)
        Me.Controls.Add(Me.lblGenderEmpty)
        Me.Controls.Add(Me.lblCustomerICEmpty)
        Me.Controls.Add(Me.lblCustomerNameEmpty)
        Me.Controls.Add(Me.lblEmailFormatError)
        Me.Controls.Add(Me.txtCustomerContact)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerPassportNo)
        Me.Controls.Add(Me.txtcustomerEmailAddress)
        Me.Controls.Add(Me.cboCustomerRace)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.mskCustomerIc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "CustomerInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Customer Insert Form"
        Me.gender.ResumeLayout(False)
        Me.gender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerPassportNo As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboCustomerRace As System.Windows.Forms.ComboBox
    Friend WithEvents rbCustomerFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbCustomerMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents mskCustomerIc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents gender As System.Windows.Forms.GroupBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerContact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEmailFormatError As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNameEmpty As System.Windows.Forms.Label
    Friend WithEvents lblCustomerICEmpty As System.Windows.Forms.Label
    Friend WithEvents lblGenderEmpty As System.Windows.Forms.Label
    Friend WithEvents lblContactEmpty As System.Windows.Forms.Label
    Friend WithEvents lblAddressEmpty As System.Windows.Forms.Label
    Friend WithEvents lblRaceEmpty As System.Windows.Forms.Label
End Class
