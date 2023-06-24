Public Class frmGird
    Private vIDS As String
    Public Property IDS() As String
        Get
            Return vIDS
        End Get
        Set(ByVal value As String)
            vIDS = value
        End Set
    End Property
    Private VTitle As String
    Public Property Title() As String
        Get
            Return VTitle
        End Get
        Set(ByVal value As String)
            VTitle = value
        End Set
    End Property
    Public Sub New(ByVal dt As DataTable, ByVal IDS As String)
        InitializeComponent()
        '=======================
        InitGrid()
        If dt.Columns.Contains("SELECTED") = False Then dt.Columns.Add("SELECTED", GetType(Boolean))
        SetChecked(IDS, dt)
        grdList.DataSource = dt
        '=======================
        grdList.Focus()
        grdList.Select()

        MoveCursor()
    End Sub
    Private Sub MoveCursor()
        Dim m As New System.Drawing.Point
    End Sub
    Private Sub InitGrid()
        Dim strInit As String = ":SELECTED:30:" & mnComponents.enmColumnType.CheckBox & ";" _
                                     & "عنوان:TITLE:180"
        grdList.Initialize(strInit)
        '===========================
        For Each COL As Janus.Windows.GridEX.GridEXColumn In grdList.RootTable.Columns
            grdList.ReadOnly(COL.Key.ToString) = True
        Next

        grdList.ReadOnly("SELECTED") = False
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.True
        grdList.ShowToolbar = False
        grdList.ShowColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        grdList.RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.False
    End Sub
    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        Try
            For Each dr As DataRow In CType(grdList.DataSource, DataTable).Rows
                dr.Item("SELECTED") = True
            Next
        Catch ex As Exception
        End Try
        CreateIDS()
    End Sub
    Private Sub btnUndoCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndoCheckAll.Click
        For Each dr As DataRow In CType(grdList.DataSource, DataTable).Rows
            dr.Item("SELECTED") = False
        Next
        CreateIDS()
    End Sub
    Private Sub frmListBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            CreateIDS()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Public Sub SetChecked(ByVal CheckItem As String, ByRef DT As DataTable)
        '==================
        If Not CheckItem Is Nothing Then
            Dim arr() As String
            arr = CheckItem.Split(",")
            Dim index As Integer = 0
            For I As Integer = 0 To DT.Rows.Count - 1
                index = Array.IndexOf(arr, DT.Rows(I).Item("ID").ToString())
                DT.Rows(I).Item("SELECTED") = IIf(index >= 0, True, False)
            Next
        Else
            For I As Integer = 0 To DT.Rows.Count - 1
                DT.Rows(I).Item("SELECTED") = False
            Next
        End If
        CreateIDS()
    End Sub
    Public Sub CreateIDS()
        '======================
        If grdList.DataSource Is Nothing Then Return
        IDS = ""
        Title = ""
        Dim dt As DataTable = CType(grdList.DataSource, DataTable).Copy
        dt.DefaultView.RowFilter = "SELECTED=" & True
        dt = dt.DefaultView.ToTable
        For Each dr As DataRow In dt.Rows
            IDS &= dr.Item("ID").ToString & ","
            Title &= dr.Item("TITLE").ToString & ","
        Next
        If Not IDS Is Nothing AndAlso IDS.Length > 0 Then IDS = IDS.Remove(IDS.Length - 1, 1)
        If Not Title Is Nothing AndAlso Title.Length > 0 Then Title = Title.Remove(Title.Length - 1, 1)
        '======================
    End Sub
    Private Sub grdList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdList.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ElseIf e.KeyCode = Keys.Enter Then
            Try
                grdList.RootTable.GridEX.MoveNext()
            Catch ex As Exception
                grdList.RootTable.GridEX.MovePrevious()
            End Try

            CreateIDS()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class