Imports OboutInc.SlideMenu
Imports Microsoft.VisualBasic

Partial Class admin_mihome
    Inherits System.Web.UI.Page
    Dim osm As SlideMenu
    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    '    If Not Page.IsPostBack Then
    '        osm.AutoPostBack = True
    '        osm.StyleFolder = "../images/xp_blue"

    '        'build menu
    '        osm.AddParent("manage", "Graduate Certificates")
    '        osm.AddChild("viewsysinfo", "<img src='../images/xp_blue/xp_check.gif' class='SMChildImage'>View current Grad Certificates")

    '        osm.AddChild("addremove", "<img src='../images/xp_blue/xp_programs.gif' class='SMChildImage'>Add new Grad Certificate")

    '        osm.AddParent("other", "USF Recruit")
    '        osm.AddChild("mydocs", "<img src='../images/xp_blue/xp_documents.gif' class='SMChildImage'>My Documents")
    '        osm.AddChild("shareddocs", "<img src='../images/xp_blue/xp_sdocuments.gif' class='SMChildImage'>Shared Documents")
    '        osm.AddChild("cpanel", "<img src='../images/xp_blue/xp_setting.gif' class='SMChildImage'>Control Panel")

    '        osm.AddParent("filetasks", "File and Folder Tasks")
    '        osm.AddChild("newfolder", "<img src='../images/xp_blue/xp_newfolder.gif' class='SMChildImage'>Make a new folder")
    '        osm.AddChild("sharefolder", "<img src='../images/xp_blue/xp_share.gif' class='SMChildImage'>Share this folder")

    '    End If
    'End Sub

    'Protected Sub Page_Init(ByVal o As Object, ByVal e As EventArgs)
    '    osm = New SlideMenu()
    '    osm.ID = "xp_blue"
    '    SMPlaceholder.Controls.Add(osm)
    'End Sub

End Class
