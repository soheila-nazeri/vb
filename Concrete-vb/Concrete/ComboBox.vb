Public Class ComboBox

    Private vSelectedGridValue As Object
    Private RealChanche As Boolean = True
    Public Shadows Event Key_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    Public WriteOnly Property IsNecessary() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                BackColor = Color.FromArgb(255, 255, 192)
            Else
                BackColor = Color.White
            End If
        End Set
    End Property

    Public Sub Initialize(ByVal DataSource As Object, _
                          ByVal ValueField As String, _
                          ByVal TextField As String, _
                          Optional ByVal AddBlankRow As Boolean = False)
        Me.DataSource = Nothing
        Me.DisplayMember = Nothing
        Me.ValueMember = Nothing
        Me.DisplayMember = TextField
        Me.ValueMember = ValueField
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
        Me.DataSource = DataSource
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
            If Me.SelectedIndex >= 0 Then
                If Me.DataSource.GetType Is GetType(DataTable) Then
                    Return CType(Me.DataSource, DataTable).DefaultView.Item(Me.SelectedIndex).Row
                Else
                    Return Me.DataSource.item(Me.SelectedIndex).row
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Sub mnComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Try
            If RealChanche = False Then Return
            If Not Me.Text Is Nothing AndAlso Me.Text.Trim <> "" Then
                RealChanche = False
                If Me.Text.Contains("ي") Then Me.Text = Me.Text.Replace("ي", "ی") '.Replace("ك", "ک")
                RealChanche = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space And e.Alt = True Then
            Dim dt As DataTable
            If Me.DataSource.GetType Is GetType(DataTable) Then
                dt = CType(Me.DataSource, DataTable).Copy
            Else
                dt = CType(Me.DataSource, DataView).ToTable
            End If
            Dim vForm As New Windows.Forms.Form
            vForm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            vForm.StartPosition = FormStartPosition.CenterParent
            vForm.RightToLeft = Windows.Forms.RightToLeft.Yes
            vForm.Size = New System.Drawing.Size(Me.Width + 45, 300)
            vForm.KeyPreview = True
            vForm.ControlBox = False
            AddHandler vForm.KeyDown, AddressOf FormKeyDown
            AddHandler vForm.KeyUp, AddressOf FormKeyUp
            AddHandler vForm.Shown, AddressOf FormShown
            Dim vGrid As New mnGrid
            vGrid.Dock = DockStyle.Fill
            vGrid.StandartTab = False
            vGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            vGrid.Name = "grd"
            vGrid.AllowUserToAddRows = False
            vGrid.ShowFooter = False
            vGrid.ShowFilterBar = True
            vGrid.ShowToolBar = False
            vGrid.ShowHeader = False
            vGrid.Initialize(":" & Me.DisplayMember & ":" & Me.Width - 10, dt)
            vForm.Controls.Add(vGrid)
            vForm.TopMost = True
            vForm.ShowDialog()
            If vForm.DialogResult = DialogResult.OK Then
                If Not vGrid.CurrentDataRow Is Nothing Then
                    Me.SelectedValue = vSelectedGridValue ' vGrid.CurrentDataRow.Item(Me.ValueMember)
                End If
            End If
            vForm.Dispose()

        ElseIf e.KeyCode = Keys.Space And e.Control = True Then

            Dim dt As DataTable = CType(Me.DataSource, DataTable).Copy
            Dim vfrm As New frmSearchList(dt, Me.DisplayMember)

            vfrm.ShowDialog()
            If Not vfrm.Selectedrow Is Nothing Then
                Me.SelectedValue = vfrm.Selectedrow("ID")
            End If
        End If
        RaiseEvent Key_Down(sender, e)
    End Sub

    Public Sub FormKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                If Not sender.toplevelcontrol.controls(0).CurrentDataRow Is Nothing Then
                    vSelectedGridValue = sender.toplevelcontrol.controls(0).CurrentDataRow.Item(Me.ValueMember)
                End If
                CType(sender, Windows.Forms.Form).DialogResult = DialogResult.OK
            Case Keys.Escape
                CType(sender, Windows.Forms.Form).DialogResult = DialogResult.Cancel
        End Select
    End Sub

    Public Sub FormKeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then CType(sender, Windows.Forms.Form).DialogResult = DialogResult.Cancel
    End Sub

    Public Sub FormShown(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.toplevelcontrol.controls(0).FocusFilterItems()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
