Public Class AgregarProyecto
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            Me.Hide()
            PrincipalCONAHSA.Show()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim tipoProyecto As Integer
        Dim encargado, Direccion, descripcion, CodigoProyecto, codigoCliente, pautaCodigoProyecto, pautaCodigoCliente As String
        Dim Respuesta1, Respuesta2, RTipoProyecto As String
        pautaCodigoCliente = "7777"
        pautaCodigoCliente = "1010"
        Try
            codigoCliente = txtcodigoCliente.Text
            CodigoProyecto = txtcodigoCliente.Text
            encargado = txtEntregado.Text
            Direccion = txtDireccion.Text
            tipoProyecto = cmbTipoProyecto.SelectedIndex
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Respuesta1 = pautaCodigoCliente = codigoCliente
        Respuesta2 = pautaCodigoProyecto = CodigoProyecto
        descripcion = txtDescripcion.Text

        If Respuesta1 <> "True" And Respuesta2 <> "True" Then
            Select Case tipoProyecto
                Case 0
                    RTipoProyecto = "Residencial"
                Case 1
                    RTipoProyecto = "Urbano"
                Case 2
                    RTipoProyecto = "Apertura de Calle"
                Case Else
                    MessageBox.Show("Error, consulte con el encargado", "Entrega de Municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
            MsgBox("Proyecto Ingresado con Exito")
            btnNuevo.Enabled = True
            Exit Sub
        Else
            MsgBox("Asegurese de que los codigos no existan ""CONAHSA", MessageBoxIcon.Error)
            Limpiar()
        End If

    End Sub
    Private Function Limpiar()
        txtcodigoCliente.Clear()
        txtCodigoProyecto.Clear()
        txtDescripcion.Clear()
        txtDireccion.Clear()
        txtEntregado.Clear()
        cmbTipoProyecto.Text = ""


    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub txtCodigoCliente_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCodigoCliente.MaskInputRejected

    End Sub

    Private Sub AgregarProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoProyecto.Focus()
    End Sub

    Private Sub txtCodigoProyecto_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCodigoProyecto.MaskInputRejected

    End Sub

    Private Sub txtCodigoProyecto_Validated(sender As Object, e As EventArgs) Handles txtCodigoProyecto.Validated

    End Sub
End Class