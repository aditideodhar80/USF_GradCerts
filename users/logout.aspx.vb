
Partial Class users_logout
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Session.RemoveAll()
        Session.Abandon()

        Dim url As String
        url = ConfigurationManager.AppSettings("logoutUrl") & "?url=" & ConfigurationManager.AppSettings("serviceURL")
        Response.Redirect(url)
    End Sub
End Class
