using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTwoCalculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            

        }

        //Declare Button Click an event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int inputOne = int.Parse(txtInputOne.Text);
            int inputTwo = int.Parse(txtInputTwo.Text);
            //Create the equation
            int outPut = inputOne + inputTwo;
            //Output the answer to the Label
            labelAnswer.Text = inputOne.ToString() + " + " + inputTwo.ToString() + " = " + outPut.ToString();
        }

        //Simple repeat of the last step, No big differences
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int inputOne = int.Parse(txtInputOne.Text);
            int inputTwo = int.Parse(txtInputTwo.Text);
            int outPut = inputOne - inputTwo;
            labelAnswer.Text = inputOne.ToString() + " - " + inputTwo.ToString() + " = " + outPut.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int inputOne = int.Parse(txtInputOne.Text);
            int inputTwo = int.Parse(txtInputTwo.Text);
            int outPut = inputOne * inputTwo;
            labelAnswer.Text = inputOne.ToString() + " * " + inputTwo.ToString() + " = " + outPut.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Declare double for Division to get back decimals in the answer
            double inputOne = double.Parse(txtInputOne.Text);
            double inputTwo = double.Parse(txtInputTwo.Text);
            double outPut = inputOne / inputTwo;
            labelAnswer.Text = inputOne.ToString() + " / " + inputTwo.ToString() + " = " + outPut.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputOne.Text = "";
            txtInputTwo.Text = "";
            labelAnswer.Text = "";
        }
    }
}
