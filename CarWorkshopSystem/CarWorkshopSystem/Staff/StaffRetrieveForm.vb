Public Class StaffRetrieveForm

    Friend selectionSearch As String = "StaffName"
    Friend id As String = ""
    Friend s As Staff


    Private Sub BindData()
        Dim search As String = txtSearch.Text


        Dim db As New DBDataContext
        Dim rs = From s In db.Staffs Where s.name.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate

        If selectionSearch.Equals("StaffName") Then
            rs = From s In db.Staffs Where s.name.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate
        ElseIf selectionSearch.Equals("StaffIC") Then
            rs = From s In db.Staffs Where s.staffIC.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate
        ElseIf selectionSearch.Equals("StaffPosition") Then
            rs = From s In db.Staffs Where s.position.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate
        ElseIf selectionSearch.Equals("StaffContactNo") Then
            rs = From s In db.Staffs Where s.contactNo.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate
        Else
            rs = From s In db.Staffs Where s.name.Contains(search) Select s.name, s.staffIC, s.position, s.gender, s.contactNo, s.password, s.status, s.address, s.email, s.race, s.emplomentDate
        End If
        dgvStaff.AutoResizeColumns()
        dgvStaff.DataSource = rs
        With dgvStaff
            .Columns(0).HeaderText = "Staff Name"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "I/C No"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Position"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "Gender"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "Contact No"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Password"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "Status"
            .Columns(6).Width = 100
            .Columns(7).HeaderText = "Address"
            .Columns(7).Width = 100
            .Columns(8).HeaderText = "Email"
            .Columns(8).Width = 100
            .Columns(9).HeaderText = "Race"
            .Columns(9).Width = 100
            .Columns(10).HeaderText = "EmplomentDate"
            .Columns(10).Width = 100
        End With
        dgvStaff.ClearSelection()
        dgvStaff.CurrentCell = Nothing
    End Sub




    Private Sub byStaffName_Click(sender As Object, e As EventArgs) Handles byStaffName.Click
        byStaffName.ForeColor = Color.MediumBlue
        byStaffIC.ForeColor = Color.Black
        byStaffPosition.ForeColor = Color.Black
        byStaffContactNo.ForeColor = Color.Black
        selectionSearch = "StaffName"
        BindData()
    End Sub

    Private Sub byStaffIC_Click(sender As Object, e As EventArgs) Handles byStaffIC.Click
        byStaffName.ForeColor = Color.Black
        byStaffIC.ForeColor = Color.MediumBlue
        byStaffPosition.ForeColor = Color.Black
        byStaffContactNo.ForeColor = Color.Black
        selectionSearch = "StaffIC"
        BindData()
    End Sub

    Private Sub byStaffPosition_Click(sender As Object, e As EventArgs) Handles byStaffPosition.Click
        byStaffName.ForeColor = Color.Black
        byStaffIC.ForeColor = Color.Black
        byStaffPosition.ForeColor = Color.MediumBlue
        byStaffContactNo.ForeColor = Color.Black
        selectionSearch = "StaffPosition"
        BindData()
    End Sub

    Private Sub byStaffContactNo_Click(sender As Object, e As EventArgs) Handles byStaffContactNo.Click
        byStaffName.ForeColor = Color.Black
        byStaffIC.ForeColor = Color.Black
        byStaffPosition.ForeColor = Color.Black
        byStaffContactNo.ForeColor = Color.MediumBlue
        selectionSearch = "StaffContactNo"
        BindData()
    End Sub

    Private Sub StaffRetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        StaffInsertForm.ShowDialog()
        BindData()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            StaffUpdateForm.SelectedId = id
            StaffUpdateForm.ShowDialog()
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim db As New DBDataContext()

            s = db.Staffs.FirstOrDefault(Function(o) o.staffIC = id)


            Dim result As Integer = MessageBox.Show("Are you Want to set Staff name " & s.name & " and staff IC " & s.staffIC & " ? ", "staff resign Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                s.status = "Resign"

                db.SubmitChanges()
                MessageBox.Show("Staff Record is resigned.", "Staff Resign", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf result = DialogResult.No Then

            End If
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record, Or This record have used in others records", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStaff.RowHeaderMouseClick
        Dim i As Integer = e.RowIndex

        id = CStr(dgvStaff.Rows(i).Cells(1).Value)
    End Sub


    Private Sub btnFired_Click(sender As Object, e As EventArgs) Handles btnFired.Click
        Try
            Dim db As New DBDataContext()

            s = db.Staffs.FirstOrDefault(Function(o) o.staffIC = id)


            Dim result As Integer = MessageBox.Show("Are you Want to set Staff name " & s.name & " and staff IC " & s.staffIC & " ? ", "staff fire Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                s.status = "Fired"

                db.SubmitChanges()
                MessageBox.Show("Staff Record is Fired.", "Staff Resign", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf result = DialogResult.No Then

            End If
            BindData()
        Catch ex As Exception
            MessageBox.Show("Please select Record, Or This record have used in others records", "Unselect Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class