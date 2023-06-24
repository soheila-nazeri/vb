Public Class frmReportFinance
    Private isload As Boolean = False

    Public Sub New()
        InitializeComponent()
        InitGrid()
        isload = True
        setdata()
    End Sub
    Private Sub setdata()
        If isload = False Then Return
        grdList.DataSource = (New FinanceCycles)._Select()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim vfrm As New frmFinanceCycle(Nothing)
        If vfrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            setdata()
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        Dim vfrm As New frmFinanceCycle(grdList.CurrentDataRow)
        If vfrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            setdata()
        End If
    End Sub
    Private Sub btnCancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancellation.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        If MessageBox.Show("ایا برای Delete مطمئن هستید؟", "توجه", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Dim clsfinance As New FinanceCycles
            clsfinance.Delete(grdList.CurrentDataRow("id"), Nothing)
            setdata()
        End If
    End Sub
    Private Sub frmReportFinance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        ElseIf e.KeyCode = Keys.F2 Then
            btnAdd_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnEdit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btnCancellation_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            btnExit_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub InitGrid()
        grdList.Initialize("title:title:100;" &
                                   "FROM_DATE:FROM_DATE:100;" &
                                   "TO_DATE:TO_DATE:100;" &
                                   "ENABLE:ENABLE:50:" & mnComponents.enmColumnType.CheckBox)
        grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.False
        grdList.RootTable.TotalRowFormatStyle.BackColor = Color.Azure
        grdList.RootTable.TotalRow = Janus.Windows.GridEX.InheritableBoolean.False
        grdList.RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        grdList.RightToLeft = Windows.Forms.RightToLeft.Yes
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        grdList.GroupByBoxVisible = False
    End Sub

End Class