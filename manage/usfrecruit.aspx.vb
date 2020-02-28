Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports URDAL
Imports System.Data.SqlClient

Partial Class manage_usfrecruit
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'bindpanel4()
            'Return



            Dim ImageID As Integer = Convert.ToInt32(176)

            'Connect to the database and bring back the image contents & MIME type for the specified picture
            Using myConnection As New SqlConnection(ConfigurationManager.AppSettings("conApp"))

                Const SQL As String = "SELECT hid, picturelink FROM [gccontacts] WHERE [hid] = @ImageID"
                Dim myCommand As New SqlCommand(SQL, myConnection)
                myCommand.Parameters.AddWithValue("@ImageID", ImageID)

                myConnection.Open()
                Dim myReader As SqlDataReader = myCommand.ExecuteReader

                If myReader.Read Then
                    ' Response.ContentType = myReader("pict_type").ToString()
                    Response.BinaryWrite(myReader("picturelink"))
                End If

                myReader.Close()
                myConnection.Close()
            End Using
        End If
    End Sub




    Protected Sub bindpanel4()
        gvcontacts.DataSource = C21MIT.METROINI.BLL.mimanage.getContactList(248)
        gvcontacts.DataBind()
    End Sub

    Protected Sub save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles save.Click
        saveonclick()
        bindpanel4()
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

            Dim objContactsUpdate As New C21MIT.METROINI.BO.gccontactsobject

            objContactsUpdate.hid = lblhid.Text
            objContactsUpdate.hcertificatedetails = lblcertid.Text
            objContactsUpdate.firstname = txtFName.Text
            objContactsUpdate.lastname = txtLName.Text
            objContactsUpdate.phone = txtPhone.Text
            objContactsUpdate.email = txtEmail.Text

            '  C21MIT.METROINI.BLL.miupdateinsertcontacts.updateinsertcontacts(objContactsUpdate)
        Next
    End Sub
    'Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

    '    Dim objcontacts As New C21MIT.METROINI.BO.gccontactsobject

    '    objcontacts.hcertificatedetails = 248
    '    objcontacts.firstname = txtFirstName.Text
    '    objcontacts.lastname = txtLastName.Text
    '    objcontacts.phone = txtPhone.Text
    '    objcontacts.email = txtEmail.Text

    '    C21MIT.METROINI.BLL.miinsertcontacts.insertcontacts(objcontacts)
    '    txtFirstName.Text = ""
    '    txtLastName.Text = ""
    '    txtPhone.Text = ""
    '    txtEmail.Text = ""
    '    bindpanel4()


    'End Sub

    'Protected Sub btnSubmit4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit4.Click
    '    If Not (Request.QueryString("task") Is Nothing) Then
    '        'stask = Request.QueryString("task")

    '        'If stask = "AddNew" Then
    '        '    UpdateStatus4("TABPANEL4", Session("currentcert"))

    '        'ElseIf stask = "Edit" Then
    '        '    UpdateStatus4("TABPANEL4", Request.QueryString("certid"))

    '        'ElseIf stask = "Pending" Then
    '        '    UpdateStatus4("TABPANEL4", Request.QueryString("certid"))
    '        'End If
    '    End If
    'End Sub
End Class
