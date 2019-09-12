
Public Class ListaSimplementeEnlazada
    Private pri As NodoLS
    Private ult As NodoLS

    Sub New()
        pri = Nothing
        ult = Nothing
    End Sub

    Public Property pPri As NodoLS
        Get
            Return pri
        End Get
        Set(value As NodoLS)
            pri = value
        End Set
    End Property

    Public Property pUlt As NodoLS
        Get
            Return ult
        End Get
        Set(value As NodoLS)
            ult = value
        End Set
    End Property

    Public Property NodoLS As NodoLS
        Get
            Return Nothing
        End Get
        Set(value As NodoLS)

        End Set
    End Property

    Public Sub crear(ByVal Nvo As NodoLS)
        pri = Nvo
        ult = Nvo
    End Sub

    Public Sub eliminar(ByVal vMarca As String)
        Dim actual As NodoLS
        Dim anterior As NodoLS

        If vMarca < pri.pDato.pMarca Then
            MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If vMarca > ult.pDato.pMarca Then
                MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If pri.pSig Is Nothing And vMarca = pri.pDato.pMarca Then
                    pri = Nothing
                    ult = Nothing
                Else
                    If vMarca = pri.pDato.pMarca Then
                        actual = pri
                        pri = actual.pSig
                    Else
                        anterior = pri
                        actual = pri
                        While actual IsNot Nothing AndAlso vMarca <> actual.pDato.pMarca
                            anterior = actual
                            actual = actual.pSig
                        End While
                        If actual IsNot Nothing Then
                            If vMarca = ult.pDato.pMarca Then
                                anterior.pSig = Nothing
                                ult = anterior
                            Else
                                anterior.pSig = actual.pSig
                            End If
                        Else
                            MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub insertar(ByVal nvo As NodoLS)
        Dim anterior, actual As New NodoLS

        If nvo.pDato.pMarca < pri.pDato.pMarca Then
            nvo.pSig = pri
            pri = nvo
        Else
            If nvo.pDato.pMarca > ult.pDato.pMarca Then
                ult.pSig = nvo
                nvo.pSig = Nothing
                ult = nvo
            Else
                anterior = pri
                actual = pri
                While nvo.pDato.pMarca > actual.pDato.pMarca
                    anterior = actual
                    actual = actual.pSig
                End While
                anterior.pSig = nvo
                nvo.pSig = actual
            End If
        End If
    End Sub

    Public Sub listar(ByVal grilla As DataGridView)
        Dim aux As NodoLS = pri

        While Not aux Is Nothing
            grilla.Rows.Add(aux.pDato.pColor, aux.pDato.pMarca, aux.pDato.pTrazo, aux.pDato.pTipoPunta, aux.pDato.pMaterial)
            aux = aux.pSig
        End While
    End Sub

    Public Sub buscar(ByVal Marca As String, ByVal Grilla As DataGridView)
        Dim Aux As NodoLS = pPri
        Dim Cont As Integer = 0

        While Aux IsNot Nothing
            If Marca = Aux.pDato.pMarca Then
                Grilla.Rows.Add(Aux.pDato.pColor, Aux.pDato.pMarca, Aux.pDato.pTrazo, Aux.pDato.pMaterial, Aux.pDato.pTipoPunta)
                Cont = Cont + 1
            End If
            Aux = Aux.pSig
        End While

        If Cont = 0 Then
            MessageBox.Show("No existe esa marca")
        Else
            MessageBox.Show("Encontrado/s: " & Cont)
        End If
    End Sub

End Class
