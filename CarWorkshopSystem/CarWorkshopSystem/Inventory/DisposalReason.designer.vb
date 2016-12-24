<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisposalReason
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
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.reasonBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quantityTxt = New System.Windows.Forms.NumericUpDown()
        CType(Me.quantityTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(212, 175)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(81, 28)
        Me.cancelBtn.TabIndex = 7
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(68, 175)
        Me.submitBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(90, 28)
        Me.submitBtn.TabIndex = 6
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(10, 20)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(100, 13)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Reason for transfer:"
        '
        'reasonBox
        '
        Me.reasonBox.Location = New System.Drawing.Point(13, 45)
        Me.reasonBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.reasonBox.Name = "reasonBox"
        Me.reasonBox.Size = New System.Drawing.Size(315, 88)
        Me.reasonBox.TabIndex = 8
        Me.reasonBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantity:"
        '
        'quantityTxt
        '
        Me.quantityTxt.Location = New System.Drawing.Point(67, 140)
        Me.quantityTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.quantityTxt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.quantityTxt.Name = "quantityTxt"
        Me.quantityTxt.Size = New System.Drawing.Size(68, 20)
        Me.quantityTxt.TabIndex = 15
        '
        'DisposalReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 213)
        Me.Controls.Add(Me.quantityTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.reasonBox)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.lblMessage)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DisposalReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Reason"
        CType(Me.quantityTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents submitBtn As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents reasonBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents quantityTxt As System.Windows.Forms.NumericUpDown
End Class
