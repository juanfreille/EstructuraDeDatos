<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LapizForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtTrazo = New System.Windows.Forms.TextBox()
        Me.txtTipoGrafito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoGrafito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(4, 201)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(127, 28)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(4, 254)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(127, 28)
        Me.btnInsertar.TabIndex = 1
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(4, 309)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(127, 28)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(3, 417)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(128, 28)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar (p/marca)"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(4, 363)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 28)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(131, 93)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(132, 22)
        Me.txtColor.TabIndex = 8
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(131, 149)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(132, 22)
        Me.txtMarca.TabIndex = 9
        '
        'txtTrazo
        '
        Me.txtTrazo.Location = New System.Drawing.Point(484, 93)
        Me.txtTrazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrazo.Name = "txtTrazo"
        Me.txtTrazo.Size = New System.Drawing.Size(132, 22)
        Me.txtTrazo.TabIndex = 10
        '
        'txtTipoGrafito
        '
        Me.txtTipoGrafito.Location = New System.Drawing.Point(484, 149)
        Me.txtTipoGrafito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoGrafito.Name = "txtTipoGrafito"
        Me.txtTipoGrafito.Size = New System.Drawing.Size(132, 22)
        Me.txtTipoGrafito.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Trazo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tipo Grafito"
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.color, Me.marca, Me.trazo, Me.tipoGrafito})
        Me.dgvGrilla.Location = New System.Drawing.Point(139, 201)
        Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(587, 245)
        Me.dgvGrilla.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 52)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "LAPIZ / COLA"
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
        'trazo
        '
        Me.trazo.HeaderText = "Trazo"
        Me.trazo.Name = "trazo"
        Me.trazo.Width = 130
        '
        'tipoGrafito
        '
        Me.tipoGrafito.HeaderText = "Tipo Grafito"
        Me.tipoGrafito.Name = "tipoGrafito"
        Me.tipoGrafito.Width = 130
        '
        'LapizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTipoGrafito)
        Me.Controls.Add(Me.txtTrazo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnCrear)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LapizForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lapiz"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrear As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtTrazo As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoGrafito As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents trazo As DataGridViewTextBoxColumn
    Friend WithEvents tipoGrafito As DataGridViewTextBoxColumn
End Class
