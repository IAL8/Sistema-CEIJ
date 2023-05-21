Public Class Servicio
    Private Sub Servicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        NombreTextBox.Text = S_Nombre
        CategoriaTextBox.Text = S_Categoria
        PrecioTextBox.Text = S_Precio
        DisponibilidadCheclbox.Checked = S_Disponibilidad

    End Sub

    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiciosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Servicio = 0) Then
            Me.ServiciosTableAdapter.RServicio(NombreTextBox.Text, CategoriaTextBox.Text, PrecioTextBox.Text, DisponibilidadCheclbox.Checked)
            MsgBox("El servicio se ha registrado")
        Else
            Me.ServiciosTableAdapter.UServicio(NombreTextBox.Text, CategoriaTextBox.Text, PrecioTextBox.Text, DisponibilidadCheclbox.Checked, Id_Servicio)
            MsgBox("El servicio se ha actualizado")
        End If
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        MenuServicios.Show()
        Me.Close()
    End Sub
End Class