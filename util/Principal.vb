Public Class Principal
    Private Sub FibraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FibraToolStripMenuItem.Click
        Dim formulario As New FibraForm
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub LapizToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LapizToolStripMenuItem.Click
        Dim formulario As New LapizForm
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub LapiceraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LapiceraToolStripMenuItem.Click
        Dim formulario As New LapiceraForm
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub CuadernoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoToolStripMenuItem.Click
        Dim formulario As New CuadernoForm
        formulario.MdiParent = Me
        formulario.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim formulario As New LapizForm
        formulario.MdiParent = Me
        formulario.Show()
    End Sub
End Class