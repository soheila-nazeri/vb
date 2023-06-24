Public Class CustomeMessageBox
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
    Public Function showMessage(ByVal strMessage As String, ByVal btn1 As String, ByVal btn2 As String) As Windows.Forms.DialogResult
        lblMessage.Text = strMessage
        If btn1 <> "" Then btnOk.Text = btn1 : btnOk.Visible = True
        If btn2 <> "" Then
            btnExit.Text = btn2 : btnExit.Visible = True
        Else
            btnExit.Visible = False

        End If

        If btn1 = "yes" Or btn1 = "بله" Then
            picQuestion.Visible = True
            picInfo.Visible = False
            btnOk.Focus()
        Else
            picQuestion.Visible = False
            picInfo.Visible = True
        End If
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.Cancel Then Me.DialogResult = Windows.Forms.DialogResult.No
        Return Me.DialogResult
    End Function
    Private Sub CustomeMessageBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End If
    End Sub
End Class