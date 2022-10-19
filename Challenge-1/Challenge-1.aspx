<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge-1.aspx.cs" Inherits="Challenge_1.Challenge_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you? <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
            <br />
            How much money do you have in your pocket? <asp:TextBox ID="MoneyTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click Me To See Your Fortune" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
