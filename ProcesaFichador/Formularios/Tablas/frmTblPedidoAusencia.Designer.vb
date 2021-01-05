<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTblPedidoAusencia
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblPedidoAusencia))
        Me.grdSolicitudAusencias = New DevExpress.XtraGrid.GridControl()
        Me.gViewSolicitudAusencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rpgArchivo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiListar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAutoRRHH = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAutoJefe = New DevExpress.XtraBars.BarButtonItem()
        Me.beiGrupos = New DevExpress.XtraBars.BarEditItem()
        Me.cboGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.beiFechaDesde = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beiFechaHasta = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.grdSolicitudAusencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewSolicitudAusencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSolicitudAusencias
        '
        Me.grdSolicitudAusencias.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdSolicitudAusencias.Location = New System.Drawing.Point(0, 113)
        Me.grdSolicitudAusencias.MainView = Me.gViewSolicitudAusencias
        Me.grdSolicitudAusencias.Margin = New System.Windows.Forms.Padding(5)
        Me.grdSolicitudAusencias.Name = "grdSolicitudAusencias"
        Me.grdSolicitudAusencias.Size = New System.Drawing.Size(1182, 380)
        Me.grdSolicitudAusencias.TabIndex = 8
        Me.grdSolicitudAusencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewSolicitudAusencias})
        '
        'gViewSolicitudAusencias
        '
        Me.gViewSolicitudAusencias.GridControl = Me.grdSolicitudAusencias
        Me.gViewSolicitudAusencias.Name = "gViewSolicitudAusencias"
        Me.gViewSolicitudAusencias.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gViewSolicitudAusencias.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'rpgArchivo
        '
        Me.rpgArchivo.Name = "rpgArchivo"
        Me.rpgArchivo.Text = "Listados"
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiListar, Me.bbiSalir, Me.bbiNuevo, Me.bbiEliminar, Me.bbiAutoRRHH, Me.bbiAutoJefe, Me.beiGrupos, Me.beiFechaDesde, Me.beiFechaHasta})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 31
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGrupo, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1182, 116)
        Me.rctMenu.Toolbar.ShowCustomizeItem = False
        Me.rctMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiListar
        '
        Me.bbiListar.Caption = "Listar"
        Me.bbiListar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiListar.Glyph = CType(resources.GetObject("bbiListar.Glyph"), System.Drawing.Image)
        Me.bbiListar.Id = 13
        Me.bbiListar.LargeGlyph = CType(resources.GetObject("bbiListar.LargeGlyph"), System.Drawing.Image)
        Me.bbiListar.Name = "bbiListar"
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
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nueva solicitud"
        Me.bbiNuevo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevo.Glyph = CType(resources.GetObject("bbiNuevo.Glyph"), System.Drawing.Image)
        Me.bbiNuevo.Id = 15
        Me.bbiNuevo.LargeGlyph = CType(resources.GetObject("bbiNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Anular solicitud"
        Me.bbiEliminar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEliminar.Glyph = CType(resources.GetObject("bbiEliminar.Glyph"), System.Drawing.Image)
        Me.bbiEliminar.Id = 16
        Me.bbiEliminar.LargeGlyph = CType(resources.GetObject("bbiEliminar.LargeGlyph"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'bbiAutoRRHH
        '
        Me.bbiAutoRRHH.Caption = "Autoriza RRHH"
        Me.bbiAutoRRHH.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiAutoRRHH.Enabled = False
        Me.bbiAutoRRHH.Glyph = CType(resources.GetObject("bbiAutoRRHH.Glyph"), System.Drawing.Image)
        Me.bbiAutoRRHH.Id = 25
        Me.bbiAutoRRHH.LargeGlyph = CType(resources.GetObject("bbiAutoRRHH.LargeGlyph"), System.Drawing.Image)
        Me.bbiAutoRRHH.Name = "bbiAutoRRHH"
        '
        'bbiAutoJefe
        '
        Me.bbiAutoJefe.Caption = "Valida Supervisor"
        Me.bbiAutoJefe.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiAutoJefe.Enabled = False
        Me.bbiAutoJefe.Glyph = CType(resources.GetObject("bbiAutoJefe.Glyph"), System.Drawing.Image)
        Me.bbiAutoJefe.Id = 26
        Me.bbiAutoJefe.LargeGlyph = CType(resources.GetObject("bbiAutoJefe.LargeGlyph"), System.Drawing.Image)
        Me.bbiAutoJefe.Name = "bbiAutoJefe"
        '
        'beiGrupos
        '
        Me.beiGrupos.Caption = "Grupos"
        Me.beiGrupos.Edit = Me.cboGrupo
        Me.beiGrupos.Id = 28
        Me.beiGrupos.Name = "beiGrupos"
        Me.beiGrupos.Width = 125
        '
        'cboGrupo
        '
        Me.cboGrupo.AutoHeight = False
        Me.cboGrupo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Descripción")})
        Me.cboGrupo.Name = "cboGrupo"
        '
        'beiFechaDesde
        '
        Me.beiFechaDesde.Caption = "Fecha Desde:"
        Me.beiFechaDesde.Edit = Me.RepositoryItemDateEdit1
        Me.beiFechaDesde.Id = 29
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
        Me.beiFechaHasta.Id = 30
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Ausencias"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiSalir)
        Me.rpgAcciones.ItemLinks.Add(Me.beiFechaDesde)
        Me.rpgAcciones.ItemLinks.Add(Me.beiFechaHasta)
        Me.rpgAcciones.ItemLinks.Add(Me.beiGrupos)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiListar)
        Me.rpgAcciones.Name = "rpgAcciones"
        Me.rpgAcciones.Text = "Fichadas manuales"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiNuevo)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiEliminar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiAutoJefe)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiAutoRRHH)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Ausencias"
        '
        'frmTblPedidoAusencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 493)
        Me.Controls.Add(Me.rctMenu)
        Me.Controls.Add(Me.grdSolicitudAusencias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTblPedidoAusencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos de ausencias"
        CType(Me.grdSolicitudAusencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewSolicitudAusencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdSolicitudAusencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewSolicitudAusencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpgArchivo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiListar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiAutoRRHH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAutoJefe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents beiGrupos As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents beiFechaDesde As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beiFechaHasta As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    'Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
