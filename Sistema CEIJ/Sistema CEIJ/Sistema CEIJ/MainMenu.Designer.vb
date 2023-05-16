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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IdiomaPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HistorialPanel = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActividadPanel = New System.Windows.Forms.Panel()
        Me.ActividadesPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PerfilPanel = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalirPanel.SuspendLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IdiomaPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistorialPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActividadPanel.SuspendLayout()
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerfilPanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SalirPanel.Controls.Add(Me.Label6)
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 35)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Salir"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdiomaPanel
        '
        Me.IdiomaPanel.BackColor = System.Drawing.Color.White
        Me.IdiomaPanel.Controls.Add(Me.PictureBox3)
        Me.IdiomaPanel.Controls.Add(Me.Label8)
        Me.IdiomaPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IdiomaPanel.Location = New System.Drawing.Point(215, 365)
        Me.IdiomaPanel.Name = "IdiomaPanel"
        Me.IdiomaPanel.Size = New System.Drawing.Size(160, 165)
        Me.IdiomaPanel.TabIndex = 16
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
        Me.Label8.Text = "Idioma"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistorialPanel
        '
        Me.HistorialPanel.BackColor = System.Drawing.Color.White
        Me.HistorialPanel.Controls.Add(Me.PictureBox4)
        Me.HistorialPanel.Controls.Add(Me.Label2)
        Me.HistorialPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistorialPanel.Location = New System.Drawing.Point(672, 174)
        Me.HistorialPanel.Name = "HistorialPanel"
        Me.HistorialPanel.Size = New System.Drawing.Size(160, 165)
        Me.HistorialPanel.TabIndex = 15
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Historial"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActividadPanel
        '
        Me.ActividadPanel.BackColor = System.Drawing.Color.White
        Me.ActividadPanel.Controls.Add(Me.ActividadesPictureBox)
        Me.ActividadPanel.Controls.Add(Me.Label4)
        Me.ActividadPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActividadPanel.Location = New System.Drawing.Point(446, 174)
        Me.ActividadPanel.Name = "ActividadPanel"
        Me.ActividadPanel.Size = New System.Drawing.Size(160, 165)
        Me.ActividadPanel.TabIndex = 14
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(1, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 35)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Actividades"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(672, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 165)
        Me.Panel2.TabIndex = 16
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
        Me.Label1.Text = "Historial"
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
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(1, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 35)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Perfil"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerfilPanel
        '
        Me.PerfilPanel.BackColor = System.Drawing.Color.White
        Me.PerfilPanel.Controls.Add(Me.Label7)
        Me.PerfilPanel.Controls.Add(Me.PictureBox2)
        Me.PerfilPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PerfilPanel.Location = New System.Drawing.Point(215, 174)
        Me.PerfilPanel.Name = "PerfilPanel"
        Me.PerfilPanel.Size = New System.Drawing.Size(160, 165)
        Me.PerfilPanel.TabIndex = 13
        '
        'Menu
        '
        Me.Menu.AutoSize = True
        Me.Menu.BackColor = System.Drawing.Color.Transparent
        Me.Menu.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Menu.Location = New System.Drawing.Point(420, 31)
        Me.Menu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(185, 68)
        Me.Menu.TabIndex = 18
        Me.Menu.Text = "Menú"
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
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 482)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(64, 68)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 562)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SalirPanel)
        Me.Controls.Add(Me.IdiomaPanel)
        Me.Controls.Add(Me.PerfilPanel)
        Me.Controls.Add(Me.HistorialPanel)
        Me.Controls.Add(Me.ActividadPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenuvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalirPanel.ResumeLayout(False)
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IdiomaPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistorialPanel.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActividadPanel.ResumeLayout(False)
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerfilPanel.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SalirPanel As Panel
    Friend WithEvents Salir As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IdiomaPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HistorialPanel As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ActividadPanel As Panel
    Friend WithEvents ActividadesPictureBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PerfilPanel As Panel
    Friend WithEvents Menu As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
