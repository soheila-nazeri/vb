''' <summary> </summary>
Public Class FinanceCycles
    Public TableName As String = "FINANCE_CYCLES"
#Region "Property"
    Private _ID As DataType.Integer
    Private _TITLE As DataType.string
    Private _FROM_DATE As DataType.string
    Private _TO_DATE As DataType.String
    Private _ENABLE As DataType.Integer
    Public Enum Columns
        ID = 0
        TITLE = 1
        FROM_DATE = 2
        TO_DATE = 3
        ENABLE = 4
    End Enum
    Private ColumnNames() As String = {"ID", "TITLE", "FROM_DATE", "TO_DATE", "ENABLE"}
    Private ColumnQuotation() As String = {"", "'", "'", "'", ""}
    Public Structure stcCondition
        Public Oprand As String
        Public OpenParenthes As Boolean
        Public CloseParenthes As Boolean
        Public Name As Columns
        Public [Operator] As Enums.Keys.Operators
        Public Value As Object
        Public Value2 As Object
    End Structure
    Public Sub New()
        _ID.Name = "ID"
        _TITLE.Name = "TITLE"
        _FROM_DATE.Name = "FROM_DATE"
        _TO_DATE.Name = "TO_DATE"
        _ENABLE.Name = "ENABLE"
    End Sub
    Public Sub Reset()
        _ID.Reset()
        _TITLE.Reset()
        _FROM_DATE.Reset()
        _TO_DATE.Reset()
        _ENABLE.Reset()
    End Sub
    ''' <summary> </summary>
    Public Property ID() As Integer
        Get
            Return _ID.Value
        End Get
        Set(ByVal value As Integer)
            _ID.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property TITLE() As String
        Get
            Return _TITLE.Value
        End Get
        Set(ByVal value As String)
            _TITLE.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property FROM_DATE() As String
        Get
            Return _FROM_DATE.Value
        End Get
        Set(ByVal value As String)
            _FROM_DATE.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property TO_DATE() As String
        Get
            Return _TO_DATE.Value
        End Get
        Set(ByVal value As String)
            _TO_DATE.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property ENABLE() As Integer
        Get
            Return _ENABLE.Value
        End Get
        Set(ByVal value As Integer)
            _ENABLE.Value = value
        End Set
    End Property

#End Region

    Private Function GetNextId(ByVal ConnectionIndex As SqlClient.SqlConnection) As Long
        Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, ConnectionIndex) + 1
    End Function

    Public Function Insert(ByVal ConnectionIndex As SqlClient.SqlConnection) As Long
        Dim str As String = ""
        Dim Values As String = ""
        ID = GetNextId(ConnectionIndex)
        str = "INSERT INTO " & TableName & "(ID"
        Values = ") VALUES(" & ID
        If _TITLE.isSet Then str &= ", " & _TITLE.Name : Values &= ", '" & _TITLE.Value & "'"
        If _FROM_DATE.isSet Then str &= ", " & _FROM_DATE.Name : Values &= ", '" & _FROM_DATE.Value & "'"
        If _TO_DATE.isSet Then str &= ", " & _TO_DATE.Name : Values &= ", '" & _TO_DATE.Value & "'"
        If _ENABLE.isSet Then str &= ", " & _ENABLE.Name : Values &= "," & _ENABLE.Value
        SQL.ExecuteNonQuery(str & Values & ")", ConnectionIndex)
        Return ID
    End Function

    Public Sub Edit(ByVal Id As Long, ByVal ConnectionIndex As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery(getEditString() & "   WHERE ID=" & Id, ConnectionIndex)
    End Sub





    Private Function getEditString() As String
        Dim str As String = "UPDATE " & TableName & " SET "
        If _ID.isSet Then str &= _ID.Name & "=" & IIf(_ID.isDBNull, "Null", _ID.Value & "") & ","
        If _TITLE.isSet Then str &= _TITLE.Name & "=" & IIf(_TITLE.isDBNull, "Null", "'" & _TITLE.Value & "'") & ","
        If _FROM_DATE.isSet Then str &= _FROM_DATE.Name & "=" & IIf(_FROM_DATE.isDBNull, "Null", "'" & _FROM_DATE.Value & "'") & ","
        If _TO_DATE.isSet Then str &= _TO_DATE.Name & "=" & IIf(_TO_DATE.isDBNull, "Null", "'" & _TO_DATE.Value & "'") & ","
        If _ENABLE.isSet Then str &= _ENABLE.Name & "=" & IIf(_ENABLE.isDBNull, "Null", _ENABLE.Value & "") & ","

        If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
        Return str
    End Function

    Public Sub Delete(ByVal ID As Long, ByVal ConnectionIndex As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, ConnectionIndex)
    End Sub

    Public Function getValue(ByVal ColumnName As Columns, ByVal Id As Long) As Object
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE ID=" & Id)
    End Function
    Public Function getRow(ByVal Id As Long) As DataRow
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE ID=" & Id)
    End Function
    Public Function _Select() As DataTable
        Dim strsql As String
        strsql = "SELECT * FROM FINANCE_CYCLES "

        Try
            Return SQL.ExecuteDataTable(strsql, Nothing)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function GetFinanceCycles() As Integer
        Dim strsql As String
        strsql = "SELECT COUNT(*) FROM FINANCE_CYCLES WHERE ISNULL(ENABLE,0)=1"
        Try
            Return SQL.ExecuteScalar(strsql, Nothing)
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
