Public Class FibraForm
    Dim PI As New Pila
    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        If PI.pUlt Is Nothing Then
            Dim Nvo As New NodoP 'Vendria a ser el Nodo

            Dim Fibra As New Fibra

            'Se agregan los datos al objLapiz
            Fibra.pColor = txtColor.Text
            Fibra.pMarca = txtMarca.Text
            Fibra.pTrazo = txtTrazo.Text
            Fibra.pBaseTinta = txtTipoGrafito.Text

            Nvo.pDato = Fibra
            Nvo.pAnt = Nothing

            PI.crear(Nvo)

        Else
            Dim Nvo As New NodoP
            Dim Fibra As New Fibra

            Fibra.pColor = txtColor.Text
            Fibra.pMarca = txtMarca.Text
            Fibra.pTrazo = txtTrazo.Text
            Fibra.pBaseTinta = txtTipoGrafito.Text

            Nvo.pDato = Fibra
            Nvo.pAnt = Nothing

            PI.insertar(Nvo)

        End If
    End Sub

    Private Sub btnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertar.Click
        Dim Nvo As New NodoP
        Dim Fibra As New Fibra

        Fibra.pColor = txtColor.Text
        Fibra.pMarca = txtMarca.Text
        Fibra.pTrazo = txtTrazo.Text
        Fibra.pBaseTinta = txtTipoGrafito.Text

        Nvo.pDato = Fibra
        Nvo.pAnt = Nothing

        If PI.pUlt IsNot Nothing Then
            PI.insertar(Nvo)
        End If
    End Sub

    Private Sub btnListar_Click(sender As System.Object, e As System.EventArgs) Handles btnListar.Click
        dgvGrilla.Rows.Clear()
        Dim Grilla As DataGridView = dgvGrilla
        PI.listar(Grilla)
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If PI.pUlt Is Nothing Then
            MessageBox.Show("No hay elementos en memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            PI.eliminar()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvGrilla.Rows.Clear()
        Dim auxMarca As String
        auxMarca = txtMarca.Text
        Dim Grilla As DataGridView = dgvGrilla
        PI.buscar(auxMarca, Grilla)
    End Sub
End Class