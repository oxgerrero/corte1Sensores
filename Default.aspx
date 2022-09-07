<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" OnTick="timer1_Tick" Interval="6000">
            </asp:Timer>
            <br />
            Proximidad&nbsp; <asp:TextBox ID="tbProximidad" runat="server"></asp:TextBox>
            <br />
            Infrarrojo&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbInfrarrojo" runat="server"></asp:TextBox>
            <br />
            Temperatura<asp:TextBox ID="tbTemperatura" runat="server"></asp:TextBox>
            <br />
            Humedad&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbHumedad" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
