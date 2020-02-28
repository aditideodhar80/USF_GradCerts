Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BLL
    Public Class mimanage
#Region "Certificates"
        Shared Function getCertificatesList() As C21MIT.METROINI.BO.gcstatusobject.gcStatusObjList
            Return C21MIT.METROINI.DAM.gccertificatestatus.gccertificatestatuslist()
        End Function

#End Region

#Region "Title and Details"
        Shared Function getTitleDetailsList(ByVal certid As Integer) As C21MIT.METROINI.BO.gctitledetailsobject.gctitledetailsobjlist
            Return C21MIT.METROINI.DAM.gctitledetails.gettitledetails(certid)
        End Function
#End Region


#Region "Admission Requirements"
        Shared Function getAdmissionRequirementsList(ByVal certid As Integer) As C21MIT.METROINI.BO.gcadmissionreqobj.gcadmissionreqobjlist
            Return C21MIT.METROINI.DAM.gcadmissionrequirements.getadmissionreq(certid)
        End Function
#End Region

#Region "Application Requirements"
        Shared Function getApplicationRequirementsList(ByVal certid As Integer) As C21MIT.METROINI.BO.gcapplicationreqobject.gcapplicationreqobjlist
            Return C21MIT.METROINI.DAM.gcapplicationrequirements.getapplicationreq(certid)
        End Function
#End Region


#Region "Contacts"
        Shared Function getContactList(ByVal certid As Integer) As C21MIT.METROINI.BO.gccontactsobject.gcContactsObjList
            Return C21MIT.METROINI.DAM.gcaccessobjects.gccontacts(certid)
        End Function
#End Region

#Region "Required Courses"
        Shared Function getRequiredCoursesList(ByVal certid As Integer) As C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Return C21MIT.METROINI.DAM.gcrequiredcourses.getrequiredcourses(certid)
        End Function
#End Region

#Region "Elective Courses"
        Shared Function getElectiveCoursesList(ByVal certid As Integer) As C21MIT.METROINI.BO.gccoursesobject.gccoursesobjlist
            Return C21MIT.METROINI.DAM.gcelectivecourses.getelectivecourses(certid)
        End Function
#End Region
#Region "Prerequisites"
        Shared Function getPrerequisiteList(ByVal certid As Integer) As C21MIT.METROINI.BO.gcprequisites.gcprereqobjlist
            Return C21MIT.METROINI.DAM.gcprerequisites.getprerequisites(certid)
        End Function
#End Region
#Region "Courses available"
        Shared Function fncheckCertificateAvailable(ByVal gctitledetails As C21MIT.METROINI.BO.gctitledetailsobject) As Integer
            Dim vCertificatePresent As Integer

            'check whether the certificate is already created. if yes, then dont create it again and give a message.
            vCertificatePresent = C21MIT.METROINI.DAL.gcmanage.fncheckifcertificatepresent(gctitledetails)
            Return vCertificatePresent
        End Function
#End Region

#Region "Photo Upload"
        Public Shared Function getWebFolderPath(ByVal filename As String) As String
            Dim strPath As String = ""

            strPath = getWebFolderRoot() & "\" & System.Configuration.ConfigurationManager.AppSettings("facultyPhoto") & "\" & filename

            Return strPath
        End Function

        Public Shared Function getWebFolderRoot() As String
            Dim v_basedirlen As Integer

            Dim v_maindir As String

            Dim v_basedir As String

            v_basedir = System.AppDomain.CurrentDomain.BaseDirectory

            v_basedirlen = v_basedir.Length

            v_basedir = v_basedir.Substring(0, v_basedirlen - 1)

            v_basedirlen = v_basedir.LastIndexOf("\")

            v_maindir = v_basedir.Substring(0, v_basedirlen)


            Return v_maindir
        End Function

#End Region
    End Class
End Namespace