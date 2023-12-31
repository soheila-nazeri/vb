
#Region "Enumerations"

Public Enum enmColumnProperties
    HeaderText = 0
    DataProperty = 1
    Width = 2
    Type = 3
    Format = 4
    NullValue = 5
    Align = 6
    FillFooter = 7
End Enum

Public Enum enmColumnType
    TextBox
    ComboBox
    CheckBox
    Image
    Button
    Link
End Enum

Public Enum enmOperator
    Equal = 0
    LessThan = 1
    LessOrEqual = 2
    GreaterThan = 3
    GreaterOrEqual = 4
    [Like] = 5
    Between = 6
End Enum

Public Enum enmOperatorType
    Farsi = 0
    English = 1
    Math = 2
End Enum

Public Enum enmColumnDataType
    [Integer] = 0
    [String] = 1
    [Single] = 2
End Enum

#End Region

Public Class mnDataGrid
    Public Event CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
    Public Event CellErrorTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs)
    Public Event DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
    Public Event Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    Public Event CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    Public Event CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    Public Event RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    Public Event CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    Public Event CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    Public Event SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
    Public Event Sorted(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs)
    Private vReportTitle As String = ""
    Private _DataSource As New DataView

    Private dtColumnValues As New DataTable
    Private vSetColumnValue As String = ""

    Public Sub New()
        InitializeComponent()

        grdGrid.AutoGenerateColumns = False
        grdGrid.ScrollBars = ScrollBars.Both
        grdGrid.RowHeadersWidth = 25
        ShowFilterBar = True
        ShowFooter = False
        AllowUserToAddRows = False
        InitOperators(btnOperator)
        InitOperands(btnOperand)

        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        grdGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush
        dtColumnValues.Columns.Add("CODE", GetType(Integer))
        dtColumnValues.Columns.Add("TITLE", GetType(String))
        InitPaperCombo()
    End Sub

#Region "Initialize"
    'Columns = HeaderText:DataPropertyName[:Width:Type:Format:NullValue:Align:FillFooter]
    Public Sub Initialize(ByVal GridColumns As String, Optional ByVal DataSource_ As Object = Nothing)
        'If Not (Calendar.GetDate() >= 13840101 And Calendar.GetDate() < 13860101) Then Exit Sub
        Dim CellStyle As DataGridViewCellStyle
        Dim lbl As Label
        Dim vFooterTextLeft As Integer = grdGrid.RowHeadersWidth
        Dim Column As Object
        Dim i, J As Integer
        Dim ColumnArray As Array = GridColumns.Split(";")
        If ColumnArray(0).ToString.ToLower.Split(":")(1) = "row" Then grdGrid.VirtualMode = True
        Dim ColumnPropertires As Array
        grdGrid.ReadOnly = False
        grdGrid.Columns.Clear()
        Dim dtCombo As New DataTable
        dtCombo.Columns.Add("CODE", GetType(Integer))
        dtCombo.Columns.Add("TITLE", GetType(String))
        pnlFooter.Controls.Clear()
        Dim btn As New Button
        btn.Width = grdGrid.RowHeadersWidth
        btn.Text = ""
        btn.Dock = DockStyle.Right
        pnlFooter.Controls.Add(btn)
        Dim vComboItems As Array
        Dim DR As DataRow
        For i = 0 To ColumnArray.Length - 1
            Column = New DataGridViewTextBoxColumn
            ColumnPropertires = ColumnArray(i).ToString.Split(":")
            If ColumnPropertires.Length > 3 Then
                Select Case Val(ColumnPropertires(enmColumnProperties.Type))
                    Case enmColumnType.TextBox
                        Column = New DataGridViewTextBoxColumn
                    Case enmColumnType.CheckBox
                        Column = New DataGridViewCheckBoxColumn
                    Case enmColumnType.ComboBox
                        Column = New DataGridViewComboBoxColumn
                        If ColumnArray(i).ToString.Split(":")(1).IndexOf("{") > 0 Then
                            vComboItems = ColumnArray(i).ToString.Split(":")(1).Split("{")(1).Split("}")(0).Split(",")
                            Dim dtComboBox As DataTable = dtCombo.Clone
                            DR = dtComboBox.NewRow
                            DR.Item("CODE") = DBNull.Value
                            DR.Item("TITLE") = ""
                            dtComboBox.Rows.Add(DR)
                            For J = 0 To vComboItems.Length - 1
                                DR = dtComboBox.NewRow
                                DR.Item("CODE") = vComboItems(J).ToString.Split("!")(0)
                                DR.Item("TITLE") = vComboItems(J).ToString.Split("!")(1)
                                dtComboBox.Rows.Add(DR)
                                'CType(vColumn, DataGridViewComboBoxColumn).Items.Add(vComboItems(j).ToString.Split("!")(1))
                            Next
                            CType(Column, DataGridViewComboBoxColumn).ValueMember = "CODE"
                            CType(Column, DataGridViewComboBoxColumn).DisplayMember = "TITLE"
                            CType(Column, DataGridViewComboBoxColumn).DataSource = dtComboBox
                        End If

                    Case enmColumnType.Image
                        Column = New DataGridViewImageColumn
                    Case enmColumnType.Button
                        Column = New DataGridViewButtonColumn
                End Select
            End If
            CellStyle = New DataGridViewCellStyle
            CType(Column, DataGridViewColumn).HeaderText = Utility.getColumnGridTitle(ColumnPropertires(enmColumnProperties.HeaderText))
            CType(Column, DataGridViewColumn).DataPropertyName = ColumnPropertires(enmColumnProperties.DataProperty).ToString.Split("{")(0)
            CType(Column, DataGridViewColumn).Name = ColumnPropertires(enmColumnProperties.DataProperty).ToString.Split("{")(0)
            CType(Column, DataGridViewColumn).ReadOnly = True
            If ColumnPropertires.Length > 2 Then
                If Val(ColumnPropertires(enmColumnProperties.Width)) = 0 Then
                    CType(Column, DataGridViewColumn).Visible = False
                Else
                    CType(Column, DataGridViewColumn).Width = ColumnPropertires(enmColumnProperties.Width)
                End If
            End If
            If ColumnPropertires.Length > enmColumnProperties.Format Then CellStyle.Format = ColumnPropertires(enmColumnProperties.Format)
            If ColumnPropertires.Length > enmColumnProperties.NullValue Then
                CellStyle.NullValue = ColumnPropertires(enmColumnProperties.NullValue)
            Else
                CellStyle.NullValue = ""
            End If
            If ColumnPropertires.Length > enmColumnProperties.Align Then
                If ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "left" Then
                    CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf ColumnPropertires(enmColumnProperties.Align).ToString.ToLower = "right" Then
                    CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Else
                    CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If
            End If
            CType(Column, DataGridViewColumn).DefaultCellStyle = CellStyle
            If ColumnPropertires.Length > 7 Then CType(Column, DataGridViewColumn).Tag = Val(ColumnPropertires(enmColumnProperties.FillFooter))
            grdGrid.Columns.Add(Column)
            lbl = New Label
            lbl.Dock = DockStyle.Right
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.AutoSize = False
            lbl.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            lbl.BackColor = Color.Lavender
            lbl.Size = New System.Drawing.Size(CType(Column, DataGridViewColumn).Width, 23)
            lbl.Name = "lblFooter" & i
            pnlFooter.Controls.Add(lbl)
            lbl.BringToFront()
        Next
        cboColumn.Items.Clear()
        For i = 0 To grdGrid.Columns.Count - 1
            If grdGrid.Columns(i).Visible Then
                cboColumn.Items.Add(Utility.getColumnGridTitle(grdGrid.Columns(i).HeaderText))
                If ColumnArray(i).ToString.Split(":").Length > 8 AndAlso ColumnArray(i).ToString.Split(":")(8) = "1" Then
                    vSetColumnValue &= "," & i & ","
                End If
            End If
        Next
        If Not DataSource_ Is Nothing Then DataSource = DataSource_
    End Sub

    Private Sub InitValueCombo()
        Dim i, j As Integer
        If vSetColumnValue = "" Then Exit Sub
        dtColumnValues.Rows.Clear()
        Dim dr As DataRow
        Dim vColumnName As String
        For i = 0 To cboColumn.Items.Count - 1
            If vSetColumnValue.IndexOf("," & i & ",") >= 0 Then
                vColumnName = GetColumnByHeaderText(cboColumn.Items(i).ToString).Name
                For j = 0 To Me.DataView.Table.Rows.Count - 1
                    If Not Me.DataView.Table.Rows(j).Item(vColumnName) Is DBNull.Value AndAlso Me.DataView.Table.Rows(j).Item(vColumnName) <> "" Then
                        dtColumnValues.DefaultView.RowFilter = "CODE=" & i & " AND TITLE='" & Me.DataView.Table.Rows(j).Item(vColumnName) & "'"
                        If dtColumnValues.DefaultView.Count = 0 Then
                            dr = dtColumnValues.NewRow
                            dr.Item("CODE") = i
                            dr.Item("TITLE") = Me.DataView.Table.Rows(j).Item(vColumnName)
                            dtColumnValues.Rows.Add(dr)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub SetColumnFilterValues(ByVal ColumnName As String, ByVal dt As DataTable, ByVal DisplayMember As String)
        Dim i As Integer
        Dim dr As DataRow
        For i = 0 To dt.Rows.Count - 1
            dr = dtColumnValues.NewRow
            dr.Item("CODE") = Me.Columns(ColumnName).Index
            dr.Item("TITLE") = dt.Rows(i).Item(DisplayMember)
            dtColumnValues.Rows.Add(dr)
        Next
    End Sub

    Public Sub SetColumnFilterValues(ByVal ColumnName As String, ByVal ParamArray Values() As String)
        Dim i As Integer
        Dim dr As DataRow
        For i = 0 To Values.Length - 1
            dr = dtColumnValues.NewRow
            dr.Item("CODE") = Me.Columns(ColumnName).Index
            dr.Item("TITLE") = Values(i)
            dtColumnValues.Rows.Add(dr)
        Next
    End Sub

    'Zarif
    Public Sub setColumnDataSource(ByVal ColumnName As String, ByVal DataSource As DataTable, ByVal ValueMember As String, ByVal DisplayMember As String)
        If grdGrid.Columns.Contains(ColumnName) = False Then Return
        Dim Column As Object = grdGrid.Columns(ColumnName)
        CType(Column, DataGridViewComboBoxColumn).ValueMember = ValueMember
        CType(Column, DataGridViewComboBoxColumn).DisplayMember = DisplayMember
        CType(Column, DataGridViewComboBoxColumn).DataSource = DataSource
    End Sub

#End Region

#Region "FooterInfo"
    Private vOldScroll As Integer = 0

    Public Event CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    Private Sub grdGrid_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellValueChanged
        RaiseEvent CellValueChanged(sender, e)
    End Sub

    Private Sub grdGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdGrid.KeyDown
        If e.KeyCode = Keys.P Then
            If e.Control = True Then
                btnPrint_Click(btnPrintLandScape, Nothing)
            ElseIf e.Alt = True Then
                btnPrint_Click(btnPrintPortrait, Nothing)
            End If
        End If
    End Sub

    Private Sub grdGrid_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles grdGrid.Scroll
        Dim i As Integer
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            vOldScroll += e.OldValue - e.NewValue
            For i = grdGrid.Columns.Count - 1 To 0 Step -1
                pnlFooter.Controls("lblFooter" & i).Width = grdGrid.Columns(i).Width
                pnlFooter.Controls("lblFooter" & i).Visible = grdGrid.Columns(i).Visible
            Next
            For i = grdGrid.Columns.Count - 1 To 0 Step -1
                If grdGrid.Columns(i).Visible = True Then
                    If pnlFooter.Controls("lblFooter" & i).Left + vOldScroll > pnlFooter.Width - grdGrid.RowHeadersWidth Then
                        pnlFooter.Controls("lblFooter" & i).Visible = False
                    ElseIf pnlFooter.Controls("lblFooter" & i).Left + pnlFooter.Controls("lblFooter" & i).Width + vOldScroll > pnlFooter.Width - grdGrid.RowHeadersWidth Then
                        pnlFooter.Controls("lblFooter" & i).Width -= pnlFooter.Controls("lblFooter" & i).Left + pnlFooter.Controls("lblFooter" & i).Width + vOldScroll - pnlFooter.Width + grdGrid.RowHeadersWidth
                    End If
                End If
            Next
        End If
        RaiseEvent Scroll(Me, e)
    End Sub

    Private Sub DG_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles grdGrid.ColumnWidthChanged
        pnlFooter.Controls("lblFooter" & e.Column.Index).Width = e.Column.Width
    End Sub

    Private Sub DG_RowHeadersWidthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.RowHeadersWidthChanged
        btnFooterRowHeader.Width = grdGrid.RowHeadersWidth
    End Sub

    Public Sub RefreshFooterItems()
        Dim i As Integer
        For i = grdGrid.Columns.Count - 1 To 0 Step -1
            pnlFooter.Controls("lblFooter" & i).Visible = grdGrid.Columns(i).Visible
        Next
    End Sub

    Public Sub FillFooterInfo()
        Dim i, j As Integer
        For j = 0 To grdGrid.Columns.Count - 1
            If grdGrid.Columns(j).Tag = 1 Then pnlFooter.Controls("lblFooter" & j).Text = 0
        Next
        For i = 0 To Me.DataView.Count - 1
            For j = 0 To grdGrid.Columns.Count - 1
                If grdGrid.Columns(j).Tag = 1 And Me.DataView.Table.Columns.Contains(grdGrid.Columns(j).Name) Then pnlFooter.Controls("lblFooter" & j).Text += Me.DataView.Item(i).Item(grdGrid.Columns(j).Name)
            Next
        Next
        For j = 0 To grdGrid.Columns.Count - 1
            If grdGrid.Columns(j).Tag = 1 Then
                pnlFooter.Controls("lblFooter" & j).Text = pnlFooter.Controls("lblFooter" & j).Text
            End If
        Next
    End Sub

    Public Function getFoolterItemValue(ByVal ColumnName As String) As Long
        If Not pnlFooter.Controls("lblFooter" & grdGrid.Columns(ColumnName).Index) Is Nothing Then Return Val(pnlFooter.Controls("lblFooter" & grdGrid.Columns(ColumnName).Index).Text.Replace(",", ""))
        Return 0
    End Function

    Public Function getFoolterItemValue(ByVal ColumnIndex As Integer) As Long
        If Not pnlFooter.Controls("lblFooter" & ColumnIndex) Is Nothing Then Return Val(pnlFooter.Controls("lblFooter" & ColumnIndex).Text.Replace(",", ""))
        Return 0
    End Function
#End Region

#Region "GetOperator"

    Private Function GetOperator(ByVal [Operator] As enmOperator, ByVal Type As enmOperatorType) As String
        Select Case [Operator]
            Case enmOperator.Equal
                If Type = enmOperatorType.English Then
                    Return "Equal"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "مساوی"
                Else 'Math
                    Return "="
                End If
            Case enmOperator.LessThan
                If Type = enmOperatorType.English Then
                    Return "LessThan"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "کوچکتر"
                Else 'Math
                    Return "<"
                End If
            Case enmOperator.LessOrEqual
                If Type = enmOperatorType.English Then
                    Return "LessOrEqual"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "کوچکترمساوی"
                Else 'Math
                    Return "<="
                End If
            Case enmOperator.GreaterThan
                If Type = enmOperatorType.English Then
                    Return "GreaterThan"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "بزرگتر"
                Else 'Math
                    Return ">"
                End If
            Case enmOperator.GreaterOrEqual
                If Type = enmOperatorType.English Then
                    Return "GreaterOrEqual"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "بزرگترمساوی"
                Else 'Math
                    Return ">="
                End If
            Case enmOperator.Like
                If Type = enmOperatorType.English Then
                    Return "Like"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "مشابه"
                Else 'Math
                    Return "Like"
                End If
            Case enmOperator.Between
                If Type = enmOperatorType.English Then
                    Return "Between"
                ElseIf Type = enmOperatorType.Farsi Then
                    Return "مابین"
                Else 'Math
                    Return "Between"
                End If
            Case Else
                Return ""
        End Select
    End Function
#End Region

#Region "Properties"

    Public Property DataSource() As Object
        Get
            Return grdGrid.DataSource
        End Get
        Set(ByVal value As Object)
            ClearFilter()
            If Not value Is Nothing Then
                If value.GetType Is GetType(DataView) Then
                    _DataSource = value
                Else
                    _DataSource = CType(value, DataTable).DefaultView
                End If
            End If
            grdGrid.DataSource = value
            If Not pnlFooter.Controls("lblFooter0") Is Nothing Then FillFooterInfo()
            InitValueCombo()
        End Set
    End Property

    Public ReadOnly Property DataView() As DataView
        Get
            Return _DataSource
        End Get
    End Property

    Public Property CurrentRowIndex() As Integer
        Get
            If Not grdGrid.CurrentRow Is Nothing Then
                Return grdGrid.CurrentRow.Index
            Else
                Return -1
            End If
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property

    Public Property StandartTab() As Boolean
        Get
            Return grdGrid.StandardTab
        End Get
        Set(ByVal value As Boolean)
            grdGrid.StandardTab = value
        End Set
    End Property

    Public Property AllowUserToAddRows() As Boolean
        Get
            Return grdGrid.AllowUserToAddRows
        End Get
        Set(ByVal value As Boolean)
            grdGrid.AllowUserToAddRows = value
        End Set
    End Property

    Public ReadOnly Property CurrentDataRow() As DataRow
        Get
            If Not grdGrid.CurrentRow Is Nothing Then
                Return _DataSource.Item(grdGrid.CurrentRow.Index).Row
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property CurrentRow() As DataGridViewRow
        Get
            Return grdGrid.CurrentRow
        End Get
    End Property

    Public ReadOnly Property RowCount() As Integer
        Get
            Return grdGrid.RowCount
        End Get
    End Property

    Public ReadOnly Property DataRow(ByVal Index As Integer) As DataRow
        Get
            If Not grdGrid.CurrentRow Is Nothing Then
                Return CType(grdGrid.DataSource, DataView).Item(Index).Row
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Columns(ByVal Name As String) As DataGridViewColumn
        Get
            Return grdGrid.Columns(Name)
        End Get
    End Property

    Public ReadOnly Property Columns(ByVal Index As Integer) As DataGridViewColumn
        Get
            Return grdGrid.Columns(Index)
        End Get
    End Property

    Public ReadOnly Property Row(ByVal Index As Integer) As DataGridViewRow
        Get
            Return grdGrid.Rows(Index)
        End Get
    End Property

    Public ReadOnly Property Cell(ByVal Row As Integer, ByVal Col As Integer) As DataGridViewCell
        Get
            Return grdGrid.Rows(Row).Cells(Col)
        End Get
    End Property

    Public Property ShowFooter() As Boolean
        Get
            Return pnlFooter.Visible
        End Get
        Set(ByVal value As Boolean)
            pnlFooter.Visible = value
        End Set
    End Property
    Public Property [ReadOnly]() As Boolean
        Get
            Return grdGrid.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            grdGrid.ReadOnly = value
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

    Public Property ShowFilterBar() As Boolean
        Get
            Return tbrFilter.Visible
        End Get
        Set(ByVal value As Boolean)
            If tbrFilter.Visible <> value Then
                pnlFilter.Visible = value
            End If
        End Set
    End Property

    Public Property SelectionMode() As DataGridViewSelectionMode
        Get
            Return grdGrid.SelectionMode
        End Get
        Set(ByVal value As DataGridViewSelectionMode)
            grdGrid.SelectionMode = value
        End Set
    End Property

    Public Property ColumnHeadersDefaultCellStyle() As DataGridViewCellStyle
        Get
            Return grdGrid.ColumnHeadersDefaultCellStyle
        End Get
        Set(ByVal value As DataGridViewCellStyle)
            grdGrid.ColumnHeadersDefaultCellStyle = value
        End Set
    End Property

    Public Property RowHeadersDefaultCellStyle() As DataGridViewCellStyle
        Get
            Return grdGrid.RowHeadersDefaultCellStyle
        End Get
        Set(ByVal value As DataGridViewCellStyle)
            grdGrid.RowHeadersDefaultCellStyle = value
        End Set
    End Property

    Public Property RowHeadersWidth() As Integer
        Get
            Return grdGrid.RowHeadersWidth
        End Get
        Set(ByVal value As Integer)
            grdGrid.RowHeadersWidth = value
        End Set
    End Property

    Public Property ColumnHeadersHeightSizeMode()
        Get
            Return grdGrid.ColumnHeadersHeightSizeMode
        End Get
        Set(ByVal value)
            grdGrid.ColumnHeadersHeightSizeMode = value
        End Set
    End Property

    Public Property AutoSizeColumnsMode() As DataGridViewAutoSizeColumnMode
        Get
            Return grdGrid.AutoSizeColumnsMode
        End Get
        Set(ByVal value As DataGridViewAutoSizeColumnMode)
            grdGrid.AutoSizeColumnsMode = value
        End Set
    End Property

    Public Property CurrentCell() As DataGridViewCell
        Get
            Return grdGrid.CurrentCell
        End Get
        Set(ByVal value As DataGridViewCell)
            grdGrid.CurrentCell = value
        End Set
    End Property

    Public ReadOnly Property Rows() As DataGridViewRowCollection
        Get
            Return grdGrid.Rows
        End Get
    End Property

    Public Property CurrentFilterColumn() As String
        Get
            Return cboColumn.Text
        End Get
        Set(ByVal value As String)
            If value <> "" Then cboColumn.Text = Utility.getColumnGridTitle(grdGrid.Columns(value).HeaderText)
        End Set
    End Property

    Public Property Item(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer) As DataGridViewCell
        Get
            Return grdGrid.Item(ColumnIndex, RowIndex)
        End Get
        Set(ByVal value As DataGridViewCell)
            grdGrid.Item(ColumnIndex, RowIndex) = value
        End Set
    End Property

    Public Property Item(ByVal ColumnName As String, ByVal RowIndex As Integer) As DataGridViewCell
        Get
            Return grdGrid.Item(ColumnName, RowIndex)
        End Get
        Set(ByVal value As DataGridViewCell)
            grdGrid.Item(ColumnName, RowIndex) = value
        End Set
    End Property

    Public ReadOnly Property Columns() As DataGridViewColumnCollection
        Get
            Return grdGrid.Columns
        End Get
    End Property

    Public ReadOnly Property SelectedRows() As DataGridViewSelectedRowCollection
        Get
            Return grdGrid.SelectedRows
        End Get
    End Property

    Public Property FirstDisplayedScrollingRowIndex() As Integer
        Get
            Return grdGrid.FirstDisplayedScrollingRowIndex
        End Get
        Set(ByVal value As Integer)
            If value > -1 Then grdGrid.FirstDisplayedScrollingRowIndex = value
        End Set
    End Property

    Public ReadOnly Property ColumnCount() As Integer
        Get
            Return grdGrid.Columns.Count
        End Get
    End Property

    Public Property ShowEditingIcon() As Boolean
        Get
            Return grdGrid.ShowEditingIcon
        End Get
        Set(ByVal value As Boolean)
            grdGrid.ShowEditingIcon = value
        End Set
    End Property

    Public Property ScrollBars() As System.Windows.Forms.ScrollBars
        Get
            Return grdGrid.ScrollBars
        End Get
        Set(ByVal value As System.Windows.Forms.ScrollBars)
            grdGrid.ScrollBars = value
        End Set
    End Property

    Public Property AlternatingRowsDefaultCellStyle() As DataGridViewCellStyle
        Get
            Return grdGrid.AlternatingRowsDefaultCellStyle
        End Get
        Set(ByVal value As DataGridViewCellStyle)
            grdGrid.AlternatingRowsDefaultCellStyle = value
        End Set
    End Property

    Public Function GetFilterText(ByVal Index As Integer) As Object
        Return Nothing
    End Function

#End Region

#Region "Functions"

    Public Function CancelEdit() As Boolean
        Return grdGrid.CancelEdit
    End Function

    Public Sub SelectAll()
        grdGrid.SelectAll()
    End Sub

#End Region

#Region "Operator"

    Private Sub InitOperators(ByVal DropDownButton As ToolStripDropDownButton)
        DropDownButton.DropDownItems.Clear()
        Dim i As Integer
        For i = enmOperator.Equal To enmOperator.Like '.Between 'enmOperator.In
            Dim Item As ToolStripItem = DropDownButton.DropDownItems.Add(GetOperator(i, enmOperatorType.Farsi))
            Item.Name = "mnu" & GetOperator(i, enmOperatorType.English) : Item.Tag = i
        Next
        DropDownButton.Text = GetOperator(enmOperator.Like, enmOperatorType.Farsi)
        DropDownButton.Tag = enmOperator.Like
    End Sub

    Private Sub btnOperator_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnOperator.DropDownItemClicked, btnPaperSize.DropDownItemClicked
        CType(sender, ToolStripDropDownItem).Text = e.ClickedItem.Text
        CType(sender, ToolStripDropDownItem).Tag = e.ClickedItem.Tag
    End Sub

#End Region

#Region "Operand"

    Private Sub InitOperands(ByVal DropDownButton As ToolStripDropDownButton)
        DropDownButton.DropDownItems.Clear()
        Dim Item As ToolStripItem
        Item = DropDownButton.DropDownItems.Add("")
        Item.Name = "mnuNone"
        Item.Tag = "None"
        Item = DropDownButton.DropDownItems.Add(" و ")
        Item.Name = "mnuAnd"
        Item.Tag = "And"
        Item = DropDownButton.DropDownItems.Add(" یا ")
        Item.Name = "mnuOr"
        Item.Tag = "Or"
        DropDownButton.Text = ""
        DropDownButton.Tag = "None"
    End Sub

    Private Sub btnOperand_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnOperand.DropDownItemClicked
        CType(sender, ToolStripDropDownItem).Text = e.ClickedItem.Text
        CType(sender, ToolStripDropDownItem).Tag = e.ClickedItem.Tag
        If CType(sender, ToolStripDropDownItem).Tag = "None" Then
        Else
            Dim i As Integer
            For i = CType(sender, ToolStripDropDownItem).Owner.Tag + 1 To pnlFilter.RowCount - 1
                If pnlFilter.RowStyles(i).Height > 0 Then Exit Sub
            Next
            If i < pnlFilter.RowCount Then Exit Sub
            Dim tbrFilters As New ToolStrip
            tbrFilters.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            tbrFilters.Name = "tbrFilter" & pnlFilter.RowCount
            tbrFilters.Size = New System.Drawing.Size(400, 25)
            tbrFilters.TabIndex = 0
            tbrFilters.Text = "ToolStrip1"
            tbrFilters.Tag = pnlFilter.RowCount

            Dim vColumn As New ToolStripComboBox
            vColumn.Size = cboColumn.Size
            vColumn.Name = "cboColumn"
            vColumn.DropDownStyle = ComboBoxStyle.DropDownList
            AddHandler vColumn.SelectedIndexChanged, AddressOf cboColumn_SelectedIndexChanged
            Dim vItem As Object
            For Each vItem In cboColumn.Items
                vColumn.Items.Add(vItem)
            Next
            Dim vToolStripSeparator0 As New ToolStripSeparator
            Dim vToolStripSeparator1 As New ToolStripSeparator
            Dim vToolStripSeparator2 As New ToolStripSeparator
            Dim vOperator As New ToolStripDropDownButton
            vOperator.AutoSize = False
            vOperator.Size = btnOperator.Size
            vOperator.DisplayStyle = ToolStripItemDisplayStyle.Text
            vOperator.Name = "btnOperator"
            InitOperators(vOperator)
            AddHandler vOperator.DropDownItemClicked, AddressOf btnOperator_DropDownItemClicked
            Dim vOperand As New ToolStripDropDownButton
            vOperand.AutoSize = False
            vOperand.Size = btnOperand.Size
            vOperand.Name = "btnOperand"
            vOperand.DisplayStyle = ToolStripItemDisplayStyle.Text
            vOperand.DropDownItems.Clear()
            InitOperands(vOperand)
            AddHandler vOperand.DropDownItemClicked, AddressOf btnOperand_DropDownItemClicked
            Dim vValue As New ToolStripComboBox
            vValue.Size = cboValue.Size
            vValue.Name = "cboValue"
            Dim vCancelButton As New ToolStripButton
            vCancelButton.Image = btnCancelFilter.Image
            vCancelButton.Tag = pnlFilter.RowCount
            AddHandler vCancelButton.Click, AddressOf btnCancelFilter_Click
            tbrFilters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {vToolStripSeparator0, vColumn, vToolStripSeparator1, vOperator, vToolStripSeparator2, vValue, vOperand, vCancelButton})

            pnlFilter.Height += 25
            grdGrid.Top += 25
            grdGrid.Height -= 25
            pnlFilter.RowCount += 1
            Me.pnlFilter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            'Me.pnlFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
            pnlFilter.Controls.Add(tbrFilters, 0, pnlFilter.RowCount - 1)

        End If
    End Sub

#End Region

#Region "Filter"

    Private Function GetColumnByHeaderText(ByVal HeaderText As String) As DataGridViewColumn
        Dim i As Integer
        For i = 0 To grdGrid.Columns.Count - 1
            If Utility.getColumnGridTitle(grdGrid.Columns(i).HeaderText) = Utility.getColumnGridTitle(HeaderText) Then
                Return grdGrid.Columns(i)
            End If
        Next
        Return Nothing
    End Function

    Private Function GetColumnDataType(ByVal ColumnName As String) As enmColumnDataType
        If _DataSource Is Nothing Then
            Return enmColumnDataType.String
        Else
            Select Case _DataSource.Table.Columns(ColumnName).DataType.ToString
                Case "Single"
                    Return enmColumnDataType.Single
                Case "Integer"
                    Return enmColumnDataType.Integer
                Case Else
                    Return enmColumnDataType.String
            End Select
        End If
    End Function

    Public Sub ClearFilter()
        'Array.Resize(FilterItems, 0)
        Dim i As Integer
        For i = 1 To pnlFilter.RowCount - 1
            If pnlFilter.RowStyles(i).Height > 0 Then
                If Not pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)) Is Nothing Then CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Dispose()
                pnlFilter.RowStyles(i).Height = 0
                pnlFilter.Height -= 25
                grdGrid.Top -= 25
                grdGrid.Height += 25
            End If
        Next
        cboValue.Text = ""
        btnOperand.Text = ""
        btnOperand.Tag = "None"
        If Not _DataSource Is Nothing Then _DataSource.RowFilter = ""
    End Sub

    Private Sub cboColumn_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColumn.SelectedIndexChanged
        Dim vValueCombo As ToolStripComboBox = CType(CType(sender, ToolStripComboBox).Owner, ToolStrip).Items("cboValue")
        If CType(sender, ToolStripComboBox).SelectedIndex = -1 Then
            vValueCombo.Enabled = False
        Else
            vValueCombo.Enabled = True
            vValueCombo.Items.Clear()
            vValueCombo.Text = ""
            dtColumnValues.DefaultView.RowFilter = "CODE=" & CType(sender, ToolStripComboBox).SelectedIndex
            Dim I As Integer
            For I = 0 To dtColumnValues.DefaultView.Count - 1
                vValueCombo.Items.Add(dtColumnValues.DefaultView.Item(I).Item("TITLE"))
            Next
        End If
    End Sub

    Private Sub btnApplyFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyFilter.Click
        Dim i As Integer
        Dim vFilter As String = ""
        Dim vOperand As String = ""
        Dim vNotFilterColumns As String = ""
        Dim vNumberColumnLike As Boolean = False
        Dim vColumnName As String = ""
        For i = 0 To pnlFilter.RowCount - 1
            If pnlFilter.RowStyles(i).Height > 0 Then
                If CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("cboColumn"), ToolStripComboBox).SelectedIndex <> -1 And CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("cboValue"), ToolStripComboBox).Text <> "" Then
                    vColumnName = GetColumnByHeaderText(CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("cboColumn"), ToolStripComboBox).Text).Name
                    If Me.DataView.Table.Columns.Contains(vColumnName) Then
                        If CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperator"), ToolStripDropDownButton).Tag = enmOperator.Like And
                           Not Me.DataView.Table.Columns(vColumnName).DataType Is GetType(String) Then
                            vNumberColumnLike = True
                        Else
                            vFilter &= " " & vOperand & " " & vColumnName & " " &
                            GetOperator(CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperator"), ToolStripDropDownButton).Tag, enmOperatorType.Math) & " '"
                            If CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperator"), ToolStripDropDownButton).Tag = enmOperator.Like Then vFilter &= "%"
                            vFilter &= CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("cboValue"), ToolStripComboBox).Text.Replace("ی", "ي")
                            If CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperator"), ToolStripDropDownButton).Tag = enmOperator.Like Then vFilter &= "%"
                            vFilter &= "'"
                            If CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperand"), ToolStripDropDownButton).Text <> "" Then
                                vOperand = CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("btnOperand"), ToolStripDropDownButton).Tag
                            End If
                        End If
                    Else
                        vNotFilterColumns &= IIf(vNotFilterColumns = "", "", " ,") & CType(CType(pnlFilter.Controls("tbrFilter" & IIf(i = 0, "", i)), ToolStrip).Items("cboColumn"), ToolStripComboBox).Text
                    End If
                End If
            End If
        Next
        If vNotFilterColumns <> "" Then
            MessageBox.Show("امکان فیلتر بر اساس فیلد(های)'" & vNotFilterColumns & "' وجود ندارد")
        End If
        If vNumberColumnLike = True Then
            MessageBox.Show("امکان Search بر اساس گزینه 'مشابه' برای فیلدهای عددی وجود ندارد")
        End If
        _DataSource.RowFilter = vFilter
        grdGrid.DataSource = _DataSource
        FillFooterInfo()
    End Sub

    Private Sub btnCancelFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelFilter.Click
        If CType(sender, ToolStripButton).Tag > 0 Then
            CType(sender, ToolStripButton).Owner.Dispose()
            Me.pnlFilter.RowStyles(CType(sender, ToolStripButton).Tag).Height = 0
            pnlFilter.Height -= 25
            grdGrid.Top -= 25
            grdGrid.Height += 25
        Else
            cboValue.Text = ""
            btnOperand.Text = ""
            btnOperand.Tag = "None"
        End If
        btnApplyFilter_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "Events"

    Private Sub grdGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdGrid.CellBeginEdit
        RaiseEvent CellBeginEdit(sender, e)
    End Sub

    Private Sub grdGrid_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellContentClick
        RaiseEvent CellContentClick(Me, e)
    End Sub

    Private Sub grdGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellEndEdit
        RaiseEvent CellEndEdit(sender, e)
    End Sub

    Private Sub grdGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellEnter
        RaiseEvent CellEnter(Me, e)
    End Sub

    Private Sub grdGrid_CellErrorTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs) Handles grdGrid.CellErrorTextNeeded
        RaiseEvent CellErrorTextNeeded(sender, e)
    End Sub

    Private Sub grdGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdGrid.CellMouseClick
        RaiseEvent CellMouseClick(Me, e)
    End Sub

    Private Sub grdGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdGrid.CellMouseDoubleClick
        RaiseEvent CellMouseDoubleClick(Me, e)
    End Sub

    Private Sub grdGrid_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles grdGrid.CellValueNeeded
        If e.ColumnIndex = 0 Then e.Value = e.RowIndex + 1
    End Sub

    Private Sub grdGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.CurrentCellChanged
        If Not ActiveControl Is Nothing AndAlso ActiveControl Is grdGrid AndAlso Not grdGrid.Columns Is Nothing AndAlso Not grdGrid.CurrentCell Is Nothing Then
            cboColumn.Text = grdGrid.Columns(grdGrid.CurrentCell.ColumnIndex).HeaderText
        End If
        RaiseEvent CurrentCellChanged(Me, e)
    End Sub

    Private Sub grdGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdGrid.DataError
        RaiseEvent DataError(sender, e)
    End Sub

    Private Sub grdGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.DoubleClick
        RaiseEvent DoubleClick(Me, e)
    End Sub

    Private Sub grdGrid_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.RowEnter
        RaiseEvent RowEnter(Me, e)
    End Sub

    Private Sub grdGrid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.SelectionChanged
        RaiseEvent SelectionChanged(Me, e)
    End Sub

    Private Sub grdGrid_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.Sorted
        RaiseEvent Sorted(Me, e)
    End Sub

    Private Sub grdGrid_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles grdGrid.SortCompare
        RaiseEvent SortCompare(Me, e)
    End Sub

#End Region

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

    Private ReportObjects() As stcReportObject = {}
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
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPortrait.Click, btnPrintLandScape.Click

        Array.Resize(ReportObjects, 0)
        PaperSize = btnPaperSize.Tag
        If sender Is btnPrintPortrait Then
            PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        Else
            PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        End If
        RaiseEvent Print(Me, e)
        Dim I As Integer
        Dim vColumns As String = ""
        For I = 0 To grdGrid.Columns.Count - 1
            If grdGrid.Columns(I).Name.ToLower <> "row" And grdGrid.Columns(I).Visible = True Then
                vColumns &= IIf(vColumns = "", "", ";") & grdGrid.Columns(I).HeaderText & ":" & grdGrid.Columns(I).Name & ":" & grdGrid.Columns(I).Width
                If grdGrid.Columns(I).DefaultCellStyle.Format <> "" Then vColumns &= ":1"
            End If
        Next
        Report = New Report(vColumns, vReportTitle, _DataSource.ToTable, vPaperOrientation, vPaperSize, vPageMargin.leftMargin, vPageMargin.topMargin, vPageMargin.rightMargin, vPageMargin.bottomMargin)
        If ShowFooter = True Then
            For I = 0 To grdGrid.Columns.Count - 1
                If grdGrid.Columns(I).Tag = 1 Then
                    Report.AddText(getFoolterItemValue(I), Report.enmTextAlign.Center, Report.enmParameterPlace.ReportFooter, grdGrid.Columns(I).Name, 5, True)
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
        'If btnPrintPreview.Tag = "On" Then
        '    Report.ShowDialog()
        'Else
        '    Report.cryReport.PrintReport()
        'End If
        Report.Dispose()
    End Sub
#End Region

    Private Sub cboValue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnApplyFilter.Enabled = True Then btnApplyFilter_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        If btnPrintPreview.Tag = "Off" Then
            btnPrintPreview.Tag = "On"

        Else
            btnPrintPreview.Tag = "Off"

        End If
    End Sub
End Class
