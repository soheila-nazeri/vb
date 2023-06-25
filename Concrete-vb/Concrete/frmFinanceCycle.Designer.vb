<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceCycle
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.txtToDate = New mnComponents.DateBox()
        Me.txtFromDate = New mnComponents.DateBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 36)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkStatus)
        Me.Panel2.Controls.Add(Me.txtToDate)
        Me.Panel2.Controls.Add(Me.txtFromDate)
        Me.Panel2.Controls.Add(Me.txtTitle)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 150)
        Me.Panel2.TabIndex = 0
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(105, 110)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(71, 22)
        Me.chkStatus.TabIndex = 3
        Me.chkStatus.Text = "Status"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'txtToDate
        '
        Me.txtToDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtToDate.Location = New System.Drawing.Point(105, 78)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.PromptInclude = True
        Me.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtToDate.Size = New System.Drawing.Size(100, 26)
        Me.txtToDate.TabIndex = 2
        '
        'txtFromDate
        '
        Me.txtFromDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(105, 50)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.PromptInclude = True
        Me.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFromDate.Size = New System.Drawing.Size(100, 26)
        Me.txtFromDate.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 22)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 26)
        Me.txtTitle.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(89, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 36)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancle  Esc"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Left

        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.Location = New System.Drawing.Point(0, 0)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(89, 36)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok F9"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'frmFinanceCycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 186)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmFinanceCycle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinanceCycle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtToDate As mnComponents.DateBox
    Friend WithEvents txtFromDate As mnComponents.DateBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
End Class
