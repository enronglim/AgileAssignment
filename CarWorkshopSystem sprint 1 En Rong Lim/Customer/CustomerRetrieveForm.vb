Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms

Public Class CustomerRetrieveForm
    Friend Shared selection As Integer = 0
    Friend selectionSearch As String = "CustomerName"
    Friend id As String = ""


    Private Sub BindData()
        Dim search As String = txtSearch.Text

        Dim db As New DBDataContext
        Dim rs = From c In db.Customers Where c.name.Contains(search)

        If selectionSearch = "CustomerName" Then
            rs = From c In db.Customers Where c.name.Contains(search)
        ElseIf selectionSearch.Equals("CustomerICNO") Then
            rs = From c In db.Customers Where c.customerIC.Contains(search)
        ElseIf selectionSearch.Equals("customerPassportNo") Then
            rs = From c In db.Customers Where c.passportNo.Contains(search)
        ElseIf selectionSearch.Equals("customerContactNo") Then
            rs = From c In db.Customers Where c.contactNo.Contains(search)
        Else
            rs = From c In db.Customers Where c.name.Contains(search)
        End If
        dgvCustomer.AutoResizeColumns()
        dgvCustomer.DataSource = rs
        With dgvCustomer
            .Columns(0).HeaderText = "Customer Name"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "I/C No"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Gender"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "Passport No"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "Contact No"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Address"
            .Columns(5).Width = 200
            .Columns(6).HeaderText = "Email"
            .Columns(6).Width = 150
            .Columns(7).HeaderText = "Race"
            .Columns(7).Width = 100
            .Columns(8).HeaderText = "Status"
            .Columns(8).Width = 100
            .Columns(9).HeaderText = "Service Count"
            .Columns(9).Width = 100

        End With
        dgvCustomer.ClearSelection()
        dgvCustomer.CurrentCell = Nothing
    End Sub

    Private Sub CustomerRetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BindData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
    End Sub

    Private Sub byCustomerName_Click(sender As Object, e As EventArgs) Handles byCustomerName.Click
        byCustomerName.ForeColor = Color.MediumBlue
        byCustomerIC.ForeColor = Color.Black
        byCustomerPassport.ForeColor = Color.Black
        btnContactNo.ForeColor = Color.Black
        selectionSearch = "CustomerName"
        BindData()
    End Sub

    Private Sub byCustomerIC_Click(sender As Object, e As EventArgs) Handles byCustomerIC.Click
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.MediumBlue
        byCustomerPassport.ForeColor = Color.Black
        btnContactNo.ForeColor = Color.Black
        selectionSearch = "CustomerICNO"
        BindData()
    End Sub

    Private Sub byCustomerPassport_Click(sender As Object, e As EventArgs) Handles byCustomerPassport.Click
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.Black
        byCustomerPassport.ForeColor = Color.MediumBlue
        btnContactNo.ForeColor = Color.Black
        selectionSearch = "customerPassportNo"
        BindData()
    End Sub




    Private Sub btnContactNo_Click(sender As Object, e As EventArgs) Handles btnContactNo.Click
        byCustomerName.ForeColor = Color.Black
        byCustomerIC.ForeColor = Color.Black
        byCustomerPassport.ForeColor = Color.Black
        btnContactNo.ForeColor = Color.MediumBlue
        selectionSearch = "customerContactNo"
        BindData()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        CustomerInsertForm.ShowDialog()
        BindData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim db As New DBDataContext()

            Dim s As Customer = db.Customers.FirstOrDefault(Function(o) o.customerIC = id)


            Dim result As Integer = MessageBox.Show("Are you Want to Delete Customer name " & s.name & " and Customer IC " & s.customerIC & " ? ", "Customer Delete Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                db.Customers.DeleteOnSubmit(s)
                db.SubmitChanges()
                MessageBox.Show("Customer Record Deleted.", "Customer Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf result = DialogResult.No Then

            End If
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record, Or this record have used in others records", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.RowHeaderMouseClick
        Dim i As Integer = e.RowIndex

        id = CStr(dgvCustomer.Rows(i).Cells(1).Value)

        'Dim db As New DBDataContext()
        's = db.Customers.FirstOrDefault(Function(o) o.customerIC = id)

        'If s Is Nothing Then
        '    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Close()
        '    Return

        'End If
    End Sub
    Private Sub dgvCustomer_CellContentDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.RowHeaderMouseDoubleClick
        Dim i As Integer = e.RowIndex

        id = CStr(dgvCustomer.Rows(i).Cells(1).Value)
        Dim db As New DBDataContext()
        Dim s As Customer = db.Customers.FirstOrDefault(Function(o) o.customerIC = id)
        If selection = 1 Then
            CustomerCarInsertForm.txtCustomerName.Text = s.name.ToString
            CustomerCarInsertForm.lblCustomerIC.Text = s.customerIC.ToString
            CustomerCarInsertForm.lblCustomerEmpty.Visible = False
            CustomerCarUpdateForm.txtCustomerName.Text = s.name.ToString
            CustomerCarUpdateForm.lblCustomerIC.Text = s.customerIC.ToString
            Me.Close()
        End If
        selection = 0
        'Dim db As New DBDataContext()
        's = db.Customers.FirstOrDefault(Function(o) o.customerIC = id)

        'If s Is Nothing Then
        '    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Close()
        '    Return

        'End If
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            CustomerUpdateForm.SelectedId = id
            CustomerUpdateForm.ShowDialog()
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
