<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_libros1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DGViewdatos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CBoxBusqueda = New System.Windows.Forms.ComboBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Txt_numReferencia = New System.Windows.Forms.TextBox()
        Me.msg = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtTema = New System.Windows.Forms.TextBox()
        Me.TxtAutor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGViewdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("News701 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num_referencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("News701 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(103, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("News701 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(103, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("News701 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(103, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tema"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("News701 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(103, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Autor"
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Location = New System.Drawing.Point(221, 303)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 60
        Me.BtnEditar.Text = "Actualizar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Location = New System.Drawing.Point(136, 334)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 59
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Location = New System.Drawing.Point(52, 303)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 58
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'DGViewdatos
        '
        Me.DGViewdatos.AllowUserToAddRows = False
        Me.DGViewdatos.AllowUserToDeleteRows = False
        Me.DGViewdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DGViewdatos.Location = New System.Drawing.Point(317, 176)
        Me.DGViewdatos.Name = "DGViewdatos"
        Me.DGViewdatos.ReadOnly = True
        Me.DGViewdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewdatos.Size = New System.Drawing.Size(537, 181)
        Me.DGViewdatos.TabIndex = 61
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(366, 154)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.Text = "Eliminar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CBoxBusqueda
        '
        Me.CBoxBusqueda.FormattingEnabled = True
        Me.CBoxBusqueda.Items.AddRange(New Object() {"Titulo", "Precio", "Tema", "Autor"})
        Me.CBoxBusqueda.Location = New System.Drawing.Point(733, 102)
        Me.CBoxBusqueda.Name = "CBoxBusqueda"
        Me.CBoxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.CBoxBusqueda.TabIndex = 63
        Me.CBoxBusqueda.Text = "Seleccionar"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(692, 129)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(172, 20)
        Me.TxtBusqueda.TabIndex = 64
        '
        'Txt_numReferencia
        '
        Me.Txt_numReferencia.Location = New System.Drawing.Point(167, 46)
        Me.Txt_numReferencia.Name = "Txt_numReferencia"
        Me.Txt_numReferencia.Size = New System.Drawing.Size(144, 20)
        Me.Txt_numReferencia.TabIndex = 65
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Location = New System.Drawing.Point(521, 274)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(107, 13)
        Me.msg.TabIndex = 70
        Me.msg.TabStop = True
        Me.msg.Text = "No se encontro libros"
        Me.msg.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(807, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 24)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(167, 80)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(144, 20)
        Me.TxtTitulo.TabIndex = 72
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(167, 116)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(144, 20)
        Me.TxtPrecio.TabIndex = 73
        '
        'TxtTema
        '
        Me.TxtTema.Location = New System.Drawing.Point(167, 151)
        Me.TxtTema.Name = "TxtTema"
        Me.TxtTema.Size = New System.Drawing.Size(144, 20)
        Me.TxtTema.TabIndex = 74
        '
        'TxtAutor
        '
        Me.TxtAutor.Location = New System.Drawing.Point(167, 181)
        Me.TxtAutor.Name = "TxtAutor"
        Me.TxtAutor.Size = New System.Drawing.Size(144, 20)
        Me.TxtAutor.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Centaur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(350, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 36)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Regirstro de Libros"
        '
        'frm_libros1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examen.My.Resources.Resources.Captura_de_pantalla__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 400)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtAutor)
        Me.Controls.Add(Me.TxtTema)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.Txt_numReferencia)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CBoxBusqueda)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DGViewdatos)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frm_libros1"
        Me.Text = "frm_libros1"
        CType(Me.DGViewdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents DGViewdatos As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CBoxBusqueda As ComboBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Txt_numReferencia As TextBox
    Friend WithEvents msg As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtAutor As TextBox
    Friend WithEvents TxtTema As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
