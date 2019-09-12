
Public Class Cola
    Private pri As NodoC
    Private ult As NodoC

    Sub New()
        pri = Nothing
        ult = Nothing
    End Sub

    Public Property pPri As NodoC
        Get
            Return pri
        End Get
        Set(value As NodoC)
            pri = value
        End Set
    End Property

    Public Property pUlt As NodoC
        Get
            Return ult
        End Get
        Set(value As NodoC)
            ult = value
        End Set
    End Property

    Public Property NodoC As NodoC
        Get
            Return Nothing
        End Get
        Set(value As NodoC)

        End Set
    End Property

    Public Sub crear(ByVal nvo As NodoC)
        pri = nvo
        ult = nvo
    End Sub

    Public Sub insertar(ByVal nvo As NodoC)
        ult.pSig = nvo
        ult = nvo
    End Sub

    Public Sub eliminar()
        If pri IsNot Nothing Then
            pri = pri.pSig
            If pri Is Nothing Then
                ult = Nothing
            End If
        End If
    End Sub

    Public Sub listar(ByVal Grilla As DataGridView)
        Dim aux As NodoC = pPri
        While aux IsNot Nothing
            Grilla.Rows.Add(aux.pDato.pColor, aux.pDato.pMarca, aux.pDato.pTrazo, aux.pDato.pTipoGrafito)
            aux = aux.pSig
        End While
    End Sub

    Public Sub buscar(ByVal Marca As String, ByVal Grilla As DataGridView)
        Dim Aux As NodoC = pPri
        Dim Cont As Integer = 0
        While Aux IsNot Nothing
            If Marca = Aux.pDato.pMarca Then
                Grilla.Rows.Add(Aux.pDato.pColor, Aux.pDato.pMarca, Aux.pDato.pTrazo, Aux.pDato.pTipoGrafito)
                Cont = Cont + 1
                MessageBox.Show(Cont)
            End If
            Aux = Aux.pSig
        End While

        If Cont = 0 Then
            MessageBox.Show("No existe esa marca")
        End If
    End Sub
End Class
