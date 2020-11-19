<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="stateManagement.aspx.cs" Inherits="statemanagement.stateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="hit count" BackColor="Blue" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" />
       
            <br />
            <asp:Button ID="Button2" runat="server" Text="open another webpage" BackColor="Blue" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" PostBackUrl="~/newform.aspx" />

            <br />
    </div>
       
        <asp:HiddenField ID="HiddenField1" runat="server" value="0"/>

        <asp:HiddenField ID="hdnfldCurrentDateTime" runat="server" />  
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button2_Click" Text="Redirect" />
        <br />
        <br />
        <asp:Label ID="lbl" runat="server" Text=""/>
        <br />
        <br />
        <asp:HiddenField ID="HiddenField2" runat="server" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
       <asp:HiddenField ID="HiddenField3" runat="server" />
        <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button3_Click" />
                <asp:Label ID="Label2" runat="server"></asp:Label>

            </form>
</body>
</html>