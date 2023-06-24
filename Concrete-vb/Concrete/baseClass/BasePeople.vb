Public Class BasePeople
    Public TableName As String = "PEOPLE"
    Public Properties As New clsProperties
    'Public Images As New clsImages
#Region "Property"
    Private _Id As DataType.Long
    Private _Type As DataType.Integer
    Private _Code As DataType.String
    Private _FirstName As DataType.String
    Private _LastName As DataType.String
    Private _FatherName As DataType.String
    Private _Gender As DataType.Integer
    Private _Birthday As DataType.String
    Private _CertificateNo As DataType.String
    Private _NationalCode As DataType.String
    Private _BirthPlace As DataType.String
    Private _RegisterDate As DataType.String
    Private _RegisterPlace As DataType.String
    Private _Nationality As DataType.Integer
    Private _ResidenceCity As DataType.Integer
    Private _MaritalDate As DataType.String
    Private _job As DataType.Integer
    Private _Address As DataType.String
    Private _JobAddress As DataType.String
    Private _TelNo As DataType.String
    Private _JobTelNo As DataType.String
    Private _MobileNo As DataType.String
    Private _ZipCode As DataType.String
    Private _EmailAddress As DataType.String
    Private _ACC_CODE As DataType.String
    Private _ParentID As DataType.Integer
    Private _status As DataType.Integer
    Private _RelationType As DataType.Integer
    Private _Employee_Date As DataType.String
    Private _Employee_Type As DataType.Integer
    Private _Insurance_No As DataType.String
    Private _MaritalStatus As DataType.Integer
    Private _MiliarityStatus As DataType.Integer
    Private _AccountNo As DataType.String
    Private _Fuid As DataType.Integer
    Public Enum Columns
        ID = 0
        TYPE = 1
        CODE = 2
        FIRST_NAME = 3
        LAST_NAME = 4
        FATHER_NAME = 5
        GENDER = 6
        BIRTHDAY = 7
        CERTIFICATE_NO = 8
        NATIONAL_CODE = 9
        CIT_ID_BIRTHPLACE = 10
        REGISTER_DATE = 11
        REGISTER_PLACE = 12
        CIT_ID_NATIONALITY = 13
        CIT_ID_RESIDENCE = 14
        MARITAL_DATE = 15
        JOB = 16
        ADDRESS = 17
        JOB_ADDRESS = 18
        TEL_NO = 19
        JOB_TEL_NO = 20
        MOBILE_NO = 21
        ZIP_CODE = 22
        EMAIL_ADDRESS = 23
        ACC_CODE = 24
        PEO_ID = 25
        STATUS = 26
        RelationType = 27
        EmployeeDate = 18
        EmployeeType = 19
        InsuranceNo = 20
        MaritalStatus = 21
        MiliarityStatus = 22
        AccountNo = 23
        FinanceID = 24
    End Enum
    Private ColumnNames() As String = {"ID", "TYPE", "CODE", "FIRST_NAME", "LAST_NAME", "FATHER_NAME", "GENDER", "BIRTHDAY", "CERTIFICATE_NO", "NATIONAL_CODE", "BIRTHPLACE", "REGISTER_DATE", "REGISTER_PLACE", "CIT_ID_NATIONALITY", "CIT_ID_RESIDENCE", "MARITAL_DATE", "JOB", "ADDRESS", "JOB_ADDRESS", "TEL_NO", "JOB_TEL_NO", "MOBILE_NO", "ZIP_CODE", "EMAIL_ADDRESS", "ACC_CODE", "PEO_ID", "STATUS", "RELATION_TYPE", "EMPLOYEMENT_DATE", "EMPLOYMENT_TYPE", "INSURANCE_NO", "MARITAL_STATUS", "MILIARITY_STATUS", "ACCOUNT_NO", "FU_ID"}
    Private ColumnQuotation() As String = {"", "", "'", "'", "'", "'", "GENDER", "'", "'", "'", "'", "'", "'", "CIT_ID_NATIONALITY", "CIT_ID_RESIDENCE", "'", "JOB", "'", "'", "'", "'", "'", "'", "'", "'", "PEO_ID", "STATUS", "", "'", "'", "'", "", "", "'", ""}
    Public Sub New()
        _Id.Name = "ID"
        _Type.Name = "TYPE"
        _Code.Name = "CODE"
        _FirstName.Name = "FIRST_NAME"
        _LastName.Name = "LAST_NAME"
        _FatherName.Name = "FATHER_NAME"
        _Gender.Name = "GENDER"
        _Birthday.Name = "BIRTHDAY"
        _CertificateNo.Name = "CERTIFICATE_NO"
        _NationalCode.Name = "NATIONAL_CODE"
        _BirthPlace.Name = "BIRTHPLACE"
        _RegisterDate.Name = "REGISTER_DATE"
        _RegisterPlace.Name = "REGISTER_PLACE"
        _Nationality.Name = "CIT_ID_NATIONALITY"
        _ResidenceCity.Name = "CIT_ID_RESIDENCE"
        _MaritalDate.Name = "MARITAL_DATE"
        _job.Name = "JOB"
        _Address.Name = "ADDRESS"
        _JobAddress.Name = "JOB_ADDRESS"
        _TelNo.Name = "TEL_NO"
        _JobTelNo.Name = "JOB_TEL_NO"
        _MobileNo.Name = "MOBILE_NO"
        _ZipCode.Name = "ZIP_CODE"
        _EmailAddress.Name = "EMAIL_ADDRESS"
        _ACC_CODE.Name = "ACC_CODE"
        _ParentID.Name = "PEO_ID"
        _status.Name = "STATUS"
        _RelationType.Name = "RELATION_TYPE"
        _Employee_Date.Name = "EMPLOYMENT_DATE"
        _Employee_Type.Name = "EMPLOYMENT_TYPE"
        _Insurance_No.Name = "INSURANCE_NO"
        _MaritalStatus.Name = "MARITAL_STATUS"
        _MiliarityStatus.Name = "MILIARITY_STATUS"
        _AccountNo.Name = "ACCOUNT_NO"
        _Fuid.Name = "FU_ID"
    End Sub
    Public Sub Reset()
        _Id.Reset()
        _Type.Reset()
        _Code.Reset()
        _FirstName.Reset()
        _LastName.Reset()
        _FatherName.Reset()
        _Gender.Reset()
        _Birthday.Reset()
        _CertificateNo.Reset()
        _NationalCode.Reset()
        _BirthPlace.Reset()
        _RegisterDate.Reset()
        _RegisterPlace.Reset()
        _Nationality.Reset()
        _ResidenceCity.Reset()
        _MaritalDate.Reset()
        _job.Reset()
        _Address.Reset()
        _JobAddress.Reset()
        _TelNo.Reset()
        _JobTelNo.Reset()
        _MobileNo.Reset()
        _ZipCode.Reset()
        _EmailAddress.Reset()
        _ACC_CODE.Reset()
        _ParentID.Reset()
        _status.Reset()
        _RelationType.Reset()
        _Employee_Date.Reset()
        _Employee_Type.Reset()
        _Insurance_No.Reset()
        _MaritalStatus.Reset()
        _MiliarityStatus.Reset()
        _AccountNo.Reset()
        _Fuid.Reset()
    End Sub
    ''' <summary>شناسه </summary>
    Public Property Id() As Long
        Get
            Return _Id.Value
        End Get
        Set(ByVal value As Long)
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
    ''' <summary>کد </summary>
    Public Property Code() As String
        Get
            Return _Code.Value
        End Get
        Set(ByVal value As String)
            _Code.Value = value
        End Set
    End Property

    ''' <summary>نام </summary>
    Public Property FirstName() As String
        Get
            Return _FirstName.Value
        End Get
        Set(ByVal value As String)
            _FirstName.Value = value
        End Set
    End Property

    ''' <summary>نام خانوادگي </summary>
    Public Property LastName() As String
        Get
            Return _LastName.Value
        End Get
        Set(ByVal value As String)
            _LastName.Value = value
        End Set
    End Property

    ''' <summary>نام پدر </summary>
    Public Property FatherName() As String
        Get
            Return _FatherName.Value
        End Get
        Set(ByVal value As String)
            _FatherName.Value = value
        End Set
    End Property

    ''' <summary>جنسيت </summary>
    Public Property Gender() As Integer
        Get
            Return _Gender.Value
        End Get
        Set(ByVal value As Integer)
            _Gender.Value = value
        End Set
    End Property

    ''' <summary>تاريخ تولد </summary>
    Public Property Birthday() As String
        Get
            Return _Birthday.Value
        End Get
        Set(ByVal value As String)
            _Birthday.Value = value
        End Set
    End Property

    ''' <summary>شماره شناسنامه </summary>
    Public Property CertificateNo() As String
        Get
            Return _CertificateNo.Value
        End Get
        Set(ByVal value As String)
            _CertificateNo.Value = value
        End Set
    End Property

    ''' <summary>کد ملي </summary>
    Public Property NationalCode() As String
        Get
            Return _NationalCode.Value
        End Get
        Set(ByVal value As String)
            _NationalCode.Value = value
        End Set
    End Property

    ''' <summary>محل تولد </summary>
    Public Property BirthPlace() As String
        Get
            Return _BirthPlace.Value
        End Get
        Set(ByVal value As String)
            _BirthPlace.Value = value
        End Set
    End Property

    ''' <summary>تاريخ ثبت شناسنامه </summary>
    Public Property RegisterDate() As String
        Get
            Return _RegisterDate.Value
        End Get
        Set(ByVal value As String)
            _RegisterDate.Value = value
        End Set
    End Property

    ''' <summary>محل ثبت شناسنامه </summary>
    Public Property RegisterPlace() As String
        Get
            Return _RegisterPlace.Value
        End Get
        Set(ByVal value As String)
            _RegisterPlace.Value = value
        End Set
    End Property

    ''' <summary>مليت </summary>
    Public Property Nationality() As Integer
        Get
            Return _Nationality.Value
        End Get
        Set(ByVal value As Integer)
            _Nationality.Value = value
        End Set
    End Property

    ''' <summary>محل اقامت </summary>
    Public Property ResidenceCity() As Integer
        Get
            Return _ResidenceCity.Value
        End Get
        Set(ByVal value As Integer)
            _ResidenceCity.Value = value
        End Set
    End Property

    ''' <summary>تاريخ ازدواج </summary>
    Public Property MaritalDate() As String
        Get
            Return _MaritalDate.Value
        End Get
        Set(ByVal value As String)
            _MaritalDate.Value = value
        End Set
    End Property

    ''' <summary>شغل </summary>
    Public Property Job() As Integer
        Get
            Return _job.Value
        End Get
        Set(ByVal value As Integer)
            _job.Value = value
        End Set
    End Property

    ''' <summary>آدرس </summary>
    Public Property Address() As String
        Get
            Return _Address.Value
        End Get
        Set(ByVal value As String)
            _Address.Value = value
        End Set
    End Property

    ''' <summary>آدرس محل کار </summary>
    Public Property JobAddress() As String
        Get
            Return _JobAddress.Value
        End Get
        Set(ByVal value As String)
            _JobAddress.Value = value
        End Set
    End Property

    ''' <summary>شماره تلفن </summary>
    Public Property TelNo() As String
        Get
            Return _TelNo.Value
        End Get
        Set(ByVal value As String)
            _TelNo.Value = value
        End Set
    End Property

    ''' <summary>تلفن محل کار </summary>
    Public Property JobTelNo() As String
        Get
            Return _JobTelNo.Value
        End Get
        Set(ByVal value As String)
            _JobTelNo.Value = value
        End Set
    End Property

    ''' <summary>شماره همراه </summary>
    Public Property MobileNo() As String
        Get
            Return _MobileNo.Value
        End Get
        Set(ByVal value As String)
            _MobileNo.Value = value
        End Set
    End Property

    ''' <summary>کد پستي </summary>
    Public Property ZipCode() As String
        Get
            Return _ZipCode.Value
        End Get
        Set(ByVal value As String)
            _ZipCode.Value = value
        End Set
    End Property

    ''' <summary>آدرس پست الکترونيکي </summary>
    Public Property EmailAddress() As String
        Get
            Return _EmailAddress.Value
        End Get
        Set(ByVal value As String)
            _EmailAddress.Value = value
        End Set
    End Property

    ''' <summary>آدرس پست الکترونيکي </summary>
    Public Property ACC_CODE() As String
        Get
            Return _ACC_CODE.Value
        End Get
        Set(ByVal value As String)
            _ACC_CODE.Value = value
        End Set
    End Property

    Public Property ParentId() As Long
        Get
            Return _ParentID.Value
        End Get
        Set(ByVal value As Long)
            _ParentID.Value = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return _status.Value
        End Get
        Set(ByVal value As Integer)
            _status.Value = value
        End Set
    End Property

    Public Property RelationType() As Integer
        Get
            Return _RelationType.Value
        End Get
        Set(ByVal value As Integer)
            _RelationType.Value = value
        End Set
    End Property

    Public Property EmployeeDate() As String
        Get
            Return _Employee_Date.Value
        End Get
        Set(ByVal value As String)
            _Employee_Date.Value = value
        End Set
    End Property

    Public Property EmployeeType() As Integer
        Get
            Return _Employee_Type.Value
        End Get
        Set(ByVal value As Integer)
            _Employee_Type.Value = value
        End Set
    End Property

    Public Property InsuranceNo() As String
        Get
            Return _Insurance_No.Value
        End Get
        Set(ByVal value As String)
            _Insurance_No.Value = value
        End Set
    End Property

    Public Property MaritalStatus() As Integer
        Get
            Return _MaritalStatus.Value
        End Get
        Set(ByVal value As Integer)
            _MaritalStatus.Value = value
        End Set
    End Property

    Public Property MiliarityStatus() As Integer
        Get
            Return _MiliarityStatus.Value
        End Get
        Set(ByVal value As Integer)
            _MiliarityStatus.Value = value
        End Set
    End Property

    Public Property AccountNo() As String
        Get
            Return _AccountNo.Value
        End Get
        Set(ByVal value As String)
            _AccountNo.Value = value
        End Set
    End Property

    Public Property FinanceID() As Integer
        Get
            Return _Fuid.Value
        End Get
        Set(ByVal value As Integer)
            _Fuid.Value = value
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
        'If _Code.isSet Then str &= ", " & _Code.Name : Values &= ", " & _Code.Value
        If _Code.isSet Then str &= ", " & _Code.Name : Values &= ", '" & _Code.Value & "'"
        If _FirstName.isSet Then str &= ", " & _FirstName.Name : Values &= ", '" & _FirstName.Value & "'"
        If _LastName.isSet Then str &= ", " & _LastName.Name : Values &= ", '" & _LastName.Value & "'"
        If _FatherName.isSet Then str &= ", " & _FatherName.Name : Values &= ", '" & _FatherName.Value & "'"
        If _Gender.isSet Then str &= ", " & _Gender.Name : Values &= ", " & _Gender.Value
        If _Birthday.isSet Then str &= ", " & _Birthday.Name : Values &= ", '" & _Birthday.Value & "'"
        If _CertificateNo.isSet Then str &= ", " & _CertificateNo.Name : Values &= ", '" & _CertificateNo.Value & "'"
        If _NationalCode.isSet Then str &= ", " & _NationalCode.Name : Values &= ", '" & _NationalCode.Value & "'"
        If _BirthPlace.isSet Then str &= ", " & _BirthPlace.Name : Values &= ", '" & _BirthPlace.Value & "'"
        If _RegisterDate.isSet Then str &= ", " & _RegisterDate.Name : Values &= ", '" & _RegisterDate.Value & "'"
        If _RegisterPlace.isSet Then str &= ", " & _RegisterPlace.Name : Values &= ", " & _RegisterPlace.Value
        If _Nationality.isSet Then str &= ", " & _Nationality.Name : Values &= ", " & _Nationality.Value
        If _ResidenceCity.isSet Then str &= ", " & _ResidenceCity.Name : Values &= ", " & _ResidenceCity.Value
        If _MaritalDate.isSet Then str &= ", " & _MaritalDate.Name : Values &= ", '" & _MaritalDate.Value & "'"
        If _job.isSet Then str &= ", " & _job.Name : Values &= ", " & _job.Value
        If _Address.isSet Then str &= ", " & _Address.Name : Values &= ", '" & _Address.Value & "'"
        If _JobAddress.isSet Then str &= ", " & _JobAddress.Name : Values &= ", '" & _JobAddress.Value & "'"
        If _TelNo.isSet Then str &= ", " & _TelNo.Name : Values &= ", '" & _TelNo.Value & "'"
        If _JobTelNo.isSet Then str &= ", " & _JobTelNo.Name : Values &= ", '" & _JobTelNo.Value & "'"
        If _MobileNo.isSet Then str &= ", " & _MobileNo.Name : Values &= ", '" & _MobileNo.Value & "'"
        If _ZipCode.isSet Then str &= ", " & _ZipCode.Name : Values &= ", '" & _ZipCode.Value & "'"
        If _EmailAddress.isSet Then str &= ", " & _EmailAddress.Name : Values &= ", '" & _EmailAddress.Value & "'"
        If _ACC_CODE.isSet Then str &= ", " & _ACC_CODE.Name : Values &= ", '" & _ACC_CODE.Value & "'"
        If _ParentID.isSet Then str &= ", " & _ParentID.Name : Values &= ", " & _ParentID.Value
        If _status.isSet Then str &= ", " & _status.Name : Values &= ", " & _status.Value
        If _RelationType.isSet Then str &= ", " & _RelationType.Name : Values &= ", " & _RelationType.Value
        If _Employee_Date.isSet Then str &= ", " & _Employee_Date.Name : Values &= ", '" & _Employee_Date.Value & "'"
        If _Employee_Type.isSet Then str &= ", " & _Employee_Type.Name : Values &= ", " & _Employee_Type.Value
        If _Insurance_No.isSet Then str &= ", " & _Insurance_No.Name : Values &= ", '" & _Insurance_No.Value & "'"
        If _MaritalStatus.isSet Then str &= ", " & _MaritalStatus.Name : Values &= ", " & _MaritalStatus.Value
        If _MiliarityStatus.isSet Then str &= ", " & _MiliarityStatus.Name : Values &= ", " & _MiliarityStatus.Value
        If _AccountNo.isSet Then str &= ", " & _AccountNo.Name : Values &= ", '" & _AccountNo.Value & "'"
        If _Fuid.isSet Then str &= ", " & _Fuid.Name : Values &= ", " & _Fuid.Value

        str &= ", USE_ID_CREATOR" : Values &= ", " & Globals.CurrentUser.Id
        str &= ", CREATE_DATE_TIME" : Values &= ", dbo.getCurrentDateTime()"
        SQL.ExecuteNonQuery(str & Values & ")", cnn)
        Return Id
    End Function

    Public Sub Edit(ByVal Id As Long, ByVal cnn As SqlClient.SqlConnection)
        Dim str As String = "UPDATE " & TableName & " SET "
        If _Id.isSet Then str &= _Id.Name & "=" & _Id.Value & ","
        If _Type.isSet Then str &= _Type.Name & "=" & _Type.Value & ","
        'If _Code.isSet Then str &= _Code.Name & "=" & _Code.Value & ","
        If _Code.isSet Then str &= _Code.Name & "='" & _Code.Value & "',"
        If _FirstName.isSet Then str &= _FirstName.Name & "='" & _FirstName.Value & "',"
        If _LastName.isSet Then str &= _LastName.Name & "='" & _LastName.Value & "',"
        If _FatherName.isSet Then str &= _FatherName.Name & "='" & _FatherName.Value & "',"
        If _Gender.isSet Then str &= _Gender.Name & "=" & _Gender.Value & ","
        If _Birthday.isSet Then str &= _Birthday.Name & "='" & _Birthday.Value & "',"
        If _CertificateNo.isSet Then str &= _CertificateNo.Name & "='" & _CertificateNo.Value & "',"
        If _NationalCode.isSet Then str &= _NationalCode.Name & "='" & _NationalCode.Value & "',"

        If _BirthPlace.isSet Then str &= _BirthPlace.Name & "='" & _BirthPlace.Value & "',"

        If _RegisterDate.isSet Then str &= _RegisterDate.Name & "='" & _RegisterDate.Value & "',"
        If _RegisterPlace.isSet Then str &= _RegisterPlace.Name & "=" & _RegisterPlace.Value & ","
        If _Nationality.isSet Then str &= _Nationality.Name & "=" & _Nationality.Value & ","
        If _ResidenceCity.isSet Then str &= _ResidenceCity.Name & "=" & _ResidenceCity.Value & ","
        If _MaritalDate.isSet Then str &= _MaritalDate.Name & "='" & _MaritalDate.Value & "',"
        If _job.isSet Then str &= _job.Name & "=" & _job.Value & ","
        If _Address.isSet Then str &= _Address.Name & "='" & _Address.Value & "',"
        If _JobAddress.isSet Then str &= _JobAddress.Name & "='" & _JobAddress.Value & "',"
        If _TelNo.isSet Then str &= _TelNo.Name & "='" & _TelNo.Value & "',"
        If _JobTelNo.isSet Then str &= _JobTelNo.Name & "='" & _JobTelNo.Value & "',"
        If _MobileNo.isSet Then str &= _MobileNo.Name & "='" & _MobileNo.Value & "',"
        If _ZipCode.isSet Then str &= _ZipCode.Name & "='" & _ZipCode.Value & "',"
        If _EmailAddress.isSet Then str &= _EmailAddress.Name & "='" & _EmailAddress.Value & "',"
        If _ACC_CODE.isSet Then str &= _ACC_CODE.Name & "='" & _ACC_CODE.Value & "',"
        If _ParentID.isSet Then str &= _ParentID.Name & "=" & _ParentID.Value & ","
        If _status.isSet Then str &= _status.Name & "=" & _status.Value & ","
        If _RelationType.isSet Then str &= _RelationType.Name & "=" & _RelationType.Value & ","
        If _Employee_Date.isSet Then str &= _Employee_Date.Name & "='" & _Employee_Date.Value & "',"
        If _Employee_Type.isSet Then str &= _Employee_Type.Name & "=" & _Employee_Type.Value & ","
        If _Insurance_No.isSet Then str &= _Insurance_No.Name & "='" & _Insurance_No.Value & "',"
        If _MaritalStatus.isSet Then str &= _MaritalStatus.Name & "=" & _MaritalStatus.Value & ","
        If _MiliarityStatus.isSet Then str &= _MiliarityStatus.Name & "=" & _MiliarityStatus.Value & ","
        If _AccountNo.isSet Then str &= _AccountNo.Name & "='" & _AccountNo.Value & "',"
        If _Fuid.isSet Then str &= _Fuid.Name & "=" & IIf(_Fuid.isDBNull, "Null", _Fuid.Value & "") & ","
        If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
        str &= "  WHERE ID=" & Id
        SQL.ExecuteNonQuery(str, cnn)
    End Sub
    Public Sub Delete(ByVal ID As Long, ByVal cnn As SqlClient.SqlConnection)
        SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, cnn)
    End Sub
    ''' <summary>مشخصات افراد </summary>
    Public Class clsProperties
        Public TableName As String = "PEOPLE_PROPERTIES"
#Region "Property"
        Private _Id As DataType.Long
        Private _PeopleId As DataType.Long
        Private _Type As DataType.Integer
        Private _Value As DataType.String
        Private _FromDate As DataType.String
        Private _ToDate As DataType.String
        Private _DiscountId As DataType.Integer
        Private _AccountId As DataType.Integer
        Private _Value2 As DataType.String
        Private _Name As DataType.String
        Public Enum Columns
            Id = 0
            PeopleId = 1
            Type = 2
            Value = 3
            FromDate = 4
            ToDate = 5
            DiscountId = 6
            AccountId = 7
            Value2 = 8
            Name = 9
        End Enum
        Private ColumnNames() As String = {"ID", "PEO_ID", "TYPE", "VALUE", "FROM_DATE", "TO_DATE", "DIS_ID", "ACC_ID", "VALUE2", "NAME"}
        Private ColumnQuotation() As String = {"", "", "", "'", "'", "'", "", "", "'", "'"}
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
            _PeopleId.Name = "PEO_ID"
            _Type.Name = "TYPE"
            _Value.Name = "VALUE"
            _FromDate.Name = "FROM_DATE"
            _ToDate.Name = "TO_DATE"
            _DiscountId.Name = "DIS_ID"
            _AccountId.Name = "ACC_ID"
            _Value2.Name = "VALUE2"
            _Name.Name = "NAME"
        End Sub

        Public Sub Reset()
            _Id.Reset()
            _PeopleId.Reset()
            _Type.Reset()
            _Value.Reset()
            _FromDate.Reset()
            _ToDate.Reset()
            _DiscountId.Reset()
            _AccountId.Reset()
            _Value2.Reset()
            _Name.Reset()
        End Sub

        ''' <summary>شناسه </summary>
        Public Property Id() As Long
            Get
                Return _Id.Value
            End Get
            Set(ByVal value As Long)
                _Id.Value = value
            End Set
        End Property

        ''' <summary>شناسه فرد </summary>
        Public Property PeopleId() As Long
            Get
                Return _PeopleId.Value
            End Get
            Set(ByVal value As Long)
                _PeopleId.Value = value
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

        ''' <summary>مقدار </summary>
        Public Property Value() As String
            Get
                Return _Value.Value
            End Get
            Set(ByVal value As String)
                _Value.Value = value
            End Set
        End Property

        ''' <summary>مقدار </summary>
        Public Property FromDate() As String
            Get
                Return _FromDate.Value
            End Get
            Set(ByVal value As String)
                _FromDate.Value = value
            End Set
        End Property
        ''' <summary>مقدار </summary>
        Public Property ToDate() As String
            Get
                Return _ToDate.Value
            End Get
            Set(ByVal value As String)
                _ToDate.Value = value
            End Set
        End Property

        Public Property DiscountId() As Integer
            Get
                Return _DiscountId.Value
            End Get
            Set(ByVal value As Integer)
                _DiscountId.Value = value
            End Set
        End Property
        ''' <summary> </summary>
        Public Property AccountID() As Integer
            Get
                Return _AccountId.Value
            End Get
            Set(ByVal value As Integer)
                _AccountId.Value = value
            End Set
        End Property
        ''' <summary>2مقدار </summary>
        Public Property Value2() As String
            Get
                Return _Value2.Value
            End Get
            Set(ByVal value As String)
                _Value2.Value = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return _Name.Value
            End Get
            Set(ByVal value As String)
                _Name.Value = value
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
            If _PeopleId.isSet Then str &= ", " & _PeopleId.Name : Values &= ", " & _PeopleId.Value
            If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
            If _Value.isSet Then str &= ", " & _Value.Name : Values &= ", '" & _Value.Value & "'"
            If _FromDate.isSet Then str &= ", " & _FromDate.Name : Values &= ", '" & _FromDate.Value & "'"
            If _ToDate.isSet Then str &= ", " & _ToDate.Name : Values &= ", '" & _ToDate.Value & "'"
            If _DiscountId.isSet Then str &= ", " & _DiscountId.Name : Values &= ", " & _DiscountId.Value
            If _AccountId.isSet Then str &= ", " & _AccountId.Name : Values &= ", " & _AccountId.Value
            If _Value2.isSet Then str &= ", " & _Value2.Name : Values &= ", '" & _Value2.Value & "'"
            If _Name.isSet Then str &= ", " & _Name.Name : Values &= ", '" & _Name.Value & "'"
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
            If _PeopleId.isSet Then str &= _PeopleId.Name & "=" & IIf(_PeopleId.isDBNull, "Null", _PeopleId.Value & "") & ","
            If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
            If _Value.isSet Then str &= _Value.Name & "=" & IIf(_Value.isDBNull, "Null", "'" & _Value.Value & "'") & ","
            If _FromDate.isSet Then str &= _FromDate.Name & "=" & IIf(_FromDate.isDBNull, "Null", "'" & _FromDate.Value & "'") & ","
            If _ToDate.isSet Then str &= _ToDate.Name & "=" & IIf(_ToDate.isDBNull, "Null", "'" & _ToDate.Value & "'") & ","
            If _DiscountId.isSet Then str &= _DiscountId.Name & "=" & IIf(_DiscountId.isDBNull, "Null", _DiscountId.Value & "") & ","
            If _AccountId.isSet Then str &= _AccountId.Name & "=" & IIf(_AccountId.isDBNull, "Null", _AccountId.Value & "") & ","
            If _Value2.isSet Then str &= _Value2.Name & "=" & IIf(_Value2.isDBNull, "Null", "'" & _Value2.Value & "'") & ","
            If _Name.isSet Then str &= _Name.Name & "=" & IIf(_Name.isDBNull, "Null", "'" & _Name.Value & "'") & ","
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


    ''' <summary>تصاویر و ضمائم الکترونیکی </summary>
    '    Public Class clsImages

    '        'Public TableName As String = "PEOPLE_IMAGES"

    '#Region "Property"

    '        Private _Id As DataType.Integer
    '        Private _Type As DataType.Integer
    '        Private _PeopleId As DataType.Long
    '        Private _Content As DataType.Image

    '        Public Enum Columns
    '            Id = 0
    '            Type = 1
    '            PeopleId = 2
    '            Content = 3
    '        End Enum

    '        Private ColumnNames() As String = {"ID", "TYPE", "PEO_ID", "CONTENT"}

    '        Private ColumnQuotation() As String = {"", "", "", ""}

    '        Public Structure stcCondition
    '            Public Oprand As String
    '            Public OpenParenthes As Boolean
    '            Public CloseParenthes As Boolean
    '            Public Name As Columns
    '            Public [Operator] As Enums.Keys.Operators
    '            Public Value As Object
    '            Public Value2 As Object
    '        End Structure

    '        Public Sub New()
    '            _Id.Name = "ID"
    '            _Type.Name = "TYPE"
    '            _PeopleId.Name = "PEO_ID"
    '            _Content.Name = "CONTENT"
    '        End Sub

    '        Public Sub Reset()
    '            _Id.Reset()
    '            _Type.Reset()
    '            _PeopleId.Reset()
    '            _Content.Reset()
    '        End Sub

    '        ''' <summary> </summary>
    '        Public Property Id() As Integer
    '            Get
    '                Return _Id.Value
    '            End Get
    '            Set(ByVal value As Integer)
    '                _Id.Value = value
    '            End Set
    '        End Property

    '        ''' <summary> </summary>
    '        Public Property Type() As Integer
    '            Get
    '                Return _Type.Value
    '            End Get
    '            Set(ByVal value As Integer)
    '                _Type.Value = value
    '            End Set
    '        End Property

    '        ''' <summary> </summary>
    '        Public Property PeopleId() As Long
    '            Get
    '                Return _PeopleId.Value
    '            End Get
    '            Set(ByVal value As Long)
    '                _PeopleId.Value = value
    '            End Set
    '        End Property

    '        ''' <summary> </summary>
    '        Public Property Content() As Byte()
    '            Get
    '                Return _Content.Value
    '            End Get
    '            Set(ByVal value As Byte())
    '                _Content.Value = value
    '            End Set
    '        End Property

    '#End Region

    '        Private Function GetNextId(ByVal cnn As SqlClient.SqlConnection) As Long
    '            Return SQL.ExecuteScalar("SELECT ISNULL(MAX(ID),0) FROM " & TableName, cnn) + 1
    '        End Function

    '        Public Function Insert(ByVal cnn As SqlClient.SqlConnection) As Long
    '            Dim str As String = ""
    '            Dim Values As String = ""
    '            Id = GetNextId(cnn)
    '            str = "INSERT INTO " & TableName & "(ID"
    '            Values = ") VALUES(" & Id
    '            If _Type.isSet Then str &= ", " & _Type.Name : Values &= ", " & _Type.Value
    '            If _PeopleId.isSet Then str &= ", " & _PeopleId.Name : Values &= ", " & _PeopleId.Value
    '            str &= ", USE_ID_CREATOR" : Values &= ", " & Globals.CurrentUser.Id
    '            str &= ", CREATE_DATE_TIME" : Values &= ", dbo.getCurrentDateTime()"
    '            SQL.ExecuteNonQuery(str & Values & ")", cnn)
    '            Return Id
    '        End Function

    '        Public Sub Edit(ByVal Id As Long, ByVal cnn As SqlClient.SqlConnection)
    '            SQL.ExecuteNonQuery(getEditString() & "   WHERE ID=" & Id, cnn)
    '        End Sub

    '        Public Sub Edit(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0)
    '            Dim c As New stcCondition
    '            c.Name = ConditionColumnName
    '            c.OpenParenthes = False
    '            c.CloseParenthes = False
    '            c.Operator = [Operator]
    '            c.Oprand = ""
    '            c.Value = Value
    '            c.Value2 = Value2
    '            SQL.ExecuteNonQuery(getEditString() & getConditionString(c))
    '        End Sub

    '        Public Sub Edit(ByVal ParamArray Condition() As stcCondition)
    '            SQL.ExecuteNonQuery(getEditString() & getConditionString(Condition))
    '        End Sub

    '        Private Function getEditString() As String
    '            Dim str As String = "UPDATE " & TableName & " SET "
    '            If _Id.isSet Then str &= _Id.Name & "=" & IIf(_Id.isDBNull, "Null", _Id.Value & "") & ","
    '            If _Type.isSet Then str &= _Type.Name & "=" & IIf(_Type.isDBNull, "Null", _Type.Value & "") & ","
    '            If _PeopleId.isSet Then str &= _PeopleId.Name & "=" & IIf(_PeopleId.isDBNull, "Null", _PeopleId.Value & "") & ","
    '            If str.EndsWith(",") Then str = str.Substring(0, str.Length - 1)
    '            Return str
    '        End Function

    '        Public Sub Delete(ByVal ID As Long, ByVal cnn As SqlClient.SqlConnection)
    '            SQL.ExecuteNonQuery("DELETE " & TableName & "   WHERE ID=" & ID, cnn)
    '        End Sub

    '        Public Sub Delete(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0)
    '            Dim c As New stcCondition
    '            c.Name = ConditionColumnName
    '            c.OpenParenthes = False
    '            c.CloseParenthes = False
    '            c.Operator = [Operator]
    '            c.Oprand = ""
    '            c.Value = Value
    '            c.Value2 = Value2
    '            SQL.ExecuteNonQuery("DELETE " & TableName & getConditionString(c))
    '        End Sub

    '        Public Sub Delete(ByVal ParamArray Condition() As stcCondition)
    '            SQL.ExecuteNonQuery("DELETE " & TableName & getConditionString(Condition))
    '        End Sub

    '        Public Function getValue(ByVal ColumnName As Columns, ByVal Id As Long) As Object
    '            Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & "   WHERE ID=" & Id)
    '        End Function

    '        Public Function getValue(ByVal ColumnName As Columns, ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As Object
    '            Dim c As New stcCondition
    '            c.Name = ConditionColumnName
    '            c.OpenParenthes = False
    '            c.CloseParenthes = False
    '            c.Operator = [Operator]
    '            c.Oprand = ""
    '            c.Value = Value
    '            c.Value2 = Value2
    '            Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & getConditionString(c))
    '        End Function

    '        Public Function getValue(ByVal ColumnName As Columns, ByVal ParamArray Condition() As stcCondition) As Object
    '            Return SQL.ExecuteScalar("SELECT " & ColumnNames(ColumnName) & " FROM " & TableName & getConditionString(Condition))
    '        End Function

    '        Public Function getRow(ByVal Id As Long) As DataRow
    '            Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & "   WHERE ID=" & Id)
    '        End Function

    '        Public Function getRow(ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As DataRow
    '            Dim c As New stcCondition
    '            c.Name = ConditionColumnName
    '            c.OpenParenthes = False
    '            c.CloseParenthes = False
    '            c.Operator = [Operator]
    '            c.Oprand = ""
    '            c.Value = Value
    '            c.Value2 = Value2
    '            Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & getConditionString(c))
    '        End Function

    '        Public Function getRow(ByVal ParamArray Condition() As stcCondition) As DataRow
    '            Return SQL.ExecuteDataRow("SELECT * FROM " & TableName & getConditionString(Condition))
    '        End Function

    '        Public Function [Select](ByVal ConditionColumnName As Columns, ByVal [Operator] As Enums.Keys.Operators, ByVal Value As Object, Optional ByVal Value2 As Object = 0) As DataTable
    '            Dim c As New stcCondition
    '            c.Name = ConditionColumnName
    '            c.OpenParenthes = False
    '            c.CloseParenthes = False
    '            c.Operator = [Operator]
    '            c.Oprand = ""
    '            c.Value = Value
    '            c.Value2 = Value2
    '            Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & getConditionString(c))
    '        End Function

    '        Public Function [Select](ByVal ParamArray Condition() As stcCondition) As DataTable
    '            Return SQL.ExecuteDataTable("SELECT * FROM " & TableName & getConditionString(Condition))
    '        End Function
    '        Private Function getConditionString(ByVal ParamArray Condition() As stcCondition) As String
    '            Dim str As String = ""
    '            For Each c As stcCondition In Condition
    '                Dim vOperator As String = SQL.ExecuteScalar("SELECT TITLE FROM DOMAINS   WHERE ID=" & c.Operator)
    '                str &= c.Oprand & IIf(c.OpenParenthes, "(", "") &
    '                ColumnNames(c.Name) & " " & vOperator &
    '                IIf(vOperator.Contains("NULL"), "", ColumnQuotation(c.Name) & c.Value & ColumnQuotation(c.Name) & IIf(c.Operator = Enums.Keys.Operators.Between, " AND " & ColumnQuotation(c.Name) & c.Value2 & ColumnQuotation(c.Name), "")) &
    '                IIf(c.CloseParenthes, ")", "")
    '            Next
    '            If str <> "" Then str = "   WHERE " & str
    '            Return str
    '        End Function

    '    End Class

End Class
