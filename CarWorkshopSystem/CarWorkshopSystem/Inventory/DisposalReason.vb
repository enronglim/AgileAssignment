Public Class DisposalReason
    Friend reasonDisposal As String
    Friend disposalQuantity As Integer
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub binBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Try
            If reasonBox.Text <> "" And CInt(quantityTxt.Text) <= Inventory.tempQuantity Then
                reasonDisposal = reasonBox.Text
                disposalQuantity = CInt(quantityTxt.Text)
                Me.Close()
            Else
                MessageBox.Show("Please specify the reason for transfer and quantity that does not exceed the initial value.")
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Public Sub initialQuantity()
        quantityTxt.Text = Inventory.tempQuantity.ToString()
    End Sub

    Private Sub DisposalReason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialQuantity()
    End Sub
End Class