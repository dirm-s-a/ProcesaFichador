Public Class FichadasDTO
    Private mFecha As String
    Private mFichadas As String
    Private mObservaciones As String
    Private mNormal As String
    Private mTotalParcial As String
    Private mExtras50 As String
    Private mExtras100 As String
    Private mTarde As String
    'Private mTotalnormal As String
    'Private mTotal As String
    'Private mTotalExtras50 As String
    'Private mTotalExtras100 As String
    'Private mTotalTarde As String

    Public Property FECHA As String
        Get
            Return mFecha
        End Get
        Set(value As String)
            mFecha = value
        End Set
    End Property

    Public Property FICHADAS As String
        Get
            Return mFichadas
        End Get
        Set(value As String)
            mFichadas = value
        End Set
    End Property

    Public Property OBSERVACIONES As String
        Get
            Return mObservaciones
        End Get
        Set(value As String)
            mObservaciones = value
        End Set
    End Property

    Public Property NORMAL As String
        Get
            Return mNormal
        End Get
        Set(value As String)
            mNormal = value
        End Set
    End Property

    Public Property TOTALPARCIAL As String
        Get
            Return mTotalParcial
        End Get
        Set(value As String)
            mTotalParcial = value
        End Set
    End Property

    Public Property EXTRAS50 As String
        Get
            Return mExtras50
        End Get
        Set(value As String)
            mExtras50 = value
        End Set
    End Property

    Public Property EXTRAS100 As String
        Get
            Return mExtras100
        End Get
        Set(value As String)
            mExtras100 = value
        End Set
    End Property

    Public Property TARDE As String
        Get
            Return mTarde
        End Get
        Set(value As String)
            mTarde = value
        End Set
    End Property

    'Public Property TOTALNORMAL As String
    '    Get
    '        Return mTotalnormal
    '    End Get
    '    Set(value As String)
    '        mTotalnormal = value
    '    End Set
    'End Property

    'Public Property TOTAL As String
    '    Get
    '        Return mTotal
    '    End Get
    '    Set(value As String)
    '        mTotal = value
    '    End Set
    'End Property

    'Public Property TOTALEXTRAS50 As String
    '    Get
    '        Return mTotalExtras50
    '    End Get
    '    Set(value As String)
    '        mTotalExtras50 = value
    '    End Set
    'End Property

    'Public Property TOTALEXTRAS100 As String
    '    Get
    '        Return mTotalExtras100
    '    End Get
    '    Set(value As String)
    '        mTotalExtras100 = value
    '    End Set
    'End Property

    'Public Property TOTALTARDE As String
    '    Get
    '        Return mTotalTarde
    '    End Get
    '    Set(value As String)
    '        mTotalTarde = value
    '    End Set
    'End Property
End Class
