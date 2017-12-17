<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="EmpDetail.aspx.cs" Inherits="EmployeeManagerProject.EmpDetail" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Maincontain2" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div>
                <fieldset style="width: 97%">
                    <legend>Employee Details</legend>
                    <table style="width: 100%; padding: 1px 1px 1px 1px; font-family: Verdana">
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%"></td>
                            <td align="left" valign="top" width="14%"></td>
                            <td width="1%"></td>
                            <td align="left" valign="top" width="68%">
                                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%"></td>
                            <td align="left" valign="top" width="14%"></td>
                            <td width="1%"></td>
                            <td align="left" valign="top" width="68%">
                               <%-- <asp:Label ID="lblEmpId" runat="server" Text=""></asp:Label>--%>
                                <asp:HiddenField ID="hdnempId" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">First Name
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtFirstName" Width="200px" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName"
                                    ErrorMessage="Enter First Name" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%"></td>
                            <td align="left" valign="top" width="14%">Middle Name
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtMiddleName" Width="200px" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Last Name
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtLastName" Width="200px" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLastName"
                                    ErrorMessage="Enter Last Name" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%"></td>
                            <td align="left" valign="top" width="14%">Address
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtAddress" Width="200px" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">City
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtCity" Width="200px" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCity"
                                    ErrorMessage="Enter City" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Gender
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:DropDownList ID="ddlGender" runat="server" Width="124px">
                                    <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" InitialValue="Select Gender"
                                    runat="server" ControlToValidate="ddlGender" ErrorMessage="Select Gender" Font-Bold="True"
                                    ForeColor="Red" ValidationGroup="Submit" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Email Id
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtEmailId" Width="200px" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmailId"
                                    ErrorMessage="Enter Email Id" Font-Bold="True" ForeColor="Red"
                                    ValidationGroup="Submit"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                    ControlToValidate="txtEmailId" ErrorMessage="Enter Valid Email Id"
                                    Font-Bold="True" ForeColor="Red"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    ValidationGroup="Submit"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Employee Status
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <div>
                                    <table width="100%">
                                        <tr>
                                            <td width="40%">
                                                <asp:RadioButtonList ID="rdoEmpStatus" runat="server"
                                                    RepeatDirection="Horizontal">
                                                    <asp:ListItem>Permanant</asp:ListItem>
                                                    <asp:ListItem>Contract</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </td>
                                            <td width="60%">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                                                    ControlToValidate="rdoEmpStatus" ErrorMessage="Select Status"
                                                    Font-Bold="True" ForeColor="Red"
                                                    ValidationGroup="Submit"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Department
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:DropDownList ID="ddlDepartment" runat="server" Width="140px"
                                    AppendDataBoundItems="True">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" InitialValue="0"
                                    runat="server" ControlToValidate="ddlDepartment" ErrorMessage="Select Department" Font-Bold="True"
                                    ForeColor="Red" ValidationGroup="Submit" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Employee Type
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:CheckBoxList ID="chkemptype" runat="server"
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Value="0">Single</asp:ListItem>
                                    <asp:ListItem Value="1">Married</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Date Of Birth
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtDateOfBirth" Width="200px" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="dateofbirth" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDateOfBirth"></cc1:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtDateOfBirth"
                                    ErrorMessage="Enter Date Of Birth" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%">*
                            </td>
                            <td align="left" valign="top" width="14%">Date Of Join
                            </td>
                            <td width="1%">:
                            </td>
                            <td align="left" valign="top" width="68%">
                                <asp:TextBox ID="txtDateOfJoin" Width="200px" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="ccdateofjoin" Format="dd/MM/yyyy" TargetControlID="txtDateOfJoin" runat="server"></cc1:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDateOfJoin"
                                    ErrorMessage="Enter Date Of Join" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td style="color: Red; vertical-align: top; width: 2%"></td>
                            <td align="left" valign="top" width="14%"></td>
                            <td width="1%"></td>
                            <td align="left" valign="top" width="68%">
                                <asp:Label ID="lblUserId" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td colspan="2" width="16%"></td>
                            <td width="1%"></td>
                            <td align="left" valign="top" width="68%">
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="60px" ValidationGroup="Submit" OnClick="btnSubmit_Click" />
                                <div class="divider">
                                </div>
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="60px" OnClick="btnCancel_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td width="15%">&nbsp;</td>
                            <td colspan="2" width="16%">&nbsp;</td>
                            <td width="1%">&nbsp;</td>
                            <td align="left" valign="top" width="68%">
                                <table style="width:100%">
                                    <tr>
                                        <td style="width:100%">

                                        
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" HeaderStyle-BackColor="Red" HeaderStyle-ForeColor="White" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" PageSize="5" ShowFooter="True" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Empid" Visible="false">
                                            <ItemTemplate>
                                                <asp:Label ID="lblgrempid" runat="server" Text='<%#Eval("EmpId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="EmpName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblname" runat="server" Text='<%#Eval("Firstname") %>'></asp:Label>
                                            </ItemTemplate>
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="txtname" runat="server" Text='<%#Eval("Firstname") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Last Name">
                                            <ItemTemplate>
                                                <asp:Label ID="lbllastname" runat="server" Text='<%#Eval("Lastname") %>'></asp:Label>
                                            </ItemTemplate>
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="txtlastname0" runat="server" Text='<%#Eval("Lastname") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Address">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="City">
                                            <ItemTemplate>
                                                <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Gender">
                                            <ItemTemplate>
                                                <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Edit">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" />
                                            </ItemTemplate>
                                            <%--<EditItemTemplate>
                                                <asp:LinkButton ID="btnUpdate" runat="server" CommandName="Update" Text="Update" />
                                                <br />
                                                <asp:LinkButton ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                                            </EditItemTemplate>--%>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('Do you want to Delete Record ?')">Delete</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" ForeColor="White" Font-Bold="True" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                                            </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>

                       <%-- <tr>
                            <td width="15%"></td>
                            <td colspan="4">
                                &nbsp;</td>
                        </tr>--%>
                    </table>
                </fieldset>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
