<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiASP1.aspx.cs" Inherits="CookiesASP.CookiASP1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" /><br />
            <asp:Label ID="Label2" runat="server" /><br /><br />
        </div>
        
        <asp:Label ID="Label3" runat="server"  Text="Select Brand Preference"/><br />
        <asp:CheckBox ID="iphone" runat="server" Text="iPhone" OnCheckedChanged="CheckBox1_CheckedChanged" /><br />
        <asp:CheckBox ID="Oneplus" runat="server" Text="OnePlus" /><br />
        <asp:CheckBox ID="samsung" runat="server" Text="samsung" /><br />
        <asp:CheckBox ID="oppo" runat="server" Text="oppo" /><br />
        <asp:CheckBox ID="Nokia" runat="server" Text="Nokia" /><br />
        <asp:CheckBox ID="RealMe" runat="server" Text="RealMe" /><br />
        <asp:CheckBox ID="Vivo" runat="server" Text="Vivo" /><br />
        <asp:CheckBox ID="Lenovo" runat="server" Text="Lenovo" /><br />
        <asp:CheckBox ID="Lava" runat="server" Text="Lava" /><br />
        <asp:CheckBox ID="Micromax" runat="server" Text="Micromax" /><br />



        <asp:Button ID="Button1" runat="server" Text="CheckOn" OnClick="Button1_Click" />
    </form>
    <p>
        <asp:Label ID="Label4" runat="server"/>
    </p>
</body>
</html>