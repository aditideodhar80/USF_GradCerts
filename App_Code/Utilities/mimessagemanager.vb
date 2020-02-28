Imports Microsoft.VisualBasic

Namespace C21MIT.VOCALDISORDERS.Util
    Public Class vdmessagemanager
        Public Shared Function EPageMessage(ByVal pPageIdentifier As String) As  _
           C21MIT.METROINI.BO.EMessageObj
            Dim myEMessageObj As New C21MIT.METROINI.BO.EMessageObj
            Dim pXMLFilePath As String = System.AppDomain.CurrentDomain.BaseDirectory() & "resources\mimessages.xml"
            Dim xpath As String

            Dim Doc As New System.Xml.XmlDocument()

            If Not pPageIdentifier.Equals("") Then
                xpath = "/ROOT/" & pPageIdentifier.ToString
            Else
                xpath = "/ROOT/NoNode"
            End If

            Dim myNode As System.Xml.XmlNode = C21MIT.VOCALDISORDERS.Util.ParsingOperations.GetXMLNode(xpath, pXMLFilePath)

            myEMessageObj.EPageHeader = myNode.ChildNodes(0).InnerXml
            myEMessageObj.EPageMessage = myNode.ChildNodes(1).InnerXml
            myEMessageObj.LinkVisible = CType(myNode.ChildNodes(2).InnerXml, Boolean)
            myEMessageObj.LinkText = myNode.ChildNodes(3).InnerXml
            myEMessageObj.LinkPath = myNode.ChildNodes(4).InnerXml

            Return myEMessageObj
        End Function
    End Class
End Namespace