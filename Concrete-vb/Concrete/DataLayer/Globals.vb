Public Class Globals

    Public Structure CurrentUser
        Public Shared Id As Integer = -1
        Public Shared Name As String = ""
        Public Shared Admin As Boolean = False
        Public Shared EnglishName As String = ""
        Private x As Integer
    End Structure

    Public Shared [Alias] As Enums.Alias
    Public Shared SessionId As Long
    Public Shared ApplicationId As Long
    Public Shared ForceAudit As Boolean = False
    Public Shared ImagePath As String = Application.StartupPath.ToLower.Replace("\debug", "") & "\Images"
    Public Shared IsCenteralBillPrint As Boolean = False


    Public Shared CurrentUserId As Integer
    Public Shared CurrentUserName As String
    Public Shared IsLangugePersian As Boolean = True

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

    Public Shared Function FormatMoney(ByVal Value As String) As String
        Dim vReturn As String = ""
        Dim vRealValue As String = Value.Split(".")(0)
        Dim vDecimalPointValue As String = ""
        If Value.Split(".").Length > 1 Then vDecimalPointValue = Value.Split(".")(1)
        Dim i As Integer = 1
        If vRealValue.Length <= 3 Then
            vReturn = vRealValue
        Else
            While i <= vRealValue.Length \ 3
                vReturn = "," & Mid(vRealValue, vRealValue.Length + 1 - i * 3, 3) & vReturn
                i += 1
            End While
            If vRealValue.Length > (i - 1) * 3 Then vReturn = Left(vRealValue, vRealValue.Length - (i - 1) * 3) & vReturn
            If Left(vReturn, 1) = "," Then vReturn = Right(vReturn, vReturn.Length - 1)
        End If
        Return vReturn & IIf(vDecimalPointValue = "", "", "." & vDecimalPointValue)
    End Function

    Public Shared Function DeFormatMoney(ByVal Value As String) As String
        Return Value.Replace(",", "")
    End Function

    Public Shared Sub ModifyHistory(ByVal TYPE As Integer, ByVal REFERENCE_TYPE As Integer, ByVal REFERENCE_ID As Long, ByVal VALUE As String)
        SQL.ExecuteNonQuery("INSERT INTO " & SQL.GlobalDatabase & ".DBO.MODIFY_HISTORIES (TYPE,REFERENCE_TYPE,REFERENCE_ID,USE_ID,DATE_TIME,MACHIN_NAME,OS_USER_NAME,VALUE )" & vbCrLf &
                                        "VALUES(" & TYPE & "," & REFERENCE_TYPE & "," & REFERENCE_ID & "," & Globals.CurrentUser.Id & ",'" & SQL.getDateTime() & "'" &
                                        ",'" & My.Computer.Name & "','" & My.User.Name & "','" & VALUE & "')")

    End Sub
    Public Sub AddLog(ByVal Title As String, ByVal AppName As String, ByVal FormName As String, ByVal RowId As Integer, ByVal TableName As String, ByVal Type As Integer, ByVal Value As String, ByVal dtColumn As DataTable)
        Try
            SQL.BeginTransaction(Nothing)
            Dim str As String = "INSERT INTO HOTEL_LOG.DBO.TRANSACTIONS(TITLE,OS_USER_NAME,HOST_NAME,APP_NAME,DATE_TIME,USE_ID,FORM_NAME) " & vbCrLf &
                                "VALUES('" & Title & "','" & My.User.Name & "','" & My.Computer.Name & "','" & AppName & "','" & Solar.GetDateTime(True) & "'," & Globals.CurrentUser.Id & ",'" & FormName & "')" & vbCrLf &
                                "select max(id) from HOTEL_LOG.DBO.TRANSACTIONS"
            Dim TraID As Integer = SQL.ExecuteScalar(str)

            str = "INSERT INTO HOTEL_LOG.DBO.TRANSACTION_TABLES(TRA_ID,ROW_ID,TYPE,TABLE_NAME,VALUE)   " & vbCrLf &
                   "VALUES(" & TraID & "," & RowId & "," & Type & ",'" & TableName & "','" & Value & "')" & vbCrLf &
                    "select max(id) from HOTEL_LOG.DBO.TRANSACTION_TABLES"
            Dim TT_ID As Integer = SQL.ExecuteScalar(str)

            For Each dr As DataRow In dtColumn.Rows
                str = "INSERT INTO HOTEL_LOG.DBO.TRANSACTION_COLUMNS(TT_ID,COLUMN_NAME,TITLE,OLD_VALUE,NEW_VALUE)   " & vbCrLf &
                    "VALUES(" & TT_ID & ",'" & dr("COLUMN_NAME") & "','" & dr("TITLE") & "','" & dr("OLD_VALUE") & "','" & dr("NEW_VALUE") & "')"
                SQL.ExecuteNonQuery(str)
            Next
            SQL.CommitTransaction()
        Catch ex As Exception
            SQL.RollbackTransaction()
        End Try

    End Sub
End Class
