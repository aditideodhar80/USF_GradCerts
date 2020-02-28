Imports Microsoft.VisualBasic
Imports System.Data

Namespace C21MIT.METROINI.DAM

#Region "Certificates"

    Public Class gccertificatestatus
        Shared Function gccertificatestatuslist() As C21MIT.METROINI.BO.gcstatusobject.gcStatusObjList
            Dim gccertlist As New C21MIT.METROINI.BO.gcstatusobject.gcStatusObjList
            '   Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getcertificates()
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData()

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(6).Rows
                Dim gccertobj As New C21MIT.METROINI.BO.gcstatusobject
                gccertobj.hid = myRow.Item("hid")
                gccertobj.certificatename = myRow.Item("certificatename")
                gccertobj.certificatetype = myRow.Item("certtype")
                gccertobj.status = myRow.Item("status")
                gccertlist.Add(gccertobj)
            Next
            Return gccertlist
        End Function
    End Class
#End Region

#Region "Title and Details"
    Public Class gctitledetails
        Shared Function gettitledetails(ByVal certid As Integer) As C21MIT.METROINI.BO.gctitledetailsobject.gctitledetailsobjlist
            Dim gcatitledetailslist As New C21MIT.METROINI.BO.gctitledetailsobject.gctitledetailsobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(0).Rows
                Dim gctitledetailsobj As New C21MIT.METROINI.BO.gctitledetailsobject

                gctitledetailsobj.hid = myRow.Item("hid")
                gctitledetailsobj.certificatecode = myRow.Item("certificatecode")
                gctitledetailsobj.certificatename = myRow.Item("certificatename")
                gctitledetailsobj.collegecode = myRow.Item("collegecode")
                gctitledetailsobj.linkname = myRow.Item("linkname")
                gctitledetailsobj.certificatetitle = myRow.Item("certificatetitle")
                gctitledetailsobj.courselocation = myRow.Item("courselocation")
                gctitledetailsobj.briefdesc = myRow.Item("briefdesc")
                gctitledetailsobj.CEU = myRow.Item("CEU")
                gctitledetailsobj.credittograd = myRow.Item("credittograd")
                gctitledetailsobj.transfercredit = myRow.Item("transfercredit")
                gctitledetailsobj.standardtests = myRow.Item("standardtests")
                gctitledetailsobj.prerequisites = myRow.Item("prerequisiteinfo")
                gctitledetailsobj.admissionreq = myRow.Item("admissionreq")
                gctitledetailsobj.appprocess = myRow.Item("appprocess")
                gctitledetailsobj.registrationprocess = myRow.Item("registrationprocess")
                gctitledetailsobj.tuitionfees = myRow.Item("tuitionfees")
                gctitledetailsobj.financialaid = myRow.Item("financialaid")
                gctitledetailsobj.timelimit = myRow.Item("timelimit")
                gctitledetailsobj.deptwebsite = myRow.Item("deptwebsite")
                gctitledetailsobj.requiredcourseinfo = myRow.Item("requiredcourseinfo")
                gctitledetailsobj.electivecourseinfo = myRow.Item("electivecourseinfo")
                gctitledetailsobj.certtype = myRow.Item("certtype")
                gctitledetailsobj.status = myRow.Item("status")

                gcatitledetailslist.Add(gctitledetailsobj)
            Next
            Return gcatitledetailslist
        End Function
    End Class
#End Region


#Region "Admission Requirements"
    Public Class gcadmissionrequirements

        Shared Function getadmissionreq(ByVal certid As Integer) As C21MIT.METROINI.BO.gcadmissionreqobj.gcadmissionreqobjlist
            Dim gcadmissionreqlist As New C21MIT.METROINI.BO.gcadmissionreqobj.gcadmissionreqobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(2).Rows
                Dim gcadmissionreqobj As New C21MIT.METROINI.BO.gcadmissionreqobj
                gcadmissionreqobj.hid = myRow.Item("hid")
                gcadmissionreqobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                gcadmissionreqobj.admissionreqdocuments = myRow.Item("admissionreqdocuments")
                gcadmissionreqlist.Add(gcadmissionreqobj)

            Next
            Return gcadmissionreqlist
        End Function
    End Class

#End Region

#Region "Admission Requirements"
    Public Class gcapplicationrequirements

        Shared Function getapplicationreq(ByVal certid As Integer) As C21MIT.METROINI.BO.gcapplicationreqobject.gcapplicationreqobjlist
            Dim gcapplicationreqlist As New C21MIT.METROINI.BO.gcapplicationreqobject.gcapplicationreqobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(3).Rows
                Dim gcapplicationreqobj As New C21MIT.METROINI.BO.gcapplicationreqobject
                gcapplicationreqobj.hid = myRow.Item("hid")
                gcapplicationreqobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                gcapplicationreqobj.applicationrequirements = myRow.Item("applicationrequirements")
                gcapplicationreqlist.Add(gcapplicationreqobj)

            Next
            Return gcapplicationreqlist
        End Function
    End Class

#End Region


#Region "Contacts"
    Public Class gcaccessobjects
        Shared Function gccontacts(ByVal certid As Integer) As C21MIT.METROINI.BO.gccontactsobject.gcContactsObjList
            Dim gccontactdatalist As New C21MIT.METROINI.BO.gccontactsobject.gcContactsObjList
            ' Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getContacts(certid)
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(4).Rows
                Dim gccontactdataobj As New C21MIT.METROINI.BO.gccontactsobject
                gccontactdataobj.hid = myRow.Item("hid")
                gccontactdataobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                ' gccontactdataobj.contactorder = myRow.Item("contactorder")
                gccontactdataobj.firstname = myRow.Item("fname")
                gccontactdataobj.lastname = myRow.Item("lname")
                gccontactdataobj.phone = myRow.Item("phone")
                gccontactdataobj.email = myRow.Item("email")
                If gccontactdataobj.picturelink = "" Then
                Else
                    gccontactdataobj.picturelink = myRow.Item("picturelink")
                End If

                gccontactdatalist.Add(gccontactdataobj)

            Next
            Return gccontactdatalist
        End Function
    End Class
#End Region




#Region "Required Courses"
    Public Class gcrequiredcourses

        Shared Function getrequiredcourses(ByVal certid As Integer) As C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Dim gcrequiredcourseslist As New C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid, "RQ")

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(5).Rows
                Dim gcrequiredcoursesobj As New C21MIT.METROINI.BO.gccoursesobject
                gcrequiredcoursesobj.hid = myRow.Item("hid")
                gcrequiredcoursesobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                gcrequiredcoursesobj.coursetype = myRow.Item("coursetype")
                gcrequiredcoursesobj.coursename = myRow.Item("coursename")
                gcrequiredcourseslist.Add(gcrequiredcoursesobj)
            Next
            Return gcrequiredcourseslist
        End Function
    End Class

#End Region

#Region "Elective Courses"
    Public Class gcelectivecourses

        Shared Function getelectivecourses(ByVal certid As Integer) As C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Dim gcelectivecourseslist As New C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid, "EL")

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(5).Rows
                Dim gcelectivecoursesobj As New C21MIT.METROINI.BO.gccoursesobject
                gcelectivecoursesobj.hid = myRow.Item("hid")
                gcelectivecoursesobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                gcelectivecoursesobj.coursetype = myRow.Item("coursetype")
                gcelectivecoursesobj.coursename = myRow.Item("coursename")
                gcelectivecourseslist.Add(gcelectivecoursesobj)
            Next
            Return gcelectivecourseslist
        End Function
    End Class

#End Region


#Region "Prerequistes"
    Public Class gcprerequisites

        Shared Function getprerequisites(ByVal certid As Integer) As C21MIT.METROINI.BO.gcprequisites.gcprereqobjlist
            Dim gcprerequisiteslist As New C21MIT.METROINI.BO.gcprequisites.gcprereqobjlist
            Dim myDS As DataSet = C21MIT.METROINI.DAL.gcmanage.getData(certid)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(1).Rows
                Dim gcprerequisitesobj As New C21MIT.METROINI.BO.gcprequisites
                gcprerequisitesobj.hid = myRow.Item("hid")
                gcprerequisitesobj.hcertificatedetails = myRow.Item("hcertificatedetails")
                gcprerequisitesobj.prerequisites = myRow.Item("prerequisites")
                gcprerequisiteslist.Add(gcprerequisitesobj)
            Next
            Return gcprerequisiteslist
        End Function
    End Class

#End Region


End Namespace