Imports System.Data.SqlClient
'c)CLASES
Public Class fprestamos
    'a)HERENCIA
    Inherits conection
    Dim cmd As New SqlCommand
    'd)FUNCIONES
    Public Function insertar(ByVal dts As Dprestamos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("insertar_prestamos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numCarnet", dts.m_num_carnet_lectores)
            cmd.Parameters.AddWithValue("@nif", dts.m_nif_bibliotecarios)
            cmd.Parameters.AddWithValue("@numReferencia", dts.m_num_referencia)
            cmd.Parameters.AddWithValue("@fecha", dts.m_fecha)
            ' cmd.Parameters.AddWithValue("@autor", dts.m_autor)
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
    Public Function mostar() As DataTable
        Try
            conectar()
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
    Public Function editar(ByVal dts As Dprestamos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("editar_prestamo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numCarnetLecores", dts.m_num_carnet_lectores)
            cmd.Parameters.AddWithValue("@nifBibliotecarios", dts.m_nif_bibliotecarios)
            cmd.Parameters.AddWithValue("@numReferencia", dts.m_num_referencia)
            cmd.Parameters.AddWithValue("@fecha", dts.m_fecha)
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
    Public Function Eliminar(ByVal dts As Dprestamos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("eliminar_prestamos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'CON EL ID_CLIENTE ES CON EL CAMPO QUE ESTOY VALIDANDO PARA ELIMINAR ESE CAMPO
            cmd.Parameters.Add("@numCarnetLectores", SqlDbType.NVarChar, 50).Value = dts.m_num_carnet_lectores
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
            cmd = New SqlCommand("mostrar_prestamos")
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
