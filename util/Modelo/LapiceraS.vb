Public Class LapiceraS
    Inherits Util

    Private material As String
    Private tipoPunta As String

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

    Public Overloads Sub escribir()

    End Sub

    Public Sub subrayar()

    End Sub
End Class
