<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchList
    Inherits frmTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdList = New mnComponents.mnJanusGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdList
        '
        Me.grdList.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdList.AutoSize = True
        Me.grdList.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        Me.grdList.CurrentRowIndex = -1
        Me.grdList.DataSource = Nothing
        Me.grdList.GroupByBoxVisible = False
        Me.grdList.HasSumColumn = False
        Me.grdList.HeaderLines = 1
        Me.grdList.Location = New System.Drawing.Point(0, 41)
        Me.grdList.Margin = New System.Windows.Forms.Padding(5)
        Me.grdList.Name = "grdList"
        Me.grdList.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        Me.grdList.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        Me.grdList.PaperType = "Portrait"
        Me.grdList.ReportTitle = ""
        Me.grdList.ShowColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowGroupBar = False
        Me.grdList.ShowSelectedAll = False
        Me.grdList.ShowToolbar = False
        Me.grdList.Size = New System.Drawing.Size(515, 332)
        Me.grdList.strFilter = Nothing
        Me.grdList.TabIndex = 6
        Me.grdList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdList.Type = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 41)
        Me.Panel1.TabIndex = 7
        '
        'txtTitle
        '
        Me.txtTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(-1, 0)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(514, 36)
        Me.txtTitle.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 41)
        Me.Panel2.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-1, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(514, 39)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSearchList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSearchList"
        Me.RightToLeftLayout = False
        Me.Text = "Search Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdList As mnComponents.mnJanusGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
