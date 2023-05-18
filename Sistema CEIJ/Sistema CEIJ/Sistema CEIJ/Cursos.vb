Public Class Cursos
    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        HoraIDateTimePicker.Format = DateTimePickerFormat.Custom
        HoraIDateTimePicker.CustomFormat = "HH:mm"
        HoraIDateTimePicker.ShowUpDown = True
        HoraFDateTimePicker.Format = DateTimePickerFormat.Custom
        HoraFDateTimePicker.CustomFormat = "HH:mm"
        HoraFDateTimePicker.ShowUpDown = True
        FechaDateTimePicker.Value = Cu_Fecha
        NombreTextBox.Text = Cu_Nombre
        If Id_Curso > 0 Then
            HoraIDateTimePicker.Value = Convert.ToDateTime(Cu_HoraI)
            HoraFDateTimePicker.Value = Convert.ToDateTime(Cu_HoraF)
        End If
        PrecioTextBox.Text = Cu_Precio
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Curso = 0) Then
            Me.CursosTableAdapter.RCurso(NombreTextBox.Text, FechaDateTimePicker.Value, PrecioTextBox.Text, HoraFDateTimePicker.Value.ToString("t"), HoraIDateTimePicker.Value.ToString("t"))
            MsgBox("El curso se ha registrado")
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Else
            Me.CursosTableAdapter.UCurso(NombreTextBox.Text, FechaDateTimePicker.Value, PrecioTextBox.Text, HoraFDateTimePicker.Value.ToString("t"), HoraIDateTimePicker.Value.ToString("t"), Id_Curso)
            MsgBox("El curso se ha actualizado")
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        End If
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        MenuCursos.Show()
        Me.Close()
    End Sub
End Class