Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors

Public Class frmabmAusenciaEmpleado
    Inherits XtraForm

    Private mentEmpleado As Empleado
    Private mEntity As AusenciaEmpleado
    Private mflgOkSave As Boolean = False


#Region "Properties"

    Public Property Empleado As Empleado
        Get
            Return mentEmpleado
        End Get
        Set(value As Empleado)
            mentEmpleado = value
        End Set
    End Property
    Public Property Entity As AusenciaEmpleado
        Get
            Return mEntity
        End Get
        Set(value As AusenciaEmpleado)
            mEntity = value
        End Set
    End Property
    Public ReadOnly Property OkSave As Boolean
        Get
            Return mflgOkSave
        End Get
    End Property
#End Region
    Private Sub frmAbmHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DefineErrProviders()
            Call LoadComboAusencias()

            If Not mEntity Is Nothing Then
                Me.Text = "Edición de ausencia"
                Call LoadObjProperties()
            Else
                Me.Text = "Alta de ausencia"
            End If

            lblEmpleado.Text = mentEmpleado.NOMBRE
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LoadComboAusencias()
        Try
            Dim objTipoAusencias As New TipoAusenciaComponent(Session.CadenaConexion)
            Dim ListAusencias As List(Of TipoAusencia) = objTipoAusencias.GetALL()
            ListAusencias.Where(Function(f) f.ACTIVO).ToList()

            CboAusencias.Properties.NullText = "Seleccione un tipo de ausencia"
            CboAusencias.Properties.DisplayMember = "DESCRIPCION"
            CboAusencias.Properties.ValueMember = "ID"
            CboAusencias.Properties.DataSource = ListAusencias
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub LoadObjProperties()
        DTFechaDesde.EditValue = mEntity.FECHADESDE
        DTFechaHasta.EditValue = mEntity.FECHAHASTA
        CboAusencias.EditValue = mEntity.IDTIPOAUSENCIA
    End Sub
    Private Sub DefineErrProviders()
        Try
            Dim iErrPad As Integer = 3
            ErrProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            OkProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            WarnProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            For Each oControl As Control In Me.Controls
                If oControl.Name.StartsWith("txt") Or oControl.Name.StartsWith("cbo") Or oControl.Name.StartsWith("chk") Or oControl.Name.StartsWith("DT") Or oControl.Name.StartsWith("msk") Then
                    ErrProvider.SetIconPadding(oControl, iErrPad)
                    OkProvider.SetIconPadding(oControl, iErrPad)
                    WarnProvider.SetIconPadding(oControl, iErrPad)
                End If
            Next

            ErrProvider.SetError(DTFechaDesde, "Debe seleccionar una fecha de inicio")
            ErrProvider.SetError(DTFechaHasta, "Debe seleccionar una fecha de fin")
            ErrProvider.SetError(CboAusencias, "Debe ingresar una hora de salida")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#Region "Eventos controles"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim entAusenciaEmpleadoAUX As New AusenciaEmpleado
        Dim objAusenciaEmpleado As New AusenciaEmpleadoComponent(Session.CadenaConexion)
        Dim listAusenciaEmpleadoAUX As New List(Of AusenciaEmpleado)
        Dim fLgOK As Boolean = True
        Dim fechaInicio As Date
        Dim fechaFin As Date

        Try
            If IsDate(DTFechaDesde.EditValue) And IsDate(DTFechaHasta.EditValue) Then
                fechaInicio = DTFechaDesde.EditValue
                fechaFin = DTFechaHasta.EditValue

                If fechaFin >= fechaInicio Then
                    listAusenciaEmpleadoAUX = objAusenciaEmpleado.GetByEmpleado(mentEmpleado.ID).Where(Function(f) f.IDUSUARIOANULA = "").ToList()
                    If listAusenciaEmpleadoAUX.Count > 0 Then
                        For Each entAusenciaEmpleadoAUX In listAusenciaEmpleadoAUX
                            If Not mEntity Is Nothing Then
                                If mEntity.ID <> entAusenciaEmpleadoAUX.ID Then
                                    If (fechaInicio >= entAusenciaEmpleadoAUX.FECHADESDE And fechaInicio <= entAusenciaEmpleadoAUX.FECHAHASTA) Or
                                    (fechaFin >= entAusenciaEmpleadoAUX.FECHADESDE And fechaFin <= entAusenciaEmpleadoAUX.FECHAHASTA) Then
                                        'El nuevo horario esta dentro del horario anterior
                                        XtraMessageBox.Show("Ya existe un pedido de ausencia que incluye los días que intenta cargar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        fLgOK = False
                                        Exit For
                                    End If
                                End If
                            Else
                                If (fechaInicio >= entAusenciaEmpleadoAUX.FECHADESDE And fechaInicio <= entAusenciaEmpleadoAUX.FECHAHASTA) Or
                                   (fechaFin >= entAusenciaEmpleadoAUX.FECHADESDE And fechaFin <= entAusenciaEmpleadoAUX.FECHAHASTA) Then
                                    'El nuevo horario esta dentro del horario anterior
                                    XtraMessageBox.Show("Ya existe un pedido de ausencia que incluye los días que intenta cargar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    fLgOK = False
                                    Exit For
                                End If
                            End If
                        Next
                    End If

                    If fLgOK Then
                        If Not validarDatos() Then Exit Sub
                        Call SetObjProperties()

                        If objAusenciaEmpleado.SaveConTraza(mEntity, Session.Usuario.ID) Then
                            XtraMessageBox.Show("Solicitud de ausencia guardada correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mflgOkSave = True
                            Me.Hide()
                        Else
                            XtraMessageBox.Show("Error al guardar ausencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Else
                    XtraMessageBox.Show("Rango de fechas incorrecto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                XtraMessageBox.Show("Rango de fechas incorrecto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub DTFechaEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaDesde.EditValueChanged
        Call validaDTEntrada()
    End Sub

    Private Sub DTFechaSalida_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaHasta.EditValueChanged
        Call validaDTSalida()
    End Sub

    Private Sub DTAusencias_EditValueChanged(sender As Object, e As EventArgs) Handles CboAusencias.EditValueChanged
        ValidaAusencia()
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Public Sub SetObjProperties()
        Try
            If mEntity Is Nothing Then mEntity = New AusenciaEmpleado
            mEntity.BeginUpdate()
            mEntity.FECHADESDE = DTFechaDesde.EditValue
            mEntity.FECHAHASTA = DTFechaHasta.EditValue
            mEntity.IDEMPLEADO = mentEmpleado.ID
            mEntity.IDTIPOAUSENCIA = CboAusencias.EditValue
            If mEntity.IsNew Then
                mEntity.IDUSUARIOSOLICITA = Session.Usuario.ID
                mEntity.FECHASOLICITUD = Date.Now
            End If
            If Session.Usuario.RRHH OrElse Session.Usuario.DIRECTORRRHH Then
                mEntity.IDUSUARIOAPRUEBA = Session.Usuario.ID
                mEntity.FECHAAPROBACION = Date.Now
            ElseIf Session.Usuario.SUPERVISOR Then
                mEntity.IDUSUARIOVALIDA = Session.Usuario.ID
                mEntity.FECHAVALIDACION = Date.Now
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region

#Region "Validaciones"

    Private Function ValidaAusencia() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If CboAusencias.EditValue Is Nothing Then
                ErrProvider.SetError(CboAusencias, "Debe indicar un tipo de ausencia")
            Else
                OkProvider.SetError(CboAusencias, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(CboAusencias, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, CboAusencias)
        Return flgOk
    End Function

    Private Function validaDTEntrada() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If String.IsNullOrEmpty(DTFechaDesde.Text) Then
                ErrProvider.SetError(DTFechaDesde, "Debe ingresar una fecha de entrada")
            Else
                OkProvider.SetError(DTFechaDesde, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(DTFechaDesde, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, DTFechaDesde)
        Return flgOk
    End Function

    Private Function validaDTSalida() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If String.IsNullOrEmpty(DTFechaHasta.Text) Then
                ErrProvider.SetError(DTFechaHasta, "Debe ingresar una fecha de salida")
            Else
                OkProvider.SetError(DTFechaHasta, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(DTFechaHasta, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, DTFechaHasta)
        Return flgOk
    End Function

    Public Function validarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False

        Try
            If Not validaDTEntrada() Then flgConError = True
            If Not validaDTSalida() Then flgConError = True
            If Not ValidaAusencia() Then flgConError = True

            If flgConError And flgConMensajeBox Then XtraMessageBox.Show("Errores en la validación de los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function

#End Region
End Class