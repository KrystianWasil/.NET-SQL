Public Class SearchForm

    Public ReadOnly Property firstName As String
        Get
            Return TextBox1.Text
        End Get
    End Property

    Public ReadOnly Property lastName As String
        Get
            Return TextBox2.Text
        End Get
    End Property

    Public ReadOnly Property Pesel As String
        Get
            Return TextBox3.Text
        End Get
    End Property

End Class