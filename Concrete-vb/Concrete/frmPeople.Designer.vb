<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeople
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.txtBirthRegisterPlace = New System.Windows.Forms.TextBox()
        Me.btnDeleteImage = New System.Windows.Forms.Button()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cbSexuality = New Concrete.mnComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.datMaritalDate = New Concrete.DateBox()
        Me.datBirthRegisterDate = New Concrete.DateBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtNationalCode = New System.Windows.Forms.TextBox()
        Me.datBirthDay = New Concrete.DateBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCertificateID = New System.Windows.Forms.TextBox()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtJobTellNo = New System.Windows.Forms.TextBox()
        Me.txtTelNo = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 465)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(827, 66)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Image = Global.Concrete.My.Resources.Resources.Del
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(649, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 41)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Image = Global.Concrete.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(735, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 41)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ثبت"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBirthPlace)
        Me.GroupBox1.Controls.Add(Me.txtBirthRegisterPlace)
        Me.GroupBox1.Controls.Add(Me.btnDeleteImage)
        Me.GroupBox1.Controls.Add(Me.btnAddImage)
        Me.GroupBox1.Controls.Add(Me.picPicture)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.cbSexuality)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.datMaritalDate)
        Me.GroupBox1.Controls.Add(Me.datBirthRegisterDate)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.txtNationalCode)
        Me.GroupBox1.Controls.Add(Me.datBirthDay)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtCertificateID)
        Me.GroupBox1.Controls.Add(Me.txtWorkPlace)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtJobTellNo)
        Me.GroupBox1.Controls.Add(Me.txtTelNo)
        Me.GroupBox1.Controls.Add(Me.txtFatherName)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label73)
        Me.GroupBox1.Controls.Add(Me.Label77)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label74)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 465)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthPlace.Location = New System.Drawing.Point(520, 222)
        Me.txtBirthPlace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBirthPlace.Size = New System.Drawing.Size(172, 26)
        Me.txtBirthPlace.TabIndex = 6
        '
        'txtBirthRegisterPlace
        '
        Me.txtBirthRegisterPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthRegisterPlace.Location = New System.Drawing.Point(520, 289)
        Me.txtBirthRegisterPlace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBirthRegisterPlace.Name = "txtBirthRegisterPlace"
        Me.txtBirthRegisterPlace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBirthRegisterPlace.Size = New System.Drawing.Size(172, 26)
        Me.txtBirthRegisterPlace.TabIndex = 8
        '
        'btnDeleteImage
        '
        Me.btnDeleteImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteImage.Image = Global.Concrete.My.Resources.Resources.Del
        Me.btnDeleteImage.Location = New System.Drawing.Point(220, 343)
        Me.btnDeleteImage.Name = "btnDeleteImage"
        Me.btnDeleteImage.Size = New System.Drawing.Size(30, 30)
        Me.btnDeleteImage.TabIndex = 190
        Me.btnDeleteImage.TabStop = False
        Me.btnDeleteImage.UseVisualStyleBackColor = True
        Me.btnDeleteImage.Visible = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddImage.Image = Global.Concrete.My.Resources.Resources.add
        Me.btnAddImage.Location = New System.Drawing.Point(184, 343)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(30, 30)
        Me.btnAddImage.TabIndex = 189
        Me.btnAddImage.TabStop = False
        Me.btnAddImage.UseVisualStyleBackColor = True
        Me.btnAddImage.Visible = False
        '
        'picPicture
        '
        Me.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPicture.Location = New System.Drawing.Point(12, 190)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(177, 182)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicture.TabIndex = 188
        Me.picPicture.TabStop = False
        Me.picPicture.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(698, 427)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 18)
        Me.Label18.TabIndex = 182
        Me.Label18.Text = "آدرس"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(25, 424)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAddress.Size = New System.Drawing.Size(667, 26)
        Me.txtAddress.TabIndex = 23
        '
        'cbSexuality
        '
        Me.cbSexuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSexuality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbSexuality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSexuality.Location = New System.Drawing.Point(520, 324)
        Me.cbSexuality.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSexuality.Name = "cbSexuality"
        Me.cbSexuality.Size = New System.Drawing.Size(172, 26)
        Me.cbSexuality.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(25, 390)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(667, 26)
        Me.txtEmail.TabIndex = 22
        '
        'datMaritalDate
        '
        Me.datMaritalDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datMaritalDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.datMaritalDate.Location = New System.Drawing.Point(521, 358)
        Me.datMaritalDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datMaritalDate.Name = "datMaritalDate"
        Me.datMaritalDate.PromptInclude = True
        Me.datMaritalDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datMaritalDate.Size = New System.Drawing.Size(171, 24)
        Me.datMaritalDate.TabIndex = 10
        '
        'datBirthRegisterDate
        '
        Me.datBirthRegisterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datBirthRegisterDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.datBirthRegisterDate.Location = New System.Drawing.Point(521, 258)
        Me.datBirthRegisterDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datBirthRegisterDate.Name = "datBirthRegisterDate"
        Me.datBirthRegisterDate.PromptInclude = True
        Me.datBirthRegisterDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datBirthRegisterDate.Size = New System.Drawing.Size(171, 24)
        Me.datBirthRegisterDate.TabIndex = 7
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobile.Location = New System.Drawing.Point(193, 86)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(203, 26)
        Me.txtMobile.TabIndex = 16
        '
        'txtNationalCode
        '
        Me.txtNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNationalCode.Location = New System.Drawing.Point(521, 156)
        Me.txtNationalCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNationalCode.Name = "txtNationalCode"
        Me.txtNationalCode.Size = New System.Drawing.Size(171, 26)
        Me.txtNationalCode.TabIndex = 4
        '
        'datBirthDay
        '
        Me.datBirthDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datBirthDay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.datBirthDay.Location = New System.Drawing.Point(521, 190)
        Me.datBirthDay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datBirthDay.Name = "datBirthDay"
        Me.datBirthDay.PromptInclude = True
        Me.datBirthDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datBirthDay.Size = New System.Drawing.Size(171, 24)
        Me.datBirthDay.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(520, 17)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 26)
        Me.txtName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.Location = New System.Drawing.Point(520, 50)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(172, 26)
        Me.txtLastName.TabIndex = 1
        '
        'txtCertificateID
        '
        Me.txtCertificateID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCertificateID.Location = New System.Drawing.Point(520, 118)
        Me.txtCertificateID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCertificateID.Name = "txtCertificateID"
        Me.txtCertificateID.Size = New System.Drawing.Size(172, 26)
        Me.txtCertificateID.TabIndex = 3
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWorkPlace.Location = New System.Drawing.Point(193, 14)
        Me.txtWorkPlace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(203, 26)
        Me.txtWorkPlace.TabIndex = 14
        '
        'txtZipCode
        '
        Me.txtZipCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtZipCode.Location = New System.Drawing.Point(193, 154)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(203, 26)
        Me.txtZipCode.TabIndex = 18
        '
        'txtJobTellNo
        '
        Me.txtJobTellNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJobTellNo.Location = New System.Drawing.Point(193, 120)
        Me.txtJobTellNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJobTellNo.Name = "txtJobTellNo"
        Me.txtJobTellNo.Size = New System.Drawing.Size(203, 26)
        Me.txtJobTellNo.TabIndex = 17
        '
        'txtTelNo
        '
        Me.txtTelNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelNo.Location = New System.Drawing.Point(193, 52)
        Me.txtTelNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(203, 26)
        Me.txtTelNo.TabIndex = 15
        '
        'txtFatherName
        '
        Me.txtFatherName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFatherName.Location = New System.Drawing.Point(520, 84)
        Me.txtFatherName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(172, 26)
        Me.txtFatherName.TabIndex = 2
        '
        'Label66
        '
        Me.Label66.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(698, 325)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(58, 18)
        Me.Label66.TabIndex = 160
        Me.Label66.Text = "جنسيت"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(698, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "نام"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(698, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "نام خانوادگي"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(698, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "ش. شناسنامه"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(698, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "محل صدور"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(698, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "تاریخ ازدواج"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(698, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "تاريخ صدور"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(698, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 18)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "محل تولد"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(698, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "نام پدر"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(698, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 174
        Me.Label12.Text = "تاريخ تولد"
        '
        'Label73
        '
        Me.Label73.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(403, 89)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(89, 18)
        Me.Label73.TabIndex = 187
        Me.Label73.Text = "شماره همراه"
        '
        'Label77
        '
        Me.Label77.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label77.Location = New System.Drawing.Point(698, 157)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(122, 17)
        Me.Label77.TabIndex = 186
        Me.Label77.Text = "کد ملی/ش گذرنامه"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(403, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 18)
        Me.Label14.TabIndex = 180
        Me.Label14.Text = "محل کار"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "کد پستی"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "تلفن محل کار"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(403, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 18)
        Me.Label16.TabIndex = 184
        Me.Label16.Text = "تلفن"
        '
        'Label74
        '
        Me.Label74.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(698, 393)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(104, 18)
        Me.Label74.TabIndex = 185
        Me.Label74.Text = "پست الکترونيک"
        '
        'frmPeople
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "frmPeople"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "مشخصات افراد"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbSexuality As mnComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents datBirthRegisterDate As DateBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtNationalCode As System.Windows.Forms.TextBox
    Friend WithEvents datBirthDay As DateBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCertificateID As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtJobTellNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datMaritalDate As DateBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteImage As System.Windows.Forms.Button
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtBirthRegisterPlace As TextBox
    Friend WithEvents txtBirthPlace As TextBox
End Class
