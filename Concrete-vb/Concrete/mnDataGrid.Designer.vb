
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnDataGrid
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mnDataGrid))
    Me.tbrFilter = New System.Windows.Forms.ToolStrip
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.cboColumn = New System.Windows.Forms.ToolStripComboBox
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnOperator = New System.Windows.Forms.ToolStripDropDownButton
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.cboValue = New System.Windows.Forms.ToolStripComboBox
    Me.btnOperand = New System.Windows.Forms.ToolStripDropDownButton
    Me.pnlFilter = New System.Windows.Forms.TableLayoutPanel
    Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.grdGrid = New System.Windows.Forms.DataGridView
    Me.pnlFooter = New System.Windows.Forms.Panel
    Me.btnFooterRowHeader = New System.Windows.Forms.Button
    Me.btnCancelFilter = New System.Windows.Forms.ToolStripButton
    Me.btnApplyFilter = New System.Windows.Forms.ToolStripButton
    Me.btnPrintPortrait = New System.Windows.Forms.ToolStripButton
    Me.btnPrintLandScape = New System.Windows.Forms.ToolStripButton
    Me.btnPaperSize = New System.Windows.Forms.ToolStripDropDownButton
    Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton
    Me.tbrFilter.SuspendLayout()
    Me.pnlFilter.SuspendLayout()
    CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlFooter.SuspendLayout()
    Me.SuspendLayout()
    '
    'tbrFilter
    '
    Me.tbrFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbrFilter.AutoSize = False
    Me.tbrFilter.Dock = System.Windows.Forms.DockStyle.None
    Me.tbrFilter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tbrFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cboColumn, Me.ToolStripSeparator3, Me.btnOperator, Me.ToolStripSeparator4, Me.cboValue, Me.btnOperand, Me.btnCancelFilter, Me.btnApplyFilter, Me.btnPrintPortrait, Me.btnPrintLandScape, Me.btnPaperSize, Me.btnPrintPreview})
    Me.tbrFilter.Location = New System.Drawing.Point(-1, 0)
    Me.tbrFilter.Name = "tbrFilter"
    Me.tbrFilter.Size = New System.Drawing.Size(574, 25)
    Me.tbrFilter.TabIndex = 0
    Me.tbrFilter.Text = "ToolStrip1"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'cboColumn
    '
    Me.cboColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboColumn.Name = "cboColumn"
    Me.cboColumn.Size = New System.Drawing.Size(140, 25)
    Me.cboColumn.ToolTipText = "عنوان ستون"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
    '
    'btnOperator
    '
    Me.btnOperator.AutoSize = False
    Me.btnOperator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnOperator.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnOperator.Name = "btnOperator"
    Me.btnOperator.Size = New System.Drawing.Size(82, 22)
    Me.btnOperator.Text = "مساوی"
    Me.btnOperator.ToolTipText = "عملگر"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
    '
    'cboValue
    '
    Me.cboValue.Name = "cboValue"
    Me.cboValue.Size = New System.Drawing.Size(140, 25)
    Me.cboValue.ToolTipText = "مقدار ستون"
    '
    'btnOperand
    '
    Me.btnOperand.AutoSize = False
    Me.btnOperand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnOperand.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnOperand.Name = "btnOperand"
    Me.btnOperand.Size = New System.Drawing.Size(30, 22)
    Me.btnOperand.Text = "   "
    Me.btnOperand.ToolTipText = "عملوند"
    '
    'pnlFilter
    '
    Me.pnlFilter.ColumnCount = 1
    Me.pnlFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 574.0!))
    Me.pnlFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.pnlFilter.Controls.Add(Me.tbrFilter, 0, 0)
    Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
    Me.pnlFilter.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlFilter.Name = "pnlFilter"
    Me.pnlFilter.RowCount = 1
    Me.pnlFilter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.pnlFilter.Size = New System.Drawing.Size(573, 28)
    Me.pnlFilter.TabIndex = 1
    '
    'grdGrid
    '
    Me.grdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.grdGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdGrid.Location = New System.Drawing.Point(0, 28)
    Me.grdGrid.Name = "grdGrid"
    Me.grdGrid.RowTemplate.Height = 25
    Me.grdGrid.Size = New System.Drawing.Size(573, 325)
    Me.grdGrid.TabIndex = 2
    '
    'pnlFooter
    '
    Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.pnlFooter.Controls.Add(Me.btnFooterRowHeader)
    Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlFooter.Location = New System.Drawing.Point(0, 353)
    Me.pnlFooter.Name = "pnlFooter"
    Me.pnlFooter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.pnlFooter.Size = New System.Drawing.Size(573, 27)
    Me.pnlFooter.TabIndex = 3
    '
    'btnFooterRowHeader
    '
    Me.btnFooterRowHeader.Dock = System.Windows.Forms.DockStyle.Right
    Me.btnFooterRowHeader.Location = New System.Drawing.Point(545, 0)
    Me.btnFooterRowHeader.Name = "btnFooterRowHeader"
    Me.btnFooterRowHeader.Size = New System.Drawing.Size(24, 23)
    Me.btnFooterRowHeader.TabIndex = 4
    Me.btnFooterRowHeader.UseVisualStyleBackColor = True
    '
    'btnCancelFilter
    '
    Me.btnCancelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image

        Me.btnCancelFilter.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelFilter.Name = "btnCancelFilter"
    Me.btnCancelFilter.Size = New System.Drawing.Size(23, 22)
    Me.btnCancelFilter.Tag = "0"
    '
    'btnApplyFilter
    '
    Me.btnApplyFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApplyFilter.Name = "btnApplyFilter"
    Me.btnApplyFilter.Size = New System.Drawing.Size(23, 22)
    Me.btnApplyFilter.ToolTipText = "اعمال فیلتر"
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
    'btnPaperSize
    '
    Me.btnPaperSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnPaperSize.Image = CType(resources.GetObject("btnPaperSize.Image"), System.Drawing.Image)
    Me.btnPaperSize.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnPaperSize.Name = "btnPaperSize"
    Me.btnPaperSize.Size = New System.Drawing.Size(26, 22)
    Me.btnPaperSize.Text = "  "
    Me.btnPaperSize.ToolTipText = "اندازه کاغذ"
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
    'mnDataGrid
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.grdGrid)
    Me.Controls.Add(Me.pnlFilter)
    Me.Controls.Add(Me.pnlFooter)
    Me.Name = "mnDataGrid"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.Size = New System.Drawing.Size(573, 380)
    Me.tbrFilter.ResumeLayout(False)
    Me.tbrFilter.PerformLayout()
    Me.pnlFilter.ResumeLayout(False)
    CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlFooter.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tbrFilter As System.Windows.Forms.ToolStrip
  Friend WithEvents cboColumn As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents cboValue As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnOperator As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents pnlFilter As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
  Friend WithEvents btnApplyFilter As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnOperand As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents btnCancelFilter As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnPrintPortrait As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents grdGrid As System.Windows.Forms.DataGridView
  Friend WithEvents pnlFooter As System.Windows.Forms.Panel
  Friend WithEvents btnFooterRowHeader As System.Windows.Forms.Button
  Friend WithEvents btnPrintLandScape As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnPaperSize As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripButton

End Class
