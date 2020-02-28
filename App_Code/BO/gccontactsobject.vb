Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gccontactsobject

        Dim imgbin As Byte


        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        'Dim _contactorder As Integer
        Dim _fname As String
        Dim _lname As String
        Dim _phone As String
        Dim _email As String
        ' Dim _picturelink As Byte()
        Dim _picturelink As String
        Dim _picturetype As String


        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            '_contactorder = 0
            _fname = ""
            _lname = ""
            _phone = ""
            _email = ""
            _picturelink = ""
            _picturetype = ""
        End Sub


        Public Property hid() As Integer
            Get
                Return _hid
            End Get
            Set(ByVal value As Integer)
                _hid = value
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


        'Public Property contactorder() As Integer
        '    Get
        '        Return _contactorder
        '    End Get
        '    Set(ByVal value As Integer)
        '        _contactorder = value
        '    End Set
        'End Property

        Public Property firstname() As String
            Get
                Return _fname
            End Get
            Set(ByVal value As String)
                _fname = value
            End Set
        End Property

        Public Property lastname() As String
            Get
                Return _lname
            End Get
            Set(ByVal value As String)
                _lname = value
            End Set
        End Property

        Public Property phone() As String
            Get
                Return _phone
            End Get
            Set(ByVal value As String)
                _phone = value
            End Set
        End Property

        Public Property email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        'Public Property picturelink() As Byte()
        '    Get
        '        Return _picturelink
        '    End Get
        '    Set(ByVal value As Byte())
        '        _picturelink = value
        '    End Set
        'End Property



        Public Property picturelink() As String
            Get
                Return _picturelink
            End Get
            Set(ByVal value As String)
                _picturelink = value
            End Set
        End Property


        Public Property picturetype() As String
            Get
                Return _picturetype
            End Get
            Set(ByVal value As String)
                _picturetype = value
            End Set
        End Property

        '' Provides a structure for the client list
        Public Class gcContactsObjList
            Inherits System.Collections.Generic.List(Of gccontactsobject)

            Public Sub New()

            End Sub
        End Class
    End Class
 
   
End Namespace