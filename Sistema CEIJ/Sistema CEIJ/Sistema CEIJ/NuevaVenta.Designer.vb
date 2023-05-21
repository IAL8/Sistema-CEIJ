<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaVenta))
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.VLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AgregarComboBox = New System.Windows.Forms.ComboBox()
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
        Me.ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Ser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteLabel = New System.Windows.Forms.Label()
        Me.SClienteBTN = New System.Windows.Forms.Button()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CarritoLabel = New System.Windows.Forms.Label()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.EliminarBTN = New System.Windows.Forms.Button()
        Me.RegistrarBTN = New System.Windows.Forms.Button()
        Me.ConfirmarBTN = New System.Windows.Forms.Button()
        Me.AgendaDataTableTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.AgendaDataTableTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.SolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolicitudesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.SolicitudesTableAdapter()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitasTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter()
        Me.ServiciosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter()
        Me.CursosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CursosTableAdapter()
        Me.ClientesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ClientesTableAdapter()
        Me.InscripcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InscripcionesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.InscripcionesTableAdapter()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendaDataTableBindingNavigator.SuspendLayout()
        CType(Me.AgendaDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InscripcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(1060, 548)
        Me.SalirPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(74, 80)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 41
        Me.SalirPictureBox.TabStop = False
        '
        'VLabel
        '
        Me.VLabel.AutoSize = True
        Me.VLabel.BackColor = System.Drawing.Color.Transparent
        Me.VLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.VLabel.Location = New System.Drawing.Point(495, 151)
        Me.VLabel.Name = "VLabel"
        Me.VLabel.Size = New System.Drawing.Size(311, 55)
        Me.VLabel.TabIndex = 40
        Me.VLabel.Text = "Nueva Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Location = New System.Drawing.Point(291, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Agregar:"
        '
        'AgregarComboBox
        '
        Me.AgregarComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarComboBox.FormattingEnabled = True
        Me.AgregarComboBox.Location = New System.Drawing.Point(388, 253)
        Me.AgregarComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AgregarComboBox.Name = "AgregarComboBox"
        Me.AgregarComboBox.Size = New System.Drawing.Size(112, 26)
        Me.AgregarComboBox.TabIndex = 43
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
        Me.AgendaDataTableBindingNavigator.Size = New System.Drawing.Size(778, 22)
        Me.AgendaDataTableBindingNavigator.TabIndex = 45
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
        'ServiciosDataGridView
        '
        Me.ServiciosDataGridView.AllowUserToAddRows = False
        Me.ServiciosDataGridView.AllowUserToDeleteRows = False
        Me.ServiciosDataGridView.AutoGenerateColumns = False
        Me.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiciosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Precio_Ser})
        Me.ServiciosDataGridView.DataSource = Me.ServiciosBindingSource
        Me.ServiciosDataGridView.Location = New System.Drawing.Point(275, 304)
        Me.ServiciosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ServiciosDataGridView.Name = "ServiciosDataGridView"
        Me.ServiciosDataGridView.ReadOnly = True
        Me.ServiciosDataGridView.RowHeadersWidth = 51
        Me.ServiciosDataGridView.RowTemplate.Height = 24
        Me.ServiciosDataGridView.Size = New System.Drawing.Size(734, 54)
        Me.ServiciosDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Id_Servicio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nom_Ser"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Precio_Ser
        '
        Me.Precio_Ser.DataPropertyName = "Precio_Ser"
        Me.Precio_Ser.HeaderText = "Precio"
        Me.Precio_Ser.MinimumWidth = 6
        Me.Precio_Ser.Name = "Precio_Ser"
        Me.Precio_Ser.ReadOnly = True
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'CursosDataGridView
        '
        Me.CursosDataGridView.AllowUserToAddRows = False
        Me.CursosDataGridView.AllowUserToDeleteRows = False
        Me.CursosDataGridView.AutoGenerateColumns = False
        Me.CursosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CursosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.CursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CursosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CursosDataGridView.DataSource = Me.CursosBindingSource
        Me.CursosDataGridView.Location = New System.Drawing.Point(275, 304)
        Me.CursosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CursosDataGridView.Name = "CursosDataGridView"
        Me.CursosDataGridView.ReadOnly = True
        Me.CursosDataGridView.RowHeadersWidth = 51
        Me.CursosDataGridView.RowTemplate.Height = 24
        Me.CursosDataGridView.Size = New System.Drawing.Size(734, 54)
        Me.CursosDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Id_Curso"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Nombre_Cur"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Fecha_Cur"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "HoraI_Cur"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Inicio"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "HoraF_Cur"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fin"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Costo_Cur"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'ClienteLabel
        '
        Me.ClienteLabel.AutoSize = True
        Me.ClienteLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClienteLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ClienteLabel.Location = New System.Drawing.Point(690, 255)
        Me.ClienteLabel.Name = "ClienteLabel"
        Me.ClienteLabel.Size = New System.Drawing.Size(82, 24)
        Me.ClienteLabel.TabIndex = 95
        Me.ClienteLabel.Text = "Cliente:"
        '
        'SClienteBTN
        '
        Me.SClienteBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SClienteBTN.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SClienteBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.SClienteBTN.Location = New System.Drawing.Point(902, 251)
        Me.SClienteBTN.Name = "SClienteBTN"
        Me.SClienteBTN.Size = New System.Drawing.Size(110, 34)
        Me.SClienteBTN.TabIndex = 94
        Me.SClienteBTN.Text = "Seleccionar"
        Me.SClienteBTN.UseVisualStyleBackColor = False
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.Enabled = False
        Me.ClienteTextBox.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ClienteTextBox.Location = New System.Drawing.Point(778, 253)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(118, 26)
        Me.ClienteTextBox.TabIndex = 93
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(275, 304)
        Me.ClientesDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.RowHeadersWidth = 51
        Me.ClientesDataGridView.RowTemplate.Height = 24
        Me.ClientesDataGridView.Size = New System.Drawing.Size(734, 54)
        Me.ClientesDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CarritoLabel)
        Me.Panel1.Controls.Add(Me.VentaDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(275, 381)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 121)
        Me.Panel1.TabIndex = 96
        '
        'CarritoLabel
        '
        Me.CarritoLabel.AutoSize = True
        Me.CarritoLabel.BackColor = System.Drawing.Color.Transparent
        Me.CarritoLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarritoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CarritoLabel.Location = New System.Drawing.Point(5, 3)
        Me.CarritoLabel.Name = "CarritoLabel"
        Me.CarritoLabel.Size = New System.Drawing.Size(82, 24)
        Me.CarritoLabel.TabIndex = 103
        Me.CarritoLabel.Text = "Carrito:"
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AllowUserToAddRows = False
        Me.VentaDataGridView.AllowUserToDeleteRows = False
        Me.VentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Tipo, Me.Precio})
        Me.VentaDataGridView.Location = New System.Drawing.Point(8, 30)
        Me.VentaDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.ReadOnly = True
        Me.VentaDataGridView.RowHeadersWidth = 51
        Me.VentaDataGridView.RowTemplate.Height = 24
        Me.VentaDataGridView.Size = New System.Drawing.Size(726, 89)
        Me.VentaDataGridView.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'CancelarBTN
        '
        Me.CancelarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CancelarBTN.Location = New System.Drawing.Point(801, 572)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(153, 56)
        Me.CancelarBTN.TabIndex = 98
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = False
        '
        'EliminarBTN
        '
        Me.EliminarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EliminarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EliminarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EliminarBTN.Location = New System.Drawing.Point(376, 572)
        Me.EliminarBTN.Name = "EliminarBTN"
        Me.EliminarBTN.Size = New System.Drawing.Size(153, 56)
        Me.EliminarBTN.TabIndex = 100
        Me.EliminarBTN.Text = "Eliminar"
        Me.EliminarBTN.UseVisualStyleBackColor = False
        '
        'RegistrarBTN
        '
        Me.RegistrarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RegistrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistrarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.RegistrarBTN.Location = New System.Drawing.Point(587, 572)
        Me.RegistrarBTN.Name = "RegistrarBTN"
        Me.RegistrarBTN.Size = New System.Drawing.Size(153, 56)
        Me.RegistrarBTN.TabIndex = 101
        Me.RegistrarBTN.Text = "Registar"
        Me.RegistrarBTN.UseVisualStyleBackColor = False
        '
        'ConfirmarBTN
        '
        Me.ConfirmarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ConfirmarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmarBTN.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ConfirmarBTN.Location = New System.Drawing.Point(505, 250)
        Me.ConfirmarBTN.Name = "ConfirmarBTN"
        Me.ConfirmarBTN.Size = New System.Drawing.Size(106, 35)
        Me.ConfirmarBTN.TabIndex = 102
        Me.ConfirmarBTN.Text = "Confirmar"
        Me.ConfirmarBTN.UseVisualStyleBackColor = False
        '
        'AgendaDataTableTableAdapter
        '
        Me.AgendaDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SolicitudesBindingSource
        '
        Me.SolicitudesBindingSource.DataMember = "Solicitudes"
        Me.SolicitudesBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'SolicitudesTableAdapter
        '
        Me.SolicitudesTableAdapter.ClearBeforeFill = True
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'InscripcionesBindingSource
        '
        Me.InscripcionesBindingSource.DataMember = "Inscripciones"
        Me.InscripcionesBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'InscripcionesTableAdapter
        '
        Me.InscripcionesTableAdapter.ClearBeforeFill = True
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 745)
        Me.Controls.Add(Me.ConfirmarBTN)
        Me.Controls.Add(Me.RegistrarBTN)
        Me.Controls.Add(Me.EliminarBTN)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.ClienteLabel)
        Me.Controls.Add(Me.SClienteBTN)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(Me.CursosDataGridView)
        Me.Controls.Add(Me.ServiciosDataGridView)
        Me.Controls.Add(Me.AgendaDataTableBindingNavigator)
        Me.Controls.Add(Me.AgregarComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.VLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NuevaVenta"
        Me.Text = "NuevaVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendaDataTableBindingNavigator.ResumeLayout(False)
        Me.AgendaDataTableBindingNavigator.PerformLayout()
        CType(Me.AgendaDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InscripcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents VLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AgregarComboBox As ComboBox
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
    Friend WithEvents SolicitudesBindingSource As BindingSource
    Friend WithEvents SolicitudesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.SolicitudesTableAdapter
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents CitasTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents ServiciosDataGridView As DataGridView
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Ser As DataGridViewTextBoxColumn
    Friend WithEvents CursosDataGridView As DataGridView
    Friend WithEvents ClienteLabel As Label
    Friend WithEvents SClienteBTN As Button
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents EliminarBTN As Button
    Friend WithEvents CarritoLabel As Label
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents RegistrarBTN As Button
    Friend WithEvents ConfirmarBTN As Button
    Friend WithEvents InscripcionesBindingSource As BindingSource
    Friend WithEvents InscripcionesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.InscripcionesTableAdapter
End Class
