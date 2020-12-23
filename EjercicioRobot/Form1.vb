Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButtonMarte.Checked = True Then
            MsgBox(" EL ROBOT CURIOSITY LLEGO A MARTE EN EL 2012",, "Vamos a Marte")
        ElseIf RadioButtonDiaMartes.Checked = True Then
            MsgBox(" Martes es un dia de la semana",, "Martes y 13! Bufff")
        Else

            MsgBox(" Vuelvelo a intentar",, "Respuesta incorrepta")
        End If
    End Sub

    Private Sub ButtonSalir_Click_1(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub

    Private Sub ButtonFrase_Click(sender As Object, e As EventArgs) Handles ButtonFrase.Click
        Dim D As String = "Descartes"
        Dim P As String = "Platon"
        If TextBoxFrase.Text = D Or RadioButtonDescartes.Checked = True Then
            LabelRespuesta.Text = "¡Pienso luego existo!"
        ElseIf TextBoxFrase.Text = P Or RadioButtonPlaton.Checked = True Then
            LabelRespuesta.Text = " ¡Solo sé que nada se!"
        Else
            LabelRespuesta.Text = ""
            MsgBox("Escriba Descartes o Platón para ver sus Frases famosas.",, "Texto Mal")
        End If

    End Sub

    Private Sub TextBoxFrase_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFrase.TextChanged


    End Sub

    Private Sub TextBoxFrase_Click(sender As Object, e As EventArgs) Handles TextBoxFrase.Click
        TextBoxFrase.Text = ""
        RadioButtonDescartes.Checked = False
        RadioButtonPlaton.Checked = False
    End Sub

    Private Sub RadioButtonPlaton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPlaton.CheckedChanged
        LabelRespuesta.Text = ""
        TextBoxFrase.Text = "Platon"
    End Sub

    Private Sub RadioButtonDescartes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDescartes.CheckedChanged
        LabelRespuesta.Text = ""
        TextBoxFrase.Text = "Descartes"
    End Sub

    Private Sub TextBoxFrase_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBoxFrase.MouseClick
        LabelRespuesta.Text = ""
        TextBoxFrase.Text = ""
    End Sub
End Class