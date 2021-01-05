
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
Public Class frmTblConvenios
    Inherits frmBase


#Region "Formato Controles"
    Private Sub FormatoGrillas()
        Try
            GridView1.OptionsView.ShowGroupedColumns = True

            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.Columns.Add(NewColumn("ID", "Código",,, False))
            GridView1.Columns.Add(NewColumn("DESCRIPCION", "Descripción"))
            GridView1.Columns.Add(NewColumn("AUSENTISMO", "Maneja ausentismo"))
            GridView1.Columns.Add(NewColumn("HORARIOFLEXIBLE", "Horario flexible"))
            GridView1.Columns.Add(NewColumn("MINUTOSGRACIA", "Minutos gracia"))
            GridView1.Columns.Add(NewColumn("MINUTOSTOPE", "Minutos tope"))
            GridView1.Columns.Add(NewColumn("SINCONTROLES", "Sin controles"))
            GridView1.Columns.Add(NewColumn("ACTIVO", "Activo"))
            GridView1.Columns.Add(NewColumn("FECHAMODIFICACION", "F.U. Modif",,, False))
            GridView1.Columns.Add(NewColumn("IDUSUARIOMODIFICACION", "Id Usu. Modif",,, False))

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
    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        Call EditarItem(GridView1.FocusedRowHandle)
    End Sub
    Private Sub bbiEliminarRegistro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarRegistro.ItemClick
        Call EliminarItem(GridView1.FocusedRowHandle)
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

    Private Sub bbiNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNew.ItemClick
        Call NuevoRegistro()
    End Sub

    Private Sub bbiExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExit.ItemClick
        Me.Hide()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        Dim menuItem As DXMenuItem
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim subMenu As New DXSubMenuItem("Principal")
            e.Menu.Items.Add(subMenu)
            'Nuevo
            menuItem = New DXMenuItem("Nuevo Registro", AddressOf OnDeleteRowClick, Global.ProcesaFichador.My.Resources.Resources.add_16x16)
            menuItem.Tag = New RowInfo(view, rowHandle)
            subMenu.Items.Add(menuItem)
            'Editar
            menuItem = New DXMenuItem("Editar Registro", AddressOf OnDeleteRowClick, Global.ProcesaFichador.My.Resources.Resources.edit_16x16)
            menuItem.Tag = New RowInfo(view, rowHandle)
            subMenu.Items.Add(menuItem)
        End If
    End Sub
    Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        Select Case item.Caption
            Case "Editar Registro" : Call EditarItem(info.RowHandle)
            Case "Nuevo Registro" : Call NuevoRegistro()
            Case "Eliminar Registro" : Call EliminarItem(info.RowHandle)
        End Select
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

    Private Sub EliminarItem(ByVal iRow As Integer)
        'Dim entity As Cepem.Entities.MapeoPlan
        'Try
        '    entity = CType(GridView1.GetRow(iRow), Cepem.Entities.MapeoPlan)
        '    If Not entity Is Nothing Then
        '        If XtraMessageBox.Show("Desea eliminar el mapeo de la tabla ?" & vbCrLf & "Consultorio: " & entity.ID, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '            Dim obj As New Cepem.Business.MapeoPlanComponent(Session.CadenaConexion)
        '            If obj.Delete(entity.ID) Then
        '                Call cargarGrilla()
        '            Else
        '                XtraMessageBox.Show("Error al eliminar el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Try
    End Sub
    Private Sub EditarItem(ByVal iRow As Integer)
        Dim entity As Convenio
        Try
            entity = CType(GridView1.GetRow(iRow), Convenio)
            If Not entity Is Nothing Then
                Dim frm As New frmAbmConvenio
                frm.Entity = entity
                frm.ShowDialog()
                If frm.OkSave Then Call cargarGrilla()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub NuevoRegistro()
        Try
            Dim frm As New frmAbmConvenio
            frm.ShowDialog()
            If frm.OkSave Then Call cargarGrilla()
        Catch ex As Exception
            XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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
        phf.Header.Content.AddRange(New String() {"", "Listado de Convenios", "[Image 0]"})
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
        Dim obj As New ConvenioComponent(Session.CadenaConexion)
        Dim List As List(Of Convenio)

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