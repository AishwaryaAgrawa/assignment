<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registraion_Page.aspx.cs" Inherits="WebApplication5.Registraion_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
        .auto-style2 {
            width: 691px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">UserName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="321px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email Address</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="321px" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="321px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Confirm Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" Width="321px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="#6600CC" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="Blue" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">City</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Gujrat</asp:ListItem>
                        <asp:ListItem>Haryana</asp:ListItem>
                        <asp:ListItem>Punjab</asp:ListItem>
                        <asp:ListItem>UP</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                    <br />
                    <br />
 
                </td>
                
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>