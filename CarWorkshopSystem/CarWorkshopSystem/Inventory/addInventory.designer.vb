<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addInventory
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
        Me.addBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.batchTxt = New System.Windows.Forms.TextBox()
        Me.categoryCombo = New System.Windows.Forms.ComboBox()
        Me.arrivalDate = New System.Windows.Forms.DateTimePicker()
        Me.brandTxt = New System.Windows.Forms.TextBox()
        Me.descriptionBox = New System.Windows.Forms.RichTextBox()
        Me.specificationBox = New System.Windows.Forms.RichTextBox()
        Me.supplierCombo = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarWorkshopDBDataSet = New CarWorkshopSystem.CarWorkshopDBDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SupplierTableAdapter = New CarWorkshopSystem.CarWorkshopDBDataSetTableAdapters.SupplierTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.localRadio = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.preRadio = New System.Windows.Forms.RadioButton()
        Me.quantityNum = New System.Windows.Forms.NumericUpDown()
        Me.priceNum = New System.Windows.Forms.NumericUpDown()
        Me.verifyName = New System.Windows.Forms.Label()
        Me.verifyBatch = New System.Windows.Forms.Label()
        Me.verifyBrand = New System.Windows.Forms.Label()
        Me.verifyDes = New System.Windows.Forms.Label()
        Me.verifySpec = New System.Windows.Forms.Label()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarWorkshopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(353, 476)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(56, 19)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(414, 476)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(56, 19)
        Me.clearBtn.TabIndex = 1
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(475, 476)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(56, 19)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inventory ID:"
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(76, 93)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(75, 14)
        Me.idLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stock Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 369)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Product Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 239)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Arrival Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Brand:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 211)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Category:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 184)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Batch No:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(340, 92)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Specification:"
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(76, 132)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.nameTxt.MaxLength = 30
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(145, 20)
        Me.nameTxt.TabIndex = 16
        '
        'batchTxt
        '
        Me.batchTxt.Location = New System.Drawing.Point(76, 184)
        Me.batchTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.batchTxt.MaxLength = 12
        Me.batchTxt.Name = "batchTxt"
        Me.batchTxt.Size = New System.Drawing.Size(75, 20)
        Me.batchTxt.TabIndex = 18
        '
        'categoryCombo
        '
        Me.categoryCombo.FormattingEnabled = True
        Me.categoryCombo.Items.AddRange(New Object() {"Tyres", "Car Engine", "Accessories", "Liquid", "Repairing Tools", "Polishing and Wax", "Wipers", "Cloth", "Spray", "Screws", "Doors", "Windows", "Lights", "Battery and Cables", "Suspension", "Exhaust System", "Chassis Lubrication", "Chassis", "Brakes", "Cleaning & Polishing", "Fuel Filter", "Labour"})
        Me.categoryCombo.Location = New System.Drawing.Point(76, 211)
        Me.categoryCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.categoryCombo.Name = "categoryCombo"
        Me.categoryCombo.Size = New System.Drawing.Size(134, 21)
        Me.categoryCombo.TabIndex = 19
        '
        'arrivalDate
        '
        Me.arrivalDate.Location = New System.Drawing.Point(76, 239)
        Me.arrivalDate.Margin = New System.Windows.Forms.Padding(2)
        Me.arrivalDate.Name = "arrivalDate"
        Me.arrivalDate.Size = New System.Drawing.Size(188, 20)
        Me.arrivalDate.TabIndex = 20
        '
        'brandTxt
        '
        Me.brandTxt.Location = New System.Drawing.Point(76, 269)
        Me.brandTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.brandTxt.MaxLength = 20
        Me.brandTxt.Name = "brandTxt"
        Me.brandTxt.Size = New System.Drawing.Size(75, 20)
        Me.brandTxt.TabIndex = 22
        '
        'descriptionBox
        '
        Me.descriptionBox.Location = New System.Drawing.Point(76, 369)
        Me.descriptionBox.Margin = New System.Windows.Forms.Padding(2)
        Me.descriptionBox.MaxLength = 40
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(188, 78)
        Me.descriptionBox.TabIndex = 23
        Me.descriptionBox.Text = ""
        '
        'specificationBox
        '
        Me.specificationBox.Location = New System.Drawing.Point(414, 92)
        Me.specificationBox.Margin = New System.Windows.Forms.Padding(2)
        Me.specificationBox.MaxLength = 40
        Me.specificationBox.Name = "specificationBox"
        Me.specificationBox.Size = New System.Drawing.Size(188, 78)
        Me.specificationBox.TabIndex = 24
        Me.specificationBox.Text = ""
        '
        'supplierCombo
        '
        Me.supplierCombo.DataSource = Me.SupplierBindingSource
        Me.supplierCombo.DisplayMember = "supplierName"
        Me.supplierCombo.FormattingEnabled = True
        Me.supplierCombo.Location = New System.Drawing.Point(76, 301)
        Me.supplierCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.supplierCombo.Name = "supplierCombo"
        Me.supplierCombo.Size = New System.Drawing.Size(134, 21)
        Me.supplierCombo.TabIndex = 26
        Me.supplierCombo.ValueMember = "supplierName"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.CarWorkshopDBDataSet
        '
        'CarWorkshopDBDataSet
        '
        Me.CarWorkshopDBDataSet.DataSetName = "CarWorkshopDBDataSet"
        Me.CarWorkshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 301)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Supplier:"
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 336)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Price:"
        '
        'imageBox
        '
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox.Location = New System.Drawing.Point(414, 188)
        Me.imageBox.Margin = New System.Windows.Forms.Padding(2)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(187, 164)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 29
        Me.imageBox.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(372, 188)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Image:"
        '
        'uploadBtn
        '
        Me.uploadBtn.Location = New System.Drawing.Point(414, 365)
        Me.uploadBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(56, 19)
        Me.uploadBtn.TabIndex = 31
        Me.uploadBtn.Text = "Browse"
        Me.uploadBtn.UseVisualStyleBackColor = True
        '
        'localRadio
        '
        Me.localRadio.AutoSize = True
        Me.localRadio.Location = New System.Drawing.Point(76, 112)
        Me.localRadio.Margin = New System.Windows.Forms.Padding(2)
        Me.localRadio.Name = "localRadio"
        Me.localRadio.Size = New System.Drawing.Size(51, 17)
        Me.localRadio.TabIndex = 61
        Me.localRadio.TabStop = True
        Me.localRadio.Text = "Local"
        Me.localRadio.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 112)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Type:"
        '
        'preRadio
        '
        Me.preRadio.AutoSize = True
        Me.preRadio.Location = New System.Drawing.Point(128, 112)
        Me.preRadio.Margin = New System.Windows.Forms.Padding(2)
        Me.preRadio.Name = "preRadio"
        Me.preRadio.Size = New System.Drawing.Size(70, 17)
        Me.preRadio.TabIndex = 59
        Me.preRadio.TabStop = True
        Me.preRadio.Text = "Pre-Order"
        Me.preRadio.UseVisualStyleBackColor = True
        '
        'quantityNum
        '
        Me.quantityNum.Location = New System.Drawing.Point(76, 158)
        Me.quantityNum.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.quantityNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.quantityNum.Name = "quantityNum"
        Me.quantityNum.Size = New System.Drawing.Size(60, 20)
        Me.quantityNum.TabIndex = 62
        Me.quantityNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'priceNum
        '
        Me.priceNum.DecimalPlaces = 2
        Me.priceNum.Location = New System.Drawing.Point(76, 334)
        Me.priceNum.Margin = New System.Windows.Forms.Padding(2)
        Me.priceNum.Maximum = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.priceNum.Minimum = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.priceNum.Name = "priceNum"
        Me.priceNum.Size = New System.Drawing.Size(70, 20)
        Me.priceNum.TabIndex = 63
        Me.priceNum.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'verifyName
        '
        Me.verifyName.ForeColor = System.Drawing.Color.Red
        Me.verifyName.Location = New System.Drawing.Point(225, 132)
        Me.verifyName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyName.Name = "verifyName"
        Me.verifyName.Size = New System.Drawing.Size(160, 19)
        Me.verifyName.TabIndex = 64
        '
        'verifyBatch
        '
        Me.verifyBatch.ForeColor = System.Drawing.Color.Red
        Me.verifyBatch.Location = New System.Drawing.Point(154, 184)
        Me.verifyBatch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyBatch.Name = "verifyBatch"
        Me.verifyBatch.Size = New System.Drawing.Size(213, 19)
        Me.verifyBatch.TabIndex = 65
        '
        'verifyBrand
        '
        Me.verifyBrand.ForeColor = System.Drawing.Color.Red
        Me.verifyBrand.Location = New System.Drawing.Point(154, 269)
        Me.verifyBrand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyBrand.Name = "verifyBrand"
        Me.verifyBrand.Size = New System.Drawing.Size(134, 19)
        Me.verifyBrand.TabIndex = 66
        '
        'verifyDes
        '
        Me.verifyDes.ForeColor = System.Drawing.Color.Red
        Me.verifyDes.Location = New System.Drawing.Point(268, 369)
        Me.verifyDes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifyDes.Name = "verifyDes"
        Me.verifyDes.Size = New System.Drawing.Size(142, 19)
        Me.verifyDes.TabIndex = 67
        '
        'verifySpec
        '
        Me.verifySpec.ForeColor = System.Drawing.Color.Red
        Me.verifySpec.Location = New System.Drawing.Point(605, 92)
        Me.verifySpec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.verifySpec.Name = "verifySpec"
        Me.verifySpec.Size = New System.Drawing.Size(139, 19)
        Me.verifySpec.TabIndex = 68
        '
        'addInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 520)
        Me.Controls.Add(Me.verifySpec)
        Me.Controls.Add(Me.verifyDes)
        Me.Controls.Add(Me.verifyBrand)
        Me.Controls.Add(Me.verifyBatch)
        Me.Controls.Add(Me.verifyName)
        Me.Controls.Add(Me.priceNum)
        Me.Controls.Add(Me.quantityNum)
        Me.Controls.Add(Me.localRadio)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.preRadio)
        Me.Controls.Add(Me.uploadBtn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.supplierCombo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.specificationBox)
        Me.Controls.Add(Me.descriptionBox)
        Me.Controls.Add(Me.brandTxt)
        Me.Controls.Add(Me.arrivalDate)
        Me.Controls.Add(Me.categoryCombo)
        Me.Controls.Add(Me.batchTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "addInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Stock"
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarWorkshopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents batchTxt As System.Windows.Forms.TextBox
    Friend WithEvents categoryCombo As System.Windows.Forms.ComboBox
    Friend WithEvents arrivalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents brandTxt As System.Windows.Forms.TextBox
    Friend WithEvents descriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents specificationBox As System.Windows.Forms.RichTextBox
    Friend WithEvents supplierCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CarWorkshopDBDataSet As CarWorkshopSystem.CarWorkshopDBDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As CarWorkshopSystem.CarWorkshopDBDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents imageBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents uploadBtn As System.Windows.Forms.Button
    Friend WithEvents localRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents preRadio As System.Windows.Forms.RadioButton
    Friend WithEvents quantityNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents priceNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents verifyName As System.Windows.Forms.Label
    Friend WithEvents verifyBatch As System.Windows.Forms.Label
    Friend WithEvents verifyBrand As System.Windows.Forms.Label
    Friend WithEvents verifyDes As System.Windows.Forms.Label
    Friend WithEvents verifySpec As System.Windows.Forms.Label
End Class
