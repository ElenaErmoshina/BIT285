<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BIT285_assighment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Automatic Passwaord Generator</h1>
    <p>Having a hard time thinking up a unique and memorable password? Enter the information below to automatically generate possible passwords.</p>
        <asp:Label runat="server">Last name</asp:Label><br />
        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>   
        <p>
        <asp:Label runat="server">Birth year</asp:Label><br />
        <asp:TextBox ID="BirthYear" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label runat="server">Favorite color</asp:Label><br />
        <asp:TextBox ID="FavouriteColor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Suggest Passwords >>>" Width="272px" />
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 60px" Width="181px">
                <asp:ListItem>Bansblueenauer</asp:ListItem>
                <asp:ListItem>blue1998B</asp:ListItem>
                <asp:ListItem>19blue98</asp:ListItem>
                <asp:ListItem>8991Bansenauer</asp:ListItem>
                <asp:ListItem>BBlueblueblue</asp:ListItem>
            </asp:DropDownList>
        </p>
    </div> 
    </form>
</body>
</html>
