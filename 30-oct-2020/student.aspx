<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="assignment.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 198px;
        }
        .auto-style2 {
            width: 388px;
        }
        .auto-style3 {
            width: 100%;
            height: 147px;
        }
    </style>
</head>
<body style="background-color:salmon; height: 397px;">
    <form id="form1" runat="server">
        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Registration Form<div>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">FirstName</td>
                <td><asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox1" ErrorMessage="FirstName Required"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">LastName</td>
                <td><asp:TextBox ID="textbox2" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">Father&#39;s Name</td>
                <td><asp:TextBox ID="textbox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textbox3" ErrorMessage="Father's namee required"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Mother&#39;s Name</td>
                <td><asp:TextBox ID="textbox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textbox4" ErrorMessage="Mother's name required"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                    <asp:RadioButton ID="RadioButton5" runat="server" Text="Female" />
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Aggregate</td>
                <td><asp:TextBox ID="textbox5" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="textbox5" ErrorMessage="Aggregate should be greater than 60%" MaximumValue="100" MinimumValue="60" Type="Integer"></asp:RangeValidator>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Course</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="ECE"   /><br />
                    <asp:CheckBox ID="checkbox1" runat="server" Text="Digital Communication" ></asp:CheckBox>
                    <asp:CheckBox ID="checkbox2" runat="server" Text="Analog"></asp:CheckBox>
                    <asp:CheckBox ID="checkbox3" runat="server" Text="Microcontroller"></asp:CheckBox><br />
                    <asp:RadioButton ID="RadioButton4" runat="server" Text="CSE" /><br />
                    <asp:CheckBox ID="checkbox4" runat="server" Text="ComputerOrganization"></asp:CheckBox>
                    <asp:CheckBox ID="checkbox5" runat="server" Text="Operating System"></asp:CheckBox>
                    <asp:CheckBox ID="checkbox6" runat="server"  Text="Graphics"></asp:CheckBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        </p>
        <p>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
