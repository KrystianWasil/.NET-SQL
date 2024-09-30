Imports System.Data.SqlClient
Imports System.Configuration

Public Class LoginForm1

    Private Sub LogInButton1Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton1.Click
        Dim login As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(login) Then
            ErrorProvider1.SetError(UsernameTextBox, "Login nie moze byc pusty")
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            ErrorProvider1.SetError(PasswordTextBox, "Haslo nie moze byc puste")
            Return
        End If

        If Not CheckLogin(login, password) Then
            ErrorProvider1.SetError(PasswordTextBox, "Niepoprawne haslo lub login")
            Return
        End If

        Dim mainForm As New MainForm()
        mainForm.LoggedInUser = login
        mainForm.Show()
        Me.Hide()
    End Sub






    Private Sub RegisterButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterButton.Click
        Dim regForm As New RegisterForm
        regForm.ShowDialog()

    End Sub

    Private Function CheckLogin(login As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            connection.Open()

            Dim adapter As New SqlDataAdapter("SELECT * FROM Employee WHERE login = @login", connection)
            adapter.SelectCommand.Parameters.AddWithValue("@login", login)

            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "Employee")

            If dataSet.Tables("Employee").Rows.Count > 0 Then
                Dim storedPassword As String = dataSet.Tables("Employee").Rows(0)("password_hash").ToString()
                If storedPassword = password Then
                    isAuthenticated = True
                End If
            End If

            connection.Close()
        End Using

        Return isAuthenticated
    End Function



End Class
