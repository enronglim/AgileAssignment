<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRetrieveForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.byStaffContactNo = New System.Windows.Forms.Button()
        Me.byStaffPosition = New System.Windows.Forms.Button()
        Me.byStaffIC = New System.Windows.Forms.Button()
        Me.byStaffName = New System.Windows.Forms.Button()
        Me.btnFired = New System.Windows.Forms.Button()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(817, 537)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(636, 537)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 29)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Resign"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(544, 537)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(86, 29)
        Me.btnChange.TabIndex = 21
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(463, 537)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 29)
        Me.btnInsert.TabIndex = 20
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSearch.Location = New System.Drawing.Point(80, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(424, 26)
        Me.txtSearch.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search:"
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToDeleteRows = False
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(12, 62)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaff.Size = New System.Drawing.Size(902, 440)
        Me.dgvStaff.TabIndex = 17
        '
        'byStaffContactNo
        '
        Me.byStaffContactNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byStaffContactNo.Location = New System.Drawing.Point(374, 1)
        Me.byStaffContactNo.Name = "byStaffContactNo"
        Me.byStaffContactNo.Size = New System.Drawing.Size(130, 23)
        Me.byStaffContactNo.TabIndex = 16
        Me.byStaffContactNo.Text = "By Staff Contact No"
        Me.byStaffContactNo.UseVisualStyleBackColor = True
        '
        'byStaffPosition
        '
        Me.byStaffPosition.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byStaffPosition.Location = New System.Drawing.Point(251, 1)
        Me.byStaffPosition.Name = "byStaffPosition"
        Me.byStaffPosition.Size = New System.Drawing.Size(123, 23)
        Me.byStaffPosition.TabIndex = 15
        Me.byStaffPosition.Text = "By Staff Position"
        Me.byStaffPosition.UseVisualStyleBackColor = True
        '
        'byStaffIC
        '
        Me.byStaffIC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byStaffIC.Location = New System.Drawing.Point(126, 1)
        Me.byStaffIC.Name = "byStaffIC"
        Me.byStaffIC.Size = New System.Drawing.Size(125, 23)
        Me.byStaffIC.TabIndex = 14
        Me.byStaffIC.Text = "By Staff I/C No"
        Me.byStaffIC.UseVisualStyleBackColor = True
        '
        'byStaffName
        '
        Me.byStaffName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byStaffName.ForeColor = System.Drawing.Color.MediumBlue
        Me.byStaffName.Location = New System.Drawing.Point(1, 1)
        Me.byStaffName.Name = "byStaffName"
        Me.byStaffName.Size = New System.Drawing.Size(125, 23)
        Me.byStaffName.TabIndex = 13
        Me.byStaffName.Text = "By Staff Name"
        Me.byStaffName.UseVisualStyleBackColor = True
        '
        'btnFired
        '
        Me.btnFired.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFired.Location = New System.Drawing.Point(725, 537)
        Me.btnFired.Name = "btnFired"
        Me.btnFired.Size = New System.Drawing.Size(86, 29)
        Me.btnFired.TabIndex = 24
        Me.btnFired.Text = "Fired"
        Me.btnFired.UseVisualStyleBackColor = True
        '
        'StaffRetrieveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 567)
        Me.Controls.Add(Me.btnFired)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.byStaffContactNo)
        Me.Controls.Add(Me.byStaffPosition)
        Me.Controls.Add(Me.byStaffIC)
        Me.Controls.Add(Me.byStaffName)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "StaffRetrieveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Browse the Staff File"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents byStaffContactNo As System.Windows.Forms.Button
    Friend WithEvents byStaffPosition As System.Windows.Forms.Button
    Friend WithEvents byStaffIC As System.Windows.Forms.Button
    Friend WithEvents byStaffName As System.Windows.Forms.Button
    Friend WithEvents btnFired As System.Windows.Forms.Button
End Class
