Public Class LapiceraForm
    Dim LD As New ListaDoblementeEnlazada
    Dim LS As New ListaSimplementeEnlazada

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim nvo As New NodoDME
        Dim Lapicera As New Lapicera

        Lapicera.pColor = txtColor.Text
        Lapicera.pMarca = txtMarca.Text
        Lapicera.pMaterial = txtTrazo.Text
        Lapicera.pTipoPunta = txtTipoPunta.Text
        Lapicera.pTrazo = txtTrazo.Text

        nvo.pDato = Lapicera
        nvo.pSig = Nothing

        If LD.pPri Is Nothing Then
            LD.crear(nvo)
        Else
            LD.insertar(nvo)
        End If
    End Sub
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim Nvo As New NodoDME
        Dim Lapicera As New Lapicera
        Lapicera.pColor = txtColor.Text
        Lapicera.pMarca = txtMarca.Text
        Lapicera.pTrazo = txtTrazo.Text
        Lapicera.pMaterial = txtTipoGrafito.Text
        Lapicera.pTipoPunta = txtTipoPunta.Text

        Nvo.pDato = Lapicera
        Nvo.pAnt = Nothing
        Nvo.pSig = Nothing

        If LD.pPri IsNot Nothing Then
            LD.insertar(Nvo)
        Else
            LD.crear(Nvo)
        End If

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dgvGrilla.Rows.Clear()
        Dim Grilla As DataGridView = dgvGrilla
        LD.listar(Grilla)
    End Sub

    Private Sub btnListar_des_Click(sender As Object, e As EventArgs) Handles btnListar_des.Click
        dgvGrilla.Rows.Clear()
        Dim Grilla As DataGridView = dgvGrilla
        LD.listarDes(Grilla)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If LD.pPri Is Nothing Then
            MessageBox.Show("No hay elementos en memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            LD.eliminar(txtMarca.Text)
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvGrilla.Rows.Clear()
        Dim auxMarca As String
        auxMarca = txtMarca.Text
        Dim Grilla As DataGridView = dgvGrilla
        LD.buscar(auxMarca, Grilla)
    End Sub



    'SIMPLEMENTE ENLAZADA
    Private Sub Crear_2_Click(sender As Object, e As EventArgs) Handles Crear_2.Click
        Dim nvo As New NodoLS
        Dim LapiceraS As New LapiceraS

        LapiceraS.pColor = txtColor_2.Text
        LapiceraS.pMarca = txtMarca_2.Text
        LapiceraS.pMaterial = txtTrazo_2.Text
        LapiceraS.pTipoPunta = txtPunta_2.Text
        LapiceraS.pTrazo = txtTrazo_2.Text

        nvo.pDato = LapiceraS
        nvo.pSig = Nothing

        If LS.pPri Is Nothing Then
            LS.crear(nvo)
        Else
            LS.insertar(nvo)
        End If
    End Sub

    Private Sub Insertar_2_Click(sender As Object, e As EventArgs) Handles Insertar_2.Click
        Dim nvo As New NodoLS
        Dim LapiceraS As New LapiceraS

        LapiceraS.pColor = txtColor_2.Text
        LapiceraS.pMarca = txtMarca_2.Text
        LapiceraS.pMaterial = txtTrazo_2.Text
        LapiceraS.pTipoPunta = txtPunta_2.Text
        LapiceraS.pTrazo = txtTrazo_2.Text

        nvo.pDato = LapiceraS
        nvo.pSig = Nothing

        If LS.pPri Is Nothing Then
            LS.crear(nvo)
        Else
            LS.insertar(nvo)
        End If
    End Sub

    Private Sub Eliminar_2_Click(sender As Object, e As EventArgs) Handles Eliminar_2.Click
        If LS.pPri Is Nothing Then
            MessageBox.Show("No hay elementos en memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            LS.eliminar(txtMarca_2.Text)
        End If

    End Sub

    Private Sub Buscar_2_Click(sender As Object, e As EventArgs) Handles Buscar_2.Click
        dgvGrilla_2.Rows.Clear()
        Dim grilla As DataGridView = dgvGrilla_2
        LS.buscar(txtMarca_2.Text, grilla)
    End Sub

    Private Sub Listar_2_Click(sender As Object, e As EventArgs) Handles Listar_2.Click
        Dim grilla As DataGridView = dgvGrilla_2
        dgvGrilla_2.Rows.Clear()
        LS.listar(grilla)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub dgvGrilla_2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla_2.CellContentClick

    End Sub
End Class