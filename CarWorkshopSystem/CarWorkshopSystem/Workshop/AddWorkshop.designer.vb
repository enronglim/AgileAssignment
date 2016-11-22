<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWorkshop
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
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.registrationTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.addressBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stateCombo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.contactTxt1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.contactTxt2 = New System.Windows.Forms.TextBox()
        Me.arrivalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.verifyContact = New System.Windows.Forms.Label()
        Me.verifyAdd = New System.Windows.Forms.Label()
        Me.verifyEmail = New System.Windows.Forms.Label()
        Me.verifyReg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(100, 128)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.emailTxt.MaxLength = 40
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(209, 20)
        Me.emailTxt.TabIndex = 29
        '
        'registrationTxt
        '
        Me.registrationTxt.Location = New System.Drawing.Point(100, 102)
        Me.registrationTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.registrationTxt.MaxLength = 20
        Me.registrationTxt.Name = "registrationTxt"
        Me.registrationTxt.Size = New System.Drawing.Size(145, 20)
        Me.registrationTxt.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 27)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Workshop Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Registration No:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(100, 76)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(84, 14)
        Me.idLabel.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Workshop ID:"
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(430, 379)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 21
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(370, 379)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(56, 19)
        Me.clearBtn.TabIndex = 20
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(309, 379)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(56, 19)
        Me.addBtn.TabIndex = 19
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(100, 183)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addressBox.MaxLength = 50
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(169, 85)
        Me.addressBox.TabIndex = 30
        Me.addressBox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "State:"
        '
        'stateCombo
        '
        Me.stateCombo.FormattingEnabled = True
        Me.stateCombo.Items.AddRange(New Object() {"Selangor", "Sabah", "Sarawak", "Kuala Lumpur", "Pulau Pinang", "Johor", "Malacca", "Kedah", "Perak", "Pahang", "Terengganu", "Perlis", "Kelantan", "Negeri Sembilan"})
        Me.stateCombo.Location = New System.Drawing.Point(100, 154)
        Me.stateCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stateCombo.Name = "stateCombo"
        Me.stateCombo.Size = New System.Drawing.Size(134, 21)
        Me.stateCombo.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 284)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Contact:"
        '
        'contactTxt1
        '
        Me.contactTxt1.Location = New System.Drawing.Point(100, 281)
        Me.contactTxt1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt1.MaxLength = 3
        Me.contactTxt1.Name = "contactTxt1"
        Me.contactTxt1.Size = New System.Drawing.Size(31, 20)
        Me.contactTxt1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "-"
        '
        'contactTxt2
        '
        Me.contactTxt2.Location = New System.Drawing.Point(146, 281)
        Me.contactTxt2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt2.MaxLength = 8
        Me.contactTxt2.Name = "contactTxt2"
        Me.contactTxt2.Size = New System.Drawing.Size(62, 20)
        Me.contactTxt2.TabIndex = 36
        '
        'arrivalDate
        '
        Me.arrivalDate.Location = New System.Drawing.Point(100, 312)
        Me.arrivalDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.arrivalDate.Name = "arrivalDate"
        Me.arrivalDate.Size = New System.Drawing.Size(188, 20)
        Me.arrivalDate.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 312)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Opening Date:"
        '
        'verifyContact
        '
        Me.verifyContact.ForeColor = System.Drawing.Color.Red
        Me.verifyContact.Location = New System.Drawing.Point(211, 281)
        Me.verifyContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyContact.Name = "verifyContact"
        Me.verifyContact.Size = New System.Drawing.Size(178, 19)
        Me.verifyContact.TabIndex = 67
        '
        'verifyAdd
        '
        Me.verifyAdd.ForeColor = System.Drawing.Color.Red
        Me.verifyAdd.Location = New System.Drawing.Point(272, 183)
        Me.verifyAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyAdd.Name = "verifyAdd"
        Me.verifyAdd.Size = New System.Drawing.Size(236, 19)
        Me.verifyAdd.TabIndex = 68
        '
        'verifyEmail
        '
        Me.verifyEmail.ForeColor = System.Drawing.Color.Red
        Me.verifyEmail.Location = New System.Drawing.Point(312, 128)
        Me.verifyEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyEmail.Name = "verifyEmail"
        Me.verifyEmail.Size = New System.Drawing.Size(196, 19)
        Me.verifyEmail.TabIndex = 69
        '
        'verifyReg
        '
        Me.verifyReg.ForeColor = System.Drawing.Color.Red
        Me.verifyReg.Location = New System.Drawing.Point(248, 102)
        Me.verifyReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyReg.Name = "verifyReg"
        Me.verifyReg.Size = New System.Drawing.Size(238, 19)
        Me.verifyReg.TabIndex = 70
        '
        'AddWorkshop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 416)
        Me.Controls.Add(Me.verifyReg)
        Me.Controls.Add(Me.verifyEmail)
        Me.Controls.Add(Me.verifyAdd)
        Me.Controls.Add(Me.verifyContact)
        Me.Controls.Add(Me.arrivalDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.contactTxt2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.contactTxt1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stateCombo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.registrationTxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AddWorkshop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Workshop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents registrationTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents addressBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents stateCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents contactTxt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents contactTxt2 As System.Windows.Forms.TextBox
    Friend WithEvents arrivalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents verifyContact As System.Windows.Forms.Label
    Friend WithEvents verifyAdd As System.Windows.Forms.Label
    Friend WithEvents verifyEmail As System.Windows.Forms.Label
    Friend WithEvents verifyReg As System.Windows.Forms.Label
End Class
