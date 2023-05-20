Public Class Historial
    Private Sub SolicitudesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SolicitudesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SolicitudesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub
    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        PuntoDeVenta.Show()
        Me.Close()
    End Sub
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SolicitudesTableAdapter.FillBySComplete(Me.BD_Sistema_CEIJDataSet.Solicitudes)
    End Sub
End Class