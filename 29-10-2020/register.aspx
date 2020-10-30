<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rapid development.aspx.cs" Inherits="_29_10_2020.rapid_development" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 197px;
        }
        .auto-style2 {
            width: 197px;
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            width: 99%;
            height: 228px;
        }
        .auto-style5 {
            width: 197px;
            height: 14px;
        }
        .auto-style6 {
            height: 14px;
            width: 261px;
        }
        .auto-style7 {
            width: 453px;
            height: 212px;
            margin-bottom: 28px;
        }
        .auto-style8 {
            width: 261px;
        }
        .auto-style9 {
            height: 25px;
            width: 261px;
        }
        .auto-style10 {
            margin-left: 7px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="background-color:aqua;align-content:center">
    <form id="form1" runat="server" class="auto-style7">
        <div>
        </div>
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">Id</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationTable %>" SelectCommand="SELECT * FROM [RegistrationTable]"></asp:SqlDataSource>
            </tr>
            <tr>
                <td class="auto-style1">UserName&nbsp; </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Email Address </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PassWord</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password">Enter Password</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">ConfirmPassword</td>
                
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox3" runat="server" Width="153px" TextMode="Password">Reenter the password</asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                
                <td class="auto-style9">
                    <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="Green" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Karnataka</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
        
        <p>
            <asp:Button ID="Button5" runat="server" Text="RedirectToAdmin" OnClick="Button5_Click" />
        </p>
        
    </form>
</body>
</html>
