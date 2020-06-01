Public Class Validacion
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim valor As Int16
        'int16 

        If txtNumero.Text = "" Then
            MsgBox("Escriba  un numero en la casila", vbInformation)
            'Not isnumeric verifica si no es numerico
        ElseIf Not IsNumeric(txtNumero.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)

            'isnumeric verifica si es numerico
            'prodia ser isNumeric(valor) o isNumeric(Val(txtNumero.Text))
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
                'vbinformativo es para que aparezca el icono de !
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If
    End Sub
End Class