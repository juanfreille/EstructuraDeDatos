<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadernoForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuadernoForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtTrazo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnListarPre = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Equilibrar = New System.Windows.Forms.Button()
        Me.btnListarEn = New System.Windows.Forms.Button()
        Me.btnListarPos = New System.Windows.Forms.Button()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.Imagen = New System.Windows.Forms.ImageList(Me.components)
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hojas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 55)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "CUADERNO / ARBOL"
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.color, Me.marca, Me.Hojas, Me.Codigo})
        Me.dgvGrilla.Location = New System.Drawing.Point(233, 193)
        Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(710, 245)
        Me.dgvGrilla.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(573, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(574, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Hojas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Color"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(673, 157)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigo.TabIndex = 61
        '
        'txtTrazo
        '
        Me.txtTrazo.Location = New System.Drawing.Point(673, 105)
        Me.txtTrazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrazo.Name = "txtTrazo"
        Me.txtTrazo.Size = New System.Drawing.Size(132, 22)
        Me.txtTrazo.TabIndex = 60
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(293, 166)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(132, 22)
        Me.txtMarca.TabIndex = 59
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(293, 109)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(132, 22)
        Me.txtColor.TabIndex = 58
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(54, 381)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(171, 28)
        Me.btnEliminar.TabIndex = 57
        Me.btnEliminar.Text = "Eliminar p/codigo"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(54, 411)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(171, 28)
        Me.btnBuscar.TabIndex = 56
        Me.btnBuscar.Text = "Buscar (p/codigo)"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListarPre
        '
        Me.btnListarPre.Location = New System.Drawing.Point(54, 255)
        Me.btnListarPre.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListarPre.Name = "btnListarPre"
        Me.btnListarPre.Size = New System.Drawing.Size(171, 28)
        Me.btnListarPre.TabIndex = 55
        Me.btnListarPre.Text = "Listar PreOrden"
        Me.btnListarPre.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(54, 224)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(171, 28)
        Me.btnInsertar.TabIndex = 54
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(54, 193)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(171, 28)
        Me.btnCrear.TabIndex = 53
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Equilibrar
        '
        Me.Equilibrar.Location = New System.Drawing.Point(54, 350)
        Me.Equilibrar.Margin = New System.Windows.Forms.Padding(4)
        Me.Equilibrar.Name = "Equilibrar"
        Me.Equilibrar.Size = New System.Drawing.Size(171, 28)
        Me.Equilibrar.TabIndex = 69
        Me.Equilibrar.Text = "Equilibrar"
        Me.Equilibrar.UseVisualStyleBackColor = True
        '
        'btnListarEn
        '
        Me.btnListarEn.Location = New System.Drawing.Point(54, 286)
        Me.btnListarEn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListarEn.Name = "btnListarEn"
        Me.btnListarEn.Size = New System.Drawing.Size(171, 28)
        Me.btnListarEn.TabIndex = 70
        Me.btnListarEn.Text = "Listar EnOrden"
        Me.btnListarEn.UseVisualStyleBackColor = True
        '
        'btnListarPos
        '
        Me.btnListarPos.Location = New System.Drawing.Point(54, 318)
        Me.btnListarPos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListarPos.Name = "btnListarPos"
        Me.btnListarPos.Size = New System.Drawing.Size(171, 28)
        Me.btnListarPos.TabIndex = 71
        Me.btnListarPos.Text = "Listar PosOrden"
        Me.btnListarPos.UseVisualStyleBackColor = True
        '
        'Tree
        '
        Me.Tree.ImageIndex = 0
        Me.Tree.ImageList = Me.Imagen
        Me.Tree.Location = New System.Drawing.Point(233, 447)
        Me.Tree.Margin = New System.Windows.Forms.Padding(4)
        Me.Tree.Name = "Tree"
        Me.Tree.SelectedImageIndex = 0
        Me.Tree.Size = New System.Drawing.Size(710, 275)
        Me.Tree.TabIndex = 72
        '
        'Imagen
        '
        Me.Imagen.ImageStream = CType(resources.GetObject("Imagen.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagen.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagen.Images.SetKeyName(0, "tree.gif")
        Me.Imagen.Images.SetKeyName(1, "azul.png")
        Me.Imagen.Images.SetKeyName(2, "rojo.png")
        '
        'color
        '
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.Width = 130
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.Width = 130
        '
        'Hojas
        '
        Me.Hojas.HeaderText = "Hojas"
        Me.Hojas.Name = "Hojas"
        Me.Hojas.Width = 130
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 130
        '
        'CuadernoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 727)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.btnListarPos)
        Me.Controls.Add(Me.btnListarEn)
        Me.Controls.Add(Me.Equilibrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtTrazo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnListarPre)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "CuadernoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuadernoForm"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtTrazo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnListarPre As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents Equilibrar As Button
    Friend WithEvents btnListarEn As Button
    Friend WithEvents btnListarPos As Button
    Friend WithEvents Tree As TreeView
    Friend WithEvents Imagen As ImageList
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents Hojas As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
End Class
