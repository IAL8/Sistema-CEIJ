Public Class MenuServicios
    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiciosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub MenuServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ServiciosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Servicio = ServiciosDataGridView.Item(0, e.RowIndex).Value
            S_Nombre = ServiciosDataGridView.Item(1, e.RowIndex).Value
            S_Categoria = ServiciosDataGridView.Item(2, e.RowIndex).Value
            S_Precio = ServiciosDataGridView.Item(3, e.RowIndex).Value
            S_Disponibilidad = ServiciosDataGridView.Item(4, e.RowIndex).Value
        End If
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        Me.ServiciosTableAdapter.DServicio(Id_Servicio)
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        MsgBox("El servicio se ha eliminado")
    End Sub

    Private Sub MenuServicios_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
    End Sub

    Private Sub NuevoBTN_Click(sender As Object, e As EventArgs) Handles NuevoBTN.Click
        Id_Servicio = 0
        S_Nombre = Nulo
        S_Categoria = Nulo
        S_Disponibilidad = True
        S_Precio = 0
        Servicio.Show()
        Me.Hide()
    End Sub

    Private Sub EditarBTN_Click(sender As Object, e As EventArgs) Handles EditarBTN.Click
        Servicio.Show()
        Me.Hide()
    End Sub
End Class