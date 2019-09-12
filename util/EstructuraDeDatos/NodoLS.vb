
Public Class NodoLS
    Private dato As LapiceraS
    Private sig As NodoLS

    Sub New()

    End Sub

    Public Property pDato As LapiceraS
        Get
            Return dato
        End Get
        Set(value As LapiceraS)
            dato = value
        End Set
    End Property

    Public Property pSig As NodoLS
        Get
            Return sig
        End Get
        Set(value As NodoLS)
            sig = value
        End Set
    End Property

End Class
