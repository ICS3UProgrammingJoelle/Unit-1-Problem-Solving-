/*
 * Created by: Joelle Ishimwe
 * Created on: Feb.-Feb.-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Perimter and Area 
 * This program calculates the perimeter and area. 
 * According to the length and width inputted by the user.
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

namespace PerAreaJoelle
{
    public partial class frmPerArea : Form
    {
        public frmPerArea()
        {
            InitializeComponent();
            //hide the perimeter and area answer lables until the calculate button is clicked
            this.lblPerimeterAnswer.Hide();
            this.lblAreaAnswer.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblArea_Click(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double length, width, area, perimeter;

            //convert string into a double in the textbox
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //calculate the area of the perimeter
            area = width * length;
            perimeter = width + width + length + length;

            //insert the area and perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " meters";

            //display the perimeter and area answers
            this.lblAreaAnswer.Show();
            this.lblPerimeterAnswer.Show();

        }
    }
}
