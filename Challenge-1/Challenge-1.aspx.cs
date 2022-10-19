using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_1
{
    public partial class Challenge_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string age = AgeTextBox.Text;
            string money = MoneyTextBox.Text;

            string message = $"At {age} years old, I would have expected you to have more than {money} in your pocket.";

            Label1.Text = message;
        }
    }
}