
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Public Class frmAbmGrupo
    Inherits XtraForm

    Private mentity As Grupo
    Private mflgOK As Boolean

    Public Property entity() As Grupo
        Get
            Return mentity
        End Get
        Set(ByVal value As Grupo)
            mentity = value
        End Set
    End Property
    Public Property OKsave() As Boolean
        Get
            Return mflgOK
        End Get
        Set(ByVal value As Boolean)
            mflgOK = value
        End Set
    End Property

    Private Sub frmAbmGrupo_Load(sender As Object, e As EventArgs) Handles Me.Load
        DefineErrProviders()

        If Not mentity Is Nothing Then
            If Not mentity.IsNew Then
                txtDescripcion.Text = mentity.DESCRIPCION
            End If
        End If
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

            ErrProvider.SetError(txtDescripcion, "Debe ingresar una descripción")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objGrupo As New GrupoComponent(Session.CadenaConexion)
            If Not SetObjProperties() Then Exit Sub

            If objGrupo.Save(mentity) Then
                XtraMessageBox.Show("Grupo guardado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mflgOK = True
                Me.Hide()
            Else
                XtraMessageBox.Show("Error al guardar el grupo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ValidatxtDescripcion
    End Sub

    Public Function validarDatos(Optional ByVal flgConMensajeBox As Boolean = True) As Boolean
        Dim flgConError As Boolean = False

        Try
            If Not ValidatxtDescripcion() Then flgConError = True

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            flgConError = True
        End Try

        Return Not flgConError
    End Function

    Private Function ValidatxtDescripcion() As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If Trim(txtDescripcion.Text) = "" Then
                ErrProvider.SetError(txtDescripcion, "Debe ingresar una descripción")
            Else
                OkProvider.SetError(txtDescripcion, "ok")
                flgOk = True
            End If
        Catch ex As Exception
            ErrProvider.SetError(txtDescripcion, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, txtDescripcion)
        Return flgOk
    End Function

    Private Function SetObjProperties() As Boolean
        Try
            If Not validarDatos() Then Return False

            If mEntity Is Nothing Then mEntity = New Grupo
            mEntity.BeginUpdate()
            mentity.DESCRIPCION = Trim(txtDescripcion.Text.ToUpper)
            If mentity.IsNew Then mentity.IDUSUARIOALTA = Session.Usuario.ID

            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return False
    End Function
End Class