<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/master/main.master" CodeFile="miaddnewgradcert.aspx.vb" Inherits="admin_gc_addnewgradcert" %>
<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
<style media="print">
.NoPrint
{
     display: none;
}
</style>
<style type="text/css">
.Hlink

{

cursor: pointer;

}
</style>
<script language="javascript">
    function Tab_SelectionChanged(sender, e) {
        var msg = "Header: " + sender.get_activeTab().get_headerText() + " ";

        msg += "Active Index: " + sender.get_activeTabIndex() + " ";
        msg += "ID: " + sender.get_element().id + " "; msg += "Page Url: " + sender.get_element().ownerDocument.location.href + " ";

        alert(msg);

    }
</script>

<%--<table width="100%">
    <tr>--%>
    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>


<ajaxToolkit:TabContainer ID = "tab1" runat="server" AutoPostBack="false">

        <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" TabIndex="1">
        <HeaderTemplate>
        <asp:Label ID="lblhdr2" runat="server" Font-Bold="True" 
                Text="View Graduate Certificates"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
        
            <td>
                </td></ContentTemplate></ajaxToolkit:TabPanel>
                
                 <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" TabIndex="2">
        <HeaderTemplate>
        <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Add New Graduate Certificate"></asp:Label></HeaderTemplate>
        <ContentTemplate>
        
       <table width="100%" border="0">
                    <tr>
                        <td  style="width:25%" align="center">
                           <asp:Label ID="hyl1" runat="server" Text="Add Title and Description"  Width="200px"></asp:Label>
                        </td>                       
                        <td style="width:25%" align="center">
                            <asp:Label ID="hyl2"  runat="server" Text="Add Contact Information" Width="200px" ></asp:Label>
                        </td><td style="width:25%" align="center">
                            <asp:Label ID="hyl3" runat="server" Text="Add Required Courses"  Width="200px"></asp:Label>
                        </td><td style="width:25%" align="left">
                            <asp:Label ID="hyl4" runat="server" Text="Add Elective Courses" Width="200px"></asp:Label>
                        </td></tr>
 
          </table>
     
     <table width="100%">
     
     
     <tr>
        <td>
            <asp:Panel runat="server" ID="Panel1">
               
               <table width="100%" border="0">
               <tr>
                <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center"><asp:Label Text="Graduate Program Certificate creation form" runat="server" ID="lbl1" Font-Bold="true"></asp:Label></td>
                </tr>
                <tr>
                    <td><hr></td>
                </tr>
                
                
                
                  
              
                <tr>
                    <td>
                    
                        <table width="100%" runat="server" border="0">
                          <tr>
                            <td></td>
                            </tr>
                        <tr>
                    <td style="width:25%" valign="top"><asp:Label ID="lblCertType" runat="server" Text="Certification Type"></asp:Label></td>
                    <td style="width:75%"><asp:RadioButton GroupName="grpCertType" ID="rdGP" runat="server" Text="Graduate Certification Program" />
                    </td>
                </tr>
                  <tr>
                    <td></td>
                </tr>
                      <tr>
                    <td style="width:25%" valign="top"></td>
                    <td style="width:75%"><asp:RadioButton GroupName="grpCertType" ID="rdOGP" runat="server" Text="Online Graduate Certification Program" />
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
                                    <asp:Button ID="btnCheckAvail" runat="server" Text="Check Certificate Code Availability" />
                                </td>
                               
                            </tr>
       <tr>
       <td></td>
       </tr>
                              <tr>
                                <td style="width:25%" valign="top">
                                    <asp:Label ID="lblCollCode" runat="server" Text = "College Code"></asp:Label>
                                </td>
                                <td style="width:75%">
                                    <asp:TextBox id="txtCollCode" runat="server" MaxLength="4" Width="40px"></asp:TextBox>
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
                                    <asp:TextBox id="txtCertName" runat="server" MaxLength="225" Width="500px"></asp:TextBox>
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
                                    <asp:TextBox id="txtCertTitle" runat="server" MaxLength="225" Width="500px"></asp:TextBox>
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
                                    <asp:TextBox id="txtBriefDesc" runat="server" MaxLength="5000" Width="500px" Height="60px" TextMode="MultiLine"></asp:TextBox>
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
                                    <asp:TextBox id="txtCEU" runat="server" MaxLength="1500" Width="500px" Height="60px" TextMode="MultiLine"></asp:TextBox>
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
                                    <asp:TextBox id="txtCourseLoc" runat="server" MaxLength="50" Width="400px" TextMode="SingleLine"></asp:TextBox>
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
                                    <asp:TextBox id="txtAdmissionReq" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>
                      
                <tr>
       <td></td>
       </tr>
      
                
                   <tr>
                                <td style="width:35%" valign="top">
                                    <asp:Label ID="lblAdRe" runat="server" Text = "Admission Requirements "></asp:Label>
                                </td>
                                <td valign="top">Add number of requirements to be added - 
                                <asp:TextBox ID="txtNoofDocs" runat="server" Width="40px"></asp:TextBox>
                                <asp:Button ID="btnCreateTextboxes" runat="server" Text="Add" />
                                </td>
                            </tr>
                   <tr>
       <td></td>
       </tr>
       
       <tr>
        <td>
        </td>
        
        <td>
            <asp:PlaceHolder ID="PHAdmissionReq" runat="server">
                
            </asp:PlaceHolder>
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
                                    <asp:TextBox id="txtAppReqDetails" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>
                     
                     
                     
                               <tr>
       <td></td>
       </tr>
      
                
                   <tr>
                                <td style="width:35%" valign="top">
                                    <asp:Label ID="lblAppRe" runat="server" Text = "Application Requirement documents"></asp:Label>
                                </td>
                                <td valign="top">Add number of documents to be added - 
                                <asp:TextBox ID="txtNoofAppReq" runat="server" Width="40px"></asp:TextBox>
                                <asp:Button ID="btnAddAppreqs" runat="server" Text="Add" />
                                </td>
                            </tr>
                   <tr>
       <td></td>
       </tr>
       
       
       
        <tr>
        <td>
        </td>
        
        <td>
            <asp:PlaceHolder ID="PHApplicationReq" runat="server">
                
            </asp:PlaceHolder>
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
                                    <asp:TextBox id="txtRegProcess" runat="server" MaxLength="1500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
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
                                    <asp:TextBox id="txtTutionandFees" runat="server" MaxLength="1000" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
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
                                    <asp:TextBox id="txtFinancialAid" runat="server" MaxLength="500" Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
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
        <td></td>
        <td align="left"><asp:ImageButton  ID="btnNext" runat="server" ImageUrl="~/images/savebutton.png" /></td>
       </tr>
       
       
                        </table>
                    </td>
                </tr>
               </table>
              
            </asp:Panel>
        </td>
     </tr>
     
       <tr>
        <td>
            <asp:Panel runat="server" ID="Panel2" >
            
               <table width="100%" border="0">
               <tr>
                <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center"><asp:Label Text="Graduate Program Certificate creation form" runat="server" ID="Label3" Font-Bold="true"></asp:Label></td>
                </tr>
                <tr>
                    <td><hr></td>
                </tr>
                
                <tr>
                    <td align="center"> <asp:Label Font-Bold="true" ID="lbl11" runat="server" Text="Contact Details"></asp:Label></td>
                </tr>
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
                                  <td style="width:75%"><asp:Button ID="btnSaveAnother" runat="server" Text="Save and add another Contact"></asp:Button> <asp:Button ID="btnAddProceed" runat="server" Text="Save Contact and Proceed"></asp:Button> </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                </table>
            </asp:Panel>
        </td>
     </tr>
     
       <tr>
        <td>
            <asp:Panel runat="server" ID="Panel3" >
               <table width="100%" border="0">
               <tr>
                <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center"><asp:Label Text="Graduate Program Certificate creation form" runat="server" ID="Label4" Font-Bold="true"></asp:Label></td>
                </tr>
                <tr>
                    <td><hr></td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" border="0">
                             <tr>
                                <td style="width:25%" valign="top">
                                    <asp:Label ID="lblReqcoursestobeAdded" runat="server" Text = "Required Courses "></asp:Label>
                                </td>
                                <td valign="top">Add number of required courses to be added - 
                                <asp:TextBox ID="txtReqcoursesToBeAdded" runat="server" Width="40px"></asp:TextBox>
                                <asp:Button ID="btnAddRequiredCourses" runat="server" Text="Add Courses" />
                                </td>
                            </tr>
                   
                                <tr>
                                    <td>
                                    </td>
                    
                                    <td>
                                        <asp:PlaceHolder ID="PHRequiredCourses" runat="server" >
                                            
                                        </asp:PlaceHolder>
                                    </td>
                                   </tr>
                                        <tr>
                                    <td colspan="2"><hr /></td>
                                   </tr>
                                   <tr>
                                                <td><asp:Button ID="btnToContacts" runat="server" Text="Go back to Contacts Page" /></td>
                                                <td align="left"><asp:ImageButton ID="btnSaveRequiredCourses" ImageUrl="~/images/savebutton.png" runat="server" /></td>
                                            </tr>
                         </table>
                                                </td>
                                             </tr>
                                             
                                             
                                            
                                            </table>
                                           </asp:Panel>
                                    </td>
                                 </tr>
     
               <tr>
                <td>
                    <asp:Panel runat="server" ID="Panel4" >
                     
                      
                      
                      
                      <table width="100%" border="0">
               <tr>
                <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center"><asp:Label Text="Graduate Program Certificate creation form" runat="server" ID="Label5" Font-Bold="true"></asp:Label></td>
                </tr>
                <tr>
                    <td><hr></td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" border="0">
                             <tr>
                                <td style="width:25%" valign="top">
                                    <asp:Label ID="Label6" runat="server" Text = "Elective Courses "></asp:Label>
                                </td>
                                <td valign="top">Add number of electives to be added - 
                                <asp:TextBox ID="txtElectiveCourses" runat="server" Width="40px"></asp:TextBox>
                                <asp:Button ID="btnAddElectiveCourses" runat="server" Text="Add Electives" />
                                </td>
                            </tr>
                   
                                <tr>
                                    <td>
                                    </td>
                    
                                    <td>
                                        <asp:PlaceHolder ID="PHElectives" runat="server">
                                            
                                        </asp:PlaceHolder>
                                    </td>
                                   </tr>
                                   
                                   <tr>
                                    <td colspan="2"><hr /></td>
                                   </tr>
                                   <tr>
                                                <td><asp:Button ID="btnTorequiredCourses" runat="server" Text="Go back to Required Courses Page" /></td>
                                                <td align="left"><asp:ImageButton ID="btnSaveElectives" ImageUrl="~/images/savebutton.png" runat="server" /></td>
                                            </tr>
                         </table>
                                                </td>
                                             </tr>
                                             
                                             
                                            
                                            </table>
                                            
                                            
                                            
                                            
                      
                      
                      </asp:Panel>
                </td>
             </tr>
                                 
</table>
     
     
                        
                        
        </ContentTemplate>
        </ajaxToolkit:TabPanel>
         
        
        </ajaxToolkit:TabContainer>
        
<%--    </tr>
</table>--%>
</asp:Content>
