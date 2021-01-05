<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTblLiquidaciones

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblLiquidaciones))
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReprocesar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarPdf = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarCsv = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.beiListar = New DevExpress.XtraBars.BarButtonItem()
        Me.beiFechaDesde = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiFechaHasta = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiLimpiarGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExportar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.grdLiquidaciones = New DevExpress.XtraGrid.GridControl()
        Me.gViewLiquidaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.grdEventosFichadas = New DevExpress.XtraGrid.GridControl()
        Me.gViewEventosFichadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.grdLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.grdEventosFichadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewEventosFichadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiExit, Me.bbiReprocesar, Me.bbiExportarExcel, Me.bbiExportarPdf, Me.bbiExportarCsv, Me.bbiPrintPreview, Me.beiListar, Me.beiFechaDesde, Me.beiFechaHasta, Me.beiLimpiarGrilla})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 45
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1275, 116)
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
        'bbiExit
        '
        Me.bbiExit.Caption = "Salir"
        Me.bbiExit.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExit.Glyph = Global.ProcesaFichador.My.Resources.Resources.close_16x16
        Me.bbiExit.Id = 14
        Me.bbiExit.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.close_32x32
        Me.bbiExit.Name = "bbiExit"
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
        Me.bbiExportarExcel.Glyph = CType(resources.GetObject("bbiExportarExcel.Glyph"), System.Drawing.Image)
        Me.bbiExportarExcel.Id = 21
        Me.bbiExportarExcel.LargeGlyph = CType(resources.GetObject("bbiExportarExcel.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarExcel.Name = "bbiExportarExcel"
        '
        'bbiExportarPdf
        '
        Me.bbiExportarPdf.Caption = "ExportarPDF"
        Me.bbiExportarPdf.Glyph = CType(resources.GetObject("bbiExportarPdf.Glyph"), System.Drawing.Image)
        Me.bbiExportarPdf.Id = 22
        Me.bbiExportarPdf.LargeGlyph = CType(resources.GetObject("bbiExportarPdf.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarPdf.Name = "bbiExportarPdf"
        '
        'bbiExportarCsv
        '
        Me.bbiExportarCsv.Caption = "Exportar Csv"
        Me.bbiExportarCsv.Glyph = CType(resources.GetObject("bbiExportarCsv.Glyph"), System.Drawing.Image)
        Me.bbiExportarCsv.Id = 23
        Me.bbiExportarCsv.LargeGlyph = CType(resources.GetObject("bbiExportarCsv.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportarCsv.Name = "bbiExportarCsv"
        '
        'bbiPrintPreview
        '
        Me.bbiPrintPreview.Caption = "Vista Preliminar"
        Me.bbiPrintPreview.Glyph = CType(resources.GetObject("bbiPrintPreview.Glyph"), System.Drawing.Image)
        Me.bbiPrintPreview.Id = 24
        Me.bbiPrintPreview.LargeGlyph = CType(resources.GetObject("bbiPrintPreview.LargeGlyph"), System.Drawing.Image)
        Me.bbiPrintPreview.Name = "bbiPrintPreview"
        '
        'beiListar
        '
        Me.beiListar.Caption = "Listar"
        Me.beiListar.Glyph = CType(resources.GetObject("beiListar.Glyph"), System.Drawing.Image)
        Me.beiListar.Id = 40
        Me.beiListar.LargeGlyph = CType(resources.GetObject("beiListar.LargeGlyph"), System.Drawing.Image)
        Me.beiListar.Name = "beiListar"
        '
        'beiFechaDesde
        '
        Me.beiFechaDesde.Caption = "Fecha Desde:"
        Me.beiFechaDesde.Edit = Me.RepositoryItemDateEdit1
        Me.beiFechaDesde.Id = 42
        Me.beiFechaDesde.Name = "beiFechaDesde"
        Me.beiFechaDesde.Width = 90
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
        Me.beiFechaHasta.Caption = "Fecha Hasta:"
        Me.beiFechaHasta.Edit = Me.RepositoryItemDateEdit2
        Me.beiFechaHasta.Id = 43
        Me.beiFechaHasta.Name = "beiFechaHasta"
        Me.beiFechaHasta.Width = 90
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'beiLimpiarGrilla
        '
        Me.beiLimpiarGrilla.Caption = "Limpiar Grilla"
        Me.beiLimpiarGrilla.Enabled = False
        Me.beiLimpiarGrilla.Glyph = CType(resources.GetObject("beiLimpiarGrilla.Glyph"), System.Drawing.Image)
        Me.beiLimpiarGrilla.Id = 44
        Me.beiLimpiarGrilla.LargeGlyph = CType(resources.GetObject("beiLimpiarGrilla.LargeGlyph"), System.Drawing.Image)
        Me.beiLimpiarGrilla.Name = "beiLimpiarGrilla"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.rpgExportar})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menu"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiExit)
        Me.rpgAcciones.ItemLinks.Add(Me.beiFechaDesde)
        Me.rpgAcciones.ItemLinks.Add(Me.beiFechaHasta)
        Me.rpgAcciones.ItemLinks.Add(Me.beiListar)
        Me.rpgAcciones.ItemLinks.Add(Me.beiLimpiarGrilla)
        Me.rpgAcciones.Name = "rpgAcciones"
        '
        'rpgExportar
        '
        Me.rpgExportar.Enabled = False
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarExcel)
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarPdf)
        Me.rpgExportar.ItemLinks.Add(Me.bbiExportarCsv)
        Me.rpgExportar.ItemLinks.Add(Me.bbiPrintPreview)
        Me.rpgExportar.Name = "rpgExportar"
        Me.rpgExportar.Text = "Reportes"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 116)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1275, 564)
        Me.XtraTabControl1.TabIndex = 23
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.grdLiquidaciones)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1269, 536)
        Me.XtraTabPage1.Text = "Liquidaciones"
        '
        'grdLiquidaciones
        '
        Me.grdLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLiquidaciones.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdLiquidaciones.Location = New System.Drawing.Point(0, 0)
        Me.grdLiquidaciones.MainView = Me.gViewLiquidaciones
        Me.grdLiquidaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdLiquidaciones.Name = "grdLiquidaciones"
        Me.grdLiquidaciones.Size = New System.Drawing.Size(1269, 536)
        Me.grdLiquidaciones.TabIndex = 23
        Me.grdLiquidaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewLiquidaciones})
        '
        'gViewLiquidaciones
        '
        Me.gViewLiquidaciones.GridControl = Me.grdLiquidaciones
        Me.gViewLiquidaciones.Name = "gViewLiquidaciones"
        Me.gViewLiquidaciones.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.grdEventosFichadas)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1269, 536)
        Me.XtraTabPage2.Text = "Eventos"
        '
        'grdEventosFichadas
        '
        Me.grdEventosFichadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEventosFichadas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdEventosFichadas.Location = New System.Drawing.Point(0, 0)
        Me.grdEventosFichadas.MainView = Me.gViewEventosFichadas
        Me.grdEventosFichadas.Margin = New System.Windows.Forms.Padding(5)
        Me.grdEventosFichadas.Name = "grdEventosFichadas"
        Me.grdEventosFichadas.Size = New System.Drawing.Size(1269, 536)
        Me.grdEventosFichadas.TabIndex = 31
        Me.grdEventosFichadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewEventosFichadas})
        '
        'gViewEventosFichadas
        '
        Me.gViewEventosFichadas.GridControl = Me.grdEventosFichadas
        Me.gViewEventosFichadas.Name = "gViewEventosFichadas"
        Me.gViewEventosFichadas.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gViewEventosFichadas.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'frmTblLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 680)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.rctMenu)
        Me.Name = "frmTblLiquidaciones"
        Me.Text = "Liquidaciones"
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.grdLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.grdEventosFichadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewEventosFichadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiAusencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReprocesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarPdf As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarCsv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdLiquidaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewLiquidaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdEventosFichadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewEventosFichadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents beiListar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents beiFechaDesde As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiFechaHasta As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiLimpiarGrilla As DevExpress.XtraBars.BarButtonItem
End Class
