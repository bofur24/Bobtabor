<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticeWork.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Practice Work</h1>
            <div>
                <h2>Data Type Conversion</h2>
                <p>
                    <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="okButton" runat="server" Text="Go" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
