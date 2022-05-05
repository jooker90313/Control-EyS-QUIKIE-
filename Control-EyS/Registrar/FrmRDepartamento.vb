Public Class FrmRDepartamento
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim response
        response = MsgBox("¿Desea regresar al Inicio? ", vbYesNo, "Notificacion")
        If response = vbYes Then
            FrmInicioAdmin.Show()
            Me.Hide()

        Else
            DialogResult = vbNo
            Return

        End If

    End Sub

    Private Sub FrmRDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged

    End Sub
End Class