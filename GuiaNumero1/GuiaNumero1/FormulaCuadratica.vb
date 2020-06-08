Imports System.ComponentModel

Public Class FormulaCuadratica

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtX2.TextChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaracion de las variabes
        Dim A, B, C, D, X1, X2 As Double

        Try

            If txtA.Text = "" Or txtB.Text = "" Or txtC.Text = "" Then
                MessageBox.Show("Debe llenar todas las casillas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Not Val(txtA.Text) Or Not Val(txtB.Text) Or Not Val(txtC.Text) Then
                MessageBox.Show("Debe ingresar valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

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

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged

    End Sub

    Private Sub txtA_Validating(sender As Object, e As CancelEventArgs) Handles txtA.Validating
        If txtA.Text <> "" Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero")
        End If
    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub txtB_Validating(sender As Object, e As CancelEventArgs) Handles txtB.Validating
        If txtB.Text <> "" Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero")
        End If
    End Sub

    Private Sub txtC_Validating(sender As Object, e As CancelEventArgs) Handles txtC.Validating
        If txtC.Text <> "" Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero")
        End If
    End Sub

    Private Sub txtA_MouseHover(sender As Object, e As EventArgs) Handles txtA.MouseHover
        ToolTip.SetToolTip(txtA, "Ingrese El valor de X^2")
        ToolTip.ToolTipTitle = "X^2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_MouseHover(sender As Object, e As EventArgs) Handles txtB.MouseHover
        ToolTip.SetToolTip(txtB, "Ingrese El valor de X")
        ToolTip.ToolTipTitle = "X^2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged

    End Sub

    Private Sub txtC_MouseHover(sender As Object, e As EventArgs) Handles txtC.MouseHover
        ToolTip.SetToolTip(txtC, "Ingrese El valor de x^2")
        ToolTip.ToolTipTitle = "Constante"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub FormulaCuadratica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class