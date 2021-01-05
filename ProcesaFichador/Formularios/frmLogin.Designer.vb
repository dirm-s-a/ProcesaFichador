<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Appearance.Options.UseFont = True
        Me.btnIngresar.ImageOptions.Image = CType(resources.GetObject("btnIngresar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIngresar.Location = New System.Drawing.Point(12, 210)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(121, 34)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(139, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 34)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 86)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(12, 108)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(156, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 156)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 1
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.EnableBonusSkins = True
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Location = New System.Drawing.Point(164, 28)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(48, 16)
        Me.lblVersion.TabIndex = 122
        Me.lblVersion.Text = "Versión:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(140, 23)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(28, 27)
        Me.PictureEdit1.TabIndex = 123
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.ProcesaFichador.My.Resources.Resources.logo_min
        Me.PictureEdit2.Location = New System.Drawing.Point(-2, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Size = New System.Drawing.Size(135, 57)
        Me.PictureEdit2.TabIndex = 124
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 283)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCancelar)
        Me.IconOptions.Icon = CType(resources.GetObject("frmLogin.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de fichadas"
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
End Class
