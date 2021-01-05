Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions
Imports Turnos.GlobalFunctions.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Data
Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel
Imports System.Drawing.Printing
Imports DevExpress.XtraEditors.Repository
Public Class frmFichadasLectura
    Inherits frmBase
    Private mFichadasAgrupado As Long = 0

#Region "Exportaciones"
    Private Sub Exportar(ByVal Tipo As String, ByVal Extension As String)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Tipo & "|*." & Extension.ToLower
        saveFileDialog1.Title = "Nombre de archivo a exportar"
        saveFileDialog1.ShowDialog()


        If saveFileDialog1.FileName <> String.Empty Then
            Select Case Extension.ToLower
                Case "csv" : GridView1.ExportToCsv(saveFileDialog1.FileName)
                Case "xlsx" : GridView1.ExportToXlsx(saveFileDialog1.FileName, New XlsxExportOptions(TextExportMode.Text))
                Case "pdf" : GridView1.ExportToPdf(saveFileDialog1.FileName)
                Case "html" : GridView1.ExportToHtml(saveFileDialog1.FileName)
            End Select
        End If
    End Sub

    Private Sub PreviewPrintableComponent(component As IPrintable, lookAndFeel As UserLookAndFeel)
        ' Create a link that will print a control.  
        Dim link As New PrintableComponentLink() With {
            .PrintingSystemBase = New PrintingSystem(),
            .Component = component,
            .Landscape = True,
            .PaperKind = PaperKind.Letter,
            .Margins = New Margins(20, 20, 80, 40)}



        'Otra opción para agregar header en la sección de Texto
        'AddHandler link.CreateReportHeaderArea, AddressOf link_CreateReportHeaderArea

        link.Images.Add(Global.ProcesaFichador.My.Resources.logo_min)

        Dim phf As PageHeaderFooter = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()
        phf.Header.Content.AddRange(New String() {"", "Listado de Fichadas", "[Image 0]"})

        'phf.Header.Font = New Font("Arial", 16, FontStyle.Underline)
        phf.Header.LineAlignment = BrickAlignment.Center

        phf = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Footer.Content.AddRange(New String() {"Impreso: [Date Printed] [Time Printed]", "", "Página [Page #]/[Páginas #]"})
        'phf.Footer.Font = New Font("Arial", 8, FontStyle.Regular)
        phf.Footer.LineAlignment = BrickAlignment.Center

        link.ShowRibbonPreview(lookAndFeel)
    End Sub

#End Region

#Region "Formato Controles"
    Private Sub FormatoGrillas()
        Try
            GridView1.Columns.Clear()
            GridView1.OptionsView.ShowGroupedColumns = True
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADOLECTORA", "ID empleado Lect."))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO_Desc", "Nombre"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("IDRELOJ_Desc", "Reloj"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("FECHAFICHADA", "Fecha Fichada",,,, True))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("DIASEMANAFICHADA", "Día"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("TipoFichadaDesc", "Tipo Fichada"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("OBSERVACIONESPROCESO", "Observaciones"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("FECHAPROCESO", "Fecha Proceso",,,, True))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("ID", "ID",,, False))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("FECHALECTURA", "Fecha Lectura",,, False, True))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("IDRELOJ", "Id Reloj",,, False))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO", "ID empleado",,, False))

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

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
#End Region

#Region "Eventos Controles"
    Private Sub frmFichadasLectura_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            ppaEspere.Top = (Me.Height - ppaEspere.Height) / 2
            ppaEspere.Left = (Me.Width - ppaEspere.Width) / 2

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub frmFichadasLectura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rpgExportar.Visible = Session.Usuario.RRHH
        rpgProcesos.Visible = Session.Usuario.RRHH
        If Not Session.Usuario.SUPERVISOR Then beiGrupos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        beiFechaDesde.EditValue = Date.Today
        beiFechaHasta.EditValue = Date.Today
        Call FormatoGrillas()
        Call CargaCboGrupos()

    End Sub

    Private Sub bbiVerFichadas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVerFichadas.ItemClick
        Call ListarGrilla()
    End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        Try
            Select Case e.Column.FieldName
                Case "FECHAPROCESO"
                    If F_IsNullValue(CType(e.CellValue, Date)) Then
                        e.Appearance.BackColor = Color.Khaki
                        e.DisplayText = "SIN PROCESAR"
                    End If
                Case "OBSERVACIONESPROCESO"
                    If CType(e.CellValue, String).ToUpper = "INCONSISTENCIA" Then
                        e.Appearance.BackColor = Color.Red
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        Call Exportar("Archivo Excel", "xlsx")
    End Sub

    Private Sub bbiExportarPdf_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPdf.ItemClick
        Call Exportar("Archivo Pdf", "pdf")
    End Sub

    Private Sub bbiExportarCsv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarCsv.ItemClick
        Call Exportar("Archivo Csv", "csv")
    End Sub

    Private Sub bbiPrintPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrintPreview.ItemClick
        Call PreviewPrintableComponent(grdFichadas, grdFichadas.LookAndFeel)
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiFichadasHuerfanas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFichadasHuerfanas.ItemClick
        Call VerificaHuerfanos()
    End Sub

    Private Sub bbiProcesaFichadas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcesaFichadas.ItemClick
        Call VerificaInconsistencias()
    End Sub
    Private Sub bbiCambiaTipoFichada_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCambiaTipoFichada.ItemClick
        Call CambiaTipoFichada(GridView1.FocusedRowHandle)
    End Sub
    Private Sub bbiDescartarFichada_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDescartarFichada.ItemClick
        Call DescartarFichada(GridView1.FocusedRowHandle)
    End Sub
    Private Sub bbiLimpiarFichada_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLimpiarFichada.ItemClick
        Call LimpiarFichada(GridView1.FocusedRowHandle)
    End Sub
    Private Sub bbiVerificaInconsistenciasEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVerificaInconsistenciasEmpleado.ItemClick
        Call VerificaInconsistencias(GridView1.FocusedRowHandle)
    End Sub
    Private Sub bbiHorarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHorarios.ItemClick
        Call HorarioEmpleado(GridView1.FocusedRowHandle)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Call ActualizaDatosFila()
    End Sub

    Private Sub ActualizaDatosFila()
        Try
            bbiVerificaInconsistenciasEmpleado.Enabled = False
            Dim entity As FichadaLectura = CType(GridView1.GetFocusedRow, FichadaLectura)
            If entity Is Nothing Then Return
            bbiVerificaInconsistenciasEmpleado.Enabled = True
            bbiHorarios.Enabled = Not F_IsNullValue(entity.IDEMPLEADO)
            If entity.DESCARTADA Then
                bbiDescartarFichada.Enabled = False
                bbiCambiaTipoFichada.Enabled = False
            Else
                bbiDescartarFichada.Enabled = True
                bbiCambiaTipoFichada.Enabled = True
            End If
            If entity.DESCARTADA OrElse Not F_IsNullValue(entity.TIPOFICHADASUPERVISOR) Then
                bbiLimpiarFichada.Enabled = True
            Else
                bbiLimpiarFichada.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bbiLimpiar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLimpiar.ItemClick
        Try
            grdFichadas.DataSource = Nothing

            bbiVerificaInconsistenciasEmpleado.Enabled = False
            bbiDescartarFichada.Enabled = False
            bbiCambiaTipoFichada.Enabled = False
            bbiHorarios.Enabled = False
            bbiLimpiarFichada.Enabled = False
            bbiLimpiar.Enabled = False
            bbiVerFichadas.Enabled = True
            beiFechaDesde.Enabled = True
            beiFechaHasta.Enabled = True
            beiGrupos.Enabled = True
            bbiExportarCsv.Enabled = False
            bbiExportarExcel.Enabled = False
            bbiExportarPdf.Enabled = False
            bbiPrintPreview.Enabled = False

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
#End Region

#Region "Procesos y Funciones"
    Private Sub LimpiarFichada(ByVal iRow As Integer)
        Dim MensajeError As String = String.Empty
        Dim objTraza As New TrazaCambioComponent(Session.CadenaConexion)
        Dim entTraza As New TrazaCambio
        Try
            If Not Session.Usuario.RRHH Then
                XtraMessageBox.Show("No tiene derechos para realizar esta operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim entity As FichadaLectura = CType(GridView1.GetRow(iRow), FichadaLectura)
            If entity Is Nothing Then Exit Sub

            Dim strMensaje As String = "Desea limpiar los cambios en la fichada del empleado: " & entity.IDEMPLEADO_Desc & Environment.NewLine
            strMensaje &= "Fecha: " & entity.FECHAFICHADA & Environment.NewLine
            If F_IsNullValue(entity.IDRELOJ) Then
                entTraza.BeginUpdate()
                entTraza.IDFICHADALECTURA = entity.ID
                entTraza = objTraza.GetListByEnt(entTraza).OrderBy(Function(o) o.ID).ToList(0)
                strMensaje &= "Alta de fichada manual" & Environment.NewLine
            Else
                strMensaje &= "Reloj: " & entity.IDRELOJ_Desc & Environment.NewLine
            End If

            If XtraMessageBox.Show(strMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim objFichadaLectura As New FichadaLecturaComponent(Session.CadenaConexion)
                entity.BeginUpdate()
                entity.DESCARTADA = False
                entity.INCONSISTENCIA = False
                entity.IDUSUARIOSUPERVISORCAMBIO = F_Set_NullValue(entity.IDUSUARIOSUPERVISORCAMBIO)
                entity.OBSERVACIONESPROCESO = F_Set_NullValue(entity.OBSERVACIONESPROCESO)
                If F_IsNullValue(entity.IDRELOJ) Then
                    entity.TIPOFICHADASUPERVISOR = entTraza.IDUSUARIO
                Else
                    entity.TIPOFICHADASUPERVISOR = F_Set_NullValue(entity.TIPOFICHADASUPERVISOR)
                End If

                entity.FECHAPROCESO = F_Set_NullValue(entity.FECHAPROCESO)
                entity.FECHAFICHADASUPERVISOR = F_Set_NullValue(entity.FECHAFICHADASUPERVISOR)

                If Not objFichadaLectura.CambioEstado(entity, Session.Usuario.ID, "Se realiza limpieza de Fichada", MensajeError) Then
                    XtraMessageBox.Show("Error al intentar limpiar la fichada !" & Environment.NewLine & "Error: " & MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub CambiaTipoFichada(ByVal iRow As Integer)
        Dim TipoFichadaModif As String = ""
        Dim TipoFichadaModifDesc As String = ""
        Dim MensajeError As String = String.Empty
        Try
            If Not Session.Usuario.RRHH AndAlso Not Session.Usuario.SUPERVISOR Then
                XtraMessageBox.Show("No tiene derechos para realizar esta operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim entity As FichadaLectura = CType(GridView1.GetRow(iRow), FichadaLectura)
            If Not entity Is Nothing Then
                If Not F_IsNullValue(entity.FECHAPROCESO) Then
                    XtraMessageBox.Show("La fichada que desea modificar se encuentra marcada como 'Procesada'." & Environment.NewLine & "No puede modificar su estado en esta situación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf entity.DESCARTADA Then
                    XtraMessageBox.Show("La fichada que desea modificar se encuentra marcada como 'Descartada'." & Environment.NewLine & "No puede modificar su estado en esta situación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Not F_IsNullValue(entity.TIPOFICHADASUPERVISOR) Then
                    If Not Session.Usuario.RRHH Then
                        XtraMessageBox.Show("No tiene derechos para realizar esta operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
                Select Case entity.TIPOFICHADASUPERVISOR
                    Case "0", "128"
                        TipoFichadaModif = "129"
                        TipoFichadaModifDesc = "SALIDA"
                    Case "1", "129"
                        TipoFichadaModif = "128"
                        TipoFichadaModifDesc = "ENTRADA"
                    Case Else
                        Select Case entity.TIPOFICHADA
                            Case "0", "128"
                                TipoFichadaModif = "129"
                                TipoFichadaModifDesc = "SALIDA"
                            Case "1", "129"
                                TipoFichadaModif = "128"
                                TipoFichadaModifDesc = "ENTRADA"
                            Case Else
                                XtraMessageBox.Show("El tipo de fichada no puede ser modificado ! ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                        End Select
                End Select
                Dim strMensaje As String = "Desea cambiar el tipo de fichada del empleado: " & entity.IDEMPLEADO_Desc & Environment.NewLine
                strMensaje &= "Fecha: " & entity.FECHAFICHADA & Environment.NewLine
                If F_IsNullValue(entity.IDRELOJ) Then
                    strMensaje &= "Alta de fichada manual" & Environment.NewLine
                Else
                    strMensaje &= "Reloj: " & entity.IDRELOJ_Desc & Environment.NewLine
                End If
                strMensaje &= "Del estado: " & entity.TipoFichadaDesc & ", a su estado inverso de " & TipoFichadaModifDesc & " ?"

                If XtraMessageBox.Show(strMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    strMensaje = "Cambio el tipo de fichada del estado: " & entity.TipoFichadaDesc & ", a su estado inverso de " & TipoFichadaModifDesc

                    entity.BeginUpdate()
                    entity.TIPOFICHADASUPERVISOR = TipoFichadaModif
                    entity.IDUSUARIOSUPERVISORCAMBIO = Session.Usuario.ID
                    entity.FECHAFICHADASUPERVISOR = F_CurrentTimeStamp()
                    entity.OBSERVACIONESPROCESO = "Cambio T.Fichada"
                    entity.INCONSISTENCIA = False

                    Dim objFichadaLectura As New FichadaLecturaComponent(Session.CadenaConexion)
                    If Not objFichadaLectura.CambioEstado(entity, Session.Usuario.ID, strMensaje, MensajeError) Then
                        XtraMessageBox.Show("Error al intentar guarar los cambios en el tipo de fichada !" & Environment.NewLine & "Error: " & MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub DescartarFichada(ByVal iRow As Integer)
        Dim TipoFichadaModif As String = ""
        Dim TipoFichadaModifDesc As String = ""
        Dim MensajeError As String = String.Empty

        Try
            If Not Session.Usuario.RRHH Then
                XtraMessageBox.Show("No tiene derechos para realizar esta operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim entity As FichadaLectura = CType(GridView1.GetRow(iRow), FichadaLectura)
            If Not entity Is Nothing Then
                If Not F_IsNullValue(entity.FECHAPROCESO) Then
                    XtraMessageBox.Show("La fichada que desea modificar se encuentra marcada como 'Procesada'." & Environment.NewLine & "No puede modificar su estado en esta situación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf entity.DESCARTADA Then
                    XtraMessageBox.Show("La fichada que desea modificar se encuentra marcada como 'Descartada'." & Environment.NewLine & "No puede modificar su estado en esta situación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Dim strMensaje As String = "Desea marcar como descartada la fichada del empleado: " & entity.IDEMPLEADO_Desc & " ?" & Environment.NewLine
                strMensaje &= "Fecha: " & entity.FECHAFICHADA & Environment.NewLine
                If F_IsNullValue(entity.IDRELOJ) Then
                    strMensaje &= "Alta de fichada manual" & Environment.NewLine
                Else
                    strMensaje &= "Reloj: " & entity.IDRELOJ_Desc & Environment.NewLine
                End If


                If XtraMessageBox.Show(strMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    entity.BeginUpdate()
                    entity.DESCARTADA = True
                    entity.IDUSUARIOSUPERVISORCAMBIO = Session.Usuario.ID
                    entity.FECHAFICHADASUPERVISOR = F_CurrentTimeStamp()
                    entity.OBSERVACIONESPROCESO = "Descartada"
                    entity.INCONSISTENCIA = False
                    entity.FECHAPROCESO = F_CurrentTimeStamp()

                    Dim objFichadaLectura As New FichadaLecturaComponent(Session.CadenaConexion)
                    Dim objTrazaCambio As New TrazaCambioComponent(Session.CadenaConexion)
                    If Not objFichadaLectura.CambioEstado(entity, Session.Usuario.ID, "Fichada marcada como 'Descartada'.", MensajeError) Then
                        XtraMessageBox.Show("Error al intentar guarar los cambios en el tipo de fichada !" & Environment.NewLine & "Error: " & MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub ListarGrilla()
        Dim objFichadas As New FichadaLecturaComponent(Session.CadenaConexion)
        Dim listFichadas As New List(Of FichadaLectura)
        Dim eFichada As New FichadaLectura
        Dim eGrupo As Grupo
        Dim objGrupo As New GrupoComponent(Session.CadenaConexion)

        Try
            If Not Session.Usuario.DIRECTORRRHH AndAlso Not Session.Usuario.RRHH Then
                Dim FechaDesde As Date = beiFechaDesde.EditValue
                If DateDiff(DateInterval.Day, FechaDesde, Date.Today) > 7 Then
                    XtraMessageBox.Show("Como supervisor puede listar hasta una semana para atrás", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
            grdFichadas.DataSource = Nothing
            If Not beiGrupos.EditValue Is Nothing Then
                eGrupo = objGrupo.GetEntById(beiGrupos.EditValue)
                If Not eGrupo Is Nothing Then
                    listFichadas = objFichadas.GetTodoEntreFechasGrupo(beiFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, beiFechaHasta.EditValue), eGrupo.ID)
                Else
                    listFichadas = objFichadas.GetTodoEntreFechas(beiFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, beiFechaHasta.EditValue))
                End If
            Else
                If Session.Usuario.RRHH Then
                    listFichadas = objFichadas.GetTodoEntreFechas(beiFechaDesde.EditValue, CDate(beiFechaHasta.EditValue).AddDays(1))
                Else
                    XtraMessageBox.Show("Debe seleccionar un grupo de empleados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If listFichadas.Count > 0 Then
                grdFichadas.DataSource = listFichadas
                bbiVerFichadas.Enabled = False
                bbiLimpiar.Enabled = True
                beiFechaDesde.Enabled = False
                beiFechaHasta.Enabled = False
                beiGrupos.Enabled = False
                If Session.Usuario.RRHH Then
                    bbiExportarCsv.Enabled = True
                    bbiExportarExcel.Enabled = True
                    bbiExportarPdf.Enabled = True
                    bbiPrintPreview.Enabled = True
                End If
            End If

            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub VerificaHuerfanos()
        Dim objFichadaLectura As New FichadaLecturaComponent(Session.CadenaConexion)
        Dim strSincruzar As String = String.Empty
        Try
            Cursor = Cursors.WaitCursor
            ppaEspere.Visible = True
            Call HabilitaControles(False)
            System.Windows.Forms.Application.DoEvents()

            If objFichadaLectura.AnalizaHuerfanos(strSincruzar) Then
                If strSincruzar = String.Empty Then
                    strSincruzar = "Sin registros huérfanos pendientes"
                Else
                    strSincruzar = "Quedan aún los siguientes registros huérfanos " & vbCrLf & strSincruzar
                End If
                Cursor = Cursors.Default
                XtraMessageBox.Show("Proceso finalizado " & vbCrLf & vbCrLf & strSincruzar, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        ppaEspere.Visible = False
        Call HabilitaControles(True)
    End Sub

    Private Sub HorarioEmpleado(ByVal iRow As Integer)
        Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
        Try
            Dim entity As FichadaLectura = CType(GridView1.GetRow(iRow), FichadaLectura)
            If entity Is Nothing Then Exit Sub
            Dim entEmpleado As Empleado = objEmpleado.GetEntById(entity.IDEMPLEADO)

            If Not entEmpleado Is Nothing Then
                Dim frm As New frmTblHorarios
                frm.Entity = entEmpleado
                frm.ShowDialog()
                frm.Dispose()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub VerificaInconsistencias(ByVal iRow As Integer, Optional ByVal flgNoPreguntar As Boolean = False)
        Dim objEmpleadoComponent As New EmpleadoComponent(Session.CadenaConexion)
        Dim objFichadaLEctura As New FichadaLecturaComponent(Session.CadenaConexion)

        Dim listFichadasLectura As New List(Of FichadaLectura)
        Dim listEmpleados As New List(Of Empleado)
        Dim FechaAnterior As Date
        Dim TipoFichadaActual As String = String.Empty
        Dim TipoFichadaAnterior As String = String.Empty
        Dim flgPrimerFichadaDelDia As Boolean = False
        Dim flgIncoInconsistencia As Boolean = False
        Try
            If Not Session.Usuario.RRHH Then
                If flgNoPreguntar Then Exit Sub
                XtraMessageBox.Show("No tiene derechos para realizar esta operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim entity As FichadaLectura = CType(GridView1.GetRow(iRow), FichadaLectura)
            If entity Is Nothing Then Exit Sub

            If flgNoPreguntar = False Then
                Dim strMensaje As String = "Desea Pre analizar las fichadas del empleado: " & entity.IDEMPLEADO_Desc & " ?" & Environment.NewLine
                strMensaje &= "Desde Fecha: " & beiFechaDesde.EditValue & Environment.NewLine
                strMensaje &= "Hasta Fecha: " & beiFechaHasta.EditValue & Environment.NewLine

                If XtraMessageBox.Show(strMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> DialogResult.Yes Then Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            ppaEspere.Visible = True
            Call HabilitaControles(False)

            Dim FechaDesde As Date = beiFechaDesde.EditValue
            Dim FechaHasta As Date = beiFechaHasta.EditValue

            listFichadasLectura = objFichadaLEctura.GetxIdEmpleadoSinProcesar(entity.IDEMPLEADO)
            listFichadasLectura = listFichadasLectura.Where(Function(f) f.FECHAFICHADA >= FechaDesde And f.FECHAFICHADA < FechaHasta.AddDays(1)).ToList()

            For Each entFichadaLectura As FichadaLectura In listFichadasLectura
                System.Windows.Forms.Application.DoEvents()
                flgIncoInconsistencia = False
                If Not F_IsNullValue(entFichadaLectura.TIPOFICHADASUPERVISOR) Then
                    TipoFichadaActual = entFichadaLectura.TIPOFICHADASUPERVISOR
                Else
                    TipoFichadaActual = entFichadaLectura.TIPOFICHADA
                End If
                Select Case TipoFichadaActual
                    Case 0, 1, 128, 129
                        If Not F_IsNullValue(FechaAnterior) AndAlso Not F_IsNullValue(TipoFichadaAnterior) Then
                            If FechaAnterior.Date = entFichadaLectura.FECHAFICHADA.Date Then
                                If DateDiff(DateInterval.Minute, FechaAnterior, entFichadaLectura.FECHAFICHADA) < 1 And TipoFichadaAnterior = TipoFichadaActual Then
                                    entFichadaLectura.BeginUpdate()
                                    entFichadaLectura.DESCARTADA = True
                                    entFichadaLectura.INCONSISTENCIA = False
                                    entFichadaLectura.OBSERVACIONESPROCESO = "Repetida"
                                    entFichadaLectura.FECHAPROCESO = F_CurrentTimeStamp()
                                    objFichadaLEctura.Save(entFichadaLectura, False)
                                Else
                                    If TipoFichadaAnterior = TipoFichadaActual Then
                                        If Not entFichadaLectura.INCONSISTENCIA Then
                                            entFichadaLectura.BeginUpdate()
                                            entFichadaLectura.INCONSISTENCIA = True
                                            entFichadaLectura.DESCARTADA = False
                                            entFichadaLectura.OBSERVACIONESPROCESO = "Inconsistencia"
                                            objFichadaLEctura.Save(entFichadaLectura, False)
                                        End If
                                        flgIncoInconsistencia = True
                                    End If
                                End If
                            End If
                        End If
                    Case Else
                        entFichadaLectura.BeginUpdate()
                        If Not entFichadaLectura.DESCARTADA Then
                            entFichadaLectura.FECHAPROCESO = F_CurrentTimeStamp()
                            entFichadaLectura.DESCARTADA = True
                            entFichadaLectura.INCONSISTENCIA = False
                            entFichadaLectura.OBSERVACIONESPROCESO = "Descartada"
                            objFichadaLEctura.Save(entFichadaLectura, False)
                        End If
                End Select

                If Not flgIncoInconsistencia And entFichadaLectura.INCONSISTENCIA And F_IsNullValue(entFichadaLectura.FECHAPROCESO) Then
                    entFichadaLectura.BeginUpdate()
                    entFichadaLectura.INCONSISTENCIA = False
                    entFichadaLectura.DESCARTADA = False
                    entFichadaLectura.OBSERVACIONESPROCESO = F_Set_NullValue(entFichadaLectura.OBSERVACIONESPROCESO)
                    objFichadaLEctura.Save(entFichadaLectura, False)
                End If

                TipoFichadaAnterior = TipoFichadaActual
                FechaAnterior = entFichadaLectura.FECHAFICHADA
            Next

            If flgNoPreguntar = False Then ListarGrilla()
        Catch ex As Exception
            Cursor = Cursors.Default
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default
        ppaEspere.Visible = False
        Call HabilitaControles(True)
    End Sub
    Private Sub VerificaInconsistencias()
        Dim objEmpleadoComponent As New EmpleadoComponent(Session.CadenaConexion)
        Dim objFichadaLEctura As New FichadaLecturaComponent(Session.CadenaConexion)

        Dim listFichadasLectura As New List(Of FichadaLectura)
        Dim listEmpleados As New List(Of Empleado)
        Dim FechaAnterior As Date
        Dim TipoFichadaActual As String = String.Empty
        Dim TipoFichadaAnterior As String = String.Empty
        Dim flgPrimerFichadaDelDia As Boolean = False
        Dim flgIncoInconsistencia As Boolean = False

        Try
            Dim strMensaje As String = "Desea Pre analizar las fichadas de todos los empleados ?"

            If XtraMessageBox.Show(strMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> DialogResult.Yes Then Exit Sub

            Cursor = Cursors.WaitCursor
            ppaEspere.Visible = True
            Call HabilitaControles(False)
            listEmpleados = objEmpleadoComponent.GetAllActivos()
            For Each entEmpleado As Empleado In listEmpleados

                FechaAnterior = F_Set_NullValue(FechaAnterior)
                TipoFichadaAnterior = String.Empty

                listFichadasLectura = objFichadaLEctura.GetxIdEmpleadoSinProcesar(entEmpleado.ID)
                For Each entFichadaLectura As FichadaLectura In listFichadasLectura
                    System.Windows.Forms.Application.DoEvents()
                    flgIncoInconsistencia = False
                    If Not F_IsNullValue(entFichadaLectura.TIPOFICHADASUPERVISOR) Then
                        TipoFichadaActual = entFichadaLectura.TIPOFICHADASUPERVISOR
                    Else
                        TipoFichadaActual = entFichadaLectura.TIPOFICHADA
                    End If
                    Select Case TipoFichadaActual
                        Case 0, 1, 128, 129
                            If Not F_IsNullValue(FechaAnterior) AndAlso Not F_IsNullValue(TipoFichadaAnterior) Then
                                If FechaAnterior.Date = entFichadaLectura.FECHAFICHADA.Date Then
                                    If DateDiff(DateInterval.Minute, FechaAnterior, entFichadaLectura.FECHAFICHADA) < 1 And TipoFichadaAnterior = TipoFichadaActual Then
                                        entFichadaLectura.BeginUpdate()
                                        entFichadaLectura.DESCARTADA = True
                                        entFichadaLectura.INCONSISTENCIA = False
                                        entFichadaLectura.OBSERVACIONESPROCESO = "Repetida"
                                        entFichadaLectura.FECHAPROCESO = F_CurrentTimeStamp()
                                        objFichadaLEctura.Save(entFichadaLectura, False)
                                    Else
                                        If TipoFichadaAnterior = TipoFichadaActual Then
                                            If Not entFichadaLectura.INCONSISTENCIA Then
                                                entFichadaLectura.BeginUpdate()
                                                entFichadaLectura.INCONSISTENCIA = True
                                                entFichadaLectura.DESCARTADA = False
                                                entFichadaLectura.OBSERVACIONESPROCESO = "Inconsistencia"
                                                objFichadaLEctura.Save(entFichadaLectura, False)
                                            End If
                                            flgIncoInconsistencia = True
                                        End If
                                    End If
                                End If
                            End If
                        Case Else
                            entFichadaLectura.BeginUpdate()
                            If Not entFichadaLectura.DESCARTADA Then
                                entFichadaLectura.FECHAPROCESO = F_CurrentTimeStamp()
                                entFichadaLectura.DESCARTADA = True
                                entFichadaLectura.INCONSISTENCIA = False
                                entFichadaLectura.OBSERVACIONESPROCESO = "Descartada"
                                objFichadaLEctura.Save(entFichadaLectura, False)
                            End If
                    End Select

                    If Not flgIncoInconsistencia And entFichadaLectura.INCONSISTENCIA And F_IsNullValue(entFichadaLectura.FECHAPROCESO) Then
                        entFichadaLectura.BeginUpdate()
                        entFichadaLectura.INCONSISTENCIA = False
                        entFichadaLectura.DESCARTADA = False
                        entFichadaLectura.OBSERVACIONESPROCESO = F_Set_NullValue(entFichadaLectura.OBSERVACIONESPROCESO)
                        objFichadaLEctura.Save(entFichadaLectura, False)
                    End If

                    TipoFichadaAnterior = TipoFichadaActual
                    FechaAnterior = entFichadaLectura.FECHAFICHADA
                Next
            Next
            ppaEspere.Visible = False
            Cursor = Cursors.Default
            Call ListarGrilla()
            MsgBox("Proceso completado.", MsgBoxStyle.Information, "Información")

        Catch ex As Exception
            Cursor = Cursors.Default
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Call HabilitaControles(True)
    End Sub

    Private Sub HabilitaControles(ByVal flgHabilitado As Boolean)
        Try
            rpgArchivo.Enabled = flgHabilitado
            rpgExportar.Enabled = flgHabilitado
            rpgProcesos.Enabled = flgHabilitado
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bbiAltaFichadaManual_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAltaFichadaManual.ItemClick
        Try
            Dim frm As New frmAbmFichadas
            frm.ShowDialog()
            If frm.OkSave Then
                Call ListarGrilla()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_ColumnFilterChanged(sender As Object, e As EventArgs) Handles GridView1.ColumnFilterChanged
        Call ActualizaDatosFila()
    End Sub
#End Region

End Class