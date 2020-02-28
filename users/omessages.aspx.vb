
Partial Class users_omessages
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim vMessageIndicator As String = CType(Request.QueryString("qModule"), String)

        If IsNothing(vMessageIndicator) Then
            vMessageIndicator = ""
        End If

        Dim vEMessage As C21MIT.METROINI.BO.EMessageObj
        vEMessage = C21MIT.VOCALDISORDERS.Util.vdmessagemanager.EPageMessage(vMessageIndicator)

        lblHeader.Text = vEMessage.EPageHeader
        lblMessage.Text = vEMessage.EPageMessage

        hlinkNext.Visible = False

        If vEMessage.LinkVisible Then
            hlinkNext.Visible = True
            hlinkNext.Text = vEMessage.LinkText
            ' hlinkNext.NavigateUrl = vEMessage.LinkPath
            hlinkNext.NavigateUrl = ConfigurationManager.AppSettings("serviceURL")
        End If
    End Sub
End Class
