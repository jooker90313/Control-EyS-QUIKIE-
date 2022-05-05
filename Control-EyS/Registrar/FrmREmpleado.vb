Public Class FrmREmpleado

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
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

    Private Sub FrmREmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class