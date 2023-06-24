Public Class UcComboBox
    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event Key_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Dim vLoad As Boolean = False
    Private vIDS As String
    Public Property IDS() As String
        Get
            Return vIDS
        End Get
        Set(ByVal value As String)
            vIDS = value
            CreateTitle()
        End Set
    End Property
    Private VTitle As String
    Public Property Title() As String
        Get
            Return VTitle
        End Get
        Set(ByVal value As String)
            VTitle = value
        End Set
    End Property
    Public Property SelectedValue() As Object
        Get
            Return cbo.SelectedValue
        End Get
        Set(ByVal value As Object)
            cbo.SelectedValue = value
        End Set
    End Property
    Public Property SelectedIndex() As Long
        Get
            Return cbo.SelectedIndex
        End Get
        Set(ByVal value As Long)
            If value = 0 Then Return
            cbo.SelectedIndex = value
        End Set
    End Property
    Public Sub CreateTitle()
        '======================
        Try
            If cbo.DataSource Is Nothing Then Return
            'Title = ""
            Dim strTitle As String = ""
            Dim dt As DataTable = CType(cbo.DataSource, DataTable).Copy
            dt.DefaultView.RowFilter = " ID IN (" & IDS & ")"
            dt = dt.DefaultView.ToTable.Copy
            For Each dr As DataRow In dt.Rows
                strTitle &= dr.Item("TITLE").ToString & ","
            Next
            If Not Title Is Nothing AndAlso Title.Length > 0 Then Title = Title.Remove(Title.Length - 1, 1)
            '======================
            cbo.Text = strTitle
            Title = strTitle
        Catch ex As Exception
        End Try
    End Sub

    Private vSelectedGridValue As Object
    Private RealChanche As Boolean = True
    Public Sub Initialize(ByVal DataSource As Object,
                          ByVal ValueField As String,
                          ByVal TextField As String,
                          Optional ByVal AddBlankRow As Boolean = False)
        vLoad = False
        cbo.DataSource = Nothing
        cbo.DisplayMember = Nothing
        cbo.ValueMember = Nothing
        cbo.DisplayMember = TextField
        cbo.ValueMember = ValueField

        '=========================
        If AddBlankRow Then AddBlankRow_(DataSource, TextField & "=," & ValueField & "=0")
        Dim i As Integer
        If DataSource.GetType Is GetType(DataTable) Then
            For i = 0 To CType(DataSource, DataTable).Rows.Count - 1
                CType(DataSource, DataTable).Rows(i).Item(TextField) = CType(DataSource, DataTable).Rows(i).Item(TextField).ToString.Replace("ي", "ی") '.Replace("ك", "ک")
            Next
        Else
            For i = 0 To CType(DataSource, DataView).Count - 1
                CType(DataSource, DataView).Item(i).Item(TextField) = CType(DataSource, DataView).Item(i).Item(TextField).ToString.Replace("ي", "ی") '.Replace("ك", "ک")
            Next
        End If
        cbo.DataSource = DataSource
        CreateTitle()
        '=========================
        vLoad = True
        FormShown(Nothing, Nothing)
    End Sub
    Private Sub AddBlankRow_(ByVal dt As DataTable, ByVal Values As String)
        Dim dr As DataRow
        Dim i As Integer
        Dim str As Array = Values.Split(",")
        dr = dt.NewRow
        For i = 0 To str.Length - 1
            dr(Trim(str(i).split("=")(0))) = Trim(str(i).split("=")(1))
        Next
        dt.Rows.InsertAt(dr, 0)
    End Sub
    Public ReadOnly Property SelectedDataRow() As DataRow
        Get
            If cbo.SelectedIndex >= 0 Then
                If cbo.DataSource.GetType Is GetType(DataTable) Then
                    Return CType(cbo.DataSource, DataTable).DefaultView.Item(cbo.SelectedIndex).Row
                Else
                    Return cbo.DataSource.item(cbo.SelectedIndex).row
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public Sub FormShown(ByVal sender As Object, ByVal e As System.EventArgs)
        cbo.Text = Title
    End Sub
    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo.KeyDown
        If vLoad = False Then Return
        If (e.KeyCode = Keys.Space) Then
            Dim frm As New CommonTools.frmGird(cbo.DataSource, Me.IDS)
            frm.ShowDialog()
            IDS = frm.IDS
            cbo.Text = frm.Title
            Title = frm.Title
            If IDS = "0" Then
                IDS = ""
                cbo.Text = ""
                Title = ""
            End If
        End If
        RaiseEvent Key_Down(sender, e)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.SelectedIndexChanged
        If vLoad = False Then Return
        Try
            IDS = IIf(Str(cbo.SelectedValue).Trim() = "0", "", cbo.SelectedValue)
            Title = cbo.Text.Trim()
            RaiseEvent SelectedIndexChanged(sender, e)
        Catch ex As Exception
        End Try
    End Sub
End Class

