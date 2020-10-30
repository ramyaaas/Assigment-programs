<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="election.aspx.cs" Inherits="assignment.election" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
    </style>
</head>
<body style="background-color:aqua">
    <form id="form1" runat="server">
        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Election Candidate Registration Form</h3>
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Candidate Name</td>
                
                <td><asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox1" ErrorMessage="CandidateNameRequired"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">House</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" Text="Red" />
                    <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#000099" Text="Blue" />
                    <asp:RadioButton ID="RadioButton3" runat="server" ForeColor="#009933" Text="Green" />
                    <asp:RadioButton ID="RadioButton4" runat="server" ForeColor="Yellow" Text="Yellow" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Class</td>
                <td><asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Class should be 6 to 12" MaximumValue="12" MinimumValue="6" Type="Integer" ControlToValidate="textbox2"></asp:RangeValidator>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td><asp:TextBox ID="textbox3" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textbox3" ErrorMessage="Enter Valid Email"  ValidationExpression="^([a-zA-Z0-9]+@gmail\\.com)$"></asp:RegularExpressionValidator>
                </td>
                
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
