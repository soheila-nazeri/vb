Public Class frmReceipt
    Private vpeople As New people_dml
    Private vdml As New CONCRETE_DML
    Private vdr As DataRow
    Private isload As Boolean = False
    Dim vActionType As Integer
    Dim vmsg As New CommonTools.CustomeMessageBox
    Dim vErr As New CommonTools.ErrorCustomeMessageBox
    Dim vID As Long
    Dim row As Janus.Windows.GridEX.GridEXRow
    Public Sub New(ByVal dr As DataRow, ByVal type As Enums.FormActionType)
        InitializeComponent()
        vdr = dr
        If Not vdr Is Nothing Then vID = dr.Item("ID")
        If type = Enums.FormActionType.View Then
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnEmployer.Enabled = False
            btnCancellation.Enabled = False
            BtnOk.Enabled = False
            grpStore.Enabled = False
            GroupBox1.Enabled = False
        End If
        InitialForm()
        txtAddress.Focus()
        txtAddress.SelectAll()
        grdList.RootTable.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
    End Sub
    Private Sub InitialForm()

        grdList.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        isload = True
        grdList.Initialize("DELETED:DELETED:90;" &
                                   "NUMBER:NUMBER:90;" &
                                   "_DATE:_DATE:90;" &
                                   "AGE day:AGE:50::##,###0.###:::1;" &
                                   "WEIGHT gr:WEIGHT:80::##,###0.###:::1;" &
                                   "SPECIAL_WEIGHT:SPECIAL_WEIGHT:90::##,###0.###:::1;" &
                                   "LENGTH:LENGTH:90::##,###0.###:::1;" &
                                   "WIDTH:WIDTH:90::##,###0.###:::1;" &
                                   "HEIGHT:HEIGHT:90::##,###0.###:::1;" &
                                   "LOADING_SURFACE_CM2 cm2:LOADING_SURFACE_CM2:130::##,###0.###:::1;" &
                                   "SAMPLE_VOLUME_CM3 cm3:SAMPLE_VOLUME_CM3:130::##,###0.###:::1;" &
                                   "LOAD_SURFACE:LOAD_SURFACE:130::##,###0.###:::1;" &
                                   "CUBIC kg/cm2:CUBIC:130::##,###0.###:::1;" &
                                   "CYLINDER  kg/cm2:CYLINDER:130::##,###0.###:::1;" &
                                   "AVG_CYLINDER kg/cm2 :AVG_CYLINDER:130::##,###0.###:::1")

        '
        setdataDetail()
        '===================================
        cboYear.Initialize((New FinanceCycles)._Select(), "id", "title", False)

        cboRequester.Initialize(vpeople.SelSimplePeople(Enums.Keys.PeopleType.REQUESTER), "ID", "FULL_NAME", False)
        cboEmployer.Initialize(vpeople.SelSimplePeople(Enums.Keys.PeopleType.EMPLOYER), "ID", "FULL_NAME", False)

        If Not vdr Is Nothing Then

            txtAddress.Text = vdr("ADDRESS")
            txtCode.Text = vdr("CODE")
            txtDate.Text = vdr("_DATE")
            txtLocation.Text = vdr("LOCATION")
            txtRequesteCode.Text = vdr("REQUESTER_CODE")
            txtRegisterDate.Text = vdr("CREATE_DATE_TIME")
            txtUser.Text = vdr("USER_NAME")
            cboYear.SelectedValue = vdr("FC_ID")
            cboRequester.SelectedValue = vdr("REQUESTER_ID")
            cboEmployer.SelectedValue = vdr("EMPLOYER_ID")
        Else
            txtAddress.Text = ""
            txtCode.Text = ""
            txtDate.Text = Solar.GetDate(True)
            txtLocation.Text = ""
            txtRequesteCode.Text = ""
            txtUser.Text = Globals.CurrentUserName
            txtRegisterDate.Text = Solar.GetDateTime(True)
        End If
        '===================================
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub frmReceipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        ElseIf e.KeyCode = Keys.F6 Then
            btnAdd_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 Then
            btnEdit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F8 Then
            btnCancellation_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            BtnOk_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        ' چک کردن اخرین کد 
        '========================
        Dim vtmpID As Long = vID
        '========================
        If CheckData() = False Then Return
        Dim clsConcrete As New BaseConcert
        Dim clsConcreteItems As New BaseConcert.clsItems

        CType(grdList.DataSource, DataTable).DefaultView.RowFilter = ""
        Try
            SQL.BeginTransaction()

            clsConcrete.LOCATION = txtLocation.Text.Trim()
            clsConcrete.Address = txtAddress.Text.Trim()
            clsConcrete.CODE = txtCode.Text.Trim()
            clsConcrete.DATE_ = txtDate.Text.Trim()
            'clsConcrete.d txtDescription.Text = ""
            clsConcrete.LOCATION = txtLocation.Text.Trim()
            clsConcrete.REQUESTER_CODE = txtRequesteCode.Text.Trim()
            clsConcrete.EMPLOYER_ID = cboEmployer.SelectedDataRow("id")
            clsConcrete.REQUESTER_ID = cboRequester.SelectedDataRow("id")
            clsConcrete.Fc_ID = cboYear.SelectedDataRow("ID")
            clsConcrete.DATE_ = txtRegisterDate.Text

            If vtmpID <= 0 Then    ' EDIT RECEIPT AND DRAFT

                vID = clsConcrete.Insert(Nothing)

                For Each Dr As DataRow In CType(grdList.DataSource, DataTable).Rows

                    clsConcreteItems.Age = Dr("AGE")
                    clsConcreteItems.AvgCylinder = Dr("AVG_CYLINDER")
                    clsConcreteItems.LoadingSurfaceCm2 = Dr("LOADING_SURFACE_CM2")
                    clsConcreteItems.Cubic = Dr("CUBIC")
                    clsConcreteItems.Cylinder = Dr("CYLINDER")
                    clsConcreteItems.Date_ = Dr("_DATE")
                    clsConcreteItems.Height = Dr("HEIGHT")
                    clsConcreteItems.Length = Dr("LENGTH")
                    clsConcreteItems.LoadSurface = Dr("LOAD_SURFACE")
                    clsConcreteItems.Number = Dr("NUMBER")
                    clsConcreteItems.SpecialWeight = Dr("SPECIAL_WEIGHT")
                    clsConcreteItems.SampleVolumeCm3 = Dr("SPECIAL_WEIGHT")
                    clsConcreteItems.Weight = Dr("WEIGHT")
                    clsConcreteItems.Width = Dr("WIDTH")
                    clsConcreteItems.Con_ID = vID
                    If mnComponents.Utility.NVL(Dr("ID"), 0) > 0 Then
                        If Dr("DELETED") = 0 Then
                            clsConcreteItems.Delete(Dr("id"), Nothing)
                        Else
                            clsConcreteItems.Edit(Nothing)
                        End If
                    ElseIf mnComponents.Utility.NVL(Dr("ID"), 0) = 0 Then
                        clsConcreteItems.Insert(Nothing)
                    End If
                Next
            Else   '=========================================== INSERT RECEIPT AND DRAFT 
                clsConcrete.Edit(vID, Nothing)
                For Each Dr As DataRow In CType(grdList.DataSource, DataTable).Rows
                    clsConcreteItems.Reset()
                    If mnComponents.Utility.NVL(Dr("ID"), 0) > 0 Then
                        clsConcreteItems.Age = Dr("AGE")
                        clsConcreteItems.AvgCylinder = Dr("AVG_CYLINDER")
                        clsConcreteItems.LoadingSurfaceCm2 = Dr("LOADING_SURFACE_CM2")
                        clsConcreteItems.Cubic = Dr("CUBIC")
                        clsConcreteItems.Cylinder = Dr("CYLINDER")
                        clsConcreteItems.Date_ = Dr("_DATE")
                        clsConcreteItems.Height = Dr("HEIGHT")
                        clsConcreteItems.Length = Dr("LENGTH")
                        clsConcreteItems.LoadSurface = Dr("LOAD_SURFACE")
                        clsConcreteItems.Number = Dr("NUMBER")
                        clsConcreteItems.SpecialWeight = Dr("SPECIAL_WEIGHT")
                        clsConcreteItems.SampleVolumeCm3 = Dr("SPECIAL_WEIGHT")
                        clsConcreteItems.Weight = Dr("WEIGHT")
                        clsConcreteItems.Width = Dr("WIDTH")
                        clsConcreteItems.Con_ID = vID

                        If Dr("DELETED") = 0 Then
                            clsConcreteItems.Edit(Dr("ID"), Nothing)
                        Else
                            clsConcreteItems.Delete(Dr("id"), Nothing)
                        End If
                    ElseIf Dr("DELETED") = 0 Then
                        clsConcreteItems.Insert(Nothing)
                    End If
                Next

            End If
            '====================================================== 
            CType(grdList.DataSource, DataTable).DefaultView.RowFilter = ""
            SQL.CommitTransaction()

            vmsg.showMessage(txtCode.Text & " Saved ", "", "")
            CType(grdList.DataSource, DataTable).DefaultView.RowFilter = ""
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            SQL.RollbackTransaction()
            vID = vtmpID
            vErr.showMessage("Err" & ex.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Function CheckData() As Boolean
        Dim dt As DataTable = CType(grdList.DataSource, DataTable).Copy
        If txtDate.Text = "" Or txtDate.Text = "----/--/--" Or txtDate.Text.Contains("-") = True Then
            vmsg.showMessage("Please Enter Factor Date", "", "")
            txtDate.Focus()
            Return False
        End If

        If txtAddress.Text.Trim = "" Then
            vmsg.showMessage("Please Enter Address", "", "")
            txtAddress.Focus()
            Return False
        End If
        If txtLocation.Text.Trim = "" Then
            vmsg.showMessage("Please Enter Location", "", "")
            txtLocation.Focus()
            Return False
        End If
        If txtCode.Text.Trim = "" Then
            vmsg.showMessage("Please Enter Code", "", "")
            txtCode.Focus()
            Return False
        End If

        If txtRequesteCode.Text.Trim = "" Then
            vmsg.showMessage("Please Enter Request Code ", "", "")
            txtRequesteCode.Focus()
            Return False
        End If
        Return True
    End Function
    'Private Sub cboYear_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
    '    If isload = False Or vID_Receipt > 0 Then Return
    '    txtCode.Text = vdml.Get_MaxCode(Enums.Keys.GoodRequestType.PurchaseRequest, cboStore.SelectedValue, cboYear.SelectedValue).ToString
    '    txtCodeReceipt.Text = vdml.Get_MaxCode(Enums.Keys.StoreDocumentType.Receipt, cboStore.SelectedValue, cboYear.SelectedValue).ToString
    'End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim vfrm As New frmAddConcreteItems(Nothing)
        While True
            vfrm.clear()

            vfrm.ShowDialog()
            If vfrm.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim DR2 As DataRow = CType(grdList.DataSource, DataTable).NewRow
                DR2("AGE") = vfrm.txtAge.Text
                DR2("AVG_CYLINDER") = vfrm.txtAvgCylinder.Text
                DR2("LOADING_SURFACE_CM2") = vfrm.txtCm2.Text
                DR2("CUBIC") = vfrm.txtCublic.Text
                DR2("CYLINDER") = vfrm.txtCylinder.Text
                DR2("_DATE") = vfrm.txtDate.Text
                DR2("HEIGHT") = vfrm.txtHeight.Text
                DR2("LENGTH") = vfrm.txtlength.Text
                DR2("LOAD_SURFACE") = vfrm.txtLoadSurface.Text
                DR2("NUMBER") = vfrm.txtNumber.Text
                DR2("SPECIAL_WEIGHT") = vfrm.txtSpecialWeight.Text
                DR2("SAMPLE_VOLUME_CM3") = vfrm.txtVolumecm3.Text
                DR2("WEIGHT") = vfrm.txtWeight.Text
                DR2("WIDTH") = vfrm.txtwidth.Text
                CType(grdList.DataSource, DataTable).Rows.Add(DR2)
            Else
                Exit While
            End If
            grdList.RootTable.GridEX.MoveLast()
        End While
    End Sub
    Private Sub btnCancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancellation.Click
        If grdList.CurrentDataRow Is Nothing Then Return

        If vmsg.showMessage("Are You Sure To Delete", "yes", "no") = Windows.Forms.DialogResult.Yes Then
            Try
                If mnComponents.Utility.NVL(grdList.CurrentDataRow("ID"), 0) > 0 Then
                    grdList.CurrentDataRow("DELETED") = 1
                Else
                    CType(grdList.DataSource, DataTable).Rows.Remove(grdList.CurrentDataRow)
                End If
            Catch ex As Exception
                vErr.showMessage("can not delete" + ex.ToString())
            End Try
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If grdList.CurrentDataRow Is Nothing Then Return
        row = grdList.RootTable.GridEX.GetRow(grdList.CurrentRowIndex)
        'While True
        Dim vfrm As New frmAddConcreteItems(grdList.CurrentDataRow)
            If vfrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                grdList.CurrentDataRow("AGE") = vfrm.txtAge.Text
                grdList.CurrentDataRow("AVG_CYLINDER") = vfrm.txtAvgCylinder.Text
                grdList.CurrentDataRow("LOADING_SURFACE_CM2") = vfrm.txtCm2.Text
                grdList.CurrentDataRow("CUBIC") = vfrm.txtCublic.Text
                grdList.CurrentDataRow("CYLINDER") = vfrm.txtCylinder.Text
                grdList.CurrentDataRow("_DATE") = vfrm.txtDate.Text
                grdList.CurrentDataRow("HEIGHT") = vfrm.txtHeight.Text
                grdList.CurrentDataRow("LENGTH") = vfrm.txtlength.Text
                grdList.CurrentDataRow("LOAD_SURFACE") = vfrm.txtLoadSurface.Text
                grdList.CurrentDataRow("NUMBER") = vfrm.txtNumber.Text
                grdList.CurrentDataRow("SPECIAL_WEIGHT") = vfrm.txtSpecialWeight.Text
                grdList.CurrentDataRow("SAMPLE_VOLUME_CM3") = vfrm.txtVolumecm3.Text
                grdList.CurrentDataRow("WEIGHT") = vfrm.txtWeight.Text
                grdList.CurrentDataRow("WIDTH") = vfrm.txtwidth.Text
                'Else
                'Exit While
            End If
        'End While
        grdList.RootTable.GridEX.MoveTo(row)
    End Sub
    Private Function ScrollGrid() As Boolean
        If grdList.CurrentRow.RowIndex < CType(grdList.DataSource, DataTable).Rows.Count - 1 Then
            grdList.CurrentRowIndex = grdList.CurrentRowIndex + 1
        ElseIf grdList.CurrentRow.RowIndex = CType(grdList.DataSource, DataTable).Rows.Count - 1 Then
            BtnOk.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub setdataDetail()
        If Not vdr Is Nothing Then
            grdList.DataSource = (New CONCRETE_DML).SelConcreteItems(vdr("ID"))
        Else
            grdList.DataSource = (New CONCRETE_DML).SelConcreteItems(-1)
        End If

    End Sub
    Private Sub btnRequester_Click(sender As Object, e As EventArgs) Handles btnRequester.Click
        Dim vfrm As New frmPeopleList(1, Enums.Keys.PeopleType.REQUESTER)
        vfrm.btnSelect.Enabled = True
        vfrm.btnSelect.Visible = True
        vfrm.ShowDialog()
        cboRequester.Initialize(vpeople.SelSimplePeople(Enums.Keys.PeopleType.REQUESTER), "ID", "FULL_NAME", False)
    End Sub

    Private Sub btnEmployer_Click(sender As Object, e As EventArgs) Handles btnEmployer.Click
        Dim vfrm As New frmPeopleList(1, Enums.Keys.PeopleType.EMPLOYER)
        vfrm.btnSelect.Enabled = True
        vfrm.btnSelect.Visible = True
        vfrm.ShowDialog()
        cboEmployer.Initialize(vpeople.SelSimplePeople(Enums.Keys.PeopleType.REQUESTER), "ID", "FULL_NAME", False)
    End Sub
    Private Sub grdList_Double_Click(sender As Object, e As EventArgs) Handles grdList.Double_Click
        btnEdit_Click(Nothing, Nothing)
    End Sub
End Class