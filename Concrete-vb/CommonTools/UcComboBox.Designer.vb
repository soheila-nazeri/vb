<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcComboBox
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
        Me.cbo = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cbo
        '
        Me.cbo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo.FormattingEnabled = True
        Me.cbo.Location = New System.Drawing.Point(0, 0)
        Me.cbo.Name = "cbo"
        Me.cbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbo.Size = New System.Drawing.Size(120, 22)
        Me.cbo.TabIndex = 0
        '
        'UcComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbo)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "UcComboBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(120, 22)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
End Class
