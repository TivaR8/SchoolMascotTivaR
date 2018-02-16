using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 16-02-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - School Mascot
 * This program allows you to select a school from a menu 
 * to find out what its mascot is.
*/

namespace SchoolMascotTivaR
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void lblSchool_Click(object sender, EventArgs e)
        {
            
        }

        //This is what happens when Immaculata is Selected
        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        //This is what happens when Gryffindor is Selected
        private void mniGryffindor_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Gryffindor";
            lblMascot.Text = "Lion";
        }

        //This is what happens when Slytherin is Selected
        private void mniSlytherin_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Slytherin";
            lblMascot.Text = "Snake";
        }

        //This is what happens when Ravenclaw is Selected
        private void mniRavenclaw_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Ravenclaw";
            lblMascot.Text = "Eagle";
        }

        //This is what happens when Hufflepuff is Selected
        private void mniHufflepuff_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Hufflepuff";
            lblMascot.Text = "Badger";
        }
    }
}
