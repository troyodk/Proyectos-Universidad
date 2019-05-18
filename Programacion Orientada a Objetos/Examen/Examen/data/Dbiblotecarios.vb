'c)CLASES
Public Class Dbiblotecarios
    Dim nif As Integer
    Dim nombre, apellidos, domicilio, cargo As String
    'b)ENCAPSULAMIENTO
    Public Property m_nif
        Get
            Return nif
        End Get
        Set(value)
            nif = value
        End Set
    End Property
    Public Property m_nombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property m_apellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property
    Public Property m_domicilio
        Get
            Return domicilio
        End Get
        Set(value)
            domicilio = value
        End Set
    End Property
    Public Property m_cargo
        Get
            Return cargo
        End Get
        Set(value)
            cargo = value
        End Set
    End Property
    'Contructor por defecto o vacio
    Public Sub New()

    End Sub
    'd)CONSTRUCTOR 
    Public Sub New(nif As Integer, nombre As String, apellidos As String, cargo As String)
        m_nif = nif
        m_nombre = nombre
        m_apellidos = apellidos
        m_cargo = cargo
    End Sub
End Class
