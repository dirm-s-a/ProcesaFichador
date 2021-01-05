Imports DevExpress.XtraEditors
Imports Turnos.GlobalFunctions.Data
Public Class xtraFechaDesdeHasta
    Inherits XtraForm

    Private mentGenericFechaDesdeHastaDTO As New GenericFechaDesdeHastaDTO

    Private Sub DefineErrProviders()
        Try
            Dim iErrPad As Integer = 3
            ErrProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            OkProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            WarnProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
            For Each oControl As Control In Me.Controls
                If oControl.Name.StartsWith("txt") Or oControl.Name.StartsWith("cbo") Or oControl.Name.StartsWith("chk") Or oControl.Name.StartsWith("dte") Or oControl.Name.StartsWith("msk") Then
                    ErrProvider.SetIconPadding(oControl, iErrPad)
                    OkProvider.SetIconPadding(oControl, iErrPad)
                    WarnProvider.SetIconPadding(oControl, iErrPad)
                End If
            Next

            ErrProvider.SetError(dteFechaDesde, "Debe seleccionar una fecha")
            ErrProvider.SetError(dteFechaHasta, "Debe seleccionar una fecha")
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Shared Function Show(ByVal Title As String) As GenericFechaDesdeHastaDTO
        Dim dialog As New xtraFechaDesdeHasta()
        dialog.Text = Title
        dialog.ShowDialog()

        Return dialog.mentGenericFechaDesdeHastaDTO
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        mentGenericFechaDesdeHastaDTO = New GenericFechaDesdeHastaDTO
        Me.Dispose()
    End Sub

    Private Sub dteFechaDesde_EditValueChanged(sender As Object, e As EventArgs) Handles dteFechaDesde.EditValueChanged
        Call ValidadteFechas()
    End Sub

    Private Function ValidadteFechas(Optional DobleControl As Boolean = True) As Boolean
        Dim flgWarning As Boolean = False
        Dim flgOk As Boolean = False

        Try
            If String.IsNullOrEmpty(dteFechaDesde.Text) Then
                ErrProvider.SetError(dteFechaDesde, "Debe seleccionar una fecha")
            ElseIf String.IsNullOrEmpty(dteFechaDesde.Text) Then
                ErrProvider.SetError(dteFechaHasta, "Debe seleccionar una fecha")
            Else
                mentGenericFechaDesdeHastaDTO.FechaDesde = dteFechaDesde.EditValue
                mentGenericFechaDesdeHastaDTO.FechaHasta = dteFechaHasta.EditValue

                If mentGenericFechaDesdeHastaDTO.FechaHasta < mentGenericFechaDesdeHastaDTO.FechaDesde Then
                    ErrProvider.SetError(dteFechaDesde, "La fecha Hasta no puede ser menor que la fecha Desde")
                    ErrProvider.SetError(dteFechaHasta, "La fecha Hasta no puede ser menor que la fecha Desde")
                Else
                    flgOk = True
                End If
            End If
            mentGenericFechaDesdeHastaDTO.Valido = flgOk
            btnAceptar.Enabled = flgOk
        Catch ex As Exception
            ErrProvider.SetError(dteFechaDesde, "Error no controlado: " & ex.Message)
            flgWarning = False
            flgOk = False
        End Try
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, dteFechaDesde)
        Call AppSharedFunctions.LimpiarEstados(ErrProvider, OkProvider, WarnProvider, flgWarning, flgOk, dteFechaHasta)
        Return flgOk

    End Function

    Private Sub dteFechaHasta_EditValueChanged(sender As Object, e As EventArgs) Handles dteFechaHasta.EditValueChanged
        Call ValidadteFechas()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidadteFechas() Then
            Me.Dispose()
        Else
            XtraMessageBox.Show("Error en la validación de las fechas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub xtraFechaDesdeHasta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call DefineErrProviders()
    End Sub
End Class