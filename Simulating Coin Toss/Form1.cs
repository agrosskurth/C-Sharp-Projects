using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulating_Coin_Toss
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //initialize variable to determine which side is up
            int sideUp;

            //create a random number generator
            Random rand = new Random();

            //generate a random number which is either 1 or 0
            //0 is tails up, 1 is heads up
            sideUp = rand.Next(2);

            //if statement to determine which side is up
            if (sideUp == 0)
            {
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }

        //close program with exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
