Public Class Utility

  Private Const KLF_ACTIVATE As Short = &H1S
  Public Enum enmLanguage
    Farsi
    English
  End Enum
  Private Const LANG_FA_IR As String = "00000429" 'FA_IR
  Private Const LANG_EN_US As String = "00000409" 'EN_US
  Private Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Integer) As Integer

  Public Shared Sub SetKeyboardLayout(ByVal Language As enmLanguage)
    If Language = enmLanguage.Farsi Then
      LoadKeyboardLayout(LANG_FA_IR & Chr(0), KLF_ACTIVATE)
    Else
      LoadKeyboardLayout(LANG_EN_US & Chr(0), KLF_ACTIVATE)
    End If
  End Sub
   Public Shared Function Max(ByVal Value1 As Integer, ByVal Value2 As Integer) As Integer
      If Value1 > Value2 Then
         Return Value1
      Else
         Return Value2
      End If
   End Function

   Public Shared Function FormatMoney(ByVal Value As String) As String
      Dim vReturn As String = ""
      Dim vRealValue As String = Value.Split(".")(0)
      Dim vDecimalPointValue As String = ""
      If Value.Split(".").Length > 1 Then vDecimalPointValue = Value.Split(".")(1)
      Dim i As Integer = 1
      If vRealValue.Length <= 3 Then
         vReturn = vRealValue
      Else
         While i <= vRealValue.Length \ 3
            vReturn = "," & Mid(vRealValue, vRealValue.Length + 1 - i * 3, 3) & vReturn
            i += 1
         End While
         If vRealValue.Length > (i - 1) * 3 Then vReturn = Left(vRealValue, vRealValue.Length - (i - 1) * 3) & vReturn
         If Left(vReturn, 1) = "," Then vReturn = Right(vReturn, vReturn.Length - 1)
      End If
      Return vReturn & IIf(vDecimalPointValue = "", "", "." & vDecimalPointValue)
   End Function

   Public Shared Function DeFormatMoney(ByVal Value As String) As String
      Return Value.Replace(",", "")
   End Function

   Public Shared Sub AddBlankRow(ByVal dt As DataTable, ByVal Values As String)
      Dim dr As DataRow
      Dim i As Integer
      Dim str As Array = Values.Split(",")
      dr = dt.NewRow
      For i = 0 To str.Length - 1
         dr(Trim(str(i).split("=")(0))) = Trim(str(i).split("=")(1))
      Next
      dt.Rows.InsertAt(dr, 0)
   End Sub

   Public Shared Function Reverse(ByVal str As String) As String
      Dim i As Integer
      Dim RStr As String = ""
      For i = str.Length - 1 To 0 Step -1
         RStr &= str.Substring(i, 1)
      Next
      Return RStr
   End Function

   Public Shared Function getControl(ByVal Container As Object, ByVal Name As String) As Object
      Static Dim ctr As Object
      Dim vControl As Object
      Dim vReturn As Object
      If Container.GetType Is GetType(ContextMenuStrip) Then
         vReturn = Container.items(Name)
      Else
            vReturn = Container.controls()(Name)
      End If
      If vReturn Is Nothing Then
         For Each vControl In Container.controls
                ' If Not vControl.GetType Is GetType(RackItem) AndAlso Not vControl.GetType Is GetType(ucRoomIcon) Then vReturn = getControl(vControl, Name)
            Next
         'For Each vControl In Container.components.components
         '  vReturn = getControl(vControl, Name)
         'Next
      Else
         ctr = vReturn
      End If
      If Not ctr Is Nothing AndAlso ctr.name = Name Then Return ctr Else Return Nothing
   End Function

   Public Shared Sub ConcatDataTable(ByVal MainDataTable As DataTable, ByVal AppendantDataTable As DataTable)
      Dim i As Integer
      For i = 0 To AppendantDataTable.Rows.Count - 1
         MainDataTable.ImportRow(AppendantDataTable.Rows(i))
      Next
   End Sub

   Public Shared Function getCount(ByVal dt As DataTable, ByVal Column As String) As Integer
      If dt.Rows.Count = 0 Then Return 0
      Dim i As Integer
      Dim vCount As Integer = 1
      Dim vDT As DataTable = dt.Copy
      vDT.DefaultView.Sort = Column
      Dim vValue As String = vDT.DefaultView.Item(0).Item(Column)
      For i = 1 To vDT.DefaultView.Count - 1
         If vDT.DefaultView.Item(i).Item(Column) <> vValue Then
            vCount += 1
            vValue = vDT.DefaultView.Item(i).Item(Column)
         End If
      Next
      Return vCount
   End Function

   Public Shared Sub FocusNextControl(ByVal Control As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyCode = Keys.Return Then
            If Not Control.GetType Is GetType(Button) Then SendKeys.Send("{TAB}")
      ElseIf e.KeyCode = Keys.Add Then
         If Control.GetType Is GetType(Button) Then SendKeys.Send("{TAB}")
      ElseIf e.KeyCode = Keys.Subtract Then
         If Control.GetType Is GetType(Button) Then SendKeys.Send("+{TAB}")
      End If
   End Sub

   Public Shared Function getNumberName(ByVal Num As String)
      Dim Value As String = Num.Replace(",", "")
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

   Public Shared Function NVL(ByVal Variable As Object, ByVal Value As Object) As Object
      If Variable Is Nothing Then
         NVL = Value
      ElseIf IsDBNull(Variable) Then
         NVL = Value
      ElseIf CType(Variable, String) = "" Then
         NVL = Value
      Else
         NVL = Variable
      End If
   End Function

   Public Shared Function MergeDataRows(ByVal dr1 As DataRow, ByVal dr2 As DataRow, ByVal ParamArray Columns() As String) As DataRow
      Dim i As Integer
      For i = 0 To Columns.Length - 1
         dr1.Item(Columns(i)) += dr2.Item(Columns(i))
      Next
      Return dr1
   End Function
    <Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ActivateKeyboardLayout",
      CallingConvention:=Runtime.InteropServices.CallingConvention.StdCall,
      CharSet:=Runtime.InteropServices.CharSet.Unicode,
      ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function ActivateKeyboardLayout(ByVal HKL As Integer, ByVal flags As Integer) As Integer
    End Function
    Public DefaultCodePage As Long

   Public Enum enmFormShowType
      Modal
      UnModal
      Mdi
   End Enum

   Public Shared Function OpenForm(ByVal [NameSpace] As String, ByVal FormName As String, ByVal Parameters As String, ByVal Parent As Form, ByVal ShowType As enmFormShowType, ByVal WindowState As FormWindowState, ByVal Text As String) As System.Windows.Forms.Form
      If FormName = "" Then Return Nothing
      Dim vForm As System.Windows.Forms.Form
      Dim a As System.Reflection.Assembly = System.Reflection.Assembly.LoadFile(Application.StartupPath & "\" & [NameSpace] & ".dll")
      If Parameters = "" Then
         vForm = a.CreateInstance(IIf([NameSpace] = "", "", [NameSpace] & ".") & FormName, True)
      Else
         Dim vParameters() As Object = getParameters(Parameters)
         vForm = a.CreateInstance(IIf([NameSpace] = "", "", [NameSpace] & ".") & FormName, True, System.Reflection.BindingFlags.CreateInstance, Nothing, vParameters, Nothing, Nothing)
      End If
      If vForm Is Nothing Then Return Nothing
      If ShowType = enmFormShowType.Mdi Then
         For Each frm As Form In Parent.MdiChildren
            If frm.Tag = vForm.Tag Then
               If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal
               frm.Activate()
               Return frm
            End If
         Next
         vForm.MdiParent = Parent
         vForm.StartPosition = FormStartPosition.Manual
         vForm.MaximizeBox = False
         Dim sw As Boolean = False
         If vForm.WindowState = FormWindowState.Maximized Then
            vForm.WindowState = FormWindowState.Normal
            sw = True
         End If
         If sw = True Then
            vForm.Location = New System.Drawing.Point(0, 0)
            vForm.Height = vForm.MdiParent.Height - 45
            vForm.Width = vForm.MdiParent.Width - 25
         End If
         If vForm.Height > vForm.MdiParent.Height - 45 Then vForm.Height = vForm.MdiParent.Height - 45
         If vForm.Width > vForm.MdiParent.Width - 25 Then vForm.Width = vForm.MdiParent.Width - 25
         vForm.Top = (vForm.MdiParent.Height - 45) / 2 - vForm.Height / 2
         vForm.Left = (vForm.MdiParent.Width - 25) / 2 - vForm.Width / 2
         If vForm.Top < 0 Then vForm.Top = 0
         If vForm.Left < 0 Then vForm.Left = 0
         Dim vSize As System.Drawing.Size = vForm.Size
         vForm.Show()
         If vForm.Size <> vSize Then vForm.Size = vSize
      Else
         vForm.WindowState = WindowState
         If ShowType = enmFormShowType.Modal Then
            vForm.ShowDialog()
         Else
            vForm.Show()
         End If
      End If
      Return vForm
   End Function

   Public Shared Function getParameters(ByVal Parameter As String) As Object
      Dim Paramaters() As Object = Nothing
      If Parameter = "" Then Return Nothing
      Array.Resize(Paramaters, Parameter.Split(",").Length)
      Dim [ParamArray] As Array = Parameter.Split(",")
      Dim vType As String, vValue As String
      For i As Integer = 0 To [ParamArray].Length - 1
         vType = [ParamArray](i).ToString.Split(":")(1).ToLower
         vValue = [ParamArray](i).ToString.Split(":")(0)
            If vValue.Trim = "Calendar.GetDate(True)" Then vValue = Solar.GetDate(True)
            If vValue.Trim = "mn_Globals.CurrentUser.Id" Then vValue = Globals.CurrentUser.Id
            Select Case vType
                Case "integer" : Paramaters(i) = Integer.Parse(vValue)
                Case "long" : Paramaters(i) = Long.Parse(vValue)
                Case "string" : Paramaters(i) = vValue
                Case "boolean" : Paramaters(i) = Boolean.Parse(vValue)
                Case "datarow" : Paramaters(i) = Nothing
                    ' Case "enums.enmrestaurantfactortype" : Paramaters(i) = [Enum].Parse(GetType(Enums.enmRestaurantFactorType), vValue, True)
                    ' Case "enums.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Enums.enmReportType), vValue, True)
                    'Case "contract.clscontract.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Contract.clsContract.enmReportType), vValue, True)
                    ' Case "enums.enmaccounttype" : Paramaters(i) = [Enum].Parse(GetType(Enums.enmAccountType), vValue, True)
                    'Case "account.frmaccountlist.enmaccounttype" : Paramaters(i) = [Enum].Parse(GetType(Account.frmAccountList.enmAccountType), vValue, True)
                    'Case "cash.frmcashreport.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Cash.frmCashReport.enmReportType), vValue, True)
                    'Case "guest.frmguestlist.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Guest.frmGuestList.enmReportType), vValue, True)
                    'Case "household.frmminibartypelist.enmformtype" : Paramaters(i) = [Enum].Parse(GetType(HouseHold.frmMinibarTypeList.enmFormType), vValue, True)
                    'Case "rack.frmrack.enmracktype" : Paramaters(i) = [Enum].Parse(GetType(Rack.frmRack.enmRackType), vValue, True)
                    '  Case "enums.enmactiontype" : Paramaters(i) = [Enum].Parse(GetType(enmActionType), vValue, True)
                    '  Case "enums.enmreportreporttype" : Paramaters(i) = [Enum].Parse(GetType(enmReportReportType), vValue, True)
                    'Case "reserve.frmreservelist.enmformtype" : Paramaters(i) = [Enum].Parse(GetType(Reserve.frmReserveList.enmFormType), vValue, True)
                    'Case "restaurant.frmrestaurantlist.enmrestaurantfactortype" : Paramaters(i) = [Enum].Parse(GetType(Restaurant.frmRestaurantList.enmRestaurantFactorType), vValue, True)
                    'Case "restaurant.frmrestaurantreport.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Restaurant.frmRestaurantReport.enmReportType), vValue, True)
                    'Case "restaurant.frmrestaurantusage.enmreporttype" : Paramaters(i) = [Enum].Parse(GetType(Restaurant.frmRestaurantUsage.enmReportType), vValue, True)
                    'Case "shift.frmshiftlist.enmformtype" : Paramaters(i) = [Enum].Parse(GetType(Shift.frmShiftList.enmFormType), vValue, True)
                    'Case "security.frmuserpermission.enmtype" : Paramaters(i) = [Enum].Parse(GetType(Security.frmUserPermission.enmType), vValue, True)
                    ' Case "enums.cashtype" : Paramaters(i) = [Enum].Parse(GetType(Enums.CashType), vValue, True)
                    ' Case "enums.formactiontype" : Paramaters(i) = [Enum].Parse(GetType(Enums.FormActionType), vValue, True)
                    'Case "enums.persontype" : Paramaters(i) = [Enum].Parse(GetType(Enums.PersonType), vValue, True)
            End Select
        Next
        Return Paramaters
    End Function

    Public Shared Function checkNationalcode(ByVal NationalCode As String) As Boolean
        If Globals.IsLangugePersian = False Then Return True

        If (String.IsNullOrEmpty(NationalCode)) Then
            MessageBox.Show("لطفا کد ملی را صحیح وارد نمایید")
            Return False
        End If

        If (NationalCode.Length <> 10) Then
            MessageBox.Show("طول کد ملی باید ده کاراکتر باشد")
            Return False
        End If

        If IsNumeric(NationalCode) = False Then
            MessageBox.Show("کد ملی تشکیل شده از ده رقم عددی می‌باشد؛ لطفا کد ملی را صحیح وارد نمایید")
            Return False
        End If

        Dim allDigitEqual As String() = {"0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999"}

        For i As Integer = 0 To 9
            If allDigitEqual(i) = NationalCode Then
                MessageBox.Show("رقم های کد ملی وارد شده یکسان است")
                Return False
            End If
        Next

        Dim chArray() = NationalCode.Split()
        Dim num0 = Convert.ToInt64(NationalCode.Substring(0, 1).ToString()) * 10
        Dim num2 = Convert.ToInt64(NationalCode.Substring(1, 1).ToString()) * 9
        Dim num3 = Convert.ToInt64(NationalCode.Substring(2, 1).ToString()) * 8
        Dim num4 = Convert.ToInt64(NationalCode.Substring(3, 1).ToString()) * 7
        Dim num5 = Convert.ToInt64(NationalCode.Substring(4, 1).ToString()) * 6
        Dim num6 = Convert.ToInt64(NationalCode.Substring(5, 1).ToString()) * 5
        Dim num7 = Convert.ToInt64(NationalCode.Substring(6, 1).ToString()) * 4
        Dim num8 = Convert.ToInt64(NationalCode.Substring(7, 1).ToString()) * 3
        Dim num9 = Convert.ToInt64(NationalCode.Substring(8, 1).ToString()) * 2
        Dim a = Convert.ToInt64(NationalCode.Substring(9, 1).ToString())

        Dim b = num0 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9
        Dim c = b Mod 11
        Dim vResult As Boolean = (((c < 2) And (a = c)) Or ((c >= 2) And ((11 - c) = a)))
        If vResult = False Then
            MessageBox.Show("کد ملی نا معتبر است")
        End If
        Return vResult
    End Function



    Public Shared Function getMessageDictiory(ByVal ID As Integer) As String
        Return SQL.ExecuteScalar(" SELECT ISNULL(STR_RESULT,STR_MESSAGE) FROM  MESSAGE_NEW WHERE ID=" & ID)
    End Function

    Public Shared Function getMessage(ByVal MessageStr As String) As String
        If Globals.IsLangugePersian = True Then
            Return MessageStr
        Else
            MessageStr = MessageStr.Replace("ي", "ی").Replace("ك", "ک")
            If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\bin\ar\MESSAGE_DICTUNARY.xml") Then
                Dim ds As New DataSet
                ds.ReadXml(System.IO.Path.GetTempPath() & "\bin\ar\MESSAGE_DICTUNARY.xml")

                For Each dr As DataRow In ds.Tables(0).Rows
                    dr("STR_MESSAGE") = dr("STR_MESSAGE").ToString.Replace("ي", "ی").Replace("ك", "ک")
                Next

                If ds.Tables(0).Select("STR_MESSAGE='" & MessageStr & "'").Length > 0 Then
                    Return NVL(ds.Tables(0).Select("STR_MESSAGE='" & MessageStr & "'")(0)("STR_RESULT"), MessageStr)
                Else
                    If SQL.ExecuteScalar("SELECT COUNT(*) FROM MESSAGE_DICTUNARY WHERE STR_MESSAGE='" & MessageStr & "'") = 0 Then
                        SQL.ExecuteNonQuery("INSERT INTO MESSAGE_DICTUNARY(STR_MESSAGE) " & vbCrLf &
                                                                                "VALUES('" + MessageStr & "')")
                    End If

                    Return MessageStr
                End If
            End If
        End If
        Return MessageStr
    End Function

    Public Shared Function getColumnGridTitle(ByVal Title As Object) As Object
        If Globals.IsLangugePersian = False Then
            If Not IsDBNull(Title) AndAlso Title <> "" Then
                Title = Title.Replace("ي", "ی").Replace("ك", "ک")
                If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml") Then
                    Dim ds As New DataSet
                    ds.ReadXml(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml")

                    For Each dr As DataRow In ds.Tables(0).Rows
                        dr("TITLE") = dr("TITLE").ToString.Replace("ي", "ی").Replace("ك", "ک")
                    Next

                    If ds.Tables(0).Select("TITLE='" & Title & "'").Length > 0 Then
                        Return NVL(ds.Tables(0).Select("TITLE='" & Title & "'")(0)("AR_TITLE"), Title)
                    Else
                        If SQL.ExecuteScalar("SELECT COUNT(*) FROM OBJECT_DICTUNARY WHERE TITLE='" & Title & "'") = 0 Then
                            SQL.ExecuteNonQuery("INSERT INTO OBJECT_DICTUNARY(TITLE) " & vbCrLf &
                                                                                    "VALUES('" + Title & "')")
                        End If
                    End If
                    Return Title
                End If
            End If
        End If
        Return Title
    End Function

    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control) As List(Of Control)
        ', ByVal ctrlType As System.Type
        If parent Is Nothing Then Return list
        If TypeOf parent Is Label Or TypeOf parent Is Button Or TypeOf parent Is RadioButton Or TypeOf parent Is CheckBox Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            ' FindControlRecursive(list, child, ctrlType)
            FindControlRecursive(list, child)
        Next
        Return list
    End Function

    Public Shared Sub setMenuObjectTitle(ByVal mnu As ContextMenuStrip)
        If Globals.IsLangugePersian = False Then
            Dim ds As New DataSet
            If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml") Then
                ds.ReadXml(System.IO.Path.GetTempPath() & "\bin\ar\OBJECT_DICTUNARY.xml")

                For Each dr As DataRow In ds.Tables(0).Rows
                    dr("TITLE") = dr("TITLE").ToString.Replace("ي", "ی").Replace("ك", "ک")
                Next

                For Each Item As ToolStripItem In mnu.Items
                    Item.Text = Item.Text.Replace("ي", "ی").Replace("ك", "ک")

                    If Item.Text.Trim.Length > 1 Then
                        If ds.Tables(0).Select("TITLE='" & Item.Text & "'").Length > 0 Then
                            Item.Text = NVL(ds.Tables(0).Select("TITLE='" & Item.Text & "'")(0)("AR_TITLE"), Item.Text)
                        Else
                            If SQL.ExecuteScalar("SELECT COUNT(*) FROM OBJECT_DICTUNARY WHERE TITLE='" & Item.Text & "'") = 0 Then
                                SQL.ExecuteNonQuery("INSERT INTO OBJECT_DICTUNARY(TITLE) " & vbCrLf &
                                                                    "VALUES('" + Item.Text & "')")
                            End If
                        End If
                    End If

                Next
            End If
        End If

    End Sub
End Class
