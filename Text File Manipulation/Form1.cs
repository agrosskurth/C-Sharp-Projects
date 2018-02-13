using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_File_Manipulation
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text;
                string userTitle = txtTitle.Text;
                string userMessage = txtMessage.Text;
                StreamWriter outputFile;

                outputFile = File.AppendText("Message.txt");

                outputFile.WriteLine(userName);

                outputFile.WriteLine(userTitle);

                outputFile.WriteLine(userMessage);
                outputFile.WriteLine("");

                outputFile.Close();

                txtName.Text = ("");
                txtTitle.Text = ("");
                txtMessage.Text = ("");
                ActiveControl = txtName;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Message.txt");

                outputFile.Close();
                ActiveControl = txtName;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        { 
            try
            {
                using (StreamReader sr = new StreamReader("Message.txt"))
                {
                    string read;

                    while ((read = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(read);
                    }

                }
                ActiveControl = txtName;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
