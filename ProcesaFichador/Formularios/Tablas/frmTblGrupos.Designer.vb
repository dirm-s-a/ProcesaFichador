<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTblGrupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblGrupos))
        Me.grdGrupos = New DevExpress.XtraGrid.GridControl()
        Me.gViewGrupos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rpgArchivo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevoSupervisor = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarSupervisor = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevoEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevoGrupo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarGrupo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditarGrupo = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboFiltro = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.lblGrupos = New DevExpress.XtraEditors.LabelControl()
        Me.grdSupervisores = New DevExpress.XtraGrid.GridControl()
        Me.gViewSupervisores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblSupervisores = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmpleados = New DevExpress.XtraEditors.LabelControl()
        Me.grdEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.gViewEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit6.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSupervisores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewSupervisores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdGrupos
        '
        Me.grdGrupos.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdGrupos.Location = New System.Drawing.Point(6, 153)
        Me.grdGrupos.MainView = Me.gViewGrupos
        Me.grdGrupos.Margin = New System.Windows.Forms.Padding(5)
        Me.grdGrupos.Name = "grdGrupos"
        Me.grdGrupos.Size = New System.Drawing.Size(557, 469)
        Me.grdGrupos.TabIndex = 8
        Me.grdGrupos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewGrupos})
        '
        'gViewGrupos
        '
        Me.gViewGrupos.GridControl = Me.grdGrupos
        Me.gViewGrupos.Name = "gViewGrupos"
        Me.gViewGrupos.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gViewGrupos.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
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
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiSalir, Me.bbiNuevoSupervisor, Me.bbiEliminarSupervisor, Me.bbiNuevoEmpleado, Me.bbiEliminarEmpleado, Me.bbiNuevoGrupo, Me.bbiEliminarGrupo, Me.bbiEditarGrupo})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 41
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.cboFiltro, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemDateEdit5, Me.RepositoryItemDateEdit6})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1182, 116)
        Me.rctMenu.Toolbar.ShowCustomizeItem = False
        Me.rctMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiSalir
        '
        Me.bbiSalir.Caption = "Salir"
        Me.bbiSalir.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSalir.Glyph = CType(resources.GetObject("bbiSalir.Glyph"), System.Drawing.Image)
        Me.bbiSalir.Id = 14
        Me.bbiSalir.LargeGlyph = CType(resources.GetObject("bbiSalir.LargeGlyph"), System.Drawing.Image)
        Me.bbiSalir.Name = "bbiSalir"
        '
        'bbiNuevoSupervisor
        '
        Me.bbiNuevoSupervisor.Caption = "Nuevo"
        Me.bbiNuevoSupervisor.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevoSupervisor.Glyph = CType(resources.GetObject("bbiNuevoSupervisor.Glyph"), System.Drawing.Image)
        Me.bbiNuevoSupervisor.Id = 15
        Me.bbiNuevoSupervisor.LargeGlyph = CType(resources.GetObject("bbiNuevoSupervisor.LargeGlyph"), System.Drawing.Image)
        Me.bbiNuevoSupervisor.Name = "bbiNuevoSupervisor"
        '
        'bbiEliminarSupervisor
        '
        Me.bbiEliminarSupervisor.Caption = "Eliminar"
        Me.bbiEliminarSupervisor.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEliminarSupervisor.Glyph = CType(resources.GetObject("bbiEliminarSupervisor.Glyph"), System.Drawing.Image)
        Me.bbiEliminarSupervisor.Id = 16
        Me.bbiEliminarSupervisor.LargeGlyph = CType(resources.GetObject("bbiEliminarSupervisor.LargeGlyph"), System.Drawing.Image)
        Me.bbiEliminarSupervisor.Name = "bbiEliminarSupervisor"
        '
        'bbiNuevoEmpleado
        '
        Me.bbiNuevoEmpleado.Caption = "Nuevo"
        Me.bbiNuevoEmpleado.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevoEmpleado.Glyph = CType(resources.GetObject("bbiNuevoEmpleado.Glyph"), System.Drawing.Image)
        Me.bbiNuevoEmpleado.Id = 36
        Me.bbiNuevoEmpleado.LargeGlyph = CType(resources.GetObject("bbiNuevoEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.bbiNuevoEmpleado.Name = "bbiNuevoEmpleado"
        '
        'bbiEliminarEmpleado
        '
        Me.bbiEliminarEmpleado.Caption = "Eliminar"
        Me.bbiEliminarEmpleado.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEliminarEmpleado.Glyph = CType(resources.GetObject("bbiEliminarEmpleado.Glyph"), System.Drawing.Image)
        Me.bbiEliminarEmpleado.Id = 37
        Me.bbiEliminarEmpleado.LargeGlyph = CType(resources.GetObject("bbiEliminarEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.bbiEliminarEmpleado.Name = "bbiEliminarEmpleado"
        '
        'bbiNuevoGrupo
        '
        Me.bbiNuevoGrupo.Caption = "Nuevo"
        Me.bbiNuevoGrupo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevoGrupo.Glyph = CType(resources.GetObject("bbiNuevoGrupo.Glyph"), System.Drawing.Image)
        Me.bbiNuevoGrupo.Id = 38
        Me.bbiNuevoGrupo.LargeGlyph = CType(resources.GetObject("bbiNuevoGrupo.LargeGlyph"), System.Drawing.Image)
        Me.bbiNuevoGrupo.Name = "bbiNuevoGrupo"
        '
        'bbiEliminarGrupo
        '
        Me.bbiEliminarGrupo.Caption = "Eliminar"
        Me.bbiEliminarGrupo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEliminarGrupo.Glyph = CType(resources.GetObject("bbiEliminarGrupo.Glyph"), System.Drawing.Image)
        Me.bbiEliminarGrupo.Id = 39
        Me.bbiEliminarGrupo.LargeGlyph = CType(resources.GetObject("bbiEliminarGrupo.LargeGlyph"), System.Drawing.Image)
        Me.bbiEliminarGrupo.Name = "bbiEliminarGrupo"
        '
        'bbiEditarGrupo
        '
        Me.bbiEditarGrupo.Caption = "Editar"
        Me.bbiEditarGrupo.Glyph = CType(resources.GetObject("bbiEditarGrupo.Glyph"), System.Drawing.Image)
        Me.bbiEditarGrupo.Id = 40
        Me.bbiEditarGrupo.LargeGlyph = CType(resources.GetObject("bbiEditarGrupo.LargeGlyph"), System.Drawing.Image)
        Me.bbiEditarGrupo.Name = "bbiEditarGrupo"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Propiedades"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiSalir)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiNuevoGrupo)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiEditarGrupo)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiEliminarGrupo)
        Me.rpgAcciones.Name = "rpgAcciones"
        Me.rpgAcciones.Text = "Propiedades"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiNuevoSupervisor)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiEliminarSupervisor)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Supervisores"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiNuevoEmpleado)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiEliminarEmpleado)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Empleados"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'cboFiltro
        '
        Me.cboFiltro.AutoHeight = False
        Me.cboFiltro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.ValidateOnEnterKey = True
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        '
        'RepositoryItemDateEdit6
        '
        Me.RepositoryItemDateEdit6.AutoHeight = False
        Me.RepositoryItemDateEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit6.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit6.Name = "RepositoryItemDateEdit6"
        '
        'lblGrupos
        '
        Me.lblGrupos.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupos.Location = New System.Drawing.Point(12, 129)
        Me.lblGrupos.Name = "lblGrupos"
        Me.lblGrupos.Size = New System.Drawing.Size(57, 19)
        Me.lblGrupos.TabIndex = 24
        Me.lblGrupos.Text = "Grupos:"
        '
        'grdSupervisores
        '
        Me.grdSupervisores.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdSupervisores.Location = New System.Drawing.Point(590, 153)
        Me.grdSupervisores.MainView = Me.gViewSupervisores
        Me.grdSupervisores.Margin = New System.Windows.Forms.Padding(5)
        Me.grdSupervisores.Name = "grdSupervisores"
        Me.grdSupervisores.Size = New System.Drawing.Size(578, 210)
        Me.grdSupervisores.TabIndex = 25
        Me.grdSupervisores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewSupervisores})
        '
        'gViewSupervisores
        '
        Me.gViewSupervisores.GridControl = Me.grdSupervisores
        Me.gViewSupervisores.Name = "gViewSupervisores"
        Me.gViewSupervisores.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gViewSupervisores.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'lblSupervisores
        '
        Me.lblSupervisores.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisores.Location = New System.Drawing.Point(590, 129)
        Me.lblSupervisores.Name = "lblSupervisores"
        Me.lblSupervisores.Size = New System.Drawing.Size(96, 19)
        Me.lblSupervisores.TabIndex = 26
        Me.lblSupervisores.Text = "Supervisores:"
        '
        'lblEmpleados
        '
        Me.lblEmpleados.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.Location = New System.Drawing.Point(590, 371)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(83, 19)
        Me.lblEmpleados.TabIndex = 28
        Me.lblEmpleados.Text = "Empleados:"
        '
        'grdEmpleados
        '
        Me.grdEmpleados.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
        Me.grdEmpleados.Location = New System.Drawing.Point(590, 395)
        Me.grdEmpleados.MainView = Me.gViewEmpleados
        Me.grdEmpleados.Margin = New System.Windows.Forms.Padding(5)
        Me.grdEmpleados.Name = "grdEmpleados"
        Me.grdEmpleados.Size = New System.Drawing.Size(578, 227)
        Me.grdEmpleados.TabIndex = 27
        Me.grdEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewEmpleados})
        '
        'gViewEmpleados
        '
        Me.gViewEmpleados.GridControl = Me.grdEmpleados
        Me.gViewEmpleados.Name = "gViewEmpleados"
        Me.gViewEmpleados.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gViewEmpleados.OptionsFind.FindNullPrompt = "Escriba aquí para buscar..."
        '
        'frmTblGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 636)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.grdEmpleados)
        Me.Controls.Add(Me.lblSupervisores)
        Me.Controls.Add(Me.grdSupervisores)
        Me.Controls.Add(Me.lblGrupos)
        Me.Controls.Add(Me.rctMenu)
        Me.Controls.Add(Me.grdGrupos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTblGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit6.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSupervisores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewSupervisores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdGrupos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewGrupos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpgArchivo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNuevoSupervisor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarSupervisor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cboFiltro As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lblGrupos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdSupervisores As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewSupervisores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblSupervisores As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmpleados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiNuevoEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiNuevoGrupo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarGrupo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditarGrupo As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
