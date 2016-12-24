<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.categoryCombo = New System.Windows.Forms.ComboBox()
        Me.batchTxt = New System.Windows.Forms.TextBox()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CarWorkshopDBDataSet = New CarWorkshopSystem.CarWorkshopDBDataSet()
        Me.supplierCombo = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SupplierTableAdapter = New CarWorkshopSystem.CarWorkshopDBDataSetTableAdapters.SupplierTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.dateText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.conditionCombo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.availableRadio = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.disabledRadio = New System.Windows.Forms.RadioButton()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.verifySpec = New System.Windows.Forms.Label()
        Me.verifyDes = New System.Windows.Forms.Label()
        Me.verifyBrand = New System.Windows.Forms.Label()
        Me.priceNum = New System.Windows.Forms.NumericUpDown()
        Me.quantityNum = New System.Windows.Forms.NumericUpDown()
        Me.specificationBox = New System.Windows.Forms.RichTextBox()
        Me.descriptionBox = New System.Windows.Forms.RichTextBox()
        Me.brandTxt = New System.Windows.Forms.TextBox()
        CType(Me.CarWorkshopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryCombo
        '
        Me.categoryCombo.FormattingEnabled = True
        Me.categoryCombo.Items.AddRange(New Object() {"Tyres", "Car Engine", "Accessories", "Liquid", "Repairing Tools", "Polishing and Wax", "Wipers", "Cloth", "Spray", "Screws", "Doors", "Windows", "Lights", "Battery and Cables", "Suspension", "Exhaust System", "Chassis Lubrication", "Chassis", "Brakes", "Cleaning & Polishing", "Fuel Filter", "Labour"})
        Me.categoryCombo.Location = New System.Drawing.Point(106, 202)
        Me.categoryCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.categoryCombo.Name = "categoryCombo"
        Me.categoryCombo.Size = New System.Drawing.Size(134, 21)
        Me.categoryCombo.TabIndex = 44
        '
        'batchTxt
        '
        Me.batchTxt.Location = New System.Drawing.Point(106, 176)
        Me.batchTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.batchTxt.Name = "batchTxt"
        Me.batchTxt.ReadOnly = True
        Me.batchTxt.Size = New System.Drawing.Size(75, 20)
        Me.batchTxt.TabIndex = 43
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(106, 123)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.ReadOnly = True
        Me.nameTxt.Size = New System.Drawing.Size(145, 20)
        Me.nameTxt.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(379, 197)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Specification:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 176)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Batch No:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Arrival Date:"
        '
        'CarWorkshopDBDataSet
        '
        Me.CarWorkshopDBDataSet.DataSetName = "CarWorkshopDBDataSet"
        Me.CarWorkshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'supplierCombo
        '
        Me.supplierCombo.FormattingEnabled = True
        Me.supplierCombo.Location = New System.Drawing.Point(106, 290)
        Me.supplierCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.supplierCombo.Name = "supplierCombo"
        Me.supplierCombo.Size = New System.Drawing.Size(134, 21)
        Me.supplierCombo.TabIndex = 50
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.CarWorkshopDBDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 292)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Supplier:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 260)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Brand:"
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 27)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Update Product Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 100)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Stock Name:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(106, 100)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(75, 14)
        Me.idLabel.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Inventory ID:"
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(513, 544)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 29
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(452, 544)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(56, 19)
        Me.resetBtn.TabIndex = 28
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(392, 544)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(56, 19)
        Me.updateBtn.TabIndex = 27
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'dateText
        '
        Me.dateText.Location = New System.Drawing.Point(106, 230)
        Me.dateText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dateText.Name = "dateText"
        Me.dateText.ReadOnly = True
        Me.dateText.Size = New System.Drawing.Size(135, 20)
        Me.dateText.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 327)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Price:"
        '
        'conditionCombo
        '
        Me.conditionCombo.FormattingEnabled = True
        Me.conditionCombo.Items.AddRange(New Object() {"Good", "Poor"})
        Me.conditionCombo.Location = New System.Drawing.Point(452, 290)
        Me.conditionCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.conditionCombo.Name = "conditionCombo"
        Me.conditionCombo.Size = New System.Drawing.Size(85, 21)
        Me.conditionCombo.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(394, 292)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Condition:"
        '
        'availableRadio
        '
        Me.availableRadio.AutoSize = True
        Me.availableRadio.Location = New System.Drawing.Point(453, 327)
        Me.availableRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.availableRadio.Name = "availableRadio"
        Me.availableRadio.Size = New System.Drawing.Size(68, 17)
        Me.availableRadio.TabIndex = 56
        Me.availableRadio.TabStop = True
        Me.availableRadio.Text = "Available"
        Me.availableRadio.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(409, 327)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Status:"
        '
        'disabledRadio
        '
        Me.disabledRadio.AutoSize = True
        Me.disabledRadio.Location = New System.Drawing.Point(522, 327)
        Me.disabledRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.disabledRadio.Name = "disabledRadio"
        Me.disabledRadio.Size = New System.Drawing.Size(66, 17)
        Me.disabledRadio.TabIndex = 58
        Me.disabledRadio.TabStop = True
        Me.disabledRadio.Text = "Disabled"
        Me.disabledRadio.UseVisualStyleBackColor = True
        '
        'uploadBtn
        '
        Me.uploadBtn.Location = New System.Drawing.Point(98, 524)
        Me.uploadBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(56, 19)
        Me.uploadBtn.TabIndex = 61
        Me.uploadBtn.Text = "Browse"
        Me.uploadBtn.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 347)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Image:"
        '
        'imageBox
        '
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox.Location = New System.Drawing.Point(98, 347)
        Me.imageBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(187, 164)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 59
        Me.imageBox.TabStop = False
        '
        'verifySpec
        '
        Me.verifySpec.ForeColor = System.Drawing.Color.Red
        Me.verifySpec.Location = New System.Drawing.Point(644, 197)
        Me.verifySpec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifySpec.Name = "verifySpec"
        Me.verifySpec.Size = New System.Drawing.Size(134, 19)
        Me.verifySpec.TabIndex = 73
        '
        'verifyDes
        '
        Me.verifyDes.ForeColor = System.Drawing.Color.Red
        Me.verifyDes.Location = New System.Drawing.Point(644, 100)
        Me.verifyDes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyDes.Name = "verifyDes"
        Me.verifyDes.Size = New System.Drawing.Size(128, 19)
        Me.verifyDes.TabIndex = 72
        '
        'verifyBrand
        '
        Me.verifyBrand.ForeColor = System.Drawing.Color.Red
        Me.verifyBrand.Location = New System.Drawing.Point(188, 260)
        Me.verifyBrand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyBrand.Name = "verifyBrand"
        Me.verifyBrand.Size = New System.Drawing.Size(144, 19)
        Me.verifyBrand.TabIndex = 71
        '
        'priceNum
        '
        Me.priceNum.DecimalPlaces = 2
        Me.priceNum.Location = New System.Drawing.Point(106, 325)
        Me.priceNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.priceNum.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.priceNum.Minimum = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.priceNum.Name = "priceNum"
        Me.priceNum.Size = New System.Drawing.Size(70, 20)
        Me.priceNum.TabIndex = 78
        Me.priceNum.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'quantityNum
        '
        Me.quantityNum.Location = New System.Drawing.Point(106, 150)
        Me.quantityNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.quantityNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.quantityNum.Name = "quantityNum"
        Me.quantityNum.Size = New System.Drawing.Size(60, 20)
        Me.quantityNum.TabIndex = 77
        Me.quantityNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'specificationBox
        '
        Me.specificationBox.Location = New System.Drawing.Point(453, 197)
        Me.specificationBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.specificationBox.MaxLength = 40
        Me.specificationBox.Name = "specificationBox"
        Me.specificationBox.Size = New System.Drawing.Size(188, 78)
        Me.specificationBox.TabIndex = 76
        Me.specificationBox.Text = ""
        '
        'descriptionBox
        '
        Me.descriptionBox.Location = New System.Drawing.Point(452, 100)
        Me.descriptionBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.descriptionBox.MaxLength = 40
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(188, 78)
        Me.descriptionBox.TabIndex = 75
        Me.descriptionBox.Text = ""
        '
        'brandTxt
        '
        Me.brandTxt.Location = New System.Drawing.Point(106, 260)
        Me.brandTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.brandTxt.MaxLength = 20
        Me.brandTxt.Name = "brandTxt"
        Me.brandTxt.Size = New System.Drawing.Size(75, 20)
        Me.brandTxt.TabIndex = 74
        '
        'updateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 582)
        Me.Controls.Add(Me.priceNum)
        Me.Controls.Add(Me.quantityNum)
        Me.Controls.Add(Me.specificationBox)
        Me.Controls.Add(Me.descriptionBox)
        Me.Controls.Add(Me.brandTxt)
        Me.Controls.Add(Me.verifySpec)
        Me.Controls.Add(Me.verifyDes)
        Me.Controls.Add(Me.verifyBrand)
        Me.Controls.Add(Me.uploadBtn)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.disabledRadio)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.availableRadio)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.conditionCombo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dateText)
        Me.Controls.Add(Me.categoryCombo)
        Me.Controls.Add(Me.batchTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.supplierCombo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "updateInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Update Product Info"
        CType(Me.CarWorkshopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents categoryCombo As System.Windows.Forms.ComboBox
    Friend WithEvents batchTxt As System.Windows.Forms.TextBox
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CarWorkshopDBDataSet As CarWorkshopSystem.CarWorkshopDBDataSet
    Friend WithEvents supplierCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SupplierTableAdapter As CarWorkshopSystem.CarWorkshopDBDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents dateText As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents conditionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents availableRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents disabledRadio As System.Windows.Forms.RadioButton
    Friend WithEvents uploadBtn As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents imageBox As System.Windows.Forms.PictureBox
    Friend WithEvents verifySpec As System.Windows.Forms.Label
    Friend WithEvents verifyDes As System.Windows.Forms.Label
    Friend WithEvents verifyBrand As System.Windows.Forms.Label
    Friend WithEvents priceNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents quantityNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents specificationBox As System.Windows.Forms.RichTextBox
    Friend WithEvents descriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents brandTxt As System.Windows.Forms.TextBox
End Class
