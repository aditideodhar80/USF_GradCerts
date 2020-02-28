Imports Microsoft.VisualBasic
Imports System.IO
Imports DotNetCASClient
Partial Class users_netidsuccess
    Inherits System.Web.UI.Page
    Dim casauth As New C21MIT.METROINI.BLL.gcadminacc

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Checks whether the user is present in the CAS system
        casauth.checkcasnetid()
    End Sub
End Class
