Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BLL
    Public Class gcadminacc
#Region "Authentication"
        '---------------------------------------------------------------------------------------------------
        ' Procedure Name : checkcasnetid  
        ' Created By : Aditi Deodhar
        ' Created Dt : Mar 13,2009
        ' Last Updated Dt: Mar 13,2009
        ' Description : This procedure checks and returns the netid from the Central 
        '               Authentication Service
        ''----------------------------------------------------------------------------------------------------
        Public Sub checkcasnetid()
            Dim client As New DotNetCASClient.DotNetCASClientServiceValidate()
            Dim userId As String = client.Authenticate(System.Web.HttpContext.Current.Request, System.Web.HttpContext.Current.Response, False)
            System.Web.HttpContext.Current.Session("netid") = userId
            If (userId.Equals("failed")) Then
                'Handle the auth failure...
                System.Web.HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=NoNode", False)
            Else
                'Check for internal session
                LoginCheck(userId)

            End If
        End Sub
     
#End Region
#Region "Authorization"
        Shared Function IsUserLoggedIn() As Boolean
            Dim s_urdet As String = System.Web.HttpContext.Current.Session("sPrimTracker")
            'Dim s_urdet As String = System.Web.HttpContext.Current.Session("netid")
            Dim strnetid As String = System.Web.HttpContext.Current.Session("netid")


            If IsNothing(s_urdet) Or s_urdet = "" Then
                Return False
            Else
                Return True
            End If
        End Function


        Shared Sub EnsureAdminAccess()
            Dim _vUrAccess As Integer = GetUserAccess(System.Web.HttpContext.Current.Session("sPrimTracker"))

            If Not _vUrAccess.Equals(1) Then
                System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/smessages.aspx?qModule=InvalidAuthorization")
            End If
        End Sub

        Shared Function GetUserAccess(ByVal sPrimTracker As String) As Integer
            Dim urDetCol() As String

            If IsNothing(sPrimTracker) Then
                System.Web.HttpContext.Current.Response.Redirect _
                               ("~/users/omessages.aspx?qModule=InvalidSession")
            End If

            urDetCol = sPrimTracker.Split(",")
            Return CType(urDetCol(4), Integer)
        End Function

#End Region


#Region "Authorization - Application"
        '---------------------------------------------------------------------------------------------------
        ' Procedure Name : LoginCheck  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 09,2009
        ' Last Updated Dt: May 08,2009
        ' Description : Evaluates user LoginCheck/If valid returns the PrimTrackerString. Also returns the
        '               sClientTracker if the user has already selected the client.                        
        '---------------------------------------------------------------------------------------------------
        Shared Sub LoginCheck(ByVal pNetId As String)
            Dim objUrAccount As New C21MIT.METROINI.DAL.miuseraccount
            Dim vPrimTracker As New C21MIT.METROINI.BO.miprimtrackerobject

            vPrimTracker = objUrAccount.fnvalidateuser(pNetId)

            If vPrimTracker Is Nothing Then
                System.Web.HttpContext.Current.Session("netid") = DBNull.Value.ToString
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidLogin", False)
            Else
                If vPrimTracker.UserId > 0 Then
                    System.Web.HttpContext.Current.Session("sPrimTracker") = vPrimTracker.PTrackerSession
                    System.Web.HttpContext.Current.Session("sDKey") = C21MIT.Util.RandomKeyString.Generate(32)

                    If vPrimTracker.UserRole = 1 Then
                        System.Web.HttpContext.Current.Response.Redirect("~/manage/miviewcerts.aspx")
                    Else
                        System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InActiveAccount", False)
                    End If
                Else
                    System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidLogin", False)
                End If
               
            End If

        End Sub
#End Region


    End Class

End Namespace