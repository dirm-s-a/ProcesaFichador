Imports Turnos.Business
Imports Turnos.Entities
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports NetApp.AbmSharedFunctions
Imports DevExpress.XtraGrid.Controls
Imports ProcesaFichador.AppSharedFunctions
Imports Employees.Business
Imports Employees.Entities

Public Class xtraFinder
    Inherits XtraForm
    Private mobj As Object
    Private mflgSeleccionado As Boolean = False

    Public ReadOnly Property ObjetoSeleccionado As Object
        Get
            If mflgSeleccionado Then
                Return mobj
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property Seleccionado As Boolean
        Get
            Return mflgSeleccionado
        End Get
    End Property

#Region "Busquedas"
    Public Sub BuscarGrupoEmpleado(Optional ByVal Filtro As String = "", Optional ByVal Multi As Boolean = False, Optional SoloActivos As Boolean = True)

        Try
            GridView1.Columns.Clear()
            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.Columns.Add(NewColumn("ID", "ID",,, False))
            GridView1.Columns.Add(NewColumn("NOMBRE", "Nombre"))

            Dim objEmpleado As New EmpleadoComponent(Session.CadenaConexion)
            Dim listEmpleados As New List(Of Empleado)

            If Session.Usuario.RRHH OrElse Session.Usuario.DIRECTORRRHH Then
                listEmpleados = objEmpleado.GetALL()
            Else
                listEmpleados = objEmpleado.GetAllActivosVisiblesPorUsuario(Session.Usuario.ID)
            End If


            If SoloActivos Then listEmpleados = listEmpleados.Where(Function(f) f.INACTIVO = False).ToList()

            GridView1.OptionsBehavior.Editable = False
            grdTabla.DataSource = listEmpleados.OrderBy(Function(p) p.NOMBRE).ToList
            GridView1.BestFitColumns()

            GridView1.OptionsFind.FindNullPrompt = "Ingrese filtro de búsqueda de Grupo de Obra Social."
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
#End Region

#Region "Eventos controles"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Call Seleccionaritem()
    End Sub

#End Region

#Region "Funciones y eventos"
    Private Sub Seleccionaritem()
        Try
            If GridView1.FocusedRowHandle < 0 Then
                XtraMessageBox.Show("Debe seleccionar un item de la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                mflgSeleccionado = True
                mobj = GridView1.GetRow(GridView1.FocusedRowHandle)
                Me.Hide()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub xtraFinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class