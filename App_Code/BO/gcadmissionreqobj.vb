Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gcadmissionreqobj
        Dim _hid As Integer
        Dim _hcertificatedetails As Integer
        Dim _admissionreqdocuments As String
        Dim _iorder As Integer

        Public Sub New()
            _hid = 0
            _hcertificatedetails = 0
            _admissionreqdocuments = ""
            _iorder = 0
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

        Public Property admissionreqdocuments() As String
            Get
                Return _admissionreqdocuments
            End Get
            Set(ByVal value As String)
                _admissionreqdocuments = value
            End Set
        End Property

        Public Property iorder() As Integer
            Get
                Return _iorder
            End Get
            Set(ByVal value As Integer)
                _iorder = value
            End Set
        End Property

        Public Class gcadmissionreqobjlist
            Inherits System.Collections.Generic.List(Of gcadmissionreqobj)

            Public Sub New()

            End Sub
        End Class
    End Class

    '' Provides a structure for the client list


End Namespace