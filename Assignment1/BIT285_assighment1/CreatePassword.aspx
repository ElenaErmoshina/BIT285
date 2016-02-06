<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePassword.aspx.cs" Inherits="BIT285_assighment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Automatic Password Generator</h1>
    <p>Having a hard time thinking up a unique and memorable password? Enter the information below to automatically generate possible passwords.</p>
        <asp:Label runat="server">Last name</asp:Label><br />
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>   
        <p>
        <asp:Label runat="server">Birth year</asp:Label><br />
        <asp:TextBox ID="BirthYear" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredYearOfBirth" runat="server"
                 ErrorMessage="*Required"
                 ControlToValidate="BirthYear"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="FourDigit" runat="server"
                 ErrorMessage="*Year format should be YYYY."
                 ControlToValidate="BirthYear"
                 ValidationExpression="\d{4}?"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
        &nbsp;
        </p>
        <p>
        <asp:Label runat="server">Favorite color</asp:Label><br />
        <asp:TextBox ID="FavouriteColor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SuggestBtn" runat="server" Text="Suggest Passwords >>>" Width="272px" OnClick="SuggestBtn_Click" />
            <asp:DropDownList ID="SuggestionDdl" runat="server" style="margin-left: 60px" Width="181px">
            </asp:DropDownList>
        </p>
    </div> 
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
        ForeColor="red" />
    </form>
</body>
</html>
