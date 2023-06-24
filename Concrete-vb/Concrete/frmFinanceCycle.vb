Public Class frmFinanceCycle
    Private vClsFinance As New FinanceCycles
    Private vID As Integer = 0
    Public Sub New(ByVal dr As DataRow)
        InitializeComponent()
        If Not (dr Is Nothing) Then
            vID = dr("ID")
            txtTitle.Text = dr("TITLE")
            txtFromDate.Text = dr("FROM_DATE")
            txtToDate.Text = dr("TO_DATE")
            If mnComponents.Utility.NVL(dr("ENABLE"), 0) = True Then chkStatus.Checked = True
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If CheckData() = False Then Return
        Try
            SQL.BeginTransaction()
            vClsFinance.Reset()
            vClsFinance.TITLE = txtTitle.Text
            vClsFinance.FROM_DATE = txtFromDate.Text
            vClsFinance.TO_DATE = txtToDate.Text
            If chkStatus.Checked = True Then
                vClsFinance.ENABLE = 1
            Else
                vClsFinance.ENABLE = 0
            End If

            If vID > 0 Then
                vClsFinance.Edit(vID, Nothing)
            Else
                vClsFinance.Insert(Nothing)
            End If


            SQL.CommitTransaction()
            MessageBox.Show("اطلاعات با موفقیت ثبت شد")
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            SQL.RollbackTransaction()
            MsgBox(ex.Message)
            DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub
    Private Function CheckData() As Boolean
        Dim _count As Integer = (New FinanceCycles).GetFinanceCycles()

        If chkStatus.Checked = True And _count > 0 Then
            MessageBox.Show("فقط یک سال مالی می تواند فعال باشد")
            Return False
        End If
        Return True
    End Function
    Private Sub frmFinanceCycle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            BtnOk_Click(Nothing, Nothing)
        End If
    End Sub
End Class