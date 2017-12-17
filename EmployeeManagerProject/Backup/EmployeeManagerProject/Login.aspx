<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="EmployeeManagerProject.Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div>
                <fieldset style="width: 470px">
                    <legend>Employee Manager Project </legend>
                    <table width="100%">
                     <tr>
                            <td style="color: Red; vertical-align: top" width="5%">
                                
                            </td>
                            <td align="left" valign="top" width="25%">
                                
                            </td>
                            <td>
                                
                            </td>
                            <td align="left" valign="top" width="70%">
                                <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="color: Red; vertical-align: top" width="5%">
                                *
                            </td>
                            <td align="left" valign="top" width="25%">
                                Username
                            </td>
                            <td>
                                :
                            </td>
                            <td align="left" valign="top" width="70%">
                                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername"
                                    ErrorMessage="Please Enter Username" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <tr>
                            <td style="color: Red; vertical-align: top" width="5%">
                                *
                            </td>
                            <td align="left" valign="top" width="25%">
                                Password
                            </td>
                            <td>
                                :
                            </td>
                            <td align="left" valign="top" width="70%">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                                    ErrorMessage="Please Enter Password" Font-Bold="True" ForeColor="Red" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <tr>
                         <td colspan="2" width="30%"></td>
                            <td colspan="2" align="left" valign="top" width="70%">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="60px" 
                                    onclick="btnLogin_Click" ValidationGroup="Submit" />
                                <asp:LinkButton ID="lnkRegister" runat="server" Text="Register" PostBackUrl="~/Register.aspx"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
