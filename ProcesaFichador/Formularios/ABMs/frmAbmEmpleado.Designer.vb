<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmEmpleado


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmEmpleado))
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSector = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNroDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.chkInactivo = New System.Windows.Forms.CheckBox()
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboConvenio = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConvenio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(121, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(278, 20)
        Me.txtNombre.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(23, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Nombre:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(23, 118)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Sector:"
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(121, 117)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Properties.MaxLength = 50
        Me.txtSector.Size = New System.Drawing.Size(278, 20)
        Me.txtSector.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(23, 163)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Nro. Documento:"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(126, 162)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Properties.MaxLength = 10
        Me.txtNroDocumento.Size = New System.Drawing.Size(133, 20)
        Me.txtNroDocumento.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = Global.ProcesaFichador.My.Resources.Resources.save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(260, 250)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 35)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = Global.ProcesaFichador.My.Resources.Resources.backward_32x32
        Me.btnSalir.Location = New System.Drawing.Point(121, 250)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 35)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'chkInactivo
        '
        Me.chkInactivo.AutoSize = True
        Me.chkInactivo.Location = New System.Drawing.Point(23, 205)
        Me.chkInactivo.Name = "chkInactivo"
        Me.chkInactivo.Size = New System.Drawing.Size(65, 17)
        Me.chkInactivo.TabIndex = 3
        Me.chkInactivo.Text = "Inactivo"
        Me.chkInactivo.UseVisualStyleBackColor = True
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
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(23, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Convenio:"
        '
        'cboConvenio
        '
        Me.cboConvenio.Location = New System.Drawing.Point(121, 67)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConvenio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True])})
        Me.cboConvenio.Properties.DisplayMember = "DESCRIPCION"
        Me.cboConvenio.Properties.ValueMember = "ID"
        Me.cboConvenio.Size = New System.Drawing.Size(278, 20)
        Me.cboConvenio.TabIndex = 8
        '
        'frmAbmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 297)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.chkInactivo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNroDocumento)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar empleado"
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConvenio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSector As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNroDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkInactivo As CheckBox
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboConvenio As DevExpress.XtraEditors.LookUpEdit
End Class
