using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            double taxOnParts = 0;
            int parts = 0;
            double servicesAndLabor = 0;
            double labor = 0;
            double calculate = 0;

            try
            {
                if (chkBoxOil.Checked && chkBoxLube.Checked)
                {
                    total = total + 26.00 + 18.00;
                    servicesAndLabor = servicesAndLabor + 26.00 + 18.00;
                }
                else if (chkBoxOil.Checked)
                {
                    total = total + 26.00;
                    servicesAndLabor = servicesAndLabor + 26.00;
                }
                else if (chkBoxLube.Checked)
                {
                    total = total + 18.00;
                    servicesAndLabor = servicesAndLabor + 18.00;
                }

                 if (chkBoxRadiator.Checked && chkBoxTransmission.Checked)
                 {
                    total = total + 30.00 + 80.00;
                    servicesAndLabor = servicesAndLabor + 30.00 + 80.00;
                 }
                 else if (chkBoxRadiator.Checked)
                 {
                    total = total + 30.00;
                    servicesAndLabor = servicesAndLabor + 30.00;
                 }
                 else if (chkBoxTransmission.Checked)
                 {
                    total = total + 80.00;
                    servicesAndLabor = servicesAndLabor + 80.00;
                 }
                
                if (chkBoxInspection.Checked && chkBoxMuffler.Checked && chkBoxTireRotation.Checked)
                {
                    total = total + 15.00 + 100.00 + 20.00;
                    servicesAndLabor = servicesAndLabor + 15.00 + 100.00 + 20.00;
                }
                else if (chkBoxInspection.Checked && chkBoxMuffler.Checked)
                {
                    total = total + 15.00 + 100.0;
                    servicesAndLabor = servicesAndLabor + 15.00 + 100.00;
                }
                else if (chkBoxInspection.Checked && chkBoxTireRotation.Checked)
                {
                    total = total + 15.00 + 20.00;
                    servicesAndLabor = servicesAndLabor + 15.00 + 20.00;
                }
                else if (chkBoxInspection.Checked)
                {
                    total = total + 15.00;
                    servicesAndLabor = servicesAndLabor + 15.00;
                }
                else if (chkBoxMuffler.Checked)
                {
                    total = total + 100.00;
                    servicesAndLabor = servicesAndLabor + 100.00;
                }
                else if (chkBoxTireRotation.Checked)
                {
                    total = total + 20.00;
                    servicesAndLabor = servicesAndLabor + 20.00;
                }

                
                parts = int.Parse(txtParts.Text);
                labor = double.Parse(txtLabor.Text);
                calculate = parts * 20.00;
                taxOnParts = calculate * .06;
                servicesAndLabor = servicesAndLabor + labor;
                total = total + labor + taxOnParts;

                labelParts.Text = parts.ToString();
                labelServicesAndLabor.Text = servicesAndLabor.ToString("c");
                labelTaxOnParts.Text = taxOnParts.ToString("c");
                labelTotalFees.Text = total.ToString("c");
                }
            catch
            {
                labelParts.Text = "error";
                labelServicesAndLabor.Text = "error";
                labelTaxOnParts.Text = "error";
                labelTotalFees.Text = "error";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkBoxInspection.Checked = false;
            chkBoxLube.Checked = false;
            chkBoxMuffler.Checked = false;
            chkBoxOil.Checked = false;
            chkBoxRadiator.Checked = false;
            chkBoxTireRotation.Checked = false;
            chkBoxTransmission.Checked = false;
            txtLabor.Text = "";
            txtParts.Text = "";
            labelParts.Text = "";
            labelServicesAndLabor.Text = "";
            labelTaxOnParts.Text = "";
            labelTotalFees.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
