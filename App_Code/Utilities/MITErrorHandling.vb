
'Imports System.Net.Mail
Imports System.Web.Mail
Imports System.Web
Imports System.Web.SessionState
Imports System.Diagnostics
Imports System.Data


Public Class MITErrorHandling
    Private _eMessage As String

    Public Sub New(ByVal eMessage As String)
        _eMessage = eMessage
    End Sub

#Region "Public Methods"
    Public Sub logError()
        SendEmailAlert(_eMessage)
    End Sub
#End Region

#Region "Private methods"

    Private Sub SendEmailAlert(ByVal v_emessage As String)

        Dim emailFrom As String
        Dim emailTo As String

        emailFrom = System.Configuration.ConfigurationManager.AppSettings("errEmail")
        emailTo = System.Configuration.ConfigurationManager.AppSettings("errEmail")

        '(1) Create the MailMessage instance
        Dim objMailMessage As New System.Net.Mail.MailMessage(emailFrom, emailTo)

        '(2) Assign the MailMessage's properties
        objMailMessage.Subject = "CMS - Application Error"
        objMailMessage.Body = v_emessage
        objMailMessage.IsBodyHtml = False

        '(3) Create the SmtpClient object
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.Send(objMailMessage)

    End Sub

#End Region
End Class
