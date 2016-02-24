<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Login Page" ForeColor="BLUE"></asp:Label>
    
    </div>
        <asp:Table ID="Table1" runat="server" Height="22px" Width="419px">
            <asp:TableRow>
                <asp:TableCell Text="User Name:"></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtLoginUser" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="User name required!" ForeColor="RED"></asp:Label></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell Text="Password:"></asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtLoginPassword" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Password required!" ForeColor="RED"></asp:Label></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                    </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="Login" /></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="lblPasswordStatus" runat="server" Text="Password is incorrect" ForeColor="RED"></asp:Label></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
