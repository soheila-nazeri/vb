Imports BaseClass
Public Class frmAddConcreteItems
    Private vDate As String
    Dim vmsg As New CommonTools.CustomeMessageBox
    Dim vErr As New CommonTools.ErrorCustomeMessageBox
    Dim vdr As DataRow
    Public Sub New(ByVal dr As DataRow)
        InitializeComponent()
        vdr = dr
        clear()
        SetData()
    End Sub
    Public Sub clear()
        txtAge.Text = "0"
        txtAvgCylinder.Text = "0"
        txtCm2.Text = "0"
        txtCublic.Text = "0"
        txtCylinder.Text = "0"
        txtDate.Text = Solar.GetDate(True)
        txtHeight.Text = "0"
        txtlength.Text = "0"
        txtLoadSurface.Text = "0"
        txtNumber.Text = "0"
        txtSpecialWeight.Text = "0"
        txtVolumecm3.Text = "0"
        txtWeight.Text = "0"
        txtwidth.Text = "0"
        txtNumber.Focus()
        txtNumber.Select()
        txtNumber.SelectAll()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub SetData()
        If Not vdr Is Nothing Then
            txtAge.Text = mnComponents.Utility.NVL(vdr("AGE"), 0)
            txtAvgCylinder.Text = mnComponents.Utility.NVL(vdr("AVG_CYLINDER"), 0)
            txtCm2.Text = mnComponents.Utility.NVL(vdr("LOADING_SURFACE_CM2"), 0)
            txtCublic.Text = mnComponents.Utility.NVL(vdr("CUBIC"), 0)
            txtCylinder.Text = mnComponents.Utility.NVL(vdr("CYLINDER"), 0)
            txtDate.Text = mnComponents.Utility.NVL(vdr("_DATE"), Solar.GetDate(True))
            txtHeight.Text = mnComponents.Utility.NVL(vdr("HEIGHT"), 0)
            txtlength.Text = mnComponents.Utility.NVL(vdr("LENGTH"), 0)
            txtLoadSurface.Text = mnComponents.Utility.NVL(vdr("LOAD_SURFACE"), 0)
            txtNumber.Text = mnComponents.Utility.NVL(vdr("NUMBER"), 0)
            txtSpecialWeight.Text = mnComponents.Utility.NVL(vdr("SPECIAL_WEIGHT"), 0)
            txtVolumecm3.Text = mnComponents.Utility.NVL(vdr("SAMPLE_VOLUME_CM3"), 0)
            txtWeight.Text = mnComponents.Utility.NVL(vdr("WEIGHT"), 0)
            txtwidth.Text = mnComponents.Utility.NVL(vdr("WIDTH"), 0)
        End If
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            If CheckData() = False Then Return
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            vErr.showMessage(ex.ToString())
        End Try
    End Sub
    Private Sub frmAddGood_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            BtnOk_Click(Nothing, Nothing)
        End If
    End Sub
    Private Function CheckData() As Boolean
        Try
            If IsNumeric(txtNumber.Text) = False Or Trim(txtNumber.Text) = "0" Then
                vmsg.showMessage("Not Correct", "", "")
                txtNumber.Text = ""
                txtNumber.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            vErr.showMessage(ex.ToString())
        End Try
    End Function
End Class