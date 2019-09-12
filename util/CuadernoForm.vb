Public Class CuadernoForm
    Dim AR As New Arbol

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If AR.pRaiz Is Nothing Then
            Dim Nvo As New NodoAB
            Dim Cuaderno As New Cuaderno

            Cuaderno.pColor = txtColor.Text
            Cuaderno.pMarca = txtMarca.Text
            Cuaderno.pTrazo = txtTrazo.Text
            Cuaderno.pCodigo = Val(txtCodigo.Text)

            Nvo.pDato = Cuaderno
            Nvo.pIzq = Nothing
            Nvo.pDer = Nothing

            AR.Crear(Nvo)
            AR.Mostrar(Tree)
        Else
            MessageBox.Show("El arbol ya ha sido creado, ingrese los datos del siguiente nodo y presione en 'Insertar'")
        End If
    End Sub


    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If AR.pRaiz IsNot Nothing Then
            Dim Nvo As New NodoAB
            Dim Cuaderno As New Cuaderno

            Cuaderno.pColor = txtColor.Text
            Cuaderno.pMarca = txtMarca.Text
            Cuaderno.pTrazo = txtTrazo.Text
            Cuaderno.pCodigo = Val(txtCodigo.Text)

            Nvo.pDato = Cuaderno
            Nvo.pIzq = Nothing
            Nvo.pDer = Nothing

            AR.Crear(Nvo)
            AR.Mostrar(Tree)
        Else
            MessageBox.Show("Necesita crear el arbol, ingrese los datos y presione el boton 'Crear' para cargar el primer nodo")
        End If
    End Sub
    Private Sub btnListarPre_Click(sender As Object, e As EventArgs) Handles btnListarPre.Click
        dgvGrilla.Rows.Clear()
        AR.PreOrden(AR.pRaiz, dgvGrilla)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        AR.Eliminar(txtCodigo.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvGrilla.Rows.Clear()
        Dim Grilla As DataGridView = dgvGrilla
        AR.Buscar(dgvGrilla, AR.pRaiz, txtCodigo.Text)
    End Sub

    Private Sub Equilibrar_Click(sender As Object, e As EventArgs) Handles Equilibrar.Click
        AR.Equilibrar(Tree)
    End Sub

    Private Sub btnListarEn_Click(sender As Object, e As EventArgs) Handles btnListarEn.Click
        dgvGrilla.Rows.Clear()
        AR.EnOrden(AR.pRaiz, dgvGrilla)
    End Sub

    Private Sub btnListarPos_Click(sender As Object, e As EventArgs) Handles btnListarPos.Click
        dgvGrilla.Rows.Clear()
        AR.PostOrden(AR.pRaiz, dgvGrilla)
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class