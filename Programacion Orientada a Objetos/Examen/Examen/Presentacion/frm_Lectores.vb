Imports System.ComponentModel
'c)CLASES
Public Class frm_Lectores

    Private Sub ocultar_columnas()
        DGViewDatos.Columns(1).Visible = False

    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = CBoxBuscar.Text & " like '" & TxtBusqueda.Text & "%'"
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
            Dim func As New flectores
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
        TxtNum_carnet.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
        TxtDomicilio.Clear()
        TxtAge.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtAge.Text Then
            Try
                Dim dts As New Dlectores
                Dim func As New flectores
                dts.M_numCarnet1 = TxtNum_carnet.Text
                dts.m_nombre = TxtNombre.Text
                dts.m_apellidos = TxtApellidos.Text
                dts.m_domicilio = TxtDomicilio.Text
                dts.m_edad = TxtAge.Text

                If func.insertar(dts) Then
                    MessageBox.Show("El lector fue registrado con exito", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Lector No Fue Registrado, Intentelo de Nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub frm_Lectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        DGViewDatos.Columns(1).Visible = False
        DGViewDatos.Columns(2).Visible = True
        DGViewDatos.Columns(3).Visible = False
        DGViewDatos.Columns(4).Visible = True
        DGViewDatos.Columns(5).Visible = False
        msg.Visible = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim equivocacion As DialogResult
        equivocacion = MessageBox.Show("¿Realmete quieres Eliminar los campos?", "Modificacion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If equivocacion = DialogResult.OK Then
            'se van a verficar que los textbox no esten vacias, antes de guardar
            If Me.ValidateChildren = True And TxtNum_carnet.Text <> "" And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtAge.Text <> "" Then
                Try
                    Dim dts As New Dlectores
                    Dim func As New flectores
                    'enviamos los datos
                    dts.M_numCarnet1 = TxtNum_carnet.Text
                    dts.m_nombre = TxtNombre.Text
                    dts.m_apellidos = TxtApellidos.Text
                    dts.m_domicilio = TxtDomicilio.Text
                    dts.m_edad = TxtAge.Text


                    If func.Eliminar(dts) Then
                        MessageBox.Show("Lector modificado", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se modifico lectorer, intentelo de nuevo", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Se Editaran los Datos del Lector. ¿Desea Continuar?", "Modificando Registros...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'Con esta condicion me aseguro que los campos esten llenos, para poder editarlos. Las comillas indican que hay algo en el cuadro de texto de cada campo.
            If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtApellidos.Text <> "" And TxtDomicilio.Text <> "" And TxtAge.Text <> "" And TxtNum_carnet.Text <> "" Then
                Try
                    Dim dts As New Dlectores
                    Dim func As New flectores
                    dts.M_numCarnet1 = TxtNum_carnet.Text
                    dts.m_nombre = TxtNombre.Text
                    dts.m_apellidos = TxtApellidos.Text
                    dts.m_domicilio = TxtDomicilio.Text
                    dts.m_edad = TxtAge.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Lector Modificado Exitosamente", "Modificando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Lector No Fue Modificado, Intentelo de Nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        TxtNum_carnet.Text = DGViewDatos.SelectedCells.Item(1).Value
        TxtNombre.Text = DGViewDatos.SelectedCells.Item(2).Value
        TxtApellidos.Text = DGViewDatos.SelectedCells.Item(3).Value
        TxtDomicilio.Text = DGViewDatos.SelectedCells.Item(4).Value
        TxtAge.Text = DGViewDatos.SelectedCells.Item(5).Value
        BtnEditar.Visible = True
        btnSave.Visible = False
    End Sub

    Private Sub TxtIDlector_TextChanged(sender As Object, e As EventArgs) Handles TxtNum_carnet.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
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

    Private Sub TxtAge_TextChanged(sender As Object, e As EventArgs) Handles TxtAge.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub msg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles msg.LinkClicked
        msg.Visible = False
    End Sub

    Private Sub ChkBoxBorrar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxBorrar.CheckedChanged
        If ChkBoxBorrar.CheckState = CheckState.Checked Then
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        Else
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        End If
        If ChkBoxBorrar.CheckState = CheckState.Unchecked Then
            btnSave.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Menu.Visible = True
        Frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub CBoxBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBuscar.SelectedIndexChanged

    End Sub
End Class