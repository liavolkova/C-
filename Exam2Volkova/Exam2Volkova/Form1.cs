using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Volkova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int books = int.Parse(txtBooks.Text);
                int days = int.Parse(txtDays.Text);
                const double FINE = 0.05; // constant value of the fine
                double total = FINE * books * days; //calculate total fine
                txtFine.Text = total.ToString("c");
                txtBooks.Focus();
            }
            catch
            {
                MessageBox.Show("Use whole numbers only.");
                txtBooks.Focus();
                txtBooks.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBooks.Text = "";
            txtDays.Text = "";
            txtFine.Text = "";
            txtBooks.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBooks_TextChanged(object sender, EventArgs e)
        {
            txtFine.Text = "";
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            txtFine.Text = "";
        }
    }
}
