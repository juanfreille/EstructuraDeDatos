
Public Class NodoDME
    Private dato As Lapicera
    Private ant As NodoDME
    Private sig As NodoDME

    Sub New()

    End Sub

    Public Property pDato As Lapicera
        Get
            Return dato
        End Get
        Set(value As Lapicera)
            dato = value
        End Set
    End Property

    Public Property pSig As NodoDME
        Get
            Return sig
        End Get
        Set(value As NodoDME)
            sig = value
        End Set
    End Property

    Public Property pAnt As NodoDME
        Get
            Return ant
        End Get
        Set(value As NodoDME)
            ant = value
        End Set
    End Property
End Class
