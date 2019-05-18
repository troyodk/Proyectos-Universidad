<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Bibliotecarios
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
        Me.DGViewDatos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboxBusqueda = New System.Windows.Forms.ComboBox()
        Me.ChkBoxEliminar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.msg = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGViewDatos
        '
        Me.DGViewDatos.AllowUserToAddRows = False
        Me.DGViewDatos.AllowUserToDeleteRows = False
        Me.DGViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DGViewDatos.Location = New System.Drawing.Point(372, 209)
        Me.DGViewDatos.Name = "DGViewDatos"
        Me.DGViewDatos.ReadOnly = True
        Me.DGViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewDatos.Size = New System.Drawing.Size(468, 145)
        Me.DGViewDatos.TabIndex = 60
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
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(489, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 36)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Regirstro de Bibliotecarios"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(623, 178)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(203, 20)
        Me.TxtBusqueda.TabIndex = 58
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Location = New System.Drawing.Point(260, 275)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 57
        Me.BtnEditar.Text = "Actualizar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Location = New System.Drawing.Point(175, 306)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 56
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Location = New System.Drawing.Point(91, 275)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 55
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(162, 140)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(201, 20)
        Me.TxtDomicilio.TabIndex = 52
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(162, 109)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(201, 20)
        Me.TxtApellidos.TabIndex = 51
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(162, 70)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(201, 20)
        Me.TxtNombre.TabIndex = 50
        '
        'TxtNif
        '
        Me.TxtNif.Location = New System.Drawing.Point(163, 33)
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.Size = New System.Drawing.Size(201, 20)
        Me.TxtNif.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(77, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(82, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(95, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre"
        '
        'CboxBusqueda
        '
        Me.CboxBusqueda.FormattingEnabled = True
        Me.CboxBusqueda.Items.AddRange(New Object() {"Apellidos"})
        Me.CboxBusqueda.Location = New System.Drawing.Point(705, 151)
        Me.CboxBusqueda.Name = "CboxBusqueda"
        Me.CboxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.CboxBusqueda.TabIndex = 43
        Me.CboxBusqueda.Text = "Busqueda "
        '
        'ChkBoxEliminar
        '
        Me.ChkBoxEliminar.AutoSize = True
        Me.ChkBoxEliminar.Location = New System.Drawing.Point(421, 186)
        Me.ChkBoxEliminar.Name = "ChkBoxEliminar"
        Me.ChkBoxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.ChkBoxEliminar.TabIndex = 42
        Me.ChkBoxEliminar.Text = "Eliminar"
        Me.ChkBoxEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(125, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nif"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(744, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 24)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "Menu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TxtCargo
        '
        Me.TxtCargo.Location = New System.Drawing.Point(163, 175)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(201, 20)
        Me.TxtCargo.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(108, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Cargo"
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Location = New System.Drawing.Point(607, 280)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(144, 13)
        Me.msg.TabIndex = 64
        Me.msg.TabStop = True
        Me.msg.Text = "No se encontro bibliotecarios"
        Me.msg.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frm_Bibliotecarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examen.My.Resources.Resources.tumblr_nx5phwWKIQ1spnyg9o1_500
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 397)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DGViewDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtNif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboxBusqueda)
        Me.Controls.Add(Me.ChkBoxEliminar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Bibliotecarios"
        Me.Text = "frm_Bibliotecarios"
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGViewDatos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNif As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboxBusqueda As ComboBox
    Friend WithEvents ChkBoxEliminar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents msg As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
