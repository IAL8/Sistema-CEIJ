Public Class MenuClientes
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub MenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NuevoBTN_Click(sender As Object, e As EventArgs) Handles NuevoBTN.Click
        Id_Cliente = 0
        C_Nombre = Nulo
        C_Apellido = Nulo
        C_Correo = Nulo
        C_Telefono = Nulo
        Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        Try
            Me.ClientesTableAdapter.DCliente(Id_Cliente)
            Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
            MsgBox("El cliente  se ha eliminado")
            Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
        Catch ex As System.Exception
            MsgBox("El usuario tiene asuntos pendientes")
        End Try
    End Sub

    Private Sub EditarBTN_Click(sender As Object, e As EventArgs) Handles EditarBTN.Click
        Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub MenuClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub ClientesDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Cliente = ClientesDataGridView.Item(0, e.RowIndex).Value
            C_Nombre = ClientesDataGridView.Item(1, e.RowIndex).Value
            C_Apellido = ClientesDataGridView.Item(2, e.RowIndex).Value
            C_Correo = ClientesDataGridView.Item(3, e.RowIndex).Value
            C_Telefono = ClientesDataGridView.Item(4, e.RowIndex).Value
        End If
    End Sub

    Private Sub MenuClientes_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
    End Sub
End Class