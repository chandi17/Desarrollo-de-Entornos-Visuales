Public Class Sar
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim sueldo, sueldoNeto As Double
        sueldo = Val(txtSueldo.Text)


        If sueldo < 16582.92 Then
            CheckBox1.Checked = True
            sueldoNeto = sueldo

        ElseIf sueldo >= 16582.92 And sueldo <= 23536.61 Then
            CheckBox2.Checked = True
            sueldoNeto = sueldo * 0.85

        ElseIf sueldo > 23536.61 And sueldo <= 50317.69 Then
            CheckBox3.Checked = True
            sueldoNeto = sueldo * 0.8
        Else
            CheckBox4.Checked = True
            sueldoNeto = sueldo * 0.75
        End If
        txtSueldoNeto.Text = sueldoNeto
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        txtSueldo.Clear()
        txtSueldoNeto.Clear()
    End Sub

End Class