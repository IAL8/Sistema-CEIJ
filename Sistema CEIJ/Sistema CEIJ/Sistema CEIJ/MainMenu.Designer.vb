<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SalirPanel = New System.Windows.Forms.Panel()
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.VentaLabel = New System.Windows.Forms.Label()
        Me.ServiciosPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClientesPanel = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ClientesLabel = New System.Windows.Forms.Label()
        Me.CursosPanel = New System.Windows.Forms.Panel()
        Me.ActividadesPictureBox = New System.Windows.Forms.PictureBox()
        Me.CursosLabel = New System.Windows.Forms.Label()
        Me.InventarioPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AgendaLabel = New System.Windows.Forms.Label()
        Me.AgendalPanel = New System.Windows.Forms.Panel()
        Me.MenuLabel = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalirPanel.SuspendLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiciosPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CursosPanel.SuspendLayout()
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendalPanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UserLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(695, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 74)
        Me.Panel1.TabIndex = 10
        '
        'UserLabel
        '
        Me.UserLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UserLabel.AutoSize = True
        Me.UserLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserLabel.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(84, 26)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(108, 35)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "Usuario"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Sistema_CEIJ.My.Resources.Resources.img_usuario
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SalirPanel
        '
        Me.SalirPanel.BackColor = System.Drawing.Color.White
        Me.SalirPanel.Controls.Add(Me.Salir)
        Me.SalirPanel.Controls.Add(Me.VentaLabel)
        Me.SalirPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPanel.Location = New System.Drawing.Point(446, 365)
        Me.SalirPanel.Name = "SalirPanel"
        Me.SalirPanel.Size = New System.Drawing.Size(160, 165)
        Me.SalirPanel.TabIndex = 17
        '
        'Salir
        '
        Me.Salir.Image = Global.Sistema_CEIJ.My.Resources.Resources.Balance
        Me.Salir.Location = New System.Drawing.Point(17, 5)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(121, 117)
        Me.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Salir.TabIndex = 3
        Me.Salir.TabStop = False
        '
        'VentaLabel
        '
        Me.VentaLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.VentaLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VentaLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentaLabel.Location = New System.Drawing.Point(1, 129)
        Me.VentaLabel.Name = "VentaLabel"
        Me.VentaLabel.Size = New System.Drawing.Size(158, 35)
        Me.VentaLabel.TabIndex = 14
        Me.VentaLabel.Text = "Venta"
        Me.VentaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServiciosPanel
        '
        Me.ServiciosPanel.BackColor = System.Drawing.Color.White
        Me.ServiciosPanel.Controls.Add(Me.PictureBox3)
        Me.ServiciosPanel.Controls.Add(Me.Label8)
        Me.ServiciosPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ServiciosPanel.Location = New System.Drawing.Point(215, 365)
        Me.ServiciosPanel.Name = "ServiciosPanel"
        Me.ServiciosPanel.Size = New System.Drawing.Size(160, 165)
        Me.ServiciosPanel.TabIndex = 16
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_CEIJ.My.Resources.Resources.Servicios
        Me.PictureBox3.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(1, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 35)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Servicios"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientesPanel
        '
        Me.ClientesPanel.BackColor = System.Drawing.Color.White
        Me.ClientesPanel.Controls.Add(Me.PictureBox4)
        Me.ClientesPanel.Controls.Add(Me.ClientesLabel)
        Me.ClientesPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClientesPanel.Location = New System.Drawing.Point(672, 174)
        Me.ClientesPanel.Name = "ClientesPanel"
        Me.ClientesPanel.Size = New System.Drawing.Size(160, 165)
        Me.ClientesPanel.TabIndex = 15
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sistema_CEIJ.My.Resources.Resources.Cliente
        Me.PictureBox4.Location = New System.Drawing.Point(21, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 113)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'ClientesLabel
        '
        Me.ClientesLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientesLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClientesLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientesLabel.Location = New System.Drawing.Point(1, 129)
        Me.ClientesLabel.Name = "ClientesLabel"
        Me.ClientesLabel.Size = New System.Drawing.Size(158, 35)
        Me.ClientesLabel.TabIndex = 13
        Me.ClientesLabel.Text = "Clientes"
        Me.ClientesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CursosPanel
        '
        Me.CursosPanel.BackColor = System.Drawing.Color.White
        Me.CursosPanel.Controls.Add(Me.ActividadesPictureBox)
        Me.CursosPanel.Controls.Add(Me.CursosLabel)
        Me.CursosPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CursosPanel.Location = New System.Drawing.Point(446, 174)
        Me.CursosPanel.Name = "CursosPanel"
        Me.CursosPanel.Size = New System.Drawing.Size(160, 165)
        Me.CursosPanel.TabIndex = 14
        '
        'ActividadesPictureBox
        '
        Me.ActividadesPictureBox.Image = Global.Sistema_CEIJ.My.Resources.Resources.Curso
        Me.ActividadesPictureBox.Location = New System.Drawing.Point(12, 3)
        Me.ActividadesPictureBox.Name = "ActividadesPictureBox"
        Me.ActividadesPictureBox.Size = New System.Drawing.Size(129, 119)
        Me.ActividadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ActividadesPictureBox.TabIndex = 6
        Me.ActividadesPictureBox.TabStop = False
        '
        'CursosLabel
        '
        Me.CursosLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.CursosLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CursosLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CursosLabel.Location = New System.Drawing.Point(1, 129)
        Me.CursosLabel.Name = "CursosLabel"
        Me.CursosLabel.Size = New System.Drawing.Size(158, 35)
        Me.CursosLabel.TabIndex = 14
        Me.CursosLabel.Text = "Cursos"
        Me.CursosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InventarioPanel
        '
        Me.InventarioPanel.BackColor = System.Drawing.Color.White
        Me.InventarioPanel.Controls.Add(Me.PictureBox5)
        Me.InventarioPanel.Controls.Add(Me.Label1)
        Me.InventarioPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventarioPanel.Location = New System.Drawing.Point(672, 364)
        Me.InventarioPanel.Name = "InventarioPanel"
        Me.InventarioPanel.Size = New System.Drawing.Size(160, 165)
        Me.InventarioPanel.TabIndex = 16
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Sistema_CEIJ.My.Resources.Resources.Inventario
        Me.PictureBox5.Location = New System.Drawing.Point(19, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(120, 113)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Inventario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_CEIJ.My.Resources.Resources.Calendario
        Me.PictureBox2.Location = New System.Drawing.Point(23, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'AgendaLabel
        '
        Me.AgendaLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.AgendaLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgendaLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AgendaLabel.Location = New System.Drawing.Point(1, 129)
        Me.AgendaLabel.Name = "AgendaLabel"
        Me.AgendaLabel.Size = New System.Drawing.Size(158, 35)
        Me.AgendaLabel.TabIndex = 14
        Me.AgendaLabel.Text = "Agenda"
        Me.AgendaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgendalPanel
        '
        Me.AgendalPanel.BackColor = System.Drawing.Color.White
        Me.AgendalPanel.Controls.Add(Me.AgendaLabel)
        Me.AgendalPanel.Controls.Add(Me.PictureBox2)
        Me.AgendalPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgendalPanel.Location = New System.Drawing.Point(215, 174)
        Me.AgendalPanel.Name = "AgendalPanel"
        Me.AgendalPanel.Size = New System.Drawing.Size(160, 165)
        Me.AgendalPanel.TabIndex = 13
        '
        'MenuLabel
        '
        Me.MenuLabel.AutoSize = True
        Me.MenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.MenuLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.MenuLabel.Location = New System.Drawing.Point(420, 31)
        Me.MenuLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MenuLabel.Name = "MenuLabel"
        Me.MenuLabel.Size = New System.Drawing.Size(185, 68)
        Me.MenuLabel.TabIndex = 18
        Me.MenuLabel.Text = "Menú"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.Sistema_CEIJ.My.Resources.Resources.Logo
        Me.PictureBox6.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(135, 132)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(12, 482)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(64, 68)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 20
        Me.SalirPictureBox.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 562)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.MenuLabel)
        Me.Controls.Add(Me.InventarioPanel)
        Me.Controls.Add(Me.SalirPanel)
        Me.Controls.Add(Me.ServiciosPanel)
        Me.Controls.Add(Me.AgendalPanel)
        Me.Controls.Add(Me.ClientesPanel)
        Me.Controls.Add(Me.CursosPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenuvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalirPanel.ResumeLayout(False)
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiciosPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesPanel.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CursosPanel.ResumeLayout(False)
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioPanel.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendalPanel.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SalirPanel As Panel
    Friend WithEvents Salir As PictureBox
    Friend WithEvents VentaLabel As Label
    Friend WithEvents ServiciosPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ClientesPanel As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ClientesLabel As Label
    Friend WithEvents CursosPanel As Panel
    Friend WithEvents ActividadesPictureBox As PictureBox
    Friend WithEvents CursosLabel As Label
    Friend WithEvents InventarioPanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AgendaLabel As Label
    Friend WithEvents AgendalPanel As Panel
    Friend WithEvents MenuLabel As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SalirPictureBox As PictureBox
End Class
