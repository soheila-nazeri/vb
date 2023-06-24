''' <summary>تنظيمات گريد </summary>
Public Class GridInit

Public TableName As String = "GRID_INIT"
#Region "Property"
    Private _ID As DataType.Integer
    Private _PARENT_FORM As DataType.String
    Private _USE_ID As DataType.Integer
    Private _STR_INIT As DataType.String
    Private _GROUP_COLUMNS As DataType.String
    Private _Type As DataType.Integer
    Private _CONTROL_NAME As DataType.String
    Public Enum Columns
        ID = 0
        PARENT_FORM = 1
        USE_ID = 3
        STR_INIT = 4
        GROUP_COLUMNS = 5
        TYPE = 6
        CONTROL_NAME = 7
    End Enum
    Private ColumnNames() As String = {"ID", "PARENT_FORM", "USE_ID", "STR_INIT", "GROUP_COLUMNS", "TYPE", "CONTROL_NAME"}
    Private ColumnQuotation() As String = {"", "'", "", "'", "'", "", "", "'"}

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
        _PARENT_FORM.Name = "PARENT_FORM"
        _USE_ID.Name = "USE_ID"
        _STR_INIT.Name = "STR_INIT"
        _GROUP_COLUMNS.Name = "GROUP_COLUMNS"
        _Type.Name = "TYPE"
        _CONTROL_NAME.Name = "CONTROL_NAME"
    End Sub

    Public Sub Reset()
        _ID.Reset()
        _PARENT_FORM.Reset()
        _USE_ID.Reset()
        _STR_INIT.Reset()
        _GROUP_COLUMNS.Reset()
        _Type.Reset()
        _CONTROL_NAME.Reset()
    End Sub

    ''' <summary>شناسه </summary>
    Public Property ID() As Integer
        Get
            Return _ID.Value
        End Get
        Set(ByVal value As Integer)
            _ID.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property PARENT_FORM() As String
        Get
            Return _PARENT_FORM.Value
        End Get
        Set(ByVal value As String)
            _PARENT_FORM.Value = value
        End Set
    End Property
    ''' <summary> </summary>
    Public Property USE_ID() As Integer
        Get
            Return _USE_ID.Value
        End Get
        Set(ByVal value As Integer)
            _USE_ID.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property STR_INIT() As String
        Get
            Return _STR_INIT.Value
        End Get
        Set(ByVal value As String)
            _STR_INIT.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property GROUP_COLUMNS() As String
        Get
            Return _GROUP_COLUMNS.Value
        End Get
        Set(ByVal value As String)
            _GROUP_COLUMNS.Value = value
        End Set
    End Property
    ''' <summary> </summary>
    Public Property TYPE() As String
        Get
            Return _Type.Value
        End Get
        Set(ByVal value As String)
            _Type.Value = value
        End Set
    End Property
    ''' <summary> </summary>
    Public Property CONTROL_NAME() As String
        Get
            Return _CONTROL_NAME.Value
        End Get
        Set(ByVal value As String)
            _CONTROL_NAME.Value = value
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
        str = "INSERT INTO " & TableName & "("
        Values = ") VALUES("
        If _PARENT_FORM.isSet Then str &= ", " & _PARENT_FORM.Name : Values &= ", '" & _PARENT_FORM.Value & "'"
        If _USE_ID.isSet Then str &= ", " & _USE_ID.Name : Values &= ", " & _USE_ID.Value
        If _STR_INIT.isSet Then str &= ", " & _STR_INIT.Name : Values &= ", '" & _STR_INIT.Value & "'"
        If _GROUP_COLUMNS.isSet Then str &= ", " & _GROUP_COLUMNS.Name : Values &= ", '" & _GROUP_COLUMNS.Value & "'"
        If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
        If _CONTROL_NAME.isSet Then str &= ", " & _CONTROL_NAME.Name : Values &= ", '" & _CONTROL_NAME.Value & "'"
        str = str.Replace("(,", "(")
        Values = Values.Replace("(,", "(")
        SQL.ExecuteNonQuery(str & Values & ")", ConnectionIndex)
        Return ID
    End Function

    Public Sub Edit(ByVal Id As Long, ByVal ConnectionIndex As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery(getEditString() & "   WHERE ID=" & Id, ConnectionIndex)
    End Sub

    Public Sub Edit(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0)
        Dim c As New stcCondition
        c.Name = ConditionColumnName
        c.OpenParenthes = False
        c.CloseParenthes = False
        c.Operator = [Operator]
        c.Oprand = ""
        c.Value = Value
        c.Value2 = Value2
        SQL.ExecuteNonQuery(getEditString() & getConditionString(c))
    End Sub

    Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
        SQL.ExecuteNonQuery(getEditString() & getConditionString(Condition))
    End Sub

    Private Function getEditString() As String
        Dim str As String = "UPDATE " & TableName & " SET "
        If _ID.isSet Then str &= _ID.Name & "=" & IIf(_ID.isDBNull, "Null", _ID.Value & "") & ","
        If _PARENT_FORM.isSet Then str &= _PARENT_FORM.Name & "=" & IIf(_PARENT_FORM.isDBNull, "Null", "'" & _PARENT_FORM.Value & "'") & ","
        If _USE_ID.isSet Then str &= _USE_ID.Name & "=" & IIf(_USE_ID.isDBNull, "Null", _USE_ID.Value & "") & ","
        If _STR_INIT.isSet Then str &= _STR_INIT.Name & "=" & IIf(_STR_INIT.isDBNull, "Null", "'" & _STR_INIT.Value & "'") & ","
        If _GROUP_COLUMNS.isSet Then str &= _GROUP_COLUMNS.Name & "=" & IIf(_GROUP_COLUMNS.isDBNull, "Null", "'" & _GROUP_COLUMNS.Value & "'") & ","
        If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
        If _CONTROL_NAME.isSet Then str &= _CONTROL_NAME.Name & "=" & IIf(_CONTROL_NAME.isDBNull, "Null", "'" & _CONTROL_NAME.Value & "'") & ","
        If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
        Return str
    End Function

    Public Sub Delete(ByVal ID As Long, ByVal ConnectionIndex As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, ConnectionIndex)
    End Sub

    Public Sub Delete(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0)
        Dim c As New stcCondition
        c.Name = ConditionColumnName
        c.OpenParenthes = False
        c.CloseParenthes = False
        c.Operator = [Operator]
        c.Oprand = ""
        c.Value = Value
        c.Value2 = Value2
        SQL.ExecuteNonQuery("DELETE " & TableName & getConditionString(c))
    End Sub

    Public Sub Delete(ByVal ParamArray Condition() As stcCondition)
        SQL.ExecuteNonQuery("DELETE " & TableName & getConditionString(Condition))
    End Sub

    Public Function getValue(ByVal ColumnName As Columns, ByVal Id As Long) As Object
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE ID=" & Id)
    End Function

    Public Function getValue(ByVal ColumnName As Columns, ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As Object
        Dim c As New stcCondition
        c.Name = ConditionColumnName
        c.OpenParenthes = False
        c.CloseParenthes = False
        c.Operator = [Operator]
        c.Oprand = ""
        c.Value = Value
        c.Value2 = Value2
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & getConditionString(c))
    End Function

    Public Function getValue(ByVal ColumnName As Columns, ByVal ParamArray Condition() As stcCondition) As Object
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & getConditionString(Condition))
    End Function

    Public Function getRow(ByVal Id As Long) As DataRow
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE ID=" & Id)
    End Function

    Public Function getRow(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As DataRow
        Dim c As New stcCondition
        c.Name = ConditionColumnName
        c.OpenParenthes = False
        c.CloseParenthes = False
        c.Operator = [Operator]
        c.Oprand = ""
        c.Value = Value
        c.Value2 = Value2
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & getConditionString(c))
    End Function

    Public Function getRow(ByVal ParamArray Condition() As stcCondition) As DataRow
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & getConditionString(Condition))
    End Function

    Public Function [Select](ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As DataTable
        Dim c As New stcCondition
        c.Name = ConditionColumnName
        c.OpenParenthes = False
        c.CloseParenthes = False
        c.Operator = [Operator]
        c.Oprand = ""
        c.Value = Value
        c.Value2 = Value2
        Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & getConditionString(c))
    End Function

    Public Function [Select](ByVal ParamArray Condition() As stcCondition) As DataTable
        Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & getConditionString(Condition))
    End Function

    Private Function getConditionString(ByVal ParamArray Condition() As stcCondition) As String
        Dim str As String = ""
        For Each c As stcCondition In Condition
            Dim vOperator As String = SQL.ExecuteScalar("SELECT TITLE FROM DOMAINS   WHERE ID=" & c.Operator)
            str &= c.Oprand & IIf(c.OpenParenthes, "(", "") & _
            ColumnNames(c.Name) & " " & vOperator & _
            IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) & _
            IIf(c.CloseParenthes, ")", "")
        Next
        If str <> "" Then str = "   WHERE " & str
        Return str
    End Function

End Class
