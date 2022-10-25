<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Your Note Taking Preferences
            </p>
            <br />
            <asp:RadioButton ID="PencilRadioButton" runat="server" Text="Pencil" GroupName="NoteTaking" />
            <asp:RadioButton ID="PenRadioButton" runat="server" Text="Pen" GroupName="NoteTaking" />
            <asp:RadioButton ID="PhoneRadioButton" runat="server" Text="Phone" GroupName="NoteTaking" />
            <asp:RadioButton ID="TabletRadioButton" runat="server" Text="Tablet" GroupName="NoteTaking" />
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" Text="OK" OnClick="OkButton_Click" />
        </div>
        <div>
            <asp:Image ID="ResultImage" runat="server" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
