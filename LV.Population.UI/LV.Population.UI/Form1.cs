using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.Population.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            if (city == "")
            {
                MessageBox.Show("Please, enter a city.");
                txtCity.Focus();
                return;
            }

            if (state == "")
            {
                MessageBox.Show("Please, enter a state.");
                txtState.Focus();
                return;
            }

            //valid state and city

            int start = 0;

            if (!int.TryParse(txtStart.Text, out start) || start <= 0)
            {
                MessageBox.Show("Please, enter a positive number");
                txtStart.Focus();
                return;
            }

            int end = 0;

            if (!int.TryParse(txtEnd.Text, out end) || end <= 0)
            {
                MessageBox.Show("Please, enter a positive number");
                txtEnd.Focus();
                return;
            }

            // valid start and end populations

            string cityState = " for: " + city + ", " + state + ".";

            //beware integer division!!
            decimal change = Math.Abs(start - end) / (decimal)start;
            if (start == end)
            {
                MessageBox.Show("No population change " + cityState);
                return;
            }

            if (start > end)
            {
                MessageBox.Show("Population decrease" + cityState);
                txtDecrease.Text = change.ToString("p");
                return;
            }

            if (end > start)
            {
                MessageBox.Show("Population increase" + cityState);
                txtIncrease.Text = change.ToString("p");
                return;
            }
        }

        private void TxtAllInput_TextChanged(object sender, EventArgs e)
        {
            txtDecrease.Text = "";
            txtIncrease.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCity.Text = "";
            txtState.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
            txtIncrease.Text = "";
            txtDecrease.Text = "";
            txtCity.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
