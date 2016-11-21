<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListView.aspx.cs" Inherits="XMLDemo.StudentListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="_lstvwStudent" runat="server" DataSourceID="_xmldsStudent">
             <ItemTemplate>
                    <div class="col-sm-4">
                        <asp:Panel ID="Panel1" runat="server">
                            <div class="well">
                                <label class="control-label">User Type Name:</label>
                                <asp:Label ID="USERTYPEIDLabel" runat="server" Text='<%# Eval("USERTYPEID") %>' Visible="false" />
                                <label class="control-label">User Type Name:</label>
                                <asp:Label ID="USERTYPENAMELabel" runat="server" Text='<%# XPath("") %>' />
                            </div>
                        </asp:Panel>
                    </div>
                </ItemTemplate>
        </asp:ListView>
        <asp:XmlDataSource runat="server" ID="_xmldsStudent" DataFile="~/StudentData.xml"></asp:XmlDataSource>
    </div>
    </form>
</body>
</html>
