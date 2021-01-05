Imports Employees.Entities

Public Class Session
    Private Shared mentUsuario As Usuario
    Public Enum mTabla
        Usuarios = 1
    End Enum

    Public Shared ReadOnly Property EntornoDesarrollo As Boolean
        Get
            If Configuration.ConfigurationManager.AppSettings.Get("EntornoDesarrollo") = "1" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public Shared ReadOnly Property CadenaConexion As String
        Get
            If Configuration.ConfigurationManager.AppSettings.Get("EntornoDesarrollo") = "1" Then
                Return Configuration.ConfigurationManager.AppSettings.Get("ConexionStringDesarrollo")
            Else
                Return Configuration.ConfigurationManager.AppSettings.Get("ConexionStringProd")
            End If
        End Get
    End Property

    Public Shared Property Usuario As Usuario
        Get
            Return mentUsuario
        End Get
        Set(value As Usuario)
            mentUsuario = value
        End Set
    End Property
End Class

