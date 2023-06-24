Public Class frmPeople
    Private vDomain As New Domain
    Private vPeople As New people_dml
    Private vId As Long = 0
    Private vPeopleType As Enums.Keys.PeopleType
    Dim vmsg As New CommonTools.CustomeMessageBox
    Dim vErr As New CommonTools.ErrorCustomeMessageBox
    Private Names As String = ""
    Private LastName As String = ""
    Private FatherName As String = ""
    Private BirthDay As String = ""
    Private CertificateID As String = ""
    Private BirthPlace As String = ""
    Private ResidenceCity As String = ""
    Private BirthRegisterDate As String = ""
    Private BirthRegisterPlace As String = ""
    Private Sexuality As String = ""
    Private MaritalDate As String = ""
    Private Nationality As String = ""
    Private Job As String = ""
    Private WorkPlace As String = ""
    Private JobTellNo As String = ""
    Private Address As String = ""
    Private AccCode As String = ""
    Private Email As String = ""
    Private TelNo As String = ""
    Private Mobile As String = ""
    Private NationalCode As String = ""
    Private ZipCode As String = ""
    Public Property Id() As Long
        Get
            Return vId
        End Get
        Set(ByVal value As Long)
            Dim drInfo As DataRow = vPeople.Select(value).Rows(0)

            setData(drInfo)
        End Set
    End Property
    Public Sub New(ByVal dr As DataRow, ByVal PeopleType As Enums.Keys.PeopleType)
        InitializeComponent()
        vPeopleType = PeopleType
        cbSexuality.Initialize(vDomain.Select(Enums.DomainKeys.Gender), "ID", "TITLE")
        cbSexuality.SelectedValue = Enums.Keys.Gender.Male
        If Not dr Is Nothing Then
            setData(dr)
        End If
        picPicture.Tag = ""

        Utility.setFormObjectTitle("People", Me)
    End Sub
    Private Sub setData(ByVal dr As DataRow)
        vId = dr.Item("id")
        txtName.Text = dr.Item("FIRST_NAME")
        Names = dr.Item("FIRST_NAME")
        txtLastName.Text = dr.Item("LAST_NAME")
        LastName = dr.Item("LAST_NAME")
        txtFatherName.Text = Utility.NVL(dr("FATHER_NAME"), "")
        FatherName = Utility.NVL(dr("FATHER_NAME"), "")
        datBirthDay.Text = Utility.NVL((dr("BIRTHDAY")), "")
        BirthDay = Utility.NVL((dr("BIRTHDAY")), "")
        txtCertificateID.Text = Utility.NVL(dr("CERTIFICATE_NO"), "")
        CertificateID = Utility.NVL(dr("CERTIFICATE_NO"), "")
        txtBirthPlace.Text = Utility.NVL(dr("BIRTHPLACE"), 0)
        datBirthRegisterDate.Text = Utility.NVL(dr("REGISTER_DATE"), "")
        BirthRegisterDate = Utility.NVL(dr("REGISTER_DATE"), "")
        txtBirthRegisterPlace.Text = Utility.NVL(dr("REGISTER_PLACE"), 0)
        cbSexuality.SelectedValue = Utility.NVL(dr("GENDER"), Enums.Keys.Gender.Male)
        Sexuality = cbSexuality.Text
        datMaritalDate.Text = Utility.NVL(dr("MARITAL_DATE"), "")
        MaritalDate = Utility.NVL(dr("MARITAL_DATE"), "")
        txtWorkPlace.Text = Utility.NVL(dr("JOB_ADDRESS"), "")
        WorkPlace = Utility.NVL(dr("JOB_ADDRESS"), "")
        txtJobTellNo.Text = Utility.NVL(dr("JOB_TEL_NO"), "")
        JobTellNo = Utility.NVL(dr("JOB_TEL_NO"), "")
        txtAddress.Text = Utility.NVL(dr("ADDRESS"), "")
        Address = Utility.NVL(dr("ADDRESS"), "")
        txtEmail.Text = Utility.NVL(dr("EMAIL_ADDRESS"), "")
        Email = Utility.NVL(dr("EMAIL_ADDRESS"), "")
        txtTelNo.Text = Utility.NVL(dr("TEL_NO"), "")
        TelNo = Utility.NVL(dr("TEL_NO"), "")
        txtMobile.Text = Utility.NVL(dr("MOBILE_NO"), "")
        Mobile = Utility.NVL(dr("MOBILE_NO"), "")
        txtNationalCode.Text = Utility.NVL(dr.Item("NATIONAL_CODE"), "")
        NationalCode = Utility.NVL(dr.Item("NATIONAL_CODE"), "")
        txtZipCode.Text = Utility.NVL(dr.Item("ZIP_CODE"), "")
        ZipCode = Utility.NVL(dr.Item("ZIP_CODE"), "")
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim = "" Then
            System.Windows.Forms.MessageBox.Show(Utility.getMessage("کاربر گرامی لطفا نام را وارد نمائید"))
            txtName.Focus()
            Return
        End If

        If txtLastName.Text.Trim = "" Then
            System.Windows.Forms.MessageBox.Show(Utility.getMessage("کاربر گرامی لطفا نام خانوادگی را وارد نمائید"))
            txtLastName.Focus()
            Return
        End If
        Try
            SQL.BeginTransaction()
            vPeople.Reset()
            vPeople.Address = txtAddress.Text
            vPeople.Birthday = datBirthDay.Text
            vPeople.CertificateNo = txtCertificateID.Text.Trim
            vPeople.EmailAddress = txtEmail.Text.Trim
            vPeople.FatherName = txtFatherName.Text.Trim
            vPeople.FirstName = txtName.Text.Trim

            If cbSexuality.SelectedValue > 0 Then vPeople.Gender = cbSexuality.SelectedValue

            vPeople.JobAddress = txtWorkPlace.Text.Trim
            vPeople.JobTelNo = txtJobTellNo.Text
            vPeople.LastName = txtLastName.Text
            vPeople.MaritalDate = datMaritalDate.Text
            vPeople.MobileNo = txtMobile.Text.Trim
            vPeople.NationalCode = txtNationalCode.Text.Trim.Replace(" ", "")
            vPeople.RegisterDate = datBirthRegisterDate.Text
            If txtBirthRegisterPlace.Text <> "" Then vPeople.RegisterPlace = txtBirthRegisterPlace.Text
            If txtBirthPlace.Text <> "" Then vPeople.BirthPlace = txtBirthPlace.Text
            vPeople.TelNo = txtTelNo.Text.Trim
            vPeople.ZipCode = txtZipCode.Text.Trim
            vPeople.Type = vPeopleType
            If vId > 0 Then
                vPeople.Edit(vId, Nothing)
                '-----------------------------------------------------------
            Else
                vId = vPeople.Insert(Nothing)
            End If
            SQL.CommitTransaction()
            System.Windows.Forms.MessageBox.Show(Utility.getMessage("اطلاعات با موفقیت ثبت شد"), "ثبت")
        Catch ex As Exception
            SQL.RollbackTransaction()
            System.Windows.Forms.MessageBox.Show(Utility.getMessage(String.Format("خطا در ثبت {0} ", ex.ToString)), "توجه")
            Return
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnDeleteImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteImage.Click
        picPicture.Tag = "-1"
        picPicture.Image = Nothing
    End Sub

    Private Sub datBirthDay_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles datBirthDay.Validating
        datBirthRegisterDate.Text = datBirthDay.Text
    End Sub

    Private Sub frmPeople_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Utility.FocusNextControl(sender, e)

    End Sub
    
End Class