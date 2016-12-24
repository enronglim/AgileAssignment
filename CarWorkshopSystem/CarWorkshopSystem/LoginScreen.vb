Public Class LoginScreen
    Private count As Integer = 0
    Public Shared staffId As String
    Public Shared staffName As String
    Public Shared staffPosition As String
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim id = UsernameTextBox.Text.ToString
        Dim password = PasswordTextBox.Text
        Dim db As New DBDataContext
        Dim rs = From staff In db.Staffs
                    Where staff.name = id And staff.password = password And staff.status = "Available"
                    Select staff.name, staff.staffIC, staff.position

        If (rs.Any = True) Then
            For Each item In rs
                staffId = item.staffIC
                staffName = item.name
                staffPosition = item.position
            Next
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
            Dim r = New MainPageForm
            Call r.ShowDialog()
            Me.Close()
        Else
            If (count = 0) Then
                MessageBox.Show("Invalid username or password. Please try again. You have 2 more chances", "Failed Logging", MessageBoxButtons.OK, MessageBoxIcon.Error)
                count += 1
            ElseIf (count = 1) Then
                MessageBox.Show("Invalid username or password. Please try again. You have 1 more chances", "Failed Logging", MessageBoxButtons.OK, MessageBoxIcon.Error)
                count += 1
            Else
                MessageBox.Show("System close due to fail login.", "Failed Logging", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            'UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            PasswordTextBox.Focus()
        End If
    End Sub
End Class