Public Class EjemploCicloFor
    Private Sub EjemploCicloFor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As Int16
        For c = 0 To 4 Step 1
            MsgBox("Hola Mundo")
        Next

    End Sub
End Class