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


    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        If (Id_Curso = 0) Then
            Me.CursosTableAdapter.RCurso(NombreTextBox.Text, FechaDateTimePicker.Value, HoraIDateTimePicker.Value.ToShortTimeString, HoraFDateTimePicker.Value.ToShortTimeString, PrecioTextBox.Text)
            MsgBox("El curso se ha registrado")
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Else
            Me.CursosTableAdapter.UCurso(NombreTextBox.Text, FechaDateTimePicker.Value, HoraIDateTimePicker.Value.ToShortTimeString, HoraFDateTimePicker.Value.ToShortTimeString, PrecioTextBox.Text, Id_Curso)
            MsgBox("El curso se ha actualizado")
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        End If
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        Me.Close()
    End Sub

    Private Sub Cursos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuCursos.Show()
    End Sub
End Class