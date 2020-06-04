Public Class PrincipalCONAHSA
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarCliente.Show()
    End Sub

    Private Sub btnProyecto_Click(sender As Object, e As EventArgs) Handles btnProyecto.Click
        Me.Hide()
        AgregarProyecto.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Hide()
        AgregarCliente.Show()
    End Sub

    Private Sub AgregarContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarContratoToolStripMenuItem.Click
        Me.Hide()
        AgregarProyecto.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        LoginCONAHSA.Show()
    End Sub
End Class