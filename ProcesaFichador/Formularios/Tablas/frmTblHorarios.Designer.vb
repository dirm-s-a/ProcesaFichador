<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTblHorarios


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblHorarios))
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVerFichadas = New DevExpress.XtraBars.BarButtonItem()
        Me.ckGetActivos = New DevExpress.XtraBars.BarCheckItem()
        Me.ckGetInactivos = New DevExpress.XtraBars.BarCheckItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grdHorarios = New DevExpress.XtraGrid.GridControl()
        Me.grdViewHorarioFijo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grdHorarioAdic = New DevExpress.XtraGrid.GridControl()
        Me.grdViewHorarioAdicional = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdAusencias = New DevExpress.XtraGrid.GridControl()
        Me.grdViewAusencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grdHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewHorarioFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.grdHorarioAdic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewHorarioAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAusencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewAusencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiSalir, Me.bbiNuevo, Me.bbiEliminar, Me.bbiEditar, Me.bbiVerFichadas, Me.ckGetActivos, Me.ckGetInactivos})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 21
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1049, 116)
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
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevo.Glyph = Global.ProcesaFichador.My.Resources.Resources.add_16x16
        Me.bbiNuevo.Id = 15
        Me.bbiNuevo.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.add_32x32
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar"
        Me.bbiEliminar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEliminar.Glyph = Global.ProcesaFichador.My.Resources.Resources.cancel_16x16
        Me.bbiEliminar.Id = 16
        Me.bbiEliminar.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.cancel_32x32
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEditar.Glyph = Global.ProcesaFichador.My.Resources.Resources.edit_16x16
        Me.bbiEditar.Id = 17
        Me.bbiEditar.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.edit_32x32
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiVerFichadas
        '
        Me.bbiVerFichadas.Caption = "Ver fichadas"
        Me.bbiVerFichadas.Glyph = CType(resources.GetObject("bbiVerFichadas.Glyph"), System.Drawing.Image)
        Me.bbiVerFichadas.Id = 1
        Me.bbiVerFichadas.LargeGlyph = CType(resources.GetObject("bbiVerFichadas.LargeGlyph"), System.Drawing.Image)
        Me.bbiVerFichadas.Name = "bbiVerFichadas"
        '
        'ckGetActivos
        '
        Me.ckGetActivos.BindableChecked = True
        Me.ckGetActivos.Caption = "Lista activos"
        Me.ckGetActivos.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.ckGetActivos.Checked = True
        Me.ckGetActivos.Id = 19
        Me.ckGetActivos.Name = "ckGetActivos"
        '
        'ckGetInactivos
        '
        Me.ckGetInactivos.Caption = "Lista inactivos"
        Me.ckGetInactivos.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.ckGetInactivos.Id = 20
        Me.ckGetInactivos.Name = "ckGetInactivos"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menu"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.ItemLinks.Add(Me.bbiSalir)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiNuevo)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiEliminar)
        Me.rpgAcciones.ItemLinks.Add(Me.bbiEditar)
        Me.rpgAcciones.Name = "rpgAcciones"
        Me.rpgAcciones.Text = "Fichadas manuales"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ckGetActivos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ckGetInactivos)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Filtros"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Nueva fichada"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Glyph = Global.ProcesaFichador.My.Resources.Resources.add_16x16
        Me.BarButtonItem1.Id = 15
        Me.BarButtonItem1.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.add_32x32
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Nueva fichada"
        Me.BarButtonItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem2.Glyph = Global.ProcesaFichador.My.Resources.Resources.add_16x16
        Me.BarButtonItem2.Id = 15
        Me.BarButtonItem2.LargeGlyph = Global.ProcesaFichador.My.Resources.Resources.add_32x32
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 116)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grdHorarios)
        Me.SplitContainerControl1.Panel1.ShowCaption = True
        Me.SplitContainerControl1.Panel1.Text = "Horarios Empleado"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.ShowCaption = True
        Me.SplitContainerControl1.Panel2.Text = "Horarios Adicionales Empleado"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1049, 589)
        Me.SplitContainerControl1.SplitterPosition = 171
        Me.SplitContainerControl1.TabIndex = 11
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grdHorarios
        '
        Me.grdHorarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdHorarios.Location = New System.Drawing.Point(0, 0)
        Me.grdHorarios.MainView = Me.grdViewHorarioFijo
        Me.grdHorarios.Name = "grdHorarios"
        Me.grdHorarios.Size = New System.Drawing.Size(1041, 149)
        Me.grdHorarios.TabIndex = 1
        Me.grdHorarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewHorarioFijo, Me.GridView2})
        '
        'grdViewHorarioFijo
        '
        Me.grdViewHorarioFijo.GridControl = Me.grdHorarios
        Me.grdViewHorarioFijo.Name = "grdViewHorarioFijo"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdHorarios
        Me.GridView2.Name = "GridView2"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.grdHorarioAdic)
        Me.SplitContainerControl2.Panel1.ShowCaption = True
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.grdAusencias)
        Me.SplitContainerControl2.Panel2.ShowCaption = True
        Me.SplitContainerControl2.Panel2.Text = "Ausencias Empleado"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1041, 387)
        Me.SplitContainerControl2.SplitterPosition = 234
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'grdHorarioAdic
        '
        Me.grdHorarioAdic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdHorarioAdic.Location = New System.Drawing.Point(0, 0)
        Me.grdHorarioAdic.MainView = Me.grdViewHorarioAdicional
        Me.grdHorarioAdic.Name = "grdHorarioAdic"
        Me.grdHorarioAdic.Size = New System.Drawing.Size(1041, 234)
        Me.grdHorarioAdic.TabIndex = 3
        Me.grdHorarioAdic.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewHorarioAdicional, Me.GridView1})
        '
        'grdViewHorarioAdicional
        '
        Me.grdViewHorarioAdicional.GridControl = Me.grdHorarioAdic
        Me.grdViewHorarioAdicional.Name = "grdViewHorarioAdicional"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdHorarioAdic
        Me.GridView1.Name = "GridView1"
        '
        'grdAusencias
        '
        Me.grdAusencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAusencias.Location = New System.Drawing.Point(0, 0)
        Me.grdAusencias.MainView = Me.grdViewAusencias
        Me.grdAusencias.Name = "grdAusencias"
        Me.grdAusencias.Size = New System.Drawing.Size(1037, 126)
        Me.grdAusencias.TabIndex = 3
        Me.grdAusencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewAusencias})
        '
        'grdViewAusencias
        '
        Me.grdViewAusencias.GridControl = Me.grdAusencias
        Me.grdViewAusencias.Name = "grdViewAusencias"
        '
        'frmTblHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 705)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.rctMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTblHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios empleados"
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grdHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewHorarioFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.grdHorarioAdic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewHorarioAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAusencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewAusencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiAusencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVerFichadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckGetActivos As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents ckGetInactivos As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grdHorarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewHorarioFijo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grdHorarioAdic As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewHorarioAdicional As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdAusencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewAusencias As DevExpress.XtraGrid.Views.Grid.GridView
End Class
