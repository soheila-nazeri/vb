Imports Stimulsoft.Base.Drawing
Imports Stimulsoft.Report
Imports Stimulsoft.Report.Components
Imports System.IO
Public Class mnJanusGrid
    Public Event UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
    Public Shadows Event MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Public Event CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    Public Event SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
    Public Event FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
    Public Shadows Event Double_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Event RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    Public Event LinkClicked(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    Public Event AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    Public Event GetNewRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.GetNewRowEventArgs)
    Public Event Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    Public Event CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private ReportObjects() As stcReportObject = {}
    Private vReportTitle As String = ""
    Dim strInit As String
    Dim PaperSizeGrd As Decimal = 10.9
    Dim strColumns As String = ""
    Dim strSumColumns As String = ""
    Private vFilter As String
    Dim dtItems As New DataTable
    Dim vUserGridColumns As String
    Dim vMainGridColumns As String
    Dim vdrLoadInitGrid As DataRow
    Private vType As Integer = 0
    Public Property Type() As Integer
        Get
            Return vType
        End Get
        Set(ByVal value As Integer)
            vType = value
        End Set
    End Property
    Public Property strFilter() As String
        Get
            Return vFilter
        End Get
        Set(ByVal value As String)
            vFilter = value
        End Set
    End Property
    Private vHasSumColumn As Boolean
    Public Property HasSumColumn() As Boolean
        Get
            Return vHasSumColumn
        End Get
        Set(ByVal value As Boolean)
            vHasSumColumn = value
        End Set
    End Property
    Private vShowSelectedAll As Boolean
    Public Property ShowSelectedAll() As Boolean
        Get
            Return vShowSelectedAll
        End Get
        Set(ByVal value As Boolean)
            vShowSelectedAll = value
            If vShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.False Then
                chkSelectAll.Visible = False
            End If
            chkSelectAll.Visible = value
        End Set
    End Property
    'Private vSelFilterData As DataTable
    'Public Property SelFilterData() As DataTable
    'Get
    '    Dim dtcopy As DataTable = Me.DataView.ToTable.Clone
    '    Try
    '        Dim x() As Janus.Windows.GridEX.GridEXRow = Me.RootTable.GridEX.GetDataRows
    '        If x.Length = 0 Then Return Nothing
    '        Dim drv As DataRowView
    '        For j As Integer = 0 To x.Length - 1
    '            drv = x(j).DataRow
    '            dtcopy.ImportRow(drv.Row)
    '        Next
    '        vSelFilterData = dtcopy.Copy
    '    Catch ex As Exception
    '    End Try

    '    Return vSelFilterData
    'End Get
    'Set(ByVal value As DataTable)
    'End Set
    'End Property
#Region "Event"
    Private Sub grd_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grd.CellEdited
        RaiseEvent CellEdited(sender, e)
    End Sub
    Private Sub grd_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grd.CellValueChanged
        RaiseEvent CellValueChanged(sender, e)
    End Sub
    Private Sub grd_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd.MouseClick
        RaiseEvent MouseClick(sender, e)
    End Sub
    Private Sub grd_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grd.UpdatingCell
        RaiseEvent UpdatingCell(sender, e)
    End Sub
    Private Sub grd_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.SelectionChanged
        RaiseEvent SelectionChanged(sender, e)
    End Sub
    Private Sub grd_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grd.RowDoubleClick
        RaiseEvent RowDoubleClick(sender, e)
    End Sub
    Private Sub grd_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles grd.FormattingRow
        RaiseEvent FormattingRow(sender, e)
    End Sub
    Private Sub grd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.DoubleClick
        RaiseEvent Double_Click(sender, e)
    End Sub
    Private Sub grd_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.RecordAdded
        RaiseEvent RecordAdded(sender, e)
    End Sub
    Private Sub grd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grd.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub
    Private Sub grd_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.RecordUpdated
        RaiseEvent RecordUpdated(sender, e)
    End Sub
    Private Sub grd_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grd.ColumnButtonClick
        RaiseEvent ColumnButtonClick(sender, e)
    End Sub
    Private Sub grd_LinkClicked(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grd.LinkClicked
        RaiseEvent LinkClicked(sender, e)
    End Sub
    Private Sub me_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.CurrentCellChanged
        RaiseEvent CurrentCellChanged(sender, e)
    End Sub
#End Region
#Region "Property"
    Public ReadOnly Property CurrentRow() As Janus.Windows.GridEX.GridEXRow
        Get
            Return grd.CurrentRow

        End Get
    End Property

    Public WriteOnly Property [ReadOnly](ByVal ColumnName As String) As Boolean
        Set(ByVal value As Boolean)
            grd.RootTable.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            grd.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            'grd.RootTable.Columns(ColumnName).SelectableCells = IIf(value = True,iif(grd.RootTable.Columns(ColumnName).editType <> Janus.Windows.GridEX.EditType.NoEdi Janus.Windows.GridEX.SelectableCells.FilterRowCells, Janus.Windows.GridEX.SelectableCells.All)
            grd.RootTable.Columns(ColumnName).SelectableCells = IIf(value = True, IIf(grd.FilterMode <> Janus.Windows.GridEX.FilterMode.None, Janus.Windows.GridEX.SelectableCells.FilterRowCells, Janus.Windows.GridEX.SelectableCells.None), Janus.Windows.GridEX.SelectableCells.All)
        End Set
    End Property
    Public Sub SetCboColumn(ByVal ColumnName As String, ByVal dt As DataTable, ByVal ValuMember As String, ByVal DisplayMember As String)
        Try
            grd.RootTable.Columns(ColumnName).EditType = Janus.Windows.GridEX.EditType.DropDownList
            grd.RootTable.Columns(ColumnName).HasValueList = True
            Dim ValueList As Janus.Windows.GridEX.GridEXValueListItemCollection = grd.RootTable.Columns(ColumnName).ValueList
            ValueList.PopulateValueList(dt.DefaultView, ValuMember, DisplayMember)
            grd.RootTable.Columns(ColumnName).EditTarget = Janus.Windows.GridEX.EditTarget.Value
            grd.RootTable.Columns(ColumnName).CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            grd.RootTable.Columns(ColumnName).DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
        Catch ex As Exception
        End Try
    End Sub
    Public Property DataSource() As Object
        Get
            Return grd.DataSource
        End Get
        Set(ByVal value As Object)

            If HasSumColumn = True And Not value Is Nothing Then
                CType(value, DataTable).Columns.Add("SumColumn", GetType(Long))
                If strSumColumns.Length > 0 Then strSumColumns = strSumColumns.Remove(0, 1)
                Dim vSum As Long
                For Each dr As DataRow In CType(value, DataTable).Rows
                    vSum = 0
                    For k As Integer = 0 To strSumColumns.Split(",").Length - 1
                        vSum += Utility.NVL(dr.Item(strSumColumns.Split(",")(k)), 0)
                    Next
                    dr.Item("sumColumn") = vSum
                Next
            End If

            grd.DataSource = value
            lblRecordCount.Text = "   " & "تعداد: " & grd.RecordCount & "   "
        End Set
    End Property
    Public ReadOnly Property DataView() As DataView
        Get
            Try
                If grd.DataSource.GetType Is GetType(DataTable) Then Return CType(grd.DataSource, DataTable).DefaultView
                If grd.DataSource.GetType Is GetType(DataView) Then Return grd.DataSource
                Return grd.DataSource
            Catch ex As Exception
            End Try
        End Get
    End Property
    Public ReadOnly Property Columns() As Janus.Windows.GridEX.GridEXColumnCollection
        Get
            Return grd.RootTable.Columns
        End Get
    End Property
    Private vCurrentDataRow As Janus.Windows.GridEX.GridEXRow
    Public ReadOnly Property CurrentDataRow() As DataRow
        Get
            If vCurrentDataRow Is Nothing Then
                If grd.CurrentRow Is Nothing Then Return Nothing
                If grd.CurrentRow.RowType = Janus.Windows.GridEX.RowType.Record Then Return CType(grd.CurrentRow.DataRow, DataRowView).Row
            Else
                If vCurrentDataRow.DataRow Is Nothing Then Return Nothing
                If vCurrentDataRow.RowType = Janus.Windows.GridEX.RowType.Record Then Return CType(vCurrentDataRow.DataRow, DataRowView).Row
            End If
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property RootTable() As Janus.Windows.GridEX.GridEXTable
        Get
            Return grd.RootTable
        End Get
    End Property
    Public Property AllowEdit() As Janus.Windows.GridEX.InheritableBoolean
        Get
            Return grd.AllowEdit
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            grd.AllowEdit = value
        End Set
    End Property
    Public Property AllowAddNew() As Janus.Windows.GridEX.InheritableBoolean
        Get
            Return grd.AllowAddNew
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            grd.AllowAddNew = value
        End Set
    End Property
    Public Property AllowDelete() As Janus.Windows.GridEX.InheritableBoolean
        Get
            Return grd.AllowDelete
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            grd.AllowDelete = value
        End Set
    End Property
    Public ReadOnly Property RecordCount() As Integer
        Get
            Return grd.RecordCount
        End Get
    End Property

    Private vHeaderLines As Integer = 1
    Public Property HeaderLines() As Integer
        Get
            Return vHeaderLines
        End Get
        Set(ByVal value As Integer)
            vHeaderLines = value
        End Set
    End Property
    Private vShowFilterBar As Janus.Windows.GridEX.InheritableBoolean = Janus.Windows.GridEX.InheritableBoolean.True
    Public Property ShowFilterBar() As Janus.Windows.GridEX.InheritableBoolean
        Get
            Return vShowFilterBar
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            If grd.FilterRow Is Nothing Then Return
            If value = Janus.Windows.GridEX.InheritableBoolean.True Then
                grd.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
            Else
                grd.FilterMode = vShowFilterBar
            End If
            vShowFilterBar = IIf(grd.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic, Janus.Windows.GridEX.InheritableBoolean.True, Janus.Windows.GridEX.InheritableBoolean.False)
            vShowFilterBar = value
        End Set
    End Property

    Private vShowGroupBar As Boolean
    Public Property ShowGroupBar() As Boolean
        Get
            Return vShowGroupBar
        End Get
        Set(ByVal value As Boolean)
            grd.GroupByBoxVisible = value
            vShowGroupBar = value
        End Set
    End Property
    Private vShowColumnHeaders As Boolean = True
    Public Property ShowColumnHeaders() As Janus.Windows.GridEX.InheritableBoolean
        Get
            If grd.RootTable Is Nothing Then Return Janus.Windows.GridEX.InheritableBoolean.True
            Return grd.RootTable.ColumnHeaders
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            If grd.RootTable Is Nothing Then Return
            grd.RootTable.ColumnHeaders = value
            vShowColumnHeaders = value
        End Set
    End Property
    Private vShowToolbar As Boolean = True
    Public Property ShowToolbar() As Boolean
        Get
            Return vShowToolbar
        End Get
        Set(ByVal value As Boolean)
            tlbHeader.Visible = value
            vShowToolbar = value
        End Set
    End Property
    Public ReadOnly Property CurrentColumn() As Janus.Windows.GridEX.GridEXColumn
        Get
            Return grd.CurrentColumn
        End Get
    End Property
    Public Property CellSelectionMode() As Janus.Windows.GridEX.CellSelectionMode
        Get
            Return grd.CellSelectionMode
        End Get
        Set(ByVal value As Janus.Windows.GridEX.CellSelectionMode)
            grd.CellSelectionMode = value
        End Set
    End Property
    Public Property GroupByBoxVisible() As Boolean
        Get
            Return grd.GroupByBoxVisible
        End Get
        Set(ByVal value As Boolean)
            grd.GroupByBoxVisible = value
        End Set
    End Property
    Public Property ReportTitle() As String
        Get
            Return vReportTitle
        End Get
        Set(ByVal value As String)
            vReportTitle = value
        End Set
    End Property
    Public Property CurrentRowIndex() As Integer
        Get
            If (Not Me.CurrentRow Is Nothing) Then
                Return Me.CurrentRow.Position
            End If
            Return -1
        End Get
        Set(ByVal value As Integer)
            If (Not Me.DataSource Is Nothing) Then
                Dim manager As CurrencyManager = DirectCast(Me.BindingContext.Item(Me.DataSource), CurrencyManager)
                manager.Position = value
            End If
        End Set
    End Property
#End Region
    Public Sub Initialize(ByVal GridColumns As String, Optional ByVal DataSource_ As Object = Nothing)
        vdrLoadInitGrid = LoadInitGrid()
        vMainGridColumns = GridColumns
        '==========================
        dtItems.Rows.Clear()
        If dtItems.Columns.Contains("ID") = False Then dtItems.Columns.Add("ID")
        If dtItems.Columns.Contains("NAME") = False Then dtItems.Columns.Add("NAME")
        If dtItems.Columns.Contains("TITLE") = False Then dtItems.Columns.Add("TITLE")
        If dtItems.Columns.Contains("SELECTED") = False Then dtItems.Columns.Add("SELECTED", GetType(Boolean))
        If HasSumColumn = True Then
            GridColumns += ";جمع:SumColumn:130::###,###,###,###:::1"
            If Not DataSource_ Is Nothing Then CType(DataSource_, DataTable).Columns.Add("SumColumn", GetType(Long))
        End If
        strInit = GridColumns.ToUpper
        strColumns = ""
        strSumColumns = ""
        '================
        Dim tspItemsSelectAll As New System.Windows.Forms.ToolStripMenuItem
        '===========================
        Dim CountItem As Integer = 2
        Dim drItems As DataRow
        drItems = dtItems.NewRow
        drItems.Item("ID") = 1
        drItems.Item("NAME") = "NewRows"
        drItems.Item("TITLE") = "row"
        drItems.Item("SELECTED") = True
        dtItems.Rows.Add(drItems)

        '===========================
        If HasSumColumn = True Then
            tspSumItems.DropDownItems.Clear()
            Dim tspItemsSelectAllSum As New System.Windows.Forms.ToolStripMenuItem
            tspSumItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {tspItemsSelectAllSum})
            tspItemsSelectAllSum.Name = "tspItemsSelectAllSum"
            tspItemsSelectAllSum.Size = New System.Drawing.Size(176, 22)
            tspItemsSelectAllSum.Text = "not select"
        Else
            tspSumItems.Visible = False
        End If
        '===========================
        grd.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        grd.GroupByBoxInfoText = "Move for Grouping"
        grd.AlternatingColors = True
        grd.AlternatingRowFormatStyle.BackColor = Color.LavenderBlush
        grd.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        grd.FilterRowFormatStyle.BackColor = Color.Gainsboro


        grd.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grd.CardColumnHeaderFormatStyle.BackColor = System.Drawing.Color.LavenderBlush
        grd.DynamicFiltering = False
        grd.FilterRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Sunken
        grd.FlatBorderColor = System.Drawing.Color.AliceBlue
        grd.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        grd.GridLineColor = System.Drawing.SystemColors.ScrollBar
        grd.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.White
        grd.GroupByBoxVisible = False
        grd.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        grd.SelectedFormatStyle.Blend = 0.5!
        grd.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.WindowText
        grd.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        grd.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard
        grd.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard

        Dim Column As New Janus.Windows.GridEX.GridEXColumn
        Dim ColumnArray As Array
        Dim vRootTable As New Janus.Windows.GridEX.GridEXTable
        vRootTable.HeaderLines = vHeaderLines
        If Not grd.RootTable Is Nothing Then grd.RootTable.Columns.Clear()
        If Not grd.DataSource Is Nothing Then grd.DataSource = Nothing
        grd.RootTable = vRootTable
        Dim i As Integer
        ColumnArray = GridColumns.Split(";")
        Dim ColumnPropertires As Array
        Dim dtCombo As New DataTable
        dtCombo.Columns.Add("CODE", GetType(Integer))
        dtCombo.Columns.Add("TITLE", GetType(String))
        grd.AlternatingColors = True
        grd.AlternatingRowFormatStyle.BackColor = Color.LavenderBlush
        grd.FlatBorderInHeaders = False
        grd.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        grd.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        grd.DynamicFiltering = False

        For i = 0 To ColumnArray.Length - 1
            Column = New Janus.Windows.GridEX.GridEXColumn
            Column.Tag = ""
            Column.SelectableCells = Janus.Windows.GridEX.SelectableCells.All
            Column.FilterEditType = Janus.Windows.GridEX.FilterEditType.SameAsEditType
            Column.FilterRowComparison = Janus.Windows.GridEX.ConditionOperator.Contains
            Column.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
            ColumnPropertires = ColumnArray(i).ToString.Split(":")
            For k As Integer = 0 To ColumnPropertires.Length - 1
                Select Case k
                    Case enmColumnProperties.HeaderText
                        Column.Caption = ColumnPropertires(enmColumnProperties.HeaderText)
                    Case enmColumnProperties.DataProperty
                        Column.DataMember = ColumnPropertires(enmColumnProperties.DataProperty).ToString.Split("{")(0)
                        Column.Key = ColumnPropertires(enmColumnProperties.DataProperty).ToString.Split("{")(0)
                    Case enmColumnProperties.Width
                        If Val(ColumnPropertires(enmColumnProperties.Width)) = 0 Then
                            Column.Visible = False
                        Else
                            Column.Width = ColumnPropertires(enmColumnProperties.Width)
                        End If
                    Case enmColumnProperties.Type
                        Select Case Val(ColumnPropertires(enmColumnProperties.Type))
                            Case enmColumnType.TextBox
                                Column.ColumnType = Janus.Windows.GridEX.ColumnType.Text
                            Case enmColumnType.Link
                                Column.ColumnType = Janus.Windows.GridEX.ColumnType.Link
                            Case enmColumnType.CheckBox
                                Column.ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
                                Column.EditType = Janus.Windows.GridEX.EditType.CheckBox
                                Column.CheckBoxTrueValue = True
                                Column.CheckBoxTriState = False
                                Column.CheckBoxNullValue = DBNull.Value
                                Column.CheckBoxFalseValue = False
                                'Column.ActAsSelector = True
                            Case enmColumnType.ComboBox
                                Column.EditType = Janus.Windows.GridEX.EditType.DropDownList
                                Column.HasValueList = True
                                Dim ValueList As Janus.Windows.GridEX.GridEXValueListItemCollection = Column.ValueList
                                Dim vComboItems As Array : Dim dr As DataRow
                                If ColumnArray(i).ToString.Split(":")(1).IndexOf("{") > 0 Then
                                    vComboItems = ColumnArray(i).ToString.Split(":")(1).Split("{")(1).Split("}")(0).Split(",")
                                    Dim dtComboBox As DataTable = dtCombo.Clone
                                    dr = dtComboBox.NewRow
                                    dr.Item("CODE") = DBNull.Value
                                    dr.Item("TITLE") = ""
                                    dtComboBox.Rows.Add(dr)
                                    For J As Integer = 0 To vComboItems.Length - 1
                                        dr = dtComboBox.NewRow
                                        dr.Item("CODE") = vComboItems(J).ToString.Split("!")(0)
                                        dr.Item("TITLE") = vComboItems(J).ToString.Split("!")(1)
                                        dtComboBox.Rows.Add(dr)
                                    Next
                                    ValueList.PopulateValueList(dtComboBox.DefaultView, "CODE", "TITLE")
                                    Column.EditTarget = Janus.Windows.GridEX.EditTarget.Value
                                    Column.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
                                    Column.DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
                                End If
                            Case enmColumnType.Image
                                Column.ColumnType = Janus.Windows.GridEX.ColumnType.BoundImage
                            Case enmColumnType.Button
                                Column.ButtonDisplayMode = Janus.Windows.GridEX.CellButtonDisplayMode.Always
                                Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.TextButton
                                Column.ButtonText = "..."
                        End Select
                    Case enmColumnProperties.Format
                        Column.FormatMode = Janus.Windows.GridEX.FormatMode.UseIFormattable
                        Column.FormatString = ColumnPropertires(enmColumnProperties.Format)
                        Column.TotalFormatString = ColumnPropertires(enmColumnProperties.Format)

                        '=========================
                        If ColumnArray(i).ToString().Split(":")(1).ToUpper <> "SumColumn".ToUpper Then
                            Dim tspItemsSumItems As New System.Windows.Forms.ToolStripMenuItem
                            tspItemsSumItems.Checked = True
                            Try
                                tspItemsSumItems.Name = ColumnArray(i).ToString().Split(":")(1)
                            Catch ex As Exception
                            End Try
                            tspItemsSumItems.Text = ColumnArray(i).ToString().Split(":")(0)
                            Me.tspSumItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {tspItemsSumItems})
                            Try
                                strSumColumns += "," + ColumnArray(i).ToString().Split(":")(1)
                            Catch ex As Exception
                            End Try
                        End If
                        '=============================

                    Case enmColumnProperties.NullValue
                        If ColumnPropertires(enmColumnProperties.NullValue) <> "" Then
                            Column.NullText = ColumnPropertires(enmColumnProperties.NullValue)
                        Else
                            Column.NullText = ""
                        End If
                    Case enmColumnProperties.Align
                        If ColumnPropertires(enmColumnProperties.Align) <> "" Then
                            If ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "left" Then
                                Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                            ElseIf ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "right" Then
                                Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                            Else
                                Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                            End If
                        End If
                    Case enmColumnProperties.FillFooter
                        If ColumnPropertires(enmColumnProperties.FillFooter) <> "" Then
                            ' Column.Tag = Val(ColumnPropertires(enmColumnProperties.FillFooter))
                            Column.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                            grd.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
                            grd.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
                        End If
                End Select

            Next
            Try
                drItems = dtItems.NewRow
                drItems.Item("ID") = CountItem
                drItems.Item("NAME") = ColumnArray(i).ToString().Split(":")(1)
                drItems.Item("TITLE") = ColumnArray(i).ToString().Split(":")(0)
                drItems.Item("SELECTED") = True
                CountItem += 1
                dtItems.Rows.Add(drItems)
            Catch ex As Exception

            End Try
            '======================
            Try
                If ColumnArray(i).ToString().Split(":")(1).ToUpper = "date".ToUpper Or ColumnArray(i).ToString().Split(":")(1).ToUpper = "row".ToUpper Then
                    strColumns += "," + "_" + ColumnArray(i).ToString().Split(":")(1).ToUpper
                Else
                    strColumns += "," + ColumnArray(i).ToString().Split(":")(1)
                End If

            Catch ex As Exception
            End Try
            grd.RootTable.Columns.Add(Column)
        Next
        grd.RootTable.GridEX.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        grd.RootTable.RowHeight = 28
        grd.HeaderFormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionBeginsWith) = "بین"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionBeginsWith) = "ابتداي عبارت"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionClear) = "پاك كردن شرط"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionContains) = "شامل عبارت"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionEndsWith) = "انتهاي عبارت"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionEqual) = "مساوي"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionGreaterThan) = "بزرگتر"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionGreaterThanOrEqual) = "بزرگتر مساوي"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionIsEmpty) = "تهي بودن"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionLessThan) = "كوچكتر"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionLessThanOrEqual) = "كوچكتر مساوي"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotContains) = "شامل عبارت نباشد"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotEqual) = "نا مساوي"
        grd.RootTable.GridEX.BuiltInTexts.Item(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotIsEmpty) = "حاوي اطلاعات"
        grd.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grd.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        grd.RootTable.GridEX.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        grd.RootTable.GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False

        If Not DataSource_ Is Nothing Then DataSource = DataSource_
        If Not vdrLoadInitGrid Is Nothing AndAlso Utility.NVL(vdrLoadInitGrid("STR_INIT"), "") <> "" Then
            UserInitialize(vdrLoadInitGrid.Item("STR_INIT"), DataSource_)
            'CreateGroups()
        End If
        'If Not vdrLoadInitGrid Is Nothing Then
        '    If vdrLoadInitGrid.Table.Columns.Contains("GRIDLAYOUT") Then
        '        tlbLoad_Click(Nothing, Nothing)
        '    End If
        'End If
    End Sub
    Public Sub UserInitialize(ByVal GridColumns As String, Optional ByVal DataSource_ As Object = Nothing)
        '==========================
        Dim ColumnArray As Array
        ColumnArray = GridColumns.Split(";")
        strInit = GridColumns.ToUpper


        Dim Column As New Janus.Windows.GridEX.GridEXColumn

        For k As Integer = 0 To grd.RootTable.Columns.Count - 1
            Column = grd.RootTable.Columns(k)
            Column.Visible = False
        Next

        For Each dr As DataRow In dtItems.Rows
            dr.Item("SELECTED") = False
            For j As Integer = 0 To ColumnArray.Length - 1
                If ColumnArray(j).ToString().Split(":")(1).ToUpper = dr.Item("NAME").ToString.ToUpper Then
                    dr.Item("SELECTED") = True
                End If
            Next
        Next

        '===========================
        'Dim CountItem As Integer = 2
        '===========================

        'Dim vRootTable As New Janus.Windows.GridEX.GridEXTable
        'vRootTable.HeaderLines = vHeaderLines
        'If Not grd.RootTable Is Nothing Then grd.RootTable.Columns.Clear()
        'If Not grd.DataSource Is Nothing Then grd.DataSource = Nothing
        'grd.RootTable = vRootTable
        Dim i As Integer

        Dim vOrdinal As Integer = 0
        Dim vOrdinal1 As Integer = 0
        Dim vHasInList As Boolean
        'For i = 0 To grd.RootTable.Columns.Count - 1
        'Column = New Janus.Windows.GridEX.GridEXColumn
        'Column = grd.RootTable.Columns(i)
        Column = New Janus.Windows.GridEX.GridEXColumn
        For j As Integer = 0 To ColumnArray.Length - 1
            vHasInList = False
            For i = 0 To grd.RootTable.Columns.Count - 1
                Column = grd.RootTable.Columns(i)
                If Column.Key.ToUpper = ColumnArray(j).ToString().Split(":")(1).ToUpper Then
                    vHasInList = True
                    Exit For
                End If
            Next

            If ColumnArray(j).ToString().Split(":")(1).ToUpper = Column.Key.ToUpper Then
                'MsgBox(ColumnArray(j).ToString().Split(":")(1).ToUpper + vOrdinal1.ToString)
                vHasInList = True
                'Column.Position = vOrdinal1
                Column.Position = j
                'vOrdinal1 += 1
                Column.Visible = True
                Column.Width = ColumnArray(j).ToString().Split(":")(2).ToUpper
                'Exit For
            End If
            If vHasInList = False Then
                'vOrdinal += 1
                Column.Visible = False
                Column.Position = ColumnArray.Length - 1 '+ vOrdinal
            End If
        Next

        ' Next
    End Sub
    Public Sub ColumnSetInitialize(ByVal DataSet As DataSet, ByVal ParamArray GridColumns() As String)
        If DataSet.Tables.Count = 0 Then Return
        grd.SetDataBinding(DataSet, DataSet.Tables(0).TableName)
        grd.Hierarchical = True
        grd.RetrieveStructure(True)
        grd.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        grd.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        grd.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        'grd.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        grd.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        For Each c As System.Data.DataRelation In DataSet.Relations
            grd.Tables(c.ParentTable.TableName).SelfReferencingSettings.ParentDataMember = c.ParentColumns(0).ColumnName
            grd.Tables(c.ParentTable.TableName).SelfReferencingSettings.ChildDataMember = c.ChildColumns(0).ColumnName
        Next
        Dim ColumnPropertires As Array
        Dim Column As Janus.Windows.GridEX.GridEXColumn
        For J As Integer = 0 To grd.Tables.Count - 1
            Dim vTables As Janus.Windows.GridEX.GridEXTable = grd.Tables(J)
            If vTables.ChildTables.Count = 0 Then
                Dim vChildFormatStyle As New Janus.Windows.GridEX.GridEXFormatStyle
                vTables.RowFormatStyle = vChildFormatStyle
            End If
            For Each c As Janus.Windows.GridEX.GridEXColumn In vTables.Columns
                c.Visible = False
            Next
            vTables.HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables
            vTables.SelfReferencingSettings.ParentRootMode = Janus.Windows.GridEX.ParentRootMode.UseParentRootValue
            vTables.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
            vTables.HeaderLines = vHeaderLines
            For i As Integer = 0 To GridColumns(J).Split(";").Length - 1
                ColumnPropertires = GridColumns(J).Split(";")(i).ToString.Split(":")
                Column = vTables.Columns(ColumnPropertires(1))
                If Column Is Nothing Then Continue For
                Column.SelectableCells = Janus.Windows.GridEX.SelectableCells.All
                Column.Visible = True
                Column.Position = i
                Column.Caption = ColumnPropertires(0)
                Column.DataMember = ColumnPropertires(1)
                Column.Key = ColumnPropertires(1)
                Column.Width = ColumnPropertires(2)
                Column.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
                Column.FilterRowComparison = Janus.Windows.GridEX.ConditionOperator.Contains
                Column.SelectableCells = Janus.Windows.GridEX.SelectableCells.FilterRowCells
                Column.FilterEditType = Janus.Windows.GridEX.FilterEditType.SameAsEditType
                If ColumnPropertires.Length > 3 Then
                    Select Case Val(ColumnPropertires(3))
                        Case enmColumnType.TextBox
                            Column.ColumnType = Janus.Windows.GridEX.ColumnType.Text
                        Case enmColumnType.CheckBox
                            Column.ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox
                            Column.EditType = Janus.Windows.GridEX.EditType.CheckBox
                            Column.CheckBoxTrueValue = True
                            Column.CheckBoxTriState = False
                            Column.CheckBoxNullValue = DBNull.Value
                            Column.CheckBoxFalseValue = False
                    End Select
                End If
                If ColumnPropertires.Length > 4 AndAlso ColumnPropertires(enmColumnProperties.Format) <> "" Then
                    Column.FormatMode = Janus.Windows.GridEX.FormatMode.UseIFormattable
                    Column.FormatString = ColumnPropertires(enmColumnProperties.Format)
                    Column.TotalFormatString = ColumnPropertires(enmColumnProperties.Format)
                End If
                If ColumnPropertires.Length > 5 AndAlso ColumnPropertires(enmColumnProperties.NullValue) <> "" Then
                    If ColumnPropertires(enmColumnProperties.NullValue) <> "" Then
                        Column.NullText = ColumnPropertires(enmColumnProperties.NullValue)
                    Else
                        Column.NullText = ""
                    End If
                End If
                If ColumnPropertires.Length > 6 AndAlso ColumnPropertires(enmColumnProperties.Align) <> "" Then
                    If ColumnPropertires(enmColumnProperties.Align) <> "" Then
                        If ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "left" Then
                            Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                        ElseIf ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "right" Then
                            Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                        Else
                            Column.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                        End If
                    End If
                End If
                If ColumnPropertires.Length > 7 AndAlso ColumnPropertires(enmColumnProperties.FillFooter) <> "" Then
                    Column.AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                    grd.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
                    grd.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
                End If
            Next
        Next
    End Sub
    Public Sub setColumnDataSource(ByVal TableIndex As Integer, ByVal ColumnName As String, ByVal DataSource As DataTable, ByVal ValueMember As String, ByVal DisplayMember As String)
        If TableIndex = 0 Then
            If grd.RootTable.Columns.Contains(ColumnName) = False Then Return
            grd.RootTable.Columns(ColumnName).HasValueList = True
            grd.RootTable.Columns(ColumnName).EditType = Janus.Windows.GridEX.EditType.DropDownList
            grd.RootTable.Columns(ColumnName).ValueList.PopulateValueList(DataSource.DefaultView, ValueMember, DisplayMember)
            grd.RootTable.Columns(ColumnName).EditTarget = Janus.Windows.GridEX.EditTarget.Value
            grd.RootTable.Columns(ColumnName).CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            grd.RootTable.Columns(ColumnName).DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
        Else
            If grd.RootTable.ChildTables(TableIndex).Columns.Contains(ColumnName) = False Then Return
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).HasValueList = True
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).EditType = Janus.Windows.GridEX.EditType.DropDownList
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).ValueList.PopulateValueList(DataSource.DefaultView, ValueMember, DisplayMember)
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).EditTarget = Janus.Windows.GridEX.EditTarget.Value
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            grd.RootTable.ChildTables(TableIndex).Columns(ColumnName).DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
        End If
    End Sub
#Region "Print"
    Private Sub btnPaperSize_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnPaperSize.DropDownItemClicked
        btnPaperSize.Text = e.ClickedItem.Text
    End Sub
    Private Sub btnPageMode_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnPageMode.DropDownItemClicked
        btnPageMode.Text = e.ClickedItem.Text
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        RaiseEvent Print(Me, e)
        If Me.DataSource Is Nothing Then Return
        Array.Resize(ReportObjects, 0)
        If btnPageMode.Text = "Portrait" Then
            PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        Else
            PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        End If
        RaiseEvent Print(Me, e)

        Dim dtcopy As DataTable = Me.DataView.ToTable.Clone

        Dim x() As Janus.Windows.GridEX.GridEXRow = Me.RootTable.GridEX.GetDataRows
        Dim drv As DataRowView
        For j As Integer = 0 To x.Length - 1
            drv = x(j).DataRow
            dtcopy.ImportRow(drv.Row)
        Next

        'For Each Col As Janus.Windows.GridEX.GridEXColumn In Me.RootTable.Columns
        '   Dim d As String = Col.Key
        'Next

        Dim I As Integer
        Dim vColumns As String = ""
        For I = 0 To Me.Columns.Count - 1
            If Me.Columns.GetColumnInPosition(I).Key.ToLower <> "row" And Me.Columns.GetColumnInPosition(I).Visible = True And Me.Columns.GetColumnInPosition(I).Width > 15 Then
                vColumns &= IIf(vColumns = "", "", ";") & Me.Columns.GetColumnInPosition(I).Caption & ":" & Me.Columns.GetColumnInPosition(I).Key & ":" & Me.Columns.GetColumnInPosition(I).Width
                If Me.Columns.GetColumnInPosition(I).FormatString <> "" Then vColumns &= ":1"
            End If
        Next
        If vReportTitle.Trim = "" Then vReportTitle = grd.ParentForm.Text
        Report = New Report(vColumns, vReportTitle, dtcopy, vPaperOrientation, vPaperSize, vPageMargin.leftMargin, vPageMargin.topMargin, vPageMargin.rightMargin, vPageMargin.bottomMargin, "", False)
        If grd.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True Then
            For I = 0 To Me.Columns.Count - 1
                If Me.Columns(I).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum Then
                    Report.AddText(Utility.FormatMoney(Sum(Me.Columns(I).Key)), Report.enmTextAlign.Center, Report.enmParameterPlace.ReportFooter, Me.Columns(I).Key, 5, True)
                End If
            Next
        End If
        For I = 0 To ReportObjects.Length - 1
            If ReportObjects(I).ColumnName = "" Then
                Report.AddText(ReportObjects(I).Value,
                               ReportObjects(I).Align,
                               ReportObjects(I).Place,
                               ReportObjects(I).X, ReportObjects(I).Y, ReportObjects(I).Width, ReportObjects(I).Border)
            Else
                Report.AddText(ReportObjects(I).Value,
                               ReportObjects(I).Align,
                               ReportObjects(I).Place,
                               ReportObjects(I).ColumnName, ReportObjects(I).Y, ReportObjects(I).Border)
            End If
        Next
        Report.ShowDialog()
        Report.Dispose()
    End Sub
    'Public Function Sum(ByVal ColumnName As String) As Long
    '    Return Utility.NVL(CType(Me.DataSource, DataTable).Compute("sum(" & ColumnName & ")", ""), 0)
    'End Function
#End Region
    Public Property TotalRow() As Janus.Windows.GridEX.InheritableBoolean
        Get
            Return grd.TotalRow
        End Get
        Set(ByVal value As Janus.Windows.GridEX.InheritableBoolean)
            grd.TotalRow = value
        End Set
    End Property

    Public Property TotalRowPosition() As Janus.Windows.GridEX.TotalRowPosition
        Get
            Return grd.TotalRowPosition
        End Get
        Set(ByVal value As Janus.Windows.GridEX.TotalRowPosition)
            grd.TotalRowPosition = value
        End Set
    End Property

    Public Property Sum(ByVal ColumnName As String) As String
        Get
            'Dim vRow As Janus.Windows.GridEX.GridEXRow = grd.RootTable.GridEX.GetTotalRow
            'Return "1" 'vRow.Cells(ColumnName).Text
            Return Utility.NVL(CType(Me.DataSource, DataTable).Compute("sum(" & ColumnName & ")", ""), 0)
        End Get
        Set(ByVal value As String)
            Dim vRow As Janus.Windows.GridEX.GridEXRow = grd.GetTotalRow
            If Not (vRow Is Nothing) Then vRow.Cells(ColumnName).Text = value

        End Set
    End Property


    Public Sub MoveToRowIndex(ByVal rowIndex As Integer)
        grd.MoveToRowIndex(rowIndex)
    End Sub

    Public Property PaperType() As String
        Get
            Return btnPageMode.Text
        End Get
        Set(ByVal value As String)
            btnPageMode.Text = value
        End Set
    End Property
    Public Shadows ReadOnly Property Row(ByVal RowPosition As Integer) As Janus.Windows.GridEX.GridEXRow
        Get
            Return grd.GetRow(RowPosition)
            'Dim i As Janus.Windows.GridEX.GridEXRow = grd.GetRow(RowPosition)
            'i.Cells("x")
        End Get
    End Property

    Private Sub grd_FilterApplied(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.FilterApplied
        lblRecordCount.Text = "   " & "تعداد: " & grd.RecordCount & "   "
    End Sub
    Public Sub New()
        InitializeComponent()
        InitPaperCombo()
        grd.GroupByBoxVisible = True
    End Sub
    Private Sub mnJanusGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblRecordCount.Text = "   " & "تعداد: " & grd.RecordCount & "   "
    End Sub
    Private Sub InitPaperCombo()
        btnPaperSize.DropDownItems.Clear()
        Dim Item As ToolStripItem
        Item = btnPaperSize.DropDownItems.Add("DefaultPaperSize")
        Item.Tag = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        Item = btnPaperSize.DropDownItems.Add("Paper10x14")
        Item.Tag = CrystalDecisions.Shared.PaperSize.Paper10x14
        Item = btnPaperSize.DropDownItems.Add("Paper11x17")
        Item.Tag = CrystalDecisions.Shared.PaperSize.Paper11x17
        Item = btnPaperSize.DropDownItems.Add("PaperA3")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperA3
        Item = btnPaperSize.DropDownItems.Add("PaperA4")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperA4
        Item = btnPaperSize.DropDownItems.Add("PaperA4Small")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperA4Small
        Item = btnPaperSize.DropDownItems.Add("PaperA5")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperA5
        Item = btnPaperSize.DropDownItems.Add("PaperB4")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperB4
        Item = btnPaperSize.DropDownItems.Add("PaperB5")
        Item.Tag = CrystalDecisions.Shared.PaperSize.PaperB5
    End Sub
#Region "Report"
    Public Report As Report
    Private Structure stcReportObject
        Public Value As String
        Public Align As Report.enmTextAlign
        Public Place As Report.enmParameterPlace
        Public X As Integer
        Public Y As Integer
        Public Width As Integer
        Public Border As Boolean
        Public ColumnName As String
    End Structure

    Private vPaperOrientation As CrystalDecisions.Shared.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
    Private vPageMargin As CrystalDecisions.Shared.PageMargins = New CrystalDecisions.Shared.PageMargins(5, 5, 5, 5)
    Private vPaperSize As CrystalDecisions.Shared.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

    Public Property PaperOrientation() As CrystalDecisions.Shared.PaperOrientation
        Get
            Return vPaperOrientation
        End Get
        Set(ByVal value As CrystalDecisions.Shared.PaperOrientation)
            vPaperOrientation = value
        End Set
    End Property
    Public Property PageMargin() As CrystalDecisions.Shared.PageMargins
        Get
            Return vPageMargin
        End Get
        Set(ByVal value As CrystalDecisions.Shared.PageMargins)
            vPageMargin = value
        End Set
    End Property
    Public Property PaperSize() As CrystalDecisions.Shared.PaperSize
        Get
            Return vPaperSize
        End Get
        Set(ByVal value As CrystalDecisions.Shared.PaperSize)
            vPaperSize = value
        End Set
    End Property
    Public Sub AddText(ByVal Value As String,
                       ByVal Align As Report.enmTextAlign,
                       ByVal Place As Report.enmParameterPlace,
                       ByVal X As Integer, ByVal Y As Integer,
                       ByVal Width As Integer, Optional ByVal Border As Boolean = False)
        Array.Resize(ReportObjects, ReportObjects.Length + 1)
        Dim vItem As New stcReportObject
        vItem.Value = Value
        vItem.Align = Align
        vItem.Place = Place
        vItem.X = X
        vItem.Y = Y
        vItem.Width = Width
        vItem.Border = Border
        ReportObjects.SetValue(vItem, ReportObjects.Length - 1)
    End Sub
    Public Sub AddText(ByVal Value As String,
                     ByVal Align As Report.enmTextAlign,
                     ByVal Place As Report.enmParameterPlace,
                     ByVal ColumnName As String,
                     ByVal Y As Integer,
                     ByVal Border As Boolean)
        Array.Resize(ReportObjects, ReportObjects.Length + 1)
        Dim vItem As New stcReportObject
        vItem.Value = Value
        vItem.Align = Align
        vItem.Place = Place
        vItem.Y = Y
        vItem.ColumnName = ColumnName
        vItem.Border = Border
        ReportObjects.SetValue(vItem, ReportObjects.Length - 1)
    End Sub
#End Region
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            Try
                Dim dv As DataView = DirectCast(grd.DataSource, DataView)
                If dv.ToTable Is Nothing OrElse dv.ToTable.Rows.Count = 0 Then Exit Sub
            Catch ex As Exception
            End Try
            Try
                If Me.DataSource Is Nothing OrElse CType(Me.DataSource, DataTable).Rows.Count = 0 Then Exit Sub
            Catch ex As Exception
            End Try

            Dim vDialog As New SaveFileDialog
            vDialog.Filter = "Microsoft Excel Files (*.xls)|*.xls|Microsoft Excel Files (*.xlsx)|*.xlsx"
            If vDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Application.DoEvents()
                pnlWait.Visible = True
                Application.DoEvents()
                Dim grdExporter As New Janus.Windows.GridEX.Export.GridEXExporter
                grdExporter.GridEX = Me.RootTable.GridEX
                ExportExcel(grdExporter, vDialog.FileName, False)
            End If
        Catch ex As Exception
            MsgBox("transfer Data Error ")
        End Try
        pnlWait.Visible = False
    End Sub
    Public Sub ExportExcel(ByRef GridExporter As Janus.Windows.GridEX.Export.GridEXExporter, ByVal FileName As String, ByVal Flag As Boolean)
        Try

            Dim stream As IO.Stream
            GridExporter.IncludeFormatStyle = True
            stream = IO.File.Open(FileName.Replace("xlsx", "xls"), IO.FileMode.Create)
            GridExporter.IncludeChildTables = Flag
            GridExporter.IncludeCollapsedRows = False
            GridExporter.GridEX.UnCheckAllRecords()
            GridExporter.Export(stream)
            stream.Close()
            If Strings.Right(FileName, 4).ToUpper = "xlsx".ToUpper Then
                Dim vExl As New Excel
                vExl.Open(FileName.Replace("xlsx", "xls"))
                vExl.SaveAs2007(FileName)
                vExl.Close()
                System.IO.File.Delete(FileName.Replace("xlsx", "xls"))
            End If
            Process.Start(FileName)
        Catch ex As Exception
        End Try

    End Sub
    Private Sub btnSendToStimulsoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToStimulsoft.Click
        RaiseEvent Print(Me, e)
        If grd.DataSource Is Nothing Then
            MessageBox.Show("اطلاعاتی جهت ارسال به Exitی وجود ندارد")
            Exit Sub
        End If

        If strColumns(0) = "," Then strColumns = strColumns.Remove(0, 1)
        '================= ستونهای گروه بندی نباید از دی تی Delete شوند به خاطر بحت گروه بندی گزارش
        Dim i As Integer = 0
        If btnPageMode.Text = btnPageMode.DropDownItems.Item(0).Text Then
            PaperSizeGrd = 7.48
        Else
            PaperSizeGrd = 10.91
        End If

        Dim NewLine() As DataRow
        NewLine = dtItems.Select("name='NewRows'")

        '==========================
        If NewLine(0).Item("selected") = True Then
            PaperSizeGrd -= 0.4
        End If

        '================================
        Dim dt As DataTable
        If grd.DataSource.GetType.FullName = "System.Data.DataView" Then
            dt = CType(grd.DataSource, DataView).Table.Clone
        Else
            dt = CType(grd.DataSource, DataTable).Clone
        End If
        Dim x() As Janus.Windows.GridEX.GridEXRow = grd.RootTable.GridEX.GetDataRows

        'dt = grd.RootTable.GridEX.GetDataRows.Sort
        '= grd.RootTable.GridEX.GetLayout
        Dim drv As DataRowView
        For j As Integer = 0 To x.Length - 1
            drv = x(j).DataRow
            dt.ImportRow(drv.Row)
        Next
        '================================
        For i = 0 To dt.Columns.Count - 1
            If dt.Columns(i).ColumnName.ToUpper = "date".ToUpper Then dt.Columns(i).ColumnName = "_date".ToUpper
            If dt.Columns(i).ColumnName.ToUpper = "row".ToUpper Then dt.Columns(i).ColumnName = "_row".ToUpper

            'For k As Integer = 0 To strColumns.Split(",").Length - 1
            '    If dt.Columns.Contains(strColumns.Split(",")(k)) = False Then
            '        dt.Columns.Add(strColumns.Split(",")(k))
            '    End If
            'Next
        Next
        '================================ به ترتیب نمایش در گرید جانوس مرتب شود 
        'For k As Integer = 0 To strColumns.Split(",").Length - 1
        '    dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
        'Next


        '================================================
        Dim dttemp As New DataTable
        dttemp.Columns.Add("NAME", GetType(String)) : dttemp.Columns.Add("POSITION", GetType(Integer))
        Dim drTemp As DataRow
        For _C As Integer = 0 To strColumns.Split(",").Length - 1
            drTemp = dttemp.NewRow
            drTemp("NAME") = strColumns.Split(",")(_C)
            If grd.RootTable.Columns(strColumns.Split(",")(_C)) IsNot Nothing Then
                drTemp("POSITION") = grd.RootTable.Columns(strColumns.Split(",")(_C)).Position
            Else
                drTemp("POSITION") = 0
            End If
            dttemp.Rows.Add(drTemp)
        Next

        dttemp.DefaultView.Sort = "POSITION ASC"
        dttemp = dttemp.DefaultView.ToTable.Copy
        strColumns = ""

        For _C As Integer = 0 To dttemp.Rows.Count - 1
            strColumns &= "," + dttemp.Rows(_C).Item("NAME")
        Next

        If strColumns(0) = "," Then strColumns = strColumns.Remove(0, 1)
        '================================================


        For k As Integer = 0 To strColumns.Split(",").Length - 1
            If dt.Columns.Contains(strColumns.Split(",")(k)) Then
                dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
            Else
                dt.Columns.Add(strColumns.Split(",")(k))
                dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
            End If
        Next
        '================= به دست آوردن ستونهای گروه بندی 
        Dim strGroupColumns As String = ""
        Dim GroupTemp As String
        For i = 0 To grd.RootTable.Groups.Count - 1
            GroupTemp = grd.RootTable.Groups.Item(i).Column.Key
            If GroupTemp.ToUpper = "date".ToUpper Then GroupTemp = "_date".ToUpper
            If GroupTemp.ToUpper = "row".ToUpper Then GroupTemp = "_row".ToUpper
            strGroupColumns += "," + GroupTemp
        Next
        If strGroupColumns.Length > 0 Then strGroupColumns = strGroupColumns.Remove(0, 1)
        '================================
        'ستونهایی که باید Delete شوند به غیر از ستونهای گروه بندی شده 
        Dim strColForDel As String = ""
        Dim arrGroupColumn As String() = strGroupColumns.Split(",")
        Dim Countcolumn As Integer = dt.Columns.Count - 1
        Dim HasGroups As Boolean
        '================================ 
        Dim IndexForDelete As Integer = strColumns.Split(",").Length
        For k As Integer = IndexForDelete To Countcolumn
            strColForDel += "," + dt.Columns(k).Caption
        Next
        '================================ Delete شدن ستونهای اضافی 
        If strColForDel.Length > 0 Then
            strColForDel = strColForDel.Remove(0, 1)
            For k As Integer = 0 To strColForDel.Split(",").Length - 1
                dt.Columns.Remove(strColForDel.Split(",")(k))
            Next
        End If
        ''================== ' Delete کردن ستونهایی که غیر قابل نمایش شده اند
        i = 0
        Dim Width(dt.Columns.Count - 1) As Decimal ' در این مرحله ستونهای اضافی Delete شده اند 
        Dim GridWidth As Decimal, grdColumn As Janus.Windows.GridEX.GridEXColumn, ColGroupsNotShow As String = "", CountGroupNotShow As Integer = 0
        ' گروه هایی که قرار است در نمایش هم دیده نشود
        For Each grdColumn In grd.RootTable.Columns
            If grdColumn.Key.ToUpper = "date".ToUpper Then grdColumn.Key = "_date".ToUpper
            If grdColumn.Key.ToUpper = "row".ToUpper Then grdColumn.Key = "_row".ToUpper
            If grdColumn.IsGrouped = True Then
                'اگر گروه هست و نمایش داده شده است پس باید درنمایش Exitی هم دیده شود 
                If grdColumn.Visible = False Or grdColumn.Width = 0 Or grdColumn.Key.ToUpper = "SELECTED" Then
                    ColGroupsNotShow += "," + grdColumn.Key
                    CountGroupNotShow += 1
                    Width(i) = 0
                    i += 1
                Else
                    dt.Columns(grdColumn.Key).Caption = grdColumn.Caption
                    Width(i) = grdColumn.Width / 72 ' point to inch 
                    GridWidth += Width(i)
                    i += 1
                End If
            Else
                'گروه نیست 
                If grdColumn.Visible = False Or grdColumn.Width = 0 Or grdColumn.Key.ToUpper = "SELECTED" Then
                    If dt.Columns.Contains(grdColumn.Key) Then dt.Columns.Remove(grdColumn.Key)
                Else
                    dt.Columns(grdColumn.Key).Caption = grdColumn.Caption
                    Width(i) = grdColumn.Width / 72 ' point to inch 
                    GridWidth += Width(i)
                    i += 1
                End If
            End If
            'i += 1
        Next
        If ColGroupsNotShow.Length > 0 Then ColGroupsNotShow = ColGroupsNotShow.Remove(0, 1)
        '==================
        Dim LastColumnShowInReport As String = "" ' آخرین ستون دی تی که درچاپ استفاده میشود - علت استفاده از این است که ممکن است آخرین ستون واقعی گروه و ... باشد پس باید دستی Select شود
        For i = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(i).ColumnName.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If HasGroups = False Then LastColumnShowInReport = dt.Columns(i).ColumnName
        Next
        '==================
        Dim FirstColumnShowInReport As String = "" ' آخرین ستون دی تی که درچاپ استفاده میشود - علت استفاده از این است که ممکن است آخرین ستون واقعی گروه و ... باشد پس باید دستی Select شود
        For i = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(i).ColumnName.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If HasGroups = False Then FirstColumnShowInReport = dt.Columns(i).ColumnName : Exit For
        Next
        '================== به صورت درصدی محاسبه شود 
        For k As Integer = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(k).Caption.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If HasGroups = False Then
                Width(k) = (PaperSizeGrd * Width(k)) / GridWidth
            Else
                Width(k) = 0
            End If
        Next
        '====================
        Dim Row As Integer = 1
        If dt.Columns.Contains("InlineBuilt") = False Then dt.Columns.Add("InlineBuilt", GetType(Integer))
        For Each dr As DataRow In dt.Rows
            dr.Item("InlineBuilt") = Row
            Row += 1
        Next
        Dim DataView As DataView = dt.DefaultView
        'DataView.Sort = "InlineBuilt"
        '==================== create Report
        Dim Report As New StiReport
        Report.ScriptLanguage = StiReportLanguageType.VB
        Report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches
        Report.RegData("view", DataView)
        Report.Dictionary.Synchronize()
        Dim Page As StiPage = Report.Pages.Item(0)
        Page.Name = "Page1"
        Page.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        Page.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        Page.PaperSize = Printing.PaperKind.A4
        Page.RightToLeft = True
        Page.Orientation = StiPageOrientation.Landscape
        If btnPageMode.Text = btnPageMode.DropDownItems.Item(0).Text Then
            Page.Orientation = StiPageOrientation.Portrait
        Else
            Page.Orientation = StiPageOrientation.Landscape
        End If
        '===============================
        CreateHeader(Page, DataView, Width, ColGroupsNotShow, FirstColumnShowInReport)
        CreateHeaderGroups(Page, DataView, Width)
        CreateData(Page, DataView, Width, ColGroupsNotShow, FirstColumnShowInReport)
        CreateFooterGroups(Page, DataView, Width)
        CreateSummary(Page, DataView, Width)
        Report.Render(True)
        Report.Show()
    End Sub

    Private Sub btnSendToStimul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintFit.Click
        RaiseEvent Print(Me, e)
        If grd.DataSource Is Nothing Then
            MessageBox.Show("اطلاعاتی جهت ارسال به Exitی وجود ندارد")
            Exit Sub
        End If

        If strColumns(0) = "," Then strColumns = strColumns.Remove(0, 1)
        '================= ستونهای گروه بندی نباید از دی تی Delete شوند به خاطر بحت گروه بندی گزارش
        Dim i As Integer = 0
        If btnPageMode.Text = btnPageMode.DropDownItems.Item(0).Text Then
            PaperSizeGrd = 7.48
        Else
            PaperSizeGrd = 10.91
        End If

        Dim NewLine() As DataRow
        NewLine = dtItems.Select("name='NewRows'")

        '==========================
        If NewLine(0).Item("selected") = True Then
            PaperSizeGrd -= 0.4
        End If

        '================================
        Dim dt As DataTable
        If grd.DataSource.GetType.FullName = "System.Data.DataView" Then
            dt = CType(grd.DataSource, DataView).Table.Clone
        Else
            dt = CType(grd.DataSource, DataTable).Clone
        End If
        Dim x() As Janus.Windows.GridEX.GridEXRow = grd.RootTable.GridEX.GetDataRows

        'dt = grd.RootTable.GridEX.GetDataRows.Sort
        '= grd.RootTable.GridEX.GetLayout
        Dim drv As DataRowView
        For j As Integer = 0 To x.Length - 1
            drv = x(j).DataRow
            dt.ImportRow(drv.Row)
        Next
        '================================
        For i = 0 To dt.Columns.Count - 1
            If dt.Columns(i).ColumnName.ToUpper = "date".ToUpper Then dt.Columns(i).ColumnName = "_date".ToUpper
            If dt.Columns(i).ColumnName.ToUpper = "row".ToUpper Then dt.Columns(i).ColumnName = "_row".ToUpper

            'For k As Integer = 0 To strColumns.Split(",").Length - 1
            '    If dt.Columns.Contains(strColumns.Split(",")(k)) = False Then
            '        dt.Columns.Add(strColumns.Split(",")(k))
            '    End If
            'Next
        Next
        '================================ به ترتیب نمایش در گرید جانوس مرتب شود 
        'For k As Integer = 0 To strColumns.Split(",").Length - 1
        '    dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
        'Next


        '================================================
        Dim dttemp As New DataTable
        dttemp.Columns.Add("NAME", GetType(String)) : dttemp.Columns.Add("POSITION", GetType(Integer))
        Dim drTemp As DataRow
        For _C As Integer = 0 To strColumns.Split(",").Length - 1
            drTemp = dttemp.NewRow
            drTemp("NAME") = strColumns.Split(",")(_C)
            If grd.RootTable.Columns(strColumns.Split(",")(_C)) IsNot Nothing Then
                drTemp("POSITION") = grd.RootTable.Columns(strColumns.Split(",")(_C)).Position
            Else
                drTemp("POSITION") = 0
            End If
            dttemp.Rows.Add(drTemp)
        Next

        dttemp.DefaultView.Sort = "POSITION ASC"
        dttemp = dttemp.DefaultView.ToTable.Copy
        strColumns = ""

        For _C As Integer = 0 To dttemp.Rows.Count - 1
            strColumns &= "," + dttemp.Rows(_C).Item("NAME")
        Next

        If strColumns(0) = "," Then strColumns = strColumns.Remove(0, 1)
        '================================================


        For k As Integer = 0 To strColumns.Split(",").Length - 1
            If dt.Columns.Contains(strColumns.Split(",")(k)) Then
                dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
            Else
                dt.Columns.Add(strColumns.Split(",")(k))
                dt.Columns(strColumns.Split(",")(k)).SetOrdinal(k)
            End If
        Next
        '================= به دست آوردن ستونهای گروه بندی 
        Dim strGroupColumns As String = ""
        Dim GroupTemp As String
        For i = 0 To grd.RootTable.Groups.Count - 1
            GroupTemp = grd.RootTable.Groups.Item(i).Column.Key
            If GroupTemp.ToUpper = "date".ToUpper Then GroupTemp = "_date".ToUpper
            If GroupTemp.ToUpper = "row".ToUpper Then GroupTemp = "_row".ToUpper
            strGroupColumns += "," + GroupTemp
        Next
        If strGroupColumns.Length > 0 Then strGroupColumns = strGroupColumns.Remove(0, 1)
        '================================
        'ستونهایی که باید Delete شوند به غیر از ستونهای گروه بندی شده 
        Dim strColForDel As String = ""
        Dim arrGroupColumn As String() = strGroupColumns.Split(",")
        Dim Countcolumn As Integer = dt.Columns.Count - 1
        Dim HasGroups As Boolean
        '================================ 
        Dim IndexForDelete As Integer = strColumns.Split(",").Length
        For k As Integer = IndexForDelete To Countcolumn
            strColForDel += "," + dt.Columns(k).Caption
        Next
        '================================ Delete شدن ستونهای اضافی 
        If strColForDel.Length > 0 Then
            strColForDel = strColForDel.Remove(0, 1)
            For k As Integer = 0 To strColForDel.Split(",").Length - 1
                dt.Columns.Remove(strColForDel.Split(",")(k))
            Next
        End If
        ''================== ' Delete کردن ستونهایی که غیر قابل نمایش شده اند
        i = 0
        Dim Width(dt.Columns.Count - 1) As Decimal ' در این مرحله ستونهای اضافی Delete شده اند 
        Dim GridWidth As Decimal, grdColumn As Janus.Windows.GridEX.GridEXColumn, ColGroupsNotShow As String = "", CountGroupNotShow As Integer = 0
        ' گروه هایی که قرار است در نمایش هم دیده نشود
        For Each grdColumn In grd.RootTable.Columns
            If grdColumn.Key.ToUpper = "date".ToUpper Then grdColumn.Key = "_date".ToUpper
            If grdColumn.Key.ToUpper = "row".ToUpper Then grdColumn.Key = "_row".ToUpper
            If grdColumn.IsGrouped = True Then
                'اگر گروه هست و نمایش داده شده است پس باید درنمایش Exitی هم دیده شود 
                If grdColumn.Visible = False Or grdColumn.Width = 0 Or grdColumn.Key.ToUpper = "SELECTED" Then
                    ColGroupsNotShow += "," + grdColumn.Key
                    CountGroupNotShow += 1
                    Width(i) = 0
                    i += 1
                Else
                    dt.Columns(grdColumn.Key).Caption = grdColumn.Caption
                    Width(i) = grdColumn.Width / 72 ' point to inch 
                    GridWidth += Width(i)
                    i += 1
                End If
            Else
                'گروه نیست 
                If grdColumn.Visible = False Or grdColumn.Width = 0 Or grdColumn.Key.ToUpper = "SELECTED" Then
                    If dt.Columns.Contains(grdColumn.Key) Then dt.Columns.Remove(grdColumn.Key)
                Else
                    dt.Columns(grdColumn.Key).Caption = grdColumn.Caption
                    Width(i) = grdColumn.Width / 72 ' point to inch 
                    GridWidth += Width(i)
                    i += 1
                End If
            End If
            'i += 1
        Next
        If ColGroupsNotShow.Length > 0 Then ColGroupsNotShow = ColGroupsNotShow.Remove(0, 1)
        '==================
        Dim LastColumnShowInReport As String = "" ' آخرین ستون دی تی که درچاپ استفاده میشود - علت استفاده از این است که ممکن است آخرین ستون واقعی گروه و ... باشد پس باید دستی Select شود
        For i = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(i).ColumnName.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If HasGroups = False Then LastColumnShowInReport = dt.Columns(i).ColumnName
        Next
        '==================
        Dim FirstColumnShowInReport As String = "" ' آخرین ستون دی تی که درچاپ استفاده میشود - علت استفاده از این است که ممکن است آخرین ستون واقعی گروه و ... باشد پس باید دستی Select شود
        For i = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(i).ColumnName.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If HasGroups = False Then FirstColumnShowInReport = dt.Columns(i).ColumnName : Exit For
        Next
        '================== به صورت درصدی محاسبه شود 
        Dim X1 As Decimal = 0
        Dim k1 As Integer = 0
        For k1 = 0 To dt.Columns.Count - 1
            HasGroups = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper = dt.Columns(k1).Caption.ToUpper Then
                    HasGroups = True
                    Exit For
                End If
            Next
            If X1 + Width(k1) > (PaperSizeGrd) Then
                Width(k1) = (PaperSizeGrd - X1)
                Exit For
            End If

            If HasGroups = False Then
                X1 += Width(k1) ' = '(PaperSizeGrd * Width(k)) / GridWidth
            Else
                Width(k1) = 0
            End If
        Next
        For i1 As Integer = k1 + 1 To dt.Columns.Count - 1
            Width(i1) = -1
        Next
        '====================
        Dim Row As Integer = 1
        If dt.Columns.Contains("InlineBuilt") = False Then dt.Columns.Add("InlineBuilt", GetType(Integer))
        For Each dr As DataRow In dt.Rows
            dr.Item("InlineBuilt") = Row
            Row += 1
        Next
        Dim DataView As DataView = dt.DefaultView
        'DataView.Sort = "InlineBuilt"
        '==================== create Report
        Dim Report As New StiReport
        Report.ScriptLanguage = StiReportLanguageType.VB
        Report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches
        Report.RegData("view", DataView)
        Report.Dictionary.Synchronize()
        Dim Page As StiPage = Report.Pages.Item(0)
        Page.Name = "Page1"
        Page.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        Page.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        Page.PaperSize = Printing.PaperKind.A4
        Page.RightToLeft = True
        Page.Orientation = StiPageOrientation.Landscape
        If btnPageMode.Text = btnPageMode.DropDownItems.Item(0).Text Then
            Page.Orientation = StiPageOrientation.Portrait
        Else
            Page.Orientation = StiPageOrientation.Landscape
        End If
        '===============================
        CreateHeader(Page, DataView, Width, ColGroupsNotShow, FirstColumnShowInReport)
        CreateHeaderGroups(Page, DataView, Width)
        CreateData(Page, DataView, Width, ColGroupsNotShow, FirstColumnShowInReport)
        CreateFooterGroups(Page, DataView, Width)
        CreateSummary(Page, DataView, Width)
        Report.Render(True)
        Report.Show()
    End Sub

    Public Sub CreateData(ByRef page As StiPage, ByVal dataview As DataView, ByVal Width() As Decimal, ByVal ColGroupsNotShow As String, ByVal FirstColumnShowInReport As String)
        Dim Databand As New StiDataBand
        Databand.DataSourceName = "view"
        Databand.Height = 1
        Databand.Name = "DataBand"
        Databand.RightToLeft = True
        Databand.CanShrink = True
        Databand.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 2, PaperSizeGrd, 0.3)
        Databand.Border.Side = StiBorderSides.None
        Databand.Sort = New System.String() {"ASC", "InlineBuilt"}
        page.Components.Add(Databand)

        Dim NewLine() As DataRow
        NewLine = dtItems.Select("name='NewRows'")
        '==========================
        If NewLine(0).Item("selected") = True Then
            Dim DataText As New StiText(New RectangleD(PaperSizeGrd, 0, 0.4, 0.3))
            DataText.Text.Value = "{Line}"
            DataText.Name = "DataText_newLine"
            DataText.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Regular)
            DataText.WordWrap = True
            DataText.CanGrow = True
            DataText.HorAlignment = StiTextHorAlignment.Center
            DataText.VertAlignment = StiVertAlignment.Center
            DataText.TextFormat = New Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 0, ",", 3, True, False, " ")

            DataText.Margins = New Stimulsoft.Report.Components.StiMargins(5, 5, 0, 0)
            DataText.Border.Side = StiBorderSides.Left
            DataText.Border.Side += StiBorderSides.Top
            DataText.Border.Side += StiBorderSides.Bottom
            DataText.Border.Size = 0.01
            DataText.GrowToHeight = True
            DataText.WordWrap = True
            DataText.Page = page
            DataText.Parent = Databand
            Databand.Components.Add(DataText)

        End If
        Dim Pos As Decimal = PaperSizeGrd  ' Databand.Width
        Dim NameIndex As Integer = 1
        Dim Column As DataColumn
        Dim HasGroupsNotShow As Boolean
        Dim j As Int32 = 0
        For i As Integer = 0 To dataview.Table.Columns.Count - 2
            Column = dataview.Table.Columns(i)
            If Not grd.RootTable.Columns.Contains(Column.ColumnName) Then Continue For

            HasGroupsNotShow = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper() = Column.Caption.ToUpper() Then
                    HasGroupsNotShow = True
                    Exit For
                End If
            Next
            If HasGroupsNotShow = True Or Width(j) = 0 Then Continue For

            If Width(j) = -1 Then Exit For
            Pos = Pos - Width(j)

            Dim DataText As New StiText(New RectangleD(Pos, 0, Width(j), 0.3))
            DataText.Text.Value = "{view." + Column.ColumnName + "}"
            DataText.Name = "DataText" + NameIndex.ToString()
            DataText.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Regular)
            DataText.WordWrap = True
            DataText.CanGrow = True
            DataText.HorAlignment = grd.RootTable.Columns(Column.ColumnName).RightToLeft
            DataText.VertAlignment = StiVertAlignment.Center
            DataText.TextFormat = New Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 0, ",", 3, True, False, " ")

            DataText.Margins = New Stimulsoft.Report.Components.StiMargins(5, 5, 0, 0)

            DataText.Border.Side = StiBorderSides.Left
            DataText.Border.Side += StiBorderSides.Top
            DataText.Border.Side += StiBorderSides.Bottom
            DataText.Border.Size = 0.01
            '================
            DataText.GrowToHeight = True
            DataText.WordWrap = True
            DataText.Page = page
            DataText.Parent = Databand
            Databand.Components.Add(DataText)
            NameIndex = NameIndex + 1
            j += 1
        Next
    End Sub

    Public Sub CreateHeader(ByRef page As StiPage, ByVal dataview As DataView, ByVal Width() As Decimal, ByVal ColGroupsNotShow As String, ByVal FirstColumnShowInReport As String)
        Dim PageHeader1 As New Stimulsoft.Report.Components.StiPageHeaderBand()
        PageHeader1.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0, PaperSizeGrd, 2)
        PageHeader1.Name = "PageHeader1"
        PageHeader1.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        PageHeader1.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 215, 227, 188))
        PageHeader1.Page = page
        PageHeader1.Parent = page
        page.Components.Add(PageHeader1)
        '============================
        Dim lblReportDate As New Stimulsoft.Report.Components.StiText()
        lblReportDate.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(1, 0, 0.7, 0.3)
        lblReportDate.Name = "lblReportDate"
        lblReportDate.Text.Value = "تاریخ گزارش"
        lblReportDate.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        lblReportDate.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        lblReportDate.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        lblReportDate.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        lblReportDate.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        lblReportDate.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        lblReportDate.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(lblReportDate)

        '// 
        '// txtReportDate
        '// 
        Dim txtReportDate As New Stimulsoft.Report.Components.StiText()
        txtReportDate.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0, 1, 0.3)
        txtReportDate.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        txtReportDate.Name = "txtReportDate"
        txtReportDate.Text.Value = Solar.GetDate(True) ' += New Stimulsoft.Report.Events.StiGetValueEventHandler(txtReportDate__GetValue)
        txtReportDate.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        txtReportDate.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        txtReportDate.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        txtReportDate.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        txtReportDate.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        txtReportDate.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        txtReportDate.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(txtReportDate)
        '====================================
        Dim txtReportTitle As New Stimulsoft.Report.Components.StiText()
        txtReportTitle.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 1.03, PaperSizeGrd, 0.37)
        txtReportTitle.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        txtReportTitle.Name = "txtReportTitle"
        txtReportTitle.Text.Value = IIf(ReportTitle.Trim = "", Me.ParentForm.Text, ReportTitle)
        txtReportTitle.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        txtReportTitle.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        txtReportTitle.Font = New System.Drawing.Font("B Titr", 12.0F, System.Drawing.FontStyle.Bold)
        txtReportTitle.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        txtReportTitle.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        txtReportTitle.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(txtReportTitle)
        '============================
        Dim txtReportTime As New Stimulsoft.Report.Components.StiText()
        txtReportTime.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0.3, 1, 0.3)
        txtReportTime.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        txtReportTime.Name = "txtReportTime"
        txtReportTime.Text.Value = Solar.GetTime(True)
        txtReportTime.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        txtReportTime.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        txtReportTime.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        txtReportTime.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        txtReportTime.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        txtReportTime.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        txtReportTime.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(txtReportTime)
        '============================
        If strFilter Is Nothing Then strFilter = ""
        If Not strFilter Is Nothing OrElse strFilter.Trim <> "" Then
            Dim txtReportFilter As New Stimulsoft.Report.Components.StiText()
            txtReportFilter.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 1.4, PaperSizeGrd, 0.37)
            txtReportFilter.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right
            txtReportFilter.Name = "txtReportfilter"
            txtReportFilter.Text.Value = strFilter.Trim()
            txtReportFilter.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            txtReportFilter.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
            txtReportFilter.Font = New System.Drawing.Font("B nazanin", 9.0F, System.Drawing.FontStyle.Bold)
            txtReportFilter.Margins = New Stimulsoft.Report.Components.StiMargins(5, 5, 0, 0)
            txtReportFilter.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
            txtReportFilter.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
            txtReportFilter.WordWrap = True
            txtReportFilter.GrowToHeight = True
            PageHeader1.Components.Add(txtReportFilter)
        End If
        '============================
        Dim lblReportTime As New Stimulsoft.Report.Components.StiText()
        lblReportTime.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(1, 0.3, 0.7, 0.3)
        lblReportTime.Name = "lblReportTime"
        lblReportTime.Text.Value = "ساعت گزارش"
        lblReportTime.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        lblReportTime.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        lblReportTime.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        lblReportTime.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        lblReportTime.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        lblReportTime.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        lblReportTime.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(lblReportTime)
        '===========================
        Dim lblPageitle As New Stimulsoft.Report.Components.StiText()
        lblPageitle.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(1, 0.6, 0.7, 0.3)
        lblPageitle.Name = "lblPageitle"
        lblPageitle.Text.Value = "صفحه"
        lblPageitle.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        lblPageitle.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        lblPageitle.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        lblPageitle.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        lblPageitle.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        lblPageitle.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        lblPageitle.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(lblPageitle)
        '===========================
        Dim txtPagefrom As New Stimulsoft.Report.Components.StiText()
        txtPagefrom.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0.7, 0.6, 0.3, 0.3)
        txtPagefrom.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        txtPagefrom.Name = "txtPagefrom"
        txtPagefrom.Text.Value = "{PageNumber}"
        txtPagefrom.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        txtPagefrom.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        txtPagefrom.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        txtPagefrom.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        txtPagefrom.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        txtPagefrom.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        txtPagefrom.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables
        txtPagefrom.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(txtPagefrom)
        '===========================
        Dim lblPage As New Stimulsoft.Report.Components.StiText()
        lblPage.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0.5, 0.6, 0.2, 0.3)
        lblPage.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        lblPage.Name = "lblPage"
        lblPage.Text.Value = "از"
        lblPage.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        lblPage.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        lblPage.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        lblPage.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        lblPage.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        lblPage.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        lblPage.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(lblPage)
        '=========================== 
        Dim txtPageTo As New Stimulsoft.Report.Components.StiText()
        txtPageTo.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0.6, 0.5, 0.3)
        txtPageTo.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
        txtPageTo.Name = "txtPageTo"
        txtPageTo.Text.Value = "{TotalPageCount}"
        txtPageTo.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables
        txtPageTo.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
        txtPageTo.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
        txtPageTo.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
        txtPageTo.Font = New System.Drawing.Font("B Nazanin", 9.0F, System.Drawing.FontStyle.Bold)
        txtPageTo.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
        txtPageTo.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
        txtPageTo.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
        PageHeader1.Components.Add(txtPageTo)
        '==============================
        Dim dtImages As New DataTable("dtImages")
        dtImages.Columns.Add("Arm", GetType(Byte()))
        Dim drImage As DataRow = dtImages.NewRow

        Dim x As Double
        If page.Orientation = StiPageOrientation.Landscape Then
            x = 4.89
        Else
            x = 3.29
        End If
        If IO.File.Exists(Globals.ImagePath & "\PrinterArm.jpg") Then

            drImage.Item("Arm") = IO.File.ReadAllBytes(Globals.ImagePath & "\PrinterArm.jpg")
            dtImages.Rows.Add(drImage)
            Dim imgArm As New Stimulsoft.Report.Components.StiImage()
            imgArm.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(x, 0, 0.85, 0.63)
            imgArm.Name = "imgArm"
            imgArm.Stretch = True
            imgArm.File = Globals.ImagePath & "\PrinterArm.jpg"
            imgArm.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            imgArm.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
            PageHeader1.Components.Add(imgArm)
        End If
        '==============================
        'Dim NewLine As New System.Windows.Forms.ToolStripMenuItem
        'NewLine = tspItems.DropDownItems.Item("NewRows")

        Dim NewLine() As DataRow
        NewLine = dtItems.Select("name='NewRows'")

        '==========================
        If NewLine(0).Item("selected") = True Then

            Dim HeaderText As New Stimulsoft.Report.Components.StiText()
            HeaderText.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(PaperSizeGrd, 1.7, 0.4 - 0.01, 0.3)
            HeaderText.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
            HeaderText.Name = "HeaderText_newLine"
            HeaderText.Text.Value = "ردیف"
            HeaderText.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression
            HeaderText.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center

            HeaderText.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 195, 190, 150))
            HeaderText.Font = New System.Drawing.Font("B Titr", 8.0F, System.Drawing.FontStyle.Bold)
            HeaderText.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
            HeaderText.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
            HeaderText.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)

            HeaderText.Border.Side = StiBorderSides.Left
            HeaderText.Border.Side += StiBorderSides.Top
            HeaderText.Border.Side += StiBorderSides.Bottom
            'HeaderText.Border.Size = StiBorderSides.All
            HeaderText.Border.Size = 0.01

            HeaderText.VertAlignment = StiVertAlignment.Center
            HeaderText.HorAlignment = StiTextHorAlignment.Center

            HeaderText.WordWrap = True
            HeaderText.CanGrow = True
            HeaderText.CanBreak = True
            HeaderText.GrowToHeight = True
            HeaderText.Page = page
            HeaderText.Parent = PageHeader1
            PageHeader1.Components.Add(HeaderText)
        End If
        '==========================
        Dim Pos As Decimal = PaperSizeGrd  ' Databand.Width
        Dim NameIndex As Integer = 1
        Dim Column As DataColumn
        '===========================
        Dim HasGroupsNotshow As Boolean
        Dim j As Int32 = 0
        For I As Integer = 0 To dataview.Table.Columns.Count - 2
            Column = dataview.Table.Columns(I)
            If Not grd.RootTable.Columns.Contains(Column.ColumnName) Then Continue For

            HasGroupsNotshow = False
            For Each str As String In ColGroupsNotShow.Split(",")
                If str.ToUpper() = Column.Caption.ToUpper() Then
                    HasGroupsNotshow = True
                    Exit For
                End If
            Next
            If HasGroupsNotshow = True Then Continue For
            If Width(j) = -1 Then Exit For
            Pos = Pos - Width(j)

            Dim HeaderText As New Stimulsoft.Report.Components.StiText()
            HeaderText.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(Pos, 1.7, Width(j), 0.3)
            HeaderText.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center
            HeaderText.Name = "HeaderText" + NameIndex.ToString()
            HeaderText.Text.Value = Column.Caption
            HeaderText.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression
            HeaderText.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
            'If FirstColumnShowInReport.ToUpper = Column.ColumnName.ToUpper Then
            'HeaderText.Border.Side = StiBorderSides.Left
            'HeaderText.Border.Side += StiBorderSides.Top
            'HeaderText.Border.Side += StiBorderSides.Bottom
            'HeaderText.Border.Side += StiBorderSides.Right
            'Else
            HeaderText.Border.Side = StiBorderSides.All
            HeaderText.Border.Size = 0.01

            'End If

            HeaderText.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 195, 190, 150))
            HeaderText.Font = New System.Drawing.Font("B Titr", 8.0F, System.Drawing.FontStyle.Bold)
            HeaderText.Margins = New Stimulsoft.Report.Components.StiMargins(10, 0, 0, 0)
            HeaderText.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
            HeaderText.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(False, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
            HeaderText.WordWrap = True
            HeaderText.CanGrow = True
            HeaderText.CanBreak = True
            HeaderText.GrowToHeight = True
            HeaderText.Page = page
            HeaderText.Parent = PageHeader1
            PageHeader1.Components.Add(HeaderText)
            NameIndex = NameIndex + 1
            j += 1
        Next
    End Sub

    Public Sub CreateHeaderGroups(ByRef page As StiPage, ByVal dataview As DataView, ByVal Width() As Decimal)
        Dim GroupsPosition As Decimal = 2.2

        For i As Integer = 0 To grd.RootTable.Groups.Count - 1
            Dim GroupHeaderBand1 As New Stimulsoft.Report.Components.StiGroupHeaderBand()
            GroupHeaderBand1.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, GroupsPosition, PaperSizeGrd, 0.3)
            Dim v1 As New Stimulsoft.Report.Components.StiGroupHeaderBand

            v1.Condition.Value = "{view." + grd.RootTable.Groups.Item(i).Column.Key + "}"  'grd.RootTable.Groups.Item(i).Column.Key
            GroupHeaderBand1.Condition.Value = v1.Condition.Value
            GroupHeaderBand1.Name = "GroupHeaderBand" + i.ToString()
            GroupHeaderBand1.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            GroupHeaderBand1.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 229, 224, 100 + i * 2))
            GroupHeaderBand1.Border.Side = StiBorderSides.All

            Dim txtGroups As New Stimulsoft.Report.Components.StiText()
            txtGroups.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0, PaperSizeGrd, 0.3)
            txtGroups.Name = "GroupHeaderBand_txt_" + i.ToString()
            txtGroups.Text.Value = Space(i * 5) + grd.RootTable.Groups.Item(i).Column.Caption + " : " + "{view." + grd.RootTable.Groups.Item(i).Column.Key + "}"
            txtGroups.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression
            txtGroups.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
            txtGroups.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            txtGroups.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
            txtGroups.Font = New System.Drawing.Font("B Nazanin", 10.0F, System.Drawing.FontStyle.Bold)
            txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0)
            txtGroups.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
            txtGroups.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(True, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
            txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(0, 5, 0, 0)
            txtGroups.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 229, 224, 100 + i * 2))
            txtGroups.Border.Side = StiBorderSides.Bottom
            txtGroups.Border.Side += StiBorderSides.Top
            GroupHeaderBand1.Components.Add(txtGroups)
            GroupsPosition += 0.3
            page.Components.Add(GroupHeaderBand1)
        Next
    End Sub

    Private Sub grd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grd.KeyPress
        'e.KeyChar = Convert.ToChar(e.KeyChar.ToString.Replace("ک", "ك").Replace("ی", "ي"))
        e.KeyChar = Convert.ToChar(e.KeyChar.ToString.Replace("ی", "ي"))
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        For Each dr As DataRow In CType(grd.DataSource, DataTable).Rows
            dr.Item("SELECTED") = chkSelectAll.Checked
        Next
    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        'Dim frm As New frmGrid(0, 200, 200, dtItems)
        'frm.ShowDialog()
        'Dim grdColumn As Janus.Windows.GridEX.GridEXColumn
        'Dim dr() As DataRow
        'For Each grdColumn In grd.RootTable.Columns
        '    dr = dtItems.Select("NAME='" & grdColumn.Key.ToString() & "'")
        '    If dr.Length > 0 Then
        '        grdColumn.Visible = dr(0).Item("SELECTED")
        '    End If
        'Next
    End Sub

    Private Sub CreateSummary(ByRef page As StiPage, ByVal dataview As DataView, ByVal Width() As Decimal)
        Dim pageSummary As New Stimulsoft.Report.Components.StiReportSummaryBand
        pageSummary.Name = "pageSummary"
        pageSummary.Page = page
        pageSummary.Parent = page
        pageSummary.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0, PaperSizeGrd, 0.3)
        pageSummary.Border.Side = StiBorderSides.All
        pageSummary.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(150, 150, 150, 200))
        page.Components.Add(pageSummary)

        '============================
        Dim Pos As Decimal = PaperSizeGrd
        Dim NameIndex As Integer = 1
        Dim Column As DataColumn
        '===========================
        Dim strsum As String
        Dim formatString As String
        Dim vColumn As New Janus.Windows.GridEX.GridEXColumn
        Dim j As Int32 = 0
        For I As Integer = 0 To dataview.Table.Columns.Count - 2
            Column = dataview.Table.Columns(I)
            If Not grd.RootTable.Columns.Contains(Column.ColumnName) Then Continue For

            'strsum = ""
            'If Column.DataType Is GetType(System.Int32) Or _
            '                    Column.DataType Is GetType(System.Int16) Or _
            '                    Column.DataType Is GetType(System.Int64) Or _
            '                    Column.DataType Is GetType(System.Byte) Or _
            '                    Column.DataType Is GetType(System.Decimal) Or _
            '                    Column.DataType Is GetType(System.Double) Then
            '    strsum = "{Sum(DataBand,view." & Column.ColumnName & ")}"
            'End If
            '====================
            formatString = ""
            strsum = ""
            For Each vColumn In grd.RootTable.Columns
                If vColumn.Key.ToString.ToUpper = Column.ColumnName.ToString.ToUpper Then
                    formatString = vColumn.FormatString
                    Exit For
                End If
            Next
            If formatString.IndexOf("#") >= 0 Then
                strsum = "{Sum(DataBand,view." & Column.ColumnName & ")}"
            End If
            '====================
            If Width(j) = -1 Then Exit For

            Pos = Pos - Width(j)
            Dim txtGroups As New Stimulsoft.Report.Components.StiText()
            txtGroups.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(Pos, 0, Width(j), 0.3)
            txtGroups.Name = "summary_text_" + I.ToString()
            txtGroups.Text.Value = strsum
            txtGroups.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression
            txtGroups.TextFormat = New Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 0, ",", 3, True, False, " ")
            txtGroups.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
            txtGroups.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            txtGroups.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
            txtGroups.Font = New System.Drawing.Font("B Nazanin", 10.0F, System.Drawing.FontStyle.Bold)
            txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(5, 5, 0, 0)
            txtGroups.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
            txtGroups.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(True, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
            txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(0, 5, 0, 0)
            txtGroups.Border.Side = StiBorderSides.None
            pageSummary.Components.Add(txtGroups)
            NameIndex = NameIndex + 1
            j += 1
        Next
    End Sub

    Public Sub CreateFooterGroups(ByRef page As StiPage, ByVal dataview As DataView, ByVal Width() As Decimal)
        For i As Integer = 0 To grd.RootTable.Groups.Count - 1
            Dim GroupFooterBand1 As New Stimulsoft.Report.Components.StiGroupFooterBand()
            GroupFooterBand1.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(0, 0, PaperSizeGrd, 0.3)
            GroupFooterBand1.Name = "GroupFooterBand" + i.ToString()
            GroupFooterBand1.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
            GroupFooterBand1.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 229, 224, 100 + i * 2))
            GroupFooterBand1.Border.Side = StiBorderSides.All
            Dim Pos As Decimal = PaperSizeGrd
            Dim NameIndex As Integer = 1
            Dim Column As DataColumn
            Dim strSum As String
            Dim formatString As String
            Dim vColumn As New Janus.Windows.GridEX.GridEXColumn
            Dim j As Int32 = 0
            For m As Integer = 0 To dataview.Table.Columns.Count - 2
                Column = dataview.Table.Columns(m)
                If Not grd.RootTable.Columns.Contains(Column.ColumnName) Then Continue For

                formatString = ""
                strSum = ""
                For Each vColumn In grd.RootTable.Columns
                    If vColumn.Key.ToString.ToUpper = Column.ColumnName.ToString.ToUpper Then
                        formatString = vColumn.FormatString
                        Exit For
                    End If
                Next

                If formatString.IndexOf("#") >= 0 Then
                    strSum = "{Sum(DataBand,view." & Column.ColumnName & ")}"
                End If

                If Width(j) = -1 Then Exit For
                Pos = Pos - Width(j)
                Dim txtGroups As New Stimulsoft.Report.Components.StiText()
                txtGroups.ClientRectangle = New Stimulsoft.Base.Drawing.RectangleD(Pos, 0, Width(j), 0.3)
                txtGroups.Name = "GroupFooterBand_txt_" + i.ToString() + "_" + m.ToString()
                txtGroups.Text.Value = strSum
                txtGroups.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression
                txtGroups.TextFormat = New Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 0, ",", 3, True, False, " ")
                txtGroups.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center
                txtGroups.Border = New Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, False, 4, New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black))
                txtGroups.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent)
                txtGroups.Font = New System.Drawing.Font("B Nazanin", 10.0F, System.Drawing.FontStyle.Bold)
                txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(5, 5, 0, 0)
                txtGroups.TextBrush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black)
                txtGroups.TextOptions = New Stimulsoft.Base.Drawing.StiTextOptions(True, False, False, 0.0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None)
                txtGroups.Margins = New Stimulsoft.Report.Components.StiMargins(0, 5, 0, 0)
                txtGroups.Brush = New Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 229, 224, 100 + i * 2))
                txtGroups.Border.Side = StiBorderSides.Bottom
                txtGroups.Border.Side += StiBorderSides.Top
                GroupFooterBand1.Components.Add(txtGroups)
                NameIndex = NameIndex + 1
                j += 1
            Next
            page.Components.Add(GroupFooterBand1)
        Next
    End Sub

    Private Sub mnJanusGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.C Or e.Control And e.KeyCode = Keys.Insert Then
            My.Computer.Clipboard.SetText(grd.CurrentRow.Cells(grd.CurrentColumn.Index).Value.ToString())
        End If
    End Sub

    Private Function LoadInitGrid() As DataRow
        'SQL.CurrentUserId & _
        '        Dim Dll_Name As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString()
        Dim DR As DataRow
        Try
            Dim strsql As String = " SELECT * FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND USE_ID=" & SQL.CurrentUserId &
                                   " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "' AND (ISNULL(STR_INIT,'')<>'' OR ISNULL(GROUP_COLUMNS,'')<>'')" &
                                IIf(vType > 0, " AND TYPE=" & vType, "")
            DR = SQL.ExecuteDataRow(strsql, Nothing)
            If DR Is Nothing Then
                strsql = " SELECT * FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND USE_ID=" & SQL.CurrentUserId &
                         " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "'" &
                         " AND TYPE=" & vType
                DR = SQL.ExecuteDataRow(strsql, Nothing)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
        Return DR
    End Function

    Private Sub CreateGroups()
        If Not vdrLoadInitGrid Is Nothing Then
            If vdrLoadInitGrid.Item("GROUP_COLUMNS") <> "" Then
                grd.RootTable.Groups.Clear()
                Dim GroupColumns() As String = vdrLoadInitGrid.Item("GROUP_COLUMNS").ToString.Split(";")
                If GroupColumns.Length > 0 Then
                    grd.RootTable.Groups.Clear()

                    For GroupIndex As Integer = 0 To GroupColumns.Length - 1
                        grd.RootTable.Groups.Add(GroupColumns(GroupIndex))
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnDeleteTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTemplate.Click
        DeleteSetting()
    End Sub

    Private Sub btnSaveTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTemplate.Click
        If vType = 0 Then Return
        Dim str As String
        Dim num As Integer
        Dim column As Janus.Windows.GridEX.GridEXColumn
        Dim num3 As Integer
        str = ""


        Me.vUserGridColumns = ""
        num = Me.RootTable.Columns.Count
        num3 = Me.RootTable.Columns.Count - 1
        Dim strGroups As String = ""
        For i As Integer = 0 To Me.RootTable.Columns.Count - 1
            column = Me.RootTable.Columns.GetColumnInPosition(i)

            Dim strColumnType As String = ""
            If column.Visible = True Or column.IsGrouped Then

                Select Case column.ColumnType
                    Case Janus.Windows.GridEX.ColumnType.Text
                        strColumnType = enmColumnType.TextBox
                    Case Janus.Windows.GridEX.ColumnType.CheckBox
                        strColumnType = enmColumnType.CheckBox
                    Case Janus.Windows.GridEX.EditType.DropDownList
                        strColumnType = enmColumnType.ComboBox
                    Case Janus.Windows.GridEX.ColumnType.BoundImage
                        strColumnType = enmColumnType.Image
                    Case Janus.Windows.GridEX.ColumnType.BoundImage
                        strColumnType = enmColumnType.Button
                End Select
                vUserGridColumns += column.Caption & ":" & column.DataMember & ":" & column.Width & ":" & strColumnType & IIf(column.FormatString = "", ";", ":" & column.FormatString & ":::1;")
            End If
            If column.IsGrouped = True Then strGroups &= column.DataMember & ";"
        Next



        vUserGridColumns = vUserGridColumns.Substring(0, (vUserGridColumns.Length - 1))
        If strGroups.Length > 0 Then strGroups = strGroups.Substring(0, (strGroups.Length - 1))
        Dim value As String
        value = Me.ParentForm.Name + Me.Name + "%" + vUserGridColumns & "%" & strGroups
        '============================
        Dim vGrid As New GridInit
        Dim strsql As String = " DELETE FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND  USE_ID=" & SQL.CurrentUserId &
                               " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "'" & " AND TYPE=" & vType
        SQL.ExecuteNonQuery(strsql, Nothing)
        vGrid.CONTROL_NAME = Me.Name
        vGrid.PARENT_FORM = Me.ParentForm.ToString.Split(",")(0)
        vGrid.GROUP_COLUMNS = strGroups
        vGrid.STR_INIT = vUserGridColumns
        If vType > 0 Then vGrid.TYPE = vType
        vGrid.USE_ID = SQL.CurrentUserId
        vGrid.Insert(Nothing)

        '============================
    End Sub

    Private Sub DeleteSetting()
        If MessageBox.Show("کاربر گرامی ! تنظیمات پیش فرض اعمال شود؟", "Delete تنظیمات", MessageBoxButtons.YesNo) = DialogResult.No Then Return
        Try
            '============================
            Dim vGrid As New GridInit
            Dim strsql As String = " DELETE FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND  USE_ID=" & SQL.CurrentUserId & " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "'" & IIf(vType > 0, " AND TYPE=" & vType, "")
            SQL.ExecuteNonQuery(strsql, Nothing)
            '============================
            Dim dt As DataTable = CType(grd.DataSource, DataTable).Copy
            Me.Initialize(vMainGridColumns, Nothing)
            grd.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd.Click
        RaiseEvent Click(sender, e)
    End Sub

    Private Sub tlbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbSave.Click
        'Dim strsql As String = " SELECT GRIDLAYOUT,TITLE,CAST(ISNULL(IS_DEFAULT,0) AS BIT)IS_DEFAULT FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND  USE_ID=" & SQL.CurrentUserId & _
        '                       " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "' AND TYPE=" & vType
        'Dim dt As DataTable = SQL.ExecuteDataTable(strsql, Nothing)

        'Dim vfrm As New frmReportSetting(dt, grd)
        'If vfrm.ShowDialog() Then

        'End If
        Try
            Dim grdpath As String = System.IO.Path.GetTempPath() & "\Mosafer\bin\grd\" & SQL.CurrentUserId

            If Not Directory.Exists(grdpath) Then
                Directory.CreateDirectory(grdpath)
            End If
            Dim layoutStream = New FileStream(grdpath & "\" & Me.Name & ".gxl", FileMode.Create)
            grd.SaveLayoutFile(layoutStream)
            layoutStream.Close()

            Dim vGrid As New GridInit
            'MsgBox(vType)
            Dim strsql As String = " DELETE FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND  USE_ID=" & SQL.CurrentUserId &
                                   " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "' AND TYPE=" & vType
            SQL.ExecuteNonQuery(strsql, Nothing)


            Dim xmldoc As New System.Xml.XmlDocument
            xmldoc.Load(grdpath & "\" & Me.Name & ".gxl")
            Dim allText As String = xmldoc.OuterXml

            strsql = " INSERT INTO GRID_INIT (PARENT_FORM, USE_ID, TYPE, CONTROL_NAME, GRIDLAYOUT)" & vbCrLf &
                     "  VALUES('" & Me.ParentForm.ToString.Split(",")(0) & "', " & SQL.CurrentUserId & "," & vType & ",'" & Me.Name & "','" & allText & "')"
            SQL.ExecuteNonQuery(strsql, Nothing)

            MessageBox.Show("کاربر گرامی، اطلاعات قالب گزارش ذخیره شد")

            Directory.Delete(grdpath, True)
        Catch ex As Exception
            MessageBox.Show("کاربر گرامی ، ذخیره سازی قالب جدول فعال نیست.لطفا با نماینده شرکت جهت فعال سازی هماهنگ بفرمائید")
        End Try
    End Sub

    Private Sub tlbLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim grdpath As String = System.IO.Path.GetTempPath() & "\Mosafer\bin\grd\" & SQL.CurrentUserId

            If Not Directory.Exists(grdpath) Then
                Directory.CreateDirectory(grdpath)
            End If

            Dim strsql As String = " SELECT GRIDLAYOUT FROM GRID_INIT WHERE CONTROL_NAME='" & Me.Name & "' AND  USE_ID=" & SQL.CurrentUserId &
                                   " AND PARENT_FORM='" & Me.ParentForm.ToString.Split(",")(0) & "' AND TYPE=" & vType
            Dim DR As DataRow = SQL.ExecuteDataRow(strsql, Nothing)
            If DR IsNot Nothing Then
                Dim xmldoc As New System.Xml.XmlDocument
                xmldoc.LoadXml(DR("GRIDLAYOUT"))
                xmldoc.Save(grdpath & "\" & Me.Name & ".gxl")

                Dim layoutStream = New FileStream(grdpath & "\" & Me.Name & ".gxl", FileMode.Open)
                grd.LoadLayoutFile(layoutStream)
                layoutStream.Close()

                Directory.Delete(grdpath, True)
            End If
        Catch ex As Exception
            MessageBox.Show("کاربر گرامی ، ذخیره سازی قالب جدول فعال نیست.لطفا با نماینده شرکت جهت فعال سازی هماهنگ بفرمائید")
        End Try
    End Sub

    Private Sub grd_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grd.AddingRecord
        RaiseEvent AddingRecord(sender, e)
    End Sub

    Private Sub grd_GetNewRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.GetNewRowEventArgs) Handles grd.GetNewRow
        RaiseEvent GetNewRow(sender, e)
    End Sub
End Class



