Imports Lenox.Business
Imports Lenox.Entities
Imports Lenox.Data
Imports Employees.Business
Imports Employees.Entities
Imports Employees.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Data
Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel
Imports System.Drawing.Printing
Public Class frmAbmUsuarios
    Inherits XtraForm
    Private mflgOkSave As Boolean = False
    Private mEntity As Usuario
    Public ReadOnly Property OkSave As Boolean
        Get
            Return mflgOkSave
        End Get
    End Property

    Public Property Entity As Usuario
        Get
            Return mEntity
        End Get
        Set(value As Usuario)
            mEntity = value
        End Set
    End Property
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ent As New Usuario
        Dim obj As New UsuarioComponent(Session.CadenaConexion)
        Try
            If mEntity Is Nothing Then mEntity = New Usuario
            mEntity.BeginUpdate()
            If mEntity.IsNew Then
                mEntity.ID = txtUsuario.Text.ToUpper
            End If

            mEntity.CLAVE = txtPassword.Text.ToUpper
            mEntity.NOMBRE = txtNombre.Text.ToUpper
            mEntity.ACTIVO = True
            mEntity.RRHH = chkRRHH.Checked
            mEntity.SUPERVISOR = chkSupervisor.Checked
            mEntity.DIRECTORRRHH = chkDirectorRrhh.Checked

            If Not obj.Save(mEntity) Then
                If Not cboEmpleados.EditValue Is Nothing Then
                    Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
                    Dim entEmpleado As Empleado = objEmpleado.GetEntById(cboEmpleados.EditValue)
                    If Not entEmpleado Is Nothing Then
                        entEmpleado.BeginUpdate()
                        entEmpleado.IDUSUARIO = Entity.ID
                        objEmpleado.Save(entEmpleado, False)
                    End If
                End If
                XtraMessageBox.Show("Error al dar de alta o editar el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mflgOkSave = True
                Me.Hide()
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub frmAbmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not mEntity Is Nothing Then
            Me.Text = "Edición de Usuario"
            Call LoadObjProperties()
        Else
            Me.Text = "Alta de Usuario"
        End If
        Call CargarCboEmpleados()
    End Sub

    Private Sub LoadObjProperties()
        cboEmpleados.Visible = False
        txtUsuario.Enabled = False
        lblEmpleado.Visible = False

        txtUsuario.Text = mEntity.ID
        txtUsuario.Enabled = False
        txtPassword.Text = mEntity.CLAVE
        txtNombre.Text = mEntity.NOMBRE
        chkSupervisor.Checked = mEntity.SUPERVISOR
        chkRRHH.Checked = mEntity.RRHH
        chkDirectorRrhh.Checked = mEntity.DIRECTORRRHH
    End Sub

    Private Sub CargarCboEmpleados()
        Dim obj As New EmpleadoComponent(Session.CadenaConexion)
        Dim List As List(Of Empleado)
        Try
            List = obj.GetAllActivos()

            cboEmpleados.Properties.NullText = "Seleccione un Empleado"
            cboEmpleados.Properties.DisplayMember = "NOMBRE"
            cboEmpleados.Properties.ValueMember = "ID"
            cboEmpleados.Properties.DataSource = List
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cboEmpleados_EditValueChanged(sender As Object, e As EventArgs) Handles cboEmpleados.EditValueChanged
        Try
            Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
            Dim entEmpleado As Empleado = objEmpleado.GetEntById(cboEmpleados.EditValue)
            If entEmpleado Is Nothing Then Exit Sub
            txtNombre.Text = entEmpleado.NOMBRE
            txtUsuario.Text = entEmpleado.NRODOCUMENTO
            txtNombre.Enabled = False
            txtUsuario.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class