Imports Turnos.GlobalFunctions.Data
Public Class GenericFechaDesdeHastaDTO
    Private _FechaDesde As Date
    Private _FechaHasta As Date
    Private _Valido As Boolean

    Public Property FechaDesde As Date
        Get
            Return _FechaDesde
        End Get
        Set(value As Date)
            _FechaDesde = value
        End Set
    End Property

    Public Property FechaHasta As Date
        Get
            Return _FechaHasta
        End Get
        Set(value As Date)
            _FechaHasta = value
        End Set
    End Property

    Public Property Valido As Boolean
        Get
            Return _Valido
        End Get
        Set(value As Boolean)
            _Valido = value
        End Set
    End Property

    Public Sub New()
        _FechaDesde = F_Set_NullValue(_FechaDesde)
        _FechaHasta = F_Set_NullValue(_FechaHasta)
        Valido = False
    End Sub
End Class

Public Class GenericIdStringDTO
    Private _ID As String
    Private _DESCRIPCION As String

    Public Property ID As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property

    Public Property DESCRIPCION As String
        Get
            Return _DESCRIPCION
        End Get
        Set(value As String)
            _DESCRIPCION = value
        End Set
    End Property

    Public Sub New(ByVal id As String, ByVal Descripcion As String)
        _ID = id
        _DESCRIPCION = Descripcion
    End Sub
End Class

Public Class GenericIdLongDTO
    Private _ID As Long
    Private _DESCRIPCION As String

    Public Property ID As Long
        Get
            Return _ID
        End Get
        Set(value As Long)
            _ID = value
        End Set
    End Property

    Public Property DESCRIPCION As String
        Get
            Return _DESCRIPCION
        End Get
        Set(value As String)
            _DESCRIPCION = value
        End Set
    End Property

    Public Sub New(ByVal id As Long, ByVal Descripcion As String)
        _ID = id
        _DESCRIPCION = Descripcion
    End Sub
End Class
