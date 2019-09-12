Public Class LapizForm
    Dim CO As New Cola

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click

        If CO.pUlt Is Nothing Then
            Dim Nvo As New NodoC 'Vendria a ser el Nodo

            Dim Lapiz As New Lapiz

            'Se agregan los datos al objLapiz
            Lapiz.pColor = txtColor.Text
            Lapiz.pMarca = txtMarca.Text
            Lapiz.pTrazo = txtTrazo.Text
            Lapiz.pTipoGrafito = txtTipoGrafito.Text

            Nvo.pDato = Lapiz
            Nvo.pSig = Nothing

            CO.crear(Nvo)

        Else
            Dim Nvo As New NodoC
            Dim Lapiz As New Lapiz

            Lapiz.pColor = txtColor.Text
            Lapiz.pMarca = txtMarca.Text
            Lapiz.pTrazo = txtTrazo.Text
            Lapiz.pTipoGrafito = txtTipoGrafito.Text

            Nvo.pDato = Lapiz
            Nvo.pSig = Nothing

            CO.insertar(Nvo)

        End If
    End Sub


    Private Sub btnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertar.Click

        Dim Nvo As New NodoC
        Dim Lapiz As New Lapiz

        Lapiz.pColor = txtColor.Text
        Lapiz.pMarca = txtMarca.Text
        Lapiz.pTrazo = txtTrazo.Text
        Lapiz.pTipoGrafito = txtTipoGrafito.Text

        Nvo.pDato = Lapiz
        Nvo.pSig = Nothing

        If CO.pUlt IsNot Nothing Then
            CO.insertar(Nvo)
        End If
    End Sub


    Private Sub btnListar_Click(sender As System.Object, e As System.EventArgs) Handles btnListar.Click
        dgvGrilla.Rows.Clear()
        Dim Grilla As DataGridView = dgvGrilla
        CO.listar(Grilla)

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If CO.pUlt Is Nothing Then
            MessageBox.Show("No hay elementos en memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            CO.eliminar()
        End If
    End Sub


    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvGrilla.Rows.Clear()
        Dim auxMarca As String
        auxMarca = txtMarca.Text
        Dim Grilla As DataGridView = dgvGrilla
        CO.buscar(auxMarca, Grilla)

    End Sub

End Class
