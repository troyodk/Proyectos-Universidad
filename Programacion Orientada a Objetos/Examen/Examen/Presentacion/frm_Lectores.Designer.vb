<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Lectores
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNum_carnet = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBoxBuscar = New System.Windows.Forms.ComboBox()
        Me.ChkBoxBorrar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGViewDatos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.msg = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Centaur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(453, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 36)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Regirstro de Usuarios"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(627, 202)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(203, 20)
        Me.TxtBusqueda.TabIndex = 38
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Location = New System.Drawing.Point(264, 299)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 37
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Location = New System.Drawing.Point(179, 330)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 36
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(95, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(148, 205)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(201, 20)
        Me.TxtAge.TabIndex = 33
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(147, 167)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(201, 20)
        Me.TxtDomicilio.TabIndex = 32
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(148, 133)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(201, 20)
        Me.TxtApellidos.TabIndex = 31
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(148, 94)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(201, 20)
        Me.TxtNombre.TabIndex = 30
        '
        'TxtNum_carnet
        '
        Me.TxtNum_carnet.Location = New System.Drawing.Point(149, 57)
        Me.TxtNum_carnet.Name = "TxtNum_carnet"
        Me.TxtNum_carnet.Size = New System.Drawing.Size(201, 20)
        Me.TxtNum_carnet.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(62, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(62, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(62, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(62, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre"
        '
        'CBoxBuscar
        '
        Me.CBoxBuscar.FormattingEnabled = True
        Me.CBoxBuscar.Items.AddRange(New Object() {"Nombre", "Apellidos", "Domicilio", "Edad"})
        Me.CBoxBuscar.Location = New System.Drawing.Point(709, 175)
        Me.CBoxBuscar.Name = "CBoxBuscar"
        Me.CBoxBuscar.Size = New System.Drawing.Size(121, 21)
        Me.CBoxBuscar.TabIndex = 23
        Me.CBoxBuscar.Text = "Busqueda "
        '
        'ChkBoxBorrar
        '
        Me.ChkBoxBorrar.AutoSize = True
        Me.ChkBoxBorrar.Location = New System.Drawing.Point(421, 208)
        Me.ChkBoxBorrar.Name = "ChkBoxBorrar"
        Me.ChkBoxBorrar.Size = New System.Drawing.Size(62, 17)
        Me.ChkBoxBorrar.TabIndex = 22
        Me.ChkBoxBorrar.Text = "Eliminar"
        Me.ChkBoxBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(62, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Id_Lector"
        '
        'DGViewDatos
        '
        Me.DGViewDatos.AllowUserToAddRows = False
        Me.DGViewDatos.AllowUserToDeleteRows = False
        Me.DGViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DGViewDatos.Location = New System.Drawing.Point(357, 228)
        Me.DGViewDatos.Name = "DGViewDatos"
        Me.DGViewDatos.ReadOnly = True
        Me.DGViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewDatos.Size = New System.Drawing.Size(512, 145)
        Me.DGViewDatos.TabIndex = 40
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Location = New System.Drawing.Point(552, 299)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(147, 13)
        Me.msg.TabIndex = 41
        Me.msg.TabStop = True
        Me.msg.Text = "No se han mostrado resultaos"
        Me.msg.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(783, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 24)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Lectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examen.My.Resources.Resources._15749066_771729296298284_527990391_o
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.DGViewDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtNum_carnet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBoxBuscar)
        Me.Controls.Add(Me.ChkBoxBorrar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frm_Lectores"
        Me.Text = "frm_Lectores"
        CType(Me.DGViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNum_carnet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBoxBuscar As ComboBox
    Friend WithEvents ChkBoxBorrar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGViewDatos As DataGridView
    Friend WithEvents msg As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
End Class
