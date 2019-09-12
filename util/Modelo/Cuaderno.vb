Public Class Cuaderno
    Inherits Util
    Private codigo As Integer
    Sub New()

    End Sub
    Public Property pCodigo As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Sub New(ByVal color As String, ByVal marca As String, ByVal Trazo As String, ByVal codigo As Integer)

        Me.pCodigo = codigo
        MyBase.pColor = color
        MyBase.pMarca = marca
        MyBase.pTrazo = Trazo
    End Sub

    Public Overloads Sub escribir()

    End Sub
End Class
