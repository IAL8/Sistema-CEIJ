Imports System.Reflection.Emit

Public Class Citas
    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        Me.Close()
    End Sub

    Private Sub Citas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuAgenda.Show()
    End Sub

    Private Sub Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Solicitudes' Puede moverla o quitarla según sea necesario.
        Me.SolicitudesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Solicitudes)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
        HoraDateTimePicker.Format = DateTimePickerFormat.Custom
        HoraDateTimePicker.CustomFormat = "HH:mm"
        HoraDateTimePicker.ShowUpDown = True
        FechaDateTimePicker.Value = Cit_Fecha
        ServicioTextBox.Text = Id_Servicio
        ServiciosDataGridView.Visible = False
        If Id_Solicitud > 0 Then
            HoraDateTimePicker.Value = Convert.ToDateTime(Cit_Hora)
            SClienteBTN.Visible = False
            ClientesDataGridView.Visible = False
            ClienteTextBox.Visible = False
            ClienteLabel.Visible = False
        End If
    End Sub

    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub SeleccionBTN_Click(sender As Object, e As EventArgs) Handles SeleccionBTN.Click
        ServiciosDataGridView.Visible = True
    End Sub

    Private Sub ServiciosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Servicio = ServiciosDataGridView.Item(0, e.RowIndex).Value
            ServicioTextBox.Text = Id_Servicio
            S_Precio = ServiciosDataGridView.Item(3, e.RowIndex).Value
            ServiciosDataGridView.Visible = False
        End If
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Servicio <> 0) Then
            If (Id_Solicitud = 0) Then
                If (Id_Cliente <> 0) Then
                    Me.SolicitudesTableAdapter.ISolicitud(ClienteTextBox.Text, "Pendiente", "En espera", S_Precio)
                    Me.SolicitudesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Solicitudes)
                    Id_Solicitud = Me.SolicitudesTableAdapter.SelectLasUserSol(Id_Cliente)
                    Me.CitasTableAdapter.RCita(Id_Solicitud, Id_Servicio, FechaDateTimePicker.Value, HoraDateTimePicker.Value.ToShortTimeString, S_Precio, 1)
                    Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
                    MsgBox("La cita se ha registrado")
                Else
                    MsgBox("Debe seleccionar un cliente")
                End If
            Else
                Me.CitasTableAdapter.UPCITA(Id_Solicitud, Id_Servicio, FechaDateTimePicker.Value, HoraDateTimePicker.Value.ToShortTimeString, S_Precio, Id_Solicitud, Original_Cita)
                Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
                MsgBox("La cita se ha actualizado")
            End If
        Else
            MsgBox("Debe seleccionar un servicio")
        End If
    End Sub

    Private Sub SClienteBTN_Click(sender As Object, e As EventArgs) Handles SClienteBTN.Click
        ClientesDataGridView.Visible = True
    End Sub

    Private Sub ClientesDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Cliente = ClientesDataGridView.Item(0, e.RowIndex).Value
            ClienteTextBox.Text = Id_Cliente
            ClientesDataGridView.Visible = False
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ServiciosTableAdapter.FillBy(Me.BD_Sistema_CEIJDataSet.Servicios)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class