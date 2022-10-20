using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(FirstValueTextBox.Text);
            int secondValue = int.Parse(SecondValueTextBox.Text);
            int result = firstValue + secondValue;

            ResultLabel.Text = result.ToString();
        }

        protected void SubButton_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(FirstValueTextBox.Text);
            int secondValue = int.Parse(SecondValueTextBox.Text);
            int result = firstValue - secondValue;

            ResultLabel.Text = result.ToString();
        }

        protected void MultiButton_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(FirstValueTextBox.Text);
            int secondValue = int.Parse(SecondValueTextBox.Text);
            int result = firstValue * secondValue;

            ResultLabel.Text = result.ToString();
        }

        protected void DivButton_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(FirstValueTextBox.Text);
            double secondValue = double.Parse(SecondValueTextBox.Text);
            double result = firstValue / secondValue;

            ResultLabel.Text = result.ToString();
        }
    }
}