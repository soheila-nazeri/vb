
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnGrid
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
        Me.components = New System.ComponentModel.Container
        Me.tlpTools = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelFilter = New System.Windows.Forms.ToolStripButton
        Me.btnPrintPortrait = New System.Windows.Forms.ToolStripButton
        Me.btnPrintLandScape = New System.Windows.Forms.ToolStripButton
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.btnPaperSize = New System.Windows.Forms.ToolStripDropDownButton
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grdGrid = New System.Windows.Forms.DataGridView
        Me.tlpHeader = New System.Windows.Forms.ToolStrip
        Me.tlpFilter = New System.Windows.Forms.ToolStrip
        Me.tlpRight = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlpFooter = New System.Windows.Forms.ToolStrip
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tlpTools.SuspendLayout()
        CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRight.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTools
        '
        Me.tlpTools.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTools.AutoSize = False
        Me.tlpTools.BackColor = System.Drawing.SystemColors.Control
        Me.tlpTools.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlpTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnCancelFilter, Me.btnPrintPortrait, Me.btnPrintLandScape, Me.btnPrintPreview, Me.btnPaperSize})
        Me.tlpTools.Location = New System.Drawing.Point(-1, 1)
        Me.tlpTools.Name = "tlpTools"
        Me.tlpTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tlpTools.Size = New System.Drawing.Size(492, 25)
        Me.tlpTools.TabIndex = 2
        Me.tlpTools.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelFilter
        '
        Me.btnCancelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image

        Me.btnCancelFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelFilter.Name = "btnCancelFilter"
        Me.btnCancelFilter.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelFilter.Tag = "0"
        '
        'btnPrintPortrait
        '
        Me.btnPrintPortrait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image

        Me.btnPrintPortrait.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPortrait.Name = "btnPrintPortrait"
        Me.btnPrintPortrait.Size = New System.Drawing.Size(23, 22)
        Me.btnPrintPortrait.Text = "چاپ"
        Me.btnPrintPortrait.ToolTipText = "چاپ - Portrait"
        '
        'btnPrintLandScape
        '
        Me.btnPrintLandScape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrintLandScape.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintLandScape.Name = "btnPrintLandScape"
        Me.btnPrintLandScape.Size = New System.Drawing.Size(23, 22)
        Me.btnPrintLandScape.Text = "چاپ"
        Me.btnPrintLandScape.ToolTipText = "چاپ - LandScape"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.btnPrintPreview.Tag = "Off"
        Me.btnPrintPreview.ToolTipText = "نمایش"
        '
        'btnPaperSize
        '
        Me.btnPaperSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPaperSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaperSize.Name = "btnPaperSize"
        Me.btnPaperSize.Size = New System.Drawing.Size(26, 22)
        Me.btnPaperSize.Text = "  "
        Me.btnPaperSize.ToolTipText = "اندازه کاغذ"
        '
        'grdGrid
        '
        Me.grdGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrid.ColumnHeadersVisible = False
        Me.grdGrid.Location = New System.Drawing.Point(0, 77)
        Me.grdGrid.Name = "grdGrid"
        Me.grdGrid.RowTemplate.Height = 25
        Me.grdGrid.Size = New System.Drawing.Size(514, 276)
        Me.grdGrid.TabIndex = 2
        '
        'tlpHeader
        '
        Me.tlpHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpHeader.AutoSize = False
        Me.tlpHeader.BackColor = System.Drawing.SystemColors.Control
        Me.tlpHeader.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpHeader.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlpHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlpHeader.Location = New System.Drawing.Point(-3452, 27)
        Me.tlpHeader.Name = "tlpHeader"
        Me.tlpHeader.Size = New System.Drawing.Size(3943, 25)
        Me.tlpHeader.TabIndex = 1
        Me.tlpHeader.Text = "ToolStrip1"
        '
        'tlpFilter
        '
        Me.tlpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpFilter.AutoSize = False
        Me.tlpFilter.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFilter.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpFilter.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlpFilter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlpFilter.Location = New System.Drawing.Point(-3452, 52)
        Me.tlpFilter.Name = "tlpFilter"
        Me.tlpFilter.Size = New System.Drawing.Size(3943, 25)
        Me.tlpFilter.TabIndex = 0
        Me.tlpFilter.Text = "ToolStrip2"
        '
        'tlpRight
        '
        Me.tlpRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpRight.AutoSize = False
        Me.tlpRight.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tlpRight.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpRight.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlpRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlpRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2})
        Me.tlpRight.Location = New System.Drawing.Point(491, 1)
        Me.tlpRight.Name = "tlpRight"
        Me.tlpRight.Padding = New System.Windows.Forms.Padding(0)
        Me.tlpRight.Size = New System.Drawing.Size(25, 76)
        Me.tlpRight.TabIndex = 6
        Me.tlpRight.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 76)
        '
        'tlpFooter
        '
        Me.tlpFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpFooter.AutoSize = False
        Me.tlpFooter.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFooter.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpFooter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlpFooter.Location = New System.Drawing.Point(-1452, 353)
        Me.tlpFooter.Name = "tlpFooter"
        Me.tlpFooter.Size = New System.Drawing.Size(1943, 25)
        Me.tlpFooter.TabIndex = 7
        Me.tlpFooter.Text = "ToolStrip2"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3})
        Me.ToolStrip3.Location = New System.Drawing.Point(491, 353)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.Size = New System.Drawing.Size(25, 25)
        Me.ToolStrip3.TabIndex = 8
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'mnGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTools)
        Me.Controls.Add(Me.tlpHeader)
        Me.Controls.Add(Me.tlpFilter)
        Me.Controls.Add(Me.tlpFooter)
        Me.Controls.Add(Me.grdGrid)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.tlpRight)
        Me.Name = "mnGrid"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(516, 380)
        Me.tlpTools.ResumeLayout(False)
        Me.tlpTools.PerformLayout()
        CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRight.ResumeLayout(False)
        Me.tlpRight.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents tlpTools As System.Windows.Forms.ToolStrip
  Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
  Friend WithEvents btnCancelFilter As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnPrintPortrait As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents grdGrid As System.Windows.Forms.DataGridView
  Friend WithEvents btnPrintLandScape As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnPaperSize As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlpHeader As System.Windows.Forms.ToolStrip
  Friend WithEvents tlpFilter As System.Windows.Forms.ToolStrip
  Friend WithEvents tlpRight As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tlpFooter As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
