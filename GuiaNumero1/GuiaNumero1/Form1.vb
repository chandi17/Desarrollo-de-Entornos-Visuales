Public Class Form1
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

    End Sub

    Private Sub btnNo_MouseHover(sender As Object, e As EventArgs) Handles btnNo.MouseHover
        btnNo.Text = "Si"
    End Sub

    Private Sub btnNo_MouseLeave(sender As Object, e As EventArgs) Handles btnNo.MouseLeave
        btnNo.Text = "No"
    End Sub
End Class