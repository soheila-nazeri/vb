Public Class frmMain
    Public Sub New()         InitializeComponent()
        SQL.setConnectionString("DESKTOP-LJ8FABD\MOSAFER", "Concrete", "sa", "123")
    End Sub
    Private Sub btnConcertList_Click(sender As Object, e As EventArgs) Handles btnConcertList.Click
        Dim vfrm As New frmConcertList()
        vfrm.ShowDialog()
    End Sub

    Private Sub btnFinanceCycles_Click(sender As Object, e As EventArgs) Handles btnFinanceCycles.Click
        Dim vfrm As New frmReportFinance()
        vfrm.ShowDialog()
    End Sub

    Private Sub btnRequesterList_Click(sender As Object, e As EventArgs) Handles btnRequesterList.Click
        Dim vfrm As New frmPeopleList(Enums.FormActionType.add, Enums.Keys.PeopleType.REQUESTER)
        vfrm.ShowDialog()
    End Sub
    Private Sub btnPersonelList_Click(sender As Object, e As EventArgs) Handles btnPersonelList.Click
        Dim vfrm As New frmPeopleList(Enums.FormActionType.add, Enums.Keys.PeopleType.Personel)
        vfrm.ShowDialog()
    End Sub
    Private Sub btnAllPeople_Click(sender As Object, e As EventArgs) Handles btnAllPeople.Click
        Dim vfrm As New frmPeopleList(Enums.FormActionType.add, 0)
        vfrm.ShowDialog()
    End Sub

    Private Sub btnEmployerList_Click(sender As Object, e As EventArgs) Handles btnEmployerList.Click
        Dim vfrm As New frmPeopleList(Enums.FormActionType.add, Enums.Keys.PeopleType.EMPLOYER)
        vfrm.ShowDialog()
    End Sub
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim vfrm As New frmLogin()
        vfrm.ShowDialog()
    End Sub
End Class