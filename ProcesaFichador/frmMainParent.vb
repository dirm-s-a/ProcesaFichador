Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports ProcesaFichador.AppSharedFunctions
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraBars
Imports System.Drawing.Printing

Public Class frmMainParent
    Inherits XtraForm

    Private Sub nbiCallCenter_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEmpleados.LinkClicked
        ViewChildForm(New frmTblEmpleados, Me)
    End Sub

    Private Sub FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub bbiAgendasActivas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles bbiFichadasLectura.LinkClicked
        ViewChildForm(New frmFichadasLectura, Me)
    End Sub

    Private Sub nbiSalir_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSalir.LinkClicked
        Me.Close()
    End Sub

    Private Sub frmMainParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Session.EntornoDesarrollo Then Me.Text &= " (Entorno de desarrollo)"
            For Each itemLink As DevExpress.XtraNavBar.NavBarItemLink In nvgPrincipal.ItemLinks
                Dim item As DevExpress.XtraNavBar.NavBarItem = itemLink.Item
                If Not item.Tag = "Salir" Then
                    Select Case item.Tag
                    Case "Fichadas Lectura", "Pedido ausencias"
                        item.Visible = (Session.Usuario.RRHH Or Session.Usuario.SUPERVISOR)
                    Case "Traza", "Usuarios"
                        item.Visible = (Session.Usuario.DIRECTORRRHH)
                    Case Else
                        item.Visible = Session.Usuario.RRHH
                End Select
                End If
            Next
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub nbiConvenios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiConvenios.LinkClicked
        ViewChildForm(New frmTblConvenios, Me)
    End Sub

    Private Sub nbiFPreProcesadas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFPreProcesadas.LinkClicked
        ViewChildForm(New frmTblEventosFichadas, Me)
    End Sub

    Private Sub nbiLiquidaciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLiquidaciones.LinkClicked
        ViewChildForm(New frmTblLiquidaciones, Me)
    End Sub

    Private Sub nbiFeriados_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFeriados.LinkClicked
        ViewChildForm(New frmTblFeriados, Me)
    End Sub

    Private Sub nbiUsuarios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiUsuarios.LinkClicked
        ViewChildForm(New frmTblUsuarios, Me)
    End Sub

    Private Sub nbiTipoAusencias_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTipoAusencias.LinkClicked
        ViewChildForm(New frmTblTipoAusencias, Me)
    End Sub

    Private Sub nbiGrupos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiGrupos.LinkClicked
        ViewChildForm(New frmTblGrupos, Me)
    End Sub

    Private Sub nbiTrazaCambios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTrazaCambios.LinkClicked
        ViewChildForm(New frmTblTraza, Me)
    End Sub

    Private Sub nbiPedidoAusencia_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiPedidoAusencia.LinkClicked
        ViewChildForm(New frmTblPedidoAusencia, Me)
    End Sub
End Class