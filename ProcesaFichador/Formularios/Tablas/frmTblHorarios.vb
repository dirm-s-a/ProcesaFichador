Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTblHorarios
    Inherits XtraForm
#Region "Eventos controles"
    Private mflgOkSave As Boolean = False
    Private mEntity As Empleado

    Public Property Entity As Empleado
        Get
            Return mEntity
        End Get
        Set(value As Empleado)
            mEntity = value
        End Set
    End Property
    Public ReadOnly Property OkSave As Boolean
        Get
            Return mflgOkSave
        End Get
    End Property

    Private Sub frmTblHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text &= " ( " & mEntity.NOMBRE & " )"
        Call FormatoGrillas()
        CargarGrillas()
        If Not Session.Usuario.RRHH Then
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
            SplitContainerControl2.PanelVisibility = SplitPanelVisibility.Panel1
            grdHorarioAdic.Focus()
        End If
    End Sub

    Private Sub grdViewHorarioFijo_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) 

        Try
            Select Case e.Column.FieldName
                Case "DIASEMANAENTRADA"
                    e.DisplayText = WeekdayName(e.CellValue,, FirstDayOfWeek.Monday).ToUpper
                Case "DIASEMANASALIDA"
                    e.DisplayText = WeekdayName(e.CellValue,, FirstDayOfWeek.Monday).ToUpper
                Case "IDEMPLEADO_Desc"
                    e.DisplayText = mEntity.NOMBRE
                Case "HORAENTRADA"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORAENTRADA1"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA1"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORAENTRADA2"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA2"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub grdViewHorarioFijo_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) 
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub grdViewHorarioAdicional_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) 
        Try
            Select Case e.Column.FieldName
                Case "DIASEMANAENTRADA"
                    e.DisplayText = WeekdayName(e.CellValue).ToUpper
                Case "DIASEMANASALIDA"
                    e.DisplayText = WeekdayName(e.CellValue).ToUpper
                Case "IDEMPLEADO_Desc"
                    e.DisplayText = mEntity.NOMBRE
                Case "HORAENTRADA"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORAENTRADA1"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA1"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORAENTRADA2"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
                Case "HORASALIDA2"
                    If CType(e.CellValue, Integer) < 0 Then
                        e.DisplayText = ""
                    Else
                        e.DisplayText = AppSharedFunctions.horaMilitarAnormal(e.CellValue)
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub grdViewHorarioAdicional_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) 
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub grdViewAusencias_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) 
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

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        If ActiveControl.Name = "grdHorarios" Then
            Call EliminarItem(grdViewHorarioFijo.FocusedRowHandle, 1)
        ElseIf ActiveControl.Name = "grdHorarioAdic" Then
            Call EliminarItem(grdViewHorarioAdicional.FocusedRowHandle, 2)
        ElseIf ActiveControl.Name = "grdAusencias" Then
            Call EliminarItem(grdViewHorarioFijo.FocusedRowHandle, 3)
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If ActiveControl.Name = "grdHorarios" Then
            Call EditarItem(grdViewHorarioFijo.FocusedRowHandle, 1)
        ElseIf ActiveControl.Name = "grdHorarioAdic" Then
            Call EditarItem(grdViewHorarioAdicional.FocusedRowHandle, 2)
        ElseIf ActiveControl.Name = "grdAusencias" Then
            Call EditarItem(grdViewAusencias.FocusedRowHandle, 3)
        End If
    End Sub
#End Region

#Region "Funciones y procedimientos"

    Private Sub CargarGrillas()
        Dim objHorarios As New HorarioEmpleadoComponent(Session.CadenaConexion)
        Dim objHorariosAdic As New HorarioAdicEmpleadoComponent(Session.CadenaConexion)
        Dim objAusencias As New AusenciaEmpleadoComponent(Session.CadenaConexion)
        Dim listHorarios As New List(Of HorarioEmpleado)
        Dim listHorariosAdic As New List(Of HorarioAdicEmpleado)
        Dim listAusencias As New List(Of AusenciaEmpleado)
        Dim fechaFin As New Date(2100, 1, 1)

        If Not mEntity Is Nothing Then
            If ckGetActivos.Checked Or ckGetInactivos.Checked Then
                listHorarios = objHorarios.GetByEmpleado(mEntity.ID)
                listHorariosAdic = objHorariosAdic.GetByEmpleado(mEntity.ID)
                listAusencias = objAusencias.GetByEmpleado(mEntity.ID).Where(Function(f) f.IDUSUARIOANULA = "").ToList

                If Not ckGetActivos.Checked Then
                    listHorarios = listHorarios.Where(Function(f) Not f.ACTIVO).ToList
                    listHorariosAdic = listHorariosAdic.Where(Function(f) Not f.ACTIVO).ToList.Where(Function(f) f.FECHAHASTA >= Date.Today).ToList
                End If
                If Not ckGetInactivos.Checked Then
                    listHorarios = listHorarios.Where(Function(f) f.ACTIVO).ToList
                    listHorariosAdic = listHorariosAdic.Where(Function(f) f.ACTIVO OrElse f.FECHAHASTA < Date.Today).ToList
                End If
            End If

            grdHorarios.DataSource = listHorarios
            grdHorarioAdic.DataSource = listHorariosAdic
            grdAusencias.DataSource = listAusencias

            grdViewHorarioFijo.BestFitColumns()
            grdViewHorarioAdicional.BestFitColumns()
            grdViewAusencias.BestFitColumns()
        End If
    End Sub

    Private Sub NuevoItem(ByVal iRow As Integer, ByVal grilla As Long)
        Try
            If grilla = 1 Then
                Dim frm As New frmAbmHorario
                frm.IDEMPLEADO = mEntity.ID
                frm.NOMBREEMPLEADO = mEntity.NOMBRE
                frm.ShowDialog()
                If frm.OkSave Then Call CargarGrillas()
            ElseIf grilla = 2 Then
                Dim frm As New frmAbmHorarioAdic
                'frm.IDEMPLEADO = mEntity.ID
                frm.NOMBREEMPLEADO = mEntity.NOMBRE
                frm.ShowDialog()
                If frm.OkSave Then Call CargarGrillas()
            ElseIf grilla = 3 Then
                Dim frm As New frmabmAusenciaEmpleado
                frm.Empleado = mEntity
                frm.ShowDialog()
                If frm.OkSave Then Call CargarGrillas()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub EliminarItem(ByVal iRow As Integer, ByVal grilla As Long)

        Try
            If grilla = 1 Then
                Dim entity As HorarioEmpleado
                entity = CType(grdViewHorarioFijo.GetRow(iRow), HorarioEmpleado)
                If Not entity Is Nothing Then
                    If entity.ACTIVO = False Then
                        XtraMessageBox.Show("El día ya se encuentra dado de baja !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        If XtraMessageBox.Show("Desea eliminar el horario?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim obj As New HorarioEmpleadoComponent(Session.CadenaConexion)
                            entity.BeginUpdate()
                            entity.FECHABAJA = F_CurrentTimeStamp()
                            entity.IDUSUARIOBAJA = Session.Usuario.ID
                            entity.ACTIVO = False
                            If obj.SaveConTraza(entity, False) Then
                                Call CargarGrillas()
                            Else
                                XtraMessageBox.Show("Error al editar el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                End If
            ElseIf grilla = 2 Then
                Dim entity As HorarioAdicEmpleado
                entity = CType(grdViewHorarioAdicional.GetRow(iRow), HorarioAdicEmpleado)
                If Not entity Is Nothing Then
                    If entity.ACTIVO = False Then
                        XtraMessageBox.Show("El día adicional ya se encuentra dado de baja !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        If (entity.IDUSUARIOMODIFICACION = Session.Usuario.ID AndAlso Not entity.AUTORIZADO) OrElse Session.Usuario.RRHH Then
                            If XtraMessageBox.Show("Desea dar de baja el día adicional?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim obj As New HorarioAdicEmpleadoComponent(Session.CadenaConexion)
                                entity.BeginUpdate()
                                entity.FECHABAJA = F_CurrentTimeStamp()
                                entity.IDUSUARIOBAJA = Session.Usuario.ID
                                entity.ACTIVO = False
                                If obj.SaveConTraza(entity, False) Then
                                    Call CargarGrillas()
                                Else
                                    XtraMessageBox.Show("Error al dar de baja el día adicional !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If
                            End If
                        End If
                    End If
                End If
            ElseIf grilla = 3 Then
                Dim entity As AusenciaEmpleado
                entity = CType(grdViewAusencias.GetRow(iRow), AusenciaEmpleado)
                If Not entity Is Nothing Then
                    If XtraMessageBox.Show("Desea eliminar la ausencia?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim obj As New AusenciaEmpleadoComponent(Session.CadenaConexion)
                        entity.BeginUpdate()
                        entity.IDUSUARIOANULA = Session.Usuario.ID
                        entity.FECHAANULACION = DateTime.Now

                        If obj.Save(entity, False) Then
                            Call CargarGrillas()
                        Else
                            XtraMessageBox.Show("Error al editar el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub EditarItem(ByVal iRow As Integer, ByVal grilla As Long)
        Try
            If grilla = 1 Then
                Dim entity As HorarioEmpleado = CType(grdViewHorarioFijo.GetRow(iRow), HorarioEmpleado)
                If Not entity Is Nothing Then
                    If entity.ACTIVO Then
                        Dim frm As New frmAbmHorario
                        frm.Entity = entity
                        frm.IDEMPLEADO = entity.IDEMPLEADO
                        frm.NOMBREEMPLEADO = mEntity.NOMBRE
                        frm.ShowDialog()
                        If frm.OkSave Then Call CargarGrillas()
                    Else
                        XtraMessageBox.Show("No se puede editar un horario dado de baja: ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            ElseIf grilla = 2 Then
                Dim entity As HorarioAdicEmpleado = CType(grdViewHorarioAdicional.GetRow(iRow), HorarioAdicEmpleado)
                If Not entity Is Nothing Then
                    If entity.ACTIVO Then
                        If (entity.IDUSUARIOMODIFICACION = Session.Usuario.ID AndAlso Not entity.AUTORIZADO) OrElse Session.Usuario.RRHH Then
                            Dim frm As New frmAbmHorarioAdic
                            frm.Entity = entity
                            frm.IDEMPLEADO = mEntity.ID
                            frm.NOMBREEMPLEADO = mEntity.NOMBRE
                            frm.ShowDialog()
                            If frm.OkSave Then Call CargarGrillas()
                        Else
                            XtraMessageBox.Show("Solo puede editar un horario que Ud. haya cargado y no se encuentre en estado autorizado !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        XtraMessageBox.Show("No se puede editar un horario dado de baja: ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            ElseIf grilla = 3 Then
                Dim entity As AusenciaEmpleado = CType(grdViewAusencias.GetRow(iRow), AusenciaEmpleado)
                If Not entity Is Nothing Then
                    Dim frm As New frmabmAusenciaEmpleado
                    frm.Empleado = mEntity
                    frm.Entity = entity
                    frm.ShowDialog()
                    If frm.OkSave Then Call CargarGrillas()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region

#Region "Formato controles"
    Private Sub FormatoGrillas()
        Try
            'Horarios fijos
            grdViewHorarioFijo.Columns.Add(NewColumn("ID", "ID",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("ACTIVO", "Activo"))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDEMPLEADO", "idEmpleado",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDEMPLEADO_Desc", "Empleado",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("FECHADESDE", "Fecha desde"))
            grdViewHorarioFijo.Columns.Add(NewColumn("FECHAHASTA", "Fecha hasta"))
            grdViewHorarioFijo.Columns.Add(NewColumn("DIASEMANAENTRADA_Desc", "Día de entrada"))
            grdViewHorarioFijo.Columns.Add(NewColumn("DIASEMANASALIDA_Desc", "Día de salida"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORAENTRADA_Desc", "Hora de entrada"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORASALIDA_Desc", "Hora de salida"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORAENTRADA1_Desc", "1° Hora entrada"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORASALIDA1_Desc", "1° Hora salida"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORAENTRADA2_Desc", "2° Hora entrada"))
            grdViewHorarioFijo.Columns.Add(NewColumn("HORASALIDA2_Desc", "2° Hora salida"))
            grdViewHorarioFijo.Columns.Add(NewColumn("MINUTOSACUMPLIR", "Min. a cumplir"))
            grdViewHorarioFijo.Columns.Add(NewColumn("INCLUYEFERIADOS", "Inc. Feriados"))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDUSUARIOBAJA", "idUsuarioBaja",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDUSUARIOBAJA_Desc", "Usuario Baja",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("FECHABAJA", "Fecha Baja",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDUSUARIOMODIFICACION", "idUsuarioModif",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("IDUSUARIOMODIFICACION_Desc", "Usuario Modif",,, False))
            grdViewHorarioFijo.Columns.Add(NewColumn("FECHAMODIFICACION", "Fecha Modif.",,, False))

            'Horarios adicionales
            grdViewHorarioAdicional.Columns.Add(NewColumn("ID", "ID",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("ACTIVO", "Activo"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("AUTORIZADO", "Autorizado"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDEMPLEADO", "idEmpleado",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDEMPLEADO_Desc", "Empleado",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("FECHADESDE", "Desde"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("FECHAHASTA", "Hasta"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORAENTRADA_Desc", "Hora de entrada"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORASALIDA_Desc", "Hora de salida"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORAENTRADA1_Desc", "1° Hora entrada"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORASALIDA1_Desc", "1° Hora salida"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORAENTRADA2_Desc", "2° Hora entrada"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("HORASALIDA2_Desc", "2° Hora salida"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("MINUTOSACUMPLIR", "Min. a cumplir"))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDUSUARIOBAJA", "idUsuarioBaja",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDUSUARIOBAJA_Desc", "Usuario Baja",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("FECHABAJA", "Fecha Baja",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDUSUARIOMODIFICACION", "idUsuarioModif",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("IDUSUARIOMODIFICACION_Desc", "Usuario Modif",,, False))
            grdViewHorarioAdicional.Columns.Add(NewColumn("FECHAMODIFICACION", "Fecha Modif.",,, False))

            'Ausencias
            grdViewAusencias.Columns.Add(NewColumn("ID", "Nro.",,, False))
            grdViewAusencias.Columns.Add(NewColumn("IDEMPLEADO", "Descripción",,, False))
            grdViewAusencias.Columns.Add(NewColumn("IDEMPLEADO_Desc", "Empleado",,, False))
            grdViewAusencias.Columns.Add(NewColumn("IDTIPOAUSENCIA_Desc", "Tipo de ausencia"))
            grdViewAusencias.Columns.Add(NewColumn("FECHADESDE", "Fecha desde"))
            grdViewAusencias.Columns.Add(NewColumn("FECHAHASTA", "Fecha hasta"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA", "ID jefe aprueba"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA_Desc", "Jefe aprueba"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAAPROBACION", "Fecha aprobación"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA2", "ID RRHH aprueba"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA2_Desc", "RRHH aprueba"))
            grdViewAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAAPROBACION2", "Fecha aprobación"))
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Shared Function NewColumn(ByVal FieldName As String,
                           ByVal Caption As String,
                           Optional ByVal Name As String = "",
                           Optional ByVal AllowEdit As Boolean = False,
                           Optional ByVal Visible As Boolean = True,
                           Optional ByVal TimeStamp As Boolean = False) As DevExpress.XtraGrid.Columns.GridColumn

        Try
            Dim grdColum As DevExpress.XtraGrid.Columns.GridColumn

            grdColum = New DevExpress.XtraGrid.Columns.GridColumn()
            If FieldName <> "" Then grdColum.FieldName = FieldName
            If Name <> "" Then grdColum.Name = Name
            If Caption <> "" Then grdColum.Caption = Caption
            grdColum.OptionsColumn.AllowEdit = AllowEdit
            grdColum.Visible = Visible
            If TimeStamp Then
                grdColum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                grdColum.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
            End If

            Return grdColum
        Catch ex As Exception
            'XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return Nothing
    End Function

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        If ActiveControl.Name = "grdHorarios" Then
            Call NuevoItem(grdViewHorarioFijo.FocusedRowHandle, 1)
        ElseIf ActiveControl.Name = "grdHorarioAdic" Then
            Call NuevoItem(grdViewHorarioAdicional.FocusedRowHandle, 2)
        ElseIf ActiveControl.Name = "grdAusencias" Then
            Call NuevoItem(grdViewHorarioAdicional.FocusedRowHandle, 3)
        End If
    End Sub

    Private Sub ckGetActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ckGetActivos.CheckedChanged
        CargarGrillas()
    End Sub

    Private Sub ckGetInactivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ckGetInactivos.CheckedChanged
        CargarGrillas()
    End Sub


#End Region
End Class