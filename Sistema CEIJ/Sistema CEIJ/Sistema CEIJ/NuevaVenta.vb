Public Class NuevaVenta
    Public FilaVenta As Integer = -1
    Public Tamaño As Integer = 0
    Public VentaTotal As Decimal = 0
    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub NuevaVenta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PuntoDeVenta.Show()
    End Sub

    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Inscripciones' Puede moverla o quitarla según sea necesario.
        Me.InscripcionesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inscripciones)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Solicitudes' Puede moverla o quitarla según sea necesario.
        Me.SolicitudesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Solicitudes)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.AgendaDataTable' Puede moverla o quitarla según sea necesario.
        Me.AgendaDataTableTableAdapter.FillCitas(Me.BD_Sistema_CEIJDataSet.AgendaDataTable)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
        AgregarComboBox.Items.Add("Servicio")
        AgregarComboBox.Items.Add("Inscripción")
        ServiciosDataGridView.Visible = False
        CursosDataGridView.Visible = False
        ClientesDataGridView.Visible = False
        Curso = 0
        Id_Servicio = 0
        Id_Cliente = 0
    End Sub

    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub AgregarComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles AgregarComboBox.SelectedValueChanged
        Curso = 0
        Id_Servicio = 0
        Id_Prodcuto = 0
        If (AgregarComboBox.Text = "Servicio") Then
            ServiciosDataGridView.Visible = True
            CursosDataGridView.Visible = False
            ClientesDataGridView.Visible = False
        ElseIf (AgregarComboBox.Text = "Inscripción") Then
            CursosDataGridView.Visible = True
            ServiciosDataGridView.Visible = False
            ClientesDataGridView.Visible = False
        End If
    End Sub

    Private Sub ServiciosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Servicio = ServiciosDataGridView.Item(0, e.RowIndex).Value
            S_Nombre = ServiciosDataGridView.Item(1, e.RowIndex).Value
            S_Precio = ServiciosDataGridView.Item(2, e.RowIndex).Value
        End If
    End Sub

    Private Sub CursosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CursosDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Curso = CursosDataGridView.Item(0, e.RowIndex).Value
            Cu_Nombre = CursosDataGridView.Item(1, e.RowIndex).Value
            Cu_Precio = CursosDataGridView.Item(5, e.RowIndex).Value
        End If
    End Sub

    Private Sub SClienteBTN_Click(sender As Object, e As EventArgs) Handles SClienteBTN.Click
        ClientesDataGridView.Visible = True
        ServiciosDataGridView.Visible = False
        CursosDataGridView.Visible = False
    End Sub

    Private Sub ClientesDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Cliente = ClientesDataGridView.Item(0, e.RowIndex).Value
            ClienteTextBox.Text = Id_Cliente
            ClientesDataGridView.Visible = False
        End If
    End Sub

    Private Sub VentaDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentaDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            FilaVenta = e.RowIndex
        End If
    End Sub

    Private Sub Agregar(ID, Nombre, Tipo, Precio)
        VentaDataGridView.Rows.Add(ID, Nombre, Tipo, Precio)
    End Sub
    Private Sub ConfirmarBTN_Click(sender As Object, e As EventArgs) Handles ConfirmarBTN.Click
        If (Id_Servicio <> 0) Then
            Agregar(Id_Servicio, S_Nombre, "Servicio", S_Precio)
            ServiciosDataGridView.Visible = False
            Tamaño += 1
        ElseIf (Curso <> 0) Then
            Agregar(Curso, Cu_Nombre, "Curso", Cu_Precio)
            CursosDataGridView.Visible = False
            Tamaño += 1
        End If
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        If (FilaVenta >= 0) Then
            VentaDataGridView.Rows.RemoveAt(FilaVenta)
            FilaVenta = -1
            Tamaño -= 1
        Else
            MsgBox("Debe seleccionar un elemento del carrito para eleiminarlo")
        End If
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Cliente <> 0) Then
            If VentaDataGridView.Rows.Count > 0 Then
                Me.SolicitudesTableAdapter.ISolicitud(Id_Cliente, Date.Now.ToShortDateString, "Completada", S_Precio)
                Me.SolicitudesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Solicitudes)
                Id_Solicitud = Me.SolicitudesTableAdapter.SelectLasUserSol(Id_Cliente)
                For i As Integer = 0 To VentaDataGridView.Rows.Count
                    If (Tamaño > i) Then
                        RegistrarDetalle(VentaDataGridView.Rows(i).Cells(0).Value, VentaDataGridView.Rows(i).Cells(1).Value, VentaDataGridView.Rows(i).Cells(2).Value, VentaDataGridView.Rows(i).Cells(3).Value)
                    End If
                Next
                Me.SolicitudesTableAdapter.USolicitudTotal(VentaTotal, Id_Solicitud)
                Me.SolicitudesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Solicitudes)
                MsgBox("Se completo con exito la compra")
                Me.Close()
            Else
                MsgBox("No puede realizar ventas vacias")
            End If
        Else
            MsgBox("Debes elegir un cliente")
        End If
    End Sub

    Private Sub RegistrarDetalle(ID, Nombre, Tipo, Precio)
        If (Tipo = "Servicio") Then
            Me.CitasTableAdapter.RCita(Id_Solicitud, ID, Date.Now.ToShortDateString, Date.Now.ToShortTimeString, Convert.ToDecimal(Precio), 2)
            Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
            VentaTotal += Precio
        ElseIf (Tipo = "Curso") Then
            Me.InscripcionesTableAdapter.IInscripcion(Id_Solicitud, ID, Convert.ToDecimal(Precio))
            Me.InscripcionesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inscripciones)
            VentaTotal += Precio
        End If
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        If (Tamaño <> 0) Then
            For Each r As DataGridViewRow In VentaDataGridView.SelectedRows
                VentaDataGridView.Rows.Remove(r)
            Next
            Tamaño = 0
        Else
            MsgBox("No hay nada que eliminar")
        End If
    End Sub
End Class