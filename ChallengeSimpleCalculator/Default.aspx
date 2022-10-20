<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>First Value: <asp:TextBox ID="FirstValueTextBox" runat="server"></asp:TextBox></p>
            <p>Second value: <asp:TextBox ID="SecondValueTextBox" runat="server"></asp:TextBox></p>
            <p>
                <asp:Button ID="AddButton" runat="server" Text="+" OnClick="AddButton_Click" />
                <asp:Button ID="SubButton" runat="server" Text="-" OnClick="SubButton_Click" />
                <asp:Button ID="MultiButton" runat="server" Text="*" OnClick="MultiButton_Click" />
                <asp:Button ID="DivButton" runat="server" Text="/" OnClick="DivButton_Click" />
            </p>
            <p>
                <asp:Label ID="ResultLabel" runat="server" Text="" Font-Bold="True" Font-Size="Larger" BackColor="#3399FF"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
