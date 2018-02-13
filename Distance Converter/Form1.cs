using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double userInput = 0;
            double solution = 0;
            double.TryParse(txtUserInput.Text, out userInput);
            try
            {
                if (radioButtonFromInches.Checked == true && radioButtonToInches.Checked == true)
                {
                    solution = userInput;
                    labelOutput.Text = solution.ToString("n2") + " in";
                }
                else if (radioButtonFromInches.Checked == true && radioButtonToFeet.Checked == true)
                {
                    solution = userInput / 12;
                    labelOutput.Text = solution.ToString("n2") + " ft";
                }
                else if (radioButtonFromInches.Checked == true && radioButtonToYards.Checked == true)
                {
                    solution = userInput / 36;
                    labelOutput.Text = solution.ToString("n2") + " yds";

                }
                else if (radioButtonFromFeet.Checked == true && radioButtonToInches.Checked == true)
                {
                    solution = userInput * 12;
                    labelOutput.Text = solution.ToString("n2") + " in";
                }
                else if (radioButtonFromFeet.Checked == true && radioButtonToFeet.Checked == true)
                {
                    solution = userInput;
                    labelOutput.Text = solution.ToString("n2") + " ft";
                }
                else if (radioButtonFromFeet.Checked == true && radioButtonToYards.Checked == true)
                {
                    solution = userInput / 3;
                    labelOutput.Text = solution.ToString("n2") + " yds";
                }
                else if (radioButtonFromYards.Checked == true && radioButtonToInches.Checked == true)
                {
                    solution = userInput * 36;
                    labelOutput.Text = solution.ToString("n2") + " in";
                }
                else if (radioButtonFromYards.Checked == true && radioButtonToFeet.Checked == true)
                {
                    solution = userInput * 3;
                    labelOutput.Text = solution.ToString("n2") + " ft";
                }
                else if (radioButtonFromYards.Checked == true && radioButtonToYards.Checked == true)
                {
                    solution = userInput;
                    labelOutput.Text = solution.ToString("n2") + " yds";
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