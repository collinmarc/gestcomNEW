Public Class MillesimeProduit
    Private _Millesime As String
    Public Property Millesime() As String
        Get
            Return _Millesime
        End Get
        Set(ByVal value As String)
            _Millesime = value
        End Set
    End Property
    Private _bDisponible As Boolean
    Public Property bDisponible() As Boolean
        Get
            Return _bDisponible
        End Get
        Set(ByVal value As Boolean)
            _bDisponible = value
        End Set
    End Property
    Private _bArchive As Boolean
    Public Property bArchive() As Boolean
        Get
            Return _bArchive
        End Get
        Set(ByVal value As Boolean)
            _bArchive = value
        End Set
    End Property
    Private _TarifA As Decimal
    Public Property TarifA() As Decimal
        Get
            Return _TarifA
        End Get
        Set(ByVal value As Decimal)
            _TarifA = value
        End Set
    End Property
    Private _TarifB As Decimal
    Public Property TarifB() As Decimal
        Get
            Return _TarifB
        End Get
        Set(ByVal value As Decimal)
            _TarifB = value
        End Set
    End Property
    Private _TarifC As Decimal
    Public Property TarifC() As Decimal
        Get
            Return _TarifC
        End Get
        Set(ByVal value As Decimal)
            _TarifC = value
        End Set
    End Property
    Private _TarifD As Decimal
    Public Property TarifD() As Decimal
        Get
            Return _TarifD
        End Get
        Set(ByVal value As Decimal)
            _TarifD = value
        End Set
    End Property

End Class
