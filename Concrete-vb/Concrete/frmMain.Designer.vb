<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPersonelList = New System.Windows.Forms.Button()
        Me.btnRequesterList = New System.Windows.Forms.Button()
        Me.btnEmployerList = New System.Windows.Forms.Button()
        Me.btnConcertList = New System.Windows.Forms.Button()
        Me.btnFinanceCycles = New System.Windows.Forms.Button()
        Me.btnAllPeople = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPersonelList
        '
        Me.btnPersonelList.Location = New System.Drawing.Point(936, 519)
        Me.btnPersonelList.Name = "btnPersonelList"
        Me.btnPersonelList.Size = New System.Drawing.Size(177, 38)
        Me.btnPersonelList.TabIndex = 0
        Me.btnPersonelList.Text = "Personal List"
        Me.btnPersonelList.UseVisualStyleBackColor = True
        '
        'btnRequesterList
        '
        Me.btnRequesterList.Location = New System.Drawing.Point(936, 563)
        Me.btnRequesterList.Name = "btnRequesterList"
        Me.btnRequesterList.Size = New System.Drawing.Size(177, 38)
        Me.btnRequesterList.TabIndex = 1
        Me.btnRequesterList.Text = "Requester List"
        Me.btnRequesterList.UseVisualStyleBackColor = True
        '
        'btnEmployerList
        '
        Me.btnEmployerList.Location = New System.Drawing.Point(936, 607)
        Me.btnEmployerList.Name = "btnEmployerList"
        Me.btnEmployerList.Size = New System.Drawing.Size(177, 38)
        Me.btnEmployerList.TabIndex = 2
        Me.btnEmployerList.Text = "Employer List"
        Me.btnEmployerList.UseVisualStyleBackColor = True
        '
        'btnConcertList
        '
        Me.btnConcertList.Location = New System.Drawing.Point(43, 651)
        Me.btnConcertList.Name = "btnConcertList"
        Me.btnConcertList.Size = New System.Drawing.Size(177, 38)
        Me.btnConcertList.TabIndex = 3
        Me.btnConcertList.Text = "Factor List"
        Me.btnConcertList.UseVisualStyleBackColor = True
        '
        'btnFinanceCycles
        '
        Me.btnFinanceCycles.Location = New System.Drawing.Point(43, 607)
        Me.btnFinanceCycles.Name = "btnFinanceCycles"
        Me.btnFinanceCycles.Size = New System.Drawing.Size(177, 38)
        Me.btnFinanceCycles.TabIndex = 7
        Me.btnFinanceCycles.Text = "Finance Cycle"
        Me.btnFinanceCycles.UseVisualStyleBackColor = True
        '
        'btnAllPeople
        '
        Me.btnAllPeople.Location = New System.Drawing.Point(936, 651)
        Me.btnAllPeople.Name = "btnAllPeople"
        Me.btnAllPeople.Size = New System.Drawing.Size(177, 38)
        Me.btnAllPeople.TabIndex = 8
        Me.btnAllPeople.Text = "All People List"
        Me.btnAllPeople.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(343, 309)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(452, 380)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(679, 58)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(434, 416)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '

        Me.PictureBox1.Location = New System.Drawing.Point(43, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 401)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 715)
        Me.Controls.Add(Me.btnAllPeople)
        Me.Controls.Add(Me.btnFinanceCycles)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConcertList)
        Me.Controls.Add(Me.btnEmployerList)
        Me.Controls.Add(Me.btnRequesterList)
        Me.Controls.Add(Me.btnPersonelList)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concrete App"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPersonelList As Button
    Friend WithEvents btnRequesterList As Button
    Friend WithEvents btnEmployerList As Button
    Friend WithEvents btnConcertList As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnFinanceCycles As Button
    Friend WithEvents btnAllPeople As Button
End Class
