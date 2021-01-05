<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmabmAusenciaEmpleado
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmabmAusenciaEmpleado))
        Me.lblAusencia = New System.Windows.Forms.Label()
        Me.DTFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.DTFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboAusencias = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboAusencias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAusencia
        '
        Me.lblAusencia.AutoSize = True
        Me.lblAusencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAusencia.Location = New System.Drawing.Point(12, 140)
        Me.lblAusencia.Name = "lblAusencia"
        Me.lblAusencia.Size = New System.Drawing.Size(110, 16)
        Me.lblAusencia.TabIndex = 15
        Me.lblAusencia.Text = "Tipo de ausencia:"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.EditValue = Nothing
        Me.DTFechaHasta.Location = New System.Drawing.Point(132, 99)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaHasta.TabIndex = 1
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.EditValue = Nothing
        Me.DTFechaDesde.Location = New System.Drawing.Point(132, 65)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaDesde.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha desde:"
        '
        'CboAusencias
        '
        Me.CboAusencias.Location = New System.Drawing.Point(132, 139)
        Me.CboAusencias.Name = "CboAusencias"
        Me.CboAusencias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboAusencias.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Descripción")})
        Me.CboAusencias.Properties.DisplayFormat.FormatString = "d"
        Me.CboAusencias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CboAusencias.Properties.EditFormat.FormatString = "d"
        Me.CboAusencias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CboAusencias.Properties.NullText = ""
        Me.CboAusencias.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboAusencias.Size = New System.Drawing.Size(328, 20)
        Me.CboAusencias.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(337, 204)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 37)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(193, 204)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 37)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'WarnProvider
        '
        Me.WarnProvider.ContainerControl = Me
        Me.WarnProvider.Icon = CType(resources.GetObject("WarnProvider.Icon"), System.Drawing.Icon)
        '
        'OkProvider
        '
        Me.OkProvider.ContainerControl = Me
        Me.OkProvider.Icon = CType(resources.GetObject("OkProvider.Icon"), System.Drawing.Icon)
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Empleado:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.Location = New System.Drawing.Point(129, 26)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(83, 16)
        Me.lblEmpleado.TabIndex = 17
        Me.lblEmpleado.Text = "lblEmpelado"
        '
        'frmabmAusenciaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 267)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAusencia)
        Me.Controls.Add(Me.DTFechaHasta)
        Me.Controls.Add(Me.DTFechaDesde)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboAusencias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmabmAusenciaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ausencias"
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboAusencias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAusencia As Label
    Friend WithEvents DTFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DTFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CboAusencias As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmpleado As Label
End Class
