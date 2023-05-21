<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAgenda))
        Me.EditarBTN = New System.Windows.Forms.Button()
        Me.EliminarBTN = New System.Windows.Forms.Button()
        Me.NuevoBTN = New System.Windows.Forms.Button()
        Me.ServiciosLabel = New System.Windows.Forms.Label()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.AgendaDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AgendaDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Sistema_CEIJDataSet = New Sistema_CEIJ.BD_Sistema_CEIJDataSet()
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
        Me.AgendaDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AgendaDataTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Se_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Ser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ci_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ci_Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ci_Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgendaDataTableTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.AgendaDataTableTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.CitasTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendaDataTableBindingNavigator.SuspendLayout()
        CType(Me.AgendaDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDataTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditarBTN
        '
        Me.EditarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EditarBTN.Location = New System.Drawing.Point(600, 574)
        Me.EditarBTN.Name = "EditarBTN"
        Me.EditarBTN.Size = New System.Drawing.Size(136, 55)
        Me.EditarBTN.TabIndex = 35
        Me.EditarBTN.Text = "Editar"
        Me.EditarBTN.UseVisualStyleBackColor = False
        '
        'EliminarBTN
        '
        Me.EliminarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EliminarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EliminarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EliminarBTN.Location = New System.Drawing.Point(319, 574)
        Me.EliminarBTN.Name = "EliminarBTN"
        Me.EliminarBTN.Size = New System.Drawing.Size(136, 55)
        Me.EliminarBTN.TabIndex = 34
        Me.EliminarBTN.Text = "Eliminar"
        Me.EliminarBTN.UseVisualStyleBackColor = False
        '
        'NuevoBTN
        '
        Me.NuevoBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NuevoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.NuevoBTN.Location = New System.Drawing.Point(878, 574)
        Me.NuevoBTN.Name = "NuevoBTN"
        Me.NuevoBTN.Size = New System.Drawing.Size(136, 55)
        Me.NuevoBTN.TabIndex = 33
        Me.NuevoBTN.Text = "Nuevo"
        Me.NuevoBTN.UseVisualStyleBackColor = False
        '
        'ServiciosLabel
        '
        Me.ServiciosLabel.AutoSize = True
        Me.ServiciosLabel.BackColor = System.Drawing.Color.Transparent
        Me.ServiciosLabel.Font = New System.Drawing.Font("Arial", 54.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiciosLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ServiciosLabel.Location = New System.Drawing.Point(560, 110)
        Me.ServiciosLabel.Name = "ServiciosLabel"
        Me.ServiciosLabel.Size = New System.Drawing.Size(214, 83)
        Me.ServiciosLabel.TabIndex = 32
        Me.ServiciosLabel.Text = "Citas"
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(1220, 561)
        Me.SalirPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(74, 80)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 36
        Me.SalirPictureBox.TabStop = False
        '
        'AgendaDataTableBindingNavigator
        '
        Me.AgendaDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AgendaDataTableBindingNavigator.BindingSource = Me.AgendaDataTableBindingSource
        Me.AgendaDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AgendaDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AgendaDataTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AgendaDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AgendaDataTableBindingNavigatorSaveItem})
        Me.AgendaDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AgendaDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AgendaDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AgendaDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AgendaDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AgendaDataTableBindingNavigator.Name = "AgendaDataTableBindingNavigator"
        Me.AgendaDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AgendaDataTableBindingNavigator.Size = New System.Drawing.Size(721, 22)
        Me.AgendaDataTableBindingNavigator.TabIndex = 37
        Me.AgendaDataTableBindingNavigator.Text = "BindingNavigator1"
        Me.AgendaDataTableBindingNavigator.Visible = False
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
        'AgendaDataTableBindingSource
        '
        Me.AgendaDataTableBindingSource.DataMember = "AgendaDataTable"
        Me.AgendaDataTableBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'BD_Sistema_CEIJDataSet
        '
        Me.BD_Sistema_CEIJDataSet.DataSetName = "BD_Sistema_CEIJDataSet"
        Me.BD_Sistema_CEIJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'AgendaDataTableBindingNavigatorSaveItem
        '
        Me.AgendaDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AgendaDataTableBindingNavigatorSaveItem.Enabled = False
        Me.AgendaDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AgendaDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AgendaDataTableBindingNavigatorSaveItem.Name = "AgendaDataTableBindingNavigatorSaveItem"
        Me.AgendaDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.AgendaDataTableBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'AgendaDataTableDataGridView
        '
        Me.AgendaDataTableDataGridView.AllowUserToAddRows = False
        Me.AgendaDataTableDataGridView.AllowUserToDeleteRows = False
        Me.AgendaDataTableDataGridView.AutoGenerateColumns = False
        Me.AgendaDataTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AgendaDataTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgendaDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgendaDataTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.C_ID, Me.Nombre, Me.Se_ID, Me.Nom_Ser, Me.Ci_Fecha, Me.Ci_Hora, Me.Ci_Precio})
        Me.AgendaDataTableDataGridView.DataSource = Me.AgendaDataTableBindingSource
        Me.AgendaDataTableDataGridView.Location = New System.Drawing.Point(184, 263)
        Me.AgendaDataTableDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.AgendaDataTableDataGridView.Name = "AgendaDataTableDataGridView"
        Me.AgendaDataTableDataGridView.ReadOnly = True
        Me.AgendaDataTableDataGridView.RowHeadersWidth = 51
        Me.AgendaDataTableDataGridView.RowTemplate.Height = 24
        Me.AgendaDataTableDataGridView.Size = New System.Drawing.Size(959, 283)
        Me.AgendaDataTableDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_S"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Solicitud"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'C_ID
        '
        Me.C_ID.DataPropertyName = "C_ID"
        Me.C_ID.HeaderText = "C_ID"
        Me.C_ID.MinimumWidth = 6
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Se_ID
        '
        Me.Se_ID.DataPropertyName = "Se_ID"
        Me.Se_ID.HeaderText = "Se_ID"
        Me.Se_ID.MinimumWidth = 6
        Me.Se_ID.Name = "Se_ID"
        Me.Se_ID.ReadOnly = True
        Me.Se_ID.Visible = False
        '
        'Nom_Ser
        '
        Me.Nom_Ser.DataPropertyName = "Nom_Ser"
        Me.Nom_Ser.HeaderText = "Servicio"
        Me.Nom_Ser.MinimumWidth = 6
        Me.Nom_Ser.Name = "Nom_Ser"
        Me.Nom_Ser.ReadOnly = True
        '
        'Ci_Fecha
        '
        Me.Ci_Fecha.DataPropertyName = "Ci_Fecha"
        Me.Ci_Fecha.HeaderText = "Fecha"
        Me.Ci_Fecha.MinimumWidth = 6
        Me.Ci_Fecha.Name = "Ci_Fecha"
        Me.Ci_Fecha.ReadOnly = True
        '
        'Ci_Hora
        '
        Me.Ci_Hora.DataPropertyName = "Ci_Hora"
        Me.Ci_Hora.HeaderText = "Hora"
        Me.Ci_Hora.MinimumWidth = 6
        Me.Ci_Hora.Name = "Ci_Hora"
        Me.Ci_Hora.ReadOnly = True
        '
        'Ci_Precio
        '
        Me.Ci_Precio.DataPropertyName = "Ci_Precio"
        Me.Ci_Precio.HeaderText = "Precio"
        Me.Ci_Precio.MinimumWidth = 6
        Me.Ci_Precio.Name = "Ci_Precio"
        Me.Ci_Precio.ReadOnly = True
        '
        'AgendaDataTableTableAdapter
        '
        Me.AgendaDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'MenuAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.AgendaDataTableDataGridView)
        Me.Controls.Add(Me.AgendaDataTableBindingNavigator)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.EditarBTN)
        Me.Controls.Add(Me.EliminarBTN)
        Me.Controls.Add(Me.NuevoBTN)
        Me.Controls.Add(Me.ServiciosLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAgenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendaDataTableBindingNavigator.ResumeLayout(False)
        Me.AgendaDataTableBindingNavigator.PerformLayout()
        CType(Me.AgendaDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDataTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents EditarBTN As Button
    Friend WithEvents EliminarBTN As Button
    Friend WithEvents NuevoBTN As Button
    Friend WithEvents ServiciosLabel As Label
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents AgendaDataTableBindingSource As BindingSource
    Friend WithEvents AgendaDataTableTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.AgendaDataTableTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AgendaDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents AgendaDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AgendaDataTableDataGridView As DataGridView
    Friend WithEvents CitasTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Se_ID As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Ser As DataGridViewTextBoxColumn
    Friend WithEvents Ci_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Ci_Hora As DataGridViewTextBoxColumn
    Friend WithEvents Ci_Precio As DataGridViewTextBoxColumn
End Class
