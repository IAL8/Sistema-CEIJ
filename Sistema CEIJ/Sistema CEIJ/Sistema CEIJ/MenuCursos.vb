Public Class MenuCursos
    Private Sub CursosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub MenuCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Cu_Fecha = Nothing
    End Sub

    Private Sub EliminarBTN_Click(sender As Object, e As EventArgs) Handles EliminarBTN.Click
        Me.CursosTableAdapter.DCurso(Id_Curso)
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        MsgBox("El curso se ha eliminado")
    End Sub

    Private Sub MenuCursos_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Cu_Fecha = Nothing
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NuevoBTN_Click(sender As Object, e As EventArgs) Handles NuevoBTN.Click
        Id_Curso = 0
        Cu_Nombre = Nulo
        Cu_Fecha = Date.Today
        Cu_HoraI = Nulo
        Cu_HoraF = Nulo
        Cu_Precio = 0
        Cursos.Show()
        Me.Hide()
    End Sub

    Private Sub CursosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CursosDataGridView.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Id_Curso = CursosDataGridView.Item(0, e.RowIndex).Value
            Cu_Nombre = CursosDataGridView.Item(1, e.RowIndex).Value
            Cu_Fecha = CursosDataGridView.Item(2, e.RowIndex).Value
            Cu_HoraI = CursosDataGridView.Item(3, e.RowIndex).Value
            Cu_HoraF = CursosDataGridView.Item(4, e.RowIndex).Value
            Cu_Precio = CursosDataGridView.Item(5, e.RowIndex).Value
        End If
    End Sub

    Private Sub EditarBTN_Click(sender As Object, e As EventArgs) Handles EditarBTN.Click
        Cursos.Show()
        Me.Hide()
    End Sub

    Private Sub SalirPictureBox_Click(sender As Object, e As EventArgs) Handles SalirPictureBox.Click
        Me.Close()
    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillToolStripButton1.Click
        Try
            Me.CursosTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cursos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AlumnosBTN_Click(sender As Object, e As EventArgs) Handles AlumnosBTN.Click
        If (Id_Curso <> 0) Then
            Alumnos.Show()
            Me.Hide()
        Else
            MsgBox("Debe seleccionar algun elemento para acceder a esta función")
        End If
    End Sub

    Private Sub MenuCursos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub
End Class