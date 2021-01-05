Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions

Public Class frmBusqueda
    Inherits XtraForm
    Private mobjLoger As New Logger
    Private mNroTabla As Integer
    Private mObjSeleccionado As Object

    Public Property NroTabla() As Integer
        Get
            Return mNroTabla
        End Get
        Set(ByVal value As Integer)
            mNroTabla = value
        End Set
    End Property

    Public Property ObjSeleccionado() As Object
        Get
            Return mObjSeleccionado
        End Get
        Set(ByVal value As Object)
            mObjSeleccionado = value
        End Set
    End Property

    Private Sub frmBusqueda_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Inicializar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
        If (e.Column.ColumnType = GetType(System.DateTime)) Then
            Dim edit As New RepositoryItemDateEdit()
            edit.NullDate = DateTime.MinValue
            edit.NullText = String.Empty
            e.RepositoryItem = edit
        End If
    End Sub

    Private Sub bbiSeleccionar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeleccionar.ItemClick
        Seleccionar()
    End Sub

    Private Sub Seleccionar()
        mObjSeleccionado = GridView1.GetFocusedRow
        If Not mObjSeleccionado Is Nothing Then Me.Hide()
    End Sub

    Private Sub bbiSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalir.ItemClick
        Me.Hide()
    End Sub

    Private Sub frmBusqueda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdDatos.Width = Me.Width - 16
        grdDatos.Height = Me.Height - 155
    End Sub

    Private Sub Inicializar()
        Select Case mNroTabla
            Case 1 : Empleado_Inicializar()
            Case 2 : Usuario_Inicializar()
            Case Else : XtraMessageBox.Show("No se pudo inicializar la tabla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

    'EMPLEADO
    Private Sub Empleado_Inicializar()
        Try
            Me.Text = "Empleados"

            GridView1.Columns.Clear()
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("NOMBRE", "Nombre"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("NRODOCUMENTO", "dni"))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("SECTOR", "Sector"))

            Dim obj As New EmpleadoComponent(Session.CadenaConexion)
            grdDatos.DataSource = obj.GetAllActivos()

            GridView1.OptionsBehavior.Editable = False

            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    'USUARIO
    Private Sub Usuario_Inicializar()
        Try
            Me.Text = "Usuarios"

            GridView1.Columns.Clear()
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("ID", "id",,, False))
            GridView1.Columns.Add(AppSharedFunctions.NewColumn("NOMBRE", "Nombre"))

            Dim obj As New UsuarioComponent(Session.CadenaConexion)
            Dim ent As New Usuario
            ent.BeginUpdate()
            ent.SUPERVISOR = True
            ent.ACTIVO = True
            grdDatos.DataSource = obj.GetListByEnt(ent)

            GridView1.OptionsBehavior.Editable = False

            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Excel", "xlsx", grdDatos)
    End Sub

    Private Sub bbiExportarPdf_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPdf.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Pdf", "pdf", grdDatos)
    End Sub

    Private Sub bbiExportarCsv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarCsv.ItemClick
        Call AppSharedFunctions.ExportarGrilla("Archivo Csv", "csv", grdDatos)
    End Sub
End Class