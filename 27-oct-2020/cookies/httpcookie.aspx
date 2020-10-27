<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="httpcookieassignment.aspx.cs" Inherits="_27_oct_2020.httpcookieassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="empid" Text="Label1" runat="server"></asp:Label><br />
            <asp:Label ID="empname" Text="Label2" runat="server"></asp:Label><br />
            <asp:Label ID="empsalary" Text="Label3" runat="server"></asp:Label><br />
            <asp:Label ID="empdesignation" Text="Label4" runat="server"></asp:Label><br />
        </div>
        <asp:Button ID="button1" runat="server" Text="submit" OnClick="button1_Click"></asp:Button >
    </form>
</body>
</html>
