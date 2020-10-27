<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookiecollection.aspx.cs" Inherits="_27_oct_2020.cookiecollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <asp:Label ID="Label1" runat="server" Text="Select your favourite fruits"></asp:Label>  
    <br />  
    <br />  
    <asp:CheckBox ID="apple" runat="server" Text="Apple" />  
    <br />  
    <asp:CheckBox ID="mango" runat="server" Text="Mango" />  
    <br />  
    <asp:CheckBox ID="orange" runat="server" Text="Orange" />  
    <br />  
    <asp:CheckBox ID="banana" runat="server" Text="Banana" />  
    <br />  
    <asp:CheckBox ID="strawberry" runat="server" Text="Strawberry" />  
    <br />  
    <asp:CheckBox ID="Pineapple" runat="server" Text="Pineapple" />  
    <br />  
    <br />  
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
    <p>  
        <asp:Label ID="Label2" runat="server"></asp:Label>  
    </p>  
        </div>
    </form>
</body>
</html>
