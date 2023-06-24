Public Class CONCRETE_DML : Inherits BaseConcert
    Public Function SelConcert() As DataTable
        Dim strsql As String
        strsql = "SELECT" & vbCrLf &
                    "CON.*,PEO_EMPLOYER.FIRST_NAME + ' ' + PEO_EMPLOYER.LAST_NAME AS EMPLOYER_FULL_NAME," & vbCrLf &
                    "PEO_REQUESTER.FIRST_NAME + ' ' + PEO_REQUESTER.LAST_NAME AS REQUESTER_FULL_NAME," & vbCrLf &
                    "FC.ID AS FC_ID,_USE.NAME AS USER_NAME " & vbCrLf &
                "FROM CONCRETE CON" & vbCrLf &
                    "INNER JOIN PEOPLE PEO_REQUESTER ON PEO_REQUESTER.ID=CON.REQUESTER_ID " & vbCrLf &
                    "INNER JOIN PEOPLE PEO_EMPLOYER ON PEO_EMPLOYER.ID=CON.EMPLOYER_ID " & vbCrLf &
                    "INNER JOIN USERS  _USE ON _USE.ID=CON.USE_ID_CREATOR" & vbCrLf &
                    "INNER JOIN FINANCE_CYCLES FC ON FC.ID=CON.FC_ID"
        Return SQL.ExecuteDataTable(strsql, Nothing)
    End Function
    Public Function SelConcreteItems(ByVal CON_ID As Long) As DataTable
        Dim strsql As String
        strsql = "SELECT
		            CD.*,0 AS DELETED 
                 FROM CONCRETE  CON
		            INNER JOIN CONCRETE_DETAILS CD ON CD.CON_ID =CON.ID" & " WHERE CON.ID=" & CON_ID
        Return SQL.ExecuteDataTable(strsql, Nothing)
    End Function
    Public Function DeleteConcrete(ByVal CON_ID As Long)
        Try
            Dim strsql As String
            strsql = "DELETE FROM CONCRETE_DETAILS WHERE CON_ID=" & CON_ID &
                     "DELETE FROM CONCRETE WHERE ID=" & CON_ID
            SQL.ExecuteNonQuery(strsql, Nothing)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
End Class
