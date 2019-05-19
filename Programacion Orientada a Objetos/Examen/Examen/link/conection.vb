Imports System.Data.SqlClient
'c)CLASES
Public Class conection
    Protected cnn As New SqlConnection
    'd)FUNCIONES
    Protected Function conectar()
        Try
            'cnn.ConnectionString = ("server=LAPTOP-OVERLORD;database=Examen_library;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
    'd)FUNCIONES
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
