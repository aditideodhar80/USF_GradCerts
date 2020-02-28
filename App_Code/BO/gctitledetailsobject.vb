Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class gctitledetailsobject

        Dim _hid As Integer
        Dim _certificatecode As String
        Dim _certificatename As String
        Dim _collegecode As String
        Dim _linkname As String
        Dim _certificatetitle As String
        Dim _courselocation As String
        Dim _briefdesc As String
        Dim _CEU As String
        Dim _credittograd As String
        Dim _transfercredit As String
        Dim _standardtests As String
        Dim _prerequisites As String
        Dim _admissionreq As String
        Dim _appprocess As String
        Dim _registrationprocess As String
        Dim _tuitionfees As String
        Dim _financialaid As String
        Dim _timelimit As String
        Dim _deptwebsite As String
        Dim _requiredcourseinfo As String
        Dim _electivecourseinfo As String
        Dim _certtype As String
        Dim _status As Integer


        Public Sub New()
            _hid = 0
            _certificatecode = ""
            _certificatename = ""
            _collegecode = ""
            _linkname = ""
            _certificatetitle = ""
            _courselocation = ""
            _briefdesc = ""
            _CEU = ""
            _credittograd = ""
            _transfercredit = ""
            _standardtests = ""
            _prerequisites = ""
            _admissionreq = ""
            _appprocess = ""
            _registrationprocess = ""
            _tuitionfees = ""
            _financialaid = ""
            _timelimit = ""
            _deptwebsite = ""
            _requiredcourseinfo = ""
            _electivecourseinfo = ""
            _certtype = ""
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

        Public Property certificatecode() As String
            Get
                Return _certificatecode
            End Get
            Set(ByVal value As String)
                _certificatecode = value
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

        Public Property collegecode() As String
            Get
                Return _collegecode
            End Get
            Set(ByVal value As String)
                _collegecode = value
            End Set
        End Property


        Public Property linkname() As String
            Get
                Return _linkname
            End Get
            Set(ByVal value As String)
                _linkname = value
            End Set
        End Property

        Public Property certificatetitle() As String
            Get
                Return _certificatetitle
            End Get
            Set(ByVal value As String)
                _certificatetitle = value
            End Set
        End Property

        Public Property courselocation() As String
            Get
                Return _courselocation
            End Get
            Set(ByVal value As String)
                _courselocation = value
            End Set
        End Property

        Public Property briefdesc() As String
            Get
                Return _briefdesc
            End Get
            Set(ByVal value As String)
                _briefdesc = value
            End Set
        End Property

        Public Property CEU() As String
            Get
                Return _CEU
            End Get
            Set(ByVal value As String)
                _CEU = value
            End Set
        End Property

        Public Property credittograd() As String
            Get
                Return _credittograd
            End Get
            Set(ByVal value As String)
                _credittograd = value
            End Set
        End Property

        Public Property transfercredit() As String
            Get
                Return _transfercredit
            End Get
            Set(ByVal value As String)
                _transfercredit = value
            End Set
        End Property

        Public Property standardtests() As String
            Get
                Return _standardtests
            End Get
            Set(ByVal value As String)
                _standardtests = value
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


        Public Property admissionreq() As String
            Get
                Return _admissionreq
            End Get
            Set(ByVal value As String)
                _admissionreq = value
            End Set
        End Property

        Public Property appprocess() As String
            Get
                Return _appprocess
            End Get
            Set(ByVal value As String)
                _appprocess = value
            End Set
        End Property


        Public Property registrationprocess() As String
            Get
                Return _registrationprocess
            End Get
            Set(ByVal value As String)
                _registrationprocess = value
            End Set
        End Property

     

        Public Property tuitionfees() As String
            Get
                Return _tuitionfees
            End Get
            Set(ByVal value As String)
                _tuitionfees = value
            End Set
        End Property

        Public Property financialaid() As String
            Get
                Return _financialaid
            End Get
            Set(ByVal value As String)
                _financialaid = value
            End Set
        End Property

        Public Property timelimit() As String
            Get
                Return _timelimit
            End Get
            Set(ByVal value As String)
                _timelimit = value
            End Set
        End Property


        Public Property deptwebsite() As String
            Get
                Return _deptwebsite
            End Get
            Set(ByVal value As String)
                _deptwebsite = value
            End Set
        End Property

        Public Property requiredcourseinfo() As String
            Get
                Return _requiredcourseinfo
            End Get
            Set(ByVal value As String)
                _requiredcourseinfo = value
            End Set
        End Property

        Public Property electivecourseinfo() As String
            Get
                Return _electivecourseinfo
            End Get
            Set(ByVal value As String)
                _electivecourseinfo = value
            End Set
        End Property


        Public Property certtype() As String
            Get
                Return _certtype
            End Get
            Set(ByVal value As String)
                _certtype = value
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

        Public Class gctitledetailsobjlist
            Inherits System.Collections.Generic.List(Of gctitledetailsobject)

            Public Sub New()

            End Sub
        End Class

    End Class


 
End Namespace