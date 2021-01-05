Imports Encriptacion
Imports System.Text
Imports Microsoft.Win32
Public Class GeneradorCadena
    'Private mEmpleadosProd As String = "data source=192.168.6.66;initial catalog=ramos;user id=sysdba;password=masterkey;returnrecordsaffected=True;Charset=NONE;Role=;Connection lifetime=60;Pooling=true; MinPoolSize=0;MaxPoolSize=20;Packet Size=8192;ServerType=0"
    Private mEmpleadosDesarrollo As String = "data source=10.21.0.10;initial catalog=Employees;user id=sysdba;password=masterkey;returnrecordsaffected=True;Charset=NONE;Role=;Connection lifetime=60;Pooling=true; MinPoolSize=0;MaxPoolSize=20;Packet Size=8192;ServerType=0"
    Private mEmpleadosProd As String = "data source=192.168.1.3;initial catalog=Employees;user id=sysdba;password=masterkey;returnrecordsaffected=True;Charset=NONE;Role=;Connection lifetime=60;Pooling=true; MinPoolSize=0;MaxPoolSize=20;Packet Size=8192;ServerType=0"
    Private mLenox As String = "data source=192.168.6.141;initial catalog=Lenox;user id=sysdba;password=masterkey;returnrecordsaffected=True;Charset=NONE;Role=;Connection lifetime=60;Pooling=true; MinPoolSize=0;MaxPoolSize=20;Packet Size=8192;ServerType=0"

    Private Function ExisteCadena(ByVal LlaveRegistro As String) As Boolean
        Try
            If Environment.Is64BitOperatingSystem Then
                Dim baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                Dim regkey = baseKey.OpenSubKey("SOFTWARE\" + LlaveRegistro)
                Return (Not regkey Is Nothing)
            Else
                Dim rk = Registry.LocalMachine.GetValue("Software\" + LlaveRegistro)
                Return (Not rk Is Nothing)
            End If

        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function

    Public Function EmpleadosProdyDesarrollo() As Boolean
        Try
            If Not GrabaCadena(mEmpleadosProd, "EmpleadosProd", False) Then Return False
            If Not GrabaCadena(mEmpleadosDesarrollo, "EmpleadosDesarrollo", False) Then Return False
            If Not GrabaCadena(mLenox, "Lenox", False) Then Return False
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function GrabaCadena(ByVal CadenaConexion As String, ByVal LlaveRegistro As String, ByVal YaEncriptada As Boolean) As Boolean
        Dim CadenaEncriptada As String = String.Empty

        Try
            If Not ExisteCadena(LlaveRegistro) Then
                If Not YaEncriptada Then
                    CadenaEncriptada = Encriptar(CadenaConexion)
                Else
                    CadenaEncriptada = CadenaConexion
                End If
                If Not CadenaEncriptada = String.Empty Then
                    Return EscribirRegistro(CadenaEncriptada, LlaveRegistro)
                End If
            End If
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Private Function Encriptar(ByVal CadenaConexion As String) As String
        Dim algorithm As EncryptionAlgorithm
        algorithm = EncryptionAlgorithm.TripleDes
        Dim CadenaEncriptada As String = String.Empty

        Try
            'Try to encrypt.
            'Create the encryptor.
            Dim enc As Encryptor
            enc = New Encryptor(EncryptionAlgorithm.TripleDes)
            Dim plainText As Byte()
            plainText = Encoding.ASCII.GetBytes(CadenaConexion)


            'Inicializo variables
            Dim IV As Byte()
            Dim key As Byte()
            If ((EncryptionAlgorithm.TripleDes = algorithm) Or (EncryptionAlgorithm.Rijndael = algorithm)) Then
                '3Des only work with a 16 or 24 byte key.
                'key = Encoding.ASCII.GetBytes("password12345678")
                key = Encoding.ASCII.GetBytes("9526745132689749")
                If (EncryptionAlgorithm.Rijndael = algorithm) Then
                    'Must be 16 bytes for Rijndael.
                    IV = Encoding.ASCII.GetBytes("init vec is big.")
                Else
                    'IV = Encoding.ASCII.GetBytes("init vec")
                    IV = Encoding.ASCII.GetBytes("aeitertg")
                End If
            Else
                'Des only works with an 8 byte key. The others uses variable length keys.
                'Set the key to null to have a new one generated.
                'key = Encoding.ASCII.GetBytes("password")
                key = Encoding.ASCII.GetBytes("9526745132689749")
                'IV = Encoding.ASCII.GetBytes("init vec")
                IV = Encoding.ASCII.GetBytes("aeitertg")
            End If
            ' Uncomment the next lines to have the key or IV generated for you.
            'key = Nothing
            'IV = nothing

            enc.IV = IV

            'Perform the encryption.
            Dim cipherText As Byte() = enc.Encrypt(plainText, key)
            ' Retrieve the intialization vector and key. You will need it
            'for decryption.
            IV = enc.IV
            key = enc.Key
            'Look at your cipher text and initialization vector.
            'Console.WriteLine(" Cipher text: " + Convert.ToBase64String(cipherText))
            CadenaEncriptada = Convert.ToBase64String(cipherText)
            'Console.WriteLine("Initialization vector: " + Convert.ToBase64String(IV))
            'Me.txtInitializationVector.Text = Convert.ToBase64String(IV)
            'Console.WriteLine(" Key: " + Convert.ToBase64String(key))
        Catch ex As Exception
            Console.WriteLine("Exception encrypting. " + ex.Message)
        End Try
        Return CadenaEncriptada
    End Function

    Private Function EscribirRegistro(ByVal CadenaEncriptada As String, ByVal LlaveRegistro As String) As Boolean
        'Create registry key and named values
        Dim Rrk64 As RegistryKey, rk64 As RegistryKey
        Dim rk As RegistryKey

        Try
            If CadenaEncriptada <> String.Empty Then
                'Aplicacion 32 bit crea la entrada en WOW6432Key
                rk = Registry.LocalMachine.OpenSubKey("Software", True)
                rk = rk.CreateSubKey(LlaveRegistro)
                'Write encrypted string, initialization vector and key to the registry
                rk.SetValue("connectionString", CadenaEncriptada)
                'Aplicacion 64 bit directo en HKEY_LOCAL_MACHINE
                Rrk64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                rk64 = Rrk64.CreateSubKey("SOFTWARE\\" + LlaveRegistro)
                rk64.SetValue("connectionString", CadenaEncriptada)
                Return True
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class
