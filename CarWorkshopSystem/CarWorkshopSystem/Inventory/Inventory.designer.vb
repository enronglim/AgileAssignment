<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.inventoryTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.alertLabel = New System.Windows.Forms.Label()
        Me.byCategory = New System.Windows.Forms.Button()
        Me.byQuantity = New System.Windows.Forms.Button()
        Me.byDate = New System.Windows.Forms.Button()
        Me.byName = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.stockView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.transferBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bySupplierName = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchSupBox = New System.Windows.Forms.TextBox()
        Me.supplierView = New System.Windows.Forms.DataGridView()
        Me.supCloseBtn = New System.Windows.Forms.Button()
        Me.removeSupBtn = New System.Windows.Forms.Button()
        Me.updateSupBtn = New System.Windows.Forms.Button()
        Me.addSupBtn = New System.Windows.Forms.Button()
        Me.inventoryTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.supplierView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inventoryTab
        '
        Me.inventoryTab.Controls.Add(Me.TabPage1)
        Me.inventoryTab.Controls.Add(Me.TabPage2)
        Me.inventoryTab.Location = New System.Drawing.Point(1, 10)
        Me.inventoryTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.inventoryTab.Name = "inventoryTab"
        Me.inventoryTab.SelectedIndex = 0
        Me.inventoryTab.Size = New System.Drawing.Size(894, 440)
        Me.inventoryTab.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.alertLabel)
        Me.TabPage1.Controls.Add(Me.byCategory)
        Me.TabPage1.Controls.Add(Me.byQuantity)
        Me.TabPage1.Controls.Add(Me.byDate)
        Me.TabPage1.Controls.Add(Me.byName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.searchBox)
        Me.TabPage1.Controls.Add(Me.stockView)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.transferBtn)
        Me.TabPage1.Controls.Add(Me.updateBtn)
        Me.TabPage1.Controls.Add(Me.addBtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(886, 414)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stock Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Low Stock:"
        '
        'alertLabel
        '
        Me.alertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.alertLabel.ForeColor = System.Drawing.Color.Red
        Me.alertLabel.Location = New System.Drawing.Point(91, 60)
        Me.alertLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.alertLabel.Name = "alertLabel"
        Me.alertLabel.Size = New System.Drawing.Size(240, 19)
        Me.alertLabel.TabIndex = 25
        Me.alertLabel.Text = "Alert"
        '
        'byCategory
        '
        Me.byCategory.Location = New System.Drawing.Point(273, 3)
        Me.byCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byCategory.Name = "byCategory"
        Me.byCategory.Size = New System.Drawing.Size(85, 20)
        Me.byCategory.TabIndex = 22
        Me.byCategory.Text = "By Category"
        Me.byCategory.UseVisualStyleBackColor = True
        '
        'byQuantity
        '
        Me.byQuantity.Location = New System.Drawing.Point(184, 3)
        Me.byQuantity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byQuantity.Name = "byQuantity"
        Me.byQuantity.Size = New System.Drawing.Size(85, 20)
        Me.byQuantity.TabIndex = 21
        Me.byQuantity.Text = "Below Quantity"
        Me.byQuantity.UseVisualStyleBackColor = True
        '
        'byDate
        '
        Me.byDate.Location = New System.Drawing.Point(94, 3)
        Me.byDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byDate.Name = "byDate"
        Me.byDate.Size = New System.Drawing.Size(85, 20)
        Me.byDate.TabIndex = 20
        Me.byDate.Text = "Before Date"
        Me.byDate.UseVisualStyleBackColor = True
        '
        'byName
        '
        Me.byName.ForeColor = System.Drawing.Color.Black
        Me.byName.Location = New System.Drawing.Point(5, 3)
        Me.byName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.byName.Name = "byName"
        Me.byName.Size = New System.Drawing.Size(85, 20)
        Me.byName.TabIndex = 19
        Me.byName.Text = "By Name"
        Me.byName.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search:"
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.searchBox.Location = New System.Drawing.Point(94, 32)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(284, 26)
        Me.searchBox.TabIndex = 17
        '
        'stockView
        '
        Me.stockView.AllowUserToAddRows = False
        Me.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stockView.Location = New System.Drawing.Point(-5, 90)
        Me.stockView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stockView.MultiSelect = False
        Me.stockView.Name = "stockView"
        Me.stockView.ReadOnly = True
        Me.stockView.RowTemplate.Height = 24
        Me.stockView.Size = New System.Drawing.Size(891, 295)
        Me.stockView.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(599, 390)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 24)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'transferBtn
        '
        Me.transferBtn.Location = New System.Drawing.Point(476, 390)
        Me.transferBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.transferBtn.Name = "transferBtn"
        Me.transferBtn.Size = New System.Drawing.Size(84, 24)
        Me.transferBtn.TabIndex = 14
        Me.transferBtn.Text = "Transfer Stock"
        Me.transferBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(355, 390)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(93, 24)
        Me.updateBtn.TabIndex = 13
        Me.updateBtn.Text = "Update Stock"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(225, 390)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(95, 24)
        Me.addBtn.TabIndex = 12
        Me.addBtn.Text = "Add Stock"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bySupplierName)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.searchSupBox)
        Me.TabPage2.Controls.Add(Me.supplierView)
        Me.TabPage2.Controls.Add(Me.supCloseBtn)
        Me.TabPage2.Controls.Add(Me.removeSupBtn)
        Me.TabPage2.Controls.Add(Me.updateSupBtn)
        Me.TabPage2.Controls.Add(Me.addSupBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(886, 414)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Supplier Control"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bySupplierName
        '
        Me.bySupplierName.Location = New System.Drawing.Point(65, 2)
        Me.bySupplierName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bySupplierName.Name = "bySupplierName"
        Me.bySupplierName.Size = New System.Drawing.Size(106, 20)
        Me.bySupplierName.TabIndex = 26
        Me.bySupplierName.Text = "By Name"
        Me.bySupplierName.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Search:"
        '
        'searchSupBox
        '
        Me.searchSupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.searchSupBox.Location = New System.Drawing.Point(137, 37)
        Me.searchSupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchSupBox.Name = "searchSupBox"
        Me.searchSupBox.Size = New System.Drawing.Size(328, 26)
        Me.searchSupBox.TabIndex = 24
        '
        'supplierView
        '
        Me.supplierView.AllowUserToAddRows = False
        Me.supplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.supplierView.Location = New System.Drawing.Point(65, 67)
        Me.supplierView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.supplierView.MultiSelect = False
        Me.supplierView.Name = "supplierView"
        Me.supplierView.ReadOnly = True
        Me.supplierView.RowTemplate.Height = 24
        Me.supplierView.Size = New System.Drawing.Size(542, 314)
        Me.supplierView.TabIndex = 23
        '
        'supCloseBtn
        '
        Me.supCloseBtn.Location = New System.Drawing.Point(518, 385)
        Me.supCloseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.supCloseBtn.Name = "supCloseBtn"
        Me.supCloseBtn.Size = New System.Drawing.Size(89, 24)
        Me.supCloseBtn.TabIndex = 22
        Me.supCloseBtn.Text = "Close"
        Me.supCloseBtn.UseVisualStyleBackColor = True
        '
        'removeSupBtn
        '
        Me.removeSupBtn.Location = New System.Drawing.Point(380, 385)
        Me.removeSupBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.removeSupBtn.Name = "removeSupBtn"
        Me.removeSupBtn.Size = New System.Drawing.Size(97, 24)
        Me.removeSupBtn.TabIndex = 21
        Me.removeSupBtn.Text = "Remove Supplier"
        Me.removeSupBtn.UseVisualStyleBackColor = True
        '
        'updateSupBtn
        '
        Me.updateSupBtn.Location = New System.Drawing.Point(249, 385)
        Me.updateSupBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateSupBtn.Name = "updateSupBtn"
        Me.updateSupBtn.Size = New System.Drawing.Size(93, 24)
        Me.updateSupBtn.TabIndex = 20
        Me.updateSupBtn.Text = "Update Supplier"
        Me.updateSupBtn.UseVisualStyleBackColor = True
        '
        'addSupBtn
        '
        Me.addSupBtn.Location = New System.Drawing.Point(115, 385)
        Me.addSupBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addSupBtn.Name = "addSupBtn"
        Me.addSupBtn.Size = New System.Drawing.Size(95, 24)
        Me.addSupBtn.TabIndex = 19
        Me.addSupBtn.Text = "Add Supplier"
        Me.addSupBtn.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 448)
        Me.Controls.Add(Me.inventoryTab)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventory"
        Me.inventoryTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.supplierView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inventoryTab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents byCategory As System.Windows.Forms.Button
    Friend WithEvents byQuantity As System.Windows.Forms.Button
    Friend WithEvents byDate As System.Windows.Forms.Button
    Friend WithEvents byName As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents transferBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents bySupplierName As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchSupBox As System.Windows.Forms.TextBox
    Friend WithEvents supplierView As System.Windows.Forms.DataGridView
    Friend WithEvents supCloseBtn As System.Windows.Forms.Button
    Friend WithEvents removeSupBtn As System.Windows.Forms.Button
    Friend WithEvents updateSupBtn As System.Windows.Forms.Button
    Friend WithEvents addSupBtn As System.Windows.Forms.Button
    Friend WithEvents stockView As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents alertLabel As System.Windows.Forms.Label

End Class
