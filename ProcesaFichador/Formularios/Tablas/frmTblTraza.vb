
Imports Employees.Business
Imports Employees.Entities
Imports Turnos.GlobalFunctions.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports ProcesaFichador.AppSharedFunctions

'Para impresión de la Grilla
Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel
Imports System.Drawing.Printing
Public Class frmTblTraza
    Inherits frmBase


#Region "Formato Controles"
    Private Sub FormatoGrillas()
        Try
            GridView1.OptionsView.ShowGroupedColumns = True

            GridView1.OptionsView.RowAutoHeight = True 'Necesario para multiline, junto con el Repositorio en la columna
            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.Columns.Add(NewColumn("ID", "Código",,, False))
            GridView1.Columns.Add(NewColumn("IDUSUARIO", "idUsuarioGen",,, False))
            GridView1.Columns.Add(NewColumn("IDUSUARIO_Desc", "Usario Generador"))
            GridView1.Columns.Add(NewColumn("FECHA", "Fecha",,,, True))
            GridView1.Columns.Add(NewColumn("TABLAAUXILIAR", "Tabla Aux."))
            GridView1.Columns.Add(NewColumn("IDAUXILIAR", "Id Aux.",,, False))
            GridView1.Columns.Add(NewColumn("IDEMPLEADO", "Id Empleado",,, False))
            GridView1.Columns.Add(NewColumn("IDEMPLEADO_Desc", "Empleado"))
            GridView1.Columns.Add(NewColumn("OBSERVACIONES", "Observaciones"))

            'Multiline en Observaciones
            Dim repo As New Repository.RepositoryItemMemoEdit
            repo.AutoHeight = True
            GridView1.Columns(8).ColumnEdit = repo

        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Eventos controles"

    Private Sub frmTblRecepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call FormatoGrillas()
            Call cargarGrilla()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub frmTblRecepciones_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            grdTabla.Width = Me.Width - grdTabla.Left - 20
            grdTabla.Top = rctMenu.Height
            grdTabla.Height = Me.Height - grdTabla.Top - 40
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub frmTblRecepciones_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Se utiliza para hacer que la pantalla levante arriba de todo, pero no de forma permanente
        Me.TopMost = True
        Me.TopMost = False
    End Sub
    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        Call Exportar("Archivo Excel", "xlsx")
    End Sub

    Private Sub bbiExportarPdf_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPdf.ItemClick
        Call Exportar("Archivo Pdf", "pdf")
    End Sub

    Private Sub bbiExportarCsv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarCsv.ItemClick
        Call Exportar("Archivo Csv", "csv")
    End Sub

    Private Sub bbiPrintPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrintPreview.ItemClick
        Call PreviewPrintableComponent(grdTabla, grdTabla.LookAndFeel)
    End Sub

    Private Sub bbiExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExit.ItemClick
        Me.Hide()
    End Sub

#End Region

#Region "Procedimientos y Eventos"
    Private Sub Exportar(ByVal Tipo As String, ByVal Extension As String)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Tipo & "|*." & Extension.ToLower
        saveFileDialog1.Title = "Nombre de archivo a exportar"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> String.Empty Then
            Select Case Extension.ToLower
                Case "csv" : GridView1.ExportToCsv(saveFileDialog1.FileName)
                Case "xlsx" : GridView1.ExportToXlsx(saveFileDialog1.FileName)
                Case "pdf" : GridView1.ExportToPdf(saveFileDialog1.FileName)
                Case "html" : GridView1.ExportToHtml(saveFileDialog1.FileName)
            End Select
        End If
    End Sub

    Private Sub PreviewPrintableComponent(component As IPrintable, lookAndFeel As UserLookAndFeel)
        ' Create a link that will print a control.  
        Dim link As New PrintableComponentLink() With {
            .PrintingSystemBase = New PrintingSystem(),
            .Component = component,
            .Landscape = True,
            .PaperKind = PaperKind.Letter,
            .Margins = New Margins(20, 20, 80, 40)}

        'Otra opción para agregar header en la sección de Texto
        'AddHandler link.CreateReportHeaderArea, AddressOf link_CreateReportHeaderArea

        link.Images.Add(Global.ProcesaFichador.My.Resources.Resources.logo_min)

        Dim phf As PageHeaderFooter = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()
        phf.Header.Content.AddRange(New String() {"", "Listado de Traza Cambios", "[Image 0]"})
        phf.Header.Font = New Font("Arial", 16, FontStyle.Underline)
        phf.Header.LineAlignment = BrickAlignment.Center

        phf = TryCast(link.PageHeaderFooter, PageHeaderFooter)
        ' Clear the PageHeaderFooter's contents.
        phf.Footer.Content.AddRange(New String() {"Impreso: [Date Printed] [Time Printed]", "", "Página [Page #]/[Páginas #]"})
        phf.Footer.Font = New Font("Arial", 8, FontStyle.Regular)
        phf.Footer.LineAlignment = BrickAlignment.Center

        link.ShowRibbonPreview(lookAndFeel)
    End Sub
    Private Sub cargarGrilla()
        Dim obj As New TrazaCambioComponent(Session.CadenaConexion)
        Dim List As List(Of TrazaCambio)

        Try
            List = obj.GetALL()

            grdTabla.DataSource = List
            GridView1.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

End Class