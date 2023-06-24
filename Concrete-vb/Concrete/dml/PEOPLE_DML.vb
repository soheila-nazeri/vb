Public Class people_dml : Inherits BasePeople
    Private vDomain As New Domain
    'Public Sub SaveImage(ByVal PeopleId As Integer, ByVal FileBytes() As Byte)
    '        If FileBytes.Length > 0 Then
    '            MyBase.Images.Reset()
    '        MyBase.Images.Type = Enums.Keys.AttachmentType.PeopleImage
    '        MyBase.Images.PeopleId = PeopleId
    '        Dim vId As Integer = MyBase.Images.Insert(Nothing)
    '        Dim Command As New SqlClient.SqlCommand
    '        Command.CommandType = CommandType.Text
    '        Command.Parameters.AddWithValue("@FILEDATA", FileBytes)
    '        Command.CommandText = "UPDATE PEOPLE_IMAGES SET CONTENT=@FILEDATA WHERE ID=" & vId
    '        SQL.ExecuteNonQuery(Command)
    '    End If
    'End Sub
    'Public Function getImage(ByVal PeopleId As Integer) As System.IO.MemoryStream
    '    Dim a = SQL.ExecuteScalar("SELECT CONTENT FROM PEOPLE_IMAGES WHERE PEO_ID=" & PeopleId & " AND TYPE=" & Enums.Keys.AttachmentType.PeopleImage)
    '    Dim Ms As System.IO.MemoryStream = Nothing
    '    If a Is Nothing Then Return Ms
    '    If a Is DBNull.Value Then Return Ms
    '    Dim Arr() As Byte = a
    '    Ms = New System.IO.MemoryStream(Arr)
    '    Return Ms
    'End Function
    Public Function [Select](ByVal vPeopleId As Integer) As DataTable
        Dim str As String
        str = "SELECT * " &
            "FROM PEOPLE_VIEW P   "
        If vPeopleId > 0 Then str &= " WHERE ID=" & vPeopleId
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selPeople(ByVal vType As Enums.Keys.PeopleType) As DataTable
        Dim str As String
        str = "SELECT *  " &
              "FROM PEOPLE_VIEW P   "
        If vType > 0 Then

            str &= " WHERE ISNULL(P.TYPE, " & Enums.Keys.PeopleType.personel & ")=" & vType
        End If
        Return SQL.ExecuteDataTable(str + " ORDER BY P.CODE ASC ")
    End Function

    Public Function getInfoByNatinalCode(ByVal _NatinalCode As String) As DataRow
        If _NatinalCode.Trim = "" Then Return Nothing
        Dim str As String
        str = "SELECT TOP 1 * FROM PEOPLE_VIEW WHERE  NATIONAL_CODE='" & _NatinalCode & "' ORDER BY ID "
        Return SQL.ExecuteDataRow(str)
    End Function
    Public Function getInfoAndSubscribeByNatinalCode(ByVal _NatinalCode As String) As DataRow
        If _NatinalCode.Trim = "" Then Return Nothing
        Dim str As String
        str = "SELECT TOP 1 FIRST_NAME,LAST_NAME ,S.ID AS SUB_ID,S.CODE AS SUB_CODE,P.MOBILE_NO,P.TEL_NO,P.ADDRESS,P.EMAIL_ADDRESS,P.CIT_ID_NATIONALITY" & vbCrLf &
            "FROM PEOPLE P" & vbCrLf &
            "LEFT JOIN SUBSCRIBES S ON S.PEO_ID=P.ID" & vbCrLf &
            "WHERE LTRIM(RTRIM(NATIONAL_CODE))='" & _NatinalCode.Trim & "'" & vbCrLf &
            "ORDER BY P.ID DESC"
        Return SQL.ExecuteDataRow(str)
    End Function
    Public Function getNextPersonelCode() As Integer
        Return Utility.NVL(SQL.ExecuteScalar(" SELECT MAX(CAST( P.CODE AS BIGINT) ) " & vbCrLf &
                                         " FROM PEOPLE P   " & vbCrLf &
                                         " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE=" & Enums.Keys.PeoplePropertyType.Personel), 0) + 1
    End Function
    Public Function selPersonel(ByVal vStatus As Integer, ByVal PeopleId As Integer, ByVal FU_ID As Long) As DataTable
        Try
            SQL.ExecuteNonQuery("drop table #TT")
        Catch ex As Exception
        End Try
        '=========================
        Dim str As String = "select MAX(id) as ID ,PEO_ID " & vbCrLf &
                            "    into #TT" & vbCrLf &
                            "from PEOPLE_PROPERTIES " & vbCrLf &
                            "where TYPE =1240 and PEO_ID in (" & vbCrLf &
                            "	select PEO_ID" & vbCrLf &
                            "	from PEOPLE_PROPERTIES  pp" & vbCrLf &
                            "	where pp.type=1240" & vbCrLf &
                            "	group by PEO_ID " & vbCrLf &
                            "	having COUNT (*)>1" & vbCrLf &
                            "	)" & vbCrLf &
                            "group by PEO_ID " & vbCrLf &
                            "" & vbCrLf &
                            "delete pp" & vbCrLf &
                            "from PEOPLE_PROPERTIES pp" & vbCrLf &
                            "inner join #TT t on t.PEO_ID =pp.PEO_ID and t.ID <> pp.ID " & vbCrLf &
                            "where pp.TYPE =1240" & vbCrLf &
                            "" & vbCrLf &
                            "update PEOPLE_PROPERTIES set FROM_DATE ='1390/01/01' where TYPE=1240 and FROM_DATE is null"
        '"update pp set FROM_DATE =isnull(p.EMPLOYMENT_DATE ,'1390/01/01')" & vbCrLf & _
        '"from PEOPLE_PROPERTIES pp" & vbCrLf & _
        '"inner join PEOPLE p on p.id=pp.PEO_ID " & vbCrLf & _
        '"where pp.type=1240  and pp.TO_DATE is null and isnull(pp.FROM_DATE ,'5000/01/01')<> isnull(p.EMPLOYMENT_DATE ,'1390/01/01')"
        SQL.ExecuteNonQuery(str)
        str = " SELECT PP.PEO_ID,ISNULL(PP.VALUE,1) AS PP_STATUS,P.*,PP.ID as PP_Id,pp.TYPE as PP_Type,pp.VALUE,pp.FROM_DATE,pp.TO_DATE,pp.DIS_ID ,PPD.VALUE AS DIS_VALUE ,PPD.DIS_ID as PP_DIS_ID," & vbCrLf &
                    " EMP_TYPE.TITLE AS EMPLOYMENT_TYPE_TITLE ,EMP_TYPE.ID AS EMPLOYMENT_TYPE_ID ," & vbCrLf &
                    " MIL_STATUS.TITLE AS MIL_TITLE ,MIL_STATUS.ID AS MIL_ID , " & vbCrLf &
                    " DOM_FINANCE.TITLE AS FINANCE_TITLE ,DOM_FINANCE.ID AS FINANCE_ID , " & vbCrLf &
                    " MARITAL_STATUS.TITLE AS MARITAL_TITLE ,MARITAL_STATUS.ID AS MARITAL_ID,P.ACCOUNT_NO,acc.code as Acc_code_2,acc.title as Acc_title " & vbCrLf &
            " FROM PEOPLE_VIEW P   " & vbCrLf &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE=" & Enums.Keys.PeoplePropertyType.Personel & vbCrLf &
            " LEFT JOIN PEOPLE_PROPERTIES PPD ON P.ID=PPD.PEO_ID AND PPD.TYPE=" & Enums.Keys.PeoplePropertyType.PersonelDiscount & " AND PPD.TO_DATE IS NULL " & vbCrLf &
            " LEFT JOIN PEOPLE_PROPERTIES PP_Acc ON P.ID=PP_Acc.PEO_ID AND PP_Acc.TYPE=" & Enums.Keys.PeoplePropertyType.AccountCode & " AND PP_Acc.TO_DATE IS NULL " & vbCrLf &
            " LEFT JOIN accounts acc ON PP_Acc.VALUE=acc.id " & vbCrLf &
            " LEFT JOIN DOMAINS EMP_TYPE ON EMP_TYPE.ID=P.EMPLOYMENT_TYPE " & vbCrLf &
            " LEFT JOIN DOMAINS MIL_STATUS ON MIL_STATUS.ID=P.MILIARITY_STATUS " & vbCrLf &
            " LEFT JOIN DOMAINS MARITAL_STATUS ON MARITAL_STATUS.ID=P.MARITAL_STATUS " & vbCrLf &
            " LEFT JOIN DOMAINS DOM_FINANCE ON DOM_FINANCE.ID=P.FU_ID " & vbCrLf &
            "WHERE 1=1"
        If vStatus <> -1 Then str &= " AND ISNULL(PP.VALUE,1)='" & vStatus & "'"
        If PeopleId > 0 Then str &= " AND P.ID=" & PeopleId
        If FU_ID > 0 Then str &= " AND P.FU_ID=" & FU_ID
        str &= " ORDER BY P.CODE ASC "
        Return SQL.ExecuteDataTable(str)
    End Function

    Public Function selPersonel(ByVal vStatus As Integer, ByVal PeopleId As Integer) As DataTable
        Try
            SQL.ExecuteNonQuery("drop table #TT")
        Catch ex As Exception
        End Try
        '=========================
        Dim str As String = "select MAX(id) as ID ,PEO_ID " & vbCrLf &
                            "    into #TT" & vbCrLf &
                            "from PEOPLE_PROPERTIES " & vbCrLf &
                            "where TYPE =1240 and PEO_ID in (" & vbCrLf &
                            "	select PEO_ID" & vbCrLf &
                            "	from PEOPLE_PROPERTIES  pp" & vbCrLf &
                            "	where pp.type=1240" & vbCrLf &
                            "	group by PEO_ID " & vbCrLf &
                            "	having COUNT (*)>1" & vbCrLf &
                            "	)" & vbCrLf &
                            "group by PEO_ID " & vbCrLf &
                            "" & vbCrLf &
                            "delete pp" & vbCrLf &
                            "from PEOPLE_PROPERTIES pp" & vbCrLf &
                            "inner join #TT t on t.PEO_ID =pp.PEO_ID and t.ID <> pp.ID " & vbCrLf &
                            "where pp.TYPE =1240" & vbCrLf &
                            "" & vbCrLf &
                            "update PEOPLE_PROPERTIES set FROM_DATE ='1390/01/01' where TYPE=1240 and FROM_DATE is null"
        '"update pp set FROM_DATE =isnull(p.EMPLOYMENT_DATE ,'1390/01/01')" & vbCrLf & _
        '"from PEOPLE_PROPERTIES pp" & vbCrLf & _
        '"inner join PEOPLE p on p.id=pp.PEO_ID " & vbCrLf & _
        '"where pp.type=1240  and pp.TO_DATE is null and isnull(pp.FROM_DATE ,'5000/01/01')<> isnull(p.EMPLOYMENT_DATE ,'1390/01/01')"
        SQL.ExecuteNonQuery(str)
        str = " SELECT PP.PEO_ID,ISNULL(PP.VALUE,1) AS PP_STATUS,P.*,PP.ID as PP_Id,pp.TYPE as PP_Type,pp.VALUE,pp.FROM_DATE,pp.TO_DATE,pp.DIS_ID ,PPD.VALUE AS DIS_VALUE ,PPD.DIS_ID as PP_DIS_ID," & vbCrLf &
                    " EMP_TYPE.TITLE AS EMPLOYMENT_TYPE_TITLE ,EMP_TYPE.ID AS EMPLOYMENT_TYPE_ID ," & vbCrLf &
                    " MIL_STATUS.TITLE AS MIL_TITLE ,MIL_STATUS.ID AS MIL_ID , " & vbCrLf &
                    " DOM_FINANCE.TITLE AS FINANCE_TITLE ,DOM_FINANCE.ID AS FINANCE_ID , " & vbCrLf &
                    " MARITAL_STATUS.TITLE AS MARITAL_TITLE ,MARITAL_STATUS.ID AS MARITAL_ID,P.ACCOUNT_NO " & vbCrLf &
            " FROM PEOPLE_VIEW P   " & vbCrLf &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE=" & Enums.Keys.PeoplePropertyType.Personel & vbCrLf &
            " LEFT JOIN PEOPLE_PROPERTIES PPD ON P.ID=PPD.PEO_ID AND PPD.TYPE=" & Enums.Keys.PeoplePropertyType.PersonelDiscount & " AND PPD.TO_DATE IS NULL " & vbCrLf &
            " LEFT JOIN DOMAINS EMP_TYPE ON EMP_TYPE.ID=P.EMPLOYMENT_TYPE " & vbCrLf &
            " LEFT JOIN DOMAINS MIL_STATUS ON MIL_STATUS.ID=P.MILIARITY_STATUS " & vbCrLf &
            " LEFT JOIN DOMAINS MARITAL_STATUS ON MARITAL_STATUS.ID=P.MARITAL_STATUS " & vbCrLf &
            " LEFT JOIN DOMAINS DOM_FINANCE ON DOM_FINANCE.ID=P.FU_ID " & vbCrLf &
            "WHERE 1=1"
        If vStatus <> -1 Then str &= " AND ISNULL(PP.VALUE,1)='" & vStatus & "'"
        If PeopleId > 0 Then str &= " AND P.ID=" & PeopleId
        str &= " ORDER BY P.CODE ASC "
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selPeopleDependencies(ByVal vStatus As Integer, ByVal PeopleId As Integer) As DataTable
        Dim str As String

        'If vStatus <> -1 Then str &= " AND ISNULL(PP.VALUE,1)='" & vStatus & "'"
        str = " SELECT PP.PEO_ID,ISNULL(PP.VALUE,1) AS PP_STATUS,peo_child.*,PP.ID as PP_Id,pp.TYPE as PP_Type," & vbCrLf &
                    " pp.VALUE,pp.FROM_DATE,pp.TO_DATE , " & vbCrLf &
                    " DOM_RELATION.TITLE AS RelationTitle , DOM_RELATION.ID AS RELATION_TYPE_ID ," & vbCrLf &
                    " DOM_GENDER.TITLE AS GenderTitle ,DOM_GENDER.ID AS GENDER_ID , " & vbCrLf &
                    " CASE      WHEN ISNULL(PEO_CHILD.STATUS,1) <= 0 THEN 'غیر فعال' ELSE 'فعال ' END AS StatusTitle    " & vbCrLf &
            " FROM PEOPLE_VIEW P   " & vbCrLf &
            " INNER JOIN PEOPLE    PEO_CHILD ON PEO_CHILD.PEO_ID=P.ID " & vbCrLf &
            " INNER JOIN DOMAINS   DOM_GENDER   ON DOM_GENDER.ID=PEO_CHILD.GENDER " & vbCrLf &
            " INNER JOIN DOMAINS   DOM_RELATION ON DOM_RELATION.ID=PEO_CHILD.RELATION_TYPE " & vbCrLf &
            " LEFT  JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE=" & Enums.Keys.PeoplePropertyType.Personel & vbCrLf &
            "WHERE 1=1"
        If PeopleId > 0 Then str &= " AND P.ID=" & PeopleId
        If vStatus <> -1 Then str &= " AND ISNULL(PEO_CHILD.status,1)='" & vStatus & "'"
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function getInfo(ByVal Id As Long) As DataRow
        Return SQL.ExecuteDataRow("SELECT *,ID AS PEO_ID FROM PEOPLE_VIEW WHERE ID=" & Id)
    End Function
    Enum PeoplePropertyStatus As Integer
        Active = 1
        NoActive = -1
        All = 0
    End Enum
    Public Function selPresenterANDReserveUnit(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.* " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE IN (" & Enums.Keys.PeoplePropertyType.Presenter & "," & Enums.Keys.PeoplePropertyType.ReserveUnit & ")"
        If vStatus = PeoplePropertyStatus.Active Then
            str &= "WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= "WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selDriver(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.VALUE,PP.VALUE2,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Driver
        If vStatus = PeoplePropertyStatus.Active Then
            str &= " WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= " WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selPresenter(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.VALUE,PP.VALUE2,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Presenter
        If vStatus = PeoplePropertyStatus.Active Then
            str &= " WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= " WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selRegistrar(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.VALUE,PP.VALUE2,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " &
              " FROM PEOPLE_VIEW P   " &
              " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Registrar
        If vStatus = PeoplePropertyStatus.Active Then
            str &= " WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= " WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    'Public Function GetPresenterInfo(ByVal Peo_code As Integer) As DataRow
    '    Dim str As String
    '    str = " SELECT  DISTINCT P.*,PP.VALUE,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " & _
    '          " FROM PEOPLE_VIEW P   " & _
    '          " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Presenter & vbCrLf & _
    '          " WHERE P.CODE=" & Peo_code
    '    Return SQL.ExecuteDataRow(str)
    'End Function
    Public Function selHostPeople(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.VALUE,PP.VALUE2,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Host
        If vStatus = PeoplePropertyStatus.Active Then
            str &= " WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= " WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selReserveUnit(Optional ByVal vStatus As PeoplePropertyStatus = PeoplePropertyStatus.Active) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.VALUE,PP.VALUE2,D.TITLE AS ReserveUnit_TITLE,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.ReserveUnit &
            " LEFT JOIN DOMAINS D ON D.ID= PP.VALUE "
        If vStatus = PeoplePropertyStatus.Active Then
            str &= "WHERE PP.TO_DATE IS NULL "
        ElseIf vStatus = PeoplePropertyStatus.NoActive Then
            str &= "WHERE NOT PP.TO_DATE IS NULL "
        End If
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function selSupporter(ByVal IsActive As Boolean) As DataTable
        Dim str As String
        str = " SELECT  DISTINCT P.*,PP.ID AS PEOPLE_PROPERTIES_ID ,PP.TO_DATE  ,ISNULL(PP.VALUE,0) VALUE ,PP.VALUE2 " &
            " FROM PEOPLE_VIEW P   " &
            " INNER JOIN PEOPLE_PROPERTIES PP ON P.ID=PP.PEO_ID AND PP.TYPE =" & Enums.Keys.PeoplePropertyType.Supporter
        If IsActive Then str &= " WHERE PP.TO_DATE IS NULL "
        If IsActive = False Then str &= " WHERE NOT PP.TO_DATE IS NULL  "
        Return SQL.ExecuteDataTable(str)
    End Function
    Public Function getUserId(ByVal PersonId As Integer) As Integer
        Return SQL.ExecuteScalar("SELECT ID FROM USERS WHERE PEO_ID=" & PersonId)
    End Function

    Public Function getAccountInfo(ByVal PersonId As Integer) As DataRow
        Return SQL.ExecuteDataRow("SELECT PP.ID,A.ID AS ACC_ID,A.CODE  " & vbCrLf &
                                               "FROM PEOPLE_PROPERTIES PP " & vbCrLf &
                                               "INNER JOIN ACCOUNTS A ON A.ID=PP.VALUE " & vbCrLf &
                                               "WHERE  PP.PEO_ID = " & PersonId & " AND PP.TYPE = " & Enums.Keys.PeoplePropertyType.AccountCode & " AND PP.TO_DATE IS NULL" & vbCrLf &
                                               "ORDER BY PP.ID DESC")
    End Function
    'Public Function selPost(ByVal PersonId As Integer) As DataTable
    '    Dim str As String
    '    str = "SELECT PP.*," & _
    '                 "POS.CODE AS POST_CODE," & _
    '                 "POS.TITLE AS POST_TITLE," & _
    '                 "HAVE=CASE WHEN (PP.ID IS NULL) THEN 0 ELSE 1 END " & _
    '          "FROM POSTS POS " & _
    '          "LEFT JOIN (SELECT * FROM PERSONAL_PROPERTIES " & _
    '                     "WHERE TYPE=" & Enums.Keys.PersonalPropertyType.Post & " AND PRS_ID=" & PersonId & ") PP ON PP.CODE=POS.CODE "
    '    Return SQL.ExecuteDataTable(str)
    'End Function

    'Public Function selPermissions(ByVal PersonId As Integer) As DataTable
    '    Dim str As String
    '    str = "SELECT PP.*," & _
    '                 "DOM.CODE AS PERMISSION_CODE," & _
    '                 "DOM.TITLE," & _
    '                 "HAVE=CASE WHEN (PP.ID IS NULL) THEN 0 ELSE 1 END " & _
    '          "FROM (SELECT * FROM DOMAINS WHERE NAME='PersonalPermission') DOM " & _
    '          "LEFT JOIN (SELECT * FROM PERSONAL_PROPERTIES " & _
    '                     "WHERE TYPE=" & Enums.Keys.PersonalPropertyType.Permission & " AND PRS_ID=" & PersonId & ") PP ON PP.CODE=DOM.CODE "
    '    Return SQL.ExecuteDataTable(str)
    'End Function
    Public Function SelBailInfo(ByVal PEO_ID As Long) As DataTable
        Dim strsql As String = "SELECT DOM.ID AS BAIL_ID,DOM.TITLE AS BAIL_TITLE , PP.FROM_DATE ,PP.ID AS PP_ID,PP.TO_DATE ,PP.PEO_ID " & vbCrLf &
                                    " FROM PEOPLE_PROPERTIES PP " & vbCrLf &
                                    " INNER JOIN DOMAINS DOM ON DOM.ID=PP.TYPE AND PP.TYPE IN (" & Enums.Keys.PeoplePropertyType.AgreementBail & "," & Enums.Keys.PeoplePropertyType.TreatmentBail & ")" & vbCrLf &
                                    " WHERE PP.PEO_ID=" & PEO_ID
        Return SQL.ExecuteDataTable(strsql, Nothing)

    End Function
    Public Sub DeletePeopleProperty(ByVal Peo_id As Long, ByVal Type As String)
        Dim strsql As String = " DELETE FROM PEOPLE_PROPERTIES WHERE PEO_ID=" & Peo_id & " AND TYPE IN (" & Type & ")"
        SQL.ExecuteNonQuery(strsql, Nothing)
    End Sub
    Public Function IsPeople(ByVal _NationalCode As String, ByVal _PeopleId As Long) As Boolean
        If _NationalCode.Trim = "" Then Return False

        Dim str As String = "SELECT COUNT(*) FROM  PEOPLE WHERE NATIONAL_CODE='" & _NationalCode.Trim.Replace(" ", "") & "' AND ID <> " & _PeopleId
        If SQL.ExecuteScalar(str) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function selDuplicatePeople() As DataTable
        Dim str As String = "SELECT P.FIRST_NAME , P.LAST_NAME, P.FATHER_NAME, P.BIRTHDAY, P.NATIONAL_CODE, P.ID" & vbCrLf &
                            "FROM PEOPLE P" & vbCrLf &
                            "INNER JOIN(SELECT FIRST_NAME, LAST_NAME, FATHER_NAME, BIRTHDAY, NATIONAL_CODE" & vbCrLf &
                            "           FROM PEOPLE P" & vbCrLf &
                            "           LEFT JOIN (SELECT PEO_ID, COUNT(*) C FROM GUESTS GROUP BY PEO_ID ) G ON P.ID=G.PEO_ID" & vbCrLf &
                            "           where ISNULL(G.C, 0)>0" & vbCrLf &
                            "           GROUP BY NATIONAL_CODE, FIRST_NAME, LAST_NAME, FATHER_NAME, BIRTHDAY " & vbCrLf &
                            "           HAVING COUNT(*)>1) PD ON P.FIRST_NAME = PD.FIRST_NAME AND P.LAST_NAME = PD.LAST_NAME AND" & vbCrLf &
                            "           P.FATHER_NAME = PD.FATHER_NAME AND P.BIRTHDAY = PD.BIRTHDAY AND P.NATIONAL_CODE=PD.NATIONAL_CODE" & vbCrLf &
                            "ORDER BY P.NATIONAL_CODE, P.FIRST_NAME , P.LAST_NAME, P.FATHER_NAME, P.BIRTHDAY"

        Return SQL.ExecuteDataTable(str)
    End Function

    Public Function selDuplicatePeople2() As DataTable
        Dim str As String = "SELECT P.FIRST_NAME , P.LAST_NAME, P.FATHER_NAME, P.BIRTHDAY, P.NATIONAL_CODE, P.ID,cast (0 as bit) CHECKED" & vbCrLf &
                            "FROM PEOPLE P" & vbCrLf &
                            "INNER JOIN(SELECT FIRST_NAME, LAST_NAME, FATHER_NAME, BIRTHDAY" & vbCrLf &
                            "           FROM PEOPLE P" & vbCrLf &
                            "           LEFT JOIN (SELECT PEO_ID, COUNT(*) C FROM GUESTS GROUP BY PEO_ID ) G ON P.ID=G.PEO_ID" & vbCrLf &
                            "           where ISNULL(G.C, 0)>0" & vbCrLf &
                            "           GROUP BY FIRST_NAME, LAST_NAME, FATHER_NAME, BIRTHDAY " & vbCrLf &
                            "           HAVING COUNT(*)>1) PD ON P.FIRST_NAME = PD.FIRST_NAME AND P.LAST_NAME = PD.LAST_NAME AND P.FATHER_NAME = PD.FATHER_NAME AND P.BIRTHDAY = PD.BIRTHDAY" & vbCrLf &
                            "ORDER BY P.FIRST_NAME , P.LAST_NAME, P.FATHER_NAME, P.BIRTHDAY"

        Return SQL.ExecuteDataTable(str)
    End Function
    'Correct Function 
    Public Function SelSimplePeople(ByVal Type As Integer) As DataTable
        Dim strsql As String
        strsql = "SELECT *,FIRST_NAME +'-' + LAST_NAME AS FULL_NAME FROM PEOPLE WHERE TYPE=" & Type
        Return SQL.ExecuteDataTable(strsql, Nothing)
    End Function
    Public Function selPeopleByFilter(ByVal vType As Enums.Keys.PeopleType, FirstName As String, LastName As String, NationalCode As String) As DataTable
        Dim str As String
        str = "SELECT *  " &
              "FROM PEOPLE   
               WHERE 1=1 "

        If vType > 0 Then str &= " AND ISNULL(TYPE, " & Enums.Keys.PeopleType.Personel & ")=" & vType
        If NationalCode.Trim <> "" Then str &= " AND NATIONAL_CODE like'%" & NationalCode.Trim & "%'"
        If FirstName.Trim <> "" Then str &= " AND FIRST_NAME  like '%" & FirstName.Trim & "%'"
        If LastName.Trim <> "" Then str &= " AND LAST_NAME like '%" & LastName.Trim & "%'"
        Return SQL.ExecuteDataTable(str + IIf(vType = Enums.Keys.PeopleType.Personel, " ORDER BY CODE ASC ", ""))
    End Function
End Class
