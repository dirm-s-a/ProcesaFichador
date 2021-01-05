Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Imports Turnos.GlobalFunctions.Data

Public Class frmAbmHorarioAdic
    Inherits XtraForm

    Private mIdEmpleado As Long = F_Set_NullValue(mIdEmpleado)
    Private mNombreEmpleado As String = String.Empty
    Private mEntity As HorarioAdicEmpleado
    Private mflgNew As Boolean = True
    Private mflgOkSave As Boolean = False

#Region "Properties"
    Public Property IDEMPLEADO As Long
        Get
            Return mIdEmpleado
        End Get
        Set(value As Long)
            mIdEmpleado = value
        End Set
    End Property

    Public Property NOMBREEMPLEADO As String
        Get
            Return mNombreEmpleado
        End Get
        Set(value As String)
            mNombreEmpleado = value
        End Set
    End Property

    Public Property Entity As HorarioAdicEmpleado
        Get
            Return mEntity
        End Get
        Set(value As HorarioAdicEmpleado)
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
    Private Sub frmAbmHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DefineErrProviders()

            If Not mEntity Is Nothing Then
                Me.Text = "Edición de horario adicional"
                Call LoadObjProperties()
                If Session.Usuario.RRHH Then
                    chkAutorizado.Enabled = Not chkAutorizado.Checked
                Else
                    chkAutorizado.Enabled = False
                End If
            Else
                chkAutorizado.Checked = Session.Usuario.RRHH
                chkAutorizado.Enabled = False
                Me.Text = "Alta de horario adicional"
            End If

            If mNombreEmpleado <> "" Then Me.Text &= " ( " & mNombreEmpleado & " )"
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call GuardarHorario
    End Sub

    Private Sub GuardarHorario()
        Dim objHorarioAdicEmpleado As New HorarioAdicEmpleadoComponent(Session.CadenaConexion)
        Dim fLgOK As Boolean = True

        Try
            If Not ValidarDatos() Then Exit Sub

            If Not objHorarioAdicEmpleado.SaveConTraza(mEntity, , True) Then
                XtraMessageBox.Show("Error al guardar horario adicional del empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mflgOkSave = True
                Me.Hide()
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub DTFechaEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaDesde.EditValueChanged
        Try
            Dim FechaHasta As Date = F_Set_NullValue(FechaHasta)
            If Not DTFechaHasta.EditValue Is Nothing Then FechaHasta = DTFechaHasta.EditValue
            ValidaFecha(DTFechaDesde)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mskHoraEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraEntrada.EditValueChanged
        Call ValidaHora(mskHoraEntrada, True)
    End Sub

    Private Sub mskHoraSalida_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraSalida.EditValueChanged
        Call ValidaHora(mskHoraSalida, True)
    End Sub
    Private Sub mskHoraEntrada1_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraEntrada1.EditValueChanged
        Call ValidaHora(mskHoraEntrada1, Not (MskFechaVacia(mskHoraSalida1)))
        Call ValidaHora(mskHoraSalida1, Not (MskFechaVacia(mskHoraEntrada1)))
    End Sub

    Private Sub mskHoraSalida1_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraSalida1.EditValueChanged
        Call ValidaHora(mskHoraEntrada1, Not (MskFechaVacia(mskHoraSalida1)))
        Call ValidaHora(mskHoraSalida1, Not (MskFechaVacia(mskHoraEntrada1)))
    End Sub

    Private Sub mskHoraEntrada2_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraEntrada2.EditValueChanged
        Call ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2)))
        Call ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2)))
    End Sub

    Private Sub mskHoraSalida2_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraSalida2.EditValueChanged
        Call ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2)))
        Call ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2)))
    End Sub
    Private Sub DTFechaHasta_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaHasta.EditValueChanged
        Call ValidaFecha(DTFechaHasta)
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Private Sub LoadObjProperties()
        mflgNew = False
        DTFechaDesde.EditValue = mEntity.FECHADESDE
        DTFechaHasta.EditValue = mEntity.FECHAHASTA
        mskHoraEntrada.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA)
        mskHoraSalida.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA)
        If Not F_IsNullValue(mEntity.HORAENTRADA1) Then mskHoraEntrada1.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA1)
        If Not F_IsNullValue(mEntity.HORASALIDA1) Then mskHoraSalida1.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA1)
        If Not F_IsNullValue(mEntity.HORAENTRADA2) Then mskHoraEntrada2.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA2)
        If Not F_IsNullValue(mEntity.HORASALIDA2) Then mskHoraSalida2.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA2)
        If Not F_IsNullValue(mEntity.MINUTOSACUMPLIR) Then mskHorasACumplir.Text = AppSharedFunctions.MinutosAHoraFormateada(mEntity.MINUTOSACUMPLIR)
        chkAutorizado.Checked = mEntity.AUTORIZADO
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

            ErrProvider.SetError(DTFechaDesde, "Debe seleccionar una fecha")
            ErrProvider.SetError(DTFechaHasta, "Debe seleccionar una fecha")
            ErrProvider.SetError(mskHoraEntrada, "Debe ingresar una hora")
            ErrProvider.SetError(mskHoraSalida, "Debe ingresar una hora")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Validaciones"

    Private Function ValidaHora(ByVal Control As Control, Optional ByVal flgRequerido As Boolean = False) As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If Not IsNumeric(Strings.Left(Control.Text, 2)) Or Not IsNumeric(Strings.Left(Control.Text, 2)) Then
                If flgRequerido Then
                    ErrProvider.SetError(Control, "Debe ingresar una hora.")
                Else
                    If Not MskFechaVacia(Control) Then
                        ErrProvider.SetError(Control, "Hora inválida")
                    Else
                        OkProvider.SetError(Control, "")
                        WarnProvider.SetError(Control, "")
                        flgOk = True
                    End If
                End If
            ElseIf CInt(Strings.Left(Control.Text, 2)) < 0 Or CInt(Strings.Left(Control.Text, 2)) > 24 Then
                ErrProvider.SetError(Control, "Hora inválida")
            ElseIf CInt(Strings.Right(Control.Text, 2)) < 0 Or CInt(Strings.Right(Control.Text, 2)) > 60 Then
                ErrProvider.SetError(Control, "Hora inválida")
            Else
                OkProvider.SetError(Control, "Ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(Control, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, Control)
        Return flgOk
    End Function

    Private Function ValidaFecha(ByVal Control As Object) As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Try
            If String.IsNullOrEmpty(Control.EditValue) Then
                ErrProvider.SetError(Control, "Debe ingresar una fecha")
            ElseIf CDate(Control.EditValue).Year < 2000 Or CDate(Control.EditValue).Year > 2100 Then
                ErrProvider.SetError(Control, "Fecha fuera del rango admitido.")
            Else
                OkProvider.SetError(Control, "Ok")
                flgOk = True
            End If

            If Not DTFechaDesde.EditValue Is Nothing And Not DTFechaHasta.EditValue Is Nothing Then
                Dim FechaDesde As Date = CDate(DTFechaDesde.EditValue)
                Dim FechaHasta As Date = CDate(DTFechaHasta.EditValue)

                If FechaDesde > FechaHasta Then
                    ErrProvider.SetError(Control, "Fechas superpuestas.")
                    flgOk = False
                End If
            End If


            If flgOk AndAlso CDate(Control.EditValue) < Date.Today Then
                WarnProvider.SetError(Control, "La fecha indicada es una fecha pasada")
                flgWarning = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(Control, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, Control)
        Return flgOk
    End Function

    Private Function ValidarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False
        Dim objHorarioAdicEmpleado As New HorarioAdicEmpleadoComponent(Session.CadenaConexion)

        Try
            If Not ValidaFecha(DTFechaDesde) Then flgConError = True
            If Not ValidaFecha(DTFechaHasta) Then flgConError = True
            If Not ValidaHora(mskHoraEntrada, True) Then flgConError = True
            If Not ValidaHora(mskHoraSalida, True) Then flgConError = True
            If Not ValidaHora(mskHoraEntrada1, Not (MskFechaVacia(mskHoraSalida1))) Then flgConError = True
            If Not ValidaHora(mskHoraSalida1, Not (MskFechaVacia(mskHoraEntrada1))) Then flgConError = True
            If Not ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2))) Then flgConError = True
            If Not ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2))) Then flgConError = True
            If Not ValidaHora(mskHorasACumplir) Then flgConError = True
            Call SetObjProperties()

            If Not mEntity.ACTIVO Then
                XtraMessageBox.Show("El horario ha sido dado de baja. No se puede editar !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                flgConError = True
            ElseIf Entity.HORAENTRADA >= Entity.HORASALIDA Or
                (Entity.HORAENTRADA1 >= Entity.HORASALIDA1 And Entity.HORAENTRADA1 >= 0) Or
                (Entity.HORAENTRADA2 >= Entity.HORASALIDA2 And Entity.HORAENTRADA2 >= 0) Then
                XtraMessageBox.Show("El horario de entrada y salida es inválido !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                flgConError = False
            Else
                Dim FechaDesde As Date = DTFechaDesde.EditValue
                Dim FechaHasta As Date = DTFechaHasta.EditValue
                Dim listHorarioAdicEmpleado As List(Of HorarioAdicEmpleado)

                listHorarioAdicEmpleado = objHorarioAdicEmpleado.GetByEmpleado(mIdEmpleado)
                listHorarioAdicEmpleado = listHorarioAdicEmpleado.Where(Function(f) f.ACTIVO).ToList
                If Not mEntity Is Nothing Then listHorarioAdicEmpleado = listHorarioAdicEmpleado.Where(Function(f) Not f.ID.Equals(mEntity.ID)).ToList
                listHorarioAdicEmpleado = listHorarioAdicEmpleado.Where(Function(f) (f.FECHADESDE <= FechaDesde AndAlso f.FECHAHASTA >= FechaDesde) OrElse (f.FECHADESDE <= FechaHasta AndAlso f.FECHAHASTA >= FechaHasta)).ToList
                If listHorarioAdicEmpleado.Count > 0 Then
                    flgConError = True
                    XtraMessageBox.Show("Ya existe un horario adicional definido dentro de ese rango de fechas !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            If flgConError And flgConMensajeBox Then XtraMessageBox.Show("Errores en la validación de los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function

    Private Sub SetObjProperties()
        Try
            If mEntity Is Nothing Then mEntity = New HorarioAdicEmpleado
            mEntity.BeginUpdate()

            If mEntity.IsNew Then
                mEntity.IDEMPLEADO = mIdEmpleado
                mEntity.ACTIVO = True
            End If

            mEntity.IDUSUARIOMODIFICACION = Session.Usuario.ID
            mEntity.FECHADESDE = DTFechaDesde.EditValue
            mEntity.FECHAHASTA = DTFechaHasta.EditValue
            mEntity.HORAENTRADA = Strings.Left(mskHoraEntrada.Text, 2) * 100 + Strings.Right(mskHoraEntrada.Text, 2)
            mEntity.HORASALIDA = Strings.Left(mskHoraSalida.Text, 2) * 100 + Strings.Right(mskHoraSalida.Text, 2)
            If MskFechaVacia(mskHoraEntrada1) Then
                mEntity.HORAENTRADA1 = F_Set_NullValue(mEntity.HORAENTRADA1)
            Else
                mEntity.HORAENTRADA1 = AppSharedFunctions.HoraNormalAMilitar(mskHoraEntrada1.Text)
            End If
            If MskFechaVacia(mskHoraEntrada2) Then
                mEntity.HORAENTRADA2 = F_Set_NullValue(mEntity.HORAENTRADA2)
            Else
                mEntity.HORAENTRADA2 = AppSharedFunctions.HoraNormalAMilitar(mskHoraEntrada2.Text)
            End If
            If MskFechaVacia(mskHoraSalida1) Then
                mEntity.HORASALIDA1 = F_Set_NullValue(mEntity.HORASALIDA1)
            Else
                mEntity.HORASALIDA1 = AppSharedFunctions.HoraNormalAMilitar(mskHoraSalida1.Text)
            End If
            If MskFechaVacia(mskHoraSalida2) Then
                mEntity.HORASALIDA2 = F_Set_NullValue(mEntity.HORASALIDA2)
            Else
                mEntity.HORASALIDA2 = AppSharedFunctions.HoraNormalAMilitar(mskHoraSalida2.Text)
            End If

            mEntity.AUTORIZADO = chkAutorizado.Checked

            If Not F_IsNullValue(mskHorasACumplir.Text) Then mEntity.MINUTOSACUMPLIR = AppSharedFunctions.HoraFormateadaAMinutos(mskHorasACumplir.Text)
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function MskFechaVacia(ByVal Control As Control) As Boolean
        Try
            Return (Control.Text = "__:__" Or Control.Text = "")
        Catch ex As Exception
            Throw New System.Exception(ex.Message, ex.InnerException)
        End Try
    End Function

    Private Sub mskHorasACumplir_EditValueChanged(sender As Object, e As EventArgs) Handles mskHorasACumplir.EditValueChanged
        Call ValidaHora(mskHorasACumplir)
    End Sub

#End Region
End Class