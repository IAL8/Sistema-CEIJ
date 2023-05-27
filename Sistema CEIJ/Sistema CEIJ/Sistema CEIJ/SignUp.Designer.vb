<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.RegistrarBTN = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.BD_Sistema_CEIJDataSet = New Sistema_CEIJ.BD_Sistema_CEIJDataSet()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CuentasTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.CuentasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuentasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Registrate = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuentasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        PasswordLabel.ForeColor = System.Drawing.Color.DarkKhaki
        PasswordLabel.Location = New System.Drawing.Point(361, 243)
        PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(125, 22)
        PasswordLabel.TabIndex = 24
        PasswordLabel.Text = "Contraseña:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        UsuarioLabel.ForeColor = System.Drawing.Color.DarkKhaki
        UsuarioLabel.Location = New System.Drawing.Point(381, 184)
        UsuarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(89, 22)
        UsuarioLabel.TabIndex = 22
        UsuarioLabel.Text = "Usuario:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.Transparent
        CorreoLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        CorreoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        CorreoLabel.Location = New System.Drawing.Point(388, 134)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(82, 22)
        CorreoLabel.TabIndex = 20
        CorreoLabel.Text = "Correo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        TelefonoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        TelefonoLabel.Location = New System.Drawing.Point(37, 242)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(98, 22)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Teléfono:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.BackColor = System.Drawing.Color.Transparent
        ApellidoLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        ApellidoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        ApellidoLabel.Location = New System.Drawing.Point(43, 186)
        ApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(92, 22)
        ApellidoLabel.TabIndex = 14
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.ForeColor = System.Drawing.Color.DarkKhaki
        NombreLabel.Location = New System.Drawing.Point(45, 134)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(90, 22)
        NombreLabel.TabIndex = 12
        NombreLabel.Text = "Nombre:"
        '
        'CancelarBTN
        '
        Me.CancelarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBTN.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CancelarBTN.Location = New System.Drawing.Point(452, 326)
        Me.CancelarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(137, 44)
        Me.CancelarBTN.TabIndex = 17
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = False
        '
        'RegistrarBTN
        '
        Me.RegistrarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RegistrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistrarBTN.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RegistrarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.RegistrarBTN.Location = New System.Drawing.Point(175, 326)
        Me.RegistrarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.RegistrarBTN.Name = "RegistrarBTN"
        Me.RegistrarBTN.Size = New System.Drawing.Size(137, 44)
        Me.RegistrarBTN.TabIndex = 15
        Me.RegistrarBTN.Text = "Registrar"
        Me.RegistrarBTN.UseVisualStyleBackColor = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(501, 242)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(191, 34)
        Me.PasswordTextBox.TabIndex = 6
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(501, 184)
        Me.UsuarioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(191, 34)
        Me.UsuarioTextBox.TabIndex = 5
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(501, 132)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(191, 34)
        Me.CorreoTextBox.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(152, 235)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(151, 34)
        Me.TelefonoTextBox.TabIndex = 3
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(152, 179)
        Me.ApellidoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(151, 34)
        Me.ApellidoTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(152, 127)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(151, 34)
        Me.NombreTextBox.TabIndex = 1
        '
        'BD_Sistema_CEIJDataSet
        '
        Me.BD_Sistema_CEIJDataSet.DataSetName = "BD_Sistema_CEIJDataSet"
        Me.BD_Sistema_CEIJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Me.CuentasTableAdapter
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuentasBindingNavigator
        '
        Me.CuentasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CuentasBindingNavigator.BindingSource = Me.CuentasBindingSource
        Me.CuentasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CuentasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CuentasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CuentasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CuentasBindingNavigatorSaveItem})
        Me.CuentasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CuentasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CuentasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CuentasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CuentasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CuentasBindingNavigator.Name = "CuentasBindingNavigator"
        Me.CuentasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CuentasBindingNavigator.Size = New System.Drawing.Size(833, 27)
        Me.CuentasBindingNavigator.TabIndex = 26
        Me.CuentasBindingNavigator.Text = "BindingNavigator1"
        Me.CuentasBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CuentasBindingNavigatorSaveItem
        '
        Me.CuentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CuentasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CuentasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CuentasBindingNavigatorSaveItem.Name = "CuentasBindingNavigatorSaveItem"
        Me.CuentasBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CuentasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Registrate
        '
        Me.Registrate.AutoSize = True
        Me.Registrate.BackColor = System.Drawing.Color.Transparent
        Me.Registrate.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrate.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Registrate.Location = New System.Drawing.Point(225, 9)
        Me.Registrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Registrate.Name = "Registrate"
        Me.Registrate.Size = New System.Drawing.Size(357, 68)
        Me.Registrate.TabIndex = 27
        Me.Registrate.Text = "Registrarse"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.FondoSign
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 419)
        Me.Controls.Add(Me.Registrate)
        Me.Controls.Add(Me.CuentasBindingNavigator)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.RegistrarBTN)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuentasBindingNavigator.ResumeLayout(False)
        Me.CuentasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelarBTN As Button
    Friend WithEvents RegistrarBTN As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CuentasTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuentasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CuentasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Registrate As Label
End Class
