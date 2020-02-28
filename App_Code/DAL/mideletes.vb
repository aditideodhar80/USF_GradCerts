Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Namespace C21MIT.METROINI.DAL
    Public Class mideletes
#Region "Admission Requirements"


        Shared Sub deleteadmissionrequirements(ByVal objadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deleteadmissionrequirements"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objadmissionreq.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region


#Region "Application Requirements"


        Shared Sub deleteapplicationrequirements(ByVal objapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deleteapplicationrequirements"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objapplicationreq.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region

#Region "Contacts"


        Shared Sub deletecontacts(ByVal objcontacts As C21MIT.METROINI.BO.gccontactsobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deletecontacts"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objcontacts.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region


#Region "Certificates"


        Shared Sub deletecerts(ByVal certid As Integer)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deletecertificate"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region


#Region "Courses"


        Shared Sub deletecourses(ByVal objdeletecourses As C21MIT.METROINI.BO.gccoursesobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deletecourses"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objdeletecourses.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            ' oRequest.AddParameter("@p_coursetype", coursetype, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region

#Region "Prerequisites"


        Shared Sub deleteprereqs(ByVal objdeleteprereqs As C21MIT.METROINI.BO.gcprequisites)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "metro_gc_deleteprereqs"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objdeleteprereqs.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
        End Sub
#End Region
    End Class
End Namespace