<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuInventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EditarBTN = New System.Windows.Forms.Button()
        Me.EliminarBTN = New System.Windows.Forms.Button()
        Me.NuevoBTN = New System.Windows.Forms.Button()
        Me.CursosLabel = New System.Windows.Forms.Label()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.InventarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.InventarioTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditarBTN
        '
        Me.EditarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EditarBTN.Location = New System.Drawing.Point(896, 724)
        Me.EditarBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EditarBTN.Name = "EditarBTN"
        Me.EditarBTN.Size = New System.Drawing.Size(201, 76)
        Me.EditarBTN.TabIndex = 38
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
        Me.EliminarBTN.Location = New System.Drawing.Point(605, 724)
        Me.EliminarBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EliminarBTN.Name = "EliminarBTN"
        Me.EliminarBTN.Size = New System.Drawing.Size(201, 76)
        Me.EliminarBTN.TabIndex = 37
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
        Me.NuevoBTN.Location = New System.Drawing.Point(1203, 724)
        Me.NuevoBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NuevoBTN.Name = "NuevoBTN"
        Me.NuevoBTN.Size = New System.Drawing.Size(201, 76)
        Me.NuevoBTN.TabIndex = 36
        Me.NuevoBTN.Text = "Nuevo"
        Me.NuevoBTN.UseVisualStyleBackColor = False
        '
        'CursosLabel
        '
        Me.CursosLabel.AutoSize = True
        Me.CursosLabel.BackColor = System.Drawing.Color.Transparent
        Me.CursosLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursosLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CursosLabel.Location = New System.Drawing.Point(864, 122)
        Me.CursosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CursosLabel.Name = "CursosLabel"
        Me.CursosLabel.Size = New System.Drawing.Size(315, 68)
        Me.CursosLabel.TabIndex = 35
        Me.CursosLabel.Text = "Inventario"
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventarioBindingNavigator.BindingSource = Me.InventarioBindingSource
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventarioBindingNavigatorSaveItem})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(965, 27)
        Me.InventarioBindingNavigator.TabIndex = 40
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        Me.InventarioBindingNavigator.Visible = False
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
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
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
        'InventarioBindingNavigatorSaveItem
        '
        Me.InventarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventarioBindingNavigatorSaveItem.Name = "InventarioBindingNavigatorSaveItem"
        Me.InventarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.InventarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AllowUserToAddRows = False
        Me.InventarioDataGridView.AllowUserToDeleteRows = False
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InventarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventarioDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InventarioDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.InventarioDataGridView.Location = New System.Drawing.Point(110, 260)
        Me.InventarioDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.ReadOnly = True
        Me.InventarioDataGridView.RowHeadersWidth = 51
        Me.InventarioDataGridView.RowTemplate.Height = 24
        Me.InventarioDataGridView.Size = New System.Drawing.Size(1591, 361)
        Me.InventarioDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(993, 27)
        Me.FillToolStrip.TabIndex = 41
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
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(1589, 702)
        Me.SalirPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(99, 98)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 39
        Me.SalirPictureBox.TabStop = False
        '
        'MenuInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InventarioDataGridView)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.EditarBTN)
        Me.Controls.Add(Me.EliminarBTN)
        Me.Controls.Add(Me.NuevoBTN)
        Me.Controls.Add(Me.CursosLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MenuInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuInventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents EditarBTN As Button
    Friend WithEvents EliminarBTN As Button
    Friend WithEvents NuevoBTN As Button
    Friend WithEvents CursosLabel As Label
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventarioBindingNavigator As BindingNavigator
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
    Friend WithEvents InventarioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InventarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents FillToolStripButton As ToolStripButton
End Class
