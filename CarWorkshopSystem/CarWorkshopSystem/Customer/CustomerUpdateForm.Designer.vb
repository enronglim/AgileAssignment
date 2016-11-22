<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerUpdateForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskCustomerIc = New System.Windows.Forms.MaskedTextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.rbCustomerFemale = New System.Windows.Forms.RadioButton()
        Me.rbCustomerMale = New System.Windows.Forms.RadioButton()
        Me.cboCustomerRace = New System.Windows.Forms.ComboBox()
        Me.txtcustomerEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerPassportNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCustomerStatus = New System.Windows.Forms.ComboBox()
        Me.txtCustomerContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblRaceEmpty = New System.Windows.Forms.Label()
        Me.lblAddressEmpty = New System.Windows.Forms.Label()
        Me.lblContactEmpty = New System.Windows.Forms.Label()
        Me.lblGenderEmpty = New System.Windows.Forms.Label()
        Me.lblCustomerNameEmpty = New System.Windows.Forms.Label()
        Me.lblEmailFormatError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name     "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer I/C No     "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender                       "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Passport No             "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(398, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "E-Mail Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(398, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Race"
        '
        'mskCustomerIc
        '
        Me.mskCustomerIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustomerIc.Location = New System.Drawing.Point(160, 50)
        Me.mskCustomerIc.Mask = "000000-00-0000"
        Me.mskCustomerIc.Name = "mskCustomerIc"
        Me.mskCustomerIc.Size = New System.Drawing.Size(100, 22)
        Me.mskCustomerIc.TabIndex = 2
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(160, 10)
        Me.txtCustomerName.MaxLength = 30
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 22)
        Me.txtCustomerName.TabIndex = 1
        '
        'rbCustomerFemale
        '
        Me.rbCustomerFemale.AutoSize = True
        Me.rbCustomerFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomerFemale.ForeColor = System.Drawing.Color.Black
        Me.rbCustomerFemale.Location = New System.Drawing.Point(222, 99)
        Me.rbCustomerFemale.Name = "rbCustomerFemale"
        Me.rbCustomerFemale.Size = New System.Drawing.Size(80, 24)
        Me.rbCustomerFemale.TabIndex = 4
        Me.rbCustomerFemale.Tag = ""
        Me.rbCustomerFemale.Text = "Female"
        Me.rbCustomerFemale.UseVisualStyleBackColor = True
        '
        'rbCustomerMale
        '
        Me.rbCustomerMale.AutoSize = True
        Me.rbCustomerMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomerMale.ForeColor = System.Drawing.Color.Black
        Me.rbCustomerMale.Location = New System.Drawing.Point(160, 99)
        Me.rbCustomerMale.Name = "rbCustomerMale"
        Me.rbCustomerMale.Size = New System.Drawing.Size(61, 24)
        Me.rbCustomerMale.TabIndex = 3
        Me.rbCustomerMale.Tag = ""
        Me.rbCustomerMale.Text = "Male"
        Me.rbCustomerMale.UseVisualStyleBackColor = True
        '
        'cboCustomerRace
        '
        Me.cboCustomerRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerRace.FormattingEnabled = True
        Me.cboCustomerRace.Items.AddRange(New Object() {"Chinese", "Malays", "Indian", "Others"})
        Me.cboCustomerRace.Location = New System.Drawing.Point(526, 98)
        Me.cboCustomerRace.Name = "cboCustomerRace"
        Me.cboCustomerRace.Size = New System.Drawing.Size(129, 28)
        Me.cboCustomerRace.TabIndex = 5
        '
        'txtcustomerEmailAddress
        '
        Me.txtcustomerEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomerEmailAddress.Location = New System.Drawing.Point(526, 158)
        Me.txtcustomerEmailAddress.MaxLength = 35
        Me.txtcustomerEmailAddress.Name = "txtcustomerEmailAddress"
        Me.txtcustomerEmailAddress.Size = New System.Drawing.Size(174, 22)
        Me.txtcustomerEmailAddress.TabIndex = 7
        '
        'txtCustomerPassportNo
        '
        Me.txtCustomerPassportNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPassportNo.Location = New System.Drawing.Point(160, 208)
        Me.txtCustomerPassportNo.MaxLength = 20
        Me.txtCustomerPassportNo.Name = "txtCustomerPassportNo"
        Me.txtCustomerPassportNo.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPassportNo.TabIndex = 8
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(160, 261)
        Me.txtCustomerAddress.MaxLength = 50
        Me.txtCustomerAddress.Multiline = True
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(540, 72)
        Me.txtCustomerAddress.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(614, 379)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(491, 379)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(86, 29)
        Me.btnChange.TabIndex = 13
        Me.btnChange.Text = "Save"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(398, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Status"
        '
        'cboCustomerStatus
        '
        Me.cboCustomerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerStatus.FormattingEnabled = True
        Me.cboCustomerStatus.Items.AddRange(New Object() {"Available", "Banned"})
        Me.cboCustomerStatus.Location = New System.Drawing.Point(526, 209)
        Me.cboCustomerStatus.Name = "cboCustomerStatus"
        Me.cboCustomerStatus.Size = New System.Drawing.Size(129, 28)
        Me.cboCustomerStatus.TabIndex = 84
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerContact.Location = New System.Drawing.Point(160, 155)
        Me.txtCustomerContact.Mask = "000-00000000"
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerContact.TabIndex = 85
        '
        'lblRaceEmpty
        '
        Me.lblRaceEmpty.AutoSize = True
        Me.lblRaceEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRaceEmpty.Location = New System.Drawing.Point(661, 107)
        Me.lblRaceEmpty.Name = "lblRaceEmpty"
        Me.lblRaceEmpty.Size = New System.Drawing.Size(40, 13)
        Me.lblRaceEmpty.TabIndex = 91
        Me.lblRaceEmpty.Text = "* Race"
        Me.lblRaceEmpty.Visible = False
        '
        'lblAddressEmpty
        '
        Me.lblAddressEmpty.AutoSize = True
        Me.lblAddressEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAddressEmpty.Location = New System.Drawing.Point(706, 288)
        Me.lblAddressEmpty.Name = "lblAddressEmpty"
        Me.lblAddressEmpty.Size = New System.Drawing.Size(127, 13)
        Me.lblAddressEmpty.TabIndex = 90
        Me.lblAddressEmpty.Text = "* Enter Customer Address"
        Me.lblAddressEmpty.Visible = False
        '
        'lblContactEmpty
        '
        Me.lblContactEmpty.AutoSize = True
        Me.lblContactEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContactEmpty.Location = New System.Drawing.Point(266, 160)
        Me.lblContactEmpty.Name = "lblContactEmpty"
        Me.lblContactEmpty.Size = New System.Drawing.Size(96, 13)
        Me.lblContactEmpty.TabIndex = 89
        Me.lblContactEmpty.Text = "* Enter Contact No"
        Me.lblContactEmpty.Visible = False
        '
        'lblGenderEmpty
        '
        Me.lblGenderEmpty.AutoSize = True
        Me.lblGenderEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGenderEmpty.Location = New System.Drawing.Point(319, 107)
        Me.lblGenderEmpty.Name = "lblGenderEmpty"
        Me.lblGenderEmpty.Size = New System.Drawing.Size(49, 13)
        Me.lblGenderEmpty.TabIndex = 88
        Me.lblGenderEmpty.Text = "* Gender"
        Me.lblGenderEmpty.Visible = False
        '
        'lblCustomerNameEmpty
        '
        Me.lblCustomerNameEmpty.AutoSize = True
        Me.lblCustomerNameEmpty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCustomerNameEmpty.Location = New System.Drawing.Point(374, 17)
        Me.lblCustomerNameEmpty.Name = "lblCustomerNameEmpty"
        Me.lblCustomerNameEmpty.Size = New System.Drawing.Size(117, 13)
        Me.lblCustomerNameEmpty.TabIndex = 87
        Me.lblCustomerNameEmpty.Text = "* Enter Customer Name"
        Me.lblCustomerNameEmpty.Visible = False
        '
        'lblEmailFormatError
        '
        Me.lblEmailFormatError.AutoSize = True
        Me.lblEmailFormatError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEmailFormatError.Location = New System.Drawing.Point(706, 163)
        Me.lblEmailFormatError.Name = "lblEmailFormatError"
        Me.lblEmailFormatError.Size = New System.Drawing.Size(92, 13)
        Me.lblEmailFormatError.TabIndex = 86
        Me.lblEmailFormatError.Text = "Email Format Error"
        Me.lblEmailFormatError.Visible = False
        '
        'CustomerUpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.lblRaceEmpty)
        Me.Controls.Add(Me.lblAddressEmpty)
        Me.Controls.Add(Me.lblContactEmpty)
        Me.Controls.Add(Me.lblGenderEmpty)
        Me.Controls.Add(Me.lblCustomerNameEmpty)
        Me.Controls.Add(Me.lblEmailFormatError)
        Me.Controls.Add(Me.txtCustomerContact)
        Me.Controls.Add(Me.cboCustomerStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerPassportNo)
        Me.Controls.Add(Me.txtcustomerEmailAddress)
        Me.Controls.Add(Me.cboCustomerRace)
        Me.Controls.Add(Me.rbCustomerFemale)
        Me.Controls.Add(Me.rbCustomerMale)
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
        Me.Name = "CustomerUpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Customer Update Detail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mskCustomerIc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents rbCustomerFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbCustomerMale As System.Windows.Forms.RadioButton
    Friend WithEvents cboCustomerRace As System.Windows.Forms.ComboBox
    Friend WithEvents txtcustomerEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerPassportNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCustomerStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerContact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblRaceEmpty As System.Windows.Forms.Label
    Friend WithEvents lblAddressEmpty As System.Windows.Forms.Label
    Friend WithEvents lblContactEmpty As System.Windows.Forms.Label
    Friend WithEvents lblGenderEmpty As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNameEmpty As System.Windows.Forms.Label
    Friend WithEvents lblEmailFormatError As System.Windows.Forms.Label
End Class
