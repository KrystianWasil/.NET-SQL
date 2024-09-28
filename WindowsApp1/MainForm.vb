Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net.Configuration


Public Class MainForm



    Public Property LoggedInUser As String

    Private CacheDataTable As DataTable
    'main 

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(LoggedInUser) Then

            LogInfoLabel.Text = "Zalogowany jako: " & LoggedInUser
        End If
        CacheDataTable = LoadDataFromDatabase()
        LoadDataToListView()
    End Sub




    'ladowanie danych 

    Private Function LoadDataFromDatabase() As DataTable
        Dim dataTable = New DataTable()

        dataTable.Columns.Add("firstName")
        dataTable.Columns.Add("lastName")
        dataTable.Columns.Add("PESEL")

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim command As New SqlCommand("SELECT firstName, lastName, PESEL FROM Users", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            dataTable.Load(reader)
        End Using

        Return dataTable

    End Function

    'main
    Private Sub LoadDataToListView(Optional firstName As String = "", Optional lastName As String = "", Optional pesel As String = "")
        If CacheDataTable Is Nothing Then
            MessageBox.Show("Brak danych do wyświetlenia.")
            Return
        End If

        ListView1.View = View.Details
        ListView1.Columns.Clear()
        ListView1.Columns.Add(" ", 30)
        ListView1.Columns.Add("Imie", 200)
        ListView1.Columns.Add("Nazwisko", 200)

        ListView1.Items.Clear()

        Dim filteredData As DataTable = CacheDataTable.Clone()

        For Each row As DataRow In CacheDataTable.Rows
            If (String.IsNullOrEmpty(firstName) Or row("firstName").ToString().Contains(firstName)) AndAlso
           (String.IsNullOrEmpty(lastName) Or row("lastName").ToString().Contains(lastName)) AndAlso
           (String.IsNullOrEmpty(pesel) Or row("PESEL").ToString().Contains(pesel)) Then
                filteredData.ImportRow(row)
            End If
        Next

        Dim items As New List(Of ListViewItem)()

        For Each row As DataRow In filteredData.Rows
            Dim item As New ListViewItem()
            item.SubItems.Add(row("firstName").ToString())
            item.SubItems.Add(row("lastName").ToString())
            item.Tag = row("PESEL").ToString()

            items.Add(item)
        Next
        ListView1.Items.AddRange(items.ToArray())

    End Sub


    Private Sub SearchButtonClicked(sender As Object, e As EventArgs) Handles searchButton.Click
        Using searchForm As New SearchForm()
            If searchForm.ShowDialog() = DialogResult.OK Then
                Dim firstName As String = searchForm.firstName
                Dim lastName As String = searchForm.lastName
                Dim pesel As String = searchForm.Pesel


                LoadDataToListView(firstName, lastName, pesel)
            End If

        End Using
    End Sub




    Private Sub AddButtonClicked(sender As Object, e As EventArgs) Handles addButton.Click
        Using addForm As New AddForm()
            If addForm.ShowDialog() = DialogResult.OK Then
                Dim firstName As String = addForm.FirstName
                Dim lastName As String = addForm.LastName
                Dim pesel As String = addForm.Pesel


                If Not String.IsNullOrWhiteSpace(pesel) Then

                    Dim item As New ListViewItem(pesel)
                    item.SubItems.Add(firstName)
                    item.SubItems.Add(lastName)
                    item.Tag = pesel

                    ListView1.Items.Add(item)

                    If CacheDataTable IsNot Nothing Then
                        Dim newRow As DataRow = CacheDataTable.NewRow()
                        newRow("firstName") = firstName
                        newRow("lastName") = lastName
                        newRow("PESEL") = pesel
                        CacheDataTable.Rows.Add(newRow)
                    End If
                Else
                    MessageBox.Show("Niepoprawny PESEL. Użytkownik nie został dodany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub


    Private Sub EditButtonClicked(sender As Object, e As EventArgs) Handles mainEditButton.Click
        Dim selectedItem As ListViewItem = Nothing

        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                If selectedItem IsNot Nothing Then
                    MessageBox.Show("Wybierz dokładnie jednego użytkownika do edycji.")
                    Return
                End If
                selectedItem = item
            End If
        Next

        If selectedItem Is Nothing Then
            MessageBox.Show("Wybierz jednego użytkownika do edycji.")
        Else

            Dim pesel As String = selectedItem.Tag

            Using editForm As New EditForm()
                editForm.Pesel = pesel
                If editForm.ShowDialog() = DialogResult.OK Then
                    selectedItem.SubItems(1).Text = editForm.FirstNameTextBox.Text
                    selectedItem.SubItems(2).Text = editForm.LastNameTextBox.Text
                End If
            End Using
        End If
    End Sub

    Private Sub selectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        For Each item As ListViewItem In ListView1.Items
            item.Checked = True
        Next
    End Sub
    Private Sub unselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For Each item As ListViewItem In ListView1.Items
            item.Checked = False
        Next
    End Sub
    Private Sub refreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click, ToolStripMenuItem2.Click
        LoadDataToListView()
    End Sub
    Private Sub DeleteUserFromDatabase(pesel As String)
        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim command As New SqlCommand("DELETE FROM Users WHERE PESEL = @Pesel", connection)
            command.Parameters.AddWithValue("@Pesel", pesel)
            connection.Open()

            command.ExecuteNonQuery()
        End Using

    End Sub
    Private Sub RemoveButtonClicked(sender As Object, e As EventArgs) Handles MainRemoveButton.Click
        Dim result As DialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczonych użytkowników?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Dim anyDeleted As Boolean = False

                For Each item As ListViewItem In ListView1.Items
                    If item.Checked Then
                        Dim pesel As String = item.Tag
                        DeleteUserFromDatabase(pesel)

                        ListView1.Items.Remove(item)
                        anyDeleted = True
                    End If
                Next

                If anyDeleted Then
                    MessageBox.Show("Zaznaczeni użytkownicy zostali pomyślnie usunięci.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nie zaznaczono żadnych użytkowników do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Wystąpił błąd podczas usuwania użytkowników: " & ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub ShowButtonClicked(sender As Object, e As EventArgs) Handles mainShowButton.Click
        Dim selectedPesel As String = Nothing
        Dim selectedCount As Integer = 0

        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                selectedPesel = item.Tag
                selectedCount += 1
            End If
        Next

        If selectedCount = 0 Then
            MessageBox.Show("Proszę zaznaczyć co najmniej jednego użytkownika.", "Brak zaznaczonych użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If selectedCount > 1 Then
            MessageBox.Show("Proszę zaznaczyć tylko jednego użytkownika do wyświetlenia.", "Wybór użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim showForm As New ShowForm()
        showForm.Pesel = selectedPesel
        showForm.LoadDataToGridView()
        showForm.ShowDialog()
    End Sub





    Public Sub RefreshButtonClicked(sender As Object, e As EventArgs) Handles mainRefreshButton.Click
        LoadDataToListView()
    End Sub


End Class