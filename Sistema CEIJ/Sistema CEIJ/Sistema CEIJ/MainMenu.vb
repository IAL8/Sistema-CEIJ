Public Class MainMenu
    Private Sub MainMenuvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = UsuarioActual
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogIn.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub ClientesPanel_Click(sender As Object, e As EventArgs) Handles ClientesPanel.Click, PictureBox4.Click, ClientesLabel.DragLeave
        MenuClientes.Show()
        Me.Hide()
    End Sub

    Private Sub CursosPanel_Click(sender As Object, e As EventArgs) Handles CursosPanel.Click, CursosLabel.Click, ActividadesPictureBox.Click
        MenuCursos.Show()
        Me.Hide()
    End Sub

    Private Sub ServiciosPanel_Click(sender As Object, e As EventArgs) Handles ServiciosPanel.Click, PictureBox3.Click, Label8.Click
        MenuServicios.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioPanel_Click(sender As Object, e As EventArgs) Handles InventarioPanel.Click, PictureBox5.Click, Label1.Click
        MenuInventario.Show()
        Me.Hide()
    End Sub

    Private Sub AgendalPanel_Click(sender As Object, e As EventArgs) Handles AgendalPanel.Click, PictureBox2.Click, AgendaLabel.Click
        MenuAgenda.Show()
        Me.Hide()
    End Sub
End Class