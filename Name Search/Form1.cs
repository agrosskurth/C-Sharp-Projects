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

namespace Name_Search
{
    public partial class FormMain : Form
    {
        string[] boyNames = new string[200];
        string[] girlNames = new string[200];

        public FormMain()
        {
            InitializeComponent();
            int indexBoy = 0;
            int indexGirl = 0;

            StreamReader inputFileBoy = File.OpenText("BoyNames.txt");
            StreamReader inputFileGirl = File.OpenText("GirlNames.txt");

            while (indexBoy < boyNames.Length && !inputFileBoy.EndOfStream)
            {
                boyNames[indexBoy] = inputFileBoy.ReadLine();
                indexBoy++;
            }
            while (indexGirl < girlNames.Length && !inputFileGirl.EndOfStream)
            {
                girlNames[indexGirl] = inputFileGirl.ReadLine();
                indexGirl++;
            }
            inputFileGirl.Close();
            inputFileBoy.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var checkBoy = boyNames.Contains(txtBoy.Text);
            var checkGirl = girlNames.Contains(txtGirl.Text);
            
            if (checkBoy == true && checkGirl == true)
            {
                labelOutputBoy.Text = "That name was popular!";
                labelOutputGirl.Text = "That name was popular!";
            }
            else if (checkBoy == true)
            {
                labelOutputBoy.Text = "That name was popular!";
                labelOutputGirl.Text = "That name was not popular!";
            }
            else if (checkGirl == true)
            {
                labelOutputBoy.Text = "That name was not popular!";
                labelOutputGirl.Text = "That name was popular!";
            }
            else
            {
                labelOutputBoy.Text = "That name was not popular!";
                labelOutputGirl.Text = "That name was not popular!";
            }

            checkBoy = false;
            checkGirl = false;
        }
    }
}
