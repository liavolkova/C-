using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.Variables.UI
{
    public partial class Form1 : Form
    {
        //class variables (fields)
        string firstName = "";
        int age = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            firstName = txtName.Text;
            txtName.Text = "";
            // lblWelcome.Text = firstName;

            age = int.Parse(txtAge.Text);
            txtAge.Text = "";
            //age = age + 1;
            //lblWelcome.Text = "Welcome " + firstName + "(" + age.ToString()+")";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome" + firstName + "(" + age.ToString() + ")";
        }
    }
}
