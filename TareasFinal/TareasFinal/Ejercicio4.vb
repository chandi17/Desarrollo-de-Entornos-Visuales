﻿Public Class Ejercicio4
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        Dim cantidad, suma, negativos, positivos, impares, pares As Integer
        cantidad = Val(txtCantidad.Text)
        Try
            Do
                valor = InputBox("Ingrese un numero entero (0 para finalizar)", "Ingresar")
                If (valor <> 0) Then
                    cmbNumeros.Items.Add(valor)
                End If
                If (valor < 0) Then
                    negativos += 1
                Else
                    positivos += 1
                End If


                If (valor Mod 2 <> 0) Then
                    impares += 1
                Else
                    pares += 1
                End If

                cantidad += 1
                suma += valor
            Loop While (valor <> 0)
            txtCantidad.Text = cantidad - 1
            txtSuma.Text = suma
            txtNegativos.Text = negativos
            txtPositivos.Text = positivos - 1
            txtPares.Text = pares - 1
            txtImpares.Text = impares
        Catch ex As Exception
            MsgBox("Ha ocurrido un error!!!")
        End Try


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub ingresodeNumeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbNumeros.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Ingresa los numeros que el usuario desea utilizar")
        ToolTip.ToolTipTitle = "Ingresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip.SetToolTip(btnSalir, "Abandona ingreso de Numeros")
        ToolTip.ToolTipTitle = "Salir"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ToolTip.SetToolTip(btnNuevo, "Realiza una nueva lista de numeros a ultilizar")
        ToolTip.ToolTipTitle = "Nuevo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

        ToolTip.SetToolTip(cmbNumeros, "Muestra la lista de numeros a utilizar")
        ToolTip.ToolTipTitle = "lista"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class