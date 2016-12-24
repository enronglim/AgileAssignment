<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateSupplier
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.verifyAddress = New System.Windows.Forms.Label()
        Me.verifyContact = New System.Windows.Forms.Label()
        Me.verifyName = New System.Windows.Forms.Label()
        Me.addressBox = New System.Windows.Forms.RichTextBox()
        Me.contactTxt2 = New System.Windows.Forms.TextBox()
        Me.contactTxt1 = New System.Windows.Forms.TextBox()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 169)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Supplier Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 27)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Update Supplier Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Supplier Contact:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Supplier Name:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(165, 95)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(75, 14)
        Me.idLabel.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Supplier ID:"
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(435, 275)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 36
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(374, 275)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(56, 19)
        Me.resetBtn.TabIndex = 35
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(314, 275)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(56, 19)
        Me.updateBtn.TabIndex = 34
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'verifyAddress
        '
        Me.verifyAddress.ForeColor = System.Drawing.Color.Red
        Me.verifyAddress.Location = New System.Drawing.Point(314, 169)
        Me.verifyAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyAddress.Name = "verifyAddress"
        Me.verifyAddress.Size = New System.Drawing.Size(117, 19)
        Me.verifyAddress.TabIndex = 70
        '
        'verifyContact
        '
        Me.verifyContact.ForeColor = System.Drawing.Color.Red
        Me.verifyContact.Location = New System.Drawing.Point(314, 143)
        Me.verifyContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyContact.Name = "verifyContact"
        Me.verifyContact.Size = New System.Drawing.Size(117, 19)
        Me.verifyContact.TabIndex = 69
        '
        'verifyName
        '
        Me.verifyName.ForeColor = System.Drawing.Color.Red
        Me.verifyName.Location = New System.Drawing.Point(314, 118)
        Me.verifyName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyName.Name = "verifyName"
        Me.verifyName.Size = New System.Drawing.Size(117, 19)
        Me.verifyName.TabIndex = 68
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(165, 169)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addressBox.MaxLength = 50
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(145, 87)
        Me.addressBox.TabIndex = 74
        Me.addressBox.Text = ""
        '
        'contactTxt2
        '
        Me.contactTxt2.Location = New System.Drawing.Point(220, 143)
        Me.contactTxt2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt2.MaxLength = 8
        Me.contactTxt2.Name = "contactTxt2"
        Me.contactTxt2.Size = New System.Drawing.Size(90, 20)
        Me.contactTxt2.TabIndex = 73
        '
        'contactTxt1
        '
        Me.contactTxt1.Location = New System.Drawing.Point(165, 143)
        Me.contactTxt1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt1.MaxLength = 3
        Me.contactTxt1.Name = "contactTxt1"
        Me.contactTxt1.Size = New System.Drawing.Size(38, 20)
        Me.contactTxt1.TabIndex = 72
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(165, 119)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(145, 20)
        Me.nameTxt.TabIndex = 71
        '
        'updateSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 323)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.contactTxt2)
        Me.Controls.Add(Me.contactTxt1)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.verifyAddress)
        Me.Controls.Add(Me.verifyContact)
        Me.Controls.Add(Me.verifyName)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "updateSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Update Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents verifyAddress As System.Windows.Forms.Label
    Friend WithEvents verifyContact As System.Windows.Forms.Label
    Friend WithEvents verifyName As System.Windows.Forms.Label
    Friend WithEvents addressBox As System.Windows.Forms.RichTextBox
    Friend WithEvents contactTxt2 As System.Windows.Forms.TextBox
    Friend WithEvents contactTxt1 As System.Windows.Forms.TextBox
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
End Class
