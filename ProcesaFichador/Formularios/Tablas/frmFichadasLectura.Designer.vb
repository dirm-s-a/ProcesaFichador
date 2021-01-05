<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichadasLectura

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichadasLectura))
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVerFichadas = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReprocesar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarPdf = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarCsv = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.beiFechaDesde = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiFechaHasta = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiGrupos = New DevExpress.XtraBars.BarEditItem()
        Me.cboGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bbiFichadasHuerfanas = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProcesaFichadas = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCambiaTipoFichada = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDescartarFichada = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLimpiarFichada = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVerificaInconsistenciasEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLimpiar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAltaFichadaManual = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiHorarios = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgArchivo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgProcesos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExportar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grdFichadas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ppaEspere = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFichadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiSalir, Me.bbiVerFichadas, Me.bbiReprocesar, Me.bbiExportarExcel, Me.bbiExportarPdf, Me.bbiExportarCsv, Me.bbiPrintPreview, Me.beiFechaDesde, Me.beiFechaHasta, Me.beiGrupos, Me.bbiFichadasHuerfanas, Me.bbiProcesaFichadas, Me.bbiCambiaTipoFichada, Me.bbiDescartarFichada, Me.bbiLimpiarFichada, Me.bbiVerificaInconsistenciasEmpleado, Me.bbiLimpiar, Me.bbiAltaFichadaManual, Me.bbiHorarios})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 38
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.cboGrupo})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1330, 116)
        Me.rctMenu.Toolbar.ShowCustomizeItem = False
        Me.rctMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiAusencias
        '
        Me.bbiAusencias.Caption = "Ausencias"
        Me.bbiAusencias.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiAusencias.Glyph = Global.ProcesaFichador.My.Resources.Resources.task_16x16
        Me.bbiAusencias.Id = 13
        Me.bbiAusencias.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.task_32x32
        Me.bbiAusencias.Name = "bbiAusencias"
        '
        'bbiSalir
        '
        Me.bbiSalir.Caption = "Salir"
        Me.bbiSalir.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSalir.Glyph = Global.ProcesaFichador.My.Resources.Resources.close_16x16
        Me.bbiSalir.Id = 14
        Me.bbiSalir.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.close_32x32
        Me.bbiSalir.Name = "bbiSalir"
        '
        'bbiVerFichadas
        '
        Me.bbiVerFichadas.Caption = "Ver fichadas"
        Me.bbiVerFichadas.Glyph = CType(resources.GetObject("bbiVerFichadas.Glyph"), System.Drawing.Image)
        Me.bbiVerFichadas.Id = 1
        Me.bbiVerFichadas.LargeGlyph = CType(resources.GetObject("bbiVerFichadas.LargeGlyph"), System.Drawing.Image)
        Me.bbiVerFichadas.Name = "bbiVerFichadas"
        '
        'bbiReprocesar
        '
        Me.bbiReprocesar.Caption = "Reprocesar"
        Me.bbiReprocesar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiReprocesar.Glyph = CType(resources.GetObject("bbiReprocesar.Glyph"), System.Drawing.Image)
        Me.bbiReprocesar.Id = 18
        Me.bbiReprocesar.LargeGlyph = CType(resources.GetObject("bbiReprocesar.LargeGlyph"), System.Drawing.Image)
        Me.bbiReprocesar.Name = "bbiReprocesar"
        '
        'bbiExportarExcel
        '
        Me.bbiExportarExcel.Caption = "Exportar Excel"
        Me.bbiExportarExcel.Enabled = False
        Me.bbiExportarExcel.Glyph = CType(resources.GetObject("bbiExportarExcel.Glyph"), System.Drawing.Image)
        Me.bbiExportarExcel.Id = 21
        Me.bbiExportarExcel.LargeGlyph = CType(resources.GetObject("bbiExportarExcel.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarExcel.Name = "bbiExportarExcel"
        '
        'bbiExportarPdf
        '
        Me.bbiExportarPdf.Caption = "ExportarPDF"
        Me.bbiExportarPdf.Enabled = False
        Me.bbiExportarPdf.Glyph = CType(resources.GetObject("bbiExportarPdf.Glyph"), System.Drawing.Image)
        Me.bbiExportarPdf.Id = 22
        Me.bbiExportarPdf.LargeGlyph = CType(resources.GetObject("bbiExportarPdf.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarPdf.Name = "bbiExportarPdf"
        '
        'bbiExportarCsv
        '
        Me.bbiExportarCsv.Caption = "Exportar Csv"
        Me.bbiExportarCsv.Enabled = False
        Me.bbiExportarCsv.Glyph = CType(resources.GetObject("bbiExportarCsv.Glyph"), System.Drawing.Image)
        Me.bbiExportarCsv.Id = 23
        Me.bbiExportarCsv.LargeGlyph = CType(resources.GetObject("bbiExportarCsv.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarCsv.Name = "bbiExportarCsv"
        '
        'bbiPrintPreview
        '
        Me.bbiPrintPreview.Caption = "Vista Preliminar"
        Me.bbiPrintPreview.Enabled = False
        Me.bbiPrintPreview.Glyph = CType(resources.GetObject("bbiPrintPreview.Glyph"), System.Drawing.Image)
        Me.bbiPrintPreview.Id = 24
        Me.bbiPrintPreview.LargeGlyph = CType(resources.GetObject("bbiPrintPreview.LargeGlyph"), System.Drawing.Image)
        Me.bbiPrintPreview.Name = "bbiPrintPreview"
        '
        'beiFechaDesde
        '
        Me.beiFechaDesde.Caption = "Fecha desde"
        Me.beiFechaDesde.Edit = Me.RepositoryItemDateEdit1
        Me.beiFechaDesde.Id = 25
        Me.beiFechaDesde.Name = "beiFechaDesde"
        Me.beiFechaDesde.Width = 99
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'beiFechaHasta
        '
        Me.beiFechaHasta.Caption = "Fecha hasta"
        Me.beiFechaHasta.Edit = Me.RepositoryItemDateEdit2
        Me.beiFechaHasta.Id = 26
        Me.beiFechaHasta.Name = "beiFechaHasta"
        Me.beiFechaHasta.Width = 99
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'beiGrupos
        '
        Me.beiGrupos.Caption = "Grupos"
        Me.beiGrupos.Edit = Me.cboGrupo
        Me.beiGrupos.Id = 27
        Me.beiGrupos.Name = "beiGrupos"
        Me.beiGrupos.Width = 125
        '
        'cboGrupo
        '
        Me.cboGrupo.AutoHeight = False
        Me.cboGrupo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION")})
        Me.cboGrupo.Name = "cboGrupo"
        '
        'bbiFichadasHuerfanas
        '
        Me.bbiFichadasHuerfanas.Caption = "Fichadas Huérfanas"
        Me.bbiFichadasHuerfanas.Glyph = CType(resources.GetObject("bbiFichadasHuerfanas.Glyph"), System.Drawing.Image)
        Me.bbiFichadasHuerfanas.Id = 28
        Me.bbiFichadasHuerfanas.LargeGlyph = CType(resources.GetObject("bbiFichadasHuerfanas.LargeGlyph"), System.Drawing.Image)
        Me.bbiFichadasHuerfanas.Name = "bbiFichadasHuerfanas"
        '
        'bbiProcesaFichadas
        '
        Me.bbiProcesaFichadas.Caption = "Pre analiza Fichadas"
        Me.bbiProcesaFichadas.Glyph = CType(resources.GetObject("bbiProcesaFichadas.Glyph"), System.Drawing.Image)
        Me.bbiProcesaFichadas.Id = 29
        Me.bbiProcesaFichadas.LargeGlyph = CType(resources.GetObject("bbiProcesaFichadas.LargeGlyph"), System.Drawing.Image)
        Me.bbiProcesaFichadas.Name = "bbiProcesaFichadas"
        '
        'bbiCambiaTipoFichada
        '
        Me.bbiCambiaTipoFichada.Caption = "Cambia Tipo Fichada"
        Me.bbiCambiaTipoFichada.Enabled = False
        Me.bbiCambiaTipoFichada.Glyph = CType(resources.GetObject("bbiCambiaTipoFichada.Glyph"), System.Drawing.Image)
        Me.bbiCambiaTipoFichada.Id = 30
        Me.bbiCambiaTipoFichada.LargeGlyph = CType(resources.GetObject("bbiCambiaTipoFichada.LargeGlyph"), System.Drawing.Image)
        Me.bbiCambiaTipoFichada.Name = "bbiCambiaTipoFichada"
        '
        'bbiDescartarFichada
        '
        Me.bbiDescartarFichada.Caption = "Descartar Fichada"
        Me.bbiDescartarFichada.Enabled = False
        Me.bbiDescartarFichada.Glyph = CType(resources.GetObject("bbiDescartarFichada.Glyph"), System.Drawing.Image)
        Me.bbiDescartarFichada.Id = 31
        Me.bbiDescartarFichada.LargeGlyph = CType(resources.GetObject("bbiDescartarFichada.LargeGlyph"), System.Drawing.Image)
        Me.bbiDescartarFichada.Name = "bbiDescartarFichada"
        '
        'bbiLimpiarFichada
        '
        Me.bbiLimpiarFichada.Caption = "Limpiar Fichada"
        Me.bbiLimpiarFichada.Enabled = False
        Me.bbiLimpiarFichada.Glyph = CType(resources.GetObject("bbiLimpiarFichada.Glyph"), System.Drawing.Image)
        Me.bbiLimpiarFichada.Id = 32
        Me.bbiLimpiarFichada.LargeGlyph = CType(resources.GetObject("bbiLimpiarFichada.LargeGlyph"), System.Drawing.Image)
        Me.bbiLimpiarFichada.Name = "bbiLimpiarFichada"
        '
        'bbiVerificaInconsistenciasEmpleado
        '
        Me.bbiVerificaInconsistenciasEmpleado.Caption = "Pre Analiza Empleado"
        Me.bbiVerificaInconsistenciasEmpleado.Enabled = False
        Me.bbiVerificaInconsistenciasEmpleado.Glyph = CType(resources.GetObject("bbiVerificaInconsistenciasEmpleado.Glyph"), System.Drawing.Image)
        Me.bbiVerificaInconsistenciasEmpleado.Id = 33
        Me.bbiVerificaInconsistenciasEmpleado.LargeGlyph = CType(resources.GetObject("bbiVerificaInconsistenciasEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.bbiVerificaInconsistenciasEmpleado.Name = "bbiVerificaInconsistenciasEmpleado"
        '
        'bbiLimpiar
        '
        Me.bbiLimpiar.Caption = "Limpiar Grilla"
        Me.bbiLimpiar.Enabled = False
        Me.bbiLimpiar.Glyph = CType(resources.GetObject("bbiLimpiar.Glyph"), System.Drawing.Image)
        Me.bbiLimpiar.Id = 35
        Me.bbiLimpiar.LargeGlyph = CType(resources.GetObject("bbiLimpiar.LargeGlyph"), System.Drawing.Image)
        Me.bbiLimpiar.Name = "bbiLimpiar"
        '
        'bbiAltaFichadaManual
        '
        Me.bbiAltaFichadaManual.Caption = "Alta Fichada Manual"
        Me.bbiAltaFichadaManual.Glyph = CType(resources.GetObject("bbiAltaFichadaManual.Glyph"), System.Drawing.Image)
        Me.bbiAltaFichadaManual.Id = 36
        Me.bbiAltaFichadaManual.LargeGlyph = CType(resources.GetObject("bbiAltaFichadaManual.LargeGlyph"), System.Drawing.Image)
        Me.bbiAltaFichadaManual.Name = "bbiAltaFichadaManual"
        '
        'bbiHorarios
        '
        Me.bbiHorarios.Caption = "Horario Empleado"
        Me.bbiHorarios.Enabled = False
        Me.bbiHorarios.Glyph = CType(resources.GetObject("bbiHorarios.Glyph"), System.Drawing.Image)
        Me.bbiHorarios.Id = 37
        Me.bbiHorarios.LargeGlyph = CType(resources.GetObject("bbiHorarios.LargeGlyph"), System.Drawing.Image)
        Me.bbiHorarios.Name = "bbiHorarios"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.rpgArchivo, Me.rpgProcesos, Me.rpgExportar})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Fichadas"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiSalir)
        Me.rpgAcciones.Name = "rpgAcciones"
        '
        'rpgArchivo
        '
        Me.rpgArchivo.ItemLinks.Add(Me.beiFechaDesde)
        Me.rpgArchivo.ItemLinks.Add(Me.beiFechaHasta)
        Me.rpgArchivo.ItemLinks.Add(Me.beiGrupos)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiVerFichadas)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiLimpiar)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiCambiaTipoFichada)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiDescartarFichada)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiLimpiarFichada)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiHorarios)
        Me.rpgArchivo.Name = "rpgArchivo"
        Me.rpgArchivo.Text = "Listados"
        '
        'rpgProcesos
        '
        Me.rpgProcesos.ItemLinks.Add(Me.bbiFichadasHuerfanas)
        Me.rpgProcesos.ItemLinks.Add(Me.bbiProcesaFichadas)
        Me.rpgProcesos.ItemLinks.Add(Me.bbiVerificaInconsistenciasEmpleado)
        Me.rpgProcesos.ItemLinks.Add(Me.bbiAltaFichadaManual)
        Me.rpgProcesos.Name = "rpgProcesos"
        Me.rpgProcesos.Text = "Procesos"
        '
        'rpgExportar
        '
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarExcel)
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarPdf)
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarCsv)
        Me.rpgExportar.ItemLinks.Add(Me.bbiPrintPreview)
        Me.rpgExportar.Name = "rpgExportar"
        Me.rpgExportar.Text = "Reportes"
        '
        'grdFichadas
        '
        Me.grdFichadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFichadas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdFichadas.Location = New System.Drawing.Point(0, 116)
        Me.grdFichadas.MainView = Me.GridView1
        Me.grdFichadas.Margin = New System.Windows.Forms.Padding(5)
        Me.grdFichadas.Name = "grdFichadas"
        Me.grdFichadas.Size = New System.Drawing.Size(1330, 483)
        Me.grdFichadas.TabIndex = 7
        Me.grdFichadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdFichadas
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, Nothing, Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'ppaEspere
        '
        Me.ppaEspere.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ppaEspere.Appearance.Options.UseBackColor = True
        Me.ppaEspere.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ppaEspere.AppearanceCaption.Options.UseFont = True
        Me.ppaEspere.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ppaEspere.AppearanceDescription.Options.UseFont = True
        Me.ppaEspere.Caption = "Espere por favor!"
        Me.ppaEspere.Description = "Procesando ..."
        Me.ppaEspere.Location = New System.Drawing.Point(463, 284)
        Me.ppaEspere.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.ppaEspere.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ppaEspere.Name = "ppaEspere"
        Me.ppaEspere.Size = New System.Drawing.Size(199, 77)
        Me.ppaEspere.TabIndex = 28
        Me.ppaEspere.Visible = False
        '
        'frmFichadasLectura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 599)
        Me.Controls.Add(Me.ppaEspere)
        Me.Controls.Add(Me.grdFichadas)
        Me.Controls.Add(Me.rctMenu)
        Me.Name = "frmFichadasLectura"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFichadasLectura"
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFichadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiAusencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVerFichadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReprocesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgArchivo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarPdf As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarCsv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdFichadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents beiFechaDesde As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiFechaHasta As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiGrupos As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiFichadasHuerfanas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiProcesaFichadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgProcesos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiCambiaTipoFichada As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDescartarFichada As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ppaEspere As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents bbiLimpiarFichada As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVerificaInconsistenciasEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLimpiar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAltaFichadaManual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiHorarios As DevExpress.XtraBars.BarButtonItem
End Class
