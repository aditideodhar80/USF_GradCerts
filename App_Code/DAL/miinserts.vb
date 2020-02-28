Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Namespace C21MIT.METROINI.DAL

    Public Class miinserts

#Region "Title and Description"

        Shared Function inserttitledescription(ByVal objtitledesc As C21MIT.METROINI.BO.gctitledetailsobject) As Integer

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_inserttitledetails"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certcode", objtitledesc.certificatecode, URDALRequest.myDataType.dtString, 4, ParameterDirection.Input)
            oRequest.AddParameter("@p_certname", objtitledesc.certificatename, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_collegecode", objtitledesc.collegecode, URDALRequest.myDataType.dtString, 10, ParameterDirection.Input)
            oRequest.AddParameter("@p_linkname", objtitledesc.linkname, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_certtitle", objtitledesc.certificatetitle, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_courselocation", objtitledesc.courselocation, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_briefdesc", objtitledesc.briefdesc, URDALRequest.myDataType.dtString, 5000, ParameterDirection.Input)
            oRequest.AddParameter("@p_CEU", objtitledesc.CEU, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_credittograd", objtitledesc.credittograd, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_transfercredit", objtitledesc.transfercredit, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_standardtests", objtitledesc.standardtests, URDALRequest.myDataType.dtString, 5000, ParameterDirection.Input)
            oRequest.AddParameter("@p_prereq", objtitledesc.prerequisites, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_admissionreq", objtitledesc.admissionreq, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_appprocess", objtitledesc.appprocess, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_registrationprocess", objtitledesc.registrationprocess, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_tutionfees", objtitledesc.tuitionfees, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_financialaid", objtitledesc.financialaid, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_timelimit", objtitledesc.timelimit, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_deptwebsite", objtitledesc.deptwebsite, URDALRequest.myDataType.dtString, 200, ParameterDirection.Input)
            oRequest.AddParameter("@p_requiredcourseinfo", objtitledesc.requiredcourseinfo, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_electivecourseinfo", objtitledesc.electivecourseinfo, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_certtype", objtitledesc.certtype, URDALRequest.myDataType.dtString, 3, ParameterDirection.Input)
            oRequest.AddParameter("@p_hid", objtitledesc.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                '  oScalar = oFactory.ExecuteScalar(oRequest)
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
            Return CType(myparOutput("@p_hid"), Integer)
        End Function


        Shared Function updateinserttitledescription(ByVal objtitledesc As C21MIT.METROINI.BO.gctitledetailsobject) As Integer

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updatetitledetails"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid", objtitledesc.hid, URDALRequest.myDataType.dtString, 4, ParameterDirection.Input)
            oRequest.AddParameter("@p_certcode", objtitledesc.certificatecode, URDALRequest.myDataType.dtString, 4, ParameterDirection.Input)
            oRequest.AddParameter("@p_certname", objtitledesc.certificatename, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_collegecode", objtitledesc.collegecode, URDALRequest.myDataType.dtString, 10, ParameterDirection.Input)
            oRequest.AddParameter("@p_linkname", objtitledesc.linkname, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_certtitle", objtitledesc.certificatetitle, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
            oRequest.AddParameter("@p_courselocation", objtitledesc.courselocation, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_briefdesc", objtitledesc.briefdesc, URDALRequest.myDataType.dtString, 5000, ParameterDirection.Input)
            oRequest.AddParameter("@p_CEU", objtitledesc.CEU, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_credittograd", objtitledesc.credittograd, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_transfercredit", objtitledesc.transfercredit, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_standardtests", objtitledesc.standardtests, URDALRequest.myDataType.dtString, 5000, ParameterDirection.Input)
            oRequest.AddParameter("@p_prereq", objtitledesc.prerequisites, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_admissionreq", objtitledesc.admissionreq, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_appprocess", objtitledesc.appprocess, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_registrationprocess", objtitledesc.registrationprocess, URDALRequest.myDataType.dtString, 1500, ParameterDirection.Input)
            oRequest.AddParameter("@p_tutionfees", objtitledesc.tuitionfees, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_financialaid", objtitledesc.financialaid, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_timelimit", objtitledesc.timelimit, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_deptwebsite", objtitledesc.deptwebsite, URDALRequest.myDataType.dtString, 200, ParameterDirection.Input)
            oRequest.AddParameter("@p_requiredcourseinfo", objtitledesc.requiredcourseinfo, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_electivecourseinfo", objtitledesc.electivecourseinfo, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_certtype", objtitledesc.certtype, URDALRequest.myDataType.dtString, 3, ParameterDirection.Input)


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
            ' Return CType(myparOutput("@p_hid"), Integer)
        End Function

#End Region

#Region "Admission Requirements"


        Shared Sub updateinsertadmissionrequirements(ByVal objadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updateinsertadmissionreq"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_hid", objadmissionreq.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid", objadmissionreq.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_admissionreqdocuments", objadmissionreq.admissionreqdocuments, URDALRequest.myDataType.dtString, 250, ParameterDirection.Input)

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

        End Sub

        Shared Sub insertadmissionrequirements(ByVal objadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_insertadmissionreq"
                .CommandType = CommandType.StoredProcedure
            End With
            '   oRequest.AddParameter("@p_hid ", objadmissionreq.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid ", objadmissionreq.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_admissionreqdocuments", objadmissionreq.admissionreqdocuments, URDALRequest.myDataType.dtString, 250, ParameterDirection.Input)
            '  oRequest.AddParameter("@p_iorder", objadmissionreq.iorder, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

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

        End Sub

#End Region

#Region "Application Requirements"

        Shared Sub updateinsertapplicationrequirements(ByVal objapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updateinsertapplicationreq"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_hid", objapplicationreq.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid", objapplicationreq.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_applicationrequirements", objapplicationreq.applicationrequirements, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)

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

        End Sub


        Shared Sub insertapplicationrequirements(ByVal objapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_insertapplicationreq"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid ", objapplicationreq.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_applicationreqdocuments", objapplicationreq.applicationrequirements, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)

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

        End Sub


#End Region

#Region "Contacts"

        Shared Sub updateinsertcontacts(ByVal objcontacts As C21MIT.METROINI.BO.gccontactsobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updateinsertcontacts"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_hid ", objcontacts.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid ", objcontacts.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_fname", objcontacts.firstname, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_lname", objcontacts.lastname, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_phone", objcontacts.phone, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_email", objcontacts.email, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            ' oRequest.AddParameter("@p_picturelink", objcontacts.picturelink, URDALRequest.myDataType.dtImage, , ParameterDirection.Input)


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

        End Sub

        '        Shared Sub insertcontacts(ByVal objcontacts As C21MIT.METROINI.BO.gccontactsobject, ByVal imagecontent As Byte(), ByVal imgtype As String)
        Shared Sub insertcontacts(ByVal objcontacts As C21MIT.METROINI.BO.gccontactsobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_insertcontacts"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim str As String
            str = Convert.ToByte(0)
            oRequest.AddParameter("@p_certid ", objcontacts.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_fname", objcontacts.firstname, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_lname", objcontacts.lastname, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_phone", objcontacts.phone, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_email", objcontacts.email, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            'If imagecontent Is Nothing Then
            '    oRequest.AddParameter("@p_picturelink", str, URDALRequest.myDataType.dtImage, , ParameterDirection.Input)
            'Else
            '    oRequest.AddParameter("@p_picturelink", imagecontent, URDALRequest.myDataType.dtImage, , ParameterDirection.Input)
            'End If
            'oRequest.AddParameter("@p_pict_type", imgtype, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)

            If objcontacts.picturelink = "" Then
                oRequest.AddParameter("@p_picturelink", "", URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            Else
                oRequest.AddParameter("@p_picturelink", objcontacts.picturelink, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            End If
            oRequest.AddParameter("@p_pict_type", objcontacts.picturetype, URDALRequest.myDataType.dtString, 225, ParameterDirection.Input)
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

        End Sub
#End Region

#Region "Courses"
        Shared Sub updateinsertcourses(ByVal objcourses As C21MIT.METROINI.BO.gccoursesobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updateinsertcourses"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_hid", objcourses.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid", objcourses.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_coursetype", objcourses.coursetype, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_coursename", objcourses.coursename, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)


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

        End Sub


        Shared Sub insertcourses(ByVal objcourses As C21MIT.METROINI.BO.gccoursesobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            With oRequest
                .Command = "dbo.metro_gc_insertcourses"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_certid", objcourses.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_coursetype", objcourses.coursetype, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_coursename", objcourses.coursename, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)


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

        End Sub
#End Region

#Region "Prerequisites"

        Shared Sub updateinsertprereqs(ByVal objprereqs As C21MIT.METROINI.BO.gcprequisites)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updateinsertprereqs"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_hid", objprereqs.hid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_certid", objprereqs.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_prerequisites", objprereqs.prerequisites, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)

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

        End Sub


        Shared Sub insertprereqs(ByVal objprereqs As C21MIT.METROINI.BO.gcprequisites)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_insertprereqs"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid ", objprereqs.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_prerequisites", objprereqs.prerequisites, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)

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

        End Sub


#End Region

#Region "Status"


        Shared Sub updatestatus_OLD(ByVal ColName As String, ByVal objadmissionreq As C21MIT.METROINI.BO.gcstatusobject)

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.metro_gc_updatestatus"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_certid", objadmissionreq.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@ColumnName", ColName, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)


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

        End Sub

        Shared Sub updatestatus(ByVal objstatus As C21MIT.METROINI.BO.gcstatusobject, ByVal status As Integer)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            With oRequest
                .Command = "dbo.metro_gc_updatecertstatus"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_certid", objstatus.hcertificatedetails, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_status", status, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

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

        End Sub

#End Region
    End Class


End Namespace
