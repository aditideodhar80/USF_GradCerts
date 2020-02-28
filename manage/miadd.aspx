<%@ Page Language="VB" MasterPageFile="~/master/main.master" AutoEventWireup="false" CodeFile="miadd.aspx.vb" Inherits="manage_miadd" %>

<%@ Register Assembly="Infragistics35.WebUI.WebHtmlEditor.v8.1" Namespace="Infragistics.WebUI.WebHtmlEditor"
    TagPrefix="ighedit" %>

<%@ Register Assembly="Infragistics35.WebUI.UltraWebGrid.v8.1" Namespace="Infragistics.WebUI.UltraWebGrid"
    TagPrefix="igtbl" %>


<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>
    
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
           
    <table width = "100%">
        <tr>
            <td  align="center"><asp:Label ID="lblMessAddUpdate" runat="server" Font-Bold="true" Font-Size="Medium"></asp:Label></td>
        </tr>
        <tr>
            <td align="center"><asp:Label Font-Bold="true" Font-Size="Small" ForeColor="Black" ID="lblCerName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
        </tr>
    </table>
      

 <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    
      
      
    <ajaxToolkit:TabContainer ID = "TAB1" runat="server">
        <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" TabIndex="1" Width="200px" >
            <HeaderTemplate>
                <asp:Label ID="lblhdr1" runat="server" Font-Bold="True" Text="Title and Description"></asp:Label>
            </HeaderTemplate>
            <ContentTemplate>
                <asp:Panel runat="server" ID="Panel1">
                    <table width="100%" border="0">
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Label ID="lblTitle" runat="server" Text="Title and Description" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2"><hr /></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top"><asp:Label ID="lblCertType" runat="server" Text="Certification Type"></asp:Label></td>
                            <td style="width:75%">
                                <asp:RadioButton GroupName="grpCertType"  Checked="true" ID="rdGP" runat="server" Text="Graduate Certification Program" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top"></td>
                            <td style="width:75%">
                                <asp:RadioButton GroupName="grpCertType" ID="rdFOGP" runat="server" Text="Fully Online Graduate Certification Program" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                         <tr>
                            <td style="width:25%" valign="top"></td>
                            <td style="width:75%">
                                <asp:RadioButton GroupName="grpCertType" ID="rdPOGP" runat="server" Text="Partially Online Graduate Certification Program" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblcertcode" runat="server" Text = "Certificate Code"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtcertcode" runat="server" MaxLength="4" Width="40px"></asp:TextBox>
                                <asp:Button ID="btnCheckCertificateAvail" CausesValidation="true" runat="server" CssClass="buttonbgimage" Text="Check Certificate Code Availability" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top"></td>
                            <td style="width:75%">
                                <asp:Label ID="rf1" runat="server" Forecolor="Red" Visible="false" Font-Size="Small" Text="This certificate code already exists. Select another one."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top"></td>
                            <td style="width:75%"> <asp:Label ID="lblcertavailablitymsg" Visible="false" Font-Size="Small" runat="server" Text="You can use this Certificate Code."></asp:Label></td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblCollCode" runat="server" Text = "College Code"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:DropDownList ID="ddlCollegeCode" runat="server">
                                <asp:ListItem Value="0">--Select--</asp:ListItem>
                                    <asp:ListItem Value="CPF">CPF</asp:ListItem>
                                    <asp:ListItem Value="CE">CE</asp:ListItem>
                                     <asp:ListItem Value="CEngg">CEngg</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblLinkName" runat="server" Text = "Link Name"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtLinkName" runat="server" MaxLength="225" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblCertName" runat="server" Text = "Certificate Name"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtCertName" runat="server" MaxLength="225" Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblCertTitle" runat="server" Text = "Certificate Title"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtCertTitle" runat="server" MaxLength="225" Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblBriefDesc" runat="server" Text = "Brief Description"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtBriefDesc" runat="server" MaxLength="5000" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                         <tr>
                            <td></td>
                         </tr>
                         <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblCEU" runat="server" Text = "CEU/Licensure"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtCEU" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                         
                        <tr>
                            <td style="width:25%" valign="top">
                                <asp:Label ID="lblCourseLoc" runat="server" Text = "Course Location"></asp:Label>
                            </td>
                            <td style="width:75%">
                                <asp:TextBox id="txtCourseLoc" runat="server" MaxLength="1000" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
            
                        <tr>
                            <td></td>
                        </tr>
            
                        <tr>
                            <td style="width:35%" valign="top">
                                <asp:Label ID="lblCreditTo" runat="server" Text = "Credit toward Graduate Degree"></asp:Label>
                            </td>
                            <td style="width:65%">
                                <asp:TextBox id="txtCreditTo" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
            
                        <tr>
                            <td></td>
                        </tr>
            
                         <tr>
                            <td style="width:35%" valign="top">
                                <asp:Label ID="lblTransferCredit" runat="server" Text = "Transfer Credit"></asp:Label>
                            </td>
                            <td style="width:65%">
                                <asp:TextBox id="txtTransferCredit" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td></td>
                        </tr>
            
                        <tr>
                            <td style="width:35%" valign="top">
                                <asp:Label ID="lblStandardizedtests" runat="server" Text = "Standardized tests"></asp:Label>
                            </td>
                            <td style="width:65%">
                            
                            
                            
                                <asp:TextBox id="txtStandardizedtests" runat="server" MaxLength="5000" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td></td>
                        </tr>
          
                        <tr>
                            <td style="width:35%" valign="top">
                                <asp:Label ID="lblAdmissionReq" runat="server" Text = "Admission Requirement Details"></asp:Label>
                            </td>
                            <td style="width:65%">
                                    <ighedit:WebHtmlEditor  ID="txtAdmissionReq" runat="server" Width="407px"  Height="100px" FontFormattingList="Heading 1=<h1>&Heading 2=<h2>&Heading 3=<h3>&Heading 4=<h4>&Heading 5=<h5>&Normal=<p>" FontSizeList="1,2,3,4,5,6,7"
                                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&Red Bold=color:red;font-weight:bold;&ALL CAPS=text-transform:uppercase;&all lowercase=text-transform:lowercase;&Reset="
                                    SpecialCharacterList="&#937;,&#931;,&#916;,&#934;,&#915;,&#936;,&#928;,&#920;,&#926;,&#923;,&#958;,&#956;,&#951;,&#966;,&#969;,&#949;,&#952;,&#948;,&#950;,&#968;,&#946;,&#960;,&#963;,&szlig;,&thorn;,&THORN;,&#402,&#1046;,&#1064;,&#1070;,&#1071;,&#1078;,&#1092;,&#1096;,&#1102;,&#1103;,&#12362;,&#12354;,&#32117;,&AElig;,&Aring;,&Ccedil;,&ETH;,&Ntilde;,&Ouml;,&aelig;,&aring;,&atilde;,&ccedil;,&eth;,&euml;,&ntilde;,&cent;,&pound;,&curren;,&yen;,&#8470;,&#153;,&copy;,&reg;,&#151;,@,&#149;,&iexcl;,&#14;,&#8592;,&#8593;,&#8594;,&#8595;,&#8596;,&#8597;,&#8598;,&#8599;,&#8600;,&#8601;,&#18;,&brvbar;,&sect;,&uml;,&ordf;,&not;,&macr;,&para;,&deg;,&plusmn;,&laquo;,&raquo;,&middot;,&cedil;,&ordm;,&sup1;,&sup2;,&sup3;,&frac14;,&frac12;,&frac34;,&iquest;,&times;,&divide;"  ightClickBehavior="Nothing" UploadedFilesDirectory="" FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" TabStripDisplay="False" ImageDirectory="../ig_common/htmleditor/">
                            
                                    <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                
                                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="CellProperties" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="ModifyTable" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                    </RightClickMenu>
                                    <DownlevelTextArea Width="550px" Wrap="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False">
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="DoubleSeparator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Bold" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Italic" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Underline" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Cut" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Copy" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Paste" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Undo" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Redo" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="UnorderedList" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="OrderedList" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="InsertLink" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="RemoveLink" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="CleanWord" />
                                    </Toolbar>
                                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" /> 
                                </ighedit:WebHtmlEditor>
                  
                            </td>
                        </tr>
            
                        <tr>
                            <td></td>
                        </tr>
            
                        <tr>
                            <td style="width:35%" valign="top">
                                <asp:Label ID="lblAppReqDetails" runat="server" Text = "Application Requirement Details"></asp:Label>
                            </td>
                            <td style="width:65%">
                            <ighedit:WebHtmlEditor  ID="txtAppReqDetails" runat="server" Width="407px"  Height="100px" FontFormattingList="Heading 1=<h1>&Heading 2=<h2>&Heading 3=<h3>&Heading 4=<h4>&Heading 5=<h5>&Normal=<p>" FontSizeList="1,2,3,4,5,6,7"
                                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&Red Bold=color:red;font-weight:bold;&ALL CAPS=text-transform:uppercase;&all lowercase=text-transform:lowercase;&Reset="
                                    SpecialCharacterList="&#937;,&#931;,&#916;,&#934;,&#915;,&#936;,&#928;,&#920;,&#926;,&#923;,&#958;,&#956;,&#951;,&#966;,&#969;,&#949;,&#952;,&#948;,&#950;,&#968;,&#946;,&#960;,&#963;,&szlig;,&thorn;,&THORN;,&#402,&#1046;,&#1064;,&#1070;,&#1071;,&#1078;,&#1092;,&#1096;,&#1102;,&#1103;,&#12362;,&#12354;,&#32117;,&AElig;,&Aring;,&Ccedil;,&ETH;,&Ntilde;,&Ouml;,&aelig;,&aring;,&atilde;,&ccedil;,&eth;,&euml;,&ntilde;,&cent;,&pound;,&curren;,&yen;,&#8470;,&#153;,&copy;,&reg;,&#151;,@,&#149;,&iexcl;,&#14;,&#8592;,&#8593;,&#8594;,&#8595;,&#8596;,&#8597;,&#8598;,&#8599;,&#8600;,&#8601;,&#18;,&brvbar;,&sect;,&uml;,&ordf;,&not;,&macr;,&para;,&deg;,&plusmn;,&laquo;,&raquo;,&middot;,&cedil;,&ordm;,&sup1;,&sup2;,&sup3;,&frac14;,&frac12;,&frac34;,&iquest;,&times;,&divide;"  ightClickBehavior="Nothing" UploadedFilesDirectory="" FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" TabStripDisplay="False" ImageDirectory="../ig_common/htmleditor/">
                            
                                    <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                
                                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="CellProperties" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="ModifyTable" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                    </RightClickMenu>
                                    <DownlevelTextArea Width="550px" Wrap="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False">
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="DoubleSeparator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Bold" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Italic" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Underline" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Cut" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Copy" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Paste" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Undo" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Redo" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="UnorderedList" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="OrderedList" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="InsertLink" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="RemoveLink" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="CleanWord" />
                                    </Toolbar>
                                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" /> 
                                </ighedit:WebHtmlEditor>
                        </td>
                    </tr>
            
                    <tr>
                        <td></td>
                    </tr>
            
                    <tr>
                        <td style="width:35%" valign="top">
                            <asp:Label ID="lblRegProcess" runat="server" Text = "Registration process"></asp:Label>
                        </td>
                        <td style="width:65%">
                        <ighedit:WebHtmlEditor  ID="txtRegProcess" runat="server" Width="407px"  Height="100px" FontFormattingList="Heading 1=<h1>&Heading 2=<h2>&Heading 3=<h3>&Heading 4=<h4>&Heading 5=<h5>&Normal=<p>" FontSizeList="1,2,3,4,5,6,7"
                                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&Red Bold=color:red;font-weight:bold;&ALL CAPS=text-transform:uppercase;&all lowercase=text-transform:lowercase;&Reset="
                                    SpecialCharacterList="&#937;,&#931;,&#916;,&#934;,&#915;,&#936;,&#928;,&#920;,&#926;,&#923;,&#958;,&#956;,&#951;,&#966;,&#969;,&#949;,&#952;,&#948;,&#950;,&#968;,&#946;,&#960;,&#963;,&szlig;,&thorn;,&THORN;,&#402,&#1046;,&#1064;,&#1070;,&#1071;,&#1078;,&#1092;,&#1096;,&#1102;,&#1103;,&#12362;,&#12354;,&#32117;,&AElig;,&Aring;,&Ccedil;,&ETH;,&Ntilde;,&Ouml;,&aelig;,&aring;,&atilde;,&ccedil;,&eth;,&euml;,&ntilde;,&cent;,&pound;,&curren;,&yen;,&#8470;,&#153;,&copy;,&reg;,&#151;,@,&#149;,&iexcl;,&#14;,&#8592;,&#8593;,&#8594;,&#8595;,&#8596;,&#8597;,&#8598;,&#8599;,&#8600;,&#8601;,&#18;,&brvbar;,&sect;,&uml;,&ordf;,&not;,&macr;,&para;,&deg;,&plusmn;,&laquo;,&raquo;,&middot;,&cedil;,&ordm;,&sup1;,&sup2;,&sup3;,&frac14;,&frac12;,&frac34;,&iquest;,&times;,&divide;"  ightClickBehavior="Nothing" UploadedFilesDirectory="" FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" TabStripDisplay="False" ImageDirectory="../ig_common/htmleditor/">
                            
                        <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                
                                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="CellProperties" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="ModifyTable" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                    </RightClickMenu>
                                    <DownlevelTextArea Width="550px" Wrap="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False">
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="DoubleSeparator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Bold" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Italic" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Underline" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Cut" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Copy" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Paste" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Undo" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Redo" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="UnorderedList" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="OrderedList" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="InsertLink" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="RemoveLink" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="CleanWord" />
                                    </Toolbar>
                                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" /> 
                    </ighedit:WebHtmlEditor>
                    </td>
                  </tr>
                          
                  <tr>
                    <td></td>
                  </tr>
            
              <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblTutionandFees" runat="server" Text = "Tuition and fees"></asp:Label>
                </td>
                <td style="width:65%">
                
                  <ighedit:WebHtmlEditor  ID="txtTutionandFees" runat="server" Width="407px"  Height="100px" FontFormattingList="Heading 1=<h1>&Heading 2=<h2>&Heading 3=<h3>&Heading 4=<h4>&Heading 5=<h5>&Normal=<p>" FontSizeList="1,2,3,4,5,6,7"
                                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&Red Bold=color:red;font-weight:bold;&ALL CAPS=text-transform:uppercase;&all lowercase=text-transform:lowercase;&Reset="
                                    SpecialCharacterList="&#937;,&#931;,&#916;,&#934;,&#915;,&#936;,&#928;,&#920;,&#926;,&#923;,&#958;,&#956;,&#951;,&#966;,&#969;,&#949;,&#952;,&#948;,&#950;,&#968;,&#946;,&#960;,&#963;,&szlig;,&thorn;,&THORN;,&#402,&#1046;,&#1064;,&#1070;,&#1071;,&#1078;,&#1092;,&#1096;,&#1102;,&#1103;,&#12362;,&#12354;,&#32117;,&AElig;,&Aring;,&Ccedil;,&ETH;,&Ntilde;,&Ouml;,&aelig;,&aring;,&atilde;,&ccedil;,&eth;,&euml;,&ntilde;,&cent;,&pound;,&curren;,&yen;,&#8470;,&#153;,&copy;,&reg;,&#151;,@,&#149;,&iexcl;,&#14;,&#8592;,&#8593;,&#8594;,&#8595;,&#8596;,&#8597;,&#8598;,&#8599;,&#8600;,&#8601;,&#18;,&brvbar;,&sect;,&uml;,&ordf;,&not;,&macr;,&para;,&deg;,&plusmn;,&laquo;,&raquo;,&middot;,&cedil;,&ordm;,&sup1;,&sup2;,&sup3;,&frac14;,&frac12;,&frac34;,&iquest;,&times;,&divide;"  ightClickBehavior="Nothing" UploadedFilesDirectory="" FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" TabStripDisplay="False" ImageDirectory="../ig_common/htmleditor/">
                            
                       <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                
                                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="CellProperties" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="ModifyTable" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                    </RightClickMenu>
                                    <DownlevelTextArea Width="550px" Wrap="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False">
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="DoubleSeparator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Bold" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Italic" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Underline" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Cut" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Copy" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Paste" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Undo" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Redo" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="UnorderedList" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="OrderedList" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="InsertLink" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="RemoveLink" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="CleanWord" />
                                    </Toolbar>
                                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" /> 
                    </ighedit:WebHtmlEditor>
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
            
            <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblFinancialAid" runat="server" Text = "Financial aid"></asp:Label>
                </td>
                <td style="width:65%">
                
                  <ighedit:WebHtmlEditor  ID="txtFinancialAid" runat="server" Width="407px"  Height="80px" FontFormattingList="Heading 1=<h1>&Heading 2=<h2>&Heading 3=<h3>&Heading 4=<h4>&Heading 5=<h5>&Normal=<p>" FontSizeList="1,2,3,4,5,6,7"
                                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&Red Bold=color:red;font-weight:bold;&ALL CAPS=text-transform:uppercase;&all lowercase=text-transform:lowercase;&Reset="
                                    SpecialCharacterList="&#937;,&#931;,&#916;,&#934;,&#915;,&#936;,&#928;,&#920;,&#926;,&#923;,&#958;,&#956;,&#951;,&#966;,&#969;,&#949;,&#952;,&#948;,&#950;,&#968;,&#946;,&#960;,&#963;,&szlig;,&thorn;,&THORN;,&#402,&#1046;,&#1064;,&#1070;,&#1071;,&#1078;,&#1092;,&#1096;,&#1102;,&#1103;,&#12362;,&#12354;,&#32117;,&AElig;,&Aring;,&Ccedil;,&ETH;,&Ntilde;,&Ouml;,&aelig;,&aring;,&atilde;,&ccedil;,&eth;,&euml;,&ntilde;,&cent;,&pound;,&curren;,&yen;,&#8470;,&#153;,&copy;,&reg;,&#151;,@,&#149;,&iexcl;,&#14;,&#8592;,&#8593;,&#8594;,&#8595;,&#8596;,&#8597;,&#8598;,&#8599;,&#8600;,&#8601;,&#18;,&brvbar;,&sect;,&uml;,&ordf;,&not;,&macr;,&para;,&deg;,&plusmn;,&laquo;,&raquo;,&middot;,&cedil;,&ordm;,&sup1;,&sup2;,&sup3;,&frac14;,&frac12;,&frac34;,&iquest;,&times;,&divide;"  ightClickBehavior="Nothing" UploadedFilesDirectory="" FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" TabStripDisplay="False" ImageDirectory="../ig_common/htmleditor/">
                            
                       <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                
                                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="CellProperties" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" InternalDialogType="ModifyTable" />
                                        </ighedit:HtmlBoxMenuItem>
                                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" Font-Italic="False"
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </ighedit:HtmlBoxMenuItem>
                                    </RightClickMenu>
                                    <DownlevelTextArea Width="550px" Wrap="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False">
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="DoubleSeparator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Bold" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Italic" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Underline" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Cut" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Copy" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Paste" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Undo" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Redo" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="UnorderedList" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="OrderedList" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="InsertLink" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="RemoveLink" />
                                        <ighedit:ToolbarImage runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="Separator" />
                                        <ighedit:ToolbarButton runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                            Font-Strikeout="False" Font-Underline="False" Type="CleanWord" />
                                    </Toolbar>
                                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" />
                                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                        Font-Underline="False" /> 
                    </ighedit:WebHtmlEditor>
    
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
            
            <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblTimeLimit" runat="server" Text = "Time limit"></asp:Label>
                </td>
                <td style="width:65%">
                    <asp:TextBox id="txtTimeLimit" runat="server" MaxLength="500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
            
            <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblDeptWebsite" runat="server" Text = "Department Website"></asp:Label>
                </td>
                <td style="width:65%">
                    <asp:TextBox id="txtDeptWebsite" runat="server" MaxLength="100" Width="400px"  TextMode="Singleline"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
               <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblPrereqs" runat="server" Text = "Prerequisite Details"></asp:Label>
                </td>
                <td style="width:65%">
                    <asp:TextBox id="txtPrereqs" runat="server" MaxLength="1500" Width="400px"  Height="60px"  TextMode="Multiline"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td></td>
            </tr>
            
            
        
            <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblRequiredCourseInfo" runat="server" Text = "Required Course Details"></asp:Label>
                </td>
                <td style="width:65%">
                    <asp:TextBox id="txtRequiredCourseInfo" runat="server" MaxLength="500" Width="400px"  Height="60px"  TextMode="Multiline"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td></td>
            </tr>
        
            <tr>
                <td style="width:35%" valign="top">
                    <asp:Label ID="lblElectiveCourseInfo" runat="server" Text = "Elective Course Details"></asp:Label>
                </td>
                <td style="width:65%">
                    <asp:TextBox id="txtElectiveCourseInfo" runat="server" MaxLength="500" Width="400px"  Height="60px"  TextMode="Multiline"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td></td>
                <td><asp:Label ID="lblfinal1" runat="server" Font-Size="Small"></asp:Label></td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
            
            <tr>
                <td></td>
                <td><asp:Label ID="lblMes1" runat="server"></asp:Label></td>
            </tr>
            
            <tr>
                <td></td>
                <td align="left">
                <asp:Button ID="btnSaveTitleDetails" runat="server" Text="Save" Width="70px" CssClass="buttonbgimage" />
                </td>
            </tr>
            
            <tr>
                <td></td>
                <td align="left">
                    <asp:Button ID="btnUpdateTitleDetails" runat="server" Text="Update" Width="70px" CssClass="buttonbgimage" />
                </td>
           </tr>
          
          </table>
       </asp:Panel>
       </ContentTemplate>
       </ajaxToolkit:TabPanel>
                
                <!-- -->
                <!-- -->
                <!-- -->
                
                
                
                
                <ajaxToolkit:TabPanel ID="TabPanel8" runat="server" TabIndex="2" Width="200px">
            <HeaderTemplate>
            <asp:Label ID="lblhdr8" runat="server" Font-Bold="True" 
                    Text="Prereqs."></asp:Label>
            </HeaderTemplate>
            <ContentTemplate>
             <asp:Panel runat="server" ID="Panel8">
                <table width="100%">
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lblPreReq" runat="server" Text="Prerequisites" Font-Bold="true" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2"><hr /></td>
                    </tr>

                  <tr>
                        <td>&nbsp;</td>
                  </tr>
                <tr>
                    <td style="width:75%">
                    <igtbl:UltraWebGrid ID="gvPrerequisites" runat="server"  DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                        <Bands>
                            <igtbl:UltraGridBand>
                                <AddNewRow View="NotSet" visible = "NotSet">
                                    <RowStyle BackColor="SaddleBrown" />
                                </AddNewRow>
                                
                                <Columns>
                                
                                   <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="True"
                            Key="hid">
                            <Header Caption="hid">
                            </Header>
                        </igtbl:UltraGridColumn>
                                    
                                    
                                     <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcert" Hidden="True"
                            Key="hcertificatedetails">
                            <Header Caption="hcertificatedetails">
                            </Header>
                        </igtbl:UltraGridColumn>
                        
                        
                                    <igtbl:TemplatedColumn ValueList-Style-ForeColor="White"  BaseColumnName="prerequisites" HeaderText="Prerequisites" Key="prerequisites"
                                        Width="555px">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <CellTemplate>
                                          <asp:TextBox 
                                             Width="550px" ID="txtPrerequisites" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"prerequisites") %>' OnTextChanged="txtPanel8_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        </CellTemplate>
                                        <Header Caption="Prerequisites"  >
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Header>
                                        <Footer>
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Footer>
                                    </igtbl:TemplatedColumn>
             
                                </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                    </RowTemplateStyle>
                     <RowEditTemplate>
                        <br />
                        <p align="center">
                            <input id="igtbl_reOkBtn8" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="OK" />&nbsp;
                            <input id="igtbl_reCancelBtn8" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="Cancel" /></p>
                    </RowEditTemplate>
                 
                            </igtbl:UltraGridBand>
                        </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvPrerequisites" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
                StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed" Version="4.00" AutoGenerateColumns="False">
          
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BorderColor="#929282" BackColor="#EFEFDE" BorderStyle="Solid" BorderWidth="1px" CssClass="style1"
                Font-Names="Verdana" Font-Size="8pt">
                <BorderDetails ColorLeft="White" ColorTop="White" />
                <Padding Left="3px" />
            </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault  CssClass="style6" BackColor="#225749"  BorderStyle="Solid">
                <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                
            </HeaderStyleDefault>
            
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Transparent" ForeColor="White" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
                </FrameStyle>
                    <RowAlternateStyleDefault BackColor="#FFFFF7" CssClass="style1">
                <BorderDetails ColorLeft="255, 255, 192" ColorTop="255, 255, 192" />
                <Padding Left="3px" />
            </RowAlternateStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <RowSelectorStyleDefault Cursor="Default">
                </RowSelectorStyleDefault>
            </DisplayLayout>
                        
                        </igtbl:UltraWebGrid>
                       
                    </td>
                    <td style="width:25%">
                        <table width="100%">
                              <tr>
                                    <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnAdd8" CssClass="buttonbgimage"  runat="server" Text="Add" Width="170px"  />
                                     </td>
                                </tr>
                              <tr>
                                  <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnUpdate8" CssClass="buttonbgimage"   runat="server" Text="Update" Width="170px"  />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnDelete8" CssClass="buttonbgimage"   runat="server" Text="Delete" Width="170px" />
                                  </td>
                              </tr>
                        </table>
                    </td>
                </tr>
              </table>
        </asp:Panel>
        </ContentTemplate>
        </ajaxToolkit:TabPanel>
        
        
        
        
        
        
        
        
        
        
        
       <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" TabIndex="2" Width="200px">
            <HeaderTemplate>
            <asp:Label ID="lblhdr2" runat="server" Font-Bold="True" 
                    Text="Admission"></asp:Label>
            </HeaderTemplate>
            <ContentTemplate>
             <asp:Panel runat="server" ID="Panel2">
                <table width="100%">
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lblAdmiReq" runat="server" Text="Admission Requirements" Font-Bold="true" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2"><hr /></td>
                    </tr>

                  <tr>
                        <td>&nbsp;</td>
                  </tr>
                <tr>
                    <td style="width:75%">
                    <igtbl:UltraWebGrid ID="gvAdmissionReq" runat="server"  DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                        <Bands>
                            <igtbl:UltraGridBand>
                                <AddNewRow View="NotSet" visible = "NotSet">
                                    <RowStyle BackColor="SaddleBrown" />
                                </AddNewRow>
                                
                                <Columns>
                                
                                   <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="True"
                            Key="hid">
                            <Header Caption="hid">
                            </Header>
                        </igtbl:UltraGridColumn>
                                    
                                    
                                     <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcert" Hidden="True"
                            Key="hcertificatedetails">
                            <Header Caption="hcertificatedetails">
                            </Header>
                        </igtbl:UltraGridColumn>
                        
                        
                                    <igtbl:TemplatedColumn ValueList-Style-ForeColor="White"  BaseColumnName="admissionreqdocuments" HeaderText="Admission Requirements" Key="admissionreqdocuments"
                                        Width="555px">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <CellTemplate>
                                          <asp:TextBox 
                                             Width="550px" ID="txtadmissionreqdocuments" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"admissionreqdocuments") %>' OnTextChanged="txtPanel2_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        </CellTemplate>
                                        <Header Caption="Admission Requirements"  >
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Header>
                                        <Footer>
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Footer>
                                    </igtbl:TemplatedColumn>
             
                                </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                    </RowTemplateStyle>
                     <RowEditTemplate>
                        <br />
                        <p align="center">
                            <input id="igtbl_reOkBtn2" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="OK" />&nbsp;
                            <input id="igtbl_reCancelBtn2" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="Cancel" /></p>
                    </RowEditTemplate>
                 
                            </igtbl:UltraGridBand>
                        </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvAdmissionReq" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
                StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed" Version="4.00" AutoGenerateColumns="False">
          
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BorderColor="#929282" BackColor="#EFEFDE" BorderStyle="Solid" BorderWidth="1px" CssClass="style1"
                Font-Names="Verdana" Font-Size="8pt">
                <BorderDetails ColorLeft="White" ColorTop="White" />
                <Padding Left="3px" />
            </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault  CssClass="style6" BackColor="#225749"  BorderStyle="Solid">
                <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                
            </HeaderStyleDefault>
            
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Transparent" ForeColor="White" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
                </FrameStyle>
                    <RowAlternateStyleDefault BackColor="#FFFFF7" CssClass="style1">
                <BorderDetails ColorLeft="255, 255, 192" ColorTop="255, 255, 192" />
                <Padding Left="3px" />
            </RowAlternateStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <RowSelectorStyleDefault Cursor="Default">
                </RowSelectorStyleDefault>
            </DisplayLayout>
                        
                        </igtbl:UltraWebGrid>
                       
                    </td>
                    <td style="width:25%">
                        <table width="100%">
                              <tr>
                                    <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnAdd2" CssClass="buttonbgimage"  runat="server" Text="Add" Width="170px"  />
                                     </td>
                                </tr>
                              <tr>
                                  <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnUpdate2" CssClass="buttonbgimage"   runat="server" Text="Update" Width="170px"  />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px;height: 30px;" valign="top">
                                        <asp:Button ID="btnDelete2" CssClass="buttonbgimage"   runat="server" Text="Delete" Width="170px" />
                                  </td>
                              </tr>
                        </table>
                    </td>
                </tr>
              </table>
        </asp:Panel>
        </ContentTemplate>
        </ajaxToolkit:TabPanel>
                
                <!-- -->
                <!-- -->
                <!-- -->
                
                   
                <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" TabIndex="3" Width="200px">
                    <HeaderTemplate>
                           <asp:Label ID="lblhdr3" runat="server" Font-Bold="True" 
                            Text="Application"></asp:Label>
                    </HeaderTemplate>
                    <ContentTemplate>
                        <asp:Panel runat="server" ID="Panel3">
                            <table width="100%">
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Label ID="lblAppReq" runat="server" Text="Application Requirements" Font-Bold="true" Font-Size="Small"></asp:Label>
                                    </td>
                                </tr>
          
                                <tr>
                                    <td colspan="2"><hr /></td>
                                </tr>
          
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width:75%">
                                        <igtbl:UltraWebGrid ID="gvApplicationReq" runat="server"  DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                                        <Bands>
                                        <igtbl:UltraGridBand>
                                            <AddNewRow View="NotSet" visible = "NotSet">
                                                <RowStyle BackColor="SaddleBrown" />
                                            </AddNewRow>
                                            
                                            <Columns>
                                
                                               <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="True" Key="hid">
                                                <Header Caption="hid"></Header>
                                               </igtbl:UltraGridColumn>
                                    
                                                <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcert" Hidden="True"
                                                    Key="hcertificatedetails">
                                                    <Header Caption="hcertificatedetails">
                                                    </Header>
                                                </igtbl:UltraGridColumn>
                        
                        
                                                <igtbl:TemplatedColumn ValueList-Style-ForeColor="Black"  BaseColumnName="applicationrequirements" HeaderText="Application Requirements" Key="applicationrequirements"
                                                    Width="555px">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <CellTemplate>
                                                      <asp:TextBox
                                                        Width="550px" ID="txtapplicationreqdocuments" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"applicationrequirements") %>' OnTextChanged="txtPanel3_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                                    </CellTemplate>
                                                    <Header Caption="Application Requirements" >
                                                        <RowLayoutColumnInfo OriginX="1" />
                                                    </Header>
                                                    <Footer>
                                                        <RowLayoutColumnInfo OriginX="1" />
                                                    </Footer>
                                                </igtbl:TemplatedColumn>
                                         </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                                   </RowTemplateStyle>
                                   <RowEditTemplate>
                                        <br />
                                        <p align="center">
                                        <input id="igtbl_reOkBtn3" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                            type="button" value="OK" />&nbsp;
                                        <input id="igtbl_reCancelBtn3" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                            type="button" value="Cancel" /></p>
                                    </RowEditTemplate>
                                </igtbl:UltraGridBand>
                            </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvApplicationReq" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
                StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed" Version="4.00" AutoGenerateColumns="False">
          
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BorderColor="#929282" BackColor="#EFEFDE" BorderStyle="Solid" BorderWidth="1px" CssClass="style1"
                Font-Names="Verdana" Font-Size="8pt">
                <BorderDetails ColorLeft="White" ColorTop="White" />
                <Padding Left="3px" />
            </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault  CssClass="style6" BackColor="#225749"  BorderStyle="Solid">
                <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                
            </HeaderStyleDefault>
            
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Transparent" ForeColor="White" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
                </FrameStyle>
                    <RowAlternateStyleDefault BackColor="#FFFFF7" CssClass="style1">
                <BorderDetails ColorLeft="255, 255, 192" ColorTop="255, 255, 192" />
                <Padding Left="3px" />
            </RowAlternateStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <RowSelectorStyleDefault Cursor="Default">
                </RowSelectorStyleDefault>
            </DisplayLayout>
                        
                        </igtbl:UltraWebGrid>
             </td>
                    
             <td style="width:25%">
                <table width="100%">
                    <tr>
                        <td style="width: 100px;height: 30px;" valign="top">
                            <asp:Button ID="btnAdd3" CssClass="buttonbgimage"  runat="server" Text="Add" Width="170px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;height: 30px;" valign="top">
                            <asp:Button ID="btnUpdate3" CssClass="buttonbgimage"  runat="server" Text="Update" Width="170px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px;height: 30px;" valign="top">
                            <asp:Button ID="btnDelete3" CssClass="buttonbgimage"  runat="server" Text="Delete" Width="170px" />
                        </td>
                     </tr>
                </table>
              </td>
          </tr>
        </table>
        </asp:Panel>
        </ContentTemplate>
        </ajaxToolkit:TabPanel>
                <!-- -->
                <!-- -->
                <!-- -->
                     
         <ajaxToolkit:TabPanel ID="TabPanel4" runat="server" TabIndex="4" Width="200px">
        <HeaderTemplate>
        <asp:Label ID="lblhdr4" runat="server" Font-Bold="True" 
                Text="Contacts"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
        <asp:Panel runat="server" ID="Panel4">
        <table width="100%" border="0">
            <tr>
                <td align="center" colspan="2"><asp:Label ID="lblContacts" runat="server" Text="Contact Information" Font-Bold="true" Font-Size="Small"></asp:Label></td>
            </tr>
          
            <tr>
                <td colspan="2"><hr /></td>
            </tr>
          
            <tr>
                <td>&nbsp;</td>
            </tr>
          
            <tr>
                <td align="center" colspan="2">
                    <asp:Label id= "lblAddNewContacts"  Font-Bold="true" Font-Size="Small" runat="server" Text="Add New Contact"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td style="width:100%" colspan="2">
                    <table width="100%">
                        <tr>
                            <td style="width:25%"><asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label></td>
                            <td style="width:75%"><asp:TextBox ID="txtFirstName" BorderWidth="1" BorderColor="#225749" runat="server" MaxLength="20" Width="300px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width:25%"><asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label> </td>
                            <td style="width:75%"><asp:TextBox ID="txtLastName" BorderWidth="1" BorderColor="#225749" runat="server" MaxLength="20" Width="300px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width:25%"><asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label> </td>
                            <td style="width:75%"><asp:TextBox ID="txtPhone" BorderWidth="1" BorderColor="#225749" runat="server" MaxLength="50" Width="300px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width:25%"><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label> </td>
                            <td style="width:75%"><asp:TextBox ID="txtEmail" BorderWidth="1" BorderColor="#225749" runat="server" MaxLength="50" Width="300px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width:25%"><asp:Label ID="lblPictureLink" runat="server" Text="Upload Picture"></asp:Label> </td>
                            <td style="width:75%">
                            <asp:FileUpload ID="flPictureLink" runat="server" BorderWidth="1" BorderColor="#225749" Width="300px" /></td>
                        </tr>
                        <tr>
                             <td style="width:25%"></td>
                             <td style="width:75%"><asp:Label Visible="false" ID="lblMessage" runat="server" Text="Contact added successfully." ForeColor="Red"></asp:Label></td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                           <td style="width:25%"></td>
                           <td style="width:75%"><asp:Button CssClass="buttonbgimage"  ID="btnSave" runat="server" Text="Save"></asp:Button></td>
                        </tr>
                      </table>
                    </td>
             </tr>
             <tr>
                <td colspan="2"><hr /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="2"><asp:Label id= "lblEditContacts"  Font-Bold="true" Font-Size="Small" runat="server" Text="Edit Contacts"></asp:Label></td>
            </tr>
            <tr>
                <td style="width:80%" colspan="2">
                
                    <asp:GridView ID="gvcontacts"  EmptyDataText = "No data to display" EmptyDataRowStyle-HorizontalAlign="Center" runat="server" DataKeyNames="hid" AutoGenerateColumns="false" >
                    <FooterStyle forecolor="#8C4510" backcolor="" ></FooterStyle>
                    <HeaderStyle font-size="10pt"  font-names="Arial" font-bold="True" horizontalalign="Center" forecolor="White" backcolor="#225749"></HeaderStyle>
                    <PagerStyle horizontalalign="Center" forecolor="#8C4510"></PagerStyle>
               
                    <Columns>
                      <asp:TemplateField HeaderText="hid" Visible="false"  >
                                <ItemTemplate><asp:Label runat="server" Visible="false" ID="pk" Text='<%# DataBinder.Eval(Container.DataItem,"hid")%>'></asp:Label></ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="CertId" Visible="false" >
                                <ItemTemplate><asp:Label runat="server" Visible="false" ID="cpk" Text='<%# DataBinder.Eval(Container.DataItem,"hcertificatedetails")%>'></asp:Label></ItemTemplate>
                         </asp:TemplateField>
                        <%-- 118 px earlier--%>
                          <asp:TemplateField HeaderText="First Name" Visible="true" >
                                <ItemTemplate>
                                    <asp:TextBox Width="175px" runat="server" Visible="true" ID="txtFirstName" Text='<%# DataBinder.Eval(Container.DataItem,"firstname")%>'></asp:TextBox>
                                    </ItemTemplate>
                         </asp:TemplateField>
                         
                        <asp:TemplateField HeaderText="Last Name" Visible="true" >
                            <ItemTemplate>
                                <asp:TextBox Width="175px"  runat="server" Visible="true" ID="txtLastName" Text='<%# DataBinder.Eval(Container.DataItem,"lastname")%>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Phone" Visible="true" >
                            <ItemTemplate>
                                <asp:TextBox Width="175px"  runat="server" Visible="true" ID="txtPhone" Text='<%# DataBinder.Eval(Container.DataItem,"phone")%>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Email" Visible="true" >
                            <ItemTemplate>
                                <asp:TextBox Width="175px"  runat="server" Visible="true" ID="txtEmail" Text='<%# DataBinder.Eval(Container.DataItem,"email")%>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
               
                        <%-- <asp:TemplateField HeaderText="Picture" Visible="true" >
                            <ItemTemplate>
                          <asp:Image ID="imgpic" runat="server" ImageUrl ='<%# DataBinder.Eval(Container.DataItem,"picturelink")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        
                       <%-- <asp:TemplateField HeaderText="Picture" Visible="true" >
                            <ItemTemplate>
                           <asp:FileUpload ID="fl1" Width="220px"  runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        --%>
                        <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                        <asp:CheckBox ID="chkdelete" Runat="server" Enabled="true"/>
                                </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center"></ItemStyle>
                             </asp:TemplateField>
                    </Columns>
            </asp:GridView>
        </td>
     </tr>
     <tr>
        <td align="center" colspan="2"><asp:Label ID="lblnorecs" runat="server" Visible="false" Text="No records found." ForeColor="Red" Font-Bold="true"></asp:Label></td>
     </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td><asp:Button CssClass="buttonbgimage"  runat="server" ID="save" Text = "Update" Width="72px" Height="23px" />&nbsp</td>
        <td align="right">
            <asp:Button ID="btnDelContacts" OnClientClick="return confirm('Are you sure to delete?')" runat="server" Text="Delete" Width="70px" CssClass="buttonbgimage" />
        </td>
      </tr>
          
        <tr>
            <td></td>
        </tr>
           
        <tr>
            <td>&nbsp;</td>
        </tr>
          
       <tr>
        <td style="width:100%" colspan="2" align="center" >
        </td>
       </tr>
              
     </table>
   </asp:Panel>
   </ContentTemplate>
  </ajaxToolkit:TabPanel>
                
                  <!-- -->
                <!-- -->
                <!-- -->
                           
    <ajaxToolkit:TabPanel ID="TabPanel5" runat="server" TabIndex="5" Width="200px">
        <HeaderTemplate>
            <asp:Label ID="lblhdr5" runat="server" Font-Bold="True" Text="Required Courses"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel5">
            <table width="100%">
                <tr>
                    <td align="center" colspan="2"><asp:Label ID="lblReqC" runat="server" Text="Required Courses" Font-Bold="true" Font-Size="Small"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2"><hr /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width:75%">
                       <igtbl:UltraWebGrid ID="gvReqCourses" runat="server" DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                        <Bands>
                            <igtbl:UltraGridBand>
                                <AddNewRow View="NotSet" visible = "NotSet">
                                    <RowStyle BackColor="SaddleBrown" />
                                </AddNewRow>
                                
                                <Columns>
                                 <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="True" Key="hid">
                                    <Header Caption="hid">
                                    </Header>
                                </igtbl:UltraGridColumn>
                                    
                                    
                                     <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcert" Hidden="True"
                                        Key="hcertificatedetails">
                                        <Header Caption="hcertificatedetails">
                                        </Header>
                                    </igtbl:UltraGridColumn>
                                    
                                    <igtbl:UltraGridColumn BaseColumnName="coursetype" HeaderText="coursetype" Hidden="True"
                                        Key="coursetype">
                                        <Header Caption="Course Type">
                                        </Header>
                                    </igtbl:UltraGridColumn>
                                    
                        
                                    <igtbl:TemplatedColumn ValueList-Style-ForeColor="Black"  BaseColumnName="coursename" HeaderText="Required Course Name" Key="coursename"
                                        Width="555px">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <CellTemplate>
                                          <asp:TextBox
                                            Width="550px" ID="txtcoursename" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"coursename") %>' OnTextChanged="txtPanel5_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        </CellTemplate>
                                        <Header Caption="Required Course Name" >
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Header>
                                        <Footer>
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Footer>
                                    </igtbl:TemplatedColumn>
                                     
                                       
                                </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                    </RowTemplateStyle>
                     <RowEditTemplate>
                        <br />
                        <p align="center">
                            <input id="igtbl_reOkBtn5" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="OK" />&nbsp;
                            <input id="igtbl_reCancelBtn5" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="Cancel" /></p>
                    </RowEditTemplate>
                 
                            </igtbl:UltraGridBand>
                        </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvReqCourses" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
                StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed" Version="4.00" AutoGenerateColumns="False">
          
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BorderColor="#929282" BackColor="#EFEFDE" BorderStyle="Solid" BorderWidth="1px" CssClass="style1"
                Font-Names="Verdana" Font-Size="8pt">
                <BorderDetails ColorLeft="White" ColorTop="White" />
                <Padding Left="3px" />
            </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault  CssClass="style6" BackColor="#225749"  BorderStyle="Solid">
                <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                
            </HeaderStyleDefault>
            
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Transparent" ForeColor="White" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
                </FrameStyle>
                    <RowAlternateStyleDefault BackColor="#FFFFF7" CssClass="style1">
                <BorderDetails ColorLeft="255, 255, 192" ColorTop="255, 255, 192" />
                <Padding Left="3px" />
            </RowAlternateStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <RowSelectorStyleDefault Cursor="Default">
                </RowSelectorStyleDefault>
            </DisplayLayout>
                        
                        </igtbl:UltraWebGrid>
            </td>
           <td style="width:25%">
                <table width="100%">
                    <tr>
                        <td style="width: 100px;height: 30px;" valign="top">
                            <asp:Button ID="btnAdd5" CssClass="buttonbgimage"  runat="server" Text="Add" Width="170px"  /></td>
                        </tr>
                        <tr>
                            <td style="width: 100px;height: 30px;" valign="top">
                                <asp:Button ID="btnUpdate5" CssClass="buttonbgimage"  runat="server" Text="Update" Width="170px" /></td>
                        </tr>
                         <tr>
                            <td style="width: 100px;height: 30px;" valign="top">
                                <asp:Button ID="btnDelete5" CssClass="buttonbgimage"  runat="server" Text="Delete" Width="170px" /></td>
                         </tr>
                        
                 </table>
            </td>
      </tr>
   </table>
</asp:Panel>
</ContentTemplate>
</ajaxToolkit:TabPanel>
                  <!-- -->
                <!-- -->
                <!-- -->
    <ajaxToolkit:TabPanel ID="TabPanel6" runat="server" TabIndex="6" Width="200px">
        <HeaderTemplate>
        <asp:Label ID="lblhdr6" runat="server" Font-Bold="True" 
                Text="Electives"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel6">
         
            <table width="100%">
                    <tr>
                        <td align="center" colspan="2"><asp:Label ID="lblElecCourses" runat="server" Text="Elective Courses" Font-Bold="true" Font-Size="Small"></asp:Label></td>
                    </tr>
                   <tr>
                    <td colspan="2"><hr /></td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
                <tr>
                    <td style="width:75%">
                    <igtbl:UltraWebGrid ID="gvElecCourses" runat="server" DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                        
                        <Bands>
                            <igtbl:UltraGridBand>
                                <AddNewRow View="NotSet" visible = "NotSet">
                                    <RowStyle BackColor="SaddleBrown" />
                                </AddNewRow>
                                
                                <Columns>
                                
                       
                                   <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="True" Key="hid">
                                    <Header Caption="hid">
                                    </Header>
                                </igtbl:UltraGridColumn>
                                    
                                    
                                     <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcert" Hidden="True"
                                        Key="hcertificatedetails">
                                        <Header Caption="hcertificatedetails">
                                        </Header>
                                    </igtbl:UltraGridColumn>
                                    
                                    <igtbl:UltraGridColumn BaseColumnName="coursetype" HeaderText="coursetype" Hidden="True"
                                        Key="coursetype">
                                        <Header Caption="Course Type">
                                        </Header>
                                    </igtbl:UltraGridColumn>
                                    
                        
                                    <igtbl:TemplatedColumn ValueList-Style-ForeColor="Black"  BaseColumnName="coursename" HeaderText="Elective Course Name" Key="coursename"
                                        Width="555px">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <CellTemplate>
                                          <asp:TextBox
                                            Width="550px" ID="txtcoursename" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"coursename") %>' OnTextChanged="txtPanel6_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        </CellTemplate>
                                        <Header Caption="Elective Course Name" >
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Header>
                                        <Footer>
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Footer>
                                    </igtbl:TemplatedColumn>
                                     
                                       
                                </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                    </RowTemplateStyle>
                     <RowEditTemplate>
                        <br />
                        <p align="center">
                            <input id="igtbl_reOkBtn6" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="OK" />&nbsp;
                            <input id="igtbl_reCancelBtn6" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="Cancel" /></p>
                    </RowEditTemplate>
                 
                            </igtbl:UltraGridBand>
                       </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvElecCourses" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
                StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed" Version="4.00" AutoGenerateColumns="False">
          
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BorderColor="#929282" BackColor="#EFEFDE" BorderStyle="Solid" BorderWidth="1px" CssClass="style1"
                Font-Names="Verdana" Font-Size="8pt">
                <BorderDetails ColorLeft="White" ColorTop="White" />
                <Padding Left="3px" />
            </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault  CssClass="style6" BackColor="#225749"  BorderStyle="Solid">
                <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                
            </HeaderStyleDefault>
            
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Transparent" ForeColor="White" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
                </FrameStyle>
                    <RowAlternateStyleDefault BackColor="#FFFFF7" CssClass="style1">
                <BorderDetails ColorLeft="255, 255, 192" ColorTop="255, 255, 192" />
                <Padding Left="3px" />
                </RowAlternateStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <RowSelectorStyleDefault Cursor="Default">
                </RowSelectorStyleDefault>
            </DisplayLayout>
                        
                        </igtbl:UltraWebGrid>
                    </td>
                    
                    <td style="width:25%">
                          <table width="100%">
                            <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
                                <asp:Button ID="btnAdd6" CssClass="buttonbgimage"  runat="server" Text="Add" Width="170px"  /></td>
                            </tr>
                            <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
                                <asp:Button ID="btnUpdate6" CssClass="buttonbgimage"  runat="server" Text="Update" Width="170px" /></td>
                            </tr>
                            <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
                                <asp:Button ID="btnDelete6" CssClass="buttonbgimage"  runat="server" Text="Delete" Width="170px" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
         
           </asp:Panel>
           </ContentTemplate>
           </ajaxToolkit:TabPanel>
           
           <ajaxToolkit:TabPanel ID="TabPanel7" runat="server" TabIndex="7" Width="200px">
           <HeaderTemplate>
                <asp:Label ID="lblsubmit" runat="server" Font-Bold="True"  ForeColor="Red" Text="Status"></asp:Label>
           </HeaderTemplate>
           <ContentTemplate>
            <asp:Panel runat="server" ID="Panel7">
              <table width="100%">
                  <tr>
                        <td align="center" colspan="2"><asp:Label ID="Label2" runat="server" Text="Submit Form" Font-Bold="true" Font-Size="Small"></asp:Label></td>
                  </tr>
                  <tr>
                    <td><hr /></td>
                  </tr>
                  <tr>
                    <td align="center" colspan="2"><asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Click the 'Save' button to update the status of the Certificate." Font-Bold="false" Font-Size="Smaller"></asp:Label></td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
                  
                  <tr>
                    <td align="center" colspan="2"><asp:DropDownList ID="ddlActiveInactive" runat="server">
                        <asp:ListItem Text = "Inactive" Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text = "Active" Value="1"></asp:ListItem>
                    </asp:DropDownList></td>
                  </tr>
                    <tr>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnPublish" runat="server" CssClass="buttonbgimage" OnClientClick="return confirm('Are you sure to save the changes?')" Text="Save" /></td>
                  </tr>
          
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
          
          
                  <tr>
                    <td align="center" colspan="2"><asp:Label ID="lblPublishMess" Visible="false" Font-Bold="true" ForeColor="Red" runat="server" Text="The Certificate status has been changed successfully."></asp:Label></td>
                  </tr>
                </table>
          </asp:Panel>
          </ContentTemplate>
          </ajaxToolkit:TabPanel>
         </ajaxToolkit:TabContainer>
   </asp:Content>