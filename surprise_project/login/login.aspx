
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FlightTicketBookinProject.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 234px;
        }
        .auto-style2 {
            width: 188px;
        }
        .auto-style3 {
            margin-left: 14px;
        }
        </style>
</head>
<body style="background-color:gainsboro;background-image:url('flight2.jpg');background-repeat:no-repeat;background-size:cover"">
    <form id="form1" runat="server">
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Page User&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="HomePage" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">UserName</td>
                <td class="auto-style2"><asp:TextBox ID="textbox1" runat="server"></asp:TextBox></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style2"><asp:TextBox ID="textbox2" runat="server"></asp:TextBox></td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="textbox2">Password Required</asp:RequiredFieldValidator>
               
                <td>
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            
        </table>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" ForeColor="#000099" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Not yet Registered?"></asp:Label>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Text="Register" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationTable %>" SelectCommand="SELECT * FROM [RegistrationTable]"></asp:SqlDataSource>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
