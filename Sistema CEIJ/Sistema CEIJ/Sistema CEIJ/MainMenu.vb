Public Class MainMenu
    Private Sub MainMenuvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = UsuarioActual
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogIn.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class