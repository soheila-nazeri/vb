Public Class UcListBox
    Private vIDS As String
    Public Event ucListBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Property IDS() As String
        Get
            Return vIDS
        End Get
        Set(ByVal value As String)
            vIDS = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        For I As Integer = 0 To chk.Items.Count - 1
            chk.SetItemChecked(I, True)
        Next
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(sender, e)
    End Sub
    Private Sub btnUndoCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndoCheckAll.Click
        For I As Integer = 0 To chk.Items.Count - 1
            chk.SetItemChecked(I, False)
        Next
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(sender, e)
    End Sub
    Public Sub SetChecked(ByVal CheckItem As String)
        If Not CheckItem Is Nothing Then
            For I As Integer = 0 To chk.Items.Count - 1
                If CheckItem.Contains(CType(chk.Items.Item(I), DataRowView).Item("ID").ToString()) Then
                    chk.SetItemChecked(I, True)
                Else
                    chk.SetItemChecked(I, False)
                End If
            Next
        End If
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(Nothing, Nothing)
    End Sub
    Public Sub Initialize(ByVal dt As DataTable, ByVal ValueField As String, ByVal TextField As String)
        If Not dt Is Nothing Then
            dt.DefaultView.RowFilter = "ISNULL(ID,0)<>0"
            dt = dt.DefaultView.ToTable.Copy
        End If
        chk.Initialize(dt, ValueField, TextField, "")
        IDS = GetStringColumnsValue(dt, "ID")
        SetChecked(IDS)
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(Nothing, Nothing)
    End Sub
    Public Function GetStringColumnsValue(ByVal dt As DataTable, ByVal Columns As String) As String
        Dim StrColumnValue As String = ""
        For Each dr As DataRow In dt.Rows
            If dr.Item(Columns).ToString() <> "" Then StrColumnValue &= dr.Item(Columns).ToString() + ","
        Next
        Return StrColumnValue.Remove(StrColumnValue.Length - 1, 1)
    End Function
    Public Sub CreateIDS()
        IDS = ""
        For Each dr As DataRowView In chk.CheckedItems
            IDS &= dr.Item("ID").ToString & ","
        Next
        If Not IDS Is Nothing AndAlso IDS.Length > 0 Then IDS = IDS.Remove(IDS.Length - 1, 1)
        '======================
    End Sub
    Private Sub chk_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk.SelectedValueChanged
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(sender, e)
    End Sub
    Private Sub chk_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chk.Validating
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(sender, e)
    End Sub
    Private Sub chk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk.SelectedIndexChanged
        CreateIDS()
        RaiseEvent ucListBox_SelectedValueChanged(sender, e)
    End Sub
End Class
