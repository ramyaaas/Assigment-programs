<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist1.aspx.cs" Inherits="_27_oct_2020.datalist1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <p>Datalist show items of datatable</p>
            <asp:DataList ID="data1" runat="server">
                <ItemTemplate> 
                  <asp:Table ID="table1" runat="server" CellPadding="2" BorderColor="1">
                      <asp:TableRow>
                          <asp:TableCell><b>Firstname</b><span><%#Eval("fname") %></span></asp:TableCell>
                          <asp:TableCell><b>Lastname</b><span><%#Eval("lname") %></span></asp:TableCell>
                          <asp:TableCell><b>ID</b><span><%#Eval("id") %></span></asp:TableCell>
                          <asp:TableCell><b>Designation</b><span><%#Eval("disignation") %></span></asp:TableCell>
                          <asp:TableCell><b>Salary</b><span><%#Eval("salary") %></span></asp:TableCell>
                      </asp:TableRow>
                  </asp:Table>
             </ItemTemplate>  
            </asp:DataList>
       
              
        </div>
    </form>
</body>
</html>
