Imports System.ComponentModel
'c)CLASES
Public Class frm_libros1

    Private Sub ocultar_columnas()
        DGViewdatos.Columns(1).Visible = False
    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt1.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = CBoxBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"
            If dv.Count <> 0 Then
                msg.Visible = False
                DGViewdatos.DataSource = dv
                ocultar_columnas()
            Else
                msg.Visible = True
                DGViewdatos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private dt1 As New DataTable
    Private Sub mostrar()
        'no pos esta madre te sirve pa ya sabes el data grid y eso 
        Try
            Dim func As New flibros
            dt1 = func.mostrar1()
            DGViewdatos.Columns.Item("Eliminar").Visible = True
            'se agrega una condicion para saber si el numero de filas es diferente a ciro
            'se muestran los resultados y se meten a dt 
            If dt1.Rows.Count <> 0 Then
                DGViewdatos.DataSource = dt1
                DGViewdatos.ColumnHeadersVisible = False
                msg.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub limpiar()
        Txt_numReferencia.Clear()
        TxtTitulo.Clear()
        TxtPrecio.Clear()
        TxtTema.Clear()
        TxtAutor.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.ValidateChildren = True And TxtTitulo.Text <> "" And TxtPrecio.Text <> "" And TxtTema.Text <> "" And TxtAutor.Text <> "" Then
            Try
                Dim dts As New Dlibros
                Dim func As New flibros
                dts.m_num_referencia = Txt_numReferencia.Text
                dts.m_titulo = TxtTitulo.Text
                dts.m_precio = TxtPrecio.Text
                dts.m_tema = TxtTema.Text
                dts.m_autor = TxtAutor.Text

                If func.insertar(dts) Then
                    MessageBox.Show("El libro fue registrado con exito", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Libro No Fue Registrado, Intentelo de Nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    'Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
    '    Dim result As DialogResult
    '    result = MessageBox.Show("Desea Realmemte Eliminar los lectores Seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If result = DialogResult.OK Then
    '        Try
    '            'Aqui simplemente hace un conteo de las columnas, para saber cuantas se deben eliminar 
    '            For Each row As DataGridViewRow In DGViewdatos.Rows
    '                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
    '                If marcado Then
    '                    Dim onekey As Integer = Convert.ToInt32(row.Cells("num_referencia").Value)
    '                    Dim vdb As New Dlibros
    '                    Dim func As New flibros
    '                    vdb.m_num_referencia = onekey
    '                    If func.Eliminar(vdb) Then
    '                    Else
    '                        MessageBox.Show("El libro No Fue Eliminado", "Eliminando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End If
    '                End If
    '            Next
    '            Call mostrar()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Cancelando Eliminacion de Registros", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call mostrar()
    '    End If
    '    Call limpiar()
    'End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim equivocacion As DialogResult
        equivocacion = MessageBox.Show("¿Realmete quieres Eliminar los campos?", "Modificacion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If equivocacion = DialogResult.OK Then
            'se van a verficar que los textbox no esten vacias, antes de guardar
            If Me.ValidateChildren = True And Txt_numReferencia.Text <> "" And TxtTitulo.Text <> "" And TxtPrecio.Text <> "" And TxtTema.Text <> "" And TxtAutor.Text <> "" Then
                Try
                    Dim dts As New Dlibros
                    Dim func As New flibros
                    'enviamos los datos
                    dts.m_num_referencia = Txt_numReferencia.Text
                    dts.m_titulo = TxtTitulo.Text
                    dts.m_precio = TxtPrecio.Text
                    dts.m_tema = TxtTema.Text
                    dts.m_autor = TxtAutor.Text


                    If func.Eliminar(dts) Then
                        MessageBox.Show("Libro modificado", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se modifico libro, intentelo de nuevo", "Modificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Se Editaran los Datos del libro. ¿Desea Continuar?", "Modificando Registros...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'Con esta condicion me aseguro que los campos esten llenos, para poder editarlos. Las comillas indican que hay algo en el cuadro de texto de cada campo.
            If Me.ValidateChildren = True And TxtTitulo.Text <> "" And TxtPrecio.Text <> "" And TxtTema.Text <> "" And TxtAutor.Text <> "" And Txt_numReferencia.Text <> "" Then
                Try
                    Dim dts As New Dlibros
                    Dim func As New flibros
                    dts.m_num_referencia = Txt_numReferencia.Text
                    dts.m_titulo = TxtTitulo.Text
                    dts.m_precio = TxtPrecio.Text
                    dts.m_tema = TxtTema.Text
                    dts.m_autor = TxtAutor.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Libro Modificado Exitosamente", "Modificando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("libro No Fue Modificado, Intentelo de Nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub DGViewDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewdatos.CellContentClick

        'Con esta instruccion lo unico que se busca es que muestre un CheckBox, 
        'para poder eliminar los registros que el usuario desea eliminar.
        If e.ColumnIndex = Me.DGViewdatos.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DGViewdatos.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub DGViewDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGViewdatos.CellClick
        'Nuevo 
        'con esto solo asigno el posicionamiento de donde estara cada dato 
        'dentro del Data Gried 
        Txt_numReferencia.Text = DGViewdatos.SelectedCells.Item(1).Value
        TxtTitulo.Text = DGViewdatos.SelectedCells.Item(2).Value
        TxtPrecio.Text = DGViewdatos.SelectedCells.Item(3).Value
        TxtTema.Text = DGViewdatos.SelectedCells.Item(4).Value
        TxtAutor.Text = DGViewdatos.SelectedCells.Item(5).Value
        BtnEditar.Visible = True
        btnSave.Visible = False
    End Sub

    Private Sub Txt_numReferencia_TextChanged(sender As Object, e As EventArgs) Handles Txt_numReferencia.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub msg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles msg.LinkClicked
        msg.Visible = False
    End Sub

    Private Sub ChkBoxBorrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            DGViewdatos.Columns.Item("Eliminar").Visible = True
        Else
            DGViewdatos.Columns.Item("Eliminar").Visible = True
        End If
        If CheckBox1.CheckState = CheckState.Unchecked Then
            BtnSave.Visible = True
        End If
    End Sub
    Private Sub frm_libros1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        msg.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Menu.Visible = True
        Frm_Menu.Show()
        Me.Close()
    End Sub
    Private Sub TxtTitulo_TextChanged(sender As Object, e As EventArgs) Handles TxtTitulo.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub
    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub
    Private Sub TxtTema_TextChanged(sender As Object, e As EventArgs) Handles TxtTema.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub
    Private Sub TxtAutor_TextChanged(sender As Object, e As EventArgs) Handles TxtAutor.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese, un valor(Campo Obligatorio)")
        End If
    End Sub

    Private Sub CBoxBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBusqueda.SelectedIndexChanged

    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub
End Class