Imports DevExpress.XtraEditors
Class xtraInputBox
    Inherits XtraForm
    Private mtxtInput As String

    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs)
        Dim txt As TextEdit = DirectCast(sender, TextEdit)

        If e.KeyCode = Keys.Enter Then
            mtxtInput = txt.Text
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        mtxtInput = txtInput.Text
        Me.Dispose()
    End Sub

    Public Shared Function Show(ByVal Prompt As String, ByVal Title As String, Optional ByVal MaxLenght As Integer = 0) As String
        Dim dialog As New xtraInputBox()
        dialog.lblPrompt.Text = Prompt
        dialog.Text = Title
        dialog.txtInput.Properties.MaxLength = MaxLenght
        dialog.ShowDialog()

        Return dialog.mtxtInput
    End Function

End Class
