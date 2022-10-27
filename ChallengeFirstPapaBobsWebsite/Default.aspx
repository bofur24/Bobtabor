<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
            <h1>Papa Bob's Pizza and Software</h1>
        </div>
        <div>
            <h2>Pizza Size</h2>
            <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="PizzaSize" Text='Baby Bob Size (10") - $10' />
            <br />
            <asp:RadioButton ID="MamaRadioButton" runat="server" GroupName="PizzaSize" Text='Mama Bob Size (13") - $13' />
            <br />
            <asp:RadioButton ID="PapaRadioButton" runat="server" GroupName="PizzaSize" Text='Papa Bob Size (16") - $16' />
        </div>
        <div>
            <h2>Crust Type</h2>
            <asp:RadioButton ID="ThinRadioButton" runat="server" GroupName="CrustType" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="DeepRadioButton" runat="server" GroupName="CrustType" Text="Deep Dish (+$2)" />
        </div>
        <div>
            <h2>Toppings</h2>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Peperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Anchovies (+$2.00)" />
        </div>
        <div>
            <h2>Papa Bob's Special Deal</h2>
            <p>
                Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.
            </p>
        </div>
        <div>
            <asp:Button ID="PurchaseButton" runat="server" Text="Purchase" />
            <p>
                Total: <asp:Label ID="TotalLabel" runat="server"></asp:Label>
            </p>
            <p>
                Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!
            </p>
        </div>
    </form>
</body>
</html>
