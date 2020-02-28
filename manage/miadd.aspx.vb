Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports URDAL
Partial Class manage_miadd
    Inherits System.Web.UI.Page
    Dim CertId As Integer
    Dim stask As String

    Dim mypanel2text As String = ""
    Dim mypanel3text As String = ""
    Dim mypanel5text As String = ""
    Dim mypanel6text As String = ""
    Dim mypanel8text As String = ""

#Region "Page_Load"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            C21MIT.METROINI.BLL.gcadminacc.EnsureAdminAccess()
            'register client script for all bullet operation buttons
            '
            'ADMISSION REQUIREMENTS START
            btnDelete2.Attributes.Add("onclick", "showMessage('" & gvAdmissionReq.ClientID & "','Please select a row to delete')")
            btnUpdate2.Attributes.Add("onclick", "showMessage('" & gvAdmissionReq.ClientID & "','Please select a row to update the content')")
            'ADMISSION REQUIREMENTS END

            'APPLICATION REQUIREMENTS START
            btnDelete3.Attributes.Add("onclick", "showMessage('" & gvApplicationReq.ClientID & "','Please select a row to delete')")
            btnUpdate3.Attributes.Add("onclick", "showMessage('" & gvApplicationReq.ClientID & "','Please select a row to update the content')")
            'APPLICATION REQUIREMENTS END

            ' REQUIRED COURSES START
            btnDelete5.Attributes.Add("onclick", "showMessage('" & gvReqCourses.ClientID & "','Please select a row to delete')")
            btnUpdate5.Attributes.Add("onclick", "showMessage('" & gvReqCourses.ClientID & "','Please select a row to update the content')")
            'REQUIRED COURSES END

            ' ELECTIVE COURSES START
            btnDelete6.Attributes.Add("onclick", "showMessage('" & gvElecCourses.ClientID & "','Please select a row to delete')")
            btnUpdate6.Attributes.Add("onclick", "showMessage('" & gvElecCourses.ClientID & "','Please select a row to update the content')")
            'ELECTIVE COURSES END


            ' ELECTIVE COURSES START
            btnDelete8.Attributes.Add("onclick", "showMessage('" & gvPrerequisites.ClientID & "','Please select a row to delete')")
            btnUpdate8.Attributes.Add("onclick", "showMessage('" & gvPrerequisites.ClientID & "','Please select a row to update the content')")
            'ELECTIVE COURSES END

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")
                '  stask = "AddNew"
                If stask = "AddNew" Then
                    Panel2.Enabled = False
                    Panel3.Enabled = False
                    Panel4.Enabled = False
                    Panel5.Enabled = False
                    Panel6.Enabled = False
                    Panel7.Enabled = False
                    Panel8.Enabled = False
                    lblsubmit.ForeColor = Drawing.Color.Red
                    'Bind all the PANELS
                    bindPanel("PANEL 1", stask)

                    'ADMISSION REQUIREMENTS START
                    bindPanel("PANEL 2", stask)
                    'ADMISSION REQUIREMENTS END

                    'APPLICATION REQUIREMENTS START
                    bindPanel("PANEL 3", stask)
                    'APPLICATION REQUIREMENTS END

                    'CONTACTS START
                    bindPanel("PANEL 4", stask)
                    'CONTACTS END

                    'REQ COURSES START
                    bindPanel("PANEL 5", stask)
                    'REQ COURSES END

                    'ELEC COURSES START
                    '  bindPanel6(stask)
                    bindPanel("PANEL 6", stask)
                    'ELEC COURSES END


                    'PREREQUISITES START
                    '  bindPanel6(stask)
                    bindPanel("PANEL 8", stask)
                    'PREREQUISITES COURSES END
                ElseIf stask = "Edit" Then
                    'Bind all the PANELS

                    ''   TabPanel7.Visible = False
                    'Bind the current status to the dropdown
                    Dim gcbindcertstatustoddl As New C21MIT.METROINI.BO.gcstatusobject.gcStatusObjList
                    'Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(Request.QueryString("certid"))
                    ddlActiveInactive.SelectedValue = C21MIT.METROINI.DAL.gcmanage.getData(Request.QueryString("certid")).Tables(7).Rows(0).Item(3)


                    btnCheckCertificateAvail.Visible = False

                    Session("certificatename") = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(Request.QueryString("certid")).Item(0).certificatename
                    lblCerName.Text = Session("certificatename")

                    'TITLE DETAILS START
                    bindPanel("PANEL 1", stask, Request.QueryString("certid"))
                    'TITLE DETAILS START

                    'ADMISSION REQUIREMENTS START
                    gvAdmissionReq.Clear()
                    bindPanel("PANEL 2", stask, Request.QueryString("certid"))
                    '  btnSubmit2.Enabled = False
                    'ADMISSION REQUIREMENTS END

                    'APPLICATION REQUIREMENTS START
                    gvApplicationReq.Clear()
                    bindPanel("PANEL 3", stask, Request.QueryString("certid"))
                    ' btnSubmit3.Enabled = False
                    'APPLICATION REQUIREMENTS END

                    'CONTACTS START
                    bindPanel("PANEL 4", stask, Request.QueryString("certid"))
                    ' btnSubmit4.Enabled = False
                    'CONTACTS END

                    'REQ COURSES START
                    gvReqCourses.Clear()
                    bindPanel("PANEL 5", stask, Request.QueryString("certid"))
                    ' btnSubmit5.Enabled = False
                    'REQ COURSES END

                    'ELEC COURSES START
                    gvElecCourses.Clear()
                    bindPanel("PANEL 6", stask, Request.QueryString("certid"))
                    ' btnSubmit6.Enabled = False
                    'ELEC COURSES END


                    'ELEC COURSES START
                    gvPrerequisites.Clear()
                    bindPanel("PANEL 8", stask, Request.QueryString("certid"))
                    ' btnSubmit6.Enabled = False
                    'ELEC COURSES END

                ElseIf stask = "Pending" Then
                    btnCheckCertificateAvail.Visible = False

                    lblsubmit.ForeColor = Drawing.Color.Red

                    Session("certificatename") = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(Request.QueryString("certid")).Item(0).certificatename
                    lblCerName.Text = Session("certificatename")




                    'TITLE DETAILS START
                    bindPanel("PANEL 1", stask, Request.QueryString("certid"))
                    'TITLE DETAILS START

                    'ADMISSION REQUIREMENTS START
                    gvAdmissionReq.Clear()
                    bindPanel("PANEL 2", stask, Request.QueryString("certid"))
                    'ADMISSION REQUIREMENTS END

                    'APPLICATION REQUIREMENTS START
                    gvApplicationReq.Clear()
                    bindPanel("PANEL 3", stask, Request.QueryString("certid"))
                    'APPLICATION REQUIREMENTS END

                    'CONTACTS START
                    bindPanel("PANEL 4", stask, Request.QueryString("certid"))
                    'CONTACTS END

                    'REQ COURSES START
                    gvReqCourses.Clear()
                    bindPanel("PANEL 5", stask, Request.QueryString("certid"))
                    'REQ COURSES END

                    'ELEC COURSES START
                    gvElecCourses.Clear()
                    bindPanel("PANEL 6", stask, Request.QueryString("certid"))
                    'ELEC COURSES END

                    'ELEC COURSES START
                    gvPrerequisites.Clear()
                    bindPanel("PANEL 8", stask, Request.QueryString("certid"))
                    'ELEC COURSES END
                End If
            Else

            End If
        End If
    End Sub

#End Region

#Region "PANEL 1"
    Protected Sub binpanel1data(Optional ByVal certid As Integer = 0)
        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatecode Is Nothing Then
            txtcertcode.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatecode
        Else
            txtcertcode.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatename Is Nothing Then
            txtCertName.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatename
        Else
            txtCertName.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).collegecode Is Nothing Then
            ddlCollegeCode.SelectedValue = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).collegecode
        Else
            ddlCollegeCode.SelectedValue = "0"
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).linkname Is Nothing Then
            txtLinkName.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).linkname
        Else
            txtLinkName.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatetitle Is Nothing Then
            txtCertTitle.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certificatetitle
        Else
            txtCertTitle.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).courselocation Is Nothing Then
            txtCourseLoc.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).courselocation
        Else
            txtCourseLoc.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).briefdesc Is Nothing Then
            txtBriefDesc.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).briefdesc
        Else
            txtBriefDesc.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).CEU Is Nothing Then
            txtCEU.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).CEU
        Else
            txtCEU.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).credittograd Is Nothing Then
            txtCreditTo.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).credittograd
        Else
            txtCreditTo.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).transfercredit Is Nothing Then
            txtTransferCredit.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).transfercredit
        Else
            txtTransferCredit.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).standardtests Is Nothing Then
            txtStandardizedtests.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).standardtests
        Else
            txtStandardizedtests.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).prerequisites Is Nothing Then
            txtPrereqs.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).prerequisites
        Else
            txtPrereqs.Text = ""
        End If


        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).admissionreq Is Nothing Then
            txtAdmissionReq.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).admissionreq
        Else
            txtAdmissionReq.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).appprocess Is Nothing Then
            txtAppReqDetails.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).appprocess
        Else
            txtAppReqDetails.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).registrationprocess Is Nothing Then
            txtRegProcess.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).registrationprocess
        Else
            txtRegProcess.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).tuitionfees Is Nothing Then
            txtTutionandFees.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).tuitionfees
        Else
            txtTutionandFees.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).financialaid Is Nothing Then
            txtFinancialAid.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).financialaid
        Else
            txtFinancialAid.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).timelimit Is Nothing Then
            txtTimeLimit.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).timelimit
        Else
            txtTimeLimit.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).deptwebsite Is Nothing Then
            txtDeptWebsite.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).deptwebsite
        Else
            txtDeptWebsite.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).requiredcourseinfo Is Nothing Then
            txtRequiredCourseInfo.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).requiredcourseinfo
        Else
            txtRequiredCourseInfo.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).electivecourseinfo Is Nothing Then
            txtElectiveCourseInfo.Text = C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).electivecourseinfo
        Else
            txtElectiveCourseInfo.Text = ""
        End If

        If Not C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certtype Is Nothing Then
            If C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certtype = "GC" Then
                rdGP.Checked = True
            ElseIf C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certtype = "FOC" Then
                rdFOGP.Checked = True
            ElseIf C21MIT.METROINI.BLL.mimanage.getTitleDetailsList(certid).Item(0).certtype = "POC" Then
                rdPOGP.Checked = True
            End If
        End If
    End Sub

    Protected Sub btnUpdateTitleDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateTitleDetails.Click
        If chechcertavailablity(Request.QueryString("certid"), txtcertcode.Text.Trim) >= 1 Then
            txtcertcode.Focus()
            rf1.Visible = True
        Else
            rf1.Visible = False
            lblfinal1.ForeColor = Drawing.Color.Red
            lblfinal1.Text = "Form updated successfully."
            lblfinal1.Focus()
            stask = Request.QueryString("task")
            updatepanel1(stask)
        End If

    End Sub

    Protected Sub updatepanel1(ByVal stask As String)
        If stask = "AddNew" Then
            btnCheckCertificateAvail.CausesValidation = True
            ''comment this later
            updatepanel1data(Session("currentcert"))
        ElseIf stask = "Edit" Then
            btnCheckCertificateAvail.CausesValidation = False
            updatepanel1data(Request.QueryString("certid"))
        ElseIf stask = "Pending" Then
            btnCheckCertificateAvail.CausesValidation = False
            updatepanel1data(Request.QueryString("certid"))
        End If
    End Sub

    Protected Sub updatepanel1data(ByVal certid As Integer)
        Dim objtitledesc As New C21MIT.METROINI.BO.gctitledetailsobject
        objtitledesc.hid = certid
        objtitledesc.certificatecode = txtcertcode.Text.Trim
        objtitledesc.certificatename = txtCertName.Text
        objtitledesc.collegecode = ddlCollegeCode.SelectedItem.Value
        objtitledesc.linkname = txtLinkName.Text
        objtitledesc.certificatetitle = txtCertTitle.Text
        objtitledesc.courselocation = txtCourseLoc.Text
        objtitledesc.briefdesc = txtBriefDesc.Text
        objtitledesc.CEU = txtCEU.Text
        objtitledesc.credittograd = txtCreditTo.Text
        objtitledesc.transfercredit = txtTransferCredit.Text
        objtitledesc.standardtests = txtStandardizedtests.Text

        objtitledesc.prerequisites = txtPrereqs.Text

        objtitledesc.admissionreq = txtAdmissionReq.Text
        objtitledesc.appprocess = txtAppReqDetails.Text
        objtitledesc.registrationprocess = txtRegProcess.Text
        objtitledesc.tuitionfees = txtTutionandFees.Text
        objtitledesc.financialaid = txtFinancialAid.Text
        objtitledesc.timelimit = txtTimeLimit.Text
        objtitledesc.deptwebsite = txtDeptWebsite.Text
        objtitledesc.requiredcourseinfo = txtRequiredCourseInfo.Text
        objtitledesc.electivecourseinfo = txtElectiveCourseInfo.Text
        If rdGP.Checked Then
            objtitledesc.certtype = "GC"
        ElseIf rdFOGP.Checked Then
            objtitledesc.certtype = "FOC"
        ElseIf rdPOGP.Checked Then
            objtitledesc.certtype = "POC"
        End If
        C21MIT.METROINI.BLL.miupdateinserttitledetails.updateinserttitledetails(objtitledesc)
    End Sub

    Protected Sub btnSaveTitleDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveTitleDetails.Click
        'Insert data in the table


        If Not Page.IsPostBack Then
            If chechcertavailablity(Request.QueryString("certid"), txtcertcode.Text.Trim) = 1 Then
                Panel2.Enabled = True
                Panel3.Enabled = True
                Panel4.Enabled = True
                Panel5.Enabled = True
                Panel6.Enabled = True
                Panel7.Enabled = True
                Panel8.Enabled = True
                ' lblfinal1.Text = "Please select a different certificate code."
                txtcertcode.Focus()
                rf1.Visible = True
                'UPDATE DATA HERE.
                updatepanel1("AddNew")
                txtcertcode.Enabled = False
                btnCheckCertificateAvail.Enabled = False
            Else
                Panel2.Enabled = True
                Panel3.Enabled = True
                Panel4.Enabled = True
                Panel5.Enabled = True
                Panel6.Enabled = True
                Panel7.Enabled = True
                Panel8.Enabled = True
                inserttitledetails()
                lblfinal1.Visible = False
                rf1.Visible = False
                lblMes1.Text = "The details have been saved."
                lblMes1.ForeColor = Drawing.Color.Red
                lblMes1.Focus()
                txtcertcode.Enabled = False
                btnCheckCertificateAvail.Enabled = False
            End If
        Else
            If chechcertavailablity(Request.QueryString("certid"), txtcertcode.Text.Trim) = 1 Then

                Panel2.Enabled = True
                Panel3.Enabled = True
                Panel4.Enabled = True
                Panel5.Enabled = True
                Panel6.Enabled = True
                Panel7.Enabled = True
                Panel8.Enabled = True

                If Session("boolOnce") = "True" Then
                    'UPDATE DATA HERE.
                    updatepanel1("AddNew")
                    txtcertcode.Enabled = True
                    btnCheckCertificateAvail.Enabled = True
                    lblfinal1.Visible = False
                    Exit Sub
                End If

                rf1.Visible = True
                rf1.Text = "This certificate code already exists. Please select a different code."
                lblfinal1.Text = "Please select a different certificate code."
                txtcertcode.Focus()
                ' updatepanel1("AddNew")
                txtcertcode.Enabled = True
                btnCheckCertificateAvail.Enabled = True
                Session("boolOnce") = "True"
                Exit Sub

            Else
                Panel2.Enabled = True
                Panel3.Enabled = True
                Panel4.Enabled = True
                Panel5.Enabled = True
                Panel6.Enabled = True
                Panel7.Enabled = True
                Panel8.Enabled = True


                'Session("boolAddedO")
                inserttitledetails()
                lblfinal1.Visible = False
                rf1.Visible = False
                lblcertavailablitymsg.Visible = False
                lblMes1.Text = "The details have been saved."
                lblMes1.ForeColor = Drawing.Color.Red
                lblMes1.Focus()
                txtcertcode.Enabled = False
                btnCheckCertificateAvail.Enabled = False
                Panel1.Enabled = False
            End If
        End If
       

        'lblMes1.Text = "The details have been saved."
        'try inserting one record here with the sessionid as hcertificatedetails
        'If Not Session("currentcert") Is Nothing Then
        '    If Session("insertblankadmissionreq") = "true" Then
        '        Exit Sub
        '    End If
        '    Session("insertblankadmissionreq") = "true"
        'Else
        '    Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
        'End If
    End Sub

    Protected Function chechcertavailablity(Optional ByVal certid As Integer = 0, Optional ByVal certcode As String = "") As Integer
        Dim objcertcode As New C21MIT.METROINI.BO.gctitledetailsobject

        If certid > 0 Then
            objcertcode.hid = certid
        Else

        End If
        objcertcode.certificatecode = certcode

        Dim intCount As Integer
        intCount = C21MIT.METROINI.BLL.mimanage.fncheckCertificateAvailable(objcertcode)
        Return intCount
    End Function

    Protected Sub inserttitledetails()
        If chechcertavailablity(Request.QueryString("certid"), txtcertcode.Text.Trim) = 1 Then

            Panel2.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True
            Panel5.Enabled = True
            Panel6.Enabled = True
            Panel7.Enabled = True
            Panel8.Enabled = True
            Return
        ElseIf chechcertavailablity(Request.QueryString("certid"), txtcertcode.Text.Trim) = 0 Then
            insertdata1()
        End If
    End Sub

    Protected Sub insertdata1()
        Dim objtitledesc As New C21MIT.METROINI.BO.gctitledetailsobject

        objtitledesc.certificatecode = txtcertcode.Text.Trim
        objtitledesc.certificatename = txtCertName.Text
        objtitledesc.collegecode = ddlCollegeCode.SelectedItem.Value
        objtitledesc.linkname = txtLinkName.Text
        objtitledesc.certificatetitle = txtCertTitle.Text
        objtitledesc.courselocation = txtCourseLoc.Text
        objtitledesc.briefdesc = txtBriefDesc.Text
        objtitledesc.CEU = txtCEU.Text
        objtitledesc.credittograd = txtCreditTo.Text
        objtitledesc.transfercredit = txtTransferCredit.Text
        objtitledesc.standardtests = txtStandardizedtests.Text
        objtitledesc.prerequisites = txtPrereqs.Text
        objtitledesc.admissionreq = txtAdmissionReq.Text
        objtitledesc.appprocess = txtAppReqDetails.Text
        objtitledesc.registrationprocess = txtRegProcess.Text
        objtitledesc.tuitionfees = txtTutionandFees.Text
        objtitledesc.financialaid = txtFinancialAid.Text
        objtitledesc.timelimit = txtTimeLimit.Text
        objtitledesc.deptwebsite = txtDeptWebsite.Text
        objtitledesc.requiredcourseinfo = txtRequiredCourseInfo.Text
        objtitledesc.electivecourseinfo = txtElectiveCourseInfo.Text
        If rdGP.Checked Then
            objtitledesc.certtype = "GC"
        ElseIf rdFOGP.Checked Then
            objtitledesc.certtype = "FOC"
        ElseIf rdPOGP.Checked Then
            objtitledesc.certtype = "POC"
        End If

        Dim currentcert As Integer
        currentcert = C21MIT.METROINI.BLL.miinserttitledetails.inserttitledetails(objtitledesc)
        Session("currentcert") = currentcert

    End Sub
    Protected Sub btnCheckCertificateAvail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckCertificateAvail.Click
        chechcertificateavailablity(txtcertcode.Text.Trim)
    End Sub
    Protected Sub chechcertificateavailablity(ByVal certcode As String)
        'check whether the certificate code is already present
        Dim objcertcode As New C21MIT.METROINI.BO.gctitledetailsobject
        objcertcode.certificatecode = certcode

        Dim intCount As Integer
        intCount = C21MIT.METROINI.BLL.mimanage.fncheckCertificateAvailable(objcertcode)

        If intCount = 0 Then
            lblcertavailablitymsg.Visible = True
            lblcertavailablitymsg.ForeColor = Drawing.Color.Teal
            
            rf1.Visible = False
          
        ElseIf intCount = 1 Then
            txtcertcode.Focus()
            rf1.Visible = True
            lblcertavailablitymsg.Visible = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False
            Panel5.Enabled = False
            Panel6.Enabled = False
        End If
    End Sub
#End Region

#Region "PANEL 2"
    Protected Sub btnAdd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        Dim objPanel2 As New C21MIT.METROINI.BO.gcadmissionreqobj
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
        If btnAdd2.Text = "Add" Then
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objPanel2.hid = 1
                    objPanel2.hcertificatedetails = Session("currentcert")
                    objPanel2.admissionreqdocuments = ""
                ElseIf stask = "Edit" Then
                    objPanel2.hid = 1
                    objPanel2.hcertificatedetails = Request.QueryString("certid")
                    objPanel2.admissionreqdocuments = ""
                ElseIf stask = "Pending" Then
                    objPanel2.hid = 1
                    objPanel2.hcertificatedetails = Request.QueryString("certid")
                    objPanel2.admissionreqdocuments = ""
                End If
            End If

            gvAdmissionReq.DisplayLayout.Rows.Add()
            C21MIT.METROINI.DAL.miinserts.insertadmissionrequirements(objPanel2)
            UIOnAddClick2()

            If stask = "AddNew" Then
                bindPanel("PANEL 2", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 2", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 2", stask, Request.QueryString("certid"))
            End If
        Else
            objPanel2.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideleteadmissionreq.deleteadmissionreq(objPanel2)
            row.Delete()
            btnAdd2.Text = "Add"
        End If
    End Sub

    Protected Sub txtPanel2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox2 As TextBox = CType(sender, TextBox)
        mypanel2text = Server.HtmlEncode(txtbox2.Text)
    End Sub

    Protected Sub UIOnAddClick2()
        btnDelete2.Enabled = False
        btnUpdate2.Text = "Save"
        btnAdd2.Text = "Cancel"
    End Sub

    Protected Sub btnUpdate2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate2.Click
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
        row = gvAdmissionReq.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If

        If mypanel2text = "" Then
            Return
        Else
            Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
            objadmissionreq.hid = row.Cells.FromKey("hid").Value

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")
                If stask = "AddNew" Then
                    objadmissionreq.hcertificatedetails = Session("currentcert")
                    objadmissionreq.admissionreqdocuments = mypanel2text
                ElseIf stask = "Edit" Then

                    objadmissionreq.hcertificatedetails = Request.QueryString("certid")
                    objadmissionreq.admissionreqdocuments = mypanel2text
                ElseIf stask = "Pending" Then

                    objadmissionreq.hcertificatedetails = Request.QueryString("certid")
                    objadmissionreq.admissionreqdocuments = mypanel2text
                End If
            End If

            C21MIT.METROINI.BLL.miupdateinsertadmissionreq.updateinsertadmissionreq(objadmissionreq)
            UIOnAddSavedCanceled2()
        End If
    End Sub

    Protected Sub UIOnAddSavedCanceled2()
        btnDelete2.Enabled = True
        btnUpdate2.Text = "Update"
        btnAdd2.Text = "Add"
    End Sub

    Protected Sub UpdateStatus2(ByVal ColName As String, ByVal certid As Integer)
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcstatusobject

        objadmissionreq.hcertificatedetails = certid
        C21MIT.METROINI.BLL.migcstatus.updatestatus_OLD(ColName, objadmissionreq)
    End Sub

    Protected Sub btnDelete2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete2.Click
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvAdmissionReq.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If

        objadmissionreq.hid = row.Cells.FromKey("hid").Value
        C21MIT.METROINI.BLL.mideletes.mideleteadmissionreq.deleteadmissionreq(objadmissionreq)

        row.Delete()
    End Sub
#End Region

#Region "PANEL 3"
    Protected Sub txtPanel3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox3 As TextBox = CType(sender, TextBox)
        mypanel3text = Server.HtmlEncode(txtbox3.Text)
    End Sub

    Protected Sub btnAdd3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd3.Click
        Dim objPanel3 As New C21MIT.METROINI.BO.gcapplicationreqobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvApplicationReq.DisplayLayout.Rows(gvApplicationReq.Rows.Count - 1)
        If btnAdd3.Text = "Add" Then
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objPanel3.hid = 1
                    objPanel3.hcertificatedetails = Session("currentcert")
                    objPanel3.applicationrequirements = ""
                ElseIf stask = "Edit" Then
                    objPanel3.hid = 1
                    objPanel3.hcertificatedetails = Request.QueryString("certid")
                    objPanel3.applicationrequirements = ""
                ElseIf stask = "Pending" Then
                    objPanel3.hid = 1
                    objPanel3.hcertificatedetails = Request.QueryString("certid")
                    objPanel3.applicationrequirements = ""
                End If
            End If

            gvApplicationReq.DisplayLayout.Rows.Add()
            C21MIT.METROINI.DAL.miinserts.insertapplicationrequirements(objPanel3)
            UIOnAddClick3()

            If stask = "AddNew" Then
                bindPanel("PANEL 3", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 3", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 3", stask, Request.QueryString("certid"))
            End If
        Else
            objPanel3.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideleteapplicationreq.deleteapplicationreq(objPanel3)
            row.Delete()
            btnAdd3.Text = "Add"
        End If
    End Sub

    Protected Sub UIOnAddClick3()
        btnDelete3.Enabled = False
        btnUpdate3.Text = "Save"
        btnAdd3.Text = "Cancel"
    End Sub

    Protected Sub btnUpdate3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate3.Click

        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
        row = gvApplicationReq.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If

        If mypanel3text = "" Then
            Return
        Else
            Dim objapplicationreq As New C21MIT.METROINI.BO.gcapplicationreqobject
            objapplicationreq.hid = row.Cells.FromKey("hid").Value

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then

                    objapplicationreq.hcertificatedetails = Session("currentcert")
                    objapplicationreq.applicationrequirements = mypanel3text
                ElseIf stask = "Edit" Then

                    objapplicationreq.hcertificatedetails = Request.QueryString("certid")
                    objapplicationreq.applicationrequirements = mypanel3text
                ElseIf stask = "Pending" Then

                    objapplicationreq.hcertificatedetails = Request.QueryString("certid")
                    objapplicationreq.applicationrequirements = mypanel3text
                End If
            End If

            C21MIT.METROINI.BLL.miupdateinsertapplicationreq.updateinsertapplicationreq(objapplicationreq)
            UIOnAddSavedCanceled3()
        End If
    End Sub
    Protected Sub UIOnAddSavedCanceled3()
        btnDelete3.Enabled = True
        btnUpdate3.Text = "Update"
        btnAdd3.Text = "Add"
    End Sub

    Protected Sub UpdateStatus3(ByVal ColName As String, ByVal certid As Integer)
        Dim objapplicationreq As New C21MIT.METROINI.BO.gcstatusobject

        objapplicationreq.hcertificatedetails = certid
        C21MIT.METROINI.BLL.migcstatus.updatestatus_OLD(ColName, objapplicationreq)
    End Sub

    Protected Sub btnDelete3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete3.Click
        Dim objapplicationreq As New C21MIT.METROINI.BO.gcapplicationreqobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvApplicationReq.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If
        objapplicationreq.hid = row.Cells.FromKey("hid").Value
        C21MIT.METROINI.BLL.mideletes.mideleteapplicationreq.deleteapplicationreq(objapplicationreq)
        row.Delete()
    End Sub
#End Region

#Region "PANEL 4"
    Protected Sub save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles save.Click
        saveonclick()
        If Not (Request.QueryString("task") Is Nothing) Then
            stask = Request.QueryString("task")
            If stask = "AddNew" Then
                bindPanel("PANEL 4", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 4", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 4", stask, Request.QueryString("certid"))
            End If
        End If
    End Sub
    Public Sub saveonclick()
        Dim dgitem As GridViewRow

        For Each dgitem In gvcontacts.Rows
            Dim lblhid As Label = CType(dgitem.FindControl("pk"), Label)
            Dim lblcertid As Label = CType(dgitem.FindControl("cpk"), Label)
            Dim txtFName As TextBox = CType(dgitem.FindControl("txtFirstName"), TextBox)
            Dim txtLName As TextBox = CType(dgitem.FindControl("txtLastName"), TextBox)
            Dim txtPhone As TextBox = CType(dgitem.FindControl("txtPhone"), TextBox)
            Dim txtEmail As TextBox = CType(dgitem.FindControl("txtEmail"), TextBox)

            Dim flpic As FileUpload = CType(dgitem.FindControl("fl1"), FileUpload)


            Dim objContactsUpdate As New C21MIT.METROINI.BO.gccontactsobject

            objContactsUpdate.hid = lblhid.Text
            objContactsUpdate.hcertificatedetails = lblcertid.Text
            objContactsUpdate.firstname = txtFName.Text
            objContactsUpdate.lastname = txtLName.Text
            objContactsUpdate.phone = txtPhone.Text
            objContactsUpdate.email = txtEmail.Text

            C21MIT.METROINI.BLL.miupdateinsertcontacts.updateinsertcontacts(objContactsUpdate)

        Next
    End Sub
    'Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    ' Dim arrContent As Byte() = Nothing
    '    Dim objcontacts As New C21MIT.METROINI.BO.gccontactsobject
    '    If Not (Request.QueryString("task") Is Nothing) Then
    '        stask = Request.QueryString("task")
    '        If stask = "AddNew" Then
    '            objcontacts.hcertificatedetails = Session("currentcert")
    '        ElseIf stask = "Edit" Then
    '            objcontacts.hcertificatedetails = Request.QueryString("certid")
    '        ElseIf stask = "Pending" Then
    '            objcontacts.hcertificatedetails = Request.QueryString("certid")

    '        End If
    '    End If

    '    If txtFirstName.Text <> "" Then
    '        objcontacts.firstname = txtFirstName.Text
    '    End If

    '    If txtLastName.Text <> "" Then
    '        objcontacts.lastname = txtLastName.Text
    '    End If

    '    If txtPhone.Text <> "" Then
    '        objcontacts.phone = txtPhone.Text
    '    End If

    '    If txtEmail.Text <> "" Then
    '        objcontacts.email = txtEmail.Text
    '    End If

    '    If flPictureLink.PostedFile.FileName = "" Then
    '        'Default Binary values
    '        'Dim ImageContent(0) As Byte
    '        'objcontacts.picturelink = ImageContent
    '        'objcontacts.picturetype = ""
    '    ElseIf flPictureLink.PostedFile.FileName <> "" Then
    '        'Dim filename As String = flPictureLink.PostedFile.FileName
    '        'Dim ext As String = filename.Substring(filename.LastIndexOf("."))
    '        'ext = ext.ToLower

    '        'Dim imgType = flPictureLink.PostedFile.ContentType
    '        'If ext = ".jpg" Then

    '        'ElseIf ext = ".bmp" Then

    '        'ElseIf ext = ".gif" Then

    '        'ElseIf ext = "jpg" Then

    '        'ElseIf ext = "bmp" Then

    '        'ElseIf ext = "gif" Then
    '        'Else
    '        '    Response.Write("Only gif, bmp, or jpg format files supported.")
    '        'End If

    '        'intLength = Convert.ToInt32(flPictureLink.PostedFile.InputStream.Length)

    '        'ReDim arrContent(intLength)
    '        'flPictureLink.PostedFile.InputStream.Read(arrContent, 0, intLength)

    '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        'Dim imageSize As Byte() = New Byte(flPictureLink.PostedFile.ContentLength - 1) {}
    '        'Dim uploadedImage As HttpPostedFile = flPictureLink.PostedFile
    '        'uploadedImage.InputStream.Read(imageSize, 0, CInt(flPictureLink.PostedFile.ContentLength))
    '        'C21MIT.METROINI.BLL.miinsertcontacts.insertcontacts(objcontacts, imageSize)
    '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    '        Dim intImageSize As Int64
    '        Dim strImageType As String
    '        Dim ImageStream As Stream

    '        ' Gets the Size of the Image
    '        intImageSize = flPictureLink.PostedFile.ContentLength

    '        ' Gets the Image Type
    '        strImageType = flPictureLink.PostedFile.ContentType

    '        ' Reads the Image
    '        ImageStream = flPictureLink.PostedFile.InputStream

    '        Dim ImageContent(intImageSize) As Byte
    '        Dim intStatus As Integer
    '        intStatus = ImageStream.Read(ImageContent, 0, intImageSize)
    '        objcontacts.picturelink = ImageContent
    '        objcontacts.picturetype = strImageType
    '    End If
    '    C21MIT.METROINI.BLL.miinsertcontacts.insertcontacts(objcontacts)

    '    txtFirstName.Text = ""
    '    txtLastName.Text = ""
    '    txtPhone.Text = ""
    '    txtEmail.Text = ""

    '    If stask = "AddNew" Then
    '        bindPanel("PANEL 4", stask, Session("currentcert"))
    '    ElseIf stask = "Edit" Then
    '        bindPanel("PANEL 4", stask, Request.QueryString("certid"))
    '    ElseIf stask = "Pending" Then
    '        bindPanel("PANEL 4", stask, Request.QueryString("certid"))
    '    End If
    'End Sub


    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Dim arrContent As Byte() = Nothing
        Dim objcontacts As New C21MIT.METROINI.BO.gccontactsobject
        If Not (Request.QueryString("task") Is Nothing) Then
            stask = Request.QueryString("task")
            If stask = "AddNew" Then
                objcontacts.hcertificatedetails = Session("currentcert")
            ElseIf stask = "Edit" Then
                objcontacts.hcertificatedetails = Request.QueryString("certid")
            ElseIf stask = "Pending" Then
                objcontacts.hcertificatedetails = Request.QueryString("certid")

            End If
        End If

        If txtFirstName.Text <> "" Then
            objcontacts.firstname = txtFirstName.Text
        End If

        If txtLastName.Text <> "" Then
            objcontacts.lastname = txtLastName.Text
        End If

        If txtPhone.Text <> "" Then
            objcontacts.phone = txtPhone.Text
        End If

        If txtEmail.Text <> "" Then
            objcontacts.email = txtEmail.Text
        End If

        If flPictureLink.PostedFile.FileName = "" Then
           
        ElseIf flPictureLink.PostedFile.FileName <> "" Then

            Dim v_FileExtension As String
            Dim fileSize As Integer = flPictureLink.PostedFile.ContentLength
            Dim fn As String = System.IO.Path.GetFileName(flPictureLink.PostedFile.FileName)
            Dim fLen As Integer = fn.Length
            ' Gets the Image Type
            Dim strImageType As String
            strImageType = flPictureLink.PostedFile.ContentType
            v_FileExtension = fn.Substring(fLen - 3)

            If v_FileExtension.Equals(".jpg") Or v_FileExtension.Equals(".bmp") Or v_FileExtension.Equals(".gif") Or v_FileExtension.Equals("jpg") Or v_FileExtension.Equals("bmp") Or v_FileExtension.Equals("gif") Then
                If fileSize <= 1000000 Then

                    C21MIT.METROINI.BLL.mimanage.getWebFolderPath(fn)

                    'Save file to the location


                    objcontacts.picturelink = C21MIT.METROINI.BLL.mimanage.getWebFolderPath(fn)
                    objcontacts.picturetype = strImageType
                    SaveUpdFile(objcontacts.picturelink)
                Else
                    lblMessage.Text = "The maximum allowable file size is 1MB"
                End If

            Else
                lblMessage.Text = "You can only upload Image Files"
            End If

          
            
        End If
        C21MIT.METROINI.BLL.miinsertcontacts.insertcontacts(objcontacts)

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""

        If stask = "AddNew" Then
            bindPanel("PANEL 4", stask, Session("currentcert"))
        ElseIf stask = "Edit" Then
            bindPanel("PANEL 4", stask, Request.QueryString("certid"))
        ElseIf stask = "Pending" Then
            bindPanel("PANEL 4", stask, Request.QueryString("certid"))
        End If
    End Sub

    Private Sub SaveUpdFile(ByVal pLink As String)

        Dim SaveLocation As String
        'Dim v_basedir As String

        'Dim v_baseDirLen As Integer
        'v_basedir = System.AppDomain.CurrentDomain.BaseDirectory
        'v_baseDirLen = v_basedir.Length
        'v_basedir = v_basedir.Substring(0, v_baseDirLen - 1)
        'v_baseDirLen = v_basedir.LastIndexOf("\")
        'SaveLocation = v_basedir.Substring(0, v_baseDirLen)
        SaveLocation = pLink

        Try
            flPictureLink.PostedFile.SaveAs(SaveLocation)

        Catch Ex As Exception
            Dim objerrLog As New MITErrorHandling(Ex.ToString())
            objerrLog.logError()

            If Ex.Message.Equals("sqlexception") Then
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings("sitePath") & "/users/uremessage.aspx", False)
            End If

        End Try

    End Sub
    Protected Sub deleteifany()
        Dim dgitem As GridViewRow
        Dim isChecked As Boolean

        Dim bDeleted As Boolean = False
        For Each dgitem In gvcontacts.Rows
            'Make sure this is an item and not the header or footer
            If (dgitem.RowType = DataControlRowType.DataRow) Then
                ' First, get the studentID for the selected row 
                Dim lblhid As Label = CType(dgitem.FindControl("pk"), Label)
                isChecked = CType(dgitem.FindControl("chkdelete"), CheckBox).Checked

                If isChecked Then
                    Dim intcert As Integer
                    intcert = Convert.ToInt32(gvcontacts.DataKeys(dgitem.RowIndex).Value)

                    Dim objdelcontacts As New C21MIT.METROINI.BO.gccontactsobject
                    objdelcontacts.hid = lblhid.Text

                    C21MIT.METROINI.DAL.mideletes.deletecontacts(objdelcontacts)
                    bDeleted = True
                Else
                    bDeleted = False
                End If
            End If
        Next
    End Sub

    Protected Sub btnDelContacts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelContacts.Click
        deletecontacts()
    End Sub

    Protected Sub deletecontacts()
        If Not (Request.QueryString("task") Is Nothing) Then
            stask = Request.QueryString("task")
            If stask = "AddNew" Then
                deleteifany()
                bindPanel("PANEL 4", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                deleteifany()
                bindPanel("PANEL 4", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                deleteifany()
                bindPanel("PANEL 4", stask, Request.QueryString("certid"))
            End If
        End If
    End Sub
#End Region

#Region "PANEL 5"
    Protected Sub txtPanel5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox5 As TextBox = CType(sender, TextBox)
        mypanel5text = Server.HtmlEncode(txtbox5.Text)
    End Sub

    Protected Sub btnAdd5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd5.Click
        Dim objPanel5 As New C21MIT.METROINI.BO.gccoursesobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvReqCourses.DisplayLayout.Rows(gvReqCourses.Rows.Count - 1)
        If btnAdd5.Text = "Add" Then
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objPanel5.hid = 1
                    objPanel5.hcertificatedetails = Session("currentcert")
                    objPanel5.coursetype = "RQ"
                    objPanel5.coursename = ""
                ElseIf stask = "Edit" Then
                    objPanel5.hid = 1
                    objPanel5.hcertificatedetails = Request.QueryString("certid")
                    objPanel5.coursetype = "RQ"
                    objPanel5.coursename = ""
                ElseIf stask = "Pending" Then
                    objPanel5.hid = 1
                    objPanel5.hcertificatedetails = Request.QueryString("certid")
                    objPanel5.coursetype = "RQ"
                    objPanel5.coursename = ""
                End If
            End If

            gvReqCourses.DisplayLayout.Rows.Add()
            C21MIT.METROINI.DAL.miinserts.insertcourses(objPanel5)
            UIOnAddClick5()

            If stask = "AddNew" Then
                bindPanel("PANEL 5", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 5", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 5", stask, Request.QueryString("certid"))
            End If
        Else
            objPanel5.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideletecourses.deletecourses(objPanel5)
            row.Delete()
            btnAdd5.Text = "Add"
        End If
    End Sub

    Protected Sub UIOnAddClick5()
        btnDelete5.Enabled = False
        btnUpdate5.Text = "Save"
        btnAdd5.Text = "Cancel"
    End Sub

    Protected Sub btnUpdate5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate5.Click
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
        row = gvReqCourses.DisplayLayout.ActiveRow

        If row Is Nothing Then
            Return
        End If

        If mypanel5text = "" Then
            Return
        Else
            Dim objreqcourses As New C21MIT.METROINI.BO.gccoursesobject
            objreqcourses.hid = row.Cells.FromKey("hid").Value

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objreqcourses.hcertificatedetails = Session("currentcert")
                    objreqcourses.coursetype = "RQ"
                    objreqcourses.coursename = mypanel5text
                ElseIf stask = "Edit" Then
                    objreqcourses.hcertificatedetails = Request.QueryString("certid")
                    objreqcourses.coursetype = "RQ"
                    objreqcourses.coursename = mypanel5text
                ElseIf stask = "Pending" Then
                    objreqcourses.hcertificatedetails = Request.QueryString("certid")
                    objreqcourses.coursetype = "RQ"
                    objreqcourses.coursename = mypanel5text
                End If
            End If
            C21MIT.METROINI.BLL.miupdateinsertcourses.updateinsertcourses(objreqcourses)
            UIOnAddSavedCanceled5()
        End If
    End Sub

    Protected Sub UIOnAddSavedCanceled5()
        btnDelete5.Enabled = True
        btnUpdate5.Text = "Update"
        btnAdd5.Text = "Add"
    End Sub

    Protected Sub btnDelete5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete5.Click
        Dim objreqcourses As New C21MIT.METROINI.BO.gccoursesobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvReqCourses.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If
        objreqcourses.hid = row.Cells.FromKey("hid").Value
        C21MIT.METROINI.BLL.mideletes.mideletecourses.deletecourses(objreqcourses)
        row.Delete()
    End Sub
#End Region

#Region "PANEL 6"
    Protected Sub txtPanel6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox6 As TextBox = CType(sender, TextBox)
        mypanel6text = Server.HtmlEncode(txtbox6.Text)
    End Sub

    Protected Sub btnAdd6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd6.Click
        Dim objPanel6 As New C21MIT.METROINI.BO.gccoursesobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvElecCourses.DisplayLayout.Rows(gvElecCourses.Rows.Count - 1)
        If btnAdd6.Text = "Add" Then
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objPanel6.hid = 1
                    objPanel6.hcertificatedetails = Session("currentcert")
                    objPanel6.coursetype = "EL"
                    objPanel6.coursename = ""
                ElseIf stask = "Edit" Then
                    objPanel6.hid = 1
                    objPanel6.hcertificatedetails = Request.QueryString("certid")
                    objPanel6.coursetype = "EL"
                    objPanel6.coursename = ""
                ElseIf stask = "Pending" Then
                    objPanel6.hid = 1
                    objPanel6.hcertificatedetails = Request.QueryString("certid")
                    objPanel6.coursetype = "EL"
                    objPanel6.coursename = ""
                End If
            End If

            gvElecCourses.DisplayLayout.Rows.Add()
            C21MIT.METROINI.DAL.miinserts.insertcourses(objPanel6)
            UIOnAddClick6()

            If stask = "AddNew" Then
                bindPanel("PANEL 6", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 6", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 6", stask, Request.QueryString("certid"))
            End If
        Else
            objPanel6.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideletecourses.deletecourses(objPanel6)
            row.Delete()
            btnAdd6.Text = "Add"
        End If
    End Sub

    Protected Sub UIOnAddClick6()
        btnDelete6.Enabled = False
        btnUpdate6.Text = "Save"
        btnAdd6.Text = "Cancel"
    End Sub

    Protected Sub btnUpdate6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate6.Click
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
        row = gvElecCourses.DisplayLayout.ActiveRow

        If row Is Nothing Then
            Return
        End If

        If mypanel6text = "" Then
            Return
        Else
            Dim objeleccourses As New C21MIT.METROINI.BO.gccoursesobject
            objeleccourses.hid = row.Cells.FromKey("hid").Value

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objeleccourses.hcertificatedetails = Session("currentcert")
                    objeleccourses.coursetype = "EL"
                    objeleccourses.coursename = mypanel6text
                ElseIf stask = "Edit" Then
                    objeleccourses.hcertificatedetails = Request.QueryString("certid")
                    objeleccourses.coursetype = "EL"
                    objeleccourses.coursename = mypanel6text
                ElseIf stask = "Pending" Then
                    objeleccourses.hcertificatedetails = Request.QueryString("certid")
                    objeleccourses.coursetype = "EL"
                    objeleccourses.coursename = mypanel6text
                End If
            End If

            C21MIT.METROINI.BLL.miupdateinsertcourses.updateinsertcourses(objeleccourses)
            UIOnAddSavedCanceled6()
        End If
    End Sub

    Protected Sub UIOnAddSavedCanceled6()
        btnDelete6.Enabled = True
        btnUpdate6.Text = "Update"
        btnAdd6.Text = "Add"
    End Sub

    Protected Sub btnDelete6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete6.Click
        Dim objeleccourses As New C21MIT.METROINI.BO.gccoursesobject
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvElecCourses.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If
        objeleccourses.hid = row.Cells.FromKey("hid").Value
        C21MIT.METROINI.BLL.mideletes.mideletecourses.deletecourses(objeleccourses)
        row.Delete()
    End Sub

#End Region

#Region "PANEL 8"
    Protected Sub btnAdd8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd8.Click
        Dim objPanel8 As New C21MIT.METROINI.BO.gcprequisites
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvPrerequisites.DisplayLayout.Rows(gvPrerequisites.Rows.Count - 1)
        If btnAdd8.Text = "Add" Then
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")

                If stask = "AddNew" Then
                    objPanel8.hid = 1
                    objPanel8.hcertificatedetails = Session("currentcert")
                    objPanel8.prerequisites = ""
                ElseIf stask = "Edit" Then
                    objPanel8.hid = 1
                    objPanel8.hcertificatedetails = Request.QueryString("certid")
                    objPanel8.prerequisites = ""
                ElseIf stask = "Pending" Then
                    objPanel8.hid = 1
                    objPanel8.hcertificatedetails = Request.QueryString("certid")
                    objPanel8.prerequisites = ""
                End If
            End If

            gvPrerequisites.DisplayLayout.Rows.Add()
            C21MIT.METROINI.DAL.miinserts.insertprereqs(objPanel8)
            UIOnAddClick8()

            If stask = "AddNew" Then
                bindPanel("PANEL 8", stask, Session("currentcert"))
            ElseIf stask = "Edit" Then
                bindPanel("PANEL 8", stask, Request.QueryString("certid"))
            ElseIf stask = "Pending" Then
                bindPanel("PANEL 8", stask, Request.QueryString("certid"))
            End If
        Else
            objPanel8.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideleteprereqs.deleteprereqs(objPanel8)
            row.Delete()
            btnAdd8.Text = "Add"
        End If
    End Sub

    Protected Sub txtPanel8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox8 As TextBox = CType(sender, TextBox)
        mypanel8text = Server.HtmlEncode(txtbox8.Text)
    End Sub

    Protected Sub UIOnAddClick8()
        btnDelete8.Enabled = False
        btnUpdate8.Text = "Save"
        btnAdd8.Text = "Cancel"
    End Sub

    Protected Sub btnUpdate8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate8.Click
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
        row = gvPrerequisites.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If

        If mypanel8text = "" Then
            Return
        Else
            Dim objaprereq As New C21MIT.METROINI.BO.gcprequisites
            objaprereq.hid = row.Cells.FromKey("hid").Value

            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")
                If stask = "AddNew" Then
                    objaprereq.hcertificatedetails = Session("currentcert")
                    objaprereq.prerequisites = mypanel8text
                ElseIf stask = "Edit" Then

                    objaprereq.hcertificatedetails = Request.QueryString("certid")
                    objaprereq.prerequisites = mypanel8text
                ElseIf stask = "Pending" Then

                    objaprereq.hcertificatedetails = Request.QueryString("certid")
                    objaprereq.prerequisites = mypanel8text
                End If
            End If

            C21MIT.METROINI.BLL.miupdateinsertprereqs.updateinsertprereqs(objaprereq)
            UIOnAddSavedCanceled8()
        End If
    End Sub

    Protected Sub UIOnAddSavedCanceled8()
        btnDelete8.Enabled = True
        btnUpdate8.Text = "Update"
        btnAdd8.Text = "Add"
    End Sub




    Protected Sub btnDelete8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete8.Click
        Dim objprereq As New C21MIT.METROINI.BO.gcprequisites
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvPrerequisites.DisplayLayout.ActiveRow
        If row Is Nothing Then
            Return
        End If

        objprereq.hid = row.Cells.FromKey("hid").Value
        C21MIT.METROINI.BLL.mideletes.mideleteprereqs.deleteprereqs(objprereq)

        row.Delete()
    End Sub
#End Region

#Region "Common subroutines"
    Protected Sub UpdateStatus_OLD(ByVal ColName As String, ByVal certid As Integer)
        Dim objstatus As New C21MIT.METROINI.BO.gcstatusobject
        objstatus.hcertificatedetails = certid
        C21MIT.METROINI.BLL.migcstatus.updatestatus_OLD(ColName, objstatus)
    End Sub
    Protected Sub UpdateStatus(ByVal certid As Integer, ByVal status As Integer)
        Dim objstatus As New C21MIT.METROINI.BO.gcstatusobject
        objstatus.hcertificatedetails = certid
        C21MIT.METROINI.BLL.migcstatus.updatestatus(objstatus, status)
    End Sub

    Protected Sub btnPublish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPublish.Click
        If Not (Request.QueryString("task") Is Nothing) Then
            stask = Request.QueryString("task")
            If stask = "AddNew" Then
                UpdateStatus(Session("currentcert"), ddlActiveInactive.SelectedItem.Value)
            ElseIf stask = "Edit" Then
                UpdateStatus(Request.QueryString("certid"), ddlActiveInactive.SelectedItem.Value)
            ElseIf stask = "Pending" Then
                UpdateStatus(Request.QueryString("certid"), ddlActiveInactive.SelectedItem.Value)
            End If
        End If
        lblPublishMess.Visible = True
    End Sub

    Protected Sub bindPanel(ByVal PanelID As String, ByVal stask As String, Optional ByVal certid As Integer = 0)
        Select Case PanelID


            Case "PANEL 1"
                If stask = "AddNew" Then
                    btnSaveTitleDetails.Visible = True
                    btnUpdateTitleDetails.Visible = False
                    btnCheckCertificateAvail.CausesValidation = True
                ElseIf stask = "Edit" Then
                    btnCheckCertificateAvail.CausesValidation = False
                    btnSaveTitleDetails.Visible = False
                    btnUpdateTitleDetails.Visible = True
                    binpanel1data(certid)
                ElseIf stask = "Pending" Then
                    btnCheckCertificateAvail.CausesValidation = False
                    btnSaveTitleDetails.Visible = False
                    btnUpdateTitleDetails.Visible = True
                    binpanel1data(certid)
                End If


            Case "PANEL 2"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid).Count > 0 Then
                        gvAdmissionReq.DataSource = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid)
                        gvAdmissionReq.DataBind()
                    End If
                    If btnAdd2.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
                        gvAdmissionReq.DisplayLayout.ActiveRow = row
                    End If
                ElseIf certid = 0 Then
                    If btnAdd2.Text = "Cancel" Then

                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
                        gvAdmissionReq.DisplayLayout.ActiveRow = row
                        gvAdmissionReq.Rows.Add(row)

                    End If
                End If


            Case "PANEL 3"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getApplicationRequirementsList(certid).Count > 0 Then
                        gvApplicationReq.DataSource = C21MIT.METROINI.BLL.mimanage.getApplicationRequirementsList(certid)
                        gvApplicationReq.DataBind()
                    End If
                    If btnAdd3.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvApplicationReq.DisplayLayout.Rows(gvApplicationReq.Rows.Count - 1)
                        gvApplicationReq.DisplayLayout.ActiveRow = row
                    End If
                ElseIf certid = 0 Then
                    If btnAdd3.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvApplicationReq.DisplayLayout.Rows(gvApplicationReq.Rows.Count - 1)
                        gvApplicationReq.DisplayLayout.ActiveRow = row
                        gvApplicationReq.Rows.Add(row)
                    End If
                End If


            Case "PANEL 4"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getContactList(certid).Count > 0 Then
                        gvcontacts.DataSource = C21MIT.METROINI.BLL.mimanage.getContactList(certid)
                        gvcontacts.DataBind()
                        gvcontacts.Visible = True
                        save.Enabled = True
                        btnDelContacts.Enabled = True
                        lblnorecs.Visible = False
                    Else

                        gvcontacts.Visible = False
                        lblnorecs.Visible = True


                        save.Enabled = False
                        btnDelContacts.Enabled = False

                        '' '' ''Dim dt As New DataTable

                        '' '' ''Dim colWidth As String
                        '' '' ''colWidth = "175px"
                        '' '' ''If dt.Rows.Count = 0 Then
                        '' '' ''    Dim newdt As DataTable = New DataTable("newdt")
                        '' '' ''    newdt.Columns.Add(New DataColumn("hid"))

                        '' '' ''    newdt.Columns.Add(New DataColumn("hcertificatedetails"))
                        '' '' ''    newdt.Columns.Add(New DataColumn("firstname"))
                        '' '' ''    newdt.Columns.Add(New DataColumn("lastname"))
                        '' '' ''    newdt.Columns.Add(New DataColumn("phone"))
                        '' '' ''    newdt.Columns.Add(New DataColumn("email"))


                        '' '' ''    Dim dr As DataRow = Nothing
                        '' '' ''    dr = newdt.NewRow()
                        '' '' ''    dr(0) = "" 'or you can also use dr("col1")="Col1 value"  
                        '' '' ''    dr(1) = ""
                        '' '' ''    dr(2) = ""
                        '' '' ''    dr(3) = ""
                        '' '' ''    newdt.Rows.Add(dr)
                        '' '' ''    gvcontacts.DataSource = newdt
                        '' '' ''    gvcontacts.DataBind()
                        '' '' ''    Dim columnCount As Integer = gvcontacts.Rows(0).Cells.Count

                        '' '' ''    gvcontacts.Rows(0).Cells.Clear()
                        '' '' ''    gvcontacts.Rows(0).Cells.Add(New TableCell())
                        '' '' ''    gvcontacts.Rows(0).Cells(0).ColumnSpan = columnCount
                        '' '' ''    ' gvcontacts.Rows(0).Cells(0).Text = message

                        '' '' ''    For i As Integer = 0 To gvcontacts.Columns.Count - 1
                        '' '' ''        gvcontacts.Columns(i).ItemStyle.Width = 175
                        '' '' ''    Next
                        '' '' ''Else
                        '' '' ''    gvcontacts.DataSource = dt
                        '' '' ''    gvcontacts.DataBind()
                        '' '' ''End If
                    End If

                ElseIf certid = 0 Then
                    gvcontacts.DataSource = C21MIT.METROINI.BLL.mimanage.getContactList(certid)
                    gvcontacts.DataBind()
                End If


            Case "PANEL 5"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getRequiredCoursesList(certid).Count > 0 Then
                        gvReqCourses.DataSource = C21MIT.METROINI.BLL.mimanage.getRequiredCoursesList(certid)
                        gvReqCourses.DataBind()
                    End If
                    If btnAdd5.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvReqCourses.DisplayLayout.Rows(gvReqCourses.Rows.Count - 1)
                        gvReqCourses.DisplayLayout.ActiveRow = row
                    End If
                ElseIf certid = 0 Then
                    If btnAdd5.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvReqCourses.DisplayLayout.Rows(gvReqCourses.Rows.Count - 1)
                        gvReqCourses.DisplayLayout.ActiveRow = row
                        gvReqCourses.Rows.Add(row)
                    End If
                End If


            Case "PANEL 6"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getElectiveCoursesList(certid).Count > 0 Then
                        gvElecCourses.DataSource = C21MIT.METROINI.BLL.mimanage.getElectiveCoursesList(certid)
                        gvElecCourses.DataBind()
                    End If
                    If btnAdd6.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvElecCourses.DisplayLayout.Rows(gvElecCourses.Rows.Count - 1)
                        gvElecCourses.DisplayLayout.ActiveRow = row
                    End If
                ElseIf certid = 0 Then
                    If btnAdd6.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvElecCourses.DisplayLayout.Rows(gvElecCourses.Rows.Count - 1)
                        gvElecCourses.DisplayLayout.ActiveRow = row
                        gvElecCourses.Rows.Add(row)
                    End If
                End If

            Case "PANEL 8"
                If certid > 0 Then
                    If C21MIT.METROINI.BLL.mimanage.getPrerequisiteList(certid).Count > 0 Then
                        gvPrerequisites.DataSource = C21MIT.METROINI.BLL.mimanage.getPrerequisiteList(certid)
                        gvPrerequisites.DataBind()
                    End If
                    If btnAdd8.Text = "Cancel" Then
                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvPrerequisites.DisplayLayout.Rows(gvPrerequisites.Rows.Count - 1)
                        gvPrerequisites.DisplayLayout.ActiveRow = row
                    End If
                ElseIf certid = 0 Then
                    If btnAdd8.Text = "Cancel" Then

                        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                        row = gvPrerequisites.DisplayLayout.Rows(gvPrerequisites.Rows.Count - 1)
                        gvPrerequisites.DisplayLayout.ActiveRow = row
                        gvPrerequisites.Rows.Add(row)

                    End If
                End If

        End Select
    End Sub
#End Region
End Class
