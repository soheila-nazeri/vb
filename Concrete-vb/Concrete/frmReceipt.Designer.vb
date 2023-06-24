<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.grpStore = New System.Windows.Forms.GroupBox()
        Me.txtRegisterDate = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRequesteCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboYear = New mnComponents.mnComboBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnEmployer = New System.Windows.Forms.Button()
        Me.cboEmployer = New mnComponents.mnComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRequester = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cboRequester = New mnComponents.mnComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDate = New mnComponents.DateBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdList = New mnComponents.mnJanusGrid()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.btnCancellation = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpStore.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStore
        '
        Me.grpStore.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpStore.Controls.Add(Me.txtRegisterDate)
        Me.grpStore.Controls.Add(Me.txtUser)
        Me.grpStore.Controls.Add(Me.Label2)
        Me.grpStore.Controls.Add(Me.Label3)
        Me.grpStore.Controls.Add(Me.txtRequesteCode)
        Me.grpStore.Controls.Add(Me.Label6)
        Me.grpStore.Controls.Add(Me.Label20)
        Me.grpStore.Controls.Add(Me.cboYear)
        Me.grpStore.Controls.Add(Me.txtCode)
        Me.grpStore.Controls.Add(Me.Label21)
        Me.grpStore.Controls.Add(Me.txtLocation)
        Me.grpStore.Controls.Add(Me.Label19)
        Me.grpStore.Controls.Add(Me.btnEmployer)
        Me.grpStore.Controls.Add(Me.cboEmployer)
        Me.grpStore.Controls.Add(Me.Label1)
        Me.grpStore.Controls.Add(Me.btnRequester)
        Me.grpStore.Controls.Add(Me.Label14)
        Me.grpStore.Controls.Add(Me.txtAddress)
        Me.grpStore.Controls.Add(Me.cboRequester)
        Me.grpStore.Controls.Add(Me.Label11)
        Me.grpStore.Controls.Add(Me.Label12)
        Me.grpStore.Controls.Add(Me.txtDate)
        Me.grpStore.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpStore.Location = New System.Drawing.Point(0, 0)
        Me.grpStore.Name = "grpStore"
        Me.grpStore.Size = New System.Drawing.Size(1240, 164)
        Me.grpStore.TabIndex = 0
        Me.grpStore.TabStop = False
        Me.grpStore.Text = "info List"
        '
        'txtRegisterDate
        '
        Me.txtRegisterDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterDate.Location = New System.Drawing.Point(885, 129)
        Me.txtRegisterDate.Name = "txtRegisterDate"
        Me.txtRegisterDate.ReadOnly = True
        Me.txtRegisterDate.Size = New System.Drawing.Size(331, 26)
        Me.txtRegisterDate.TabIndex = 111
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtUser.Location = New System.Drawing.Point(885, 98)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(331, 26)
        Me.txtUser.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(772, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(772, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "RegisterDate"
        '
        'txtRequesteCode
        '
        Me.txtRequesteCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequesteCode.Location = New System.Drawing.Point(885, 24)
        Me.txtRequesteCode.Name = "txtRequesteCode"
        Me.txtRequesteCode.Size = New System.Drawing.Size(218, 26)
        Me.txtRequesteCode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Year"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(772, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 18)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "RequesteCode"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1394", "1395", "1396", "1397", "1398", "1399", "1400"})
        Me.cboYear.Location = New System.Drawing.Point(547, 57)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(123, 26)
        Me.cboYear.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtCode.Location = New System.Drawing.Point(547, 25)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(123, 26)
        Me.txtCode.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(502, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 18)
        Me.Label21.TabIndex = 105
        Me.Label21.Text = "Code"
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocation.Location = New System.Drawing.Point(107, 128)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(359, 26)
        Me.txtLocation.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 18)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "Location"
        '
        'btnEmployer
        '
        Me.btnEmployer.BackColor = System.Drawing.SystemColors.Control
        Me.btnEmployer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployer.Location = New System.Drawing.Point(270, 54)
        Me.btnEmployer.Name = "btnEmployer"
        Me.btnEmployer.Size = New System.Drawing.Size(29, 30)
        Me.btnEmployer.TabIndex = 4
        Me.btnEmployer.TabStop = False
        Me.btnEmployer.Text = "+"
        Me.btnEmployer.UseVisualStyleBackColor = False
        '
        'cboEmployer
        '
        Me.cboEmployer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployer.FormattingEnabled = True
        Me.cboEmployer.Location = New System.Drawing.Point(107, 57)
        Me.cboEmployer.Name = "cboEmployer"
        Me.cboEmployer.Size = New System.Drawing.Size(157, 26)
        Me.cboEmployer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Employer"
        '
        'btnRequester
        '
        Me.btnRequester.BackColor = System.Drawing.SystemColors.Control
        Me.btnRequester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequester.Location = New System.Drawing.Point(270, 22)
        Me.btnRequester.Name = "btnRequester"
        Me.btnRequester.Size = New System.Drawing.Size(29, 30)
        Me.btnRequester.TabIndex = 1
        Me.btnRequester.TabStop = False
        Me.btnRequester.Text = "+"
        Me.btnRequester.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 18)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Requester"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Location = New System.Drawing.Point(107, 95)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(359, 26)
        Me.txtAddress.TabIndex = 2
        '
        'cboRequester
        '
        Me.cboRequester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRequester.FormattingEnabled = True
        Me.cboRequester.Location = New System.Drawing.Point(107, 25)
        Me.cboRequester.Name = "cboRequester"
        Me.cboRequester.Size = New System.Drawing.Size(157, 26)
        Me.cboRequester.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 18)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Address"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(771, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtDate.Location = New System.Drawing.Point(885, 56)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PromptInclude = True
        Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDate.Size = New System.Drawing.Size(77, 26)
        Me.txtDate.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnOk)
        Me.Panel1.Controls.Add(Me.btnCancellation)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 640)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 35)
        Me.Panel1.TabIndex = 2
        Me.Panel1.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.grdList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1240, 476)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
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
        Me.grdList.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grdList.CurrentRowIndex = -1
        Me.grdList.DataSource = Nothing
        Me.grdList.GroupByBoxVisible = False
        Me.grdList.HasSumColumn = False
        Me.grdList.HeaderLines = 1
        Me.grdList.Location = New System.Drawing.Point(0, 22)
        Me.grdList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.grdList.Size = New System.Drawing.Size(1234, 447)
        Me.grdList.strFilter = Nothing
        Me.grdList.TabIndex = 0
        Me.grdList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdList.Type = 0
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Image = Global.Concrete.My.Resources.Resources.Del
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(508, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(138, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Exit  Esc"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnOk.Image = Global.Concrete.My.Resources.Resources.check
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.Location = New System.Drawing.Point(377, 0)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(131, 35)
        Me.BtnOk.TabIndex = 3
        Me.BtnOk.Text = "Register -F9"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'btnCancellation
        '
        Me.btnCancellation.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancellation.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancellation.Image = Global.Concrete.My.Resources.Resources.Del
        Me.btnCancellation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancellation.Location = New System.Drawing.Point(259, 0)
        Me.btnCancellation.Name = "btnCancellation"
        Me.btnCancellation.Size = New System.Drawing.Size(118, 35)
        Me.btnCancellation.TabIndex = 2
        Me.btnCancellation.Text = "Delete - F8"
        Me.btnCancellation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancellation.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.Image = Global.Concrete.My.Resources.Resources.edit
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(128, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(131, 35)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit - F7"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Image = Global.Concrete.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 35)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "New - F6"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 675)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpStore)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpStore.ResumeLayout(False)
        Me.grpStore.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents grpStore As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboYear As mnComponents.mnComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdList As mnComponents.mnJanusGrid
    Friend WithEvents btnCancellation As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtRequesteCode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnEmployer As Button
    Friend WithEvents cboEmployer As mnComponents.mnComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRequester As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents cboRequester As mnComponents.mnComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDate As mnComponents.DateBox
    Friend WithEvents txtRegisterDate As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
