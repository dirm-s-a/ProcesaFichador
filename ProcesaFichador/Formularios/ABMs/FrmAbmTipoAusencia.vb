Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Imports Turnos.GlobalFunctions.Data
Public Class FrmAbmTipoAusencia
    Inherits XtraForm

    Private mEntity As TipoAusencia
    Private mflgNew As Boolean = True
    Private mflgOkSave As Boolean = False

#Region "Properties"
    Public Property Entity As TipoAusencia
        Get
            Return mEntity
        End Get
        Set(value As TipoAusencia)
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

            If Not mEntity Is Nothing Then
                Me.Text &= ", Edición del registro"
                Call LoadObjProperties()
                chkActivo.Enabled =  mEntity.ACTIVO
            Else
                chkActivo.Enabled = False
                chkActivo.Checked = True
                Me.Text &= ", Alta del registro"
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        Call ValidaDescripcion()
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Private Sub Guardar()
        Dim objTipoAusencia As New TipoAusenciaComponent(Session.CadenaConexion)
        Dim fLgOK As Boolean = True

        Try
            If Not ValidarDatos() Then Exit Sub
            Call SetObjProperties()

            If Not objTipoAusencia.SaveConTraza(mEntity, , True) Then
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
        chkActivo.Checked = mEntity.ACTIVO
        chkJustificada.Checked = mEntity.JUSTIFICADA
        chkPierdePresentismo.Checked = mEntity.PIERDEPRESENTISMO
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
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Validaciones"

    Private Function ValidaDescripcion() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False
        Dim objTipoAusencia As New TipoAusenciaComponent(Session.CadenaConexion)
        Dim listTipoAusencia As New List(Of TipoAusencia)
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

    Private Function ValidarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False
        Dim objTipoAusencia As New TipoAusenciaComponent(Session.CadenaConexion)

        Try
            If Not ValidaDescripcion() Then flgConError = True

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
            If mEntity Is Nothing Then mEntity = New TipoAusencia
            mEntity.BeginUpdate()

            If mEntity.IsNew Then mEntity.IDUDUARIOALTA = Session.Usuario.ID

            mEntity.PIERDEPRESENTISMO = chkPierdePresentismo.Checked
            mEntity.ACTIVO = chkActivo.Checked
            mEntity.DESCRIPCION = txtDescripcion.Text
            mEntity.JUSTIFICADA = chkJustificada.Checked
            mEntity.IDUSUARIOMODIFICACION = Session.Usuario.ID

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
End Class