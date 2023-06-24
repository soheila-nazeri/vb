Public Class clsCommon
    Public Sub AddStringToDatatable(ByRef dt As DataTable, ByVal strColumns As String)
        Dim _Array() As String = strColumns.Split(",")
        For i As Integer = 0 To _Array.Length - 1
            dt.Columns.Add(_Array(i))
        Next
    End Sub
    Public Function GetStringColumnsValue(ByVal dt As DataTable, ByVal Columns As String) As String
        Dim StrColumnValue As String = ""
        For Each dr As DataRow In dt.Rows
            If dr.Item(Columns).ToString() <> "" Then StrColumnValue &= dr.Item(Columns).ToString() + ","
        Next
        Return StrColumnValue.Remove(StrColumnValue.Length - 1, 1)
    End Function
    Public Shared Function getNumberName(ByVal Num As String)
        Dim vIsNegative As Boolean = False
        If Num = "0" Then Return "صفر"
        Dim Value As String = Num.Replace(",", "")
        If Val(Value) < 0 Then
            Value = Value.Replace("-", "")
            vIsNegative = True
        End If
        Dim i As Integer
        Dim str As String
        Dim s As String = ""
        Dim vReturn As String = ""
        If Value.Length > 3 Then
            While i <= Value.Length \ 3
                s = "," & Microsoft.VisualBasic.Mid(Value, Value.Length + 1 - i * 3, 3) & s
                i += 1
            End While
            If Value.Length > (i - 1) * 3 Then s = Microsoft.VisualBasic.Left(Value, Value.Length - (i - 1) * 3) & s
            If Microsoft.VisualBasic.Right(s, 1) = "," Then s = Microsoft.VisualBasic.Left(s, s.Length - 1)
        Else
            s = Value
        End If
        Dim vArray As Array = s.Split(",")
        For i = 0 To vArray.Length - 1
            s = Val(vArray(i)).ToString
            str = ""
            While s <> ""
                If Val(s) < 20 Then
                    str = str & IIf(str = "", "", " و ") & getDigitName(s)
                    s = ""
                Else
                    str = str & IIf(str = "", "", " و ") & getDigitName(s.Substring(0, 1) * 10 ^ (s.Length - 1))
                    s = s.Substring(1)
                End If
            End While
            If str.EndsWith(" و ") Then str = str.Substring(0, str.Length - 3)
            If i = vArray.Length - 1 Then
                vReturn = vReturn & str
            Else
                vReturn = vReturn & str & " " & IIf(str = "", "", getDigitName(10 ^ ((vArray.Length - 1 - i) * 3)) & " و ")
            End If
        Next
        If vReturn.Trim.EndsWith("و") Then vReturn = vReturn.Trim.Substring(0, vReturn.Trim.Length - 1)
        If vIsNegative = True Then
            vReturn = vReturn + "-"
        End If
        Return vReturn
    End Function
    Private Shared Function getDigitName(ByVal Num As Integer)
        Select Case Num
            Case 1
                Return "يک"
            Case 2
                Return "دو"
            Case 3
                Return "سه"
            Case 4
                Return "چهار"
            Case 5
                Return "پنج"
            Case 6
                Return "شش"
            Case 7
                Return "هفت"
            Case 8
                Return "هشت"
            Case 9
                Return "نه"
            Case 10
                Return "ده"
            Case 11
                Return "يازده"
            Case 12
                Return "دوازده"
            Case 13
                Return "سيزده"
            Case 14
                Return "چهارده"
            Case 15
                Return "پانزده"
            Case 16
                Return "شانزده"
            Case 17
                Return "هفده"
            Case 18
                Return "هجده"
            Case 19
                Return "نوزده"
            Case 20
                Return "بيست"
            Case 30
                Return "سي"
            Case 40
                Return "چهل"
            Case 50
                Return "پنجاه"
            Case 60
                Return "شصت"
            Case 70
                Return "هفتاد"
            Case 80
                Return "هشتاد"
            Case 90
                Return "نود"
            Case 100
                Return "صد"
            Case 200
                Return "دويست"
            Case 300
                Return "سيصد"
            Case 400
                Return "چهارصد"
            Case 500
                Return "پانصد"
            Case 600
                Return "ششصد"
            Case 700
                Return "هفتصد"
            Case 800
                Return "هشتصد"
            Case 900
                Return "نهصد"
            Case 1000
                Return "هزار"
            Case 1000000
                Return "ميليون"
            Case 1000000000
                Return "ميليارد"
            Case Else
                Return ""
        End Select
    End Function
    Public Function GetDateToDigit(ByVal s As String)
        Dim t As String = ""
        If (s.Length = 0) Then Return ("")
        If (s.Length = 1) Then s = "0" + s
        Dim Day As String = f2(Strings.Mid(s, 9, 2))
        Dim Month As String = M(Strings.Mid(s, 6, 2))
        Dim Year As String = ""
        If Strings.Mid(s, 1, 4) = "1400" Then
            Year = " هزار و چهارصد  "
        ElseIf Strings.Mid(s, 1, 2) = "14" Then
            Year = " هزار و چهارصد و " & f2(Strings.Mid(s, 3, 2))
        Else
                Year = " هزار و سیصد و " & f2(Strings.Mid(s, 3, 2))
        End If

        Return Day + Space(1) + Month + Space(1) + Year
    End Function
    Public Function M(ByVal s As String) As String
        Select Case s
            Case "01" : Return "فروردين"
            Case "02" : Return "ارديبهشت"
            Case "03" : Return "خرداد"
            Case "04" : Return "تير"
            Case "05" : Return "مرداد"
            Case "06" : Return "شهريور"
            Case "07" : Return "مهر"
            Case "08" : Return "آبان"
            Case "09" : Return "آذر"
            Case "10" : Return "دي"
            Case "11" : Return "بهمن"
            Case "12" : Return "اسفند"
        End Select
        Return ("Err")
    End Function
    Public Function f2(ByVal s As String) As String
        Dim t As String = ""
        If (s.Length = 0) Then Return ("")
        If (s.Length = 1) Then s = "0" + s
        Select Case s
            Case "00" : t = ""
            Case "01" : t = "يك"
            Case "02" : t = "دو"
            Case "03" : t = "سه"
            Case "04" : t = "چهار"
            Case "05" : t = "پنج"
            Case "06" : t = "شش"
            Case "07" : t = "هفت"
            Case "08" : t = "هشت"
            Case "09" : t = "نه"
            Case "10" : t = "ده"
            Case "11" : t = "يازده"
            Case "12" : t = "دوازده"
            Case "13" : t = "سيزده"
            Case "14" : t = "چهارده"
            Case "15" : t = "پانزده"
            Case "16" : t = "شانزده"
            Case "17" : t = "هفده"
            Case "18" : t = "هجده"
            Case "19" : t = "نوزده"
            Case "20" : t = "بيست"
            Case "21" : t = "بيست و يك"
            Case "22" : t = "بيست و دو"
            Case "23" : t = "بيست و سه"
            Case "24" : t = "بيست و چهار"
            Case "25" : t = "بيست و پنج"
            Case "26" : t = "بيست و شش"
            Case "27" : t = "بيست و هفت"
            Case "28" : t = "بيست و هشت"
            Case "29" : t = "بيست و نه"
            Case "30" : t = "سي"
            Case "31" : t = "سي و يك"
            Case "32" : t = "سي و دو"
            Case "33" : t = "سي و سه"
            Case "34" : t = "سي و چهار"
            Case "35" : t = "سي و پنج"
            Case "36" : t = "سي و شش"
            Case "37" : t = "سي و هفت"
            Case "38" : t = "سي و هشت"
            Case "39" : t = "سي و نه"
            Case "40" : t = "چهل"
            Case "41" : t = "چهل و يك"
            Case "42" : t = "چهل و دو"
            Case "43" : t = "چهل و سه"
            Case "44" : t = "چهل و چهار"
            Case "45" : t = "چهل و پنج"
            Case "46" : t = "چهل و شش"
            Case "47" : t = "چهل و هفت"
            Case "48" : t = "چهل و هشت"
            Case "49" : t = "چهل و نه"
            Case "50" : t = "پنجاه"
            Case "51" : t = "پنجاه و يك"
            Case "52" : t = "پنجاه و دو"
            Case "53" : t = "پنجاه و سه"
            Case "54" : t = "پنجاه و چهار"
            Case "55" : t = "پنجاه و پنج"
            Case "56" : t = "پنجاه و شش"
            Case "57" : t = "پنجاه و هفت"
            Case "58" : t = "پنجاه و هشت"
            Case "59" : t = "پنجاه و نه"
            Case "60" : t = "شصت"
            Case "61" : t = "شصت و يك"
            Case "62" : t = "شصت و دو"
            Case "63" : t = "شصت و سه"
            Case "64" : t = "شصت و چهار"
            Case "65" : t = "شصت و پنج"
            Case "66" : t = "شصت و شش"
            Case "67" : t = "شصت و هفت"
            Case "68" : t = "شصت و هشت"
            Case "69" : t = "شصت و نه"
            Case "70" : t = "هفتاد"
            Case "71" : t = "هفتاد و يك"
            Case "72" : t = "هفتاد و دو"
            Case "73" : t = "هفتاد و سه"
            Case "74" : t = "هفتاد و چهار"
            Case "75" : t = "هفتاد و پنج"
            Case "76" : t = "هفتاد و شش"
            Case "77" : t = "هفتاد و هفت"
            Case "78" : t = "هفتاد و هشت"
            Case "79" : t = "هفتاد و نه"
            Case "80" : t = "هشتاد"
            Case "81" : t = "هشتاد و يك"
            Case "82" : t = "هشتاد و دو"
            Case "83" : t = "هشتاد و سه"
            Case "84" : t = "هشتاد و چهار"
            Case "85" : t = "هشتاد و پنج"
            Case "86" : t = "هشتاد و شش"
            Case "87" : t = "هشتاد و هفت"
            Case "88" : t = "هشتاد و هشت"
            Case "89" : t = "هشتاد و نه"
            Case "90" : t = "نود"
            Case "91" : t = "نود و يك"
            Case "92" : t = "نود و دو"
            Case "93" : t = "نود و سه"
            Case "94" : t = "نود و چهار"
            Case "95" : t = "نود و پنج"
            Case "96" : t = "نود و شش"
            Case "97" : t = "نود و هفت"
            Case "98" : t = "نود و هشت"
            Case "99" : t = "نود و نه"
        End Select
        Return t
    End Function
    Public Function GetCONCRETEName() As String
        Dim strSQl As String = "SELECT ISNULL(VALUE,'') AS VALUE FROM CONFIGURATIONS WHERE CODE ='1'"
        Return mnDataLayer.SQL.ExecuteScalar(strSQl, Nothing)
    End Function
End Class
