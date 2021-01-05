
Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Public Class frmAbmFeriado
    Inherits XtraForm

    Private mflgOK As Boolean
    Public Property OKsave() As Boolean
        Get
            Return mflgOK
        End Get
        Set(ByVal value As Boolean)
            mflgOK = value
        End Set
    End Property

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim entAUX As New Feriado
        Dim ent As New Feriado
        Dim list As List(Of Feriado)
        Dim obj As New FeriadoComponent(Session.CadenaConexion)
        Try
            entAUX.BeginUpdate()
            entAUX.FECHA = DTFecha.EditValue

            list = obj.GetListByEnt(entAUX)
            list = list.Where(Function(f) f.FECHAANULACION = Date.MinValue).ToList
            If list.Count > 0 Then
                XtraMessageBox.Show("Ya existe un feriado activo cargado para esa fecha", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ent.BeginUpdate()
                ent.DESCRIPCION = txtDescripcion.Text.ToUpper
                ent.FECHA = DTFecha.EditValue
                ent.ACTIVO = True
                ent.FECHAALTA = Date.Now
                If Not obj.Save(ent) Then
                    mflgOK = True
                    XtraMessageBox.Show("Error al dar de alta feriado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    XtraMessageBox.Show("Feriado guardado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class