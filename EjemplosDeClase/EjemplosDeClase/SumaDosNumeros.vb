Public Class SumaDosNumeros
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Numero1, Numero2, Respuesta As Integer

        Numero1 = txtNumero1.Text
        Numero2 = txtNumero2.Text

        Respuesta = Numero1 + Numero2

        txtRespuesta.Text = Respuesta

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
