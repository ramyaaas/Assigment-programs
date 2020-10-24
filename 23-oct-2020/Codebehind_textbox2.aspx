<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Codebehind.aspx.cs" Inherits="Codebehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" runat="server" Text="click" ForeColor="black" OnClick="Button1_Click" />

            <asp:TextBox ID="TexBox1" runat="server" OnTextChanged="TexBox1_TextChanged" />
        </div>
    </form>
</body>
</html>
