Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports URDAL
Partial Class manage_migradcerts
    Inherits System.Web.UI.Page

    Dim CertId As Integer
    Dim stask As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        If Not IsPostBack Then
            ' stask = "Edit"
            If Not (Request.QueryString("task") Is Nothing) Then
                stask = Request.QueryString("task")
                If stask = "AddNew" Then
                    'show empty form
                    Panel2.Enabled = False
                    Panel3.Enabled = False
                    Panel4.Enabled = False
                    Panel5.Enabled = False
                    Panel6.Enabled = False

                    bindAdmissionrequirements(stask, CertId)

                    bindApplicationrequirements(stask, CertId)
                    bindContacts(stask, CertId)
                    bindRequiredCourses(stask, CertId)
                    bindElectiveCourses(stask, CertId)
                    btnSaveTitleDetails.Visible = True
                    btnUpdateTitleDetails.Visible = False
                    lblMessAddUpdate.Text = "Add New Graduate Certificate"

                ElseIf stask = "Edit" Then
                    'if coming from edit
                    'show filled form if any
                    If Not (Request.QueryString("certid") Is Nothing) Then
                        CertId = Request.QueryString("")
                        bindAdmissionrequirements(stask, CertId)
                        bindApplicationrequirements(stask, CertId)
                        bindContacts(stask, CertId)
                        bindRequiredCourses(stask, CertId)
                        bindElectiveCourses(stask, CertId)
                        btnSaveTitleDetails.Visible = False
                        btnUpdateTitleDetails.Visible = True
                        lblMessAddUpdate.Text = "Edit Graduate Certificate"
                    ElseIf Request.QueryString("certid") Is Nothing Then
                        bindAdmissionrequirements(stask, 142)
                        bindApplicationrequirements(stask, 0)
                        bindContacts(stask, 0)
                        bindRequiredCourses(stask, 0)
                        bindElectiveCourses(stask, 0)
                        btnSaveTitleDetails.Visible = False
                        btnUpdateTitleDetails.Visible = True
                        lblMessAddUpdate.Text = "Edit Graduate Certificate"

                        Panel2.Enabled = True
                    End If
                End If
            End If
        End If

    End Sub

    Protected Sub bindAdmissionrequirements(ByVal stask As String, ByVal certid As Integer)
        'If stask is add, then bind empty controls on the form
        If stask = "AddNew" Then
            SetInitialRow1()
        ElseIf stask = "Edit" Then
            If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid).Count > 0 Then
                gvAdmissionReq.DataSource = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid)
                gvAdmissionReq.DataBind()
            ElseIf C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid).Count = 0 Then
                'Add a blank row
                SetInitialRow1()
            End If
        End If
    End Sub


    Private Sub SetInitialRow1()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing

        dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
        ' dt.Columns.Add(New DataColumn("RowNumber", GetType(Integer)))
        dt.Columns.Add(New DataColumn("hcertificatedetails", GetType(Integer)))
        dt.Columns.Add(New DataColumn("admissionreqdocuments", GetType(String)))

        dr = dt.NewRow()

        dr("hid") = 1
        ' dr("RowNumber") = 1
        dr("hcertificatedetails") = 1
        dr("admissionreqdocuments") = String.Empty

        dt.Rows.Add(dr)

        'Store the DataTable in ViewState
        ViewState("CurrentTable1") = dt

        gvAdmissionReq.DataSource = dt
        gvAdmissionReq.DataBind()
    End Sub

    Private Sub AddNewRowToGrid1()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable1") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable1"), DataTable)
            Dim drCurrentRow As DataRow = Nothing
            Dim boxstr As String = ""
            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    'extract the TextBox values
                    Dim box1 As TextBox = DirectCast(gvAdmissionReq.Rows(rowIndex).Cells(1).FindControl("txtAdmissionReq"), TextBox)
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("hid") = i + 1
                    drCurrentRow("hcertificatedetails") = i + 1
                    'drCurrentRow("RowNumber") = i + 1
                    dtCurrentTable.Rows(i - 1)("admissionreqdocuments") = box1.Text
                    boxstr = box1.Text
                    rowIndex += 1
                Next
                'try inserting one record here with the sessionid as hcertificatedetails
                If Not Session("currenthid") Is Nothing Then
                    insertblankadmissionrequirements(Session("currenthid"), boxstr)
                Else
                    Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
                End If

                dtCurrentTable.Rows.Add(drCurrentRow)

                ViewState("CurrentTable1") = dtCurrentTable

                gvAdmissionReq.DataSource = dtCurrentTable
                gvAdmissionReq.DataBind()
            End If
        Else
            ' Response.Write("ViewState is null")
        End If
        'Set Previous Data on Postbacks
        SetPreviousData1()
    End Sub

    Private Sub SetPreviousData1()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable1") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable1"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box1 As TextBox = DirectCast(gvAdmissionReq.Rows(rowIndex).Cells(1).FindControl("txtAdmissionReq"), TextBox)
                    box1.Text = dt.Rows(i)("admissionreqdocuments").ToString()

                    rowIndex += 1
                Next
            End If
        End If
    End Sub

    Protected Sub bindApplicationrequirements(ByVal stask As String, ByVal certid As Integer)
        'If stask is add, then bind empty controls on the form
        If stask = "AddNew" Then
            SetInitialRow2()
        ElseIf stask = "Edit" Then
            If C21MIT.METROINI.BLL.mimanage.getApplicationRequirementsList(certid).Count > 0 Then
                gvApplicationReq.DataSource = C21MIT.METROINI.BLL.mimanage.getApplicationRequirementsList(certid)
                gvApplicationReq.DataBind()
            ElseIf C21MIT.METROINI.BLL.mimanage.getApplicationRequirementsList(certid).Count = 0 Then
                'Add a blank row
                SetInitialRow2()
            End If
        End If
    End Sub

    Private Sub SetInitialRow2()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing

        dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
        dt.Columns.Add(New DataColumn("applicationrequirements", GetType(String)))

        dr = dt.NewRow()
        dr("hid") = 1
        dr("applicationrequirements") = String.Empty

        dt.Rows.Add(dr)

        'Store the DataTable in ViewState
        ViewState("CurrentTable2") = dt

        gvApplicationReq.DataSource = dt
        gvApplicationReq.DataBind()
    End Sub

    Private Sub AddNewRowToGrid2()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable2") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable2"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    'extract the TextBox values
                    Dim box2 As TextBox = DirectCast(gvApplicationReq.Rows(rowIndex).Cells(1).FindControl("txtApplicationReq"), TextBox)
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("hid") = i + 1
                    ' drCurrentRow("RowNumber") = i + 1
                    dtCurrentTable.Rows(i - 1)("applicationrequirements") = box2.Text
                    rowIndex += 1
                Next
                dtCurrentTable.Rows.Add(drCurrentRow)

                ViewState("CurrentTable2") = dtCurrentTable

                gvApplicationReq.DataSource = dtCurrentTable
                gvApplicationReq.DataBind()
            End If
        Else
            ' Response.Write("ViewState is null")
        End If

        'Set Previous Data on Postbacks
        SetPreviousData2()
    End Sub

    Private Sub SetPreviousData2()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable2") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable2"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box2 As TextBox = DirectCast(gvApplicationReq.Rows(rowIndex).Cells(1).FindControl("txtApplicationReq"), TextBox)
                    box2.Text = dt.Rows(i)("applicationrequirements").ToString()

                    rowIndex += 1
                Next
            End If
        End If
    End Sub

    Protected Sub bindContacts(ByVal stask As String, ByVal certid As Integer)
        'If stask is add, then bind empty controls on the form
        If stask = "AddNew" Then
            SetInitialRow3()
        ElseIf stask = "Edit" Then
            If C21MIT.METROINI.BLL.mimanage.getContactList(certid).Count > 0 Then
                gvContacts.DataSource = C21MIT.METROINI.BLL.mimanage.getContactList(certid)
                gvContacts.DataBind()
            ElseIf C21MIT.METROINI.BLL.mimanage.getContactList(certid).Count = 0 Then
                'Add a blank row
                SetInitialRow3()
            End If
        End If
    End Sub

    Private Sub SetInitialRow3()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing

        dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
        dt.Columns.Add(New DataColumn("firstname", GetType(String)))
        dt.Columns.Add(New DataColumn("lastname", GetType(String)))
        dt.Columns.Add(New DataColumn("phone", GetType(String)))
        dt.Columns.Add(New DataColumn("email", GetType(String)))
        dt.Columns.Add(New DataColumn("picturelink", GetType(String)))

        dr = dt.NewRow()

        dr("hid") = 1
        dr("firstname") = String.Empty
        dr("lastname") = String.Empty
        dr("phone") = String.Empty
        dr("email") = String.Empty
        dr("picturelink") = String.Empty

        dt.Rows.Add(dr)

        'Store the DataTable in ViewState
        ViewState("CurrentTable3") = dt

        gvContacts.DataSource = dt
        gvContacts.DataBind()
    End Sub


    Private Sub AddNewRowToGrid3()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable3") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable3"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    'extract the TextBox values
                    Dim box3 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtfName"), TextBox)
                    Dim box4 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtlName"), TextBox)
                    Dim box5 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtphone"), TextBox)
                    Dim box6 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtemail"), TextBox)
                    Dim fileupload1 As FileUpload = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("flupload"), FileUpload)
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("hid") = i + 1
                    dtCurrentTable.Rows(i - 1)("firstname") = box3.Text
                    dtCurrentTable.Rows(i - 1)("lastname") = box4.Text
                    dtCurrentTable.Rows(i - 1)("phone") = box5.Text
                    dtCurrentTable.Rows(i - 1)("email") = box6.Text
                    dtCurrentTable.Rows(i - 1)("picturelink") = fileupload1.FileName.ToString

                    rowIndex += 1
                Next
                dtCurrentTable.Rows.Add(drCurrentRow)

                ViewState("CurrentTable3") = dtCurrentTable

                gvContacts.DataSource = dtCurrentTable
                gvContacts.DataBind()
            End If
        Else
            ' Response.Write("ViewState is null")
        End If

        'Set Previous Data on Postbacks
        SetPreviousData3()
    End Sub

    Private Sub SetPreviousData3()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable3") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable3"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box3 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtfName"), TextBox)
                    Dim box4 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtlName"), TextBox)
                    Dim box5 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtphone"), TextBox)
                    Dim box6 As TextBox = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("txtemail"), TextBox)
                    Dim fileupload1 As FileUpload = DirectCast(gvContacts.Rows(rowIndex).Cells(1).FindControl("flupload"), FileUpload)
                    box3.Text = dt.Rows(i)("firstname").ToString()
                    box4.Text = dt.Rows(i)("lastname").ToString()
                    box5.Text = dt.Rows(i)("phone").ToString()
                    box6.Text = dt.Rows(i)("email").ToString()

                    rowIndex += 1
                Next
            End If
        End If
    End Sub

    Protected Sub bindRequiredCourses(ByVal stask As String, ByVal certid As Integer)
        'If stask is add, then bind empty controls on the form
        If stask = "AddNew" Then
            SetInitialRow4()
        ElseIf stask = "Edit" Then
            If C21MIT.METROINI.BLL.mimanage.getRequiredCoursesList(certid).Count > 0 Then
                gvApplicationReq.DataSource = C21MIT.METROINI.BLL.mimanage.getRequiredCoursesList(certid)
                gvApplicationReq.DataBind()
            ElseIf C21MIT.METROINI.BLL.mimanage.getRequiredCoursesList(certid).Count = 0 Then
                'Add a blank row
                SetInitialRow4()
            End If
        End If
    End Sub

    Private Sub SetInitialRow4()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing

        dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
        dt.Columns.Add(New DataColumn("coursename", GetType(String)))
   
        dr = dt.NewRow()

        dr("hid") = 1
        dr("coursename") = String.Empty
       
        dt.Rows.Add(dr)

        'Store the DataTable in ViewState
        ViewState("CurrentTable4") = dt

        gvRequiredCourses.DataSource = dt
        gvRequiredCourses.DataBind()
    End Sub

    Private Sub AddNewRowToGrid4()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable4") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable4"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    'extract the TextBox values
                    Dim box7 As TextBox = DirectCast(gvRequiredCourses.Rows(rowIndex).Cells(1).FindControl("txtReqCourses"), TextBox)
               
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("hid") = i + 1
                    dtCurrentTable.Rows(i - 1)("coursename") = box7.Text
                  
                    rowIndex += 1
                Next
                dtCurrentTable.Rows.Add(drCurrentRow)

                ViewState("CurrentTable4") = dtCurrentTable

                gvRequiredCourses.DataSource = dtCurrentTable
                gvRequiredCourses.DataBind()
            End If
        Else
            ' Response.Write("ViewState is null")
        End If

        'Set Previous Data on Postbacks
        SetPreviousData4()
    End Sub

    Private Sub SetPreviousData4()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable4") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable4"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box7 As TextBox = DirectCast(gvRequiredCourses.Rows(rowIndex).Cells(1).FindControl("txtReqCourses"), TextBox)

                    box7.Text = dt.Rows(i)("coursename").ToString()
                    rowIndex += 1
                Next
            End If
        End If
    End Sub

    Protected Sub bindElectiveCourses(ByVal stask As String, ByVal certid As Integer)
        'If stask is add, then bind empty controls on the form
        If stask = "AddNew" Then
            SetInitialRow5()
        ElseIf stask = "Edit" Then
            If C21MIT.METROINI.BLL.mimanage.getElectiveCoursesList(certid).Count > 0 Then
                gvElect.DataSource = C21MIT.METROINI.BLL.mimanage.getElectiveCoursesList(certid)
                gvElect.DataBind()
            ElseIf C21MIT.METROINI.BLL.mimanage.getElectiveCoursesList(certid).Count = 0 Then
                'Add a blank row
                SetInitialRow5()
            End If
        End If
    End Sub

    Private Sub SetInitialRow5()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing

        dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
        dt.Columns.Add(New DataColumn("coursename", GetType(String)))

        dr = dt.NewRow()

        dr("hid") = 1
        dr("coursename") = String.Empty

        dt.Rows.Add(dr)

        'Store the DataTable in ViewState
        ViewState("CurrentTable5") = dt

        gvElect.DataSource = dt
        gvElect.DataBind()
    End Sub

    Private Sub AddNewRowToGrid5()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable5") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable5"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    'extract the TextBox values
                    Dim box8 As TextBox = DirectCast(gvElect.Rows(rowIndex).Cells(1).FindControl("txtElectives"), TextBox)

                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("hid") = i + 1
                    dtCurrentTable.Rows(i - 1)("coursename") = box8.Text

                    rowIndex += 1
                Next
                dtCurrentTable.Rows.Add(drCurrentRow)

                ViewState("CurrentTable5") = dtCurrentTable

                gvElect.DataSource = dtCurrentTable
                gvElect.DataBind()
            End If
        Else
            ' Response.Write("ViewState is null")
        End If

        'Set Previous Data on Postbacks
        SetPreviousData5()
    End Sub

    Private Sub SetPreviousData5()
        Dim rowIndex As Integer = 0
        If ViewState("CurrentTable5") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable5"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box8 As TextBox = DirectCast(gvElect.Rows(rowIndex).Cells(1).FindControl("txtElectives"), TextBox)

                    box8.Text = dt.Rows(i)("coursename").ToString()
                    rowIndex += 1
                Next
            End If
        End If
    End Sub
    Protected Sub btnAddNewRow1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow1.Click
        AddNewRowToGrid1()
    End Sub

    Protected Sub btnAddNewRow2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow2.Click
        AddNewRowToGrid2()
    End Sub

    Protected Sub btnAddNewRow3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow3.Click
        AddNewRowToGrid3()
    End Sub

    Protected Sub btnAddNewRow4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow4.Click
        AddNewRowToGrid4()
    End Sub

    Protected Sub btnAddNewRow5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow5.Click
        AddNewRowToGrid5()
    End Sub

    Protected Sub btnSaveTitleDetails_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveTitleDetails.Click
        'Insert data in the table

        If chechcertavailablity(txtcertcode.Text.Trim) = 1 Then
            Panel2.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True
            Panel5.Enabled = True
            Panel6.Enabled = True
        Else
            Panel2.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True
            Panel5.Enabled = True
            Panel6.Enabled = True


        End If
        inserttitledetails()
        ' Response.Write(Session("currenthid"))
        'try inserting one record here with the sessionid as hcertificatedetails
        If Not Session("currenthid") Is Nothing Then
            If Session("insertblankadmissionreq") = "true" Then
                Exit Sub
            End If
            insertblankadmissionrequirements(Session("currenthid"), "")
            Session("insertblankadmissionreq") = "true"
        Else
            Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
        End If
    End Sub

    Protected Sub inserttitledetails()
        If chechcertavailablity(txtcertcode.Text.Trim) = 1 Then
            lblfinal1.Text = "The certificate is already present in the system. Please select a different code."
            lblfinal1.ForeColor = Drawing.Color.Red
            Panel2.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True
            Panel5.Enabled = True
            Panel6.Enabled = True
            Return
        ElseIf chechcertavailablity(txtcertcode.Text.Trim) = 0 Then
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
        ElseIf rdOGP.Checked Then
            objtitledesc.certtype = "OGC"
        End If
        'C21MIT.METROINI.BLL.miinserttitledetails.inserttitledetails(objtitledesc)

        Dim currenthid As Integer
        currenthid = C21MIT.METROINI.BLL.miinserttitledetails.inserttitledetails(objtitledesc)

        Session("currenthid") = currenthid
    End Sub



    Protected Sub btnCheckCertificateAvail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckCertificateAvail.Click
        'check with the database
        chechcertificateavailablity(txtcertcode.Text.Trim)
    End Sub

    Protected Function chechcertavailablity(ByVal certcode As String) As Integer
        Dim objcertcode As New C21MIT.METROINI.BO.gctitledetailsobject
        objcertcode.certificatecode = certcode

        Dim intCount As Integer
        intCount = C21MIT.METROINI.BLL.mimanage.fncheckCertificateAvailable(objcertcode)

        Return intCount
    End Function
    Protected Sub chechcertificateavailablity(ByVal certcode As String)
        'check whether the certificate code is already present
        Dim objcertcode As New C21MIT.METROINI.BO.gctitledetailsobject
        objcertcode.certificatecode = certcode

        Dim intCount As Integer
        intCount = C21MIT.METROINI.BLL.mimanage.fncheckCertificateAvailable(objcertcode)

        If intCount = 0 Then
            lblcertavailablitymsg.Visible = True
            lblcertavailablitymsg.ForeColor = Drawing.Color.Teal
            lblcertavailablitymsg.Font.Size = FontSize.Small
            lblcertavailablitymsg.Text = "You can use this Certificate Code."
            rq1.Visible = False
        ElseIf intCount = 1 Then
            'display message
            lblcertavailablitymsg.Visible = True
            lblcertavailablitymsg.ForeColor = Drawing.Color.Red
            lblcertavailablitymsg.Font.Size = FontSize.Small
            lblcertavailablitymsg.Text = "This certificate already exists. Please select a different code."
            rq1.Visible = False

            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False
            Panel5.Enabled = False

            Panel6.Enabled = False
        End If
    End Sub

    Protected Sub btnSaveData1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveData1.Click
        Dim sesionhid As Integer
        If Request.QueryString("task") = "AddNew" Then
            If Not Session("currenthid") Is Nothing Then
                sesionhid = Session("currenthid")
                updateinsertadmissionrequirements(sesionhid)
            Else
                Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
            End If
        ElseIf Request.QueryString("task") = "Edit" Then
            'updateinsertadmissionrequirements(sesionhid)
        End If


        


    End Sub

    Protected Sub insertadmissionrequirements(ByVal sessionid As Integer)
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj

        Dim dgitem1 As GridViewRow
        For Each dgitem1 In gvAdmissionReq.Rows
            Dim txtAdmisReq As TextBox = CType(dgitem1.FindControl("txtAdmissionReq"), TextBox)
            'Save the gridview to the database
            objadmissionreq.hcertificatedetails = sessionid
            objadmissionreq.admissionreqdocuments = txtAdmisReq.Text
            
            C21MIT.METROINI.BLL.miinsertadmissionreq.insertadmissionreq(objadmissionreq)
        Next
    End Sub

    Protected Sub updateinsertadmissionrequirements(ByVal sessionid As Integer)
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
        Dim dgitem1 As GridViewRow
        For Each dgitem1 In gvAdmissionReq.Rows
            Dim lblRN As Label = CType(dgitem1.FindControl("lblRowNumber"), Label)
            Dim txtAdmisReq As TextBox = CType(dgitem1.FindControl("txtAdmissionReq"), TextBox)
            Dim lblCertDetails As Label = CType(dgitem1.FindControl("lblCertDetails"), Label)
            'Save the gridview to the database
            objadmissionreq.hid = lblCertDetails.Text
            objadmissionreq.hcertificatedetails = sessionid
            objadmissionreq.admissionreqdocuments = txtAdmisReq.Text

            C21MIT.METROINI.BLL.miupdateinsertadmissionreq.updateinsertadmissionreq(objadmissionreq)
        Next
    End Sub
    Protected Sub insertblankadmissionrequirements(ByVal sessionid As Integer, ByVal admissionrequirements As String)
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
        Dim i As Integer

        For i = 1 To 1
            Dim txtAdmisReq As TextBox = CType(gvAdmissionReq.FindControl("txtAdmissionReq"), TextBox)
            Dim lblRN As Label = CType(gvAdmissionReq.FindControl("lblRowNumber"), Label)
            'Save the gridview to the database
            objadmissionreq.hcertificatedetails = sessionid
            objadmissionreq.admissionreqdocuments = ""

            C21MIT.METROINI.BLL.miinsertadmissionreq.insertadmissionreq(objadmissionreq)
        Next
    End Sub

    Protected Sub btnSaveData2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveData2.Click
        Dim sesionhid As Integer
        If Request.QueryString("task") = "AddNew" Then
            If Not Session("currenthid") Is Nothing Then
                sesionhid = Session("currenthid")
                insertapplicationrequirements(sesionhid)
            Else
                Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
            End If
        ElseIf Request.QueryString("task") = "Edit" Then
            'updateinsertapplicationrequirements(sesionhid)
        End If

    End Sub

    Protected Sub insertapplicationrequirements(ByVal sessionid As Integer)
        Dim objapplicationreq As New C21MIT.METROINI.BO.gcapplicationreqobject

        Dim dgitem1 As GridViewRow
        For Each dgitem1 In gvApplicationReq.Rows
            Dim txtAppReq As TextBox = CType(dgitem1.FindControl("txtApplicationReq"), TextBox)
            'Save the gridview to the database
            objapplicationreq.hcertificatedetails = sessionid
            objapplicationreq.applicationrequirements = txtAppReq.Text

            C21MIT.METROINI.BLL.miinsertapplicationreq.insertapplicationreq(objapplicationreq)
        Next
    End Sub

    Protected Sub bindAdmissionrequirementdata(ByVal stask As String, ByVal CertId As Integer)

        If Not Session("currenthid") Is Nothing Then
            gvAdmissionReq.DataSource = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(Session("currenthid"))
            gvAdmissionReq.DataBind()
        End If
    End Sub

    Protected Sub gvAdmissionReq_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvAdmissionReq.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then

            If Not Session("currenthid") Is Nothing Then
                If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(Session("currenthid")).Count > 0 Then
                    Dim lblcertdetails As Label = CType(e.Row.FindControl("lblCertDetails"), Label)
                    Dim txtadmissionreq As TextBox = CType(e.Row.FindControl("txtAdmissionReq"), TextBox)
                    lblcertdetails.Text = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(Session("currenthid")).Item(e.Row.RowIndex).hid
                    txtadmissionreq.Text = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(Session("currenthid")).Item(e.Row.RowIndex).admissionreqdocuments
                End If
                'Else
                '    If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(137).Count > 0 Then
                '        Dim lblcertdetails As Label = CType(e.Row.FindControl("lblCertDetails"), Label)
                '        Dim txtadmissionreq As TextBox = CType(e.Row.FindControl("txtAdmissionReq"), TextBox)
                '        lblcertdetails.Text = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(137).Item(e.Row.RowIndex).hid
                '        txtadmissionreq.Text = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(137).Item(e.Row.RowIndex).admissionreqdocuments
                '    End If
            End If
        End If
    End Sub
End Class
