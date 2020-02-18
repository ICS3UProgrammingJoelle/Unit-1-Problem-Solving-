/*
 * Created by: Joelle Ishimwe
 * Created on: 18-Feb-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - School Mascot
 * This program displays a menu bar with menu items. When you 
 * click on a menu item, the lable changes according to the item you clicked on.
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

namespace SchoolMascot
{
    public partial class SchoolMascotForm : Form
    {
        public SchoolMascotForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void LblSchool_Click(object sender, EventArgs e)
        {

        }

        private void StPattricksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the lables to reflect St. Patricks
            this.lblSchool.Text = "St. Patricks";
            this.lblMascot.Text = "Fighting Irish";
        }

        private void ImmaculataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the lables to reflect Immaculata
            this.lblSchool.Text = "Immaculata";
            this.lblMascot.Text = "Saints";
        }

        private void MotherTerresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the lables to reflect Mother Teresa
            this.lblSchool.Text = "Mother Teresa";
            this.lblMascot.Text = "Titans";
        }

        private void StMatthiewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the lables to reflect St.Matthew
            this.lblSchool.Text = "St.Matthew";
            this.lblMascot.Text = "Tiger";
        }
    }
}
