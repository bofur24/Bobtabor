<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your first Name? <asp:TextBox runat="server" ID="firstNameTextBox"></asp:TextBox>
            <br /> <br />
            What is your last name? <asp:TextBox runat="server" ID="lastNameTextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" Text="Click Me" OnClick="okButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
       </div>
       
       
    </form>
</body>

</html>
