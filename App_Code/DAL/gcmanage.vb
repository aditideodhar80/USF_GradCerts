Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Namespace C21MIT.METROINI.DAL
    Public Class gcmanage

#Region "Certificates"

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getcertificates
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 27,2009
        ' Last Updated Dt : Oct 27,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getcertificates() As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getcertificates"
                .CommandType = CommandType.StoredProcedure
            End With

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function

#End Region
#Region "Title and Details"

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : gettitledetails 
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 23,2009
        ' Last Updated Dt : Oct 23,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function gettitledetails(ByVal certid As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_gettitledetails"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Admission Requirements"

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getadmissionrequirements 
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 21,2009
        ' Last Updated Dt : Oct 21,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getadmissionrequirements(ByVal certid As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getadmissionrequirements"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Application Requirements"

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getapplicationrequirements 
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 21,2009
        ' Last Updated Dt : Oct 21,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getapplicationrequirements(ByVal certid As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getapplicationrequirements"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Contacts"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getContacts  
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 21,2009
        ' Last Updated Dt : Oct 21,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getContacts(ByVal certid As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_contacts"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Courses"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getCourses  
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 22,2009
        ' Last Updated Dt : Oct 22,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getCourses(ByVal certid As Integer, ByVal coursetype As String) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getcourses"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_coursetype", coursetype, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Check whether the CERTIFICATE CODE is already present"
        Shared Function fncheckifcertificatepresent(ByVal gctitledetails As C21MIT.METROINI.BO.gctitledetailsobject) As Integer
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable


            With oRequest
                .Command = "dbo.metro_gc_checkcertavailablity"
                .CommandType = CommandType.StoredProcedure
            End With

            ''
            If gctitledetails.hid > 0 Then
                oRequest.AddParameter("@p_certid", gctitledetails.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            Else


            End If
            ''
            oRequest.AddParameter("@p_certcode", gctitledetails.certificatecode, URDALRequest.myDataType.dtString, 4, ParameterDirection.Input)
            oRequest.AddParameter("@p_intCount", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

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

            Return CType(myparOutput("@p_intCount"), Integer)
        End Function
#End Region




#Region "Prerequisites"

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getPREREQUISITES 
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 21,2009
        ' Last Updated Dt : Oct 21,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getprerequisites(ByVal certid As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getprerequisites"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region

#Region "Contacts"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getContacts  
        ' Created By : Aditi Deodhar
        ' Created Dt : Oct 21,2009
        ' Last Updated Dt : Oct 21,2009
        ' Description : This function gets the client master data
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getData(Optional ByVal certid As Integer = 0, Optional ByVal coursetype As String = "") As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.metro_gc_getdata"
                .CommandType = CommandType.StoredProcedure
            End With


            If certid > 0 Then
                oRequest.AddParameter("@p_certid", certid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            Else
                oRequest.AddParameter("@p_certid", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            End If


            If coursetype <> "" Then
                oRequest.AddParameter("@p_coursetype", coursetype, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            Else
                oRequest.AddParameter("@p_coursetype", DBNull.Value, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            End If

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
#End Region
    End Class



End Namespace