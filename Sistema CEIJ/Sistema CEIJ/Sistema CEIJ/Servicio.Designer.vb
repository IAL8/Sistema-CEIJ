<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Servicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicio))
        Me.ClienteLabel = New System.Windows.Forms.Label()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.RegistrarBTN = New System.Windows.Forms.Button()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DisponibilidadCheclbox = New System.Windows.Forms.CheckBox()
        Me.BD_Sistema_CEIJDataSet = New Sistema_CEIJ.BD_Sistema_CEIJDataSet()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.ServiciosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ServiciosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CorreoLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiciosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.Transparent
        CorreoLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        CorreoLabel.Location = New System.Drawing.Point(575, 447)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(216, 32)
        CorreoLabel.TabIndex = 52
        CorreoLabel.Text = "Disponibilidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.BackColor = System.Drawing.Color.Transparent
        PrecioLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.ForeColor = System.Drawing.Color.DarkKhaki
        PrecioLabel.Location = New System.Drawing.Point(575, 365)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(108, 32)
        PrecioLabel.TabIndex = 51
        PrecioLabel.Text = "Precio:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.BackColor = System.Drawing.Color.Transparent
        CategoriaLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.ForeColor = System.Drawing.Color.DarkKhaki
        CategoriaLabel.Location = New System.Drawing.Point(575, 288)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(151, 32)
        CategoriaLabel.TabIndex = 48
        CategoriaLabel.Text = "Categoria:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.DarkKhaki
        NombreLabel.Location = New System.Drawing.Point(575, 214)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(130, 32)
        NombreLabel.TabIndex = 47
        NombreLabel.Text = "Nombre:"
        '
        'ClienteLabel
        '
        Me.ClienteLabel.AutoSize = True
        Me.ClienteLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClienteLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ClienteLabel.Location = New System.Drawing.Point(648, 99)
        Me.ClienteLabel.Name = "ClienteLabel"
        Me.ClienteLabel.Size = New System.Drawing.Size(211, 55)
        Me.ClienteLabel.TabIndex = 53
        Me.ClienteLabel.Text = "Servicio"
        '
        'CancelarBTN
        '
        Me.CancelarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CancelarBTN.Location = New System.Drawing.Point(798, 569)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(136, 56)
        Me.CancelarBTN.TabIndex = 50
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = False
        '
        'RegistrarBTN
        '
        Me.RegistrarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RegistrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistrarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.RegistrarBTN.Location = New System.Drawing.Point(590, 569)
        Me.RegistrarBTN.Name = "RegistrarBTN"
        Me.RegistrarBTN.Size = New System.Drawing.Size(136, 56)
        Me.RegistrarBTN.TabIndex = 49
        Me.RegistrarBTN.Text = "Guardar"
        Me.RegistrarBTN.UseVisualStyleBackColor = False
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(689, 365)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(216, 29)
        Me.PrecioTextBox.TabIndex = 45
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(703, 276)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(202, 29)
        Me.CategoriaTextBox.TabIndex = 44
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(703, 208)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(202, 29)
        Me.NombreTextBox.TabIndex = 43
        '
        'DisponibilidadCheclbox
        '
        Me.DisponibilidadCheclbox.AutoSize = True
        Me.DisponibilidadCheclbox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisponibilidadCheclbox.Location = New System.Drawing.Point(814, 460)
        Me.DisponibilidadCheclbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DisponibilidadCheclbox.Name = "DisponibilidadCheclbox"
        Me.DisponibilidadCheclbox.Size = New System.Drawing.Size(15, 14)
        Me.DisponibilidadCheclbox.TabIndex = 54
        Me.DisponibilidadCheclbox.UseVisualStyleBackColor = True
        '
        'BD_Sistema_CEIJDataSet
        '
        Me.BD_Sistema_CEIJDataSet.DataSetName = "BD_Sistema_CEIJDataSet"
        Me.BD_Sistema_CEIJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ServiciosBindingNavigator
        '
        Me.ServiciosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ServiciosBindingNavigator.BindingSource = Me.ServiciosBindingSource
        Me.ServiciosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServiciosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ServiciosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ServiciosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ServiciosBindingNavigatorSaveItem})
        Me.ServiciosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServiciosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServiciosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServiciosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServiciosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServiciosBindingNavigator.Name = "ServiciosBindingNavigator"
        Me.ServiciosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServiciosBindingNavigator.Size = New System.Drawing.Size(326, 22)
        Me.ServiciosBindingNavigator.TabIndex = 55
        Me.ServiciosBindingNavigator.Text = "BindingNavigator1"
        Me.ServiciosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 19)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'ServiciosBindingNavigatorSaveItem
        '
        Me.ServiciosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServiciosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServiciosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServiciosBindingNavigatorSaveItem.Name = "ServiciosBindingNavigatorSaveItem"
        Me.ServiciosBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.ServiciosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.FondoSign
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 839)
        Me.Controls.Add(Me.ServiciosBindingNavigator)
        Me.Controls.Add(Me.DisponibilidadCheclbox)
        Me.Controls.Add(Me.ClienteLabel)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.RegistrarBTN)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Servicio"
        Me.Text = "Servicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiciosBindingNavigator.ResumeLayout(False)
        Me.ServiciosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClienteLabel As Label
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents RegistrarBTN As Button
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DisponibilidadCheclbox As CheckBox
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServiciosBindingNavigator As BindingNavigator
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
    Friend WithEvents ServiciosBindingNavigatorSaveItem As ToolStripButton
End Class
