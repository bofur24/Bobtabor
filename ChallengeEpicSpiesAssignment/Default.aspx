<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="/epic-spies-logo.jpg" Height="190px" />
            <h1>Spy New Assignment Form</h1>
            <p>
                Spy Code name: <asp:TextBox ID="SpyCodeNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                New Assignment Name <asp:TextBox ID="newAssignmentNameTextBox" runat="server"></asp:TextBox>
            </p>
        </div>
    </form>
</body>
</html>
