<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.UtilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapiceraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadernoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilesToolStripMenuItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(409, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'UtilesToolStripMenuItem
        '
        Me.UtilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FibraToolStripMenuItem, Me.LapizToolStripMenuItem, Me.LapiceraToolStripMenuItem, Me.CuadernoToolStripMenuItem})
        Me.UtilesToolStripMenuItem.Name = "UtilesToolStripMenuItem"
        Me.UtilesToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.UtilesToolStripMenuItem.Text = "Utiles"
        '
        'FibraToolStripMenuItem
        '
        Me.FibraToolStripMenuItem.Name = "FibraToolStripMenuItem"
        Me.FibraToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.FibraToolStripMenuItem.Text = "Fibra"
        '
        'LapizToolStripMenuItem
        '
        Me.LapizToolStripMenuItem.Name = "LapizToolStripMenuItem"
        Me.LapizToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.LapizToolStripMenuItem.Text = "Lapiz"
        '
        'LapiceraToolStripMenuItem
        '
        Me.LapiceraToolStripMenuItem.Name = "LapiceraToolStripMenuItem"
        Me.LapiceraToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.LapiceraToolStripMenuItem.Text = "Lapicera"
        '
        'CuadernoToolStripMenuItem
        '
        Me.CuadernoToolStripMenuItem.Name = "CuadernoToolStripMenuItem"
        Me.CuadernoToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.CuadernoToolStripMenuItem.Text = "Cuaderno"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 297)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents UtilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FibraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LapizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LapiceraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadernoToolStripMenuItem As ToolStripMenuItem
End Class
