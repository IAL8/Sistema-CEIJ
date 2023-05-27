<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cursos
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
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cursos))
        Me.CursoLabel = New System.Windows.Forms.Label()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.RegistrarBTN = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CursosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CursosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CursosTableAdapter = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.CursosTableAdapter()
        Me.TableAdapterManager = New Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager()
        Me.HoraIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraFDateTimePicker = New System.Windows.Forms.DateTimePicker()
        HoraLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CursosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CursosBindingNavigator.SuspendLayout()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.BackColor = System.Drawing.Color.Transparent
        HoraLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraLabel.ForeColor = System.Drawing.Color.DarkKhaki
        HoraLabel.Location = New System.Drawing.Point(573, 389)
        HoraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(107, 40)
        HoraLabel.TabIndex = 63
        HoraLabel.Text = "Hora:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.BackColor = System.Drawing.Color.Transparent
        PrecioLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.ForeColor = System.Drawing.Color.DarkKhaki
        PrecioLabel.Location = New System.Drawing.Point(573, 448)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(133, 40)
        PrecioLabel.TabIndex = 62
        PrecioLabel.Text = "Precio:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.ForeColor = System.Drawing.Color.DarkKhaki
        FechaLabel.Location = New System.Drawing.Point(573, 327)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(126, 40)
        FechaLabel.TabIndex = 59
        FechaLabel.Text = "Fecha:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.DarkKhaki
        NombreLabel.Location = New System.Drawing.Point(573, 268)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(159, 40)
        NombreLabel.TabIndex = 58
        NombreLabel.Text = "Nombre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Label1.ForeColor = System.Drawing.Color.DarkKhaki
        Label1.Location = New System.Drawing.Point(847, 406)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(16, 22)
        Label1.TabIndex = 71
        Label1.Text = "-"
        '
        'CursoLabel
        '
        Me.CursoLabel.AutoSize = True
        Me.CursoLabel.BackColor = System.Drawing.Color.Transparent
        Me.CursoLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursoLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CursoLabel.Location = New System.Drawing.Point(699, 165)
        Me.CursoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CursoLabel.Name = "CursoLabel"
        Me.CursoLabel.Size = New System.Drawing.Size(202, 68)
        Me.CursoLabel.TabIndex = 64
        Me.CursoLabel.Text = "Curso"
        '
        'CancelarBTN
        '
        Me.CancelarBTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBTN.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarBTN.ForeColor = System.Drawing.Color.DarkKhaki
        Me.CancelarBTN.Location = New System.Drawing.Point(871, 534)
        Me.CancelarBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(137, 44)
        Me.CancelarBTN.TabIndex = 61
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
        Me.RegistrarBTN.Location = New System.Drawing.Point(633, 534)
        Me.RegistrarBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RegistrarBTN.Name = "RegistrarBTN"
        Me.RegistrarBTN.Size = New System.Drawing.Size(137, 44)
        Me.RegistrarBTN.TabIndex = 60
        Me.RegistrarBTN.Text = "Guardar"
        Me.RegistrarBTN.UseVisualStyleBackColor = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(759, 270)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(215, 34)
        Me.NombreTextBox.TabIndex = 55
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(759, 454)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(215, 34)
        Me.PrecioTextBox.TabIndex = 66
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(759, 342)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FechaDateTimePicker.MaxDate = New Date(2024, 6, 18, 0, 0, 0, 0)
        Me.FechaDateTimePicker.MinDate = New Date(2020, 5, 18, 0, 0, 0, 0)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(215, 39)
        Me.FechaDateTimePicker.TabIndex = 69
        Me.FechaDateTimePicker.Value = New Date(2024, 5, 18, 0, 0, 0, 0)
        '
        'CursosBindingNavigator
        '
        Me.CursosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CursosBindingNavigator.BindingSource = Me.CursosBindingSource
        Me.CursosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CursosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CursosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CursosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CursosBindingNavigatorSaveItem})
        Me.CursosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CursosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CursosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CursosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CursosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CursosBindingNavigator.Name = "CursosBindingNavigator"
        Me.CursosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CursosBindingNavigator.Size = New System.Drawing.Size(489, 27)
        Me.CursosBindingNavigator.TabIndex = 70
        Me.CursosBindingNavigator.Text = "BindingNavigator1"
        Me.CursosBindingNavigator.Visible = False
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
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.BD_Sistema_CEIJDataSet
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
        'CursosBindingNavigatorSaveItem
        '
        Me.CursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CursosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CursosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CursosBindingNavigatorSaveItem.Name = "CursosBindingNavigatorSaveItem"
        Me.CursosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CursosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Me.CursosTableAdapter
        Me.TableAdapterManager.InscripcionesTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_CEIJ.BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HoraIDateTimePicker
        '
        Me.HoraIDateTimePicker.CalendarFont = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraIDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraIDateTimePicker.Location = New System.Drawing.Point(744, 404)
        Me.HoraIDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HoraIDateTimePicker.Name = "HoraIDateTimePicker"
        Me.HoraIDateTimePicker.Size = New System.Drawing.Size(95, 22)
        Me.HoraIDateTimePicker.TabIndex = 72
        '
        'HoraFDateTimePicker
        '
        Me.HoraFDateTimePicker.CalendarFont = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraFDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraFDateTimePicker.Location = New System.Drawing.Point(871, 404)
        Me.HoraFDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HoraFDateTimePicker.Name = "HoraFDateTimePicker"
        Me.HoraFDateTimePicker.Size = New System.Drawing.Size(95, 22)
        Me.HoraFDateTimePicker.TabIndex = 73
        '
        'Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.FondoSign
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.HoraFDateTimePicker)
        Me.Controls.Add(Me.HoraIDateTimePicker)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CursosBindingNavigator)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.CursoLabel)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.RegistrarBTN)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cursos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CursosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CursosBindingNavigator.ResumeLayout(False)
        Me.CursosBindingNavigator.PerformLayout()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_CEIJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CursoLabel As Label
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents RegistrarBTN As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents BD_Sistema_CEIJDataSet As BD_Sistema_CEIJDataSet
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_CEIJDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_CEIJDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CursosBindingNavigator As BindingNavigator
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
    Friend WithEvents CursosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HoraIDateTimePicker As DateTimePicker
    Friend WithEvents HoraFDateTimePicker As DateTimePicker
End Class
