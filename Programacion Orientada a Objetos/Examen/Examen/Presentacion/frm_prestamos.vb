Imports System.ComponentModel
'c)CLASES
Public Class frm_prestamos
    Private Sub ocultar_columnas()
        DGViewDatos.Columns(1).Visible = False
    End Sub
    Private dt As New DataTable
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = CBoxBusqueda.Text & "like '" & TxtBusqueda.Text & "%'"
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
    Private Sub mostrar()
        Try
            Dim func As New fprestamos
            dt = func.mostrar1()
            DGViewDatos.Columns.Item("Eliminar").Visible = True
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
        TxtNumCarnet.Clear()
        TxtNifBibliotecarios.Clear()
        TxtNumReferencia.Clear()
        TxtFecha.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Menu.Visible = True
        Frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub frm_prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        msg.Visible = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Me.ValidateChildren = True And TxtNumCarnet.Text <> "" And TxtNifBibliotecarios.Text <> "" And TxtNumReferencia.Text <> "" And TxtFecha.Text Then
            Try
                Dim dts As New Dprestamos
                Dim func As New fprestamos
                dts.m_num_carnet_lectores = TxtNumCarnet.Text
                dts.m_nif_bibliotecarios = TxtNifBibliotecarios.Text
                dts.m_num_referencia = TxtNumReferencia.Text
                dts.m_fecha = TxtFecha.Text

                If func.insertar(dts) Then
                    MessageBox.Show("El prestamo fue registrado con exito", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("El Prestamo No Fue Registrado, Intentelo de Nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim equivocacion As DialogResult
        equivocacion = MessageBox.Show("¿Realmete quieres Eliminar los campos?", "Modificacion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If equivocacion = DialogResult.OK Then
            'se van a verficar que los textbox no esten vacias, antes de guardar
            If Me.ValidateChildren = True And TxtNumCarnet.Text <> "" And TxtNifBibliotecarios.Text <> "" And TxtNumReferencia.Text <> "" And TxtFecha.Text <> "" Then
                Try
                    Dim dts As New Dprestamos
                    Dim func As New fprestamos
                    'enviamos los datos
                    dts.m_num_carnet_lectores = TxtNumCarnet.Text
                    dts.m_nif_bibliotecarios = TxtNifBibliotecarios.Text
                    dts.m_num_referencia = TxtNumReferencia.Text
                    dts.m_fecha = TxtFecha.Text


                    If func.Eliminar(dts) Then
                        MessageBox.Show("Prestamo modificado", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se modifico el prestamo, intentelo de nuevo", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Se Editaran los Datos del Prestamo. ¿Desea Continuar?", "Modificando Registros...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'Con esta condicion me aseguro que los campos esten llenos, para poder editarlos. Las comillas indican que hay algo en el cuadro de texto de cada campo.
            If Me.ValidateChildren = True And TxtNumCarnet.Text <> "" And TxtNifBibliotecarios.Text <> "" And TxtNumReferencia.Text <> "" And TxtFecha.Text <> "" Then
                Try
                    Dim dts As New Dprestamos
                    Dim func As New fprestamos
                    dts.m_num_carnet_lectores = TxtNumCarnet.Text
                    dts.m_nif_bibliotecarios = TxtNifBibliotecarios.Text
                    dts.m_num_referencia = TxtNumReferencia.Text
                    dts.m_fecha = TxtFecha.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Prestamo Modificado Exitosamente", "Modificando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El Prestamo No Fue Modificado, Intentelo de Nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If e.ColumnIndex = Me.DGViewDatos.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DGViewDatos.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub DGViewDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewDatos.CellClick
        TxtNumCarnet.Text = DGViewDatos.SelectedCells.Item(1).Value
        TxtNifBibliotecarios.Text = DGViewDatos.SelectedCells.Item(2).Value
        TxtNumReferencia.Text = DGViewDatos.SelectedCells.Item(3).Value
        TxtFecha.Text = DGViewDatos.SelectedCells.Item(4).Value
        BtnEditar.Visible = True
        BtnSave.Visible = False
    End Sub

    Private Sub TxtNumCarnet_TextChanged(sender As Object, e As EventArgs) Handles TxtNumCarnet.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtNifBibliotecarios_TextChanged(sender As Object, e As EventArgs) Handles TxtNifBibliotecarios.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtNumReferencia_TextChanged(sender As Object, e As EventArgs) Handles TxtNumReferencia.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub TxtFecha_TextChanged(sender As Object, e As EventArgs) Handles TxtFecha.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub ChkBoxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxEliminar.CheckedChanged
        If ChkBoxEliminar.CheckState = CheckState.Checked Then
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        Else
            DGViewDatos.Columns.Item("Eliminar").Visible = True
        End If
        If ChkBoxEliminar.CheckState = CheckState.Unchecked Then
            BtnSave.Visible = True
        End If
    End Sub

    Private Sub CBoxBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBusqueda.SelectedIndexChanged

    End Sub
End Class

