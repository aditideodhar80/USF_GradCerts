<%@ Page Language="VB" MasterPageFile="~/master/main.master" AutoEventWireup="false" CodeFile="TEST.aspx.vb" Inherits="manage_TEST" %>
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
            <td></td>
            
        </tr>
          <tr>
            <td></td>
            
        </tr>
    </table>
      <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
<ajaxToolkit:TabContainer ID = "tab1" runat="server" AutoPostBack="TRUE">




 <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" TabIndex="1"  >
        <HeaderTemplate>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" 
                Text="Title and Description"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel2">
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
                    <asp:Button ID="btnCheckCertificateAvail" runat="server" Text="Check Certificate Code Availability" />
                </td>
            </tr>
            
            <tr>
                <td></td>
            </tr>
              <tr><td style="width:25%" valign="top"></td>
            <td style="width:75%"><%--<asp:RequiredFieldValidator Text="Please select a valid Certificate Code" ID="rq1" runat="server" ControlToValidate="txtcertcode"></asp:RequiredFieldValidator>--%></td>
               
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
                
                
                
                
                
                
                
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" TabIndex="2" >
        <HeaderTemplate>
        <asp:Label ID="lblhdr1" runat="server" Font-Bold="True" 
                Text="Admission Requirements"></asp:Label>
        </HeaderTemplate>
        <ContentTemplate>
         <asp:Panel runat="server" ID="Panel1">
       
         <table width="100%">
         
            <tr>
                    <td style="width:75%">
                          <igtbl:UltraWebGrid ID="gvAdmissionReq" runat="server"  DisplayLayout-AutoGenerateColumns="false" style="left: -46px; top: -30px;" Width="592px" Height="250px">
                        
                        <Bands>
                        
                            <igtbl:UltraGridBand>
                                <AddNewRow View="NotSet" visible = "NotSet">
                                    <RowStyle BackColor="SaddleBrown" />
                                </AddNewRow>
                                
                                <Columns>
                                
                                   <igtbl:UltraGridColumn BaseColumnName="hid" HeaderText="hid" Hidden="False"
                                        Key="hid">
                                        <Header Caption="hid">
                                        </Header>
                                    </igtbl:UltraGridColumn>
                                    
                                    
                                     <igtbl:UltraGridColumn BaseColumnName="hcertificatedetails" HeaderText="hcertificatedetails" Hidden="False"
                                            Key="hcertificatedetails">
                                            <Header Caption="hcertificatedetails">
                                            </Header>
                                      </igtbl:UltraGridColumn>
                                        
                        
                                    <igtbl:TemplatedColumn ValueList-Style-ForeColor="Black"  BaseColumnName="admissionreqdocuments" HeaderText="Admission Requirements" Key="admissionreqdocuments"
                                        Width="555px">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <CellTemplate>
                                          <asp:TextBox 
                                            Width="550px" ID="txtadmissionreqdocuments" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"admissionreqdocuments") %>' OnTextChanged="txtPanel2_TextChanged"  TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        </CellTemplate>
                                        <Header Caption="Admission Requirements" >
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Header>
                                        <Footer>
                                            <RowLayoutColumnInfo OriginX="1" />
                                        </Footer>
                                    </igtbl:TemplatedColumn>
                                      <igtbl:UltraGridColumn BaseColumnName="i_order" HeaderText="Order" Hidden="True"
                                     Key="i_order">
                                    <Header Caption="Order">
                                <RowLayoutColumnInfo OriginX="2" />
                            </Header>
                            <Footer>
                                <RowLayoutColumnInfo OriginX="2" />
                            </Footer>
                        </igtbl:UltraGridColumn>
                                                     
                                </Columns>
                                   <RowTemplateStyle BackColor="Transparent" BorderColor="Transparent" BorderStyle="Ridge">
                        <BorderDetails WidthBottom="3px" WidthLeft="3px" WidthRight="3px" WidthTop="3px" />
                    </RowTemplateStyle>
                     <RowEditTemplate>
                        <br />
                        <p align="center">
                            <input id="igtbl_reOkBtn" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="OK" />&nbsp;
                            <input id="igtbl_reCancelBtn" onclick="igtbl_gRowEditButtonClick(event);" style="width: 50px"
                                type="button" value="Cancel" /></p>
                    </RowEditTemplate>
                 
                            </igtbl:UltraGridBand>
                        </Bands>
                        
                         <DisplayLayout AllowColumnMovingDefault="NotSet" AllowDeleteDefault="NotSet"
                AllowSortingDefault="NotSet" AllowUpdateDefault="NotSet" BorderCollapseDefault="NotSet"
                HeaderClickActionDefault="NotSet" Name="gvBullets" RowHeightDefault="20px" SelectTypeRowDefault="Single"  StationaryMargins="Header"
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
                <FrameStyle BackColor="Transparent" BorderColor="InactiveCaption" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Width="592px" Height="250px">
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
                             
                          
                          <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
         <asp:Button ID="btnAdd1"  runat="server" Text="Add" Width="170px" CssClass="buttonbgimage" /></td>
                          </tr>
                          <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
        <asp:Button ID="btnUpdate1"  runat="server" Text="Update" Width="170px" CssClass="buttonbgimage" /></td>
                          </tr>
                          <tr>
                              <td style="width: 100px;height: 30px;" valign="top">
         <asp:Button ID="btnDelete1"  runat="server" Text="Delete" Width="170px" CssClass="buttonbgimage" /></td>
                          </tr>
                          
                          <tr>
                              <td style="width: 100px; height: 30px" valign="top">
                                  <asp:Button ID="btnSubmit1" runat="server" Text="Submit Changes" Width="170px" CssClass="buttonbgimage" /></td>
                          </tr>
                            
                            </tr>
                        
                        </table>
                      
                    
                    </td>
                </tr>
         </table>
           </asp:Panel>
           </ContentTemplate>
       </ajaxToolkit:TabPanel>
       
       
             <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" TabIndex="3">
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
                        
        <%--APPLICATION REQUIREMENTS GRIDVIEW--%>
                    
                    </td>
                    
                    <td style="width:25%">
                         <%--BUTTONS--%>
                    </td>
                </tr>
                
            </table>
            </asp:Panel>
            </ContentTemplate></ajaxToolkit:TabPanel>
                <!-- -->
                <!-- -->
                <!-- -->
                     
       </ajaxToolkit:TabContainer>
   </asp:Content>