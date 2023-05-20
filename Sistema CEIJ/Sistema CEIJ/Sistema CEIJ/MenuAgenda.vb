Public Class MenuAgenda
    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)
        Id_Solicitud = 0
        Id_Cliente = 0
        Id_Servicio = 0
    End Sub

    Private Sub MenuAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.AgendaDataTable' Puede moverla o quitarla según sea necesario.
        Me.AgendaDataTableTableAdapter.FillCitas(Me.BD_Sistema_CEIJDataSet.AgendaDataTable)
        Cit_Fecha = Nothing

    End Sub

    Private Sub AgendaDataTableDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgendaDataTableDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Solicitud = AgendaDataTableDataGridView.Item(0, e.RowIndex).Value
            Id_Cliente = AgendaDataTableDataGridView.Item(1, e.RowIndex).Value
            Id_Servicio = AgendaDataTableDataGridView.Item(3, e.RowIndex).Value
            Cit_Fecha = AgendaDataTableDataGridView.Item(5, e.RowIndex).Value
            Cit_Hora = AgendaDataTableDataGridView.Item(6, e.RowIndex).Value
        End If
    End Sub

    Private Sub NuevoBTN_Click(sender As Object, e As EventArgs) Handles NuevoBTN.Click
        Id_Solicitud = 0
        Id_Servicio = 0
        Id_Cliente = 0
        Cit_Fecha = Date.Today
        Cit_Hora = Nulo
        Citas.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        If (Id_Solicitud <> 0) Then
            Me.CitasTableAdapter.DCita(Id_Solicitud, Id_Servicio)
            Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
            Me.AgendaDataTableTableAdapter.FillCitas(Me.BD_Sistema_CEIJDataSet.AgendaDataTable)
        Else
            MsgBox("Debe seleccionar algun elemento para acceder a esta función")
        End If
    End Sub

    Private Sub EditarBTN_Click(sender As Object, e As EventArgs) Handles EditarBTN.Click
        If (Id_Solicitud <> 0) Then
            Citas.Show()
            Me.Hide()
        Else
            MsgBox("Debe seleccionar algun elemento para acceder a esta función")
        End If
    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub MenuAgenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Close()
    End Sub

    Private Sub MenuAgenda_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.CitasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Citas)
        Me.AgendaDataTableTableAdapter.FillCitas(Me.BD_Sistema_CEIJDataSet.AgendaDataTable)
        Cit_Fecha = Nothing
    End Sub
End Class