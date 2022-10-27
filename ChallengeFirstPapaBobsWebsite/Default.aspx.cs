using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PurchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0.00;
            double sizePrice = 0.00;
            double crustPrice = 0.00;
            double toppingPrice = 0.00;
            double discountPrice = 0.00;

            if (babyRadioButton.Checked)
            {
                sizePrice = 10.00;
            }
            else if (MamaRadioButton.Checked)
            {
                sizePrice = 13.00;
            }
            else if (PapaRadioButton.Checked)
            {
                sizePrice = 16.00;
            }
            else
            {
                sizePrice = 0.00;
            }

            if (ThinRadioButton.Checked)
            {
                crustPrice = 0.00;
            }
            else if (DeepRadioButton.Checked)
            {
                crustPrice = 2.00;
            }

            if (PeperoniCheckBox.Checked)
            {
                toppingPrice += 1.50;
            }
            
            if (OnionsCheckBox.Checked)
            {
                toppingPrice += 0.75;
            }
            
            if (GreenPeppersCheckBox.Checked)
            {
                toppingPrice += 0.50;
            }
            
            if (RedPeppersCheckBox.Checked)
            {
                toppingPrice += 0.75;
            }
            
            if (AnchoviesCheckBox.Checked)
            {
                toppingPrice += 2.00;
            }


            if ((PeperoniCheckBox.Checked 
                && GreenPeppersCheckBox.Checked 
                && AnchoviesCheckBox.Checked )
                || (PeperoniCheckBox.Checked 
                && RedPeppersCheckBox.Checked 
                && OnionsCheckBox.Checked))
            {
                discountPrice = -2.00;
            }



            
            total = sizePrice + crustPrice + toppingPrice + discountPrice;


            TotalLabel.Text = total.ToString();
        }
    }
}