using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWork
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int i;
            //i = "3";

            // upcast
            //int i = 2000000000;
            //long j = i;

            //downcast
            //long i = 2000000000;
            //int j = (int)i;

            //double k = 2.5;
            //int j = (int)k;

            // casting is for numbers only
            //resultLabel.Text = (string)j;
            //resultLabel.Text = j.ToString();

            //string i = inputTextBox.Text;
            //int j = int.Parse(i);
            //int k = j + 1;

            //resultLabel.Text = k.ToString();    

            int i = 1;
            int j = 2;
            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i / j;

            //i = i + 1;
            //i += 1;
            //i++;
            //i--;

            //int myInteger = (5 + 1) * 7; // 42
            //int myInteger2 = 5 + 1 * 7; // 12
            //resultLabel.Text = myInteger.ToString();

            double myDouble = 5.5;
            int myInteger = 7;
            int myOtherInteger = 4;

            //double myResult = mydouble + myInteger;
            //int myResult = (int)myDouble + myInteger;
            //int myResult = myInteger / myOtherInteger;
            //double myResult = (double)myInteger / (double)myOtherInteger;
            //resultLabel.Text = myResult.ToString();

            int firstNumber = 2000000000;
            int secondNumber = 20000000;
            long resultNumber;

            checked
            {
                resultNumber = firstNumber * secondNumber;
            }

            resultLabel.Text = resultNumber.ToString();







        }

    }
}