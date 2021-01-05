<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbmHorarioAdic


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmHorarioAdic))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskHoraEntrada = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraSalida = New DevExpress.XtraEditors.TextEdit()
        Me.DTFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.mskHoraSalida1 = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraEntrada1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskHoraSalida2 = New DevExpress.XtraEditors.TextEdit()
        Me.mskHoraEntrada2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskHorasACumplir = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkAutorizado = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.mskHoraEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraEntrada1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraSalida2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHoraEntrada2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHorasACumplir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutorizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hora salida:"
        '
        'mskHoraEntrada
        '
        Me.mskHoraEntrada.Location = New System.Drawing.Point(141, 66)
        Me.mskHoraEntrada.Name = "mskHoraEntrada"
        Me.mskHoraEntrada.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraEntrada.TabIndex = 2
        '
        'mskHoraSalida
        '
        Me.mskHoraSalida.Location = New System.Drawing.Point(426, 68)
        Me.mskHoraSalida.Name = "mskHoraSalida"
        Me.mskHoraSalida.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraSalida.TabIndex = 3
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.EditValue = Nothing
        Me.DTFechaDesde.Location = New System.Drawing.Point(141, 25)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaDesde.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaDesde.TabIndex = 0
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
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(426, 213)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 37)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(275, 213)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 37)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        '
        'mskHoraSalida1
        '
        Me.mskHoraSalida1.Location = New System.Drawing.Point(426, 108)
        Me.mskHoraSalida1.Name = "mskHoraSalida1"
        Me.mskHoraSalida1.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida1.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraSalida1.TabIndex = 5
        '
        'mskHoraEntrada1
        '
        Me.mskHoraEntrada1.Location = New System.Drawing.Point(141, 106)
        Me.mskHoraEntrada1.Name = "mskHoraEntrada1"
        Me.mskHoraEntrada1.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada1.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraEntrada1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hora 2° salida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora 2° entrada:"
        '
        'mskHoraSalida2
        '
        Me.mskHoraSalida2.Location = New System.Drawing.Point(426, 148)
        Me.mskHoraSalida2.Name = "mskHoraSalida2"
        Me.mskHoraSalida2.Properties.Mask.EditMask = "90:00"
        Me.mskHoraSalida2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraSalida2.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraSalida2.TabIndex = 7
        '
        'mskHoraEntrada2
        '
        Me.mskHoraEntrada2.Location = New System.Drawing.Point(141, 146)
        Me.mskHoraEntrada2.Name = "mskHoraEntrada2"
        Me.mskHoraEntrada2.Properties.Mask.EditMask = "90:00"
        Me.mskHoraEntrada2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHoraEntrada2.Size = New System.Drawing.Size(50, 20)
        Me.mskHoraEntrada2.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hora salida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Hora 3° entrada:"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.EditValue = Nothing
        Me.DTFechaHasta.Location = New System.Drawing.Point(426, 25)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaHasta.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaHasta.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha Hasta:"
        '
        'mskHorasACumplir
        '
        Me.mskHorasACumplir.Location = New System.Drawing.Point(141, 187)
        Me.mskHorasACumplir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHorasACumplir.Name = "mskHorasACumplir"
        Me.mskHorasACumplir.Properties.Mask.EditMask = "90:00"
        Me.mskHorasACumplir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHorasACumplir.Size = New System.Drawing.Size(46, 20)
        Me.mskHorasACumplir.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Hrs. a cumplir:"
        '
        'chkAutorizado
        '
        Me.chkAutorizado.Location = New System.Drawing.Point(15, 230)
        Me.chkAutorizado.Name = "chkAutorizado"
        Me.chkAutorizado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutorizado.Properties.Appearance.Options.UseFont = True
        Me.chkAutorizado.Properties.Caption = "Horario Autorizado"
        Me.chkAutorizado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutorizado.Size = New System.Drawing.Size(131, 20)
        Me.chkAutorizado.TabIndex = 19
        '
        'frmAbmHorarioAdic
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(591, 271)
        Me.Controls.Add(Me.chkAutorizado)
        Me.Controls.Add(Me.mskHorasACumplir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTFechaHasta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mskHoraSalida2)
        Me.Controls.Add(Me.mskHoraEntrada2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskHoraSalida1)
        Me.Controls.Add(Me.mskHoraEntrada1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTFechaDesde)
        Me.Controls.Add(Me.mskHoraSalida)
        Me.Controls.Add(Me.mskHoraEntrada)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbmHorarioAdic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de horario adicional"
        CType(Me.mskHoraEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraEntrada1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraSalida2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHoraEntrada2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHorasACumplir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutorizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mskHoraSalida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraEntrada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DTFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents mskHoraSalida2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraEntrada2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mskHoraSalida1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mskHoraEntrada1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DTFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents mskHorasACumplir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents chkAutorizado As DevExpress.XtraEditors.CheckEdit
End Class
