Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Imports Turnos.GlobalFunctions.Data

Public Class frmAbmHorario
    Inherits XtraForm

    Private mIdEmpleado As Long
    Private mNombreEmpleado As String
    Private mEntity As HorarioEmpleado
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
    Public Property Entity As HorarioEmpleado
        Get
            Return mEntity
        End Get
        Set(value As HorarioEmpleado)
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
            Call FormatoControles()
            Call DefineErrProviders()
            Call LoadCboEntradaSalida()

            If Not mEntity Is Nothing Then
                Me.Text = "Edición de horario"
                Call LoadObjProperties()
            Else
                Me.Text = "Alta de horario"
            End If

            If mNombreEmpleado <> "" Then Me.Text &= " ( " & mNombreEmpleado & " )"

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub LoadObjProperties()
        DTFechaDesde.EditValue = mEntity.FECHADESDE
        DTFechaHasta.EditValue = mEntity.FECHAHASTA
        cboDiaEntrada.EditValue = CLng(mEntity.DIASEMANAENTRADA)
        cboDiaSalida.EditValue = CLng(mEntity.DIASEMANASALIDA)
        mskHoraEntrada.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA)
        mskHoraSalida.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA)
        If Not F_IsNullValue(mEntity.HORAENTRADA1) Then mskHoraEntrada1.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA1)
        If Not F_IsNullValue(mEntity.HORASALIDA1) Then mskHoraSalida1.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA1)
        If Not F_IsNullValue(mEntity.HORAENTRADA2) Then mskHoraEntrada2.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORAENTRADA2)
        If Not F_IsNullValue(mEntity.HORASALIDA2) Then mskHoraSalida2.Text = AppSharedFunctions.horaMilitarAnormal(mEntity.HORASALIDA2)
        If Not F_IsNullValue(mEntity.MINUTOSACUMPLIR) Then mskHorasACumplir.Text = AppSharedFunctions.MinutosAHoraFormateada(mEntity.MINUTOSACUMPLIR)
        chkFeriado.Checked = mEntity.INCLUYEFERIADOS
    End Sub
    Private Sub DefineErrProviders()
        Try
            Dim iErrPad As Integer = 3
            ErrProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            OkProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            WarnProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            For Each oControl As Control In Me.Controls
                If oControl.Name.StartsWith("DT") OrElse oControl.Name.StartsWith("txt") OrElse oControl.Name.StartsWith("cbo") Or oControl.Name.StartsWith("chk") Or oControl.Name.StartsWith("msk") Then
                    ErrProvider.SetIconPadding(oControl, iErrPad)
                    OkProvider.SetIconPadding(oControl, iErrPad)
                    WarnProvider.SetIconPadding(oControl, iErrPad)
                End If
            Next

            ErrProvider.SetError(DTFechaDesde, "Debe seleccionar una fecha")
            ErrProvider.SetError(DTFechaHasta, "Debe seleccionar una fecha")
            ErrProvider.SetError(cboDiaEntrada, "Debe seleccionar un día de entrada")
            ErrProvider.SetError(cboDiaSalida, "Debe seleccionar un día de salida")
            ErrProvider.SetError(mskHoraEntrada, "Debe ingresar una hora de entrada")
            ErrProvider.SetError(mskHoraSalida, "Debe ingresar una hora de salida")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#Region "Eventos controles"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objHorarioEmpleado As New HorarioEmpleadoComponent(Session.CadenaConexion)

        Try
            If ValidarDatos() Then
                Call SetObjProperties()
                If objHorarioEmpleado.SaveConTraza(mEntity,, True) Then
                    mflgOkSave = True
                    Me.Hide()
                Else
                    XtraMessageBox.Show("Error al guardar horario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cboDiaEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiaEntrada.EditValueChanged
        Call ValidaDiaEntrada()
    End Sub

    Private Sub cboDiaSalida_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiaSalida.EditValueChanged
        Call ValidaDiaSalida()
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
        Call ValidaHora(mskHoraSalida1, Not (MskFechaVacia(mskHoraEntrada1)))
        Call ValidaHora(mskHoraEntrada1, Not (MskFechaVacia(mskHoraSalida1)))
    End Sub

    Private Sub mskHoraEntrada2_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraEntrada2.EditValueChanged
        Call ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2)))
        Call ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2)))
    End Sub

    Private Sub mskHoraSalida2_EditValueChanged(sender As Object, e As EventArgs) Handles mskHoraSalida2.EditValueChanged
        Call ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2)))
        Call ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2)))
    End Sub

    Private Sub DTFechaEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaDesde.EditValueChanged
        Try
            Dim FechaHasta As Date = F_Set_NullValue(FechaHasta)
            If Not DTFechaHasta.EditValue Is Nothing Then FechaHasta = DTFechaHasta.EditValue
            ValidaFecha(DTFechaDesde)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DTFechaHasta_EditValueChanged(sender As Object, e As EventArgs) Handles DTFechaHasta.EditValueChanged
        Call ValidaFecha(DTFechaHasta)
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Private Sub SetObjProperties()
        Try
            If mEntity Is Nothing Then mEntity = New HorarioEmpleado
            mEntity.BeginUpdate()

            If mEntity.IsNew Then
                mEntity.IDEMPLEADO = mIdEmpleado
                mEntity.ACTIVO = True
            End If

            mEntity.FECHADESDE = DTFechaDesde.EditValue
            mEntity.FECHAHASTA = DTFechaHasta.EditValue

            mEntity.IDUSUARIOMODIFICACION = Session.Usuario.ID

            mEntity.DIASEMANAENTRADA = CInt(cboDiaEntrada.EditValue)
            mEntity.DIASEMANASALIDA = CInt(cboDiaSalida.EditValue)

            mEntity.HORAENTRADA = AppSharedFunctions.HoraNormalAMilitar(mskHoraEntrada.Text)
            mEntity.HORASALIDA = AppSharedFunctions.HoraNormalAMilitar(mskHoraSalida.Text)
            If MskFechaVacia(mskHoraEntrada1) Then
                mEntity.HORAENTRADA1 = F_Set_NullValue(Entity.HORAENTRADA1)
            Else
                mEntity.HORAENTRADA1 = AppSharedFunctions.HoraNormalAMilitar(mskHoraEntrada1.Text)
            End If
            If MskFechaVacia(mskHoraEntrada2) Then
                mEntity.HORAENTRADA2 = F_Set_NullValue(Entity.HORAENTRADA2)
            Else
                mEntity.HORAENTRADA2 = AppSharedFunctions.HoraNormalAMilitar(mskHoraEntrada2.Text)
            End If
            If MskFechaVacia(mskHoraSalida1) Then
                mEntity.HORASALIDA1 = F_Set_NullValue(Entity.HORASALIDA1)
            Else
                mEntity.HORASALIDA1 = AppSharedFunctions.HoraNormalAMilitar(mskHoraSalida1.Text)
            End If
            If MskFechaVacia(mskHoraSalida2) Then
                mEntity.HORASALIDA2 = F_Set_NullValue(Entity.HORASALIDA2)
            Else
                mEntity.HORASALIDA2 = AppSharedFunctions.HoraNormalAMilitar(mskHoraSalida2.Text)
            End If

            mEntity.INCLUYEFERIADOS = (chkFeriado.Checked = True)

            If Not F_IsNullValue(mskHorasACumplir.Text) Then mEntity.MINUTOSACUMPLIR = AppSharedFunctions.HoraFormateadaAMinutos(mskHorasACumplir.Text)

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormatoControles()

        Try
            cboDiaEntrada.Properties.NullText = "Seleccione día de entrada"
            cboDiaEntrada.Properties.DisplayMember = "DESCRIPCION"
            cboDiaEntrada.Properties.ValueMember = "ID"
            cboDiaSalida.Properties.NullText = "Seleccione día de salida"
            cboDiaSalida.Properties.DisplayMember = "DESCRIPCION"
            cboDiaSalida.Properties.ValueMember = "ID"
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub LoadCboEntradaSalida()
        Dim ListDias As New List(Of GenericIdLongDTO)
        Try
            For X As Integer = 1 To 7
                ListDias.Add(New GenericIdLongDTO(X, UCase(WeekdayName(X,, FirstDayOfWeek.Monday))))
            Next

            cboDiaEntrada.Properties.DataSource = ListDias
            cboDiaSalida.Properties.DataSource = ListDias
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region

#Region "Validaciones"
    Private Function ValidaFecha(ByVal Control As Object) As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        'Dim objHorarioAdicEmpleado As New HorarioAdicEmpleadoComponent(Session.CadenaConexion)
        'Dim listHorarioAdicEmpleado As New List(Of HorarioAdicEmpleado)
        Try
            If String.IsNullOrEmpty(Control.EditValue) Then
                ErrProvider.SetError(Control, "Debe ingresar una fecha")
            ElseIf CDate(Control.EditValue).Year < 2000 Or CDate(Control.EditValue).Year > 2100 Then
                ErrProvider.SetError(Control, "Fecha fuera del rango admitido.")
            Else
                OkProvider.SetError(Control, "Ok")
                flgOk = True
                '    End If
            End If

            If Not DTFechaDesde.EditValue Is Nothing And Not DTFechaHasta.EditValue Is Nothing Then
                Dim FechaDesde As Date = CDate(DTFechaDesde.EditValue)
                Dim FechaHasta As Date = CDate(DTFechaHasta.EditValue)

                If FechaDesde > FechaHasta Then
                    ErrProvider.SetError(Control, "Fechas superpuestas.")
                    flgOk = False
                End If
            End If

        Catch ex As Exception
            ErrProvider.SetError(Control, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, Control)
        Return flgOk
    End Function

    Private Function ValidaDiaEntrada() As Boolean
        Dim flgOk As Boolean = False
        Dim flgWarning As Boolean = False

        Try
            If cboDiaEntrada.GetSelectedDataRow Is Nothing Then
                ErrProvider.SetError(cboDiaEntrada, "Debe seleccionar un día de entrada")
            Else
                If Not cboDiaSalida.GetSelectedDataRow Is Nothing Then
                    If cboDiaEntrada.EditValue > cboDiaSalida.EditValue Then
                        ErrProvider.SetError(cboDiaEntrada, "El día de salida no puede ser menor al del entrada.")
                    Else
                        OkProvider.SetError(cboDiaEntrada, "Ok")
                        flgOk = True
                    End If
                Else
                    OkProvider.SetError(cboDiaEntrada, "Ok")
                    flgOk = True
                End If
            End If
        Catch ex As Exception
            ErrProvider.SetError(cboDiaEntrada, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try

        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, cboDiaEntrada)
        Return flgOk
    End Function

    Private Function ValidaDiaSalida() As Boolean
        Dim flgOk As Boolean = False
        Dim flgWarning As Boolean = False

        Try
            If cboDiaSalida.GetSelectedDataRow Is Nothing Then
                ErrProvider.SetError(cboDiaSalida, "Debe seleccionar un día de salida")
            Else
                If Not cboDiaEntrada.GetSelectedDataRow Is Nothing Then
                    If cboDiaEntrada.EditValue > cboDiaSalida.EditValue Then
                        ErrProvider.SetError(cboDiaSalida, "El día de salida no puede ser menor al del entrada.")
                    Else
                        OkProvider.SetError(cboDiaSalida, "Ok")
                        flgOk = True
                    End If
                Else
                    OkProvider.SetError(cboDiaSalida, "Ok")
                    flgOk = True
                End If
            End If
        Catch ex As Exception
            ErrProvider.SetError(cboDiaSalida, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try

        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, cboDiaSalida)
        Return flgOk
    End Function

    Private Function MskFechaVacia(ByVal Control As Control) As Boolean
        Try
            Return (Control.Text = "__:__" Or Control.Text = "")
        Catch ex As Exception
            Throw New System.Exception(ex.Message, ex.InnerException)
        End Try
    End Function
    Private Function ValidaDiasRepetidos() As Boolean
        Dim flgOk As Boolean = True
        Dim listHorarioEmpleado As List(Of HorarioEmpleado)
        Dim objHorarioEmpleado As New HorarioEmpleadoComponent(Session.CadenaConexion)

        Try
            Dim FechaDesde As Date = DTFechaDesde.EditValue
            Dim FechaHasta As Date = DTFechaHasta.EditValue

            listHorarioEmpleado = objHorarioEmpleado.GetByEmpleado(mIdEmpleado)
            listHorarioEmpleado = listHorarioEmpleado.Where(Function(f) f.ACTIVO).ToList
            If Not mEntity Is Nothing Then listHorarioEmpleado = listHorarioEmpleado.Where(Function(f) Not f.ID.Equals(mEntity.ID)).ToList
            listHorarioEmpleado = listHorarioEmpleado.Where(Function(f) (f.FECHADESDE <= FechaDesde AndAlso f.FECHAHASTA >= FechaDesde) OrElse (f.FECHADESDE <= FechaHasta AndAlso f.FECHAHASTA >= FechaHasta)).ToList

            For X As Integer = cboDiaEntrada.EditValue To cboDiaSalida.EditValue
                Dim DiaSemana As Integer = X
                If listHorarioEmpleado.Exists(Function(f) f.DIASEMANAENTRADA <= DiaSemana AndAlso f.DIASEMANASALIDA >= DiaSemana) Then
                    flgOk = False
                    Exit For
                End If
            Next

            If Not flgOk Then XtraMessageBox.Show("Existe otro horario asignado al empleado con días que ha seleccionado en el actual horario !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return flgOk
    End Function
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

    Public Function ValidarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False

        Try
            If Not ValidaFecha(DTFechaDesde) Then flgConError = True
            If Not ValidaFecha(DTFechaHasta) Then flgConError = True
            If Not ValidaDiaEntrada() Then flgConError = True
            If Not ValidaDiaSalida() Then flgConError = True
            If Not ValidaDiasRepetidos() Then flgConError = True
            If Not ValidaHora(mskHoraEntrada, True) Then flgConError = True
            If Not ValidaHora(mskHoraSalida, True) Then flgConError = True
            If Not ValidaHora(mskHoraEntrada1, Not (MskFechaVacia(mskHoraSalida1))) Then flgConError = True
            If Not ValidaHora(mskHoraSalida1, Not (MskFechaVacia(mskHoraEntrada1))) Then flgConError = True
            If Not ValidaHora(mskHoraEntrada2, Not (MskFechaVacia(mskHoraSalida2))) Then flgConError = True
            If Not ValidaHora(mskHoraSalida2, Not (MskFechaVacia(mskHoraEntrada2))) Then flgConError = True
            If Not ValidaHora(mskHorasACumplir) Then flgConError = True

            If flgConError And flgConMensajeBox Then XtraMessageBox.Show("Errores en la validación de los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function

    Private Sub mskHorasACumplir_EditValueChanged(sender As Object, e As EventArgs) Handles mskHorasACumplir.EditValueChanged
        Call ValidaHora(mskHorasACumplir)
    End Sub

#End Region

End Class