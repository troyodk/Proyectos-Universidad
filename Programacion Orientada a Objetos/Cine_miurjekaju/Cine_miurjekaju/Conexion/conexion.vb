Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As SqlConnection

    Protected Function conectar()
        Try
            cnn.ConnectionString = ("server=LAPTOP-OVERLORD;database=examencine;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
