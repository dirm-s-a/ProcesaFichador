
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository
Imports Turnos.GlobalFunctions.Data

Public Class frmTblEmpleados
    Inherits frmBase
    Private WithEvents mobjEventoFichada As New EventoFichadaComponent(Session.CadenaConexion)
    Private WithEvents mobjLiquidacion As New LiquidacionComponent(Session.CadenaConexion)

    Private Sub frmTblEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarGrilla()
    End Sub

#Region "Eventos controles"
    Private Sub btnAgregarHorario_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario.Click
        Try
            Dim frm As New frmAbmHorario
            Dim ent As Empleado = CType(grdViewEmpleado.GetFocusedRow(), Empleado)
            frm.NOMBREEMPLEADO = ent.NOMBRE
            frm.IDEMPLEADO = ent.ID
            frm.ShowDialog()
            If frm.OkSave Then CargarHorarios()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnAgregarHorarioAdic_Click(sender As Object, e As EventArgs) Handles btnAgregarHorarioAdic.Click
        Try
            Dim frm As New frmAbmHorarioAdic
            Dim ent As Empleado = CType(grdViewEmpleado.GetFocusedRow(), Empleado)
            frm.NOMBREEMPLEADO = ent.NOMBRE
            frm.IDEMPLEADO = ent.ID
            frm.ShowDialog()
            If frm.OkSave Then CargarHorarios()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CargarHorarios()
        Dim objHorarioEmpleado As New HorarioEmpleadoComponent(Session.CadenaConexion)
        Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)
        Dim listHorarioEmpleado As List(Of HorarioEmpleado)
        Dim item1 As ListViewItem

        Try
            Dim entEmpleado As Empleado = CType(grdViewEmpleado.GetFocusedRow, Empleado)

            lblEmpleado.Text = ""
            lstViewHorarios.Items.Clear()
            If entEmpleado Is Nothing Then Exit Sub

            listHorarioEmpleado = objHorarioEmpleado.GetByEmpleado(entEmpleado.ID).Where(Function(f) f.ACTIVO).ToList
            Dim entConvenio As Convenio = objConvenio.GetEntById(entEmpleado.IDCONVENIO)

            For Each entHorarioEmpleado As HorarioEmpleado In listHorarioEmpleado
                lblEmpleado.Text = entEmpleado.NOMBRE

                item1 = New ListViewItem(lstViewHorarios.Items.Count)
                If entHorarioEmpleado.DIASEMANAENTRADA = entHorarioEmpleado.DIASEMANASALIDA Then
                    item1.SubItems.Add(AppSharedFunctions.DiaNumeroAString(entHorarioEmpleado.DIASEMANAENTRADA))
                Else
                    item1.SubItems.Add(AppSharedFunctions.DiaNumeroAString(entHorarioEmpleado.DIASEMANAENTRADA) & " - " & AppSharedFunctions.DiaNumeroAString(entHorarioEmpleado.DIASEMANASALIDA))
                End If

                item1.SubItems.Add(AppSharedFunctions.horaMilitarAnormal(entHorarioEmpleado.HORAENTRADA) & " - " & AppSharedFunctions.horaMilitarAnormal(entHorarioEmpleado.HORASALIDA))

                If entConvenio.SINCONTROLES Then
                    item1.SubItems.Add("Sin Controles")
                ElseIf entConvenio.HORARIOFLEXIBLE Then
                    item1.SubItems.Add("Flexible")
                ElseIf entConvenio.AUSENTISMO Then
                    item1.SubItems.Add("Fijo")
                End If

                lstViewHorarios.Items.Insert(lstViewHorarios.Items.Count, item1)
            Next
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        EditarItem(grdViewEmpleado.FocusedRowHandle)
    End Sub

    Private Sub bbiBorrarEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBorrarEmpleado.ItemClick
        EliminarCompleto(grdViewEmpleado.FocusedRowHandle)
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles grdViewEmpleado.RowClick
        CargarHorarios()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdViewEmpleado.FocusedRowChanged
        CargarHorarios()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles grdViewEmpleado.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        Dim menuItem As DXMenuItem
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim subMenu As New DXSubMenuItem("Principal")
            e.Menu.Items.Add(subMenu)

            ''Nuevo
            menuItem = New DXMenuItem("Nuevo Empleado", AddressOf OnDeleteRowClick, Global.ProcesaFichador.My.Resources.Resources.add_16x16)
            menuItem.Tag = New RowInfo(view, rowHandle)
            subMenu.Items.Add(menuItem)

            'Editar
            menuItem = New DXMenuItem("Editar Empleado", AddressOf OnDeleteRowClick, Global.ProcesaFichador.My.Resources.editcontact_16x16)
            menuItem.Tag = New RowInfo(view, rowHandle)
            subMenu.Items.Add(menuItem)

            ''Deshabilitar
            menuItem = New DXMenuItem("Deshabilitar Empleado", AddressOf OnDeleteRowClick, Global.ProcesaFichador.My.Resources.Resources.cancel_16x16)
            menuItem.Tag = New RowInfo(view, rowHandle)
            subMenu.Items.Add(menuItem)

            'subMenu = New DXSubMenuItem("Misceláneos")
            'e.Menu.Items.Add(subMenu)
            ''Eliminar
            'menuItem = New DXMenuItem("Cambiar Código Consultorio", AddressOf OnDeleteRowClick, Global.NetApp.My.Resources.Resources.convert_16x16)
            'menuItem.Tag = New RowInfo(view, rowHandle)
            'subMenu.Items.Add(menuItem)
        End If
    End Sub

    Private Sub btnHistoricoHorarios_Click(sender As Object, e As EventArgs) Handles btnHistoricoHorarios.Click
        Try
            Dim frm As New frmTblHorarios
            Dim ent As Empleado = CType(grdViewEmpleado.GetFocusedRow(), Empleado)
            If Not ent Is Nothing Then
                frm.Entity = ent
                frm.ShowDialog()
                Call CargarHorarios()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        Select Case item.Caption
            Case "Editar Empleado" : Call EditarItem(info.RowHandle)
            Case "Nuevo Empleado" : Call NuevoItem()
            Case "Deshabilitar Empleado" : Call DeshabilitarItem(info.RowHandle)
        End Select
    End Sub

    Private Sub cargarGrilla()
        Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
        Dim listEmpleados As New List(Of Empleado)

        Try
            listEmpleados = objEmpleado.GetALL()

            grdViewEmpleado.OptionsBehavior.Editable = False

            grdEmpleados.DataSource = listEmpleados.OrderBy(Function(p) p.NOMBRE).ToList

            grdViewEmpleado.Columns.Item("ID").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIO").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIO_Desc").Visible = False
            grdViewEmpleado.Columns.Item("IDCONVENIO").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIOALTA").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIOALTA_Desc").Visible = False
            grdViewEmpleado.Columns.Item("FECHAALTA").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIOMODIFICACION").Visible = False
            grdViewEmpleado.Columns.Item("IDUSUARIOMODIFICACION_Desc").Visible = False
            grdViewEmpleado.Columns.Item("FECHAMODIFICACION").Visible = False

            grdViewEmpleado.Columns.Item("Table").Visible = False

            grdViewEmpleado.OptionsSelection.MultiSelect = False
            grdViewEmpleado.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            grdViewEmpleado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles grdViewEmpleado.CustomRowCellEdit
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Hide()
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        NuevoItem()
    End Sub

    Private Sub NuevoItem()
        Dim form As New frmAbmEmpleado
        form.Entity = New Empleado
        form.ShowDialog()
        If form.OkSave Then Call cargarGrilla()
    End Sub

    Private Sub bbiDeshabilitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDeshabilitar.ItemClick
        DeshabilitarItem(grdViewEmpleado.FocusedRowHandle)
    End Sub

    Private Sub DeshabilitarItem(ByVal iRow As Integer)
        Dim entity As Empleado = CType(grdViewEmpleado.GetRow(iRow), Empleado)
        If Not entity Is Nothing Then
            If Not entity.INACTIVO Then
                If XtraMessageBox.Show("Está seguro que desea deshabilitar el empleado seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    entity.BeginUpdate()
                    entity.INACTIVO = True
                    entity.FECHABAJA = DateTime.Now

                    Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
                    If objEmpleado.SaveConTraza(entity) Then
                        XtraMessageBox.Show("Empleado deshabilitado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cargarGrilla()
                    End If
                End If
            Else
                XtraMessageBox.Show("El empleado ya se encuentra inactivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub EditarItem(ByVal iRow As Integer)
        Try
            Dim entity As Empleado = CType(grdViewEmpleado.GetRow(iRow), Empleado)
            If Not entity Is Nothing Then
                Dim frm As New frmAbmEmpleado
                frm.Entity = entity
                frm.ShowDialog()
                If frm.OkSave Then
                    Call cargarGrilla()

                    For x As Long = 0 To grdViewEmpleado.RowCount - 1
                        If frm.Entity.ID = grdViewEmpleado.GetRowCellValue(x, "ID") Then
                            grdViewEmpleado.FocusedRowHandle = x
                            grdViewEmpleado.SelectRow(x)
                            Exit For
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub EliminarCompleto(ByVal iRow As Integer)
        Try
            Dim entity As Empleado = CType(grdViewEmpleado.GetRow(iRow), Empleado)
            If Not entity Is Nothing Then
                If entity.INACTIVO Then
                    If XtraMessageBox.Show("Está seguro que desea borrar el empleado seleccionado?" & vbCrLf & "Esta acción es irreversible." & vbCrLf & "Se eliminarán todos los registros del empleado." & vbCr & vbCrLf & "Empleado: " & entity.NOMBRE, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Dim obj As New EmpleadoComponent(Session.CadenaConexion)
                        If obj.EliminarCompleto(entity.ID, Session.Usuario.ID) Then
                            XtraMessageBox.Show("Se ha eliminado por completo el empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call cargarGrilla()
                        Else
                            XtraMessageBox.Show("No se puedo eliminar al empleado !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Else
                    XtraMessageBox.Show("No puede eliminar un empleado activo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub bbiProcesarEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcesarEmpleado.ItemClick
        Try
            Dim entity As Empleado = CType(grdViewEmpleado.GetRow(grdViewEmpleado.FocusedRowHandle), Empleado)
            If entity Is Nothing Then Exit Sub

            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Pre-Proceso Empleado")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea Pre-procesar fichadas del empleado: " & entity.NOMBRE & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim List As New List(Of Empleado)
                    Dim ListInconsistencias As New List(Of Empleado)
                    List.Add(entity)
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    Application.DoEvents()
                    mobjEventoFichada.ProcesaFichadas(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta, ListInconsistencias, flgCancelado, True)
                    ppaEspere.Visible = False
                    If ListInconsistencias.Count > 0 Then
                        XtraMessageBox.Show("Proceso corrido con inconsistencias.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiProcesarTodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcesarTodos.ItemClick
        Try
            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Pre-Proceso Empleados")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea hacer un Pre-proceso de fichadas de todos los empleados ?" & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta & Environment.NewLine
                str &= "Este proceso va a tomar varios minutos para completarse."

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim objEmpleados As New EmpleadoComponent(Session.CadenaConexion)
                    Dim List As List(Of Empleado) = objEmpleados.GetAllActivos
                    Dim ListInconsistencias As New List(Of Empleado)
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    ppaEspere.BringToFront()
                    Application.DoEvents()
                    mobjEventoFichada.ProcesaFichadas(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta, ListInconsistencias, flgCancelado, True)
                    ppaEspere.Visible = False
                    If ListInconsistencias.Count > 0 Then
                        Dim StrEmpleados As String = ""
                        For Each ent As Empleado In ListInconsistencias
                            StrEmpleados &= ent.NOMBRE & Environment.NewLine
                        Next
                        XtraMessageBox.Show("Proceso corrido con " & ListInconsistencias.Count & " empleados con inconsistencias." & Environment.NewLine & StrEmpleados, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiDesprocesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDesprocesar.ItemClick
        Try
            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Desproceso Empleados")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea hacer un roll back del Pre-proceso de fichadas de todos los empleados ?" & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta & Environment.NewLine
                str &= "Este proceso va a tomar varios minutos para completarse."

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim objEmpleados As New EmpleadoComponent(Session.CadenaConexion)
                    Dim List As List(Of Empleado) = objEmpleados.GetAllActivos
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    Application.DoEvents()
                    mobjEventoFichada.Desprocesar(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta, flgCancelado)
                    ppaEspere.Visible = False
                    XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub objcontratos_PercentDone(ByVal Percent As Single, ByVal Observacion As String, ByVal Contador As Long, ByRef Cancel As Boolean) Handles mobjEventoFichada.PercentDone, mobjLiquidacion.PercentDone
        ppaEspere.Caption = Format(Percent, "#0.00") & " % (" & Contador & ")"
        ppaEspere.Description = "Procesando empleado: " & Observacion
        Application.DoEvents()
    End Sub

    Private Sub frmTblEmpleados_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ppaEspere.Top = (Me.Height - ppaEspere.Height) / 2
        ppaEspere.Left = (Me.Width - ppaEspere.Width) / 2
    End Sub

    Private Sub bbiDesprocesarEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDesprocesarEmpleado.ItemClick
        Try
            Dim entity As Empleado = CType(grdViewEmpleado.GetRow(grdViewEmpleado.FocusedRowHandle), Empleado)
            If entity Is Nothing Then Exit Sub

            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Desproceso Empleado")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea hacer un roll back del pre proceso de fichadas del empleado: " & entity.NOMBRE & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim List As New List(Of Empleado)
                    Dim ListInconsistencias As New List(Of Empleado)
                    List.Add(entity)
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    Application.DoEvents()
                    mobjEventoFichada.Desprocesar(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta, flgCancelado)
                    ppaEspere.Visible = False
                    If ListInconsistencias.Count > 0 Then
                        XtraMessageBox.Show("Proceso corrido con inconsistencias.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bbiLiquidarEmpleados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLiquidarEmpleados.ItemClick
        Try
            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Liquidación Empleados")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea liquidar todos los empleados ? " & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta & Environment.NewLine
                str &= "Este proceso va a tomar varios minutos para completarse."

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim objEmpleados As New EmpleadoComponent(Session.CadenaConexion)
                    Dim List As List(Of Empleado) = objEmpleados.GetAllActivos
                    'Dim ListInconsistencias As New List(Of Empleado)
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    Application.DoEvents()
                    mobjLiquidacion.LiquidarPeriodo(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta)
                    ppaEspere.Visible = False
                    XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiLiquidarEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLiquidarEmpleado.ItemClick
        Try
            Dim entity As Empleado = CType(grdViewEmpleado.GetRow(grdViewEmpleado.FocusedRowHandle), Empleado)
            If entity Is Nothing Then Exit Sub

            Dim entGenericFechaDesdeHastaDTO As GenericFechaDesdeHastaDTO = xtraFechaDesdeHasta.Show("Fechas Liquidación Empleado")
            If entGenericFechaDesdeHastaDTO.Valido Then
                Dim str As String = "Desea liquidar empleado: " & entity.NOMBRE & Environment.NewLine
                str &= "Desde Fecha: " & entGenericFechaDesdeHastaDTO.FechaDesde & Environment.NewLine
                str &= "Hasta Fecha: " & entGenericFechaDesdeHastaDTO.FechaHasta

                If XtraMessageBox.Show(str, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim List As New List(Of Empleado)
                    List.Add(entity)
                    Dim flgCancelado As Boolean = False
                    ppaEspere.Visible = True
                    Application.DoEvents()
                    mobjLiquidacion.LiquidarPeriodo(List, entGenericFechaDesdeHastaDTO.FechaDesde, entGenericFechaDesdeHastaDTO.FechaHasta)
                    ppaEspere.Visible = False
                    XtraMessageBox.Show("Proceso corrido correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdViewEmpleado_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdViewEmpleado.ColumnFilterChanged
        Call CargarHorarios()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim objEmplado As New EmpleadoComponent(Session.CadenaConexion)
        Dim List As List(Of Empleado)
        objEmplado.BuscaInasistenciaAhora(List)
        Dim Str As String = "Empleados con ausentismo " & Environment.NewLine
        For Each ent As Empleado In List.Where(Function(f) Not f.SECTOR.Equals("*")).ToList
            Str &= ent.NOMBRE & " (" & ent.NRODOCUMENTO & ")" & Environment.NewLine
        Next
        Str &= "Empleados con ausentismo o llegadas muy tarde " & Environment.NewLine
        For Each ent As Empleado In List.Where(Function(f) f.SECTOR.Equals("*")).ToList
            Str &= ent.NOMBRE & " (" & ent.NRODOCUMENTO & ")" & Environment.NewLine
        Next

        XtraMessageBox.Show(Str, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

#End Region
End Class