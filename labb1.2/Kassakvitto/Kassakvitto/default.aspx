<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Kassakvitto._default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="moneybox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Fältet får inte vara tomt" Display="Dynamic" ControlToValidate="moneybox" SetFocusOnError="True" Enabled="True"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="sendButton" runat="server" Text="Button" OnClick="sendButton_Click" />
    </div>
        <p>
        <asp:Label ID="resultRecipe" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
