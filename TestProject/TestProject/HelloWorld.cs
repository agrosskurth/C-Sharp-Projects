using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void HelloWorld_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFirstName.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void picBackground_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beautiful Universe!");
        }
    }
}
