Public Class AusenciasDTO
    Private mEmpleado As String
    Private mFecha As Date
    Private mDia As String

    Public Property EMPLEADO As String
        Get
            Return mEmpleado
        End Get
        Set(value As String)
            mEmpleado = value
        End Set
    End Property

    Public Property FECHA As Date
        Get
            Return mFecha
        End Get
        Set(value As Date)
            mFecha = value
        End Set
    End Property

    Public Property DIA As String
        Get
            Return mDia
        End Get
        Set(value As String)
            mDia = value
        End Set
    End Property
End Class
