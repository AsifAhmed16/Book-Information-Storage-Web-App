<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BookInformationApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Index" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="IndexUI" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Font-Underline="False"></asp:Label>
    
    </div>
        <p>
            <asp:HyperLink runat="server" NavigateUrl = "~/UI/AddBook.aspx" Text="Add Book" Font-Size="20pt" ></asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink runat="server" NavigateUrl = "~/UI/ShowBook.aspx" Text="Show Book" Font-Size="20pt" ></asp:HyperLink>
        </p>
    </form>
</body>
</html>
