Public Class LoginCONAHSA

    Private Sub LoginCONAHSA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Declaración de las variables a utilizar
        Dim pautaUsuario, pautaPassword, usuario, password, rPassword, rUsuario As String

        'Asignamos el valor que debe ingresar el usuario para poder entrar
        pautaUsuario = "Chandi17"
        pautaPassword = "Holamundo"
        'Leemos los valores Ingresados 
        usuario = txtUsuario.Text.ToString
                password = txtPassword.Text.ToString
                rUsuario = usuario = pautaUsuario
        rPassword = password = pautaPassword

        If rPassword = "True" And rUsuario = "True" Then
            Intentos = -1
            UsoCheckBox.Show()
            Me.Hide()
            Exit Sub

        End If
        Intentos -= 1
            txtPassword.Clear()
            txtUsuario.Clear()
            MessageBox.Show("Usuario o Contraseña incorrecto... Tiene " & Intentos & " Intentos restantes", "Error Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        ' btnLogin.PerformClick()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class