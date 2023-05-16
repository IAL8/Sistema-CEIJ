Imports System.Diagnostics.Eventing.Reader

Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cuentas)

    End Sub

    Private Sub SignUp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogIn.Show()
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        Me.Close()
    End Sub

    Private Sub RegistrarBTN_Click(sender As Object, e As EventArgs) Handles RegistrarBTN.Click
        Dim Read As Boolean
        Dim User As String
        Nulo = ""
        Read = UsuarioTextBox.Text IsNot Nulo AndAlso NombreTextBox.Text IsNot Nulo AndAlso ApellidoTextBox.Text IsNot Nulo AndAlso CorreoTextBox.Text IsNot Nulo AndAlso PasswordTextBox.Text IsNot Nulo AndAlso TelefonoTextBox.Text IsNot Nulo
        If UsuarioTextBox.Text IsNot Nulo Then
            User = Me.CuentasTableAdapter.BUser(UsuarioTextBox.Text)
            If StrComp(Nulo, User, vbBinaryCompare) = 0 Then
                If PasswordTextBox.Text IsNot Nulo Then
                    If Read Then
                        Registro()
                    Else
                        MsgBox("Toodos los recaudros son obligatorios")
                    End If
                Else
                    MsgBox("Debe ingresar una contraseña")
                End If
            Else
                MsgBox("El nombre de usuario ya esta registrado, escriba otro.")
            End If
        Else
            MsgBox("Debe ingresar un nombre de usuario.")
        End If
    End Sub

    Private Sub Registro()
        Me.CuentasTableAdapter.RUser(NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, UsuarioTextBox.Text, PasswordTextBox.Text)
        Me.CuentasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cuentas)
        MsgBox("La cuenta se ha registrado")
    End Sub
    Private Sub CuentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CuentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub
End Class