Imports Microsoft.VisualBasic.ApplicationServices

Public Class PuntoDeVenta


    Private Sub NuevVentaPanel_Click(sender As Object, e As EventArgs) Handles NuevVentaPanel.Click, PictureBox2.Click, NuevaVentaLabel.Click
        NuevaVenta.Show()
        Me.Hide()
    End Sub

    Private Sub HistorialPanel_Click(sender As Object, e As EventArgs) Handles HistorialPanel.Click, HistorialLabel.Click, ActividadesPictureBox.Click
        Historial.Show()
        Me.Hide()
    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub PuntoDeVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = UsuarioActual
    End Sub
End Class