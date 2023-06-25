
Public Class frmPeopleList
    Private vDML As New people_dml
    Private vActionType As Enums.FormActionType
    Private vgrdCurrentDataRow As DataRow
    Private vPeopleType As Enums.Keys.PeopleType
    Public ReadOnly Property SelectedRow() As DataRow
        Get
            Return vgrdCurrentDataRow
        End Get
    End Property
    Public WriteOnly Property EnableEditInfo() As Boolean
        Set(ByVal value As Boolean)
            btnAdd.Enabled = value
        End Set
    End Property
    Public Sub New(ByVal ActionType As Enums.FormActionType, ByVal PeopleType As Integer)
        InitializeComponent()
        vActionType = ActionType
        vPeopleType = PeopleType
        grdList.Initialize("CODE:CODE:70;" &
                                "FIRST_NAME:FIRST_NAME:70;" &
                                "LAST_NAME:LAST_NAME:95;" &
                                "FATHER_NAME:FATHER_NAME:60;" &
                                "CERTIFICATE_NO:CERTIFICATE_NO:70;" &
                                "ACC_CODE:ACC_CODE:70;" &
                                "NATIONAL_CODE:NATIONAL_CODE:70;" &
                                "BIRTHDAY:BIRTHDAY:70;" &
                                "BIRTHPLACE:BIRTHPLACE:70;" &
                                "BIRTH_REGISTER_DATE:BIRTH_REGISTER_DATE:150;" &
                                "BIRTH_REGISTER_PLACE:BIRTH_REGISTER_PLACE:70;" &
                                "NATIONALITY:NATIONALITY:70;" &
                                "RESIDENCE_PLACE:RESIDENCE_PLACE:70;" &
                                "GENDER_TITLE:GENDER_TITLE:70;" &
                                "MARITAL_DATE:MARITAL_DATE:70;" &
                                "ADDRESS:ADDRESS:70;" &
                                "JOB_TITLE:JOB_TITLE:70;" &
                                "WORK_PLACE:WORK_PLACE:70;" &
                                "TEL_NO:TEL_NO:70;" &
                                "MOBILE_NO:MOBILE_NO:70;" &
                                "JOB_TEL_NO:JOB_TEL_NO:70")
        setDataSource()
        If vActionType = Enums.FormActionType.SingleSelection Then
            btnSelect.Enabled = True
        Else
            btnSelect.Enabled = False
        End If
        If vActionType = Enums.FormActionType.add Then
            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Else
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
        grdList.GroupByBoxVisible = False
    End Sub
    Private Sub setDataSource()
        grdList.DataSource = vDML.selPeopleByFilter(vPeopleType, txtName.Text, txtLastName.Text, txtNationalCode.Text)
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim vForm As New frmPeople(Nothing, vPeopleType)
        vForm.ShowDialog()
        If vForm.DialogResult = Windows.Forms.DialogResult.OK Then
            If vActionType = Enums.FormActionType.SingleSelection Then
                vgrdCurrentDataRow = vDML.Select(vForm.Id).Rows(0)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Return
            End If
            setDataSource()
        End If
        vForm.Dispose()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        Dim vForm As New frmPeople(grdList.CurrentDataRow, vPeopleType)
        vForm.ShowDialog()
        If vForm.DialogResult = Windows.Forms.DialogResult.OK Then
            If vActionType = Enums.FormActionType.SingleSelection Then
                vgrdCurrentDataRow = vDML.Select(vForm.Id).Rows(0)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Return
            End If
            setDataSource()
        End If
        vForm.Dispose()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        If MessageBox.Show(("are you sure ?"), "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                vDML.Delete(grdList.CurrentDataRow.Item("ID"), Nothing)
            Catch ex As Exception
            End Try
            setDataSource()
        End If
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        vgrdCurrentDataRow = grdList.CurrentDataRow
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub frmPeopleList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F6 Then
            btnAdd_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 Then
            btnEdit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F8 Then
            btnDelete_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            btnSelect_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtLastName.Text.Trim = "" AndAlso txtName.Text.Trim = "" AndAlso txtNationalCode.Text.Trim = "" Then
            If MessageBox.Show(" without filter ", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                setDataSource()
            End If
        Else
            setDataSource()
        End If
    End Sub
End Class