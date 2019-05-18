<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cine
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TaquillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaquillaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FdhgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GtegteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSalasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaquillaToolStripMenuItem, Me.FdhgToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TaquillaToolStripMenuItem
        '
        Me.TaquillaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaquillaToolStripMenuItem1})
        Me.TaquillaToolStripMenuItem.Name = "TaquillaToolStripMenuItem"
        Me.TaquillaToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TaquillaToolStripMenuItem.Text = "Sucursal"
        '
        'TaquillaToolStripMenuItem1
        '
        Me.TaquillaToolStripMenuItem1.Name = "TaquillaToolStripMenuItem1"
        Me.TaquillaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TaquillaToolStripMenuItem1.Text = "Taquilla"
        '
        'FdhgToolStripMenuItem
        '
        Me.FdhgToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GtegteToolStripMenuItem})
        Me.FdhgToolStripMenuItem.Name = "FdhgToolStripMenuItem"
        Me.FdhgToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FdhgToolStripMenuItem.Text = "Online"
        '
        'GtegteToolStripMenuItem
        '
        Me.GtegteToolStripMenuItem.Name = "GtegteToolStripMenuItem"
        Me.GtegteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GtegteToolStripMenuItem.Text = "Reserva"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPeliculasToolStripMenuItem, Me.VerPeliculasToolStripMenuItem, Me.VerSalasToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'AgregarPeliculasToolStripMenuItem
        '
        Me.AgregarPeliculasToolStripMenuItem.Name = "AgregarPeliculasToolStripMenuItem"
        Me.AgregarPeliculasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgregarPeliculasToolStripMenuItem.Text = "Agregar peliculas"
        '
        'VerPeliculasToolStripMenuItem
        '
        Me.VerPeliculasToolStripMenuItem.Name = "VerPeliculasToolStripMenuItem"
        Me.VerPeliculasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VerPeliculasToolStripMenuItem.Text = "Ver peliculas"
        '
        'VerSalasToolStripMenuItem
        '
        Me.VerSalasToolStripMenuItem.Name = "VerSalasToolStripMenuItem"
        Me.VerSalasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VerSalasToolStripMenuItem.Text = "Ver salas"
        '
        'Cine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 387)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cine"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TaquillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FdhgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GtegteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaquillaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSalasToolStripMenuItem As ToolStripMenuItem
End Class
