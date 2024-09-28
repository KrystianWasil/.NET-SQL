Imports System.Configuration
Imports System.Data.SqlClient

Public Class EditForm



    Private Property _pesel As String

    Public Property Pesel As String
        Get
            Return _pesel
        End Get
        Set(value As String)
            _pesel = value
        End Set
    End Property


    Private Function GetUser(pesel As String) As DataRow
        Dim userDataTable As New DataTable()

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim command As New SqlCommand("SELECT * FROM Users WHERE PESEL = @Pesel", connection)
            command.Parameters.AddWithValue("@Pesel", pesel)

            connection.Open()

            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(userDataTable)
        End Using

        If userDataTable.Rows.Count > 0 Then
            Return userDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userRow As DataRow = GetUser(_pesel)
        If userRow IsNot Nothing Then
            FirstNameTextBox.Text = userRow("firstName").ToString()
            LastNameTextBox.Text = userRow("lastName").ToString()
            EmailTextBox.Text = userRow("email").ToString()
            PeselTextBox.Text = userRow("PESEL").ToString()
            NumberTextBox.Text = userRow("number").ToString()
            AdressTextBox.Text = userRow("adress").ToString()
        Else
            MessageBox.Show("Użytkownik nie został znaleziony.")
        End If
    End Sub

    Private Function ValidateForm() As Boolean

        ErrorProvider1.Clear()

        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            ErrorProvider1.SetError(FirstNameTextBox, "Niepoprawne imię")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            ErrorProvider1.SetError(LastNameTextBox, "Niepoprawne nazwisko")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(EmailTextBox.Text) OrElse Not ValidationUtils.IsValidEmail(EmailTextBox.Text) Then
            ErrorProvider1.SetError(EmailTextBox, "Niepoprawny adres e-mail")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(PeselTextBox.Text) OrElse Not ValidationUtils.IsValidPesel(PeselTextBox.Text) Then
            ErrorProvider1.SetError(PeselTextBox, "Niepoprawny PESEL")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(NumberTextBox.Text) OrElse Not ValidationUtils.IsValidNumber(NumberTextBox.Text) Then
            ErrorProvider1.SetError(NumberTextBox, "Niepoprawny numer telefonu")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(AdressTextBox.Text) Then
            ErrorProvider1.SetError(AdressTextBox, "Niepoprawny adres")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If Not ValidateForm() Then
            MessageBox.Show("Popraw błędy w formularzu, aby kontynuować.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
                Dim command As New SqlCommand("UPDATE Users SET firstName = @FirstName, lastName = @LastName, email = @Email, PESEL = @PESEL, number = @Number, adress = @Adress WHERE PESEL = @Pesel", connection)
                command.Parameters.AddWithValue("@PESEL", _pesel)
                command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text)
                command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text)
                command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                command.Parameters.AddWithValue("@Number", NumberTextBox.Text)
                command.Parameters.AddWithValue("@Adress", AdressTextBox.Text)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As SqlException
            If ex.Number = 2627 Or ex.Number = 2601 Then
                MessageBox.Show("Użytkownik z podanymi danymi już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Wystąpił błąd: " & ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
