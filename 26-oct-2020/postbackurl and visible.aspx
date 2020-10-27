<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linkbutton.aspx.cs" Inherits="oct_26_2020.linkbutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>It is a hyperlink style button</p>  
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" BackColor="DarkBlue" ForeColor="White">Click here</asp:LinkButton>  
            <asp:LinkButton ID="myLinkButton" runat="server" PostBackUrl="~/checkbox.aspx" > Click here! </asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="https://www.google.com" > Click here! </asp:LinkButton>
            <asp:LinkButton ID="myLinkButton1" Visible="True" runat="server"></asp:LinkButton>
        <p>  
            <asp:Label ID="Label1" runat="server"></asp:Label>  
       </p> 
        </div>
    </form>
</body>
</html>
