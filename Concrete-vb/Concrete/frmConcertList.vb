Public Class frmConcertList
    Dim vmsg As New CommonTools.CustomeMessageBox
    Dim vErr As New CommonTools.ErrorCustomeMessageBox
    Dim row As Janus.Windows.GridEX.GridEXRow
    Public Sub New()
        InitializeComponent()
        '====================
        grdList.Initialize("EMPLOYER_FULL_NAME:EMPLOYER_FULL_NAME:120;" &
                            "REQUESTER_FULL_NAME:REQUESTER_FULL_NAME:120;" &
                            "LOCATION:LOCATION:90;" &
                            "CODE:CODE:110;" &
                            "_DATE:_DATE:140;" &
                            "REQUESTER_CODE:REQUESTER_CODE:110;" &
                            "_DATE:_DATE:150;" &
                            "ADDRESS:ADDRESS:400")
        '====================
        setDataSource()
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        'grdList.RootTable.GridEX.FrozenColumns = 4
        'grdList.RootTable.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim vfrm As New frmReceipt(Nothing, 0)
        If vfrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            setDataSource()
            grdList.RootTable.GridEX.MoveLast()
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        row = grdList.RootTable.GridEX.GetRow(grdList.CurrentRowIndex)
        Dim vfrm As New frmReceipt(grdList.CurrentDataRow, 0)
        If vfrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            setDataSource()
            grdList.RootTable.GridEX.MoveTo(row)
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub frmPersonalList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F6 Then
            btnAdd_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 Then
            btnEdit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F8 Then
            btnDelete_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            btnView_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim vfrm As New frmReceipt(grdList.CurrentDataRow, Enums.FormActionType.View)
        vfrm.ShowDialog()
    End Sub
    Private Sub cboUnit_SelectedIndexChanged(sender As Object, e As EventArgs)
        setDataSource()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        '======================================
        Dim ds As New DataSet
        ds.Clear()

        Dim dtConcrete As DataTable = CType(grdList.DataSource, DataTable).Copy
        dtConcrete.Columns.Add("Arm", GetType(Byte()))
        'dtConcrete.Rows(0).Item("Arm") = IO.File.ReadAllBytes(Globals.ImagePath & "\PrinterArm.jpg")
        dtConcrete.TableName = "dtConcrete"
        ds.Tables.Add(dtConcrete)

        Dim dtConcreteItems As DataTable = (New CONCRETE_DML).SelConcreteItems(grdList.CurrentDataRow("ID"))
        dtConcreteItems.TableName = "dtConcreteItems"
        ds.Tables.Add(dtConcreteItems)
        Dim v1 As New mnStimulsoftReport.frmPreview(ds, "mrtConcertList", False)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim vdml As New CONCRETE_DML()
        If vdml.DeleteConcrete(grdList.CurrentDataRow("ID")) Then
            setDataSource()
            vmsg.showMessage("Delete با موفقیت انجام شد", "", "")
        End If
    End Sub
    Private Sub setDataSource()
        grdList.DataSource = (New CONCRETE_DML).SelConcert()
    End Sub

    Private Sub grdList_Double_Click(sender As Object, e As EventArgs) Handles grdList.Double_Click
        btnEdit_Click(Nothing, Nothing)
    End Sub
End Class