Public Class Alumnos

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Inscripciones' Puede moverla o quitarla según sea necesario.
        Me.InscripcionesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inscripciones)
        Me.AlumnosDataTableTableAdapter.FillAlumnos(Me.BD_Sistema_CEIJDataSet.AlumnosDataTable, CType(Curso, Integer))
        CursosLabel.Text = Cu_Nombre
    End Sub


    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub Alumnos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuCursos.Show()
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        Me.InscripcionesTableAdapter.DInscripcion(Id_Solicitud, Curso)
        Me.InscripcionesTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Inscripciones)
        MsgBox("El alumno se ha eliminado")
        Me.AlumnosDataTableTableAdapter.FillAlumnos(Me.BD_Sistema_CEIJDataSet.AlumnosDataTable, CType(Curso, Integer))
    End Sub

    Private Sub AlumnosDataTableDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AlumnosDataTableDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Solicitud = AlumnosDataTableDataGridView.Item(0, e.RowIndex).Value
        End If
    End Sub
End Class