using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            radioLeftRed.Checked = false;
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioRightRed.Checked == true && radioLeftRed.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Red;
                }
                else if (radioRightRed.Checked == true && radioLeftBlue.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Purple;
                }
                else if (radioRightRed.Checked == true && radioLeftYellow.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Orange;
                }
                else if (radioRightBlue.Checked == true && radioLeftRed.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Purple;
                }
                else if (radioRightBlue.Checked == true && radioLeftBlue.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Blue;
                }
                else if (radioRightBlue.Checked == true && radioLeftYellow.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Green;
                }
                else if (radioRightYellow.Checked == true && radioLeftRed.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Orange;
                }
                else if (radioRightYellow.Checked == true && radioLeftBlue.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Green;
                }
                else if (radioRightYellow.Checked == true && radioLeftYellow.Checked == true)
                {
                    this.BackColor = System.Drawing.Color.Yellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
