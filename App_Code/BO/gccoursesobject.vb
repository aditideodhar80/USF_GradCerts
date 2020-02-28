Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gccoursesobject
        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _coursetype As String
        Dim _coursename As String


        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _coursetype = ""
            _coursename = ""
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


        Public Property coursetype() As String
            Get
                Return _coursetype
            End Get
            Set(ByVal value As String)
                _coursetype = value
            End Set
        End Property

        Public Property coursename() As String
            Get
                Return _coursename
            End Get
            Set(ByVal value As String)
                _coursename = value
            End Set
        End Property

        Public Class gccoursesobjlist
            Inherits System.Collections.Generic.List(Of gccoursesobject)

            Public Sub New()

            End Sub
        End Class
    End Class

  
End Namespace