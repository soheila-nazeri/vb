<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcListBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcListBox))
        Me.chk = New mnComponents.Controls.mnCheckedListBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCheckAll = New System.Windows.Forms.ToolStripButton
        Me.btnUndoCheckAll = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk
        '
        Me.chk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk.ForeColor = System.Drawing.Color.Black
        Me.chk.Location = New System.Drawing.Point(0, 0)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(229, 174)
        Me.chk.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheckAll, Me.btnUndoCheckAll, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(-7, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(32, 174)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.chk)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(255, 174)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'UcListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UcListBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(255, 174)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk As mnComponents.Controls.mnCheckedListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndoCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
