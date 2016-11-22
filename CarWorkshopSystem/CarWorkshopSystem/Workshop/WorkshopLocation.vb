Public Class WorkshopLocation

    Friend tempID As String
    Friend tempReg As String
    Friend tempEmail As String
    Friend tempState As String
    Friend tempAdd As String
    Friend tempContact As String
    Friend tempOD As Date
    Friend tempStatus As String

    Dim checkButton As Integer 

    Private Sub refreshViewer()
        Try
            Dim dbCheck As New DBDataContext
            Dim rsCheck = From workshopDB In dbCheck.Workshops
                          Select workshopDB

            workshopView.DataSource = rsCheck

            workshopView.Columns(0).HeaderText = "Workshop ID"
            workshopView.Columns(1).HeaderText = "Registration No"
            workshopView.Columns(2).HeaderText = "Email"
            workshopView.Columns(3).HeaderText = "State"
            workshopView.Columns(4).HeaderText = "Address"
            workshopView.Columns(5).HeaderText = "Contact"
            workshopView.Columns(6).HeaderText = "Date"
            workshopView.Columns(7).HeaderText = "Status"

            workshopView.ClearSelection()
            workshopView.CurrentCell = Nothing

            workshopView.AutoResizeColumns()
            workshopView.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnsMode.AllCells
            workshopView.AutoResizeRows()
            workshopView.AutoSizeRowsMode() = DataGridViewAutoSizeRowsMode.AllCells
        Catch ex As Exception
            MessageBox.Show("Error detected while connecting to the database. Contact your local system Administrator", "Error")
        End Try
    End Sub
    Private Sub WorkshopLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshViewer()
        byState.ForeColor = System.Drawing.Color.MediumBlue
        checkButton = 1
        searchboxFilter()
    End Sub

    Private Sub WorkshopLocation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        refreshViewer()
        tempID = ""
    End Sub

    Private Sub searchboxFilter()
        Dim searchText As String = searchBox.Text

        Dim dbWorkshop As New DBDataContext
        If checkButton = 1 Then
            Dim rsWorkshop = From all In dbWorkshop.Workshops
                             Where all.workshopState.Contains(searchText)

            workshopView.DataSource = rsWorkshop

        ElseIf checkButton = 2 Then
            Dim rsWorkshop = From all In dbWorkshop.Workshops
                             Where all.workshopID.Contains(searchText)

            workshopView.DataSource = rsWorkshop

        ElseIf checkButton = 3 Then
            Dim rsWorkshop = From all In dbWorkshop.Workshops
                             Where all.workshopEmail.Contains(searchText)

            workshopView.DataSource = rsWorkshop

        ElseIf checkButton = 4 Then
            Dim rsWorkshop = From all In dbWorkshop.Workshops
                             Where all.workshopStatus.Contains(searchText)

            workshopView.DataSource = rsWorkshop
        End If
    End Sub

    Private Sub byState_Click(sender As Object, e As EventArgs) Handles byState.Click
        byID.ForeColor = Color.Black
        byState.ForeColor = System.Drawing.Color.MediumBlue
        byEmail.ForeColor = Color.Black
        byStatus.ForeColor = Color.Black

        checkButton = 1

        searchboxFilter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles byStatus.Click
        byID.ForeColor = Color.Black
        byState.ForeColor = Color.Black
        byEmail.ForeColor = Color.Black
        byStatus.ForeColor = System.Drawing.Color.MediumBlue

        checkButton = 4
        searchboxFilter()
    End Sub

    Private Sub byRegistration_Click(sender As Object, e As EventArgs) Handles byEmail.Click
        byID.ForeColor = Color.Black
        byState.ForeColor = Color.Black
        byEmail.ForeColor = System.Drawing.Color.MediumBlue
        byStatus.ForeColor = Color.Black

        checkButton = 3
        searchboxFilter()
    End Sub

    Private Sub byID_Click(sender As Object, e As EventArgs) Handles byID.Click
        byID.ForeColor = System.Drawing.Color.MediumBlue
        byState.ForeColor = Color.Black
        byEmail.ForeColor = Color.Black
        byStatus.ForeColor = Color.Black

        checkButton = 2

        searchboxFilter()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddWorkshop.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub workshopView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles workshopView.CellClick
        tempID = workshopView.CurrentRow.Cells(0).Value.ToString
        tempReg = workshopView.CurrentRow.Cells(1).Value.ToString 'As String
        tempEmail = workshopView.CurrentRow.Cells(2).Value.ToString 'As String
        tempState = workshopView.CurrentRow.Cells(3).Value.ToString 'As String
        tempAdd = workshopView.CurrentRow.Cells(4).Value.ToString 'String
        tempContact = workshopView.CurrentRow.Cells(5).Value.ToString 'As String
        tempOD = CDate(workshopView.CurrentRow.Cells(6).Value) 'As Date
        tempStatus = workshopView.CurrentRow.Cells(7).Value.ToString 'As String

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tempID <> "" Then
            UpdateWorkshop.ShowDialog()
        Else
            MessageBox.Show("Please select a record from the Table", "Note")
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchboxFilter()
    End Sub
End Class