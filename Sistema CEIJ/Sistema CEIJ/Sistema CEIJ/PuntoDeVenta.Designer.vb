<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuntoDeVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuntoDeVenta))
        Me.MenuLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NuevVentaPanel = New System.Windows.Forms.Panel()
        Me.NuevaVentaLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HistorialPanel = New System.Windows.Forms.Panel()
        Me.ActividadesPictureBox = New System.Windows.Forms.PictureBox()
        Me.HistorialLabel = New System.Windows.Forms.Label()
        Me.SalirPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NuevVentaPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistorialPanel.SuspendLayout()
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLabel
        '
        Me.MenuLabel.AutoSize = True
        Me.MenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.MenuLabel.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.MenuLabel.Location = New System.Drawing.Point(864, 122)
        Me.MenuLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MenuLabel.Name = "MenuLabel"
        Me.MenuLabel.Size = New System.Drawing.Size(465, 68)
        Me.MenuLabel.TabIndex = 22
        Me.MenuLabel.Text = "Punto de Venta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UserLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1569, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 73)
        Me.Panel1.TabIndex = 21
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
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NuevVentaPanel
        '
        Me.NuevVentaPanel.BackColor = System.Drawing.Color.White
        Me.NuevVentaPanel.Controls.Add(Me.NuevaVentaLabel)
        Me.NuevVentaPanel.Controls.Add(Me.PictureBox2)
        Me.NuevVentaPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevVentaPanel.Location = New System.Drawing.Point(815, 297)
        Me.NuevVentaPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NuevVentaPanel.Name = "NuevVentaPanel"
        Me.NuevVentaPanel.Size = New System.Drawing.Size(245, 331)
        Me.NuevVentaPanel.TabIndex = 25
        '
        'NuevaVentaLabel
        '
        Me.NuevaVentaLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.NuevaVentaLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevaVentaLabel.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.NuevaVentaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NuevaVentaLabel.Location = New System.Drawing.Point(1, 213)
        Me.NuevaVentaLabel.Name = "NuevaVentaLabel"
        Me.NuevaVentaLabel.Size = New System.Drawing.Size(243, 117)
        Me.NuevaVentaLabel.TabIndex = 14
        Me.NuevaVentaLabel.Text = "Nueva Venta"
        Me.NuevaVentaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_CEIJ.My.Resources.Resources.Nueva_Venta
        Me.PictureBox2.Location = New System.Drawing.Point(35, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'HistorialPanel
        '
        Me.HistorialPanel.BackColor = System.Drawing.Color.White
        Me.HistorialPanel.Controls.Add(Me.ActividadesPictureBox)
        Me.HistorialPanel.Controls.Add(Me.HistorialLabel)
        Me.HistorialPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistorialPanel.Location = New System.Drawing.Point(1143, 297)
        Me.HistorialPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistorialPanel.Name = "HistorialPanel"
        Me.HistorialPanel.Size = New System.Drawing.Size(245, 330)
        Me.HistorialPanel.TabIndex = 15
        '
        'ActividadesPictureBox
        '
        Me.ActividadesPictureBox.Image = Global.Sistema_CEIJ.My.Resources.Resources.Historial
        Me.ActividadesPictureBox.Location = New System.Drawing.Point(37, 37)
        Me.ActividadesPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ActividadesPictureBox.Name = "ActividadesPictureBox"
        Me.ActividadesPictureBox.Size = New System.Drawing.Size(175, 159)
        Me.ActividadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ActividadesPictureBox.TabIndex = 6
        Me.ActividadesPictureBox.TabStop = False
        '
        'HistorialLabel
        '
        Me.HistorialLabel.BackColor = System.Drawing.Color.DarkKhaki
        Me.HistorialLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistorialLabel.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.HistorialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HistorialLabel.Location = New System.Drawing.Point(0, 213)
        Me.HistorialLabel.Name = "HistorialLabel"
        Me.HistorialLabel.Size = New System.Drawing.Size(245, 118)
        Me.HistorialLabel.TabIndex = 14
        Me.HistorialLabel.Text = "Historial"
        Me.HistorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalirPictureBox
        '
        Me.SalirPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SalirPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirPictureBox.Image = CType(resources.GetObject("SalirPictureBox.Image"), System.Drawing.Image)
        Me.SalirPictureBox.Location = New System.Drawing.Point(1787, 855)
        Me.SalirPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalirPictureBox.Name = "SalirPictureBox"
        Me.SalirPictureBox.Size = New System.Drawing.Size(99, 98)
        Me.SalirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SalirPictureBox.TabIndex = 24
        Me.SalirPictureBox.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.Sistema_CEIJ.My.Resources.Resources.Logo
        Me.PictureBox6.Location = New System.Drawing.Point(521, 97)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(135, 132)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PuntoDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CEIJ.My.Resources.Resources.v748_toon_111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.HistorialPanel)
        Me.Controls.Add(Me.NuevVentaPanel)
        Me.Controls.Add(Me.SalirPictureBox)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.MenuLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PuntoDeVenta"
        Me.Text = "PuntoDeVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NuevVentaPanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistorialPanel.ResumeLayout(False)
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirPictureBox As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents MenuLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NuevVentaPanel As Panel
    Friend WithEvents NuevaVentaLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HistorialPanel As Panel
    Friend WithEvents ActividadesPictureBox As PictureBox
    Friend WithEvents HistorialLabel As Label
End Class
