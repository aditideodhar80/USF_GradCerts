<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/master/main.master" CodeFile="miviewcerts.aspx.vb" Inherits="manage_gcviewcerts" %>

<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>
    
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    
    <table width="100%">
    
        <tr>
            <td align="center"><asp:Label Font-Bold="true" Font-Size="Small" ID="lblView" runat="server" Text="View Graduate Certificates"></asp:Label></td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td align="center"> 
                <asp:GridView runat="server" ID="gvcerts" AutoGenerateColumns="False" AllowPaging="true" PageSize="10"  Font-Names="Arial"
                    Width="700px" BackColor="White" BorderColor="#336666" BorderWidth="2px" OnPageIndexChanging="gvcerts_PageIndexChanging"
                    CellPadding="4" GridLines="None" DataKeyNames="hid">
                    <PagerSettings Mode="Numeric" FirstPageText="First" />
                    <RowStyle BackColor="#EAE9DB" ForeColor="#333333" />
                    <Columns>
                       
                        
                                 <asp:TemplateField HeaderText="hid" Visible="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <asp:Label ID="lblhid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"hid")%>'></asp:Label>
                                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
                            </asp:TemplateField>
                            
                            
                             <asp:TemplateField HeaderText="Graduate Certificates" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <asp:Label ID="lblActivity" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"certificatename")%>'></asp:Label>
                                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Certificate Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" >
                                       <ItemTemplate>
                                            <asp:Label ID="lblCertType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"certificatetype")%>'></asp:Label>
                                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" >
                           
                            <ItemTemplate>
                             <asp:HyperLink  Text="Link" id = "lnkStatus" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center">
                           
                            <ItemTemplate>
                             <asp:HyperLink  Text="Edit" id = "lnkEdit" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                            
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
                           
                            <ItemTemplate>
                                <asp:CheckBox ID="chkDelete" runat="server" />
                            </ItemTemplate>
                            
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            
                            </asp:TemplateField>
                      </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
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
            <td align="center">
            <table width="89%" border="0">
                <tr>
                    <td align="left"> <asp:Button  ID="btnToAddGradCert" runat="server" Text="Add New Graduate Certificate" Width="220px" CssClass="buttonbgimage" /></td>
                    <td align="right"> <asp:Button ID="btnDeleteCert" OnClientClick="return confirm('Are you sure to delete?')"  runat="server" Text="Delete" CssClass="buttonbgimage"  /></td>
                </tr>
            </table>
            
           
        </td>
           
        </tr>
        
    </table>

</asp:Content>