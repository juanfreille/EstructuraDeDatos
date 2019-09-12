
Public Class Lapiz
    Inherits Util
    Private tipoGrafito As String

    Sub New()

    End Sub

    Sub New(ByVal color As String, ByVal marca As String, ByVal Trazo As String, ByVal TipoGrafico As String)

        Me.tipoGrafito = TipoGrafico ' me. se utiliza para el atributo de la clase
        MyBase.pColor = color ' Mybase. se utiliza para el atributo de la super clase
        MyBase.pMarca = marca
        MyBase.pTrazo = Trazo

    End Sub



    Public Property pTipoGrafito As String
        Get
            Return tipoGrafito
        End Get
        Set(value As String)
            tipoGrafito = value
        End Set
    End Property

    Public Sub dibujar()

    End Sub

    Public Overloads Sub escribir()

    End Sub

End Class
