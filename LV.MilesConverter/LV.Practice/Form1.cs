using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = double.Parse(txtMiles.Text);//declaring and setting the value of num1
                double num2 = 1.61; //setting the value of num2
                double answer = num1 * num2; //multiplying
                txtKm.Text = answer.ToString(); // storing the value in the answer(km) variable
                txtMiles.Focus();

            }
            catch
            {
                MessageBox.Show("Please, enter numbers only.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKm.Text = "";
            txtMiles.Text = "";
            txtMiles.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
