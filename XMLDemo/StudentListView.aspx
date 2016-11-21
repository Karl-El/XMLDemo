<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListView.aspx.cs" Inherits="XMLDemo.StudentListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="Content/site.css" rel="stylesheet" type="text/css" />
    <link href="Content/checkbox.css" rel="stylesheet" type="text/css" />
    <link href="Content/font-awesome.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="_lstvwStudent" runat="server" DataSourceID="_xmldsStudent">
                <ItemTemplate>
                    <div class="col-sm-4">
                        <asp:Panel ID="Panel1" runat="server">
                            <div class="well">
                                <label class="control-label">ID:</label>
                                <asp:Label ID="_lblID" runat="server" Text='<%# XPath("id") %>' /><br />
                                <label class="control-label">First Name:</label>
                                <asp:Label ID="_lblFirstName" runat="server" Text='<%# XPath("firstname") %>' /><br />
                                <label class="control-label">Last Name:</label>
                                <asp:Label ID="_lblLastName" runat="server" Text='<%# XPath("lastname") %>' /><br />
                                <label class="control-label">City:</label>
                                <asp:Label ID="_lblCity" runat="server" Text='<%# XPath("city") %>' /><br />
                                <label class="control-label">Gender:</label>
                                <asp:Label ID="_lblGender" runat="server" Text='<%# XPath("gender") %>' /><br />
                                <label class="control-label">Postal Code:</label>
                                <asp:Label ID="_lblPostalCode" runat="server" Text='<%# XPath("postalcode") %>' /><br />
                                <label class="control-label">Mobile No.:</label>
                                <asp:Label ID="_lblMobileNo" runat="server" Text='<%# XPath("mobileno") %>' /><br />
                            </div>
                        </asp:Panel>
                    </div>
                </ItemTemplate>
                <LayoutTemplate>
                    <div id="itemPlaceholderContainer" runat="server" style="">
                        <span runat="server" id="itemPlaceholder" />
                    </div>
                </LayoutTemplate>
            </asp:ListView>
            <asp:XmlDataSource runat="server" ID="_xmldsStudent" DataFile="~/StudentData.xml"></asp:XmlDataSource>
        </div>
        <div class="row col-xs-12">
            <asp:DataPager ID="DataPager1" runat="server" PageSize="5" PagedControlID="_lstvwStudent">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="True" ButtonCssClass="btn btn-primary btn-sm" />
                    <asp:NumericPagerField NumericButtonCssClass="label label-success" CurrentPageLabelCssClass="badge" />
                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="True" ShowPreviousPageButton="False" ButtonCssClass="btn btn-primary btn-sm" />
                </Fields>
            </asp:DataPager>
        </div>
    </form>
</body>
</html>
