Public Class Animal
    Private _name As String
    Public age As Integer

    Public Sub New()
        _name = "未定"
    End Sub

    Public Property NAME() As String
        Get
            Return _name
        End Get
        Set(value As String)
            If value = "" Then
                _name = "動物"
            Else
                _name = value
            End If
        End Set
    End Property

    Public Function ageAgterFiveYear()
        Const add As Integer = 5

        Return age + add
    End Function
End Class
