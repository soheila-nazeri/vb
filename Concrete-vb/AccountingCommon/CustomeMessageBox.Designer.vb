<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomeMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomeMessageBox))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        Me.picQuestion = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMessage.Location = New System.Drawing.Point(73, 39)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMessage.Size = New System.Drawing.Size(285, 59)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "------------"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "کاربرگرامی"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.CommonTools.My.Resources.Resources.newexit
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(163, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 31)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "خروج"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picInfo
        '
        Me.picInfo.Image = CType(resources.GetObject("picInfo.Image"), System.Drawing.Image)
        Me.picInfo.Location = New System.Drawing.Point(13, 39)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(54, 56)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfo.TabIndex = 10
        Me.picInfo.TabStop = False
        '
        'picQuestion
        '
        Me.picQuestion.Image = CType(resources.GetObject("picQuestion.Image"), System.Drawing.Image)
        Me.picQuestion.Location = New System.Drawing.Point(12, 39)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(54, 52)
        Me.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuestion.TabIndex = 9
        Me.picQuestion.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Image = Global.CommonTools.My.Resources.Resources._select
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(261, 108)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(99, 31)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "تائید"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'CustomeMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(370, 146)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "CustomeMessageBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
End Class
