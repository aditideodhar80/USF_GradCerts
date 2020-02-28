<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/master/main.master" CodeFile="miaddgradcerts.aspx.vb" Inherits="manage_migradcerts" %>

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
            <td></td>
            
        </tr>
          <tr>
            <td></td>
            
        </tr>
    </table>
      <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
<ajaxToolkit:TabContainer ID = "tab1" runat="server" AutoPostBack="false">

        <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" TabIndex="1" >
        <HeaderTemplate>
        <asp:Label ID="lblhdr1" runat="server" Font-Bold="True" 
                Text="Title and Description"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel1">
        <table width="100%" border="0">
           
            <tr>
                <td colspan="2" align="center"><asp:Label ID="lblTitle" runat="server" Text="Title and Description" Font-Bold="true" Font-Size="Small"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
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
                    <asp:Button ID="btnCheckCertificateAvail" CausesValidation="true" runat="server" Text="Check Certificate Code Availability" />
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
              <tr><td style="width:25%" valign="top"></td>
            <td style="width:75%"><asp:RequiredFieldValidator Text="Please select a valid Certificate Code" ID="rq1" runat="server" ControlToValidate="txtcertcode"></asp:RequiredFieldValidator></td>
               
            </tr>
             <tr>
                <td></td>
            </tr>
            <tr><td style="width:25%" valign="top"></td>
            <td style="width:75%"> <asp:Label ID="lblcertavailablitymsg" runat="server"></asp:Label></td>
               
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
                    <asp:ListItem Selected="True">--Select--</asp:ListItem>
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
                <td align="left"><asp:ImageButton  ID="btnSaveTitleDetails" runat="server" ImageUrl="~/images/savebutton.png" /></td>
            </tr>
            
            <tr>
                <td></td>
                <td align="left"><asp:ImageButton  ID="btnUpdateTitleDetails" runat="server" ImageUrl="~/images/nextbutton.png" /></td>
           </tr>
        </table>
           </asp:Panel>
                </ContentTemplate></ajaxToolkit:TabPanel>
                
                <!-- -->
                <!-- -->
                <!-- -->
                <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" TabIndex="2">
            <HeaderTemplate>
            <asp:Label ID="lblhdr2" runat="server" Font-Bold="True" 
                    Text="Admission Requirements"></asp:Label>
            </HeaderTemplate>
            <ContentTemplate>
             <asp:Panel runat="server" ID="Panel2">
            <table width="100%">
              <tr>
            <td align="center" colspan="2"><asp:Label ID="lblAdmiReq" runat="server" Text="Admission Requirements" Font-Bold="true" Font-Size="Small"></asp:Label></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
                <tr>
                    <td style="width:75%">
                        <asp:GridView ID="gvAdmissionReq" EmptyDataText="No data found" runat="server" AutoGenerateColumns="False"  Width="500px"
                        Font-Names="Arial" Font-Size="Small"  GridLines="Horizontal">
                          <HeaderStyle BackColor="Teal" />
                          <Columns>
                          
                            <asp:BoundField DataField="hid" Visible="false" />
                            
                               <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Label ID="lblCertDetails" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"hcertificatedetails")%>'  />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="imgbullet1" runat="server" ImageUrl="../images/lbwwhi.gif" />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="Admission Requirements">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="250" Width="500px" Height="40px"  TextMode="MultiLine"  Text='<%# DataBinder.Eval(Container.DataItem,"admissionreqdocuments")%>' ID="txtAdmissionReq" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                          </Columns>
                        </asp:GridView>
                    
                    </td>
                    
                    <td style="width:25%">
                        <table width="100%" runat="server">
                            <tr>
                                <td><asp:Button runat="server" ID="btnAddNewRow1" Text="Add Row" Width="100px" /></td>    
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnCancelNewRow1" Text="Cancel" Width="100px" /></td>   
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnDeleteRow1" Text="Delete" Width="100px" /></td>   
                             </tr>  
                              <tr>
                                <td><asp:Button runat="server" ID="btnSaveData1" Text="Save" Width="100px" /></td>   
                             </tr>    
                        </table>
                    </td>
                </tr>
                
            </table>
        </asp:Panel>
            </ContentTemplate></ajaxToolkit:TabPanel>
                
                <!-- -->
                <!-- -->
                <!-- -->
                
                   
                <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" TabIndex="2">
        <HeaderTemplate>
        <asp:Label ID="lblhdr3" runat="server" Font-Bold="True" 
                Text="Application Requirements"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel3">
              <table width="100%">
                <tr>
            <td align="center" colspan="2"><asp:Label ID="lblAppReq" runat="server" Text="Application Requirements" Font-Bold="true" Font-Size="Small"></asp:Label></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
                <tr>
                    <td style="width:75%">
                        <asp:GridView ID="gvApplicationReq" EmptyDataText="No data found" runat="server" AutoGenerateColumns="False"  Width="500px"
                        Font-Names="Arial" Font-Size="Small"  GridLines="Horizontal">
                          <HeaderStyle BackColor="Teal" />
                          <Columns>
                          
                            <asp:BoundField DataField="hid" Visible="false" />
                     <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="imgbullet1" runat="server" ImageUrl="../images/lbwwhi.gif" />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="Application Requirements">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="250" Width="500px" Height="40px"  TextMode="MultiLine"  Text='<%# DataBinder.Eval(Container.DataItem,"applicationrequirements")%>' ID="txtApplicationReq" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                          </Columns>
                        </asp:GridView>
                    
                    </td>
                    
                    <td style="width:25%">
                        <table id="Table1" width="100%" runat="server">
                            <tr>
                                <td><asp:Button runat="server" ID="btnAddNewRow2" Text="Add Row" Width="100px" /></td>    
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnCancelNewRow2" Text="Cancel" Width="100px" /></td>   
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnDeleteRow2" Text="Delete" Width="100px" /></td>   
                             </tr>  
                              <tr>
                                <td><asp:Button runat="server" ID="btnSaveData2" Text="Save" Width="100px" /></td>   
                             </tr>    
                        </table>
                    </td>
                </tr>
                
            </table>
            </asp:Panel>
            </ContentTemplate></ajaxToolkit:TabPanel>
                <!-- -->
                <!-- -->
                <!-- -->
                     
                <ajaxToolkit:TabPanel ID="TabPanel4" runat="server" TabIndex="2">
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
            <td></td>
          </tr>
                <tr>
                    <td style="width:75%">
                        <asp:GridView ID="gvContacts" EmptyDataText="No data found" runat="server" AutoGenerateColumns="False"  Width="400px"
                        Font-Names="Arial" Font-Size="Small"  GridLines="Horizontal">
                          <HeaderStyle BackColor="Teal" />
                          <Columns>
                          
                            <asp:BoundField DataField="hid" Visible="false" />
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="imgbullet1" runat="server" ImageUrl="../images/lbwwhi.gif" />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="First Name">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="20" Width="110px" Height="20px"  TextMode="SingleLine"  Text='<%# DataBinder.Eval(Container.DataItem,"firstname")%>' ID="txtfName" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Last Name">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="50" Width="110px" Height="20px"  TextMode="SingleLine"  Text='<%# DataBinder.Eval(Container.DataItem,"lastname")%>' ID="txtlName" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Phone">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="50" Width="110px" Height="20px"  TextMode="SingleLine" Text='<%# DataBinder.Eval(Container.DataItem,"phone")%>' ID="txtphone" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Email">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="50" Width="110px" Height="20px"  TextMode="SingleLine"  Text='<%# DataBinder.Eval(Container.DataItem,"email")%>' ID="txtemail" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Picture">
                                <ItemTemplate>
                                   <asp:FileUpload Width="200px" runat="server" Height="20px"  ID="flupload"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                          </Columns>
                        </asp:GridView>
                    
                    </td>
                    
                    <td style="width:25%">
                        <table id="Table2" width="100%" runat="server">
                            <tr>
                                <td><asp:Button runat="server" ID="btnAddNewRow3" Text="Add Row" Width="100px" /></td>    
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnCancelNewRow3" Text="Cancel" Width="100px" /></td>   
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnDeleteRow3" Text="Delete" Width="100px" /></td>   
                             </tr>  
                              <tr>
                                <td><asp:Button runat="server" ID="btnSaveData3" Text="Save" Width="100px" /></td>   
                             </tr>    
                        </table>
                    </td>
                </tr>
                
            </table>
            </asp:Panel>
              
        </ContentTemplate></ajaxToolkit:TabPanel>
                
                  <!-- -->
                <!-- -->
                <!-- -->
                           
                <ajaxToolkit:TabPanel ID="TabPanel5" runat="server" TabIndex="2">
        <HeaderTemplate>
        <asp:Label ID="lblhdr5" runat="server" Font-Bold="True" 
                Text="Required Courses"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel5">
              
            <table width="100%">
              <tr>
            <td align="center" colspan="2"><asp:Label ID="lblReqC" runat="server" Text="Required Courses" Font-Bold="true" Font-Size="Small"></asp:Label></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
                <tr>
                    <td style="width:75%">
                        <asp:GridView ID="gvRequiredCourses" EmptyDataText="No data found" runat="server" AutoGenerateColumns="False"  Width="500px"
                        Font-Names="Arial" Font-Size="Small"  GridLines="Horizontal">
                          <HeaderStyle BackColor="Teal" />
                          <Columns>
                          
                            <asp:BoundField DataField="hid" Visible="false" />
                              <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="imgbullet1" runat="server" ImageUrl="../images/lbwwhi.gif" />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="Course Name">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="250" Width="500px" Height="40px"  TextMode="MultiLine"  Text='<%# DataBinder.Eval(Container.DataItem,"coursename")%>' ID="txtReqCourses" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                          </Columns>
                        </asp:GridView>
                    
                    </td>
                    
                    <td style="width:25%">
                        <table id="Table3" width="100%" runat="server">
                            <tr>
                                <td><asp:Button runat="server" ID="btnAddNewRow4" Text="Add Row" Width="100px" /></td>    
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnCancelNewRow4" Text="Cancel" Width="100px" /></td>   
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnDeleteRow4" Text="Delete" Width="100px" /></td>   
                             </tr>  
                              <tr>
                                <td><asp:Button runat="server" ID="btnSaveData4" Text="Save" Width="100px" /></td>   
                             </tr>    
                        </table>
                    </td>
                </tr>
                
            </table>
           
                </asp:Panel>
                </ContentTemplate></ajaxToolkit:TabPanel>
                  <!-- -->
                <!-- -->
                <!-- -->
                 <ajaxToolkit:TabPanel ID="TabPanel6" runat="server" TabIndex="2">
        <HeaderTemplate>
        <asp:Label ID="lblhdr6" runat="server" Font-Bold="True" 
                Text="Electives"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel6">
         
            <table width="100%">
              <tr>
            <td align="center" colspan="2"><asp:Label ID="Label1" runat="server" Text="Elective Courses" Font-Bold="true" Font-Size="Small"></asp:Label></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
                <tr>
                    <td style="width:75%">
                        <asp:GridView ID="gvElect" EmptyDataText="No data found" runat="server" AutoGenerateColumns="False"  Width="500px"
                        Font-Names="Arial" Font-Size="Small"  GridLines="Horizontal">
                          <HeaderStyle BackColor="Teal" />
                          <Columns>
                          
                            <asp:BoundField DataField="hid" Visible="false" />
                           <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="imgbullet1" runat="server" ImageUrl="../images/lbwwhi.gif" />
                                </ItemTemplate>
                                
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="Course Name">
                                <ItemTemplate>
                                    <asp:TextBox MaxLength="250" Width="500px" Height="40px"  TextMode="MultiLine"  Text='<%# DataBinder.Eval(Container.DataItem,"coursename")%>' ID="txtElectives" runat="server"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                          </Columns>
                        </asp:GridView>
                    
                    </td>
                    
                    <td style="width:25%">
                        <table id="Table4" width="100%" runat="server">
                            <tr>
                                <td><asp:Button runat="server" ID="btnAddNewRow5" Text="Add Row" Width="100px" /></td>    
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnCancelNewRow5" Text="Cancel" Width="100px" /></td>   
                            </tr>    
                             <tr>
                                <td><asp:Button  runat="server" ID="btnDeleteRow5" Text="Delete" Width="100px" /></td>   
                             </tr>  
                              <tr>
                                <td><asp:Button runat="server" ID="btnSaveData5" Text="Save" Width="100px" /></td>   
                             </tr>    
                        </table>
                    </td>
                </tr>
                
            </table>
         
           </asp:Panel></ContentTemplate></ajaxToolkit:TabPanel>
                </ajaxToolkit:TabContainer>
                </asp:Content>