<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMainForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(36, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 103)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "    Job Sheet      Summary Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button2.Location = New System.Drawing.Point(329, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(213, 103)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Service Coupon Summary Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button3.Location = New System.Drawing.Point(648, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(213, 103)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Payment Receipt Summary  Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button4.Location = New System.Drawing.Point(36, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 103)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Most Purchased Product Exception Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button5.Location = New System.Drawing.Point(329, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(213, 103)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Monthly Pre-Order Exception Report"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button6.Location = New System.Drawing.Point(648, 248)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(213, 103)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Total Product Sales Summary Report"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ReportMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CarWorkshopSystem.My.Resources.Resources.ReportBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "ReportMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Report Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
