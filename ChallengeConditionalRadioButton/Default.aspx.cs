using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (PencilRadioButton.Checked)
            {
                ResultImage.ImageUrl = "Assets/pencil.png"; 
                ResultLabel.Text = "You have slected a Pencil";
            }
            else if (PenRadioButton.Checked)
            {
                ResultImage.ImageUrl = "Assets/pen.png";
                ResultLabel.Text = "You have slected a Pen";
            }
            else if (PhoneRadioButton.Checked)
            {
                ResultImage.ImageUrl = "Assets/phone.png";
                ResultLabel.Text = "You have slected a Phone";
            }
            else if (TabletRadioButton.Checked)
            {
                ResultImage.ImageUrl = "Assets/tablet.png";
                ResultLabel.Text = "You have slected a Tablet";
            }
            else 
            {
                ResultLabel.Text = "You have not slected an item";
            }

        }
    }
}