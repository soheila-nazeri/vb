Public Class DateBox

    Private Enum enmKeyType
        Digit
        Delete
        Back
        Right
        Left
    End Enum
    Private vKeyType As enmKeyType
    Private PreviousText As String
    Public TextType As Integer
    Public vIsValid As Boolean = True
    Private vPromptInclude As Boolean = False
    Public Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public WriteOnly Property IsNecessary() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                datDate.BackColor = Color.FromArgb(255, 255, 192)
            Else
                datDate.BackColor = Color.White
            End If
        End Set
    End Property
    Private Sub datDatedatDatee_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDate.TextChanged
        If datDate.Tag = "F" Then Exit Sub
        datDate.Tag = "F"
        Dim vPointer As Integer = datDate.SelectionStart
        If datDate.Text.IndexOf("/") < 0 Then
            If datDate.Text.Length > 6 Then
                datDate.Text = datDate.Text.Substring(0, 4) & "/" & datDate.Text.Substring(4, 2) & "/" & datDate.Text.Substring(6)
            ElseIf datDate.Text.Length > 4 Then
                datDate.Text = datDate.Text.Substring(0, 4) & "/" & datDate.Text.Substring(4)
            End If
        End If
        Dim S As String = Trim(datDate.Text)
        If (vKeyType = enmKeyType.Back Or vKeyType = enmKeyType.Delete) And (vPointer = 4 Or vPointer = 7) Then
            S = S.Substring(0, vPointer + 1) & "/" & S.Substring(vPointer + 2)
        End If
        Dim Y As String = (S & "----").Substring(0, 4)
        Dim M As String = "--"
        Dim D As String = "--"
        If S.IndexOf("/") > 0 Then
            Y = (S.Substring(0, S.IndexOf("/")) & "----").Substring(0, 4)
            M = (S.Substring(S.IndexOf("/") + 1) & "--").Substring(0, 2)
        End If
        Dim p As New Globalization.PersianCalendar

        If S.LastIndexOf("/") > S.IndexOf("/") Then
            M = (S.Substring(S.IndexOf("/") + 1, S.LastIndexOf("/") - S.IndexOf("/") - 1) & "--").Substring(0, 2)
            D = (S.Substring(S.LastIndexOf("/") + 1) & "--").Substring(0, 2)
        End If
        If Val(M.Replace("-", "")) > 12 Or Val(D.Replace("-", "")) > 31 Or
           (Val(M.Replace("-", "")) = 12 AndAlso Val(D.Replace("-", "")) > 29 AndAlso Not p.IsLeapYear(Y)) Or
           (Val(M.Replace("-", "")) > 6 And Val(D.Replace("-", "")) > 30 And Val(Y.Replace("-", "")) < 1500) Then
            datDate.Text = PreviousText
            datDate.Tag = "T"
            If vPointer > 0 Then datDate.SelectionStart = vPointer - 1
            Exit Sub
        End If
        S = Y & "/" & M & "/" & D
        datDate.Text = S
        datDate.SelectionStart = datDate.Text.Length
        If vKeyType = enmKeyType.Digit And (vPointer = 4 Or vPointer = 7) Then vPointer += 1
        If vPointer > -1 Then datDate.SelectionStart = vPointer
        datDate.Tag = "T"
    End Sub

    Private Sub datDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datDate.KeyDown
        PreviousText = datDate.Text
        vKeyType = enmKeyType.Digit
        If e.KeyCode = Keys.Back Then
            vKeyType = enmKeyType.Back
        ElseIf e.KeyCode = Keys.Delete Then
            vKeyType = enmKeyType.Delete
            If datDate.SelectionStart = 4 Then datDate.SelectionStart = 5
            If datDate.SelectionStart = 7 Then datDate.SelectionStart = 8
        ElseIf e.KeyCode = Keys.Right Then
            vKeyType = enmKeyType.Right
        ElseIf e.KeyCode = Keys.Left Then
            vKeyType = enmKeyType.Left
        ElseIf e.KeyCode = Keys.F3 Then
            datDate.Text = Solar.GetDate(True)
        ElseIf Not ((e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105)) Then
            e.Handled = False
        ElseIf (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            vKeyType = enmKeyType.Digit
            If datDate.Text.IndexOf("/") = 4 Then
                If datDate.SelectionStart = 4 Then datDate.SelectionStart = 5
            End If
            If datDate.Text.LastIndexOf("/") = 7 Then
                If datDate.SelectionStart = 7 Then datDate.SelectionStart = 8
            End If
            If datDate.SelectionStart > 0 Then
                Dim i As Integer
                For i = datDate.SelectionStart - 1 To 0 Step -1
                    If datDate.SelectionStart = 0 Then Exit For
                    If datDate.Text.Substring(i, 1) = "-" Then datDate.SelectionStart -= 1
                    If datDate.Text.Substring(i, 1) = "/" Then
                        If datDate.Text.Substring(i - 1, 1) = "-" Then
                            datDate.SelectionStart -= 1
                        End If
                    End If
                Next
            End If
        End If
        RaiseEvent KeyDown(Me, e)
    End Sub

    Private Sub datDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datDate.KeyUp
        RaiseEvent KeyUp(Me, e)
    End Sub

    Public Overrides Property Text() As String
        Get
            If vPromptInclude Then
                Return datDate.Text
            Else
                Return datDate.Text.Replace("/", "").Replace("-", "")
            End If
        End Get
        Set(ByVal Value As String)
            datDate.Text = Value
        End Set
    End Property

    Public Property PromptInclude() As Boolean
        Get
            Return vPromptInclude
        End Get
        Set(ByVal value As Boolean)
            vPromptInclude = value
        End Set
    End Property

    Public ReadOnly Property IsValid() As Boolean
        Get
            Dim s As String = datDate.Text.Replace("/", "").Replace("-", "")
            If s.Length = 0 Then Return True
            If s.Length = 8 Then
                If Val(s.Substring(0, 4)) > 1000 And Val(s.Substring(4, 2)) > 0 And Val(s.Substring(4, 2)) <= 12 And Val(s.Substring(6)) > 0 And Val(s.Substring(6)) <= 31 And _
                  (Val(s.Substring(4, 2)) < 7 Or Val(s.Substring(8)) <= 30) Then
                    Return True
                End If
            End If
            Return False
        End Get
    End Property

    Private Sub datDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDate.Leave
        ErrorProvider1.SetError(datDate, "")
        Dim s As String = datDate.Text.Replace("/", "").Replace("-", "")
        If s = "" Then Exit Sub
        If IsValid = False Then
            ErrorProvider1.SetError(datDate, "ÊÇÑíÎ ÇÔÊÈÇå ÇÓÊ")
            ErrorProvider1.SetIconAlignment(datDate, ErrorIconAlignment.MiddleRight)
            datDate.Width -= 15
            vIsValid = False
        End If
    End Sub

    Private Sub datDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDate.Enter
        If ErrorProvider1.GetError(datDate) <> "" Then datDate.Width += 15
        ErrorProvider1.SetError(datDate, "")
        If datDate.Text.Replace("/", "").Replace("-", "") <> "" Then
            datDate.SelectionStart = 5
            datDate.SelectionLength = 5
        End If
    End Sub

    Private Sub DateBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = datDate.Height
    End Sub


    Public Shadows Sub [Select]()
        datDate.Select()
    End Sub

    Public Shadows Sub [Select](ByVal start As Integer, ByVal length As Integer)
        datDate.Select(start, length)
    End Sub

End Class
