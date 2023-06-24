Public Class UcEmploymentCode
    Private vEmploymentCode As String

    Public Property EmploymentCode() As String
        Get
            Return vEmploymentCode
        End Get
        Set(ByVal value As String)
            vEmploymentCode = value
        End Set
    End Property
    Private VID As Integer
    Public Property ID() As Integer
        Get
            Return VID
        End Get
        Set(ByVal value As Integer)
            VID = value
            Try
                txtEmploymentCode.Text = mnDataLayer.SQL.ExecuteScalar("SELECT CODE FROM PEOPLE WHERE ID=" & VID)
                SetValues()
            Catch ex As Exception
            End Try
            
        End Set
    End Property
    Private VFULL_NAME As String
    Public Property FULL_NAME() As String
        Get
            Return VFULL_NAME
        End Get
        Set(ByVal value As String)
            VFULL_NAME = value
        End Set
    End Property
    Private VCODE As String
    Public Property CODE() As String
        Get
            Return VCODE
        End Get
        Set(ByVal value As String)
            VCODE = value
        End Set
    End Property
    Public Event Key_Enter(ByVal sender As System.Object)
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub txtEmploymentCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmploymentCode.KeyDown
        If txtEmploymentCode.Text = "" Then
            Clear()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            SetCode()
            SendKenter(sender)
        ElseIf e.KeyCode = Keys.Space Then
            btnPeopleList_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub SendKenter(ByVal sender As System.Object)
        SetValues()
        RaiseEvent Key_Enter(sender)
        txtEmploymentCode.Focus()
        txtEmploymentCode.Select()
        txtEmploymentCode.SelectAll()

    End Sub
    Public Sub SetValues()

        Dim DR As DataRow = mnDataLayer.SQL.ExecuteDataRow("SELECT ID,CODE,FIRST_NAME +'-' +LAST_NAME AS FULL_NAME FROM PEOPLE WHERE ID=" & VID)
        If Not DR Is Nothing Then
            VID = DR.Item("ID")
            VFULL_NAME = mnComponents.Utility.NVL(DR.Item("FULL_NAME"), "")
            VCODE = mnComponents.Utility.NVL(DR.Item("CODE"), "")
            lblFullName.Text = mnComponents.Utility.NVL(DR.Item("FULL_NAME"), "")
        Else
            Clear()
        End If

    End Sub
    Public Sub Clear()
        lblFullName.Text = ""
        txtEmploymentCode.Text = ""
        EmploymentCode = ""
        VID = 0
        vEmploymentCode = 0
        VCODE = 0
        VFULL_NAME = ""
       
    End Sub
    Private Sub btnPeopleList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeopleList.Click
        Dim vfrm As New People.frmPersonalList(mnComponents.Enums.FormActionType.SingleSelection)
        vfrm.ShowDialog()
        If vfrm.DialogResult = Windows.Forms.DialogResult.OK Then

            VID = vfrm.SelectedRow.Item("ID").ToString()
            If mnComponents.Utility.NVL(mnDataLayer.SQL.ExecuteScalar(" SELECT ISNULL(VALUE,0) FROM PEOPLE_PROPERTIES WHERE PEO_ID=" & VID & " AND TYPE = 1231", Nothing), 0) = 0 Then
                MsgBox("پرسنل مورد نظر غیر فعال است")
                Clear()
                Exit Sub
            End If

            txtEmploymentCode.Text = vfrm.SelectedRow.Item("CODE").ToString()
            lblFullName.Text = vfrm.SelectedRow.Item("FIRST_NAME").ToString() + "-" + vfrm.SelectedRow.Item("LAST_NAME").ToString()

            VCODE = vfrm.SelectedRow.Item("CODE").ToString()
            VFULL_NAME = vfrm.SelectedRow.Item("FIRST_NAME").ToString() + "-" + vfrm.SelectedRow.Item("LAST_NAME").ToString()
            SendKenter(txtEmploymentCode)
        End If
    End Sub
    Private Sub txtEmploymentCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmploymentCode.Validating
        SetCode()
    End Sub
    Public Sub SetCode()
        Dim DR As DataRow = mnDataLayer.SQL.ExecuteDataRow("SELECT ID,CODE,FIRST_NAME +'-' +LAST_NAME AS FULL_NAME FROM PEOPLE WHERE CODE='" & txtEmploymentCode.Text.Trim & "'" & " AND TYPE=1091")
        If Not DR Is Nothing Then
            VID = DR.Item("ID")
            If mnComponents.Utility.NVL(mnDataLayer.SQL.ExecuteScalar(" SELECT ISNULL(VALUE,0) FROM PEOPLE_PROPERTIES WHERE PEO_ID=" & VID & " AND TYPE = 1231", Nothing), 0) = 0 Then
                MsgBox("پرسنل مورد نظر غیر فعال است")
                Clear()
                Exit Sub
            End If
            VFULL_NAME = mnComponents.Utility.NVL(DR.Item("FULL_NAME"), "")
            VCODE = mnComponents.Utility.NVL(DR.Item("CODE"), "")
            lblFullName.Text = mnComponents.Utility.NVL(DR.Item("FULL_NAME"), "")
            If Val(VCODE) = 0 Then
                Clear()
            End If
        Else
        End If
    End Sub
End Class
