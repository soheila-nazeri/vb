Public Class Utility
    Public Shared Function NVL(ByVal Variable As Object, ByVal Value As Object) As Object
        If Variable Is Nothing Then
            NVL = Value
        ElseIf IsDBNull(Variable) Then
            NVL = Value
        ElseIf CType(Variable, String) = "" Then
            NVL = Value
        Else
            NVL = Variable
        End If
    End Function


    Public Shared Function getColumnGridTitle(ByVal Title As Object) As Object
        If Globals.IsLangugePersian = False Then
            If Not IsDBNull(Title) AndAlso Title <> "" Then
                Title = Title.Replace("ي", "ی").Replace("ك", "ک")
                If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml") Then
                    Dim ds As New DataSet
                    ds.ReadXml(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml")

                    For Each dr As DataRow In ds.Tables(0).Rows
                        dr("TITLE") = dr("TITLE").ToString.Replace("ي", "ی").Replace("ك", "ک")
                    Next

                    If ds.Tables(0).Select("TITLE='" & Title & "'").Length > 0 Then
                        Return NVL(ds.Tables(0).Select("TITLE='" & Title & "'")(0)("AR_TITLE"), Title)
                    Else
                        If SQL.ExecuteScalar("SELECT COUNT(*) FROM OBJECT_DICTUNARY WHERE TITLE='" & Title & "'") = 0 Then
                            SQL.ExecuteNonQuery("INSERT INTO OBJECT_DICTUNARY(TITLE) " & vbCrLf &
                                                                                "VALUES('" + Title & "')")
                        End If
                    End If
                    Return Title
                End If
            End If
        End If
        Return Title
    End Function

End Class
