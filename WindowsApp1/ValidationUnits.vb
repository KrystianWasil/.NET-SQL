Imports System.Text.RegularExpressions

Public Class ValidationUtils
    Public Shared Function IsValidEmail(email As String) As Boolean
        Return Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function

    Public Shared Function IsValidPesel(pesel As String) As Boolean
        Return Regex.IsMatch(pesel, "^\d{11}$")
    End Function

    Public Shared Function IsValidNumber(number As String) As Boolean
        Return Regex.IsMatch(number, "^\d{9}$")
    End Function
End Class


