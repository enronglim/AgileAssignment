<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkshopLocation
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
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.workshopView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.byEmail = New System.Windows.Forms.Button()
        Me.byID = New System.Windows.Forms.Button()
        Me.byState = New System.Windows.Forms.Button()
        Me.byStatus = New System.Windows.Forms.Button()
        CType(Me.workshopView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search:"
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.searchBox.Location = New System.Drawing.Point(89, 39)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchBox.MaxLength = 50
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(282, 26)
        Me.searchBox.TabIndex = 24
        '
        'workshopView
        '
        Me.workshopView.AllowUserToAddRows = False
        Me.workshopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.workshopView.Location = New System.Drawing.Point(9, 79)
        Me.workshopView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.workshopView.MultiSelect = False
        Me.workshopView.Name = "workshopView"
        Me.workshopView.ReadOnly = True
        Me.workshopView.RowTemplate.Height = 24
        Me.workshopView.Size = New System.Drawing.Size(812, 314)
        Me.workshopView.TabIndex = 23
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(673, 399)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 24)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(575, 399)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 24)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update Workshop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(476, 399)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 24)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add Workshop"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'byEmail
        '
        Me.byEmail.Location = New System.Drawing.Point(196, 10)
        Me.byEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byEmail.Name = "byEmail"
        Me.byEmail.Size = New System.Drawing.Size(85, 20)
        Me.byEmail.TabIndex = 28
        Me.byEmail.Text = "By Email"
        Me.byEmail.UseVisualStyleBackColor = True
        '
        'byID
        '
        Me.byID.Location = New System.Drawing.Point(106, 10)
        Me.byID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byID.Name = "byID"
        Me.byID.Size = New System.Drawing.Size(85, 20)
        Me.byID.TabIndex = 27
        Me.byID.Text = "By ID"
        Me.byID.UseVisualStyleBackColor = True
        '
        'byState
        '
        Me.byState.Location = New System.Drawing.Point(14, 10)
        Me.byState.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byState.Name = "byState"
        Me.byState.Size = New System.Drawing.Size(88, 20)
        Me.byState.TabIndex = 26
        Me.byState.Text = "By State"
        Me.byState.UseVisualStyleBackColor = True
        '
        'byStatus
        '
        Me.byStatus.Location = New System.Drawing.Point(285, 10)
        Me.byStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byStatus.Name = "byStatus"
        Me.byStatus.Size = New System.Drawing.Size(85, 20)
        Me.byStatus.TabIndex = 29
        Me.byStatus.Text = "By Status"
        Me.byStatus.UseVisualStyleBackColor = True
        '
        'WorkshopLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 432)
        Me.Controls.Add(Me.byStatus)
        Me.Controls.Add(Me.byEmail)
        Me.Controls.Add(Me.byID)
        Me.Controls.Add(Me.byState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.workshopView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "WorkshopLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WorkshopLocation"
        CType(Me.workshopView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents workshopView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents byEmail As System.Windows.Forms.Button
    Friend WithEvents byID As System.Windows.Forms.Button
    Friend WithEvents byState As System.Windows.Forms.Button
    Friend WithEvents byStatus As System.Windows.Forms.Button
End Class
