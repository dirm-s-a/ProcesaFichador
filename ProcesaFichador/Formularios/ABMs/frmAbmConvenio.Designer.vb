<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmConvenio

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmConvenio))
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosGracia = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAusentismo = New System.Windows.Forms.CheckBox()
        Me.chkHorarioFlexible = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkSinControl = New System.Windows.Forms.CheckBox()
        Me.txtMinutosTope = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskHorasACumplirLUNVIE = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskHorasACumplirSABADO = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskHorasACumplirDOMINGO = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkControlDescanso = New System.Windows.Forms.CheckBox()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinutosGracia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinutosTope.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHorasACumplirLUNVIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHorasACumplirSABADO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskHorasACumplirDOMINGO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(447, 245)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 37)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(296, 245)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 37)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Descripción:"
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
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 100
        Me.txtDescripcion.Size = New System.Drawing.Size(381, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtMinutosGracia
        '
        Me.txtMinutosGracia.EditValue = "0"
        Me.txtMinutosGracia.Location = New System.Drawing.Point(143, 141)
        Me.txtMinutosGracia.Name = "txtMinutosGracia"
        Me.txtMinutosGracia.Properties.MaxLength = 100
        Me.txtMinutosGracia.Size = New System.Drawing.Size(49, 20)
        Me.txtMinutosGracia.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Minutos de gracia:"
        '
        'chkAusentismo
        '
        Me.chkAusentismo.AutoSize = True
        Me.chkAusentismo.Location = New System.Drawing.Point(26, 83)
        Me.chkAusentismo.Name = "chkAusentismo"
        Me.chkAusentismo.Size = New System.Drawing.Size(185, 17)
        Me.chkAusentismo.TabIndex = 1
        Me.chkAusentismo.Text = "Calcula Ausentismo (puntualidad)"
        Me.chkAusentismo.UseVisualStyleBackColor = True
        '
        'chkHorarioFlexible
        '
        Me.chkHorarioFlexible.AutoSize = True
        Me.chkHorarioFlexible.Location = New System.Drawing.Point(26, 106)
        Me.chkHorarioFlexible.Name = "chkHorarioFlexible"
        Me.chkHorarioFlexible.Size = New System.Drawing.Size(98, 17)
        Me.chkHorarioFlexible.TabIndex = 2
        Me.chkHorarioFlexible.Text = "Horario flexible"
        Me.chkHorarioFlexible.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(26, 233)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkSinControl
        '
        Me.chkSinControl.AutoSize = True
        Me.chkSinControl.Location = New System.Drawing.Point(26, 200)
        Me.chkSinControl.Name = "chkSinControl"
        Me.chkSinControl.Size = New System.Drawing.Size(87, 17)
        Me.chkSinControl.TabIndex = 33
        Me.chkSinControl.Text = "Sin controles"
        Me.chkSinControl.UseVisualStyleBackColor = True
        '
        'txtMinutosTope
        '
        Me.txtMinutosTope.EditValue = "0"
        Me.txtMinutosTope.Location = New System.Drawing.Point(143, 167)
        Me.txtMinutosTope.Name = "txtMinutosTope"
        Me.txtMinutosTope.Properties.MaxLength = 100
        Me.txtMinutosTope.Size = New System.Drawing.Size(49, 20)
        Me.txtMinutosTope.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Minutos de tope:"
        '
        'mskHorasACumplirLUNVIE
        '
        Me.mskHorasACumplirLUNVIE.EditValue = "00:00"
        Me.mskHorasACumplirLUNVIE.Location = New System.Drawing.Point(447, 104)
        Me.mskHorasACumplirLUNVIE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHorasACumplirLUNVIE.Name = "mskHorasACumplirLUNVIE"
        Me.mskHorasACumplirLUNVIE.Properties.Mask.EditMask = "90:00"
        Me.mskHorasACumplirLUNVIE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHorasACumplirLUNVIE.Size = New System.Drawing.Size(46, 20)
        Me.mskHorasACumplirLUNVIE.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Hrs. a cumplir L/V:"
        '
        'mskHorasACumplirSABADO
        '
        Me.mskHorasACumplirSABADO.EditValue = "00:00"
        Me.mskHorasACumplirSABADO.Location = New System.Drawing.Point(447, 141)
        Me.mskHorasACumplirSABADO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHorasACumplirSABADO.Name = "mskHorasACumplirSABADO"
        Me.mskHorasACumplirSABADO.Properties.Mask.EditMask = "90:00"
        Me.mskHorasACumplirSABADO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHorasACumplirSABADO.Size = New System.Drawing.Size(46, 20)
        Me.mskHorasACumplirSABADO.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Hrs. a cumplir Sábado:"
        '
        'mskHorasACumplirDOMINGO
        '
        Me.mskHorasACumplirDOMINGO.EditValue = "00:00"
        Me.mskHorasACumplirDOMINGO.Location = New System.Drawing.Point(447, 183)
        Me.mskHorasACumplirDOMINGO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskHorasACumplirDOMINGO.Name = "mskHorasACumplirDOMINGO"
        Me.mskHorasACumplirDOMINGO.Properties.Mask.EditMask = "90:00"
        Me.mskHorasACumplirDOMINGO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.mskHorasACumplirDOMINGO.Size = New System.Drawing.Size(46, 20)
        Me.mskHorasACumplirDOMINGO.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Hrs. a cumplir Domingo:"
        '
        'chkControlDescanso
        '
        Me.chkControlDescanso.AutoSize = True
        Me.chkControlDescanso.Location = New System.Drawing.Point(26, 60)
        Me.chkControlDescanso.Name = "chkControlDescanso"
        Me.chkControlDescanso.Size = New System.Drawing.Size(279, 17)
        Me.chkControlDescanso.TabIndex = 42
        Me.chkControlDescanso.Text = "Fichadas de descanso forman parte de la liquidación."
        Me.chkControlDescanso.UseVisualStyleBackColor = True
        '
        'frmAbmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 299)
        Me.Controls.Add(Me.chkControlDescanso)
        Me.Controls.Add(Me.mskHorasACumplirDOMINGO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mskHorasACumplirSABADO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mskHorasACumplirLUNVIE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMinutosTope)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkSinControl)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.chkHorarioFlexible)
        Me.Controls.Add(Me.txtMinutosGracia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAusentismo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbmConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAbmConvenio"
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinutosGracia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinutosTope.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHorasACumplirLUNVIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHorasACumplirSABADO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskHorasACumplirDOMINGO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents chkHorarioFlexible As CheckBox
    Friend WithEvents txtMinutosGracia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAusentismo As CheckBox
    Friend WithEvents chkSinControl As CheckBox
    Friend WithEvents txtMinutosTope As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents mskHorasACumplirDOMINGO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents mskHorasACumplirSABADO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents mskHorasACumplirLUNVIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents chkControlDescanso As CheckBox
End Class
