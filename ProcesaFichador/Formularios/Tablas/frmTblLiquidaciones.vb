
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports ProcesaFichador.AppSharedFunctions

'Para impresión de la Grilla
Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid
Imports DevExpress.Data

Public Class frmTblLiquidaciones
    Inherits frmBase

    Private mListConvenios As List(Of Convenio)
#Region "Formato Controles"
    Private Sub FormatoGrillas()
        Try
            gViewLiquidaciones.OptionsView.ShowGroupedColumns = True

            gViewLiquidaciones.OptionsSelection.MultiSelect = False
            gViewLiquidaciones.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            gViewLiquidaciones.Columns.Add(NewColumn("ID", "Código",,, False))
            gViewLiquidaciones.Columns.Add(NewColumn("IDEMPLEADO", "Id Empleado",,, False))
            gViewLiquidaciones.Columns.Add(NewColumn("IDEMPLEADO_Desc", "Empleado"))
            gViewLiquidaciones.Columns.Add(NewColumn("IDCONVENIO_Desc", "Convenio"))
            gViewLiquidaciones.Columns.Add(NewColumn("IDCONVENIO", "Id Convenio",,, False))
            gViewLiquidaciones.Columns.Add(NewColumn("FECHADESDE", "Desde"))
            gViewLiquidaciones.Columns.Add(NewColumn("FECHAHASTA", "Hasta"))
            gViewLiquidaciones.Columns.Add(NewColumn("FECHALIQUDACION", "Fecha Liq"))
            gViewLiquidaciones.Columns.Add(NewColumn("AUSENCIASCONPRESENTISMO", "Au c/Presentismo"))
            gViewLiquidaciones.Columns.Add(NewColumn("AUSENCIASJUSTIFICADAS", "Au c/Justif"))
            gViewLiquidaciones.Columns.Add(NewColumn("AUSENCIASINJUSTIFICADAS", "Au s/Justif"))
            gViewLiquidaciones.Columns.Add(NewColumn("DIASTRABAJADOS", "D. Trabajados"))
            gViewLiquidaciones.Columns.Add(NewColumn("MINUTOSTARDE", "Min. tarde"))
            gViewLiquidaciones.Columns.Add(NewColumn("INCONSISTENCIAS", "Inconsistencias"))
            gViewLiquidaciones.Columns.Add(NewColumn("PRESENTISMO", "Presentismo"))
            gViewLiquidaciones.Columns.Add(NewColumn("MEDIOPRESENTISMO", "1/2 Presentismo"))


            gViewEventosFichadas.Columns.Clear()
            gViewEventosFichadas.OptionsView.ShowGroupedColumns = True
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO_Desc", "Nombre"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("FECHAENTRADA", "Fecha Entrada",,,, True))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("DIASEMANAENTRADA", "Día Entrada"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("FECHASALIDA", "Fecha Salida",,,, True))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("DIASEMANASALIDA", "Día Salida",,, False))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("INCONSISTENCIA", "Inconsistencia"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("OBSERVACIONES", "Observaciones"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("MINUTOSTRABAJADOS", "Minutos Trabajados"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("MINUTOSTARDE", "Minutos Tarde"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("AUSENTE", "Ausente"))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("ID", "ID",,, False))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDEMPLEADO", "ID empleado",,, False))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDCONVENIO", "ID Convenio",,, False))
            gViewEventosFichadas.Columns.Add(AppSharedFunctions.NewColumn("IDCONVENIO_Desc", "Convenio",,, False))

            Dim item As GridGroupSummaryItem = New GridGroupSummaryItem(SummaryItemType.Custom, "ID", Nothing, "")
            gViewEventosFichadas.GroupSummary.Add(item)

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Eventos controles"

    Private Sub frmTblLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)
            mListConvenios = objConvenio.GetALL
            Call FormatoGrillas()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub frmTblLiquidaciones_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            'grdLiquidaciones.Width = Me.Width - grdLiquidaciones.Left - 20
            'grdLiquidaciones.Top = rctMenu.Height
            'grdLiquidaciones.Height = Me.Height - grdLiquidaciones.Top - 40
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub grdViewEventosFichadas_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gViewEventosFichadas.CustomDrawCell
        Try
            Dim view As GridView = CType(sender, GridView)
            Dim ent As EventoFichada = CType(view.GetRow(e.RowHandle), EventoFichada)
            Select Case e.Column.FieldName
                Case "AUSENTE"
                    If ent.AUSENTE Then e.Appearance.BackColor = Color.Red
                Case "INCONSISTENCIA"
                    If ent.INCONSISTENCIA Then e.Appearance.BackColor = Color.Red
                Case "MINUTOSTARDE"
                    Dim entConvenio As Convenio = mListConvenios.Where(Function(f) f.ID.Equals(ent.IDCONVENIO)).ToList(0)
                    If ent.MINUTOSTARDE > entConvenio.MINUTOSTOPE Then
                        e.Appearance.BackColor = Color.Red
                    ElseIf ent.MINUTOSTARDE > entConvenio.MINUTOSGRACIA Then
                        e.Appearance.BackColor = Color.LightYellow
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmTblLiquidaciones_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Se utiliza para hacer que la pantalla levante arriba de todo, pero no de forma permanente
        Me.TopMost = True
        Me.TopMost = False
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
        Call PreviewPrintableComponent(grdLiquidaciones, grdLiquidaciones.LookAndFeel)
    End Sub

    Private Sub bbiExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExit.ItemClick
        Me.Hide()
    End Sub

    Private Sub grdViewLiquidaciones_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gViewLiquidaciones.CustomDrawCell
        Try
            Dim view As GridView = CType(sender, GridView)
            Dim ent As Liquidacion = CType(view.GetRow(e.RowHandle), Liquidacion)
            Select Case e.Column.FieldName
                Case "PRESENTISMO"
                    If ent.PRESENTISMO Then
                        e.Appearance.BackColor = Color.Green
                    ElseIf ent.MEDIOPRESENTISMO Then
                        e.Appearance.BackColor = Color.LightYellow
                    Else
                        e.Appearance.BackColor = Color.Red
                    End If
                Case "MEDIOPRESENTISMO"
                    If CType(e.CellValue, Boolean) Then
                        e.Appearance.BackColor = Color.LightYellow
                    ElseIf ent.PRESENTISMO Then
                        e.Appearance.BackColor = Color.Green
                    Else
                        e.Appearance.BackColor = Color.Red
                    End If
                Case "INCONSISTENCIAS"
                    If ent.INCONSISTENCIAS > 0 Then e.Appearance.BackColor = Color.Red
                Case "AUSENCIASJUSTIFICADAS"
                    If ent.AUSENCIASJUSTIFICADAS > 0 Then e.Appearance.BackColor = Color.LightYellow
                Case "AUSENCIASINJUSTIFICADAS"
                    If ent.AUSENCIASINJUSTIFICADAS > 0 Then e.Appearance.BackColor = Color.Red
                Case "DIASMEDIOPRESENTISMO"
                    If ent.DIASMEDIOPRESENTISMO > 0 Then e.Appearance.BackColor = Color.LightYellow
                Case "DIASSINPRESENTISMO"
                    If ent.DIASSINPRESENTISMO > 0 Then e.Appearance.BackColor = Color.Red
                Case "MINUTOSTARDE"
                    Dim entConvenio As Convenio = mListConvenios.Where(Function(f) f.ID.Equals(ent.IDCONVENIO)).ToList(0)
                    If ent.MINUTOSTARDE > entConvenio.MINUTOSTOPE Then
                        e.Appearance.BackColor = Color.Red
                    ElseIf ent.MINUTOSTARDE > entConvenio.MINUTOSGRACIA Then
                        e.Appearance.BackColor = Color.LightYellow
                    End If

            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Procedimientos y Eventos"
    Private Sub Exportar(ByVal Tipo As String, ByVal Extension As String)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Tipo & "|*." & Extension.ToLower
        saveFileDialog1.Title = "Nombre de archivo a exportar"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> String.Empty Then
            Select Case Extension.ToLower
                Case "csv" : gViewLiquidaciones.ExportToCsv(saveFileDialog1.FileName)
                Case "xlsx" : gViewLiquidaciones.ExportToXlsx(saveFileDialog1.FileName)
                Case "pdf" : gViewLiquidaciones.ExportToPdf(saveFileDialog1.FileName)
                Case "html" : gViewLiquidaciones.ExportToHtml(saveFileDialog1.FileName)
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

        link.Images.Add(Global.ProcesaFichador.My.Resources.Resources.logo_min)

        Dim phf As PageHeaderFooter = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()
        phf.Header.Content.AddRange(New String() {"", "Listado de liquidaciones de Empleados", "[Image 0]"})
        phf.Header.Font = New Font("Arial", 16, FontStyle.Underline)
        phf.Header.LineAlignment = BrickAlignment.Center

        phf = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Footer.Content.AddRange(New String() {"Impreso: [Date Printed] [Time Printed]", "", "Página [Page #]/[Páginas #]"})
        phf.Footer.Font = New Font("Arial", 8, FontStyle.Regular)
        phf.Footer.LineAlignment = BrickAlignment.Center

        link.ShowRibbonPreview(lookAndFeel)
    End Sub

    Private Sub CargarGrillaEventos(ByVal idLiquidacion As Long)
        Dim obj As New EventoFichadaComponent(Session.CadenaConexion)
        Try
            Dim List As List(Of EventoFichada) = obj.GetByIdLiquidacion(idLiquidacion)
            grdEventosFichadas.DataSource = Nothing
            grdEventosFichadas.DataSource = List
            gViewEventosFichadas.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub CargarGrilla()
        Dim obj As New LiquidacionComponent(Session.CadenaConexion)
        Dim List As List(Of Liquidacion)

        Try
            If beiFechaHasta.EditValue Is Nothing OrElse beiFechaHasta.EditValue Is Nothing Then
                XtraMessageBox.Show("Debe ingresar un rango de fechas para listas liquidaciones.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            List = obj.GetTodoEntreFechas(beiFechaDesde.EditValue, beiFechaHasta.EditValue)

            grdLiquidaciones.DataSource = List
            gViewLiquidaciones.BestFitColumns()
            If List.Count = 0 Then
                XtraMessageBox.Show("Si registros entre las fechas selccionadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                beiFechaDesde.Enabled = False
                beiFechaHasta.Enabled = False
                beiListar.Enabled = False
                rpgExportar.Enabled = True
                beiLimpiarGrilla.Enabled = True
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub gViewLiquidaciones_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gViewLiquidaciones.FocusedRowChanged
        Call ActualizaFilaLiquidaciones()
    End Sub

    Private Sub ActualizaFilaLiquidaciones()
        Try
            Dim entity As Liquidacion = CType(gViewLiquidaciones.GetFocusedRow, Liquidacion)
            If entity Is Nothing Then
                grdEventosFichadas.DataSource = Nothing
            Else
                Call CargarGrillaEventos(entity.ID)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub bbiListar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles beiListar.ItemClick
        Call CargarGrilla()
    End Sub

    Private Sub beiLimpiarGrilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles beiLimpiarGrilla.ItemClick
        grdLiquidaciones.DataSource = Nothing
        grdEventosFichadas.DataSource = Nothing
        beiLimpiarGrilla.Enabled = False
        rpgExportar.Enabled = False
        beiFechaDesde.Enabled = True
        beiFechaHasta.Enabled = True
        beiListar.Enabled = True
    End Sub

    Private Sub gViewLiquidaciones_ColumnFilterChanged(sender As Object, e As EventArgs) Handles gViewLiquidaciones.ColumnFilterChanged
        Call ActualizaFilaLiquidaciones()
    End Sub


#End Region


End Class