using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Number_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imgOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One.");
        }

        private void imgTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two.");
        }

        private void imgThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three.");
        }

        private void imgFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four.");
        }

        private void imgFive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five.");
        }

    }
}
