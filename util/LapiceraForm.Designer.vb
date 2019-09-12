<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapiceraForm
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
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoGrafito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPunta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoGrafito = New System.Windows.Forms.TextBox()
        Me.txtTrazo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoPunta = New System.Windows.Forms.TextBox()
        Me.btnListar_des = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvGrilla_2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaterial_2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Eliminar_2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Buscar_2 = New System.Windows.Forms.Button()
        Me.txtTrazo_2 = New System.Windows.Forms.TextBox()
        Me.Crear_2 = New System.Windows.Forms.Button()
        Me.txtPunta_2 = New System.Windows.Forms.TextBox()
        Me.Listar_2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Insertar_2 = New System.Windows.Forms.Button()
        Me.txtMarca_2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtColor_2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvGrilla_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.color, Me.marca, Me.trazo, Me.tipoGrafito, Me.TipoPunta})
        Me.dgvGrilla.Location = New System.Drawing.Point(223, 244)
        Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(710, 245)
        Me.dgvGrilla.TabIndex = 46
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
        Me.tipoGrafito.HeaderText = "Material"
        Me.tipoGrafito.Name = "tipoGrafito"
        Me.tipoGrafito.Width = 130
        '
        'TipoPunta
        '
        Me.TipoPunta.HeaderText = "TipoPunta"
        Me.TipoPunta.Name = "TipoPunta"
        Me.TipoPunta.Width = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(551, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Tipo Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(551, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Trazo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Color"
        '
        'txtTipoGrafito
        '
        Me.txtTipoGrafito.Location = New System.Drawing.Point(660, 142)
        Me.txtTipoGrafito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoGrafito.Name = "txtTipoGrafito"
        Me.txtTipoGrafito.Size = New System.Drawing.Size(132, 22)
        Me.txtTipoGrafito.TabIndex = 41
        '
        'txtTrazo
        '
        Me.txtTrazo.Location = New System.Drawing.Point(660, 90)
        Me.txtTrazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrazo.Name = "txtTrazo"
        Me.txtTrazo.Size = New System.Drawing.Size(132, 22)
        Me.txtTrazo.TabIndex = 40
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(280, 151)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(132, 22)
        Me.txtMarca.TabIndex = 39
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(280, 94)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(132, 22)
        Me.txtColor.TabIndex = 38
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(44, 416)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(171, 28)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.Text = "Eliminar p/marca"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(44, 461)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(171, 28)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "Buscar (p/marca)"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(44, 333)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(171, 28)
        Me.btnListar.TabIndex = 35
        Me.btnListar.Text = "Listar Ascendente"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(44, 290)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(171, 28)
        Me.btnInsertar.TabIndex = 34
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(44, 244)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(171, 28)
        Me.btnCrear.TabIndex = 33
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 47)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "LAPICERA / LISTA ENLAZADA DOBLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(551, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Tipo Punta"
        '
        'txtTipoPunta
        '
        Me.txtTipoPunta.Location = New System.Drawing.Point(660, 189)
        Me.txtTipoPunta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoPunta.Name = "txtTipoPunta"
        Me.txtTipoPunta.Size = New System.Drawing.Size(132, 22)
        Me.txtTipoPunta.TabIndex = 42
        '
        'btnListar_des
        '
        Me.btnListar_des.Location = New System.Drawing.Point(44, 375)
        Me.btnListar_des.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListar_des.Name = "btnListar_des"
        Me.btnListar_des.Size = New System.Drawing.Size(171, 28)
        Me.btnListar_des.TabIndex = 51
        Me.btnListar_des.Text = "Listar Descendente"
        Me.btnListar_des.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(980, 528)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvGrilla)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTipoGrafito)
        Me.TabPage1.Controls.Add(Me.btnListar_des)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.txtTrazo)
        Me.TabPage1.Controls.Add(Me.btnCrear)
        Me.TabPage1.Controls.Add(Me.txtTipoPunta)
        Me.TabPage1.Controls.Add(Me.btnListar)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnInsertar)
        Me.TabPage1.Controls.Add(Me.txtMarca)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtColor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(972, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista Doble"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvGrilla_2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMaterial_2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Eliminar_2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Buscar_2)
        Me.TabPage2.Controls.Add(Me.txtTrazo_2)
        Me.TabPage2.Controls.Add(Me.Crear_2)
        Me.TabPage2.Controls.Add(Me.txtPunta_2)
        Me.TabPage2.Controls.Add(Me.Listar_2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Insertar_2)
        Me.TabPage2.Controls.Add(Me.txtMarca_2)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtColor_2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(972, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista Simple"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvGrilla_2
        '
        Me.dgvGrilla_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvGrilla_2.Location = New System.Drawing.Point(223, 244)
        Me.dgvGrilla_2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGrilla_2.Name = "dgvGrilla_2"
        Me.dgvGrilla_2.Size = New System.Drawing.Size(710, 245)
        Me.dgvGrilla_2.TabIndex = 66
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Trazo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "TipoPunta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(787, 47)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "LAPICERA / LISTA ENLAZADA SIMPLE"
        '
        'txtMaterial_2
        '
        Me.txtMaterial_2.Location = New System.Drawing.Point(660, 142)
        Me.txtMaterial_2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaterial_2.Name = "txtMaterial_2"
        Me.txtMaterial_2.Size = New System.Drawing.Size(132, 22)
        Me.txtMaterial_2.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(551, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Tipo Punta"
        '
        'Eliminar_2
        '
        Me.Eliminar_2.Location = New System.Drawing.Point(44, 410)
        Me.Eliminar_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Eliminar_2.Name = "Eliminar_2"
        Me.Eliminar_2.Size = New System.Drawing.Size(171, 28)
        Me.Eliminar_2.TabIndex = 56
        Me.Eliminar_2.Text = "Eliminar p/marca"
        Me.Eliminar_2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 98)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Color"
        '
        'Buscar_2
        '
        Me.Buscar_2.Location = New System.Drawing.Point(44, 461)
        Me.Buscar_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Buscar_2.Name = "Buscar_2"
        Me.Buscar_2.Size = New System.Drawing.Size(171, 28)
        Me.Buscar_2.TabIndex = 55
        Me.Buscar_2.Text = "Buscar (p/marca)"
        Me.Buscar_2.UseVisualStyleBackColor = True
        '
        'txtTrazo_2
        '
        Me.txtTrazo_2.Location = New System.Drawing.Point(660, 90)
        Me.txtTrazo_2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrazo_2.Name = "txtTrazo_2"
        Me.txtTrazo_2.Size = New System.Drawing.Size(132, 22)
        Me.txtTrazo_2.TabIndex = 59
        '
        'Crear_2
        '
        Me.Crear_2.Location = New System.Drawing.Point(44, 244)
        Me.Crear_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Crear_2.Name = "Crear_2"
        Me.Crear_2.Size = New System.Drawing.Size(171, 28)
        Me.Crear_2.TabIndex = 52
        Me.Crear_2.Text = "Crear"
        Me.Crear_2.UseVisualStyleBackColor = True
        '
        'txtPunta_2
        '
        Me.txtPunta_2.Location = New System.Drawing.Point(660, 189)
        Me.txtPunta_2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPunta_2.Name = "txtPunta_2"
        Me.txtPunta_2.Size = New System.Drawing.Size(132, 22)
        Me.txtPunta_2.TabIndex = 61
        '
        'Listar_2
        '
        Me.Listar_2.Location = New System.Drawing.Point(44, 356)
        Me.Listar_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Listar_2.Name = "Listar_2"
        Me.Listar_2.Size = New System.Drawing.Size(171, 28)
        Me.Listar_2.TabIndex = 54
        Me.Listar_2.Text = "Listar"
        Me.Listar_2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 153)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Marca"
        '
        'Insertar_2
        '
        Me.Insertar_2.Location = New System.Drawing.Point(44, 302)
        Me.Insertar_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Insertar_2.Name = "Insertar_2"
        Me.Insertar_2.Size = New System.Drawing.Size(171, 28)
        Me.Insertar_2.TabIndex = 53
        Me.Insertar_2.Text = "Insertar"
        Me.Insertar_2.UseVisualStyleBackColor = True
        '
        'txtMarca_2
        '
        Me.txtMarca_2.Location = New System.Drawing.Point(280, 151)
        Me.txtMarca_2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca_2.Name = "txtMarca_2"
        Me.txtMarca_2.Size = New System.Drawing.Size(132, 22)
        Me.txtMarca_2.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(551, 144)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 17)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Tipo Material"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(551, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Trazo"
        '
        'txtColor_2
        '
        Me.txtColor_2.Location = New System.Drawing.Point(280, 94)
        Me.txtColor_2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColor_2.Name = "txtColor_2"
        Me.txtColor_2.Size = New System.Drawing.Size(132, 22)
        Me.txtColor_2.TabIndex = 57
        '
        'LapiceraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LapiceraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lapicera"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvGrilla_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipoGrafito As System.Windows.Forms.TextBox
    Friend WithEvents txtTrazo As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTipoPunta As TextBox
    Friend WithEvents btnListar_des As Button
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents trazo As DataGridViewTextBoxColumn
    Friend WithEvents tipoGrafito As DataGridViewTextBoxColumn
    Friend WithEvents TipoPunta As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvGrilla_2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaterial_2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Eliminar_2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Buscar_2 As Button
    Friend WithEvents txtTrazo_2 As TextBox
    Friend WithEvents Crear_2 As Button
    Friend WithEvents txtPunta_2 As TextBox
    Friend WithEvents Listar_2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Insertar_2 As Button
    Friend WithEvents txtMarca_2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtColor_2 As TextBox
End Class
