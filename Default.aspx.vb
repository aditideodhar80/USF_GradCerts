
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Redirect("users/netidsuccess.aspx")
    End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Response.Redirect("users/netidsuccess.aspx")
    'End Sub
End Class
