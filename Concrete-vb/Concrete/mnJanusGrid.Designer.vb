<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnJanusGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mnJanusGrid))
        Me.grd = New Janus.Windows.GridEX.GridEX()
        Me.tlbHeader = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPageMode = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PortraitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LandscapeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPaperSize = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRecordCount = New System.Windows.Forms.ToolStripLabel()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.tspSumItems = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnCheckAll = New System.Windows.Forms.ToolStripButton()
        Me.btnSendToStimulsoft = New System.Windows.Forms.ToolStripButton()
        Me.PrintFit = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveTemplate = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteTemplate = New System.Windows.Forms.ToolStripButton()
        Me.tlbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrintDocument = New Janus.Windows.GridEX.GridEXPrintDocument()
        Me.ppd = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlWait = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbHeader.SuspendLayout()
        Me.pnlWait.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grd.AlternatingColors = True
        Me.grd.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LavenderBlush
        Me.grd.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.DynamicFiltering = True
        Me.grd.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grd.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grd.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grd.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grd.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grd.GroupByBoxVisible = False
        Me.grd.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grd.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter
        Me.grd.Location = New System.Drawing.Point(0, 27)
        Me.grd.Margin = New System.Windows.Forms.Padding(4)
        Me.grd.Name = "grd"
        Me.grd.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grd.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grd.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grd.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grd.Size = New System.Drawing.Size(797, 382)
        Me.grd.TabIndex = 4
        Me.grd.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grd.TotalRowFormatStyle.ForeColor = System.Drawing.Color.Maroon
        Me.grd.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'tlbHeader
        '
        Me.tlbHeader.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlbHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.ToolStripSeparator2, Me.btnPageMode, Me.ToolStripSeparator1, Me.btnPaperSize, Me.ToolStripSeparator3, Me.lblRecordCount, Me.btnExcel, Me.tspSumItems, Me.btnCheckAll, Me.btnSendToStimulsoft, Me.PrintFit, Me.btnSaveTemplate, Me.btnDeleteTemplate, Me.tlbSave, Me.ToolStripDropDownButton1})
        Me.tlbHeader.Location = New System.Drawing.Point(0, 0)
        Me.tlbHeader.Name = "tlbHeader"
        Me.tlbHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tlbHeader.Size = New System.Drawing.Size(797, 27)
        Me.tlbHeader.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = Global.Concrete.My.Resources.Resources.print
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(24, 24)
        Me.btnPrint.Text = "ارسال به Exitی"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnPageMode
        '
        Me.btnPageMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPageMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortraitToolStripMenuItem, Me.LandscapeToolStripMenuItem})
        Me.btnPageMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPageMode.Name = "btnPageMode"
        Me.btnPageMode.Size = New System.Drawing.Size(71, 24)
        Me.btnPageMode.Text = "Portrait"
        '
        'PortraitToolStripMenuItem
        '
        Me.PortraitToolStripMenuItem.Name = "PortraitToolStripMenuItem"
        Me.PortraitToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.PortraitToolStripMenuItem.Text = "Portrait"
        '
        'LandscapeToolStripMenuItem
        '
        Me.LandscapeToolStripMenuItem.Name = "LandscapeToolStripMenuItem"
        Me.LandscapeToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.LandscapeToolStripMenuItem.Text = "Landscape"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnPaperSize
        '
        Me.btnPaperSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPaperSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaperSize.Name = "btnPaperSize"
        Me.btnPaperSize.Size = New System.Drawing.Size(78, 24)
        Me.btnPaperSize.Text = "PaperA4"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRecordCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRecordCount.Size = New System.Drawing.Size(2, 24)
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExcel
        '
        Me.btnExcel.Enabled = False
        Me.btnExcel.Image = Global.Concrete.My.Resources.Resources.EXPORT_PRES
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(125, 24)
        Me.btnExcel.Text = "انتقال به اکسل"
        '
        'tspSumItems
        '
        Me.tspSumItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspSumItems.Image = Global.Concrete.My.Resources.Resources.CALC
        Me.tspSumItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspSumItems.Name = "tspSumItems"
        Me.tspSumItems.Size = New System.Drawing.Size(34, 24)
        Me.tspSumItems.Text = "نمایش جمع ستون ها"
        '
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCheckAll.Image = Global.Concrete.My.Resources.Resources.check
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(24, 24)
        Me.btnCheckAll.Text = "Select آیتم ها"
        '
        'btnSendToStimulsoft
        '
        Me.btnSendToStimulsoft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSendToStimulsoft.Image = Global.Concrete.My.Resources.Resources.print
        Me.btnSendToStimulsoft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSendToStimulsoft.Name = "btnSendToStimulsoft"
        Me.btnSendToStimulsoft.Size = New System.Drawing.Size(24, 24)
        Me.btnSendToStimulsoft.Text = "نمایش Exitی"
        '
        'PrintFit
        '
        Me.PrintFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintFit.Image = Global.Concrete.My.Resources.Resources.print
        Me.PrintFit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintFit.Name = "PrintFit"
        Me.PrintFit.Size = New System.Drawing.Size(24, 24)
        Me.PrintFit.Text = "نمایش Exitی"
        '
        'btnSaveTemplate
        '
        Me.btnSaveTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveTemplate.Image = Global.Concrete.My.Resources.Resources.save_check
        Me.btnSaveTemplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveTemplate.Name = "btnSaveTemplate"
        Me.btnSaveTemplate.Size = New System.Drawing.Size(24, 24)
        Me.btnSaveTemplate.Text = "ذخیره تنظیمات "
        '
        'btnDeleteTemplate
        '
        Me.btnDeleteTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeleteTemplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteTemplate.Name = "btnDeleteTemplate"
        Me.btnDeleteTemplate.Size = New System.Drawing.Size(23, 24)
        Me.btnDeleteTemplate.Text = "Delete تنظیمات/تنظیمات پیش فرض"
        '
        'tlbSave
        '
        Me.tlbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSave.Name = "tlbSave"
        Me.tlbSave.Size = New System.Drawing.Size(23, 24)
        Me.tlbSave.Text = "ذخیره قالب جدول"
        Me.tlbSave.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(14, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Visible = False
        '
        'PrintDocument
        '
        Me.PrintDocument.GridEX = Me.grd
        '
        'ppd
        '
        Me.ppd.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd.Document = Me.PrintDocument
        Me.ppd.Enabled = True
        Me.ppd.Icon = CType(resources.GetObject("ppd.Icon"), System.Drawing.Icon)
        Me.ppd.Name = "ppd"
        Me.ppd.Visible = False
        '
        'pnlWait
        '
        Me.pnlWait.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlWait.Controls.Add(Me.Label1)
        Me.pnlWait.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlWait.Location = New System.Drawing.Point(219, 116)
        Me.pnlWait.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlWait.Name = "pnlWait"
        Me.pnlWait.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlWait.Size = New System.Drawing.Size(361, 81)
        Me.pnlWait.TabIndex = 6
        Me.pnlWait.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 81)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transfer Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(62, 6)
        Me.chkSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSelectAll.Size = New System.Drawing.Size(79, 18)
        Me.chkSelectAll.TabIndex = 7
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        Me.chkSelectAll.Visible = False
        '
        'mnJanusGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.pnlWait)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.tlbHeader)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mnJanusGrid"
        Me.Size = New System.Drawing.Size(797, 409)
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbHeader.ResumeLayout(False)
        Me.tlbHeader.PerformLayout()
        Me.pnlWait.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd As Janus.Windows.GridEX.GridEX
    Friend WithEvents tlbHeader As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ppd As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents btnPaperSize As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPageMode As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PortraitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LandscapeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRecordCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlWait As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSendToStimulsoft As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspSumItems As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnSaveTemplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteTemplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents tlbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintFit As System.Windows.Forms.ToolStripButton
End Class
