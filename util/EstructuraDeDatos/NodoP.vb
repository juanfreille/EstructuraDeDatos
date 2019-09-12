
Public Class NodoP
    Private dato As Fibra
    Private ant As NodoP

    Sub New()

    End Sub

    Public Property pDato As Fibra
        Get
            Return dato
        End Get
        Set(value As Fibra)
            dato = value
        End Set
    End Property

    Public Property pAnt As NodoP
        Get
            Return ant
        End Get
        Set(value As NodoP)
            ant = value
        End Set
    End Property

End Class
