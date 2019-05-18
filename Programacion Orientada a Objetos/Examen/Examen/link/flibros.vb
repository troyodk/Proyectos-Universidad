Imports System.Data.SqlClient
'c)CLASES
Public Class flibros
    'a)HERENCIA
    Inherits conection
    Dim cmd As New SqlCommand
    'd)FUNCIONES
    Public Function insertar(ByVal dts As Dlibros) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("insertar_libros1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numReferencia", dts.m_num_referencia)
            cmd.Parameters.AddWithValue("@titulo", dts.m_titulo)
            cmd.Parameters.AddWithValue("@precio", dts.m_precio)
            cmd.Parameters.AddWithValue("@tema", dts.m_tema)
            cmd.Parameters.AddWithValue("@autor", dts.m_autor)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
        Return False
    End Function
    'd)FUNCIONES
    Public Function mostrar() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("mostrar_libros3")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
                da.Fill(dt)
                Return Nothing
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    'd)FUNCIONES
    Public Function editar(ByVal dts As Dlibros) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("editar_libros1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numReferencia", dts.m_num_referencia)
            cmd.Parameters.AddWithValue("@titulo", dts.m_titulo)
            cmd.Parameters.AddWithValue("@precio", dts.m_precio)
            cmd.Parameters.AddWithValue("@tema", dts.m_tema)
            cmd.Parameters.AddWithValue("@autor", dts.m_autor)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()

        End Try
        Return False
    End Function
    'd)FUNCIONES
    Public Function Eliminar(ByVal dts As Dlibros) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("eliminar_libros1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@numReferencia", SqlDbType.NVarChar, (50)).Value = dts.m_num_referencia
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'd)FUNCIONES
    Public Function mostrar1()
        Try
            conectar()
            cmd = New SqlCommand("mostrar_libros3")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                'correcion falto cmd
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                'correccion, debe de estar dt
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try


    End Function
End Class
