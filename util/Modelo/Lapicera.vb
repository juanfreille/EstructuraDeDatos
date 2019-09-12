
Public Class Lapicera
    Inherits Util
    Private tipoPunta As String
    Private material As String

    Sub New()

    End Sub

    Sub New(ByVal color As String, ByVal marca As String, ByVal Trazo As String, ByVal Material As String, ByVal TipoPunta As String)

        Me.pMaterial = Material
        Me.pTipoPunta = TipoPunta
        MyBase.pColor = color
        MyBase.pMarca = marca
        MyBase.pTrazo = Trazo
    End Sub

    Public Property pMaterial As String
        Get
            Return material
        End Get
        Set(value As String)
            material = value
        End Set
    End Property

    Public Property pTipoPunta As String
        Get
            Return tipoPunta
        End Get
        Set(value As String)
            tipoPunta = value
        End Set
    End Property

    Public Sub subrayar()

    End Sub

    Public Overloads Sub escribir()

    End Sub

End Class
