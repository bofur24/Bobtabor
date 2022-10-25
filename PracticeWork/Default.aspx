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
                <hr />
                <p>
                    Is <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> equal to <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
                    <br />
                    If you could eat only one food for the rest of your life, what would you choose?
                    <br />
                    <asp:RadioButton ID="PizzaRadioButton" runat="server" Text="Pizza" GroupName="FoodGroup" Checked="True" />
                    <br />
                    <asp:RadioButton ID="SaladRadioButton" runat="server" Text="Salad" GroupName="FoodGroup" />
                    <br />
                    <asp:RadioButton ID="PBJRadioButton" runat="server" Text="Peanut Butter and Jelly" GroupName="FoodGroup" />
                    <br />
                    <br />
                    <asp:Button ID="okButton2" runat="server" Text="OK" OnClick="okButton2_Click" />
                    <br />
                    <br />                    
                    <br />
                    <asp:Label ID="resultLabel2" runat="server" Text=""></asp:Label>

                </p>
                <hr />
                <div>
                    <h1>Comparison and Logical Operators</h1>
                    Is <asp:TextBox ID="ComparisonTextBox1" runat="server"></asp:TextBox> <asp:Label ID="ComparisonTypeLabel" runat="server" Text="Label"> </asp:Label> <asp:TextBox ID="ComparisonTextBox2" runat="server"></asp:TextBox> ?
                    <br />
                    <br />
                    <asp:CheckBox ID="ComparisonCheckBox" runat="server" Text="I am checked" />
                    <br />
                    <br />
                    <asp:Button ID="ComparisonOkButton" runat="server" Text="OK" OnClick="ComparisonOkButton_Click" />
                    <br />
                    <br />
                    <asp:Label ID="ComparisonResultLabel" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
