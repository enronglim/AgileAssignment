<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferDisposable
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
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.secondRadio = New System.Windows.Forms.RadioButton()
        Me.damagedRadio = New System.Windows.Forms.RadioButton()
        Me.descriptionBox = New System.Windows.Forms.RichTextBox()
        Me.priceTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quantityTxt = New System.Windows.Forms.NumericUpDown()
        CType(Me.quantityTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity:"
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(233, 177)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(81, 28)
        Me.cancelBtn.TabIndex = 9
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(96, 177)
        Me.submitBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(90, 28)
        Me.submitBtn.TabIndex = 8
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'secondRadio
        '
        Me.secondRadio.AutoSize = True
        Me.secondRadio.Location = New System.Drawing.Point(96, 20)
        Me.secondRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.secondRadio.Name = "secondRadio"
        Me.secondRadio.Size = New System.Drawing.Size(72, 17)
        Me.secondRadio.TabIndex = 10
        Me.secondRadio.TabStop = True
        Me.secondRadio.Text = "2nd Hand"
        Me.secondRadio.UseVisualStyleBackColor = True
        '
        'damagedRadio
        '
        Me.damagedRadio.AutoSize = True
        Me.damagedRadio.Location = New System.Drawing.Point(183, 20)
        Me.damagedRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.damagedRadio.Name = "damagedRadio"
        Me.damagedRadio.Size = New System.Drawing.Size(71, 17)
        Me.damagedRadio.TabIndex = 11
        Me.damagedRadio.TabStop = True
        Me.damagedRadio.Text = "Damaged"
        Me.damagedRadio.UseVisualStyleBackColor = True
        '
        'descriptionBox
        '
        Me.descriptionBox.Location = New System.Drawing.Point(96, 54)
        Me.descriptionBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(156, 67)
        Me.descriptionBox.TabIndex = 12
        Me.descriptionBox.Text = ""
        '
        'priceTxt
        '
        Me.priceTxt.Location = New System.Drawing.Point(96, 132)
        Me.priceTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.priceTxt.Name = "priceTxt"
        Me.priceTxt.Size = New System.Drawing.Size(69, 20)
        Me.priceTxt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Price:"
        '
        'quantityTxt
        '
        Me.quantityTxt.Location = New System.Drawing.Point(233, 135)
        Me.quantityTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.quantityTxt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.quantityTxt.Name = "quantityTxt"
        Me.quantityTxt.Size = New System.Drawing.Size(68, 20)
        Me.quantityTxt.TabIndex = 16
        '
        'TransferDisposable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 218)
        Me.Controls.Add(Me.quantityTxt)
        Me.Controls.Add(Me.priceTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.descriptionBox)
        Me.Controls.Add(Me.damagedRadio)
        Me.Controls.Add(Me.secondRadio)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferDisposable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer To Disposable"
        CType(Me.quantityTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents submitBtn As System.Windows.Forms.Button
    Friend WithEvents secondRadio As System.Windows.Forms.RadioButton
    Friend WithEvents damagedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents descriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents priceTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents quantityTxt As System.Windows.Forms.NumericUpDown
End Class
