Public Class DataType

  Public Structure [String]
    Private N As String
    Private V As String
    Private S As Boolean
    Private isNull As Boolean

    Public Property Name() As String
      Get
        Return N
      End Get
      Set(ByVal value As String)
        N = value
      End Set
    End Property

    Public Property Value() As String
      Get
        Return V
      End Get
      Set(ByVal value As String)
        isNull = False
        If value = dbNull.ToString Then isNull = True
        V = value
        S = True
      End Set
    End Property

    Public Property isDBNull() As Boolean
      Get
        Return isNull
      End Get
      Set(ByVal value As Boolean)
        isNull = value
        S = True
      End Set
    End Property

    Public ReadOnly Property isSet() As Boolean
      Get
        Return S
      End Get
    End Property

    Public Sub Reset()
      S = False
      isNull = False
    End Sub

    Public Shared ReadOnly Property dbNull() As Double
      Get
        Return Double.MinValue
      End Get
    End Property

  End Structure

  Public Structure [Integer]
    Private N As String
    Private V As Integer
    Private S As Boolean
    Private isNull As Boolean

    Public Property Name() As String
      Get
        Return N
      End Get
      Set(ByVal value As String)
        N = value
      End Set
    End Property

    Public Property Value() As Integer
      Get
        Return V
      End Get
      Set(ByVal value As Integer)
        isNull = False
        If value = dbNull Then isNull = True
        V = value
        S = True
      End Set
    End Property

    Public Property isDBNull() As Boolean
      Get
        Return isNull
      End Get
      Set(ByVal value As Boolean)
        isNull = value
        S = True
      End Set
    End Property

    Public ReadOnly Property isSet() As Boolean
      Get
        Return S
      End Get
    End Property

    Public Sub Reset()
      S = False
      isNull = False
    End Sub

    Public Shared ReadOnly Property dbNull() As Integer
      Get
        Return Integer.MinValue
      End Get
    End Property
  End Structure

  Public Structure [Long]
    Private N As String
    Private V As Long
    Private S As Boolean
    Private isNull As Boolean

    Public Property Name() As String
      Get
        Return N
      End Get
      Set(ByVal value As String)
        N = value
      End Set
    End Property

    Public Property Value() As Long
      Get
        Return V
      End Get
      Set(ByVal value As Long)
        isNull = False
        If value = dbNull Then isNull = True
        V = value
        S = True
      End Set
    End Property

    Public Property isDBNull() As Boolean
      Get
        Return isNull
      End Get
      Set(ByVal value As Boolean)
        isNull = value
        S = True
      End Set
    End Property

    Public ReadOnly Property isSet() As Boolean
      Get
        Return S
      End Get
    End Property

    Public Sub Reset()
      S = False
      isNull = False
    End Sub

    Public Shared ReadOnly Property dbNull() As Long
      Get
        Return Long.MinValue
      End Get
    End Property
  End Structure

  Public Structure [Double]
    Private N As String
    Private V As Double
    Private S As Boolean
    Private isNull As Boolean

    Public Property Name() As String
      Get
        Return N
      End Get
      Set(ByVal value As String)
        N = value
      End Set
    End Property

    Public Property Value() As Double
      Get
        Return V
      End Get
      Set(ByVal value As Double)
        isNull = False
        If value = dbNull Then isNull = True
        V = value
        S = True
      End Set
    End Property

    Public Property isDBNull() As Boolean
      Get
        Return isNull
      End Get
      Set(ByVal value As Boolean)
        isNull = value
        S = True
      End Set
    End Property

    Public ReadOnly Property isSet() As Boolean
      Get
        Return S
      End Get
    End Property

    Public Sub Reset()
      S = False
      isNull = False
    End Sub

    Public Shared ReadOnly Property dbNull() As Double
      Get
        Return Double.MinValue
      End Get
    End Property

  End Structure

  Public Structure [Image]
    Private N As String
    Private V As Byte()
    Private S As Boolean
    Private isNull As Boolean

    Public Property Name() As String
      Get
        Return N
      End Get
      Set(ByVal value As String)
        N = value
      End Set
    End Property

    Public Property Value() As Byte()
      Get
        Return V
      End Get
      Set(ByVal value As Byte())
        V = value
        S = True
      End Set
    End Property

    Public Property isDBNull() As Boolean
      Get
        Return isNull
      End Get
      Set(ByVal value As Boolean)
        isNull = value
        S = True
      End Set
    End Property

    Public ReadOnly Property isSet() As Boolean
      Get
        Return S
      End Get
    End Property

    Public Sub Reset()
      S = False
      isNull = False
    End Sub
  End Structure

End Class
