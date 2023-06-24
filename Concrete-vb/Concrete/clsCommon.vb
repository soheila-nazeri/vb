Public Class clsCommon
    Public Sub AddStringToDatatable(ByRef dt As DataTable, ByVal strColumns As String)
        Dim _Array() As String = strColumns.Split(",")
        For i As Integer = 0 To _Array.Length - 1
            dt.Columns.Add(_Array(i))
        Next
    End Sub
    Public Function GetStringColumnsValue(ByVal dt As DataTable, ByVal Columns As String) As String
        Dim StrColumnValue As String = ""
        For Each dr As DataRow In dt.Rows
            If dr.Item(Columns).ToString() <> "" Then StrColumnValue &= dr.Item(Columns).ToString() + ","
        Next
        If StrColumnValue.Length = 0 Then
            Return ""
        Else
            Return StrColumnValue.Remove(StrColumnValue.Length - 1, 1)
        End If

    End Function
End Class
