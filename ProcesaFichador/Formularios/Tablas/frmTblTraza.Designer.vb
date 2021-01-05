<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTblTraza

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblTraza))
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReprocesar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarPdf = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarCsv = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.beiFechaDesde = New DevExpress.XtraBars.BarEditItem()
        Me.beiFechaHasta = New DevExpress.XtraBars.BarEditItem()
        Me.beiGrupos = New DevExpress.XtraBars.BarEditItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExportar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grdTabla = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTabla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiExit, Me.bbiReprocesar, Me.bbiExportarExcel, Me.bbiExportarPdf, Me.bbiExportarCsv, Me.bbiPrintPreview, Me.beiFechaDesde, Me.beiFechaHasta, Me.beiGrupos})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 40
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1158, 116)
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
        'beiFechaDesde
        '
        Me.beiFechaDesde.Caption = "Fecha desde"
        Me.beiFechaDesde.Edit = Nothing
        Me.beiFechaDesde.Id = 25
        Me.beiFechaDesde.Name = "beiFechaDesde"
        Me.beiFechaDesde.Width = 99
        '
        'beiFechaHasta
        '
        Me.beiFechaHasta.Caption = "Fecha hasta"
        Me.beiFechaHasta.Edit = Nothing
        Me.beiFechaHasta.Id = 26
        Me.beiFechaHasta.Name = "beiFechaHasta"
        Me.beiFechaHasta.Width = 99
        '
        'beiGrupos
        '
        Me.beiGrupos.Caption = "Grupos"
        Me.beiGrupos.Edit = Nothing
        Me.beiGrupos.Id = 27
        Me.beiGrupos.Name = "beiGrupos"
        Me.beiGrupos.Width = 125
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.rpgExportar})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Fichadas"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiExit)
        Me.rpgAcciones.Name = "rpgAcciones"
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
        'grdTabla
        '
        Me.grdTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTabla.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdTabla.Location = New System.Drawing.Point(0, 116)
        Me.grdTabla.MainView = Me.GridView1
        Me.grdTabla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdTabla.Name = "grdTabla"
        Me.grdTabla.Size = New System.Drawing.Size(1158, 455)
        Me.grdTabla.TabIndex = 20
        Me.grdTabla.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdTabla
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        '
        'frmTblTraza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 571)
        Me.Controls.Add(Me.grdTabla)
        Me.Controls.Add(Me.rctMenu)
        Me.Name = "frmTblTraza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoría del sistema"
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents beiFechaDesde As DevExpress.XtraBars.BarEditItem
    Friend WithEvents beiFechaHasta As DevExpress.XtraBars.BarEditItem
    Friend WithEvents beiGrupos As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grdTabla As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
