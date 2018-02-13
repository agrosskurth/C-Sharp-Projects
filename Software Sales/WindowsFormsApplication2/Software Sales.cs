using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                double solution = 0;
            double userInput = 0;
            if (double.TryParse(txtUserInput.Text, out userInput))
            {
                if (userInput < 10 && userInput >= 1)
                {
                    solution = (userInput * 99);
                    labelTotal.Text = solution.ToString("c");
                    labelDiscount.Text = "0%";
                    txtUserInput.Text = "";
                    ActiveControl = txtUserInput;
                }
                else if (userInput >= 10 && userInput <= 19)
                {
                    solution = (userInput * 99) * .80;
                    labelTotal.Text = solution.ToString("c");
                    labelDiscount.Text = "20%";
                    txtUserInput.Text = "";
                    ActiveControl = txtUserInput;
                }
                else if (userInput >= 20 && userInput <= 49)
                {
                    solution = (userInput * 99) * .70;
                    labelTotal.Text = solution.ToString("c");
                    labelDiscount.Text = "30%";
                    txtUserInput.Text = "";
                    ActiveControl = txtUserInput;
                }
                else if (userInput >= 50 && userInput <= 99)
                {
                    solution = (userInput * 99) * .60;
                    labelTotal.Text = solution.ToString("c");
                    labelDiscount.Text = "40%";
                    txtUserInput.Text = "";
                    ActiveControl = txtUserInput;
                }
                else if (userInput >= 100)
                {
                    solution = (userInput * 99) * .50;
                    labelTotal.Text = solution.ToString("c");
                    labelDiscount.Text = "50%";
                    txtUserInput.Text = "";
                    ActiveControl = txtUserInput;
                }
            }

            else
            {
                MessageBox.Show("Please enter a number!");
                txtUserInput.Text = "";
                ActiveControl = txtUserInput;
            }
        }
    }
}
