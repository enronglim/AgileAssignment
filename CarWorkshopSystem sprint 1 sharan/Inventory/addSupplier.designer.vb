<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSupplier
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
        Me.contactTxt1 = New System.Windows.Forms.TextBox()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contactTxt2 = New System.Windows.Forms.TextBox()
        Me.addressBox = New System.Windows.Forms.RichTextBox()
        Me.verifyName = New System.Windows.Forms.Label()
        Me.verifyContact = New System.Windows.Forms.Label()
        Me.verifyAddress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'contactTxt1
        '
        Me.contactTxt1.Location = New System.Drawing.Point(101, 134)
        Me.contactTxt1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt1.MaxLength = 3
        Me.contactTxt1.Name = "contactTxt1"
        Me.contactTxt1.Size = New System.Drawing.Size(38, 20)
        Me.contactTxt1.TabIndex = 29
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(101, 110)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(145, 20)
        Me.nameTxt.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Supplier Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 27)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Supplier Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Supplier Contact:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Supplier Name:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(101, 86)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(75, 14)
        Me.idLabel.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Supplier ID:"
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(371, 266)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 21
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(310, 266)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(56, 19)
        Me.clearBtn.TabIndex = 20
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(250, 266)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(56, 19)
        Me.addBtn.TabIndex = 19
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "-"
        '
        'contactTxt2
        '
        Me.contactTxt2.Location = New System.Drawing.Point(157, 134)
        Me.contactTxt2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.contactTxt2.MaxLength = 8
        Me.contactTxt2.Name = "contactTxt2"
        Me.contactTxt2.Size = New System.Drawing.Size(90, 20)
        Me.contactTxt2.TabIndex = 32
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(101, 160)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addressBox.MaxLength = 50
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(145, 87)
        Me.addressBox.TabIndex = 33
        Me.addressBox.Text = ""
        '
        'verifyName
        '
        Me.verifyName.ForeColor = System.Drawing.Color.Red
        Me.verifyName.Location = New System.Drawing.Point(250, 109)
        Me.verifyName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyName.Name = "verifyName"
        Me.verifyName.Size = New System.Drawing.Size(117, 19)
        Me.verifyName.TabIndex = 65
        '
        'verifyContact
        '
        Me.verifyContact.ForeColor = System.Drawing.Color.Red
        Me.verifyContact.Location = New System.Drawing.Point(250, 134)
        Me.verifyContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyContact.Name = "verifyContact"
        Me.verifyContact.Size = New System.Drawing.Size(117, 19)
        Me.verifyContact.TabIndex = 66
        '
        'verifyAddress
        '
        Me.verifyAddress.ForeColor = System.Drawing.Color.Red
        Me.verifyAddress.Location = New System.Drawing.Point(250, 160)
        Me.verifyAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyAddress.Name = "verifyAddress"
        Me.verifyAddress.Size = New System.Drawing.Size(117, 19)
        Me.verifyAddress.TabIndex = 67
        '
        'addSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 305)
        Me.Controls.Add(Me.verifyAddress)
        Me.Controls.Add(Me.verifyContact)
        Me.Controls.Add(Me.verifyName)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.contactTxt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.contactTxt1)
        Me.Controls.Add(Me.nameTxt)
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
        Me.Name = "addSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contactTxt1 As System.Windows.Forms.TextBox
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents contactTxt2 As System.Windows.Forms.TextBox
    Friend WithEvents addressBox As System.Windows.Forms.RichTextBox
    Friend WithEvents verifyName As System.Windows.Forms.Label
    Friend WithEvents verifyContact As System.Windows.Forms.Label
    Friend WithEvents verifyAddress As System.Windows.Forms.Label
End Class
