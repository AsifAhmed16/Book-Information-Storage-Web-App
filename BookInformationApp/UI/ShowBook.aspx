<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBook.aspx.cs" Inherits="BookInformationApp.UI.ShowBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Show"></asp:Label>
    <div>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameSearchTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
        
        <asp:GridView ID="bookListGridView" runat="server" AutoGenerateColumns="False">
                
                <Columns>
                    <asp:TemplateField HeaderText="SN#">
                        <ItemTemplate><%# Container.DataItemIndex+1 %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ISBN">
                        <ItemTemplate><%#Eval("Isbn") %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate><%#Eval("Name") %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Author">
                        <ItemTemplate><%#Eval("Author") %></ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </form>
</body>
</html>
