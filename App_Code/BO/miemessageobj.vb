Imports Microsoft.VisualBasic
Namespace C21MIT.METROINI.BO


    Public Class EMessageObj

        Private _header As String
        Private _mesasge As String
        Private _linkvisible As Boolean
        Private _lText As String
        Private _lpath As String

        Public Sub New()

            _header = ""
            _mesasge = ""
            _linkvisible = False
            _lText = ""
            _lpath = ""

        End Sub

        Public Property EPageHeader() As String
            Get
                Return _header
            End Get
            Set(ByVal value As String)
                _header = value
            End Set
        End Property
        Public Property EPageMessage() As String
            Get
                Return _mesasge
            End Get
            Set(ByVal value As String)
                _mesasge = value
            End Set
        End Property

        Public Property LinkVisible() As Boolean
            Get
                Return _linkvisible
            End Get
            Set(ByVal value As Boolean)
                _linkvisible = value
            End Set
        End Property
        Public Property LinkText() As String
            Get
                Return _lText
            End Get
            Set(ByVal value As String)
                _lText = value
            End Set
        End Property

        Public Property LinkPath() As String
            Get
                Return _lpath
            End Get
            Set(ByVal value As String)
                _lpath = value
            End Set
        End Property

    End Class
End Namespace
