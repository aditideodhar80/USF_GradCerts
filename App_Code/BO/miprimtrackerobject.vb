Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO
    Public Class miprimtrackerobject
        Dim _vUserId As Integer
        Dim _vNetId As String
        Dim _vFirstName As String
        Dim _vLastName As String
        Dim _vUrRole As Integer

#Region "Constructors"
        Public Sub New()
            _vUserId = 0
            _vNetId = ""
            _vFirstName = ""
            _vLastName = ""
            _vUrRole = 0
        End Sub

        Sub New(ByVal sPrimTracker As String)
            Dim urDetCol() As String
            If sPrimTracker = "" Then
                Return
            Else
                urDetCol = sPrimTracker.Split(",")
            End If

            _vUserId = CType(urDetCol(0), Integer)
            _vNetId = CType(urDetCol(1), String)
            _vFirstName = CType(urDetCol(2), String)
            _vLastName = CType(urDetCol(3), String)
            _vUrRole = CType(urDetCol(4), Integer)
        End Sub
#End Region

#Region "Properties"

        Public Property UserId() As Integer
            Get
                Return _vUserId
            End Get
            Set(ByVal value As Integer)
                _vUserId = value
            End Set
        End Property

        Public Property NetId() As String
            Get
                Return _vNetId
            End Get
            Set(ByVal value As String)
                _vNetId = value
            End Set
        End Property

        Public Property FirstName() As String
            Get
                Return _vFirstName
            End Get
            Set(ByVal value As String)
                _vFirstName = value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return _vLastName
            End Get
            Set(ByVal value As String)
                _vLastName = value
            End Set
        End Property

        Public Property UserRole() As Integer
            Get
                Return _vUrRole
            End Get
            Set(ByVal value As Integer)
                _vUrRole = value
            End Set
        End Property

        Public ReadOnly Property PTrackerSession() As String
            Get
                Return _vUserId.ToString + "," + _vNetId + "," + _vFirstName + "," + _vLastName + "," + _vUrRole.ToString
            End Get
        End Property
#End Region
    End Class
End Namespace