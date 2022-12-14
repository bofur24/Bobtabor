<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>How many days have elapsed?</h1>  
            <p>Chose one date:
                <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p>Chose a second date:
                <br />
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </p>
            <p>
                <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
