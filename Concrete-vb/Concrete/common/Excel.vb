Imports Microsoft.Office.Interop.Excel
Imports System.Globalization
Imports System.Threading
Public Class Excel
    Implements IDisposable
    Private App As ApplicationClass
    Private OriginalCulture As Globalization.CultureInfo
    Private _OpenFileName As String
    Public Enum Category
        Numeric
        Formatted
    End Enum
    Public Sub New()
        OriginalCulture = Thread.CurrentThread.CurrentCulture
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        App = New ApplicationClass()
        App.DisplayAlerts = False
    End Sub

    Public Sub Create(ByVal fileName As String)
        Try
            Close()
            App.Workbooks.Add(XlWBATemplate.xlWBATWorksheet)
            App.ActiveWorkbook.SaveAs(fileName,
                                      XlFileFormat.xlWorkbookNormal,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      XlSaveAsAccessMode.xlNoChange,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      System.Type.Missing,
                                      System.Type.Missing)
            _OpenFileName = fileName
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Open(ByVal Filename As String)
        Try
            Close()
            App.Workbooks.Open(Filename,
                               False,
                               False,
                               System.Type.Missing,
                               System.Type.Missing,
                               System.Type.Missing,
                               System.Type.Missing,
                               System.Type.Missing,
                               System.Type.Missing,
                               False,
                               System.Type.Missing,
                               System.Type.Missing,
                               False,
                               System.Type.Missing,
                               System.Type.Missing)
            _OpenFileName = Filename
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Close()
        Try
            App.Workbooks.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public ReadOnly Property AnyFileOpen() As Boolean
        Get
            Return Not String.IsNullOrEmpty(_OpenFileName)
        End Get
    End Property
    Public Sub Save()
        If Not AnyFileOpen Then Throw New ExcelException("No file is Open")
        App.ActiveWorkbook.Save()
    End Sub
    Public Sub SaveAs(ByVal newFileName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            App.ActiveWorkbook.SaveAs(newFileName,
                                              XlFileFormat.xlWorkbookNormal,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              XlSaveAsAccessMode.xlNoChange,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing)
            _OpenFileName = newFileName
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not save file as '{0}'", newFileName), ex)
        End Try
    End Sub
    Public Sub SaveAs2007(ByVal newFileName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            App.ActiveWorkbook.SaveAs(newFileName,
                                              XlFileFormat.xlOpenXMLWorkbook,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              XlSaveAsAccessMode.xlNoChange,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing,
                                              System.Type.Missing)
            _OpenFileName = newFileName
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not save file as '{0}'", newFileName), ex)
        End Try
    End Sub
#Region "Functions to work with Worksheets"

    Public ReadOnly Property ActSheet() As Microsoft.Office.Interop.Excel.Worksheet

        Get
            Return App.ActiveSheet
        End Get

    End Property
    Public Function GetSheetsName(ByVal Filename As String) As Data.DataTable
        Dim dt As New Data.DataTable
        dt.Columns.Add("SheetName")
        Dim dr As DataRow
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            For Each wsheet As _Worksheet In App.ActiveWorkbook.Sheets
                dr = dt.NewRow
                dr.Item("SheetName") = wsheet.Name.ToString
                dt.Rows.Add(dr)
            Next
            Return dt
        Catch ex As Exception
            'Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not Find SheetName", ""), ex)
            Return Nothing
        End Try
        Return dt
    End Function
    Public Function ImportFromExcel(ByVal FilePath As String, ByVal SheetName As String) As Data.DataTable
        Dim dt As New Data.DataTable
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & FilePath & "';Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & SheetName & "$]", MyConnection)
            'MyCommand.TableMappings.Add("Table", "TestTable")
            MyCommand.Fill(dt)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return dt
    End Function
    Public Sub ColumnNameSheet(ByVal sheetName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        'dim str as String =
        Try
            For Each wsheet As _Worksheet In App.ActiveWorkbook.Sheets
                If (String.Compare(wsheet.Name, sheetName, True) = 0) Then
                    wsheet.Columns.Name.ToString()
                    Return
                End If
            Next
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not activate sheet '{0}'", sheetName), ex)
        End Try
    End Sub
    Public Sub ActivateSheet(ByVal sheetName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            For Each wsheet As _Worksheet In App.ActiveWorkbook.Sheets
                If (String.Compare(wsheet.Name, sheetName, True) = 0) Then
                    wsheet.Activate()
                    Return
                End If
            Next
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not activate sheet '{0}'", sheetName), ex)
        End Try
    End Sub
    Public Sub RemoveSheet(ByVal sheetName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            For Each wsheet As _Worksheet In App.ActiveWorkbook.Sheets
                If (String.Compare(wsheet.Name, sheetName, True) = 0) Then
                    wsheet.Delete()
                    Return
                End If
                Throw New ExcelException(String.Format("Can not find sheet '{0}'", sheetName))
            Next

        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not Remove sheet '{0}'", sheetName), ex)
            Close()

        End Try
    End Sub
    Public Sub AddSheet(ByVal sheetName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            Dim wsheet As _Worksheet
            wsheet = App.Sheets.Add()
            wsheet.DisplayRightToLeft = True
            wsheet.Name = sheetName
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not Add sheet '{0}'", sheetName), ex)
            Close()
        End Try
    End Sub
    Public Sub RenameSheet(ByVal oldName As String, ByVal newName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            For Each wsheet As _Worksheet In App.ActiveWorkbook.Sheets
                If (String.Compare(wsheet.Name, oldName, True) = 0) Then
                    wsheet.Name = newName
                    Return
                End If
                Throw New ExcelException(String.Format("Can not find sheet '{0}'", oldName))
            Next
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not rename sheet '{0}' to '{1}'", oldName, newName), ex)
            Close()

        End Try
    End Sub
    Public Sub RenameCurrentSheet(ByVal newName As String)
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            CType(App.ActiveSheet, _Worksheet).Name = newName

        Catch ex As Exception
            Throw New ExcelException("Can not rename current sheet", ex)
            Close()
        End Try
    End Sub
    Public Sub Run()
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            App.Application.Visible = True

        Catch ex As Exception
            Throw New ExcelException("Can not PrintPreview ActiveWorkbook", ex)
            Close()
        End Try
    End Sub
    Public Sub PrintPrintview()
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            App.ActiveWorkbook.PrintPreview()

        Catch ex As Exception
            Throw New ExcelException("Can not PrintPreview ActiveWorkbook", ex)
            Close()
        End Try
    End Sub
#End Region
#Region "Functions to work with cell and range values"
    Public Function GetValue(ByVal cellAddress As String, ByVal Category As Category) As Object
        If (String.IsNullOrEmpty(cellAddress)) Then Throw New ArgumentNullException("cellAddress")
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            Dim Range As Range = CType(App.ActiveSheet, _Worksheet).Range(cellAddress, System.Type.Missing)
            If (Category = Category.Numeric) Then
                Return Range.Value2
            Else
                Return Range.Text
            End If

        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not access values at address '{0}'", cellAddress), ex)
        End Try

    End Function
    Public Sub SetValueMarg(ByVal cellAddress As String, ByVal HorizontalAlignment As Microsoft.Office.Interop.Excel.XlHAlign _
                            , ByVal TEXT As String, ByVal ForeColor As Color, ByVal BackColor As Color)

    End Sub
    Public Property Reng(ByVal cellAddress As String) As Microsoft.Office.Interop.Excel.Range
        Get
            If (Not AnyFileOpen) Then
                If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
                Return Nothing
            End If
            Return CType(App.ActiveSheet, _Worksheet).Range(cellAddress, System.Type.Missing)
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Excel.Range)
            App.Range(cellAddress, System.Type.Missing).Value2 = value.Value2
        End Set
    End Property
    Public Function GetNumericValue(ByVal cellAddress As String) As Double
        Return CType(GetValue(cellAddress, Category.Numeric), Double)
    End Function
    Public Function GetFormattedValue(ByVal cellAddress As String) As Object
        Return GetValue(cellAddress, Category.Formatted)
    End Function
    Public Sub SetValue(ByVal cellAddress As String, ByVal Value As Object)
        If (String.IsNullOrEmpty(cellAddress)) Then Throw New ArgumentNullException("cellAddress")
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            App.Range(cellAddress, System.Type.Missing).Value2 = Value
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not set value of cell '{0}'", cellAddress), ex)
        End Try
    End Sub
    Public Sub SetValue(ByVal RowIndex As Integer,
                        ByVal ColIndex As Integer,
                        ByVal Value As Object)
        Dim rng As Microsoft.Office.Interop.Excel.Range
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try
            rng = GetReng(RowIndex, ColIndex)
            rng.Value = Value
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not set value of cell '{0}'"), ex)
        End Try
    End Sub
    Public Sub SetValue(ByVal RowIndex As Integer,
                        ByVal ColIndex As Integer,
                        ByVal Value As Object,
                        ByVal Value2 As Object,
                        ByVal FontName As String,
                        ByVal FontUnderline As Boolean,
                        ByVal FontSize As Integer,
                        ByVal FontBold As Boolean,
                        ByVal FontColor As String,
                        ByVal VerticalAlignment As Microsoft.Office.Interop.Excel.XlVAlign,
                        ByVal HorizontalAlignment As Microsoft.Office.Interop.Excel.XlHAlign,
                        ByVal Orientation As Integer,
                        ByVal WrapText As Boolean,
                        ByVal ColumnWidth As Integer,
                        ByVal RowHeight As Integer,
                        ByVal ColorIndex As Integer)
        'Dim vStyle As Style
        'Dim vBorder As Microsoft.Office.Interop.Excel.Border
        '' vStyle.IncludeAlignment = True
        ' vStyle.Nam()
        Dim rng As Microsoft.Office.Interop.Excel.Range
        'If (String.IsNullOrEmpty( cellAddress)) Then Throw New ArgumentNullException("cellAddress")
        If (Not AnyFileOpen) Then Throw New ExcelException("No file is Open")
        Try

            rng = GetReng(RowIndex, ColIndex)
            With rng
                .Value = Value
                .Merge()
                .Font.Name = FontName
                .Font.Underline = FontUnderline
                .Font.Size = FontSize
                .Font.Bold = FontBold
                If FontColor <> "" Then .Font.Color = FontColor
                .VerticalAlignment = VerticalAlignment
                .Interior.ColorIndex = ColorIndex
                .HorizontalAlignment = HorizontalAlignment
                .Orientation = Orientation
                .WrapText = WrapText
                If ColumnWidth > 0 Then .ColumnWidth = ColumnWidth
                If RowHeight > 0 Then .RowHeight = RowHeight
                .Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous
                .Borders(XlBordersIndex.xlEdgeRight).Weight = XlBorderWeight.xlThin
                .Borders(XlBordersIndex.xlEdgeRight).ColorIndex = XlColorIndex.xlColorIndexAutomatic
                .Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous
                .Borders(XlBordersIndex.xlEdgeLeft).Weight = XlBorderWeight.xlThin
                .Borders(XlBordersIndex.xlEdgeLeft).ColorIndex = XlColorIndex.xlColorIndexAutomatic
                .Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous
                .Borders(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin
                .Borders(XlBordersIndex.xlEdgeBottom).ColorIndex = XlColorIndex.xlColorIndexAutomatic
                .Borders(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous
                .Borders(XlBordersIndex.xlEdgeTop).Weight = XlBorderWeight.xlThin
                .Borders(XlBordersIndex.xlEdgeTop).ColorIndex = XlColorIndex.xlColorIndexAutomatic
            End With
            'Dim chrt As Microsoft.Office.Interop.Excel.Chart = App.Charts.Add
            'chrt.SetSourceData(rng)
        Catch ex As Exception
            Throw New ExcelException(String.Format(CultureInfo.InvariantCulture, "Can not set value of cell '{0}'", rng.Address), ex)
        End Try
    End Sub
    Public Function GetReng(ByVal cellAddress As String) As Microsoft.Office.Interop.Excel.Range
        Return App.ActiveSheet.Range(cellAddress, System.Type.Missing)
    End Function
    Public Function GetReng(ByVal RowIndex As Integer, ByVal ColIndex As Integer) As Microsoft.Office.Interop.Excel.Range
        Return App.ActiveSheet.Cells(RowIndex, ColIndex)
    End Function
#End Region
#Region " IDisposable Support "
    Private disposedValue As Boolean = False    ' To detect redundant calls

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If App IsNot Nothing Then
                    '     Close()
                    App.Quit()
                    If AnyFileOpen Then Close()

                    App = Nothing
                    Thread.CurrentThread.CurrentCulture = OriginalCulture
                End If
            End If

        End If
        Me.disposedValue = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Try
            Close()
        Catch ex As Exception
        End Try
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
Public Class ExcelException
    Inherits Exception
    Public Sub New()
    End Sub
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(ByVal message As String, ByVal inner As Exception)
        MyBase.New(message, inner)
    End Sub
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, _
                      ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
    End Sub
End Class
