<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage1.aspx.cs" Inherits="Project1.HomePage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Label ID="lblTitle" runat="server" Text="Welcome To The Course Management System"></asp:Label>
        </p>
        <asp:Label ID="lblLogin" runat="server" Text="Please Enter Your Login Credentials"></asp:Label>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="tbUser" runat="server"></asp:TextBox>
        </p>
        <p id="lblpass">
            <asp:Label ID="lblpass" runat="server" Text="Password:"></asp:Label>
        </p>
        <asp:TextBox ID="tbPass" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="login" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
