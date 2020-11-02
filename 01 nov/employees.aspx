<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employees.aspx.cs" Inherits="DataboundControls.employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:aliceblue">
            <table style="border:2px solid red;width:300px;text-align:left;border-radius:2px;background-color:lime;padding-top:2px;border-radius:0px;font-size:20px;" class="auto-style3" />
               
            <asp:Repeater ID="rp2" runat="server">
                <HeaderTemplate>
                    <table style="width:200px;text-align:center;height:40px;background-color:gold" /> 
                  <tr>
                      <td style="font-size:20px;text-align:center;height:40px;background-color:yellow" >Employee Details</td>
                 
                  </tr>
                   
                   </table>

                </HeaderTemplate>
                <ItemTemplate>
                     <table style="width:100%; border:solid 2px;background-color:red">
                     <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label7" runat="server" Text="EmpId"></asp:Label>
                        </td>
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("EmpId")%>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="EmpName"></asp:Label>
                        </td>
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="Label8" runat="server" Text='<%#Eval("EmpName")%>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" Text="EmpEmail"></asp:Label>
                        </td>
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="Label9" runat="server" Text='<%#Eval("EmpEmail")%>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" >
                            <asp:Label ID="Label4" runat="server" Text="EmpMobileno"></asp:Label>
                        </td >
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="Label10" runat="server" Text='<%#Eval("EmpEmail")%>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label5" runat="server" Text="EmpImage"></asp:Label>
                        </td>
                        <td rowspan="5" >&nbsp;
                            <asp:Image ID="Image1" runat="server" Width="100px" ImageUrl='<%"~/Pictures/"+Eval("EmpImage")%>'></asp:Image>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label6" runat="server" Text="EmpGender"></asp:Label>
                        </td>
                        <td class="auto-style2">&nbsp;
                            <asp:Label ID="Label11" runat="server" Text='<%#Eval("EmpGender")%>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    
                </table>
                

                </ItemTemplate>
                <FooterTemplate>
                    <table style="background-color:aqua;border:solid 2px;color:red">
                        <tr>
                            <td>
                                 @developed by Haritha<br />
                                @All Copyrights reserved to this Page

                            </td>

                        </tr>
                    </table>
                </FooterTemplate>

            </asp:Repeater>
        </div>
                
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeTableConnectionString %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
                
   
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpIdLabel" runat="server" Text='<%# Eval("EmpId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpEmailLabel" runat="server" Text='<%# Eval("EmpEmail") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpMobilenoLabel" runat="server" Text='<%# Eval("EmpMobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpIdTextBox" runat="server" Text='<%# Bind("EmpId") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpEmailTextBox" runat="server" Text='<%# Bind("EmpEmail") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpMobilenoTextBox" runat="server" Text='<%# Bind("EmpMobileno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpIdTextBox" runat="server" Text='<%# Bind("EmpId") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpEmailTextBox" runat="server" Text='<%# Bind("EmpEmail") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpMobilenoTextBox" runat="server" Text='<%# Bind("EmpMobileno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpIdLabel" runat="server" Text='<%# Eval("EmpId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpEmailLabel" runat="server" Text='<%# Eval("EmpEmail") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpMobilenoLabel" runat="server" Text='<%# Eval("EmpMobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th runat="server">Id</th>
                                    <th runat="server">EmpId</th>
                                    <th runat="server">EmpName</th>
                                    <th runat="server">EmpEmail</th>
                                    <th runat="server">EmpMobileno</th>
                                    <th runat="server">EmpImage</th>
                                    <th runat="server">EmpGender</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpIdLabel" runat="server" Text='<%# Eval("EmpId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpEmailLabel" runat="server" Text='<%# Eval("EmpEmail") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpMobilenoLabel" runat="server" Text='<%# Eval("EmpMobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="EmpId" HeaderText="EmpId" SortExpression="EmpId" />
                <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                <asp:BoundField DataField="EmpEmail" HeaderText="EmpEmail" SortExpression="EmpEmail" />
                <asp:BoundField DataField="EmpMobileno" HeaderText="EmpMobileno" SortExpression="EmpMobileno" />
                <asp:BoundField DataField="EmpImage" HeaderText="EmpImage" SortExpression="EmpImage" />
                <asp:BoundField DataField="EmpGender" HeaderText="EmpGender" SortExpression="EmpGender" />
            </Columns>
        </asp:GridView>
         
       
       
          
        
        
        
        </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                Id:
                <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                <br />
                EmpId:
                <asp:TextBox ID="EmpIdTextBox" runat="server" Text='<%# Bind("EmpId") %>' />
                <br />
                EmpName:
                <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmail:
                <asp:TextBox ID="EmpEmailTextBox" runat="server" Text='<%# Bind("EmpEmail") %>' />
                <br />
                EmpMobileno:
                <asp:TextBox ID="EmpMobilenoTextBox" runat="server" Text='<%# Bind("EmpMobileno") %>' />
                <br />
                EmpImage:
                <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Id:
                <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                <br />
                EmpId:
                <asp:TextBox ID="EmpIdTextBox" runat="server" Text='<%# Bind("EmpId") %>' />
                <br />
                EmpName:
                <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmail:
                <asp:TextBox ID="EmpEmailTextBox" runat="server" Text='<%# Bind("EmpEmail") %>' />
                <br />
                EmpMobileno:
                <asp:TextBox ID="EmpMobilenoTextBox" runat="server" Text='<%# Bind("EmpMobileno") %>' />
                <br />
                EmpImage:
                <asp:TextBox ID="EmpImageTextBox" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:TextBox ID="EmpGenderTextBox" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Bind("Id") %>' />
                <br />
                EmpId:
                <asp:Label ID="EmpIdLabel" runat="server" Text='<%# Bind("EmpId") %>' />
                <br />
                EmpName:
                <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Bind("EmpName") %>' />
                <br />
                EmpEmail:
                <asp:Label ID="EmpEmailLabel" runat="server" Text='<%# Bind("EmpEmail") %>' />
                <br />
                EmpMobileno:
                <asp:Label ID="EmpMobilenoLabel" runat="server" Text='<%# Bind("EmpMobileno") %>' />
                <br />
                EmpImage:
                <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Bind("EmpImage") %>' />
                <br />
                EmpGender:
                <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Bind("EmpGender") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        </form>
        </div>
            
        
        
        
</body>
</html>