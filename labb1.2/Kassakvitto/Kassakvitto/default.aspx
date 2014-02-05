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
        <asp:CompareValidator ID="CompareValidator" runat="server" ErrorMessage="Du måste använda siffror" Enabled="true" ControlToValidate="moneybox" Display="Dynamic" Operator="DataTypeCheck" SetFocusOnError="True" Type="Double"></asp:CompareValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Värdet moste vara större än 0" Enabled="true" ControlToValidate="moneybox" Display="Dynamic" Operator="GreaterThan" SetFocusOnError="True" Type="Double" ValueToCompare="0"></asp:CompareValidator>
    </div>
    <div>
        <asp:Button ID="sendButton" runat="server" Text="Button" OnClick="sendButton_Click" />
    </div>
        <p>
        <asp:Label ID="resultRecipe" runat="server" Text=""></asp:Label>
        </p>
    </form>
    <script type="text/javascript" src="Scripts/script.js"></script>
</body>
</html>
