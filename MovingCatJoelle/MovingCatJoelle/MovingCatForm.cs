/*
 * Created by: Joelle Ishimwe
 * Created on: 18-Feb.-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program will diplay an image in the picturebox, 
 * according to what menu item the user clicks on. 
 * It will also have the option to exit, upon the request of the user.
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

namespace MovingCatJoelle
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void MovingCatForm_Load(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
                
        }

        private void MniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void LamborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.Dog1;
        }

        private void MnuCars_Click(object sender, EventArgs e)
        {

        }

        private void MniDog2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.Dog2;
        }
    }
}
