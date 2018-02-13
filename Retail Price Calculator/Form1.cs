using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double userWholesale = 0;
            double userMarkup = 0;
            double retailPrice = 0;

            try
            {
                userWholesale = double.Parse(txtWholesale.Text);
                userMarkup = double.Parse(txtMarkup.Text);

                retailPrice = calculateRetail(userWholesale, userMarkup);

                labelTotal.Text = retailPrice.ToString("c");
            }
            catch
            {
                labelTotal.Text = "error";
            }
        }

        public double calculateRetail(double a, double b)
        {
            double calculate = 0;
            double markup = 0;
            double solution = 0;

            markup = a / 100;
            calculate = b * markup;
            solution = a + calculate;

            return solution;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
