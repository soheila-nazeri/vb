Public Class ErrorCustomeMessageBox
    Public MessageBox As String
    Public Sub New()
        InitializeComponent()
        lblMessage.Text = MessageBox
        DialogResult = Windows.Forms.DialogResult.Cancel
        btnExit.Visible = False
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub
    Public Function showMessage(ByVal strMessage As String) As Windows.Forms.DialogResult
        lblMessage.Text = strMessage
        Me.ShowDialog()
        btnOk.Focus()
        If Me.DialogResult = Windows.Forms.DialogResult.Cancel Then Me.DialogResult = Windows.Forms.DialogResult.No
        Return Me.DialogResult
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class