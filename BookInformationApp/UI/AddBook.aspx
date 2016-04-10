<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookInformationApp.UI.AddBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Add Book"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="ISBN"></asp:Label>
        <asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Author"></asp:Label>
            <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        </p>
        <asp:Label ID="saveDetailsLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
