<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcEmploymentCode
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPeopleList = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtEmploymentCode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPeopleList)
        Me.Panel1.Controls.Add(Me.lblFullName)
        Me.Panel1.Controls.Add(Me.txtEmploymentCode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 23)
        Me.Panel1.TabIndex = 0
        '
        'btnPeopleList
        '
        Me.btnPeopleList.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPeopleList.Location = New System.Drawing.Point(1, 0)
        Me.btnPeopleList.Name = "btnPeopleList"
        Me.btnPeopleList.Size = New System.Drawing.Size(30, 23)
        Me.btnPeopleList.TabIndex = 1
        Me.btnPeopleList.TabStop = False
        Me.btnPeopleList.Text = "..."
        Me.btnPeopleList.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFullName.ForeColor = System.Drawing.Color.Red
        Me.lblFullName.Location = New System.Drawing.Point(31, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(321, 23)
        Me.lblFullName.TabIndex = 28
        '
        'txtEmploymentCode
        '
        Me.txtEmploymentCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtEmploymentCode.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtEmploymentCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtEmploymentCode.Location = New System.Drawing.Point(352, 0)
        Me.txtEmploymentCode.Name = "txtEmploymentCode"
        Me.txtEmploymentCode.Size = New System.Drawing.Size(66, 27)
        Me.txtEmploymentCode.TabIndex = 0
        '
        'UcEmploymentCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "UcEmploymentCode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(418, 23)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents btnPeopleList As System.Windows.Forms.Button
    Public WithEvents txtEmploymentCode As System.Windows.Forms.TextBox
End Class
