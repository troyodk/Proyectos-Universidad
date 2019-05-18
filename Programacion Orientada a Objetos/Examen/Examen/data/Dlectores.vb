'c)CLASES
Public Class Dlectores
    Dim num_carnet As Integer
    Dim nombre, apellidos, domicilio, edad As String
    'c)ENCAPSULAMIENTO
    Public Property M_numCarnet1
        Get
            Return num_carnet
        End Get
        Set(value)
            num_carnet = value
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

    Public Property m_edad
        Get
            Return edad
        End Get
        Set(value)
            edad = value
        End Set
    End Property

    'Contructor por defecto o vacio
    Public Sub New()

    End Sub

    'd)CONSTRUCTOR 
    Public Sub New(num_carnet As Integer, nombre As String, apellidos As String, domicilio As String, edad As String)
        M_numCarnet1 = num_carnet
        m_nombre = nombre
        m_apellidos = apellidos
        m_domicilio = domicilio
        m_edad = edad
    End Sub
End Class
