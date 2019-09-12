
Public Class ListaDoblementeEnlazada
    Private pri As NodoDME
    Private ult As NodoDME

    Sub New()
        pri = Nothing
        ult = Nothing
    End Sub

    Public Property NodoDME As NodoDME
        Get
            Return Nothing
        End Get
        Set(value As NodoDME)
        End Set
    End Property

    Public Property pPri As NodoDME
        Get
            Return pri
        End Get
        Set(value As NodoDME)
            pri = value
        End Set
    End Property

    Public Property pUlt As NodoDME
        Get
            Return ult
        End Get
        Set(value As NodoDME)
            ult = value
        End Set
    End Property

    Public Sub crear(ByVal nvo As NodoDME)
        pri = nvo
        ult = nvo
    End Sub
    Public Sub insertar(ByVal nvo As NodoDME)
        Dim aux As NodoDME

        If nvo.pDato.pMarca < pri.pDato.pMarca Then
            nvo.pAnt = Nothing
            nvo.pSig = pri
            pri.pAnt = nvo
            pri = nvo
        Else
            If nvo.pDato.pMarca > ult.pDato.pMarca Then
                ult.pSig = nvo
                nvo.pSig = Nothing
                nvo.pAnt = ult
                ult = nvo
            Else
                aux = pri
                While nvo.pDato.pMarca > aux.pDato.pMarca
                    aux = aux.pSig
                End While
                nvo.pAnt = aux.pAnt
                nvo.pSig = aux
                aux.pAnt = nvo
                aux.pAnt.pSig = nvo
            End If
        End If
    End Sub
    Public Sub buscar(ByVal Marca As String, ByVal Grilla As DataGridView)
        Dim Aux As NodoDME = pUlt
        Dim Cont As Integer = 0
        While Aux IsNot Nothing
            If Marca = Aux.pDato.pMarca Then
                Grilla.Rows.Add(Aux.pDato.pColor, Aux.pDato.pMarca, Aux.pDato.pTrazo, Aux.pDato.pMaterial, Aux.pDato.pTipoPunta)
                Cont = Cont + 1
            End If
            Aux = Aux.pAnt
        End While

        If Cont = 0 Then
            MessageBox.Show("No existe esa marca")
        Else
            MessageBox.Show("Encontrado/s: " & Cont)
        End If
    End Sub

    Public Sub listar(ByVal Grilla As DataGridView)
        Dim aux As NodoDME = pPri
        While aux IsNot Nothing
            Grilla.Rows.Add(aux.pDato.pColor, aux.pDato.pMarca, aux.pDato.pTrazo, aux.pDato.pMaterial, aux.pDato.pTipoPunta)
            aux = aux.pSig
        End While

    End Sub

    Public Sub listarDes(ByVal Grilla As DataGridView)
        'Recorrer descendente
        Dim aux As NodoDME = pUlt
        While aux IsNot Nothing
            Grilla.Rows.Add(aux.pDato.pColor, aux.pDato.pMarca, aux.pDato.pTrazo, aux.pDato.pMaterial, aux.pDato.pTipoPunta)
            aux = aux.pAnt
        End While

    End Sub

    Public Sub eliminar(ByVal vMarca As String)
        If vMarca < pri.pDato.pMarca Then
            MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If vMarca > ult.pDato.pMarca Then
                MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If vMarca = pri.pDato.pMarca Then
                    pri = pri.pSig
                    If pri Is Nothing Then
                        ult = Nothing
                    Else
                        pri.pAnt = Nothing
                    End If
                Else
                    If vMarca = ult.pDato.pMarca Then
                        ult = ult.pAnt
                        ult.pSig = Nothing
                    Else
                        Dim auxI As NodoDME = pri
                        While auxI IsNot Nothing And vMarca <> auxI.pDato.pMarca
                            auxI = auxI.pSig
                        End While
                        If auxI Is Nothing Then
                            MessageBox.Show("El elemento no está cargado en la lista", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            auxI.pAnt.pSig = auxI.pSig
                            auxI.pSig.pAnt = auxI.pAnt
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class
