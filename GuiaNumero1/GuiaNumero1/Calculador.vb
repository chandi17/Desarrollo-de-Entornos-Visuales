Public Class Calculador

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Dim Historial As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "1"
        Historial &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "2"
        Historial &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "3"
        Historial &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "4"
        Historial &= "4"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "7"
        Historial &= "7"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "5"
        Historial &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "6"
        Historial &= "6"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "8"
        Historial &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "9"
        Historial &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        EvaluaRestriccionesParaConcatenar()
        txtScreen.Text &= "0"
        Historial &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(txtScreen.Text, ".", CompareMethod.Text) = 0 Then
            txtScreen.Text &= "."
            Historial &= "."
        End If
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        EvaluayHazOperacion()
        Operacion = "/"
        Historial &= "/"
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        EvaluayHazOperacion()
        Operacion = "*"
        Historial &= "*"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
        Historial &= "-"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
        Historial &= "+"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtScreen.Text = "0"
        txtHistorial.Text = Historial
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
        Historial &= "=" & ValorResultado & String.Format(Environment.NewLine)
    End Sub
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(txtScreen.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado += Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
                    FormatNumber(ValorResultado, 2)
            End Select
            txtScreen.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            txtScreen.Text = ""
            SePresionaOperador = False
        ElseIf txtScreen.Text = "0" Then
            txtScreen.Text = ""
        End If
    End Sub

    Private Sub txtHistorial_TextChanged(sender As Object, e As EventArgs) Handles txtHistorial.TextChanged

    End Sub

    Private Sub Calculador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
