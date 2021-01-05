<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainParent

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainParent))
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.nbiEmpleados = New DevExpress.XtraNavBar.NavBarItem()
        Me.bbiFichadasLectura = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgPrincipal = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiConvenios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiFPreProcesadas = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiLiquidaciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiFeriados = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiUsuarios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiTipoAusencias = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiPedidoAusencia = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiGrupos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiTrazaCambios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiSalir = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbcMenu = New DevExpress.XtraNavBar.NavBarControl()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbcMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'nbiEmpleados
        '
        Me.nbiEmpleados.Caption = "Empleados"
        Me.nbiEmpleados.LargeImage = CType(resources.GetObject("nbiEmpleados.LargeImage"), System.Drawing.Image)
        Me.nbiEmpleados.Name = "nbiEmpleados"
        Me.nbiEmpleados.SmallImage = CType(resources.GetObject("nbiEmpleados.SmallImage"), System.Drawing.Image)
        '
        'bbiFichadasLectura
        '
        Me.bbiFichadasLectura.Caption = "Fichadas Lectura"
        Me.bbiFichadasLectura.LargeImage = CType(resources.GetObject("bbiFichadasLectura.LargeImage"), System.Drawing.Image)
        Me.bbiFichadasLectura.Name = "bbiFichadasLectura"
        Me.bbiFichadasLectura.SmallImage = CType(resources.GetObject("bbiFichadasLectura.SmallImage"), System.Drawing.Image)
        Me.bbiFichadasLectura.Tag = "Fichadas Lectura"
        '
        'nvgPrincipal
        '
        Me.nvgPrincipal.Caption = "Menú"
        Me.nvgPrincipal.Expanded = True
        Me.nvgPrincipal.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.nvgPrincipal.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEmpleados), New DevExpress.XtraNavBar.NavBarItemLink(Me.bbiFichadasLectura), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiConvenios), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFPreProcesadas), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiLiquidaciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFeriados), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiUsuarios), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiTipoAusencias), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPedidoAusencia), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGrupos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiTrazaCambios), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSalir)})
        Me.nvgPrincipal.Name = "nvgPrincipal"
        '
        'nbiConvenios
        '
        Me.nbiConvenios.Caption = "Convenios"
        Me.nbiConvenios.LargeImage = CType(resources.GetObject("nbiConvenios.LargeImage"), System.Drawing.Image)
        Me.nbiConvenios.Name = "nbiConvenios"
        Me.nbiConvenios.SmallImage = CType(resources.GetObject("nbiConvenios.SmallImage"), System.Drawing.Image)
        '
        'nbiFPreProcesadas
        '
        Me.nbiFPreProcesadas.Caption = "Fichadas Pre Procesadas"
        Me.nbiFPreProcesadas.LargeImage = CType(resources.GetObject("nbiFPreProcesadas.LargeImage"), System.Drawing.Image)
        Me.nbiFPreProcesadas.Name = "nbiFPreProcesadas"
        Me.nbiFPreProcesadas.SmallImage = CType(resources.GetObject("nbiFPreProcesadas.SmallImage"), System.Drawing.Image)
        '
        'nbiLiquidaciones
        '
        Me.nbiLiquidaciones.Caption = "Liquidaciones"
        Me.nbiLiquidaciones.LargeImage = CType(resources.GetObject("nbiLiquidaciones.LargeImage"), System.Drawing.Image)
        Me.nbiLiquidaciones.Name = "nbiLiquidaciones"
        Me.nbiLiquidaciones.SmallImage = CType(resources.GetObject("nbiLiquidaciones.SmallImage"), System.Drawing.Image)
        '
        'nbiFeriados
        '
        Me.nbiFeriados.Caption = "Feriados"
        Me.nbiFeriados.LargeImage = CType(resources.GetObject("nbiFeriados.LargeImage"), System.Drawing.Image)
        Me.nbiFeriados.Name = "nbiFeriados"
        Me.nbiFeriados.SmallImage = CType(resources.GetObject("nbiFeriados.SmallImage"), System.Drawing.Image)
        '
        'nbiUsuarios
        '
        Me.nbiUsuarios.Caption = "Usuarios"
        Me.nbiUsuarios.LargeImage = CType(resources.GetObject("nbiUsuarios.LargeImage"), System.Drawing.Image)
        Me.nbiUsuarios.Name = "nbiUsuarios"
        Me.nbiUsuarios.SmallImage = CType(resources.GetObject("nbiUsuarios.SmallImage"), System.Drawing.Image)
        Me.nbiUsuarios.Tag = "Usuarios"
        '
        'nbiTipoAusencias
        '
        Me.nbiTipoAusencias.Caption = "TipoAusencias"
        Me.nbiTipoAusencias.LargeImage = CType(resources.GetObject("nbiTipoAusencias.LargeImage"), System.Drawing.Image)
        Me.nbiTipoAusencias.Name = "nbiTipoAusencias"
        Me.nbiTipoAusencias.SmallImage = CType(resources.GetObject("nbiTipoAusencias.SmallImage"), System.Drawing.Image)
        '
        'nbiPedidoAusencia
        '
        Me.nbiPedidoAusencia.Caption = "Pedido de Ausencia"
        Me.nbiPedidoAusencia.LargeImage = CType(resources.GetObject("nbiPedidoAusencia.LargeImage"), System.Drawing.Image)
        Me.nbiPedidoAusencia.Name = "nbiPedidoAusencia"
        Me.nbiPedidoAusencia.SmallImage = CType(resources.GetObject("nbiPedidoAusencia.SmallImage"), System.Drawing.Image)
        Me.nbiPedidoAusencia.Tag = "Pedido ausencias"
        '
        'nbiGrupos
        '
        Me.nbiGrupos.Caption = "Grupos"
        Me.nbiGrupos.LargeImage = CType(resources.GetObject("nbiGrupos.LargeImage"), System.Drawing.Image)
        Me.nbiGrupos.Name = "nbiGrupos"
        Me.nbiGrupos.SmallImage = CType(resources.GetObject("nbiGrupos.SmallImage"), System.Drawing.Image)
        '
        'nbiTrazaCambios
        '
        Me.nbiTrazaCambios.Caption = "Traza Cambios Sistema"
        Me.nbiTrazaCambios.LargeImage = CType(resources.GetObject("nbiTrazaCambios.LargeImage"), System.Drawing.Image)
        Me.nbiTrazaCambios.Name = "nbiTrazaCambios"
        Me.nbiTrazaCambios.SmallImage = CType(resources.GetObject("nbiTrazaCambios.SmallImage"), System.Drawing.Image)
        Me.nbiTrazaCambios.Tag = "Traza"
        '
        'nbiSalir
        '
        Me.nbiSalir.Caption = "Salir"
        Me.nbiSalir.LargeImage = CType(resources.GetObject("nbiSalir.LargeImage"), System.Drawing.Image)
        Me.nbiSalir.Name = "nbiSalir"
        Me.nbiSalir.SmallImage = CType(resources.GetObject("nbiSalir.SmallImage"), System.Drawing.Image)
        Me.nbiSalir.Tag = "Salir"
        '
        'nbcMenu
        '
        Me.nbcMenu.ActiveGroup = Me.nvgPrincipal
        Me.nbcMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.nbcMenu.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nvgPrincipal})
        Me.nbcMenu.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbiEmpleados, Me.bbiFichadasLectura, Me.nbiConvenios, Me.nbiFPreProcesadas, Me.nbiLiquidaciones, Me.nbiFeriados, Me.nbiUsuarios, Me.nbiTipoAusencias, Me.nbiPedidoAusencia, Me.nbiGrupos, Me.nbiTrazaCambios, Me.nbiSalir})
        Me.nbcMenu.Location = New System.Drawing.Point(0, 0)
        Me.nbcMenu.Name = "nbcMenu"
        Me.nbcMenu.OptionsNavPane.ExpandedWidth = 118
        Me.nbcMenu.Size = New System.Drawing.Size(118, 526)
        Me.nbcMenu.TabIndex = 1
        Me.nbcMenu.Text = "NavBarControl1"
        '
        'frmMainParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 526)
        Me.Controls.Add(Me.nbcMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmMainParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Control de Fichadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbcMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents nbcMenu As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nvgPrincipal As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiEmpleados As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bbiFichadasLectura As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiConvenios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFPreProcesadas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiLiquidaciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFeriados As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiUsuarios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTipoAusencias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiGrupos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTrazaCambios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiSalir As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiPedidoAusencia As DevExpress.XtraNavBar.NavBarItem
End Class
