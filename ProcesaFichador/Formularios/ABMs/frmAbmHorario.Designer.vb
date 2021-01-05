<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbmHorario

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmHorario))
        Me.cboDiaEntrada = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.cboDiaSalida = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mskHoraSalida = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraEntrada = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraEntrada1 = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraSalida1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskHoraEntrada2 = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraSalida2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkFeriado = New DevExpress.XtraEditors.CheckEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.mskHorasACumplir = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.cboDiaEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDiaSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraEntrada1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraEntrada2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFeriado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHorasACumplir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDiaEntrada
        '
        Me.cboDiaEntrada.Location = New System.Drawing.Point(146, 69)
        Me.cboDiaEntrada.Name = "cboDiaEntrada"
        Me.cboDiaEntrada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDiaEntrada.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DÍA", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[False])})
        Me.cboDiaEntrada.Size = New System.Drawing.Size(145, 20)
        Me.cboDiaEntrada.TabIndex = 2
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.Location = New System.Drawing.Point(12, 69)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(79, 16)
        Me.lblEntrada.TabIndex = 2
        Me.lblEntrada.Text = "Día entrada:"
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.Location = New System.Drawing.Point(318, 70)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(68, 16)
        Me.lblSalida.TabIndex = 3
        Me.lblSalida.Text = "Día salida:"
        '
        'cboDiaSalida
        '
        Me.cboDiaSalida.Location = New System.Drawing.Point(433, 69)
        Me.cboDiaSalida.Name = "cboDiaSalida"
        Me.cboDiaSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDiaSalida.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DÍAS", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[False])})
        Me.cboDiaSalida.Size = New System.Drawing.Size(145, 20)
        Me.cboDiaSalida.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hora salida:"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'OkProvider
        '
        Me.OkProvider.ContainerControl = Me
        Me.OkProvider.Icon = CType(resources.GetObject("OkProvider.Icon"), System.Drawing.Icon)
        '
        'WarnProvider
        '
        Me.WarnProvider.ContainerControl = Me
        Me.WarnProvider.Icon = CType(resources.GetObject("WarnProvider.Icon"), System.Drawing.Icon)
        '
        'mskHoraSalida
        '
        Me.mskHoraSalida.EditValue = ""
        Me.mskHoraSalida.Location = New System.Drawing.Point(433, 102)
        Me.mskHoraSalida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraSalida.Name = "mskHoraSalida"
        Me.mskHoraSalida.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraSalida.TabIndex = 5
        '
        'mskHoraEntrada
        '
        Me.mskHoraEntrada.Location = New System.Drawing.Point(146, 102)
        Me.mskHoraEntrada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraEntrada.Name = "mskHoraEntrada"
        Me.mskHoraEntrada.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraEntrada.TabIndex = 4
        '
        'mskHoraEntrada1
        '
        Me.mskHoraEntrada1.Location = New System.Drawing.Point(146, 134)
        Me.mskHoraEntrada1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraEntrada1.Name = "mskHoraEntrada1"
        Me.mskHoraEntrada1.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada1.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraEntrada1.TabIndex = 6
        '
        'mskHoraSalida1
        '
        Me.mskHoraSalida1.EditValue = ""
        Me.mskHoraSalida1.Location = New System.Drawing.Point(433, 134)
        Me.mskHoraSalida1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraSalida1.Name = "mskHoraSalida1"
        Me.mskHoraSalida1.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida1.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraSalida1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hora 2° salida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hora 2° entrada:"
        '
        'mskHoraEntrada2
        '
        Me.mskHoraEntrada2.Location = New System.Drawing.Point(146, 169)
        Me.mskHoraEntrada2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraEntrada2.Name = "mskHoraEntrada2"
        Me.mskHoraEntrada2.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada2.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraEntrada2.TabIndex = 8
        '
        'mskHoraSalida2
        '
        Me.mskHoraSalida2.EditValue = ""
        Me.mskHoraSalida2.Location = New System.Drawing.Point(433, 169)
        Me.mskHoraSalida2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHoraSalida2.Name = "mskHoraSalida2"
        Me.mskHoraSalida2.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida2.Size = New System.Drawing.Size(46, 20)
        Me.mskHoraSalida2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Hora 3° salida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hora 3° entrada:"
        '
        'chkFeriado
        '
        Me.chkFeriado.Location = New System.Drawing.Point(11, 216)
        Me.chkFeriado.Name = "chkFeriado"
        Me.chkFeriado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFeriado.Properties.Appearance.Options.UseFont = True
        Me.chkFeriado.Properties.Caption = "Incluye feriados"
        Me.chkFeriado.Size = New System.Drawing.Size(114, 20)
        Me.chkFeriado.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(433, 284)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(149, 46)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(263, 284)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(149, 46)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir "
        '
        'mskHorasACumplir
        '
        Me.mskHorasACumplir.Location = New System.Drawing.Point(146, 252)
        Me.mskHorasACumplir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHorasACumplir.Name = "mskHorasACumplir"
        Me.mskHorasACumplir.Properties.Mask.EditMask = "90:00"
        Me.mskHorasACumplir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHorasACumplir.Size = New System.Drawing.Size(46, 20)
        Me.mskHorasACumplir.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Hrs. a cumplir:"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.EditValue = Nothing
        Me.DTFechaHasta.Location = New System.Drawing.Point(433, 28)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaHasta.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha Hasta:"
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.EditValue = Nothing
        Me.DTFechaDesde.Location = New System.Drawing.Point(146, 28)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaDesde.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha Desde:"
        '
        'frmAbmHorario
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 363)
        Me.Controls.Add(Me.DTFechaHasta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTFechaDesde)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mskHorasACumplir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkFeriado)
        Me.Controls.Add(Me.mskHoraEntrada2)
        Me.Controls.Add(Me.mskHoraSalida2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mskHoraEntrada1)
        Me.Controls.Add(Me.mskHoraSalida1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskHoraEntrada)
        Me.Controls.Add(Me.mskHoraSalida)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDiaSalida)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.cboDiaEntrada)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbmHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de horario"
        CType(Me.cboDiaEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDiaSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraEntrada1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraEntrada2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFeriado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHorasACumplir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDiaEntrada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEntrada As Label
    Friend WithEvents lblSalida As Label
    Friend WithEvents cboDiaSalida As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents mskHoraEntrada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraSalida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraEntrada2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraSalida2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mskHoraEntrada1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraSalida1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkFeriado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mskHorasACumplir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents DTFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents DTFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As Label
End Class
