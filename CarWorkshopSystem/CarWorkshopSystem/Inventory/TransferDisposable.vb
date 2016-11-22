Public Class TransferDisposable

    Friend disposalType As String
    Friend disposalDescription As String
    Friend disposalQuantity As Integer
    Friend disposalPrice As Decimal

    Private Sub TransferDisposable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        secondRadio.Select()
        initialQuantity()
    End Sub

    Public Sub initialQuantity()
        quantityTxt.Text = Inventory.tempQuantity.ToString()
        priceTxt.Text = Inventory.tempPrice.ToString()
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If CInt(quantityTxt.Text) > Inventory.tempQuantity Then
            MessageBox.Show("Please enter an equal or lower quantity of the product", "Note")
            initialQuantity()
        Else
            If secondRadio.Checked = True Then
                disposalType = "2nd Hand"
            Else
                disposalType = "Damaged"
            End If
            disposalDescription = descriptionBox.Text
            disposalQuantity = CInt(quantityTxt.Value)
            disposalPrice = CDec(priceTxt.Text)
            Me.Close()
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        disposalQuantity = 0
        descriptionBox.Text = ""
        quantityTxt.Value = 0
        Me.Close()
    End Sub
End Class