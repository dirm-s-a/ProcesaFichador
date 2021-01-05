Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Public Class AppSharedFunctions
    Public Shared Sub ViewChildForm(frm As frmBase,
                                    frmParent As XtraForm,
                                    Optional ByVal PermiteNRepetidos As Integer = 0)

        'Creado el 11/08/2018 por Diego de la Fuente
        If frmParent.MdiChildren.Where(Function(f) f.Name = frm.Name).Count > PermiteNRepetidos Then
            Dim Page As Integer = frmParent.MdiChildren.Where(Function(f) f.Name = frm.Name).ToList(0).TabIndex
            For Each frmRep As frmBase In frmParent.MdiChildren
                If frmRep.Name = frm.Name Then
                    If Not frmRep.CancelClose Then 'Si estamos en un proceso crítico marcamos 'Cancelado' el cierre del formulario
                        frmRep.Close()
                        Exit For
                    Else
                        frmRep.Activate()
                        Exit Sub
                    End If
                End If
            Next
        End If


        frm.MdiParent = frmParent
        frm.Show()
    End Sub

    Public Shared Function MinutosAHoraFormateada(ByVal Minutos As Integer) As String
        Dim StrHora As String = ""
        Try
            Dim HorasACumplir As Integer = Math.Abs(Minutos / 60)
            Dim MinutosACumplir As Integer = Minutos - Math.Abs(HorasACumplir * 60)
            StrHora = Strings.Right("00" & HorasACumplir, 2) & ":" & Strings.Right("00" & MinutosACumplir, 2)

        Catch ex As Exception

        End Try
        Return StrHora
    End Function
    Public Shared Function HoraFormateadaAMinutos(ByVal HoraFormateada As String) As Integer
        Try
            If HoraFormateada.Length = 5 Then
                Return CInt(Strings.Left(HoraFormateada, 2) * 60) + CInt(Strings.Right(HoraFormateada, 2))
            End If
        Catch ex As Exception

        End Try
        Return -1
    End Function
    Public Shared Sub LimpiarEstados(ByVal ErrProvider As ErrorProvider,
                               ByVal OkProvider As ErrorProvider,
                               ByVal WarnProvider As ErrorProvider,
                               ByVal flgWarning As Boolean,
                               ByVal flgOk As Boolean,
                               ByVal ElControl As Control)
        Try
            If flgWarning Then
                ErrProvider.SetError(ElControl, "")
                OkProvider.SetError(ElControl, "")
            ElseIf flgOk = False Then
                WarnProvider.SetError(ElControl, "")
                OkProvider.SetError(ElControl, "")
            Else
                WarnProvider.SetError(ElControl, "")
                ErrProvider.SetError(ElControl, "")
                OkProvider.SetError(ElControl, "Ok")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function HoraNormalAMilitar(ByRef hora As String) As Long
        Dim horaM As String
        Dim minutosM As String
        Dim horatotalMilitar As Long

        horaM = hora.Substring(0, 2)
        minutosM = hora.Substring(3, 2)

        horatotalMilitar = (CLng(horaM) * 100) + CLng(minutosM)

        Return horatotalMilitar
    End Function

    Public Shared Function diaStringANumero(ByVal dia As String) As Long
        Dim diaNum As Integer
        Select Case dia
            Case "LUNES" : diaNum = 1
            Case "MARTES" : diaNum = 2
            Case "MIÉRCOLES" : diaNum = 3
            Case "JUEVES" : diaNum = 4
            Case "VIERNES" : diaNum = 5
            Case "SÁBADO" : diaNum = 6
            Case "DOMINGO" : diaNum = 7
        End Select
        Return diaNum
    End Function

    Public Shared Function DiaNumeroAString(ByVal dia As Long) As String
        Dim diaNum As String = ""
        Select Case dia
            Case 1 : diaNum = "LUNES"
            Case 2 : diaNum = "MARTES"
            Case 3 : diaNum = "MIÉRCOLES"
            Case 4 : diaNum = "JUEVES"
            Case 5 : diaNum = "VIERNES"
            Case 6 : diaNum = "SABADO"
            Case 7 : diaNum = "DOMINGO"
        End Select

        Return diaNum
    End Function

    Public Shared Function horaMilitarAnormal(ByVal hora As Long) As String
        Dim h As String
        Dim m As String
        Dim horaInicio As String = hora
        Dim horaFinStr As String

        If hora.ToString.Length <= 3 Then
            horaInicio = hora.ToString.PadLeft(4, "0")
        End If

        If hora.ToString.Length > 4 Then
            h = horaInicio.ToString.Substring(0, hora.ToString.Length - 2)
            m = horaInicio.ToString.Substring(hora.ToString.Length - 2, 2)
        Else
            h = horaInicio.ToString.Substring(0, 2)
            m = horaInicio.ToString.Substring(2, 2)
        End If

        horaFinStr = h & ":" & m

        Return horaFinStr
    End Function

    Public Shared Function restarHoraMilitar(ByVal horaHasta As Long, ByVal horaDesde As Long) As Long
        Dim hH As String = Convert.ToString(horaHasta)
        Dim hD As String = Convert.ToString(horaDesde)
        Dim minHasta As String
        Dim minDesde As String
        'Dim horaFinal As Long
        Dim minutosFinal As Long
        Dim horaTotalFinal As String

        If hH.Length > 1 Then
            minHasta = hH.Substring(hH.Length - 2, 2)
        Else
            minHasta = "00"
        End If

        If hD.Length > 1 Then
            minDesde = hD.Substring(hD.Length - 2, 2)
        Else
            minDesde = hD
        End If

        If hH.Length > 3 Then
            hH = hH.Substring(0, 2)
        Else
            If hH.Length > 2 Then
                hH = hH.Substring(0, 1)
            Else
                hH = "00"
            End If
        End If

        If hD.Length > 3 Then
            hD = hD.Substring(0, 2)
        Else
            If hD.Length > 2 Then
                hD = hD.Substring(0, 1)
            Else
                hD = "00"
            End If
        End If

        'horaFinal = CLng(hH) - CLng(hD)
        'minutosFinal = CLng(minHasta) - CLng(minDesde)

        Dim hInicial As New TimeSpan(CLng(hD), CLng(minDesde), 0)
        Dim hFinal As New TimeSpan(CLng(hH), CLng(minHasta), 0)
        Dim dif As TimeSpan = hFinal.Subtract(hInicial)

        horaTotalFinal = dif.Hours.ToString
        minutosFinal = dif.Minutes.ToString
        'If minutosFinal < 0 Then
        '    minutosFinal += 60
        '    If horaFinal < 0 Then horaFinal = horaFinal * -1
        '    horaFinal -= 1
        'End If

        If minutosFinal.ToString.Length = 1 Then
            horaTotalFinal = Math.Abs(CLng(horaTotalFinal)) & "0" & Math.Abs(CLng(minutosFinal))
        Else
            horaTotalFinal = Math.Abs(CLng(horaTotalFinal)) & Math.Abs(CLng(minutosFinal))
        End If

        Return CLng(horaTotalFinal)

    End Function

    Public Shared Function sumarHoraMilitar(ByVal horaHasta As Long, ByVal horaDesde As Long) As Long
        Dim hH As String = Convert.ToString(horaHasta)
        Dim hD As String = Convert.ToString(horaDesde)
        Dim minHasta As String
        Dim minDesde As String
        'Dim horaFinal As Long
        Dim minutosFinal As Long
        Dim horaTotalFinal As String
        Dim diasTotal As Long

        If hH.Length > 1 Then
            minHasta = hH.Substring(hH.Length - 2, 2)
        Else
            minHasta = "00"
        End If

        If hD.Length > 1 Then
            minDesde = hD.Substring(hD.Length - 2, 2)
        Else
            minDesde = hD
        End If

        If hH.Length > 3 Then
            hH = hH.Substring(0, hH.Length - 2)
        Else
            If hH.Length > 2 Then
                hH = hH.Substring(0, 1)
            Else
                hH = "00"
            End If
        End If

        If hD.Length > 3 Then
            hD = hD.Substring(0, 2)
        Else
            If hD.Length > 2 Then
                hD = hD.Substring(0, 1)
            Else
                hD = "00"
            End If
        End If

        'horaFinal = CLng(hH) - CLng(hD)
        'minutosFinal = CLng(minHasta) - CLng(minDesde)

        Dim hInicial As New TimeSpan(CLng(hD), CLng(minDesde), 0)
        Dim hFinal As New TimeSpan(CLng(hH), CLng(minHasta), 0)
        Dim dif As TimeSpan = hFinal.Add(hInicial)

        horaTotalFinal = dif.Hours.ToString
        minutosFinal = dif.Minutes.ToString
        diasTotal = dif.Days * 24
        'If minutosFinal < 0 Then
        '    minutosFinal += 60
        '    If horaFinal < 0 Then horaFinal = horaFinal * -1
        '    horaFinal -= 1
        'End If

        If minutosFinal.ToString.Length = 1 Then
            horaTotalFinal = Math.Abs(CLng(horaTotalFinal + diasTotal)) & "0" & Math.Abs(CLng(minutosFinal))
        Else
            horaTotalFinal = Math.Abs(CLng(horaTotalFinal + diasTotal)) & Math.Abs(CLng(minutosFinal))
        End If

        Return CLng(horaTotalFinal)

    End Function

    Public Shared Function NewColumn(ByVal FieldName As String,
                               ByVal Caption As String,
                               Optional ByVal Name As String = "",
                               Optional ByVal AllowEdit As Boolean = False,
                               Optional ByVal Visible As Boolean = True,
                               Optional ByVal TimeStamp As Boolean = False) As DevExpress.XtraGrid.Columns.GridColumn

        Try
            Dim grdColum As DevExpress.XtraGrid.Columns.GridColumn

            grdColum = New DevExpress.XtraGrid.Columns.GridColumn()
            If FieldName <> "" Then grdColum.FieldName = FieldName
            If Name <> "" Then grdColum.Name = Name
            If Caption <> "" Then grdColum.Caption = Caption
            grdColum.OptionsColumn.AllowEdit = AllowEdit
            grdColum.Visible = Visible
            If TimeStamp Then
                grdColum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                grdColum.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
            End If

            Return grdColum
        Catch ex As Exception
            'XtraMessageBox.Show("Error no controlado: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return Nothing
    End Function

    Public Shared Sub ExportarGrilla(ByVal Tipo As String, ByVal Extension As String, ByRef Grilla As DevExpress.XtraGrid.GridControl)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Tipo & "|*." & Extension.ToLower
        saveFileDialog1.Title = "Nombre del archivo a exportar"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> String.Empty Then
            Select Case Extension.ToLower
                Case "csv" : Grilla.ExportToCsv(saveFileDialog1.FileName)
                Case "xlsx" : Grilla.ExportToXlsx(saveFileDialog1.FileName)
                Case "pdf" : Grilla.ExportToPdf(saveFileDialog1.FileName)
                Case "html" : Grilla.ExportToHtml(saveFileDialog1.FileName)
            End Select
        End If
    End Sub
End Class

Public Class RowInfo
    Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
        Me.RowHandle = rowHandle
        Me.View = view
    End Sub 'New
    Public View As GridView
    Public RowHandle As Integer
End Class
