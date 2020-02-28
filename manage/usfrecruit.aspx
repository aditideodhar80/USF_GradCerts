<%@ Page Language="VB" AutoEventWireup="false" CodeFile="usfrecruit.aspx.vb" Inherits="manage_usfrecruit" %>

<%@ Register Assembly="Infragistics35.WebUI.WebHtmlEditor.v8.1" Namespace="Infragistics.WebUI.WebHtmlEditor"
    TagPrefix="ighedit" %>

<%@ Register Assembly="Infragistics35.WebUI.UltraWebGrid.v8.1" Namespace="Infragistics.WebUI.UltraWebGrid"
    TagPrefix="igtbl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 719px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%">
        <tr>
        <td>
                        <table width="100%">
                            <tr>
                                <td style="width:25%"><asp:Label ID="lblFirstName" runat="server" Text="Contact Person First Name"></asp:Label> </td>
                                  <td style="width:75%"><asp:TextBox ID="txtFirstName" BorderColor="Black" runat="server" MaxLength="20" Width="300px"></asp:TextBox></td>
                            </tr>
                              <tr>
                                <td style="width:25%"><asp:Label ID="lblLastName" runat="server" Text="Contact Person Last Name"></asp:Label> </td>
                                  <td style="width:75%"><asp:TextBox ID="txtLastName" BorderColor="Black" runat="server" MaxLength="20" Width="300px"></asp:TextBox></td>
                            </tr>
                             <tr>
                                <td style="width:25%"><asp:Label ID="lblPhone" runat="server" Text="Contact Person Phone"></asp:Label> </td>
                                  <td style="width:75%"><asp:TextBox ID="txtPhone" BorderColor="Black" runat="server" MaxLength="50" Width="300px"></asp:TextBox></td>
                            </tr>
                              <tr>
                                <td style="width:25%"><asp:Label ID="lblEmail" runat="server" Text="Contact Person Email"></asp:Label> </td>
                                  <td style="width:75%"><asp:TextBox ID="txtEmail" BorderColor="Black" runat="server" MaxLength="50" Width="300px"></asp:TextBox></td>
                            </tr>
                              <tr>
                                <td style="width:25%"><asp:Label ID="lblPictureLink" runat="server" Text="Contact Person Picture"></asp:Label> </td>
                                  <td style="width:75%">
                                  <asp:FileUpload ID="flPictureLink" runat="server" Width="300px" BorderColor="Black" /></td>
                              </tr>
                            <tr>
                                 <td style="width:25%"></td>
                                 <td style="width:75%"><asp:Label Visible="false" ID="lblMessage" runat="server" Text="Contact added successfully." ForeColor="Red"></asp:Label></td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr>
                               <td style="width:25%">                   </td>
                                  <td style="width:75%"><asp:Button ID="btnSave" runat="server" Text="Save and add another Contact"></asp:Button> <asp:Button ID="btnAddProceed" runat="server" Text="Save Contact and Proceed"></asp:Button> </td>
                            </tr>
                        </table>
                    </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:GridView ID="gvcontacts" runat="server" DataKeyNames="hid" AutoGenerateColumns="false">
                     <FooterStyle forecolor="#8C4510" backcolor=""></FooterStyle>
                <HeaderStyle font-size="10pt" font-names="Arial" font-bold="True" horizontalalign="Center" forecolor="#39362d" backcolor="#39362d"></HeaderStyle>
                <PagerStyle horizontalalign="Center" forecolor="#8C4510"></PagerStyle>
                
                <Columns>
                  <asp:TemplateField HeaderText="hid" Visible="true" >
                            <ItemTemplate><asp:Label runat="server" Visible="false" ID="pk" Text='<%# DataBinder.Eval(Container.DataItem,"hid")%>'></asp:Label></ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="CertId" Visible="true" >
                            <ItemTemplate><asp:Label runat="server" Visible="false" ID="cpk" Text='<%# DataBinder.Eval(Container.DataItem,"hcertificatedetails")%>'></asp:Label></ItemTemplate>
                     </asp:TemplateField>
                     
                      <asp:TemplateField HeaderText="First Name" Visible="true" >
                            <ItemTemplate>
                                <asp:TextBox runat="server" Visible="true" ID="txtFirstName" Text='<%# DataBinder.Eval(Container.DataItem,"firstname")%>'></asp:TextBox>
                                </ItemTemplate>
                     </asp:TemplateField>
                     
                    <asp:TemplateField HeaderText="Last Name" Visible="true" >
                        <ItemTemplate>
                            <asp:TextBox runat="server" Visible="true" ID="txtLastName" Text='<%# DataBinder.Eval(Container.DataItem,"lastname")%>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Phone" Visible="true" >
                        <ItemTemplate>
                            <asp:TextBox runat="server" Visible="true" ID="txtPhone" Text='<%# DataBinder.Eval(Container.DataItem,"phone")%>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Email" Visible="true" >
                        <ItemTemplate>
                            <asp:TextBox runat="server" Visible="true" ID="txtEmail" Text='<%# DataBinder.Eval(Container.DataItem,"email")%>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                         <asp:TemplateField HeaderText="Picture" Visible="true" >
                        <ItemTemplate>
                       <asp:FileUpload ID="fl1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
                </asp:GridView>
                
                <center><asp:Button CssClass="tctiformbutton"  runat="server" ID="save" Text = "Save" Width="72px" 
                Height="23px" /></center>
            </td>    
        
        </tr>
        <tr>
            <td>
                  <asp:Button ID="btnSubmit4" runat="server" Text="Submit Changes" Width="170px" CssClass="buttonbgimage" />
            </td>
        </tr>
        
        </table>
    
    </div>
    </form>
</body>
</html>




