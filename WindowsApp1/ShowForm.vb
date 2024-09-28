Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ShowForm

    Private Property _pesel As String
    Public Property Pesel As String
        Get
            Return _pesel
        End Get
        Set(value As String)
            _pesel = value
        End Set
    End Property

    Private Sub ShowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToGridView()
    End Sub

    Public Sub LoadDataToGridView()
        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("CONNECTION").ToString())
            Dim query As String = "SELECT * FROM Users WHERE PESEL = @Pesel"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Pesel", Pesel)

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            connection.Open()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

            DataGridView1.Columns(0).HeaderText = "Imię"
            DataGridView1.Columns(1).HeaderText = "Nazwisko"
            DataGridView1.Columns(2).HeaderText = "Email"
            DataGridView1.Columns(3).HeaderText = "PESEL"
            DataGridView1.Columns(4).HeaderText = "Numer telefonu"
            DataGridView1.Columns(5).HeaderText = "Adres"

        End Using
    End Sub
End Class
