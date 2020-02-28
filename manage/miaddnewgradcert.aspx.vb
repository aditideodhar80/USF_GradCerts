
Partial Class admin_gc_addnewgradcert
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If txtReqcoursesToBeAdded.Text <> "" Then
                addRequiredcoursetextboxes()
            End If

            If txtNoofDocs.Text <> "" Then
                addAdmissionrequirementtextboxes()
            End If

            If txtNoofAppReq.Text <> "" Then
                addApplicationrequirementtextboxes()
            End If
        Else
            If txtReqcoursesToBeAdded.Text <> "" Then

                addRequiredcoursetextboxes()
            End If

            If txtNoofDocs.Text <> "" Then
                addAdmissionrequirementtextboxes()
            End If

            If txtNoofAppReq.Text <> "" Then
                addApplicationrequirementtextboxes()
            End If
        End If









        Dim Tabid As String
        Tabid = (Request.QueryString("tabid"))

        If Tabid = "TabPanel1" Then
            tab1.ActiveTab = TabPanel1
        End If
        If Tabid = "TabPanel2" Then
            tab1.ActiveTab = TabPanel1
        End If


        Panel1.Visible = True
        hyl1.ForeColor = Drawing.Color.Red
        hyl1.Font.Bold = True
        hyl2.Enabled = False
        hyl3.Enabled = False
        hyl4.Enabled = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False


    End Sub

 
    Protected Sub btnCreateTextboxes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateTextboxes.Click
        'get the number of textboxes to be created

        ''  addAdmissionrequirementtextboxes()

    End Sub

    Protected Sub addAdmissionrequirementtextboxes()
        Dim i As Integer
        Dim numtextboxes As Integer

        numtextboxes = CInt(txtNoofDocs.Text)

        For i = 1 To numtextboxes

            Dim txtAdmissionReqDoc As TextBox = New TextBox
            Dim lblAdReq As Label = New Label
            'Set the textbox's ID Properties


            lblAdReq.ID = "lblAdmissionReq" & i
            lblAdReq.Text = i & ". "


            txtAdmissionReqDoc.ID = "txtAdmissionRqdDoc" & i
            txtAdmissionReqDoc.Width = 400
            txtAdmissionReqDoc.MaxLength = 250

            txtAdmissionReqDoc.Text = txtAdmissionReqDoc.Text
            PHAdmissionReq.Controls.Add(lblAdReq)
            PHAdmissionReq.Controls.Add(txtAdmissionReqDoc)
            'Add a spacer

            Dim spacer As LiteralControl = New LiteralControl("<br /><br />")
            PHAdmissionReq.Controls.Add(spacer)

        Next
    End Sub

    Protected Sub btnAddAppreqs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddAppreqs.Click
        'get the number of textboxes to be created

        ''  addApplicationrequirementtextboxes()
        ''  addAdmissionrequirementtextboxes()


        'ON THE CLICK OF THIS BUTTON PERSIST THE VALUES OF THE TEXTBOXES ABOVE AS FOLLOWS -

    End Sub

    Protected Sub addApplicationrequirementtextboxes()

        Dim i As Integer
        Dim numtextboxes As Integer

        numtextboxes = CInt(txtNoofAppReq.Text)

        For i = 1 To numtextboxes

            Dim txtApplicationReqDoc As TextBox = New TextBox
            Dim lblAppReq As Label = New Label
            'Set the textbox's ID Properties


            lblAppReq.ID = "lblApplicationReq" & i
            lblAppReq.Text = i & ". "


            txtApplicationReqDoc.ID = "txtApplicationRqdDoc" & i
            txtApplicationReqDoc.Width = 400
            txtApplicationReqDoc.MaxLength = 250

            PHApplicationReq.Controls.Add(lblAppReq)
            PHApplicationReq.Controls.Add(txtApplicationReqDoc)
            'Add a spacer

            Dim spacer As LiteralControl = New LiteralControl("<br /><br />")
            PHApplicationReq.Controls.Add(spacer)


        Next
    End Sub

    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNext.Click
        Panel2.Visible = True
        Panel1.Visible = False
        hyl1.Enabled = False
        hyl2.Enabled = True
        hyl2.ForeColor = Drawing.Color.Red
        hyl2.Font.Bold = True

    End Sub

    Protected Sub btnAddProceed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddProceed.Click
        'save contact and proceed


        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = True
        hyl4.Enabled = False

        hyl3.ForeColor = Drawing.Color.Red
        hyl3.Font.Bold = True
    End Sub

    Protected Sub btnToContacts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnToContacts.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False

        hyl1.Enabled = False
        hyl2.Enabled = True
        hyl3.Enabled = False
        hyl4.Enabled = False

        hyl2.ForeColor = Drawing.Color.Red
        hyl2.Font.Bold = True
    End Sub

    Protected Sub addRequiredcoursetextboxes()
        PHRequiredCourses.Controls.Clear()
        Dim i As Integer
        Dim numtextboxes As Integer

        numtextboxes = CInt(txtReqcoursesToBeAdded.Text)

        For i = 1 To numtextboxes

            Dim txtReqcoursesToBeAdded As TextBox = New TextBox
            Dim lblReqCourses As Label = New Label
            'Set the textbox's ID Properties


            lblReqCourses.ID = "lblRequiredCourses" & i
            lblReqCourses.Text = i & ". "


            txtReqcoursesToBeAdded.ID = "txtRequiredCourses" & i
            txtReqcoursesToBeAdded.Width = 400
            'txtReqcoursesToBeAdded.Text = txtReqcoursesToBeAdded.Text
            txtReqcoursesToBeAdded.MaxLength = 250

            PHRequiredCourses.Controls.Add(lblReqCourses)
            PHRequiredCourses.Controls.Add(txtReqcoursesToBeAdded)
            'Add a spacer

            Dim spacer As LiteralControl = New LiteralControl("<br /><br />")
            PHRequiredCourses.Controls.Add(spacer)


        Next

      
    End Sub

    Protected Sub btnAddRequiredCourses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddRequiredCourses.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = True
        hyl4.Enabled = False

        hyl3.ForeColor = Drawing.Color.Red
        hyl3.Font.Bold = True
        'addRequiredcoursetextboxes()
    End Sub

    Protected Sub btnSaveRequiredCourses_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveRequiredCourses.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = False
        hyl4.Enabled = True

        hyl4.ForeColor = Drawing.Color.Red
        hyl4.Font.Bold = True

        'TRIAL
        Dim txt As TextBox = New TextBox
        Dim i As Integer
       
        ' Dim textval As String
        Dim numtextboxes As Integer

       
        numtextboxes = CInt(txtReqcoursesToBeAdded.Text)



        'For Each c As Control In PHRequiredCourses.Controls
        '    PHRequiredCourses.FindControl("ctl00_ContentPlaceHolder1_tab1_TabPanel2_txtRequiredCourses")
        'Next

        ''For i = 1 To numtextboxes
        ''    'Dim txtctrl As TextBox = PHRequiredCourses.FindControl("ctl00_ContentPlaceHolder1_tab1_TabPanel2_txtRequiredCourses" & i.ToString)
        ''    Dim txtctrl As TextBox = DirectCast(FindControl("ctl00_ContentPlaceHolder1_tab1_TabPanel2_txtRequiredCourses" & i.ToString), TextBox)

        ''    If txtctrl Is Nothing Then
        ''    Else
        ''        textval = txtctrl.Text
        ''        Response.Write(textval)
        ''    End If
        ''Next


        For i = 1 To numtextboxes
            Dim txtctrl As TextBox = PHRequiredCourses.FindControl("txtRequiredCourses" & i.ToString)

            If txtctrl Is Nothing Then
                ' TextBox1.Text = TextBox1.Text & "," & txtctrl.Text
            Else
                'INSERT INTO THE DATABASE HERE
                'Response.Write(txtctrl.Text)
            End If
        Next
        'TRIAL END
    End Sub

    Protected Sub btnAddElectiveCourses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddElectiveCourses.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = False
        hyl4.Enabled = True

        hyl4.ForeColor = Drawing.Color.Red
        hyl4.Font.Bold = True
        addElectivecoursetextboxes()
    End Sub


    Protected Sub addElectivecoursetextboxes()

        Dim i As Integer
        Dim numtextboxes As Integer

        numtextboxes = CInt(txtElectiveCourses.Text)

        For i = 1 To numtextboxes

            Dim txtElectiveCourses As TextBox = New TextBox
            Dim lblElecCourses As Label = New Label
            'Set the textbox's ID Properties


            lblElecCourses.ID = "lblElectiveCourses" & i
            lblElecCourses.Text = i & ". "


            txtElectiveCourses.ID = "txtElectiveCourses" & i
            txtElectiveCourses.Width = 400
            txtElectiveCourses.MaxLength = 250

            PHElectives.Controls.Add(lblElecCourses)
            PHElectives.Controls.Add(txtElectiveCourses)
            'Add a spacer

            Dim spacer As LiteralControl = New LiteralControl("<br /><br />")
            PHElectives.Controls.Add(spacer)


        Next


    End Sub

    Protected Sub btnSaveElectives_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSaveElectives.Click
        ' Response.Redirect("miaddnewgradcert.aspx?tabid=TabPanel2")

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = False
        hyl4.Enabled = True

        hyl4.ForeColor = Drawing.Color.Red
        hyl4.Font.Bold = True
    End Sub

   
    Protected Sub btnTorequiredCourses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTorequiredCourses.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False

        hyl1.Enabled = False
        hyl2.Enabled = False
        hyl3.Enabled = True
        hyl4.Enabled = False

        hyl3.ForeColor = Drawing.Color.Red
        hyl3.Font.Bold = True
    End Sub

    Protected Sub btnSaveAnother_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveAnother.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False

        hyl1.Enabled = False
        hyl2.Enabled = True
        hyl3.Enabled = False
        hyl4.Enabled = False

        hyl2.ForeColor = Drawing.Color.Red
        hyl2.Font.Bold = True

        'IF THE RECORD IS ADDED THEN DISPLAY A MESSAGE HERE
    End Sub
End Class
