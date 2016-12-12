<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPageForm))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnUserName = New System.Windows.Forms.Button()
        Me.gbInventory = New System.Windows.Forms.GroupBox()
        Me.btnPreOrder = New System.Windows.Forms.Button()
        Me.btnDisposanleStocl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInventoryControl = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gbMaintain = New System.Windows.Forms.GroupBox()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnVehicle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.gbService = New System.Windows.Forms.GroupBox()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnServiceCoupon = New System.Windows.Forms.Button()
        Me.btnCollection = New System.Windows.Forms.Button()
        Me.btnWarrantyClaim = New System.Windows.Forms.Button()
        Me.btnCounterSales = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnJobSheet = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInventory.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMaintain.SuspendLayout()
        Me.gbService.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Image = Global.CarWorkshopSystem.My.Resources.Resources.images
        Me.lblTime.Location = New System.Drawing.Point(12, 46)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(171, 33)
        Me.lblTime.TabIndex = 85
        Me.lblTime.Text = "lblTime"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Image = Global.CarWorkshopSystem.My.Resources.Resources.images
        Me.lblDate.Location = New System.Drawing.Point(12, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(171, 33)
        Me.lblDate.TabIndex = 86
        Me.lblDate.Text = "lblDate"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(369, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 57)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "TH Car WorkShop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnQuit.Location = New System.Drawing.Point(1265, 17)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 33)
        Me.btnQuit.TabIndex = 89
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarWorkshopSystem.My.Resources.Resources.orange_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 621)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CarWorkshopSystem.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1350, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'btnUserName
        '
        Me.btnUserName.BackgroundImage = Global.CarWorkshopSystem.My.Resources.Resources.images
        Me.btnUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserName.Location = New System.Drawing.Point(953, 17)
        Me.btnUserName.Name = "btnUserName"
        Me.btnUserName.Size = New System.Drawing.Size(293, 37)
        Me.btnUserName.TabIndex = 93
        Me.btnUserName.Text = "Name"
        Me.btnUserName.UseVisualStyleBackColor = True
        '
        'gbInventory
        '
        Me.gbInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbInventory.Controls.Add(Me.btnPreOrder)
        Me.gbInventory.Controls.Add(Me.btnDisposanleStocl)
        Me.gbInventory.Controls.Add(Me.Label3)
        Me.gbInventory.Controls.Add(Me.btnInventoryControl)
        Me.gbInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInventory.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbInventory.Location = New System.Drawing.Point(11, 359)
        Me.gbInventory.Name = "gbInventory"
        Me.gbInventory.Size = New System.Drawing.Size(200, 142)
        Me.gbInventory.TabIndex = 95
        Me.gbInventory.TabStop = False
        '
        'btnPreOrder
        '
        Me.btnPreOrder.BackColor = System.Drawing.Color.White
        Me.btnPreOrder.Location = New System.Drawing.Point(0, 106)
        Me.btnPreOrder.Name = "btnPreOrder"
        Me.btnPreOrder.Size = New System.Drawing.Size(200, 37)
        Me.btnPreOrder.TabIndex = 3
        Me.btnPreOrder.Text = "Pre-Order"
        Me.btnPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreOrder.UseVisualStyleBackColor = False
        Me.btnPreOrder.Visible = False
        '
        'btnDisposanleStocl
        '
        Me.btnDisposanleStocl.BackColor = System.Drawing.Color.White
        Me.btnDisposanleStocl.Location = New System.Drawing.Point(0, 66)
        Me.btnDisposanleStocl.Name = "btnDisposanleStocl"
        Me.btnDisposanleStocl.Size = New System.Drawing.Size(200, 37)
        Me.btnDisposanleStocl.TabIndex = 2
        Me.btnDisposanleStocl.Text = "Disposable Stock"
        Me.btnDisposanleStocl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisposanleStocl.UseVisualStyleBackColor = False
        Me.btnDisposanleStocl.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inventory                     "
        '
        'btnInventoryControl
        '
        Me.btnInventoryControl.BackColor = System.Drawing.Color.White
        Me.btnInventoryControl.Location = New System.Drawing.Point(0, 27)
        Me.btnInventoryControl.Name = "btnInventoryControl"
        Me.btnInventoryControl.Size = New System.Drawing.Size(200, 37)
        Me.btnInventoryControl.TabIndex = 0
        Me.btnInventoryControl.Text = "Inventory Control"
        Me.btnInventoryControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryControl.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox3.Location = New System.Drawing.Point(224, 82)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1126, 621)
        Me.PictureBox3.TabIndex = 97
        Me.PictureBox3.TabStop = False
        '
        'gbMaintain
        '
        Me.gbMaintain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbMaintain.Controls.Add(Me.btnReview)
        Me.gbMaintain.Controls.Add(Me.BtnReport)
        Me.gbMaintain.Controls.Add(Me.Button14)
        Me.gbMaintain.Controls.Add(Me.btnStaff)
        Me.gbMaintain.Controls.Add(Me.btnVehicle)
        Me.gbMaintain.Controls.Add(Me.Label4)
        Me.gbMaintain.Controls.Add(Me.btnCustomer)
        Me.gbMaintain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMaintain.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbMaintain.Location = New System.Drawing.Point(11, 507)
        Me.gbMaintain.Name = "gbMaintain"
        Me.gbMaintain.Size = New System.Drawing.Size(200, 182)
        Me.gbMaintain.TabIndex = 98
        Me.gbMaintain.TabStop = False
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.Color.White
        Me.btnReview.Location = New System.Drawing.Point(108, 67)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(92, 37)
        Me.btnReview.TabIndex = 7
        Me.btnReview.Text = "Review"
        Me.btnReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReview.UseVisualStyleBackColor = False
        Me.btnReview.Visible = False
        '
        'BtnReport
        '
        Me.BtnReport.BackColor = System.Drawing.Color.White
        Me.BtnReport.Location = New System.Drawing.Point(0, 107)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(200, 37)
        Me.BtnReport.TabIndex = 6
        Me.BtnReport.Text = "Report View"
        Me.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReport.UseVisualStyleBackColor = False
        Me.BtnReport.Visible = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(0, 146)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(200, 37)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "Workshop Profile"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = False
        Me.Button14.Visible = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.White
        Me.btnStaff.Location = New System.Drawing.Point(118, 28)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(82, 37)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnVehicle
        '
        Me.btnVehicle.BackColor = System.Drawing.Color.White
        Me.btnVehicle.Location = New System.Drawing.Point(0, 67)
        Me.btnVehicle.Name = "btnVehicle"
        Me.btnVehicle.Size = New System.Drawing.Size(102, 37)
        Me.btnVehicle.TabIndex = 2
        Me.btnVehicle.Text = "Vehicle"
        Me.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicle.UseVisualStyleBackColor = False
        Me.btnVehicle.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Maintain                   "
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.White
        Me.btnCustomer.Location = New System.Drawing.Point(0, 28)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(112, 37)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'gbService
        '
        Me.gbService.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbService.Controls.Add(Me.btnAppointment)
        Me.gbService.Controls.Add(Me.btnServiceCoupon)
        Me.gbService.Controls.Add(Me.btnCollection)
        Me.gbService.Controls.Add(Me.btnWarrantyClaim)
        Me.gbService.Controls.Add(Me.btnCounterSales)
        Me.gbService.Controls.Add(Me.Label2)
        Me.gbService.Controls.Add(Me.btnJobSheet)
        Me.gbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbService.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbService.Location = New System.Drawing.Point(12, 88)
        Me.gbService.Name = "gbService"
        Me.gbService.Size = New System.Drawing.Size(200, 264)
        Me.gbService.TabIndex = 99
        Me.gbService.TabStop = False
        '
        'btnAppointment
        '
        Me.btnAppointment.BackColor = System.Drawing.Color.White
        Me.btnAppointment.Location = New System.Drawing.Point(0, 188)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(201, 37)
        Me.btnAppointment.TabIndex = 6
        Me.btnAppointment.Text = "Appointment"
        Me.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.UseVisualStyleBackColor = False
        Me.btnAppointment.Visible = False
        '
        'btnServiceCoupon
        '
        Me.btnServiceCoupon.BackColor = System.Drawing.Color.White
        Me.btnServiceCoupon.Location = New System.Drawing.Point(0, 148)
        Me.btnServiceCoupon.Name = "btnServiceCoupon"
        Me.btnServiceCoupon.Size = New System.Drawing.Size(200, 37)
        Me.btnServiceCoupon.TabIndex = 5
        Me.btnServiceCoupon.Text = "Service Coupon"
        Me.btnServiceCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServiceCoupon.UseVisualStyleBackColor = False
        Me.btnServiceCoupon.Visible = False
        '
        'btnCollection
        '
        Me.btnCollection.BackColor = System.Drawing.Color.White
        Me.btnCollection.Location = New System.Drawing.Point(-1, 228)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(201, 37)
        Me.btnCollection.TabIndex = 4
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCollection.UseVisualStyleBackColor = False
        Me.btnCollection.Visible = False
        '
        'btnWarrantyClaim
        '
        Me.btnWarrantyClaim.BackColor = System.Drawing.Color.White
        Me.btnWarrantyClaim.Location = New System.Drawing.Point(0, 107)
        Me.btnWarrantyClaim.Name = "btnWarrantyClaim"
        Me.btnWarrantyClaim.Size = New System.Drawing.Size(200, 37)
        Me.btnWarrantyClaim.TabIndex = 3
        Me.btnWarrantyClaim.Text = "Warranty Claim"
        Me.btnWarrantyClaim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWarrantyClaim.UseVisualStyleBackColor = False
        Me.btnWarrantyClaim.Visible = False
        '
        'btnCounterSales
        '
        Me.btnCounterSales.BackColor = System.Drawing.Color.White
        Me.btnCounterSales.Location = New System.Drawing.Point(-1, 28)
        Me.btnCounterSales.Name = "btnCounterSales"
        Me.btnCounterSales.Size = New System.Drawing.Size(200, 37)
        Me.btnCounterSales.TabIndex = 2
        Me.btnCounterSales.Text = "Counter Sales"
        Me.btnCounterSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCounterSales.UseVisualStyleBackColor = False
        Me.btnCounterSales.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service                     "
        '
        'btnJobSheet
        '
        Me.btnJobSheet.BackColor = System.Drawing.Color.White
        Me.btnJobSheet.Location = New System.Drawing.Point(-1, 66)
        Me.btnJobSheet.Name = "btnJobSheet"
        Me.btnJobSheet.Size = New System.Drawing.Size(200, 37)
        Me.btnJobSheet.TabIndex = 0
        Me.btnJobSheet.Text = "JobSheet"
        Me.btnJobSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJobSheet.UseVisualStyleBackColor = False
        Me.btnJobSheet.Visible = False
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 701)
        Me.Controls.Add(Me.gbService)
        Me.Controls.Add(Me.gbMaintain)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.gbInventory)
        Me.Controls.Add(Me.btnUserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 0)
        Me.MaximumSize = New System.Drawing.Size(1366, 740)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "MainPageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Car Service and Sales Information Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInventory.ResumeLayout(False)
        Me.gbInventory.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMaintain.ResumeLayout(False)
        Me.gbMaintain.PerformLayout()
        Me.gbService.ResumeLayout(False)
        Me.gbService.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnUserName As System.Windows.Forms.Button
    Friend WithEvents gbInventory As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisposanleStocl As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInventoryControl As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gbMaintain As System.Windows.Forms.GroupBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnVehicle As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents gbService As System.Windows.Forms.GroupBox
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnServiceCoupon As System.Windows.Forms.Button
    Friend WithEvents btnCollection As System.Windows.Forms.Button
    Friend WithEvents btnWarrantyClaim As System.Windows.Forms.Button
    Friend WithEvents btnCounterSales As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnJobSheet As System.Windows.Forms.Button
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents btnPreOrder As System.Windows.Forms.Button
    Friend WithEvents btnReview As System.Windows.Forms.Button
End Class
