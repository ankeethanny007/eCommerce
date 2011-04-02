<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="eCommerceWeb.admin.AdminPanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style/StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
<h1>HALİM</h1>
    <form id="form1" runat="server">
    <center>
    <div id="wrapper">
    <div id="menu">
    <div id="author">
        <asp:ImageButton ID="ImageButtonAuthor" runat="server" Height="100px" 
            ImageUrl="~/images/author.png"  
            PostBackUrl="~/admin/Author.aspx" Width="120px" />
    </div>

    <div id="book">
    <asp:ImageButton ID="ImageButtonBook" runat="server" Height="100px" 
            ImageUrl="~/images/book.png" Width="120px" />
    </div>

     <div id="publisher">
     <asp:ImageButton ID="ImageButtonCategory" runat="server" Height="100px" 
             ImageUrl="~/images/category.png" Width="120px" />
    </div>

     <div id="category">
     <asp:ImageButton ID="ImageButtonPublisher" runat="server" Height="100px" 
             ImageUrl="~/images/publisher.png" Width="120px" />
    </div>

     <div id="member">
     <asp:ImageButton ID="ImageButtonMember" runat="server" Height="100px" 
             ImageUrl="~/images/member.png" Width="120px" />
    </div>
    </div>
    </div>
    </center>
    </form>
</body>
</html>
