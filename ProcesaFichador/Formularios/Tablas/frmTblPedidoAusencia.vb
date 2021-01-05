Imports DevExpress.XtraEditors
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions.Data

Public Class frmTblPedidoAusencia
    Inherits frmBase

    Private Sub CargaCboGrupos()
        Try
            Dim list As New List(Of GrupoSupervisor)
            Dim objGrupoSup As New GrupoSupervisorComponent(Session.CadenaConexion)
            Dim eGrupoSupervisor As New GrupoSupervisor

            Dim objGrupo As New GrupoComponent(Session.CadenaConexion)
            Dim ListGrupos As New List(Of Grupo)
            Dim eGrupo As New Grupo

            If Session.Usuario.RRHH Then
                ListGrupos = objGrupo.GetALL
            Else
                eGrupoSupervisor.BeginUpdate()
                eGrupoSupervisor.IDUSUARIOSUP = Session.Usuario.ID

                list = objGrupoSup.GetListByEnt(eGrupoSupervisor)
                For Each eGrupoSupervisor In list
                    eGrupo = objGrupo.GetEntById(eGrupoSupervisor.IDGRUPO)
                    ListGrupos.Add(eGrupo)
                Next

            End If

            cboGrupo.DisplayMember = "DESCRIPCION"
            cboGrupo.ValueMember = "ID"
            cboGrupo.DataSource = ListGrupos
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub listarGrilla()
        Dim objAusencias As New AusenciaEmpleadoComponent(Session.CadenaConexion)
        Dim listAusencias As New List(Of AusenciaEmpleado)
        Dim eGrupo As Grupo
        Dim objGrupo As New GrupoComponent(Session.CadenaConexion)

        Try
            grdSolicitudAusencias.DataSource = Nothing
            If Not beiGrupos.EditValue Is Nothing Then
                eGrupo = objGrupo.GetEntById(beiGrupos.EditValue)
                If Not eGrupo Is Nothing Then
                    listAusencias = objAusencias.GetTodoEntreFechasGrupo(beiFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, beiFechaHasta.EditValue), eGrupo.ID)
                Else
                    listAusencias = objAusencias.GetEntreFechas(beiFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, beiFechaHasta.EditValue))
                End If
            Else
                If Session.Usuario.RRHH Then
                    listAusencias = objAusencias.GetEntreFechas(beiFechaDesde.EditValue, CDate(beiFechaHasta.EditValue).AddDays(1))
                Else
                    XtraMessageBox.Show("Debe seleccionar un grupo de empleados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            listAusencias = listAusencias.Where(Function(f) f.IDUSUARIOANULA = String.Empty).ToList

            grdSolicitudAusencias.DataSource = listAusencias

            gViewSolicitudAusencias.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Try
            Dim fmrFinder As New xtraFinder
            Dim entEmpleado As Empleado

            Call fmrFinder.BuscarGrupoEmpleado()
            fmrFinder.ShowDialog()
            entEmpleado = fmrFinder.ObjetoSeleccionado

            If Not entEmpleado Is Nothing Then
                Dim frm As New frmabmAusenciaEmpleado
                frm.Empleado = entEmpleado
                frm.ShowDialog()
                If frm.OkSave Then Call listarGrilla()
            Else
                XtraMessageBox.Show("Debe seleccionar un empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim entity As AusenciaEmpleado = CType(gViewSolicitudAusencias.GetFocusedRow(), AusenciaEmpleado)
        If Not entity Is Nothing Then
            If entity.FECHAHASTA >= DateTime.Today Then
                If Not F_IsNullValue(entity.IDUSUARIOANULA) Then
                    XtraMessageBox.Show("La solicitud de Ausencia ya se encuentra dada de baja", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Not F_IsNullValue(entity.IDUSUARIOAPRUEBA) Then
                    If Not Session.Usuario.DIRECTORRRHH Then
                        XtraMessageBox.Show("Solamente puede dar de baja, una solicitud aprobada de ausencia, un usuario con perfil de Director de RRHH", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
                If XtraMessageBox.Show("Está seguro que desea eliminar la ausencia seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    entity.BeginUpdate()
                    entity.IDUSUARIOANULA = Session.Usuario.ID
                    entity.FECHAANULACION = F_CurrentTimeStamp()

                    Dim obj As New AusenciaEmpleadoComponent(Session.CadenaConexion)

                    If obj.SaveConTraza(entity, Session.Usuario.ID, False) Then
                        XtraMessageBox.Show("Ausencia dada de baja", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call listarGrilla()
                    Else
                        XtraMessageBox.Show("Error al dar de baja la ausencia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                XtraMessageBox.Show("No puede dar de baja una ausencia pasada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub bbiListar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListar.ItemClick
        listarGrilla()
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Hide()
    End Sub

    Private Sub FormatoGrillas()
        Try
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("ID", "ID",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO", "idEmpleado",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO_Desc", "Nombre"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHADESDE", "Fecha desde"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAHASTA", "Fecha hasta"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDTIPOAUSENCIA", "IDTIPOAUSENCIA",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDTIPOAUSENCIA_Desc", "Tipo de ausencia"))

            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOSOLICITA", "ID Solicitante",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOSOLICITA_Desc", "Solicitante"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHASOLICITUD", "F. Solicitud"))

            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOVALIDA", "ID Validador",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOVALIDA_Desc", "Validador"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAVALIDACION", "F. Validación"))

            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA", "ID Aprueba",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOAPRUEBA_Desc", "Aprueba"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAAPROBACION", "F. Aprobación"))

            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOANULA", "ID Anula",,, False))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("IDUSUARIOANULA_Desc", "Anula"))
            gViewSolicitudAusencias.Columns.Add(AppSharedFunctions.NewColumn("FECHAANULACION", "F. Anulación"))
            'GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            'GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            'GridView1.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            'GridView1.Columns(12).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmPedidoAusencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FormatoGrillas()
            Call CargaCboGrupos()

            If Session.Usuario.RRHH Then bbiAutoRRHH.Enabled = True
            If Session.Usuario.SUPERVISOR Then bbiAutoJefe.Enabled = True

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiAutoRRHH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAutoRRHH.ItemClick
        Try
            Dim ent As AusenciaEmpleado = CType(gViewSolicitudAusencias.GetFocusedRow(), AusenciaEmpleado)
            Dim objAusencia As New AusenciaEmpleadoComponent(Session.CadenaConexion)

            If Not ent Is Nothing Then
                If Not F_IsNullValue(ent.IDUSUARIOANULA) Then
                    XtraMessageBox.Show("La ausencia se encuentra anulada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Not F_IsNullValue(ent.IDUSUARIOAPRUEBA) Then
                    XtraMessageBox.Show("La ausencia ya está Aprobada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If XtraMessageBox.Show("Desea Aprobar la ausencia seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ent.BeginUpdate()
                        ent.IDUSUARIOAPRUEBA = Session.Usuario.ID
                        ent.FECHAAPROBACION = F_CurrentTimeStamp()

                        If objAusencia.SaveConTraza(ent, Session.Usuario.ID, False) Then
                            XtraMessageBox.Show("Aprobado correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            listarGrilla()
                        Else
                            XtraMessageBox.Show("Error al aprobar la solicitud de ausencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiAutoJefe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAutoJefe.ItemClick
        Try
            Dim ent As AusenciaEmpleado = CType(gViewSolicitudAusencias.GetFocusedRow(), AusenciaEmpleado)
            Dim objAusencia As New AusenciaEmpleadoComponent(Session.CadenaConexion)

            If Not ent Is Nothing Then
                If Not F_IsNullValue(ent.IDUSUARIOANULA) Then
                    XtraMessageBox.Show("La ausencia se encuentra anulada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Not F_IsNullValue(ent.IDUSUARIOAPRUEBA) Then
                    XtraMessageBox.Show("La ausencia ya está Aprobada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Not F_IsNullValue(ent.IDUSUARIOVALIDA) Then
                    XtraMessageBox.Show("La ausencia ya está validada por un supervisor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If XtraMessageBox.Show("Desea validar la ausencia seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ent.BeginUpdate()
                        ent.IDUSUARIOVALIDA = Session.Usuario.ID
                        ent.FECHAVALIDACION = F_CurrentTimeStamp()

                        If objAusencia.SaveConTraza(ent, Session.Usuario.ID, False) Then
                            XtraMessageBox.Show("Validado correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            listarGrilla()
                        Else
                            XtraMessageBox.Show("Error al validar la solicitud de ausencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class