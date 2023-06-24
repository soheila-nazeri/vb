Public Class people_dml : Inherits BasePeople
    Private vDomain As New Domain
    Public Function [Select](ByVal vPeopleId As Integer) As DataTable
        Dim str As String
        str = "SELECT * " &
            "FROM PEOPLE_VIEW P   "
        If vPeopleId > 0 Then str &= " WHERE ID=" & vPeopleId
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
