using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachRosterSelection
{
    public partial class Form1 : Form
    {
        //Initialize variables
        int teamRoster = 0;
        int answer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmEntry_Click(object sender, EventArgs e)
        {
            //Create a loop to fill in listbox
            if (teamRoster < 12)
            {
                listPlayerRoster.Items.Add(txtPlayerInput.Text);
                txtPlayerInput.Text = "";
                ActiveControl = txtPlayerInput;
                teamRoster = teamRoster + 1;
            }

            else
            {
                MessageBox.Show("Your roster is already full, please submit it.");
                txtPlayerInput.Text = "";
                ActiveControl = txtPlayerInput;
            }
            
        }

        private void listPlayerRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check if radio button "yes" is selected
            if (radioBtnYes.Checked)
            {
                //Check if teamRoster is over or under 10, and do equation
                int tempRoster = teamRoster;
                if (tempRoster >= 10)
                {
                    tempRoster = 10;
                    answer = tempRoster * 15;
                }
                
                if (teamRoster < 10)
                {
                    answer = teamRoster * 15;
                }
                MessageBox.Show("Your team of " + teamRoster + " players will cost you $" + answer + ".");
            }
            //If "no" selected, create message box
            if (radioBtnNo.Checked)
            {
                MessageBox.Show("Please make any adjustments by clicking on the 'Clear Roster' button and starting over.");
            }
        }
        //create "clear" button to reset form
        private void btnClearListbox_Click(object sender, EventArgs e)
        {
            txtPlayerInput.Text = "";
            listPlayerRoster.Items.Clear();
            teamRoster = 0;
            radioBtnNo.Checked = false;
            radioBtnYes.Checked = false;
        }
    }
}
