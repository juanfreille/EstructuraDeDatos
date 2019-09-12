
Public Class Pila
    Private pri As NodoP
    Private ult As NodoP

    Sub New()
        pri = Nothing
        ult = Nothing
    End Sub

    Public Property pPri As NodoP
        Get
            Return pri
        End Get
        Set(value As NodoP)
            pri = value
        End Set
    End Property

    Public Property pUlt As NodoP
        Get
            Return ult
        End Get
        Set(value As NodoP)
            ult = value
        End Set
    End Property

    Public Property NodoP As NodoP
        Get
            Return Nothing
        End Get
        Set(value As NodoP)

        End Set
    End Property

    Public Sub crear(ByVal nvo As NodoP)
        pri = nvo
        ult = nvo
    End Sub

    Public Sub eliminar()
        If ult IsNot Nothing Then
            ult = ult.pAnt
            If ult Is Nothing Then
                pri = Nothing
            End If
        End If
    End Sub

    Public Sub insertar(ByVal nvo As NodoP)
        nvo.pAnt = pUlt
        ult = nvo
    End Sub

    Public Sub listar(ByVal Grilla As DataGridView)
        Dim aux As NodoP = pUlt
        While aux IsNot Nothing
            Grilla.Rows.Add(aux.pDato.pColor, aux.pDato.pMarca, aux.pDato.pTrazo, aux.pDato.pBaseTinta)
            aux = aux.pAnt
        End While
    End Sub

    Public Sub buscar(ByVal Marca As String, ByVal Grilla As DataGridView)
        Dim Aux As NodoP = pUlt
        Dim Cont As Integer = 0
        While Aux IsNot Nothing
            If Marca = Aux.pDato.pMarca Then
                Grilla.Rows.Add(Aux.pDato.pColor, Aux.pDato.pMarca, Aux.pDato.pTrazo, Aux.pDato.pBaseTinta)
                Cont = Cont + 1
                MessageBox.Show(Cont)
            End If
            Aux = Aux.pAnt
        End While

        If Cont = 0 Then
            MessageBox.Show("No existe esa marca")
        End If
    End Sub

End Class
