<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbmUsuarios

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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.chkSupervisor = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRRHH = New DevExpress.XtraEditors.CheckEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cboEmpleados = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.chkDirectorRrhh = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.chkSupervisor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRRHH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDirectorRrhh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Contraseña:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 116)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nombre:"
        '
        'chkSupervisor
        '
        Me.chkSupervisor.Location = New System.Drawing.Point(26, 149)
        Me.chkSupervisor.Name = "chkSupervisor"
        Me.chkSupervisor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.chkSupervisor.Properties.Caption = "Supervisor"
        Me.chkSupervisor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSupervisor.Size = New System.Drawing.Size(75, 19)
        Me.chkSupervisor.TabIndex = 3
        '
        'chkRRHH
        '
        Me.chkRRHH.Location = New System.Drawing.Point(123, 149)
        Me.chkRRHH.Name = "chkRRHH"
        Me.chkRRHH.Properties.Caption = "RRHH"
        Me.chkRRHH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRRHH.Size = New System.Drawing.Size(75, 19)
        Me.chkRRHH.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(103, 47)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(183, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 113)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(103, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(183, 20)
        Me.txtPassword.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = Global.ProcesaFichador.My.Resources.Resources.save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(265, 204)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(131, 35)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = Global.ProcesaFichador.My.Resources.Resources.backward_32x32
        Me.btnSalir.Location = New System.Drawing.Point(103, 204)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 35)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        '
        'cboEmpleados
        '
        Me.cboEmpleados.Location = New System.Drawing.Point(103, 12)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmpleados.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboEmpleados.Properties.NullText = ""
        Me.cboEmpleados.Size = New System.Drawing.Size(336, 20)
        Me.cboEmpleados.TabIndex = 10
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.Location = New System.Drawing.Point(25, 16)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(61, 16)
        Me.lblEmpleado.TabIndex = 11
        Me.lblEmpleado.Text = "Empleado:"
        '
        'chkDirectorRrhh
        '
        Me.chkDirectorRrhh.Location = New System.Drawing.Point(234, 149)
        Me.chkDirectorRrhh.Name = "chkDirectorRrhh"
        Me.chkDirectorRrhh.Properties.Caption = "Director RRHH"
        Me.chkDirectorRrhh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDirectorRrhh.Size = New System.Drawing.Size(93, 19)
        Me.chkDirectorRrhh.TabIndex = 12
        '
        'frmAbmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 251)
        Me.Controls.Add(Me.chkDirectorRrhh)
        Me.Controls.Add(Me.cboEmpleados)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.chkRRHH)
        Me.Controls.Add(Me.chkSupervisor)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta usuarios"
        CType(Me.chkSupervisor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRRHH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDirectorRrhh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSupervisor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRRHH As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cboEmpleados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkDirectorRrhh As DevExpress.XtraEditors.CheckEdit
End Class
