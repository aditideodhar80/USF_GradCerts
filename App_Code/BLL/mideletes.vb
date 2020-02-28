Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BLL
    Public Class mideletes
#Region "Admission Requirements"
        Public Class mideleteadmissionreq
            Shared Sub deleteadmissionreq(ByVal objdeleteadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)
                C21MIT.METROINI.DAL.mideletes.deleteadmissionrequirements(objdeleteadmissionreq)
            End Sub
        End Class

        
#End Region

#Region "Application Requirements"
        Public Class mideleteapplicationreq
            Shared Sub deleteapplicationreq(ByVal objdeleteapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)
                C21MIT.METROINI.DAL.mideletes.deleteapplicationrequirements(objdeleteapplicationreq)
            End Sub
        End Class


#End Region
#Region "Contacts"
        Public Class mideletecontacts
            Shared Sub deletecontacts(ByVal objdeletecontacts As C21MIT.METROINI.BO.gccontactsobject)
                C21MIT.METROINI.DAL.mideletes.deletecontacts(objdeletecontacts)
            End Sub
        End Class
#End Region

#Region "Certificates"
        Public Class mideletecerts
            Shared Sub deletecerts(ByVal certid As Integer)
                C21MIT.METROINI.DAL.mideletes.deletecerts(certid)
            End Sub
        End Class


#End Region


#Region "Courses"
        Public Class mideletecourses
            Shared Sub deletecourses(ByVal objdeletecourses As C21MIT.METROINI.BO.gccoursesobject)
                C21MIT.METROINI.DAL.mideletes.deletecourses(objdeletecourses)
            End Sub
        End Class
#End Region

#Region "Prerequisites"
        Public Class mideleteprereqs
            Shared Sub deleteprereqs(ByVal objdeleteprereqs As C21MIT.METROINI.BO.gcprequisites)
                C21MIT.METROINI.DAL.mideletes.deleteprereqs(objdeleteprereqs)
            End Sub
        End Class
#End Region


    End Class
End Namespace