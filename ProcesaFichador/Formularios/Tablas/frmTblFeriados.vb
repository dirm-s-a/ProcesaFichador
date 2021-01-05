Imports Employees.Business
Imports Employees.Entities
Imports DevExpress.XtraEditors
Public Class frmTblFeriados
    Inherits frmBase

#Region "Eventos controles"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New frmAbmFeriado
        frm.ShowDialog()
        If frm.OKsave Then Call cargarGrilla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ent As Feriado = CType(GridView1.GetFocusedRow(), Feriado)
        Try
            If XtraMessageBox.Show("Desea dar de baja el feriado seleccionado?" & vbCrLf, ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ent.BeginUpdate()
                ent.ACTIVO = False
                ent.FECHAANULACION = Date.Now

                Dim obj As New FeriadoComponent(Session.CadenaConexion)
                If obj.Save(ent) Then
                    XtraMessageBox.Show("El feriado fué dado de baja", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    XtraMessageBox.Show("Error al guardar el feriado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado:    " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmTblFeriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call formatoGrilla()
        Call cargarGrilla()
    End Sub
#End Region

#Region "Funciones y procedimientos"
    Private Sub cargarGrilla()
        Dim obj As New FeriadoComponent(Session.CadenaConexion)
        Dim list As New List(Of Feriado)
        Dim ent As New Employees.Entities.Feriado

        Try
            ent.BeginUpdate()
            ent.ACTIVO = True


            list = obj.GetListByEnt(ent).OrderBy(Function(f) f.FECHA).ToList

            grdFeriados.DataSource = list
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
#End Region

#Region "Formato grilla"
    Private Sub formatoGrilla()
        Try
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("FECHA", "Fecha"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("DESCRIPCION", "Descripción"))

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region


End Class