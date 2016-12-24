Public Class TransferMessage
    Dim messageLabel As String
    Dim buttonSelect As Integer

    Friend selectionI As Integer
    Private Sub TransferMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = "Where would you like to transfer the record, " + Inventory.tempName + " to?"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles disposeBtn.Click
        selectionI = 1
        TransferDisposable.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles binBtn.Click
        selectionI = 2
        DisposalReason.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        selectionI = 3
        Me.Close()
    End Sub
End Class