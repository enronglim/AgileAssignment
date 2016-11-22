<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CounterSalesManagement
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.userRadio = New System.Windows.Forms.RadioButton()
        Me.guestRadio = New System.Windows.Forms.RadioButton()
        Me.addCusBtn = New System.Windows.Forms.Button()
        Me.cusClearBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ic3Txt = New System.Windows.Forms.TextBox()
        Me.ic2Txt = New System.Windows.Forms.TextBox()
        Me.cusSearchBtn = New System.Windows.Forms.Button()
        Me.ic1Txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.custnameTxt = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.productDetailsPanel = New System.Windows.Forms.Panel()
        Me.warrantyBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.detailspriceTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.quantityProductNum = New System.Windows.Forms.NumericUpDown()
        Me.finaliseBtn = New System.Windows.Forms.Button()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.billingRecordView = New System.Windows.Forms.DataGridView()
        Me.detailsbrandTxt = New System.Windows.Forms.TextBox()
        Me.detailsconditionTxt = New System.Windows.Forms.TextBox()
        Me.detailsnameTxt = New System.Windows.Forms.TextBox()
        Me.detailsidTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkAvailabilityPanel = New System.Windows.Forms.Panel()
        Me.conditionCombo = New System.Windows.Forms.ComboBox()
        Me.alertLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productNameTxt = New System.Windows.Forms.TextBox()
        Me.stockView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.unpaidBtn = New System.Windows.Forms.Button()
        Me.paidBtn = New System.Windows.Forms.Button()
        Me.btnCloseBill = New System.Windows.Forms.Button()
        Me.byDate = New System.Windows.Forms.Button()
        Me.byBillNo = New System.Windows.Forms.Button()
        Me.byName = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.billView = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.productDetailsPanel.SuspendLayout()
        CType(Me.quantityProductNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billingRecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.checkAvailabilityPanel.SuspendLayout()
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.billView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(755, 439)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.closeBtn)
        Me.TabPage1.Controls.Add(Me.productDetailsPanel)
        Me.TabPage1.Controls.Add(Me.checkAvailabilityPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(747, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Counter Sales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.userRadio)
        Me.Panel3.Controls.Add(Me.guestRadio)
        Me.Panel3.Controls.Add(Me.addCusBtn)
        Me.Panel3.Controls.Add(Me.cusClearBtn)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.ic3Txt)
        Me.Panel3.Controls.Add(Me.ic2Txt)
        Me.Panel3.Controls.Add(Me.cusSearchBtn)
        Me.Panel3.Controls.Add(Me.ic1Txt)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.custnameTxt)
        Me.Panel3.Location = New System.Drawing.Point(2, 5)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(329, 160)
        Me.Panel3.TabIndex = 48
        '
        'userRadio
        '
        Me.userRadio.AutoSize = True
        Me.userRadio.Location = New System.Drawing.Point(142, 66)
        Me.userRadio.Margin = New System.Windows.Forms.Padding(2)
        Me.userRadio.Name = "userRadio"
        Me.userRadio.Size = New System.Drawing.Size(108, 17)
        Me.userRadio.TabIndex = 63
        Me.userRadio.TabStop = True
        Me.userRadio.Text = "Existing Customer"
        Me.userRadio.UseVisualStyleBackColor = True
        '
        'guestRadio
        '
        Me.guestRadio.AutoSize = True
        Me.guestRadio.Location = New System.Drawing.Point(78, 66)
        Me.guestRadio.Margin = New System.Windows.Forms.Padding(2)
        Me.guestRadio.Name = "guestRadio"
        Me.guestRadio.Size = New System.Drawing.Size(53, 17)
        Me.guestRadio.TabIndex = 62
        Me.guestRadio.TabStop = True
        Me.guestRadio.Text = "Guest"
        Me.guestRadio.UseVisualStyleBackColor = True
        '
        'addCusBtn
        '
        Me.addCusBtn.Location = New System.Drawing.Point(260, 64)
        Me.addCusBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.addCusBtn.Name = "addCusBtn"
        Me.addCusBtn.Size = New System.Drawing.Size(49, 19)
        Me.addCusBtn.TabIndex = 61
        Me.addCusBtn.Text = "Add"
        Me.addCusBtn.UseVisualStyleBackColor = True
        '
        'cusClearBtn
        '
        Me.cusClearBtn.Location = New System.Drawing.Point(169, 118)
        Me.cusClearBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cusClearBtn.Name = "cusClearBtn"
        Me.cusClearBtn.Size = New System.Drawing.Size(71, 24)
        Me.cusClearBtn.TabIndex = 60
        Me.cusClearBtn.Text = "Clear"
        Me.cusClearBtn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(198, 98)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(154, 98)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "-"
        '
        'ic3Txt
        '
        Me.ic3Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ic3Txt.Location = New System.Drawing.Point(212, 94)
        Me.ic3Txt.Margin = New System.Windows.Forms.Padding(2)
        Me.ic3Txt.MaxLength = 4
        Me.ic3Txt.Name = "ic3Txt"
        Me.ic3Txt.Size = New System.Drawing.Size(50, 20)
        Me.ic3Txt.TabIndex = 57
        '
        'ic2Txt
        '
        Me.ic2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ic2Txt.Location = New System.Drawing.Point(169, 94)
        Me.ic2Txt.Margin = New System.Windows.Forms.Padding(2)
        Me.ic2Txt.MaxLength = 2
        Me.ic2Txt.Name = "ic2Txt"
        Me.ic2Txt.Size = New System.Drawing.Size(26, 20)
        Me.ic2Txt.TabIndex = 56
        '
        'cusSearchBtn
        '
        Me.cusSearchBtn.Location = New System.Drawing.Point(78, 118)
        Me.cusSearchBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cusSearchBtn.Name = "cusSearchBtn"
        Me.cusSearchBtn.Size = New System.Drawing.Size(71, 24)
        Me.cusSearchBtn.TabIndex = 49
        Me.cusSearchBtn.Text = "Search"
        Me.cusSearchBtn.UseVisualStyleBackColor = True
        '
        'ic1Txt
        '
        Me.ic1Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ic1Txt.Location = New System.Drawing.Point(78, 94)
        Me.ic1Txt.Margin = New System.Windows.Forms.Padding(2)
        Me.ic1Txt.MaxLength = 6
        Me.ic1Txt.Name = "ic1Txt"
        Me.ic1Txt.Size = New System.Drawing.Size(72, 20)
        Me.ic1Txt.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 17)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "IC:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 42)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 17)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Check Customer"
        '
        'custnameTxt
        '
        Me.custnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.custnameTxt.Location = New System.Drawing.Point(76, 40)
        Me.custnameTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.custnameTxt.Name = "custnameTxt"
        Me.custnameTxt.ReadOnly = True
        Me.custnameTxt.Size = New System.Drawing.Size(142, 20)
        Me.custnameTxt.TabIndex = 51
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(650, 378)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(71, 24)
        Me.closeBtn.TabIndex = 47
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'productDetailsPanel
        '
        Me.productDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productDetailsPanel.Controls.Add(Me.warrantyBox)
        Me.productDetailsPanel.Controls.Add(Me.Label2)
        Me.productDetailsPanel.Controls.Add(Me.detailspriceTxt)
        Me.productDetailsPanel.Controls.Add(Me.Label15)
        Me.productDetailsPanel.Controls.Add(Me.quantityProductNum)
        Me.productDetailsPanel.Controls.Add(Me.finaliseBtn)
        Me.productDetailsPanel.Controls.Add(Me.removeBtn)
        Me.productDetailsPanel.Controls.Add(Me.billingRecordView)
        Me.productDetailsPanel.Controls.Add(Me.detailsbrandTxt)
        Me.productDetailsPanel.Controls.Add(Me.detailsconditionTxt)
        Me.productDetailsPanel.Controls.Add(Me.detailsnameTxt)
        Me.productDetailsPanel.Controls.Add(Me.detailsidTxt)
        Me.productDetailsPanel.Controls.Add(Me.Label9)
        Me.productDetailsPanel.Controls.Add(Me.Label8)
        Me.productDetailsPanel.Controls.Add(Me.addBtn)
        Me.productDetailsPanel.Controls.Add(Me.Label7)
        Me.productDetailsPanel.Controls.Add(Me.Label5)
        Me.productDetailsPanel.Controls.Add(Me.Label3)
        Me.productDetailsPanel.Enabled = False
        Me.productDetailsPanel.Location = New System.Drawing.Point(334, 5)
        Me.productDetailsPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.productDetailsPanel.Name = "productDetailsPanel"
        Me.productDetailsPanel.Size = New System.Drawing.Size(408, 368)
        Me.productDetailsPanel.TabIndex = 45
        '
        'warrantyBox
        '
        Me.warrantyBox.Location = New System.Drawing.Point(287, 98)
        Me.warrantyBox.Margin = New System.Windows.Forms.Padding(2)
        Me.warrantyBox.Name = "warrantyBox"
        Me.warrantyBox.ReadOnly = True
        Me.warrantyBox.Size = New System.Drawing.Size(100, 20)
        Me.warrantyBox.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Warranty:"
        '
        'detailspriceTxt
        '
        Me.detailspriceTxt.Location = New System.Drawing.Point(62, 96)
        Me.detailspriceTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.detailspriceTxt.Name = "detailspriceTxt"
        Me.detailspriceTxt.ReadOnly = True
        Me.detailspriceTxt.Size = New System.Drawing.Size(72, 20)
        Me.detailspriceTxt.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 98)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Price:"
        '
        'quantityProductNum
        '
        Me.quantityProductNum.Location = New System.Drawing.Point(143, 96)
        Me.quantityProductNum.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityProductNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.quantityProductNum.Name = "quantityProductNum"
        Me.quantityProductNum.Size = New System.Drawing.Size(37, 20)
        Me.quantityProductNum.TabIndex = 52
        Me.quantityProductNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'finaliseBtn
        '
        Me.finaliseBtn.Location = New System.Drawing.Point(315, 128)
        Me.finaliseBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.finaliseBtn.Name = "finaliseBtn"
        Me.finaliseBtn.Size = New System.Drawing.Size(71, 24)
        Me.finaliseBtn.TabIndex = 46
        Me.finaliseBtn.Text = "Finalise"
        Me.finaliseBtn.UseVisualStyleBackColor = True
        '
        'removeBtn
        '
        Me.removeBtn.Location = New System.Drawing.Point(146, 128)
        Me.removeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(71, 24)
        Me.removeBtn.TabIndex = 45
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'billingRecordView
        '
        Me.billingRecordView.AllowUserToAddRows = False
        Me.billingRecordView.AllowUserToDeleteRows = False
        Me.billingRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billingRecordView.Location = New System.Drawing.Point(-1, 157)
        Me.billingRecordView.Margin = New System.Windows.Forms.Padding(2)
        Me.billingRecordView.Name = "billingRecordView"
        Me.billingRecordView.ReadOnly = True
        Me.billingRecordView.RowTemplate.Height = 24
        Me.billingRecordView.Size = New System.Drawing.Size(410, 210)
        Me.billingRecordView.TabIndex = 11
        '
        'detailsbrandTxt
        '
        Me.detailsbrandTxt.Location = New System.Drawing.Point(286, 68)
        Me.detailsbrandTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.detailsbrandTxt.Name = "detailsbrandTxt"
        Me.detailsbrandTxt.ReadOnly = True
        Me.detailsbrandTxt.Size = New System.Drawing.Size(101, 20)
        Me.detailsbrandTxt.TabIndex = 10
        '
        'detailsconditionTxt
        '
        Me.detailsconditionTxt.Location = New System.Drawing.Point(286, 39)
        Me.detailsconditionTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.detailsconditionTxt.Name = "detailsconditionTxt"
        Me.detailsconditionTxt.ReadOnly = True
        Me.detailsconditionTxt.Size = New System.Drawing.Size(101, 20)
        Me.detailsconditionTxt.TabIndex = 8
        '
        'detailsnameTxt
        '
        Me.detailsnameTxt.Location = New System.Drawing.Point(62, 71)
        Me.detailsnameTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.detailsnameTxt.Name = "detailsnameTxt"
        Me.detailsnameTxt.ReadOnly = True
        Me.detailsnameTxt.Size = New System.Drawing.Size(119, 20)
        Me.detailsnameTxt.TabIndex = 7
        '
        'detailsidTxt
        '
        Me.detailsidTxt.Location = New System.Drawing.Point(62, 41)
        Me.detailsidTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.detailsidTxt.Name = "detailsidTxt"
        Me.detailsidTxt.ReadOnly = True
        Me.detailsidTxt.Size = New System.Drawing.Size(98, 20)
        Me.detailsidTxt.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(244, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Brand:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ID:"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(62, 128)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(71, 24)
        Me.addBtn.TabIndex = 44
        Me.addBtn.Text = "Add Product"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Condition:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product Details"
        '
        'checkAvailabilityPanel
        '
        Me.checkAvailabilityPanel.BackColor = System.Drawing.Color.White
        Me.checkAvailabilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.checkAvailabilityPanel.Controls.Add(Me.conditionCombo)
        Me.checkAvailabilityPanel.Controls.Add(Me.alertLabel)
        Me.checkAvailabilityPanel.Controls.Add(Me.Label1)
        Me.checkAvailabilityPanel.Controls.Add(Me.productNameTxt)
        Me.checkAvailabilityPanel.Controls.Add(Me.stockView)
        Me.checkAvailabilityPanel.Enabled = False
        Me.checkAvailabilityPanel.Location = New System.Drawing.Point(2, 162)
        Me.checkAvailabilityPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.checkAvailabilityPanel.Name = "checkAvailabilityPanel"
        Me.checkAvailabilityPanel.Size = New System.Drawing.Size(329, 215)
        Me.checkAvailabilityPanel.TabIndex = 44
        '
        'conditionCombo
        '
        Me.conditionCombo.FormattingEnabled = True
        Me.conditionCombo.Items.AddRange(New Object() {"Name", "ID"})
        Me.conditionCombo.Location = New System.Drawing.Point(19, 36)
        Me.conditionCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.conditionCombo.Name = "conditionCombo"
        Me.conditionCombo.Size = New System.Drawing.Size(54, 21)
        Me.conditionCombo.TabIndex = 51
        '
        'alertLabel
        '
        Me.alertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.alertLabel.ForeColor = System.Drawing.Color.Red
        Me.alertLabel.Location = New System.Drawing.Point(16, 67)
        Me.alertLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.alertLabel.Name = "alertLabel"
        Me.alertLabel.Size = New System.Drawing.Size(307, 19)
        Me.alertLabel.TabIndex = 39
        Me.alertLabel.Text = "Alert"
        Me.alertLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Check Product Availability"
        '
        'productNameTxt
        '
        Me.productNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.productNameTxt.Location = New System.Drawing.Point(76, 36)
        Me.productNameTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.productNameTxt.Name = "productNameTxt"
        Me.productNameTxt.Size = New System.Drawing.Size(142, 20)
        Me.productNameTxt.TabIndex = 46
        '
        'stockView
        '
        Me.stockView.AllowUserToAddRows = False
        Me.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stockView.Location = New System.Drawing.Point(2, 89)
        Me.stockView.Margin = New System.Windows.Forms.Padding(2)
        Me.stockView.MultiSelect = False
        Me.stockView.Name = "stockView"
        Me.stockView.RowTemplate.Height = 24
        Me.stockView.Size = New System.Drawing.Size(324, 120)
        Me.stockView.TabIndex = 45
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.unpaidBtn)
        Me.TabPage2.Controls.Add(Me.paidBtn)
        Me.TabPage2.Controls.Add(Me.btnCloseBill)
        Me.TabPage2.Controls.Add(Me.byDate)
        Me.TabPage2.Controls.Add(Me.byBillNo)
        Me.TabPage2.Controls.Add(Me.byName)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.searchBox)
        Me.TabPage2.Controls.Add(Me.billView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(747, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bill Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'unpaidBtn
        '
        Me.unpaidBtn.ForeColor = System.Drawing.Color.Black
        Me.unpaidBtn.Location = New System.Drawing.Point(519, 5)
        Me.unpaidBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.unpaidBtn.Name = "unpaidBtn"
        Me.unpaidBtn.Size = New System.Drawing.Size(85, 20)
        Me.unpaidBtn.TabIndex = 50
        Me.unpaidBtn.Text = "Unpaid"
        Me.unpaidBtn.UseVisualStyleBackColor = True
        '
        'paidBtn
        '
        Me.paidBtn.ForeColor = System.Drawing.Color.Black
        Me.paidBtn.Location = New System.Drawing.Point(430, 5)
        Me.paidBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.paidBtn.Name = "paidBtn"
        Me.paidBtn.Size = New System.Drawing.Size(85, 20)
        Me.paidBtn.TabIndex = 49
        Me.paidBtn.Text = "Paid"
        Me.paidBtn.UseVisualStyleBackColor = True
        '
        'btnCloseBill
        '
        Me.btnCloseBill.Location = New System.Drawing.Point(532, 367)
        Me.btnCloseBill.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseBill.Name = "btnCloseBill"
        Me.btnCloseBill.Size = New System.Drawing.Size(71, 24)
        Me.btnCloseBill.TabIndex = 48
        Me.btnCloseBill.Text = "Close"
        Me.btnCloseBill.UseVisualStyleBackColor = True
        '
        'byDate
        '
        Me.byDate.Location = New System.Drawing.Point(298, 5)
        Me.byDate.Margin = New System.Windows.Forms.Padding(2)
        Me.byDate.Name = "byDate"
        Me.byDate.Size = New System.Drawing.Size(85, 20)
        Me.byDate.TabIndex = 27
        Me.byDate.Text = "Before Date"
        Me.byDate.UseVisualStyleBackColor = True
        '
        'byBillNo
        '
        Me.byBillNo.Location = New System.Drawing.Point(209, 5)
        Me.byBillNo.Margin = New System.Windows.Forms.Padding(2)
        Me.byBillNo.Name = "byBillNo"
        Me.byBillNo.Size = New System.Drawing.Size(85, 20)
        Me.byBillNo.TabIndex = 26
        Me.byBillNo.Text = "By Bill No"
        Me.byBillNo.UseVisualStyleBackColor = True
        '
        'byName
        '
        Me.byName.ForeColor = System.Drawing.Color.Black
        Me.byName.Location = New System.Drawing.Point(120, 5)
        Me.byName.Margin = New System.Windows.Forms.Padding(2)
        Me.byName.Name = "byName"
        Me.byName.Size = New System.Drawing.Size(85, 20)
        Me.byName.TabIndex = 25
        Me.byName.Text = "By Name"
        Me.byName.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Search:"
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.searchBox.Location = New System.Drawing.Point(192, 37)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(413, 26)
        Me.searchBox.TabIndex = 23
        '
        'billView
        '
        Me.billView.AllowUserToAddRows = False
        Me.billView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billView.Location = New System.Drawing.Point(120, 67)
        Me.billView.Margin = New System.Windows.Forms.Padding(2)
        Me.billView.Name = "billView"
        Me.billView.RowTemplate.Height = 24
        Me.billView.Size = New System.Drawing.Size(484, 288)
        Me.billView.TabIndex = 0
        '
        'CounterSalesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 427)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CounterSalesManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Counter Sales Management"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.productDetailsPanel.ResumeLayout(False)
        Me.productDetailsPanel.PerformLayout()
        CType(Me.quantityProductNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billingRecordView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.checkAvailabilityPanel.ResumeLayout(False)
        Me.checkAvailabilityPanel.PerformLayout()
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.billView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents alertLabel As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents checkAvailabilityPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents stockView As System.Windows.Forms.DataGridView
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents conditionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents productDetailsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents detailsbrandTxt As System.Windows.Forms.TextBox
    Friend WithEvents detailsconditionTxt As System.Windows.Forms.TextBox
    Friend WithEvents detailsnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents detailsidTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents finaliseBtn As System.Windows.Forms.Button
    Friend WithEvents removeBtn As System.Windows.Forms.Button
    Friend WithEvents billingRecordView As System.Windows.Forms.DataGridView
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents quantityProductNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ic1Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents custnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ic3Txt As System.Windows.Forms.TextBox
    Friend WithEvents ic2Txt As System.Windows.Forms.TextBox
    Friend WithEvents cusSearchBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cusClearBtn As System.Windows.Forms.Button
    Friend WithEvents detailspriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents billView As System.Windows.Forms.DataGridView
    Friend WithEvents byDate As System.Windows.Forms.Button
    Friend WithEvents byBillNo As System.Windows.Forms.Button
    Friend WithEvents byName As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents addCusBtn As System.Windows.Forms.Button
    Friend WithEvents btnCloseBill As System.Windows.Forms.Button
    Friend WithEvents unpaidBtn As System.Windows.Forms.Button
    Friend WithEvents paidBtn As System.Windows.Forms.Button
    Friend WithEvents userRadio As System.Windows.Forms.RadioButton
    Friend WithEvents guestRadio As System.Windows.Forms.RadioButton
    Friend WithEvents warrantyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
