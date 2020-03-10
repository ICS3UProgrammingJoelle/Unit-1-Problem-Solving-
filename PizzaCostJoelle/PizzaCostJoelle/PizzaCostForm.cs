/*
 * Created by: Joelle Ishimwe
 * Created on: 29-Feb.-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - PizzaCost
 * This program will diplay the cost of a pizza (including taxes). 
 * The cost will depend on the diameter of the pizza, given by the user.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostJoelle
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            this.lblCost.Hide();
            this.lblStateCost.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare the local variables
            double diameter, subtotal, total;

            //declare constant
            double TAX = 1.13;

            //convert the string diameter into a double
            diameter = double.Parse(txtDiameter.Text);

            //calucate the cost of the pizza after tax
            subtotal = (0.5 * diameter) + 0.99 + 0.75;
            total = subtotal * TAX;

            //convert the total into a string
            this.lblCost.Text = "$ " + Convert.ToString(Math.Round(total,2));

            //diplay the cost of the pizza (round to 2 decimal places)
            this.lblCost.Show();
            this.lblStateCost.Show();
        }
    }
}
