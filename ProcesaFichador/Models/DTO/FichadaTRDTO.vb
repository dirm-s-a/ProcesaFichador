Imports ProcesaFichador

Public Class FichadaTRDTO
    Private mIdCliente As Integer
    Private mNombre As String
    Private mApellido As String
    Private mFichada As Date

    Public Property IDCLIENTE As Integer
        Get
            Return mIdCliente
        End Get
        Set(value As Integer)
            mIdCliente = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property APELLIDO As String
        Get
            Return mApellido
        End Get
        Set(value As String)
            mApellido = value
        End Set
    End Property

    Public Property FICHADA As Date
        Get
            Return mFichada
        End Get
        Set(value As Date)
            mFichada = value
        End Set
    End Property
End Class
