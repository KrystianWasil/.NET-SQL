Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AddForm

    Private _pesel As Integer

    'gettery 



    Public ReadOnly Property FirstName As String
        Get
            Return firstNameTextBox.Text
        End Get
    End Property

    Public ReadOnly Property LastName As String
        Get
            Return lastNameTextBox.Text
        End Get
    End Property

    Public ReadOnly Property Email As String
        Get
            Return emailTextBox.Text
        End Get
    End Property

    Public ReadOnly Property Pesel As String
        Get
            Return peselTextBox.Text
        End Get
    End Property

    Public ReadOnly Property Number As String
        Get
            Return numberTextBox.Text
        End Get
    End Property

    Public ReadOnly Property Adress As String
        Get
            Return adressTextBox.Text
        End Get
    End Property


    Private Sub AddUser(firstName As String, lastName As String, email As String, pesel As String, number As String, adress As String)
        Try
            Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
                Dim query As String = "INSERT INTO Users (firstName, lastName, email, pesel, number, adress) " &
                                      "VALUES (@FirstName, @LastName, @Email, @Pesel, @Number, @Adress); "

                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@LastName", lastName)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Pesel", pesel)
                command.Parameters.AddWithValue("@Number", number)
                command.Parameters.AddWithValue("@Adress", adress)

                connection.Open()

                command.ExecuteScalar()
            End Using
        Catch ex As SqlException
            MessageBox.Show("Wystąpił błąd: " & ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub









    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(firstNameTextBox.Text) Then
            ErrorProvider1.SetError(firstNameTextBox, "Niepoprawne imię")
            Return
        End If

        If String.IsNullOrWhiteSpace(lastNameTextBox.Text) Then
            ErrorProvider1.SetError(lastNameTextBox, "Niepoprawn nazwisko")
            Return
        End If

        If String.IsNullOrWhiteSpace(emailTextBox.Text) OrElse Not ValidationUtils.IsValidEmail(emailTextBox.Text) Then
            ErrorProvider1.SetError(emailTextBox, "Niepoprawny adres e-mail")
            Return
        End If

        If String.IsNullOrWhiteSpace(peselTextBox.Text) OrElse Not ValidationUtils.IsValidPesel(peselTextBox.Text) Then
            ErrorProvider1.SetError(peselTextBox, "Niepoprawny PESEL")
            Return
        End If

        If String.IsNullOrWhiteSpace(numberTextBox.Text) OrElse Not ValidationUtils.IsValidNumber(numberTextBox.Text) Then
            ErrorProvider1.SetError(numberTextBox, "Niepoprawny numer")
            Return
        End If

        If String.IsNullOrWhiteSpace(adressTextBox.Text) Then
            ErrorProvider1.SetError(adressTextBox, "Niepoprawny adres")
            Return
        End If

        AddUser(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, peselTextBox.Text, numberTextBox.Text, adressTextBox.Text)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class