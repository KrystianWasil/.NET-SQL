Imports System.Configuration
Imports System.Data.SqlClient

Public Class RegisterForm

    Private Sub RegisterButton2Clicked() Handles RegisterButton2.Click
        Dim login As String = LoginTextBox2.Text
        Dim password As String = PasswordTextBox2.Text

        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(login) Then
            ErrorProvider1.SetError(LoginTextBox2, " Login nie moze byc pusty ! ")
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            ErrorProvider1.SetError(PasswordTextBox2, " Haslo nie moze byc psute !")
            Return
        End If

        If CheckDataBase(login) Then
            ErrorProvider1.SetError(LoginTextBox2, " Login jest już zajęty ! ")
            Return
        End If

        If AddNewUser(login, password) Then
            MessageBox.Show("Rejestracja zakończona pomyślnie!")
            Me.Close()
        Else
            MessageBox.Show("Wystąpił problem podczas rejestracji. Proszę spróbować ponownie.")
        End If

    End Sub

    Private Function CheckDataBase(login As String) As Boolean
        Dim exists As Boolean = False

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim query As String = "SELECT COUNT(*) FROM Employee WHERE login = @login"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@login", login)

            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            exists = (count > 0)
        End Using

        Return exists
    End Function

    Private Function AddNewUser(login As String, password As String) As Boolean
        Dim isAdded As Boolean = False

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim command As New SqlCommand("INSERT INTO Employee (login, password_hash) VALUES (@login, @password_hash)", connection)
            command.Parameters.AddWithValue("@login", login)
            command.Parameters.AddWithValue("@password_hash", password)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            isAdded = (rowsAffected > 0)
        End Using

        Return isAdded
    End Function

End Class