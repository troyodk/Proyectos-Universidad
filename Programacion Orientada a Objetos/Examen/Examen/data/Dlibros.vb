'c)CLASES
Public Class Dlibros
    Dim num_referencia As Integer
    Dim titulo, precio, tema, autor As String
    'b)ENCAPSULAMIENTO
    Public Property m_num_referencia
        Get
            Return num_referencia
        End Get
        Set(value)
            num_referencia = value
        End Set
    End Property
    Public Property m_titulo
        Get
            Return titulo
        End Get
        Set(value)
            titulo = value
        End Set
    End Property
    Public Property m_precio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property
    Public Property m_tema
        Get
            Return tema
        End Get
        Set(value)
            tema = value
        End Set
    End Property
    Public Property m_autor
        Get
            Return autor
        End Get
        Set(value)
            autor = value
        End Set
    End Property
    'Contructor por defecto o vacio
    Public Sub New()

    End Sub
    'd)CONSTRUCTOR 
    Public Sub New(num_referencia As Integer, titulo As String, precio As String, tema As String, autor As String)
        m_num_referencia = num_referencia
        m_titulo = titulo
        m_precio = precio
        m_tema = tema
        m_autor = autor
    End Sub
End Class
