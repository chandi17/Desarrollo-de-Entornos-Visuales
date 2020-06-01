Public Class Calculadora
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero1.Clear()
        txtNumero2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMulti.Clear()
        txtDivi.Clear()

        txtNumero1.Focus()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Valor1, Valor2, Suma, Multi, Resta As Integer
        Dim Divi As Double

        If Not Val(txtNumero1.Text) Then
            MsgBox("Ingrese un Valor Numerico ")
        End If


        Valor1 = txtNumero1.Text
        Valor2 = txtNumero2.Text

        Suma = Valor1 + Valor2
        Resta = Valor1 - Valor2
        Multi = Valor1 * Valor2
        Divi = Valor1 / Valor2

        txtSuma.Text = Suma
        txtResta.Text = Resta
        txtMulti.Text = Multi
        txtDivi.Text = Divi

    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class