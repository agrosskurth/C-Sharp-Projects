using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelCardName.Text = "Two of Clubs";
        }

        private void imgTwo_Click(object sender, EventArgs e)
        {
            labelCardName.Text = "Five of Clubs";
        }

        private void imgThree_Click(object sender, EventArgs e)
        {
            labelCardName.Text = "Eight of Hearts";
        }

        private void imgFour_Click(object sender, EventArgs e)
        {
            labelCardName.Text = "Jack of Diamonds";
        }

        private void imgFive_Click(object sender, EventArgs e)
        {
            labelCardName.Text = "Black Joker";
        }
    }
}
