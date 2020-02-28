Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports URDAL
Partial Class manage_TEST
    Inherits System.Web.UI.Page
    Dim stask As String
    Dim CertId As Integer


    Dim mypanel2text As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    stask = "Edit"
        '    ' If Not (Request.QueryString("task") Is Nothing) Then
        '    ' stask = Request.QueryString("task")
        '    If stask = "Edit" Then
        '        SetInitialRow1()
        '        bindAdmissionrequirements(stask, 147)

        '    End If
        '    'End If
        'End If

        ''If  tab1.ActiveTabIndex = "1"TabPanel1" Then
        ''    Response.Write("here")
        ''End If
    End Sub
    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        If Not IsPostBack Then
            '  If Not (Request.QueryString("task") Is Nothing) Then
            'stask = Request.QueryString("task")
            stask = "Edit"
            If stask = "AddNew" Then

                Panel3.Enabled = False
             


                'Bind all the PANELS


                'ADMISSION REQUIREMENTS START

                bindAdmissionrequirements(stask)
                'ADMISSION REQUIREMENTS END






            ElseIf stask = "Edit" Then
                '  If Not (Request.QueryString("certid") Is Nothing) Then
                'CertId = Request.QueryString("")

                'Bind all the PANELS

               


                'ADMISSION REQUIREMENTS START
                gvAdmissionReq.Clear()
                bindAdmissionrequirements(stask, 203)
                'ADMISSION REQUIREMENTS END
            ElseIf stask = "Pending" Then

            End If

        Else

        End If
    End Sub
    'Protected Sub bindAdmissionrequirements(ByVal stask As String, ByVal certid As Integer)
    '    'If stask is add, then bind empty controls on the form

    '    If stask = "Edit" Then
    '        If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Count > 0 Then
    '            gvAdmissionReq.DataSource = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid)
    '            gvAdmissionReq.DataBind()
    '        ElseIf C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Count = 0 Then
    '            gvAdmissionReq.EmptyDataText = "No Data Found."
    '        End If
    '    End If
    'End Sub

    'Protected Sub btnAddNewRow1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewRow1.Click

    '    AddNewRowToGrid1()

    'End Sub


    'Private Sub SetInitialRow1()
    '    Dim dt As New DataTable()
    '    Dim dr As DataRow = Nothing
    '    Dim i As Integer
    '    dt.Columns.Add(New DataColumn("hid", GetType(Integer)))
    '    ' dt.Columns.Add(New DataColumn("RowNumber", GetType(Integer)))
    '    dt.Columns.Add(New DataColumn("hcertificatedetails", GetType(Integer)))
    '    dt.Columns.Add(New DataColumn("admissionreqdocuments", GetType(String)))


    '    Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
    '    '  Dim dgitem1 As GridViewRow
    '    ' For Each dgitem1 In gvAdmissionReq.Rows

    '    For i = 0 To C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Count - 1

    '        dr = dt.NewRow()
    '        dr("hid") = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Item(0).hid
    '        dr("hcertificatedetails") = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Item(0).hcertificatedetails
    '        dr("admissionreqdocuments") = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(147).Item(0).admissionreqdocuments

    '    Next
    '    dt.Rows.Add(dr)

    '    'Store the DataTable in ViewState
    '    ViewState("CurrentTable1") = dt

    '    gvAdmissionReq.DataSource = dt
    '    gvAdmissionReq.DataBind()
    'End Sub
#Region "PANEL 2"
    Protected Sub btnAdd1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
        Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow

        row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
        If btnAdd1.Text = "Add" Then
            If row Is Nothing Then
                objadmissionreq.iorder = 1
            Else
                objadmissionreq.iorder = CType(row.Cells.FromKey("i_order").Value, Integer) + 1
            End If

            objadmissionreq.hid = 1
            objadmissionreq.hcertificatedetails = 203
            objadmissionreq.admissionreqdocuments = ""
            gvAdmissionReq.DisplayLayout.Rows.Add()

            C21MIT.METROINI.DAL.miinserts.insertadmissionrequirements(objadmissionreq)

            UIOnAddClick1()
            'ADMISSION REQUIREMENTS START
            bindAdmissionrequirements(stask, 203)
            'ADMISSION REQUIREMENTS END

        Else
            objadmissionreq.hid = row.Cells.FromKey("hid").Value
            C21MIT.METROINI.BLL.mideletes.mideleteadmissionreq.deleteadmissionreq(objadmissionreq)
            row.Delete()
            btnAdd1.Text = "Add"
        End If
    End Sub

    Protected Sub txtPanel2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox2 As TextBox = CType(sender, TextBox)
        mypanel2text = Server.HtmlEncode(txtbox2.Text)
    End Sub

    Protected Sub UIOnAddClick1()
        btnDelete1.Enabled = False
        btnUpdate1.Text = "Save"
        btnAdd1.Text = "Cancel"
    End Sub

    Protected Sub insertblankadmissionrequirements(ByVal sessionid As Integer, ByVal objadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)
        ' Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
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
    Protected Sub bindAdmissionrequirements(ByVal stask As String, Optional ByVal certid As Integer = 0)
        'If stask is add, then bind empty controls on the form

        If certid > 0 Then
            If C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid).Count > 0 Then
                gvAdmissionReq.DataSource = C21MIT.METROINI.BLL.mimanage.getAdmissionRequirementsList(certid)
                gvAdmissionReq.DataBind()
            End If

            If btnAdd1.Text = "Cancel" Then

                Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
                gvAdmissionReq.DisplayLayout.ActiveRow = row

                '

            End If
        ElseIf certid = 0 Then
            'Do nothing to the Gridview
            If btnAdd1.Text = "Cancel" Then

                Dim row As Infragistics.WebUI.UltraWebGrid.UltraGridRow
                row = gvAdmissionReq.DisplayLayout.Rows(gvAdmissionReq.Rows.Count - 1)
                gvAdmissionReq.DisplayLayout.ActiveRow = row
                gvAdmissionReq.Rows.Add(row)
                bindAdmissionrequirements(stask, 203)
            End If
        End If

    End Sub

    Protected Sub btnUpdate1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate1.Click

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
            objadmissionreq.hcertificatedetails = 203
            objadmissionreq.admissionreqdocuments = mypanel2text

            C21MIT.METROINI.BLL.miupdateinsertadmissionreq.updateinsertadmissionreq(objadmissionreq)
            UIOnAddSavedCanceled1()
        End If




    End Sub

    Protected Sub UIOnAddSavedCanceled1()
        btnDelete1.Enabled = True
        btnUpdate1.Text = "Update"
        btnAdd1.Text = "Add"

    End Sub
#End Region

    'Private Sub AddNewRowToGrid1()
    '    ''Dim ds As New DataSet
    '    ''Dim dv As DataView
    '    ''ds = C21MIT.METROINI.DAL.gcmanage.getadmissionrequirements(147)
    '    ''dv = New DataView(ds.Tables(0))
    '    ''Dim newRow As DataRowView = dv.AddNew()
    '    ''newRow("hid") = 1
    '    ''newRow("hcertificatedetails") = 1
    '    ''newRow("admissionreqdocuments") = ""
    '    ''newRow.EndEdit()


    '    ''dv.Sort = "hid"

    '    ''gvAdmissionReq.DataSource = dv
    '    Dim rowIndex As Integer = 0
    '    Dim ds As New DataSet
    '    Dim dt As New DataTable
    '    ds = C21MIT.METROINI.DAL.gcmanage.getadmissionrequirements(147)
    '    ViewState("CurrentTable") = ds
    '    ds = DirectCast(ViewState("CurrentTable"), DataSet)

    '    Dim drCurrentRow As DataRow = Nothing
    '    If ds.Tables.Count > 0 Then
    '        For i As Integer = 1 To dt.Rows.Count
    '            'extract the TextBox values
    '            Dim box7 As TextBox = DirectCast(gvAdmissionReq.Rows(rowIndex).Cells(1).FindControl("txtReqCourses"), TextBox)

    '            drCurrentRow = dt.NewRow()
    '            drCurrentRow("hid") = i + 1
    '            dt.Rows(i - 1)("coursename") = box7.Text

    '            rowIndex += 1
    '        Next
    '        dt.Rows.Add(drCurrentRow)

    '        ViewState("CurrentTable4") = dt

    '        gvAdmissionReq.DataSource = dt
    '        gvAdmissionReq.DataBind()
    '    End If


    '    'Set Previous Data on Postbacks
    '    'SetPreviousData1()
    'End Sub

    '  Private Sub SetPreviousData1()
    '    Dim rowIndex As Integer = 0
    '    If ViewState("CurrentTable1") IsNot Nothing Then
    '        Dim dt As DataTable = DirectCast(ViewState("CurrentTable1"), DataTable)
    '        If dt.Rows.Count > 0 Then
    '            For i As Integer = 0 To dt.Rows.Count - 1
    '                Dim box1 As TextBox = DirectCast(gvAdmissionReq.Rows(rowIndex).Cells(1).FindControl("txtAdmissionReq"), TextBox)
    '                box1.Text = dt.Rows(i)("admissionreqdocuments").ToString()

    '                rowIndex += 1
    '            Next
    '        End If
    '    End If
    'End Sub

    'Protected Sub insertblankadmissionrequirements(ByVal sessionid As Integer, ByVal admissionrequirements As String)
    '    Dim objadmissionreq As New C21MIT.METROINI.BO.gcadmissionreqobj
    '    Dim i As Integer

    '    For i = 1 To 1
    '        Dim txtAdmisReq As TextBox = CType(gvAdmissionReq.FindControl("txtAdmissionReq"), TextBox)
    '        Dim lblRN As Label = CType(gvAdmissionReq.FindControl("lblRowNumber"), Label)
    '        'Save the gridview to the database
    '        objadmissionreq.hcertificatedetails = sessionid
    '        objadmissionreq.admissionreqdocuments = ""

    '        C21MIT.METROINI.BLL.miinsertadmissionreq.insertadmissionreq(objadmissionreq)
    '    Next
    'End Sub

 

    Protected Sub btnSaveTitleDetails_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveTitleDetails.Click
        'Insert data in the table

        If chechcertavailablity(txtcertcode.Text.Trim) = 1 Then
            Panel2.Enabled = True
            Panel3.Enabled = True
           
        Else
            Panel2.Enabled = True
            Panel3.Enabled = True
       
        End If
        inserttitledetails()
        ' Response.Write(Session("currenthid"))
        'try inserting one record here with the sessionid as hcertificatedetails
        If Not Session("currentcert") Is Nothing Then
            If Session("insertblankadmissionreq") = "true" Then
                Exit Sub
            End If
            Session("insertblankadmissionreq") = "true"
        Else
            Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
        End If
    End Sub

    Protected Function chechcertavailablity(ByVal certcode As String) As Integer
        Dim objcertcode As New C21MIT.METROINI.BO.gctitledetailsobject
        objcertcode.certificatecode = certcode

        Dim intCount As Integer
        intCount = C21MIT.METROINI.BLL.mimanage.fncheckCertificateAvailable(objcertcode)

        Return intCount
    End Function

    Protected Sub inserttitledetails()
        If chechcertavailablity(txtcertcode.Text.Trim) = 1 Then
            lblfinal1.Text = "The certificate is already present in the system. Please select a different code."
            lblfinal1.ForeColor = Drawing.Color.Red
            Panel2.Enabled = True
            Panel3.Enabled = True
         
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

        Dim currentcert As Integer
        currentcert = C21MIT.METROINI.BLL.miinserttitledetails.inserttitledetails(objtitledesc)

        Session("currentcert") = currentcert
    End Sub


    Protected Sub btnDelete1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
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
End Class
