
Imports System.Data.SqlClient

Public Class SQL
   Public Shared UserDate As String = ""
   Public Shared vErrMessage As String
    Private Shared ConnectionString As String = "Data Source=Concrete;User ID=sa;Password=123;Initial Catalog=Concrete"
    Private Shared GlobalCnn As SqlConnection = Nothing
   Public Shared GlobalDatabase As String
   Public Shared GlobalServer As String
   Public Shared CurrentUserId As Integer = 0
   Private Shared tr As SqlTransaction = Nothing
   Private Shared trCnnString As String = ""
   Public Shared LogInsert As Boolean = True

   Public Shared Function GetConnection(Optional ByVal Server As String = "", Optional ByVal DataBase As String = "", Optional ByVal UserName As String = "", Optional ByVal Password As String = "") As SqlConnection
 
      Dim vCnnStr As String = "Data Source=" & IIf(Server.Trim = "", GlobalServer, Server) & ";User ID=" & UserName & ";Password=" & Password & ";Initial Catalog=" & IIf(DataBase.Trim = "", GlobalDatabase, DataBase)
        If UserName = "" Then vCnnStr = ConnectionString
        Dim Cnn As SqlConnection = New SqlConnection(vCnnStr)
      Try
         Cnn.Open()
         Dim cmd As New SqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED", Cnn)
         cmd.ExecuteNonQuery()

            cmd = New SqlCommand("SET LOCK_TIMEOUT 5000", Cnn)
         cmd.ExecuteNonQuery()
         Return Cnn
      Catch ex As Exception
         Return Nothing
      End Try

   End Function

   Public Shared Sub setConnectionString(ByVal Server As String, ByVal DataBase As String, ByVal UserName As String, ByVal Password As String)
      If DataBase.Trim <> "" Then GlobalDatabase = DataBase
      If Server.Trim <> "" Then GlobalServer = Server
      ConnectionString = "Data Source=" & GlobalServer & ";User ID=" & UserName & ";Password=" & Password & ";Initial Catalog=" & GlobalDatabase
      If Not GlobalCnn Is Nothing Then
         If GlobalCnn.State = ConnectionState.Open Then GlobalCnn.Close()
         GlobalCnn.Dispose()
         GlobalCnn = Nothing
      End If
      GlobalCnn = GetConnection()
   End Sub

   Public Shared Sub setConnectionString(ByVal str As String)
      Dim a As Array = str.Split(";")
      For i As Integer = 0 To a.Length - 1
         If a(i).ToString.Split("=")(0).Trim.ToLower = "data source" Then
            GlobalServer = a(i).ToString.Split("=")(1)
         ElseIf a(i).ToString.Split("=")(0).Trim.ToLower = "initial catalog" Then
            GlobalDatabase = a(i).ToString.Split("=")(1)
         End If
      Next
      ConnectionString = str
      If Not GlobalCnn Is Nothing Then
         GlobalCnn.Dispose()
         GlobalCnn = Nothing
      End If
      GlobalCnn = GetConnection()
   End Sub

   Public Shared Function BeginTransaction(Optional ByVal cnn As SqlConnection = Nothing) As Boolean
      If tr Is Nothing Then
         If Not cnn Is Nothing Then
            If cnn.State = ConnectionState.Closed Then cnn.Open()
            tr = cnn.BeginTransaction(IsolationLevel.ReadUncommitted) 'IsolationLevel.ReadCommitted)
            trCnnString = cnn.ConnectionString
         Else
            If GlobalCnn.State = ConnectionState.Closed Then GlobalCnn.Open()
            tr = GlobalCnn.BeginTransaction(IsolationLevel.ReadUncommitted) 'IsolationLevel.ReadCommitted)
            trCnnString = GlobalCnn.ConnectionString
         End If
         Return True
      Else
         Return False
      End If
   End Function

   Public Shared Function CommitTransaction() As Boolean
      If tr Is Nothing Then
         Return False
      Else
         tr.Commit()
         tr.Dispose()
         tr = Nothing
         trCnnString = ""
         Return True
      End If
   End Function

   Public Shared Function RollbackTransaction() As Boolean
      If tr Is Nothing Then
         Return False
      Else
         tr.Rollback()
         tr.Dispose()
         tr = Nothing
         trCnnString = ""
         Return True
      End If
   End Function

   Public Shared Sub CloseConnection(Optional ByVal cnn As SqlConnection = Nothing)
      If cnn Is Nothing Then
         If GlobalCnn.State = ConnectionState.Open Then GlobalCnn.Close()
         GlobalCnn.Dispose()
         GlobalCnn = Nothing
      Else
         If cnn.State = ConnectionState.Open Then cnn.Close()
         cnn.Dispose()
         cnn = Nothing
      End If
   End Sub

   Public Shared Function ExecuteReader(ByVal SqlString As String) As SqlDataReader
      Dim cmd As New SqlCommand
      vErrMessage = ""
      Try
         cmd.Connection = GlobalCnn
         cmd.Transaction = tr
         cmd.CommandText = SqlString
         Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
      Catch exp As SqlException
         OLEDBErrorHandle(exp, SqlString)
         Throw exp
      End Try
      Return Nothing
   End Function

   Public Shared Function ExecuteNonQuery(ByVal SqlString As String, Optional ByVal cnn As SqlConnection = Nothing) As Integer
      Dim cmd As New SqlCommand
      vErrMessage = ""
      cmd.Connection = cnn
      If cmd.Connection Is Nothing Then cmd.Connection = GlobalCnn
      If cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Open()
      If Not tr Is Nothing AndAlso cmd.Connection.ConnectionString = trCnnString Then cmd.Transaction = tr
      cmd.CommandType = CommandType.Text
      Dim vCount As Integer
      Try
         cmd.CommandText = SqlString.Replace("ي", "ی").Replace("ك", "ک")
         vCount = cmd.ExecuteNonQuery()
         If LogInsert = True Then
            Try
                    cmd.CommandText = "INSERT INTO CONCRETE_LOG.DBO.SQL_COMMANDS(DATE_TIME, U_USER_ID, COMMAND_TEXT) VALUES('" & DateTime.Today.ToString("yyyy-MM-dd") & "'," & CurrentUserId & ",'" & SqlString.Replace("'", "''") & "')"
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            OLEDBErrorHandle(ex, SqlString)
            Throw ex
        End Try
        Return vCount
    End Function

    Public Shared Function ExecuteNonQuery(ByRef Command As SqlCommand, Optional ByVal cnn As SqlConnection = Nothing) As Integer
        vErrMessage = ""
        Command.Connection = cnn
        If Command.Connection Is Nothing Then Command.Connection = GlobalCnn
        If Command.Connection.State = ConnectionState.Closed Then Command.Connection.Open()
        If Not tr Is Nothing AndAlso Command.Connection.ConnectionString = trCnnString Then Command.Transaction = tr
        Dim vSqlStr As String = Command.CommandText
        Dim vCount As Integer
        Try
            Command.CommandText = vSqlStr.Replace("ي", "ی").Replace("ك", "ک")
            vCount = Command.ExecuteNonQuery()
            If LogInsert = True Then
                Try
                    Command.CommandText = "INSERT INTO CONCRETE_LOG.DBO.SQL_COMMANDS(DATE_TIME, U_USER_ID, COMMAND_TEXT) VALUES('" & DateTime.Today.ToString("yyyy-MM-dd") & "'," & CurrentUserId & ",'" & vSqlStr.Replace("'", "''") & "')"
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            OLEDBErrorHandle(ex, vSqlStr)
            Throw ex
        End Try
        Return vCount
    End Function

    Public Shared Function ExecuteScalar(ByVal SqlString As String, Optional ByVal cnn As SqlConnection = Nothing) As Object
        Dim cmd As New SqlCommand
        vErrMessage = ""
        Try
            cmd.Connection = cnn
            If cmd.Connection Is Nothing Then cmd.Connection = GlobalCnn
            If cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Open()
            cmd.Transaction = tr
            cmd.CommandText = SqlString.Replace("ي", "ی").Replace("ك", "ک")
            cmd.CommandType = CommandType.Text

            Dim X As Object = cmd.ExecuteScalar()
            'If LogInsert = True Then
            'Try
            '   cmd.CommandText = "INSERT INTO CONCRETE_LOG.DBO.SQL_COMMANDS(DATE_TIME, U_USER_ID, COMMAND_TEXT) VALUES(dbo.getCurrentDateTime()," & CurrentUserId & ",'" & SqlString.Replace("'", "''") & "')"
            '   cmd.ExecuteNonQuery()
            'Catch ex As Exception
            'End Try
            'End If
            Return X
        Catch exp As SqlException
            OLEDBErrorHandle(exp, SqlString)
            Throw exp
        End Try
    End Function

    Public Shared Function ExecuteScalar(ByVal Command As SqlCommand, Optional ByVal cnn As SqlConnection = Nothing) As Object
        vErrMessage = ""
        Try
            Command.Connection = cnn
            If Command.Connection Is Nothing Then Command.Connection = GlobalCnn
            If Command.Connection.State = ConnectionState.Closed Then Command.Connection.Open()
            Command.Transaction = tr
            Dim X As Object = Command.ExecuteScalar()
            'If LogInsert = True Then
            '   Try
            '      Command.CommandText = "INSERT INTO CONCRETE_LOG.DBO.SQL_COMMANDS(DATE_TIME, U_USER_ID, COMMAND_TEXT) VALUES(dbo.getCurrentDateTime()," & CurrentUserId & ",'" & Command.CommandText.Replace("'", "''") & "')"
            '      Command.ExecuteNonQuery()
            '   Catch ex As Exception
            '   End Try
            'End If
            Return X
        Catch exp As SqlException
            OLEDBErrorHandle(exp, Command.CommandText)
            Throw exp
        End Try
    End Function

    Public Shared Function ExecuteDataRow(ByVal SqlString As String, Optional ByVal cnn As SqlConnection = Nothing) As DataRow
        Dim dt As DataTable = ExecuteDataTable(SqlString, cnn)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function ExecuteDataTable(ByVal SqlString As String, Optional ByVal cnn As SqlConnection = Nothing) As DataTable
        vErrMessage = ""
        Dim sda As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = cnn
            If cmd.Connection Is Nothing Then cmd.Connection = GlobalCnn
            If cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Open()
            cmd.Transaction = tr
            cmd.CommandText = SqlString
            sda.SelectCommand = cmd
            sda.Fill(dt)
            'If LogInsert = True Then
            '   Try
            '      cmd.CommandText = "INSERT INTO CONCRETE_LOG.DBO.SQL_COMMANDS(DATE_TIME, U_USER_ID, COMMAND_TEXT) VALUES(dbo.getCurrentDateTime()," & CurrentUserId & ",'" & SqlString.Replace("'", "''") & "')"
            '      cmd.ExecuteNonQuery()
            '   Catch ex As Exception
            '   End Try
            'End If
            Return dt
        Catch exp As SqlException
            OLEDBErrorHandle(exp, SqlString)
            Throw exp
        End Try
    End Function

    Public Shared Function InsertTransaction(ByVal TITLE As String, ByVal DB_NAME As String, ByVal HOST_NAME As String, ByVal OS_UserName As String, ByVal APP_NAME As String, ByVal USE_ID As Integer, ByVal APP_CODE As Integer, ByVal FORM_NAME As String, ByVal EVENT_NAME As String, ByVal DESCRIPTION As String) As Long
        Dim cmd As New SqlCommand
        Dim SqlString As String = "INSERT INTO [CONCRETE_LOG].[dbo].[TRANSACTIONS](TITLE,DB_NAME,HOST_NAME,OS_USER_NAME,APP_NAME,DATE_TIME,USE_ID,APP_CODE,FORM_NAME,EVENT_NAME,DESCRIPTION) " & vbCrLf &
                                "VALUES ('" & TITLE.Trim & "','" & DB_NAME.Trim & "','" & HOST_NAME.Trim & "','" & OS_UserName.Trim & "','" & APP_NAME.Trim & "','" & getDateTime() & "'," & USE_ID & "," & APP_CODE & ",'" & FORM_NAME.Trim & "','" & EVENT_NAME.Trim & "','" & DESCRIPTION.Trim & "')"
        Try
            cmd.Connection = GlobalCnn
            ' cmd.Transaction = tr
            cmd.CommandText = SqlString & ";SELECT SCOPE_IDENTITY ()"
            cmd.CommandType = CommandType.Text
            Return cmd.ExecuteScalar()
        Catch exp As SqlException
        End Try
    End Function

    Public Shared Function InsertTransactionTable(ByVal TRA_ID As Long, ByVal ROW_ID As Long, ByVal TYPE As Integer, ByVal TABLE_NAME As String) As Long
        Dim cmd As New SqlCommand
        Dim SqlString As String = "INSERT INTO [CONCRETE_LOG].[dbo].[TRANSACTION_TABLES](TRA_ID,ROW_ID,TYPE,TABLE_NAME) " & vbCrLf &
                                "VALUES (" & TRA_ID & "," & ROW_ID & "," & TYPE & ",'" & TABLE_NAME.Trim & "')"
        Try
            cmd.Connection = GlobalCnn
            ' cmd.Transaction = tr
            cmd.CommandText = SqlString & ";SELECT SCOPE_IDENTITY ()"
            cmd.CommandType = CommandType.Text
            Return cmd.ExecuteScalar()
        Catch exp As SqlException
        End Try
    End Function

    Public Shared Sub InsertTransactionColumns(ByVal TT_ID As Long, ByVal COLUMN_NAME As String, ByVal TITLE As String, ByVal OLD_VALUE As Object, ByVal NEW_VALUE As Object)
        Dim cmd As New SqlCommand
        Dim SqlString As String = "INSERT INTO [CONCRETE_LOG].[dbo].[TRANSACTION_COLUMNS](TT_ID,COLUMN_NAME,TITLE,OLD_VALUE,NEW_VALUE) " & vbCrLf &
                                "VALUES (" & TT_ID & ",'" & COLUMN_NAME.Trim & "','" & TITLE.Trim & "'," & IIf(OLD_VALUE Is DBNull.Value, "NULL", "'" & OLD_VALUE & "'") & "," & IIf(NEW_VALUE Is DBNull.Value, "NULL", "'" & NEW_VALUE & "'") & ")"
        Try
            cmd.Connection = GlobalCnn
            cmd.CommandText = SqlString
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
        Catch exp As SqlException
        End Try
    End Sub

    Private Shared Sub OLEDBErrorHandle(ByVal exp As SqlException, ByVal SqlString As String)
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = GlobalCnn
            cmd.Transaction = tr
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO CONCRETE_LOG.DBO.ERRORS(DATE_TIME, USER_ID, ERR_NUMBER, ERR_MESSAGE, SQL_COMMAND) " &
                           "VALUES('dbo.getCurrentDateTime()'," & CurrentUserId & ",'" &
                                       "','" & exp.Message.Replace("'", "''") & "','" & SqlString.Replace("'", "''") & "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function getDateTime() As String
        If UserDate.Trim = "" Then
            Return ExecuteScalar("SELECT dbo.getCurrentDateTime()")
        Else
            Return UserDate & "_" & getServerTime()
        End If
    End Function

    Public Shared Function getDate() As String
        If UserDate.Trim = "" Then
            Return ExecuteScalar("SELECT dbo.getCurrentDate()")
        Else
            Return UserDate
        End If
    End Function

    Public Shared Function getServerDate() As Date
        Dim dr As DataRow = SQL.ExecuteDataTable("SELECT DATEPART(YEAR, GETDATE()) AS YEAR, DATEPART(MONTH, GETDATE()) AS MONTH, DATEPART(DAY, GETDATE()) AS DAY").Rows(0)
        Return DateSerial(dr.Item("YEAR"), dr.Item("MONTH"), dr.Item("DAY"))
    End Function

    Public Shared Function getServerTime() As String
        Dim dr As DataRow = SQL.ExecuteDataTable("SELECT DATEPART(HOUR, GETDATE()) AS HOUR, DATEPART(MINUTE, GETDATE()) AS MINUTE, DATEPART(SECOND, GETDATE()) AS SECOND").Rows(0)
        Return dr.Item("HOUR").ToString.PadLeft(2, "0") & ":" & dr.Item("MINUTE").ToString.PadLeft(2, "0") & ":" & dr.Item("SECOND").ToString.PadLeft(2, "0")
    End Function

    Public Shared Sub CreateLogin(ByVal DataBase As String, ByVal UserName As String, ByVal Password As String)
        Dim str As String
        Dim dt As DataTable = ExecuteDataTable("USE [MASTER];" & vbCrLf &
                                               "SELECT SPID, HOSTNAME FROM SYSPROCESSES WHERE LOGINAME = N'" & UserName & "'")

        If dt.Rows.Count > 0 Then
            ExecuteNonQuery("ALTER LOGIN [" & UserName & "] WITH PASSWORD=N'" & Password & "';")
            Return

        End If
        str = "USE [MASTER];" & vbCrLf &
          "IF EXISTS (SELECT * FROM SYS.SYSLOGINS WHERE NAME = N'" & UserName & "')" & vbCrLf &
          "	ALTER LOGIN [" & UserName & "] WITH PASSWORD=N'" & Password & "';" & vbCrLf &
          "ELSE" & vbCrLf &
          "	CREATE LOGIN [" & UserName & "] WITH PASSWORD=N'" & Password & "', CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;" & vbCrLf &
          "USE [" & IIf(DataBase = "", GlobalDatabase, DataBase) & "];" & vbCrLf &
          "IF EXISTS (SELECT * FROM SYS.SYSUSERS WHERE NAME = N'" & UserName & "')" & vbCrLf &
          "	DROP USER [" & UserName & "];" & vbCrLf &
          "	CREATE USER [" & UserName & "] FOR LOGIN [" & UserName & "];" & vbCrLf &
          "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';" & vbCrLf &
          "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';"
        ExecuteNonQuery(str)
        str = "USE [CONCRETE_LOG];" & vbCrLf &
         "IF EXISTS (SELECT * FROM SYS.SYSUSERS WHERE NAME = N'" & UserName & "')" & vbCrLf &
         "	DROP USER [" & UserName & "];" & vbCrLf &
         "	CREATE USER [" & UserName & "] FOR LOGIN [" & UserName & "];" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';"
        Try
         ExecuteNonQuery(str)
      Catch ex As Exception
         ex.Data.Clear()
      End Try
        str = "USE [CONCRETE_IMAGE];" & vbCrLf &
         "IF EXISTS (SELECT * FROM SYS.SYSUSERS WHERE NAME = N'" & UserName & "')" & vbCrLf &
         "	DROP USER [" & UserName & "];" & vbCrLf &
         "	CREATE USER [" & UserName & "] FOR LOGIN [" & UserName & "];" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';"
        Try
         ExecuteNonQuery(str)
      Catch ex As Exception
         ex.Data.Clear()
      End Try


        '---------------
        str = "USE [CONCRETE_A];" & vbCrLf &
         "IF EXISTS (SELECT * FROM SYS.SYSUSERS WHERE NAME = N'" & UserName & "')" & vbCrLf &
         "	DROP USER [" & UserName & "];" & vbCrLf &
         "	CREATE USER [" & UserName & "] FOR LOGIN [" & UserName & "];" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';" & vbCrLf &
         "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';"
        Try
            ExecuteNonQuery(str)
        Catch ex As Exception
            ex.Data.Clear()
        End Try

        str = "USE [CONCRETE_T];" & vbCrLf &
            "IF EXISTS (SELECT * FROM SYS.SYSUSERS WHERE NAME = N'" & UserName & "')" & vbCrLf &
            "	DROP USER [" & UserName & "];" & vbCrLf &
            "	CREATE USER [" & UserName & "] FOR LOGIN [" & UserName & "];" & vbCrLf &
            "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';" & vbCrLf &
            "	EXEC SP_ADDROLEMEMBER N'db_owner', N'" & UserName & "';"
        Try
         ExecuteNonQuery(str)
      Catch ex As Exception
         ex.Data.Clear()
      End Try

   End Sub

End Class
