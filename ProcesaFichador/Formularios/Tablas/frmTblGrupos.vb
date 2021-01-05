Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions

Public Class frmTblGrupos
    Inherits frmBase
    Private mobjLoger As New Logger

#Region "Eventos"

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub frmTblGrupos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.TopMost = True
            Me.TopMost = False

            CargarGrupos()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gViewGrupos.CustomRowCellEdit
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub frmBusqueda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdGrupos.Width = (Me.Width / 2) - 20
        grdGrupos.Height = Me.Height - 155

        grdSupervisores.Width = (Me.Width / 2) - 20
        grdSupervisores.Left = grdGrupos.Width + 20
        lblSupervisores.Left = grdGrupos.Width + 20

        grdEmpleados.Width = grdSupervisores.Width
        grdEmpleados.Left = grdSupervisores.Left
        lblEmpleados.Left = lblSupervisores.Left
    End Sub

#End Region

    Private Sub CargarGrupos()
        Try
            gViewGrupos.Columns.Clear()
            gViewSupervisores.Columns.Clear()
            gViewEmpleados.Columns.Clear()

            gViewGrupos.Columns.Add(AppSharedFunctions.NewColumn("ID", "ID",,, False))
            gViewGrupos.Columns.Add(AppSharedFunctions.NewColumn("DESCRIPCION", "Descripción"))
            gViewGrupos.Columns.Add(AppSharedFunctions.NewColumn("FECHAALTA", "Fecha Alta"))
            gViewGrupos.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOALTA", "Usuario Alta"))

            Dim obj As New GrupoComponent(Session.CadenaConexion)
            grdGrupos.DataSource = obj.GetALL
            gViewGrupos.OptionsBehavior.Editable = False
            gViewGrupos.OptionsSelection.MultiSelect = False
            gViewGrupos.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            gViewGrupos.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CargarSupervisores()
        Try
            gViewSupervisores.Columns.Clear()
            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                gViewSupervisores.Columns.Add(AppSharedFunctions.NewColumn("ID", "id",,, False))
                gViewSupervisores.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOSUP", "id Usuario"))
                gViewSupervisores.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOSUP_Desc", "Usuario"))

                Dim obj As New GrupoSupervisorComponent(Session.CadenaConexion)
                grdSupervisores.DataSource = obj.GetByGrupo(eGrupo.ID)
                gViewSupervisores.OptionsBehavior.Editable = False
                gViewSupervisores.OptionsSelection.MultiSelect = False
                gViewSupervisores.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
                gViewSupervisores.BestFitColumns()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CargarEmpleados()
        Try
            gViewEmpleados.Columns.Clear()

            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                gViewEmpleados.Columns.Add(AppSharedFunctions.NewColumn("id", "id",,, False))
                gViewEmpleados.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO_Desc", "Nombre"))

                Dim obj As New GrupoDetalleComponent(Session.CadenaConexion)
                grdEmpleados.DataSource = obj.GetByGrupo(eGrupo.ID)
                gViewEmpleados.OptionsBehavior.Editable = False
                gViewEmpleados.OptionsSelection.MultiSelect = False
                gViewEmpleados.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
                gViewEmpleados.BestFitColumns()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiNuevoSupervisor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevoSupervisor.ItemClick
        Try
            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                Dim frm As New frmBusqueda
                frm.NroTabla = 2 'Usuarios
                frm.ShowDialog()
                If Not frm.ObjSeleccionado Is Nothing Then
                    Dim eUsuario As Usuario = frm.ObjSeleccionado
                    Dim objGrupoSupervisor As New GrupoSupervisorComponent(Session.CadenaConexion)
                    Dim eGrupoSupervisor As New GrupoSupervisor
                    eGrupoSupervisor.BeginUpdate()
                    eGrupoSupervisor.IDGRUPO = eGrupo.ID
                    eGrupoSupervisor.IDUSUARIOSUP = eUsuario.ID

                    If objGrupoSupervisor.GetListByEnt(eGrupoSupervisor).Count = 0 Then
                        objGrupoSupervisor.Save(eGrupoSupervisor,, True)
                        CargarSupervisores()
                    Else
                        XtraMessageBox.Show("El usuario seleccionado ya es supervisor del grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                XtraMessageBox.Show("Seleccione un grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiEliminarSupervisor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarSupervisor.ItemClick
        Try
            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                Dim eGrupoSupervisor As GrupoSupervisor = gViewSupervisores.GetFocusedRow
                If Not eGrupoSupervisor Is Nothing Then
                    If XtraMessageBox.Show("Está seguro que desea eliminar el supervisor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Dim obj As New GrupoSupervisorComponent(Session.CadenaConexion)
                        obj.Delete(eGrupoSupervisor.ID)
                        CargarSupervisores()
                    End If
                Else
                    XtraMessageBox.Show("Seleccione un supervisor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                XtraMessageBox.Show("Seleccione un grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiNuevoEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevoEmpleado.ItemClick
        Try
            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                Dim frm As New frmBusqueda
                frm.NroTabla = 1 'EMPLEADOS
                frm.ShowDialog()
                If Not frm.ObjSeleccionado Is Nothing Then
                    Dim eEmpleado As Empleado = frm.ObjSeleccionado
                    Dim objGrupoDetalles As New GrupoDetalleComponent(Session.CadenaConexion)
                    Dim eGrupoDetalles As New GrupoDetalle
                    eGrupoDetalles.BeginUpdate()
                    eGrupoDetalles.IDGRUPO = eGrupo.ID
                    eGrupoDetalles.IDEMPLEADO = eEmpleado.ID

                    If objGrupoDetalles.GetListByEnt(eGrupoDetalles).Count = 0 Then
                        objGrupoDetalles.Save(eGrupoDetalles,, True)
                        CargarEmpleados()
                    Else
                        XtraMessageBox.Show("El empleado seleccionado ya se encuentra en el grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                XtraMessageBox.Show("Seleccione un grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiEliminarEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarEmpleado.ItemClick
        Try
            Dim eGrupo As Grupo = gViewGrupos.GetFocusedRow
            If Not eGrupo Is Nothing Then
                Dim eGrupoDetalles As GrupoDetalle = gViewEmpleados.GetFocusedRow
                If Not eGrupoDetalles Is Nothing Then
                    If XtraMessageBox.Show("Está seguro que desea eliminar el empleado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Dim obj As New GrupoDetalleComponent(Session.CadenaConexion)
                        obj.Delete(eGrupoDetalles.ID)
                        CargarEmpleados()
                    End If
                Else
                    XtraMessageBox.Show("Seleccione un empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                XtraMessageBox.Show("Seleccione un grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub gViewGrupos_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gViewGrupos.FocusedRowChanged
        CargarSupervisores()
        CargarEmpleados()
    End Sub

    Private Sub bbiNuevoGrupo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevoGrupo.ItemClick
        Try
            Dim frm As New frmAbmGrupo
            frm.ShowDialog()
            If frm.OKsave Then Call CargarGrupos()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiEliminarGrupo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarGrupo.ItemClick
        Dim entity As Grupo = CType(gViewGrupos.GetFocusedRow(), Grupo)
        If Not entity Is Nothing Then
            If XtraMessageBox.Show("Está seguro que desea eliminar el grupo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim obj As New GrupoComponent(Session.CadenaConexion)

                If obj.Delete(entity.ID) Then
                    XtraMessageBox.Show("Grupo eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrupos()
                Else
                    XtraMessageBox.Show("Error al eliminar el grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub bbiEditarGrupo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditarGrupo.ItemClick
        Try
            Dim entity As Grupo = CType(gViewGrupos.GetFocusedRow(), Grupo)
            If entity Is Nothing Then Exit Sub

            Dim frm As New frmAbmGrupo
            frm.entity = entity
            frm.ShowDialog()
            If frm.OKsave Then
                Call CargarGrupos()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gViewGrupos_ColumnFilterChanged(sender As Object, e As EventArgs) Handles gViewGrupos.ColumnFilterChanged
        CargarSupervisores()
        CargarEmpleados()
    End Sub
End Class