
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Public Class frmAbmEmpleado
    Inherits XtraForm

    Private mflgOkSave As Boolean = False
    Private mflgEdicion As Boolean = False
    Private mEntity As Empleado

    Public Property Entity As Empleado
        Get
            Return mEntity
        End Get
        Set(value As Empleado)
            mEntity = value
        End Set
    End Property
    Public ReadOnly Property OkSave As Boolean
        Get
            Return mflgOkSave
        End Get
    End Property

    Public Property flgEdicion As Boolean
        Get
            Return mflgEdicion
        End Get
        Set(value As Boolean)
            mflgEdicion = value
        End Set
    End Property

#Region "Eventos controles"
    Private Sub frmAbmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DefineErrProviders()
            Call loadCboConvenios

            If Not mEntity Is Nothing Then
                If Not mEntity.IsNew Then
                    txtNombre.Text = mEntity.NOMBRE
                    txtSector.Text = mEntity.SECTOR
                    txtNroDocumento.Text = mEntity.NRODOCUMENTO
                    chkInactivo.Checked = mEntity.INACTIVO
                    cboConvenio.EditValue = mEntity.IDCONVENIO
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub loadCboConvenios()
        Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)
        Try
            cboConvenio.Properties.DataSource = objConvenio.GetALL
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub DefineErrProviders()
        Try
            Dim iErrPad As Integer = 3
            ErrProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            OkProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            WarnProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            For Each oControl As Control In Me.Controls
                If oControl.Name.StartsWith("txt") OrElse oControl.Name.StartsWith("cbo") Or oControl.Name.StartsWith("chk") Then
                    ErrProvider.SetIconPadding(oControl, iErrPad)
                    OkProvider.SetIconPadding(oControl, iErrPad)
                    WarnProvider.SetIconPadding(oControl, iErrPad)
                End If
            Next

            ErrProvider.SetError(txtNroDocumento, "Debe ingresar un dni")
            ErrProvider.SetError(cboConvenio, "Debe seleccionar un convenio")
            ErrProvider.SetError(txtNombre, "Debe ingresar un nombre")
            ErrProvider.SetError(txtSector, "Debe ingresar un sector")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
            If Not SetObjProperties() Then Exit Sub

            If mEntity.IsNew Then
                Dim ListEmpleado As List(Of Empleado) = objEmpleado.GetByDocumento(Trim(txtNroDocumento.Text))
                If ListEmpleado.Count > 0 Then
                    XtraMessageBox.Show("Ya existe un empleado con este dni", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If objEmpleado.SaveConTraza(mEntity) Then
                XtraMessageBox.Show("Empleado guardado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mflgOkSave = True
                Me.Hide()
            Else
                XtraMessageBox.Show("Error al guardar empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Funciones y procedimientos"
    Private Function SetObjProperties() As Boolean
        Try
            If Not validarDatos() Then Return False

            If mEntity Is Nothing Then mEntity = New Empleado
            mEntity.BeginUpdate()
            If mEntity.IsNew Then mEntity.IDUSUARIOALTA = Session.Usuario.ID
            mEntity.IDUSUARIOMODIFICACION = Session.Usuario.ID
            mEntity.NOMBRE = Trim(txtNombre.Text.ToUpper)
            mEntity.NRODOCUMENTO = IIf(txtNroDocumento.Text = "", "S/A", txtNroDocumento.Text)
            mEntity.SECTOR = Trim(txtSector.Text)
            mEntity.INACTIVO = chkInactivo.Checked
            mEntity.IDCONVENIO = cboConvenio.EditValue

            If mEntity.INACTIVO Then
                mEntity.FECHABAJA = DateTime.Now
            Else
                mEntity.FECHABAJA = Date.MinValue
            End If

            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return False
    End Function

    Public Function validarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False

        Try
            If Not ValidatxtNroDocumento() Then flgConError = True
            If Not ValidatxtNombre() Then flgConError = True
            If Not ValidatxtSector() Then flgConError = True
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function
    Private Function ValidaConvenio() As Boolean
        Dim flgOk As Boolean = False
        Dim flgWarning As Boolean = False

        Try
            If cboConvenio.GetSelectedDataRow Is Nothing Then
                ErrProvider.SetError(cboConvenio, "Debe seleccionar un convenio")
            Else
                OkProvider.SetError(cboConvenio, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(cboConvenio, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try

        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, cboConvenio)
        Return flgOk
    End Function


    Private Function ValidatxtNroDocumento() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try

            If Trim(txtNroDocumento.Text) = "S/A" Then
                OkProvider.SetError(txtNroDocumento, "ok")
                flgOk = True
            ElseIf Not IsNumeric(txtNroDocumento.Text) Then
                ErrProvider.SetError(txtNroDocumento, "Debe ingresar un dni")
            Else
                OkProvider.SetError(txtNroDocumento, "ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(txtNroDocumento, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtNroDocumento)
        Return flgOk
    End Function

    Private Function ValidatxtNombre() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If Trim(txtNombre.Text) = "" Then
                ErrProvider.SetError(txtNombre, "Debe ingresar un nombre")
            Else
                OkProvider.SetError(txtNombre, "ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(txtNombre, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtNombre)
        Return flgOk
    End Function

    Private Function ValidatxtSector() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If Trim(txtSector.Text) = "" Then
                ErrProvider.SetError(txtSector, "Debe ingresar un sector")
            Else
                OkProvider.SetError(txtSector, "ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(txtSector, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtSector)
        Return flgOk
    End Function

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ValidatxtNombre()
    End Sub

    Private Sub txtSector_EditValueChanged(sender As Object, e As EventArgs) Handles txtSector.EditValueChanged
        ValidatxtSector()
    End Sub

    Private Sub txtNroDocumento_EditValueChanged(sender As Object, e As EventArgs) Handles txtNroDocumento.EditValueChanged
        ValidatxtNroDocumento()
    End Sub

    Private Sub cboConvenio_EditValueChanged(sender As Object, e As EventArgs) Handles cboConvenio.EditValueChanged
        ValidaConvenio()
    End Sub
#End Region
End Class