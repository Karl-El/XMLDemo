<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="XMLDemo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <fieldset style="width: 400px">
                <legend>XML Database Demo</legend>
                <table border="1">
                    <tr>
                        <th>Roll No:</th>
                        <td>
                            <asp:TextBox runat="server" ID="_txtID" />
                        </td>
                    </tr>
                    <tr>
                        <th>First Name:</th>
                        <td>
                            <asp:TextBox runat="server" ID="_txtFirstName" />
                        </td>
                    </tr>
                    <tr>
                        <th>Last Name:</th>
                        <td>
                            <asp:TextBox runat="server" ID="_txtLastName" />
                        </td>
                    </tr>
                    <tr>
                        <th>City:</th>
                        <td>
                            <asp:DropDownList runat="server" ID="_drpdwnlstCity">
                                <asp:ListItem>Quezon City</asp:ListItem>
                                <asp:ListItem>Manila</asp:ListItem>
                                <asp:ListItem>Caloocan</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>Gender:</th>
                        <td>
                            <asp:RadioButtonList runat="server" ID="_rdbtnlstGender" RepeatDirection="Horizontal">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>

                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <th>Postal code:</th>
                        <td>
                            <asp:TextBox runat="server" ID="_txtPostalCode" />
                        </td>
                    </tr>
                    <tr>
                        <th>Mobile No:</th>
                        <td>
                            <asp:TextBox runat="server" ID="_txtMobileNo" />
                        </td>
                    </tr>
                    <tr>
                        <th>
                            <asp:Button runat="server" Text="Insert" ID="_btnInsert" OnClick="_btnInsert_Click"/>
                        </th>
                    </tr>
                </table>
                <br />
                <asp:GridView runat="server" ID="_grdvwStudent" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </fieldset>
        </div>
    </form>
</body>
</html>
