Imports System.Data.SqlClient
'c)CLASES
Public Class fbibliotecarios
    'a)HERENCIA
    Inherits conection
    Dim cmd As New SqlCommand
    'd)FUNCIONES

    Public Function insertar(ByVal dts As Dbiblotecarios) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("insertar_bibliotecarios1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nif", dts.m_nif)
            cmd.Parameters.AddWithValue("@nombre", dts.m_nombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.m_apellidos)
            cmd.Parameters.AddWithValue("@domicilio", dts.m_domicilio)
            cmd.Parameters.AddWithValue("@cargo", dts.m_cargo)
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
            cmd = New SqlCommand("mostrar_biblitecarios1")
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
    Public Function editar(ByVal dts As Dbiblotecarios) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("editar_bibliotecarios1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nif", dts.m_nif)
            cmd.Parameters.AddWithValue("@nombre", dts.m_nombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.m_apellidos)
            cmd.Parameters.AddWithValue("@domicilio", dts.m_domicilio)
            cmd.Parameters.AddWithValue("@cargo", dts.m_cargo)
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
    Public Function Eliminar(ByVal dts As Dbiblotecarios) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("eliminar_bibliotecarios1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'CON EL ID_CLIENTE ES CON EL CAMPO QUE ESTOY VALIDANDO PARA ELIMINAR ESE CAMPO
            cmd.Parameters.Add("@nif", SqlDbType.NVarChar, 50).Value = dts.m_nif
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
            cmd = New SqlCommand("mostrar_biblitecarios1")
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
