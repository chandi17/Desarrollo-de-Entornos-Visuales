Public Class Factura
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtSubtotal.Clear()
        txtDescuento.Clear()
        txtTotal.Clear()
        If chkDescuento.Checked = True Then
            chkDescuento.Checked = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pUnitario, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplicarDescuento As Boolean

        pUnitario = Val(txtPrecio.Text)
        cantidad = Val(txtCantidad.Text)

        aplicarDescuento = chkDescuento.Checked
        descuento = 0
        subtotal = pUnitario * cantidad
        If aplicarDescuento = True Then
            descuento = subtotal * 0.05
        End If

        total = subtotal - descuento
        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtTotal.Text = total
    End Sub
End Class