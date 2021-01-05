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
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmTblEventosFichadas
    Inherits frmBase
    Private mEventosAgrupado As Long = 0
    Private mflgConObservaciones As Boolean = False

#Region "Exportaciones"
    Private Sub Exportar(ByVal Tipo As String, ByVal Extension As String)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Tipo & "|*." & Extension.ToLower
        saveFileDialog1.Title = "Nombre de archivo a exportar"
        saveFileDialog1.ShowDialog()


        If saveFileDialog1.FileName <> String.Empty Then
            Select Case Extension.ToLower
                Case "csv" : grdViewEventosFichadas.ExportToCsv(saveFileDialog1.FileName)
                Case "xlsx" : grdViewEventosFichadas.ExportToXlsx(saveFileDialog1.FileName, New XlsxExportOptions(TextExportMode.Text))
                Case "pdf" : grdViewEventosFichadas.ExportToPdf(saveFileDialog1.FileName)
                Case "html" : grdViewEventosFichadas.ExportToHtml(saveFileDialog1.FileName)
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
        phf.Header.Content.AddRange(New String() {"", "Listado de Eventos de fichadas", "[Image 0]"})

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
            grdViewEventosFichadas.Columns.Clear()
            grdViewEventosFichadas.OptionsView.ShowGroupedColumns = True
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO_Desc", "Nombre"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("FECHAENTRADA", "Fecha Entrada",,,, True))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("DIASEMANAENTRADA", "Día Entrada"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("FECHASALIDA", "Fecha Salida",,,, True))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("DIASEMANASALIDA", "Día Salida",,, False))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("INCONSISTENCIA", "Inconsistencia"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("OBSERVACIONES", "Observaciones"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("MINUTOSTRABAJADOS", "Minutos Trabajados"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("MINUTOSTARDE", "Minutos Tarde"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("AUSENTE", "Ausente"))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("ID", "ID",,, False))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO", "ID empleado",,, False))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDCONVENIO", "ID Convenio",,, False))
            grdViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDCONVENIO_Desc", "Convenio",,, False))

            Dim item As GridGroupSummaryItem = New GridGroupSummaryItem(SummaryItemType.Custom, "ID", Nothing, "")
            grdViewEventosFichadas.GroupSummary.Add(item)
            'grdViewEventosFichadas.GroupSummary(0).Tag = 1

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region

#Region "Eventos Controles"
    Private Sub grdViewEventosFichadas_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdViewEventosFichadas.FocusedRowChanged
        Call ActualizaView()
    End Sub

    Private Sub ActualizaView()
        Try
            Dim entity As EventoFichada = CType(grdViewEventosFichadas.GetFocusedRow, EventoFichada)
            If entity Is Nothing Then Return
            bbiVerHorario.Enabled = Not F_IsNullValue(entity.IDEMPLEADO)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmFichadasLectura_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            ppaEspere.Top = (Me.Height - ppaEspere.Height) / 2
            ppaEspere.Left = (Me.Width - ppaEspere.Width) / 2

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub frmFichadasLectura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaDesde.EditValue = Date.Today
        dtpFechaHasta.EditValue = Date.Today
        Call FormatoGrillas()
        Call CargaCboGrupos()

        If Not Session.Usuario.SUPERVISOR Then beiGrupos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub bbiVerFichadas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVerFichadas.ItemClick
        Call ListarGrilla()
    End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles grdViewEventosFichadas.CustomDrawCell

        Try
            Select Case e.Column.FieldName
                Case "INCONSISTENCIA"
                    If CType(e.CellValue, Boolean) Then
                        e.Appearance.BackColor = Color.Red
                    End If
                Case "AUSENTE"
                    If CType(e.CellValue, Boolean) Then
                        e.Appearance.BackColor = Color.Red
                    End If
                Case "MINUTOSTARDE"
                    If CType(e.CellValue, Integer) > 10 Then
                        e.Appearance.BackColor = Color.Red
                    ElseIf CType(e.CellValue, Integer) > 0 Then
                        e.Appearance.BackColor = Color.Yellow
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
        Call PreviewPrintableComponent(grdEventosFichadas, grdEventosFichadas.LookAndFeel)
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Hide()
    End Sub
    Private Sub bbiHorarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVerHorario.ItemClick
        Call HorarioEmpleado(grdViewEventosFichadas.FocusedRowHandle)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdViewEventosFichadas.FocusedRowChanged
        Dim view As GridView = sender
        Try
            If view Is Nothing Then Return
            Dim entity As FichadaLectura = CType(grdViewEventosFichadas.GetRow(e.FocusedRowHandle), FichadaLectura)
            If entity Is Nothing Then Return
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiLimpiar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLimpiar.ItemClick
        Try
            grdEventosFichadas.DataSource = Nothing
            bbiVerHorario.Enabled = False
            bbiLimpiar.Enabled = False
            bbiVerFichadas.Enabled = True
            beiGrupos.Enabled = True
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
            bbiExportarExcel.Enabled = False
            bbiExportarCsv.Enabled = False
            bbiExportarPdf.Enabled = False
            bbiPrintPreview.Enabled = False
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

#End Region

#Region "Procesos y Funciones"
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

    Private Sub ListarGrilla()
        Dim objEventoFichada As New EventoFichadaComponent(Session.CadenaConexion)
        Dim ListEventoFichada As New List(Of EventoFichada)
        Dim eFichada As New EventoFichada
        Dim eGrupo As Grupo
        Dim objGrupo As New GrupoComponent(Session.CadenaConexion)

        Try
            grdEventosFichadas.DataSource = Nothing
            If Not beiGrupos.EditValue Is Nothing Then
                eGrupo = objGrupo.GetEntById(beiGrupos.EditValue)
                If Not eGrupo Is Nothing Then
                    ListEventoFichada = objEventoFichada.GetTodoEntreFechaseEntradaGrupo(dtpFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, dtpFechaHasta.EditValue), eGrupo.ID)
                Else
                    ListEventoFichada = objEventoFichada.GetTodoEntreFechasEntrada(dtpFechaDesde.EditValue, DateAdd(DateInterval.Day, 1, dtpFechaHasta.EditValue))
                End If
            Else
                If Session.Usuario.RRHH Then
                    ListEventoFichada = objEventoFichada.GetTodoEntreFechasEntrada(dtpFechaDesde.EditValue, CDate(dtpFechaHasta.EditValue).AddDays(1))
                Else
                    XtraMessageBox.Show("Debe seleccionar un grupo de empleados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If ListEventoFichada.Count > 0 Then
                grdEventosFichadas.DataSource = ListEventoFichada
                bbiVerFichadas.Enabled = False
                bbiLimpiar.Enabled = True
                dtpFechaDesde.Enabled = False
                dtpFechaHasta.Enabled = False
                beiGrupos.Enabled = False
                bbiExportarExcel.Enabled = True
                bbiExportarCsv.Enabled = True
                bbiExportarPdf.Enabled = True
                bbiPrintPreview.Enabled = True
            End If

            grdViewEventosFichadas.OptionsBehavior.Editable = False
            grdViewEventosFichadas.OptionsSelection.MultiSelect = False
            grdViewEventosFichadas.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            grdViewEventosFichadas.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub HorarioEmpleado(ByVal iRow As Integer)
        Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
        Try
            Dim entity As EventoFichada = CType(grdViewEventosFichadas.GetRow(iRow), EventoFichada)
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

    Private Sub grdViewEventosFichadas_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles grdViewEventosFichadas.CustomSummaryCalculate
        Try
            Dim view As GridView = CType(sender, GridView)
            Dim summaryID As Integer = Convert.ToInt32((TryCast(e.Item, GridSummaryItem)).Tag)

            If e.SummaryProcess = CustomSummaryProcess.Start Then
                mEventosAgrupado = 0
                mflgConObservaciones = False

            ElseIf e.SummaryProcess = CustomSummaryProcess.Calculate Then
                mEventosAgrupado += 1
                If Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "AUSENTE")) OrElse
                    Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "MINUTOSTARDE")) > 0 OrElse
                    Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "INCONSISTENCIA")) Then

                    mflgConObservaciones = True
                End If
            ElseIf e.SummaryProcess = CustomSummaryProcess.Finalize Then
                e.TotalValue = "Eventos fichadas: " & mEventosAgrupado
                If mflgConObservaciones Then e.TotalValue &= ", *Con Observaciones"
                e.TotalValueReady = True

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub grdViewEventosFichadas_CustomDrawGroupRow(sender As Object, e As RowObjectCustomDrawEventArgs) Handles grdViewEventosFichadas.CustomDrawGroupRow
        Dim row As GridGroupRowInfo = e.Info
        row.GroupText = row.GroupText.Replace("Personalizado=", "")
    End Sub

    Private Sub grdViewEventosFichadas_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdViewEventosFichadas.ColumnFilterChanged
        Call ActualizaView()
    End Sub
#End Region

End Class