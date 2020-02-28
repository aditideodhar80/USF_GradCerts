
Partial Class manage_gcviewcerts
    Inherits System.Web.UI.Page
#Region "Page Load"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'bind certificates and their status, edit and delete checkboxes
        If Not Page.IsPostBack Then
            'If IsValid Then
            C21MIT.METROINI.BLL.gcadminacc.EnsureAdminAccess()
            binddata()
            'End If
        End If
    End Sub
#End Region

    Protected Sub binddata()
        If C21MIT.METROINI.BLL.mimanage.getCertificatesList().Count > 0 Then
            gvcerts.DataSource = C21MIT.METROINI.BLL.mimanage.getCertificatesList()
            gvcerts.DataBind()
        Else
            gvcerts.Visible = False
            lblnorecs.Visible = True
        End If
        
    End Sub

    Protected Sub btnToAddGradCert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnToAddGradCert.Click
        'Response.Redirect("miaddgradcerts.aspx?Task=AddNew")
        'Response.Redirect("TEST.aspx?Task=Edit")
        'Response.Redirect("miadd.aspx?Task=Edit&certid=246")
        Response.Redirect("miadd.aspx?Task=AddNew")
    End Sub

    Protected Function EncryptString(ByVal hid As String) As String
        Return C21MIT.Util.RJEncryp.EncryptString128Bit(hid, Session("sDKey"))
    End Function

    Protected Sub gvcerts_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvcerts.PageIndexChanging
        binddata()
        gvcerts.PageIndex = e.NewPageIndex
        gvcerts.DataBind()
    End Sub


    Protected Sub gvcerts_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvcerts.RowDataBound
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim hylstatus As HyperLink = CType(e.Row.FindControl("lnkStatus"), HyperLink)
            Dim I As Integer
            I = e.Row.RowIndex

            If C21MIT.METROINI.BLL.mimanage.getCertificatesList().Item(I).status = 1 Then
                hylstatus.Text = "Active"
                hylstatus.Enabled = False
            ElseIf C21MIT.METROINI.BLL.mimanage.getCertificatesList().Item(I).status = 0 Then
                hylstatus.Text = "Inactive"
                hylstatus.Font.Bold = True
                hylstatus.Enabled = True
                hylstatus.NavigateUrl = "miadd.aspx?certid=" & C21MIT.METROINI.BLL.mimanage.getCertificatesList().Item(I).hid & "&task=Pending"
            End If

            Dim hylEdit As HyperLink = CType(e.Row.FindControl("lnkEdit"), HyperLink)

            If C21MIT.METROINI.BLL.mimanage.getCertificatesList().Item(I).status = 1 Then
                'hylstatus.Text = "Complete"
                hylEdit.Enabled = True
                hylEdit.Font.Bold = True
                hylEdit.NavigateUrl = "miadd.aspx?certid=" & C21MIT.METROINI.BLL.mimanage.getCertificatesList().Item(I).hid & "&task=Edit"
            Else
                hylEdit.Enabled = False

            End If
        End If
    End Sub


    Protected Sub btnDeleteCert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteCert.Click
        deletcerts()
        binddata()
    End Sub

    Protected Sub deletcerts()
        Dim dgitem As GridViewRow
        Dim isChecked As Boolean

        For Each dgitem In gvcerts.Rows
            'Make sure this is an item and not the header or footer
            If (dgitem.RowType = DataControlRowType.DataRow) Then
                ' First, get the studentID for the selected row 
                Dim lblhid As Label = CType(dgitem.FindControl("lblhid"), Label)
                isChecked = CType(dgitem.FindControl("chkDelete"), CheckBox).Checked

                If isChecked Then
                    Dim intcert As Integer
                    intcert = Convert.ToInt32(gvcerts.DataKeys(dgitem.RowIndex).Value)
                    'gvcontacts.DeleteRow(intcert)

                    Dim objdelcert As New C21MIT.METROINI.BO.gctitledetailsobject
                    objdelcert.hid = lblhid.Text

                    C21MIT.METROINI.DAL.mideletes.deletecerts(objdelcert.hid)
                Else

                End If
            End If
        Next
    End Sub
End Class
