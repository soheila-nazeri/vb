Public Class Domain

    Public TableName As String = "DOMAINS"
  Public Values As New clsValues

#Region "Property"

    Private _Id As DataType.Integer
    Private _DomainId As DataType.Integer
    Private _PermissionId As DataType.Integer
    Private _Type As DataType.Integer
    Private _Name As DataType.String
    Private _Code As DataType.Integer
    Private _Title As DataType.String
   Private _Priority As DataType.Integer
    Private _Value As DataType.Double
    Private _Description As DataType.String
    Private _ArabicTitle As DataType.String
    Private _Status As DataType.Integer
    Private _OldDomId As DataType.Integer
    Private _AccountId As DataType.Integer
    Private _Value2 As DataType.String
    Private _Value3 As DataType.String

    Public Enum Columns
        Id = 0
        DomainId = 1
        PermissionId = 2
        Type = 3
        Name = 4
        Code = 5
        Title = 6
      Priority = 7
        Value = 8
        Description = 9
        ArabicTitle = 10
        Status = 11
        OldDomId = 12
        AccountId = 13
        Value2 = 14
        Value3 = 15
    End Enum
    Private ColumnNames() As String = {"ID", "DOM_ID", "PER_ID", "TYPE", "NAME", "CODE", "TITLE", "PRIORITY", "VALUE", "DESCRIPTION", "AR_TITLE", "STATUS", "OLD_DOM_ID", "ACC_ID", "VALUE2", "VALUE3"}
    Private ColumnQuotation() As String = {"", "", "", "", "'", "", "'", "", "", "'", "'", "", "", "", "'"}

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
        _Id.Name = "ID"
        _DomainId.Name = "DOM_ID"
        _PermissionId.Name = "PER_ID"
        _Type.Name = "TYPE"
        _Name.Name = "NAME"
        _Code.Name = "CODE"
        _Title.Name = "TITLE"
        _Priority.Name = "PRIORITY"
        _Value.Name = "VALUE"
        _Description.Name = "DESCRIPTION"
        _ArabicTitle.Name = "AR_TITLE"
        _Status.Name = "STATUS"
        _OldDomId.Name = "OLD_DOM_ID"
        _AccountId.Name = "ACC_ID"
        _Value2.Name = "VALUE2"
        _Value3.Name = "VALUE3"
    End Sub
    Public Sub Reset()
        _Id.Reset()
        _DomainId.Reset()
        _PermissionId.Reset()
        _Type.Reset()
        _Name.Reset()
        _Code.Reset()
        _Title.Reset()
        _Priority.Reset()
        _Value.Reset()
        _Description.Reset()
        _ArabicTitle.Reset()
        _Status.Reset()
        _OldDomId.Reset()
        _AccountId.Reset()
        _Value2.Reset()
        _Value3.Reset()
    End Sub

    ''' <summary> </summary>
    Public Property Id() As Integer
        Get
            Return _Id.Value
        End Get
        Set(ByVal value As Integer)
            _Id.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property DomainId() As Integer
        Get
            Return _DomainId.Value
        End Get
        Set(ByVal value As Integer)
            _DomainId.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property PermissionId() As Integer
        Get
            Return _PermissionId.Value
        End Get
        Set(ByVal value As Integer)
            _PermissionId.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Type() As Integer
        Get
            Return _Type.Value
        End Get
        Set(ByVal value As Integer)
            _Type.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Name() As String
        Get
            Return _Name.Value
        End Get
        Set(ByVal value As String)
            _Name.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Code() As Integer
        Get
            Return _Code.Value
        End Get
        Set(ByVal value As Integer)
            _Code.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Title() As String
        Get
            Return _Title.Value
        End Get
        Set(ByVal value As String)
            _Title.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Priority() As Integer
        Get
            Return _Priority.Value
        End Get
        Set(ByVal value As Integer)
            _Priority.Value = value
        End Set
    End Property

    Public Property Value() As Double
        Get
            Return _Value.Value
        End Get
        Set(ByVal value As Double)
            _Value.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Description() As String
        Get
            Return _Description.Value
        End Get
        Set(ByVal value As String)
            _Description.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property ArabicTitle() As String
        Get
            Return _ArabicTitle.Value
        End Get
        Set(ByVal value As String)
            _ArabicTitle.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property Status() As Integer
        Get
            Return _Status.Value
        End Get
        Set(ByVal value As Integer)
            _Status.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property OldDomId() As Integer
        Get
            Return _OldDomId.Value
        End Get
        Set(ByVal value As Integer)
            _OldDomId.Value = value
        End Set
    End Property

    ''' <summary> </summary>
    Public Property AccountId() As Integer
        Get
            Return _AccountId.Value
        End Get
        Set(ByVal value As Integer)
            _AccountId.Value = value
        End Set
    End Property
    ''' <summary> </summary>
    Public Property Value2() As String
        Get
            Return _Value2.Value
        End Get
        Set(ByVal value As String)
            _Value2.Value = value
        End Set
    End Property
    ''' <summary> </summary>
    Public Property Value3() As String
        Get
            Return _Value3.Value
        End Get
        Set(ByVal value As String)
            _Value3.Value = value
        End Set
    End Property

#End Region

    Private Function GetNextId(ByVal cnn As SqlClient.SqlConnection) As Long
        Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, cnn) + 1
    End Function

    Public Function Insert(ByVal cnn As SqlClient.SqlConnection) As Long
        Dim str As String = ""
        Dim Values As String = ""
        Id = GetNextId(cnn)
        str = "INSERT INTO " & TableName & "(ID"
        Values = ") VALUES(" & Id
        If _DomainId.isSet Then str &= ", " & _DomainId.Name : Values &= ", " & _DomainId.Value
        If _PermissionId.isSet Then str &= ", " & _PermissionId.Name : Values &= ", " & _PermissionId.Value
        If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
        If _Name.isSet Then str &= ", " & _Name.Name : Values &= ", '" & _Name.Value & "'"
        If _Code.isSet Then str &= ", " & _Code.Name : Values &= ", " & _Code.Value
        If _Title.isSet Then str &= ", " & _Title.Name : Values &= ", '" & _Title.Value & "'"
        If _Priority.isSet Then str &= ", " & _Priority.Name : Values &= ", " & _Priority.Value
        If _Value.isSet Then str &= ", " & _Value.Name : Values &= ", " & _Value.Value
        If _Description.isSet Then str &= ", " & _Description.Name : Values &= ", '" & _Description.Value & "'"
        If _ArabicTitle.isSet Then str &= ", " & _ArabicTitle.Name : Values &= ", '" & _ArabicTitle.Value & "'"
        If _Status.isSet Then str &= ", " & _Status.Name : Values &= ", " & _Status.Value
        If _OldDomId.isSet Then str &= ", " & _OldDomId.Name : Values &= ", " & _OldDomId.Value
        If _AccountId.isSet Then str &= ", " & _AccountId.Name : Values &= ", " & _AccountId.Value
        If _Value2.isSet Then str &= ", " & _Value2.Name : Values &= ", '" & _Value2.Value & "'"
        If _Value3.isSet Then str &= ", " & _Value3.Name : Values &= ", '" & _Value3.Value & "'"

        SQL.ExecuteNonQuery(str & Values & ")", cnn)
        Return Id
    End Function

    Public Sub Edit(ByVal Id As Long, ByVal cnn As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery(getEditString() & "   WHERE ID=" & Id, cnn)
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
        SQL.ExecuteNonQuery(getEditString() & "   WHERE " & getConditionString(c))
    End Sub

    Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
        SQL.ExecuteNonQuery(getEditString() & "   WHERE " & getConditionString(Condition))
    End Sub

    Private Function getEditString() As String
        Dim str As String = "UPDATE " & TableName & " SET "
        If _Id.isSet Then str &= _Id.Name & "=" & IIf(_Id.isDBNull, "Null", _Id.Value & "") & ","
        If _DomainId.isSet Then str &= _DomainId.Name & "=" & IIf(_DomainId.isDBNull, "Null", _DomainId.Value & "") & ","
        If _PermissionId.isSet Then str &= _PermissionId.Name & "=" & IIf(_PermissionId.isDBNull, "Null", _PermissionId.Value & "") & ","
        If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
        If _Name.isSet Then str &= _Name.Name & "=" & IIf(_Name.isDBNull, "Null", "'" & _Name.Value & "'") & ","
        If _Code.isSet Then str &= _Code.Name & "=" & IIf(_Code.isDBNull, "Null", _Code.Value & "") & ","
        If _Title.isSet Then str &= _Title.Name & "=" & IIf(_Title.isDBNull, "Null", "'" & _Title.Value & "'") & ","
        If _Priority.isSet Then str &= _Priority.Name & "=" & IIf(_Priority.isDBNull, "Null", _Priority.Value & "") & ","
        If _Value.isSet Then str &= _Value.Name & "=" & IIf(_Value.isDBNull, "Null", _Value.Value & "") & ","
        If _Description.isSet Then str &= _Description.Name & "=" & IIf(_Description.isDBNull, "Null", "'" & _Description.Value & "'") & ","
        If _ArabicTitle.isSet Then str &= _ArabicTitle.Name & "=" & IIf(_ArabicTitle.isDBNull, "Null", "'" & _ArabicTitle.Value & "'") & ","
        If _Status.isSet Then str &= _Status.Name & "=" & IIf(_Status.isDBNull, "Null", _Status.Value & "") & ","
        If _OldDomId.isSet Then str &= _OldDomId.Name & "=" & IIf(_OldDomId.isDBNull, "Null", _OldDomId.Value & "") & ","
        If _AccountId.isSet Then str &= _AccountId.Name & "=" & IIf(_AccountId.isDBNull, "Null", _AccountId.Value & "") & ","
        If _Value2.isSet Then str &= _Value2.Name & "=" & IIf(_Value2.isDBNull, "Null", "'" & _Value2.Value & "'") & ","
        If _Value3.isSet Then str &= _Value3.Name & "=" & IIf(_Value3.isDBNull, "Null", "'" & _Value3.Value & "'") & ","

        If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
        Return str
    End Function

    Public Sub Delete(ByVal ID As Long, ByVal cnn As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, cnn)
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
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE " & getConditionString(c))
    End Sub

    Public Sub Delete(ByVal ParamArray Condition() As stcCondition)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE " & getConditionString(Condition))
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
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE " & getConditionString(c))
    End Function

    Public Function getValue(ByVal ColumnName As Columns, ByVal ParamArray Condition() As stcCondition) As Object
        Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE " & getConditionString(Condition))
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
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE " & getConditionString(c))
    End Function

    Public Function getRow(ByVal ParamArray Condition() As stcCondition) As DataRow
        Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE " & getConditionString(Condition))
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
        Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & "   WHERE ISNULL(STATUS,1151)<>1150 AND " & getConditionString(c))
    End Function

    Public Function [Select](ByVal ParamArray Condition() As stcCondition) As DataTable
        Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & "   WHERE ISNULL(STATUS,1151)<>1150 AND " & getConditionString(Condition))
    End Function

    Private Function getConditionString(ByVal ParamArray Condition() As stcCondition) As String
        Dim str As String = ""
        For Each c As stcCondition In Condition
            Dim vOperator As String = SQL.ExecuteScalar("SELECT TITLE FROM DOMAINS   WHERE ID=" & c.Operator)
            str &= c.Oprand & IIf(c.OpenParenthes, "(", "") &
         ColumnNames(c.Name) & " " & vOperator &
         IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) &
         IIf(c.CloseParenthes, ")", "")
        Next
        Return str
    End Function

    Public Function [Select](ByVal Id As Enums.DomainKeys) As DataTable
        Return SQL.ExecuteDataTable("SELECT * FROM DOMAINS   WHERE DOM_ID=" & Id & "AND ISNULL(STATUS,1151)<>1150  ORDER BY PRIORITY ")
    End Function

    Public Function [Select](ByVal Id As Enums.PropertyKeys) As DataTable
        Return SQL.ExecuteDataTable("SELECT * FROM DOMAINS   WHERE DOM_ID=" & Id & " AND ISNULL(STATUS,1151)<>1150  ORDER BY PRIORITY ")
    End Function

    Public Function getTitle(ByVal Id As Integer) As String
        Return SQL.ExecuteScalar("SELECT TITLE FROM DOMAINS   WHERE ID=" & Id)
    End Function

    Public Function getId(ByVal ParentId As Enums.DomainKeys, ByVal Code As Integer) As String
        Return SQL.ExecuteScalar("SELECT ID FROM DOMAINS   WHERE DOM_ID=" & ParentId & " AND CODE=" & Code)
    End Function

    Public Function getId(ByVal ParentId As Enums.PropertyKeys, ByVal Code As Integer) As String
        Return SQL.ExecuteScalar("SELECT ID FROM DOMAINS   WHERE DOM_ID=" & ParentId & " AND CODE=" & Code)
    End Function
    Public Function getValue(ByVal ID As Enums.DomainKeys, ByVal DateTime As String) As String
        Dim str As String
        str = "SELECT VALUE " &
              "FROM DOMAIN_VALUES " &
              "  WHERE DOM_ID=" & ID & " AND " & IIf(DateTime = "", " TO_DATE_TIME IS NULL ", "'" & DateTime & "' BETWEEN FROM_DATE_TIME AND ISNULL(TO_DATE_TIME, '1500/01/01')")
        Return SQL.ExecuteScalar(str)
    End Function
    ''' <summary> </summary>
    Public Class clsValues
        Public TableName As String = "DOMAIN_VALUES"
#Region "Property"

        Private _Id As DataType.Integer
        Private _DomainId As DataType.Integer
        Private _Type As DataType.Integer
        Private _Value As DataType.String
        Private _FromDateTime As DataType.String
        Private _ToDateTime As DataType.String
        Private _DomainIdRelated As DataType.Integer
        Private _AccountID As DataType.Integer
        Public Enum Columns
            Id = 0
            DomainId = 1
            Type = 2
            Value = 3
            FromDateTime = 4
            ToDateTime = 5
            DomainIdRelated = 6
            AccountID = 7
        End Enum

        Private ColumnNames() As String = {"ID", "DOM_ID", "TYPE", "VALUE", "FROM_DATE_TIME", "TO_DATE_TIME", "DOM_ID_RELATED", "ACC_ID"}

        Private ColumnQuotation() As String = {"", "", "", "'", "'", "'", "", ""}

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
            _Id.Name = "ID"
            _DomainId.Name = "DOM_ID"
            _Type.Name = "TYPE"
            _Value.Name = "VALUE"
            _FromDateTime.Name = "FROM_DATE_TIME"
            _ToDateTime.Name = "TO_DATE_TIME"
            _DomainIdRelated.Name = "DOM_ID_RELATED"
            _AccountID.Name = "ACC_ID"

        End Sub

        Public Sub Reset()
            _Id.Reset()
            _DomainId.Reset()
            _Type.Reset()
            _Value.Reset()
            _FromDateTime.Reset()
            _ToDateTime.Reset()
            _DomainIdRelated.Reset()
            _AccountID.Reset()

        End Sub

        ''' <summary> </summary>
        Public Property Id() As Integer
            Get
                Return _Id.Value
            End Get
            Set(ByVal value As Integer)
                _Id.Value = value
            End Set
        End Property

        ''' <summary> </summary>
        Public Property DomainId() As Integer
            Get
                Return _DomainId.Value
            End Get
            Set(ByVal value As Integer)
                _DomainId.Value = value
            End Set
        End Property

        ''' <summary> </summary>
        Public Property Type() As Integer
            Get
                Return _Type.Value
            End Get
            Set(ByVal value As Integer)
                _Type.Value = value
            End Set
        End Property

        ''' <summary> </summary>
        Public Property Value() As String
            Get
                Return _Value.Value
            End Get
            Set(ByVal value As String)
                _Value.Value = value
            End Set
        End Property

        ''' <summary> </summary>
        Public Property FromDateTime() As String
            Get
                Return _FromDateTime.Value
            End Get
            Set(ByVal value As String)
                _FromDateTime.Value = value
            End Set
        End Property

        ''' <summary> </summary>
        Public Property ToDateTime() As String
            Get
                Return _ToDateTime.Value
            End Get
            Set(ByVal value As String)
                _ToDateTime.Value = value
            End Set
        End Property

        Public Property DomainIdRelated() As Integer
            Get
                Return _DomainIdRelated.Value
            End Get
            Set(ByVal value As Integer)
                _DomainIdRelated.Value = value
            End Set
        End Property
        ''' <summary> </summary>
        Public Property AccountID() As Integer
            Get
                Return _AccountID.Value
            End Get
            Set(ByVal value As Integer)
                _AccountID.Value = value
            End Set
        End Property
#End Region
        Private Function GetNextId(ByVal cnn As SqlClient.SqlConnection) As Long
            Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, cnn) + 1
        End Function
        Public Function Insert(ByVal cnn As SqlClient.SqlConnection) As Long
            Dim str As String = ""
            Dim Values As String = ""
            Id = GetNextId(cnn)
            str = "INSERT INTO " & TableName & "(ID"
            Values = ") VALUES(" & Id
            If _DomainId.isSet Then str &= ", " & _DomainId.Name : Values &= ", " & _DomainId.Value
            If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
            If _Value.isSet Then str &= ", " & _Value.Name : Values &= ", '" & _Value.Value & "'"
            If _FromDateTime.isSet Then str &= ", " & _FromDateTime.Name : Values &= ", '" & _FromDateTime.Value & "'"
            If _ToDateTime.isSet Then str &= ", " & _ToDateTime.Name : Values &= ", '" & _ToDateTime.Value & "'"
            If _DomainIdRelated.isSet Then str &= ", " & _DomainIdRelated.Name : Values &= ", " & _DomainIdRelated.Value
            If _AccountID.isSet Then str &= ", " & _AccountID.Name : Values &= ", " & _AccountID.Value

            str &= ", USE_ID_CREATOR" : Values &= ", " & Globals.CurrentUser.Id
            str &= ", CREATE_DATE_TIME" : Values &= ", dbo.getCurrentDateTime()"
            SQL.ExecuteNonQuery(str & Values & ")", cnn)
            Return Id
        End Function
        Public Sub Edit(ByVal Id As Long, ByVal cnn As SqlClient.SqlConnection)
            SQL.ExecuteNonQuery(getEditString() & "   WHERE ID=" & Id, cnn)
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
            SQL.ExecuteNonQuery(getEditString() & "   WHERE " & getConditionString(c))
        End Sub

        Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
            SQL.ExecuteNonQuery(getEditString() & "   WHERE " & getConditionString(Condition))
        End Sub

        Private Function getEditString() As String
            Dim str As String = "UPDATE " & TableName & " SET "
            If _Id.isSet Then str &= _Id.Name & "=" & IIf(_Id.isDBNull, "Null", _Id.Value & "") & ","
            If _DomainId.isSet Then str &= _DomainId.Name & "=" & IIf(_DomainId.isDBNull, "Null", _DomainId.Value & "") & ","
            If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
            If _Value.isSet Then str &= _Value.Name & "=" & IIf(_Value.isDBNull, "Null", "'" & _Value.Value & "'") & ","
            If _FromDateTime.isSet Then str &= _FromDateTime.Name & "=" & IIf(_FromDateTime.isDBNull, "Null", "'" & _FromDateTime.Value & "'") & ","
            If _ToDateTime.isSet Then str &= _ToDateTime.Name & "=" & IIf(_ToDateTime.isDBNull, "Null", "'" & _ToDateTime.Value & "'") & ","
            If _DomainIdRelated.isSet Then str &= _DomainIdRelated.Name & "=" & IIf(_DomainIdRelated.isDBNull, "Null", _DomainIdRelated.Value & "") & ","
            If _AccountID.isSet Then str &= _AccountID.Name & "=" & IIf(_AccountID.isDBNull, "Null", _AccountID.Value & "") & ","
            If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
            Return str
        End Function

        Public Sub Delete(ByVal ID As Long, ByVal cnn As SqlClient.SqlConnection)
            SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, cnn)
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
            SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE " & getConditionString(c))
        End Sub

        Public Sub Delete(ByVal ParamArray Condition() As stcCondition)
            SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE " & getConditionString(Condition))
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
            Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE " & getConditionString(c))
        End Function
        Public Function getValue(ByVal ColumnName As Columns, ByVal ParamArray Condition() As stcCondition) As Object
            Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE " & getConditionString(Condition))
        End Function
        Public Function getValue(ByVal ID As Integer, ByVal DateTime As String) As String
            Dim str As String
            str = "SELECT VALUE " &
                  "FROM DOMAIN_VALUES " &
                  "  WHERE DOM_ID=" & ID & " AND " & IIf(DateTime = "", " TO_DATE_TIME IS NULL ", "'" & DateTime & "' BETWEEN FROM_DATE_TIME AND ISNULL(TO_DATE_TIME, '1500/01/01')")
            Return SQL.ExecuteScalar(str)
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
            Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE " & getConditionString(c))
        End Function

        Public Function getRow(ByVal ParamArray Condition() As stcCondition) As DataRow
            Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE " & getConditionString(Condition))
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
            Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & "   WHERE " & getConditionString(c))
        End Function

        Public Function [Select](ByVal ParamArray Condition() As stcCondition) As DataTable
            Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & "   WHERE " & getConditionString(Condition))
        End Function

        Private Function getConditionString(ByVal ParamArray Condition() As stcCondition) As String
            Dim str As String = ""
            For Each c As stcCondition In Condition
                Dim vOperator As String = SQL.ExecuteScalar("SELECT TITLE FROM DOMAINS   WHERE ID=" & c.Operator)
                str &= c.Oprand & IIf(c.OpenParenthes, "(", "") &
            ColumnNames(c.Name) & " " & vOperator &
            IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) &
            IIf(c.CloseParenthes, ")", "")
            Next
            Return str
        End Function
        Public Function selCurrencyTypeCost(ByVal vDate As String) As DataTable
            If vDate.Trim = "" Then vDate = SQL.getDate()
            Dim str As String = "SELECT D.ID,D.TITLE, DV.VALUE ,CAST( DV.VALUE AS INT) AS PRICE " & vbCrLf &
                                "FROM DOMAINS D" & vbCrLf &
                                "INNER JOIN DOMAIN_VALUES DV ON D.ID=DV.DOM_ID AND DV.TYPE=" & Enums.Keys.DomainValueType.CurrencyTypeCost & "  AND '" & vDate & "' BETWEEN DV.FROM_DATE_TIME AND ISNULL(DV.TO_DATE_TIME,'5000/12/30') " & vbCrLf &
                                "WHERE D.DOM_ID=" & Enums.PropertyKeys.CurrencyType & vbCrLf &
                                "ORDER BY D.PRIORITY "
            Return SQL.ExecuteDataTable(str)
        End Function
   End Class

End Class
