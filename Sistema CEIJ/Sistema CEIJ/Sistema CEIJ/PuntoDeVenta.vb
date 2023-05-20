Public Class PuntoDeVenta


    Private Sub NuevVentaPanel_Click(sender As Object, e As EventArgs) Handles NuevVentaPanel.Click, PictureBox2.Click, NuevaVentaLabel.Click
        NuevaVenta.Show()
    End Sub

    Private Sub HistorialPanel_Click(sender As Object, e As EventArgs) Handles HistorialPanel.Click, HistorialLabel.Click, ActividadesPictureBox.Click
        Historial.Show()
    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class