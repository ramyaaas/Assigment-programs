<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="FlightTicketBookinProject.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
        .auto-style8 {
            width: 203px;
            height: 39px;
        }
        .auto-style5 {
            margin-left: 67px;
        }
        .auto-style9 {
            width: 203px;
            height: 52px;
        }
        .auto-style10 {
            width: 203px;
            height: 42px;
        }
        .auto-style11 {
            width: 203px;
            height: 40px;
        }
        .auto-style12 {
            width: 203px;
            height: 41px;
        }
        </style>
</head>
<body style="background-image: url('flight3.jpg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Flight Ticket Booking </h2>
        
        <table class="auto-style4">
            <tr>
                <td class="auto-style9">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button6" runat="server" BackColor="#000066" ForeColor="Yellow" Height="27px" Text="Register" OnClick="Button6_Click" />
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style10">
                    
                    &nbsp;&nbsp;
                    
                    <asp:Button ID="Button2" runat="server" Text="Login" CssClass="auto-style5" BackColor="#000066" ForeColor="Yellow" OnClick="Button2_Click" />
                    
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style11">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Button3" runat="server" Text="Admin" BackColor="#000066" ForeColor="Yellow" OnClick="Button3_Click" />
                    
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style12">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Button5" runat="server" BackColor="#000066" ForeColor="Yellow" OnClick="Button5_Click" Text="BookTicket" />
                    
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style12">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Button4" runat="server" Text="ContactUs(Help)" BackColor="#000066" ForeColor="Yellow" OnClick="Button4_Click" />
                    
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style8">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Reservation" runat="server" BackColor="#000066" ForeColor="Yellow" Text="About Us" OnClick="Reservation_Click" />
                    
                    &nbsp;</td>
                
            </tr>
        </table>
        
    </form>
</body>
</html>
