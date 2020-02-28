Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BLL

#Region "Title and Details"
    Public Class miinserttitledetails
        Shared Function inserttitledetails(ByVal objtitledesc As C21MIT.METROINI.BO.gctitledetailsobject) As Integer
            Dim hid As Integer
            hid = C21MIT.METROINI.DAL.miinserts.inserttitledescription(objtitledesc)
            Return hid

            'C21MIT.METROINI.DAL.miinserts.inserttitledescription(objtitledesc)
        End Function
    End Class

    Public Class miupdateinserttitledetails
        Shared Function updateinserttitledetails(ByVal objtitledesc As C21MIT.METROINI.BO.gctitledetailsobject) As Integer
            Dim hid As Integer
            hid = C21MIT.METROINI.DAL.miinserts.updateinserttitledescription(objtitledesc)
            Return hid

            'C21MIT.METROINI.DAL.miinserts.inserttitledescription(objtitledesc)
        End Function
    End Class
#End Region

#Region "Admission Requirements"
    Public Class miupdateinsertadmissionreq
        Shared Sub updateinsertadmissionreq(ByVal objupdateinsertadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)
            C21MIT.METROINI.DAL.miinserts.updateinsertadmissionrequirements(objupdateinsertadmissionreq)
        End Sub
    End Class

    Public Class miinsertadmissionreq
        Shared Sub insertadmissionreq(ByVal objinsertadmissionreq As C21MIT.METROINI.BO.gcadmissionreqobj)
            'Dim hid As Integer
            'hid = C21MIT.METROINI.DAL.miinserts.inserttitledescription(objtitledesc)
            'Return hid

            C21MIT.METROINI.DAL.miinserts.insertadmissionrequirements(objinsertadmissionreq)
        End Sub
    End Class
#End Region

#Region "Application Requirements"
    Public Class miupdateinsertapplicationreq
        Shared Sub updateinsertapplicationreq(ByVal objupdateinsertapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)
            C21MIT.METROINI.DAL.miinserts.updateinsertapplicationrequirements(objupdateinsertapplicationreq)
        End Sub
    End Class
    Public Class miinsertapplicationreq


        Shared Sub insertapplicationreq(ByVal objinsertapplicationreq As C21MIT.METROINI.BO.gcapplicationreqobject)
            'Dim hid As Integer
            'hid = C21MIT.METROINI.DAL.miinserts.inserttitledescription(objtitledesc)
            'Return hid

            C21MIT.METROINI.DAL.miinserts.insertapplicationrequirements(objinsertapplicationreq)
        End Sub
    End Class
#End Region
#Region "Contacts"

    Public Class miupdateinsertcontacts
        Shared Sub updateinsertcontacts(ByVal objupdateinsertcontacts As C21MIT.METROINI.BO.gccontactsobject)
            C21MIT.METROINI.DAL.miinserts.updateinsertcontacts(objupdateinsertcontacts)
        End Sub
    End Class
    Public Class miinsertcontacts
        '   Shared Sub insertcontacts(ByVal objinsertcontacts As C21MIT.METROINI.BO.gccontactsobject, ByVal imagecontent As Byte(), ByVal imgtype As String)
        Shared Sub insertcontacts(ByVal objinsertcontacts As C21MIT.METROINI.BO.gccontactsobject)
            ' C21MIT.METROINI.DAL.miinserts.insertcontacts(objinsertcontacts, imagecontent, imgtype)
            C21MIT.METROINI.DAL.miinserts.insertcontacts(objinsertcontacts)
        End Sub
    End Class
#End Region

#Region "Courses"

    Public Class miupdateinsertcourses
        Shared Sub updateinsertcourses(ByVal objupdateinsertcourses As C21MIT.METROINI.BO.gccoursesobject)
            C21MIT.METROINI.DAL.miinserts.updateinsertcourses(objupdateinsertcourses)
        End Sub
    End Class

    Public Class miinsertcourses
        Shared Sub insertcourses(ByVal objinsertcourses As C21MIT.METROINI.BO.gccoursesobject)
            C21MIT.METROINI.DAL.miinserts.insertcourses(objinsertcourses)
        End Sub
    End Class
#End Region

#Region "Prerequisites"
    Public Class miupdateinsertprereqs
        Shared Sub updateinsertprereqs(ByVal objupdateinsertprereqs As C21MIT.METROINI.BO.gcprequisites)
            C21MIT.METROINI.DAL.miinserts.updateinsertprereqs(objupdateinsertprereqs)
        End Sub
    End Class
    Public Class miinsertprereqs


        Shared Sub insertprereqs(ByVal objinsertprereqs As C21MIT.METROINI.BO.gcprequisites)
            C21MIT.METROINI.DAL.miinserts.insertprereqs(objinsertprereqs)
        End Sub
    End Class
#End Region

#Region "Status"
    Public Class migcstatus
        Shared Sub updatestatus_OLD(ByVal ColName As String, ByVal objstatus As C21MIT.METROINI.BO.gcstatusobject)
            C21MIT.METROINI.DAL.miinserts.updatestatus_OLD(ColName, objstatus)
        End Sub
        Shared Sub updatestatus(ByVal objstatus As C21MIT.METROINI.BO.gcstatusobject, ByVal status As Integer)
            C21MIT.METROINI.DAL.miinserts.updatestatus(objstatus, status)
        End Sub

    End Class
#End Region
End Namespace