Public Class Enums
    Public Class Keys
        Public Enum Gender
            ''' <summary>مرد</summary>
            Male = 1
            ''' <summary>زن</summary>
            Female = 2
        End Enum
        Public Enum Operators
            ''' <summary>=</summary>
            Equal = 1741
            ''' <summary><></summary>
            NotEqual = 1742
            ''' <summary>></summary>
            Great = 1743
            ''' <summary><</summary>
            Less = 1744
            ''' <summary>>=</summary>
            GreatEqual = 1745
            ''' <summary><=</summary>
            LessEqual = 1746
            ''' <summary> IN</summary>
            [In] = 1747
            ''' <summary> NOT IN</summary>
            NotIn = 1748
            ''' <summary>LIKE</summary>
            [Like] = 1749
            ''' <summary>BETWEEN</summary>
            Between = 1750
            ''' <summary>IS NULL</summary>
            IsNull = 1751
            ''' <summary>IS NOT NULL</summary>
            IsNotNull = 1752
        End Enum
        Public Enum PeopleType
            Personel = 2
            REQUESTER = 3
            EMPLOYER = 4
        End Enum
    End Class
    Public Enum FormActionType
        add = 1
        SingleSelection = 2
        View = 3
    End Enum
    Public Enum DomainKeys
        Gender = 1
    End Enum

End Class