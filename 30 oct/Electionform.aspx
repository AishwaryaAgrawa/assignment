<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="ASPRegistrationOfCabinetElections.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 166px;
		}
		.auto-style2 {
			width: 302px;
		}
		.auto-style3 {
			margin-left: 318px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table style="width:100%; background-color:antiquewhite">
			<tr>
				<td class="auto-style1">Candidate Name</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Candidate Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Candidate House</td>
				<td class="auto-style2">&nbsp;
					<asp:RadioButton ID="RadioButton1" runat="server" Text="Red" />
&nbsp;
					<asp:RadioButton ID="RadioButton2" runat="server" Text="Blue" />
					<br />
&nbsp;<asp:RadioButton ID="RadioButton3" runat="server" Text="Yellow" />
&nbsp;
					<asp:RadioButton ID="RadioButton4" runat="server" Text="Green" />
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Candidate Home Required" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Class</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server" Width="294px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Class Required" ForeColor="Red"></asp:RequiredFieldValidator>
				&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="12" MinimumValue="6" Type="Integer">Class must be in between 6 to 12</asp:RangeValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Email ID</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox3" runat="server" Width="295px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Emai ID Required" ForeColor="Red"></asp:RequiredFieldValidator>
				&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter a valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
				</td>
			</tr>
		</table>
		<br />
		<asp:Button ID="Button1" runat="server" Text="Button" Width="207px" BackColor="#CCFF99" BorderColor="#003300" CssClass="auto-style3" />
    
    	<br />
    
    	<table style="width:100%; background-color:cadetblue">
			<tr>
				<td>
					<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
				</td>
			</tr>
		</table>
    
    </form>
</body>
</html>