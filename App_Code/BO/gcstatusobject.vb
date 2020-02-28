Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gcstatusobject
        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _certificatename As String
        Dim _certificatetype As String
        Dim _titlestatus As Integer
        Dim _adreqstatus As Integer
        Dim _appreqstatus As Integer
        Dim _contactstatus As Integer
        Dim _reqcoursestatus As Integer
        Dim _electivestatus As Integer
        Dim _status As Integer


        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _certificatename = ""
            _certificatetype = ""
            _titlestatus = 0
            _adreqstatus = 0
            _appreqstatus = 0
            _contactstatus = 0
            _reqcoursestatus = 0
            _electivestatus = 0
            _status = 0
        End Sub


        Public Property hid() As Integer
            Get
                Return _hid
            End Get
            Set(ByVal value As Integer)
                _hid = value
            End Set
        End Property

        Public Property certificatename() As String
            Get
                Return _certificatename
            End Get
            Set(ByVal value As String)
                _certificatename = value
            End Set
        End Property

        Public Property certificatetype() As String
            Get
                Return _certificatetype
            End Get
            Set(ByVal value As String)
                _certificatetype = value
            End Set
        End Property

        Public Property hcertificatedetails() As Integer
            Get
                Return _hcertificatedetails
            End Get
            Set(ByVal value As Integer)
                _hcertificatedetails = value
            End Set
        End Property


        Public Property titlestatus() As Integer
            Get
                Return _titlestatus
            End Get
            Set(ByVal value As Integer)
                _titlestatus = value
            End Set
        End Property

        Public Property adreqstatus() As Integer
            Get
                Return _adreqstatus
            End Get
            Set(ByVal value As Integer)
                _adreqstatus = value
            End Set
        End Property

        Public Property appreqstatus() As Integer
            Get
                Return _appreqstatus
            End Get
            Set(ByVal value As Integer)
                _appreqstatus = value
            End Set
        End Property

        Public Property contactstatus() As Integer
            Get
                Return _contactstatus
            End Get
            Set(ByVal value As Integer)
                _contactstatus = value
            End Set
        End Property

        Public Property reqcoursestatus() As Integer
            Get
                Return _reqcoursestatus
            End Get
            Set(ByVal value As Integer)
                _reqcoursestatus = value
            End Set
        End Property

        Public Property electivestatus() As Integer
            Get
                Return _electivestatus
            End Get
            Set(ByVal value As Integer)
                _electivestatus = value
            End Set
        End Property

        Public Property status() As Integer
            Get
                Return _status
            End Get
            Set(ByVal value As Integer)
                _status = value
            End Set
        End Property

        Public Class gcStatusObjList
            Inherits System.Collections.Generic.List(Of gcstatusobject)

            Public Sub New()

            End Sub
        End Class
    End Class
   
End Namespace