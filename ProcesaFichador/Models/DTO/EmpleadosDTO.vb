Imports ProcesaFichador

Public Class EmpleadosDTO
    Private mEmpleado As String
    Private mSector As String
    Private mListaFichadas As List(Of FichadasDTO)

    Public Property EMPLEADO As String
        Get
            Return mEmpleado
        End Get
        Set(value As String)
            mEmpleado = value
        End Set
    End Property

    Public Property SECTOR As String
        Get
            Return mSector
        End Get
        Set(value As String)
            mSector = value
        End Set
    End Property

    Public Property LISTAFICHADAS As List(Of FichadasDTO)
        Get
            Return mListaFichadas
        End Get
        Set(value As List(Of FichadasDTO))
            mListaFichadas = value
        End Set
    End Property
End Class
