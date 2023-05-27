<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alumnos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.EliminarBTN = New System.Windows.Forms.Button()
        Me.CursosLabel = New System.Windows.Forms.Label()
        Me.AlumnosDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AlumnosDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillAlumnosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Ref_CursoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Ref_CursoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillAlumnosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosDataTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillAlumnosToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Ref_CursoToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Ref_CursoToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillAlumnosToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosDataTableTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.AlumnosDataTableTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.InscripcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InscripcionesTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.InscripcionesTableAdapter()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlumnosDataTableBindingNavigator.SuspendLayout()
        CType(Me.AlumnosDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillAlumnosToolStrip.SuspendLayout()
        CType(Me.AlumnosDataTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillAlumnosToolStrip1.SuspendLayout()
        CType(Me.InscripcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(30, 751)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(120, 116)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 39
        Me.SalirPictureBox.TabStop = False
        '
        'EliminarBTN
        '
        Me.EliminarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EliminarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EliminarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBTN.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.EliminarBTN.Location = New System.Drawing.Point(1000, 678)
        Me.EliminarBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EliminarBTN.Name = "EliminarBTN"
        Me.EliminarBTN.Size = New System.Drawing.Size(176, 63)
        Me.EliminarBTN.TabIndex = 37
        Me.EliminarBTN.Text = "Eliminar"
        Me.EliminarBTN.UseVisualStyleBackColor = False
        '
        'CursosLabel
        '
        Me.CursosLabel.AutoSize = True
        Me.CursosLabel.BackColor = System.Drawing.Color.Transparent
        Me.CursosLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursosLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CursosLabel.Location = New System.Drawing.Point(927, 9)
        Me.CursosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CursosLabel.Name = "CursosLabel"
        Me.CursosLabel.Size = New System.Drawing.Size(289, 68)
        Me.CursosLabel.TabIndex = 35
        Me.CursosLabel.Text = "Curso de"
        Me.CursosLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AlumnosDataTableBindingNavigator
        '
        Me.AlumnosDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlumnosDataTableBindingNavigator.BindingSource = Me.AlumnosDataTableBindingSource
        Me.AlumnosDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlumnosDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlumnosDataTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AlumnosDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlumnosDataTableBindingNavigatorSaveItem})
        Me.AlumnosDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlumnosDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlumnosDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlumnosDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlumnosDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlumnosDataTableBindingNavigator.Name = "AlumnosDataTableBindingNavigator"
        Me.AlumnosDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlumnosDataTableBindingNavigator.Size = New System.Drawing.Size(972, 27)
        Me.AlumnosDataTableBindingNavigator.TabIndex = 40
        Me.AlumnosDataTableBindingNavigator.Text = "BindingNavigator1"
        Me.AlumnosDataTableBindingNavigator.Visible = False
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
        'AlumnosDataTableBindingSource
        '
        Me.AlumnosDataTableBindingSource.DataMember = "AlumnosDataTable"
        Me.AlumnosDataTableBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
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
        'AlumnosDataTableBindingNavigatorSaveItem
        '
        Me.AlumnosDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlumnosDataTableBindingNavigatorSaveItem.Enabled = False
        Me.AlumnosDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlumnosDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlumnosDataTableBindingNavigatorSaveItem.Name = "AlumnosDataTableBindingNavigatorSaveItem"
        Me.AlumnosDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.AlumnosDataTableBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillAlumnosToolStrip
        '
        Me.FillAlumnosToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillAlumnosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ref_CursoToolStripLabel, Me.Ref_CursoToolStripTextBox, Me.FillAlumnosToolStripButton})
        Me.FillAlumnosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillAlumnosToolStrip.Name = "FillAlumnosToolStrip"
        Me.FillAlumnosToolStrip.Size = New System.Drawing.Size(972, 27)
        Me.FillAlumnosToolStrip.TabIndex = 41
        Me.FillAlumnosToolStrip.Text = "FillAlumnosToolStrip"
        Me.FillAlumnosToolStrip.Visible = False
        '
        'Ref_CursoToolStripLabel
        '
        Me.Ref_CursoToolStripLabel.Name = "Ref_CursoToolStripLabel"
        Me.Ref_CursoToolStripLabel.Size = New System.Drawing.Size(73, 24)
        Me.Ref_CursoToolStripLabel.Text = "ref_Curso:"
        '
        'Ref_CursoToolStripTextBox
        '
        Me.Ref_CursoToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ref_CursoToolStripTextBox.Name = "Ref_CursoToolStripTextBox"
        Me.Ref_CursoToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillAlumnosToolStripButton
        '
        Me.FillAlumnosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillAlumnosToolStripButton.Name = "FillAlumnosToolStripButton"
        Me.FillAlumnosToolStripButton.Size = New System.Drawing.Size(90, 24)
        Me.FillAlumnosToolStripButton.Text = "FillAlumnos"
        '
        'AlumnosDataTableDataGridView
        '
        Me.AlumnosDataTableDataGridView.AllowUserToAddRows = False
        Me.AlumnosDataTableDataGridView.AllowUserToDeleteRows = False
        Me.AlumnosDataTableDataGridView.AutoGenerateColumns = False
        Me.AlumnosDataTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AlumnosDataTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AlumnosDataTableDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AlumnosDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlumnosDataTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_S, Me.ID, Me.DataGridViewTextBoxColumn1})
        Me.AlumnosDataTableDataGridView.DataSource = Me.AlumnosDataTableBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AlumnosDataTableDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.AlumnosDataTableDataGridView.Location = New System.Drawing.Point(231, 247)
        Me.AlumnosDataTableDataGridView.Name = "AlumnosDataTableDataGridView"
        Me.AlumnosDataTableDataGridView.ReadOnly = True
        Me.AlumnosDataTableDataGridView.RowHeadersWidth = 51
        Me.AlumnosDataTableDataGridView.RowTemplate.Height = 24
        Me.AlumnosDataTableDataGridView.Size = New System.Drawing.Size(1533, 329)
        Me.AlumnosDataTableDataGridView.TabIndex = 41
        '
        'Id_S
        '
        Me.Id_S.DataPropertyName = "Id_S"
        Me.Id_S.HeaderText = "Solicitd"
        Me.Id_S.MinimumWidth = 6
        Me.Id_S.Name = "Id_S"
        Me.Id_S.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FillAlumnosToolStrip1
        '
        Me.FillAlumnosToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillAlumnosToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ref_CursoToolStripLabel1, Me.Ref_CursoToolStripTextBox1, Me.FillAlumnosToolStripButton1})
        Me.FillAlumnosToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillAlumnosToolStrip1.Name = "FillAlumnosToolStrip1"
        Me.FillAlumnosToolStrip1.Size = New System.Drawing.Size(518, 27)
        Me.FillAlumnosToolStrip1.TabIndex = 42
        Me.FillAlumnosToolStrip1.Text = "FillAlumnosToolStrip1"
        Me.FillAlumnosToolStrip1.Visible = False
        '
        'Ref_CursoToolStripLabel1
        '
        Me.Ref_CursoToolStripLabel1.Name = "Ref_CursoToolStripLabel1"
        Me.Ref_CursoToolStripLabel1.Size = New System.Drawing.Size(73, 24)
        Me.Ref_CursoToolStripLabel1.Text = "ref_Curso:"
        '
        'Ref_CursoToolStripTextBox1
        '
        Me.Ref_CursoToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ref_CursoToolStripTextBox1.Name = "Ref_CursoToolStripTextBox1"
        Me.Ref_CursoToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'FillAlumnosToolStripButton1
        '
        Me.FillAlumnosToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillAlumnosToolStripButton1.Name = "FillAlumnosToolStripButton1"
        Me.FillAlumnosToolStripButton1.Size = New System.Drawing.Size(90, 24)
        Me.FillAlumnosToolStripButton1.Text = "FillAlumnos"
        '
        'AlumnosDataTableTableAdapter
        '
        Me.AlumnosDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
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
        'InscripcionesBindingSource
        '
        Me.InscripcionesBindingSource.DataMember = "Inscripciones"
        Me.InscripcionesBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
        '
        'InscripcionesTableAdapter
        '
        Me.InscripcionesTableAdapter.ClearBeforeFill = True
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.FillAlumnosToolStrip1)
        Me.Controls.Add(Me.AlumnosDataTableDataGridView)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.EliminarBTN)
        Me.Controls.Add(Me.CursosLabel)
        Me.Controls.Add(Me.FillAlumnosToolStrip)
        Me.Controls.Add(Me.AlumnosDataTableBindingNavigator)
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlumnosDataTableBindingNavigator.ResumeLayout(False)
        Me.AlumnosDataTableBindingNavigator.PerformLayout()
        CType(Me.AlumnosDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillAlumnosToolStrip.ResumeLayout(False)
        Me.FillAlumnosToolStrip.PerformLayout()
        CType(Me.AlumnosDataTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillAlumnosToolStrip1.ResumeLayout(False)
        Me.FillAlumnosToolStrip1.PerformLayout()
        CType(Me.InscripcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents EliminarBTN As Button
    Friend WithEvents CursosLabel As Label
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents AlumnosDataTableBindingSource As BindingSource
    Friend WithEvents AlumnosDataTableTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.AlumnosDataTableTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlumnosDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents AlumnosDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillAlumnosToolStrip As ToolStrip
    Friend WithEvents Ref_CursoToolStripLabel As ToolStripLabel
    Friend WithEvents Ref_CursoToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillAlumnosToolStripButton As ToolStripButton
    Friend WithEvents AlumnosDataTableDataGridView As DataGridView
    Friend WithEvents FillAlumnosToolStrip1 As ToolStrip
    Friend WithEvents Ref_CursoToolStripLabel1 As ToolStripLabel
    Friend WithEvents Ref_CursoToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillAlumnosToolStripButton1 As ToolStripButton
    Friend WithEvents InscripcionesBindingSource As BindingSource
    Friend WithEvents InscripcionesTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.InscripcionesTableAdapter
    Friend WithEvents Id_S As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
