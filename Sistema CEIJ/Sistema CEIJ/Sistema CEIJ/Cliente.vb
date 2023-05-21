Public Class Cliente
    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Cliente = 0) Then
            Me.ClientesTableAdapter.RCliente(NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text)
            MsgBox("El cliente se ha registrado")
        Else
            Me.ClientesTableAdapter.UCliente(NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, Id_Cliente)
            MsgBox("El cliente se ha actualizado")
        End If
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
        NombreTextBox.Text = C_Nombre
        ApellidoTextBox.Text = C_Apellido
        CorreoTextBox.Text = C_Correo
        TelefonoTextBox.Text = C_Telefono
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        Me.Close()
        MenuClientes.Show()
    End Sub
End Class