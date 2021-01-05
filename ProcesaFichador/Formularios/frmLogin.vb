Imports Employees.Business
Imports DevExpress.XtraEditors
Public Class frmLogin
    Inherits XtraForm

#Region "Eventos controles"
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If ValidaUsuario() Then
            Dim frm As New frmMainParent
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidaUsuario() Then
                Dim frm As New frmMainParent
                frm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles txtUsuario.EditValueChanged
        txtUsuario.Text = txtUsuario.Text.ToUpper
    End Sub
#End Region

#Region "Funciones"
    Private Function ValidaUsuario() As Boolean
        Dim objUsuario As UsuarioComponent
        Try
            objUsuario = New UsuarioComponent(Session.CadenaConexion)
            Session.Usuario = objUsuario.GetEntById(txtUsuario.Text.ToUpper)
            If Session.Usuario Is Nothing Then
                XtraMessageBox.Show("Usuario inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Text = ""
                txtPassword.Text = ""
                txtUsuario.Select()
                Return False
            Else
                If Session.Usuario.ACTIVO = False Then
                    XtraMessageBox.Show("Usuario inactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPassword.Text = ""
                    txtUsuario.Select()
                    Return False
                End If
                If Session.Usuario.CLAVE.ToUpper.Trim <> txtPassword.Text.ToUpper.Trim Then
                    XtraMessageBox.Show("Contraseña inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPassword.Text = ""
                    txtUsuario.Select()
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Sub CheckUpdates()
        Try
            'Esto es para que corrar el Update, solo si lo corremos desde un exe
            If Not Debugger.IsAttached Then

                Dim returnValue As String() = Environment.GetCommandLineArgs()
                If returnValue.Length = 1 Then
                    If IO.File.Exists(My.Application.Info.DirectoryPath & "\CheckUpdates.exe") Then IO.File.Delete(My.Application.Info.DirectoryPath & "\CheckUpdates.exe")
                    IO.File.Copy("\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\CheckUpdates452.exe", My.Application.Info.DirectoryPath & "\CheckUpdates.exe", True)
                    IO.File.Copy("\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\Newtonsoft.Json.Net20.dll", My.Application.Info.DirectoryPath & "\Newtonsoft.Json.Net20.dll", True)

                    Const DblQts As String = """"

                    Dim strParam As String = DblQts & Application.ProductVersion & DblQts & " " &
                                              DblQts & My.Application.Info.DirectoryPath & DblQts & " " &
                                              DblQts & "\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\Version.json" & DblQts & " " &
                                              DblQts & IO.Path.GetFileName(Application.ExecutablePath) & DblQts

                    Process.Start(My.Application.Info.DirectoryPath & "\CheckUpdates.exe ", strParam)
                    Application.Exit()
                End If
                If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\System.Data.dll") AndAlso IO.File.Exists("\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\System.Data.dll") Then
                    IO.File.Copy("\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\System.Data.dll", My.Application.Info.DirectoryPath & "\System.Data.dll", True)
                End If
                If IO.File.Exists(My.Application.Info.DirectoryPath & "\pryPbxCallQueue.exe") Then IO.File.Delete(My.Application.Info.DirectoryPath & "\pryPbxCallQueue.exe")
                If IO.File.Exists(My.Application.Info.DirectoryPath & "\pryPbxCallQueue.exe.config") Then IO.File.Delete(My.Application.Info.DirectoryPath & "\pryPbxCallQueue.exe.config")
                Call ParcheNewTonSoft()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ParcheNewTonSoft()
        Try
            IO.File.Copy("\\192.168.6.55\Publico\vnNetpAppsNew\FichadorDistrib\Newtonsoft.Json.dll", My.Application.Info.DirectoryPath & "\Newtonsoft.Json.dll", True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Siempre al principio
        CheckUpdates()
    End Sub



#End Region

End Class