<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTblEventosFichadas

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblEventosFichadas))
        Me.ppaEspere = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.grdEventosFichadas = New DevExpress.XtraGrid.GridControl()
        Me.grdViewEventosFichadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVerFichadas = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReprocesar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarPdf = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarCsv = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLimpiar = New DevExpress.XtraBars.BarButtonItem()
        Me.dtpFechaDesde = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.dtpFechaHasta = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiGrupos = New DevExpress.XtraBars.BarEditItem()
        Me.cboGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bbiVerHorario = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgArchivo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExportar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.grdEventosFichadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewEventosFichadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ppaEspere.Location = New System.Drawing.Point(356, 261)
        Me.ppaEspere.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.ppaEspere.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ppaEspere.Name = "ppaEspere"
        Me.ppaEspere.Size = New System.Drawing.Size(185, 72)
        Me.ppaEspere.TabIndex = 31
        Me.ppaEspere.Visible = False
        '
        'grdEventosFichadas
        '
        Me.grdEventosFichadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEventosFichadas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdEventosFichadas.Location = New System.Drawing.Point(0, 116)
        Me.grdEventosFichadas.MainView = Me.grdViewEventosFichadas
        Me.grdEventosFichadas.Margin = New System.Windows.Forms.Padding(5)
        Me.grdEventosFichadas.Name = "grdEventosFichadas"
        Me.grdEventosFichadas.Size = New System.Drawing.Size(1114, 422)
        Me.grdEventosFichadas.TabIndex = 30
        Me.grdEventosFichadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewEventosFichadas})
        '
        'grdViewEventosFichadas
        '
        Me.grdViewEventosFichadas.GridControl = Me.grdEventosFichadas
        Me.grdViewEventosFichadas.Name = "grdViewEventosFichadas"
        Me.grdViewEventosFichadas.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.grdViewEventosFichadas.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiSalir, Me.bbiVerFichadas, Me.bbiReprocesar, Me.bbiExportarExcel, Me.bbiExportarPdf, Me.bbiExportarCsv, Me.bbiPrintPreview, Me.bbiLimpiar, Me.dtpFechaDesde, Me.dtpFechaHasta, Me.beiGrupos, Me.bbiVerHorario})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 44
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.cboGrupo})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1114, 116)
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
        'bbiLimpiar
        '
        Me.bbiLimpiar.Caption = "Limpiar Grilla"
        Me.bbiLimpiar.Enabled = False
        Me.bbiLimpiar.Glyph = CType(resources.GetObject("bbiLimpiar.Glyph"), System.Drawing.Image)
        Me.bbiLimpiar.Id = 35
        Me.bbiLimpiar.LargeGlyph = CType(resources.GetObject("bbiLimpiar.LargeGlyph"), System.Drawing.Image)
        Me.bbiLimpiar.Name = "bbiLimpiar"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Caption = "Fecha Desde:"
        Me.dtpFechaDesde.Edit = Me.RepositoryItemDateEdit1
        Me.dtpFechaDesde.Id = 38
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Width = 99
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Caption = "Fecha Hasta:"
        Me.dtpFechaHasta.Edit = Me.RepositoryItemDateEdit2
        Me.dtpFechaHasta.Id = 39
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Width = 99
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
        Me.beiGrupos.Caption = "Grupos:"
        Me.beiGrupos.Edit = Me.cboGrupo
        Me.beiGrupos.Id = 42
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
        'bbiVerHorario
        '
        Me.bbiVerHorario.Caption = "Horario Empleado"
        Me.bbiVerHorario.Enabled = False
        Me.bbiVerHorario.Glyph = CType(resources.GetObject("bbiVerHorario.Glyph"), System.Drawing.Image)
        Me.bbiVerHorario.Id = 43
        Me.bbiVerHorario.LargeGlyph = CType(resources.GetObject("bbiVerHorario.LargeGlyph"), System.Drawing.Image)
        Me.bbiVerHorario.Name = "bbiVerHorario"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.rpgArchivo, Me.rpgExportar})
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
        Me.rpgArchivo.ItemLinks.Add(Me.dtpFechaDesde)
        Me.rpgArchivo.ItemLinks.Add(Me.dtpFechaHasta)
        Me.rpgArchivo.ItemLinks.Add(Me.beiGrupos)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiVerFichadas)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiLimpiar)
        Me.rpgArchivo.ItemLinks.Add(Me.bbiVerHorario)
        Me.rpgArchivo.Name = "rpgArchivo"
        Me.rpgArchivo.Text = "Listados"
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
        'frmTblEventosFichadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 538)
        Me.Controls.Add(Me.ppaEspere)
        Me.Controls.Add(Me.grdEventosFichadas)
        Me.Controls.Add(Me.rctMenu)
        Me.Name = "frmTblEventosFichadas"
        Me.Text = "frmTblEventosFichadas"
        CType(Me.grdEventosFichadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewEventosFichadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ppaEspere As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents grdEventosFichadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewEventosFichadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiAusencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVerFichadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReprocesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarPdf As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarCsv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLimpiar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgArchivo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents dtpFechaDesde As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpFechaHasta As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiGrupos As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiVerHorario As DevExpress.XtraBars.BarButtonItem
End Class
