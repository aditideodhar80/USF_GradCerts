Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gcprequisites
        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _prerequisites As String


        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _prerequisites = ""

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

        Public Property prerequisites() As String
            Get
                Return _prerequisites
            End Get
            Set(ByVal value As String)
                _prerequisites = value
            End Set
        End Property

        Public Class gcprereqobjlist
            Inherits System.Collections.Generic.List(Of gcprequisites)

            Public Sub New()

            End Sub
        End Class
    End Class

End Namespace