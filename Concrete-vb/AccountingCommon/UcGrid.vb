Public Class UcGrid
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub txtGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrid.KeyDown
        Dim vfrm As New frmGird(Nothing, "")
        vfrm.ShowDialog()
    End Sub
End Class
