
Public MustInherit Class Util
    Private color As String
    Private marca As String
    Private trazo As String

    Sub New()

    End Sub

    Public Property pMarca As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property


    Public Property pColor As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    Public Property pTrazo As String
        Get
            Return trazo

        End Get
        Set(value As String)
            trazo = value
        End Set
    End Property

    Public Sub escribir()

    End Sub

    Public Sub pintar()

    End Sub

End Class
