Public Class FacturaSencilla
    Private Sub FacturaSencilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrecio.Focus()
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged

    End Sub

    Private Sub chkDescuento_Click(sender As Object, e As EventArgs) Handles chkDescuento.Click
        If cmbDescuento.Enabled = True Then
            cmbDescuento.Enabled = False
        End If
        If cmbDescuento.Enabled = False Then
            cmbDescuento.Enabled = True
        End If

        If chkISV.Enabled = True Then
            chkISV.Enabled = False
        End If
        If chkISV.Enabled = False Then
            chkISV.Enabled = True
        End If
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged

    End Sub

    Private Sub chkISV_Click(sender As Object, e As EventArgs) Handles chkISV.Click
        If cmbISV.Enabled = True Then
            cmbISV.Enabled = False
        End If
        If cmbISV.Enabled = False Then
            cmbISV.Enabled = True
        End If
        If chkDescuento.Enabled = True Then
            chkDescuento.Enabled = False
        End If
        If chkDescuento.Enabled = False Then
            chkDescuento.Enabled = True
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el Precio Unitario")
        End If
    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese la Cantidad")
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        btnNuevo.Enabled = False
        Dim Cantidad As Integer
        Dim Descuento, ISV, subTotal, Total, precioU, op As Double
        Try
            If chkDescuento.Checked = True And chkISV.Checked = True Then
                MsgBox("Debe seleccionar unicamente una opción")
                Exit Sub
            End If
            If chkDescuento.Checked = False And chkISV.Checked = False Then
                MsgBox("Debe seleccionar al menos una opción")
                Exit Sub
            End If
            If Me.ValidateChildren And txtCantidad.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                'MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Compra realizada con exito ", "Formulario Factura_Sencilla", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cantidad = txtCantidad.Text
        precioU = txtPrecio.Text

        If chkDescuento.Checked = True Then
            op = cmbDescuento.SelectedIndex
            Select Case op
                Case 0
                    Descuento = 0.15
                Case 1
                    Descuento = 0.1
                Case 2
                    Descuento = 0.5
                Case 3
                    Descuento = 0.2
                Case 4
                    Descuento = 0.17
                Case Else
                    MsgBox("Error al ingresar datos")
            End Select
        End If
        If chkISV.Checked = True Then
            op = cmbISV.SelectedIndex
            Select Case op
                Case 0
                    ISV = 0.12
                Case 1
                    ISV = 0.15
            End Select
        End If
        subTotal = Cantidad * precioU
        Total = subTotal - (subTotal * Descuento) + (subTotal * ISV)
        txtDescuento.Text = subTotal * Descuento
        txtISV.Text = subTotal * ISV
        txtSubtotal.Text = subTotal
        txtTotal.Text = Total
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtSubtotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        txtTotal.Clear()
        chkDescuento.Checked = False
        chkISV.Checked = False
        cmbDescuento.Text = ""
        cmbISV.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        
    End Sub

    Private Sub cmbDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescuento.SelectedIndexChanged

    End Sub
End Class
