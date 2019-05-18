Public Class dLogin
    Dim usuario As String = "marty"


    Public Property mUsuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Public Property mContrasena
        Get
            Return contrasena
        End Get
        Set(value)
            contrasena = value
        End Set
    End Property

    Public Function login_acceso(ByVal text1 As String, ByVal text2 As String) As Boolean
        'falta la funcion
    End Function
    Public Sub New()

    End Sub
    Public Sub New(usuario As String, contraseña As String)
        mUsuario = usuario
        mContraseña = contraseña
    End Sub
End Class
