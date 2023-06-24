<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateBox
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
    Me.datDate = New System.Windows.Forms.TextBox
    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'datDate
    '
    Me.datDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.datDate.Location = New System.Drawing.Point(0, 0)
    Me.datDate.Name = "datDate"
    Me.datDate.Size = New System.Drawing.Size(150, 21)
    Me.datDate.TabIndex = 0
    Me.datDate.Text = "----/--/--"
    '
    'ErrorProvider1
    '
    Me.ErrorProvider1.ContainerControl = Me
    '
    'DateBox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.datDate)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Name = "DateBox"
    Me.Size = New System.Drawing.Size(150, 21)
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents datDate As System.Windows.Forms.TextBox
  Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
