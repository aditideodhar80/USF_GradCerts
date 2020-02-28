<%@ Page Language="VB" AutoEventWireup="false" CodeFile="omessages.aspx.vb"  MasterPageFile="~/master/error.master" Inherits="users_omessages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div align="center" >
     <table style="width: 60%">
     <tr >
     <td style="height:60px"></td>
     </tr>
        <tr>
            <td align="center" >
                 <asp:Label ID="lblHeader" Font-Bold="true" runat="server" ForeColor="Red" ></asp:Label>
            </td>
        </tr>
        <tr>
          
          <td align="center">
           <table >
            <tr>
            <td style="text-align: center;">
            
                <asp:Label ID="lblMessage" runat="server" Width="523px"  Font-Size="Small"
                    BorderStyle="None"></asp:Label><br>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td class="emessage" >
                <asp:HyperLink ID="hlinkNext" runat="server">[hlinkNext]</asp:HyperLink>
    
            </td>
        </tr>
        
       </table>
      </td></tr>  
    </table>
    </div>
</asp:Content>
