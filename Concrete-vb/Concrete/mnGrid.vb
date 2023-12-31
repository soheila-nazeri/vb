Public Class mnGrid
  Public Event CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Event CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
  Public Event CellErrorTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs)
  Public Event DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
  Public Event Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
  Public Event CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  Public Event CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  Public Event CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  Public Event CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  Public Event RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  Public Event CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
  Public Event CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
  Public Event CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
  Public Event SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  Public Shadows Event Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
  Public Event Sorted(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Event SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs)
  Private vReportTitle As String = ""
  Private _DataSource As New DataView
  Private dtColumnValues As New DataTable
  Private vSetColumnValue As String = ""
  Private vFilterString As String = ""
  Private vPrimaryFilter As String = ""
  Public PrinterName As String = ""

  Public Enum enmPrintOriantation
    Portrait
    Landcape
  End Enum
  Public PrintOriantation As enmPrintOriantation = enmPrintOriantation.Portrait
  Public Sub New()
    InitializeComponent()

    grdGrid.AutoGenerateColumns = False
    grdGrid.ScrollBars = ScrollBars.Both
    grdGrid.RowHeadersWidth = 25
    ShowFilterBar = True
    ShowFooter = False
    AllowUserToAddRows = False

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
              DR.Item("TITLE") = " "
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
      CType(Column, DataGridViewColumn).Tag = 0
      If ColumnPropertires.Length > 7 Then CType(Column, DataGridViewColumn).Tag = Val(ColumnPropertires(enmColumnProperties.FillFooter))
      grdGrid.Columns.Add(Column)
    Next
    If Not DataSource_ Is Nothing Then DataSource = DataSource_
    setGridHeader()
      vFilterString = ""
   End Sub

  Public Sub setGridHeader()
    tlpHeader.Items.Clear()
    tlpFilter.Items.Clear()
    tlpFooter.Items.Clear()
    Dim tsiHeader As ToolStripItem
    For i As Integer = 0 To grdGrid.Columns.Count - 1
      If grdGrid.Columns(i).Visible = True Then
        tsiHeader = New ToolStripButton
            tsiHeader.AutoSize = False
        tsiHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsiHeader.ImageTransparentColor = System.Drawing.Color.Magenta
        tsiHeader.Tag = i
            tsiHeader.Size = New System.Drawing.Size(CType(grdGrid.Columns(i), DataGridViewColumn).Width - IIf(i = 0, 1, 4), 22)
                tsiHeader.Text = Utility.getColumnGridTitle(CType(grdGrid.Columns(i), DataGridViewColumn).HeaderText)
                AddHandler tsiHeader.Click, AddressOf tlpButtonHeaderClick
        tlpHeader.Items.Add(tsiHeader)

        tsiHeader = New ToolStripSeparator
        tsiHeader.AutoSize = False
            tsiHeader.Size = New System.Drawing.Size(4, 25)
        tlpHeader.Items.Add(tsiHeader)

        tsiHeader = New ToolStripTextBox
        tsiHeader.AutoSize = False
        CType(tsiHeader, ToolStripTextBox).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        tsiHeader.Tag = i
        tsiHeader.Size = New System.Drawing.Size(CType(grdGrid.Columns(i), DataGridViewColumn).Width - 2, 21)
                AddHandler tsiHeader.TextChanged, AddressOf FilterTextChanged
                tlpFilter.Items.Add(tsiHeader)

        tsiHeader = New ToolStripTextBox
        'tsiHeader.Enabled = False
        tsiHeader.ForeColor = Color.Blue
        tsiHeader.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        tsiHeader.BackColor = Color.White
        tsiHeader.AutoSize = False
        CType(tsiHeader, ToolStripTextBox).TextBoxTextAlign = HorizontalAlignment.Center
        CType(tsiHeader, ToolStripTextBox).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        tsiHeader.Tag = i
        tsiHeader.Size = New System.Drawing.Size(CType(grdGrid.Columns(i), DataGridViewColumn).Width - 2, 21)
        CType(tsiHeader, ToolStripTextBox).TextAlign = ContentAlignment.MiddleCenter
        tlpFooter.Items.Add(tsiHeader)
      End If
    Next
    tlpHeader.Left = tlpRight.Left - tlpHeader.Width
    tlpFilter.Left = tlpRight.Left - tlpFilter.Width
    tlpFooter.Left = tlpRight.Left - tlpFooter.Width
    FillFooterInfo()
  End Sub

#End Region

#Region "FooterInfo"
  Private vOldScroll As Integer = 0


  Private Sub grdGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdGrid.KeyDown
        If e.KeyCode = Keys.P Then
            If e.Control = True Then
                btnPrint_Click(btnPrintLandScape, Nothing)
            ElseIf e.Alt = True Then
                btnPrint_Click(btnPrintPortrait, Nothing)
            End If
        End If
        RaiseEvent KeyDown(Me, e)
  End Sub

  Private Sub grdGrid_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles grdGrid.Scroll
    If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
      tlpHeader.Left += e.OldValue - e.NewValue
      tlpFilter.Left += e.OldValue - e.NewValue
      tlpFooter.Left += e.OldValue - e.NewValue
    End If
    RaiseEvent Scroll(Me, e)
  End Sub

  Private Sub DG_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles grdGrid.ColumnWidthChanged
    Dim x As Integer = 0
    For i As Integer = 0 To e.Column.Index
      If grdGrid.Columns(i).Visible = False Then x += 1
    Next
    If (e.Column.Index - x) * 2 < tlpHeader.Items.Count Then tlpHeader.Items((e.Column.Index - x) * 2).Width = e.Column.Width - IIf(e.Column.Index = 0, 1, 4)
    If e.Column.Index - x < tlpFilter.Items.Count Then tlpFilter.Items(e.Column.Index - x).Width = e.Column.Width - 2
    If e.Column.Index - x < tlpFooter.Items.Count Then tlpFooter.Items(e.Column.Index - x).Width = e.Column.Width - 2
  End Sub

  Private Sub DG_RowHeadersWidthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.RowHeadersWidthChanged
    'btnFooterRowHeader.Width = grdGrid.RowHeadersWidth
  End Sub

  Public Sub FillFooterInfo()
    Dim j As Integer
    For j = 0 To tlpFooter.Items.Count - 1
      If grdGrid.Columns(j).Tag = 1 Then tlpFooter.Items(j).Text = 0
    Next
    If Me.DataSource Is Nothing Then Exit Sub
    For j = 0 To tlpFooter.Items.Count - 1
      If grdGrid.Columns(tlpFooter.Items(j).Tag).Name <> "row" AndAlso grdGrid.Columns(tlpFooter.Items(j).Tag).Tag = 1 And Me.DataView.Table.Columns.Contains(grdGrid.Columns(tlpFooter.Items(j).Tag).Name) Then
                tlpFooter.Items(j).Text = Utility.NVL(Me.DataView.ToTable.Compute("SUM(" & grdGrid.Columns(tlpFooter.Items(j).Tag).Name & ")", ""), 0)
            End If
    Next
  End Sub

  Private Function getFooterIndex(ByVal ColumnIndex As Integer) As Integer
    For i As Integer = 0 To tlpFooter.Items.Count - 1
      If tlpFooter.Items(i).Tag = ColumnIndex Then Return i
    Next
    Return -1
  End Function

  Public Property Sum(ByVal ColumnName As String) As Long
    Get
      Dim i As Integer = getFooterIndex(grdGrid.Columns(ColumnName).Index)
      If i <> -1 Then Return Val(tlpFooter.Items(i).Text.Replace(",", ""))
      Return 0
    End Get
    Set(ByVal value As Long)
      Dim i As Integer = getFooterIndex(grdGrid.Columns(ColumnName).Index)
            If i <> -1 Then tlpFooter.Items(i).Text = value
        End Set
  End Property

  Public Property Sum(ByVal ColumnIndex As Integer) As Long
    Get
      Dim i As Integer = getFooterIndex(ColumnIndex)
      If i > 0 Then Return Val(tlpFooter.Items(i).Text.Replace(",", ""))
      Return 0
    End Get
    Set(ByVal value As Long)
      Dim i As Integer = getFooterIndex(ColumnIndex)
            If i <> -1 Then tlpFooter.Items(i).Text = value
        End Set
  End Property

#End Region

    Public Sub FocusFilterItems(Optional ByVal ColumnIndex As Integer = 0)
        If tlpFilter.Items.Count > 0 Then
            CType(tlpFilter.Items(ColumnIndex), ToolStripTextBox).Focus()
        End If
    End Sub

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
      vPrimaryFilter = _DataSource.RowFilter
      If tlpFooter.Items.Count > 0 Then FillFooterInfo()
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
      Dim b As BindingManagerBase
      b = BindingContext(DataView)
      b.Position = value
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

  Public Property ShowToolBar() As Boolean
    Get
      Return tlpTools.Visible
    End Get
    Set(ByVal value As Boolean)
      If tlpTools.Visible <> value Then
        tlpTools.Visible = value
        If value = False Then
          tlpHeader.Top -= tlpTools.Height
          tlpFilter.Top -= tlpTools.Height
          grdGrid.Top -= tlpTools.Height
          grdGrid.Height += tlpTools.Height
          tlpRight.Height -= tlpHeader.Height
        Else
          tlpHeader.Top += tlpTools.Height
          tlpFilter.Top += tlpTools.Height
          grdGrid.Top += tlpTools.Height
          grdGrid.Height -= tlpTools.Height
          tlpRight.Height += tlpHeader.Height
        End If
      End If
    End Set
  End Property

  Public Property ShowHeader() As Boolean
    Get
      Return tlpHeader.Visible
    End Get
    Set(ByVal value As Boolean)
      If tlpHeader.Visible <> value Then
        tlpHeader.Visible = value
        If value = False Then
          tlpFilter.Top -= tlpHeader.Height
          grdGrid.Top -= tlpHeader.Height
          grdGrid.Height += tlpHeader.Height
          tlpRight.Height -= tlpHeader.Height
        Else
          tlpFilter.Top += tlpHeader.Height
          grdGrid.Top += tlpHeader.Height
          grdGrid.Height -= tlpHeader.Height
          tlpRight.Height += tlpHeader.Height
        End If
      End If
    End Set
  End Property

  Public Property ShowFilterBar() As Boolean
    Get
      Return tlpFilter.Visible
    End Get
    Set(ByVal value As Boolean)
      If tlpFilter.Visible <> value Then
        tlpFilter.Visible = value
        If value = False Then
          grdGrid.Top -= tlpFilter.Height
          grdGrid.Height += tlpFilter.Height
                    tlpRight.Height -= tlpHeader.Height
                Else
                    grdGrid.Top += tlpFilter.Height
                    grdGrid.Height -= tlpFilter.Height
                    tlpRight.Height += tlpHeader.Height
                End If
      End If
    End Set
  End Property

  Public Property ShowFooter() As Boolean
    Get
      Return tlpFooter.Visible
    End Get
    Set(ByVal value As Boolean)
      If tlpFooter.Visible <> value Then
        tlpFooter.Visible = value
        If value = False Then
          grdGrid.Height = Me.Height - grdGrid.Top - 1
        Else
          grdGrid.Height = Me.Height - grdGrid.Top - tlpFooter.Height - 1
        End If
      End If
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

#End Region

#Region "Filter"

  Public Sub ClearFilter()
    For i As Integer = 0 To tlpFilter.Items.Count - 1
      CType(tlpFilter.Items(i), ToolStripTextBox).Text = ""
    Next
    If Not _DataSource Is Nothing Then _DataSource.RowFilter = vPrimaryFilter
  End Sub

  Private Sub btnCancelFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelFilter.Click
    Dim tlpTextBox As ToolStripTextBox
    For Each tlpTextBox In tlpFilter.Items
      tlpTextBox.Text = ""
    Next
    'If Not _DataSource Is Nothing Then _DataSource.RowFilter = ""
  End Sub

#End Region

#Region "Events"

  Private Sub grdGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdGrid.CellBeginEdit
    RaiseEvent CellBeginEdit(sender, e)
  End Sub

  Private Sub grdGrid_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdGrid.CellMouseMove
    RaiseEvent CellMouseMove(sender, e)
  End Sub

  Private Sub grdGrid_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellContentClick
    RaiseEvent CellContentClick(Me, e)
  End Sub

  Private Sub grdGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellEndEdit
    If ShowFooter = True Then
      FillFooterInfo()
    End If
    RaiseEvent CellEndEdit(sender, e)
  End Sub

  Private Sub grdGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellEnter
    RaiseEvent CellEnter(Me, e)
  End Sub

  Private Sub grdGrid_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrid.CellEnter
    RaiseEvent CellLeave(Me, e)
  End Sub

  Private Sub grdGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.CurrentCellChanged
    RaiseEvent CurrentCellChanged(Me, e)
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

  Public Sub AddText(ByVal Value As String, _
                     ByVal Align As Report.enmTextAlign, _
                     ByVal Place As Report.enmParameterPlace, _
                     ByVal X As Integer, ByVal Y As Integer, _
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

  Public Sub AddText(ByVal Value As String, _
                   ByVal Align As Report.enmTextAlign, _
                   ByVal Place As Report.enmParameterPlace, _
                   ByVal ColumnName As String, _
                   ByVal Y As Integer, _
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

  'Private Sub btnPrintPortrait_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrintPortrait.MouseDown, btnPrintLandScape.MouseDown
  '  If e.Button = Windows.Forms.MouseButtons.Right Then
  '    vPrinterStatus = enmPrinterStatus.PreView
  '  End If
  '  btnPrint_Click(sender, Nothing)
  '  vPrinterStatus = enmPrinterStatus.Printer
  'End Sub

  Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPortrait.Click, btnPrintLandScape.Click
    PrintOriantation = enmPrintOriantation.Portrait
    If sender Is btnPrintLandScape Then PrintOriantation = enmPrintOriantation.Landcape
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
                vColumns &= IIf(vColumns = "", "", ";") & Utility.getColumnGridTitle(grdGrid.Columns(I).HeaderText) & ":" & grdGrid.Columns(I).Name & ":" & grdGrid.Columns(I).Width
                If grdGrid.Columns(I).DefaultCellStyle.Format <> "" Then vColumns &= ":1"
      End If
    Next
    Report = New Report(vColumns, vReportTitle, _DataSource.ToTable, vPaperOrientation, vPaperSize, vPageMargin.leftMargin, vPageMargin.topMargin, vPageMargin.rightMargin, vPageMargin.bottomMargin, PrinterName, IIf(btnPrintPreview.Tag = "On", False, True))
    If ShowFooter = True Then
      For I = 0 To grdGrid.Columns.Count - 1
        If grdGrid.Columns(I).Tag = 1 Then
                    Report.AddText(Sum(I), Report.enmTextAlign.Center, Report.enmParameterPlace.ReportFooter, grdGrid.Columns(I).Name, 5, True)
                End If
      Next
    End If
    For I = 0 To ReportObjects.Length - 1
      If ReportObjects(I).ColumnName = "" Then
        Report.AddText(ReportObjects(I).Value, _
                       ReportObjects(I).Align, _
                       ReportObjects(I).Place, _
                       ReportObjects(I).X, ReportObjects(I).Y, ReportObjects(I).Width, ReportObjects(I).Border)
      Else
        Report.AddText(ReportObjects(I).Value, _
                       ReportObjects(I).Align, _
                       ReportObjects(I).Place, _
                       ReportObjects(I).ColumnName, ReportObjects(I).Y, ReportObjects(I).Border)
      End If
    Next
        'If btnPrintPreview.Tag = "On" Then
        '  Report.ShowDialog()
        'ElseIf PrinterName <> "" Then
        '  Report.Print()
        'Else
        '  Report.cryReport.PrintReport()
        'End If
        Report.Dispose()
  End Sub
#End Region

  Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        If btnPrintPreview.Tag = "Off" Then
            btnPrintPreview.Tag = "On"
        Else
            btnPrintPreview.Tag = "Off"
        End If
    End Sub

  Private Sub grdGrid_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdGrid.LocationChanged
    tlpHeader.Left = grdGrid.Left + grdGrid.Width - tlpHeader.Width
        tlpFilter.Left = grdGrid.Left + grdGrid.Width - tlpFilter.Width
    tlpFooter.Left = grdGrid.Left + grdGrid.Width - tlpFooter.Width
  End Sub

  Private Sub FilterTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    If CType(sender, ToolStripTextBox).Focused = False Then Return
    If Not _DataSource Is Nothing Then
      Dim vFilter = ""
      For i As Integer = 0 To tlpFilter.Items.Count - 1
        If CType(tlpFilter.Items(i), ToolStripTextBox).Text <> "" And grdGrid.Columns(CType(tlpFilter.Items(i), ToolStripTextBox).Tag).Name.ToString.ToLower <> "row" Then
          If _DataSource.Table.Columns(grdGrid.Columns(CType(tlpFilter.Items(i), ToolStripTextBox).Tag).Name).DataType Is GetType(String) Then
            Dim vColumnName As String = grdGrid.Columns(CType(tlpFilter.Items(i), ToolStripTextBox).Tag).Name
                  vFilter &= IIf(vFilter = "", "", " AND ") & "(" & vColumnName & " LIKE '%" & CType(tlpFilter.Items(i), ToolStripTextBox).Text & "%' or " & vColumnName & " LIKE '%" & CType(tlpFilter.Items(i), ToolStripTextBox).Text.Replace("ی", "ي") & "%'  or " & vColumnName & " LIKE '%" & CType(tlpFilter.Items(i), ToolStripTextBox).Text.Replace("ي", "ی") & "%' or " & vColumnName & " LIKE '%" & CType(tlpFilter.Items(i), ToolStripTextBox).Text.Replace("ک", "ك") & "%'  or " & vColumnName & " LIKE '%" & CType(tlpFilter.Items(i), ToolStripTextBox).Text.Replace("ك", "ک") & "%')"
          Else
                  vFilter &= IIf(vFilter = "", "", " AND ") & "[" & grdGrid.Columns(CType(tlpFilter.Items(i), ToolStripTextBox).Tag).Name & "] = " & CType(tlpFilter.Items(i), ToolStripTextBox).Text
          End If
        End If
      Next
      If vPrimaryFilter = "" Then
        _DataSource.RowFilter = vFilter 'grdGrid.Columns(CType(sender, ToolStripTextBox).Tag).Name & " LIKE '%" & CType(sender, ToolStripTextBox).Text & "%'"
      Else
        _DataSource.RowFilter = "(" & vPrimaryFilter & ") " & IIf(vFilter = "", "", " AND (" & vFilter & ")")
      End If
      FillFooterInfo()
    End If
  End Sub

  Private Sub tlpButtonHeaderClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim i As Integer
    If Not _DataSource.Table.Columns.Contains(grdGrid.Columns(CType(sender, ToolStripButton).Tag).Name) Then Return
    If vFilterString = "" Then
      For i = 0 To grdGrid.Columns.Count - 1
        vFilterString &= "0,"
      Next
      If vFilterString.Length > 0 Then vFilterString = vFilterString.Substring(0, vFilterString.Length - 1)
    End If
    Dim vArray As Array = vFilterString.Split(",")
    'Dim vTurn As Integer = vArray(CType(sender, ToolStripButton).Tag).ToString.Split(".")(1)
    'Dim vMax As Integer = 0
    'For i = 0 To vArray.Length - 1
    'If Val(vArray(i).ToString.Split(".")(1)) > vMax Then vMax = Val(vArray(i).ToString.Split(".")(1))
    'Next
    Select Case vArray(CType(sender, ToolStripButton).Tag).ToString.Split(".")(0)
      Case "0"
        vArray(CType(sender, ToolStripButton).Tag) = "1"
        CType(sender, ToolStripButton).Text = CType(sender, ToolStripButton).Text.Replace("(ص)", "").Replace("(ن)", "") & "(ص)"
      Case "1"
        vArray(CType(sender, ToolStripButton).Tag) = "-1"
        CType(sender, ToolStripButton).Text = CType(sender, ToolStripButton).Text.Replace("(ص)", "").Replace("(ن)", "") & "(ن)"
      Case "-1"
        vArray(CType(sender, ToolStripButton).Tag) = "0"
        CType(sender, ToolStripButton).Text = CType(sender, ToolStripButton).Text.Replace("(ص)", "").Replace("(ن)", "")
    End Select
    vFilterString = ""
    Dim vOrder As String = ""
    For i = 0 To vArray.Length - 1
      If vArray(i) = "1" Then
        vOrder &= IIf(vOrder = "", "", ",") & grdGrid.Columns(CType(sender, ToolStripButton).Tag).Name
      ElseIf vArray(i) = "-1" Then
        vOrder &= IIf(vOrder = "", "", ",") & grdGrid.Columns(CType(sender, ToolStripButton).Tag).Name & " DESC"
      End If
      vFilterString &= vArray(i) & ","
    Next
    If vFilterString.Length > 0 Then vFilterString = vFilterString.Substring(0, vFilterString.Length - 1)
    _DataSource.Sort = vOrder
  End Sub


    Private Sub mnGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If grdGrid.Focused = True Then Return
        If e.KeyCode = Keys.Down Then
            If CurrentRowIndex < grdGrid.RowCount - 1 Then CurrentRowIndex += 1
        ElseIf e.KeyCode = Keys.Up Then
            If CurrentRowIndex > 1 Then CurrentRowIndex -= 1
        End If
        'RaiseEvent KeyDown(Me, e)
    End Sub

End Class
