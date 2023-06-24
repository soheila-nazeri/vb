''' <summary>کاربران </summary>
Public Class User

  Public TableName As String = "USERS"
  Public Properties As New clsProperties
  Public Permission As New clsPermission

#Region "Property"

  Private _Id As DataType.Integer
  Private _Name As DataType.String
  Private _PeopleId As DataType.Long
  Private _Password As DataType.String
    Private _Enabled As DataType.Integer
    Private _EnglishName As DataType.String

  Public Enum Columns
    Id = 0
    Name = 1
    PeopleId = 2
    Password = 3
        Enabled = 4
        EnglishName = 5
  End Enum

    Private ColumnNames() As String = {"ID", "NAME", "PEO_ID", "PASSWORD", "ENABLED", "ENGLISH_NAME"}

    Private ColumnQuotation() As String = {"", "'", "", "'", "", "'"}

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
        _Name.Name = "NAME"
        _PeopleId.Name = "PEO_ID"
        _Password.Name = "PASSWORD"
        _Enabled.Name = "ENABLED"
        _EnglishName.Name = "ENGLISH_NAME"
    End Sub

    Public Sub Reset()
        _Id.Reset()
        _Name.Reset()
        _PeopleId.Reset()
        _Password.Reset()
        _Enabled.Reset()
        _EnglishName.Reset()
    End Sub

    ''' <summary>شناسه </summary>
    Public Property Id() As Integer
        Get
            Return _Id.Value
        End Get
        Set(ByVal value As Integer)
            _Id.Value = value
        End Set
    End Property

    ''' <summary>نام </summary>
    Public Property Name() As String
        Get
            Return _Name.Value
        End Get
        Set(ByVal value As String)
            _Name.Value = value
        End Set
    End Property

    ''' <summary>شنامه فرد </summary>
    Public Property PeopleId() As Long
        Get
            Return _PeopleId.Value
        End Get
        Set(ByVal value As Long)
            _PeopleId.Value = value
        End Set
    End Property

    ''' <summary>رمز </summary>
    Public Property Password() As String
        Get
            Return _Password.Value
        End Get
        Set(ByVal value As String)
            _Password.Value = value
        End Set
    End Property

    ''' <summary>فعال </summary>
    Public Property Enabled() As Integer
        Get
            Return _Enabled.Value
        End Get
        Set(ByVal value As Integer)
            _Enabled.Value = value
        End Set
    End Property

    ''' <summary>نام لاتین </summary>
    Public Property EnglishName() As String
        Get
            Return _EnglishName.Value
        End Get
        Set(ByVal value As String)
            _EnglishName.Value = value
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
        If _Name.isSet Then str &= ", " & _Name.Name : Values &= ", '" & _Name.Value & "'"
        If _PeopleId.isSet Then str &= ", " & _PeopleId.Name : Values &= ", " & _PeopleId.Value
        If _Password.isSet Then str &= ", " & _Password.Name : Values &= ", '" & _Password.Value & "'"
        If _Enabled.isSet Then str &= ", " & _Enabled.Name : Values &= ", " & _Enabled.Value
        If _EnglishName.isSet Then str &= ", " & _EnglishName.Name : Values &= ", '" & _EnglishName.Value & "'"
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
        SQL.ExecuteNonQuery(getEditString() & getConditionString(c))
    End Sub

    Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
        SQL.ExecuteNonQuery(getEditString() & getConditionString(Condition))
    End Sub

    Private Function getEditString() As String
        Dim str As String = "UPDATE " & TableName & " SET "
        If _Id.isSet Then str &= _Id.Name & "=" & IIf(_Id.isDBNull, "Null", _Id.Value & "") & ","
        If _Name.isSet Then str &= _Name.Name & "=" & IIf(_Name.isDBNull, "Null", "'" & _Name.Value & "'") & ","
        If _PeopleId.isSet Then str &= _PeopleId.Name & "=" & IIf(_PeopleId.isDBNull, "Null", _PeopleId.Value & "") & ","
        If _Password.isSet Then str &= _Password.Name & "=" & IIf(_Password.isDBNull, "Null", "'" & _Password.Value & "'") & ","
        If _Enabled.isSet Then str &= _Enabled.Name & "=" & IIf(_Enabled.isDBNull, "Null", _Enabled.Value & "") & ","
        If _EnglishName.isSet Then str &= _EnglishName.Name & "=" & IIf(_EnglishName.isDBNull, "Null", "'" & _EnglishName.Value & "'") & ","
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
            str &= c.Oprand & IIf(c.OpenParenthes, "(", "") &
         ColumnNames(c.Name) & " " & vOperator &
         IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) &
         IIf(c.CloseParenthes, ")", "")
        Next
        If str <> "" Then str = "   WHERE " & str
        Return str
    End Function

    ''' <summary>مشخصه ها </summary>
    Public Class clsProperties

        Public TableName As String = "USER_PROPERTIES"

#Region "Property"

        Private _Id As DataType.Integer
        Private _Type As DataType.Integer
        Private _UserId As DataType.Integer
        Private _DomainId As DataType.Integer
        Private _Value As DataType.String

        Public Enum Columns
            Id = 0
            Type = 1
            UserId = 2
            DomainId = 3
            Value = 4
        End Enum

        Private ColumnNames() As String = {"ID", "TYPE", "USE_ID", "DOM_ID", "VALUE"}

        Private ColumnQuotation() As String = {"", "", "", "", "'"}

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
            _Type.Name = "TYPE"
            _UserId.Name = "USE_ID"
            _DomainId.Name = "DOM_ID"
            _Value.Name = "VALUE"
        End Sub

        Public Sub Reset()
            _Id.Reset()
            _Type.Reset()
            _UserId.Reset()
            _DomainId.Reset()
            _Value.Reset()
        End Sub

        ''' <summary>شناسه </summary>
        Public Property Id() As Integer
            Get
                Return _Id.Value
            End Get
            Set(ByVal value As Integer)
                _Id.Value = value
            End Set
        End Property

        ''' <summary>نوع </summary>
        Public Property Type() As Integer
            Get
                Return _Type.Value
            End Get
            Set(ByVal value As Integer)
                _Type.Value = value
            End Set
        End Property

        ''' <summary>شناسه کاربر </summary>
        Public Property UserId() As Integer
            Get
                Return _UserId.Value
            End Get
            Set(ByVal value As Integer)
                _UserId.Value = value
            End Set
        End Property

        ''' <summary>شناسه دامنه </summary>
        Public Property DomainId() As Integer
            Get
                Return _DomainId.Value
            End Get
            Set(ByVal value As Integer)
                _DomainId.Value = value
            End Set
        End Property

        ''' <summary>مقدار </summary>
        Public Property Value() As String
            Get
                Return _Value.Value
            End Get
            Set(ByVal value As String)
                _Value.Value = value
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
            If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
            If _UserId.isSet Then str &= ", " & _UserId.Name : Values &= ", " & _UserId.Value
            If _DomainId.isSet Then str &= ", " & _DomainId.Name : Values &= ", " & _DomainId.Value
            If _Value.isSet Then str &= ", " & _Value.Name : Values &= ", '" & _Value.Value & "'"
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
            If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
            If _UserId.isSet Then str &= _UserId.Name & "=" & IIf(_UserId.isDBNull, "Null", _UserId.Value & "") & ","
            If _DomainId.isSet Then str &= _DomainId.Name & "=" & IIf(_DomainId.isDBNull, "Null", _DomainId.Value & "") & ","
            If _Value.isSet Then str &= _Value.Name & "=" & IIf(_Value.isDBNull, "Null", "'" & _Value.Value & "'") & ","
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

    End Class

    ''' <summary>محوزها </summary>
    Public Class clsPermission

        Public TableName As String = "USER_PERMISSIONS"

#Region "Property"

        Private _Id As DataType.Integer
        Private _UserId As DataType.Integer
        Private _PermissionId As DataType.Integer
        Private _Status As DataType.Integer
        Private _FromDateTime As DataType.String
        Private _ToDateTime As DataType.String

        Public Enum Columns
            Id = 0
            UserId = 1
            PermissionId = 2
            Status = 3
            FromDateTime = 4
            ToDateTime = 5
        End Enum

        Private ColumnNames() As String = {"ID", "USE_ID", "PER_ID", "STATUS", "FROM_DATE_TIME", "TO_DATE_TIME"}

        Private ColumnQuotation() As String = {"", "", "", "", "'", "'"}

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
            _UserId.Name = "USE_ID"
            _PermissionId.Name = "PER_ID"
            _Status.Name = "STATUS"
            _FromDateTime.Name = "FROM_DATE_TIME"
            _ToDateTime.Name = "TO_DATE_TIME"
        End Sub

        Public Sub Reset()
            _Id.Reset()
            _UserId.Reset()
            _PermissionId.Reset()
            _Status.Reset()
            _FromDateTime.Reset()
            _ToDateTime.Reset()
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
        Public Property UserId() As Integer
            Get
                Return _UserId.Value
            End Get
            Set(ByVal value As Integer)
                _UserId.Value = value
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
        Public Property Status() As Integer
            Get
                Return _Status.Value
            End Get
            Set(ByVal value As Integer)
                _Status.Value = value
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
            If _UserId.isSet Then str &= ", " & _UserId.Name : Values &= ", " & _UserId.Value
            If _PermissionId.isSet Then str &= ", " & _PermissionId.Name : Values &= ", " & _PermissionId.Value
            If _Status.isSet Then str &= ", " & _Status.Name : Values &= ", " & _Status.Value
            If _FromDateTime.isSet Then str &= ", " & _FromDateTime.Name : Values &= ", '" & _FromDateTime.Value & "'"
            If _ToDateTime.isSet Then str &= ", " & _ToDateTime.Name : Values &= ", '" & _ToDateTime.Value & "'"
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
            SQL.ExecuteNonQuery(getEditString() & getConditionString(c))
        End Sub

        Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
            SQL.ExecuteNonQuery(getEditString() & getConditionString(Condition))
        End Sub

        Private Function getEditString() As String
            Dim str As String = "UPDATE " & TableName & " SET "
            If _Id.isSet Then str &= _Id.Name & "=" & IIf(_Id.isDBNull, "Null", _Id.Value & "") & ","
            If _UserId.isSet Then str &= _UserId.Name & "=" & IIf(_UserId.isDBNull, "Null", _UserId.Value & "") & ","
            If _PermissionId.isSet Then str &= _PermissionId.Name & "=" & IIf(_PermissionId.isDBNull, "Null", _PermissionId.Value & "") & ","
            If _Status.isSet Then str &= _Status.Name & "=" & IIf(_Status.isDBNull, "Null", _Status.Value & "") & ","
            If _FromDateTime.isSet Then str &= _FromDateTime.Name & "=" & IIf(_FromDateTime.isDBNull, "Null", "'" & _FromDateTime.Value & "'") & ","
            If _ToDateTime.isSet Then str &= _ToDateTime.Name & "=" & IIf(_ToDateTime.isDBNull, "Null", "'" & _ToDateTime.Value & "'") & ","
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
                str &= c.Oprand & IIf(c.OpenParenthes, "(", "") &
            ColumnNames(c.Name) & " " & vOperator &
            IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) &
            IIf(c.CloseParenthes, ")", "")
            Next
         If str <> "" Then str = "   WHERE " & str
         Return str
      End Function

   End Class
    Public Function SelInfo(ByVal UserName As String, ByVal PassWord As String) As DataRow
        Dim strsql As String = ""
        strsql = "SELECT * FROM USERS WHERE NAME='" & UserName & "'AND PASSWORD='" & PassWord.GetHashCode & "'"
        Return SQL.ExecuteDataRow(strsql, Nothing)
    End Function
End Class
