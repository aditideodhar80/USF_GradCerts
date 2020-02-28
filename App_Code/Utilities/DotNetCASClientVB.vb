Imports Microsoft.VisualBasic
Imports System.Xml
Imports System.IO
Imports System.Web
Imports System.Net
Imports System.Diagnostics
Imports System.Security
Imports System.Web.Configuration
Imports System

Namespace DotNetCASClient

    Public Class DotNetCASClientProxyValidate
        Dim casProxyValidationURL As String
        Dim serviceURL As String

#Region "Constructors"
        Public Sub New(ByVal service As String, ByVal validationURL As String)
            Me.serviceURL = service
            Me.casProxyValidationURL = validationURL

            Try
                If (Not EventLog.SourceExists("CasClientVB")) Then
                    EventLog.CreateEventSource("CasClientVB", "Application")
                End If

            Catch securityex As SecurityException
                Dim objerrLog As New MITErrorHandling("Could not search all the Logs for the specified source (CasClientVB):")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Catch argumentex As ArgumentException
                Dim objerrLog As New MITErrorHandling("Invalid Log Name: " & argumentex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Catch invalidoprexp As InvalidOperationException
                Dim objerrLog As New MITErrorHandling("Could not open registry key: " & invalidoprexp.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            End Try
        End Sub

#End Region

        Public Function Authenticate(ByVal ticket As String) As String
            Dim url As String = casProxyValidationURL & "?ticket=" & ticket & "&service=" & serviceURL
            Dim result As String = DBNull.Value.ToString

            Try
                Dim reader As XmlTextReader = New XmlTextReader(url)
                While reader.Read
                    If reader.LocalName = "user" Then
                        result = reader.ReadString
                    End If
                End While
                reader.Close()

            Catch ex As FileNotFoundException
                Dim objerrLog As New MITErrorHandling("Failed to locate XML: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            Catch ex As DirectoryNotFoundException
                Dim objerrLog As New MITErrorHandling("Failed to locate XML: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            Catch ex As WebException
                Dim objerrLog As New MITErrorHandling("Problem accessing the resource - could be a network problem: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            Catch ex As UriFormatException
                Dim objerrLog As New MITErrorHandling("The URL is not properly formed: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            Catch ex As XmlException
                Dim objerrLog As New MITErrorHandling("The XML is malformed: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            Catch ex As InvalidOperationException
                Dim objerrLog As New MITErrorHandling("Invalid Operation: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
                Return "Failed"

            End Try

            If result = DBNull.Value.ToString Then
                Try
                    Dim objerrLog As New MITErrorHandling("Failed to authenticate.")
                    objerrLog.logError()
                    System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

                Catch ex As Exception
                    Dim objerrLog As New MITErrorHandling("Failed to log error")
                    objerrLog.logError()
                    System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

                End Try
                result = "failed"
            End If

            Return result

        End Function

        '---------------------------------------------------------------------------------------------------
        '<summary>
        'Performs the ticket validation but simply returns all the XML from CAS without trying to retrieve a 
        'username.
        '</summary>
        '<param name="ticket">The proxy or service ticket uses to authorise with CAS</param>
        '<returns>The XML from CAS - or null if an exception occurs.</returns>
        '---------------------------------------------------------------------------------------------------
        Public Function GetCasXML(ByVal ticket As String) As XmlDocument
            Dim url As String
            url = casProxyValidationURL & "?ticket=" & ticket & "&service=" & serviceURL
            Dim xml As XmlDocument = New XmlDocument

            Try
                xml = New XmlDocument
                xml.Load(New XmlTextReader(url))
                System.Web.HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=TechErr", False)
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling("Failed to read and/or parse XML: ")
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            End Try
            Return xml
        End Function
    End Class
    '---------------------------------------------------------------------------------------------------
    ' <summary>
    ' Looks for a ticket in the request and uses it to authenticate the user
    ' or, if there isn't one, redirects to the CAS server based on web-config 
    ' settings.
    ' </summary>
    '---------------------------------------------------------------------------------------------------
    Public Class DotNetCASClientServiceValidate
        Dim casLoginURL As String
        Dim casValidateURL As String
        Dim serviceURL As String
        '---------------------------------------------------------------------------------------------------
        '<summary>
        'Initialises a new instance of DotNetCASClientServiceValidate
        '</summary>
        '---------------------------------------------------------------------------------------------------
        Public Sub New()
            Try
                If Not EventLog.SourceExists("CasClientVB") Then
                    EventLog.CreateEventSource("CasClientVB", "Application")
                End If

            Catch ex As SecurityException
                Dim objerrLog As New MITErrorHandling("Could not search all the Logs for the specified source (CasClientVB): " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Catch ex As ArgumentException
                Dim objerrLog As New MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Catch ex As InvalidOperationException
                Dim objerrLog As New MITErrorHandling("Could not open registry key: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            End Try

            casLoginURL = ConfigurationManager.AppSettings("casLoginURL")
            casValidateURL = ConfigurationManager.AppSettings("casValidateURL")
            serviceURL = ConfigurationManager.AppSettings("serviceURL")
        End Sub

        '---------------------------------------------------------------------------------------------------
        ' <summary>
        ' Performs simple authentication by either validating a ticket or redirecting
        ' the user to the CAS server in order to obtain a ticket.
        ' </summary>
        ' <param name="request">The HttpRequest which may contain the ticket</param>
        ' <param name="response">The HttpResponse in case the user needs redrecting</param>
        ' <param name="needXML">Whether or not to return a username or the XML response from CAS</param>
        ' <returns></returns>
        '---------------------------------------------------------------------------------------------------
        Public Function Authenticate(ByVal request As HttpRequest, ByVal response As HttpResponse, ByVal needXML As Boolean) As String
            Dim ticket As String = request.Params("ticket")
            Dim result As String = DBNull.Value.ToString

            If ticket = DBNull.Value.ToString Then
                Try
                    response.Redirect(casLoginURL & "?service=" & serviceURL)
                Catch ex As HttpException
                    Dim objerrLog As New MITErrorHandling("Failed to redirect the user to the CAS server")
                    objerrLog.logError()
                    System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

                End Try

            ElseIf Not ticket = Nothing Then
                Dim client As DotNetCASClientProxyValidate = New DotNetCASClientProxyValidate(serviceURL, casValidateURL)
                If Not needXML Then
                    result = client.Authenticate(ticket)
                    If result.Equals("failed") Then
                        Try
                            EventLog.WriteEntry("CasClientVB", "Failed to authenticate based on the given ticket", EventLogEntryType.Warning)
                        Catch ex As Exception
                            Dim objerrLog As New MITErrorHandling("Failed to log error")
                            objerrLog.logError()
                            System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

                        End Try
                    End If
                Else
                    result = client.GetCasXML(ticket).InnerXml
                End If

                Return result

            End If
        End Function
    End Class

End Namespace