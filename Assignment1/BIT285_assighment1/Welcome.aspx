<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="BIT285_assighment1.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Welcome<br />
        <asp:Button ID="Refresh" runat="server" Text="Refresh" OnClick="Refresh_Click" />
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
        <br />
        <asp:Label ID="loggedOutLabel" runat="server" Text="You sucessufully loged out." ForeColor="Red" Visible="False"></asp:Label>
        <asp:GridView ID="UserLogGrid" runat="server" AutoGenerateColumns="False" Width="360px">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="User Name" />
                <asp:BoundField DataField="login_time" HeaderText="Loged in at" />
                <asp:BoundField DataField="ip_address" HeaderText="From Ip Address" />
            </Columns>
            <EmptyDataTemplate>
                User Name
            </EmptyDataTemplate>
            <HeaderStyle BackColor="#999999" />
            <RowStyle BackColor="#CCCCCC" />
    </asp:GridView>

    </form>
    
</body>
</html>
