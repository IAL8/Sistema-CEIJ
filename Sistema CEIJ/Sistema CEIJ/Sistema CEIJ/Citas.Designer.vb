<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Citas
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
        Dim HoraLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CursoLabel = New System.Windows.Forms.Label()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.RegistrarBTN = New System.Windows.Forms.Button()
        Me.ServicioTextBox = New System.Windows.Forms.TextBox()
        Me.CitasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CitasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SeleccionBTN = New System.Windows.Forms.Button()
        Me.ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria_Ser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SClienteBTN = New System.Windows.Forms.Button()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteLabel = New System.Windows.Forms.Label()
        Me.CitasTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.ServiciosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter()
        Me.ClientesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.ClientesTableAdapter()
        Me.SolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolicitudesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.SolicitudesTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        HoraLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.CitasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CitasBindingNavigator.SuspendLayout()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.BackColor = System.Drawing.Color.Transparent
        HoraLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraLabel.ForeColor = System.Drawing.Color.DarkKhaki
        HoraLabel.Location = New System.Drawing.Point(737, 432)
        HoraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(107, 40)
        HoraLabel.TabIndex = 80
        HoraLabel.Text = "Hora:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.ForeColor = System.Drawing.Color.DarkKhaki
        FechaLabel.Location = New System.Drawing.Point(716, 356)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(126, 40)
        FechaLabel.TabIndex = 76
        FechaLabel.Text = "Fecha:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.DarkKhaki
        NombreLabel.Location = New System.Drawing.Point(679, 188)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(161, 40)
        NombreLabel.TabIndex = 75
        NombreLabel.Text = "Servicio:"
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(875, 442)
        Me.HoraDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(215, 22)
        Me.HoraDateTimePicker.TabIndex = 85
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CalendarFont = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(875, 366)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FechaDateTimePicker.MaxDate = New Date(2024, 6, 18, 0, 0, 0, 0)
        Me.FechaDateTimePicker.MinDate = New Date(2020, 5, 18, 0, 0, 0, 0)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(215, 22)
        Me.FechaDateTimePicker.TabIndex = 83
        Me.FechaDateTimePicker.Value = New Date(2024, 5, 18, 0, 0, 0, 0)
        '
        'CursoLabel
        '
        Me.CursoLabel.AutoSize = True
        Me.CursoLabel.BackColor = System.Drawing.Color.Transparent
        Me.CursoLabel.Font = New System.Drawing.Font("Arial", 54.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CursoLabel.Location = New System.Drawing.Point(873, 37)
        Me.CursoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CursoLabel.Name = "CursoLabel"
        Me.CursoLabel.Size = New System.Drawing.Size(219, 105)
        Me.CursoLabel.TabIndex = 81
        Me.CursoLabel.Text = "Cita"
        '
        'CancelarBTN
        '
        Me.CancelarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CancelarBTN.Location = New System.Drawing.Point(1065, 771)
        Me.CancelarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(181, 69)
        Me.CancelarBTN.TabIndex = 78
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
        Me.RegistrarBTN.Location = New System.Drawing.Point(766, 771)
        Me.RegistrarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.RegistrarBTN.Name = "RegistrarBTN"
        Me.RegistrarBTN.Size = New System.Drawing.Size(181, 69)
        Me.RegistrarBTN.TabIndex = 77
        Me.RegistrarBTN.Text = "Guardar"
        Me.RegistrarBTN.UseVisualStyleBackColor = False
        '
        'ServicioTextBox
        '
        Me.ServicioTextBox.Enabled = False
        Me.ServicioTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicioTextBox.Location = New System.Drawing.Point(861, 194)
        Me.ServicioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServicioTextBox.Name = "ServicioTextBox"
        Me.ServicioTextBox.Size = New System.Drawing.Size(231, 34)
        Me.ServicioTextBox.TabIndex = 74
        '
        'CitasBindingNavigator
        '
        Me.CitasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CitasBindingNavigator.BindingSource = Me.CitasBindingSource
        Me.CitasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CitasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CitasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CitasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CitasBindingNavigatorSaveItem})
        Me.CitasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CitasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CitasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CitasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CitasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CitasBindingNavigator.Name = "CitasBindingNavigator"
        Me.CitasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CitasBindingNavigator.Size = New System.Drawing.Size(475, 27)
        Me.CitasBindingNavigator.TabIndex = 86
        Me.CitasBindingNavigator.Text = "BindingNavigator1"
        Me.CitasBindingNavigator.Visible = False
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
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
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
        'CitasBindingNavigatorSaveItem
        '
        Me.CitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CitasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CitasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CitasBindingNavigatorSaveItem.Name = "CitasBindingNavigatorSaveItem"
        Me.CitasBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CitasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SeleccionBTN
        '
        Me.SeleccionBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeleccionBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.SeleccionBTN.Location = New System.Drawing.Point(1116, 188)
        Me.SeleccionBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.SeleccionBTN.Name = "SeleccionBTN"
        Me.SeleccionBTN.Size = New System.Drawing.Size(181, 50)
        Me.SeleccionBTN.TabIndex = 87
        Me.SeleccionBTN.Text = "Seleccionar"
        Me.SeleccionBTN.UseVisualStyleBackColor = False
        '
        'ServiciosDataGridView
        '
        Me.ServiciosDataGridView.AllowUserToAddRows = False
        Me.ServiciosDataGridView.AllowUserToDeleteRows = False
        Me.ServiciosDataGridView.AutoGenerateColumns = False
        Me.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiciosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiciosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Categoria_Ser, Me.DataGridViewTextBoxColumn4})
        Me.ServiciosDataGridView.DataSource = Me.ServiciosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiciosDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ServiciosDataGridView.Location = New System.Drawing.Point(253, 251)
        Me.ServiciosDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ServiciosDataGridView.Name = "ServiciosDataGridView"
        Me.ServiciosDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiciosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ServiciosDataGridView.RowHeadersWidth = 51
        Me.ServiciosDataGridView.RowTemplate.Height = 24
        Me.ServiciosDataGridView.Size = New System.Drawing.Size(1385, 95)
        Me.ServiciosDataGridView.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Servicio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_Ser"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Categoria_Ser
        '
        Me.Categoria_Ser.DataPropertyName = "Categoria_Ser"
        Me.Categoria_Ser.HeaderText = "Categoria"
        Me.Categoria_Ser.MinimumWidth = 6
        Me.Categoria_Ser.Name = "Categoria_Ser"
        Me.Categoria_Ser.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Precio_Ser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'SClienteBTN
        '
        Me.SClienteBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SClienteBTN.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SClienteBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.SClienteBTN.Location = New System.Drawing.Point(1131, 501)
        Me.SClienteBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.SClienteBTN.Name = "SClienteBTN"
        Me.SClienteBTN.Size = New System.Drawing.Size(181, 50)
        Me.SClienteBTN.TabIndex = 90
        Me.SClienteBTN.Text = "Seleccionar"
        Me.SClienteBTN.UseVisualStyleBackColor = False
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.Enabled = False
        Me.ClienteTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextBox.Location = New System.Drawing.Point(861, 516)
        Me.ClienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(224, 34)
        Me.ClienteTextBox.TabIndex = 89
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClientesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClientesDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClientesDataGridView.Location = New System.Drawing.Point(230, 582)
        Me.ClientesDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.RowHeadersWidth = 51
        Me.ClientesDataGridView.RowTemplate.Height = 24
        Me.ClientesDataGridView.Size = New System.Drawing.Size(1421, 156)
        Me.ClientesDataGridView.TabIndex = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'ClienteLabel
        '
        Me.ClienteLabel.AutoSize = True
        Me.ClienteLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClienteLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ClienteLabel.Location = New System.Drawing.Point(699, 507)
        Me.ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClienteLabel.Name = "ClienteLabel"
        Me.ClienteLabel.Size = New System.Drawing.Size(140, 40)
        Me.ClienteLabel.TabIndex = 92
        Me.ClienteLabel.Text = "Cliente:"
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
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
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1827, 27)
        Me.FillByToolStrip.TabIndex = 93
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.FondoSign
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ClienteLabel)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.SClienteBTN)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(Me.ServiciosDataGridView)
        Me.Controls.Add(Me.SeleccionBTN)
        Me.Controls.Add(Me.HoraDateTimePicker)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.CursoLabel)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.RegistrarBTN)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.ServicioTextBox)
        Me.Controls.Add(Me.CitasBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Citas"
        Me.Text = "Citas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CitasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CitasBindingNavigator.ResumeLayout(False)
        Me.CitasBindingNavigator.PerformLayout()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HoraDateTimePicker As DateTimePicker
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents CursoLabel As Label
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents RegistrarBTN As Button
    Friend WithEvents ServicioTextBox As TextBox
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents CitasTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CitasBindingNavigator As BindingNavigator
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
    Friend WithEvents CitasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SeleccionBTN As Button
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents ServiciosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Categoria_Ser As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents SClienteBTN As Button
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents SolicitudesBindingSource As BindingSource
    Friend WithEvents SolicitudesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.SolicitudesTableAdapter
    Friend WithEvents ClienteLabel As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
