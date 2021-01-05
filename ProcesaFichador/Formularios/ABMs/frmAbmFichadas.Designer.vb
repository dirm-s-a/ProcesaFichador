<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmFichadas

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmFichadas))
        Me.txtHorafichada = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboEmpleados = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.DTFechaFichada = New DevExpress.XtraEditors.DateEdit()
        Me.WarnProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OkProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboTipoFichada = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtHorafichada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaFichada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFechaFichada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoFichada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHorafichada
        '
        Me.txtHorafichada.Location = New System.Drawing.Point(104, 135)
        Me.txtHorafichada.Name = "txtHorafichada"
        Me.txtHorafichada.Properties.Mask.EditMask = "90:00"
        Me.txtHorafichada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtHorafichada.Size = New System.Drawing.Size(49, 20)
        Me.txtHorafichada.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Empleado:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(11, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Fecha entrada:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(11, 136)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Hora entrada:"
        '
        'cboEmpleados
        '
        Me.cboEmpleados.Location = New System.Drawing.Point(104, 11)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmpleados.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboEmpleados.Properties.NullText = ""
        Me.cboEmpleados.Size = New System.Drawing.Size(336, 20)
        Me.cboEmpleados.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.ProcesaFichador.My.Resources.Resources.backward_32x32
        Me.btnCancelar.Location = New System.Drawing.Point(83, 184)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(152, 37)
        Me.btnCancelar.TabIndex = 88
        Me.btnCancelar.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.ProcesaFichador.My.Resources.Resources.save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(288, 184)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(152, 37)
        Me.btnGuardar.TabIndex = 87
        Me.btnGuardar.Text = "Guardar"
        '
        'DTFechaFichada
        '
        Me.DTFechaFichada.EditValue = Nothing
        Me.DTFechaFichada.Location = New System.Drawing.Point(104, 98)
        Me.DTFechaFichada.Name = "DTFechaFichada"
        Me.DTFechaFichada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaFichada.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFechaFichada.Size = New System.Drawing.Size(107, 20)
        Me.DTFechaFichada.TabIndex = 2
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
        'cboTipoFichada
        '
        Me.cboTipoFichada.Location = New System.Drawing.Point(104, 52)
        Me.cboTipoFichada.Name = "cboTipoFichada"
        Me.cboTipoFichada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoFichada.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True])})
        Me.cboTipoFichada.Properties.NullText = ""
        Me.cboTipoFichada.Size = New System.Drawing.Size(131, 20)
        Me.cboTipoFichada.TabIndex = 89
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(11, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl3.TabIndex = 90
        Me.LabelControl3.Text = "Tipo Fichada:"
        '
        'frmAbmFichadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 233)
        Me.Controls.Add(Me.cboTipoFichada)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.DTFechaFichada)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cboEmpleados)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtHorafichada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbmFichadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta fichada"
        CType(Me.txtHorafichada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaFichada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFechaFichada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoFichada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHorafichada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboEmpleados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DTFechaFichada As DevExpress.XtraEditors.DateEdit
    Friend WithEvents WarnProvider As ErrorProvider
    Friend WithEvents OkProvider As ErrorProvider
    Friend WithEvents ErrProvider As ErrorProvider
    Private WithEvents cboTipoFichada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
