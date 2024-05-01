using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.SalesCommission.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal Sales = 0;
            bool worked = decimal.TryParse(txtSales.Text, out Sales);
            string LastName = txtLastName.Text;
            string FirstName = txtFirstName.Text;
            decimal Commission;
            Commission = Sales * 0.1M;

            
            if (worked)
            {
                if (Sales < 0)
                {
                    MessageBox.Show("Sales cannot be less than 0");
                    txtSales.SelectAll();
                    txtSales.Focus();
                    txtCommission.Text = "";
                }
                else
                {
                    txtCommission.Text = Commission.ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Please, enter a number");
                txtSales.SelectAll();
                txtSales.Focus();
            }
                           
            

            if (FirstName == string.Empty && LastName == string.Empty)
            {
                lblCommission.Text = "Commission";
            }

            if (FirstName != string.Empty && LastName == string.Empty)
            {
                lblCommission.Text="Commission for " + FirstName;
            }

            if (FirstName == string.Empty && LastName != string.Empty)
            {
                lblCommission.Text="Commission for " + LastName;
            }
            
            if (FirstName != string.Empty && LastName != string.Empty)
            {
                lblCommission.Text="Commission for " + FirstName + " " + LastName;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtSales.Text = "";
            lblCommission.Text = "";
            txtCommission.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtCommission.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtCommission.Text = "";
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            txtCommission.Text = "";
        }
    }
}
