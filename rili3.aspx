<%@ Page Language="VB" AutoEventWireup="false" CodeFile="rili3.aspx.vb" Inherits="rili3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        带提示的日历：<br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
            BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
            Height="250px" NextPrevFormat="ShortMonth" Width="330px">
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                ForeColor="White" Height="12pt" />
        </asp:Calendar>
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="xjy" />
        <asp:Button ID="Button2" runat="server" Text="xzy" />
        <asp:Button ID="Button3" runat="server" Text="Clear" />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
