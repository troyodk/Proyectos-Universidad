Imports System.ComponentModel
'c)CLASES
Public Class frm_Bibliotecarios
    Private Sub ocultar_columnas()
        DGViewDatos.Columns(1).Visible = False
    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = CboxBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"
            If dv.Count <> 0 Then
                msg.Visible = False
                DGViewDatos.DataSource = dv
                ocultar_columnas()
            Else
                msg.Visible = True
                DGViewDatos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private dt As New DataTable
    Private Sub mostrar()
        'no pos esta madre te sirve pa ya sabes el data grid y eso 
        Try
            Dim func As New fbibliotecarios
            dt = func.mostrar1()
            DGViewDatos.Columns.Item("Eliminar").Visible = True
            'se agrega una condicion para saber si el numero de filas es diferente a ciro
            'se muestran los resultados y se meten a dt 
            If dt.Rows.Count <> 0 Then
                DGViewDatos.DataSource = dt
                DGViewDatos.ColumnHeadersVisible = False
                msg.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub limpiar()
        TxtNif.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
        TxtDomicilio.Clear()
        TxtCargo.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtCargo.Text Then
            Try
                Dim dts As New Dbiblotecarios
                Dim func As New fbibliotecarios
                dts.m_nif = TxtNif.Text
                dts.m_nombre = TxtNombre.Text
                dts.m_apellidos = TxtApellidos.Text
                dts.m_domicilio = TxtDomicilio.Text
                dts.m_cargo = TxtCargo.Text

                If func.insertar(dts) Then
                    MessageBox.Show("El Bibliotecario fue registrado con exito", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Bibliotecario No Fue Registrado, Intentelo de Nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta Ingresar algún dato", "Guardando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub frm_Bibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        msg.Visible = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim equivocacion As DialogResult
        equivocacion = MessageBox.Show("¿Realmete quieres eliminar los campos?", "Eliminacion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If equivocacion = DialogResult.OK Then
            'se van a verficar que los textbox no esten vacias, antes de guardar
            If Me.ValidateChildren = True And TxtNif.Text <> "" And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtCargo.Text <> "" Then
                Try
                    Dim dts As New Dbiblotecarios
                    Dim func As New fbibliotecarios
                    'enviamos los datos
                    dts.m_nif = TxtNif.Text
                    dts.m_nombre = TxtNombre.Text
                    dts.m_apellidos = TxtApellidos.Text
                    dts.m_domicilio = TxtDomicilio.Text
                    dts.m_cargo = TxtCargo.Text


                    If func.Eliminar(dts) Then
                        MessageBox.Show("Bibliotecarios modificado", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se modifico bibliotecarios, intentelo de nuevo", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'este else aplicara cuando se tengan cajas de texto vacias
            Else
                MessageBox.Show("Complete los datos por favor", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult
        'Se crea una variable que podria tomar los valores de la botonera del message box, si da click en aceptar, realizara el proceso que permitir editar
        'los campos que tiene la tabla de cliente
        result = MessageBox.Show("Se Editaran los Datos del Bibliotecarios. ¿Desea Continuar?", "Modificando Registros...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'Con esta condicion me aseguro que los campos esten llenos, para poder editarlos. Las comillas indican que hay algo en el cuadro de texto de cada campo.
            If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtCargo.Text <> "" And TxtNif.Text <> "" Then
                Try
                    Dim dts As New Dbiblotecarios
                    Dim func As New fbibliotecarios
                    dts.m_nif = TxtNif.Text
                    dts.m_nombre = TxtNombre.Text
                    dts.m_apellidos = TxtApellidos.Text
                    dts.m_domicilio = TxtDomicilio.Text
                    dts.m_cargo = TxtCargo.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Bibliotecario Modificado Exitosamente", "Modificando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El Bibliotecario No Fue Modificado, Intentelo de Nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta Ingresar Unos Datos", "Modificando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Buscar()
    End Sub

    Private Sub DGViewDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewDatos.CellContentClick

        'Con esta instruccion lo unico que se busca es quemuestre un CheckBox, 
        'para poder eliminar los registros que el usuario desea eliminar.
        If e.ColumnIndex = Me.DGViewDatos.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DGViewDatos.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub DGViewDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewDatos.CellClick
        'Nuevo 
        'con esto solo asigno el posicionamiento de donde estara cada dato 
        'dentro del Data Gried 
        TxtNif.Text = DGViewDatos.SelectedCells.Item(1).Value
        TxtNombre.Text = DGViewDatos.SelectedCells.Item(2).Value
        TxtApellidos.Text = DGViewDatos.SelectedCells.Item(3).Value
        TxtDomicilio.Text = DGViewDatos.SelectedCells.Item(4).Value
        TxtCargo.Text = DGViewDatos.SelectedCells.Item(5).Value
        BtnEditar.Visible = True
        BtnSave.Visible = False
    End Sub

    Private Sub TxtNif_TextChanged(sender As Object, e As EventArgs) Handles TxtNif.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidos.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtDomicilio_TextChanged(sender As Object, e As EventArgs) Handles TxtDomicilio.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtCargo_TextChanged(sender As Object, e As EventArgs) Handles TxtCargo.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub msg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles msg.LinkClicked
        msg.Visible = False
    End Sub

    Private Sub ChkBoxBorrar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxEliminar.CheckedChanged
        If ChkBoxEliminar.CheckState = CheckState.Checked Then
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        Else
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        End If
        If ChkBoxEliminar.CheckState = CheckState.Unchecked Then
            BtnSave.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Menu.Visible = True
        Frm_Menu.Show()
        Me.Close()
    End Sub

End Class