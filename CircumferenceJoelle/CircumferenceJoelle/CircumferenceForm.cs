/*
 * Created by: Joelle Ishimwe
 * Created on: 24-Feb.-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference 
 * This program will ask the user for the radius. Then calculates the circumference of a circle.
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

namespace CircumferenceJoelle
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            this.lblCircumferenceAnswer.Hide();
            this.lblCircumferenceState.Hide(); 
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare the variables
            double radius;
            double circumference;

            //convert the string radius (from the user) into a double
            radius = double.Parse(txtRadius.Text);

            //calculate the circumference
            circumference = 2 * radius * Math.PI;

            // insert the circumfrence into it's respectible labels
            this.lblCircumferenceAnswer.Text = Convert.ToString(circumference) + "cm";

            //display the circumfrence
            this.lblCircumferenceAnswer.Show();
            this.lblCircumferenceState.Show();
        }

        private void LblRadius_Click(object sender, EventArgs e)
        {

        }
    }
}
