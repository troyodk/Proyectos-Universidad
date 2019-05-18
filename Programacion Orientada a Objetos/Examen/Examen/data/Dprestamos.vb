'c)CLASES
Public Class Dprestamos
    Dim num_carnet_lectores, nif_bibliotecarios, num_referencia As Integer
    Dim fecha As String
    'b)ENCAPSULAMIENTO
    Public Property m_num_carnet_lectores
        Get
            Return num_carnet_lectores
        End Get
        Set(value)
            num_carnet_lectores = value
        End Set
    End Property
    Public Property m_nif_bibliotecarios
        Get
            Return nif_bibliotecarios
        End Get
        Set(value)
            nif_bibliotecarios = value
        End Set
    End Property
    Public Property m_num_referencia
        Get
            Return num_referencia
        End Get
        Set(value)
            num_referencia = value
        End Set
    End Property
    Public Property m_fecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
    'Contructor por defecto o vacio
    Public Sub New()

    End Sub
    'd)CONSTRUCTOR 
    Public Sub New(num_carnet_lectores As Integer, nif_bibliotecarios As Integer, num_referencia As Integer, fecha As String)
        m_num_carnet_lectores = num_carnet_lectores
        m_nif_bibliotecarios = nif_bibliotecarios
        m_num_referencia = num_referencia
        m_fecha = fecha
    End Sub
End Class
