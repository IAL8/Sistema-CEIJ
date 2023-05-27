<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuServicios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EditarBTN = New System.Windows.Forms.Button()
        Me.EliminarBTN = New System.Windows.Forms.Button()
        Me.NuevoBTN = New System.Windows.Forms.Button()
        Me.ServiciosLabel = New System.Windows.Forms.Label()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.ServiciosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ServiciosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ServiciosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.FillByAllToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiciosBindingNavigator.SuspendLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByAllToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditarBTN
        '
        Me.EditarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EditarBTN.Location = New System.Drawing.Point(944, 758)
        Me.EditarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EditarBTN.Name = "EditarBTN"
        Me.EditarBTN.Size = New System.Drawing.Size(181, 69)
        Me.EditarBTN.TabIndex = 30
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
        Me.EliminarBTN.Location = New System.Drawing.Point(664, 758)
        Me.EliminarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EliminarBTN.Name = "EliminarBTN"
        Me.EliminarBTN.Size = New System.Drawing.Size(181, 69)
        Me.EliminarBTN.TabIndex = 29
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
        Me.NuevoBTN.Location = New System.Drawing.Point(1223, 758)
        Me.NuevoBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.NuevoBTN.Name = "NuevoBTN"
        Me.NuevoBTN.Size = New System.Drawing.Size(181, 69)
        Me.NuevoBTN.TabIndex = 28
        Me.NuevoBTN.Text = "Nuevo"
        Me.NuevoBTN.UseVisualStyleBackColor = False
        '
        'ServiciosLabel
        '
        Me.ServiciosLabel.AutoSize = True
        Me.ServiciosLabel.BackColor = System.Drawing.Color.Transparent
        Me.ServiciosLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiciosLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ServiciosLabel.Location = New System.Drawing.Point(864, 122)
        Me.ServiciosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ServiciosLabel.Name = "ServiciosLabel"
        Me.ServiciosLabel.Size = New System.Drawing.Size(295, 68)
        Me.ServiciosLabel.TabIndex = 26
        Me.ServiciosLabel.Text = "Servicios"
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(1652, 729)
        Me.SalirPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(99, 98)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 31
        Me.SalirPictureBox.TabStop = False
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
        Me.ServiciosBindingNavigator.Size = New System.Drawing.Size(1053, 27)
        Me.ServiciosBindingNavigator.TabIndex = 32
        Me.ServiciosBindingNavigator.Text = "BindingNavigator1"
        Me.ServiciosBindingNavigator.Visible = False
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
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'BD_Sistema_CEIJDataSet
        '
        Me.BD_Sistema_CEIJDataSet.DataSetName = "BD_Sistema_CEIJDataSet"
        Me.BD_Sistema_CEIJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
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
        'ServiciosBindingNavigatorSaveItem
        '
        Me.ServiciosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServiciosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServiciosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServiciosBindingNavigatorSaveItem.Name = "ServiciosBindingNavigatorSaveItem"
        Me.ServiciosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ServiciosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1053, 27)
        Me.FillToolStrip.TabIndex = 33
        Me.FillToolStrip.Text = "FillToolStrip"
        Me.FillToolStrip.Visible = False
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(32, 24)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ServiciosDataGridView
        '
        Me.ServiciosDataGridView.AllowUserToAddRows = False
        Me.ServiciosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        Me.ServiciosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ServiciosDataGridView.AutoGenerateColumns = False
        Me.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiciosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiciosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1})
        Me.ServiciosDataGridView.DataSource = Me.ServiciosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiciosDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ServiciosDataGridView.Location = New System.Drawing.Point(128, 329)
        Me.ServiciosDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ServiciosDataGridView.Name = "ServiciosDataGridView"
        Me.ServiciosDataGridView.ReadOnly = True
        Me.ServiciosDataGridView.RowHeadersWidth = 51
        Me.ServiciosDataGridView.RowTemplate.Height = 24
        Me.ServiciosDataGridView.Size = New System.Drawing.Size(1590, 320)
        Me.ServiciosDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Servicio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nom_Ser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Categoria_Ser"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Precio_Ser"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Disp_Ser"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Disponibilidad"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
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
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FillByAllToolStrip
        '
        Me.FillByAllToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByAllToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByAllToolStripButton})
        Me.FillByAllToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByAllToolStrip.Name = "FillByAllToolStrip"
        Me.FillByAllToolStrip.Size = New System.Drawing.Size(1827, 27)
        Me.FillByAllToolStrip.TabIndex = 34
        Me.FillByAllToolStrip.Text = "FillByAllToolStrip"
        Me.FillByAllToolStrip.Visible = False
        '
        'FillByAllToolStripButton
        '
        Me.FillByAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByAllToolStripButton.Name = "FillByAllToolStripButton"
        Me.FillByAllToolStripButton.Size = New System.Drawing.Size(66, 24)
        Me.FillByAllToolStripButton.Text = "FillByAll"
        '
        'MenuServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.FillByAllToolStrip)
        Me.Controls.Add(Me.ServiciosDataGridView)
        Me.Controls.Add(Me.ServiciosBindingNavigator)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.EditarBTN)
        Me.Controls.Add(Me.EliminarBTN)
        Me.Controls.Add(Me.NuevoBTN)
        Me.Controls.Add(Me.ServiciosLabel)
        Me.Location = New System.Drawing.Point(1340, 695)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MenuServicios"
        Me.Text = "MenuServicios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiciosBindingNavigator.ResumeLayout(False)
        Me.ServiciosBindingNavigator.PerformLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByAllToolStrip.ResumeLayout(False)
        Me.FillByAllToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents EditarBTN As Button
    Friend WithEvents EliminarBTN As Button
    Friend WithEvents NuevoBTN As Button
    Friend WithEvents ServiciosLabel As Label
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
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ServiciosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents FillByAllToolStrip As ToolStrip
    Friend WithEvents FillByAllToolStripButton As ToolStripButton
End Class
