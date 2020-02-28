Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO

    Public Class gcapplicationreqobject

        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _applicationrequirements As String

        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _applicationrequirements = ""
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

        Public Property applicationrequirements() As String
            Get
                Return _applicationrequirements
            End Get
            Set(ByVal value As String)
                _applicationrequirements = value
            End Set
        End Property
        Public Class gcapplicationreqobjlist
            Inherits System.Collections.Generic.List(Of gcapplicationreqobject)

            Public Sub New()

            End Sub
        End Class
    End Class

   

End Namespace

