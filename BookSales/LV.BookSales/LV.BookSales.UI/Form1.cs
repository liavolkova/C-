using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV.BookSales.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSalesAmount.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double Sale = double.Parse(txtSalesAmount.Text);
                const double DISCOUNT = 0.25; // constant value
                double DiscountAmount = Sale * DISCOUNT; //calculate the discount amount
                double Total = Sale - DiscountAmount; // calculate price after the discount
                txtDiscountAmount.Text = DiscountAmount.ToString("c"); 
                txtTotal.Text = Total.ToString("c");
                txtSalesAmount.Focus();
            }
            catch
            {
                MessageBox.Show("Use numbers only.");
                txtSalesAmount.Focus();
                txtSalesAmount.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = "";
            txtSalesAmount.Text = "";
            txtTotal.Text = "";
            txtSalesAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSalesAmount_TextChanged(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = "";
            txtTotal.Text = "";
        }

    }
}
