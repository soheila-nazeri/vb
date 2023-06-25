<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFinance
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
        Me.GroupBox3 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancellation = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdList = New mnComponents.mnJanusGrid()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnCancellation)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 462)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(740, 35)
        Me.GroupBox3.TabIndex = 28
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(340, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit  Esc"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancellation
        '
        Me.btnCancellation.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancellation.Dock = System.Windows.Forms.DockStyle.Left

        Me.btnCancellation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancellation.Location = New System.Drawing.Point(233, 0)
        Me.btnCancellation.Name = "btnCancellation"
        Me.btnCancellation.Size = New System.Drawing.Size(107, 35)
        Me.btnCancellation.TabIndex = 17
        Me.btnCancellation.Text = "Cancle F4"
        Me.btnCancellation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancellation.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left

        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(111, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(122, 35)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit F3"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 35)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "New F2"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'grdList
        '
        Me.grdList.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.AutoSize = True
        Me.grdList.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grdList.CurrentRowIndex = -1
        Me.grdList.DataSource = Nothing
        Me.grdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdList.GroupByBoxVisible = False
        Me.grdList.HasSumColumn = False
        Me.grdList.HeaderLines = 1
        Me.grdList.Location = New System.Drawing.Point(0, 0)
        Me.grdList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdList.Name = "grdList"
        Me.grdList.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        Me.grdList.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        Me.grdList.PaperType = "Portrait"
        Me.grdList.ReportTitle = ""
        Me.grdList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grdList.ShowColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowFilterBar = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdList.ShowGroupBar = False
        Me.grdList.ShowSelectedAll = False
        Me.grdList.ShowToolbar = True
        Me.grdList.Size = New System.Drawing.Size(740, 462)
        Me.grdList.strFilter = Nothing
        Me.grdList.TabIndex = 29
        Me.grdList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdList.Type = 0
        '
        'frmReportFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 497)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmReportFinance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Cycle List"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCancellation As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdList As mnComponents.mnJanusGrid
End Class
