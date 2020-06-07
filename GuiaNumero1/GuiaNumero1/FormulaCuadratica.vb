Public Class FormulaCuadratica

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtX2.TextChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaracion de las variabes
        Dim A, B, C, D, X1, X2 As Double

        Try
            A = Val(txtA.Text)
            B = Val(txtB.Text)
            C = Val(txtC.Text)

            D = (B ^ 2) - (4 * A * C)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If D < 0 Then
            MessageBox.Show("No existe una Solucion Real para esta ecuación", "Formula Cuadratica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            txtX1.Clear()
            txtX2.Clear()
            Exit Sub
        End If

        X1 = -B + ((D) ^ 1 / 2) / 2 * A
        X2 = -B - ((D) ^ 1 / 2) / 2 * A

        txtX1.Text = X1
        txtX2.Text = X2
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class