<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BIT285_assighment1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Please Login</h1>
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="UserName" runat="server" style="margin-left: 11px" Width="157px"></asp:TextBox>
    </div>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password" runat="server" style="margin-left: 23px" Width="156px" TextMode="Password"></asp:TextBox>
        </p>
        <asp:LinkButton ID="LinkButton1" runat="server">need a new account?</asp:LinkButton>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Login" Width="103px" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="LoginError" runat="server" Text="Login error" Visible="False" ForeColor="#FF0066" ></asp:Label>
    </form>
</body>
</html>
