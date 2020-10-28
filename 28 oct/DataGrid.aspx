<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGrid_Prac.aspx.cs" Inherits="WebApplication4.DataGrid_Prac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Table</h2>
            <asp:DataGrid ID="datagrid1" runat="server">
            </asp:DataGrid>
            <br />
            <h2>Student Table</h2>
            <asp:DataGrid ID="datagrid2" runat="server">
            </asp:DataGrid>
            <br />
            
            <h2>Indian Cricket Team Table</h2>
            <asp:DataGrid ID="datagrid3" runat="server">
            </asp:DataGrid>
            <br />
            
            <h2>Indian Railway Table</h2>
            <asp:DataGrid ID="datagrid4" runat="server">
            </asp:DataGrid>
            <br />
            
            <h2>Bank Table</h2>
            <asp:DataGrid ID="datagrid5" runat="server">
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>