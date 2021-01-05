Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions

Public Class frmTblUsuarios
    Inherits frmBase
    Private mobjLoger As New Logger


#Region "Eventos"

    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Excel", "xlsx", grdDatos)
    End Sub

    Private Sub bbiExportarPdf_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPdf.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Pdf", "pdf", grdDatos)
    End Sub

    Private Sub bbiExportarCsv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarCsv.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Csv", "csv", grdDatos)
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Hide()
    End Sub

    Private Sub bbiListar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListar.ItemClick
        CargarGrilla()
    End Sub

    Private Sub frmTabla_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call Usuarios_Inicializar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub frmBusqueda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdDatos.Width = Me.Width - 16
        grdDatos.Height = Me.Height - 155
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Alta()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Editar()
    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Eliminar()
    End Sub

#End Region

    'Private Sub Inicializar()
    '    Select Case mNroTabla
    '        Case Session.mTabla.Usuarios : Usuarios_Inicializar()
    '        Case Else : XtraMessageBox.Show("No se pudo inicializar la tabla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End Select
    'End Sub

    Private Sub CargarGrilla()
        Call Usuarios_CargarGrilla()
    End Sub

    Private Sub Alta()
        Call Usuarios_Alta()
    End Sub

    Private Sub Editar()
        Call Usuarios_Editar()
    End Sub

    Private Sub Eliminar()
        Call Usuarios_Eliminar()
    End Sub

    'STOCKDEPOSITOS

    Private Sub Usuarios_Inicializar()
        Try
            Me.Text = "Usuarios"

            GridView1.Columns.Clear()
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("ID", "id"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("NOMBRE", "Nombre"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("RRHH", "Recursos Humanos"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("SUPERVISOR", "Supervisor"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("DIRECTORRRHH", "Director rrhh"))
            Usuarios_CargarGrilla()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Usuarios_CargarGrilla()
        Try
            Dim obj As New UsuarioComponent(Session.CadenaConexion)
            Dim ent As New Usuario
            ent.BeginUpdate()
            ent.ACTIVO = True 'me traigo solo los activos
            grdDatos.DataSource = obj.GetListByEnt(ent)
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Usuarios_Alta()
        Try
            Dim frm As New frmAbmUsuarios
            frm.ShowDialog()
            If frm.okSave Then Call CargarGrilla()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Usuarios_Editar()
        Try
            Dim ent As Usuario = CType(GridView1.GetFocusedRow(), Usuario)
            If Not ent Is Nothing Then
                Dim frm As New frmAbmUsuarios
                frm.Entity = ent
                frm.ShowDialog()
                If frm.OkSave Then
                    Call CargarGrilla()

                    For x As Long = 0 To GridView1.RowCount - 1
                        If frm.Entity.id = GridView1.GetRowCellValue(x, "id") Then
                            GridView1.FocusedRowHandle = x
                            GridView1.SelectRow(x)
                            Exit For
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Usuarios_Eliminar()
        Dim entity As Usuario = CType(GridView1.GetFocusedRow(), Usuario)
        If Not entity Is Nothing Then
            If XtraMessageBox.Show("Está seguro que desea eliminar el usuario seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                entity.BeginUpdate()
                entity.ACTIVO = False
                Dim obj As New UsuarioComponent(Session.CadenaConexion)

                If obj.Save(entity) Then
                    XtraMessageBox.Show("Usuario dado de baja", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call CargarGrilla()
                Else
                    XtraMessageBox.Show("Error al dar de baja el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub
End Class