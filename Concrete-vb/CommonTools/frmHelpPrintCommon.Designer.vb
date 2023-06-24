<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpPrintCommon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelpPrintCommon))
        Me.btnExit = New System.Windows.Forms.Button
        Me.picInfo = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.CommonTools.My.Resources.Resources.newexit
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(4, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 31)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "خروج"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picInfo
        '
        Me.picInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picInfo.Image = CType(resources.GetObject("picInfo.Image"), System.Drawing.Image)
        Me.picInfo.Location = New System.Drawing.Point(4, 22)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(69, 63)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfo.TabIndex = 16
        Me.picInfo.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55024!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44976!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label26, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label27, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(89, 128)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(290, 43)
        Me.TableLayoutPanel3.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Location = New System.Drawing.Point(103, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(184, 21)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "حرکت بین کنترل ها"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Location = New System.Drawing.Point(3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(94, 21)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "TAB - ENTER"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(103, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(184, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "خروج "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(94, 22)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "ESC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.25387!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.74613!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(89, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(290, 75)
        Me.TableLayoutPanel1.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(101, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(186, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "انتخاب "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "F8"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(3, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(92, 20)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "F6"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(101, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(186, 20)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "به روز رسانی"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(101, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(186, 20)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "حذف فیلتر"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "F5"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label29.Size = New System.Drawing.Size(92, 15)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "CTRL + p"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Location = New System.Drawing.Point(101, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label30.Size = New System.Drawing.Size(186, 15)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "چاپ"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(230, 102)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(148, 16)
        Me.Label28.TabIndex = 49
        Me.Label28.Text = "لیست کلید های عمومی "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(282, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "کلید های میانبر "
        '
        'frmHelpPrintCommon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(391, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelpPrintCommon"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "راهنما"
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
