Public Class UsoCheckBox
    Private Sub chkSuma_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuma.CheckedChanged
        txtNumero1.Focus()
        If chkSuma.Checked = True Then
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkSuma.Checked = False Then
            chkResta.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtnumero2.Enabled = True
    End Sub

    Private Sub chkResta_CheckedChanged(sender As Object, e As EventArgs) Handles chkResta.CheckedChanged
        txtNumero1.Focus()

        If chkResta.Checked = True Then
            chkSuma.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkResta.Checked = False Then
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtNumero2.Enabled = True
    End Sub

    Private Sub chkMulti_CheckedChanged(sender As Object, e As EventArgs) Handles chkMulti.CheckedChanged
        txtNumero1.Focus()

        If chkMulti.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkMulti.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtNumero2.Enabled = True
    End Sub

    Private Sub chkRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles chkRaiz.CheckedChanged
        txtNumero1.Focus()
        If chkRaiz.Checked = True Then
            chkSuma.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkResta.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkRaiz.Checked = False Then
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkResta.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtNumero2.Enabled = False


    End Sub

    Private Sub chkDivi_CheckedChanged(sender As Object, e As EventArgs) Handles chkDivi.CheckedChanged
        txtNumero1.Focus()

        If chkDivi.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkDivi.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtNumero2.Enabled = True
    End Sub

    Private Sub chkPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkPotencia.CheckedChanged
        txtNumero1.Focus()

        If chkPotencia.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkRaiz.Enabled = False
            chkDivi.Enabled = False
        End If
        If chkPotencia.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkRaiz.Enabled = True
            chkDivi.Enabled = True
        End If
        txtNumero2.Enabled = True
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero1, numero2 As Integer
        Dim Respuesta As Double
        'Asignacion de valores a las variables

        numero1 = Val(txtNumero1.Text)
        numero2 = Val(txtNumero2.Text)
        If chkSuma.Checked = True Then
            Respuesta = numero1 + numero2
            txtRespuesta.Text = Respuesta

        ElseIf chkResta.Checked = True Then
            Respuesta = numero1 - numero2
            txtRespuesta.Text = Respuesta
        ElseIf chkMulti.Checked = True Then
            Respuesta = numero1 * numero2
            txtRespuesta.Text = Respuesta
        ElseIf chkDivi.Checked = True Then
            Respuesta = numero1 / numero2
            txtRespuesta.Text = Respuesta
        ElseIf chkPotencia.Checked = True Then
            Respuesta = numero1 ^ numero2
            txtRespuesta.Text = Respuesta
        ElseIf chkRaiz.Checked = True Then
            Respuesta = numero1 ^ 0.5
            txtRespuesta.Text = Respuesta
        End If



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero1.Clear()
        txtNumero2.Clear()
        txtRespuesta.Clear()

        chkResta.Enabled = True
        chkSuma.Enabled = True
        chkMulti.Enabled = True
        chkRaiz.Enabled = True
        chkDivi.Enabled = True
        chkPotencia.Enabled = False
        chkResta.Checked = False
        chkSuma.Checked = False
        chkMulti.Checked = False
        chkRaiz.Checked = False
        chkDivi.Checked = False
        chkPotencia.Checked = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class