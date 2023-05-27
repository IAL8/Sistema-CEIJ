Public Class Productos
    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        MenuInventario.Show()
        Me.Close()
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Prodcuto = 0) Then
            Me.InventarioTableAdapter.RInventario(NombreTextBox.Text, CantidadTextBox.Text, PrecioTextBox.Text)
            MsgBox("El producto se ha registrado")
        Else
            Me.InventarioTableAdapter.UInventario(NombreTextBox.Text, CantidadTextBox.Text, PrecioTextBox.Text, Id_Prodcuto)
            MsgBox("El producto se ha actualizado")
        End If
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
    End Sub

    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inventario)
        NombreTextBox.Text = P_Nombre
        CantidadTextBox.Text = P_Cantidad
        PrecioTextBox.Text = P_Precio
    End Sub
End Class