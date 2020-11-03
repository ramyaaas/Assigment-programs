<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="flightdetails.aspx.cs" Inherits="FlightTicketBookinProject.flightdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 105px;
        }
        .auto-style2 {
            width: 393px;
        }
    </style>
</head>
<body style="background-color:lightgreen;background-image:url('flight2.jpg');background-repeat:no-repeat;background-size:cover"">
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Flight Details</div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="flightnumber" HeaderText="flightnumber" SortExpression="flightnumber" />
                <asp:BoundField DataField="flightname" HeaderText="flightname" SortExpression="flightname" />
                <asp:BoundField DataField="source" HeaderText="source" SortExpression="source" />
                <asp:BoundField DataField="destination" HeaderText="destination" SortExpression="destination" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationTable %>" SelectCommand="SELECT * FROM [FlightDetails]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red"></asp:Label>
        <br />
        <p style="color:darkblue">Create Flight</p><table style="width:100%;">
            <tr>
                <td class="auto-style1">FlightId</td>
                <td class="auto-style2"><asp:TextBox ID="texbox1" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">FlightNumber</td>
                <td class="auto-style2"><asp:TextBox ID="textBox2" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">FlightName</td>
                <td class="auto-style2"><asp:TextBox ID="textbox3" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">Source</td>
                <td class="auto-style2"><asp:TextBox ID="textBox4" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">Destination</td>
                <td class="auto-style2"><asp:TextBox ID="textBox5" runat="server"></asp:TextBox></td>
                
            </tr>
        </table>
        <p>
            <asp:Button ID="Button1" runat="server" Text="AddFlight" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
