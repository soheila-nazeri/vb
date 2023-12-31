Public Class frmSearchList
    Private vSelectedRow As DataRow
    Public Property Selectedrow() As DataRow
        Get
            Return vSelectedRow
        End Get
        Set(ByVal value As DataRow)
            vSelectedRow = value
        End Set
    End Property
    Dim vdtBase As DataTable
    Public Sub New(ByVal dt As DataTable)
        InitializeComponent()
        InitGrid()
        grdList.DataSource = dt
        vdtBase = dt
        Me.Height = 550
    End Sub
    Private Sub InitGrid()
        Dim STRINIT As String = "TITLE:TITLE:500"
        grdList.Initialize(STRINIT)
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        grdList.RootTable.GridEX.RowFormatStyle.BackColor = Color.Honeydew
        grdList.RootTable.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.False
        grdList.ShowToolbar = False
        grdList.ShowColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        grdList.RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        txtTitle.Focus()
        txtTitle.Select()
    End Sub
    Private Sub frmOldAccountList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape : DialogResult = Windows.Forms.DialogResult.OK
        End Select
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub grdlist_Double_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdList.Double_Click
        btnSelect_Click(sender, e)
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            vSelectedRow = grdList.CurrentDataRow
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
        End Try
    End Sub
    Private Sub grdlist_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdList.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSelect_Click(sender, e)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf e.KeyCode = Keys.Tab Then
            grdList.RootTable.GridEX.Select()
            grdList.RootTable.GridEX.MoveFirst()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        ElseIf e.KeyCode = Keys.Up Then
            If grdList.CurrentRowIndex = 0 Then
                txtTitle.Focus()
                txtTitle.Select()
            End If
        End If
    End Sub
    Private Sub txtTitle_Keyup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTitle.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            grdList.Focus()
            grdList.Select()
        Else
            filterring()
        End If
    End Sub
    Private Sub txtTitle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        e.KeyChar = Convert.ToChar(e.KeyChar.ToString.Replace("ی", "ي"))
    End Sub
    Private Sub filterring()
        Try
            Dim vFilter As String = " "
            vFilter &= IIf(Len(txtTitle.Text) > 0, "  TITLE LIKE '%" & txtTitle.Text & "%'", "")
            '==================

            Dim vdt As DataTable = vdtBase.Copy
            vdt.DefaultView.RowFilter = vFilter
            vdt = vdt.DefaultView.ToTable.Copy

            grdList.DataSource = vdt
        Catch ex As Exception
        End Try
        '==================
    End Sub
End Class