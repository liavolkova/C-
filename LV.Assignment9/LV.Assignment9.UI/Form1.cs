using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.Assignment9.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstReps.Items.Clear();
            double days = 0;
            double salary = 0.01;
            double total=0;
            double final = 0.01;

            if (double.TryParse(txtDays.Text, out days) && days > 0)
            {
                total = salary;
                
                for (int i = 1; i <= days; i++)
                {
                    lstReps.Items.Add(i + ". " + total.ToString("C") + " " + final.ToString("C"));
                    total *=2;
                    final += total;
                }
            }

            else
            {
                MessageBox.Show("Enter the whole numbers only.");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lstReps.Items.Clear();
            txtDays.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
