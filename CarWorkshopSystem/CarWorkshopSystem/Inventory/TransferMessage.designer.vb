<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferMessage
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.disposeBtn = New System.Windows.Forms.Button()
        Me.binBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(9, 31)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(60, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "lblMessage"
        '
        'disposeBtn
        '
        Me.disposeBtn.Location = New System.Drawing.Point(35, 98)
        Me.disposeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.disposeBtn.Name = "disposeBtn"
        Me.disposeBtn.Size = New System.Drawing.Size(100, 28)
        Me.disposeBtn.TabIndex = 1
        Me.disposeBtn.Text = "Disposable Stock"
        Me.disposeBtn.UseVisualStyleBackColor = True
        '
        'binBtn
        '
        Me.binBtn.Location = New System.Drawing.Point(152, 98)
        Me.binBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.binBtn.Name = "binBtn"
        Me.binBtn.Size = New System.Drawing.Size(90, 28)
        Me.binBtn.TabIndex = 2
        Me.binBtn.Text = "Bin"
        Me.binBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(263, 98)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(81, 28)
        Me.cancelBtn.TabIndex = 3
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'TransferMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 136)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.binBtn)
        Me.Controls.Add(Me.disposeBtn)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Record Destination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents disposeBtn As System.Windows.Forms.Button
    Friend WithEvents binBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
End Class
