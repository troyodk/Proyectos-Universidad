<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_prestamos
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGViewDatos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CBoxBusqueda = New System.Windows.Forms.ComboBox()
        Me.ChkBoxEliminar = New System.Windows.Forms.CheckBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtNumReferencia = New System.Windows.Forms.TextBox()
        Me.TxtNifBibliotecarios = New System.Windows.Forms.TextBox()
        Me.TxtNumCarnet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.msg = New System.Windows.Forms.LinkLabel()
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(785, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 24)
        Me.Button4.TabIndex = 82
        Me.Button4.Text = "Menu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGViewDatos
        '
        Me.DGViewDatos.AllowUserToAddRows = False
        Me.DGViewDatos.AllowUserToDeleteRows = False
        Me.DGViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DGViewDatos.Location = New System.Drawing.Point(379, 215)
        Me.DGViewDatos.Name = "DGViewDatos"
        Me.DGViewDatos.ReadOnly = True
        Me.DGViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewDatos.Size = New System.Drawing.Size(461, 145)
        Me.DGViewDatos.TabIndex = 81
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Centaur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(536, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 36)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Regirstro de Prestamos"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(623, 184)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(203, 20)
        Me.TxtBusqueda.TabIndex = 79
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Location = New System.Drawing.Point(260, 281)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 78
        Me.BtnEditar.Text = "Actualizar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Location = New System.Drawing.Point(175, 312)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 77
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Location = New System.Drawing.Point(91, 281)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 76
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'CBoxBusqueda
        '
        Me.CBoxBusqueda.FormattingEnabled = True
        Me.CBoxBusqueda.Items.AddRange(New Object() {"Num_Carnet", "Nif_Bibliotecarios", "Num_referencia", "Fecha"})
        Me.CBoxBusqueda.Location = New System.Drawing.Point(705, 157)
        Me.CBoxBusqueda.Name = "CBoxBusqueda"
        Me.CBoxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.CBoxBusqueda.TabIndex = 64
        Me.CBoxBusqueda.Text = "Busqueda "
        '
        'ChkBoxEliminar
        '
        Me.ChkBoxEliminar.AutoSize = True
        Me.ChkBoxEliminar.Location = New System.Drawing.Point(430, 192)
        Me.ChkBoxEliminar.Name = "ChkBoxEliminar"
        Me.ChkBoxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.ChkBoxEliminar.TabIndex = 63
        Me.ChkBoxEliminar.Text = "Eliminar"
        Me.ChkBoxEliminar.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(192, 156)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(201, 20)
        Me.TxtFecha.TabIndex = 90
        '
        'TxtNumReferencia
        '
        Me.TxtNumReferencia.Location = New System.Drawing.Point(192, 125)
        Me.TxtNumReferencia.Name = "TxtNumReferencia"
        Me.TxtNumReferencia.Size = New System.Drawing.Size(201, 20)
        Me.TxtNumReferencia.TabIndex = 89
        '
        'TxtNifBibliotecarios
        '
        Me.TxtNifBibliotecarios.Location = New System.Drawing.Point(192, 86)
        Me.TxtNifBibliotecarios.Name = "TxtNifBibliotecarios"
        Me.TxtNifBibliotecarios.Size = New System.Drawing.Size(201, 20)
        Me.TxtNifBibliotecarios.TabIndex = 88
        '
        'TxtNumCarnet
        '
        Me.TxtNumCarnet.Location = New System.Drawing.Point(193, 49)
        Me.TxtNumCarnet.Name = "TxtNumCarnet"
        Me.TxtNumCarnet.Size = New System.Drawing.Size(201, 20)
        Me.TxtNumCarnet.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(137, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(59, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Num_Referencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(42, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Nif_Bibliotecarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(88, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Num_Carnet"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Location = New System.Drawing.Point(539, 281)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(126, 13)
        Me.msg.TabIndex = 91
        Me.msg.TabStop = True
        Me.msg.Text = "No se encontro prestamo"
        Me.msg.Visible = False
        '
        'frm_prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examen.My.Resources.Resources.a__11_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(883, 382)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtNumReferencia)
        Me.Controls.Add(Me.TxtNifBibliotecarios)
        Me.Controls.Add(Me.TxtNumCarnet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DGViewDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CBoxBusqueda)
        Me.Controls.Add(Me.ChkBoxEliminar)
        Me.Name = "frm_prestamos"
        Me.Text = "frm_prestamos"
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents DGViewDatos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CBoxBusqueda As ComboBox
    Friend WithEvents ChkBoxEliminar As CheckBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents TxtNumReferencia As TextBox
    Friend WithEvents TxtNifBibliotecarios As TextBox
    Friend WithEvents TxtNumCarnet As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents msg As LinkLabel
End Class
