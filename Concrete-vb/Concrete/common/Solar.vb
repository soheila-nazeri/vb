Public Class Solar

   Public Enum WeekDays
      Saturday = 1
      Sunday = 2
      Monday = 4
      Tuesday = 8
      Wednesday = 16
      Thursday = 32
      Friday = 64
   End Enum

   Public Shared Function GetTime(Optional ByVal Formated As Boolean = False) As String
      Dim vTime As String
        vTime = SQL.getServerTime()
        If Formated = False Then
            Return vTime.Replace(":", "")
        Else
            Return vTime
        End If
    End Function

   Public Shared Function GetDate(Optional ByVal Formated As Boolean = False) As String
      Dim vDate As String
        vDate = SQL.getDate()
        If Formated = False Then
            Return vDate.Replace("/", "")
        Else
            Return vDate
        End If
    End Function

   Public Shared Function GetDateTime(Optional ByVal Formated As Boolean = False) As String
      If Formated = False Then
         Return GetDate(Formated) & GetTime(Formated)
      Else
         Return GetDate(Formated) & "_" & GetTime(Formated)
      End If
   End Function

    'Public Shared Sub setSystemDateTime()
    '   TimeString = GetTime(True)
    '   Dim vDate As Date = SQL.getServerDate()
    '   DateString = vDate.Month & "-" & vDate.Day & "-" & vDate.Year
    'End Sub

    Public Shared Function FormatDateTime(ByVal DateTime As String) As String
        Dim vDate As String = DateTime.Replace("/", "").Replace("_", "").Replace("-", "").Replace(":", "")
        If DateTime = "" Then
            Return ""
        ElseIf DateTime.Length = 8 Then
            Return DateTime.Substring(0, 4) & "/" & DateTime.Substring(4, 2) & "/" & DateTime.Substring(6, 2)
        ElseIf DateTime.Length = 14 Then
            Return DateTime.Substring(0, 4) & "/" & DateTime.Substring(4, 2) & "/" & DateTime.Substring(6, 2) & "_" & DateTime.Substring(8, 2) & ":" & DateTime.Substring(10, 2) & ":" & DateTime.Substring(12, 2)
        Else
            Return ""
        End If
    End Function

    Public Shared Function FormatTime(ByVal Time As String) As String
        Dim vDate As String = Time.Replace(":", "")
        If Time = "" Then
            Return ""
        ElseIf Time.Length = 6 Then
            Return Time.Substring(0, 2) & ":" & Time.Substring(2, 2) & ":" & Time.Substring(4, 2)
        Else
            Return ""
        End If
    End Function

    Public Shared Function AddDay(ByVal SolarDate As String, ByVal Addition As Integer) As String
        Dim vFormat As Boolean = False
        If SolarDate.IndexOf("/") > 0 Then vFormat = True
        Dim vNewDate As String = ""
        If Strings.Left(SolarDate, 4) <= "1500" Then
            vNewDate = SQL.ExecuteScalar("SELECT dbo.MiladiToShamsi(DATEADD(DAY, " & Addition & ",dbo.getStrShamsitoMiladi('" & SolarDate & "') ))")
            'Dim vDate As String = getGregorianDate(SolarDate.Substring(0, 10)).Replace("/", "").Replace("-", "").PadLeft(8, "0")
            'Dim vGdate As String = DateSerial(vDate.Substring(0, 4), vDate.Substring(4, 2), vDate.Substring(6, 2)).AddDays(Addition).ToString("yyyy/MM/dd")
            'If Strings.Left(vDate, 4) <= "1500" Then
            '    vNewDate = vGdate
            'Else
            '    vNewDate = getSolarDate(vGdate)
            'End If
        Else
            'Dim vd As Date = Convert.ToDateTime(SolarDate).AddDays(Addition)
            'vNewDate = vd.Year & "/" & vd.Month.ToString.PadLeft(2, "0") & "/" & vd.Day.ToString.PadLeft(2, "0")
            vNewDate = SQL.ExecuteScalar("SELECT  REPLACE(CONVERT(VARCHAR(10),DATEADD(DAY, " & Addition & ",'" & SolarDate & "' ), 102) ,'.','/')")
        End If

        If vFormat = True Then
            Return vNewDate
        Else
            Return vNewDate.Replace("/", "")
        End If
    End Function

    Public Shared Function AddMonth(ByVal SolarDate As String, ByVal Addition As Integer) As String
        Dim vFormat As Boolean = False
        If SolarDate.IndexOf("/") > 0 Then vFormat = True
        Dim vNewDate As String = ""
        If Left(SolarDate, 4) <= "1500" Then
            Dim vDate As String = getGregorianDate(SolarDate.Substring(0, 10)).Replace("/", "").Replace("-", "").PadLeft(8, "0")
            Dim vGdate As String = DateSerial(vDate.Substring(0, 4), vDate.Substring(4, 2), vDate.Substring(6, 2)).AddMonths(Addition).ToString("yyyy/MM/dd")
            If Strings.Left(vDate, 4) <= "1500" Then
                vNewDate = vGdate
            Else
                vNewDate = getSolarDate(vGdate)
            End If
        Else
            Dim vd As Date = Convert.ToDateTime(SolarDate).AddMonths(Addition)
            vNewDate = vd.Year & "/" & vd.Month.ToString.PadLeft(2, "0") & "/" & vd.Day.ToString.PadLeft(2, "0")
        End If
        If vFormat = True Then
            Return FormatDate(vNewDate)
        Else
            Return vNewDate.Replace("/", "")
        End If
    End Function

    Public Shared Function getSolarDate(ByVal D As String) As String
        If Left(D, 4) <= "1500" Then Return D

        If Globals.IsLangugePersian Then
            Return SQL.ExecuteScalar("SELECT dbo.MiladiToShamsi('" & D & "')")
        Else
            Return D
        End If
    End Function

    Public Shared Function getGregorianDate(ByVal SolarDate As String) As String
        If Len(SolarDate) < 4 Then Return ""
        If Left(SolarDate, 4) > "1500" Then Return SolarDate
        Return SQL.ExecuteScalar("SELECT dbo.getStrShamsitoMiladi('" & SolarDate & "')")
    End Function



    Public Shared Function DateDiff(ByVal Date1 As String, ByVal Date2 As String) As Integer
        If Left(Date1, 4) <= "1500" Then

            'Date1 = getGregorianDate(Date1).Replace("/", "").Replace("-", "").PadLeft(8, "0")
            'Date2 = getGregorianDate(Date2).Replace("/", "").Replace("-", "").PadLeft(8, "0")

            'Return Microsoft.VisualBasic.DateDiff(DateInterval.Day, DateSerial(Date1.Substring(0, 4), Date1.Substring(4, 2), Date1.Substring(6, 2)), _
            '                             DateSerial(Date2.Substring(0, 4), Date2.Substring(4, 2), Date2.Substring(6, 2)))

            Return SQL.ExecuteScalar("SELECT DATEDIFF(DAY, dbo.getStrShamsitoMiladi('" & Date1 & "') ,dbo.getStrShamsitoMiladi('" & Date2 & "')) ")
        Else
            'Date1 = Date1.Replace("/", "").Replace("-", "").PadLeft(8, "0")
            'Date2 = Date2.Replace("/", "").Replace("-", "").PadLeft(8, "0")
            'Return Microsoft.VisualBasic.DateDiff(DateInterval.Day, DateSerial(Date1.Substring(0, 4), Date1.Substring(4, 2), Date1.Substring(6, 2)), DateSerial(Date2.Substring(0, 4), Date2.Substring(4, 2), Date2.Substring(6, 2)))
            Return SQL.ExecuteScalar("SELECT DATEDIFF(DAY,'" & Date1 & "' , '" & Date2 & "' ) ")

        End If
    End Function

    Public Shared Function AddTime(ByVal Time As String, ByVal Addition As String) As String
        'DateFormat HH:MM:SS
        Dim TimeArray As Array = Time.Split(":")
        Dim AdditionArray As Array = Addition.Split(":")
        TimeArray(2) = Val(TimeArray(2)) + Val(AdditionArray(2))
        If Val(TimeArray(2)) >= 60 Then
            TimeArray(2) = TimeArray(2) - 60
            TimeArray(1) = Val(TimeArray(1)) + 1
        End If
        TimeArray(1) = Val(TimeArray(1)) + Val(AdditionArray(1))
        If Val(TimeArray(1)) >= 60 Then
            TimeArray(1) = TimeArray(1) - 60
            TimeArray(1) = Val(TimeArray(1)) + 1
        End If
        TimeArray(0) = Val(TimeArray(0)) + Val(AdditionArray(0))
        If Val(TimeArray(0)) > 24 Then
            TimeArray(0) = 0
        End If
        Return Right("00" & TimeArray(0), 2) & ":" & Right("00" & TimeArray(1), 2) & ":" & Right("00" & TimeArray(2), 2)
    End Function

    Public Shared Function TimeDiff(ByVal DateTime1 As String, ByVal DateTime2 As String) As String
        Dim h, m, s As Integer
        Dim DateDiff As Integer = 0
        Dim Time1 As String = Microsoft.VisualBasic.Right(("000000" & DateTime1.Replace("/", "").Replace(":", "").Replace("-", "").Replace("_", "")), 6)
        Dim Time2 As String = Microsoft.VisualBasic.Right(("000000" & DateTime2.Replace("/", "").Replace(":", "").Replace("-", "").Replace("_", "")), 6)
        Dim Date1 As String = ""
        Dim Date2 As String = ""
        If DateTime1.Replace("/", "").Replace(":", "").Replace("-", "").Replace("_", "").Length = 14 Then Date1 = DateTime1.Substring(0, 10)
        If DateTime2.Replace("/", "").Replace(":", "").Replace("-", "").Replace("_", "").Length = 14 Then Date2 = DateTime2.Substring(0, 10)
        If Date1 <> "" And Date2 <> "" And Date1 <> Date2 Then DateDiff = Solar.DateDiff(Date1, Date2)
        h = Val(Time2.Substring(0, 2)) - Val(Time1.Substring(0, 2))
        m = Val(Time2.Substring(2, 2)) - Val(Time1.Substring(2, 2))
        s = Val(Time2.Substring(4, 2)) - Val(Time1.Substring(4, 2))
        If s < 0 Then : s += 60 : m -= 1 : End If
        If m < 0 Then : m += 60 : h -= 1 : End If
        If DateDiff > 0 Then h = h + 24 * DateDiff
        Return (h & ":" & m.ToString.PadLeft(2, "0") & ":" & s.ToString.PadLeft(2, "0")).PadLeft(8, "0")
    End Function

    Public Shared Function FormatDate(ByVal inDate As String, Optional ByVal Reverse As Boolean = False) As String
        inDate = inDate.Replace("/", "").Replace(":", "").Replace("-", "")
        If inDate.Length = 8 Then
            If Reverse = True Then
                Return inDate.Substring(6, 2) & "/" & inDate.Substring(4, 2) & "/" & inDate.Substring(0, 4)
            Else
                Return inDate.Substring(0, 4) & "/" & inDate.Substring(4, 2) & "/" & inDate.Substring(6, 2)
            End If
        ElseIf inDate.Length = 14 Then
            If Reverse = True Then
                Return inDate.Substring(8, 2) & ":" & inDate.Substring(10, 2) & ":" & inDate.Substring(12, 2) & "-" & inDate.Substring(6, 2) & "/" & inDate.Substring(4, 2) & "/" & inDate.Substring(0, 4)
            Else
                Return inDate.Substring(0, 4) & "/" & inDate.Substring(4, 2) & "/" & inDate.Substring(6, 2) & "-" & inDate.Substring(8, 2) & ":" & inDate.Substring(10, 2) & ":" & inDate.Substring(12, 2)
            End If
        Else
            Return ""
        End If
    End Function

    Public Shared Function GetDayName(ByVal SolarDate As String) As String
        Dim dv As String = getGregorianDate(SolarDate).Replace("/", "").Replace("-", "").PadLeft(8, "0")
        Dim d As Date = DateSerial(dv.Substring(0, 4), dv.Substring(4, 2), dv.Substring(6, 2))
        'تاریخ برای زبان غیر ایرانی، میلادی در نظر گرفته شده است
        If Globals.IsLangugePersian Then

            Select Case d.DayOfWeek
                Case DayOfWeek.Saturday
                    Return "شنبه"
                Case DayOfWeek.Sunday
                    Return "یکشنبه"
                Case DayOfWeek.Monday
                    Return "دوشنبه"
                Case DayOfWeek.Tuesday
                    Return "سه شنبه"
                Case DayOfWeek.Wednesday
                    Return "چهارشنبه"
                Case DayOfWeek.Thursday
                    Return "پنجشنبه"
                Case DayOfWeek.Friday
                    Return "جمعه"
                Case Else
                    Return ""
            End Select
        Else
            Select Case d.DayOfWeek
                Case DayOfWeek.Saturday
                    Return DayOfWeek.Saturday
                Case DayOfWeek.Sunday
                    Return DayOfWeek.Sunday
                Case DayOfWeek.Monday
                    Return DayOfWeek.Monday
                Case DayOfWeek.Tuesday
                    Return DayOfWeek.Tuesday
                Case DayOfWeek.Wednesday
                    Return DayOfWeek.Wednesday
                Case DayOfWeek.Thursday
                    Return DayOfWeek.Thursday
                Case DayOfWeek.Friday
                    Return DayOfWeek.Friday
                Case Else
                    Return ""
            End Select
        End If
    End Function

    Public Shared Function getDayOfWeek(ByVal SolarDate As String) As WeekDays
        Dim dv As String = getGregorianDate(SolarDate).Replace("/", "").Replace("-", "").PadLeft(8, "0")
        Dim d As Date = DateSerial(dv.Substring(0, 4), dv.Substring(4, 2), dv.Substring(6, 2))

        Select Case d.DayOfWeek
            Case DayOfWeek.Saturday
                Return WeekDays.Saturday
            Case DayOfWeek.Sunday
                Return WeekDays.Sunday
            Case DayOfWeek.Monday
                Return WeekDays.Monday
            Case DayOfWeek.Tuesday
                Return WeekDays.Tuesday
            Case DayOfWeek.Wednesday
                Return WeekDays.Wednesday
            Case DayOfWeek.Thursday
                Return WeekDays.Thursday
            Case DayOfWeek.Friday
                Return WeekDays.Friday
            Case Else
                Return ""
        End Select
    End Function

    Private Shared Function GetDayName_(ByVal d As Integer) As String
        Select Case d
            Case 0
                Return "شنبه"
            Case 1
                Return "يکشنبه"
            Case 2
                Return "دوشنبه"
            Case 3
                Return "سه شنبه"
            Case 4
                Return "چهارشنبه"
            Case 5
                Return "پنجشنبه"
            Case 6
                Return "جمعه"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function GetMonthName(ByVal SolarDate As String) As String
        Return GetMonthName_(SolarDate.Replace(",", "").Replace("/", "").Replace("-", "").Substring(4, 2))
    End Function

    Private Shared Function GetMonthName_(ByVal m As Integer) As String
        Select Case m
            Case 1
                Return "فروردین"
            Case 2
                Return "اردیبهشت"
            Case 3
                Return "خرداد"
            Case 4
                Return "تیر"
            Case 5
                Return "مرداد"
            Case 6
                Return "شهریور"
            Case 7
                Return "مهر"
            Case 8
                Return "آبان"
            Case 9
                Return "آذر"
            Case 10
                Return "دی"
            Case 11
                Return "بهمن"
            Case 12
                Return "اسفند"
            Case Else
                Return ""
        End Select
    End Function

    Private Shared Function FullDateName(ByVal SolarDate As String) As String
        Return GetDayName(SolarDate) & " " &
             SolarDate.Replace(",", "").Substring(6) & " " &
             GetMonthName_(SolarDate.Replace(",", "").Substring(4, 2)) & " " &
             SolarDate.Replace(",", "").Substring(0, 4)
    End Function

    Public Shared Function SlashDate(ByVal vDate As String) As String
        Dim deSlashDate As String
        deSlashDate = vDate.Replace("/", "")
        If deSlashDate.Length = 8 Then
            SlashDate = Mid(deSlashDate, 1, 4) & "/" & Mid(deSlashDate, 5, 2) & "/" & Mid(deSlashDate, 7, 2)
        Else
            SlashDate = ""
        End If
    End Function

    Public Shared Function SlashReverseDate(ByVal vDate As String) As String
        Dim deSlashDate As String
        deSlashDate = vDate.Replace("/", "")
        If deSlashDate.Length = 8 Then
            Return Mid(deSlashDate, 7, 2) & "/" & Mid(deSlashDate, 5, 2) & "/" & Mid(deSlashDate, 1, 4)
        Else
            Return ""
        End If
    End Function

    Public Shared Function DeSlashDate(ByVal vDate As String) As String
        DeSlashDate = vDate.Replace("/", "")
    End Function

    Public Shared Sub setCalendar(ByVal FromDate As String, ByVal ToDate As String)
        If FromDate = "" Then Return
        Dim dt As DataTable = SQL.ExecuteDataTable("SELECT * FROM CALENDAR WHERE DATE BETWEEN '" & FromDate & "' AND '" & ToDate & "' ORDER BY DATE")
        If dt.Rows.Count <> DateDiff(FromDate, ToDate) + 1 Then
            Dim vDate As String = FromDate, vNextDate As String, vPreviouseDate As String = Solar.AddDay(FromDate, -1)
            While vDate <= ToDate
                dt.DefaultView.RowFilter = "DATE='" & vDate & "'"
                vNextDate = AddDay(vDate, 1)
                If dt.DefaultView.Count = 0 Then SQL.ExecuteNonQuery("INSERT INTO CALENDAR(DATE, PREVIOUSE_DATE, NEXT_DATE) VALUES('" & vDate & "','" & vPreviouseDate & "','" & vNextDate & "')")
                vPreviouseDate = vDate
            vDate = vNextDate
         End While
      End If
   End Sub

End Class

