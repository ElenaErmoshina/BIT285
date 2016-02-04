<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="BIT285_assighment1.NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 25px;
            width: 184px;
            margin-left: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>&nbsp;New account information</h1>
        <asp:Label ID="Label1" runat="server" Text="First name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" Height="23px" style="margin-left: 56px" Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtFirstName"
            ErrorMessage="*required"
            ForeColor="red"
            ></asp:RequiredFieldValidator>
        &nbsp;&nbsp;
        </div>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Last name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Height="23px" style="margin-left: 57px" Width="174px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtLastName"
            ErrorMessage="*required"
            ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp; </p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" Height="22px" Width="174px" style="margin-left: 0px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:CustomValidator ID="EmailValidator" runat="server" 
            ControlToValidate="txtEmail"
            ValidateEmptyText="True"
            ErrorMessage="*required"
            ForeColor="red" OnServerValidate="EmailValidator_ServerValidate1"></asp:CustomValidator>
        </p>
        <p>
        <asp:Label ID="Label4" runat="server" Text="Program Option"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="txtProgramOption" runat="server" Height="20px" Width="162px">
            <asp:ListItem> Web Developer Degree</asp:ListItem>
            <asp:ListItem>ETSP Degree</asp:ListItem>
            <asp:ListItem>Network Technology Degree</asp:ListItem>
            </asp:DropDownList>
        &nbsp;</p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="email me program updates"/>
        </p>
        <p>
&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="create account" Width="128px" OnClick="Button1_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="reset" Width="97px" />
        </p>
    </form>
</body>
</html>
