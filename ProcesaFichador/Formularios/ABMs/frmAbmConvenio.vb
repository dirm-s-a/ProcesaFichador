Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Imports Turnos.GlobalFunctions.Data
Public Class frmAbmConvenio
    Inherits XtraForm

    Private mEntity As Convenio
    Private mflgNew As Boolean = True
    Private mflgOkSave As Boolean = False

#Region "Properties"
    Public Property Entity As Convenio
        Get
            Return mEntity
        End Get
        Set(value As Convenio)
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
    Private Sub frmAbm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DefineErrProviders()

            txtDescripcion.Properties.MaxLength = 100

            txtMinutosGracia.Properties.MaxLength = 2
            txtMinutosGracia.Properties.Mask.EditMask = "\d+"
            txtMinutosGracia.Properties.Mask.MaskType = Mask.MaskType.RegEx

            txtMinutosTope.Properties.MaxLength = 2
            txtMinutosTope.Properties.Mask.EditMask = "\d+"
            txtMinutosTope.Properties.Mask.MaskType = Mask.MaskType.RegEx

            If Not mEntity Is Nothing Then
                Me.Text = "Edición del registro"
                Call LoadObjProperties()
            Else
                Me.Text = "Alta del registro"
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        Call ValidaDescripcion()
    End Sub
    Private Sub txtMinutosGracia_EditValueChanged(sender As Object, e As EventArgs) Handles txtMinutosGracia.EditValueChanged
        Call ValidaMinutosGracia()
    End Sub
    Private Sub txtMinutosTope_EditValueChanged(sender As Object, e As EventArgs) Handles txtMinutosTope.EditValueChanged
        Call ValidaMinutosTope()
    End Sub
    Private Sub chkAusentismo_CheckedChanged(sender As Object, e As EventArgs) Handles chkAusentismo.CheckedChanged
        Call ValidaTipoConvenio()
    End Sub

    Private Sub chkHorarioFlexible_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorarioFlexible.CheckedChanged
        Call ValidaTipoConvenio()
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Private Sub Guardar()
        Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)
        Dim fLgOK As Boolean = True

        Try
            If Not ValidarDatos() Then Exit Sub
            Call SetObjProperties()

            If Not objConvenio.SaveConTraza(mEntity, , True) Then
                XtraMessageBox.Show("Error al guardar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mflgOkSave = True
                Me.Hide()
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub LoadObjProperties()
        mflgNew = False
        txtDescripcion.Text = mEntity.DESCRIPCION
        chkControlDescanso.Checked = mEntity.CONTROLDESCANSO
        chkActivo.Checked = mEntity.ACTIVO
        chkAusentismo.Checked = mEntity.AUSENTISMO
        chkHorarioFlexible.Checked = mEntity.HORARIOFLEXIBLE
        chkSinControl.Checked = mEntity.SINCONTROLES
        txtMinutosGracia.Text = mEntity.MINUTOSGRACIA
        txtMinutosTope.Text = mEntity.MINUTOSTOPE
        mskHorasACumplirLUNVIE.Text = AppSharedFunctions.MinutosAHoraFormateada(Entity.MINUTOSLUNVIER)
        mskHorasACumplirSABADO.Text = AppSharedFunctions.MinutosAHoraFormateada(Entity.MINUTOSSABADO)
        mskHorasACumplirDOMINGO.Text = AppSharedFunctions.MinutosAHoraFormateada(Entity.MINUTOSDOMINGO)

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

            ErrProvider.SetError(txtDescripcion, "Debe indicar una descripción.")
            ErrProvider.SetError(chkAusentismo, "Debe indicar una opción de ausentismo u horario flexible.")
            ErrProvider.SetError(chkHorarioFlexible, "Debe indicar una opción de ausentismo u horario flexible.")
            'ErrProvider.SetError(txtMinutosGracia, "Debe indicar una opción de ausentismo u horario flexible.")
            'ErrProvider.SetError(txtMinutosTope, "Debe indicar una opción de ausentismo u horario flexible.")

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Validaciones"

    Private Function ValidaMinutosGracia() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Try
            If F_IsNullValue(txtMinutosGracia.Text) Then
                ErrProvider.SetError(txtMinutosGracia, "Debe los minutos de gracia que pudiera tener el empleado.")
            Else
                OkProvider.SetError(txtMinutosGracia, "Ok")
                flgOk = True
                '    End If
            End If

        Catch ex As Exception
            ErrProvider.SetError(txtMinutosGracia, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtMinutosGracia)
        Return flgOk
    End Function
    Private Function ValidaMinutosTope() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Try
            If F_IsNullValue(txtMinutosTope.Text) Then
                ErrProvider.SetError(txtMinutosTope, "Debe los minutos Tope que pudiera tener el empleado.")
            Else
                OkProvider.SetError(txtMinutosTope, "Ok")
                flgOk = True
                '    End If
            End If

        Catch ex As Exception
            ErrProvider.SetError(txtMinutosTope, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtMinutosTope)
        Return flgOk
    End Function
    Private Function ValidaDescripcion() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Try
            If F_IsNullValue(txtDescripcion.Text) Then
                ErrProvider.SetError(txtDescripcion, "Debe indicar una descripción.")
            Else
                OkProvider.SetError(txtDescripcion, "Ok")
                flgOk = True
                '    End If
            End If

        Catch ex As Exception
            ErrProvider.SetError(txtDescripcion, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtDescripcion)
        Return flgOk
    End Function

    Private Function ValidaTipoConvenio() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)
        Dim listConvenio As New List(Of Convenio)
        Try
            If Not chkAusentismo.Checked AndAlso Not chkHorarioFlexible.Checked Then
                ErrProvider.SetError(chkAusentismo, "Debe indicar una opción de ausentismo u horario flexible.")
                ErrProvider.SetError(chkHorarioFlexible, "Debe indicar una opción de ausentismo u horario flexible.")
            ElseIf chkAusentismo.Checked AndAlso chkHorarioFlexible.Checked Then
                ErrProvider.SetError(chkAusentismo, "No puede seleccionar ambas opciones.")
                ErrProvider.SetError(chkHorarioFlexible, "No puede seleccionar ambas opciones.")
            Else
                OkProvider.SetError(chkAusentismo, "Ok")
                OkProvider.SetError(chkHorarioFlexible, "Ok")
                flgOk = True
            End If

        Catch ex As Exception
            ErrProvider.SetError(chkAusentismo, "Error no controlado: " & ex.Message)
            ErrProvider.SetError(chkHorarioFlexible, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, chkAusentismo)
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, chkHorarioFlexible)
        Return flgOk
    End Function

    Private Function ValidarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False
        Dim objConvenio As New ConvenioComponent(Session.CadenaConexion)

        Try
            If Not ValidaDescripcion() Then flgConError = True
            If Not ValidaTipoConvenio() Then flgConError = True
            If Not ValidaMinutosGracia() Then flgConError = True
            If Not ValidaMinutosTope() Then flgConError = True


            If Not mEntity Is Nothing AndAlso Not mEntity.ACTIVO Then
                XtraMessageBox.Show("El registro ha sido dado de baja. No se puede editar !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                flgConError = True
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
            If mEntity Is Nothing Then mEntity = New Convenio
            mEntity.BeginUpdate()

            If mEntity.IsNew Then mEntity.IDUDUARIOALTA = Session.Usuario.ID

            mEntity.IDUSUARIOMODIFICACION = Session.Usuario.ID
            mEntity.ACTIVO = chkActivo.Checked
            mEntity.CONTROLDESCANSO = chkControlDescanso.Checked
            mEntity.AUSENTISMO = chkAusentismo.Checked
            mEntity.DESCRIPCION = txtDescripcion.Text
            mEntity.HORARIOFLEXIBLE = chkHorarioFlexible.Checked
            mEntity.MINUTOSGRACIA = CInt(txtMinutosGracia.Text)
            mEntity.MINUTOSTOPE = CInt(txtMinutosTope.Text)
            mEntity.SINCONTROLES = chkSinControl.Checked
            mEntity.MINUTOSLUNVIER = AppSharedFunctions.HoraFormateadaAMinutos(mskHorasACumplirLUNVIE.Text)
            mEntity.MINUTOSSABADO = AppSharedFunctions.HoraFormateadaAMinutos(mskHorasACumplirSABADO.Text)
            mEntity.MINUTOSDOMINGO = AppSharedFunctions.HoraFormateadaAMinutos(mskHorasACumplirDOMINGO.Text)
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region
End Class