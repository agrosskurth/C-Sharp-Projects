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

namespace Class_Registration
{
    public partial class Form1 : Form
    {
        string[] classes = new string[100];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFile();
            loadListBox();
        }

        private void readFile()
        {
            StreamReader inputFile;

            inputFile = File.OpenText("Classes.txt");

            while (!((inputFile.EndOfStream) && (count < 100)))
            {
                classes[count] = inputFile.ReadLine();
                count++;
            }
            inputFile.Close();
        }

        private void loadListBox()
        {
            
            listBoxClasses.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                listBoxClasses.Items.Add(classes[i]);
            }
        }

        private void addClass()
        {
            string course = txtCRN.Text + "," + txtDepartment.Text + "," + txtClass.Text + "," + txtCourseName.Text + "," + txtCampus.Text + "," + txtRoom.Text + "," + txtDays.Text + "," + txtTime.Text + "," + txtInstructor.Text;
            txtCRN.Text = "";
            txtDepartment.Text= "";
            txtClass.Text = "";
            txtCourseName.Text = "";
            txtCampus.Text = "";
            txtRoom.Text = "";
            txtDays.Text = "";
            txtTime.Text = "";
            txtInstructor.Text = "";

            if (count <= 100)
            {
                classes[count] = course;
                count++;
            }
            else
            {
                MessageBox.Show("There is no more room for any more courses. Please delete one!");
            }
            loadListBox();

        }
        
        private void deleteLine()
        {
            int selected = listBoxClasses.SelectedIndex;

            for (int i = selected +1; i < count; i++)
            {
                classes[i - 1] = classes[i];
            }
            count--;
            loadListBox();
        }

        private void changeLine()
        {
            int selected = listBoxClasses.SelectedIndex;

            classes[selected] = txtCRN.Text + "," + txtDepartment.Text + "," + txtClass.Text + "," + txtCourseName.Text + "," + txtCampus.Text + "," + txtRoom.Text + "," + txtDays.Text + "," + txtTime.Text + "," + txtInstructor.Text;
            txtCRN.Text = "";
            txtDepartment.Text = "";
            txtClass.Text = "";
            txtCourseName.Text = "";
            txtCampus.Text = "";
            txtRoom.Text = "";
            txtDays.Text = "";
            txtTime.Text = "";
            txtInstructor.Text = "";

            loadListBox();
        }


        private void closeFile()
        {
            StreamWriter outputFile;

            outputFile = File.CreateText("Classes.txt");

            for (int i = 0; i < count; i++)
            {
                outputFile.WriteLine(classes[i]);
            }
            outputFile.Close();
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addClass();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteLine();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            changeLine();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeFile();
        }
    }
}
