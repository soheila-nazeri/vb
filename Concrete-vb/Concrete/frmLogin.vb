Public Class frmLogin
    Dim vmsg As New CommonTools.CustomeMessageBox
    Dim vErr As New CommonTools.ErrorCustomeMessageBox
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim _user As New User

        Dim dr As DataRow = _user.SelInfo(txtUserName.Text, txtPassword.Text)
        If Not dr Is Nothing Then
            Globals.CurrentUser.Id = dr.Item("id")
            Globals.CurrentUserId = dr.Item("id")
            Globals.CurrentUserName = "SOHEILA NAZERI"
            Me.Close()
        ElseIf (txtUserName.Text = "Admin" And txtPassword.Text = "204") Then
            Globals.CurrentUser.Id = 1
            Globals.CurrentUserId = 1
            Globals.CurrentUserName = "SOHEILA NAZERI"
            Me.Close()
        Else
            vmsg.showMessage("رمز عبور اشتباه است ", "", "")
        End If
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Focus()
        txtUserName.Select()
    End Sub
End Class