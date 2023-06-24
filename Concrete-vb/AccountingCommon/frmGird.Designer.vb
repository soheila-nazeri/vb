<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGird
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGird))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnOkExit = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grdList = New mnComponents.mnJanusGrid
        Me.btnCheckAll = New System.Windows.Forms.ToolStripButton
        Me.btnUndoCheckAll = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheckAll, Me.btnUndoCheckAll, Me.btnOkExit, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(-9, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(32, 285)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnOkExit
        '
        Me.btnOkExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOkExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOkExit.Name = "btnOkExit"
        Me.btnOkExit.Size = New System.Drawing.Size(29, 4)
        Me.btnOkExit.Text = "ToolStripButton1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdList)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(258, 287)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 9
        '
        'grdList
        '
        Me.grdList.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AutoSize = True
        Me.grdList.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
        Me.grdList.CurrentRowIndex = -1
        Me.grdList.DataSource = Nothing
        Me.grdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdList.GroupByBoxVisible = False
        Me.grdList.HasSumColumn = False
        Me.grdList.HeaderLines = 1
        Me.grdList.Location = New System.Drawing.Point(0, 0)
        Me.grdList.Name = "grdList"
        Me.grdList.PaperType = "Portrait"
        Me.grdList.ReportTitle = ""
        Me.grdList.ShowColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowGroupBar = False
        Me.grdList.ShowSelectedAll = False
        Me.grdList.ShowToolbar = False
        Me.grdList.Size = New System.Drawing.Size(230, 285)
        Me.grdList.strFilter = Nothing
        Me.grdList.TabIndex = 1
        Me.grdList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdList.Type = 0
        '
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCheckAll.Image = Global.CommonTools.My.Resources.Resources.check
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(29, 20)
        Me.btnCheckAll.Text = "ToolStripButton1"
        '
        'btnUndoCheckAll
        '
        Me.btnUndoCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndoCheckAll.Image = Global.CommonTools.My.Resources.Resources.Del
        Me.btnUndoCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndoCheckAll.Name = "btnUndoCheckAll"
        Me.btnUndoCheckAll.Size = New System.Drawing.Size(29, 20)
        Me.btnUndoCheckAll.Text = "ToolStripButton2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'frmGird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 287)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGird"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndoCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnOkExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdList As mnComponents.mnJanusGrid
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
