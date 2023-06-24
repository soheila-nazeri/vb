
Public Class Report

    Public Enum enmParameterPlace
        ReportHeader
        PageHeader
        ReportFooter
        PageFooter
    End Enum

    Public Enum enmTextAlign
        Left = 1
        Center = 2
        Right = 3
    End Enum

    Public Enum enmFunctionTypes
        Sum
        Average
    End Enum

    Private RHTextCount As Integer = 20
    Private PHTextCount As Integer = 40
    Private RFTextCount As Integer = 60
    Private PFTextCount As Integer = 100

    Private MaxColumn As Integer = 30

    Private vParameters As String = ""
    Public rpt 'As New rptReport
    Private dt As DataTable
    Private vColumns As Array

    Public ReadOnly Property ReportSource() As CrystalDecisions.CrystalReports.Engine.ReportClass
        Get
            Return rpt
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        Dim vParameterFields As New CrystalDecisions.Shared.ParameterFields
        vParameterFields.Add(GetParamValue("CompanyName", ""))
        vParameterFields.Add(GetParamValue("ReportTitle", ""))
        vParameterFields.Add(GetParamValue("ReportDateTime", ""))
        cryReport.ParameterFieldInfo = vParameterFields
        'rpt = New rptReport2
        'rpt.SetDataSource(New DataTable)
        'cryReport.ReportSource = rpt
    End Sub

    Public Sub New(ByVal rpt As Object, ByVal Parameters As String)
        InitializeComponent()

        If Parameters <> "" Then
            Dim vParameterFields As New CrystalDecisions.Shared.ParameterFields
            Dim vArray As Array = Parameters.Split(";")
            For i As Integer = 0 To vArray.Length - 1
                vParameterFields.Add(GetParamValue(vArray(i).ToString.Split("=")(0), vArray(i).ToString.Split("=")(1)))
            Next
            cryReport.ParameterFieldInfo = vParameterFields
        End If
        cryReport.ReportSource = rpt
    End Sub


    Public Sub New(ByVal Columns As String, ByVal ReportTitle As String,
                    ByVal dtItems As DataTable,
                    Optional ByVal PaperOrientation As CrystalDecisions.Shared.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait,
                    Optional ByVal PaperSize As CrystalDecisions.Shared.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4,
                    Optional ByVal PageMarginL As Integer = 5,
                    Optional ByVal PageMarginT As Integer = 5,
                    Optional ByVal PageMarginR As Integer = 5,
                    Optional ByVal PageMarginB As Integer = 5,
                    Optional ByVal PrinterName As String = "",
                    Optional ByVal PrintToPrinter As Boolean = False)
        InitializeComponent()

        'If PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait Then
        '    rpt = New rptReport
        'Else
        '    rpt = New rptReportLanScape
        'End If
        If PrinterName <> "" Then
            CType(rpt, CrystalDecisions.CrystalReports.Engine.ReportClass).PrintOptions.PrinterName = PrinterName
        End If
        dt = dtItems.Copy
        Dim vParams As Array = vParameters.Split(";")
        Dim i As Integer
        If PrintToPrinter = True And PrinterName <> "" Then
            rpt.SetParameterValue("CompanyName", CompanyName)
            rpt.SetParameterValue("ReportTitle", ReportTitle)
            'rpt.SetParameterValue("ReportDateTime", "")
            rpt.SetParameterValue("ReportDateTime", Solar.GetDateTime(True))
        Else
            Dim vParameterFields As New CrystalDecisions.Shared.ParameterFields
            vParameterFields.Add(GetParamValue("CompanyName", CompanyName))
            vParameterFields.Add(GetParamValue("ReportTitle", ReportTitle))
            vParameterFields.Add(GetParamValue("ReportDateTime", Solar.GetDateTime(True)))
            cryReport.ParameterFieldInfo = vParameterFields
        End If

        Dim vPageMargin As CrystalDecisions.Shared.PageMargins = New CrystalDecisions.Shared.PageMargins(PageMarginL, PageMarginT, PageMarginR, PageMarginB)
        rpt.PrintOptions.PaperSize = PaperSize
        rpt.PrintOptions.PaperOrientation = PaperOrientation

        rpt.Section3.ReportObjects("Text0").Left = rpt.PrintOptions.PageContentWidth - 500
        rpt.Section3.ReportObjects("fldRow").Left = rpt.PrintOptions.PageContentWidth - 500
        Dim vReportLeft As Integer = 0
        Dim vReportRight As Integer = rpt.Section3.ReportObjects("fldRow").Left + rpt.Section3.ReportObjects("fldRow").Width
        Dim vLeft As Integer = rpt.Section3.ReportObjects("fldRow").Left

        Dim j As Integer = 0, k As Integer = 0, z As Integer = 0
        Dim vPreFix As String = ""
        rpt.Section2.ReportObjects("hBox0").Left = rpt.Section3.ReportObjects("Text0").Left - 20
        CType(rpt.Section2.ReportObjects("hBox0"), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = vReportRight ' rpt.Section2.ReportObjects("hBox0").Left 'vRight
        rpt.Section2.ReportObjects("hBox0").Top = rpt.Section3.ReportObjects("Text0").Top
        CType(rpt.Section2.ReportObjects("hBox0"), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = rpt.Section3.ReportObjects("Text0").Top + rpt.Section3.ReportObjects("Text0").Height

        rpt.Section3.ReportObjects("BoxR").Left = vReportRight
        CType(rpt.Section3.ReportObjects("BoxR"), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = vReportRight
        rpt.Section3.ReportObjects("BoxR").Top = rpt.Section3.ReportObjects("fldRow").Top
        CType(rpt.Section3.ReportObjects("BoxR"), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = rpt.Section3.ReportObjects("fldRow").Top + rpt.Section3.ReportObjects("fldRow").Height

        rpt.Section3.ReportObjects("Box0").Left = rpt.Section3.ReportObjects("fldRow").Left - 20
        CType(rpt.Section3.ReportObjects("Box0"), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = rpt.Section3.ReportObjects("Box0").Left ' rpt.Section3.ReportObjects("fldRow").Left + rpt.Section3.ReportObjects("fldRow").Width + 20
        rpt.Section3.ReportObjects("Box0").Top = rpt.Section3.ReportObjects("fldRow").Top
        CType(rpt.Section3.ReportObjects("Box0"), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = rpt.Section3.ReportObjects("fldRow").Top + rpt.Section3.ReportObjects("fldRow").Height

        vColumns = Columns.Split(";")
        Dim vSeparator As Boolean = False
        For i = 0 To vColumns.Length - 1
            vSeparator = False
            If vColumns(i).ToString.Split(":").Length > 3 AndAlso vColumns(i).ToString.Split(":")(3) = "1" Then
                vSeparator = True
            End If
            vLeft = vLeft - vColumns(i).ToString.Split(":")(2) * 15 - 48
            If vLeft - 20 < 0 Then Exit For
            If vSeparator = False Then
                j += 1 : z = j : vPreFix = ""
            Else
                k += 1 : z = k : vPreFix = "I"
            End If

            If dt.Columns.Contains(vColumns(i).ToString.Split(":")(1)) Then
                dt.Columns(vColumns(i).ToString.Split(":")(1)).ColumnName = vPreFix & "Column" & z
                If dt.Columns(vPreFix & "Column" & z).DataType Is GetType(String) Or dt.Columns(vPreFix & "Column" & z).DataType Is GetType(Decimal) Then
                    rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").ObjectFormat.HorizontalAlignment = CrystalDecisions.Shared.Alignment.RightAlign
                    CType(rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1"), CrystalDecisions.CrystalReports.Engine.FieldObject).FieldFormat.NumericFormat.DecimalPlaces = 0
                    CType(rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1"), CrystalDecisions.CrystalReports.Engine.FieldObject).FieldFormat.NumericFormat.RoundingFormat = CrystalDecisions.Shared.RoundingFormat.RoundToUnit
                ElseIf dt.Columns(vPreFix & "Column" & z).DataType Is GetType(Decimal) Then
                    CType(rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1"), CrystalDecisions.CrystalReports.Engine.FieldObject).FieldFormat.NumericFormat.DecimalPlaces = 3
                Else
                    rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").ObjectFormat.HorizontalAlignment = CrystalDecisions.Shared.Alignment.HorizontalCenterAlign
                    CType(rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1"), CrystalDecisions.CrystalReports.Engine.FieldObject).FieldFormat.NumericFormat.DecimalPlaces = 0
                    CType(rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1"), CrystalDecisions.CrystalReports.Engine.FieldObject).FieldFormat.NumericFormat.RoundingFormat = CrystalDecisions.Shared.RoundingFormat.RoundToUnit
                End If
            End If

            rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Left = vLeft
            rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Width = vColumns(i).ToString.Split(":")(2) * 15
            rpt.Section3.ReportObjects("Box" & j + k).Left = vLeft - 20
            'vRight = vLeft + vColumns(i).ToString.Split(":")(2) * 15 + 20
            CType(rpt.Section3.ReportObjects("Box" & j + k), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = rpt.Section3.ReportObjects("Box" & j + k).Left 'vRight
            rpt.Section3.ReportObjects("Box" & j + k).Top = rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Top
            CType(rpt.Section3.ReportObjects("Box" & j + k), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Top + rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Height
            rpt.Section2.ReportObjects("Text" & j + k).Left = vLeft - 10
            rpt.Section2.ReportObjects("Text" & j + k).Width = vColumns(i).ToString.Split(":")(2) * 15 + 10
            CType(rpt.Section2.ReportObjects("Text" & j + k), CrystalDecisions.CrystalReports.Engine.TextObject).Text = vColumns(i).ToString.Split(":")(0)
            rpt.Section2.ReportObjects("hBox" & j + k).Left = vLeft - 20
            CType(rpt.Section2.ReportObjects("hBox" & j + k), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = vLeft + vColumns(i).ToString.Split(":")(2) * 15 + 20
            rpt.Section2.ReportObjects("hBox" & j + k).Top = rpt.Section2.ReportObjects("Text" & j + k).Top
            CType(rpt.Section2.ReportObjects("hBox" & j + k), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = rpt.Section2.ReportObjects("Text" & j + k).Top + rpt.Section2.ReportObjects("Text" & j + k).Height
            If z = MaxColumn Then Exit For
        Next
        vReportLeft = rpt.Section3.ReportObjects(vPreFix & "Column" & z & "1").Left
        rpt.Section2.ReportObjects("ReportDateTime1").Left = vReportLeft + 10
        rpt.Section2.ReportObjects("Reporter").Left = vReportLeft + 10
        rpt.Section2.ReportObjects("Reporter").text = Globals.CurrentUser.Name
        rpt.Section2.ReportObjects("CONCRETEName1").Left = vReportLeft
        rpt.Section2.ReportObjects("CONCRETEName1").Width = vReportRight - vReportLeft
        rpt.Section2.ReportObjects("ReportTitle1").Left = vReportLeft
        rpt.Section2.ReportObjects("ReportTitle1").Width = vReportRight - vReportLeft
        rpt.Section2.ReportObjects("boxFrame").Left = vReportLeft - 10
        CType(rpt.Section2.ReportObjects("boxFrame"), CrystalDecisions.CrystalReports.Engine.BoxObject).Right = vReportRight + 10
        CType(rpt.Section2.ReportObjects("linDetail"), CrystalDecisions.CrystalReports.Engine.LineObject).Left = vReportLeft
        CType(rpt.Section2.ReportObjects("linDetail"), CrystalDecisions.CrystalReports.Engine.LineObject).Right = vReportRight
        For i = j + 1 To 15
            rpt.Section3.ReportObjects("Column" & i & "1").Width = 0
        Next
        If PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait Then
            For i = k + 1 To 15
                rpt.Section3.ReportObjects("IColumn" & i & "1").Width = 0
            Next
        End If
        For i = j + k + 1 To 38
            Try
                CType(rpt.Section2.ReportObjects("Box" & i), CrystalDecisions.CrystalReports.Engine.BoxObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine
            Catch ex As Exception
            End Try
            Try
                CType(rpt.Section2.ReportObjects("hBox" & i), CrystalDecisions.CrystalReports.Engine.BoxObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine
            Catch ex As Exception
            End Try
            Try
                rpt.Section2.ReportObjects("Text" & i).Width = 0
            Catch ex As Exception
            End Try
        Next

        rpt.SetDataSource(dt)
        If PrintToPrinter = False Or PrinterName = "" Then cryReport.ReportSource = rpt
    End Sub
    Public Sub Print()
        cryReport.PrintReport()
    End Sub

    Public Sub AddText(ByVal Value As String,
    ByVal Align As enmTextAlign,
    ByVal Place As enmParameterPlace,
    ByVal ColumnName As String,
    ByVal Y As Integer,
    ByVal Border As Boolean)
        Dim i As Integer
        For i = 0 To vColumns.Length - 1
            If vColumns(i).ToString.Split(":")(1).Split(":")(0) = ColumnName Then Exit For
        Next
        If i = vColumns.Length Then Exit Sub
        i += 1
        AddText(Value, Align, Place, rpt.Section2.ReportObjects("Text" & i).Left + 30, Y, rpt.Section2.ReportObjects("Text" & i).Width - 30, Border, 1)
    End Sub

    Public Sub AddText(ByVal Value As String,
    ByVal Align As enmTextAlign,
    ByVal Place As enmParameterPlace,
    ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer,
    ByVal Border As Boolean,
    Optional ByVal Scale As Integer = 10)
        Dim i As Integer
        Dim vTopOffset As Integer = 0
        If Width < 0 Then Exit Sub
        Dim vTextId As Integer = 0
        Dim Section As CrystalDecisions.CrystalReports.Engine.Section = rpt.Section1
        Select Case Place
            Case enmParameterPlace.ReportHeader
                Section = rpt.Section1
                RHTextCount += 1
                vTextId = RHTextCount
            Case enmParameterPlace.PageHeader
                Section = rpt.Section2
                PHTextCount += 1
                vTextId = PHTextCount
                vTopOffset = 550
            Case enmParameterPlace.ReportFooter
                Section = rpt.Section4
                RFTextCount += 1
                vTextId = RFTextCount
            Case enmParameterPlace.PageFooter
                Section = rpt.Section5
                PFTextCount += 1
                vTextId = PFTextCount
        End Select
        If Section.Height - vTopOffset < Y * Scale + 350 Then '+ 550 Then
            Section.Height += 350
        End If
        If Place = enmParameterPlace.PageHeader Then
            For i = 0 To 20
                CType(rpt.Section2.ReportObjects("Text" & i), CrystalDecisions.CrystalReports.Engine.TextObject).Top = Section.Height - 545
                CType(rpt.Section2.ReportObjects("hBox" & i), CrystalDecisions.CrystalReports.Engine.BoxObject).Top = Section.Height - 550
                CType(rpt.Section2.ReportObjects("hBox" & i), CrystalDecisions.CrystalReports.Engine.BoxObject).Bottom = Section.Height - 10
            Next
        End If
        CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).ObjectFormat.HorizontalAlignment = Align
        CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Value
        CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Left = X * Scale
        CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Top = Y * Scale
        CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Width = Width * Scale
        If Border = True Then
            CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Border.TopLineStyle = CrystalDecisions.Shared.LineStyle.SingleLine
            CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Border.BottomLineStyle = CrystalDecisions.Shared.LineStyle.SingleLine
            CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Border.RightLineStyle = CrystalDecisions.Shared.LineStyle.SingleLine
            CType(Section.ReportObjects("Text" & vTextId), CrystalDecisions.CrystalReports.Engine.TextObject).Border.LeftLineStyle = CrystalDecisions.Shared.LineStyle.SingleLine
        End If
    End Sub
    Public Shared Function GetParamValue(ByVal paramName As String, ByVal paramValue As String) As CrystalDecisions.Shared.ParameterField
        Dim paramField As New CrystalDecisions.Shared.ParameterField
        Dim discreteVal As New CrystalDecisions.Shared.ParameterDiscreteValue
        paramField.ParameterFieldName = paramName
        discreteVal.Value = paramValue
        paramField.CurrentValues.Add(discreteVal)
        Return paramField
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToExcel.Click
        Dim vDialog As New SaveFileDialog
        vDialog.Filter = "Microsoft Excel Files (*.xls)|*.xls"
        If rpt IsNot Nothing Then

            For i As Integer = 0 To 20
                rpt.Section2.ReportObjects("hBox" & i).ObjectFormat.EnableSuppress = True
            Next
            For i As Integer = 0 To 20
                'If CType(rpt.Section2.ReportObjects("Text" & i), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "" Then
                rpt.Section2.ReportObjects("Text" & i).ObjectFormat.EnableSuppress = True
                'End If
            Next
            For i As Integer = 21 To 40
                rpt.Section1.ReportObjects("Text" & i).ObjectFormat.EnableSuppress = True
            Next
            For i As Integer = 41 To 60
                rpt.Section2.ReportObjects("Text" & i).ObjectFormat.EnableSuppress = True
            Next
            For i As Integer = 61 To 100
                rpt.Section4.ReportObjects("Text" & i).ObjectFormat.EnableSuppress = True
            Next
            For i As Integer = 101 To 110
                rpt.Section5.ReportObjects("Text" & i).ObjectFormat.EnableSuppress = True
            Next
            For i As Integer = 0 To 20
                rpt.Section4.ReportObjects("Box" & i).ObjectFormat.EnableSuppress = True
            Next
        End If

        If vDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportClass = cryReport.ReportSource
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, vDialog.FileName)
            rpt = Nothing
            MessageBox.Show("Success!")
        End If
        vDialog = Nothing
    End Sub
    Private Sub Report_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                cryReport.PrintReport()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class