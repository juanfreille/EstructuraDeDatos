
Public Class Fibra
    Inherits Util
    Private baseTinta As Integer

    Sub New()

    End Sub
    Sub New(ByVal color As String, ByVal marca As String, ByVal Trazo As String, ByVal BaseTinta As String)

        Me.pBaseTinta = BaseTinta
        MyBase.pColor = color
        MyBase.pMarca = marca
        MyBase.pTrazo = Trazo
    End Sub
    Public Property pBaseTinta As String
        Get
            Return baseTinta
        End Get
        Set(value As String)
            baseTinta = value
        End Set
    End Property

    Public Sub resaltar()

    End Sub

    Public Overloads Sub escribir()

    End Sub

End Class
