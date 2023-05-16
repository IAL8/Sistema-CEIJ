Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LogIn
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Sistema_CEIJDataSet.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BD_Sistema_CEIJDataSet.Cuentas)

    End Sub
    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Dim UserD, UserP, PswD, PswP As String
        Dim P As Integer
        Nulo = ""
        If UsuarioTextBox.Text IsNot Nulo And PasswordTextBox.Text IsNot Nulo Then
            UserD = Me.CuentasTableAdapter.BUser(UsuarioTextBox.Text)
            UserP = UsuarioTextBox.Text
            P = StrComp(UserP, UserD, vbBinaryCompare)
            If P = 0 Then
                PswD = Me.CuentasTableAdapter.BPSW(UserP, PasswordTextBox.Text)
                PswP = PasswordTextBox.Text
                P = StrComp(PswP, PswD, vbBinaryCompare)
                If P = 0 Then
                    UsuarioActual = UserD
                    MainMenu.Show()
                    Me.Hide()
                Else
                    MsgBox("La contraseña es incorrecta")
                End If
            Else
                MsgBox("El usuario no esta registrado o lo ha escrito incorrectamente, asegure de escribir correctamente su nombre usario.")
            End If
        Else
            MsgBox("Debe llenar todos los espacios")
        End If
    End Sub

    Private Sub CuentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CuentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CuentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_Sistema_CEIJDataSet)

    End Sub

    Private Sub RegustrarBTN_Click(sender As Object, e As EventArgs) Handles RegustrarBTN.Click
        SignUp.Show()
        Me.Hide()
    End Sub
End Class
