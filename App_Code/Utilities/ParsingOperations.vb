Imports Microsoft.VisualBasic

Namespace C21MIT.VOCALDISORDERS.Util

    Public Class ParsingOperations

        Public Shared Function GetXMLNodeValue(ByVal pXPath As String, ByVal pXMLFilePath As String) As String

            Dim vMessage As String


            Dim Doc As New System.Xml.XmlDocument()
            Doc.Load(pXMLFilePath)

            Dim Root As System.Xml.XmlElement = Doc.DocumentElement
            Dim myNode As System.Xml.XmlNode = Root.SelectSingleNode(pXPath)

            If Not IsNothing(myNode) Then
                vMessage = myNode.InnerXml
            Else

                vMessage = ""

            End If

            Return vMessage


        End Function

        Public Shared Function GetXMLNode(ByVal pXPath As String, ByVal pXMLFilePath As String) As  _
            System.Xml.XmlNode

            Dim Doc As New System.Xml.XmlDocument()
            Doc.Load(pXMLFilePath)

            Dim Root As System.Xml.XmlElement = Doc.DocumentElement
            Dim myNode As System.Xml.XmlNode

            myNode = Root.SelectSingleNode(pXPath)

            If IsNothing(myNode) Then
                myNode = Root.SelectSingleNode("/ROOT/NoNode")

            End If

            Return myNode


        End Function

        Public Shared Function GetDecryptQString(ByVal qName As String) As String
            Dim qVal As String = ""

            If Not IsNothing(qName) Then
                qVal = C21MIT.Util.RJEncryp.DecryptString128Bit _
                (System.Web.HttpContext.Current.Request.QueryString(qName), _
                System.Web.HttpContext.Current.Session("sDKey"))

                Return qVal

            End If
        End Function

        Public Shared Function DecryptUIDQString() As Integer
            Dim encrypUID As String = System.Web.HttpContext.Current.Request.QueryString("qUID")

            Dim qVal As Object



            If Not IsNothing(encrypUID) Then

                ''The request object automatically replaces + with a blank value. This is to revert back the autochange
                encrypUID = encrypUID.Replace(" ", "+")

                qVal = C21MIT.Util.RJEncryp.DecryptString128Bit _
                (encrypUID, System.Web.HttpContext.Current.Session("sDKey"))

                If IsNumeric(qVal) Then

                    Return CType(qVal, Integer)

                Else
                    HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=InvalidUID")

                End If
            Else
                HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=InvalidUID")
            End If
        End Function

        Public Shared Function DecryptUIDQString(ByVal pQVar As String) As Integer
            Dim encrypUID As String = System.Web.HttpContext.Current.Request.QueryString(pQVar)

            Dim qVal As Object

            If Not IsNothing(encrypUID) Then
                ''The request object automatically replaces + with a blank value. This is to revert back the autochange
                encrypUID = encrypUID.Replace(" ", "+")

                qVal = C21MIT.Util.RJEncryp.DecryptString128Bit _
                (encrypUID, System.Web.HttpContext.Current.Session("sDKey"))

                If IsNumeric(qVal) Then
                    Return CType(qVal, Integer)
                Else
                    HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=InvalidUID")
                End If
            Else
                HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=InvalidUID")
            End If
        End Function
    End Class
End Namespace
