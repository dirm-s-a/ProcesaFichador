Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports Employees.Data
Imports Turnos.GlobalFunctions
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
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

#End Region

End Class