<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="FlightTicketBookinProject.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 222px;
        }
        .auto-style2 {
            width: 714px;
        }
    </style>
</head>
<body style="background-color:darkturquoise;background-image:url('flight2.jpg');background-repeat:no-repeat;background-size:cover; width: 928px;">
    <form id="form1" runat="server">
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Register Here&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h1>
        <div>
        </div>

    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Id</td>
            <td class="auto-style2"><asp:TextBox ID="textbox5" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Username</td>
            <td class="auto-style2"><asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" ErrorMessage="UserNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Email</td>
            <td class="auto-style2"><asp:TextBox ID="textbox6" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textbox6" ErrorMessage="Enter Valid Email" ForeColor="Red" ValidationExpression="^([a-zA-Z0-9]+@gmail.com)$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Password</td>
            <td class="auto-style2"><asp:TextBox ID="textbox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox2" ErrorMessage="PassworRequired" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Confirm Password</td>
            <td class="auto-style2"><asp:TextBox ID="textbox3" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="textbox2" ControlToValidate="textbox3" ErrorMessage="PasswordMissmatch" ForeColor="Red"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Age</td>
            <td class="auto-style2"><asp:TextBox ID="textbox4" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Gender</td>
            <td class="auto-style2">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        &nbsp;
        </p>
        <p>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Status"></asp:Label>
&nbsp;
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationTable %>" SelectCommand="SELECT * FROM [RegistrationTable]"></asp:SqlDataSource>

    </form>
    </body>
</html>
