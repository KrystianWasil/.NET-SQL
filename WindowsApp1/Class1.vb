Imports System.Net.Security

Public Class User
    Public Property imie As String
    Public Property nazwisko As String
    Public Property email As String
    Public Property pesel As String
    Public Property numer_tel As String
    Public Property adres As String



    Public Sub New(imie As String, nazwisko As String, email As String, pesel As String, numerTelefonu As String, adres As String)
        Me.imie = imie
        Me.nazwisko = nazwisko
        Me.email = email
        Me.pesel = pesel
        Me.numer_tel = numerTelefonu
        Me.adres = adres
    End Sub


End Class
