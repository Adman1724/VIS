<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MAJ0101_Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            
        <div ID="loginTopText">Fitness APP - Client Login</div>
        <asp:TextBox ID="loginInput" class="loginInput" AutoCompleteType="Disabled" runat="server" placeholder="Email"></asp:TextBox>
        <asp:TextBox ID="passwordInput" class="loginInput" TextMode="Password" runat="server" placeholder="Password"></asp:TextBox>
        <asp:Button ID="confirmButton" runat="server" Text="Login" />

    </div>
    </form>
</body>
</html>
