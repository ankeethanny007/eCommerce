<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAuthor.aspx.cs" Inherits="eCommerceWeb.admin.InsertAuthor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        td
        {
            width:100px;
        }
        .button
        {
            float:right;
        }
        .validator
        {
            color:Red;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <h2>
   Insert Author Page
     
   </h2>
        <table >
            <tr>
                <td >
                    </td>
                <td>
                    </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td >
                     <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Alan boş geçilemez" 
                        SetFocusOnError="True" ValidationGroup="a" CssClass="validator"></asp:RequiredFieldValidator>
                  </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Alan boş geçilemez" 
                        SetFocusOnError="True" ValidationGroup="a" CssClass="validator"></asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td >
                    </td>
                <td>
                   
                    <asp:ImageButton ID="ButtonAdd"  runat="server" Text="Add" CssClass="button" 
                        ValidationGroup="a" ImageUrl="~/images/buttonAdd.png" 
                        onclick="ButtonAdd_Click" />
                   
                </td>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    </td>
            </tr>
        </table>
   
    </div>
    
    </form>
</body>
</html>
