Public Class NodoAB
    Private dato As Cuaderno
    Private izq As NodoAB
    Private der As NodoAB

    Sub New()

    End Sub

    Public Property pDato As Cuaderno
        Get
            Return dato
        End Get
        Set(value As Cuaderno)
            dato = value
        End Set
    End Property

    Public Property pDer As NodoAB
        Get
            Return der
        End Get
        Set(value As NodoAB)
            der = value
        End Set
    End Property

    Public Property pIzq As NodoAB
        Get
            Return izq
        End Get
        Set(value As NodoAB)
            izq = value
        End Set
    End Property

End Class
