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
        Me.btnInventoryControl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gbMaintain = New System.Windows.Forms.GroupBox()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.gbService = New System.Windows.Forms.GroupBox()
        Me.btnCollection = New System.Windows.Forms.Button()
        Me.btnCounterSales = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.gbInventory.Controls.Add(Me.Label3)
        Me.gbInventory.Controls.Add(Me.btnInventoryControl)
        Me.gbInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInventory.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbInventory.Location = New System.Drawing.Point(10, 248)
        Me.gbInventory.Name = "gbInventory"
        Me.gbInventory.Size = New System.Drawing.Size(200, 64)
        Me.gbInventory.TabIndex = 95
        Me.gbInventory.TabStop = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inventory                     "
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
        Me.gbMaintain.Controls.Add(Me.btnStaff)
        Me.gbMaintain.Controls.Add(Me.Label4)
        Me.gbMaintain.Controls.Add(Me.btnCustomer)
        Me.gbMaintain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMaintain.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbMaintain.Location = New System.Drawing.Point(12, 349)
        Me.gbMaintain.Name = "gbMaintain"
        Me.gbMaintain.Size = New System.Drawing.Size(200, 69)
        Me.gbMaintain.TabIndex = 98
        Me.gbMaintain.TabStop = False
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
        Me.btnCustomer.Location = New System.Drawing.Point(2, 28)
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
        Me.gbService.Controls.Add(Me.btnCollection)
        Me.gbService.Controls.Add(Me.btnCounterSales)
        Me.gbService.Controls.Add(Me.Label2)
        Me.gbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbService.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbService.Location = New System.Drawing.Point(12, 88)
        Me.gbService.Name = "gbService"
        Me.gbService.Size = New System.Drawing.Size(200, 109)
        Me.gbService.TabIndex = 99
        Me.gbService.TabStop = False
        '
        'btnCollection
        '
        Me.btnCollection.BackColor = System.Drawing.Color.White
        Me.btnCollection.Location = New System.Drawing.Point(-2, 71)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(201, 37)
        Me.btnCollection.TabIndex = 4
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCollection.UseVisualStyleBackColor = False
        '
        'btnCounterSales
        '
        Me.btnCounterSales.BackColor = System.Drawing.Color.White
        Me.btnCounterSales.Location = New System.Drawing.Point(0, 28)
        Me.btnCounterSales.Name = "btnCounterSales"
        Me.btnCounterSales.Size = New System.Drawing.Size(200, 37)
        Me.btnCounterSales.TabIndex = 2
        Me.btnCounterSales.Text = "Counter Sales"
        Me.btnCounterSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCounterSales.UseVisualStyleBackColor = False
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInventoryControl As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gbMaintain As System.Windows.Forms.GroupBox
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents gbService As System.Windows.Forms.GroupBox
    Friend WithEvents btnCollection As System.Windows.Forms.Button
    Friend WithEvents btnCounterSales As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
