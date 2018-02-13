using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            tempAge = int.Parse(txtAge.Text);
            Pet p1 = new Pet(txtName.Text, txtType.Text,tempAge);
        }
    }
}

internal class Pet
{
    private string petName;
    private string type;
    private int age;
    private int tempAge;
    public Pet()
    {
        petName = "";
        type = "";
        age = 0;
    }
    public Pet(string _name, string _type, int _age)
    {
        petName = _name;
        type = _type;
        age = _age;
    }
    public string PetName
    {
        get { return petName; }
        set { petName = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
