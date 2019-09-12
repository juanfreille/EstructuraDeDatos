
Public Class NodoC
    Private dato As Lapiz
    Private siguiente As NodoC

    Sub New()

    End Sub

    Public Property pDato As Lapiz
        Get
            Return dato
        End Get
        Set(value As Lapiz)
            dato = value
        End Set
    End Property

    Public Property pSig As NodoC
        Get
            Return siguiente
        End Get
        Set(value As NodoC)
            siguiente = value
        End Set
    End Property

End Class
