Public Class MainPageForm
    Private Function myZero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, Convert.ToChar("0"))
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")

    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        btnUserName.Text = LoginScreen.staffName
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub


    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim r = New LoginScreen
        Call r.Show()
        Me.Close()
    End Sub

    Private Sub btnUserName_Click(sender As Object, e As EventArgs) Handles btnUserName.Click
        StaffUpdateForm.selection = 1
        StaffUpdateForm.SelectedId = LoginScreen.staffId
        StaffUpdateForm.ShowDialog()

    End Sub

   
  

  

    Private Sub btnCollection_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        PaymentRetrieveForm.ShowDialog()
    End Sub

    Private Sub btnInventoryControl_Click(sender As Object, e As EventArgs) Handles btnInventoryControl.Click
        Inventory.ShowDialog()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        CustomerRetrieveForm.ShowDialog()
    End Sub

    
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        If (LoginScreen.staffPosition <> "Manager") Then
            MessageBox.Show("Only Manager can maintain the staff, you dont have permission.", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            StaffUpdateForm.selection = 0
            StaffRetrieveForm.ShowDialog()
        End If
      
    End Sub


  
    Private Sub btnCounterSales_Click(sender As Object, e As EventArgs) Handles btnCounterSales.Click
        CounterSalesManagement.ShowDialog()
    End Sub

   
    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        WorkshopLocation.ShowDialog()
    End Sub


 


  
End Class