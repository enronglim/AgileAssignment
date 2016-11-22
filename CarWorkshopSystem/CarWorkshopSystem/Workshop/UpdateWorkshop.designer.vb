<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateWorkshop
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
        Me.contactTxt2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.contactTxt1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addressBox = New System.Windows.Forms.RichTextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.registrationTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.odTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stateTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.statusCombo = New System.Windows.Forms.ComboBox()
        Me.verifyEmail = New System.Windows.Forms.Label()
        Me.verifyContact = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'contactTxt2
        '
        Me.contactTxt2.Location = New System.Drawing.Point(155, 264)
        Me.contactTxt2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt2.MaxLength = 8
        Me.contactTxt2.Name = "contactTxt2"
        Me.contactTxt2.Size = New System.Drawing.Size(72, 20)
        Me.contactTxt2.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(141, 264)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "-"
        '
        'contactTxt1
        '
        Me.contactTxt1.Location = New System.Drawing.Point(110, 264)
        Me.contactTxt1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt1.MaxLength = 3
        Me.contactTxt1.Name = "contactTxt1"
        Me.contactTxt1.Size = New System.Drawing.Size(28, 20)
        Me.contactTxt1.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Contact:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "State:"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(110, 166)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.ReadOnly = True
        Me.addressBox.Size = New System.Drawing.Size(169, 85)
        Me.addressBox.TabIndex = 48
        Me.addressBox.Text = ""
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(110, 111)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.emailTxt.MaxLength = 40
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(168, 20)
        Me.emailTxt.TabIndex = 47
        '
        'registrationTxt
        '
        Me.registrationTxt.Location = New System.Drawing.Point(110, 84)
        Me.registrationTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.registrationTxt.Name = "registrationTxt"
        Me.registrationTxt.ReadOnly = True
        Me.registrationTxt.Size = New System.Drawing.Size(145, 20)
        Me.registrationTxt.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 166)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 27)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Update Workshop Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Registration No:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(110, 59)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(84, 14)
        Me.idLabel.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Workshop ID:"
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(424, 377)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 39
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(363, 377)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(56, 19)
        Me.resetBtn.TabIndex = 38
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(302, 377)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(56, 20)
        Me.updateBtn.TabIndex = 37
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'odTxt
        '
        Me.odTxt.Location = New System.Drawing.Point(110, 296)
        Me.odTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.odTxt.Name = "odTxt"
        Me.odTxt.ReadOnly = True
        Me.odTxt.Size = New System.Drawing.Size(107, 20)
        Me.odTxt.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 298)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Opening Date:"
        '
        'stateTxt
        '
        Me.stateTxt.Location = New System.Drawing.Point(109, 136)
        Me.stateTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stateTxt.Name = "stateTxt"
        Me.stateTxt.ReadOnly = True
        Me.stateTxt.Size = New System.Drawing.Size(107, 20)
        Me.stateTxt.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 330)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Status"
        '
        'statusCombo
        '
        Me.statusCombo.FormattingEnabled = True
        Me.statusCombo.Items.AddRange(New Object() {"Operational", "Ceased"})
        Me.statusCombo.Location = New System.Drawing.Point(110, 327)
        Me.statusCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.statusCombo.Name = "statusCombo"
        Me.statusCombo.Size = New System.Drawing.Size(84, 21)
        Me.statusCombo.TabIndex = 59
        '
        'verifyEmail
        '
        Me.verifyEmail.ForeColor = System.Drawing.Color.Red
        Me.verifyEmail.Location = New System.Drawing.Point(281, 111)
        Me.verifyEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyEmail.Name = "verifyEmail"
        Me.verifyEmail.Size = New System.Drawing.Size(196, 19)
        Me.verifyEmail.TabIndex = 71
        '
        'verifyContact
        '
        Me.verifyContact.ForeColor = System.Drawing.Color.Red
        Me.verifyContact.Location = New System.Drawing.Point(231, 264)
        Me.verifyContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyContact.Name = "verifyContact"
        Me.verifyContact.Size = New System.Drawing.Size(178, 19)
        Me.verifyContact.TabIndex = 70
        '
        'UpdateWorkshop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 414)
        Me.Controls.Add(Me.verifyEmail)
        Me.Controls.Add(Me.verifyContact)
        Me.Controls.Add(Me.statusCombo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.stateTxt)
        Me.Controls.Add(Me.odTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.contactTxt2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.contactTxt1)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UpdateWorkshop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "UpdateWorkshop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contactTxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents contactTxt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents addressBox As System.Windows.Forms.RichTextBox
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents registrationTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents odTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents stateTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents statusCombo As System.Windows.Forms.ComboBox
    Friend WithEvents verifyEmail As System.Windows.Forms.Label
    Friend WithEvents verifyContact As System.Windows.Forms.Label
End Class
