<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcGrid
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
        Me.txtGrid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGrid
        '
        Me.txtGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrid.Location = New System.Drawing.Point(0, 0)
        Me.txtGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrid.Name = "txtGrid"
        Me.txtGrid.Size = New System.Drawing.Size(192, 22)
        Me.txtGrid.TabIndex = 0
        '
        'UcGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtGrid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcGrid"
        Me.Size = New System.Drawing.Size(192, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGrid As System.Windows.Forms.TextBox

End Class
