<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbmTipoAusencia

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbmTipoAusencia))
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkPierdePresentismo = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkJustificada = New System.Windows.Forms.CheckBox()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(12, 148)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 46
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkPierdePresentismo
        '
        Me.chkPierdePresentismo.AutoSize = True
        Me.chkPierdePresentismo.Location = New System.Drawing.Point(12, 99)
        Me.chkPierdePresentismo.Name = "chkPierdePresentismo"
        Me.chkPierdePresentismo.Size = New System.Drawing.Size(117, 17)
        Me.chkPierdePresentismo.TabIndex = 2
        Me.chkPierdePresentismo.Text = "Pierde presentismo"
        Me.chkPierdePresentismo.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(110, 25)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 100
        Me.txtDescripcion.Size = New System.Drawing.Size(381, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(368, 128)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 37)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(209, 128)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 37)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Descripción:"
        '
        'chkJustificada
        '
        Me.chkJustificada.AutoSize = True
        Me.chkJustificada.Location = New System.Drawing.Point(12, 67)
        Me.chkJustificada.Name = "chkJustificada"
        Me.chkJustificada.Size = New System.Drawing.Size(77, 17)
        Me.chkJustificada.TabIndex = 1
        Me.chkJustificada.Text = "Justificada"
        Me.chkJustificada.UseVisualStyleBackColor = True
        '
        'FrmAbmTipoAusencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 186)
        Me.Controls.Add(Me.chkJustificada)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.chkPierdePresentismo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbmTipoAusencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Ausencia"
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents chkPierdePresentismo As CheckBox
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents chkJustificada As CheckBox
End Class
