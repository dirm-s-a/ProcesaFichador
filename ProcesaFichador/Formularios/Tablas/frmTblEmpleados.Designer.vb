<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTblEmpleados


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTblEmpleados))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", ""}, -1)
        Me.btnAgregarHorario = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarHorarioAdic = New DevExpress.XtraEditors.SimpleButton()
        Me.gcHorario = New DevExpress.XtraEditors.GroupControl()
        Me.lstViewHorarios = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.ppaEspere = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btnHistoricoHorarios = New DevExpress.XtraEditors.SimpleButton()
        Me.rpgAcciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rctMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAusencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDeshabilitar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVerFichadas = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiBorrarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProcesarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProcesarTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDesprocesar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDesprocesarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLiquidarEmpleados = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLiquidarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Miscelaneos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grdEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.grdViewEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcHorario.SuspendLayout()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarHorario
        '
        Me.btnAgregarHorario.Image = CType(resources.GetObject("btnAgregarHorario.Image"), System.Drawing.Image)
        Me.btnAgregarHorario.Location = New System.Drawing.Point(18, 15)
        Me.btnAgregarHorario.Name = "btnAgregarHorario"
        Me.btnAgregarHorario.Size = New System.Drawing.Size(192, 47)
        Me.btnAgregarHorario.TabIndex = 1
        Me.btnAgregarHorario.Text = "Agregar horario"
        '
        'btnAgregarHorarioAdic
        '
        Me.btnAgregarHorarioAdic.Image = CType(resources.GetObject("btnAgregarHorarioAdic.Image"), System.Drawing.Image)
        Me.btnAgregarHorarioAdic.Location = New System.Drawing.Point(346, 15)
        Me.btnAgregarHorarioAdic.Name = "btnAgregarHorarioAdic"
        Me.btnAgregarHorarioAdic.Size = New System.Drawing.Size(192, 47)
        Me.btnAgregarHorarioAdic.TabIndex = 2
        Me.btnAgregarHorarioAdic.Text = "Agregar horario adicional"
        '
        'gcHorario
        '
        Me.gcHorario.Controls.Add(Me.lstViewHorarios)
        Me.gcHorario.Controls.Add(Me.Label1)
        Me.gcHorario.Controls.Add(Me.lblEmpleado)
        Me.gcHorario.Location = New System.Drawing.Point(33, 80)
        Me.gcHorario.Name = "gcHorario"
        Me.gcHorario.Size = New System.Drawing.Size(505, 285)
        Me.gcHorario.TabIndex = 3
        Me.gcHorario.Text = "HORARIO ACTIVO"
        '
        'lstViewHorarios
        '
        Me.lstViewHorarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstViewHorarios.FullRowSelect = True
        Me.lstViewHorarios.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lstViewHorarios.Location = New System.Drawing.Point(0, 55)
        Me.lstViewHorarios.Name = "lstViewHorarios"
        Me.lstViewHorarios.Size = New System.Drawing.Size(485, 230)
        Me.lstViewHorarios.TabIndex = 55
        Me.lstViewHorarios.UseCompatibleStateImageBehavior = False
        Me.lstViewHorarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "#"
        Me.ColumnHeader4.Width = 26
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Días"
        Me.ColumnHeader1.Width = 141
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Horas"
        Me.ColumnHeader2.Width = 244
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo Horario"
        Me.ColumnHeader3.Width = 70
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Empleado:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(66, 31)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(0, 13)
        Me.lblEmpleado.TabIndex = 3
        '
        'ppaEspere
        '
        Me.ppaEspere.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ppaEspere.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppaEspere.Appearance.Options.UseBackColor = True
        Me.ppaEspere.Appearance.Options.UseFont = True
        Me.ppaEspere.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ppaEspere.AppearanceCaption.Options.UseFont = True
        Me.ppaEspere.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ppaEspere.AppearanceDescription.Options.UseFont = True
        Me.ppaEspere.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ppaEspere.Caption = "Espere por favor!"
        Me.ppaEspere.Description = "Procesando ..."
        Me.ppaEspere.Location = New System.Drawing.Point(670, 24)
        Me.ppaEspere.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.ppaEspere.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ppaEspere.Name = "ppaEspere"
        Me.ppaEspere.Size = New System.Drawing.Size(464, 77)
        Me.ppaEspere.TabIndex = 29
        Me.ppaEspere.Visible = False
        '
        'btnHistoricoHorarios
        '
        Me.btnHistoricoHorarios.Image = Global.ProcesaFichador.My.Resources.Resources.timelineview_32x32
        Me.btnHistoricoHorarios.Location = New System.Drawing.Point(18, 386)
        Me.btnHistoricoHorarios.Name = "btnHistoricoHorarios"
        Me.btnHistoricoHorarios.Size = New System.Drawing.Size(192, 47)
        Me.btnHistoricoHorarios.TabIndex = 4
        Me.btnHistoricoHorarios.Text = "Histórico horarios"
        '
        'rpgAcciones
        '
        Me.rpgAcciones.Name = "rpgAcciones"
        Me.rpgAcciones.Text = "Fichadas manuales"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgAcciones})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Fichadas"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Fichadas manuales"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Fichadas manuales"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Fichadas manuales"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Fichadas manuales"
        '
        'rctMenu
        '
        Me.rctMenu.AllowKeyTips = False
        Me.rctMenu.AllowMdiChildButtons = False
        Me.rctMenu.AllowMinimizeRibbon = False
        Me.rctMenu.AllowTrimPageText = False
        Me.rctMenu.ExpandCollapseItem.Id = 0
        Me.rctMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rctMenu.ExpandCollapseItem, Me.bbiAusencias, Me.bbiSalir, Me.bbiNuevo, Me.bbiDeshabilitar, Me.bbiEditar, Me.bbiVerFichadas, Me.bbiBorrarEmpleado, Me.bbiProcesarEmpleado, Me.bbiProcesarTodos, Me.bbiDesprocesar, Me.bbiDesprocesarEmpleado, Me.bbiLiquidarEmpleados, Me.bbiLiquidarEmpleado})
        Me.rctMenu.Location = New System.Drawing.Point(0, 0)
        Me.rctMenu.MaxItemId = 25
        Me.rctMenu.Name = "rctMenu"
        Me.rctMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2})
        Me.rctMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowCategoryInCaption = False
        Me.rctMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.rctMenu.ShowToolbarCustomizeItem = False
        Me.rctMenu.Size = New System.Drawing.Size(1237, 116)
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
        Me.bbiNuevo.Caption = "Nuevo Empleado"
        Me.bbiNuevo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNuevo.Glyph = CType(resources.GetObject("bbiNuevo.Glyph"), System.Drawing.Image)
        Me.bbiNuevo.Id = 15
        Me.bbiNuevo.LargeGlyph = CType(resources.GetObject("bbiNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiDeshabilitar
        '
        Me.bbiDeshabilitar.Caption = "Deshabilitar Empleado"
        Me.bbiDeshabilitar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDeshabilitar.Glyph = CType(resources.GetObject("bbiDeshabilitar.Glyph"), System.Drawing.Image)
        Me.bbiDeshabilitar.Id = 16
        Me.bbiDeshabilitar.LargeGlyph = CType(resources.GetObject("bbiDeshabilitar.LargeGlyph"), System.Drawing.Image)
        Me.bbiDeshabilitar.Name = "bbiDeshabilitar"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar Empleado"
        Me.bbiEditar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEditar.Glyph = CType(resources.GetObject("bbiEditar.Glyph"), System.Drawing.Image)
        Me.bbiEditar.Id = 17
        Me.bbiEditar.LargeGlyph = CType(resources.GetObject("bbiEditar.LargeGlyph"), System.Drawing.Image)
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
        'bbiBorrarEmpleado
        '
        Me.bbiBorrarEmpleado.Caption = "Borrar Empleado"
        Me.bbiBorrarEmpleado.Glyph = CType(resources.GetObject("bbiBorrarEmpleado.Glyph"), System.Drawing.Image)
        Me.bbiBorrarEmpleado.Id = 18
        Me.bbiBorrarEmpleado.LargeGlyph = CType(resources.GetObject("bbiBorrarEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.bbiBorrarEmpleado.Name = "bbiBorrarEmpleado"
        '
        'bbiProcesarEmpleado
        '
        Me.bbiProcesarEmpleado.Caption = "ProcesarEmpleado"
        Me.bbiProcesarEmpleado.Id = 19
        Me.bbiProcesarEmpleado.Name = "bbiProcesarEmpleado"
        '
        'bbiProcesarTodos
        '
        Me.bbiProcesarTodos.Caption = "Procesar Todos"
        Me.bbiProcesarTodos.Id = 20
        Me.bbiProcesarTodos.Name = "bbiProcesarTodos"
        '
        'bbiDesprocesar
        '
        Me.bbiDesprocesar.Caption = "Desprocesar Todos"
        Me.bbiDesprocesar.Id = 21
        Me.bbiDesprocesar.Name = "bbiDesprocesar"
        '
        'bbiDesprocesarEmpleado
        '
        Me.bbiDesprocesarEmpleado.Caption = "Desprocesar Empleado"
        Me.bbiDesprocesarEmpleado.Id = 22
        Me.bbiDesprocesarEmpleado.Name = "bbiDesprocesarEmpleado"
        '
        'bbiLiquidarEmpleados
        '
        Me.bbiLiquidarEmpleados.Caption = "Liquidar Empleados"
        Me.bbiLiquidarEmpleados.Id = 23
        Me.bbiLiquidarEmpleados.Name = "bbiLiquidarEmpleados"
        '
        'bbiLiquidarEmpleado
        '
        Me.bbiLiquidarEmpleado.Caption = "Liquidar Empleado"
        Me.bbiLiquidarEmpleado.Id = 24
        Me.bbiLiquidarEmpleado.Name = "bbiLiquidarEmpleado"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.Miscelaneos})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Personal"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiSalir)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiNuevo)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiEditar)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiDeshabilitar)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiProcesarEmpleado)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiDesprocesarEmpleado)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiLiquidarEmpleado)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiProcesarTodos)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiDesprocesar)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiLiquidarEmpleados)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Opciones Personal"
        '
        'Miscelaneos
        '
        Me.Miscelaneos.ItemLinks.Add(Me.bbiBorrarEmpleado)
        Me.Miscelaneos.Name = "Miscelaneos"
        Me.Miscelaneos.Text = "RibbonPageGroup6"
        Me.Miscelaneos.Visible = False
        '
        'grdEmpleados
        '
        Me.grdEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmpleados.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.grdEmpleados.MainView = Me.grdViewEmpleado
        Me.grdEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEmpleados.Name = "grdEmpleados"
        Me.grdEmpleados.Size = New System.Drawing.Size(647, 444)
        Me.grdEmpleados.TabIndex = 18
        Me.grdEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewEmpleado})
        '
        'grdViewEmpleado
        '
        Me.grdViewEmpleado.GridControl = Me.grdEmpleados
        Me.grdViewEmpleado.Name = "grdViewEmpleado"
        Me.grdViewEmpleado.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 116)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grdEmpleados)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnHistoricoHorarios)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnAgregarHorario)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcHorario)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnAgregarHorarioAdic)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1237, 444)
        Me.SplitContainerControl1.SplitterPosition = 647
        Me.SplitContainerControl1.TabIndex = 31
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(290, 395)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(156, 37)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Prueba Control Ausentes"
        '
        'frmTblEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 560)
        Me.Controls.Add(Me.ppaEspere)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.rctMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTblEmpleados"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gcHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcHorario.ResumeLayout(False)
        Me.gcHorario.PerformLayout()
        CType(Me.rctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarHorario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarHorarioAdic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcHorario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents btnHistoricoHorarios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rpgAcciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rctMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiAusencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDeshabilitar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVerFichadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lstViewHorarios As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents grdEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiBorrarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Miscelaneos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiProcesarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiProcesarTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDesprocesar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ppaEspere As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents bbiDesprocesarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLiquidarEmpleados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLiquidarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
