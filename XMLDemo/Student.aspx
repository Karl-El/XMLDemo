<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="XMLDemo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <%--<link href="Content/site.css" rel="stylesheet" type="text/css" />--%>
    <link href="Content/checkbox.css" rel="stylesheet" type="text/css" />
    <link href="Content/font-awesome.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="well">
                <h3>XML Database Demo</h3>
                <table class="table table-responsive">
                    <tr>
                        <th>Roll No:</th>
                        <td>
                            <asp:TextBox runat="server"  CssClass="form-control" ID="_txtID" />
                        </td>
                    </tr>
                    <tr>
                        <th>First Name:</th>
                        <td>
                            <asp:TextBox runat="server"  CssClass="form-control" ID="_txtFirstName" />
                        </td>
                    </tr>
                    <tr>
                        <th>Last Name:</th>
                        <td>
                            <asp:TextBox runat="server"  CssClass="form-control" ID="_txtLastName" />
                        </td>
                    </tr>
                    <tr>
                        <th>City:</th>
                        <td>
                            <asp:DropDownList runat="server" CssClass="form-control" ID="_drpdwnlstCity">
                                <asp:ListItem>Quezon City</asp:ListItem>
                                <asp:ListItem>Manila</asp:ListItem>
                                <asp:ListItem>Caloocan</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>Gender:</th>
                        <td>
                            <asp:RadioButtonList runat="server" CssClass="radio radio-info" ID="_rdbtnlstGender" >
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <th>Postal code:</th>
                        <td>
                            <asp:TextBox runat="server"  CssClass="form-control" ID="_txtPostalCode" />
                        </td>
                    </tr>
                    <tr>
                        <th>Mobile No:</th>
                        <td>
                            <asp:TextBox runat="server"  CssClass="form-control" ID="_txtMobileNo"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" CssClass="btn btn-default" Text="Insert" ID="_btnInsert" OnClick="_btnInsert_Click" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:GridView runat="server" ID="_grdvwStudent" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-responsive">
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
