using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWork
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ComparisonTypeLabel.Text = "greater than";
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

            //int firstNumber = 2000000000;
            //int secondNumber = 20000000;
            //long resultNumber;

            //checked
            //{
            //    resultNumber = firstNumber * secondNumber;
            //}

            //resultLabel.Text = resultNumber.ToString();
        }

        protected void okButton2_Click(object sender, EventArgs e)
        {
            resultLabel2.Text = "";
            //if (TextBox1.Text == TextBox2.Text)
            //{
            //    resultLabel2.Text = "Yes! They're equal!";
            //}
            //else
            //{
            //    resultLabel2.Text = "No! They're not equal!";
            //}
            //if (coolCheckBox.Checked)
            //{
            //    resultLabel2.Text = "Yes, you are definitely cool.";
            //}
            //else
            //{
            //    resultLabel2.Text = "Don't be so hard on yourself.";
            //}
            //if (PizzaRadioButton.Checked)
            //{
            //    resultLabel2.Text = "You must be from Chicago!";
            //}
            //else if (SaladRadioButton.Checked)
            //{
            //    resultLabel2.Text = "You must be healthy";
            //}
            //else if (PBJRadioButton.Checked)
            //{
            //    resultLabel2.Text = "You must be a fun loving person!";
            //}
            //else
            //{
            //    resultLabel2.Text = "Please select one of the options.";
            //}

            //resultLabel2.Text = (TextBox1.Text == TextBox2.Text) ? "Yes" : "No";


            //resultLabel2.Text = (coolCheckBox.Checked)
            //    ? "I'm teaching an old dog new tricks!" 
            //    : "Young whippersnapper! Get off my lawn!";

            int result = (TextBox1.Text == TextBox2.Text) ? 100 : 50;

            resultLabel2.Text = result.ToString();


        }

        protected void ComparisonOkButton_Click(object sender, EventArgs e)
        {
            ComparisonResultLabel.Text = "";

            //ComparisonResultLabel.Text = (ComparisonTextBox1.Text == ComparisonTextBox2.Text) ? "Yes" : "No"; 

            //int first = int.Parse(ComparisonTextBox1.Text);
            //int second = int.Parse(ComparisonTextBox2.Text);

            //ComparisonResultLabel.Text = (first > second) ? "Yes" : "No";
            //ComparisonResultLabel.Text = (first < second) ? "Yes" : "No";
            //ComparisonResultLabel.Text = (first >= second) ? "Yes" : "No";
            //ComparisonResultLabel.Text = (first <= second) ? "Yes" : "No";

            //ComparisonResultLabel.Text = (!ComparisonCheckBox.Checked) ? "No" : "Yes";

            //if (ComparisonCheckBox.Checked 
            //    && ComparisonTextBox1.Text == "Keith" 
            //    && ComparisonTextBox2.Text == "Heffington")
            //{
            //    ComparisonResultLabel.Text = "Perfect trifecta!";
            //}

            if (ComparisonCheckBox.Checked
              || ComparisonTextBox1.Text == "Keith"
              || ComparisonTextBox2.Text == "Heffington")
            {
                ComparisonResultLabel.Text = "One out of three ain't bad.";
            }

        }

        protected void TimeButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            //TimeLabel.Text = myValue.ToString();
            //TimeLabel.Text = myValue.ToLongDateString();  Day Month Day# Year#
            //TimeLabel.Text = myValue.ToLongTimeString(); HH:MM:SS AM/PM 
            //TimeLabel.Text = myValue.ToShortDateString(); MM/DD/YY   
            //TimeLabel.Text = myValue.ToShortTimeString(); HH:MM AM/PM

            //TimeLabel.Text = myValue.AddDays(2).ToString();
            //TimeLabel.Text = myValue.Month.ToString();
            //TimeLabel.Text = myValue.DayOfWeek.ToString();
            //TimeLabel.Text = myValue.DayOfYear.ToString();

            DateTime myValue = new DateTime(1985, 3, 4);
            TimeLabel.Text = myValue.ToLongDateString();
        }

        protected void TimeSpanButton_Click(object sender, EventArgs e)
        {
            // Days.Hours:Minutes:Seconds.milliseconds

            TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

            DateTime myBirthday = DateTime.Parse("03/04/1989");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);



            //TimeSpanLabel.Text = myAge.Hours.ToString();
            TimeSpanLabel.Text = myAge.TotalDays.ToString();
        }

        protected void GetDateButton_Click(object sender, EventArgs e)
        {
            DateLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void SetDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("11/2/2022");
        }

        protected void ShowDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("03/04/1985");
        }

        protected void SelectedWeekButton_Click(object sender, EventArgs e)
        {
            DateLabel.Text = "Week of " + myCalendar.SelectedDate.ToShortDateString();
        }

        protected void myCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }
    }
}