Public Class Arbol
    Private raiz As NodoAB
    Private Vec(0) As NodoAB
    Private I As Integer = 0
    Public Property pRaiz As NodoAB
        Get
            Return raiz
        End Get
        Set(value As NodoAB)
            raiz = value
        End Set
    End Property
    Public Property NodoAB As NodoAB
        Get
            Return Nothing
        End Get
        Set(value As NodoAB)
        End Set
    End Property

    'Crear
    Public Sub Crear(nvo)
        If raiz Is Nothing Then
            nvo.pIzq = Nothing
            nvo.pDer = Nothing
            raiz = nvo
        Else
            Insertar(raiz, nvo)
        End If
    End Sub

    'Un Insertar no recursivo, codigo sin usar //////

    '    Public Sub Insertar2(ByVal raiz As NodoAB, ByVal nvo As NodoAB)
    '   Dim Actual As NodoAB = raiz
    '  Dim Ant As NodoAB = raiz

    '      nvo.pIzq = Nothing
    '      nvo.pDer = Nothing
    '      Actual = raiz
    '   Do While Not (Actual Is Nothing)
    '       Ant = Actual
    '   If nvo.pDato.pCodigo < Actual.pDato.pCodigo Then
    '               Actual = Actual.pIzq
    '   Else
    '               Actual = Actual.pDer
    '   End If
    '   Loop
    '   If nvo.pDato.pCodigo < Ant.pDato.pCodigo Then
    '           Ant.pIzq = nvo
    '   Else
    '           Ant.pDer = nvo
    '   End If
    'End Sub

    'Insertar
    Public Sub Insertar(ByVal raiz As NodoAB, ByVal nvo As NodoAB)
        nvo.pIzq = Nothing
        nvo.pDer = Nothing
        If nvo.pDato.pCodigo = raiz.pDato.pCodigo Then
            MessageBox.Show("Ese código ya ha sido ingresado en el árbol")
        Else
            If nvo.pDato.pCodigo <= raiz.pDato.pCodigo Then
                If (raiz.pIzq Is Nothing) Then
                    raiz.pIzq = nvo
                Else
                    Insertar(raiz.pIzq, nvo)
                End If
            Else
                If (raiz.pDer Is Nothing) Then
                    raiz.pDer = nvo
                Else
                    Insertar(raiz.pDer, nvo)
                End If
            End If
        End If
    End Sub

    'Buscar
    Public Sub Buscar(GRILLA As DataGridView, ByVal temp As NodoAB, ByVal x As Integer)
        If temp Is Nothing Then
            MessageBox.Show("El código '" & x & "' no está en el Arbol")
        ElseIf (x = temp.pDato.pCodigo) Then
            GRILLA.Rows.Add(temp.pDato.pColor, temp.pDato.pMarca, temp.pDato.pTrazo, temp.pDato.pCodigo)
            MessageBox.Show("El código '" & x & "' si está en el Arbol.")
        ElseIf (x < temp.pDato.pCodigo) Then
            Buscar(GRILLA, temp.pIzq, x)
        Else
            Buscar(GRILLA, temp.pDer, x)
        End If
    End Sub

    '    RECORRIDO En-Orden
    Public Sub EnOrden(ByVal R As NodoAB, ByVal D As DataGridView)
        If Not R.pIzq Is Nothing Then
            EnOrden(R.pIzq, D)
        End If
        D.Rows.Add(R.pDato.pColor, R.pDato.pMarca, R.pDato.pTrazo, R.pDato.pCodigo)
        If Not R.pDer Is Nothing Then
            EnOrden(R.pDer, D)
        End If
    End Sub

    '    RECORRIDO Post-Orden
    Public Sub PostOrden(ByVal R As NodoAB, ByVal D As DataGridView)
        If Not R.pIzq Is Nothing Then
            PostOrden(R.pIzq, D)
        End If
        If Not R.pDer Is Nothing Then
            PostOrden(R.pDer, D)
        End If
        D.Rows.Add(R.pDato.pColor, R.pDato.pMarca, R.pDato.pTrazo, R.pDato.pCodigo)
    End Sub

    '   RECORRIDO Pre-Orden
    Public Sub PreOrden(ByVal R As NodoAB, ByVal D As DataGridView)
        D.Rows.Add(R.pDato.pColor, R.pDato.pMarca, R.pDato.pTrazo, R.pDato.pCodigo)

        If Not R.pIzq Is Nothing Then
            PreOrden(R.pIzq, D)
        End If
        If Not R.pDer Is Nothing Then
            PreOrden(R.pDer, D)
        End If
    End Sub

    '   Equilibrar
    Public Sub Equilibrar(ByVal T As TreeView)
        I = 0
        CopiarA_Vector(raiz)
        raiz = Nothing
        PegarDeVector(0, I - 1)
        ReDim Vec(0)
        Mostrar(T)
    End Sub
    Private Sub CopiarA_Vector(ByVal R2 As NodoAB)
        If Not (R2.pIzq Is Nothing) Then
            CopiarA_Vector(R2.pIzq)
        End If
        Vec(I) = R2
        I = I + 1
        ReDim Preserve Vec(I)
        If Not (R2.pDer Is Nothing) Then
            CopiarA_Vector(R2.pDer)
        End If
    End Sub
    Private Sub PegarDeVector(primero As Integer, ultimo As Integer)
        Dim Medio As Integer
        Medio = (primero + ultimo) / 2
        If primero <= ultimo Then
            Crear(Vec(Medio))
            PegarDeVector(primero, Medio - 1)
            PegarDeVector(Medio + 1, ultimo)
        End If
    End Sub

    'Eliminar Nodo
    Public Sub Eliminar(ByVal n As Integer)
        I = 0
        CopiarY_BorrarVector(raiz, n)
        raiz = Nothing
        PegarDeVector(0, I - 1)
        ReDim Vec(0)
    End Sub
    Private Sub CopiarY_BorrarVector(ByVal R As NodoAB, ByVal Num As Integer)
        If R.pIzq IsNot Nothing Then
            CopiarY_BorrarVector(R.pIzq, Num)
        End If
        If Num <> R.pDato.pCodigo Then
            Vec(I) = R
            I = I + 1
            ReDim Preserve Vec(I)
        End If
        If R.pDer IsNot Nothing Then
            CopiarY_BorrarVector(R.pDer, Num)
        End If
    End Sub
    'Arbol gráfico
    Public Sub Mostrar(ByVal T As TreeView)
        T.Nodes.Clear()
        T.Nodes.Add("", "", 0)
        IO(raiz, T.Nodes(0))
        T.ExpandAll()
    End Sub
    Private Sub IO(ByVal Pos As NodoAB, ByVal N As TreeNode)
        If Not (Pos.pIzq Is Nothing) Then
            IO(Pos.pIzq, N.Nodes.Add("", "", 1))
        End If
        N.Text = (Pos.pDato.pCodigo)
        If Not (Pos.pDer Is Nothing) Then
            IO(Pos.pDer, N.Nodes.Add("", "", 2))
        End If
    End Sub
End Class
