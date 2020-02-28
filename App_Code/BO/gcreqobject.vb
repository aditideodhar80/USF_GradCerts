Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gcreqobject
        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _text As String


        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _text = ""

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

        Public Property text() As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                _text = value
            End Set
        End Property

        Public Class gcreqobjectlist
            Inherits System.Collections.Generic.List(Of gcreqobject)

            Public Sub New()

            End Sub
        End Class
    End Class
End Namespace