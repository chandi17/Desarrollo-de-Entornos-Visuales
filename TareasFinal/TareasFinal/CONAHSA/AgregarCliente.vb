Public Class AgregarCliente
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chekGeneral.CheckedChanged, chekEmpresarial.CheckedChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        PrincipalCONAHSA.Show()
    End Sub
End Class