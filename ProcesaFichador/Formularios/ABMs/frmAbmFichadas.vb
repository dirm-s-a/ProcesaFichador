Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports Employees.Data
Imports Turnos.GlobalFunctions
Imports DevExpress.XtraGrid.Views.Base

Imports DevExpress.XtraEditors
Public Class frmAbmFichadas
    Inherits XtraForm

    Private mflgOkSave As Boolean = False
    Private mEntity As FichadaLectura

#Region "Properties"
    Public Property Entity As FichadaLectura
        Get
            Return mEntity
        End Get
        Set(value As FichadaLectura)
            mEntity = value
        End Set
    End Property
    Public ReadOnly Property OkSave As Boolean
        Get
            Return mflgOkSave
        End Get
    End Property
#End Region

#Region "Eventos controles"
    Private Sub frmAbmFichadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DefineErrProviders()
            Call CargarCboEmpleados()
            Call CargarComboTipoFichadas()

            If Not mEntity Is Nothing Then
                Me.Text = "Editar fichada"
                Call loadObjProperties()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objFichadaLectura As New FichadaLecturaComponent(Session.CadenaConexion)
            If Not SetObjProperties() Then Exit Sub

            If objFichadaLectura.Save(mEntity) Then
                Dim objTrazaCambio As New TrazaCambioComponent(Session.CadenaConexion)
                Dim entTraza As New TrazaCambio
                entTraza.BeginUpdate()
                entTraza.IDFICHADALECTURA = Entity.ID
                entTraza.IDUSUARIO = Session.Usuario.ID
                entTraza.OBSERVACIONES = "Alta de fichada manual."

                objTrazaCambio.Save(entTraza)

                XtraMessageBox.Show("Fichada guardada correctamente." & Environment.NewLine & "Se recomienda que Pre analice al empleado luego de completar la carga manual de fichadas", ProductName, MessageBoxButtons.OK)
                mflgOkSave = True
                Me.Hide()
            Else
                XtraMessageBox.Show("Error al guardar fichada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub DTFechaEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaFichada.EditValueChanged
        Call ValidaFechaFichada()
    End Sub

    Private Sub txtHoraEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles txtHorafichada.EditValueChanged
        Call ValidaHoraFichada()
    End Sub

    Private Sub cboEmpleados_EditValueChanged(sender As Object, e As EventArgs) Handles cboEmpleados.EditValueChanged
        Call ValidaEmpleados()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
    Private Sub cboTipoFichada_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoFichada.EditValueChanged
        Call ValidaTipoFichada()
    End Sub


#End Region

#Region "Funciones y procedimientos"

    Private Sub CargarComboTipoFichadas()
        Dim List As New List(Of GenericIdStringDTO)
        Try
            List.Add(New GenericIdStringDTO("0", "ENTRADA"))
            List.Add(New GenericIdStringDTO("1", "SALIDA"))

            cboTipoFichada.Properties.NullText = "Seleccione un tipo de fichada"
            cboTipoFichada.Properties.DisplayMember = "DESCRIPCION"
            cboTipoFichada.Properties.ValueMember = "ID"
            cboTipoFichada.Properties.DataSource = List
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

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

    Private Sub loadObjProperties()
        cboEmpleados.EditValue = mEntity.IDEMPLEADO
        cboEmpleados.Enabled = False
        DTFechaFichada.Text = mEntity.FECHAFICHADA.Date
        txtHorafichada.Text = Format(mEntity.FECHAFICHADA, "HH:mm")
    End Sub

    Private Function SetObjProperties() As Boolean
        Try
            If Not validarDatos() Then Return False
            If mEntity Is Nothing Then mEntity = New FichadaLectura
            mEntity.BeginUpdate()
            If mEntity.IsNew Then mEntity.IDEMPLEADO = cboEmpleados.EditValue
            mEntity.TIPOFICHADA = cboTipoFichada.EditValue
            mEntity.FECHAFICHADA = DTFechaFichada.EditValue
            mEntity.FECHAFICHADA = mEntity.FECHAFICHADA.AddHours(CInt(Strings.Left(txtHorafichada.Text, 2))).AddMinutes(CInt(Strings.Right(txtHorafichada.Text, 2)))
            mEntity.IDUSUARIOSUPERVISORCAMBIO = Session.Usuario.ID
            mEntity.IDEMPLEADOLECTORA = "ALTA MANUAL"

            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

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

            ErrProvider.SetError(txtHorafichada, "Debe ingresar una hora de fichada")
            ErrProvider.SetError(cboEmpleados, "Debe seleccionar un empleado")
            ErrProvider.SetError(cboTipoFichada, "Debe seleccionar un tipo de fichada")
            ErrProvider.SetError(DTFechaFichada, "Debe seleccionar una fecha de fichada")

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Validaciones"
    Public Function validarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False

        Try
            If Not ValidaEmpleados() Then flgConError = True
            If Not ValidaTipoFichada() Then flgConError = True
            If Not ValidaFechaFichada() Then flgConError = True
            If Not ValidaHoraFichada() Then flgConError = True

            If flgConError And flgConMensajeBox Then
                XtraMessageBox.Show("Errores en la validación de los datos !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function

    Private Function ValidaHoraFichada() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If String.IsNullOrEmpty(txtHorafichada.Text) Then
                ErrProvider.SetError(txtHorafichada, "Debe ingresar una hora de fichada")
            Else
                If Not IsNumeric(Strings.Left(txtHorafichada.Text, 2)) Then
                    ErrProvider.SetError(txtHorafichada, "Formato de hora incorrecto")
                ElseIf Not IsNumeric(Strings.Right(txtHorafichada.Text, 2)) Then
                    ErrProvider.SetError(txtHorafichada, "Formato de hora incorrecto")
                ElseIf CInt(Strings.Left(txtHorafichada.Text, 2)) < 0 OrElse CInt(Strings.Left(txtHorafichada.Text, 2)) > 24 Then
                    ErrProvider.SetError(txtHorafichada, "Formato de hora incorrecto")
                ElseIf CInt(Strings.Right(txtHorafichada.Text, 2)) < 0 OrElse CInt(Strings.Right(txtHorafichada.Text, 2)) > 60 Then
                    ErrProvider.SetError(txtHorafichada, "Formato de hora incorrecto")
                Else
                    OkProvider.SetError(txtHorafichada, "Ok")
                    flgOk = True
                End If
            End If
        Catch ex As Exception
            ErrProvider.SetError(txtHorafichada, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtHorafichada)
        Return flgOk
    End Function

    Private Function ValidaFechaFichada() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If String.IsNullOrEmpty(DTFechaFichada.Text) Then
                ErrProvider.SetError(DTFechaFichada, "Debe ingresar una fecha de fichada")
            Else
                OkProvider.SetError(DTFechaFichada, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(DTFechaFichada, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, DTFechaFichada)
        Return flgOk
    End Function

    Private Function ValidaEmpleados() As Boolean
        Dim flgOk As Boolean = False
        Dim flgWarning As Boolean = False

        Try
            If cboEmpleados.GetSelectedDataRow Is Nothing Then
                ErrProvider.SetError(cboEmpleados, "Debe seleccionar un empleado")
            Else
                OkProvider.SetError(cboEmpleados, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(cboEmpleados, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try

        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, cboEmpleados)
        Return flgOk
    End Function

    Private Function ValidaTipoFichada() As Boolean
        Dim flgOk As Boolean = False
        Dim flgWarning As Boolean = False

        Try
            If cboTipoFichada.GetSelectedDataRow Is Nothing Then
                ErrProvider.SetError(cboEmpleados, "Debe seleccionar un tipo de fichada")
            Else
                OkProvider.SetError(cboTipoFichada, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(cboTipoFichada, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try

        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, cboTipoFichada)
        Return flgOk
    End Function

#End Region

End Class