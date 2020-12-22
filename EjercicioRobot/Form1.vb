Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButtonMarte.Checked = True Then
            MsgBox(" EL ROBOT CURIOSITY LLEGO A MARTE EN EL 2012",, "Vamos a Marte")
        Else
            MsgBox(" Vuelvelo a intentar",, "Respuesta incorrepta")
        End If

    End Sub

    Private Sub RadioButtonMarte_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMarte.CheckedChanged

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class