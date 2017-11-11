using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Postage_Calculator_Helper_Methods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if(checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }


        }




        private bool checkUserInput()
        {
            if (widthTextBox.Text.Trim() == "" && heightTextBox.Text.Trim() == "")
            {
                return false;
            }

            if (!groundRadioButton.Checked && !airRadioButton.Checked && !nextDayRadioButton.Checked)
            {
                return false;
            }

            return true;

        }

        private double calculateCost()
        {
            double price = 0.0;
            double width = double.Parse(widthTextBox.Text.Trim());
            double height = double.Parse(heightTextBox.Text.Trim());

            if(lengthTextBox.Text.Trim() != "")
            {
                double length = double.Parse(lengthTextBox.Text.Trim());
                price = width * height * length;
            } else
            {
                price = width * height;
            }

            if (groundRadioButton.Checked) price *= .15;
            if (airRadioButton.Checked) price *= .25;
            if (nextDayRadioButton.Checked) price *= .45;

            return price;
        }

        private void displayCost(double price)
        {
            resultLabel.Text = $"The price for you package is: {price} $";
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUserInput())
            {
                double price = calculateCost();
                displayCost(price);
            }
        }
    }
}