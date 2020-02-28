Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data

Namespace C21MIT.METROINI.DAL
    Public Class miuseraccount
#Region "User validation"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fnvalidateuser  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 09,2009
        ' Last Updated Dt : April 09,2009
        ' Description : This procedure is used when the netID authentication has verified the user 
        ' and we need to find out the access level for the user in the UR system.
        ' The procedure should be directly used in case of Admin login when they want access to the student/faculty profiles
        '-------------------------------------------------------------------------------------------------------------------
        Public Function fnvalidateuser(ByVal pNetId As String) As C21MIT.METROINI.BO.miprimtrackerobject
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory


            Dim myparOutput As New Hashtable
            Dim objPrimTracker As New C21MIT.METROINI.BO.miprimtrackerobject
            With oRequest
                .Command = "dbo.metro_logincheck"
                .CommandType = Data.CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_urid", , URDALRequest.myDataType.dtInteger, , Data.ParameterDirection.Output)
            oRequest.AddParameter("@p_urnetid", pNetId, URDALRequest.myDataType.dtString, 20, Data.ParameterDirection.Input)
            oRequest.AddParameter("@p_urfname", , URDALRequest.myDataType.dtString, 20, Data.ParameterDirection.Output)
            oRequest.AddParameter("@p_urlname", , URDALRequest.myDataType.dtString, 50, Data.ParameterDirection.Output)
            oRequest.AddParameter("@p_urrole", , URDALRequest.myDataType.dtInteger, , Data.ParameterDirection.Output)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
            If myparOutput("@p_urid") Is System.DBNull.Value Then
                Return Nothing

            Else
                objPrimTracker.UserId = CType(myparOutput("@p_urid"), Integer)
                objPrimTracker.NetId = System.Web.HttpContext.Current.Session("netid")
                objPrimTracker.FirstName = CType(myparOutput("@p_urfname"), String)
                objPrimTracker.LastName = CType(myparOutput("@p_urlname"), String)
                objPrimTracker.UserRole = CType(myparOutput("@p_urrole"), Integer)

                Return objPrimTracker
            End If
        End Function
#End Region



    End Class
End Namespace