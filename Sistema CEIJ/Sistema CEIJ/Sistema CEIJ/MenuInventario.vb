Public Class MenuInventario
    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub MenuInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub MenuInventario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        Me.InventarioTableAdapter.DInventario(Id_Prodcuto)
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
        MsgBox("El producto se ha eliminado")
    End Sub

    Private Sub NuevoBTN_Click(sender As Object, e As EventArgs) Handles NuevoBTN.Click
        Id_Prodcuto = 0
        P_Nombre = Nulo
        P_Cantidad = 0
        P_Precio = 0
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub MenuInventario_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
    End Sub

    Private Sub EditarBTN_Click(sender As Object, e As EventArgs) Handles EditarBTN.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles InventarioDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Prodcuto = InventarioDataGridView.Item(0, e.RowIndex).Value
            P_Nombre = InventarioDataGridView.Item(1, e.RowIndex).Value
            P_Cantidad = InventarioDataGridView.Item(2, e.RowIndex).Value
            P_Precio = InventarioDataGridView.Item(3, e.RowIndex).Value
        End If
    End Sub
End Class