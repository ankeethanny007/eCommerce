<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetAuthors.aspx.cs" Inherits="eCommerceWeb.admin.GetAuthors" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/jquery.js" type="text/javascript"></script>
<script type="text/javascript">
function halim() {
    var answer = confirm("Silmek istediinizden eminmisiniz")
    if (answer) {
        alert('Basarıyla silindi');

    }
    else {
        alert('silmedin');
        $("a").attr("href", "GetAuthors.aspx");
    }
}
</script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>The List of the Authors</h2>
    <br /><br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
