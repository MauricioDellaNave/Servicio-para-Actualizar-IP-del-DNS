<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.ObtenerIP = New System.Windows.Forms.Button()
        Me.ActualizarHTML = New System.Windows.Forms.Button()
        Me.SubirFTP = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtIPPublica = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPPublicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObtenerIP
        '
        Me.ObtenerIP.Location = New System.Drawing.Point(12, 41)
        Me.ObtenerIP.Name = "ObtenerIP"
        Me.ObtenerIP.Size = New System.Drawing.Size(130, 46)
        Me.ObtenerIP.TabIndex = 0
        Me.ObtenerIP.Text = "Obtener IP Publica"
        Me.ObtenerIP.UseVisualStyleBackColor = True
        '
        'ActualizarHTML
        '
        Me.ActualizarHTML.Location = New System.Drawing.Point(12, 88)
        Me.ActualizarHTML.Name = "ActualizarHTML"
        Me.ActualizarHTML.Size = New System.Drawing.Size(130, 45)
        Me.ActualizarHTML.TabIndex = 1
        Me.ActualizarHTML.Text = "Actualizar HTML"
        Me.ActualizarHTML.UseVisualStyleBackColor = True
        '
        'SubirFTP
        '
        Me.SubirFTP.Location = New System.Drawing.Point(12, 134)
        Me.SubirFTP.Name = "SubirFTP"
        Me.SubirFTP.Size = New System.Drawing.Size(130, 45)
        Me.SubirFTP.TabIndex = 2
        Me.SubirFTP.Text = "Conexion FTP"
        Me.SubirFTP.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 84)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 39)
        Me.TextBox1.TabIndex = 3
        '
        'txtIPPublica
        '
        Me.txtIPPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPPublica.Location = New System.Drawing.Point(148, 58)
        Me.txtIPPublica.Name = "txtIPPublica"
        Me.txtIPPublica.ReadOnly = True
        Me.txtIPPublica.Size = New System.Drawing.Size(179, 22)
        Me.txtIPPublica.TabIndex = 4
        Me.txtIPPublica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 129)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 39)
        Me.TextBox2.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem, Me.IPPublicaToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(350, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'IPPublicaToolStripMenuItem
        '
        Me.IPPublicaToolStripMenuItem.Name = "IPPublicaToolStripMenuItem"
        Me.IPPublicaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.IPPublicaToolStripMenuItem.Text = "IP Publica"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 321)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtIPPublica)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SubirFTP)
        Me.Controls.Add(Me.ActualizarHTML)
        Me.Controls.Add(Me.ObtenerIP)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Cliente DNS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ObtenerIP As System.Windows.Forms.Button
    Friend WithEvents ActualizarHTML As System.Windows.Forms.Button
    Friend WithEvents SubirFTP As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIPPublica As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPPublicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
