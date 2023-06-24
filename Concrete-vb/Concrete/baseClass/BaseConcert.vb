Public Class BaseConcert
    Public TableName As String = "CONCRETE"
#Region "Property"
    Private _Id As DataType.Long
    Private _RequesterId As DataType.Long
    Private _EmployerId As DataType.Long
    Private _Address As DataType.String
    Private _Location As DataType.String
    Private _code As DataType.String
    Private _date As DataType.String
    Private _RequesterCode As DataType.String
    Private _FcId As DataType.String
    Public Enum Columns
        _Id = 0
        _RequesterId = 1
        _EmployerId = 2
        _Address = 3
        _Location = 4
        _code = 5
        _Date = 6
        _RequesterCode = 7
        _FcId = 8
    End Enum
    Private ColumnNames() As String = {"ID", "REQUESTER_ID", "EMPLOYER_ID", "ADDRESS", "LOCATION", "CODE", "_Date", "REQUESTER_CODE", "FC_ID"}
    Private ColumnQuotation() As String = {"", "", "", "'", "'", "'", "'", "'", ""}
    Public Sub New()
        _Id.Name = "ID"
        _RequesterId.Name = "REQUESTER_ID"
        _EmployerId.Name = "EMPLOYER_ID"
        _Address.Name = "ADDRESS"
        _Location.Name = "LOCATION"
        _code.Name = "CODE"
        _date.Name = "_Date"
        _RequesterCode.Name = "REQUESTER_CODE"
        _FcId.Name = "FC_ID"
    End Sub
    Public Sub Reset()
        _Id.Reset()
        _RequesterId.Reset()
        _EmployerId.Reset()
        _Address.Reset()
        _Location.Reset()
        _code.Reset()
        _date.Reset()
        _RequesterCode.Reset()
        _FcId.Reset()
    End Sub
    Public Property Id() As Long
        Get
            Return _Id.Value
        End Get
        Set(ByVal value As Long)
            _Id.Value = value
        End Set
    End Property
    ''' <summary>نوع </summary>
    Public Property REQUESTER_ID() As Long
        Get
            Return _RequesterId.Value
        End Get
        Set(ByVal value As Long)
            _RequesterId.Value = value
        End Set
    End Property
    ''' <summary>کد </summary>
    Public Property EMPLOYER_ID() As Long
        Get
            Return _EmployerId.Value
        End Get
        Set(ByVal value As Long)
            _EmployerId.Value = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _Address.Value
        End Get
        Set(ByVal value As String)
            _Address.Value = value
        End Set
    End Property
    Public Property LOCATION() As String
        Get
            Return _Location.Value
        End Get
        Set(ByVal value As String)
            _Location.Value = value
        End Set
    End Property
    Public Property CODE() As String
        Get
            Return _code.Value
        End Get
        Set(ByVal value As String)
            _code.Value = value
        End Set
    End Property
    Public Property DATE_() As String
        Get
            Return _date.Value
        End Get
        Set(ByVal value As String)
            _date.Value = value
        End Set
    End Property
    Public Property REQUESTER_CODE() As String
        Get
            Return _RequesterCode.Value
        End Get
        Set(ByVal value As String)
            _RequesterCode.Value = value
        End Set
    End Property
    Public Property Fc_ID() As Integer
        Get
            Return _FcId.Value
        End Get
        Set(ByVal value As Integer)
            _FcId.Value = value
        End Set
    End Property
#End Region

    Public Function Insert(ByVal cnn As SqlClient.SqlConnection) As Long
        Dim str As String = ""
        Dim Values As String = ""
        str = "INSERT INTO " & TableName & "("
        Values = ") VALUES("

        If _RequesterId.isSet Then str &= _RequesterId.Name : Values &= _RequesterId.Value
        If _EmployerId.isSet Then str &= ", " & _EmployerId.Name : Values &= ", " & _EmployerId.Value
        If _FcId.isSet Then str &= ", " & _FcId.Name : Values &= ", " & _FcId.Value


        If _Address.isSet Then str &= ", " & _Address.Name : Values &= ", '" & _Address.Value & "'"
        If _Location.isSet Then str &= ", " & _Location.Name : Values &= ", '" & _Location.Value & "'"
        If _code.isSet Then str &= ", " & _code.Name : Values &= ", '" & _code.Value & "'"
        If _date.isSet Then str &= ", " & _date.Name : Values &= ", '" & _date.Value & "'"
        If _RequesterCode.isSet Then str &= ", " & _RequesterCode.Name : Values &= ", '" & _RequesterCode.Value & "'"

        str &= ", USE_ID_CREATOR" : Values &= ", " & Globals.CurrentUser.Id
        str &= ", CREATE_DATE_TIME" : Values &= ", dbo.getCurrentDateTime()"
        SQL.ExecuteNonQuery(str & Values & ")", cnn)
        Id = GetNextId(Nothing )
        Return Id
    End Function
    Private Function GetNextId(ByVal cnn As SqlClient.SqlConnection) As Long
        Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, cnn)
    End Function

    Public Sub Edit(ByVal Id As Long, ByVal cnn As SqlClient.SqlConnection)
        Dim str As String = "UPDATE " & TableName & " SET "
        If _Id.isSet Then str &= _Id.Name & "=" & _Id.Value & ","


        If _Id.isSet Then str &= _Id.Name & "=" & _Id.Value & ","
        If _RequesterId.isSet Then str &= _RequesterId.Name & "=" & _RequesterId.Value & ","
        If _EmployerId.isSet Then str &= _EmployerId.Name & "=" & _EmployerId.Value & ","
        If _FcId.isSet Then str &= _FcId.Name & "=" & _FcId.Value & ","

        If _Address.isSet Then str &= _Address.Name & "='" & _Address.Value & "',"
        If _Location.isSet Then str &= _Location.Name & "='" & _Location.Value & "',"
        If _code.isSet Then str &= _code.Name & "='" & _code.Value & "',"
        If _date.isSet Then str &= _date.Name & "='" & _date.Value & "',"
        If _RequesterCode.isSet Then str &= _RequesterCode.Name & "='" & _RequesterCode.Value & "',"



        If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
        str &= "  WHERE ID=" & Id
        SQL.ExecuteNonQuery(str, cnn)
    End Sub
    Public Sub Delete(ByVal ID As Long, ByVal cnn As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, cnn)
    End Sub
    ''' <summary>ITEMS  </summary>
    Public Class clsItems
        Public TableName As String = "CONCRETE_DETAILS"
#Region "items"
        Private _Id As DataType.Long
        Private _conId As DataType.Long
        Private _Number As DataType.String
        Private _Date As DataType.String
        Private _Age As DataType.Double
        Private _Weight As DataType.Double
        Private _SpecialWeight As DataType.Double
        Private _LoadingSurfaceCm2 As DataType.Double
        Private _SampleVolumeCm3 As DataType.Double
        Private _LoadSurface As DataType.Double
        Private _Cubic As DataType.Double
        Private _Cylinder As DataType.Double
        Private _AvgCylinder As DataType.Double
        Private _width As DataType.Double
        Private _length As DataType.Double
        Private _height As DataType.Double

        Public Enum Columns
            _Id = 0
            _conId = 1
            _Number = 2
            _Date = 3
            _Age = 4
            _Weight = 5
            _SpecialWeight = 6
            _LoadingSurfaceCm2 = 7
            _SampleVolumeCm3 = 8
            _LoadSurface = 9
            _Cubic = 10
            _Cylinder = 11
            _AvgCylinder = 12
            _width = 13
            _length = 14
            _height = 15
        End Enum
        Private ColumnNames() As String = {"ID", "CON_ID", "NUMBER", "_DATE", "AGE", "WEIGHT",
              "SPECIAL_WEIGHT", "LOADING_SURFACE_CM2", "SAMPLE_VOLUME_CM3",
              "LOAD_SURFACE", "CUBIC", "CYLINDER", "AVG_CYLINDER", "LENGTH", "WIDTH", "HEIGHT"}
        Private ColumnQuotation() As String = {"", "", "", "'", "", "", "", "", "", "", "", "", ""}
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
            _conId.Name = "CON_ID"
            _Number.Name = "NUMBER"
            _Date.Name = "_DATE"
            _Age.Name = "AGE"
            _Weight.Name = "WEIGHT"
            _SpecialWeight.Name = "SPECIAL_WEIGHT"
            _LoadingSurfaceCm2.Name = "LOADING_SURFACE_CM2"
            _SampleVolumeCm3.Name = "SAMPLE_VOLUME_CM3"
            _LoadSurface.Name = "LOAD_SURFACE"
            _Cubic.Name = "CUBIC"
            _Cylinder.Name = "CYLINDER"
            _AvgCylinder.Name = "AVG_CYLINDER"
            _width.Name = "WIDTH"
            _length.Name = "LENGTH"
            _height.Name = "HEIGHT"
        End Sub

        Public Sub Reset()
            _Id.Reset()
            _conId.Reset()
            _Number.Reset()
            _Date.Reset()
            _Age.Reset()
            _Weight.Reset()
            _SpecialWeight.Reset()
            _LoadingSurfaceCm2.Reset()
            _SampleVolumeCm3.Reset()
            _LoadSurface.Reset()
            _Cubic.Reset()
            _Cylinder.Reset()
            _AvgCylinder.Reset()
            _width.Reset()
            _length.Reset()
            _height.Reset()
        End Sub
        Public Property Id() As Long
            Get
                Return _Id.Value
            End Get
            Set(ByVal value As Long)
                _Id.Value = value
            End Set
        End Property
        Public Property Con_ID() As Long
            Get
                Return _conId.Value
            End Get
            Set(ByVal value As Long)
                _conId.Value = value
            End Set
        End Property
        Public Property Number() As String
            Get
                Return _Number.Value
            End Get
            Set(ByVal value As String)
                _Number.Value = value
            End Set
        End Property
        Public Property Date_() As String
            Get
                Return _Date.Value
            End Get
            Set(ByVal value As String)
                _Date.Value = value
            End Set
        End Property
        Public Property Age() As Decimal
            Get
                Return _Age.Value
            End Get
            Set(ByVal value As Decimal)
                _Age.Value = value
            End Set
        End Property
        Public Property Weight() As Decimal
            Get
                Return _Weight.Value
            End Get
            Set(ByVal value As Decimal)
                _Weight.Value = value
            End Set
        End Property
        Public Property SpecialWeight() As Decimal
            Get
                Return _SpecialWeight.Value
            End Get
            Set(ByVal value As Decimal)
                _SpecialWeight.Value = value
            End Set
        End Property
        Public Property LoadingSurfaceCm2() As Decimal
            Get
                Return _LoadingSurfaceCm2.Value
            End Get
            Set(ByVal value As Decimal)
                _LoadingSurfaceCm2.Value = value
            End Set
        End Property
        Public Property SampleVolumeCm3() As Decimal
            Get
                Return _SampleVolumeCm3.Value
            End Get
            Set(ByVal value As Decimal)
                _SampleVolumeCm3.Value = value
            End Set
        End Property
        Public Property LoadSurface() As Decimal
            Get
                Return _LoadSurface.Value
            End Get
            Set(ByVal value As Decimal)
                _LoadSurface.Value = value
            End Set
        End Property
        Public Property Cubic() As Decimal
            Get
                Return _Cubic.Value
            End Get
            Set(ByVal value As Decimal)
                _Cubic.Value = value
            End Set
        End Property
        Public Property Cylinder() As Decimal
            Get
                Return _Cylinder.Value
            End Get
            Set(ByVal value As Decimal)
                _Cylinder.Value = value
            End Set
        End Property
        Public Property AvgCylinder() As Decimal
            Get
                Return _AvgCylinder.Value
            End Get
            Set(ByVal value As Decimal)
                _AvgCylinder.Value = value
            End Set
        End Property

        Public Property Width() As Decimal
            Get
                Return _width.Value
            End Get
            Set(ByVal value As Decimal)
                _width.Value = value
            End Set
        End Property
        Public Property Length() As Decimal
            Get
                Return _length.Value
            End Get
            Set(ByVal value As Decimal)
                _length.Value = value
            End Set
        End Property
        Public Property Height() As Decimal
            Get
                Return _height.Value
            End Get
            Set(ByVal value As Decimal)
                _height.Value = value
            End Set
        End Property

#End Region
        Private Function GetNextId(ByVal cnn As SqlClient.SqlConnection) As Long
            Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, cnn) + 1
        End Function
        Public Function Insert(ByVal cnn As SqlClient.SqlConnection) As Long
            Dim str As String = ""
            Dim Values As String = ""
            str = "INSERT INTO " & TableName & "("
            Values = ") VALUES("

            If _conId.isSet Then str &= _conId.Name : Values &= _conId.Value
            If _Number.isSet Then str &= ", " & _Number.Name : Values &= ", '" & _Number.Value & "'"
            If _Date.isSet Then str &= ", " & _Date.Name : Values &= ", '" & _Date.Value & "'"
            If _Age.isSet Then str &= ", " & _Age.Name : Values &= ", " & _Age.Value
            If _Weight.isSet Then str &= ", " & _Weight.Name : Values &= ", " & _Weight.Value
            If _SpecialWeight.isSet Then str &= ", " & _SpecialWeight.Name : Values &= ", " & _SpecialWeight.Value
            If _LoadingSurfaceCm2.isSet Then str &= ", " & _LoadingSurfaceCm2.Name : Values &= ", " & _LoadingSurfaceCm2.Value
            If _SampleVolumeCm3.isSet Then str &= ", " & _SampleVolumeCm3.Name : Values &= ", " & _SampleVolumeCm3.Value
            If _LoadSurface.isSet Then str &= ", " & _LoadSurface.Name : Values &= ", " & _LoadSurface.Value

            If _Cubic.isSet Then str &= ", " & _Cubic.Name : Values &= ", " & _Cubic.Value
            If _Cylinder.isSet Then str &= ", " & _Cylinder.Name : Values &= ", " & _Cylinder.Value
            If _AvgCylinder.isSet Then str &= ", " & _AvgCylinder.Name : Values &= ", " & _AvgCylinder.Value

            If _height.isSet Then str &= ", " & _height.Name : Values &= ", " & _height.Value
            If _length.isSet Then str &= ", " & _length.Name : Values &= ", " & _length.Value
            If _width.isSet Then str &= ", " & _width.Name : Values &= ", " & _width.Value


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


            If _conId.isSet Then str &= _conId.Name & "=" & IIf(_conId.isDBNull, "Null", _conId.Value & "") & ","
            If _Age.isSet Then str &= _Age.Name & "=" & IIf(_Age.isDBNull, "Null", _Age.Value & "") & ","
            If _Weight.isSet Then str &= _Weight.Name & "=" & IIf(_Weight.isDBNull, "Null", _Weight.Value & "") & ","
            If _SpecialWeight.isSet Then str &= _SpecialWeight.Name & "=" & IIf(_SpecialWeight.isDBNull, "Null", _SpecialWeight.Value & "") & ","
            If _LoadingSurfaceCm2.isSet Then str &= _LoadingSurfaceCm2.Name & "=" & IIf(_LoadingSurfaceCm2.isDBNull, "Null", _LoadingSurfaceCm2.Value & "") & ","
            If _SampleVolumeCm3.isSet Then str &= _SampleVolumeCm3.Name & "=" & IIf(_SampleVolumeCm3.isDBNull, "Null", _SampleVolumeCm3.Value & "") & ","
            If _LoadSurface.isSet Then str &= _LoadSurface.Name & "=" & IIf(_LoadSurface.isDBNull, "Null", _LoadSurface.Value & "") & ","
            If _Cubic.isSet Then str &= _Cubic.Name & "=" & IIf(_Cubic.isDBNull, "Null", _Cubic.Value & "") & ","
            If _Cylinder.isSet Then str &= _Cylinder.Name & "=" & IIf(_Cylinder.isDBNull, "Null", _Cylinder.Value & "") & ","
            If _AvgCylinder.isSet Then str &= _AvgCylinder.Name & "=" & IIf(_AvgCylinder.isDBNull, "Null", _AvgCylinder.Value & "") & ","
            If _Date.isSet Then str &= _Date.Name & "=" & IIf(_Date.isDBNull, "Null", "'" & _Date.Value & "'") & ","
            If _Number.isSet Then str &= _Number.Name & "=" & IIf(_Number.isDBNull, "Null", "'" & _Number.Value & "'") & ","
            If _height.isSet Then str &= _height.Name & "=" & IIf(_height.isDBNull, "Null", _height.Value & "") & ","
            If _length.isSet Then str &= _length.Name & "=" & IIf(_length.isDBNull, "Null", _length.Value & "") & ","
            If _width.isSet Then str &= _width.Name & "=" & IIf(_width.isDBNull, "Null", _width.Value & "") & ","
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
End Class
