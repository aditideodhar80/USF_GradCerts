Imports OboutInc.SlideMenu
Imports Microsoft.VisualBasic
Partial Class master_main
    Inherits System.Web.UI.MasterPage

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'If C21MIT.WEpisodes.BLL.CMUserAcct.IsUserLoggedIn() = False Then

    '  Menu1.Visible = False
    ' End If
    '
    'If Not IsPostBack Then
    '    'load user menu
    '    xmlMenu.DataFile = Server.MapPath("~/cmsresources/menuitems.xml")
    '    xmlMenu.XPath = "/menuitems/adminprofile/menuitem"

    'End If

    'Dim osm As SlideMenu
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

    'Protected Sub Menu1_MenuItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemDataBound

    'End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If C21MIT.METROINI..CMUserAcct.IsUserLoggedIn() = False Then
        '    ' hllink.Visible = False
        '    Menu1.Visible = False
        'End If
        Menu1.Visible = True

        If Not IsPostBack Then
            'load user menu
            xmlMenu.DataFile = Server.MapPath("~/resources/menuitems.xml")
            xmlMenu.XPath = "/menuitems/adminprofile/menuitem"

        End If

    End Sub

    Protected Sub Menu1_MenuItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemDataBound

    End Sub
End Class

